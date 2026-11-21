using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004550 RID: 17744
	public struct ISheriffAnomalyProgressBoardConfig : IFlatbufferObject
	{
		// Token: 0x17007C05 RID: 31749
		// (get) Token: 0x06019CDE RID: 105694 RVA: 0x003AED61 File Offset: 0x003ACF61
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019CDF RID: 105695 RVA: 0x003AED6E File Offset: 0x003ACF6E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019CE0 RID: 105696 RVA: 0x003AED78 File Offset: 0x003ACF78
		public static ISheriffAnomalyProgressBoardConfig GetRootAsISheriffAnomalyProgressBoardConfig(ByteBuffer _bb)
		{
			return ISheriffAnomalyProgressBoardConfig.GetRootAsISheriffAnomalyProgressBoardConfig(_bb, default(ISheriffAnomalyProgressBoardConfig));
		}

		// Token: 0x06019CE1 RID: 105697 RVA: 0x003AED94 File Offset: 0x003ACF94
		public static ISheriffAnomalyProgressBoardConfig GetRootAsISheriffAnomalyProgressBoardConfig(ByteBuffer _bb, ISheriffAnomalyProgressBoardConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019CE2 RID: 105698 RVA: 0x003AEDB1 File Offset: 0x003ACFB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019CE3 RID: 105699 RVA: 0x003AEDC0 File Offset: 0x003ACFC0
		public ISheriffAnomalyProgressBoardConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007C06 RID: 31750
		// (get) Token: 0x06019CE4 RID: 105700 RVA: 0x003AEDD0 File Offset: 0x003ACFD0
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

		// Token: 0x06019CE5 RID: 105701 RVA: 0x003AEE0C File Offset: 0x003AD00C
		public static Offset<ISheriffAnomalyProgressBoardConfig> CreateISheriffAnomalyProgressBoardConfig(FlatBufferBuilder builder, int AnomalyId = 0)
		{
			builder.StartTable(1);
			ISheriffAnomalyProgressBoardConfig.AddAnomalyId(builder, AnomalyId);
			return ISheriffAnomalyProgressBoardConfig.EndISheriffAnomalyProgressBoardConfig(builder);
		}

		// Token: 0x06019CE6 RID: 105702 RVA: 0x003AEE22 File Offset: 0x003AD022
		public static void StartISheriffAnomalyProgressBoardConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06019CE7 RID: 105703 RVA: 0x003AEE2B File Offset: 0x003AD02B
		public static void AddAnomalyId(FlatBufferBuilder builder, int anomalyId)
		{
			builder.AddInt(0, anomalyId, 0);
		}

		// Token: 0x06019CE8 RID: 105704 RVA: 0x003AEE36 File Offset: 0x003AD036
		public static Offset<ISheriffAnomalyProgressBoardConfig> EndISheriffAnomalyProgressBoardConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISheriffAnomalyProgressBoardConfig>(builder.EndTable());
		}

		// Token: 0x06019CE9 RID: 105705 RVA: 0x003AEE44 File Offset: 0x003AD044
		public ISheriffAnomalyProgressBoardConfigT UnPack()
		{
			ISheriffAnomalyProgressBoardConfigT sheriffAnomalyProgressBoardConfigT = new ISheriffAnomalyProgressBoardConfigT();
			this.UnPackTo(sheriffAnomalyProgressBoardConfigT);
			return sheriffAnomalyProgressBoardConfigT;
		}

		// Token: 0x06019CEA RID: 105706 RVA: 0x003AEE5F File Offset: 0x003AD05F
		public void UnPackTo(ISheriffAnomalyProgressBoardConfigT _o)
		{
			_o.AnomalyId = this.AnomalyId;
		}

		// Token: 0x06019CEB RID: 105707 RVA: 0x003AEE70 File Offset: 0x003AD070
		public static Offset<ISheriffAnomalyProgressBoardConfig> Pack(FlatBufferBuilder builder, ISheriffAnomalyProgressBoardConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISheriffAnomalyProgressBoardConfig>);
			}
			return ISheriffAnomalyProgressBoardConfig.CreateISheriffAnomalyProgressBoardConfig(builder, _o.AnomalyId);
		}

		// Token: 0x0400C6E9 RID: 50921
		private Table __p;
	}
}
