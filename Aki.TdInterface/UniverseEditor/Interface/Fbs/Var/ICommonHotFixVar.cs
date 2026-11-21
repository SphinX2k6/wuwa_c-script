using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E68 RID: 15976
	public struct ICommonHotFixVar : IFlatbufferObject
	{
		// Token: 0x17006BDB RID: 27611
		// (get) Token: 0x0601585D RID: 88157 RVA: 0x0031A747 File Offset: 0x00318947
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601585E RID: 88158 RVA: 0x0031A754 File Offset: 0x00318954
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601585F RID: 88159 RVA: 0x0031A75C File Offset: 0x0031895C
		public static ICommonHotFixVar GetRootAsICommonHotFixVar(ByteBuffer _bb)
		{
			return ICommonHotFixVar.GetRootAsICommonHotFixVar(_bb, default(ICommonHotFixVar));
		}

		// Token: 0x06015860 RID: 88160 RVA: 0x0031A778 File Offset: 0x00318978
		public static ICommonHotFixVar GetRootAsICommonHotFixVar(ByteBuffer _bb, ICommonHotFixVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015861 RID: 88161 RVA: 0x0031A795 File Offset: 0x00318995
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015862 RID: 88162 RVA: 0x0031A7A4 File Offset: 0x003189A4
		public ICommonHotFixVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006BDC RID: 27612
		// (get) Token: 0x06015863 RID: 88163 RVA: 0x0031A7B4 File Offset: 0x003189B4
		public ESystemVarName Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESystemVarName.CommonHotFixVar;
				}
				return (ESystemVarName)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006BDD RID: 27613
		// (get) Token: 0x06015864 RID: 88164 RVA: 0x0031A7F0 File Offset: 0x003189F0
		public string VarName
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015865 RID: 88165 RVA: 0x0031A827 File Offset: 0x00318A27
		public Span<byte> GetVarNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06015866 RID: 88166 RVA: 0x0031A836 File Offset: 0x00318A36
		public byte[] GetVarNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17006BDE RID: 27614
		// (get) Token: 0x06015867 RID: 88167 RVA: 0x0031A844 File Offset: 0x00318A44
		public string VarParams
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015868 RID: 88168 RVA: 0x0031A87B File Offset: 0x00318A7B
		public Span<byte> GetVarParamsBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06015869 RID: 88169 RVA: 0x0031A88A File Offset: 0x00318A8A
		public byte[] GetVarParamsArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0601586A RID: 88170 RVA: 0x0031A898 File Offset: 0x00318A98
		public static Offset<ICommonHotFixVar> CreateICommonHotFixVar(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar, StringOffset VarNameOffset = default(StringOffset), StringOffset VarParamsOffset = default(StringOffset))
		{
			builder.StartTable(3);
			ICommonHotFixVar.AddVarParams(builder, VarParamsOffset);
			ICommonHotFixVar.AddVarName(builder, VarNameOffset);
			ICommonHotFixVar.AddType(builder, Type);
			return ICommonHotFixVar.EndICommonHotFixVar(builder);
		}

		// Token: 0x0601586B RID: 88171 RVA: 0x0031A8BC File Offset: 0x00318ABC
		public static void StartICommonHotFixVar(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601586C RID: 88172 RVA: 0x0031A8C5 File Offset: 0x00318AC5
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601586D RID: 88173 RVA: 0x0031A8D0 File Offset: 0x00318AD0
		public static void AddVarName(FlatBufferBuilder builder, StringOffset varNameOffset)
		{
			builder.AddOffset(1, varNameOffset.Value, 0);
		}

		// Token: 0x0601586E RID: 88174 RVA: 0x0031A8E0 File Offset: 0x00318AE0
		public static void AddVarParams(FlatBufferBuilder builder, StringOffset varParamsOffset)
		{
			builder.AddOffset(2, varParamsOffset.Value, 0);
		}

		// Token: 0x0601586F RID: 88175 RVA: 0x0031A8F0 File Offset: 0x00318AF0
		public static Offset<ICommonHotFixVar> EndICommonHotFixVar(FlatBufferBuilder builder)
		{
			return new Offset<ICommonHotFixVar>(builder.EndTable());
		}

		// Token: 0x06015870 RID: 88176 RVA: 0x0031A900 File Offset: 0x00318B00
		public ICommonHotFixVarT UnPack()
		{
			ICommonHotFixVarT commonHotFixVarT = new ICommonHotFixVarT();
			this.UnPackTo(commonHotFixVarT);
			return commonHotFixVarT;
		}

		// Token: 0x06015871 RID: 88177 RVA: 0x0031A91B File Offset: 0x00318B1B
		public void UnPackTo(ICommonHotFixVarT _o)
		{
			_o.Type = this.Type;
			_o.VarName = this.VarName;
			_o.VarParams = this.VarParams;
		}

		// Token: 0x06015872 RID: 88178 RVA: 0x0031A944 File Offset: 0x00318B44
		public static Offset<ICommonHotFixVar> Pack(FlatBufferBuilder builder, ICommonHotFixVarT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonHotFixVar>);
			}
			StringOffset varNameOffset = (_o.VarName == null) ? default(StringOffset) : builder.CreateString(_o.VarName);
			StringOffset varParamsOffset = (_o.VarParams == null) ? default(StringOffset) : builder.CreateString(_o.VarParams);
			return ICommonHotFixVar.CreateICommonHotFixVar(builder, _o.Type, varNameOffset, varParamsOffset);
		}

		// Token: 0x0400B82C RID: 47148
		private Table __p;
	}
}
