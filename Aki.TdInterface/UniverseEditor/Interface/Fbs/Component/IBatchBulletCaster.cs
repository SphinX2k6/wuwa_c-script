using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005427 RID: 21543
	public struct IBatchBulletCaster : IFlatbufferObject
	{
		// Token: 0x170098E1 RID: 39137
		// (get) Token: 0x06021C12 RID: 138258 RVA: 0x004A7616 File Offset: 0x004A5816
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021C13 RID: 138259 RVA: 0x004A7623 File Offset: 0x004A5823
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021C14 RID: 138260 RVA: 0x004A762C File Offset: 0x004A582C
		public static IBatchBulletCaster GetRootAsIBatchBulletCaster(ByteBuffer _bb)
		{
			return IBatchBulletCaster.GetRootAsIBatchBulletCaster(_bb, default(IBatchBulletCaster));
		}

		// Token: 0x06021C15 RID: 138261 RVA: 0x004A7648 File Offset: 0x004A5848
		public static IBatchBulletCaster GetRootAsIBatchBulletCaster(ByteBuffer _bb, IBatchBulletCaster obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021C16 RID: 138262 RVA: 0x004A7665 File Offset: 0x004A5865
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021C17 RID: 138263 RVA: 0x004A7674 File Offset: 0x004A5874
		public IBatchBulletCaster __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170098E2 RID: 39138
		// (get) Token: 0x06021C18 RID: 138264 RVA: 0x004A7684 File Offset: 0x004A5884
		public int BulletIndex
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170098E3 RID: 39139
		// (get) Token: 0x06021C19 RID: 138265 RVA: 0x004A76C0 File Offset: 0x004A58C0
		public long BulletType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0L;
				}
				return this.__p.bb.GetLong(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170098E4 RID: 39140
		// (get) Token: 0x06021C1A RID: 138266 RVA: 0x004A7700 File Offset: 0x004A5900
		public int DelayTime
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

		// Token: 0x170098E5 RID: 39141
		// (get) Token: 0x06021C1B RID: 138267 RVA: 0x004A773C File Offset: 0x004A593C
		public int FlyTime
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170098E6 RID: 39142
		// (get) Token: 0x06021C1C RID: 138268 RVA: 0x004A777C File Offset: 0x004A597C
		public int FlyDistance
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170098E7 RID: 39143
		// (get) Token: 0x06021C1D RID: 138269 RVA: 0x004A77BC File Offset: 0x004A59BC
		public int WarningTime
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170098E8 RID: 39144
		// (get) Token: 0x06021C1E RID: 138270 RVA: 0x004A77FC File Offset: 0x004A59FC
		public int WarningWidth
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170098E9 RID: 39145
		// (get) Token: 0x06021C1F RID: 138271 RVA: 0x004A783C File Offset: 0x004A5A3C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021C20 RID: 138272 RVA: 0x004A787C File Offset: 0x004A5A7C
		public static Offset<IBatchBulletCaster> CreateIBatchBulletCaster(FlatBufferBuilder builder, int BulletIndex = 0, long BulletType = 0L, int DelayTime = 0, int FlyTime = 0, int FlyDistance = 0, int WarningTime = 0, int WarningWidth = 0, byte NullMask = 0)
		{
			builder.StartTable(8);
			IBatchBulletCaster.AddBulletType(builder, BulletType);
			IBatchBulletCaster.AddWarningWidth(builder, WarningWidth);
			IBatchBulletCaster.AddWarningTime(builder, WarningTime);
			IBatchBulletCaster.AddFlyDistance(builder, FlyDistance);
			IBatchBulletCaster.AddFlyTime(builder, FlyTime);
			IBatchBulletCaster.AddDelayTime(builder, DelayTime);
			IBatchBulletCaster.AddBulletIndex(builder, BulletIndex);
			IBatchBulletCaster.AddNullMask(builder, NullMask);
			return IBatchBulletCaster.EndIBatchBulletCaster(builder);
		}

		// Token: 0x06021C21 RID: 138273 RVA: 0x004A78D3 File Offset: 0x004A5AD3
		public static void StartIBatchBulletCaster(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06021C22 RID: 138274 RVA: 0x004A78DC File Offset: 0x004A5ADC
		public static void AddBulletIndex(FlatBufferBuilder builder, int bulletIndex)
		{
			builder.AddInt(0, bulletIndex, 0);
		}

		// Token: 0x06021C23 RID: 138275 RVA: 0x004A78E7 File Offset: 0x004A5AE7
		public static void AddBulletType(FlatBufferBuilder builder, long bulletType)
		{
			builder.AddLong(1, bulletType, 0L);
		}

		// Token: 0x06021C24 RID: 138276 RVA: 0x004A78F3 File Offset: 0x004A5AF3
		public static void AddDelayTime(FlatBufferBuilder builder, int delayTime)
		{
			builder.AddInt(2, delayTime, 0);
		}

		// Token: 0x06021C25 RID: 138277 RVA: 0x004A78FE File Offset: 0x004A5AFE
		public static void AddFlyTime(FlatBufferBuilder builder, int flyTime)
		{
			builder.AddInt(3, flyTime, 0);
		}

		// Token: 0x06021C26 RID: 138278 RVA: 0x004A7909 File Offset: 0x004A5B09
		public static void AddFlyDistance(FlatBufferBuilder builder, int flyDistance)
		{
			builder.AddInt(4, flyDistance, 0);
		}

		// Token: 0x06021C27 RID: 138279 RVA: 0x004A7914 File Offset: 0x004A5B14
		public static void AddWarningTime(FlatBufferBuilder builder, int warningTime)
		{
			builder.AddInt(5, warningTime, 0);
		}

		// Token: 0x06021C28 RID: 138280 RVA: 0x004A791F File Offset: 0x004A5B1F
		public static void AddWarningWidth(FlatBufferBuilder builder, int warningWidth)
		{
			builder.AddInt(6, warningWidth, 0);
		}

		// Token: 0x06021C29 RID: 138281 RVA: 0x004A792A File Offset: 0x004A5B2A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06021C2A RID: 138282 RVA: 0x004A7935 File Offset: 0x004A5B35
		public static Offset<IBatchBulletCaster> EndIBatchBulletCaster(FlatBufferBuilder builder)
		{
			return new Offset<IBatchBulletCaster>(builder.EndTable());
		}

		// Token: 0x06021C2B RID: 138283 RVA: 0x004A7944 File Offset: 0x004A5B44
		public IBatchBulletCasterT UnPack()
		{
			IBatchBulletCasterT batchBulletCasterT = new IBatchBulletCasterT();
			this.UnPackTo(batchBulletCasterT);
			return batchBulletCasterT;
		}

		// Token: 0x06021C2C RID: 138284 RVA: 0x004A7960 File Offset: 0x004A5B60
		public void UnPackTo(IBatchBulletCasterT _o)
		{
			_o.BulletIndex = this.BulletIndex;
			_o.BulletType = this.BulletType;
			_o.DelayTime = this.DelayTime;
			_o.FlyTime = this.FlyTime;
			_o.FlyDistance = this.FlyDistance;
			_o.WarningTime = this.WarningTime;
			_o.WarningWidth = this.WarningWidth;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06021C2D RID: 138285 RVA: 0x004A79D0 File Offset: 0x004A5BD0
		public static Offset<IBatchBulletCaster> Pack(FlatBufferBuilder builder, IBatchBulletCasterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBatchBulletCaster>);
			}
			return IBatchBulletCaster.CreateIBatchBulletCaster(builder, _o.BulletIndex, _o.BulletType, _o.DelayTime, _o.FlyTime, _o.FlyDistance, _o.WarningTime, _o.WarningWidth, _o.NullMask);
		}

		// Token: 0x0400E8D3 RID: 59603
		private Table __p;
	}
}
