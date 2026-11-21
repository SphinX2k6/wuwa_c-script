using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.SymbolStore;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	// Token: 0x020007C4 RID: 1988
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class ILGenerator
	{
		// Token: 0x06007FB1 RID: 32689 RVA: 0x0012DA0F File Offset: 0x0012BC0F
		protected static Label CreateLabel(int id)
		{
			return new Label(id);
		}

		// Token: 0x06007FB2 RID: 32690
		public abstract void Emit(OpCode opcode);

		// Token: 0x06007FB3 RID: 32691
		public abstract void Emit(OpCode opcode, byte arg);

		// Token: 0x06007FB4 RID: 32692
		public abstract void Emit(OpCode opcode, short arg);

		// Token: 0x06007FB5 RID: 32693
		public abstract void Emit(OpCode opcode, long arg);

		// Token: 0x06007FB6 RID: 32694
		public abstract void Emit(OpCode opcode, float arg);

		// Token: 0x06007FB7 RID: 32695
		public abstract void Emit(OpCode opcode, double arg);

		// Token: 0x06007FB8 RID: 32696
		public abstract void Emit(OpCode opcode, int arg);

		// Token: 0x06007FB9 RID: 32697
		public abstract void Emit(OpCode opcode, MethodInfo meth);

		// Token: 0x06007FBA RID: 32698
		[NullableContext(2)]
		public abstract void EmitCalli(OpCode opcode, CallingConventions callingConvention, Type returnType, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] parameterTypes, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] optionalParameterTypes);

		// Token: 0x06007FBB RID: 32699
		[NullableContext(2)]
		public abstract void EmitCalli(OpCode opcode, CallingConvention unmanagedCallConv, Type returnType, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] parameterTypes);

		// Token: 0x06007FBC RID: 32700
		public abstract void EmitCall(OpCode opcode, MethodInfo methodInfo, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] optionalParameterTypes);

		// Token: 0x06007FBD RID: 32701
		public abstract void Emit(OpCode opcode, SignatureHelper signature);

		// Token: 0x06007FBE RID: 32702
		public abstract void Emit(OpCode opcode, ConstructorInfo con);

		// Token: 0x06007FBF RID: 32703
		public abstract void Emit(OpCode opcode, Type cls);

		// Token: 0x06007FC0 RID: 32704
		public abstract void Emit(OpCode opcode, Label label);

		// Token: 0x06007FC1 RID: 32705
		public abstract void Emit(OpCode opcode, Label[] labels);

		// Token: 0x06007FC2 RID: 32706
		public abstract void Emit(OpCode opcode, FieldInfo field);

		// Token: 0x06007FC3 RID: 32707
		public abstract void Emit(OpCode opcode, string str);

		// Token: 0x06007FC4 RID: 32708
		public abstract void Emit(OpCode opcode, LocalBuilder local);

		// Token: 0x06007FC5 RID: 32709
		public abstract Label BeginExceptionBlock();

		// Token: 0x06007FC6 RID: 32710
		public abstract void EndExceptionBlock();

		// Token: 0x06007FC7 RID: 32711
		public abstract void BeginExceptFilterBlock();

		// Token: 0x06007FC8 RID: 32712
		[NullableContext(2)]
		public abstract void BeginCatchBlock(Type exceptionType);

		// Token: 0x06007FC9 RID: 32713
		public abstract void BeginFaultBlock();

		// Token: 0x06007FCA RID: 32714
		public abstract void BeginFinallyBlock();

		// Token: 0x06007FCB RID: 32715
		public abstract Label DefineLabel();

		// Token: 0x06007FCC RID: 32716
		public abstract void MarkLabel(Label loc);

		// Token: 0x06007FCD RID: 32717 RVA: 0x0012DA18 File Offset: 0x0012BC18
		public virtual void ThrowException([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)] Type excType)
		{
			ArgumentNullException.ThrowIfNull(excType, "excType");
			if (!excType.IsSubclassOf(typeof(Exception)) && excType != typeof(Exception))
			{
				throw new ArgumentException(SR.Argument_NotExceptionType, "excType");
			}
			ConstructorInfo constructor = excType.GetConstructor(Type.EmptyTypes);
			if (constructor == null)
			{
				throw new ArgumentException(SR.Arg_NoDefCTorWithoutTypeName, "excType");
			}
			ConstructorInfo con = constructor;
			this.Emit(OpCodes.Newobj, con);
			this.Emit(OpCodes.Throw);
		}

		// Token: 0x06007FCE RID: 32718 RVA: 0x0012DA9C File Offset: 0x0012BC9C
		public virtual void EmitWriteLine(string value)
		{
			this.Emit(OpCodes.Ldstr, value);
			MethodInfo method = Type.GetType("System.Console, System.Console", true).GetMethod("WriteLine", ILGenerator.s_parameterTypes);
			this.Emit(OpCodes.Call, method);
		}

		// Token: 0x06007FCF RID: 32719 RVA: 0x0012DADC File Offset: 0x0012BCDC
		public virtual void EmitWriteLine(LocalBuilder localBuilder)
		{
			this.Emit(OpCodes.Call, Type.GetType("System.Console, System.Console", true).GetMethod("get_Out"));
			this.Emit(OpCodes.Ldloc, localBuilder);
			Type localType = localBuilder.LocalType;
			bool flag = localType is TypeBuilder || localType is EnumBuilder;
			if (flag)
			{
				throw new ArgumentException(SR.NotSupported_OutputStreamUsingTypeBuilder);
			}
			MethodInfo method = typeof(TextWriter).GetMethod("WriteLine", new Type[]
			{
				localType
			});
			if (method == null)
			{
				throw new ArgumentException(SR.Argument_EmitWriteLineType, "localBuilder");
			}
			MethodInfo meth = method;
			this.Emit(OpCodes.Callvirt, meth);
		}

		// Token: 0x06007FD0 RID: 32720 RVA: 0x0012DB80 File Offset: 0x0012BD80
		public virtual void EmitWriteLine(FieldInfo fld)
		{
			ArgumentNullException.ThrowIfNull(fld, "fld");
			this.Emit(OpCodes.Call, Type.GetType("System.Console, System.Console", true).GetMethod("get_Out"));
			if ((fld.Attributes & FieldAttributes.Static) != FieldAttributes.PrivateScope)
			{
				this.Emit(OpCodes.Ldsfld, fld);
			}
			else
			{
				this.Emit(OpCodes.Ldarg_0);
				this.Emit(OpCodes.Ldfld, fld);
			}
			Type fieldType = fld.FieldType;
			bool flag = fieldType is TypeBuilder || fieldType is EnumBuilder;
			if (flag)
			{
				throw new NotSupportedException(SR.NotSupported_OutputStreamUsingTypeBuilder);
			}
			MethodInfo method = typeof(TextWriter).GetMethod("WriteLine", new Type[]
			{
				fieldType
			});
			if (method == null)
			{
				throw new ArgumentException(SR.Argument_EmitWriteLineType, "fld");
			}
			MethodInfo meth = method;
			this.Emit(OpCodes.Callvirt, meth);
		}

		// Token: 0x06007FD1 RID: 32721 RVA: 0x0012DC52 File Offset: 0x0012BE52
		public virtual LocalBuilder DeclareLocal(Type localType)
		{
			return this.DeclareLocal(localType, false);
		}

		// Token: 0x06007FD2 RID: 32722
		public abstract LocalBuilder DeclareLocal(Type localType, bool pinned);

		// Token: 0x06007FD3 RID: 32723
		public abstract void UsingNamespace(string usingNamespace);

		// Token: 0x06007FD4 RID: 32724
		public abstract void BeginScope();

		// Token: 0x06007FD5 RID: 32725
		public abstract void EndScope();

		// Token: 0x1700112D RID: 4397
		// (get) Token: 0x06007FD6 RID: 32726
		public abstract int ILOffset { get; }

		// Token: 0x06007FD7 RID: 32727 RVA: 0x0012DC5C File Offset: 0x0012BE5C
		[CLSCompliant(false)]
		public void Emit(OpCode opcode, sbyte arg)
		{
			this.Emit(opcode, (byte)arg);
		}

		// Token: 0x06007FD8 RID: 32728 RVA: 0x0012DC68 File Offset: 0x0012BE68
		public void MarkSequencePoint(ISymbolDocumentWriter document, int startLine, int startColumn, int endLine, int endColumn)
		{
			ArgumentNullException.ThrowIfNull(document, "document");
			if (startLine < 0 || startLine >= 536870912)
			{
				throw new ArgumentOutOfRangeException("startLine");
			}
			if (endLine < 0 || endLine >= 536870912 || startLine > endLine)
			{
				throw new ArgumentOutOfRangeException("endLine");
			}
			if (startColumn < 0 || startColumn >= 65536)
			{
				throw new ArgumentOutOfRangeException("startColumn");
			}
			if (endColumn < 0 || endColumn >= 65536 || (startLine == endLine && startLine != 16707566 && startColumn >= endColumn))
			{
				throw new ArgumentOutOfRangeException("endColumn");
			}
			this.MarkSequencePointCore(document, startLine, startColumn, endLine, endColumn);
		}

		// Token: 0x06007FD9 RID: 32729 RVA: 0x0012DD04 File Offset: 0x0012BF04
		protected virtual void MarkSequencePointCore(ISymbolDocumentWriter document, int startLine, int startColumn, int endLine, int endColumn)
		{
			throw new NotSupportedException(SR.NotSupported_EmitDebugInfo);
		}

		// Token: 0x040018B0 RID: 6320
		private static readonly Type[] s_parameterTypes = new Type[]
		{
			typeof(string)
		};
	}
}
