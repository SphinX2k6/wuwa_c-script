using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BC0 RID: 27584
	public struct IDeadeyeEnergyConfig : IFlatbufferObject
	{
		// Token: 0x1700CA65 RID: 51813
		// (get) Token: 0x0602F7BA RID: 194490 RVA: 0x00679CAF File Offset: 0x00677EAF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F7BB RID: 194491 RVA: 0x00679CBC File Offset: 0x00677EBC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F7BC RID: 194492 RVA: 0x00679CC4 File Offset: 0x00677EC4
		public static IDeadeyeEnergyConfig GetRootAsIDeadeyeEnergyConfig(ByteBuffer _bb)
		{
			return IDeadeyeEnergyConfig.GetRootAsIDeadeyeEnergyConfig(_bb, default(IDeadeyeEnergyConfig));
		}

		// Token: 0x0602F7BD RID: 194493 RVA: 0x00679CE0 File Offset: 0x00677EE0
		public static IDeadeyeEnergyConfig GetRootAsIDeadeyeEnergyConfig(ByteBuffer _bb, IDeadeyeEnergyConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F7BE RID: 194494 RVA: 0x00679CFD File Offset: 0x00677EFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F7BF RID: 194495 RVA: 0x00679D0C File Offset: 0x00677F0C
		public IDeadeyeEnergyConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA66 RID: 51814
		// (get) Token: 0x0602F7C0 RID: 194496 RVA: 0x00679D1C File Offset: 0x00677F1C
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

		// Token: 0x1700CA67 RID: 51815
		// (get) Token: 0x0602F7C1 RID: 194497 RVA: 0x00679D58 File Offset: 0x00677F58
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

		// Token: 0x1700CA68 RID: 51816
		// (get) Token: 0x0602F7C2 RID: 194498 RVA: 0x00679D94 File Offset: 0x00677F94
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

		// Token: 0x0602F7C3 RID: 194499 RVA: 0x00679DD0 File Offset: 0x00677FD0
		public static Offset<IDeadeyeEnergyConfig> CreateIDeadeyeEnergyConfig(FlatBufferBuilder builder, int MaxEnergy = 0, int BulletConsumption = 0, int TimeConsumption = 0)
		{
			builder.StartTable(3);
			IDeadeyeEnergyConfig.AddTimeConsumption(builder, TimeConsumption);
			IDeadeyeEnergyConfig.AddBulletConsumption(builder, BulletConsumption);
			IDeadeyeEnergyConfig.AddMaxEnergy(builder, MaxEnergy);
			return IDeadeyeEnergyConfig.EndIDeadeyeEnergyConfig(builder);
		}

		// Token: 0x0602F7C4 RID: 194500 RVA: 0x00679DF4 File Offset: 0x00677FF4
		public static void StartIDeadeyeEnergyConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602F7C5 RID: 194501 RVA: 0x00679DFD File Offset: 0x00677FFD
		public static void AddMaxEnergy(FlatBufferBuilder builder, int maxEnergy)
		{
			builder.AddInt(0, maxEnergy, 0);
		}

		// Token: 0x0602F7C6 RID: 194502 RVA: 0x00679E08 File Offset: 0x00678008
		public static void AddBulletConsumption(FlatBufferBuilder builder, int bulletConsumption)
		{
			builder.AddInt(1, bulletConsumption, 0);
		}

		// Token: 0x0602F7C7 RID: 194503 RVA: 0x00679E13 File Offset: 0x00678013
		public static void AddTimeConsumption(FlatBufferBuilder builder, int timeConsumption)
		{
			builder.AddInt(2, timeConsumption, 0);
		}

		// Token: 0x0602F7C8 RID: 194504 RVA: 0x00679E1E File Offset: 0x0067801E
		public static Offset<IDeadeyeEnergyConfig> EndIDeadeyeEnergyConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDeadeyeEnergyConfig>(builder.EndTable());
		}

		// Token: 0x0602F7C9 RID: 194505 RVA: 0x00679E2C File Offset: 0x0067802C
		public IDeadeyeEnergyConfigT UnPack()
		{
			IDeadeyeEnergyConfigT deadeyeEnergyConfigT = new IDeadeyeEnergyConfigT();
			this.UnPackTo(deadeyeEnergyConfigT);
			return deadeyeEnergyConfigT;
		}

		// Token: 0x0602F7CA RID: 194506 RVA: 0x00679E47 File Offset: 0x00678047
		public void UnPackTo(IDeadeyeEnergyConfigT _o)
		{
			_o.MaxEnergy = this.MaxEnergy;
			_o.BulletConsumption = this.BulletConsumption;
			_o.TimeConsumption = this.TimeConsumption;
		}

		// Token: 0x0602F7CB RID: 194507 RVA: 0x00679E70 File Offset: 0x00678070
		public static Offset<IDeadeyeEnergyConfig> Pack(FlatBufferBuilder builder, IDeadeyeEnergyConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDeadeyeEnergyConfig>);
			}
			return IDeadeyeEnergyConfig.CreateIDeadeyeEnergyConfig(builder, _o.MaxEnergy, _o.BulletConsumption, _o.TimeConsumption);
		}

		// Token: 0x040119BE RID: 72126
		private Table __p;
	}
}
