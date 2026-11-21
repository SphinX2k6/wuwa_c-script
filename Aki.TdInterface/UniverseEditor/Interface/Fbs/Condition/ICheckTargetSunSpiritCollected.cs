using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005037 RID: 20535
	public struct ICheckTargetSunSpiritCollected : IFlatbufferObject
	{
		// Token: 0x170092EC RID: 37612
		// (get) Token: 0x06020151 RID: 131409 RVA: 0x004737B4 File Offset: 0x004719B4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020152 RID: 131410 RVA: 0x004737C1 File Offset: 0x004719C1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020153 RID: 131411 RVA: 0x004737C8 File Offset: 0x004719C8
		public static ICheckTargetSunSpiritCollected GetRootAsICheckTargetSunSpiritCollected(ByteBuffer _bb)
		{
			return ICheckTargetSunSpiritCollected.GetRootAsICheckTargetSunSpiritCollected(_bb, default(ICheckTargetSunSpiritCollected));
		}

		// Token: 0x06020154 RID: 131412 RVA: 0x004737E4 File Offset: 0x004719E4
		public static ICheckTargetSunSpiritCollected GetRootAsICheckTargetSunSpiritCollected(ByteBuffer _bb, ICheckTargetSunSpiritCollected obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020155 RID: 131413 RVA: 0x00473801 File Offset: 0x00471A01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020156 RID: 131414 RVA: 0x00473810 File Offset: 0x00471A10
		public ICheckTargetSunSpiritCollected __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170092ED RID: 37613
		// (get) Token: 0x06020157 RID: 131415 RVA: 0x00473820 File Offset: 0x00471A20
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

		// Token: 0x170092EE RID: 37614
		// (get) Token: 0x06020158 RID: 131416 RVA: 0x0047385C File Offset: 0x00471A5C
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

		// Token: 0x170092EF RID: 37615
		// (get) Token: 0x06020159 RID: 131417 RVA: 0x00473898 File Offset: 0x00471A98
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

		// Token: 0x170092F0 RID: 37616
		// (get) Token: 0x0602015A RID: 131418 RVA: 0x004738D4 File Offset: 0x00471AD4
		public bool IsCollected
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170092F1 RID: 37617
		// (get) Token: 0x0602015B RID: 131419 RVA: 0x00473914 File Offset: 0x00471B14
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

		// Token: 0x0602015C RID: 131420 RVA: 0x00473954 File Offset: 0x00471B54
		public TTable? OnlinePlayerConditionTargetOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602015D RID: 131421 RVA: 0x0047399C File Offset: 0x00471B9C
		public IOnlinePlayerConditionTargetHost OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetHost()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>().Value;
		}

		// Token: 0x0602015E RID: 131422 RVA: 0x004739B8 File Offset: 0x00471BB8
		public IOnlinePlayerConditionTargetParticipator OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetParticipator()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>().Value;
		}

		// Token: 0x0602015F RID: 131423 RVA: 0x004739D3 File Offset: 0x00471BD3
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

		// Token: 0x06020160 RID: 131424 RVA: 0x00473A0F File Offset: 0x00471C0F
		public static void StartICheckTargetSunSpiritCollected(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06020161 RID: 131425 RVA: 0x00473A18 File Offset: 0x00471C18
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020162 RID: 131426 RVA: 0x00473A23 File Offset: 0x00471C23
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(1, dungeonId, 0);
		}

		// Token: 0x06020163 RID: 131427 RVA: 0x00473A2E File Offset: 0x00471C2E
		public static void AddSunSpiritEntityId(FlatBufferBuilder builder, int sunSpiritEntityId)
		{
			builder.AddInt(2, sunSpiritEntityId, 0);
		}

		// Token: 0x06020164 RID: 131428 RVA: 0x00473A39 File Offset: 0x00471C39
		public static void AddIsCollected(FlatBufferBuilder builder, bool isCollected)
		{
			builder.AddBool(3, isCollected, false);
		}

		// Token: 0x06020165 RID: 131429 RVA: 0x00473A44 File Offset: 0x00471C44
		public static void AddOnlinePlayerConditionTargetOptionType(FlatBufferBuilder builder, TOnlinePlayerConditionTarget onlinePlayerConditionTargetOptionType)
		{
			builder.AddByte(4, (byte)onlinePlayerConditionTargetOptionType, 0);
		}

		// Token: 0x06020166 RID: 131430 RVA: 0x00473A4F File Offset: 0x00471C4F
		public static void AddOnlinePlayerConditionTargetOption(FlatBufferBuilder builder, int onlinePlayerConditionTargetOptionOffset)
		{
			builder.AddOffset(5, onlinePlayerConditionTargetOptionOffset, 0);
		}

		// Token: 0x06020167 RID: 131431 RVA: 0x00473A5A File Offset: 0x00471C5A
		public static Offset<ICheckTargetSunSpiritCollected> EndICheckTargetSunSpiritCollected(FlatBufferBuilder builder)
		{
			return new Offset<ICheckTargetSunSpiritCollected>(builder.EndTable());
		}

		// Token: 0x06020168 RID: 131432 RVA: 0x00473A68 File Offset: 0x00471C68
		public ICheckTargetSunSpiritCollectedT UnPack()
		{
			ICheckTargetSunSpiritCollectedT checkTargetSunSpiritCollectedT = new ICheckTargetSunSpiritCollectedT();
			this.UnPackTo(checkTargetSunSpiritCollectedT);
			return checkTargetSunSpiritCollectedT;
		}

		// Token: 0x06020169 RID: 131433 RVA: 0x00473A84 File Offset: 0x00471C84
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

		// Token: 0x0602016A RID: 131434 RVA: 0x00473B58 File Offset: 0x00471D58
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

		// Token: 0x0400DF0C RID: 57100
		private Table __p;
	}
}
