using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B2F RID: 23343
	public struct IVehicleTypedMotorConfig : IFlatbufferObject
	{
		// Token: 0x1700B02F RID: 45103
		// (get) Token: 0x06027E4A RID: 163402 RVA: 0x0057C5B2 File Offset: 0x0057A7B2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027E4B RID: 163403 RVA: 0x0057C5BF File Offset: 0x0057A7BF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027E4C RID: 163404 RVA: 0x0057C5C8 File Offset: 0x0057A7C8
		public static IVehicleTypedMotorConfig GetRootAsIVehicleTypedMotorConfig(ByteBuffer _bb)
		{
			return IVehicleTypedMotorConfig.GetRootAsIVehicleTypedMotorConfig(_bb, default(IVehicleTypedMotorConfig));
		}

		// Token: 0x06027E4D RID: 163405 RVA: 0x0057C5E4 File Offset: 0x0057A7E4
		public static IVehicleTypedMotorConfig GetRootAsIVehicleTypedMotorConfig(ByteBuffer _bb, IVehicleTypedMotorConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027E4E RID: 163406 RVA: 0x0057C601 File Offset: 0x0057A801
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027E4F RID: 163407 RVA: 0x0057C610 File Offset: 0x0057A810
		public IVehicleTypedMotorConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B030 RID: 45104
		// (get) Token: 0x06027E50 RID: 163408 RVA: 0x0057C620 File Offset: 0x0057A820
		public EVehicleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVehicleType.Gongduola;
				}
				return (EVehicleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B031 RID: 45105
		// (get) Token: 0x06027E51 RID: 163409 RVA: 0x0057C65C File Offset: 0x0057A85C
		public int TrialAttributeId
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

		// Token: 0x1700B032 RID: 45106
		// (get) Token: 0x06027E52 RID: 163410 RVA: 0x0057C698 File Offset: 0x0057A898
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027E53 RID: 163411 RVA: 0x0057C6D4 File Offset: 0x0057A8D4
		public static Offset<IVehicleTypedMotorConfig> CreateIVehicleTypedMotorConfig(FlatBufferBuilder builder, EVehicleType Type = EVehicleType.Gongduola, int TrialAttributeId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IVehicleTypedMotorConfig.AddTrialAttributeId(builder, TrialAttributeId);
			IVehicleTypedMotorConfig.AddNullMask(builder, NullMask);
			IVehicleTypedMotorConfig.AddType(builder, Type);
			return IVehicleTypedMotorConfig.EndIVehicleTypedMotorConfig(builder);
		}

		// Token: 0x06027E54 RID: 163412 RVA: 0x0057C6F8 File Offset: 0x0057A8F8
		public static void StartIVehicleTypedMotorConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06027E55 RID: 163413 RVA: 0x0057C701 File Offset: 0x0057A901
		public static void AddType(FlatBufferBuilder builder, EVehicleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027E56 RID: 163414 RVA: 0x0057C70C File Offset: 0x0057A90C
		public static void AddTrialAttributeId(FlatBufferBuilder builder, int trialAttributeId)
		{
			builder.AddInt(1, trialAttributeId, 0);
		}

		// Token: 0x06027E57 RID: 163415 RVA: 0x0057C717 File Offset: 0x0057A917
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06027E58 RID: 163416 RVA: 0x0057C722 File Offset: 0x0057A922
		public static Offset<IVehicleTypedMotorConfig> EndIVehicleTypedMotorConfig(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleTypedMotorConfig>(builder.EndTable());
		}

		// Token: 0x06027E59 RID: 163417 RVA: 0x0057C730 File Offset: 0x0057A930
		public IVehicleTypedMotorConfigT UnPack()
		{
			IVehicleTypedMotorConfigT vehicleTypedMotorConfigT = new IVehicleTypedMotorConfigT();
			this.UnPackTo(vehicleTypedMotorConfigT);
			return vehicleTypedMotorConfigT;
		}

		// Token: 0x06027E5A RID: 163418 RVA: 0x0057C74B File Offset: 0x0057A94B
		public void UnPackTo(IVehicleTypedMotorConfigT _o)
		{
			_o.Type = this.Type;
			_o.TrialAttributeId = this.TrialAttributeId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06027E5B RID: 163419 RVA: 0x0057C774 File Offset: 0x0057A974
		public static Offset<IVehicleTypedMotorConfig> Pack(FlatBufferBuilder builder, IVehicleTypedMotorConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleTypedMotorConfig>);
			}
			return IVehicleTypedMotorConfig.CreateIVehicleTypedMotorConfig(builder, _o.Type, _o.TrialAttributeId, _o.NullMask);
		}

		// Token: 0x0400F254 RID: 62036
		private Table __p;
	}
}
