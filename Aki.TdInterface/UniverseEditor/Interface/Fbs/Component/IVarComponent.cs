using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200611B RID: 24859
	public struct IVarComponent : IFlatbufferObject
	{
		// Token: 0x1700B912 RID: 47378
		// (get) Token: 0x0602A250 RID: 172624 RVA: 0x005C06EA File Offset: 0x005BE8EA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A251 RID: 172625 RVA: 0x005C06F7 File Offset: 0x005BE8F7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A252 RID: 172626 RVA: 0x005C0700 File Offset: 0x005BE900
		public static IVarComponent GetRootAsIVarComponent(ByteBuffer _bb)
		{
			return IVarComponent.GetRootAsIVarComponent(_bb, default(IVarComponent));
		}

		// Token: 0x0602A253 RID: 172627 RVA: 0x005C071C File Offset: 0x005BE91C
		public static IVarComponent GetRootAsIVarComponent(ByteBuffer _bb, IVarComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A254 RID: 172628 RVA: 0x005C0739 File Offset: 0x005BE939
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A255 RID: 172629 RVA: 0x005C0748 File Offset: 0x005BE948
		public IVarComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B913 RID: 47379
		// (get) Token: 0x0602A256 RID: 172630 RVA: 0x005C0758 File Offset: 0x005BE958
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602A257 RID: 172631 RVA: 0x005C0798 File Offset: 0x005BE998
		public IVarDefine? Vars(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IVarDefine?(default(IVarDefine).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B914 RID: 47380
		// (get) Token: 0x0602A258 RID: 172632 RVA: 0x005C07F8 File Offset: 0x005BE9F8
		public int VarsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700B915 RID: 47381
		// (get) Token: 0x0602A259 RID: 172633 RVA: 0x005C0824 File Offset: 0x005BEA24
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A25A RID: 172634 RVA: 0x005C0860 File Offset: 0x005BEA60
		public static Offset<IVarComponent> CreateIVarComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset VarsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IVarComponent.AddVars(builder, VarsOffset);
			IVarComponent.AddNullMask(builder, NullMask);
			IVarComponent.AddDisabled(builder, Disabled);
			return IVarComponent.EndIVarComponent(builder);
		}

		// Token: 0x0602A25B RID: 172635 RVA: 0x005C0884 File Offset: 0x005BEA84
		public static void StartIVarComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602A25C RID: 172636 RVA: 0x005C088D File Offset: 0x005BEA8D
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602A25D RID: 172637 RVA: 0x005C0898 File Offset: 0x005BEA98
		public static void AddVars(FlatBufferBuilder builder, VectorOffset varsOffset)
		{
			builder.AddOffset(1, varsOffset.Value, 0);
		}

		// Token: 0x0602A25E RID: 172638 RVA: 0x005C08A8 File Offset: 0x005BEAA8
		public static VectorOffset CreateVarsVector(FlatBufferBuilder builder, Offset<IVarDefine>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A25F RID: 172639 RVA: 0x005C08E8 File Offset: 0x005BEAE8
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, Offset<IVarDefine>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IVarDefine>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A260 RID: 172640 RVA: 0x005C0902 File Offset: 0x005BEB02
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IVarDefine>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IVarDefine>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A261 RID: 172641 RVA: 0x005C0920 File Offset: 0x005BEB20
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IVarDefine>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A262 RID: 172642 RVA: 0x005C0939 File Offset: 0x005BEB39
		public static void StartVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602A263 RID: 172643 RVA: 0x005C0944 File Offset: 0x005BEB44
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602A264 RID: 172644 RVA: 0x005C094F File Offset: 0x005BEB4F
		public static Offset<IVarComponent> EndIVarComponent(FlatBufferBuilder builder)
		{
			return new Offset<IVarComponent>(builder.EndTable());
		}

		// Token: 0x0602A265 RID: 172645 RVA: 0x005C095C File Offset: 0x005BEB5C
		public IVarComponentT UnPack()
		{
			IVarComponentT varComponentT = new IVarComponentT();
			this.UnPackTo(varComponentT);
			return varComponentT;
		}

		// Token: 0x0602A266 RID: 172646 RVA: 0x005C0978 File Offset: 0x005BEB78
		public void UnPackTo(IVarComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Vars = new List<IVarDefineT>();
			for (int i = 0; i < this.VarsLength; i++)
			{
				_o.Vars.Add((this.Vars(i) != null) ? this.Vars(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602A267 RID: 172647 RVA: 0x005C09F0 File Offset: 0x005BEBF0
		public static Offset<IVarComponent> Pack(FlatBufferBuilder builder, IVarComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVarComponent>);
			}
			VectorOffset varsOffset = default(VectorOffset);
			if (_o.Vars != null)
			{
				Offset<IVarDefine>[] array = new Offset<IVarDefine>[_o.Vars.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IVarDefine.Pack(builder, _o.Vars[i]);
				}
				varsOffset = IVarComponent.CreateVarsVector(builder, array);
			}
			return IVarComponent.CreateIVarComponent(builder, _o.Disabled, varsOffset, _o.NullMask);
		}

		// Token: 0x0400FF0E RID: 65294
		private Table __p;
	}
}
