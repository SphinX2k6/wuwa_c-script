using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007592 RID: 30098
	public struct IVisualNovelOptionGroupSolarSchoolExam : IFlatbufferObject
	{
		// Token: 0x1700E433 RID: 58419
		// (get) Token: 0x06036BF4 RID: 224244 RVA: 0x0076E8C2 File Offset: 0x0076CAC2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036BF5 RID: 224245 RVA: 0x0076E8CF File Offset: 0x0076CACF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036BF6 RID: 224246 RVA: 0x0076E8D8 File Offset: 0x0076CAD8
		public static IVisualNovelOptionGroupSolarSchoolExam GetRootAsIVisualNovelOptionGroupSolarSchoolExam(ByteBuffer _bb)
		{
			return IVisualNovelOptionGroupSolarSchoolExam.GetRootAsIVisualNovelOptionGroupSolarSchoolExam(_bb, default(IVisualNovelOptionGroupSolarSchoolExam));
		}

		// Token: 0x06036BF7 RID: 224247 RVA: 0x0076E8F4 File Offset: 0x0076CAF4
		public static IVisualNovelOptionGroupSolarSchoolExam GetRootAsIVisualNovelOptionGroupSolarSchoolExam(ByteBuffer _bb, IVisualNovelOptionGroupSolarSchoolExam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036BF8 RID: 224248 RVA: 0x0076E911 File Offset: 0x0076CB11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036BF9 RID: 224249 RVA: 0x0076E920 File Offset: 0x0076CB20
		public IVisualNovelOptionGroupSolarSchoolExam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E434 RID: 58420
		// (get) Token: 0x06036BFA RID: 224250 RVA: 0x0076E930 File Offset: 0x0076CB30
		public EVisualNovelOptionGroupType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisualNovelOptionGroupType.SolarSchoolExam;
				}
				return (EVisualNovelOptionGroupType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E435 RID: 58421
		// (get) Token: 0x06036BFB RID: 224251 RVA: 0x0076E96C File Offset: 0x0076CB6C
		public int ExamImageId
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

		// Token: 0x1700E436 RID: 58422
		// (get) Token: 0x06036BFC RID: 224252 RVA: 0x0076E9A8 File Offset: 0x0076CBA8
		public int TrueAnswerOptionIndex
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

		// Token: 0x1700E437 RID: 58423
		// (get) Token: 0x06036BFD RID: 224253 RVA: 0x0076E9E4 File Offset: 0x0076CBE4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036BFE RID: 224254 RVA: 0x0076EA21 File Offset: 0x0076CC21
		public static Offset<IVisualNovelOptionGroupSolarSchoolExam> CreateIVisualNovelOptionGroupSolarSchoolExam(FlatBufferBuilder builder, EVisualNovelOptionGroupType Type = EVisualNovelOptionGroupType.SolarSchoolExam, int ExamImageId = 0, int TrueAnswerOptionIndex = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IVisualNovelOptionGroupSolarSchoolExam.AddTrueAnswerOptionIndex(builder, TrueAnswerOptionIndex);
			IVisualNovelOptionGroupSolarSchoolExam.AddExamImageId(builder, ExamImageId);
			IVisualNovelOptionGroupSolarSchoolExam.AddNullMask(builder, NullMask);
			IVisualNovelOptionGroupSolarSchoolExam.AddType(builder, Type);
			return IVisualNovelOptionGroupSolarSchoolExam.EndIVisualNovelOptionGroupSolarSchoolExam(builder);
		}

		// Token: 0x06036BFF RID: 224255 RVA: 0x0076EA4D File Offset: 0x0076CC4D
		public static void StartIVisualNovelOptionGroupSolarSchoolExam(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06036C00 RID: 224256 RVA: 0x0076EA56 File Offset: 0x0076CC56
		public static void AddType(FlatBufferBuilder builder, EVisualNovelOptionGroupType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036C01 RID: 224257 RVA: 0x0076EA61 File Offset: 0x0076CC61
		public static void AddExamImageId(FlatBufferBuilder builder, int examImageId)
		{
			builder.AddInt(1, examImageId, 0);
		}

		// Token: 0x06036C02 RID: 224258 RVA: 0x0076EA6C File Offset: 0x0076CC6C
		public static void AddTrueAnswerOptionIndex(FlatBufferBuilder builder, int trueAnswerOptionIndex)
		{
			builder.AddInt(2, trueAnswerOptionIndex, 0);
		}

		// Token: 0x06036C03 RID: 224259 RVA: 0x0076EA77 File Offset: 0x0076CC77
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06036C04 RID: 224260 RVA: 0x0076EA82 File Offset: 0x0076CC82
		public static Offset<IVisualNovelOptionGroupSolarSchoolExam> EndIVisualNovelOptionGroupSolarSchoolExam(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelOptionGroupSolarSchoolExam>(builder.EndTable());
		}

		// Token: 0x06036C05 RID: 224261 RVA: 0x0076EA90 File Offset: 0x0076CC90
		public IVisualNovelOptionGroupSolarSchoolExamT UnPack()
		{
			IVisualNovelOptionGroupSolarSchoolExamT visualNovelOptionGroupSolarSchoolExamT = new IVisualNovelOptionGroupSolarSchoolExamT();
			this.UnPackTo(visualNovelOptionGroupSolarSchoolExamT);
			return visualNovelOptionGroupSolarSchoolExamT;
		}

		// Token: 0x06036C06 RID: 224262 RVA: 0x0076EAAB File Offset: 0x0076CCAB
		public void UnPackTo(IVisualNovelOptionGroupSolarSchoolExamT _o)
		{
			_o.Type = this.Type;
			_o.ExamImageId = this.ExamImageId;
			_o.TrueAnswerOptionIndex = this.TrueAnswerOptionIndex;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06036C07 RID: 224263 RVA: 0x0076EAE0 File Offset: 0x0076CCE0
		public static Offset<IVisualNovelOptionGroupSolarSchoolExam> Pack(FlatBufferBuilder builder, IVisualNovelOptionGroupSolarSchoolExamT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelOptionGroupSolarSchoolExam>);
			}
			return IVisualNovelOptionGroupSolarSchoolExam.CreateIVisualNovelOptionGroupSolarSchoolExam(builder, _o.Type, _o.ExamImageId, _o.TrueAnswerOptionIndex, _o.NullMask);
		}

		// Token: 0x0401249A RID: 74906
		private Table __p;
	}
}
