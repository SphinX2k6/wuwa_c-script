using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200549F RID: 21663
	public struct ICategoryMatchingSucceedBase : IFlatbufferObject
	{
		// Token: 0x17009A63 RID: 39523
		// (get) Token: 0x0602219F RID: 139679 RVA: 0x004B3803 File Offset: 0x004B1A03
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060221A0 RID: 139680 RVA: 0x004B3810 File Offset: 0x004B1A10
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060221A1 RID: 139681 RVA: 0x004B3818 File Offset: 0x004B1A18
		public static ICategoryMatchingSucceedBase GetRootAsICategoryMatchingSucceedBase(ByteBuffer _bb)
		{
			return ICategoryMatchingSucceedBase.GetRootAsICategoryMatchingSucceedBase(_bb, default(ICategoryMatchingSucceedBase));
		}

		// Token: 0x060221A2 RID: 139682 RVA: 0x004B3834 File Offset: 0x004B1A34
		public static ICategoryMatchingSucceedBase GetRootAsICategoryMatchingSucceedBase(ByteBuffer _bb, ICategoryMatchingSucceedBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060221A3 RID: 139683 RVA: 0x004B3851 File Offset: 0x004B1A51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060221A4 RID: 139684 RVA: 0x004B3860 File Offset: 0x004B1A60
		public ICategoryMatchingSucceedBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009A64 RID: 39524
		// (get) Token: 0x060221A5 RID: 139685 RVA: 0x004B3870 File Offset: 0x004B1A70
		public bool IsSilent
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009A65 RID: 39525
		// (get) Token: 0x060221A6 RID: 139686 RVA: 0x004B38B0 File Offset: 0x004B1AB0
		public bool IsDestroy
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009A66 RID: 39526
		// (get) Token: 0x060221A7 RID: 139687 RVA: 0x004B38F0 File Offset: 0x004B1AF0
		public bool SyncAdsorbatePerformance
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009A67 RID: 39527
		// (get) Token: 0x060221A8 RID: 139688 RVA: 0x004B3930 File Offset: 0x004B1B30
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

		// Token: 0x060221A9 RID: 139689 RVA: 0x004B3968 File Offset: 0x004B1B68
		public Span<byte> GetChangeSelfStateBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060221AA RID: 139690 RVA: 0x004B3978 File Offset: 0x004B1B78
		public byte[] GetChangeSelfStateArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x17009A68 RID: 39528
		// (get) Token: 0x060221AB RID: 139691 RVA: 0x004B3988 File Offset: 0x004B1B88
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

		// Token: 0x17009A69 RID: 39529
		// (get) Token: 0x060221AC RID: 139692 RVA: 0x004B39E8 File Offset: 0x004B1BE8
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

		// Token: 0x17009A6A RID: 39530
		// (get) Token: 0x060221AD RID: 139693 RVA: 0x004B3A28 File Offset: 0x004B1C28
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

		// Token: 0x17009A6B RID: 39531
		// (get) Token: 0x060221AE RID: 139694 RVA: 0x004B3A88 File Offset: 0x004B1C88
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

		// Token: 0x060221AF RID: 139695 RVA: 0x004B3AC0 File Offset: 0x004B1CC0
		public Span<byte> GetChangeSelfStateAfterDischargedBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060221B0 RID: 139696 RVA: 0x004B3AD0 File Offset: 0x004B1CD0
		public byte[] GetChangeSelfStateAfterDischargedArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x17009A6C RID: 39532
		// (get) Token: 0x060221B1 RID: 139697 RVA: 0x004B3AE0 File Offset: 0x004B1CE0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060221B2 RID: 139698 RVA: 0x004B3B20 File Offset: 0x004B1D20
		public static Offset<ICategoryMatchingSucceedBase> CreateICategoryMatchingSucceedBase(FlatBufferBuilder builder, bool IsSilent = false, bool IsDestroy = false, bool SyncAdsorbatePerformance = false, StringOffset ChangeSelfStateOffset = default(StringOffset), Offset<IEntityState> ChangeItemStateOffset = default(Offset<IEntityState>), int DelayDischarge = 0, Offset<IEntityState> ChangeItemStateAfterDischargedOffset = default(Offset<IEntityState>), StringOffset ChangeSelfStateAfterDischargedOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(9);
			ICategoryMatchingSucceedBase.AddChangeSelfStateAfterDischarged(builder, ChangeSelfStateAfterDischargedOffset);
			ICategoryMatchingSucceedBase.AddChangeItemStateAfterDischarged(builder, ChangeItemStateAfterDischargedOffset);
			ICategoryMatchingSucceedBase.AddDelayDischarge(builder, DelayDischarge);
			ICategoryMatchingSucceedBase.AddChangeItemState(builder, ChangeItemStateOffset);
			ICategoryMatchingSucceedBase.AddChangeSelfState(builder, ChangeSelfStateOffset);
			ICategoryMatchingSucceedBase.AddNullMask(builder, NullMask);
			ICategoryMatchingSucceedBase.AddSyncAdsorbatePerformance(builder, SyncAdsorbatePerformance);
			ICategoryMatchingSucceedBase.AddIsDestroy(builder, IsDestroy);
			ICategoryMatchingSucceedBase.AddIsSilent(builder, IsSilent);
			return ICategoryMatchingSucceedBase.EndICategoryMatchingSucceedBase(builder);
		}

		// Token: 0x060221B3 RID: 139699 RVA: 0x004B3B80 File Offset: 0x004B1D80
		public static void StartICategoryMatchingSucceedBase(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x060221B4 RID: 139700 RVA: 0x004B3B8A File Offset: 0x004B1D8A
		public static void AddIsSilent(FlatBufferBuilder builder, bool isSilent)
		{
			builder.AddBool(0, isSilent, false);
		}

		// Token: 0x060221B5 RID: 139701 RVA: 0x004B3B95 File Offset: 0x004B1D95
		public static void AddIsDestroy(FlatBufferBuilder builder, bool isDestroy)
		{
			builder.AddBool(1, isDestroy, false);
		}

		// Token: 0x060221B6 RID: 139702 RVA: 0x004B3BA0 File Offset: 0x004B1DA0
		public static void AddSyncAdsorbatePerformance(FlatBufferBuilder builder, bool syncAdsorbatePerformance)
		{
			builder.AddBool(2, syncAdsorbatePerformance, false);
		}

		// Token: 0x060221B7 RID: 139703 RVA: 0x004B3BAB File Offset: 0x004B1DAB
		public static void AddChangeSelfState(FlatBufferBuilder builder, StringOffset changeSelfStateOffset)
		{
			builder.AddOffset(3, changeSelfStateOffset.Value, 0);
		}

		// Token: 0x060221B8 RID: 139704 RVA: 0x004B3BBB File Offset: 0x004B1DBB
		public static void AddChangeItemState(FlatBufferBuilder builder, Offset<IEntityState> changeItemStateOffset)
		{
			builder.AddOffset(4, changeItemStateOffset.Value, 0);
		}

		// Token: 0x060221B9 RID: 139705 RVA: 0x004B3BCB File Offset: 0x004B1DCB
		public static void AddDelayDischarge(FlatBufferBuilder builder, int delayDischarge)
		{
			builder.AddInt(5, delayDischarge, 0);
		}

		// Token: 0x060221BA RID: 139706 RVA: 0x004B3BD6 File Offset: 0x004B1DD6
		public static void AddChangeItemStateAfterDischarged(FlatBufferBuilder builder, Offset<IEntityState> changeItemStateAfterDischargedOffset)
		{
			builder.AddOffset(6, changeItemStateAfterDischargedOffset.Value, 0);
		}

		// Token: 0x060221BB RID: 139707 RVA: 0x004B3BE6 File Offset: 0x004B1DE6
		public static void AddChangeSelfStateAfterDischarged(FlatBufferBuilder builder, StringOffset changeSelfStateAfterDischargedOffset)
		{
			builder.AddOffset(7, changeSelfStateAfterDischargedOffset.Value, 0);
		}

		// Token: 0x060221BC RID: 139708 RVA: 0x004B3BF6 File Offset: 0x004B1DF6
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x060221BD RID: 139709 RVA: 0x004B3C01 File Offset: 0x004B1E01
		public static Offset<ICategoryMatchingSucceedBase> EndICategoryMatchingSucceedBase(FlatBufferBuilder builder)
		{
			return new Offset<ICategoryMatchingSucceedBase>(builder.EndTable());
		}

		// Token: 0x060221BE RID: 139710 RVA: 0x004B3C10 File Offset: 0x004B1E10
		public ICategoryMatchingSucceedBaseT UnPack()
		{
			ICategoryMatchingSucceedBaseT categoryMatchingSucceedBaseT = new ICategoryMatchingSucceedBaseT();
			this.UnPackTo(categoryMatchingSucceedBaseT);
			return categoryMatchingSucceedBaseT;
		}

		// Token: 0x060221BF RID: 139711 RVA: 0x004B3C2C File Offset: 0x004B1E2C
		public void UnPackTo(ICategoryMatchingSucceedBaseT _o)
		{
			_o.IsSilent = this.IsSilent;
			_o.IsDestroy = this.IsDestroy;
			_o.SyncAdsorbatePerformance = this.SyncAdsorbatePerformance;
			_o.ChangeSelfState = this.ChangeSelfState;
			_o.ChangeItemState = ((this.ChangeItemState != null) ? this.ChangeItemState.Value.UnPack() : null);
			_o.DelayDischarge = this.DelayDischarge;
			_o.ChangeItemStateAfterDischarged = ((this.ChangeItemStateAfterDischarged != null) ? this.ChangeItemStateAfterDischarged.Value.UnPack() : null);
			_o.ChangeSelfStateAfterDischarged = this.ChangeSelfStateAfterDischarged;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060221C0 RID: 139712 RVA: 0x004B3CEC File Offset: 0x004B1EEC
		public static Offset<ICategoryMatchingSucceedBase> Pack(FlatBufferBuilder builder, ICategoryMatchingSucceedBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICategoryMatchingSucceedBase>);
			}
			StringOffset changeSelfStateOffset = (_o.ChangeSelfState == null) ? default(StringOffset) : builder.CreateString(_o.ChangeSelfState);
			Offset<IEntityState> changeItemStateOffset = (_o.ChangeItemState == null) ? default(Offset<IEntityState>) : IEntityState.Pack(builder, _o.ChangeItemState);
			Offset<IEntityState> changeItemStateAfterDischargedOffset = (_o.ChangeItemStateAfterDischarged == null) ? default(Offset<IEntityState>) : IEntityState.Pack(builder, _o.ChangeItemStateAfterDischarged);
			StringOffset changeSelfStateAfterDischargedOffset = (_o.ChangeSelfStateAfterDischarged == null) ? default(StringOffset) : builder.CreateString(_o.ChangeSelfStateAfterDischarged);
			return ICategoryMatchingSucceedBase.CreateICategoryMatchingSucceedBase(builder, _o.IsSilent, _o.IsDestroy, _o.SyncAdsorbatePerformance, changeSelfStateOffset, changeItemStateOffset, _o.DelayDischarge, changeItemStateAfterDischargedOffset, changeSelfStateAfterDischargedOffset, _o.NullMask);
		}

		// Token: 0x0400E9B9 RID: 59833
		private Table __p;
	}
}
