using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044D6 RID: 17622
	public struct IHitRemainScoreZoneResult : IFlatbufferObject
	{
		// Token: 0x17007C5E RID: 31838
		// (get) Token: 0x0601A56A RID: 107882 RVA: 0x003C274A File Offset: 0x003C094A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A56B RID: 107883 RVA: 0x003C2757 File Offset: 0x003C0957
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A56C RID: 107884 RVA: 0x003C2760 File Offset: 0x003C0960
		public static IHitRemainScoreZoneResult GetRootAsIHitRemainScoreZoneResult(ByteBuffer _bb)
		{
			return IHitRemainScoreZoneResult.GetRootAsIHitRemainScoreZoneResult(_bb, default(IHitRemainScoreZoneResult));
		}

		// Token: 0x0601A56D RID: 107885 RVA: 0x003C277C File Offset: 0x003C097C
		public static IHitRemainScoreZoneResult GetRootAsIHitRemainScoreZoneResult(ByteBuffer _bb, IHitRemainScoreZoneResult obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A56E RID: 107886 RVA: 0x003C2799 File Offset: 0x003C0999
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A56F RID: 107887 RVA: 0x003C27A8 File Offset: 0x003C09A8
		public IHitRemainScoreZoneResult __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007C5F RID: 31839
		// (get) Token: 0x0601A570 RID: 107888 RVA: 0x003C27B8 File Offset: 0x003C09B8
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

		// Token: 0x17007C60 RID: 31840
		// (get) Token: 0x0601A571 RID: 107889 RVA: 0x003C27F4 File Offset: 0x003C09F4
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

		// Token: 0x0601A572 RID: 107890 RVA: 0x003C2830 File Offset: 0x003C0A30
		public static Offset<IHitRemainScoreZoneResult> CreateIHitRemainScoreZoneResult(FlatBufferBuilder builder, EDartSkillResultType Type = EDartSkillResultType.NoBust, int Probability = 0)
		{
			builder.StartTable(2);
			IHitRemainScoreZoneResult.AddProbability(builder, Probability);
			IHitRemainScoreZoneResult.AddType(builder, Type);
			return IHitRemainScoreZoneResult.EndIHitRemainScoreZoneResult(builder);
		}

		// Token: 0x0601A573 RID: 107891 RVA: 0x003C284D File Offset: 0x003C0A4D
		public static void StartIHitRemainScoreZoneResult(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601A574 RID: 107892 RVA: 0x003C2856 File Offset: 0x003C0A56
		public static void AddType(FlatBufferBuilder builder, EDartSkillResultType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A575 RID: 107893 RVA: 0x003C2861 File Offset: 0x003C0A61
		public static void AddProbability(FlatBufferBuilder builder, int probability)
		{
			builder.AddInt(1, probability, 0);
		}

		// Token: 0x0601A576 RID: 107894 RVA: 0x003C286C File Offset: 0x003C0A6C
		public static Offset<IHitRemainScoreZoneResult> EndIHitRemainScoreZoneResult(FlatBufferBuilder builder)
		{
			return new Offset<IHitRemainScoreZoneResult>(builder.EndTable());
		}

		// Token: 0x0601A577 RID: 107895 RVA: 0x003C287C File Offset: 0x003C0A7C
		public IHitRemainScoreZoneResultT UnPack()
		{
			IHitRemainScoreZoneResultT hitRemainScoreZoneResultT = new IHitRemainScoreZoneResultT();
			this.UnPackTo(hitRemainScoreZoneResultT);
			return hitRemainScoreZoneResultT;
		}

		// Token: 0x0601A578 RID: 107896 RVA: 0x003C2897 File Offset: 0x003C0A97
		public void UnPackTo(IHitRemainScoreZoneResultT _o)
		{
			_o.Type = this.Type;
			_o.Probability = this.Probability;
		}

		// Token: 0x0601A579 RID: 107897 RVA: 0x003C28B4 File Offset: 0x003C0AB4
		public static Offset<IHitRemainScoreZoneResult> Pack(FlatBufferBuilder builder, IHitRemainScoreZoneResultT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHitRemainScoreZoneResult>);
			}
			return IHitRemainScoreZoneResult.CreateIHitRemainScoreZoneResult(builder, _o.Type, _o.Probability);
		}

		// Token: 0x0400C4ED RID: 50413
		private Table __p;
	}
}
