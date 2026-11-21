using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200702E RID: 28718
	public struct IInteract : IFlatbufferObject
	{
		// Token: 0x1700D248 RID: 53832
		// (get) Token: 0x06031C50 RID: 203856 RVA: 0x006BCE28 File Offset: 0x006BB028
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031C51 RID: 203857 RVA: 0x006BCE35 File Offset: 0x006BB035
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031C52 RID: 203858 RVA: 0x006BCE3C File Offset: 0x006BB03C
		public static IInteract GetRootAsIInteract(ByteBuffer _bb)
		{
			return IInteract.GetRootAsIInteract(_bb, default(IInteract));
		}

		// Token: 0x06031C53 RID: 203859 RVA: 0x006BCE58 File Offset: 0x006BB058
		public static IInteract GetRootAsIInteract(ByteBuffer _bb, IInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031C54 RID: 203860 RVA: 0x006BCE75 File Offset: 0x006BB075
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031C55 RID: 203861 RVA: 0x006BCE84 File Offset: 0x006BB084
		public IInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D249 RID: 53833
		// (get) Token: 0x06031C56 RID: 203862 RVA: 0x006BCE94 File Offset: 0x006BB094
		public int Who
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D24A RID: 53834
		// (get) Token: 0x06031C57 RID: 203863 RVA: 0x006BCED0 File Offset: 0x006BB0D0
		public string Param
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

		// Token: 0x06031C58 RID: 203864 RVA: 0x006BCF07 File Offset: 0x006BB107
		public Span<byte> GetParamBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06031C59 RID: 203865 RVA: 0x006BCF16 File Offset: 0x006BB116
		public byte[] GetParamArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06031C5A RID: 203866 RVA: 0x006BCF24 File Offset: 0x006BB124
		public static Offset<IInteract> CreateIInteract(FlatBufferBuilder builder, int Who = 0, StringOffset ParamOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IInteract.AddParam(builder, ParamOffset);
			IInteract.AddWho(builder, Who);
			return IInteract.EndIInteract(builder);
		}

		// Token: 0x06031C5B RID: 203867 RVA: 0x006BCF41 File Offset: 0x006BB141
		public static void StartIInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031C5C RID: 203868 RVA: 0x006BCF4A File Offset: 0x006BB14A
		public static void AddWho(FlatBufferBuilder builder, int who)
		{
			builder.AddInt(0, who, 0);
		}

		// Token: 0x06031C5D RID: 203869 RVA: 0x006BCF55 File Offset: 0x006BB155
		public static void AddParam(FlatBufferBuilder builder, StringOffset paramOffset)
		{
			builder.AddOffset(1, paramOffset.Value, 0);
		}

		// Token: 0x06031C5E RID: 203870 RVA: 0x006BCF65 File Offset: 0x006BB165
		public static Offset<IInteract> EndIInteract(FlatBufferBuilder builder)
		{
			return new Offset<IInteract>(builder.EndTable());
		}

		// Token: 0x06031C5F RID: 203871 RVA: 0x006BCF74 File Offset: 0x006BB174
		public IInteractT UnPack()
		{
			IInteractT interactT = new IInteractT();
			this.UnPackTo(interactT);
			return interactT;
		}

		// Token: 0x06031C60 RID: 203872 RVA: 0x006BCF8F File Offset: 0x006BB18F
		public void UnPackTo(IInteractT _o)
		{
			_o.Who = this.Who;
			_o.Param = this.Param;
		}

		// Token: 0x06031C61 RID: 203873 RVA: 0x006BCFAC File Offset: 0x006BB1AC
		public static Offset<IInteract> Pack(FlatBufferBuilder builder, IInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteract>);
			}
			StringOffset paramOffset = (_o.Param == null) ? default(StringOffset) : builder.CreateString(_o.Param);
			return IInteract.CreateIInteract(builder, _o.Who, paramOffset);
		}

		// Token: 0x04011F6E RID: 73582
		private Table __p;
	}
}
