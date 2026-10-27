using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E4D RID: 20045
	public struct IActivateSpecifiedPieceConfig : IFlatbufferObject
	{
		// Token: 0x17008F73 RID: 36723
		// (get) Token: 0x0601F75A RID: 128858 RVA: 0x00461FC8 File Offset: 0x004601C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F75B RID: 128859 RVA: 0x00461FD5 File Offset: 0x004601D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F75C RID: 128860 RVA: 0x00461FDC File Offset: 0x004601DC
		public static IActivateSpecifiedPieceConfig GetRootAsIActivateSpecifiedPieceConfig(ByteBuffer _bb)
		{
			return IActivateSpecifiedPieceConfig.GetRootAsIActivateSpecifiedPieceConfig(_bb, default(IActivateSpecifiedPieceConfig));
		}

		// Token: 0x0601F75D RID: 128861 RVA: 0x00461FF8 File Offset: 0x004601F8
		public static IActivateSpecifiedPieceConfig GetRootAsIActivateSpecifiedPieceConfig(ByteBuffer _bb, IActivateSpecifiedPieceConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F75E RID: 128862 RVA: 0x00462015 File Offset: 0x00460215
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F75F RID: 128863 RVA: 0x00462024 File Offset: 0x00460224
		public IActivateSpecifiedPieceConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008F74 RID: 36724
		// (get) Token: 0x0601F760 RID: 128864 RVA: 0x00462034 File Offset: 0x00460234
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

		// Token: 0x17008F75 RID: 36725
		// (get) Token: 0x0601F761 RID: 128865 RVA: 0x00462094 File Offset: 0x00460294
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

		// Token: 0x0601F762 RID: 128866 RVA: 0x004620CB File Offset: 0x004602CB
		public Span<byte> GetSelfStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601F763 RID: 128867 RVA: 0x004620DA File Offset: 0x004602DA
		public byte[] GetSelfStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601F764 RID: 128868 RVA: 0x004620E8 File Offset: 0x004602E8
		public static Offset<IActivateSpecifiedPieceConfig> CreateIActivateSpecifiedPieceConfig(FlatBufferBuilder builder, Offset<IJigsawConfig> JigsawOffset = default(Offset<IJigsawConfig>), StringOffset SelfStateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IActivateSpecifiedPieceConfig.AddSelfState(builder, SelfStateOffset);
			IActivateSpecifiedPieceConfig.AddJigsaw(builder, JigsawOffset);
			return IActivateSpecifiedPieceConfig.EndIActivateSpecifiedPieceConfig(builder);
		}

		// Token: 0x0601F765 RID: 128869 RVA: 0x00462105 File Offset: 0x00460305
		public static void StartIActivateSpecifiedPieceConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F766 RID: 128870 RVA: 0x0046210E File Offset: 0x0046030E
		public static void AddJigsaw(FlatBufferBuilder builder, Offset<IJigsawConfig> jigsawOffset)
		{
			builder.AddOffset(0, jigsawOffset.Value, 0);
		}

		// Token: 0x0601F767 RID: 128871 RVA: 0x0046211E File Offset: 0x0046031E
		public static void AddSelfState(FlatBufferBuilder builder, StringOffset selfStateOffset)
		{
			builder.AddOffset(1, selfStateOffset.Value, 0);
		}

		// Token: 0x0601F768 RID: 128872 RVA: 0x0046212E File Offset: 0x0046032E
		public static Offset<IActivateSpecifiedPieceConfig> EndIActivateSpecifiedPieceConfig(FlatBufferBuilder builder)
		{
			return new Offset<IActivateSpecifiedPieceConfig>(builder.EndTable());
		}

		// Token: 0x0601F769 RID: 128873 RVA: 0x0046213C File Offset: 0x0046033C
		public IActivateSpecifiedPieceConfigT UnPack()
		{
			IActivateSpecifiedPieceConfigT activateSpecifiedPieceConfigT = new IActivateSpecifiedPieceConfigT();
			this.UnPackTo(activateSpecifiedPieceConfigT);
			return activateSpecifiedPieceConfigT;
		}

		// Token: 0x0601F76A RID: 128874 RVA: 0x00462158 File Offset: 0x00460358
		public void UnPackTo(IActivateSpecifiedPieceConfigT _o)
		{
			_o.Jigsaw = ((this.Jigsaw != null) ? this.Jigsaw.Value.UnPack() : null);
			_o.SelfState = this.SelfState;
		}

		// Token: 0x0601F76B RID: 128875 RVA: 0x004621A0 File Offset: 0x004603A0
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

		// Token: 0x0400DBE8 RID: 56296
		private Table __p;
	}
}
