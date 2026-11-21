using System;
using System.Buffers.Binary;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	// Token: 0x020007AC RID: 1964
	[StructLayout(LayoutKind.Sequential)]
	internal sealed class RuntimeILGenerator : ILGenerator
	{
		// Token: 0x06007D87 RID: 32135 RVA: 0x0012796A File Offset: 0x00125B6A
		[DynamicDependency("token_fixups")]
		internal RuntimeILGenerator(Module m, ITokenGenerator token_gen, int size)
		{
			if (size < 0)
			{
				size = 128;
			}
			this.code = new byte[size];
			this.module = m;
			this.token_gen = token_gen;
		}

		// Token: 0x170010BE RID: 4286
		// (get) Token: 0x06007D88 RID: 32136 RVA: 0x00127997 File Offset: 0x00125B97
		[MemberNotNullWhen(true, "open_blocks")]
		private bool InExceptionBlock
		{
			[MemberNotNullWhen(true, "open_blocks")]
			get
			{
				return this.open_blocks != null && this.open_blocks.Count > 0;
			}
		}

		// Token: 0x06007D89 RID: 32137 RVA: 0x001279B4 File Offset: 0x00125BB4
		private void make_room(int nbytes)
		{
			if (this.code_len + nbytes < this.code.Length)
			{
				return;
			}
			byte[] destinationArray = new byte[(this.code_len + nbytes) * 2 + 128];
			Array.Copy(this.code, 0, destinationArray, 0, this.code.Length);
			this.code = destinationArray;
		}

		// Token: 0x06007D8A RID: 32138 RVA: 0x00127A07 File Offset: 0x00125C07
		private void emit_int(int val)
		{
			BinaryPrimitives.WriteInt32LittleEndian(this.code.AsSpan(this.code_len), val);
			this.code_len += 4;
		}

		// Token: 0x06007D8B RID: 32139 RVA: 0x00127A30 File Offset: 0x00125C30
		private void ll_emit(OpCode opcode)
		{
			int num;
			if (opcode.Size == 2)
			{
				byte[] array = this.code;
				num = this.code_len;
				this.code_len = num + 1;
				array[num] = (byte)(opcode.Value >> 8);
			}
			byte[] array2 = this.code;
			num = this.code_len;
			this.code_len = num + 1;
			array2[num] = (byte)(opcode.Value & 255);
			switch (opcode.StackBehaviourPush)
			{
			case StackBehaviour.Push1:
			case StackBehaviour.Pushi:
			case StackBehaviour.Pushi8:
			case StackBehaviour.Pushr4:
			case StackBehaviour.Pushr8:
			case StackBehaviour.Pushref:
			case StackBehaviour.Varpush:
				this.cur_stack++;
				break;
			case StackBehaviour.Push1_push1:
				this.cur_stack += 2;
				break;
			}
			if (this.max_stack < this.cur_stack)
			{
				this.max_stack = this.cur_stack;
			}
			switch (opcode.StackBehaviourPop)
			{
			case StackBehaviour.Pop1:
			case StackBehaviour.Popi:
			case StackBehaviour.Popref:
				this.cur_stack--;
				return;
			case StackBehaviour.Pop1_pop1:
			case StackBehaviour.Popi_pop1:
			case StackBehaviour.Popi_popi:
			case StackBehaviour.Popi_popi8:
			case StackBehaviour.Popi_popr4:
			case StackBehaviour.Popi_popr8:
			case StackBehaviour.Popref_pop1:
			case StackBehaviour.Popref_popi:
				this.cur_stack -= 2;
				return;
			case StackBehaviour.Popi_popi_popi:
			case StackBehaviour.Popref_popi_popi:
			case StackBehaviour.Popref_popi_popi8:
			case StackBehaviour.Popref_popi_popr4:
			case StackBehaviour.Popref_popi_popr8:
			case StackBehaviour.Popref_popi_popref:
				this.cur_stack -= 3;
				break;
			case StackBehaviour.Push0:
			case StackBehaviour.Push1:
			case StackBehaviour.Push1_push1:
			case StackBehaviour.Pushi:
			case StackBehaviour.Pushi8:
			case StackBehaviour.Pushr4:
			case StackBehaviour.Pushr8:
			case StackBehaviour.Pushref:
			case StackBehaviour.Varpop:
				break;
			default:
				return;
			}
		}

		// Token: 0x06007D8C RID: 32140 RVA: 0x00127BA3 File Offset: 0x00125DA3
		private static int target_len(OpCode opcode)
		{
			if (opcode.OperandType == OperandType.InlineBrTarget)
			{
				return 4;
			}
			return 1;
		}

		// Token: 0x06007D8D RID: 32141 RVA: 0x00127BB4 File Offset: 0x00125DB4
		private void InternalEndClause()
		{
			switch (this.ex_handlers[this.cur_block].LastClauseType())
			{
			case -1:
			case 0:
			case 1:
				this.Emit(OpCodes.Leave, this.ex_handlers[this.cur_block].end);
				return;
			case 2:
			case 4:
				this.Emit(OpCodes.Endfinally);
				break;
			case 3:
				break;
			default:
				return;
			}
		}

		// Token: 0x06007D8E RID: 32142 RVA: 0x00127C28 File Offset: 0x00125E28
		public override void BeginCatchBlock(Type exceptionType)
		{
			if (!this.InExceptionBlock)
			{
				throw new NotSupportedException(SR.Argument_NotInExceptionBlock);
			}
			if (exceptionType != null && exceptionType.IsUserType)
			{
				throw new NotSupportedException(SR.PlatformNotSupported_UserDefinedSubclassesOfType);
			}
			if (this.ex_handlers[this.cur_block].LastClauseType() == -1)
			{
				if (exceptionType != null)
				{
					throw new ArgumentException(SR.Argument_ShouldNotSpecifyExceptionType);
				}
				this.Emit(OpCodes.Endfilter);
				this.ex_handlers[this.cur_block].PatchFilterClause(this.code_len);
			}
			else
			{
				this.InternalEndClause();
				this.ex_handlers[this.cur_block].AddCatch(exceptionType, this.code_len);
			}
			this.cur_stack = 1;
			if (this.max_stack < this.cur_stack)
			{
				this.max_stack = this.cur_stack;
			}
		}

		// Token: 0x06007D8F RID: 32143 RVA: 0x00127CFE File Offset: 0x00125EFE
		public override void BeginExceptFilterBlock()
		{
			if (!this.InExceptionBlock)
			{
				throw new NotSupportedException(SR.Argument_NotInExceptionBlock);
			}
			this.InternalEndClause();
			this.ex_handlers[this.cur_block].AddFilter(this.code_len);
		}

		// Token: 0x06007D90 RID: 32144 RVA: 0x00127D38 File Offset: 0x00125F38
		public override Label BeginExceptionBlock()
		{
			Int32Stack int32Stack;
			if ((int32Stack = this.open_blocks) == null)
			{
				int32Stack = (this.open_blocks = new Int32Stack(2));
			}
			if (this.ex_handlers != null)
			{
				this.cur_block = this.ex_handlers.Length;
				ILExceptionInfo[] destinationArray = new ILExceptionInfo[this.cur_block + 1];
				Array.Copy(this.ex_handlers, destinationArray, this.cur_block);
				this.ex_handlers = destinationArray;
			}
			else
			{
				this.ex_handlers = new ILExceptionInfo[1];
				this.cur_block = 0;
			}
			int32Stack.Push(this.cur_block);
			this.ex_handlers[this.cur_block].start = this.code_len;
			return this.ex_handlers[this.cur_block].end = this.DefineLabel();
		}

		// Token: 0x06007D91 RID: 32145 RVA: 0x00127DF8 File Offset: 0x00125FF8
		public override void BeginFaultBlock()
		{
			if (!this.InExceptionBlock)
			{
				throw new NotSupportedException(SR.Argument_NotInExceptionBlock);
			}
			if (this.ex_handlers[this.cur_block].LastClauseType() == -1)
			{
				this.Emit(OpCodes.Leave, this.ex_handlers[this.cur_block].end);
				this.ex_handlers[this.cur_block].PatchFilterClause(this.code_len);
			}
			this.InternalEndClause();
			this.ex_handlers[this.cur_block].AddFault(this.code_len);
		}

		// Token: 0x06007D92 RID: 32146 RVA: 0x00127E90 File Offset: 0x00126090
		public override void BeginFinallyBlock()
		{
			if (!this.InExceptionBlock)
			{
				throw new NotSupportedException(SR.Argument_NotInExceptionBlock);
			}
			this.InternalEndClause();
			if (this.ex_handlers[this.cur_block].LastClauseType() == -1)
			{
				this.Emit(OpCodes.Leave, this.ex_handlers[this.cur_block].end);
				this.ex_handlers[this.cur_block].PatchFilterClause(this.code_len);
			}
			this.ex_handlers[this.cur_block].AddFinally(this.code_len);
		}

		// Token: 0x06007D93 RID: 32147 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		public override void BeginScope()
		{
		}

		// Token: 0x06007D94 RID: 32148 RVA: 0x00127F28 File Offset: 0x00126128
		public override LocalBuilder DeclareLocal(Type localType, bool pinned)
		{
			ArgumentNullException.ThrowIfNull(localType, "localType");
			if (localType.IsUserType)
			{
				throw new NotSupportedException(SR.PlatformNotSupported_UserDefinedSubclassesOfType);
			}
			RuntimeLocalBuilder runtimeLocalBuilder = new RuntimeLocalBuilder(localType, this);
			runtimeLocalBuilder.is_pinned = pinned;
			if (this.locals != null)
			{
				RuntimeLocalBuilder[] array = new RuntimeLocalBuilder[this.locals.Length + 1];
				Array.Copy(this.locals, array, this.locals.Length);
				array[this.locals.Length] = runtimeLocalBuilder;
				this.locals = array;
			}
			else
			{
				this.locals = new RuntimeLocalBuilder[1];
				this.locals[0] = runtimeLocalBuilder;
			}
			runtimeLocalBuilder.position = (ushort)(this.locals.Length - 1);
			return runtimeLocalBuilder;
		}

		// Token: 0x06007D95 RID: 32149 RVA: 0x00127FCC File Offset: 0x001261CC
		public override Label DefineLabel()
		{
			if (this.labels == null)
			{
				this.labels = new RuntimeILGenerator.LabelData[4];
			}
			else if (this.num_labels >= this.labels.Length)
			{
				RuntimeILGenerator.LabelData[] destinationArray = new RuntimeILGenerator.LabelData[this.labels.Length * 2];
				Array.Copy(this.labels, destinationArray, this.labels.Length);
				this.labels = destinationArray;
			}
			this.labels[this.num_labels] = new RuntimeILGenerator.LabelData(-1, 0);
			int num = this.num_labels;
			this.num_labels = num + 1;
			return new Label(num);
		}

		// Token: 0x06007D96 RID: 32150 RVA: 0x00128058 File Offset: 0x00126258
		public override void Emit(OpCode opcode)
		{
			this.make_room(2);
			this.ll_emit(opcode);
		}

		// Token: 0x06007D97 RID: 32151 RVA: 0x00128068 File Offset: 0x00126268
		public override void Emit(OpCode opcode, byte arg)
		{
			this.make_room(3);
			this.ll_emit(opcode);
			byte[] array = this.code;
			int num = this.code_len;
			this.code_len = num + 1;
			array[num] = arg;
		}

		// Token: 0x06007D98 RID: 32152 RVA: 0x0012809C File Offset: 0x0012629C
		public override void Emit(OpCode opcode, ConstructorInfo con)
		{
			int token = this.token_gen.GetToken(con, true);
			this.make_room(6);
			this.ll_emit(opcode);
			this.emit_int(token);
			if (opcode.StackBehaviourPop == StackBehaviour.Varpop)
			{
				this.cur_stack -= con.GetParametersCount();
			}
		}

		// Token: 0x06007D99 RID: 32153 RVA: 0x001280EA File Offset: 0x001262EA
		public override void Emit(OpCode opcode, double arg)
		{
			this.make_room(10);
			this.ll_emit(opcode);
			BinaryPrimitives.WriteDoubleLittleEndian(this.code.AsSpan(this.code_len), arg);
			this.code_len += 8;
		}

		// Token: 0x06007D9A RID: 32154 RVA: 0x00128120 File Offset: 0x00126320
		public override void Emit(OpCode opcode, FieldInfo field)
		{
			int token = this.token_gen.GetToken(field, true);
			this.make_room(6);
			this.ll_emit(opcode);
			this.emit_int(token);
		}

		// Token: 0x06007D9B RID: 32155 RVA: 0x00128150 File Offset: 0x00126350
		public override void Emit(OpCode opcode, short arg)
		{
			this.make_room(4);
			this.ll_emit(opcode);
			BinaryPrimitives.WriteInt16LittleEndian(this.code.AsSpan(this.code_len), arg);
			this.code_len += 2;
		}

		// Token: 0x06007D9C RID: 32156 RVA: 0x00128185 File Offset: 0x00126385
		public override void Emit(OpCode opcode, int arg)
		{
			this.make_room(6);
			this.ll_emit(opcode);
			this.emit_int(arg);
		}

		// Token: 0x06007D9D RID: 32157 RVA: 0x0012819C File Offset: 0x0012639C
		public override void Emit(OpCode opcode, long arg)
		{
			this.make_room(10);
			this.ll_emit(opcode);
			BinaryPrimitives.WriteInt64LittleEndian(this.code.AsSpan(this.code_len), arg);
			this.code_len += 8;
		}

		// Token: 0x06007D9E RID: 32158 RVA: 0x001281D4 File Offset: 0x001263D4
		public override void Emit(OpCode opcode, Label label)
		{
			int num = RuntimeILGenerator.target_len(opcode);
			this.make_room(6);
			this.ll_emit(opcode);
			if (this.cur_stack > this.labels[label.m_label].maxStack)
			{
				this.labels[label.m_label].maxStack = this.cur_stack;
			}
			if (this.fixups == null)
			{
				this.fixups = new RuntimeILGenerator.LabelFixup[4];
			}
			else if (this.num_fixups >= this.fixups.Length)
			{
				RuntimeILGenerator.LabelFixup[] destinationArray = new RuntimeILGenerator.LabelFixup[this.fixups.Length * 2];
				Array.Copy(this.fixups, destinationArray, this.fixups.Length);
				this.fixups = destinationArray;
			}
			this.fixups[this.num_fixups].offset = num;
			this.fixups[this.num_fixups].pos = this.code_len;
			this.fixups[this.num_fixups].label_idx = label.m_label;
			this.num_fixups++;
			this.code_len += num;
		}

		// Token: 0x06007D9F RID: 32159 RVA: 0x001282EC File Offset: 0x001264EC
		public override void Emit(OpCode opcode, Label[] labels)
		{
			ArgumentNullException.ThrowIfNull(labels, "labels");
			int num = labels.Length;
			this.make_room(6 + num * 4);
			this.ll_emit(opcode);
			for (int i = 0; i < num; i++)
			{
				if (this.cur_stack > this.labels[labels[i].m_label].maxStack)
				{
					this.labels[labels[i].m_label].maxStack = this.cur_stack;
				}
			}
			this.emit_int(num);
			if (this.fixups == null)
			{
				this.fixups = new RuntimeILGenerator.LabelFixup[4 + num];
			}
			else if (this.num_fixups + num >= this.fixups.Length)
			{
				RuntimeILGenerator.LabelFixup[] destinationArray = new RuntimeILGenerator.LabelFixup[num + this.fixups.Length * 2];
				Array.Copy(this.fixups, destinationArray, this.fixups.Length);
				this.fixups = destinationArray;
			}
			int j = 0;
			int num2 = num * 4;
			while (j < num)
			{
				this.fixups[this.num_fixups].offset = num2;
				this.fixups[this.num_fixups].pos = this.code_len;
				this.fixups[this.num_fixups].label_idx = labels[j].m_label;
				this.num_fixups++;
				this.code_len += 4;
				j++;
				num2 -= 4;
			}
		}

		// Token: 0x06007DA0 RID: 32160 RVA: 0x00128454 File Offset: 0x00126654
		public override void Emit(OpCode opcode, LocalBuilder local)
		{
			ArgumentNullException.ThrowIfNull(local, "local");
			RuntimeLocalBuilder runtimeLocalBuilder = local as RuntimeLocalBuilder;
			if (runtimeLocalBuilder == null || runtimeLocalBuilder.ilgen != this)
			{
				throw new ArgumentException(SR.Argument_UnmatchedMethodForLocal, "local");
			}
			uint position = (uint)runtimeLocalBuilder.position;
			if ((opcode == OpCodes.Ldloca_S || opcode == OpCodes.Ldloc_S || opcode == OpCodes.Stloc_S) && position > 255U)
			{
				throw new InvalidOperationException(SR.InvalidOperation_BadInstructionOrIndexOutOfBound);
			}
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			this.make_room(6);
			if (opcode.StackBehaviourPop == StackBehaviour.Pop1)
			{
				this.cur_stack--;
				flag2 = true;
			}
			else if (opcode.StackBehaviourPush == StackBehaviour.Push1 || opcode.StackBehaviourPush == StackBehaviour.Pushi)
			{
				this.cur_stack++;
				flag3 = true;
				if (this.cur_stack > this.max_stack)
				{
					this.max_stack = this.cur_stack;
				}
				flag = (opcode.StackBehaviourPush == StackBehaviour.Pushi);
			}
			if (flag)
			{
				int num;
				if (position < 256U)
				{
					byte[] array = this.code;
					num = this.code_len;
					this.code_len = num + 1;
					array[num] = 18;
					byte[] array2 = this.code;
					num = this.code_len;
					this.code_len = num + 1;
					array2[num] = (byte)position;
					return;
				}
				byte[] array3 = this.code;
				num = this.code_len;
				this.code_len = num + 1;
				array3[num] = 254;
				byte[] array4 = this.code;
				num = this.code_len;
				this.code_len = num + 1;
				array4[num] = 13;
				byte[] array5 = this.code;
				num = this.code_len;
				this.code_len = num + 1;
				array5[num] = (byte)(position & 255U);
				byte[] array6 = this.code;
				num = this.code_len;
				this.code_len = num + 1;
				array6[num] = (byte)(position >> 8 & 255U);
				return;
			}
			else if (flag2)
			{
				int num;
				if (position < 4U)
				{
					byte[] array7 = this.code;
					num = this.code_len;
					this.code_len = num + 1;
					array7[num] = (byte)(10U + position);
					return;
				}
				if (position < 256U)
				{
					byte[] array8 = this.code;
					num = this.code_len;
					this.code_len = num + 1;
					array8[num] = 19;
					byte[] array9 = this.code;
					num = this.code_len;
					this.code_len = num + 1;
					array9[num] = (byte)position;
					return;
				}
				byte[] array10 = this.code;
				num = this.code_len;
				this.code_len = num + 1;
				array10[num] = 254;
				byte[] array11 = this.code;
				num = this.code_len;
				this.code_len = num + 1;
				array11[num] = 14;
				byte[] array12 = this.code;
				num = this.code_len;
				this.code_len = num + 1;
				array12[num] = (byte)(position & 255U);
				byte[] array13 = this.code;
				num = this.code_len;
				this.code_len = num + 1;
				array13[num] = (byte)(position >> 8 & 255U);
				return;
			}
			else
			{
				if (!flag3)
				{
					this.ll_emit(opcode);
					return;
				}
				int num;
				if (position < 4U)
				{
					byte[] array14 = this.code;
					num = this.code_len;
					this.code_len = num + 1;
					array14[num] = (byte)(6U + position);
					return;
				}
				if (position < 256U)
				{
					byte[] array15 = this.code;
					num = this.code_len;
					this.code_len = num + 1;
					array15[num] = 17;
					byte[] array16 = this.code;
					num = this.code_len;
					this.code_len = num + 1;
					array16[num] = (byte)position;
					return;
				}
				byte[] array17 = this.code;
				num = this.code_len;
				this.code_len = num + 1;
				array17[num] = 254;
				byte[] array18 = this.code;
				num = this.code_len;
				this.code_len = num + 1;
				array18[num] = 12;
				byte[] array19 = this.code;
				num = this.code_len;
				this.code_len = num + 1;
				array19[num] = (byte)(position & 255U);
				byte[] array20 = this.code;
				num = this.code_len;
				this.code_len = num + 1;
				array20[num] = (byte)(position >> 8 & 255U);
				return;
			}
		}

		// Token: 0x06007DA1 RID: 32161 RVA: 0x00128808 File Offset: 0x00126A08
		public override void Emit(OpCode opcode, MethodInfo meth)
		{
			ArgumentNullException.ThrowIfNull(meth, "meth");
			if (meth is DynamicMethod && (opcode == OpCodes.Ldftn || opcode == OpCodes.Ldvirtftn || opcode == OpCodes.Ldtoken))
			{
				throw new ArgumentException(SR.Argument_InvalidOpCodeOnDynamicMethod);
			}
			int token = this.token_gen.GetToken(meth, true);
			this.make_room(6);
			this.ll_emit(opcode);
			this.emit_int(token);
			if (meth.ReturnType != typeof(void))
			{
				this.cur_stack++;
			}
			if (opcode.StackBehaviourPop == StackBehaviour.Varpop)
			{
				this.cur_stack -= meth.GetParametersCount();
			}
		}

		// Token: 0x06007DA2 RID: 32162 RVA: 0x001288C0 File Offset: 0x00126AC0
		private void Emit(OpCode opcode, MethodInfo method, int token)
		{
			this.make_room(6);
			this.ll_emit(opcode);
			this.emit_int(token);
			if (method.ReturnType != typeof(void))
			{
				this.cur_stack++;
			}
			if (opcode.StackBehaviourPop == StackBehaviour.Varpop)
			{
				this.cur_stack -= method.GetParametersCount();
			}
		}

		// Token: 0x06007DA3 RID: 32163 RVA: 0x00128928 File Offset: 0x00126B28
		public override void Emit(OpCode opcode, SignatureHelper signature)
		{
			int token = this.token_gen.GetToken(signature);
			this.make_room(6);
			this.ll_emit(opcode);
			this.emit_int(token);
		}

		// Token: 0x06007DA4 RID: 32164 RVA: 0x00128957 File Offset: 0x00126B57
		public override void Emit(OpCode opcode, float arg)
		{
			this.make_room(6);
			this.ll_emit(opcode);
			BinaryPrimitives.WriteSingleLittleEndian(this.code.AsSpan(this.code_len), arg);
			this.code_len += 4;
		}

		// Token: 0x06007DA5 RID: 32165 RVA: 0x0012898C File Offset: 0x00126B8C
		public override void Emit(OpCode opcode, string str)
		{
			int token = this.token_gen.GetToken(str);
			this.make_room(6);
			this.ll_emit(opcode);
			this.emit_int(token);
		}

		// Token: 0x06007DA6 RID: 32166 RVA: 0x001289BC File Offset: 0x00126BBC
		public override void Emit(OpCode opcode, Type cls)
		{
			this.make_room(6);
			this.ll_emit(opcode);
			int token = this.token_gen.GetToken(cls, opcode != OpCodes.Ldtoken);
			this.emit_int(token);
		}

		// Token: 0x06007DA7 RID: 32167 RVA: 0x001289F8 File Offset: 0x00126BF8
		public override void EmitCall(OpCode opcode, MethodInfo methodInfo, Type[] optionalParameterTypes)
		{
			ArgumentNullException.ThrowIfNull(methodInfo, "methodInfo");
			short value = opcode.Value;
			if (value != OpCodes.Call.Value && value != OpCodes.Callvirt.Value)
			{
				throw new NotSupportedException(SR.Argument_NotMethodCallOpcode);
			}
			if ((methodInfo.CallingConvention & CallingConventions.VarArgs) == (CallingConventions)0)
			{
				optionalParameterTypes = null;
			}
			if (optionalParameterTypes == null)
			{
				this.Emit(opcode, methodInfo);
				return;
			}
			if ((methodInfo.CallingConvention & CallingConventions.VarArgs) == (CallingConventions)0)
			{
				throw new InvalidOperationException(SR.InvalidOperation_NotAVarArgCallingConvention);
			}
			int token = this.token_gen.GetToken(methodInfo, optionalParameterTypes);
			this.Emit(opcode, methodInfo, token);
		}

		// Token: 0x06007DA8 RID: 32168 RVA: 0x00128A84 File Offset: 0x00126C84
		public override void EmitCalli(OpCode opcode, CallingConvention unmanagedCallConv, Type returnType, Type[] parameterTypes)
		{
			SignatureHelper methodSigHelper = SignatureHelper.GetMethodSigHelper(this.module as ModuleBuilder, (CallingConventions)0, unmanagedCallConv, returnType, parameterTypes);
			this.Emit(opcode, methodSigHelper);
		}

		// Token: 0x06007DA9 RID: 32169 RVA: 0x00128AB0 File Offset: 0x00126CB0
		public override void EmitCalli(OpCode opcode, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, Type[] optionalParameterTypes)
		{
			if (optionalParameterTypes != null)
			{
				throw new NotImplementedException();
			}
			SignatureHelper methodSigHelper = SignatureHelper.GetMethodSigHelper(this.module as ModuleBuilder, callingConvention, (CallingConvention)0, returnType, parameterTypes);
			this.Emit(opcode, methodSigHelper);
		}

		// Token: 0x06007DAA RID: 32170 RVA: 0x00128AE8 File Offset: 0x00126CE8
		public override void EndExceptionBlock()
		{
			if (!this.InExceptionBlock)
			{
				throw new NotSupportedException(SR.Argument_NotInExceptionBlock);
			}
			if (this.ex_handlers[this.cur_block].LastClauseType() == -1)
			{
				throw new InvalidOperationException(SR.Argument_BadExceptionCodeGen);
			}
			this.InternalEndClause();
			this.MarkLabel(this.ex_handlers[this.cur_block].end);
			this.ex_handlers[this.cur_block].End(this.code_len);
			this.open_blocks.Pop();
			if (this.open_blocks.Count > 0)
			{
				this.cur_block = this.open_blocks.Peek();
			}
		}

		// Token: 0x06007DAB RID: 32171 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		public override void EndScope()
		{
		}

		// Token: 0x06007DAC RID: 32172 RVA: 0x00128B98 File Offset: 0x00126D98
		public override void MarkLabel(Label loc)
		{
			if (loc.m_label < 0 || loc.m_label >= this.num_labels)
			{
				throw new ArgumentException(SR.Argument_InvalidLabel);
			}
			if (this.labels[loc.m_label].addr >= 0)
			{
				throw new ArgumentException(SR.Argument_RedefinedLabel);
			}
			this.labels[loc.m_label].addr = this.code_len;
			if (this.labels[loc.m_label].maxStack > this.cur_stack)
			{
				this.cur_stack = this.labels[loc.m_label].maxStack;
			}
		}

		// Token: 0x06007DAD RID: 32173 RVA: 0x0000FD41 File Offset: 0x0000DF41
		public override void UsingNamespace(string usingNamespace)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06007DAE RID: 32174 RVA: 0x00128C44 File Offset: 0x00126E44
		internal void label_fixup(MethodBase mb)
		{
			for (int i = 0; i < this.num_fixups; i++)
			{
				if (this.labels[this.fixups[i].label_idx].addr < 0)
				{
					throw new ArgumentException(SR.Format(SR.Argument_LabelUnmarked, this.fixups[i].label_idx + 1, mb.Name));
				}
				int num = this.labels[this.fixups[i].label_idx].addr - (this.fixups[i].pos + this.fixups[i].offset);
				if (this.fixups[i].offset == 1)
				{
					this.code[this.fixups[i].pos] = (byte)((sbyte)num);
				}
				else
				{
					int num2 = this.code_len;
					this.code_len = this.fixups[i].pos;
					this.emit_int(num);
					this.code_len = num2;
				}
			}
		}

		// Token: 0x06007DAF RID: 32175 RVA: 0x00128D5D File Offset: 0x00126F5D
		internal void SetCode(byte[] code, int max_stack)
		{
			this.code = ((code != null) ? ((byte[])code.Clone()) : Array.Empty<byte>());
			this.code_len = this.code.Length;
			this.max_stack = max_stack;
			this.cur_stack = 0;
		}

		// Token: 0x06007DB0 RID: 32176 RVA: 0x00128D98 File Offset: 0x00126F98
		internal unsafe void SetCode(byte* code, int code_size, int max_stack)
		{
			this.code = new ReadOnlySpan<byte>((void*)code, code_size).ToArray();
			this.code_len = code_size;
			this.max_stack = max_stack;
			this.cur_stack = 0;
		}

		// Token: 0x170010BF RID: 4287
		// (get) Token: 0x06007DB1 RID: 32177 RVA: 0x00128DCF File Offset: 0x00126FCF
		internal ITokenGenerator TokenGenerator
		{
			get
			{
				return this.token_gen;
			}
		}

		// Token: 0x170010C0 RID: 4288
		// (get) Token: 0x06007DB2 RID: 32178 RVA: 0x00128DD7 File Offset: 0x00126FD7
		public override int ILOffset
		{
			get
			{
				return this.code_len;
			}
		}

		// Token: 0x040017F7 RID: 6135
		private byte[] code;

		// Token: 0x040017F8 RID: 6136
		private int code_len;

		// Token: 0x040017F9 RID: 6137
		private int max_stack;

		// Token: 0x040017FA RID: 6138
		private int cur_stack;

		// Token: 0x040017FB RID: 6139
		private RuntimeLocalBuilder[] locals;

		// Token: 0x040017FC RID: 6140
		private ILExceptionInfo[] ex_handlers;

		// Token: 0x040017FD RID: 6141
		private int num_token_fixups;

		// Token: 0x040017FE RID: 6142
		private object token_fixups;

		// Token: 0x040017FF RID: 6143
		private RuntimeILGenerator.LabelData[] labels;

		// Token: 0x04001800 RID: 6144
		private int num_labels;

		// Token: 0x04001801 RID: 6145
		private RuntimeILGenerator.LabelFixup[] fixups;

		// Token: 0x04001802 RID: 6146
		private int num_fixups;

		// Token: 0x04001803 RID: 6147
		internal Module module;

		// Token: 0x04001804 RID: 6148
		private int cur_block;

		// Token: 0x04001805 RID: 6149
		private Int32Stack open_blocks;

		// Token: 0x04001806 RID: 6150
		private ITokenGenerator token_gen;

		// Token: 0x020007AD RID: 1965
		private struct LabelFixup
		{
			// Token: 0x04001807 RID: 6151
			public int offset;

			// Token: 0x04001808 RID: 6152
			public int pos;

			// Token: 0x04001809 RID: 6153
			public int label_idx;
		}

		// Token: 0x020007AE RID: 1966
		private struct LabelData
		{
			// Token: 0x06007DB3 RID: 32179 RVA: 0x00128DDF File Offset: 0x00126FDF
			public LabelData(int addr, int maxStack)
			{
				this.addr = addr;
				this.maxStack = maxStack;
			}

			// Token: 0x0400180A RID: 6154
			public int addr;

			// Token: 0x0400180B RID: 6155
			public int maxStack;
		}
	}
}
