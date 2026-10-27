using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200722F RID: 29231
	public struct ISummonEntity : IFlatbufferObject
	{
		// Token: 0x1700D8F2 RID: 55538
		// (get) Token: 0x06033D94 RID: 212372 RVA: 0x006F9FD1 File Offset: 0x006F81D1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033D95 RID: 212373 RVA: 0x006F9FDE File Offset: 0x006F81DE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033D96 RID: 212374 RVA: 0x006F9FE8 File Offset: 0x006F81E8
		public static ISummonEntity GetRootAsISummonEntity(ByteBuffer _bb)
		{
			return ISummonEntity.GetRootAsISummonEntity(_bb, default(ISummonEntity));
		}

		// Token: 0x06033D97 RID: 212375 RVA: 0x006FA004 File Offset: 0x006F8204
		public static ISummonEntity GetRootAsISummonEntity(ByteBuffer _bb, ISummonEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033D98 RID: 212376 RVA: 0x006FA021 File Offset: 0x006F8221
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033D99 RID: 212377 RVA: 0x006FA030 File Offset: 0x006F8230
		public ISummonEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D8F3 RID: 55539
		// (get) Token: 0x06033D9A RID: 212378 RVA: 0x006FA040 File Offset: 0x006F8240
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

		// Token: 0x06033D9B RID: 212379 RVA: 0x006FA09D File Offset: 0x006F829D
		public static Offset<ISummonEntity> CreateISummonEntity(FlatBufferBuilder builder, Offset<ISummonVehicle> SummonEntityConfigOffset = default(Offset<ISummonVehicle>))
		{
			builder.StartTable(1);
			ISummonEntity.AddSummonEntityConfig(builder, SummonEntityConfigOffset);
			return ISummonEntity.EndISummonEntity(builder);
		}

		// Token: 0x06033D9C RID: 212380 RVA: 0x006FA0B3 File Offset: 0x006F82B3
		public static void StartISummonEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033D9D RID: 212381 RVA: 0x006FA0BC File Offset: 0x006F82BC
		public static void AddSummonEntityConfig(FlatBufferBuilder builder, Offset<ISummonVehicle> summonEntityConfigOffset)
		{
			builder.AddOffset(0, summonEntityConfigOffset.Value, 0);
		}

		// Token: 0x06033D9E RID: 212382 RVA: 0x006FA0CC File Offset: 0x006F82CC
		public static Offset<ISummonEntity> EndISummonEntity(FlatBufferBuilder builder)
		{
			return new Offset<ISummonEntity>(builder.EndTable());
		}

		// Token: 0x06033D9F RID: 212383 RVA: 0x006FA0DC File Offset: 0x006F82DC
		public ISummonEntityT UnPack()
		{
			ISummonEntityT summonEntityT = new ISummonEntityT();
			this.UnPackTo(summonEntityT);
			return summonEntityT;
		}

		// Token: 0x06033DA0 RID: 212384 RVA: 0x006FA0F8 File Offset: 0x006F82F8
		public void UnPackTo(ISummonEntityT _o)
		{
			_o.SummonEntityConfig = ((this.SummonEntityConfig != null) ? this.SummonEntityConfig.Value.UnPack() : null);
		}

		// Token: 0x06033DA1 RID: 212385 RVA: 0x006FA134 File Offset: 0x006F8334
		public static Offset<ISummonEntity> Pack(FlatBufferBuilder builder, ISummonEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISummonEntity>);
			}
			Offset<ISummonVehicle> summonEntityConfigOffset = (_o.SummonEntityConfig == null) ? default(Offset<ISummonVehicle>) : ISummonVehicle.Pack(builder, _o.SummonEntityConfig);
			return ISummonEntity.CreateISummonEntity(builder, summonEntityConfigOffset);
		}

		// Token: 0x04011D20 RID: 72992
		private Table __p;
	}
}
