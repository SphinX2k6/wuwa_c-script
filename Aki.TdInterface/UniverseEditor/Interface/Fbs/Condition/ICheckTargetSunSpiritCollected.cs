using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B50 RID: 19280
	public struct ICheckTargetSunSpiritCollected : IFlatbufferObject
	{
		// Token: 0x17008BDC RID: 35804
		// (get) Token: 0x0601E5C3 RID: 124355 RVA: 0x00440F68 File Offset: 0x0043F168
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E5C4 RID: 124356 RVA: 0x00440F75 File Offset: 0x0043F175
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E5C5 RID: 124357 RVA: 0x00440F7C File Offset: 0x0043F17C
		public static ICheckTargetSunSpiritCollected GetRootAsICheckTargetSunSpiritCollected(ByteBuffer _bb)
		{
			return ICheckTargetSunSpiritCollected.GetRootAsICheckTargetSunSpiritCollected(_bb, default(ICheckTargetSunSpiritCollected));
		}

		// Token: 0x0601E5C6 RID: 124358 RVA: 0x00440F98 File Offset: 0x0043F198
		public static ICheckTargetSunSpiritCollected GetRootAsICheckTargetSunSpiritCollected(ByteBuffer _bb, ICheckTargetSunSpiritCollected obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E5C7 RID: 124359 RVA: 0x00440FB5 File Offset: 0x0043F1B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E5C8 RID: 124360 RVA: 0x00440FC4 File Offset: 0x0043F1C4
		public ICheckTargetSunSpiritCollected __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008BDD RID: 35805
		// (get) Token: 0x0601E5C9 RID: 124361 RVA: 0x00440FD4 File Offset: 0x0043F1D4
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

		// Token: 0x17008BDE RID: 35806
		// (get) Token: 0x0601E5CA RID: 124362 RVA: 0x00441010 File Offset: 0x0043F210
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

		// Token: 0x17008BDF RID: 35807
		// (get) Token: 0x0601E5CB RID: 124363 RVA: 0x0044104C File Offset: 0x0043F24C
		public int SunSpiritEntityId
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

		// Token: 0x17008BE0 RID: 35808
		// (get) Token: 0x0601E5CC RID: 124364 RVA: 0x00441088 File Offset: 0x0043F288
		public bool IsCollected
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008BE1 RID: 35809
		// (get) Token: 0x0601E5CD RID: 124365 RVA: 0x004410C8 File Offset: 0x0043F2C8
		public TOnlinePlayerConditionTarget OnlinePlayerConditionTargetOptionType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return TOnlinePlayerConditionTarget.NONE;
				}
				return (TOnlinePlayerConditionTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E5CE RID: 124366 RVA: 0x00441108 File Offset: 0x0043F308
		public TTable? OnlinePlayerConditionTargetOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601E5CF RID: 124367 RVA: 0x00441150 File Offset: 0x0043F350
		public IOnlinePlayerConditionTargetHost OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetHost()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>().Value;
		}

		// Token: 0x0601E5D0 RID: 124368 RVA: 0x0044116C File Offset: 0x0043F36C
		public IOnlinePlayerConditionTargetParticipator OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetParticipator()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>().Value;
		}

		// Token: 0x0601E5D1 RID: 124369 RVA: 0x00441187 File Offset: 0x0043F387
		public static Offset<ICheckTargetSunSpiritCollected> CreateICheckTargetSunSpiritCollected(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int DungeonId = 0, int SunSpiritEntityId = 0, bool IsCollected = false, TOnlinePlayerConditionTarget OnlinePlayerConditionTargetOption_type = TOnlinePlayerConditionTarget.NONE, int OnlinePlayerConditionTargetOptionOffset = 0)
		{
			builder.StartTable(6);
			ICheckTargetSunSpiritCollected.AddOnlinePlayerConditionTargetOption(builder, OnlinePlayerConditionTargetOptionOffset);
			ICheckTargetSunSpiritCollected.AddSunSpiritEntityId(builder, SunSpiritEntityId);
			ICheckTargetSunSpiritCollected.AddDungeonId(builder, DungeonId);
			ICheckTargetSunSpiritCollected.AddOnlinePlayerConditionTargetOptionType(builder, OnlinePlayerConditionTargetOption_type);
			ICheckTargetSunSpiritCollected.AddIsCollected(builder, IsCollected);
			ICheckTargetSunSpiritCollected.AddType(builder, Type);
			return ICheckTargetSunSpiritCollected.EndICheckTargetSunSpiritCollected(builder);
		}

		// Token: 0x0601E5D2 RID: 124370 RVA: 0x004411C3 File Offset: 0x0043F3C3
		public static void StartICheckTargetSunSpiritCollected(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601E5D3 RID: 124371 RVA: 0x004411CC File Offset: 0x0043F3CC
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E5D4 RID: 124372 RVA: 0x004411D7 File Offset: 0x0043F3D7
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(1, dungeonId, 0);
		}

		// Token: 0x0601E5D5 RID: 124373 RVA: 0x004411E2 File Offset: 0x0043F3E2
		public static void AddSunSpiritEntityId(FlatBufferBuilder builder, int sunSpiritEntityId)
		{
			builder.AddInt(2, sunSpiritEntityId, 0);
		}

		// Token: 0x0601E5D6 RID: 124374 RVA: 0x004411ED File Offset: 0x0043F3ED
		public static void AddIsCollected(FlatBufferBuilder builder, bool isCollected)
		{
			builder.AddBool(3, isCollected, false);
		}

		// Token: 0x0601E5D7 RID: 124375 RVA: 0x004411F8 File Offset: 0x0043F3F8
		public static void AddOnlinePlayerConditionTargetOptionType(FlatBufferBuilder builder, TOnlinePlayerConditionTarget onlinePlayerConditionTargetOptionType)
		{
			builder.AddByte(4, (byte)onlinePlayerConditionTargetOptionType, 0);
		}

		// Token: 0x0601E5D8 RID: 124376 RVA: 0x00441203 File Offset: 0x0043F403
		public static void AddOnlinePlayerConditionTargetOption(FlatBufferBuilder builder, int onlinePlayerConditionTargetOptionOffset)
		{
			builder.AddOffset(5, onlinePlayerConditionTargetOptionOffset, 0);
		}

		// Token: 0x0601E5D9 RID: 124377 RVA: 0x0044120E File Offset: 0x0043F40E
		public static Offset<ICheckTargetSunSpiritCollected> EndICheckTargetSunSpiritCollected(FlatBufferBuilder builder)
		{
			return new Offset<ICheckTargetSunSpiritCollected>(builder.EndTable());
		}

		// Token: 0x0601E5DA RID: 124378 RVA: 0x0044121C File Offset: 0x0043F41C
		public ICheckTargetSunSpiritCollectedT UnPack()
		{
			ICheckTargetSunSpiritCollectedT checkTargetSunSpiritCollectedT = new ICheckTargetSunSpiritCollectedT();
			this.UnPackTo(checkTargetSunSpiritCollectedT);
			return checkTargetSunSpiritCollectedT;
		}

		// Token: 0x0601E5DB RID: 124379 RVA: 0x00441238 File Offset: 0x0043F438
		public void UnPackTo(ICheckTargetSunSpiritCollectedT _o)
		{
			_o.Type = this.Type;
			_o.DungeonId = this.DungeonId;
			_o.SunSpiritEntityId = this.SunSpiritEntityId;
			_o.IsCollected = this.IsCollected;
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

		// Token: 0x0601E5DC RID: 124380 RVA: 0x0044130C File Offset: 0x0043F50C
		public static Offset<ICheckTargetSunSpiritCollected> Pack(FlatBufferBuilder builder, ICheckTargetSunSpiritCollectedT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckTargetSunSpiritCollected>);
			}
			TOnlinePlayerConditionTarget onlinePlayerConditionTargetOption_type = (_o.OnlinePlayerConditionTargetOption == null) ? TOnlinePlayerConditionTarget.NONE : _o.OnlinePlayerConditionTargetOption.Type;
			int onlinePlayerConditionTargetOptionOffset = (_o.OnlinePlayerConditionTargetOption == null) ? 0 : TOnlinePlayerConditionTargetUnion.Pack(builder, _o.OnlinePlayerConditionTargetOption);
			return ICheckTargetSunSpiritCollected.CreateICheckTargetSunSpiritCollected(builder, _o.Type, _o.DungeonId, _o.SunSpiritEntityId, _o.IsCollected, onlinePlayerConditionTargetOption_type, onlinePlayerConditionTargetOptionOffset);
		}

		// Token: 0x0400D40C RID: 54284
		private Table __p;
	}
}
