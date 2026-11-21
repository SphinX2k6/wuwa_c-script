using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DA0 RID: 32160
	public struct IVisualNovelPerformanceEnterBlackScreen : IFlatbufferObject
	{
		// Token: 0x1700F0A8 RID: 61608
		// (get) Token: 0x0603A12A RID: 237866 RVA: 0x007D41EB File Offset: 0x007D23EB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A12B RID: 237867 RVA: 0x007D41F8 File Offset: 0x007D23F8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A12C RID: 237868 RVA: 0x007D4200 File Offset: 0x007D2400
		public static IVisualNovelPerformanceEnterBlackScreen GetRootAsIVisualNovelPerformanceEnterBlackScreen(ByteBuffer _bb)
		{
			return IVisualNovelPerformanceEnterBlackScreen.GetRootAsIVisualNovelPerformanceEnterBlackScreen(_bb, default(IVisualNovelPerformanceEnterBlackScreen));
		}

		// Token: 0x0603A12D RID: 237869 RVA: 0x007D421C File Offset: 0x007D241C
		public static IVisualNovelPerformanceEnterBlackScreen GetRootAsIVisualNovelPerformanceEnterBlackScreen(ByteBuffer _bb, IVisualNovelPerformanceEnterBlackScreen obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A12E RID: 237870 RVA: 0x007D4239 File Offset: 0x007D2439
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A12F RID: 237871 RVA: 0x007D4248 File Offset: 0x007D2448
		public IVisualNovelPerformanceEnterBlackScreen __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F0A9 RID: 61609
		// (get) Token: 0x0603A130 RID: 237872 RVA: 0x007D4258 File Offset: 0x007D2458
		public EVisualNovelPerformanceType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisualNovelPerformanceType.Enter;
				}
				return (EVisualNovelPerformanceType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700F0AA RID: 61610
		// (get) Token: 0x0603A131 RID: 237873 RVA: 0x007D4294 File Offset: 0x007D2494
		public float StartTime
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700F0AB RID: 61611
		// (get) Token: 0x0603A132 RID: 237874 RVA: 0x007D42D4 File Offset: 0x007D24D4
		public TEaseCurveType EaseCurveType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TEaseCurveType.NONE;
				}
				return (TEaseCurveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603A133 RID: 237875 RVA: 0x007D4310 File Offset: 0x007D2510
		public TTable? EaseCurve<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603A134 RID: 237876 RVA: 0x007D4358 File Offset: 0x007D2558
		public IEaseCurveCustom EaseCurveAsIEaseCurveCustom()
		{
			return this.EaseCurve<IEaseCurveCustom>().Value;
		}

		// Token: 0x0603A135 RID: 237877 RVA: 0x007D4374 File Offset: 0x007D2574
		public IEaseCurvePreset EaseCurveAsIEaseCurvePreset()
		{
			return this.EaseCurve<IEaseCurvePreset>().Value;
		}

		// Token: 0x1700F0AC RID: 61612
		// (get) Token: 0x0603A136 RID: 237878 RVA: 0x007D4390 File Offset: 0x007D2590
		public float FadeInTime
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700F0AD RID: 61613
		// (get) Token: 0x0603A137 RID: 237879 RVA: 0x007D43D4 File Offset: 0x007D25D4
		public EVisualNovelBlackScreenType ScreenType
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return EVisualNovelBlackScreenType.Black;
				}
				return (EVisualNovelBlackScreenType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700F0AE RID: 61614
		// (get) Token: 0x0603A138 RID: 237880 RVA: 0x007D4414 File Offset: 0x007D2614
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603A139 RID: 237881 RVA: 0x007D4454 File Offset: 0x007D2654
		public static Offset<IVisualNovelPerformanceEnterBlackScreen> CreateIVisualNovelPerformanceEnterBlackScreen(FlatBufferBuilder builder, EVisualNovelPerformanceType Type = EVisualNovelPerformanceType.Enter, float StartTime = 0f, TEaseCurveType EaseCurve_type = TEaseCurveType.NONE, int EaseCurveOffset = 0, float FadeInTime = 0f, EVisualNovelBlackScreenType ScreenType = EVisualNovelBlackScreenType.Black, byte NullMask = 0)
		{
			builder.StartTable(7);
			IVisualNovelPerformanceEnterBlackScreen.AddFadeInTime(builder, FadeInTime);
			IVisualNovelPerformanceEnterBlackScreen.AddEaseCurve(builder, EaseCurveOffset);
			IVisualNovelPerformanceEnterBlackScreen.AddStartTime(builder, StartTime);
			IVisualNovelPerformanceEnterBlackScreen.AddNullMask(builder, NullMask);
			IVisualNovelPerformanceEnterBlackScreen.AddScreenType(builder, ScreenType);
			IVisualNovelPerformanceEnterBlackScreen.AddEaseCurveType(builder, EaseCurve_type);
			IVisualNovelPerformanceEnterBlackScreen.AddType(builder, Type);
			return IVisualNovelPerformanceEnterBlackScreen.EndIVisualNovelPerformanceEnterBlackScreen(builder);
		}

		// Token: 0x0603A13A RID: 237882 RVA: 0x007D44A3 File Offset: 0x007D26A3
		public static void StartIVisualNovelPerformanceEnterBlackScreen(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0603A13B RID: 237883 RVA: 0x007D44AC File Offset: 0x007D26AC
		public static void AddType(FlatBufferBuilder builder, EVisualNovelPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603A13C RID: 237884 RVA: 0x007D44B7 File Offset: 0x007D26B7
		public static void AddStartTime(FlatBufferBuilder builder, float startTime)
		{
			builder.AddFloat(1, startTime, 0.0);
		}

		// Token: 0x0603A13D RID: 237885 RVA: 0x007D44CA File Offset: 0x007D26CA
		public static void AddEaseCurveType(FlatBufferBuilder builder, TEaseCurveType easeCurveType)
		{
			builder.AddByte(2, (byte)easeCurveType, 0);
		}

		// Token: 0x0603A13E RID: 237886 RVA: 0x007D44D5 File Offset: 0x007D26D5
		public static void AddEaseCurve(FlatBufferBuilder builder, int easeCurveOffset)
		{
			builder.AddOffset(3, easeCurveOffset, 0);
		}

		// Token: 0x0603A13F RID: 237887 RVA: 0x007D44E0 File Offset: 0x007D26E0
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(4, fadeInTime, 0.0);
		}

		// Token: 0x0603A140 RID: 237888 RVA: 0x007D44F3 File Offset: 0x007D26F3
		public static void AddScreenType(FlatBufferBuilder builder, EVisualNovelBlackScreenType screenType)
		{
			builder.AddByte(5, (byte)screenType, 0);
		}

		// Token: 0x0603A141 RID: 237889 RVA: 0x007D44FE File Offset: 0x007D26FE
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0603A142 RID: 237890 RVA: 0x007D4509 File Offset: 0x007D2709
		public static Offset<IVisualNovelPerformanceEnterBlackScreen> EndIVisualNovelPerformanceEnterBlackScreen(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelPerformanceEnterBlackScreen>(builder.EndTable());
		}

		// Token: 0x0603A143 RID: 237891 RVA: 0x007D4518 File Offset: 0x007D2718
		public IVisualNovelPerformanceEnterBlackScreenT UnPack()
		{
			IVisualNovelPerformanceEnterBlackScreenT visualNovelPerformanceEnterBlackScreenT = new IVisualNovelPerformanceEnterBlackScreenT();
			this.UnPackTo(visualNovelPerformanceEnterBlackScreenT);
			return visualNovelPerformanceEnterBlackScreenT;
		}

		// Token: 0x0603A144 RID: 237892 RVA: 0x007D4534 File Offset: 0x007D2734
		public void UnPackTo(IVisualNovelPerformanceEnterBlackScreenT _o)
		{
			_o.Type = this.Type;
			_o.StartTime = this.StartTime;
			_o.EaseCurve = new TEaseCurveTypeUnion();
			_o.EaseCurve.Type = this.EaseCurveType;
			TEaseCurveType easeCurveType = this.EaseCurveType;
			if (easeCurveType != TEaseCurveType.IEaseCurveCustom)
			{
				if (easeCurveType == TEaseCurveType.IEaseCurvePreset)
				{
					_o.EaseCurve.Value = ((this.EaseCurve<IEaseCurvePreset>() != null) ? this.EaseCurve<IEaseCurvePreset>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.EaseCurve.Value = ((this.EaseCurve<IEaseCurveCustom>() != null) ? this.EaseCurve<IEaseCurveCustom>().Value.UnPack() : null);
			}
			_o.FadeInTime = this.FadeInTime;
			_o.ScreenType = this.ScreenType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603A145 RID: 237893 RVA: 0x007D4618 File Offset: 0x007D2818
		public static Offset<IVisualNovelPerformanceEnterBlackScreen> Pack(FlatBufferBuilder builder, IVisualNovelPerformanceEnterBlackScreenT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelPerformanceEnterBlackScreen>);
			}
			TEaseCurveType easeCurve_type = (_o.EaseCurve == null) ? TEaseCurveType.NONE : _o.EaseCurve.Type;
			int easeCurveOffset = (_o.EaseCurve == null) ? 0 : TEaseCurveTypeUnion.Pack(builder, _o.EaseCurve);
			return IVisualNovelPerformanceEnterBlackScreen.CreateIVisualNovelPerformanceEnterBlackScreen(builder, _o.Type, _o.StartTime, easeCurve_type, easeCurveOffset, _o.FadeInTime, _o.ScreenType, _o.NullMask);
		}

		// Token: 0x04013509 RID: 79113
		private Table __p;
	}
}
