using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A04 RID: 31236
	public struct ISummonEntity : IFlatbufferObject
	{
		// Token: 0x1700E4EB RID: 58603
		// (get) Token: 0x06037096 RID: 225430 RVA: 0x0075B331 File Offset: 0x00759531
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06037097 RID: 225431 RVA: 0x0075B33E File Offset: 0x0075953E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06037098 RID: 225432 RVA: 0x0075B348 File Offset: 0x00759548
		public static ISummonEntity GetRootAsISummonEntity(ByteBuffer _bb)
		{
			return ISummonEntity.GetRootAsISummonEntity(_bb, default(ISummonEntity));
		}

		// Token: 0x06037099 RID: 225433 RVA: 0x0075B364 File Offset: 0x00759564
		public static ISummonEntity GetRootAsISummonEntity(ByteBuffer _bb, ISummonEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603709A RID: 225434 RVA: 0x0075B381 File Offset: 0x00759581
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603709B RID: 225435 RVA: 0x0075B390 File Offset: 0x00759590
		public ISummonEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E4EC RID: 58604
		// (get) Token: 0x0603709C RID: 225436 RVA: 0x0075B3A0 File Offset: 0x007595A0
		public ISummonVehicle? SummonEntityConfig
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new ISummonVehicle?(default(ISummonVehicle).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0603709D RID: 225437 RVA: 0x0075B3FD File Offset: 0x007595FD
		public static Offset<ISummonEntity> CreateISummonEntity(FlatBufferBuilder builder, Offset<ISummonVehicle> SummonEntityConfigOffset = default(Offset<ISummonVehicle>))
		{
			builder.StartTable(1);
			ISummonEntity.AddSummonEntityConfig(builder, SummonEntityConfigOffset);
			return ISummonEntity.EndISummonEntity(builder);
		}

		// Token: 0x0603709E RID: 225438 RVA: 0x0075B413 File Offset: 0x00759613
		public static void StartISummonEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603709F RID: 225439 RVA: 0x0075B41C File Offset: 0x0075961C
		public static void AddSummonEntityConfig(FlatBufferBuilder builder, Offset<ISummonVehicle> summonEntityConfigOffset)
		{
			builder.AddOffset(0, summonEntityConfigOffset.Value, 0);
		}

		// Token: 0x060370A0 RID: 225440 RVA: 0x0075B42C File Offset: 0x0075962C
		public static Offset<ISummonEntity> EndISummonEntity(FlatBufferBuilder builder)
		{
			return new Offset<ISummonEntity>(builder.EndTable());
		}

		// Token: 0x060370A1 RID: 225441 RVA: 0x0075B43C File Offset: 0x0075963C
		public ISummonEntityT UnPack()
		{
			ISummonEntityT summonEntityT = new ISummonEntityT();
			this.UnPackTo(summonEntityT);
			return summonEntityT;
		}

		// Token: 0x060370A2 RID: 225442 RVA: 0x0075B458 File Offset: 0x00759658
		public void UnPackTo(ISummonEntityT _o)
		{
			_o.SummonEntityConfig = ((this.SummonEntityConfig != null) ? this.SummonEntityConfig.Value.UnPack() : null);
		}

		// Token: 0x060370A3 RID: 225443 RVA: 0x0075B494 File Offset: 0x00759694
		public static Offset<ISummonEntity> Pack(FlatBufferBuilder builder, ISummonEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISummonEntity>);
			}
			Offset<ISummonVehicle> summonEntityConfigOffset = (_o.SummonEntityConfig == null) ? default(Offset<ISummonVehicle>) : ISummonVehicle.Pack(builder, _o.SummonEntityConfig);
			return ISummonEntity.CreateISummonEntity(builder, summonEntityConfigOffset);
		}

		// Token: 0x04012D22 RID: 77090
		private Table __p;
	}
}
