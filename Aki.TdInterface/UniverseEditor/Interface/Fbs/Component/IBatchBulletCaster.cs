using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EF5 RID: 20213
	public struct IBatchBulletCaster : IFlatbufferObject
	{
		// Token: 0x1700915F RID: 37215
		// (get) Token: 0x0601FEA2 RID: 130722 RVA: 0x00471282 File Offset: 0x0046F482
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FEA3 RID: 130723 RVA: 0x0047128F File Offset: 0x0046F48F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FEA4 RID: 130724 RVA: 0x00471298 File Offset: 0x0046F498
		public static IBatchBulletCaster GetRootAsIBatchBulletCaster(ByteBuffer _bb)
		{
			return IBatchBulletCaster.GetRootAsIBatchBulletCaster(_bb, default(IBatchBulletCaster));
		}

		// Token: 0x0601FEA5 RID: 130725 RVA: 0x004712B4 File Offset: 0x0046F4B4
		public static IBatchBulletCaster GetRootAsIBatchBulletCaster(ByteBuffer _bb, IBatchBulletCaster obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FEA6 RID: 130726 RVA: 0x004712D1 File Offset: 0x0046F4D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FEA7 RID: 130727 RVA: 0x004712E0 File Offset: 0x0046F4E0
		public IBatchBulletCaster __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009160 RID: 37216
		// (get) Token: 0x0601FEA8 RID: 130728 RVA: 0x004712F0 File Offset: 0x0046F4F0
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

		// Token: 0x17009161 RID: 37217
		// (get) Token: 0x0601FEA9 RID: 130729 RVA: 0x0047132C File Offset: 0x0046F52C
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

		// Token: 0x17009162 RID: 37218
		// (get) Token: 0x0601FEAA RID: 130730 RVA: 0x0047136C File Offset: 0x0046F56C
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

		// Token: 0x17009163 RID: 37219
		// (get) Token: 0x0601FEAB RID: 130731 RVA: 0x004713A8 File Offset: 0x0046F5A8
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

		// Token: 0x17009164 RID: 37220
		// (get) Token: 0x0601FEAC RID: 130732 RVA: 0x004713E8 File Offset: 0x0046F5E8
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

		// Token: 0x17009165 RID: 37221
		// (get) Token: 0x0601FEAD RID: 130733 RVA: 0x00471428 File Offset: 0x0046F628
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

		// Token: 0x17009166 RID: 37222
		// (get) Token: 0x0601FEAE RID: 130734 RVA: 0x00471468 File Offset: 0x0046F668
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

		// Token: 0x17009167 RID: 37223
		// (get) Token: 0x0601FEAF RID: 130735 RVA: 0x004714A8 File Offset: 0x0046F6A8
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

		// Token: 0x0601FEB0 RID: 130736 RVA: 0x004714E8 File Offset: 0x0046F6E8
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

		// Token: 0x0601FEB1 RID: 130737 RVA: 0x0047153F File Offset: 0x0046F73F
		public static void StartIBatchBulletCaster(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0601FEB2 RID: 130738 RVA: 0x00471548 File Offset: 0x0046F748
		public static void AddBulletIndex(FlatBufferBuilder builder, int bulletIndex)
		{
			builder.AddInt(0, bulletIndex, 0);
		}

		// Token: 0x0601FEB3 RID: 130739 RVA: 0x00471553 File Offset: 0x0046F753
		public static void AddBulletType(FlatBufferBuilder builder, long bulletType)
		{
			builder.AddLong(1, bulletType, 0L);
		}

		// Token: 0x0601FEB4 RID: 130740 RVA: 0x0047155F File Offset: 0x0046F75F
		public static void AddDelayTime(FlatBufferBuilder builder, int delayTime)
		{
			builder.AddInt(2, delayTime, 0);
		}

		// Token: 0x0601FEB5 RID: 130741 RVA: 0x0047156A File Offset: 0x0046F76A
		public static void AddFlyTime(FlatBufferBuilder builder, int flyTime)
		{
			builder.AddInt(3, flyTime, 0);
		}

		// Token: 0x0601FEB6 RID: 130742 RVA: 0x00471575 File Offset: 0x0046F775
		public static void AddFlyDistance(FlatBufferBuilder builder, int flyDistance)
		{
			builder.AddInt(4, flyDistance, 0);
		}

		// Token: 0x0601FEB7 RID: 130743 RVA: 0x00471580 File Offset: 0x0046F780
		public static void AddWarningTime(FlatBufferBuilder builder, int warningTime)
		{
			builder.AddInt(5, warningTime, 0);
		}

		// Token: 0x0601FEB8 RID: 130744 RVA: 0x0047158B File Offset: 0x0046F78B
		public static void AddWarningWidth(FlatBufferBuilder builder, int warningWidth)
		{
			builder.AddInt(6, warningWidth, 0);
		}

		// Token: 0x0601FEB9 RID: 130745 RVA: 0x00471596 File Offset: 0x0046F796
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x0601FEBA RID: 130746 RVA: 0x004715A1 File Offset: 0x0046F7A1
		public static Offset<IBatchBulletCaster> EndIBatchBulletCaster(FlatBufferBuilder builder)
		{
			return new Offset<IBatchBulletCaster>(builder.EndTable());
		}

		// Token: 0x0601FEBB RID: 130747 RVA: 0x004715B0 File Offset: 0x0046F7B0
		public IBatchBulletCasterT UnPack()
		{
			IBatchBulletCasterT batchBulletCasterT = new IBatchBulletCasterT();
			this.UnPackTo(batchBulletCasterT);
			return batchBulletCasterT;
		}

		// Token: 0x0601FEBC RID: 130748 RVA: 0x004715CC File Offset: 0x0046F7CC
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

		// Token: 0x0601FEBD RID: 130749 RVA: 0x0047163C File Offset: 0x0046F83C
		public static Offset<IBatchBulletCaster> Pack(FlatBufferBuilder builder, IBatchBulletCasterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBatchBulletCaster>);
			}
			return IBatchBulletCaster.CreateIBatchBulletCaster(builder, _o.BulletIndex, _o.BulletType, _o.DelayTime, _o.FlyTime, _o.FlyDistance, _o.WarningTime, _o.WarningWidth, _o.NullMask);
		}

		// Token: 0x0400DD24 RID: 56612
		private Table __p;
	}
}
