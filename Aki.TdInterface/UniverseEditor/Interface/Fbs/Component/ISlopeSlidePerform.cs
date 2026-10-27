using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005938 RID: 22840
	public struct ISlopeSlidePerform : IFlatbufferObject
	{
		// Token: 0x1700AB6C RID: 43884
		// (get) Token: 0x06026A52 RID: 158290 RVA: 0x00552976 File Offset: 0x00550B76
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026A53 RID: 158291 RVA: 0x00552983 File Offset: 0x00550B83
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026A54 RID: 158292 RVA: 0x0055298C File Offset: 0x00550B8C
		public static ISlopeSlidePerform GetRootAsISlopeSlidePerform(ByteBuffer _bb)
		{
			return ISlopeSlidePerform.GetRootAsISlopeSlidePerform(_bb, default(ISlopeSlidePerform));
		}

		// Token: 0x06026A55 RID: 158293 RVA: 0x005529A8 File Offset: 0x00550BA8
		public static ISlopeSlidePerform GetRootAsISlopeSlidePerform(ByteBuffer _bb, ISlopeSlidePerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026A56 RID: 158294 RVA: 0x005529C5 File Offset: 0x00550BC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026A57 RID: 158295 RVA: 0x005529D4 File Offset: 0x00550BD4
		public ISlopeSlidePerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AB6D RID: 43885
		// (get) Token: 0x06026A58 RID: 158296 RVA: 0x005529E4 File Offset: 0x00550BE4
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

		// Token: 0x1700AB6E RID: 43886
		// (get) Token: 0x06026A59 RID: 158297 RVA: 0x00552A20 File Offset: 0x00550C20
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

		// Token: 0x1700AB6F RID: 43887
		// (get) Token: 0x06026A5A RID: 158298 RVA: 0x00552A5C File Offset: 0x00550C5C
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

		// Token: 0x1700AB70 RID: 43888
		// (get) Token: 0x06026A5B RID: 158299 RVA: 0x00552A98 File Offset: 0x00550C98
		public bool IsAllowJump
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AB71 RID: 43889
		// (get) Token: 0x06026A5C RID: 158300 RVA: 0x00552AD8 File Offset: 0x00550CD8
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

		// Token: 0x06026A5D RID: 158301 RVA: 0x00552B15 File Offset: 0x00550D15
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

		// Token: 0x06026A5E RID: 158302 RVA: 0x00552B49 File Offset: 0x00550D49
		public static void StartISlopeSlidePerform(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06026A5F RID: 158303 RVA: 0x00552B52 File Offset: 0x00550D52
		public static void AddType(FlatBufferBuilder builder, ESlidePerformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026A60 RID: 158304 RVA: 0x00552B5D File Offset: 0x00550D5D
		public static void AddTriggerLandingDistance(FlatBufferBuilder builder, int triggerLandingDistance)
		{
			builder.AddInt(1, triggerLandingDistance, 0);
		}

		// Token: 0x06026A61 RID: 158305 RVA: 0x00552B68 File Offset: 0x00550D68
		public static void AddFallbackLandingPointId(FlatBufferBuilder builder, int fallbackLandingPointId)
		{
			builder.AddInt(2, fallbackLandingPointId, 0);
		}

		// Token: 0x06026A62 RID: 158306 RVA: 0x00552B73 File Offset: 0x00550D73
		public static void AddIsAllowJump(FlatBufferBuilder builder, bool isAllowJump)
		{
			builder.AddBool(3, isAllowJump, false);
		}

		// Token: 0x06026A63 RID: 158307 RVA: 0x00552B7E File Offset: 0x00550D7E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06026A64 RID: 158308 RVA: 0x00552B89 File Offset: 0x00550D89
		public static Offset<ISlopeSlidePerform> EndISlopeSlidePerform(FlatBufferBuilder builder)
		{
			return new Offset<ISlopeSlidePerform>(builder.EndTable());
		}

		// Token: 0x06026A65 RID: 158309 RVA: 0x00552B98 File Offset: 0x00550D98
		public ISlopeSlidePerformT UnPack()
		{
			ISlopeSlidePerformT slopeSlidePerformT = new ISlopeSlidePerformT();
			this.UnPackTo(slopeSlidePerformT);
			return slopeSlidePerformT;
		}

		// Token: 0x06026A66 RID: 158310 RVA: 0x00552BB3 File Offset: 0x00550DB3
		public void UnPackTo(ISlopeSlidePerformT _o)
		{
			_o.Type = this.Type;
			_o.TriggerLandingDistance = this.TriggerLandingDistance;
			_o.FallbackLandingPointId = this.FallbackLandingPointId;
			_o.IsAllowJump = this.IsAllowJump;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06026A67 RID: 158311 RVA: 0x00552BF4 File Offset: 0x00550DF4
		public static Offset<ISlopeSlidePerform> Pack(FlatBufferBuilder builder, ISlopeSlidePerformT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISlopeSlidePerform>);
			}
			return ISlopeSlidePerform.CreateISlopeSlidePerform(builder, _o.Type, _o.TriggerLandingDistance, _o.FallbackLandingPointId, _o.IsAllowJump, _o.NullMask);
		}

		// Token: 0x0400EF06 RID: 61190
		private Table __p;
	}
}
