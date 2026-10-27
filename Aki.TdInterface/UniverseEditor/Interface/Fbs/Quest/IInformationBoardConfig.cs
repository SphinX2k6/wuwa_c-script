using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E99 RID: 16025
	public struct IInformationBoardConfig : IFlatbufferObject
	{
		// Token: 0x17006F47 RID: 28487
		// (get) Token: 0x06016A02 RID: 92674 RVA: 0x00344C14 File Offset: 0x00342E14
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016A03 RID: 92675 RVA: 0x00344C21 File Offset: 0x00342E21
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016A04 RID: 92676 RVA: 0x00344C28 File Offset: 0x00342E28
		public static IInformationBoardConfig GetRootAsIInformationBoardConfig(ByteBuffer _bb)
		{
			return IInformationBoardConfig.GetRootAsIInformationBoardConfig(_bb, default(IInformationBoardConfig));
		}

		// Token: 0x06016A05 RID: 92677 RVA: 0x00344C44 File Offset: 0x00342E44
		public static IInformationBoardConfig GetRootAsIInformationBoardConfig(ByteBuffer _bb, IInformationBoardConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016A06 RID: 92678 RVA: 0x00344C61 File Offset: 0x00342E61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016A07 RID: 92679 RVA: 0x00344C70 File Offset: 0x00342E70
		public IInformationBoardConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006F48 RID: 28488
		// (get) Token: 0x06016A08 RID: 92680 RVA: 0x00344C80 File Offset: 0x00342E80
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

		// Token: 0x06016A09 RID: 92681 RVA: 0x00344CDD File Offset: 0x00342EDD
		public static Offset<IInformationBoardConfig> CreateIInformationBoardConfig(FlatBufferBuilder builder, Offset<IDangoAbyssInformationBoard> InformationBoardOffset = default(Offset<IDangoAbyssInformationBoard>))
		{
			builder.StartTable(1);
			IInformationBoardConfig.AddInformationBoard(builder, InformationBoardOffset);
			return IInformationBoardConfig.EndIInformationBoardConfig(builder);
		}

		// Token: 0x06016A0A RID: 92682 RVA: 0x00344CF3 File Offset: 0x00342EF3
		public static void StartIInformationBoardConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06016A0B RID: 92683 RVA: 0x00344CFC File Offset: 0x00342EFC
		public static void AddInformationBoard(FlatBufferBuilder builder, Offset<IDangoAbyssInformationBoard> informationBoardOffset)
		{
			builder.AddOffset(0, informationBoardOffset.Value, 0);
		}

		// Token: 0x06016A0C RID: 92684 RVA: 0x00344D0C File Offset: 0x00342F0C
		public static Offset<IInformationBoardConfig> EndIInformationBoardConfig(FlatBufferBuilder builder)
		{
			return new Offset<IInformationBoardConfig>(builder.EndTable());
		}

		// Token: 0x06016A0D RID: 92685 RVA: 0x00344D1C File Offset: 0x00342F1C
		public IInformationBoardConfigT UnPack()
		{
			IInformationBoardConfigT informationBoardConfigT = new IInformationBoardConfigT();
			this.UnPackTo(informationBoardConfigT);
			return informationBoardConfigT;
		}

		// Token: 0x06016A0E RID: 92686 RVA: 0x00344D38 File Offset: 0x00342F38
		public void UnPackTo(IInformationBoardConfigT _o)
		{
			_o.InformationBoard = ((this.InformationBoard != null) ? this.InformationBoard.Value.UnPack() : null);
		}

		// Token: 0x06016A0F RID: 92687 RVA: 0x00344D74 File Offset: 0x00342F74
		public static Offset<IInformationBoardConfig> Pack(FlatBufferBuilder builder, IInformationBoardConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInformationBoardConfig>);
			}
			Offset<IDangoAbyssInformationBoard> informationBoardOffset = (_o.InformationBoard == null) ? default(Offset<IDangoAbyssInformationBoard>) : IDangoAbyssInformationBoard.Pack(builder, _o.InformationBoard);
			return IInformationBoardConfig.CreateIInformationBoardConfig(builder, informationBoardOffset);
		}

		// Token: 0x0400B864 RID: 47204
		private Table __p;
	}
}
