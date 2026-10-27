using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044DC RID: 17628
	public struct IHoldBreathResult : IFlatbufferObject
	{
		// Token: 0x17007C6B RID: 31851
		// (get) Token: 0x0601A5AA RID: 107946 RVA: 0x003C304C File Offset: 0x003C124C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A5AB RID: 107947 RVA: 0x003C3059 File Offset: 0x003C1259
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A5AC RID: 107948 RVA: 0x003C3060 File Offset: 0x003C1260
		public static IHoldBreathResult GetRootAsIHoldBreathResult(ByteBuffer _bb)
		{
			return IHoldBreathResult.GetRootAsIHoldBreathResult(_bb, default(IHoldBreathResult));
		}

		// Token: 0x0601A5AD RID: 107949 RVA: 0x003C307C File Offset: 0x003C127C
		public static IHoldBreathResult GetRootAsIHoldBreathResult(ByteBuffer _bb, IHoldBreathResult obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A5AE RID: 107950 RVA: 0x003C3099 File Offset: 0x003C1299
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A5AF RID: 107951 RVA: 0x003C30A8 File Offset: 0x003C12A8
		public IHoldBreathResult __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007C6C RID: 31852
		// (get) Token: 0x0601A5B0 RID: 107952 RVA: 0x003C30B8 File Offset: 0x003C12B8
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

		// Token: 0x17007C6D RID: 31853
		// (get) Token: 0x0601A5B1 RID: 107953 RVA: 0x003C30F4 File Offset: 0x003C12F4
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

		// Token: 0x17007C6E RID: 31854
		// (get) Token: 0x0601A5B2 RID: 107954 RVA: 0x003C3130 File Offset: 0x003C1330
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

		// Token: 0x0601A5B3 RID: 107955 RVA: 0x003C316C File Offset: 0x003C136C
		public static Offset<IHoldBreathResult> CreateIHoldBreathResult(FlatBufferBuilder builder, EDartSkillResultType Type = EDartSkillResultType.NoBust, int Probability = 0, int SpeedReducePercent = 0)
		{
			builder.StartTable(3);
			IHoldBreathResult.AddSpeedReducePercent(builder, SpeedReducePercent);
			IHoldBreathResult.AddProbability(builder, Probability);
			IHoldBreathResult.AddType(builder, Type);
			return IHoldBreathResult.EndIHoldBreathResult(builder);
		}

		// Token: 0x0601A5B4 RID: 107956 RVA: 0x003C3190 File Offset: 0x003C1390
		public static void StartIHoldBreathResult(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601A5B5 RID: 107957 RVA: 0x003C3199 File Offset: 0x003C1399
		public static void AddType(FlatBufferBuilder builder, EDartSkillResultType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A5B6 RID: 107958 RVA: 0x003C31A4 File Offset: 0x003C13A4
		public static void AddProbability(FlatBufferBuilder builder, int probability)
		{
			builder.AddInt(1, probability, 0);
		}

		// Token: 0x0601A5B7 RID: 107959 RVA: 0x003C31AF File Offset: 0x003C13AF
		public static void AddSpeedReducePercent(FlatBufferBuilder builder, int speedReducePercent)
		{
			builder.AddInt(2, speedReducePercent, 0);
		}

		// Token: 0x0601A5B8 RID: 107960 RVA: 0x003C31BA File Offset: 0x003C13BA
		public static Offset<IHoldBreathResult> EndIHoldBreathResult(FlatBufferBuilder builder)
		{
			return new Offset<IHoldBreathResult>(builder.EndTable());
		}

		// Token: 0x0601A5B9 RID: 107961 RVA: 0x003C31C8 File Offset: 0x003C13C8
		public IHoldBreathResultT UnPack()
		{
			IHoldBreathResultT holdBreathResultT = new IHoldBreathResultT();
			this.UnPackTo(holdBreathResultT);
			return holdBreathResultT;
		}

		// Token: 0x0601A5BA RID: 107962 RVA: 0x003C31E3 File Offset: 0x003C13E3
		public void UnPackTo(IHoldBreathResultT _o)
		{
			_o.Type = this.Type;
			_o.Probability = this.Probability;
			_o.SpeedReducePercent = this.SpeedReducePercent;
		}

		// Token: 0x0601A5BB RID: 107963 RVA: 0x003C320C File Offset: 0x003C140C
		public static Offset<IHoldBreathResult> Pack(FlatBufferBuilder builder, IHoldBreathResultT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHoldBreathResult>);
			}
			return IHoldBreathResult.CreateIHoldBreathResult(builder, _o.Type, _o.Probability, _o.SpeedReducePercent);
		}

		// Token: 0x0400C4F4 RID: 50420
		private Table __p;
	}
}
