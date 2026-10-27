using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A99 RID: 19097
	public struct ICheckIsPlayerUsingVehicle : IFlatbufferObject
	{
		// Token: 0x17008A59 RID: 35417
		// (get) Token: 0x0601DF3E RID: 122686 RVA: 0x004349E1 File Offset: 0x00432BE1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DF3F RID: 122687 RVA: 0x004349EE File Offset: 0x00432BEE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DF40 RID: 122688 RVA: 0x004349F8 File Offset: 0x00432BF8
		public static ICheckIsPlayerUsingVehicle GetRootAsICheckIsPlayerUsingVehicle(ByteBuffer _bb)
		{
			return ICheckIsPlayerUsingVehicle.GetRootAsICheckIsPlayerUsingVehicle(_bb, default(ICheckIsPlayerUsingVehicle));
		}

		// Token: 0x0601DF41 RID: 122689 RVA: 0x00434A14 File Offset: 0x00432C14
		public static ICheckIsPlayerUsingVehicle GetRootAsICheckIsPlayerUsingVehicle(ByteBuffer _bb, ICheckIsPlayerUsingVehicle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DF42 RID: 122690 RVA: 0x00434A31 File Offset: 0x00432C31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DF43 RID: 122691 RVA: 0x00434A40 File Offset: 0x00432C40
		public ICheckIsPlayerUsingVehicle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008A5A RID: 35418
		// (get) Token: 0x0601DF44 RID: 122692 RVA: 0x00434A50 File Offset: 0x00432C50
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

		// Token: 0x17008A5B RID: 35419
		// (get) Token: 0x0601DF45 RID: 122693 RVA: 0x00434A8C File Offset: 0x00432C8C
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

		// Token: 0x17008A5C RID: 35420
		// (get) Token: 0x0601DF46 RID: 122694 RVA: 0x00434AC8 File Offset: 0x00432CC8
		public bool CheckType
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008A5D RID: 35421
		// (get) Token: 0x0601DF47 RID: 122695 RVA: 0x00434B08 File Offset: 0x00432D08
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

		// Token: 0x0601DF48 RID: 122696 RVA: 0x00434B48 File Offset: 0x00432D48
		public TTable? OnlinePlayerConditionTargetOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601DF49 RID: 122697 RVA: 0x00434B90 File Offset: 0x00432D90
		public IOnlinePlayerConditionTargetHost OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetHost()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>().Value;
		}

		// Token: 0x0601DF4A RID: 122698 RVA: 0x00434BAC File Offset: 0x00432DAC
		public IOnlinePlayerConditionTargetParticipator OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetParticipator()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>().Value;
		}

		// Token: 0x17008A5E RID: 35422
		// (get) Token: 0x0601DF4B RID: 122699 RVA: 0x00434BC8 File Offset: 0x00432DC8
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

		// Token: 0x0601DF4C RID: 122700 RVA: 0x00434C05 File Offset: 0x00432E05
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

		// Token: 0x0601DF4D RID: 122701 RVA: 0x00434C41 File Offset: 0x00432E41
		public static void StartICheckIsPlayerUsingVehicle(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601DF4E RID: 122702 RVA: 0x00434C4A File Offset: 0x00432E4A
		public static void AddType(FlatBufferBuilder builder, EVehicleConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DF4F RID: 122703 RVA: 0x00434C55 File Offset: 0x00432E55
		public static void AddVehicleType(FlatBufferBuilder builder, EVehicleType vehicleType)
		{
			builder.AddByte(1, (byte)vehicleType, 0);
		}

		// Token: 0x0601DF50 RID: 122704 RVA: 0x00434C60 File Offset: 0x00432E60
		public static void AddCheckType(FlatBufferBuilder builder, bool checkType)
		{
			builder.AddBool(2, checkType, false);
		}

		// Token: 0x0601DF51 RID: 122705 RVA: 0x00434C6B File Offset: 0x00432E6B
		public static void AddOnlinePlayerConditionTargetOptionType(FlatBufferBuilder builder, TOnlinePlayerConditionTarget onlinePlayerConditionTargetOptionType)
		{
			builder.AddByte(3, (byte)onlinePlayerConditionTargetOptionType, 0);
		}

		// Token: 0x0601DF52 RID: 122706 RVA: 0x00434C76 File Offset: 0x00432E76
		public static void AddOnlinePlayerConditionTargetOption(FlatBufferBuilder builder, int onlinePlayerConditionTargetOptionOffset)
		{
			builder.AddOffset(4, onlinePlayerConditionTargetOptionOffset, 0);
		}

		// Token: 0x0601DF53 RID: 122707 RVA: 0x00434C81 File Offset: 0x00432E81
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0601DF54 RID: 122708 RVA: 0x00434C8C File Offset: 0x00432E8C
		public static Offset<ICheckIsPlayerUsingVehicle> EndICheckIsPlayerUsingVehicle(FlatBufferBuilder builder)
		{
			return new Offset<ICheckIsPlayerUsingVehicle>(builder.EndTable());
		}

		// Token: 0x0601DF55 RID: 122709 RVA: 0x00434C9C File Offset: 0x00432E9C
		public ICheckIsPlayerUsingVehicleT UnPack()
		{
			ICheckIsPlayerUsingVehicleT checkIsPlayerUsingVehicleT = new ICheckIsPlayerUsingVehicleT();
			this.UnPackTo(checkIsPlayerUsingVehicleT);
			return checkIsPlayerUsingVehicleT;
		}

		// Token: 0x0601DF56 RID: 122710 RVA: 0x00434CB8 File Offset: 0x00432EB8
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

		// Token: 0x0601DF57 RID: 122711 RVA: 0x00434D90 File Offset: 0x00432F90
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

		// Token: 0x0400D309 RID: 54025
		private Table __p;
	}
}
