using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060EE RID: 24814
	public struct ITriggerCountConfig : IFlatbufferObject
	{
		// Token: 0x1700B8A9 RID: 47273
		// (get) Token: 0x0602A0AE RID: 172206 RVA: 0x005BD3D3 File Offset: 0x005BB5D3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A0AF RID: 172207 RVA: 0x005BD3E0 File Offset: 0x005BB5E0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A0B0 RID: 172208 RVA: 0x005BD3E8 File Offset: 0x005BB5E8
		public static ITriggerCountConfig GetRootAsITriggerCountConfig(ByteBuffer _bb)
		{
			return ITriggerCountConfig.GetRootAsITriggerCountConfig(_bb, default(ITriggerCountConfig));
		}

		// Token: 0x0602A0B1 RID: 172209 RVA: 0x005BD404 File Offset: 0x005BB604
		public static ITriggerCountConfig GetRootAsITriggerCountConfig(ByteBuffer _bb, ITriggerCountConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A0B2 RID: 172210 RVA: 0x005BD421 File Offset: 0x005BB621
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A0B3 RID: 172211 RVA: 0x005BD430 File Offset: 0x005BB630
		public ITriggerCountConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B8AA RID: 47274
		// (get) Token: 0x0602A0B4 RID: 172212 RVA: 0x005BD440 File Offset: 0x005BB640
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

		// Token: 0x1700B8AB RID: 47275
		// (get) Token: 0x0602A0B5 RID: 172213 RVA: 0x005BD47C File Offset: 0x005BB67C
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

		// Token: 0x0602A0B6 RID: 172214 RVA: 0x005BD4BC File Offset: 0x005BB6BC
		public static Offset<ITriggerCountConfig> CreateITriggerCountConfig(FlatBufferBuilder builder, int TriggerCount = 0, float TriggerInterval = 0f)
		{
			builder.StartTable(2);
			ITriggerCountConfig.AddTriggerInterval(builder, TriggerInterval);
			ITriggerCountConfig.AddTriggerCount(builder, TriggerCount);
			return ITriggerCountConfig.EndITriggerCountConfig(builder);
		}

		// Token: 0x0602A0B7 RID: 172215 RVA: 0x005BD4D9 File Offset: 0x005BB6D9
		public static void StartITriggerCountConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602A0B8 RID: 172216 RVA: 0x005BD4E2 File Offset: 0x005BB6E2
		public static void AddTriggerCount(FlatBufferBuilder builder, int triggerCount)
		{
			builder.AddInt(0, triggerCount, 0);
		}

		// Token: 0x0602A0B9 RID: 172217 RVA: 0x005BD4ED File Offset: 0x005BB6ED
		public static void AddTriggerInterval(FlatBufferBuilder builder, float triggerInterval)
		{
			builder.AddFloat(1, triggerInterval, 0.0);
		}

		// Token: 0x0602A0BA RID: 172218 RVA: 0x005BD500 File Offset: 0x005BB700
		public static Offset<ITriggerCountConfig> EndITriggerCountConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITriggerCountConfig>(builder.EndTable());
		}

		// Token: 0x0602A0BB RID: 172219 RVA: 0x005BD510 File Offset: 0x005BB710
		public ITriggerCountConfigT UnPack()
		{
			ITriggerCountConfigT triggerCountConfigT = new ITriggerCountConfigT();
			this.UnPackTo(triggerCountConfigT);
			return triggerCountConfigT;
		}

		// Token: 0x0602A0BC RID: 172220 RVA: 0x005BD52B File Offset: 0x005BB72B
		public void UnPackTo(ITriggerCountConfigT _o)
		{
			_o.TriggerCount = this.TriggerCount;
			_o.TriggerInterval = this.TriggerInterval;
		}

		// Token: 0x0602A0BD RID: 172221 RVA: 0x005BD548 File Offset: 0x005BB748
		public static Offset<ITriggerCountConfig> Pack(FlatBufferBuilder builder, ITriggerCountConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITriggerCountConfig>);
			}
			return ITriggerCountConfig.CreateITriggerCountConfig(builder, _o.TriggerCount, _o.TriggerInterval);
		}

		// Token: 0x0400FEC8 RID: 65224
		private Table __p;
	}
}
