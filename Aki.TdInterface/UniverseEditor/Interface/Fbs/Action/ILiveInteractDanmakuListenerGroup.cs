using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070FA RID: 28922
	public struct ILiveInteractDanmakuListenerGroup : IFlatbufferObject
	{
		// Token: 0x1700D3CD RID: 54221
		// (get) Token: 0x060323A6 RID: 205734 RVA: 0x006CB198 File Offset: 0x006C9398
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060323A7 RID: 205735 RVA: 0x006CB1A5 File Offset: 0x006C93A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060323A8 RID: 205736 RVA: 0x006CB1AC File Offset: 0x006C93AC
		public static ILiveInteractDanmakuListenerGroup GetRootAsILiveInteractDanmakuListenerGroup(ByteBuffer _bb)
		{
			return ILiveInteractDanmakuListenerGroup.GetRootAsILiveInteractDanmakuListenerGroup(_bb, default(ILiveInteractDanmakuListenerGroup));
		}

		// Token: 0x060323A9 RID: 205737 RVA: 0x006CB1C8 File Offset: 0x006C93C8
		public static ILiveInteractDanmakuListenerGroup GetRootAsILiveInteractDanmakuListenerGroup(ByteBuffer _bb, ILiveInteractDanmakuListenerGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060323AA RID: 205738 RVA: 0x006CB1E5 File Offset: 0x006C93E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060323AB RID: 205739 RVA: 0x006CB1F4 File Offset: 0x006C93F4
		public ILiveInteractDanmakuListenerGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D3CE RID: 54222
		// (get) Token: 0x060323AC RID: 205740 RVA: 0x006CB204 File Offset: 0x006C9404
		public TLiveInteractDanmakuTrigger TriggerType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TLiveInteractDanmakuTrigger.NONE;
				}
				return (TLiveInteractDanmakuTrigger)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060323AD RID: 205741 RVA: 0x006CB240 File Offset: 0x006C9440
		public TTable? Trigger<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060323AE RID: 205742 RVA: 0x006CB284 File Offset: 0x006C9484
		public ILiveInteractDanmakuTriggerBattleEvent TriggerAsILiveInteractDanmakuTriggerBattleEvent()
		{
			return this.Trigger<ILiveInteractDanmakuTriggerBattleEvent>().Value;
		}

		// Token: 0x060323AF RID: 205743 RVA: 0x006CB2A0 File Offset: 0x006C94A0
		public ILiveInteractDanmakuTriggerSkillGenre TriggerAsILiveInteractDanmakuTriggerSkillGenre()
		{
			return this.Trigger<ILiveInteractDanmakuTriggerSkillGenre>().Value;
		}

		// Token: 0x060323B0 RID: 205744 RVA: 0x006CB2BC File Offset: 0x006C94BC
		public ILiveInteractDanmakuTriggerSkillId TriggerAsILiveInteractDanmakuTriggerSkillId()
		{
			return this.Trigger<ILiveInteractDanmakuTriggerSkillId>().Value;
		}

		// Token: 0x1700D3CF RID: 54223
		// (get) Token: 0x060323B1 RID: 205745 RVA: 0x006CB2D8 File Offset: 0x006C94D8
		public int DanmakuPoolId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D3D0 RID: 54224
		// (get) Token: 0x060323B2 RID: 205746 RVA: 0x006CB314 File Offset: 0x006C9514
		public int TriggerCount
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D3D1 RID: 54225
		// (get) Token: 0x060323B3 RID: 205747 RVA: 0x006CB354 File Offset: 0x006C9554
		public int MaxTriggerCount
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060323B4 RID: 205748 RVA: 0x006CB391 File Offset: 0x006C9591
		public static Offset<ILiveInteractDanmakuListenerGroup> CreateILiveInteractDanmakuListenerGroup(FlatBufferBuilder builder, TLiveInteractDanmakuTrigger Trigger_type = TLiveInteractDanmakuTrigger.NONE, int TriggerOffset = 0, int DanmakuPoolId = 0, int TriggerCount = 0, int MaxTriggerCount = 0)
		{
			builder.StartTable(5);
			ILiveInteractDanmakuListenerGroup.AddMaxTriggerCount(builder, MaxTriggerCount);
			ILiveInteractDanmakuListenerGroup.AddTriggerCount(builder, TriggerCount);
			ILiveInteractDanmakuListenerGroup.AddDanmakuPoolId(builder, DanmakuPoolId);
			ILiveInteractDanmakuListenerGroup.AddTrigger(builder, TriggerOffset);
			ILiveInteractDanmakuListenerGroup.AddTriggerType(builder, Trigger_type);
			return ILiveInteractDanmakuListenerGroup.EndILiveInteractDanmakuListenerGroup(builder);
		}

		// Token: 0x060323B5 RID: 205749 RVA: 0x006CB3C5 File Offset: 0x006C95C5
		public static void StartILiveInteractDanmakuListenerGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060323B6 RID: 205750 RVA: 0x006CB3CE File Offset: 0x006C95CE
		public static void AddTriggerType(FlatBufferBuilder builder, TLiveInteractDanmakuTrigger triggerType)
		{
			builder.AddByte(0, (byte)triggerType, 0);
		}

		// Token: 0x060323B7 RID: 205751 RVA: 0x006CB3D9 File Offset: 0x006C95D9
		public static void AddTrigger(FlatBufferBuilder builder, int triggerOffset)
		{
			builder.AddOffset(1, triggerOffset, 0);
		}

		// Token: 0x060323B8 RID: 205752 RVA: 0x006CB3E4 File Offset: 0x006C95E4
		public static void AddDanmakuPoolId(FlatBufferBuilder builder, int danmakuPoolId)
		{
			builder.AddInt(2, danmakuPoolId, 0);
		}

		// Token: 0x060323B9 RID: 205753 RVA: 0x006CB3EF File Offset: 0x006C95EF
		public static void AddTriggerCount(FlatBufferBuilder builder, int triggerCount)
		{
			builder.AddInt(3, triggerCount, 0);
		}

		// Token: 0x060323BA RID: 205754 RVA: 0x006CB3FA File Offset: 0x006C95FA
		public static void AddMaxTriggerCount(FlatBufferBuilder builder, int maxTriggerCount)
		{
			builder.AddInt(4, maxTriggerCount, 0);
		}

		// Token: 0x060323BB RID: 205755 RVA: 0x006CB405 File Offset: 0x006C9605
		public static Offset<ILiveInteractDanmakuListenerGroup> EndILiveInteractDanmakuListenerGroup(FlatBufferBuilder builder)
		{
			return new Offset<ILiveInteractDanmakuListenerGroup>(builder.EndTable());
		}

		// Token: 0x060323BC RID: 205756 RVA: 0x006CB414 File Offset: 0x006C9614
		public ILiveInteractDanmakuListenerGroupT UnPack()
		{
			ILiveInteractDanmakuListenerGroupT liveInteractDanmakuListenerGroupT = new ILiveInteractDanmakuListenerGroupT();
			this.UnPackTo(liveInteractDanmakuListenerGroupT);
			return liveInteractDanmakuListenerGroupT;
		}

		// Token: 0x060323BD RID: 205757 RVA: 0x006CB430 File Offset: 0x006C9630
		public void UnPackTo(ILiveInteractDanmakuListenerGroupT _o)
		{
			_o.Trigger = new TLiveInteractDanmakuTriggerUnion();
			_o.Trigger.Type = this.TriggerType;
			switch (this.TriggerType)
			{
			case TLiveInteractDanmakuTrigger.ILiveInteractDanmakuTriggerBattleEvent:
				_o.Trigger.Value = ((this.Trigger<ILiveInteractDanmakuTriggerBattleEvent>() != null) ? this.Trigger<ILiveInteractDanmakuTriggerBattleEvent>().Value.UnPack() : null);
				break;
			case TLiveInteractDanmakuTrigger.ILiveInteractDanmakuTriggerSkillGenre:
				_o.Trigger.Value = ((this.Trigger<ILiveInteractDanmakuTriggerSkillGenre>() != null) ? this.Trigger<ILiveInteractDanmakuTriggerSkillGenre>().Value.UnPack() : null);
				break;
			case TLiveInteractDanmakuTrigger.ILiveInteractDanmakuTriggerSkillId:
				_o.Trigger.Value = ((this.Trigger<ILiveInteractDanmakuTriggerSkillId>() != null) ? this.Trigger<ILiveInteractDanmakuTriggerSkillId>().Value.UnPack() : null);
				break;
			}
			_o.DanmakuPoolId = this.DanmakuPoolId;
			_o.TriggerCount = this.TriggerCount;
			_o.MaxTriggerCount = this.MaxTriggerCount;
		}

		// Token: 0x060323BE RID: 205758 RVA: 0x006CB544 File Offset: 0x006C9744
		public static Offset<ILiveInteractDanmakuListenerGroup> Pack(FlatBufferBuilder builder, ILiveInteractDanmakuListenerGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiveInteractDanmakuListenerGroup>);
			}
			TLiveInteractDanmakuTrigger trigger_type = (_o.Trigger == null) ? TLiveInteractDanmakuTrigger.NONE : _o.Trigger.Type;
			int triggerOffset = (_o.Trigger == null) ? 0 : TLiveInteractDanmakuTriggerUnion.Pack(builder, _o.Trigger);
			return ILiveInteractDanmakuListenerGroup.CreateILiveInteractDanmakuListenerGroup(builder, trigger_type, triggerOffset, _o.DanmakuPoolId, _o.TriggerCount, _o.MaxTriggerCount);
		}

		// Token: 0x040120CB RID: 73931
		private Table __p;
	}
}
