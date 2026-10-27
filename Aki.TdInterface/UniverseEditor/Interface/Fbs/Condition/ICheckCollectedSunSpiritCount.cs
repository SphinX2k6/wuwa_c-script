using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049A6 RID: 18854
	public struct ICheckCollectedSunSpiritCount : IFlatbufferObject
	{
		// Token: 0x17008846 RID: 34886
		// (get) Token: 0x0601D6B4 RID: 120500 RVA: 0x004254CE File Offset: 0x004236CE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D6B5 RID: 120501 RVA: 0x004254DB File Offset: 0x004236DB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D6B6 RID: 120502 RVA: 0x004254E4 File Offset: 0x004236E4
		public static ICheckCollectedSunSpiritCount GetRootAsICheckCollectedSunSpiritCount(ByteBuffer _bb)
		{
			return ICheckCollectedSunSpiritCount.GetRootAsICheckCollectedSunSpiritCount(_bb, default(ICheckCollectedSunSpiritCount));
		}

		// Token: 0x0601D6B7 RID: 120503 RVA: 0x00425500 File Offset: 0x00423700
		public static ICheckCollectedSunSpiritCount GetRootAsICheckCollectedSunSpiritCount(ByteBuffer _bb, ICheckCollectedSunSpiritCount obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D6B8 RID: 120504 RVA: 0x0042551D File Offset: 0x0042371D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D6B9 RID: 120505 RVA: 0x0042552C File Offset: 0x0042372C
		public ICheckCollectedSunSpiritCount __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008847 RID: 34887
		// (get) Token: 0x0601D6BA RID: 120506 RVA: 0x0042553C File Offset: 0x0042373C
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

		// Token: 0x17008848 RID: 34888
		// (get) Token: 0x0601D6BB RID: 120507 RVA: 0x00425578 File Offset: 0x00423778
		public int DungeonId
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

		// Token: 0x17008849 RID: 34889
		// (get) Token: 0x0601D6BC RID: 120508 RVA: 0x004255B4 File Offset: 0x004237B4
		public int AreaId
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

		// Token: 0x1700884A RID: 34890
		// (get) Token: 0x0601D6BD RID: 120509 RVA: 0x004255F0 File Offset: 0x004237F0
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700884B RID: 34891
		// (get) Token: 0x0601D6BE RID: 120510 RVA: 0x00425630 File Offset: 0x00423830
		public int Count
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

		// Token: 0x1700884C RID: 34892
		// (get) Token: 0x0601D6BF RID: 120511 RVA: 0x00425670 File Offset: 0x00423870
		public TOnlinePlayerConditionTarget OnlinePlayerConditionTargetOptionType
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return TOnlinePlayerConditionTarget.NONE;
				}
				return (TOnlinePlayerConditionTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D6C0 RID: 120512 RVA: 0x004256B0 File Offset: 0x004238B0
		public TTable? OnlinePlayerConditionTargetOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601D6C1 RID: 120513 RVA: 0x004256F8 File Offset: 0x004238F8
		public IOnlinePlayerConditionTargetHost OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetHost()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>().Value;
		}

		// Token: 0x0601D6C2 RID: 120514 RVA: 0x00425714 File Offset: 0x00423914
		public IOnlinePlayerConditionTargetParticipator OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetParticipator()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>().Value;
		}

		// Token: 0x0601D6C3 RID: 120515 RVA: 0x00425730 File Offset: 0x00423930
		public static Offset<ICheckCollectedSunSpiritCount> CreateICheckCollectedSunSpiritCount(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int DungeonId = 0, int AreaId = 0, ECompare Compare = ECompare.Eq, int Count = 0, TOnlinePlayerConditionTarget OnlinePlayerConditionTargetOption_type = TOnlinePlayerConditionTarget.NONE, int OnlinePlayerConditionTargetOptionOffset = 0)
		{
			builder.StartTable(7);
			ICheckCollectedSunSpiritCount.AddOnlinePlayerConditionTargetOption(builder, OnlinePlayerConditionTargetOptionOffset);
			ICheckCollectedSunSpiritCount.AddCount(builder, Count);
			ICheckCollectedSunSpiritCount.AddAreaId(builder, AreaId);
			ICheckCollectedSunSpiritCount.AddDungeonId(builder, DungeonId);
			ICheckCollectedSunSpiritCount.AddOnlinePlayerConditionTargetOptionType(builder, OnlinePlayerConditionTargetOption_type);
			ICheckCollectedSunSpiritCount.AddCompare(builder, Compare);
			ICheckCollectedSunSpiritCount.AddType(builder, Type);
			return ICheckCollectedSunSpiritCount.EndICheckCollectedSunSpiritCount(builder);
		}

		// Token: 0x0601D6C4 RID: 120516 RVA: 0x0042577F File Offset: 0x0042397F
		public static void StartICheckCollectedSunSpiritCount(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601D6C5 RID: 120517 RVA: 0x00425788 File Offset: 0x00423988
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D6C6 RID: 120518 RVA: 0x00425793 File Offset: 0x00423993
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(1, dungeonId, 0);
		}

		// Token: 0x0601D6C7 RID: 120519 RVA: 0x0042579E File Offset: 0x0042399E
		public static void AddAreaId(FlatBufferBuilder builder, int areaId)
		{
			builder.AddInt(2, areaId, 0);
		}

		// Token: 0x0601D6C8 RID: 120520 RVA: 0x004257A9 File Offset: 0x004239A9
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(3, (byte)compare, 0);
		}

		// Token: 0x0601D6C9 RID: 120521 RVA: 0x004257B4 File Offset: 0x004239B4
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(4, count, 0);
		}

		// Token: 0x0601D6CA RID: 120522 RVA: 0x004257BF File Offset: 0x004239BF
		public static void AddOnlinePlayerConditionTargetOptionType(FlatBufferBuilder builder, TOnlinePlayerConditionTarget onlinePlayerConditionTargetOptionType)
		{
			builder.AddByte(5, (byte)onlinePlayerConditionTargetOptionType, 0);
		}

		// Token: 0x0601D6CB RID: 120523 RVA: 0x004257CA File Offset: 0x004239CA
		public static void AddOnlinePlayerConditionTargetOption(FlatBufferBuilder builder, int onlinePlayerConditionTargetOptionOffset)
		{
			builder.AddOffset(6, onlinePlayerConditionTargetOptionOffset, 0);
		}

		// Token: 0x0601D6CC RID: 120524 RVA: 0x004257D5 File Offset: 0x004239D5
		public static Offset<ICheckCollectedSunSpiritCount> EndICheckCollectedSunSpiritCount(FlatBufferBuilder builder)
		{
			return new Offset<ICheckCollectedSunSpiritCount>(builder.EndTable());
		}

		// Token: 0x0601D6CD RID: 120525 RVA: 0x004257E4 File Offset: 0x004239E4
		public ICheckCollectedSunSpiritCountT UnPack()
		{
			ICheckCollectedSunSpiritCountT checkCollectedSunSpiritCountT = new ICheckCollectedSunSpiritCountT();
			this.UnPackTo(checkCollectedSunSpiritCountT);
			return checkCollectedSunSpiritCountT;
		}

		// Token: 0x0601D6CE RID: 120526 RVA: 0x00425800 File Offset: 0x00423A00
		public void UnPackTo(ICheckCollectedSunSpiritCountT _o)
		{
			_o.Type = this.Type;
			_o.DungeonId = this.DungeonId;
			_o.AreaId = this.AreaId;
			_o.Compare = this.Compare;
			_o.Count = this.Count;
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

		// Token: 0x0601D6CF RID: 120527 RVA: 0x004258E0 File Offset: 0x00423AE0
		public static Offset<ICheckCollectedSunSpiritCount> Pack(FlatBufferBuilder builder, ICheckCollectedSunSpiritCountT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckCollectedSunSpiritCount>);
			}
			TOnlinePlayerConditionTarget onlinePlayerConditionTargetOption_type = (_o.OnlinePlayerConditionTargetOption == null) ? TOnlinePlayerConditionTarget.NONE : _o.OnlinePlayerConditionTargetOption.Type;
			int onlinePlayerConditionTargetOptionOffset = (_o.OnlinePlayerConditionTargetOption == null) ? 0 : TOnlinePlayerConditionTargetUnion.Pack(builder, _o.OnlinePlayerConditionTargetOption);
			return ICheckCollectedSunSpiritCount.CreateICheckCollectedSunSpiritCount(builder, _o.Type, _o.DungeonId, _o.AreaId, _o.Compare, _o.Count, onlinePlayerConditionTargetOption_type, onlinePlayerConditionTargetOptionOffset);
		}

		// Token: 0x0400D1C2 RID: 53698
		private Table __p;
	}
}
