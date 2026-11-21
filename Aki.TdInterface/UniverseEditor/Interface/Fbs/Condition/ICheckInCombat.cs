using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F38 RID: 20280
	public struct ICheckInCombat : IFlatbufferObject
	{
		// Token: 0x170090E2 RID: 37090
		// (get) Token: 0x0601F879 RID: 129145 RVA: 0x00463144 File Offset: 0x00461344
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F87A RID: 129146 RVA: 0x00463151 File Offset: 0x00461351
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F87B RID: 129147 RVA: 0x00463158 File Offset: 0x00461358
		public static ICheckInCombat GetRootAsICheckInCombat(ByteBuffer _bb)
		{
			return ICheckInCombat.GetRootAsICheckInCombat(_bb, default(ICheckInCombat));
		}

		// Token: 0x0601F87C RID: 129148 RVA: 0x00463174 File Offset: 0x00461374
		public static ICheckInCombat GetRootAsICheckInCombat(ByteBuffer _bb, ICheckInCombat obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F87D RID: 129149 RVA: 0x00463191 File Offset: 0x00461391
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F87E RID: 129150 RVA: 0x004631A0 File Offset: 0x004613A0
		public ICheckInCombat __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170090E3 RID: 37091
		// (get) Token: 0x0601F87F RID: 129151 RVA: 0x004631B0 File Offset: 0x004613B0
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

		// Token: 0x170090E4 RID: 37092
		// (get) Token: 0x0601F880 RID: 129152 RVA: 0x004631EC File Offset: 0x004613EC
		public bool InCombat
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170090E5 RID: 37093
		// (get) Token: 0x0601F881 RID: 129153 RVA: 0x0046322C File Offset: 0x0046142C
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

		// Token: 0x0601F882 RID: 129154 RVA: 0x00463268 File Offset: 0x00461468
		public TTable? OnlinePlayerConditionTargetOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601F883 RID: 129155 RVA: 0x004632B0 File Offset: 0x004614B0
		public IOnlinePlayerConditionTargetHost OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetHost()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>().Value;
		}

		// Token: 0x0601F884 RID: 129156 RVA: 0x004632CC File Offset: 0x004614CC
		public IOnlinePlayerConditionTargetParticipator OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetParticipator()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>().Value;
		}

		// Token: 0x0601F885 RID: 129157 RVA: 0x004632E7 File Offset: 0x004614E7
		public static Offset<ICheckInCombat> CreateICheckInCombat(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, bool InCombat = false, TOnlinePlayerConditionTarget OnlinePlayerConditionTargetOption_type = TOnlinePlayerConditionTarget.NONE, int OnlinePlayerConditionTargetOptionOffset = 0)
		{
			builder.StartTable(4);
			ICheckInCombat.AddOnlinePlayerConditionTargetOption(builder, OnlinePlayerConditionTargetOptionOffset);
			ICheckInCombat.AddOnlinePlayerConditionTargetOptionType(builder, OnlinePlayerConditionTargetOption_type);
			ICheckInCombat.AddInCombat(builder, InCombat);
			ICheckInCombat.AddType(builder, Type);
			return ICheckInCombat.EndICheckInCombat(builder);
		}

		// Token: 0x0601F886 RID: 129158 RVA: 0x00463313 File Offset: 0x00461513
		public static void StartICheckInCombat(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601F887 RID: 129159 RVA: 0x0046331C File Offset: 0x0046151C
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F888 RID: 129160 RVA: 0x00463327 File Offset: 0x00461527
		public static void AddInCombat(FlatBufferBuilder builder, bool inCombat)
		{
			builder.AddBool(1, inCombat, false);
		}

		// Token: 0x0601F889 RID: 129161 RVA: 0x00463332 File Offset: 0x00461532
		public static void AddOnlinePlayerConditionTargetOptionType(FlatBufferBuilder builder, TOnlinePlayerConditionTarget onlinePlayerConditionTargetOptionType)
		{
			builder.AddByte(2, (byte)onlinePlayerConditionTargetOptionType, 0);
		}

		// Token: 0x0601F88A RID: 129162 RVA: 0x0046333D File Offset: 0x0046153D
		public static void AddOnlinePlayerConditionTargetOption(FlatBufferBuilder builder, int onlinePlayerConditionTargetOptionOffset)
		{
			builder.AddOffset(3, onlinePlayerConditionTargetOptionOffset, 0);
		}

		// Token: 0x0601F88B RID: 129163 RVA: 0x00463348 File Offset: 0x00461548
		public static Offset<ICheckInCombat> EndICheckInCombat(FlatBufferBuilder builder)
		{
			return new Offset<ICheckInCombat>(builder.EndTable());
		}

		// Token: 0x0601F88C RID: 129164 RVA: 0x00463358 File Offset: 0x00461558
		public ICheckInCombatT UnPack()
		{
			ICheckInCombatT checkInCombatT = new ICheckInCombatT();
			this.UnPackTo(checkInCombatT);
			return checkInCombatT;
		}

		// Token: 0x0601F88D RID: 129165 RVA: 0x00463374 File Offset: 0x00461574
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

		// Token: 0x0601F88E RID: 129166 RVA: 0x00463430 File Offset: 0x00461630
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

		// Token: 0x0400DDB4 RID: 56756
		private Table __p;
	}
}
