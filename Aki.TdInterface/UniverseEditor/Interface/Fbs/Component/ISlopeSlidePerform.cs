using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F45 RID: 24389
	public struct ISlopeSlidePerform : IFlatbufferObject
	{
		// Token: 0x1700B4A0 RID: 46240
		// (get) Token: 0x06028FBC RID: 167868 RVA: 0x005995E2 File Offset: 0x005977E2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028FBD RID: 167869 RVA: 0x005995EF File Offset: 0x005977EF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028FBE RID: 167870 RVA: 0x005995F8 File Offset: 0x005977F8
		public static ISlopeSlidePerform GetRootAsISlopeSlidePerform(ByteBuffer _bb)
		{
			return ISlopeSlidePerform.GetRootAsISlopeSlidePerform(_bb, default(ISlopeSlidePerform));
		}

		// Token: 0x06028FBF RID: 167871 RVA: 0x00599614 File Offset: 0x00597814
		public static ISlopeSlidePerform GetRootAsISlopeSlidePerform(ByteBuffer _bb, ISlopeSlidePerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028FC0 RID: 167872 RVA: 0x00599631 File Offset: 0x00597831
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028FC1 RID: 167873 RVA: 0x00599640 File Offset: 0x00597840
		public ISlopeSlidePerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B4A1 RID: 46241
		// (get) Token: 0x06028FC2 RID: 167874 RVA: 0x00599650 File Offset: 0x00597850
		public ESlidePerformType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESlidePerformType.SlopeSlide;
				}
				return (ESlidePerformType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B4A2 RID: 46242
		// (get) Token: 0x06028FC3 RID: 167875 RVA: 0x0059968C File Offset: 0x0059788C
		public int TriggerLandingDistance
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

		// Token: 0x1700B4A3 RID: 46243
		// (get) Token: 0x06028FC4 RID: 167876 RVA: 0x005996C8 File Offset: 0x005978C8
		public int FallbackLandingPointId
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

		// Token: 0x1700B4A4 RID: 46244
		// (get) Token: 0x06028FC5 RID: 167877 RVA: 0x00599704 File Offset: 0x00597904
		public bool IsAllowJump
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B4A5 RID: 46245
		// (get) Token: 0x06028FC6 RID: 167878 RVA: 0x00599744 File Offset: 0x00597944
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028FC7 RID: 167879 RVA: 0x00599781 File Offset: 0x00597981
		public static Offset<ISlopeSlidePerform> CreateISlopeSlidePerform(FlatBufferBuilder builder, ESlidePerformType Type = ESlidePerformType.SlopeSlide, int TriggerLandingDistance = 0, int FallbackLandingPointId = 0, bool IsAllowJump = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			ISlopeSlidePerform.AddFallbackLandingPointId(builder, FallbackLandingPointId);
			ISlopeSlidePerform.AddTriggerLandingDistance(builder, TriggerLandingDistance);
			ISlopeSlidePerform.AddNullMask(builder, NullMask);
			ISlopeSlidePerform.AddIsAllowJump(builder, IsAllowJump);
			ISlopeSlidePerform.AddType(builder, Type);
			return ISlopeSlidePerform.EndISlopeSlidePerform(builder);
		}

		// Token: 0x06028FC8 RID: 167880 RVA: 0x005997B5 File Offset: 0x005979B5
		public static void StartISlopeSlidePerform(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06028FC9 RID: 167881 RVA: 0x005997BE File Offset: 0x005979BE
		public static void AddType(FlatBufferBuilder builder, ESlidePerformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028FCA RID: 167882 RVA: 0x005997C9 File Offset: 0x005979C9
		public static void AddTriggerLandingDistance(FlatBufferBuilder builder, int triggerLandingDistance)
		{
			builder.AddInt(1, triggerLandingDistance, 0);
		}

		// Token: 0x06028FCB RID: 167883 RVA: 0x005997D4 File Offset: 0x005979D4
		public static void AddFallbackLandingPointId(FlatBufferBuilder builder, int fallbackLandingPointId)
		{
			builder.AddInt(2, fallbackLandingPointId, 0);
		}

		// Token: 0x06028FCC RID: 167884 RVA: 0x005997DF File Offset: 0x005979DF
		public static void AddIsAllowJump(FlatBufferBuilder builder, bool isAllowJump)
		{
			builder.AddBool(3, isAllowJump, false);
		}

		// Token: 0x06028FCD RID: 167885 RVA: 0x005997EA File Offset: 0x005979EA
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06028FCE RID: 167886 RVA: 0x005997F5 File Offset: 0x005979F5
		public static Offset<ISlopeSlidePerform> EndISlopeSlidePerform(FlatBufferBuilder builder)
		{
			return new Offset<ISlopeSlidePerform>(builder.EndTable());
		}

		// Token: 0x06028FCF RID: 167887 RVA: 0x00599804 File Offset: 0x00597A04
		public ISlopeSlidePerformT UnPack()
		{
			ISlopeSlidePerformT slopeSlidePerformT = new ISlopeSlidePerformT();
			this.UnPackTo(slopeSlidePerformT);
			return slopeSlidePerformT;
		}

		// Token: 0x06028FD0 RID: 167888 RVA: 0x0059981F File Offset: 0x00597A1F
		public void UnPackTo(ISlopeSlidePerformT _o)
		{
			_o.Type = this.Type;
			_o.TriggerLandingDistance = this.TriggerLandingDistance;
			_o.FallbackLandingPointId = this.FallbackLandingPointId;
			_o.IsAllowJump = this.IsAllowJump;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06028FD1 RID: 167889 RVA: 0x00599860 File Offset: 0x00597A60
		public static Offset<ISlopeSlidePerform> Pack(FlatBufferBuilder builder, ISlopeSlidePerformT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISlopeSlidePerform>);
			}
			return ISlopeSlidePerform.CreateISlopeSlidePerform(builder, _o.Type, _o.TriggerLandingDistance, _o.FallbackLandingPointId, _o.IsAllowJump, _o.NullMask);
		}

		// Token: 0x0400FBFB RID: 64507
		private Table __p;
	}
}
