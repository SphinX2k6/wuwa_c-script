using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042D7 RID: 17111
	public struct IInformationBoardConfig : IFlatbufferObject
	{
		// Token: 0x17007534 RID: 30004
		// (get) Token: 0x0601804F RID: 98383 RVA: 0x0036DB9C File Offset: 0x0036BD9C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018050 RID: 98384 RVA: 0x0036DBA9 File Offset: 0x0036BDA9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018051 RID: 98385 RVA: 0x0036DBB0 File Offset: 0x0036BDB0
		public static IInformationBoardConfig GetRootAsIInformationBoardConfig(ByteBuffer _bb)
		{
			return IInformationBoardConfig.GetRootAsIInformationBoardConfig(_bb, default(IInformationBoardConfig));
		}

		// Token: 0x06018052 RID: 98386 RVA: 0x0036DBCC File Offset: 0x0036BDCC
		public static IInformationBoardConfig GetRootAsIInformationBoardConfig(ByteBuffer _bb, IInformationBoardConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018053 RID: 98387 RVA: 0x0036DBE9 File Offset: 0x0036BDE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018054 RID: 98388 RVA: 0x0036DBF8 File Offset: 0x0036BDF8
		public IInformationBoardConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007535 RID: 30005
		// (get) Token: 0x06018055 RID: 98389 RVA: 0x0036DC08 File Offset: 0x0036BE08
		public IDangoAbyssInformationBoard? InformationBoard
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IDangoAbyssInformationBoard?(default(IDangoAbyssInformationBoard).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06018056 RID: 98390 RVA: 0x0036DC65 File Offset: 0x0036BE65
		public static Offset<IInformationBoardConfig> CreateIInformationBoardConfig(FlatBufferBuilder builder, Offset<IDangoAbyssInformationBoard> InformationBoardOffset = default(Offset<IDangoAbyssInformationBoard>))
		{
			builder.StartTable(1);
			IInformationBoardConfig.AddInformationBoard(builder, InformationBoardOffset);
			return IInformationBoardConfig.EndIInformationBoardConfig(builder);
		}

		// Token: 0x06018057 RID: 98391 RVA: 0x0036DC7B File Offset: 0x0036BE7B
		public static void StartIInformationBoardConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06018058 RID: 98392 RVA: 0x0036DC84 File Offset: 0x0036BE84
		public static void AddInformationBoard(FlatBufferBuilder builder, Offset<IDangoAbyssInformationBoard> informationBoardOffset)
		{
			builder.AddOffset(0, informationBoardOffset.Value, 0);
		}

		// Token: 0x06018059 RID: 98393 RVA: 0x0036DC94 File Offset: 0x0036BE94
		public static Offset<IInformationBoardConfig> EndIInformationBoardConfig(FlatBufferBuilder builder)
		{
			return new Offset<IInformationBoardConfig>(builder.EndTable());
		}

		// Token: 0x0601805A RID: 98394 RVA: 0x0036DCA4 File Offset: 0x0036BEA4
		public IInformationBoardConfigT UnPack()
		{
			IInformationBoardConfigT informationBoardConfigT = new IInformationBoardConfigT();
			this.UnPackTo(informationBoardConfigT);
			return informationBoardConfigT;
		}

		// Token: 0x0601805B RID: 98395 RVA: 0x0036DCC0 File Offset: 0x0036BEC0
		public void UnPackTo(IInformationBoardConfigT _o)
		{
			_o.InformationBoard = ((this.InformationBoard != null) ? this.InformationBoard.Value.UnPack() : null);
		}

		// Token: 0x0601805C RID: 98396 RVA: 0x0036DCFC File Offset: 0x0036BEFC
		public static Offset<IInformationBoardConfig> Pack(FlatBufferBuilder builder, IInformationBoardConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInformationBoardConfig>);
			}
			Offset<IDangoAbyssInformationBoard> informationBoardOffset = (_o.InformationBoard == null) ? default(Offset<IDangoAbyssInformationBoard>) : IDangoAbyssInformationBoard.Pack(builder, _o.InformationBoard);
			return IInformationBoardConfig.CreateIInformationBoardConfig(builder, informationBoardOffset);
		}

		// Token: 0x0400C240 RID: 49728
		private Table __p;
	}
}
