using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004112 RID: 16658
	public struct ISheriffClueDetailBoardConfig : IFlatbufferObject
	{
		// Token: 0x17007602 RID: 30210
		// (get) Token: 0x0601864D RID: 99917 RVA: 0x00384ED1 File Offset: 0x003830D1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601864E RID: 99918 RVA: 0x00384EDE File Offset: 0x003830DE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601864F RID: 99919 RVA: 0x00384EE8 File Offset: 0x003830E8
		public static ISheriffClueDetailBoardConfig GetRootAsISheriffClueDetailBoardConfig(ByteBuffer _bb)
		{
			return ISheriffClueDetailBoardConfig.GetRootAsISheriffClueDetailBoardConfig(_bb, default(ISheriffClueDetailBoardConfig));
		}

		// Token: 0x06018650 RID: 99920 RVA: 0x00384F04 File Offset: 0x00383104
		public static ISheriffClueDetailBoardConfig GetRootAsISheriffClueDetailBoardConfig(ByteBuffer _bb, ISheriffClueDetailBoardConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018651 RID: 99921 RVA: 0x00384F21 File Offset: 0x00383121
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018652 RID: 99922 RVA: 0x00384F30 File Offset: 0x00383130
		public ISheriffClueDetailBoardConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06018653 RID: 99923 RVA: 0x00384F40 File Offset: 0x00383140
		public static void StartISheriffClueDetailBoardConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x06018654 RID: 99924 RVA: 0x00384F49 File Offset: 0x00383149
		public static Offset<ISheriffClueDetailBoardConfig> EndISheriffClueDetailBoardConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISheriffClueDetailBoardConfig>(builder.EndTable());
		}

		// Token: 0x06018655 RID: 99925 RVA: 0x00384F58 File Offset: 0x00383158
		public ISheriffClueDetailBoardConfigT UnPack()
		{
			ISheriffClueDetailBoardConfigT sheriffClueDetailBoardConfigT = new ISheriffClueDetailBoardConfigT();
			this.UnPackTo(sheriffClueDetailBoardConfigT);
			return sheriffClueDetailBoardConfigT;
		}

		// Token: 0x06018656 RID: 99926 RVA: 0x00384F73 File Offset: 0x00383173
		public void UnPackTo(ISheriffClueDetailBoardConfigT _o)
		{
		}

		// Token: 0x06018657 RID: 99927 RVA: 0x00384F78 File Offset: 0x00383178
		public static Offset<ISheriffClueDetailBoardConfig> Pack(FlatBufferBuilder builder, ISheriffClueDetailBoardConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISheriffClueDetailBoardConfig>);
			}
			ISheriffClueDetailBoardConfig.StartISheriffClueDetailBoardConfig(builder);
			return ISheriffClueDetailBoardConfig.EndISheriffClueDetailBoardConfig(builder);
		}

		// Token: 0x0400BD02 RID: 48386
		private Table __p;
	}
}
