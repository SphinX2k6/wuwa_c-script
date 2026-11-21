using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004944 RID: 18756
	public struct IHoldBreathResult : IFlatbufferObject
	{
		// Token: 0x170082AA RID: 33450
		// (get) Token: 0x0601BD7B RID: 114043 RVA: 0x003EF258 File Offset: 0x003ED458
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BD7C RID: 114044 RVA: 0x003EF265 File Offset: 0x003ED465
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BD7D RID: 114045 RVA: 0x003EF26C File Offset: 0x003ED46C
		public static IHoldBreathResult GetRootAsIHoldBreathResult(ByteBuffer _bb)
		{
			return IHoldBreathResult.GetRootAsIHoldBreathResult(_bb, default(IHoldBreathResult));
		}

		// Token: 0x0601BD7E RID: 114046 RVA: 0x003EF288 File Offset: 0x003ED488
		public static IHoldBreathResult GetRootAsIHoldBreathResult(ByteBuffer _bb, IHoldBreathResult obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BD7F RID: 114047 RVA: 0x003EF2A5 File Offset: 0x003ED4A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BD80 RID: 114048 RVA: 0x003EF2B4 File Offset: 0x003ED4B4
		public IHoldBreathResult __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170082AB RID: 33451
		// (get) Token: 0x0601BD81 RID: 114049 RVA: 0x003EF2C4 File Offset: 0x003ED4C4
		public EDartSkillResultType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDartSkillResultType.NoBust;
				}
				return (EDartSkillResultType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170082AC RID: 33452
		// (get) Token: 0x0601BD82 RID: 114050 RVA: 0x003EF300 File Offset: 0x003ED500
		public int Probability
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

		// Token: 0x170082AD RID: 33453
		// (get) Token: 0x0601BD83 RID: 114051 RVA: 0x003EF33C File Offset: 0x003ED53C
		public int SpeedReducePercent
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

		// Token: 0x0601BD84 RID: 114052 RVA: 0x003EF378 File Offset: 0x003ED578
		public static Offset<IHoldBreathResult> CreateIHoldBreathResult(FlatBufferBuilder builder, EDartSkillResultType Type = EDartSkillResultType.NoBust, int Probability = 0, int SpeedReducePercent = 0)
		{
			builder.StartTable(3);
			IHoldBreathResult.AddSpeedReducePercent(builder, SpeedReducePercent);
			IHoldBreathResult.AddProbability(builder, Probability);
			IHoldBreathResult.AddType(builder, Type);
			return IHoldBreathResult.EndIHoldBreathResult(builder);
		}

		// Token: 0x0601BD85 RID: 114053 RVA: 0x003EF39C File Offset: 0x003ED59C
		public static void StartIHoldBreathResult(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601BD86 RID: 114054 RVA: 0x003EF3A5 File Offset: 0x003ED5A5
		public static void AddType(FlatBufferBuilder builder, EDartSkillResultType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601BD87 RID: 114055 RVA: 0x003EF3B0 File Offset: 0x003ED5B0
		public static void AddProbability(FlatBufferBuilder builder, int probability)
		{
			builder.AddInt(1, probability, 0);
		}

		// Token: 0x0601BD88 RID: 114056 RVA: 0x003EF3BB File Offset: 0x003ED5BB
		public static void AddSpeedReducePercent(FlatBufferBuilder builder, int speedReducePercent)
		{
			builder.AddInt(2, speedReducePercent, 0);
		}

		// Token: 0x0601BD89 RID: 114057 RVA: 0x003EF3C6 File Offset: 0x003ED5C6
		public static Offset<IHoldBreathResult> EndIHoldBreathResult(FlatBufferBuilder builder)
		{
			return new Offset<IHoldBreathResult>(builder.EndTable());
		}

		// Token: 0x0601BD8A RID: 114058 RVA: 0x003EF3D4 File Offset: 0x003ED5D4
		public IHoldBreathResultT UnPack()
		{
			IHoldBreathResultT holdBreathResultT = new IHoldBreathResultT();
			this.UnPackTo(holdBreathResultT);
			return holdBreathResultT;
		}

		// Token: 0x0601BD8B RID: 114059 RVA: 0x003EF3EF File Offset: 0x003ED5EF
		public void UnPackTo(IHoldBreathResultT _o)
		{
			_o.Type = this.Type;
			_o.Probability = this.Probability;
			_o.SpeedReducePercent = this.SpeedReducePercent;
		}

		// Token: 0x0601BD8C RID: 114060 RVA: 0x003EF418 File Offset: 0x003ED618
		public static Offset<IHoldBreathResult> Pack(FlatBufferBuilder builder, IHoldBreathResultT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHoldBreathResult>);
			}
			return IHoldBreathResult.CreateIHoldBreathResult(builder, _o.Type, _o.Probability, _o.SpeedReducePercent);
		}

		// Token: 0x0400CF22 RID: 53026
		private Table __p;
	}
}
