using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F70 RID: 20336
	public struct ICategoryMatchingSucceedBase : IFlatbufferObject
	{
		// Token: 0x170092EA RID: 37610
		// (get) Token: 0x0602044D RID: 132173 RVA: 0x0047D813 File Offset: 0x0047BA13
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602044E RID: 132174 RVA: 0x0047D820 File Offset: 0x0047BA20
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602044F RID: 132175 RVA: 0x0047D828 File Offset: 0x0047BA28
		public static ICategoryMatchingSucceedBase GetRootAsICategoryMatchingSucceedBase(ByteBuffer _bb)
		{
			return ICategoryMatchingSucceedBase.GetRootAsICategoryMatchingSucceedBase(_bb, default(ICategoryMatchingSucceedBase));
		}

		// Token: 0x06020450 RID: 132176 RVA: 0x0047D844 File Offset: 0x0047BA44
		public static ICategoryMatchingSucceedBase GetRootAsICategoryMatchingSucceedBase(ByteBuffer _bb, ICategoryMatchingSucceedBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020451 RID: 132177 RVA: 0x0047D861 File Offset: 0x0047BA61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020452 RID: 132178 RVA: 0x0047D870 File Offset: 0x0047BA70
		public ICategoryMatchingSucceedBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170092EB RID: 37611
		// (get) Token: 0x06020453 RID: 132179 RVA: 0x0047D880 File Offset: 0x0047BA80
		public bool IsSilent
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170092EC RID: 37612
		// (get) Token: 0x06020454 RID: 132180 RVA: 0x0047D8C0 File Offset: 0x0047BAC0
		public bool IsDestroy
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170092ED RID: 37613
		// (get) Token: 0x06020455 RID: 132181 RVA: 0x0047D900 File Offset: 0x0047BB00
		public bool SyncAdsorbatePerformance
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170092EE RID: 37614
		// (get) Token: 0x06020456 RID: 132182 RVA: 0x0047D940 File Offset: 0x0047BB40
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

		// Token: 0x06020457 RID: 132183 RVA: 0x0047D978 File Offset: 0x0047BB78
		public Span<byte> GetChangeSelfStateBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06020458 RID: 132184 RVA: 0x0047D988 File Offset: 0x0047BB88
		public byte[] GetChangeSelfStateArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x170092EF RID: 37615
		// (get) Token: 0x06020459 RID: 132185 RVA: 0x0047D998 File Offset: 0x0047BB98
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

		// Token: 0x170092F0 RID: 37616
		// (get) Token: 0x0602045A RID: 132186 RVA: 0x0047D9F8 File Offset: 0x0047BBF8
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

		// Token: 0x170092F1 RID: 37617
		// (get) Token: 0x0602045B RID: 132187 RVA: 0x0047DA38 File Offset: 0x0047BC38
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

		// Token: 0x170092F2 RID: 37618
		// (get) Token: 0x0602045C RID: 132188 RVA: 0x0047DA98 File Offset: 0x0047BC98
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

		// Token: 0x0602045D RID: 132189 RVA: 0x0047DAD0 File Offset: 0x0047BCD0
		public Span<byte> GetChangeSelfStateAfterDischargedBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0602045E RID: 132190 RVA: 0x0047DAE0 File Offset: 0x0047BCE0
		public byte[] GetChangeSelfStateAfterDischargedArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x170092F3 RID: 37619
		// (get) Token: 0x0602045F RID: 132191 RVA: 0x0047DAF0 File Offset: 0x0047BCF0
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

		// Token: 0x06020460 RID: 132192 RVA: 0x0047DB30 File Offset: 0x0047BD30
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

		// Token: 0x06020461 RID: 132193 RVA: 0x0047DB90 File Offset: 0x0047BD90
		public static void StartICategoryMatchingSucceedBase(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06020462 RID: 132194 RVA: 0x0047DB9A File Offset: 0x0047BD9A
		public static void AddIsSilent(FlatBufferBuilder builder, bool isSilent)
		{
			builder.AddBool(0, isSilent, false);
		}

		// Token: 0x06020463 RID: 132195 RVA: 0x0047DBA5 File Offset: 0x0047BDA5
		public static void AddIsDestroy(FlatBufferBuilder builder, bool isDestroy)
		{
			builder.AddBool(1, isDestroy, false);
		}

		// Token: 0x06020464 RID: 132196 RVA: 0x0047DBB0 File Offset: 0x0047BDB0
		public static void AddSyncAdsorbatePerformance(FlatBufferBuilder builder, bool syncAdsorbatePerformance)
		{
			builder.AddBool(2, syncAdsorbatePerformance, false);
		}

		// Token: 0x06020465 RID: 132197 RVA: 0x0047DBBB File Offset: 0x0047BDBB
		public static void AddChangeSelfState(FlatBufferBuilder builder, StringOffset changeSelfStateOffset)
		{
			builder.AddOffset(3, changeSelfStateOffset.Value, 0);
		}

		// Token: 0x06020466 RID: 132198 RVA: 0x0047DBCB File Offset: 0x0047BDCB
		public static void AddChangeItemState(FlatBufferBuilder builder, Offset<IEntityState> changeItemStateOffset)
		{
			builder.AddOffset(4, changeItemStateOffset.Value, 0);
		}

		// Token: 0x06020467 RID: 132199 RVA: 0x0047DBDB File Offset: 0x0047BDDB
		public static void AddDelayDischarge(FlatBufferBuilder builder, int delayDischarge)
		{
			builder.AddInt(5, delayDischarge, 0);
		}

		// Token: 0x06020468 RID: 132200 RVA: 0x0047DBE6 File Offset: 0x0047BDE6
		public static void AddChangeItemStateAfterDischarged(FlatBufferBuilder builder, Offset<IEntityState> changeItemStateAfterDischargedOffset)
		{
			builder.AddOffset(6, changeItemStateAfterDischargedOffset.Value, 0);
		}

		// Token: 0x06020469 RID: 132201 RVA: 0x0047DBF6 File Offset: 0x0047BDF6
		public static void AddChangeSelfStateAfterDischarged(FlatBufferBuilder builder, StringOffset changeSelfStateAfterDischargedOffset)
		{
			builder.AddOffset(7, changeSelfStateAfterDischargedOffset.Value, 0);
		}

		// Token: 0x0602046A RID: 132202 RVA: 0x0047DC06 File Offset: 0x0047BE06
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x0602046B RID: 132203 RVA: 0x0047DC11 File Offset: 0x0047BE11
		public static Offset<ICategoryMatchingSucceedBase> EndICategoryMatchingSucceedBase(FlatBufferBuilder builder)
		{
			return new Offset<ICategoryMatchingSucceedBase>(builder.EndTable());
		}

		// Token: 0x0602046C RID: 132204 RVA: 0x0047DC20 File Offset: 0x0047BE20
		public ICategoryMatchingSucceedBaseT UnPack()
		{
			ICategoryMatchingSucceedBaseT categoryMatchingSucceedBaseT = new ICategoryMatchingSucceedBaseT();
			this.UnPackTo(categoryMatchingSucceedBaseT);
			return categoryMatchingSucceedBaseT;
		}

		// Token: 0x0602046D RID: 132205 RVA: 0x0047DC3C File Offset: 0x0047BE3C
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

		// Token: 0x0602046E RID: 132206 RVA: 0x0047DCFC File Offset: 0x0047BEFC
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

		// Token: 0x0400DE0F RID: 56847
		private Table __p;
	}
}
