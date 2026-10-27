using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B29 RID: 23337
	public struct IVehicleTypedConfig : IFlatbufferObject
	{
		// Token: 0x1700B02A RID: 45098
		// (get) Token: 0x06027E2C RID: 163372 RVA: 0x0057C33E File Offset: 0x0057A53E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027E2D RID: 163373 RVA: 0x0057C34B File Offset: 0x0057A54B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027E2E RID: 163374 RVA: 0x0057C354 File Offset: 0x0057A554
		public static IVehicleTypedConfig GetRootAsIVehicleTypedConfig(ByteBuffer _bb)
		{
			return IVehicleTypedConfig.GetRootAsIVehicleTypedConfig(_bb, default(IVehicleTypedConfig));
		}

		// Token: 0x06027E2F RID: 163375 RVA: 0x0057C370 File Offset: 0x0057A570
		public static IVehicleTypedConfig GetRootAsIVehicleTypedConfig(ByteBuffer _bb, IVehicleTypedConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027E30 RID: 163376 RVA: 0x0057C38D File Offset: 0x0057A58D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027E31 RID: 163377 RVA: 0x0057C39C File Offset: 0x0057A59C
		public IVehicleTypedConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B02B RID: 45099
		// (get) Token: 0x06027E32 RID: 163378 RVA: 0x0057C3AC File Offset: 0x0057A5AC
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

		// Token: 0x06027E33 RID: 163379 RVA: 0x0057C3E8 File Offset: 0x0057A5E8
		public static Offset<IVehicleTypedConfig> CreateIVehicleTypedConfig(FlatBufferBuilder builder, EVehicleType Type = EVehicleType.Gongduola)
		{
			builder.StartTable(1);
			IVehicleTypedConfig.AddType(builder, Type);
			return IVehicleTypedConfig.EndIVehicleTypedConfig(builder);
		}

		// Token: 0x06027E34 RID: 163380 RVA: 0x0057C3FE File Offset: 0x0057A5FE
		public static void StartIVehicleTypedConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06027E35 RID: 163381 RVA: 0x0057C407 File Offset: 0x0057A607
		public static void AddType(FlatBufferBuilder builder, EVehicleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027E36 RID: 163382 RVA: 0x0057C412 File Offset: 0x0057A612
		public static Offset<IVehicleTypedConfig> EndIVehicleTypedConfig(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleTypedConfig>(builder.EndTable());
		}

		// Token: 0x06027E37 RID: 163383 RVA: 0x0057C420 File Offset: 0x0057A620
		public IVehicleTypedConfigT UnPack()
		{
			IVehicleTypedConfigT vehicleTypedConfigT = new IVehicleTypedConfigT();
			this.UnPackTo(vehicleTypedConfigT);
			return vehicleTypedConfigT;
		}

		// Token: 0x06027E38 RID: 163384 RVA: 0x0057C43B File Offset: 0x0057A63B
		public void UnPackTo(IVehicleTypedConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06027E39 RID: 163385 RVA: 0x0057C44C File Offset: 0x0057A64C
		public static Offset<IVehicleTypedConfig> Pack(FlatBufferBuilder builder, IVehicleTypedConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleTypedConfig>);
			}
			return IVehicleTypedConfig.CreateIVehicleTypedConfig(builder, _o.Type);
		}

		// Token: 0x0400F24C RID: 62028
		private Table __p;
	}
}
