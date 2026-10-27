using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200654F RID: 25935
	public struct IDeadeyeEnergyConfig : IFlatbufferObject
	{
		// Token: 0x1700C0CA RID: 49354
		// (get) Token: 0x0602CFFE RID: 184318 RVA: 0x0062D4EB File Offset: 0x0062B6EB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CFFF RID: 184319 RVA: 0x0062D4F8 File Offset: 0x0062B6F8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D000 RID: 184320 RVA: 0x0062D500 File Offset: 0x0062B700
		public static IDeadeyeEnergyConfig GetRootAsIDeadeyeEnergyConfig(ByteBuffer _bb)
		{
			return IDeadeyeEnergyConfig.GetRootAsIDeadeyeEnergyConfig(_bb, default(IDeadeyeEnergyConfig));
		}

		// Token: 0x0602D001 RID: 184321 RVA: 0x0062D51C File Offset: 0x0062B71C
		public static IDeadeyeEnergyConfig GetRootAsIDeadeyeEnergyConfig(ByteBuffer _bb, IDeadeyeEnergyConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D002 RID: 184322 RVA: 0x0062D539 File Offset: 0x0062B739
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D003 RID: 184323 RVA: 0x0062D548 File Offset: 0x0062B748
		public IDeadeyeEnergyConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C0CB RID: 49355
		// (get) Token: 0x0602D004 RID: 184324 RVA: 0x0062D558 File Offset: 0x0062B758
		public int MaxEnergy
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

		// Token: 0x1700C0CC RID: 49356
		// (get) Token: 0x0602D005 RID: 184325 RVA: 0x0062D594 File Offset: 0x0062B794
		public int BulletConsumption
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

		// Token: 0x1700C0CD RID: 49357
		// (get) Token: 0x0602D006 RID: 184326 RVA: 0x0062D5D0 File Offset: 0x0062B7D0
		public int TimeConsumption
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

		// Token: 0x0602D007 RID: 184327 RVA: 0x0062D60C File Offset: 0x0062B80C
		public static Offset<IDeadeyeEnergyConfig> CreateIDeadeyeEnergyConfig(FlatBufferBuilder builder, int MaxEnergy = 0, int BulletConsumption = 0, int TimeConsumption = 0)
		{
			builder.StartTable(3);
			IDeadeyeEnergyConfig.AddTimeConsumption(builder, TimeConsumption);
			IDeadeyeEnergyConfig.AddBulletConsumption(builder, BulletConsumption);
			IDeadeyeEnergyConfig.AddMaxEnergy(builder, MaxEnergy);
			return IDeadeyeEnergyConfig.EndIDeadeyeEnergyConfig(builder);
		}

		// Token: 0x0602D008 RID: 184328 RVA: 0x0062D630 File Offset: 0x0062B830
		public static void StartIDeadeyeEnergyConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602D009 RID: 184329 RVA: 0x0062D639 File Offset: 0x0062B839
		public static void AddMaxEnergy(FlatBufferBuilder builder, int maxEnergy)
		{
			builder.AddInt(0, maxEnergy, 0);
		}

		// Token: 0x0602D00A RID: 184330 RVA: 0x0062D644 File Offset: 0x0062B844
		public static void AddBulletConsumption(FlatBufferBuilder builder, int bulletConsumption)
		{
			builder.AddInt(1, bulletConsumption, 0);
		}

		// Token: 0x0602D00B RID: 184331 RVA: 0x0062D64F File Offset: 0x0062B84F
		public static void AddTimeConsumption(FlatBufferBuilder builder, int timeConsumption)
		{
			builder.AddInt(2, timeConsumption, 0);
		}

		// Token: 0x0602D00C RID: 184332 RVA: 0x0062D65A File Offset: 0x0062B85A
		public static Offset<IDeadeyeEnergyConfig> EndIDeadeyeEnergyConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDeadeyeEnergyConfig>(builder.EndTable());
		}

		// Token: 0x0602D00D RID: 184333 RVA: 0x0062D668 File Offset: 0x0062B868
		public IDeadeyeEnergyConfigT UnPack()
		{
			IDeadeyeEnergyConfigT deadeyeEnergyConfigT = new IDeadeyeEnergyConfigT();
			this.UnPackTo(deadeyeEnergyConfigT);
			return deadeyeEnergyConfigT;
		}

		// Token: 0x0602D00E RID: 184334 RVA: 0x0062D683 File Offset: 0x0062B883
		public void UnPackTo(IDeadeyeEnergyConfigT _o)
		{
			_o.MaxEnergy = this.MaxEnergy;
			_o.BulletConsumption = this.BulletConsumption;
			_o.TimeConsumption = this.TimeConsumption;
		}

		// Token: 0x0602D00F RID: 184335 RVA: 0x0062D6AC File Offset: 0x0062B8AC
		public static Offset<IDeadeyeEnergyConfig> Pack(FlatBufferBuilder builder, IDeadeyeEnergyConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDeadeyeEnergyConfig>);
			}
			return IDeadeyeEnergyConfig.CreateIDeadeyeEnergyConfig(builder, _o.MaxEnergy, _o.BulletConsumption, _o.TimeConsumption);
		}

		// Token: 0x04010BA0 RID: 68512
		private Table __p;
	}
}
