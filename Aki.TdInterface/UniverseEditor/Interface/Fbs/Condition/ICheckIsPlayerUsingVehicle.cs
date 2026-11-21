using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F65 RID: 20325
	public struct ICheckIsPlayerUsingVehicle : IFlatbufferObject
	{
		// Token: 0x1700913F RID: 37183
		// (get) Token: 0x0601FA0D RID: 129549 RVA: 0x00465F6D File Offset: 0x0046416D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FA0E RID: 129550 RVA: 0x00465F7A File Offset: 0x0046417A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FA0F RID: 129551 RVA: 0x00465F84 File Offset: 0x00464184
		public static ICheckIsPlayerUsingVehicle GetRootAsICheckIsPlayerUsingVehicle(ByteBuffer _bb)
		{
			return ICheckIsPlayerUsingVehicle.GetRootAsICheckIsPlayerUsingVehicle(_bb, default(ICheckIsPlayerUsingVehicle));
		}

		// Token: 0x0601FA10 RID: 129552 RVA: 0x00465FA0 File Offset: 0x004641A0
		public static ICheckIsPlayerUsingVehicle GetRootAsICheckIsPlayerUsingVehicle(ByteBuffer _bb, ICheckIsPlayerUsingVehicle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FA11 RID: 129553 RVA: 0x00465FBD File Offset: 0x004641BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FA12 RID: 129554 RVA: 0x00465FCC File Offset: 0x004641CC
		public ICheckIsPlayerUsingVehicle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009140 RID: 37184
		// (get) Token: 0x0601FA13 RID: 129555 RVA: 0x00465FDC File Offset: 0x004641DC
		public EVehicleConditionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVehicleConditionType.UsingVehicle;
				}
				return (EVehicleConditionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009141 RID: 37185
		// (get) Token: 0x0601FA14 RID: 129556 RVA: 0x00466018 File Offset: 0x00464218
		public EVehicleType VehicleType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EVehicleType.Gongduola;
				}
				return (EVehicleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009142 RID: 37186
		// (get) Token: 0x0601FA15 RID: 129557 RVA: 0x00466054 File Offset: 0x00464254
		public bool CheckType
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009143 RID: 37187
		// (get) Token: 0x0601FA16 RID: 129558 RVA: 0x00466094 File Offset: 0x00464294
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

		// Token: 0x0601FA17 RID: 129559 RVA: 0x004660D4 File Offset: 0x004642D4
		public TTable? OnlinePlayerConditionTargetOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601FA18 RID: 129560 RVA: 0x0046611C File Offset: 0x0046431C
		public IOnlinePlayerConditionTargetHost OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetHost()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>().Value;
		}

		// Token: 0x0601FA19 RID: 129561 RVA: 0x00466138 File Offset: 0x00464338
		public IOnlinePlayerConditionTargetParticipator OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetParticipator()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>().Value;
		}

		// Token: 0x17009144 RID: 37188
		// (get) Token: 0x0601FA1A RID: 129562 RVA: 0x00466154 File Offset: 0x00464354
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601FA1B RID: 129563 RVA: 0x00466191 File Offset: 0x00464391
		public static Offset<ICheckIsPlayerUsingVehicle> CreateICheckIsPlayerUsingVehicle(FlatBufferBuilder builder, EVehicleConditionType Type = EVehicleConditionType.UsingVehicle, EVehicleType VehicleType = EVehicleType.Gongduola, bool CheckType = false, TOnlinePlayerConditionTarget OnlinePlayerConditionTargetOption_type = TOnlinePlayerConditionTarget.NONE, int OnlinePlayerConditionTargetOptionOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(6);
			ICheckIsPlayerUsingVehicle.AddOnlinePlayerConditionTargetOption(builder, OnlinePlayerConditionTargetOptionOffset);
			ICheckIsPlayerUsingVehicle.AddNullMask(builder, NullMask);
			ICheckIsPlayerUsingVehicle.AddOnlinePlayerConditionTargetOptionType(builder, OnlinePlayerConditionTargetOption_type);
			ICheckIsPlayerUsingVehicle.AddCheckType(builder, CheckType);
			ICheckIsPlayerUsingVehicle.AddVehicleType(builder, VehicleType);
			ICheckIsPlayerUsingVehicle.AddType(builder, Type);
			return ICheckIsPlayerUsingVehicle.EndICheckIsPlayerUsingVehicle(builder);
		}

		// Token: 0x0601FA1C RID: 129564 RVA: 0x004661CD File Offset: 0x004643CD
		public static void StartICheckIsPlayerUsingVehicle(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601FA1D RID: 129565 RVA: 0x004661D6 File Offset: 0x004643D6
		public static void AddType(FlatBufferBuilder builder, EVehicleConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FA1E RID: 129566 RVA: 0x004661E1 File Offset: 0x004643E1
		public static void AddVehicleType(FlatBufferBuilder builder, EVehicleType vehicleType)
		{
			builder.AddByte(1, (byte)vehicleType, 0);
		}

		// Token: 0x0601FA1F RID: 129567 RVA: 0x004661EC File Offset: 0x004643EC
		public static void AddCheckType(FlatBufferBuilder builder, bool checkType)
		{
			builder.AddBool(2, checkType, false);
		}

		// Token: 0x0601FA20 RID: 129568 RVA: 0x004661F7 File Offset: 0x004643F7
		public static void AddOnlinePlayerConditionTargetOptionType(FlatBufferBuilder builder, TOnlinePlayerConditionTarget onlinePlayerConditionTargetOptionType)
		{
			builder.AddByte(3, (byte)onlinePlayerConditionTargetOptionType, 0);
		}

		// Token: 0x0601FA21 RID: 129569 RVA: 0x00466202 File Offset: 0x00464402
		public static void AddOnlinePlayerConditionTargetOption(FlatBufferBuilder builder, int onlinePlayerConditionTargetOptionOffset)
		{
			builder.AddOffset(4, onlinePlayerConditionTargetOptionOffset, 0);
		}

		// Token: 0x0601FA22 RID: 129570 RVA: 0x0046620D File Offset: 0x0046440D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0601FA23 RID: 129571 RVA: 0x00466218 File Offset: 0x00464418
		public static Offset<ICheckIsPlayerUsingVehicle> EndICheckIsPlayerUsingVehicle(FlatBufferBuilder builder)
		{
			return new Offset<ICheckIsPlayerUsingVehicle>(builder.EndTable());
		}

		// Token: 0x0601FA24 RID: 129572 RVA: 0x00466228 File Offset: 0x00464428
		public ICheckIsPlayerUsingVehicleT UnPack()
		{
			ICheckIsPlayerUsingVehicleT checkIsPlayerUsingVehicleT = new ICheckIsPlayerUsingVehicleT();
			this.UnPackTo(checkIsPlayerUsingVehicleT);
			return checkIsPlayerUsingVehicleT;
		}

		// Token: 0x0601FA25 RID: 129573 RVA: 0x00466244 File Offset: 0x00464444
		public void UnPackTo(ICheckIsPlayerUsingVehicleT _o)
		{
			_o.Type = this.Type;
			_o.VehicleType = this.VehicleType;
			_o.CheckType = this.CheckType;
			_o.OnlinePlayerConditionTargetOption = new TOnlinePlayerConditionTargetUnion();
			_o.OnlinePlayerConditionTargetOption.Type = this.OnlinePlayerConditionTargetOptionType;
			TOnlinePlayerConditionTarget onlinePlayerConditionTargetOptionType = this.OnlinePlayerConditionTargetOptionType;
			if (onlinePlayerConditionTargetOptionType != TOnlinePlayerConditionTarget.IOnlinePlayerConditionTargetHost)
			{
				if (onlinePlayerConditionTargetOptionType == TOnlinePlayerConditionTarget.IOnlinePlayerConditionTargetParticipator)
				{
					_o.OnlinePlayerConditionTargetOption.Value = ((this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>() != null) ? this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.OnlinePlayerConditionTargetOption.Value = ((this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>() != null) ? this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>().Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601FA26 RID: 129574 RVA: 0x0046631C File Offset: 0x0046451C
		public static Offset<ICheckIsPlayerUsingVehicle> Pack(FlatBufferBuilder builder, ICheckIsPlayerUsingVehicleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckIsPlayerUsingVehicle>);
			}
			TOnlinePlayerConditionTarget onlinePlayerConditionTargetOption_type = (_o.OnlinePlayerConditionTargetOption == null) ? TOnlinePlayerConditionTarget.NONE : _o.OnlinePlayerConditionTargetOption.Type;
			int onlinePlayerConditionTargetOptionOffset = (_o.OnlinePlayerConditionTargetOption == null) ? 0 : TOnlinePlayerConditionTargetUnion.Pack(builder, _o.OnlinePlayerConditionTargetOption);
			return ICheckIsPlayerUsingVehicle.CreateICheckIsPlayerUsingVehicle(builder, _o.Type, _o.VehicleType, _o.CheckType, onlinePlayerConditionTargetOption_type, onlinePlayerConditionTargetOptionOffset, _o.NullMask);
		}

		// Token: 0x0400DDEA RID: 56810
		private Table __p;
	}
}
