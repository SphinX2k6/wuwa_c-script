using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200549C RID: 21660
	public struct ICategoryMatchingSucceed : IFlatbufferObject
	{
		// Token: 0x17009A4C RID: 39500
		// (get) Token: 0x0602215F RID: 139615 RVA: 0x004B2EB3 File Offset: 0x004B10B3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022160 RID: 139616 RVA: 0x004B2EC0 File Offset: 0x004B10C0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022161 RID: 139617 RVA: 0x004B2EC8 File Offset: 0x004B10C8
		public static ICategoryMatchingSucceed GetRootAsICategoryMatchingSucceed(ByteBuffer _bb)
		{
			return ICategoryMatchingSucceed.GetRootAsICategoryMatchingSucceed(_bb, default(ICategoryMatchingSucceed));
		}

		// Token: 0x06022162 RID: 139618 RVA: 0x004B2EE4 File Offset: 0x004B10E4
		public static ICategoryMatchingSucceed GetRootAsICategoryMatchingSucceed(ByteBuffer _bb, ICategoryMatchingSucceed obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022163 RID: 139619 RVA: 0x004B2F01 File Offset: 0x004B1101
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022164 RID: 139620 RVA: 0x004B2F10 File Offset: 0x004B1110
		public ICategoryMatchingSucceed __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009A4D RID: 39501
		// (get) Token: 0x06022165 RID: 139621 RVA: 0x004B2F20 File Offset: 0x004B1120
		public bool IsSilent
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009A4E RID: 39502
		// (get) Token: 0x06022166 RID: 139622 RVA: 0x004B2F60 File Offset: 0x004B1160
		public bool IsDestroy
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009A4F RID: 39503
		// (get) Token: 0x06022167 RID: 139623 RVA: 0x004B2FA0 File Offset: 0x004B11A0
		public bool SyncAdsorbatePerformance
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009A50 RID: 39504
		// (get) Token: 0x06022168 RID: 139624 RVA: 0x004B2FE0 File Offset: 0x004B11E0
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

		// Token: 0x06022169 RID: 139625 RVA: 0x004B3018 File Offset: 0x004B1218
		public Span<byte> GetChangeSelfStateBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0602216A RID: 139626 RVA: 0x004B3028 File Offset: 0x004B1228
		public byte[] GetChangeSelfStateArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x17009A51 RID: 39505
		// (get) Token: 0x0602216B RID: 139627 RVA: 0x004B3038 File Offset: 0x004B1238
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

		// Token: 0x17009A52 RID: 39506
		// (get) Token: 0x0602216C RID: 139628 RVA: 0x004B3098 File Offset: 0x004B1298
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

		// Token: 0x17009A53 RID: 39507
		// (get) Token: 0x0602216D RID: 139629 RVA: 0x004B30D8 File Offset: 0x004B12D8
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

		// Token: 0x17009A54 RID: 39508
		// (get) Token: 0x0602216E RID: 139630 RVA: 0x004B3138 File Offset: 0x004B1338
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

		// Token: 0x0602216F RID: 139631 RVA: 0x004B3170 File Offset: 0x004B1370
		public Span<byte> GetChangeSelfStateAfterDischargedBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06022170 RID: 139632 RVA: 0x004B3180 File Offset: 0x004B1380
		public byte[] GetChangeSelfStateAfterDischargedArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x17009A55 RID: 39509
		// (get) Token: 0x06022171 RID: 139633 RVA: 0x004B3190 File Offset: 0x004B1390
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

		// Token: 0x17009A56 RID: 39510
		// (get) Token: 0x06022172 RID: 139634 RVA: 0x004B31F0 File Offset: 0x004B13F0
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

		// Token: 0x06022173 RID: 139635 RVA: 0x004B3228 File Offset: 0x004B1428
		public Span<byte> GetDischargeSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06022174 RID: 139636 RVA: 0x004B3238 File Offset: 0x004B1438
		public byte[] GetDischargeSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x17009A57 RID: 39511
		// (get) Token: 0x06022175 RID: 139637 RVA: 0x004B3248 File Offset: 0x004B1448
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

		// Token: 0x06022176 RID: 139638 RVA: 0x004B3288 File Offset: 0x004B1488
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

		// Token: 0x06022177 RID: 139639 RVA: 0x004B32F8 File Offset: 0x004B14F8
		public static void StartICategoryMatchingSucceed(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x06022178 RID: 139640 RVA: 0x004B3302 File Offset: 0x004B1502
		public static void AddIsSilent(FlatBufferBuilder builder, bool isSilent)
		{
			builder.AddBool(0, isSilent, false);
		}

		// Token: 0x06022179 RID: 139641 RVA: 0x004B330D File Offset: 0x004B150D
		public static void AddIsDestroy(FlatBufferBuilder builder, bool isDestroy)
		{
			builder.AddBool(1, isDestroy, false);
		}

		// Token: 0x0602217A RID: 139642 RVA: 0x004B3318 File Offset: 0x004B1518
		public static void AddSyncAdsorbatePerformance(FlatBufferBuilder builder, bool syncAdsorbatePerformance)
		{
			builder.AddBool(2, syncAdsorbatePerformance, false);
		}

		// Token: 0x0602217B RID: 139643 RVA: 0x004B3323 File Offset: 0x004B1523
		public static void AddChangeSelfState(FlatBufferBuilder builder, StringOffset changeSelfStateOffset)
		{
			builder.AddOffset(3, changeSelfStateOffset.Value, 0);
		}

		// Token: 0x0602217C RID: 139644 RVA: 0x004B3333 File Offset: 0x004B1533
		public static void AddChangeItemState(FlatBufferBuilder builder, Offset<IEntityState> changeItemStateOffset)
		{
			builder.AddOffset(4, changeItemStateOffset.Value, 0);
		}

		// Token: 0x0602217D RID: 139645 RVA: 0x004B3343 File Offset: 0x004B1543
		public static void AddDelayDischarge(FlatBufferBuilder builder, int delayDischarge)
		{
			builder.AddInt(5, delayDischarge, 0);
		}

		// Token: 0x0602217E RID: 139646 RVA: 0x004B334E File Offset: 0x004B154E
		public static void AddChangeItemStateAfterDischarged(FlatBufferBuilder builder, Offset<IEntityState> changeItemStateAfterDischargedOffset)
		{
			builder.AddOffset(6, changeItemStateAfterDischargedOffset.Value, 0);
		}

		// Token: 0x0602217F RID: 139647 RVA: 0x004B335E File Offset: 0x004B155E
		public static void AddChangeSelfStateAfterDischarged(FlatBufferBuilder builder, StringOffset changeSelfStateAfterDischargedOffset)
		{
			builder.AddOffset(7, changeSelfStateAfterDischargedOffset.Value, 0);
		}

		// Token: 0x06022180 RID: 139648 RVA: 0x004B336E File Offset: 0x004B156E
		public static void AddChangeAdsorbateState(FlatBufferBuilder builder, Offset<IItemChangeAdsorbateState> changeAdsorbateStateOffset)
		{
			builder.AddOffset(8, changeAdsorbateStateOffset.Value, 0);
		}

		// Token: 0x06022181 RID: 139649 RVA: 0x004B337E File Offset: 0x004B157E
		public static void AddDischargeSequence(FlatBufferBuilder builder, StringOffset dischargeSequenceOffset)
		{
			builder.AddOffset(9, dischargeSequenceOffset.Value, 0);
		}

		// Token: 0x06022182 RID: 139650 RVA: 0x004B338F File Offset: 0x004B158F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(10, nullMask, 0);
		}

		// Token: 0x06022183 RID: 139651 RVA: 0x004B339B File Offset: 0x004B159B
		public static Offset<ICategoryMatchingSucceed> EndICategoryMatchingSucceed(FlatBufferBuilder builder)
		{
			return new Offset<ICategoryMatchingSucceed>(builder.EndTable());
		}

		// Token: 0x06022184 RID: 139652 RVA: 0x004B33A8 File Offset: 0x004B15A8
		public ICategoryMatchingSucceedT UnPack()
		{
			ICategoryMatchingSucceedT categoryMatchingSucceedT = new ICategoryMatchingSucceedT();
			this.UnPackTo(categoryMatchingSucceedT);
			return categoryMatchingSucceedT;
		}

		// Token: 0x06022185 RID: 139653 RVA: 0x004B33C4 File Offset: 0x004B15C4
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

		// Token: 0x06022186 RID: 139654 RVA: 0x004B34C0 File Offset: 0x004B16C0
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

		// Token: 0x0400E9AD RID: 59821
		private Table __p;
	}
}
