using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004556 RID: 17750
	public struct ISheriffMainBoardConfig : IFlatbufferObject
	{
		// Token: 0x17007C09 RID: 31753
		// (get) Token: 0x06019CFD RID: 105725 RVA: 0x003AEFC2 File Offset: 0x003AD1C2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019CFE RID: 105726 RVA: 0x003AEFCF File Offset: 0x003AD1CF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019CFF RID: 105727 RVA: 0x003AEFD8 File Offset: 0x003AD1D8
		public static ISheriffMainBoardConfig GetRootAsISheriffMainBoardConfig(ByteBuffer _bb)
		{
			return ISheriffMainBoardConfig.GetRootAsISheriffMainBoardConfig(_bb, default(ISheriffMainBoardConfig));
		}

		// Token: 0x06019D00 RID: 105728 RVA: 0x003AEFF4 File Offset: 0x003AD1F4
		public static ISheriffMainBoardConfig GetRootAsISheriffMainBoardConfig(ByteBuffer _bb, ISheriffMainBoardConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019D01 RID: 105729 RVA: 0x003AF011 File Offset: 0x003AD211
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019D02 RID: 105730 RVA: 0x003AF020 File Offset: 0x003AD220
		public ISheriffMainBoardConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06019D03 RID: 105731 RVA: 0x003AF030 File Offset: 0x003AD230
		public static void StartISheriffMainBoardConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x06019D04 RID: 105732 RVA: 0x003AF039 File Offset: 0x003AD239
		public static Offset<ISheriffMainBoardConfig> EndISheriffMainBoardConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISheriffMainBoardConfig>(builder.EndTable());
		}

		// Token: 0x06019D05 RID: 105733 RVA: 0x003AF048 File Offset: 0x003AD248
		public ISheriffMainBoardConfigT UnPack()
		{
			ISheriffMainBoardConfigT sheriffMainBoardConfigT = new ISheriffMainBoardConfigT();
			this.UnPackTo(sheriffMainBoardConfigT);
			return sheriffMainBoardConfigT;
		}

		// Token: 0x06019D06 RID: 105734 RVA: 0x003AF063 File Offset: 0x003AD263
		public void UnPackTo(ISheriffMainBoardConfigT _o)
		{
		}

		// Token: 0x06019D07 RID: 105735 RVA: 0x003AF068 File Offset: 0x003AD268
		public static Offset<ISheriffMainBoardConfig> Pack(FlatBufferBuilder builder, ISheriffMainBoardConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISheriffMainBoardConfig>);
			}
			ISheriffMainBoardConfig.StartISheriffMainBoardConfig(builder);
			return ISheriffMainBoardConfig.EndISheriffMainBoardConfig(builder);
		}

		// Token: 0x0400C6EC RID: 50924
		private Table __p;
	}
}
