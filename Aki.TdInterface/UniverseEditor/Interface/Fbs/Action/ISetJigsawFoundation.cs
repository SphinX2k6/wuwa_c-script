using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077D0 RID: 30672
	public struct ISetJigsawFoundation : IFlatbufferObject
	{
		// Token: 0x1700E0D7 RID: 57559
		// (get) Token: 0x06035E15 RID: 220693 RVA: 0x00738185 File Offset: 0x00736385
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035E16 RID: 220694 RVA: 0x00738192 File Offset: 0x00736392
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035E17 RID: 220695 RVA: 0x0073819C File Offset: 0x0073639C
		public static ISetJigsawFoundation GetRootAsISetJigsawFoundation(ByteBuffer _bb)
		{
			return ISetJigsawFoundation.GetRootAsISetJigsawFoundation(_bb, default(ISetJigsawFoundation));
		}

		// Token: 0x06035E18 RID: 220696 RVA: 0x007381B8 File Offset: 0x007363B8
		public static ISetJigsawFoundation GetRootAsISetJigsawFoundation(ByteBuffer _bb, ISetJigsawFoundation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035E19 RID: 220697 RVA: 0x007381D5 File Offset: 0x007363D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035E1A RID: 220698 RVA: 0x007381E4 File Offset: 0x007363E4
		public ISetJigsawFoundation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E0D8 RID: 57560
		// (get) Token: 0x06035E1B RID: 220699 RVA: 0x007381F4 File Offset: 0x007363F4
		public ISetPieceState? Config
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new ISetPieceState?(default(ISetPieceState).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06035E1C RID: 220700 RVA: 0x00738251 File Offset: 0x00736451
		public static Offset<ISetJigsawFoundation> CreateISetJigsawFoundation(FlatBufferBuilder builder, Offset<ISetPieceState> ConfigOffset = default(Offset<ISetPieceState>))
		{
			builder.StartTable(1);
			ISetJigsawFoundation.AddConfig(builder, ConfigOffset);
			return ISetJigsawFoundation.EndISetJigsawFoundation(builder);
		}

		// Token: 0x06035E1D RID: 220701 RVA: 0x00738267 File Offset: 0x00736467
		public static void StartISetJigsawFoundation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035E1E RID: 220702 RVA: 0x00738270 File Offset: 0x00736470
		public static void AddConfig(FlatBufferBuilder builder, Offset<ISetPieceState> configOffset)
		{
			builder.AddOffset(0, configOffset.Value, 0);
		}

		// Token: 0x06035E1F RID: 220703 RVA: 0x00738280 File Offset: 0x00736480
		public static Offset<ISetJigsawFoundation> EndISetJigsawFoundation(FlatBufferBuilder builder)
		{
			return new Offset<ISetJigsawFoundation>(builder.EndTable());
		}

		// Token: 0x06035E20 RID: 220704 RVA: 0x00738290 File Offset: 0x00736490
		public ISetJigsawFoundationT UnPack()
		{
			ISetJigsawFoundationT setJigsawFoundationT = new ISetJigsawFoundationT();
			this.UnPackTo(setJigsawFoundationT);
			return setJigsawFoundationT;
		}

		// Token: 0x06035E21 RID: 220705 RVA: 0x007382AC File Offset: 0x007364AC
		public void UnPackTo(ISetJigsawFoundationT _o)
		{
			_o.Config = ((this.Config != null) ? this.Config.Value.UnPack() : null);
		}

		// Token: 0x06035E22 RID: 220706 RVA: 0x007382E8 File Offset: 0x007364E8
		public static Offset<ISetJigsawFoundation> Pack(FlatBufferBuilder builder, ISetJigsawFoundationT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetJigsawFoundation>);
			}
			Offset<ISetPieceState> configOffset = (_o.Config == null) ? default(Offset<ISetPieceState>) : ISetPieceState.Pack(builder, _o.Config);
			return ISetJigsawFoundation.CreateISetJigsawFoundation(builder, configOffset);
		}

		// Token: 0x04012A10 RID: 76304
		private Table __p;
	}
}
