using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006145 RID: 24901
	public struct IVehicleTypedMotorConfig : IFlatbufferObject
	{
		// Token: 0x1700B977 RID: 47479
		// (get) Token: 0x0602A40E RID: 173070 RVA: 0x005C4006 File Offset: 0x005C2206
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A40F RID: 173071 RVA: 0x005C4013 File Offset: 0x005C2213
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A410 RID: 173072 RVA: 0x005C401C File Offset: 0x005C221C
		public static IVehicleTypedMotorConfig GetRootAsIVehicleTypedMotorConfig(ByteBuffer _bb)
		{
			return IVehicleTypedMotorConfig.GetRootAsIVehicleTypedMotorConfig(_bb, default(IVehicleTypedMotorConfig));
		}

		// Token: 0x0602A411 RID: 173073 RVA: 0x005C4038 File Offset: 0x005C2238
		public static IVehicleTypedMotorConfig GetRootAsIVehicleTypedMotorConfig(ByteBuffer _bb, IVehicleTypedMotorConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A412 RID: 173074 RVA: 0x005C4055 File Offset: 0x005C2255
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A413 RID: 173075 RVA: 0x005C4064 File Offset: 0x005C2264
		public IVehicleTypedMotorConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B978 RID: 47480
		// (get) Token: 0x0602A414 RID: 173076 RVA: 0x005C4074 File Offset: 0x005C2274
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

		// Token: 0x1700B979 RID: 47481
		// (get) Token: 0x0602A415 RID: 173077 RVA: 0x005C40B0 File Offset: 0x005C22B0
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

		// Token: 0x1700B97A RID: 47482
		// (get) Token: 0x0602A416 RID: 173078 RVA: 0x005C40EC File Offset: 0x005C22EC
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

		// Token: 0x0602A417 RID: 173079 RVA: 0x005C4128 File Offset: 0x005C2328
		public static Offset<IVehicleTypedMotorConfig> CreateIVehicleTypedMotorConfig(FlatBufferBuilder builder, EVehicleType Type = EVehicleType.Gongduola, int TrialAttributeId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IVehicleTypedMotorConfig.AddTrialAttributeId(builder, TrialAttributeId);
			IVehicleTypedMotorConfig.AddNullMask(builder, NullMask);
			IVehicleTypedMotorConfig.AddType(builder, Type);
			return IVehicleTypedMotorConfig.EndIVehicleTypedMotorConfig(builder);
		}

		// Token: 0x0602A418 RID: 173080 RVA: 0x005C414C File Offset: 0x005C234C
		public static void StartIVehicleTypedMotorConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602A419 RID: 173081 RVA: 0x005C4155 File Offset: 0x005C2355
		public static void AddType(FlatBufferBuilder builder, EVehicleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A41A RID: 173082 RVA: 0x005C4160 File Offset: 0x005C2360
		public static void AddTrialAttributeId(FlatBufferBuilder builder, int trialAttributeId)
		{
			builder.AddInt(1, trialAttributeId, 0);
		}

		// Token: 0x0602A41B RID: 173083 RVA: 0x005C416B File Offset: 0x005C236B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602A41C RID: 173084 RVA: 0x005C4176 File Offset: 0x005C2376
		public static Offset<IVehicleTypedMotorConfig> EndIVehicleTypedMotorConfig(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleTypedMotorConfig>(builder.EndTable());
		}

		// Token: 0x0602A41D RID: 173085 RVA: 0x005C4184 File Offset: 0x005C2384
		public IVehicleTypedMotorConfigT UnPack()
		{
			IVehicleTypedMotorConfigT vehicleTypedMotorConfigT = new IVehicleTypedMotorConfigT();
			this.UnPackTo(vehicleTypedMotorConfigT);
			return vehicleTypedMotorConfigT;
		}

		// Token: 0x0602A41E RID: 173086 RVA: 0x005C419F File Offset: 0x005C239F
		public void UnPackTo(IVehicleTypedMotorConfigT _o)
		{
			_o.Type = this.Type;
			_o.TrialAttributeId = this.TrialAttributeId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602A41F RID: 173087 RVA: 0x005C41C8 File Offset: 0x005C23C8
		public static Offset<IVehicleTypedMotorConfig> Pack(FlatBufferBuilder builder, IVehicleTypedMotorConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleTypedMotorConfig>);
			}
			return IVehicleTypedMotorConfig.CreateIVehicleTypedMotorConfig(builder, _o.Type, _o.TrialAttributeId, _o.NullMask);
		}

		// Token: 0x0400FF5A RID: 65370
		private Table __p;
	}
}
