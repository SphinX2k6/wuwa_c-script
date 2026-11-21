using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DE2 RID: 32226
	public struct IVisualNovelRoleIntroductionSolarSchool : IFlatbufferObject
	{
		// Token: 0x1700F16C RID: 61804
		// (get) Token: 0x0603A3CF RID: 238543 RVA: 0x007D934A File Offset: 0x007D754A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A3D0 RID: 238544 RVA: 0x007D9357 File Offset: 0x007D7557
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A3D1 RID: 238545 RVA: 0x007D9360 File Offset: 0x007D7560
		public static IVisualNovelRoleIntroductionSolarSchool GetRootAsIVisualNovelRoleIntroductionSolarSchool(ByteBuffer _bb)
		{
			return IVisualNovelRoleIntroductionSolarSchool.GetRootAsIVisualNovelRoleIntroductionSolarSchool(_bb, default(IVisualNovelRoleIntroductionSolarSchool));
		}

		// Token: 0x0603A3D2 RID: 238546 RVA: 0x007D937C File Offset: 0x007D757C
		public static IVisualNovelRoleIntroductionSolarSchool GetRootAsIVisualNovelRoleIntroductionSolarSchool(ByteBuffer _bb, IVisualNovelRoleIntroductionSolarSchool obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A3D3 RID: 238547 RVA: 0x007D9399 File Offset: 0x007D7599
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A3D4 RID: 238548 RVA: 0x007D93A8 File Offset: 0x007D75A8
		public IVisualNovelRoleIntroductionSolarSchool __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F16D RID: 61805
		// (get) Token: 0x0603A3D5 RID: 238549 RVA: 0x007D93B8 File Offset: 0x007D75B8
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

		// Token: 0x1700F16E RID: 61806
		// (get) Token: 0x0603A3D6 RID: 238550 RVA: 0x007D93F4 File Offset: 0x007D75F4
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

		// Token: 0x1700F16F RID: 61807
		// (get) Token: 0x0603A3D7 RID: 238551 RVA: 0x007D9430 File Offset: 0x007D7630
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

		// Token: 0x1700F170 RID: 61808
		// (get) Token: 0x0603A3D8 RID: 238552 RVA: 0x007D9470 File Offset: 0x007D7670
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

		// Token: 0x0603A3D9 RID: 238553 RVA: 0x007D94AD File Offset: 0x007D76AD
		public static Offset<IVisualNovelRoleIntroductionSolarSchool> CreateIVisualNovelRoleIntroductionSolarSchool(FlatBufferBuilder builder, EVisualNovelSubType Type = EVisualNovelSubType.SolarSchool, int IntroductionId = 0, float Duration = 0f, byte NullMask = 0)
		{
			builder.StartTable(4);
			IVisualNovelRoleIntroductionSolarSchool.AddDuration(builder, Duration);
			IVisualNovelRoleIntroductionSolarSchool.AddIntroductionId(builder, IntroductionId);
			IVisualNovelRoleIntroductionSolarSchool.AddNullMask(builder, NullMask);
			IVisualNovelRoleIntroductionSolarSchool.AddType(builder, Type);
			return IVisualNovelRoleIntroductionSolarSchool.EndIVisualNovelRoleIntroductionSolarSchool(builder);
		}

		// Token: 0x0603A3DA RID: 238554 RVA: 0x007D94D9 File Offset: 0x007D76D9
		public static void StartIVisualNovelRoleIntroductionSolarSchool(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0603A3DB RID: 238555 RVA: 0x007D94E2 File Offset: 0x007D76E2
		public static void AddType(FlatBufferBuilder builder, EVisualNovelSubType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603A3DC RID: 238556 RVA: 0x007D94ED File Offset: 0x007D76ED
		public static void AddIntroductionId(FlatBufferBuilder builder, int introductionId)
		{
			builder.AddInt(1, introductionId, 0);
		}

		// Token: 0x0603A3DD RID: 238557 RVA: 0x007D94F8 File Offset: 0x007D76F8
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(2, duration, 0.0);
		}

		// Token: 0x0603A3DE RID: 238558 RVA: 0x007D950B File Offset: 0x007D770B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0603A3DF RID: 238559 RVA: 0x007D9516 File Offset: 0x007D7716
		public static Offset<IVisualNovelRoleIntroductionSolarSchool> EndIVisualNovelRoleIntroductionSolarSchool(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelRoleIntroductionSolarSchool>(builder.EndTable());
		}

		// Token: 0x0603A3E0 RID: 238560 RVA: 0x007D9524 File Offset: 0x007D7724
		public IVisualNovelRoleIntroductionSolarSchoolT UnPack()
		{
			IVisualNovelRoleIntroductionSolarSchoolT visualNovelRoleIntroductionSolarSchoolT = new IVisualNovelRoleIntroductionSolarSchoolT();
			this.UnPackTo(visualNovelRoleIntroductionSolarSchoolT);
			return visualNovelRoleIntroductionSolarSchoolT;
		}

		// Token: 0x0603A3E1 RID: 238561 RVA: 0x007D953F File Offset: 0x007D773F
		public void UnPackTo(IVisualNovelRoleIntroductionSolarSchoolT _o)
		{
			_o.Type = this.Type;
			_o.IntroductionId = this.IntroductionId;
			_o.Duration = this.Duration;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603A3E2 RID: 238562 RVA: 0x007D9574 File Offset: 0x007D7774
		public static Offset<IVisualNovelRoleIntroductionSolarSchool> Pack(FlatBufferBuilder builder, IVisualNovelRoleIntroductionSolarSchoolT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelRoleIntroductionSolarSchool>);
			}
			return IVisualNovelRoleIntroductionSolarSchool.CreateIVisualNovelRoleIntroductionSolarSchool(builder, _o.Type, _o.IntroductionId, _o.Duration, _o.NullMask);
		}

		// Token: 0x04013581 RID: 79233
		private Table __p;
	}
}
