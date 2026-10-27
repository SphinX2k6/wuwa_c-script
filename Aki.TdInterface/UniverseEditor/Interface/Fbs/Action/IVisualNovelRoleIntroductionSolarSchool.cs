using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075DD RID: 30173
	public struct IVisualNovelRoleIntroductionSolarSchool : IFlatbufferObject
	{
		// Token: 0x1700E538 RID: 58680
		// (get) Token: 0x06036F60 RID: 225120 RVA: 0x007756F6 File Offset: 0x007738F6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036F61 RID: 225121 RVA: 0x00775703 File Offset: 0x00773903
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036F62 RID: 225122 RVA: 0x0077570C File Offset: 0x0077390C
		public static IVisualNovelRoleIntroductionSolarSchool GetRootAsIVisualNovelRoleIntroductionSolarSchool(ByteBuffer _bb)
		{
			return IVisualNovelRoleIntroductionSolarSchool.GetRootAsIVisualNovelRoleIntroductionSolarSchool(_bb, default(IVisualNovelRoleIntroductionSolarSchool));
		}

		// Token: 0x06036F63 RID: 225123 RVA: 0x00775728 File Offset: 0x00773928
		public static IVisualNovelRoleIntroductionSolarSchool GetRootAsIVisualNovelRoleIntroductionSolarSchool(ByteBuffer _bb, IVisualNovelRoleIntroductionSolarSchool obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036F64 RID: 225124 RVA: 0x00775745 File Offset: 0x00773945
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036F65 RID: 225125 RVA: 0x00775754 File Offset: 0x00773954
		public IVisualNovelRoleIntroductionSolarSchool __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E539 RID: 58681
		// (get) Token: 0x06036F66 RID: 225126 RVA: 0x00775764 File Offset: 0x00773964
		public EVisualNovelSubType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisualNovelSubType.SolarSchool;
				}
				return (EVisualNovelSubType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E53A RID: 58682
		// (get) Token: 0x06036F67 RID: 225127 RVA: 0x007757A0 File Offset: 0x007739A0
		public int IntroductionId
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

		// Token: 0x1700E53B RID: 58683
		// (get) Token: 0x06036F68 RID: 225128 RVA: 0x007757DC File Offset: 0x007739DC
		public float Duration
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E53C RID: 58684
		// (get) Token: 0x06036F69 RID: 225129 RVA: 0x0077581C File Offset: 0x00773A1C
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

		// Token: 0x06036F6A RID: 225130 RVA: 0x00775859 File Offset: 0x00773A59
		public static Offset<IVisualNovelRoleIntroductionSolarSchool> CreateIVisualNovelRoleIntroductionSolarSchool(FlatBufferBuilder builder, EVisualNovelSubType Type = EVisualNovelSubType.SolarSchool, int IntroductionId = 0, float Duration = 0f, byte NullMask = 0)
		{
			builder.StartTable(4);
			IVisualNovelRoleIntroductionSolarSchool.AddDuration(builder, Duration);
			IVisualNovelRoleIntroductionSolarSchool.AddIntroductionId(builder, IntroductionId);
			IVisualNovelRoleIntroductionSolarSchool.AddNullMask(builder, NullMask);
			IVisualNovelRoleIntroductionSolarSchool.AddType(builder, Type);
			return IVisualNovelRoleIntroductionSolarSchool.EndIVisualNovelRoleIntroductionSolarSchool(builder);
		}

		// Token: 0x06036F6B RID: 225131 RVA: 0x00775885 File Offset: 0x00773A85
		public static void StartIVisualNovelRoleIntroductionSolarSchool(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06036F6C RID: 225132 RVA: 0x0077588E File Offset: 0x00773A8E
		public static void AddType(FlatBufferBuilder builder, EVisualNovelSubType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036F6D RID: 225133 RVA: 0x00775899 File Offset: 0x00773A99
		public static void AddIntroductionId(FlatBufferBuilder builder, int introductionId)
		{
			builder.AddInt(1, introductionId, 0);
		}

		// Token: 0x06036F6E RID: 225134 RVA: 0x007758A4 File Offset: 0x00773AA4
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(2, duration, 0.0);
		}

		// Token: 0x06036F6F RID: 225135 RVA: 0x007758B7 File Offset: 0x00773AB7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06036F70 RID: 225136 RVA: 0x007758C2 File Offset: 0x00773AC2
		public static Offset<IVisualNovelRoleIntroductionSolarSchool> EndIVisualNovelRoleIntroductionSolarSchool(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelRoleIntroductionSolarSchool>(builder.EndTable());
		}

		// Token: 0x06036F71 RID: 225137 RVA: 0x007758D0 File Offset: 0x00773AD0
		public IVisualNovelRoleIntroductionSolarSchoolT UnPack()
		{
			IVisualNovelRoleIntroductionSolarSchoolT visualNovelRoleIntroductionSolarSchoolT = new IVisualNovelRoleIntroductionSolarSchoolT();
			this.UnPackTo(visualNovelRoleIntroductionSolarSchoolT);
			return visualNovelRoleIntroductionSolarSchoolT;
		}

		// Token: 0x06036F72 RID: 225138 RVA: 0x007758EB File Offset: 0x00773AEB
		public void UnPackTo(IVisualNovelRoleIntroductionSolarSchoolT _o)
		{
			_o.Type = this.Type;
			_o.IntroductionId = this.IntroductionId;
			_o.Duration = this.Duration;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06036F73 RID: 225139 RVA: 0x00775920 File Offset: 0x00773B20
		public static Offset<IVisualNovelRoleIntroductionSolarSchool> Pack(FlatBufferBuilder builder, IVisualNovelRoleIntroductionSolarSchoolT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelRoleIntroductionSolarSchool>);
			}
			return IVisualNovelRoleIntroductionSolarSchool.CreateIVisualNovelRoleIntroductionSolarSchool(builder, _o.Type, _o.IntroductionId, _o.Duration, _o.NullMask);
		}

		// Token: 0x04012542 RID: 75074
		private Table __p;
	}
}
