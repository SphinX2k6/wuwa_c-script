using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004553 RID: 17747
	public struct ISheriffClueDetailBoardConfig : IFlatbufferObject
	{
		// Token: 0x17007C08 RID: 31752
		// (get) Token: 0x06019CF0 RID: 105712 RVA: 0x003AEED9 File Offset: 0x003AD0D9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019CF1 RID: 105713 RVA: 0x003AEEE6 File Offset: 0x003AD0E6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019CF2 RID: 105714 RVA: 0x003AEEF0 File Offset: 0x003AD0F0
		public static ISheriffClueDetailBoardConfig GetRootAsISheriffClueDetailBoardConfig(ByteBuffer _bb)
		{
			return ISheriffClueDetailBoardConfig.GetRootAsISheriffClueDetailBoardConfig(_bb, default(ISheriffClueDetailBoardConfig));
		}

		// Token: 0x06019CF3 RID: 105715 RVA: 0x003AEF0C File Offset: 0x003AD10C
		public static ISheriffClueDetailBoardConfig GetRootAsISheriffClueDetailBoardConfig(ByteBuffer _bb, ISheriffClueDetailBoardConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019CF4 RID: 105716 RVA: 0x003AEF29 File Offset: 0x003AD129
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019CF5 RID: 105717 RVA: 0x003AEF38 File Offset: 0x003AD138
		public ISheriffClueDetailBoardConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06019CF6 RID: 105718 RVA: 0x003AEF48 File Offset: 0x003AD148
		public static void StartISheriffClueDetailBoardConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x06019CF7 RID: 105719 RVA: 0x003AEF51 File Offset: 0x003AD151
		public static Offset<ISheriffClueDetailBoardConfig> EndISheriffClueDetailBoardConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISheriffClueDetailBoardConfig>(builder.EndTable());
		}

		// Token: 0x06019CF8 RID: 105720 RVA: 0x003AEF60 File Offset: 0x003AD160
		public ISheriffClueDetailBoardConfigT UnPack()
		{
			ISheriffClueDetailBoardConfigT sheriffClueDetailBoardConfigT = new ISheriffClueDetailBoardConfigT();
			this.UnPackTo(sheriffClueDetailBoardConfigT);
			return sheriffClueDetailBoardConfigT;
		}

		// Token: 0x06019CF9 RID: 105721 RVA: 0x003AEF7B File Offset: 0x003AD17B
		public void UnPackTo(ISheriffClueDetailBoardConfigT _o)
		{
		}

		// Token: 0x06019CFA RID: 105722 RVA: 0x003AEF80 File Offset: 0x003AD180
		public static Offset<ISheriffClueDetailBoardConfig> Pack(FlatBufferBuilder builder, ISheriffClueDetailBoardConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISheriffClueDetailBoardConfig>);
			}
			ISheriffClueDetailBoardConfig.StartISheriffClueDetailBoardConfig(builder);
			return ISheriffClueDetailBoardConfig.EndISheriffClueDetailBoardConfig(builder);
		}

		// Token: 0x0400C6EB RID: 50923
		private Table __p;
	}
}
