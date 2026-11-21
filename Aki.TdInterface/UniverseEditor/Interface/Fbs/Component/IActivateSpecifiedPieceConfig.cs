using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200535E RID: 21342
	public struct IActivateSpecifiedPieceConfig : IFlatbufferObject
	{
		// Token: 0x170096AC RID: 38572
		// (get) Token: 0x060213A5 RID: 136101 RVA: 0x00495FE0 File Offset: 0x004941E0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060213A6 RID: 136102 RVA: 0x00495FED File Offset: 0x004941ED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060213A7 RID: 136103 RVA: 0x00495FF4 File Offset: 0x004941F4
		public static IActivateSpecifiedPieceConfig GetRootAsIActivateSpecifiedPieceConfig(ByteBuffer _bb)
		{
			return IActivateSpecifiedPieceConfig.GetRootAsIActivateSpecifiedPieceConfig(_bb, default(IActivateSpecifiedPieceConfig));
		}

		// Token: 0x060213A8 RID: 136104 RVA: 0x00496010 File Offset: 0x00494210
		public static IActivateSpecifiedPieceConfig GetRootAsIActivateSpecifiedPieceConfig(ByteBuffer _bb, IActivateSpecifiedPieceConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060213A9 RID: 136105 RVA: 0x0049602D File Offset: 0x0049422D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060213AA RID: 136106 RVA: 0x0049603C File Offset: 0x0049423C
		public IActivateSpecifiedPieceConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170096AD RID: 38573
		// (get) Token: 0x060213AB RID: 136107 RVA: 0x0049604C File Offset: 0x0049424C
		public IJigsawConfig? Jigsaw
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IJigsawConfig?(default(IJigsawConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170096AE RID: 38574
		// (get) Token: 0x060213AC RID: 136108 RVA: 0x004960AC File Offset: 0x004942AC
		public string SelfState
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

		// Token: 0x060213AD RID: 136109 RVA: 0x004960E3 File Offset: 0x004942E3
		public Span<byte> GetSelfStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060213AE RID: 136110 RVA: 0x004960F2 File Offset: 0x004942F2
		public byte[] GetSelfStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060213AF RID: 136111 RVA: 0x00496100 File Offset: 0x00494300
		public static Offset<IActivateSpecifiedPieceConfig> CreateIActivateSpecifiedPieceConfig(FlatBufferBuilder builder, Offset<IJigsawConfig> JigsawOffset = default(Offset<IJigsawConfig>), StringOffset SelfStateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IActivateSpecifiedPieceConfig.AddSelfState(builder, SelfStateOffset);
			IActivateSpecifiedPieceConfig.AddJigsaw(builder, JigsawOffset);
			return IActivateSpecifiedPieceConfig.EndIActivateSpecifiedPieceConfig(builder);
		}

		// Token: 0x060213B0 RID: 136112 RVA: 0x0049611D File Offset: 0x0049431D
		public static void StartIActivateSpecifiedPieceConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060213B1 RID: 136113 RVA: 0x00496126 File Offset: 0x00494326
		public static void AddJigsaw(FlatBufferBuilder builder, Offset<IJigsawConfig> jigsawOffset)
		{
			builder.AddOffset(0, jigsawOffset.Value, 0);
		}

		// Token: 0x060213B2 RID: 136114 RVA: 0x00496136 File Offset: 0x00494336
		public static void AddSelfState(FlatBufferBuilder builder, StringOffset selfStateOffset)
		{
			builder.AddOffset(1, selfStateOffset.Value, 0);
		}

		// Token: 0x060213B3 RID: 136115 RVA: 0x00496146 File Offset: 0x00494346
		public static Offset<IActivateSpecifiedPieceConfig> EndIActivateSpecifiedPieceConfig(FlatBufferBuilder builder)
		{
			return new Offset<IActivateSpecifiedPieceConfig>(builder.EndTable());
		}

		// Token: 0x060213B4 RID: 136116 RVA: 0x00496154 File Offset: 0x00494354
		public IActivateSpecifiedPieceConfigT UnPack()
		{
			IActivateSpecifiedPieceConfigT activateSpecifiedPieceConfigT = new IActivateSpecifiedPieceConfigT();
			this.UnPackTo(activateSpecifiedPieceConfigT);
			return activateSpecifiedPieceConfigT;
		}

		// Token: 0x060213B5 RID: 136117 RVA: 0x00496170 File Offset: 0x00494370
		public void UnPackTo(IActivateSpecifiedPieceConfigT _o)
		{
			_o.Jigsaw = ((this.Jigsaw != null) ? this.Jigsaw.Value.UnPack() : null);
			_o.SelfState = this.SelfState;
		}

		// Token: 0x060213B6 RID: 136118 RVA: 0x004961B8 File Offset: 0x004943B8
		public static Offset<IActivateSpecifiedPieceConfig> Pack(FlatBufferBuilder builder, IActivateSpecifiedPieceConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActivateSpecifiedPieceConfig>);
			}
			Offset<IJigsawConfig> jigsawOffset = (_o.Jigsaw == null) ? default(Offset<IJigsawConfig>) : IJigsawConfig.Pack(builder, _o.Jigsaw);
			StringOffset selfStateOffset = (_o.SelfState == null) ? default(StringOffset) : builder.CreateString(_o.SelfState);
			return IActivateSpecifiedPieceConfig.CreateIActivateSpecifiedPieceConfig(builder, jigsawOffset, selfStateOffset);
		}

		// Token: 0x0400E762 RID: 59234
		private Table __p;
	}
}
