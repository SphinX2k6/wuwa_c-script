using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049B2 RID: 18866
	public struct ICheckCurrentRole : IFlatbufferObject
	{
		// Token: 0x1700886A RID: 34922
		// (get) Token: 0x0601D730 RID: 120624 RVA: 0x004262C0 File Offset: 0x004244C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D731 RID: 120625 RVA: 0x004262CD File Offset: 0x004244CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D732 RID: 120626 RVA: 0x004262D4 File Offset: 0x004244D4
		public static ICheckCurrentRole GetRootAsICheckCurrentRole(ByteBuffer _bb)
		{
			return ICheckCurrentRole.GetRootAsICheckCurrentRole(_bb, default(ICheckCurrentRole));
		}

		// Token: 0x0601D733 RID: 120627 RVA: 0x004262F0 File Offset: 0x004244F0
		public static ICheckCurrentRole GetRootAsICheckCurrentRole(ByteBuffer _bb, ICheckCurrentRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D734 RID: 120628 RVA: 0x0042630D File Offset: 0x0042450D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D735 RID: 120629 RVA: 0x0042631C File Offset: 0x0042451C
		public ICheckCurrentRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700886B RID: 34923
		// (get) Token: 0x0601D736 RID: 120630 RVA: 0x0042632C File Offset: 0x0042452C
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700886C RID: 34924
		// (get) Token: 0x0601D737 RID: 120631 RVA: 0x00426368 File Offset: 0x00424568
		public int RoleId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700886D RID: 34925
		// (get) Token: 0x0601D738 RID: 120632 RVA: 0x004263A4 File Offset: 0x004245A4
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700886E RID: 34926
		// (get) Token: 0x0601D739 RID: 120633 RVA: 0x004263E0 File Offset: 0x004245E0
		public TOnlinePlayerConditionTarget OnlinePlayerConditionTargetOptionType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TOnlinePlayerConditionTarget.NONE;
				}
				return (TOnlinePlayerConditionTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D73A RID: 120634 RVA: 0x00426420 File Offset: 0x00424620
		public TTable? OnlinePlayerConditionTargetOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601D73B RID: 120635 RVA: 0x00426468 File Offset: 0x00424668
		public IOnlinePlayerConditionTargetHost OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetHost()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>().Value;
		}

		// Token: 0x0601D73C RID: 120636 RVA: 0x00426484 File Offset: 0x00424684
		public IOnlinePlayerConditionTargetParticipator OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetParticipator()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>().Value;
		}

		// Token: 0x0601D73D RID: 120637 RVA: 0x0042649F File Offset: 0x0042469F
		public static Offset<ICheckCurrentRole> CreateICheckCurrentRole(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int RoleId = 0, ECompare Compare = ECompare.Eq, TOnlinePlayerConditionTarget OnlinePlayerConditionTargetOption_type = TOnlinePlayerConditionTarget.NONE, int OnlinePlayerConditionTargetOptionOffset = 0)
		{
			builder.StartTable(5);
			ICheckCurrentRole.AddOnlinePlayerConditionTargetOption(builder, OnlinePlayerConditionTargetOptionOffset);
			ICheckCurrentRole.AddRoleId(builder, RoleId);
			ICheckCurrentRole.AddOnlinePlayerConditionTargetOptionType(builder, OnlinePlayerConditionTargetOption_type);
			ICheckCurrentRole.AddCompare(builder, Compare);
			ICheckCurrentRole.AddType(builder, Type);
			return ICheckCurrentRole.EndICheckCurrentRole(builder);
		}

		// Token: 0x0601D73E RID: 120638 RVA: 0x004264D3 File Offset: 0x004246D3
		public static void StartICheckCurrentRole(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601D73F RID: 120639 RVA: 0x004264DC File Offset: 0x004246DC
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D740 RID: 120640 RVA: 0x004264E7 File Offset: 0x004246E7
		public static void AddRoleId(FlatBufferBuilder builder, int roleId)
		{
			builder.AddInt(1, roleId, 0);
		}

		// Token: 0x0601D741 RID: 120641 RVA: 0x004264F2 File Offset: 0x004246F2
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x0601D742 RID: 120642 RVA: 0x004264FD File Offset: 0x004246FD
		public static void AddOnlinePlayerConditionTargetOptionType(FlatBufferBuilder builder, TOnlinePlayerConditionTarget onlinePlayerConditionTargetOptionType)
		{
			builder.AddByte(3, (byte)onlinePlayerConditionTargetOptionType, 0);
		}

		// Token: 0x0601D743 RID: 120643 RVA: 0x00426508 File Offset: 0x00424708
		public static void AddOnlinePlayerConditionTargetOption(FlatBufferBuilder builder, int onlinePlayerConditionTargetOptionOffset)
		{
			builder.AddOffset(4, onlinePlayerConditionTargetOptionOffset, 0);
		}

		// Token: 0x0601D744 RID: 120644 RVA: 0x00426513 File Offset: 0x00424713
		public static Offset<ICheckCurrentRole> EndICheckCurrentRole(FlatBufferBuilder builder)
		{
			return new Offset<ICheckCurrentRole>(builder.EndTable());
		}

		// Token: 0x0601D745 RID: 120645 RVA: 0x00426520 File Offset: 0x00424720
		public ICheckCurrentRoleT UnPack()
		{
			ICheckCurrentRoleT checkCurrentRoleT = new ICheckCurrentRoleT();
			this.UnPackTo(checkCurrentRoleT);
			return checkCurrentRoleT;
		}

		// Token: 0x0601D746 RID: 120646 RVA: 0x0042653C File Offset: 0x0042473C
		public void UnPackTo(ICheckCurrentRoleT _o)
		{
			_o.Type = this.Type;
			_o.RoleId = this.RoleId;
			_o.Compare = this.Compare;
			_o.OnlinePlayerConditionTargetOption = new TOnlinePlayerConditionTargetUnion();
			_o.OnlinePlayerConditionTargetOption.Type = this.OnlinePlayerConditionTargetOptionType;
			TOnlinePlayerConditionTarget onlinePlayerConditionTargetOptionType = this.OnlinePlayerConditionTargetOptionType;
			if (onlinePlayerConditionTargetOptionType == TOnlinePlayerConditionTarget.IOnlinePlayerConditionTargetHost)
			{
				_o.OnlinePlayerConditionTargetOption.Value = ((this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>() != null) ? this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>().Value.UnPack() : null);
				return;
			}
			if (onlinePlayerConditionTargetOptionType != TOnlinePlayerConditionTarget.IOnlinePlayerConditionTargetParticipator)
			{
				return;
			}
			_o.OnlinePlayerConditionTargetOption.Value = ((this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>() != null) ? this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>().Value.UnPack() : null);
		}

		// Token: 0x0601D747 RID: 120647 RVA: 0x00426604 File Offset: 0x00424804
		public static Offset<ICheckCurrentRole> Pack(FlatBufferBuilder builder, ICheckCurrentRoleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckCurrentRole>);
			}
			TOnlinePlayerConditionTarget onlinePlayerConditionTargetOption_type = (_o.OnlinePlayerConditionTargetOption == null) ? TOnlinePlayerConditionTarget.NONE : _o.OnlinePlayerConditionTargetOption.Type;
			int onlinePlayerConditionTargetOptionOffset = (_o.OnlinePlayerConditionTargetOption == null) ? 0 : TOnlinePlayerConditionTargetUnion.Pack(builder, _o.OnlinePlayerConditionTargetOption);
			return ICheckCurrentRole.CreateICheckCurrentRole(builder, _o.Type, _o.RoleId, _o.Compare, onlinePlayerConditionTargetOption_type, onlinePlayerConditionTargetOptionOffset);
		}

		// Token: 0x0400D1D6 RID: 53718
		private Table __p;
	}
}
