using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044D0 RID: 17616
	public struct IHitNoScoreResult : IFlatbufferObject
	{
		// Token: 0x17007C56 RID: 31830
		// (get) Token: 0x0601A542 RID: 107842 RVA: 0x003C23D2 File Offset: 0x003C05D2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A543 RID: 107843 RVA: 0x003C23DF File Offset: 0x003C05DF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A544 RID: 107844 RVA: 0x003C23E8 File Offset: 0x003C05E8
		public static IHitNoScoreResult GetRootAsIHitNoScoreResult(ByteBuffer _bb)
		{
			return IHitNoScoreResult.GetRootAsIHitNoScoreResult(_bb, default(IHitNoScoreResult));
		}

		// Token: 0x0601A545 RID: 107845 RVA: 0x003C2404 File Offset: 0x003C0604
		public static IHitNoScoreResult GetRootAsIHitNoScoreResult(ByteBuffer _bb, IHitNoScoreResult obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A546 RID: 107846 RVA: 0x003C2421 File Offset: 0x003C0621
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A547 RID: 107847 RVA: 0x003C2430 File Offset: 0x003C0630
		public IHitNoScoreResult __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007C57 RID: 31831
		// (get) Token: 0x0601A548 RID: 107848 RVA: 0x003C2440 File Offset: 0x003C0640
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

		// Token: 0x0601A549 RID: 107849 RVA: 0x003C247C File Offset: 0x003C067C
		public static Offset<IHitNoScoreResult> CreateIHitNoScoreResult(FlatBufferBuilder builder, EDartSkillResultType Type = EDartSkillResultType.NoBust)
		{
			builder.StartTable(1);
			IHitNoScoreResult.AddType(builder, Type);
			return IHitNoScoreResult.EndIHitNoScoreResult(builder);
		}

		// Token: 0x0601A54A RID: 107850 RVA: 0x003C2492 File Offset: 0x003C0692
		public static void StartIHitNoScoreResult(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601A54B RID: 107851 RVA: 0x003C249B File Offset: 0x003C069B
		public static void AddType(FlatBufferBuilder builder, EDartSkillResultType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A54C RID: 107852 RVA: 0x003C24A6 File Offset: 0x003C06A6
		public static Offset<IHitNoScoreResult> EndIHitNoScoreResult(FlatBufferBuilder builder)
		{
			return new Offset<IHitNoScoreResult>(builder.EndTable());
		}

		// Token: 0x0601A54D RID: 107853 RVA: 0x003C24B4 File Offset: 0x003C06B4
		public IHitNoScoreResultT UnPack()
		{
			IHitNoScoreResultT hitNoScoreResultT = new IHitNoScoreResultT();
			this.UnPackTo(hitNoScoreResultT);
			return hitNoScoreResultT;
		}

		// Token: 0x0601A54E RID: 107854 RVA: 0x003C24CF File Offset: 0x003C06CF
		public void UnPackTo(IHitNoScoreResultT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601A54F RID: 107855 RVA: 0x003C24E0 File Offset: 0x003C06E0
		public static Offset<IHitNoScoreResult> Pack(FlatBufferBuilder builder, IHitNoScoreResultT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHitNoScoreResult>);
			}
			return IHitNoScoreResult.CreateIHitNoScoreResult(builder, _o.Type);
		}

		// Token: 0x0400C4E8 RID: 50408
		private Table __p;
	}
}
