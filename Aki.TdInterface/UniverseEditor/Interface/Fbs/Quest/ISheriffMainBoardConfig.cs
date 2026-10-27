using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004115 RID: 16661
	public struct ISheriffMainBoardConfig : IFlatbufferObject
	{
		// Token: 0x17007603 RID: 30211
		// (get) Token: 0x0601865A RID: 99930 RVA: 0x00384FBA File Offset: 0x003831BA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601865B RID: 99931 RVA: 0x00384FC7 File Offset: 0x003831C7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601865C RID: 99932 RVA: 0x00384FD0 File Offset: 0x003831D0
		public static ISheriffMainBoardConfig GetRootAsISheriffMainBoardConfig(ByteBuffer _bb)
		{
			return ISheriffMainBoardConfig.GetRootAsISheriffMainBoardConfig(_bb, default(ISheriffMainBoardConfig));
		}

		// Token: 0x0601865D RID: 99933 RVA: 0x00384FEC File Offset: 0x003831EC
		public static ISheriffMainBoardConfig GetRootAsISheriffMainBoardConfig(ByteBuffer _bb, ISheriffMainBoardConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601865E RID: 99934 RVA: 0x00385009 File Offset: 0x00383209
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601865F RID: 99935 RVA: 0x00385018 File Offset: 0x00383218
		public ISheriffMainBoardConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06018660 RID: 99936 RVA: 0x00385028 File Offset: 0x00383228
		public static void StartISheriffMainBoardConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x06018661 RID: 99937 RVA: 0x00385031 File Offset: 0x00383231
		public static Offset<ISheriffMainBoardConfig> EndISheriffMainBoardConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISheriffMainBoardConfig>(builder.EndTable());
		}

		// Token: 0x06018662 RID: 99938 RVA: 0x00385040 File Offset: 0x00383240
		public ISheriffMainBoardConfigT UnPack()
		{
			ISheriffMainBoardConfigT sheriffMainBoardConfigT = new ISheriffMainBoardConfigT();
			this.UnPackTo(sheriffMainBoardConfigT);
			return sheriffMainBoardConfigT;
		}

		// Token: 0x06018663 RID: 99939 RVA: 0x0038505B File Offset: 0x0038325B
		public void UnPackTo(ISheriffMainBoardConfigT _o)
		{
		}

		// Token: 0x06018664 RID: 99940 RVA: 0x00385060 File Offset: 0x00383260
		public static Offset<ISheriffMainBoardConfig> Pack(FlatBufferBuilder builder, ISheriffMainBoardConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISheriffMainBoardConfig>);
			}
			ISheriffMainBoardConfig.StartISheriffMainBoardConfig(builder);
			return ISheriffMainBoardConfig.EndISheriffMainBoardConfig(builder);
		}

		// Token: 0x0400BD03 RID: 48387
		private Table __p;
	}
}
