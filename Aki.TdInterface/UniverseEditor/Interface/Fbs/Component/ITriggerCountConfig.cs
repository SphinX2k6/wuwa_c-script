using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AE1 RID: 23265
	public struct ITriggerCountConfig : IFlatbufferObject
	{
		// Token: 0x1700AF6D RID: 44909
		// (get) Token: 0x06027B22 RID: 162594 RVA: 0x00575F0F File Offset: 0x0057410F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027B23 RID: 162595 RVA: 0x00575F1C File Offset: 0x0057411C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027B24 RID: 162596 RVA: 0x00575F24 File Offset: 0x00574124
		public static ITriggerCountConfig GetRootAsITriggerCountConfig(ByteBuffer _bb)
		{
			return ITriggerCountConfig.GetRootAsITriggerCountConfig(_bb, default(ITriggerCountConfig));
		}

		// Token: 0x06027B25 RID: 162597 RVA: 0x00575F40 File Offset: 0x00574140
		public static ITriggerCountConfig GetRootAsITriggerCountConfig(ByteBuffer _bb, ITriggerCountConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027B26 RID: 162598 RVA: 0x00575F5D File Offset: 0x0057415D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027B27 RID: 162599 RVA: 0x00575F6C File Offset: 0x0057416C
		public ITriggerCountConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AF6E RID: 44910
		// (get) Token: 0x06027B28 RID: 162600 RVA: 0x00575F7C File Offset: 0x0057417C
		public int TriggerCount
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

		// Token: 0x1700AF6F RID: 44911
		// (get) Token: 0x06027B29 RID: 162601 RVA: 0x00575FB8 File Offset: 0x005741B8
		public float TriggerInterval
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027B2A RID: 162602 RVA: 0x00575FF8 File Offset: 0x005741F8
		public static Offset<ITriggerCountConfig> CreateITriggerCountConfig(FlatBufferBuilder builder, int TriggerCount = 0, float TriggerInterval = 0f)
		{
			builder.StartTable(2);
			ITriggerCountConfig.AddTriggerInterval(builder, TriggerInterval);
			ITriggerCountConfig.AddTriggerCount(builder, TriggerCount);
			return ITriggerCountConfig.EndITriggerCountConfig(builder);
		}

		// Token: 0x06027B2B RID: 162603 RVA: 0x00576015 File Offset: 0x00574215
		public static void StartITriggerCountConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06027B2C RID: 162604 RVA: 0x0057601E File Offset: 0x0057421E
		public static void AddTriggerCount(FlatBufferBuilder builder, int triggerCount)
		{
			builder.AddInt(0, triggerCount, 0);
		}

		// Token: 0x06027B2D RID: 162605 RVA: 0x00576029 File Offset: 0x00574229
		public static void AddTriggerInterval(FlatBufferBuilder builder, float triggerInterval)
		{
			builder.AddFloat(1, triggerInterval, 0.0);
		}

		// Token: 0x06027B2E RID: 162606 RVA: 0x0057603C File Offset: 0x0057423C
		public static Offset<ITriggerCountConfig> EndITriggerCountConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITriggerCountConfig>(builder.EndTable());
		}

		// Token: 0x06027B2F RID: 162607 RVA: 0x0057604C File Offset: 0x0057424C
		public ITriggerCountConfigT UnPack()
		{
			ITriggerCountConfigT triggerCountConfigT = new ITriggerCountConfigT();
			this.UnPackTo(triggerCountConfigT);
			return triggerCountConfigT;
		}

		// Token: 0x06027B30 RID: 162608 RVA: 0x00576067 File Offset: 0x00574267
		public void UnPackTo(ITriggerCountConfigT _o)
		{
			_o.TriggerCount = this.TriggerCount;
			_o.TriggerInterval = this.TriggerInterval;
		}

		// Token: 0x06027B31 RID: 162609 RVA: 0x00576084 File Offset: 0x00574284
		public static Offset<ITriggerCountConfig> Pack(FlatBufferBuilder builder, ITriggerCountConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITriggerCountConfig>);
			}
			return ITriggerCountConfig.CreateITriggerCountConfig(builder, _o.TriggerCount, _o.TriggerInterval);
		}

		// Token: 0x0400F1CE RID: 61902
		private Table __p;
	}
}
