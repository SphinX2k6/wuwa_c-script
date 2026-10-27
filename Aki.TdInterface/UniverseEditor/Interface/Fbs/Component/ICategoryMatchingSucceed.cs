using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F6D RID: 20333
	public struct ICategoryMatchingSucceed : IFlatbufferObject
	{
		// Token: 0x170092D3 RID: 37587
		// (get) Token: 0x0602040D RID: 132109 RVA: 0x0047CEC3 File Offset: 0x0047B0C3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602040E RID: 132110 RVA: 0x0047CED0 File Offset: 0x0047B0D0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602040F RID: 132111 RVA: 0x0047CED8 File Offset: 0x0047B0D8
		public static ICategoryMatchingSucceed GetRootAsICategoryMatchingSucceed(ByteBuffer _bb)
		{
			return ICategoryMatchingSucceed.GetRootAsICategoryMatchingSucceed(_bb, default(ICategoryMatchingSucceed));
		}

		// Token: 0x06020410 RID: 132112 RVA: 0x0047CEF4 File Offset: 0x0047B0F4
		public static ICategoryMatchingSucceed GetRootAsICategoryMatchingSucceed(ByteBuffer _bb, ICategoryMatchingSucceed obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020411 RID: 132113 RVA: 0x0047CF11 File Offset: 0x0047B111
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020412 RID: 132114 RVA: 0x0047CF20 File Offset: 0x0047B120
		public ICategoryMatchingSucceed __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170092D4 RID: 37588
		// (get) Token: 0x06020413 RID: 132115 RVA: 0x0047CF30 File Offset: 0x0047B130
		public bool IsSilent
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170092D5 RID: 37589
		// (get) Token: 0x06020414 RID: 132116 RVA: 0x0047CF70 File Offset: 0x0047B170
		public bool IsDestroy
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170092D6 RID: 37590
		// (get) Token: 0x06020415 RID: 132117 RVA: 0x0047CFB0 File Offset: 0x0047B1B0
		public bool SyncAdsorbatePerformance
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170092D7 RID: 37591
		// (get) Token: 0x06020416 RID: 132118 RVA: 0x0047CFF0 File Offset: 0x0047B1F0
		public string ChangeSelfState
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020417 RID: 132119 RVA: 0x0047D028 File Offset: 0x0047B228
		public Span<byte> GetChangeSelfStateBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06020418 RID: 132120 RVA: 0x0047D038 File Offset: 0x0047B238
		public byte[] GetChangeSelfStateArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x170092D8 RID: 37592
		// (get) Token: 0x06020419 RID: 132121 RVA: 0x0047D048 File Offset: 0x0047B248
		public IEntityState? ChangeItemState
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IEntityState?(default(IEntityState).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170092D9 RID: 37593
		// (get) Token: 0x0602041A RID: 132122 RVA: 0x0047D0A8 File Offset: 0x0047B2A8
		public int DelayDischarge
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170092DA RID: 37594
		// (get) Token: 0x0602041B RID: 132123 RVA: 0x0047D0E8 File Offset: 0x0047B2E8
		public IEntityState? ChangeItemStateAfterDischarged
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new IEntityState?(default(IEntityState).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170092DB RID: 37595
		// (get) Token: 0x0602041C RID: 132124 RVA: 0x0047D148 File Offset: 0x0047B348
		public string ChangeSelfStateAfterDischarged
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602041D RID: 132125 RVA: 0x0047D180 File Offset: 0x0047B380
		public Span<byte> GetChangeSelfStateAfterDischargedBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0602041E RID: 132126 RVA: 0x0047D190 File Offset: 0x0047B390
		public byte[] GetChangeSelfStateAfterDischargedArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x170092DC RID: 37596
		// (get) Token: 0x0602041F RID: 132127 RVA: 0x0047D1A0 File Offset: 0x0047B3A0
		public IItemChangeAdsorbateState? ChangeAdsorbateState
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return new IItemChangeAdsorbateState?(default(IItemChangeAdsorbateState).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170092DD RID: 37597
		// (get) Token: 0x06020420 RID: 132128 RVA: 0x0047D200 File Offset: 0x0047B400
		public string DischargeSequence
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020421 RID: 132129 RVA: 0x0047D238 File Offset: 0x0047B438
		public Span<byte> GetDischargeSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06020422 RID: 132130 RVA: 0x0047D248 File Offset: 0x0047B448
		public byte[] GetDischargeSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x170092DE RID: 37598
		// (get) Token: 0x06020423 RID: 132131 RVA: 0x0047D258 File Offset: 0x0047B458
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020424 RID: 132132 RVA: 0x0047D298 File Offset: 0x0047B498
		public static Offset<ICategoryMatchingSucceed> CreateICategoryMatchingSucceed(FlatBufferBuilder builder, bool IsSilent = false, bool IsDestroy = false, bool SyncAdsorbatePerformance = false, StringOffset ChangeSelfStateOffset = default(StringOffset), Offset<IEntityState> ChangeItemStateOffset = default(Offset<IEntityState>), int DelayDischarge = 0, Offset<IEntityState> ChangeItemStateAfterDischargedOffset = default(Offset<IEntityState>), StringOffset ChangeSelfStateAfterDischargedOffset = default(StringOffset), Offset<IItemChangeAdsorbateState> ChangeAdsorbateStateOffset = default(Offset<IItemChangeAdsorbateState>), StringOffset DischargeSequenceOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(11);
			ICategoryMatchingSucceed.AddDischargeSequence(builder, DischargeSequenceOffset);
			ICategoryMatchingSucceed.AddChangeAdsorbateState(builder, ChangeAdsorbateStateOffset);
			ICategoryMatchingSucceed.AddChangeSelfStateAfterDischarged(builder, ChangeSelfStateAfterDischargedOffset);
			ICategoryMatchingSucceed.AddChangeItemStateAfterDischarged(builder, ChangeItemStateAfterDischargedOffset);
			ICategoryMatchingSucceed.AddDelayDischarge(builder, DelayDischarge);
			ICategoryMatchingSucceed.AddChangeItemState(builder, ChangeItemStateOffset);
			ICategoryMatchingSucceed.AddChangeSelfState(builder, ChangeSelfStateOffset);
			ICategoryMatchingSucceed.AddNullMask(builder, NullMask);
			ICategoryMatchingSucceed.AddSyncAdsorbatePerformance(builder, SyncAdsorbatePerformance);
			ICategoryMatchingSucceed.AddIsDestroy(builder, IsDestroy);
			ICategoryMatchingSucceed.AddIsSilent(builder, IsSilent);
			return ICategoryMatchingSucceed.EndICategoryMatchingSucceed(builder);
		}

		// Token: 0x06020425 RID: 132133 RVA: 0x0047D308 File Offset: 0x0047B508
		public static void StartICategoryMatchingSucceed(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x06020426 RID: 132134 RVA: 0x0047D312 File Offset: 0x0047B512
		public static void AddIsSilent(FlatBufferBuilder builder, bool isSilent)
		{
			builder.AddBool(0, isSilent, false);
		}

		// Token: 0x06020427 RID: 132135 RVA: 0x0047D31D File Offset: 0x0047B51D
		public static void AddIsDestroy(FlatBufferBuilder builder, bool isDestroy)
		{
			builder.AddBool(1, isDestroy, false);
		}

		// Token: 0x06020428 RID: 132136 RVA: 0x0047D328 File Offset: 0x0047B528
		public static void AddSyncAdsorbatePerformance(FlatBufferBuilder builder, bool syncAdsorbatePerformance)
		{
			builder.AddBool(2, syncAdsorbatePerformance, false);
		}

		// Token: 0x06020429 RID: 132137 RVA: 0x0047D333 File Offset: 0x0047B533
		public static void AddChangeSelfState(FlatBufferBuilder builder, StringOffset changeSelfStateOffset)
		{
			builder.AddOffset(3, changeSelfStateOffset.Value, 0);
		}

		// Token: 0x0602042A RID: 132138 RVA: 0x0047D343 File Offset: 0x0047B543
		public static void AddChangeItemState(FlatBufferBuilder builder, Offset<IEntityState> changeItemStateOffset)
		{
			builder.AddOffset(4, changeItemStateOffset.Value, 0);
		}

		// Token: 0x0602042B RID: 132139 RVA: 0x0047D353 File Offset: 0x0047B553
		public static void AddDelayDischarge(FlatBufferBuilder builder, int delayDischarge)
		{
			builder.AddInt(5, delayDischarge, 0);
		}

		// Token: 0x0602042C RID: 132140 RVA: 0x0047D35E File Offset: 0x0047B55E
		public static void AddChangeItemStateAfterDischarged(FlatBufferBuilder builder, Offset<IEntityState> changeItemStateAfterDischargedOffset)
		{
			builder.AddOffset(6, changeItemStateAfterDischargedOffset.Value, 0);
		}

		// Token: 0x0602042D RID: 132141 RVA: 0x0047D36E File Offset: 0x0047B56E
		public static void AddChangeSelfStateAfterDischarged(FlatBufferBuilder builder, StringOffset changeSelfStateAfterDischargedOffset)
		{
			builder.AddOffset(7, changeSelfStateAfterDischargedOffset.Value, 0);
		}

		// Token: 0x0602042E RID: 132142 RVA: 0x0047D37E File Offset: 0x0047B57E
		public static void AddChangeAdsorbateState(FlatBufferBuilder builder, Offset<IItemChangeAdsorbateState> changeAdsorbateStateOffset)
		{
			builder.AddOffset(8, changeAdsorbateStateOffset.Value, 0);
		}

		// Token: 0x0602042F RID: 132143 RVA: 0x0047D38E File Offset: 0x0047B58E
		public static void AddDischargeSequence(FlatBufferBuilder builder, StringOffset dischargeSequenceOffset)
		{
			builder.AddOffset(9, dischargeSequenceOffset.Value, 0);
		}

		// Token: 0x06020430 RID: 132144 RVA: 0x0047D39F File Offset: 0x0047B59F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(10, nullMask, 0);
		}

		// Token: 0x06020431 RID: 132145 RVA: 0x0047D3AB File Offset: 0x0047B5AB
		public static Offset<ICategoryMatchingSucceed> EndICategoryMatchingSucceed(FlatBufferBuilder builder)
		{
			return new Offset<ICategoryMatchingSucceed>(builder.EndTable());
		}

		// Token: 0x06020432 RID: 132146 RVA: 0x0047D3B8 File Offset: 0x0047B5B8
		public ICategoryMatchingSucceedT UnPack()
		{
			ICategoryMatchingSucceedT categoryMatchingSucceedT = new ICategoryMatchingSucceedT();
			this.UnPackTo(categoryMatchingSucceedT);
			return categoryMatchingSucceedT;
		}

		// Token: 0x06020433 RID: 132147 RVA: 0x0047D3D4 File Offset: 0x0047B5D4
		public void UnPackTo(ICategoryMatchingSucceedT _o)
		{
			_o.IsSilent = this.IsSilent;
			_o.IsDestroy = this.IsDestroy;
			_o.SyncAdsorbatePerformance = this.SyncAdsorbatePerformance;
			_o.ChangeSelfState = this.ChangeSelfState;
			_o.ChangeItemState = ((this.ChangeItemState != null) ? this.ChangeItemState.Value.UnPack() : null);
			_o.DelayDischarge = this.DelayDischarge;
			_o.ChangeItemStateAfterDischarged = ((this.ChangeItemStateAfterDischarged != null) ? this.ChangeItemStateAfterDischarged.Value.UnPack() : null);
			_o.ChangeSelfStateAfterDischarged = this.ChangeSelfStateAfterDischarged;
			_o.ChangeAdsorbateState = ((this.ChangeAdsorbateState != null) ? this.ChangeAdsorbateState.Value.UnPack() : null);
			_o.DischargeSequence = this.DischargeSequence;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06020434 RID: 132148 RVA: 0x0047D4D0 File Offset: 0x0047B6D0
		public static Offset<ICategoryMatchingSucceed> Pack(FlatBufferBuilder builder, ICategoryMatchingSucceedT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICategoryMatchingSucceed>);
			}
			StringOffset changeSelfStateOffset = (_o.ChangeSelfState == null) ? default(StringOffset) : builder.CreateString(_o.ChangeSelfState);
			Offset<IEntityState> changeItemStateOffset = (_o.ChangeItemState == null) ? default(Offset<IEntityState>) : IEntityState.Pack(builder, _o.ChangeItemState);
			Offset<IEntityState> changeItemStateAfterDischargedOffset = (_o.ChangeItemStateAfterDischarged == null) ? default(Offset<IEntityState>) : IEntityState.Pack(builder, _o.ChangeItemStateAfterDischarged);
			StringOffset changeSelfStateAfterDischargedOffset = (_o.ChangeSelfStateAfterDischarged == null) ? default(StringOffset) : builder.CreateString(_o.ChangeSelfStateAfterDischarged);
			Offset<IItemChangeAdsorbateState> changeAdsorbateStateOffset = (_o.ChangeAdsorbateState == null) ? default(Offset<IItemChangeAdsorbateState>) : IItemChangeAdsorbateState.Pack(builder, _o.ChangeAdsorbateState);
			StringOffset dischargeSequenceOffset = (_o.DischargeSequence == null) ? default(StringOffset) : builder.CreateString(_o.DischargeSequence);
			return ICategoryMatchingSucceed.CreateICategoryMatchingSucceed(builder, _o.IsSilent, _o.IsDestroy, _o.SyncAdsorbatePerformance, changeSelfStateOffset, changeItemStateOffset, _o.DelayDischarge, changeItemStateAfterDischargedOffset, changeSelfStateAfterDischargedOffset, changeAdsorbateStateOffset, dischargeSequenceOffset, _o.NullMask);
		}

		// Token: 0x0400DE03 RID: 56835
		private Table __p;
	}
}
