using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200410F RID: 16655
	public struct ISheriffAnomalyProgressBoardConfig : IFlatbufferObject
	{
		// Token: 0x170075FF RID: 30207
		// (get) Token: 0x0601863B RID: 99899 RVA: 0x00384D59 File Offset: 0x00382F59
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601863C RID: 99900 RVA: 0x00384D66 File Offset: 0x00382F66
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601863D RID: 99901 RVA: 0x00384D70 File Offset: 0x00382F70
		public static ISheriffAnomalyProgressBoardConfig GetRootAsISheriffAnomalyProgressBoardConfig(ByteBuffer _bb)
		{
			return ISheriffAnomalyProgressBoardConfig.GetRootAsISheriffAnomalyProgressBoardConfig(_bb, default(ISheriffAnomalyProgressBoardConfig));
		}

		// Token: 0x0601863E RID: 99902 RVA: 0x00384D8C File Offset: 0x00382F8C
		public static ISheriffAnomalyProgressBoardConfig GetRootAsISheriffAnomalyProgressBoardConfig(ByteBuffer _bb, ISheriffAnomalyProgressBoardConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601863F RID: 99903 RVA: 0x00384DA9 File Offset: 0x00382FA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018640 RID: 99904 RVA: 0x00384DB8 File Offset: 0x00382FB8
		public ISheriffAnomalyProgressBoardConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007600 RID: 30208
		// (get) Token: 0x06018641 RID: 99905 RVA: 0x00384DC8 File Offset: 0x00382FC8
		public int AnomalyId
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

		// Token: 0x06018642 RID: 99906 RVA: 0x00384E04 File Offset: 0x00383004
		public static Offset<ISheriffAnomalyProgressBoardConfig> CreateISheriffAnomalyProgressBoardConfig(FlatBufferBuilder builder, int AnomalyId = 0)
		{
			builder.StartTable(1);
			ISheriffAnomalyProgressBoardConfig.AddAnomalyId(builder, AnomalyId);
			return ISheriffAnomalyProgressBoardConfig.EndISheriffAnomalyProgressBoardConfig(builder);
		}

		// Token: 0x06018643 RID: 99907 RVA: 0x00384E1A File Offset: 0x0038301A
		public static void StartISheriffAnomalyProgressBoardConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06018644 RID: 99908 RVA: 0x00384E23 File Offset: 0x00383023
		public static void AddAnomalyId(FlatBufferBuilder builder, int anomalyId)
		{
			builder.AddInt(0, anomalyId, 0);
		}

		// Token: 0x06018645 RID: 99909 RVA: 0x00384E2E File Offset: 0x0038302E
		public static Offset<ISheriffAnomalyProgressBoardConfig> EndISheriffAnomalyProgressBoardConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISheriffAnomalyProgressBoardConfig>(builder.EndTable());
		}

		// Token: 0x06018646 RID: 99910 RVA: 0x00384E3C File Offset: 0x0038303C
		public ISheriffAnomalyProgressBoardConfigT UnPack()
		{
			ISheriffAnomalyProgressBoardConfigT sheriffAnomalyProgressBoardConfigT = new ISheriffAnomalyProgressBoardConfigT();
			this.UnPackTo(sheriffAnomalyProgressBoardConfigT);
			return sheriffAnomalyProgressBoardConfigT;
		}

		// Token: 0x06018647 RID: 99911 RVA: 0x00384E57 File Offset: 0x00383057
		public void UnPackTo(ISheriffAnomalyProgressBoardConfigT _o)
		{
			_o.AnomalyId = this.AnomalyId;
		}

		// Token: 0x06018648 RID: 99912 RVA: 0x00384E68 File Offset: 0x00383068
		public static Offset<ISheriffAnomalyProgressBoardConfig> Pack(FlatBufferBuilder builder, ISheriffAnomalyProgressBoardConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISheriffAnomalyProgressBoardConfig>);
			}
			return ISheriffAnomalyProgressBoardConfig.CreateISheriffAnomalyProgressBoardConfig(builder, _o.AnomalyId);
		}

		// Token: 0x0400BD00 RID: 48384
		private Table __p;
	}
}
