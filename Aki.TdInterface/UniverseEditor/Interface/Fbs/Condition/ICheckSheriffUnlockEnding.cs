using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B26 RID: 19238
	public struct ICheckSheriffUnlockEnding : IFlatbufferObject
	{
		// Token: 0x17008B8F RID: 35727
		// (get) Token: 0x0601E440 RID: 123968 RVA: 0x0043E0A5 File Offset: 0x0043C2A5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E441 RID: 123969 RVA: 0x0043E0B2 File Offset: 0x0043C2B2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E442 RID: 123970 RVA: 0x0043E0BC File Offset: 0x0043C2BC
		public static ICheckSheriffUnlockEnding GetRootAsICheckSheriffUnlockEnding(ByteBuffer _bb)
		{
			return ICheckSheriffUnlockEnding.GetRootAsICheckSheriffUnlockEnding(_bb, default(ICheckSheriffUnlockEnding));
		}

		// Token: 0x0601E443 RID: 123971 RVA: 0x0043E0D8 File Offset: 0x0043C2D8
		public static ICheckSheriffUnlockEnding GetRootAsICheckSheriffUnlockEnding(ByteBuffer _bb, ICheckSheriffUnlockEnding obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E444 RID: 123972 RVA: 0x0043E0F5 File Offset: 0x0043C2F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E445 RID: 123973 RVA: 0x0043E104 File Offset: 0x0043C304
		public ICheckSheriffUnlockEnding __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008B90 RID: 35728
		// (get) Token: 0x0601E446 RID: 123974 RVA: 0x0043E114 File Offset: 0x0043C314
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008B91 RID: 35729
		// (get) Token: 0x0601E447 RID: 123975 RVA: 0x0043E150 File Offset: 0x0043C350
		public int AnomalyId
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

		// Token: 0x17008B92 RID: 35730
		// (get) Token: 0x0601E448 RID: 123976 RVA: 0x0043E18C File Offset: 0x0043C38C
		public int EndingId
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

		// Token: 0x0601E449 RID: 123977 RVA: 0x0043E1C8 File Offset: 0x0043C3C8
		public static Offset<ICheckSheriffUnlockEnding> CreateICheckSheriffUnlockEnding(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int AnomalyId = 0, int EndingId = 0)
		{
			builder.StartTable(3);
			ICheckSheriffUnlockEnding.AddEndingId(builder, EndingId);
			ICheckSheriffUnlockEnding.AddAnomalyId(builder, AnomalyId);
			ICheckSheriffUnlockEnding.AddType(builder, Type);
			return ICheckSheriffUnlockEnding.EndICheckSheriffUnlockEnding(builder);
		}

		// Token: 0x0601E44A RID: 123978 RVA: 0x0043E1EC File Offset: 0x0043C3EC
		public static void StartICheckSheriffUnlockEnding(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601E44B RID: 123979 RVA: 0x0043E1F5 File Offset: 0x0043C3F5
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E44C RID: 123980 RVA: 0x0043E200 File Offset: 0x0043C400
		public static void AddAnomalyId(FlatBufferBuilder builder, int anomalyId)
		{
			builder.AddInt(1, anomalyId, 0);
		}

		// Token: 0x0601E44D RID: 123981 RVA: 0x0043E20B File Offset: 0x0043C40B
		public static void AddEndingId(FlatBufferBuilder builder, int endingId)
		{
			builder.AddInt(2, endingId, 0);
		}

		// Token: 0x0601E44E RID: 123982 RVA: 0x0043E216 File Offset: 0x0043C416
		public static Offset<ICheckSheriffUnlockEnding> EndICheckSheriffUnlockEnding(FlatBufferBuilder builder)
		{
			return new Offset<ICheckSheriffUnlockEnding>(builder.EndTable());
		}

		// Token: 0x0601E44F RID: 123983 RVA: 0x0043E224 File Offset: 0x0043C424
		public ICheckSheriffUnlockEndingT UnPack()
		{
			ICheckSheriffUnlockEndingT checkSheriffUnlockEndingT = new ICheckSheriffUnlockEndingT();
			this.UnPackTo(checkSheriffUnlockEndingT);
			return checkSheriffUnlockEndingT;
		}

		// Token: 0x0601E450 RID: 123984 RVA: 0x0043E23F File Offset: 0x0043C43F
		public void UnPackTo(ICheckSheriffUnlockEndingT _o)
		{
			_o.Type = this.Type;
			_o.AnomalyId = this.AnomalyId;
			_o.EndingId = this.EndingId;
		}

		// Token: 0x0601E451 RID: 123985 RVA: 0x0043E268 File Offset: 0x0043C468
		public static Offset<ICheckSheriffUnlockEnding> Pack(FlatBufferBuilder builder, ICheckSheriffUnlockEndingT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckSheriffUnlockEnding>);
			}
			return ICheckSheriffUnlockEnding.CreateICheckSheriffUnlockEnding(builder, _o.Type, _o.AnomalyId, _o.EndingId);
		}

		// Token: 0x0400D3CA RID: 54218
		private Table __p;
	}
}
