using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A72 RID: 19058
	public struct ICheckInCombat : IFlatbufferObject
	{
		// Token: 0x17008A06 RID: 35334
		// (get) Token: 0x0601DDD6 RID: 122326 RVA: 0x00431FB8 File Offset: 0x004301B8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DDD7 RID: 122327 RVA: 0x00431FC5 File Offset: 0x004301C5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DDD8 RID: 122328 RVA: 0x00431FCC File Offset: 0x004301CC
		public static ICheckInCombat GetRootAsICheckInCombat(ByteBuffer _bb)
		{
			return ICheckInCombat.GetRootAsICheckInCombat(_bb, default(ICheckInCombat));
		}

		// Token: 0x0601DDD9 RID: 122329 RVA: 0x00431FE8 File Offset: 0x004301E8
		public static ICheckInCombat GetRootAsICheckInCombat(ByteBuffer _bb, ICheckInCombat obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DDDA RID: 122330 RVA: 0x00432005 File Offset: 0x00430205
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DDDB RID: 122331 RVA: 0x00432014 File Offset: 0x00430214
		public ICheckInCombat __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008A07 RID: 35335
		// (get) Token: 0x0601DDDC RID: 122332 RVA: 0x00432024 File Offset: 0x00430224
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

		// Token: 0x17008A08 RID: 35336
		// (get) Token: 0x0601DDDD RID: 122333 RVA: 0x00432060 File Offset: 0x00430260
		public bool InCombat
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008A09 RID: 35337
		// (get) Token: 0x0601DDDE RID: 122334 RVA: 0x004320A0 File Offset: 0x004302A0
		public TOnlinePlayerConditionTarget OnlinePlayerConditionTargetOptionType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TOnlinePlayerConditionTarget.NONE;
				}
				return (TOnlinePlayerConditionTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601DDDF RID: 122335 RVA: 0x004320DC File Offset: 0x004302DC
		public TTable? OnlinePlayerConditionTargetOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601DDE0 RID: 122336 RVA: 0x00432124 File Offset: 0x00430324
		public IOnlinePlayerConditionTargetHost OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetHost()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>().Value;
		}

		// Token: 0x0601DDE1 RID: 122337 RVA: 0x00432140 File Offset: 0x00430340
		public IOnlinePlayerConditionTargetParticipator OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetParticipator()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>().Value;
		}

		// Token: 0x0601DDE2 RID: 122338 RVA: 0x0043215B File Offset: 0x0043035B
		public static Offset<ICheckInCombat> CreateICheckInCombat(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, bool InCombat = false, TOnlinePlayerConditionTarget OnlinePlayerConditionTargetOption_type = TOnlinePlayerConditionTarget.NONE, int OnlinePlayerConditionTargetOptionOffset = 0)
		{
			builder.StartTable(4);
			ICheckInCombat.AddOnlinePlayerConditionTargetOption(builder, OnlinePlayerConditionTargetOptionOffset);
			ICheckInCombat.AddOnlinePlayerConditionTargetOptionType(builder, OnlinePlayerConditionTargetOption_type);
			ICheckInCombat.AddInCombat(builder, InCombat);
			ICheckInCombat.AddType(builder, Type);
			return ICheckInCombat.EndICheckInCombat(builder);
		}

		// Token: 0x0601DDE3 RID: 122339 RVA: 0x00432187 File Offset: 0x00430387
		public static void StartICheckInCombat(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601DDE4 RID: 122340 RVA: 0x00432190 File Offset: 0x00430390
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DDE5 RID: 122341 RVA: 0x0043219B File Offset: 0x0043039B
		public static void AddInCombat(FlatBufferBuilder builder, bool inCombat)
		{
			builder.AddBool(1, inCombat, false);
		}

		// Token: 0x0601DDE6 RID: 122342 RVA: 0x004321A6 File Offset: 0x004303A6
		public static void AddOnlinePlayerConditionTargetOptionType(FlatBufferBuilder builder, TOnlinePlayerConditionTarget onlinePlayerConditionTargetOptionType)
		{
			builder.AddByte(2, (byte)onlinePlayerConditionTargetOptionType, 0);
		}

		// Token: 0x0601DDE7 RID: 122343 RVA: 0x004321B1 File Offset: 0x004303B1
		public static void AddOnlinePlayerConditionTargetOption(FlatBufferBuilder builder, int onlinePlayerConditionTargetOptionOffset)
		{
			builder.AddOffset(3, onlinePlayerConditionTargetOptionOffset, 0);
		}

		// Token: 0x0601DDE8 RID: 122344 RVA: 0x004321BC File Offset: 0x004303BC
		public static Offset<ICheckInCombat> EndICheckInCombat(FlatBufferBuilder builder)
		{
			return new Offset<ICheckInCombat>(builder.EndTable());
		}

		// Token: 0x0601DDE9 RID: 122345 RVA: 0x004321CC File Offset: 0x004303CC
		public ICheckInCombatT UnPack()
		{
			ICheckInCombatT checkInCombatT = new ICheckInCombatT();
			this.UnPackTo(checkInCombatT);
			return checkInCombatT;
		}

		// Token: 0x0601DDEA RID: 122346 RVA: 0x004321E8 File Offset: 0x004303E8
		public void UnPackTo(ICheckInCombatT _o)
		{
			_o.Type = this.Type;
			_o.InCombat = this.InCombat;
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

		// Token: 0x0601DDEB RID: 122347 RVA: 0x004322A4 File Offset: 0x004304A4
		public static Offset<ICheckInCombat> Pack(FlatBufferBuilder builder, ICheckInCombatT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckInCombat>);
			}
			TOnlinePlayerConditionTarget onlinePlayerConditionTargetOption_type = (_o.OnlinePlayerConditionTargetOption == null) ? TOnlinePlayerConditionTarget.NONE : _o.OnlinePlayerConditionTargetOption.Type;
			int onlinePlayerConditionTargetOptionOffset = (_o.OnlinePlayerConditionTargetOption == null) ? 0 : TOnlinePlayerConditionTargetUnion.Pack(builder, _o.OnlinePlayerConditionTargetOption);
			return ICheckInCombat.CreateICheckInCombat(builder, _o.Type, _o.InCombat, onlinePlayerConditionTargetOption_type, onlinePlayerConditionTargetOptionOffset);
		}

		// Token: 0x0400D2D9 RID: 53977
		private Table __p;
	}
}
