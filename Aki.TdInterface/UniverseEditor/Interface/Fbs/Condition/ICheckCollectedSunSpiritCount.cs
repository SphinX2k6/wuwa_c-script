using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E5D RID: 20061
	public struct ICheckCollectedSunSpiritCount : IFlatbufferObject
	{
		// Token: 0x17008F01 RID: 36609
		// (get) Token: 0x0601F0D9 RID: 127193 RVA: 0x00455982 File Offset: 0x00453B82
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F0DA RID: 127194 RVA: 0x0045598F File Offset: 0x00453B8F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F0DB RID: 127195 RVA: 0x00455998 File Offset: 0x00453B98
		public static ICheckCollectedSunSpiritCount GetRootAsICheckCollectedSunSpiritCount(ByteBuffer _bb)
		{
			return ICheckCollectedSunSpiritCount.GetRootAsICheckCollectedSunSpiritCount(_bb, default(ICheckCollectedSunSpiritCount));
		}

		// Token: 0x0601F0DC RID: 127196 RVA: 0x004559B4 File Offset: 0x00453BB4
		public static ICheckCollectedSunSpiritCount GetRootAsICheckCollectedSunSpiritCount(ByteBuffer _bb, ICheckCollectedSunSpiritCount obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F0DD RID: 127197 RVA: 0x004559D1 File Offset: 0x00453BD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F0DE RID: 127198 RVA: 0x004559E0 File Offset: 0x00453BE0
		public ICheckCollectedSunSpiritCount __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008F02 RID: 36610
		// (get) Token: 0x0601F0DF RID: 127199 RVA: 0x004559F0 File Offset: 0x00453BF0
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

		// Token: 0x17008F03 RID: 36611
		// (get) Token: 0x0601F0E0 RID: 127200 RVA: 0x00455A2C File Offset: 0x00453C2C
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

		// Token: 0x17008F04 RID: 36612
		// (get) Token: 0x0601F0E1 RID: 127201 RVA: 0x00455A68 File Offset: 0x00453C68
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

		// Token: 0x17008F05 RID: 36613
		// (get) Token: 0x0601F0E2 RID: 127202 RVA: 0x00455AA4 File Offset: 0x00453CA4
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

		// Token: 0x17008F06 RID: 36614
		// (get) Token: 0x0601F0E3 RID: 127203 RVA: 0x00455AE4 File Offset: 0x00453CE4
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

		// Token: 0x17008F07 RID: 36615
		// (get) Token: 0x0601F0E4 RID: 127204 RVA: 0x00455B24 File Offset: 0x00453D24
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

		// Token: 0x0601F0E5 RID: 127205 RVA: 0x00455B64 File Offset: 0x00453D64
		public TTable? OnlinePlayerConditionTargetOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601F0E6 RID: 127206 RVA: 0x00455BAC File Offset: 0x00453DAC
		public IOnlinePlayerConditionTargetHost OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetHost()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>().Value;
		}

		// Token: 0x0601F0E7 RID: 127207 RVA: 0x00455BC8 File Offset: 0x00453DC8
		public IOnlinePlayerConditionTargetParticipator OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetParticipator()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>().Value;
		}

		// Token: 0x0601F0E8 RID: 127208 RVA: 0x00455BE4 File Offset: 0x00453DE4
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

		// Token: 0x0601F0E9 RID: 127209 RVA: 0x00455C33 File Offset: 0x00453E33
		public static void StartICheckCollectedSunSpiritCount(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601F0EA RID: 127210 RVA: 0x00455C3C File Offset: 0x00453E3C
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F0EB RID: 127211 RVA: 0x00455C47 File Offset: 0x00453E47
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(1, dungeonId, 0);
		}

		// Token: 0x0601F0EC RID: 127212 RVA: 0x00455C52 File Offset: 0x00453E52
		public static void AddAreaId(FlatBufferBuilder builder, int areaId)
		{
			builder.AddInt(2, areaId, 0);
		}

		// Token: 0x0601F0ED RID: 127213 RVA: 0x00455C5D File Offset: 0x00453E5D
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(3, (byte)compare, 0);
		}

		// Token: 0x0601F0EE RID: 127214 RVA: 0x00455C68 File Offset: 0x00453E68
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(4, count, 0);
		}

		// Token: 0x0601F0EF RID: 127215 RVA: 0x00455C73 File Offset: 0x00453E73
		public static void AddOnlinePlayerConditionTargetOptionType(FlatBufferBuilder builder, TOnlinePlayerConditionTarget onlinePlayerConditionTargetOptionType)
		{
			builder.AddByte(5, (byte)onlinePlayerConditionTargetOptionType, 0);
		}

		// Token: 0x0601F0F0 RID: 127216 RVA: 0x00455C7E File Offset: 0x00453E7E
		public static void AddOnlinePlayerConditionTargetOption(FlatBufferBuilder builder, int onlinePlayerConditionTargetOptionOffset)
		{
			builder.AddOffset(6, onlinePlayerConditionTargetOptionOffset, 0);
		}

		// Token: 0x0601F0F1 RID: 127217 RVA: 0x00455C89 File Offset: 0x00453E89
		public static Offset<ICheckCollectedSunSpiritCount> EndICheckCollectedSunSpiritCount(FlatBufferBuilder builder)
		{
			return new Offset<ICheckCollectedSunSpiritCount>(builder.EndTable());
		}

		// Token: 0x0601F0F2 RID: 127218 RVA: 0x00455C98 File Offset: 0x00453E98
		public ICheckCollectedSunSpiritCountT UnPack()
		{
			ICheckCollectedSunSpiritCountT checkCollectedSunSpiritCountT = new ICheckCollectedSunSpiritCountT();
			this.UnPackTo(checkCollectedSunSpiritCountT);
			return checkCollectedSunSpiritCountT;
		}

		// Token: 0x0601F0F3 RID: 127219 RVA: 0x00455CB4 File Offset: 0x00453EB4
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

		// Token: 0x0601F0F4 RID: 127220 RVA: 0x00455D94 File Offset: 0x00453F94
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

		// Token: 0x0400DC8A RID: 56458
		private Table __p;
	}
}
