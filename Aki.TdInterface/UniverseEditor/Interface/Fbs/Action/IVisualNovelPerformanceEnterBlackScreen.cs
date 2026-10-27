using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075A7 RID: 30119
	public struct IVisualNovelPerformanceEnterBlackScreen : IFlatbufferObject
	{
		// Token: 0x1700E47B RID: 58491
		// (get) Token: 0x06036CFC RID: 224508 RVA: 0x00770C6B File Offset: 0x0076EE6B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036CFD RID: 224509 RVA: 0x00770C78 File Offset: 0x0076EE78
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036CFE RID: 224510 RVA: 0x00770C80 File Offset: 0x0076EE80
		public static IVisualNovelPerformanceEnterBlackScreen GetRootAsIVisualNovelPerformanceEnterBlackScreen(ByteBuffer _bb)
		{
			return IVisualNovelPerformanceEnterBlackScreen.GetRootAsIVisualNovelPerformanceEnterBlackScreen(_bb, default(IVisualNovelPerformanceEnterBlackScreen));
		}

		// Token: 0x06036CFF RID: 224511 RVA: 0x00770C9C File Offset: 0x0076EE9C
		public static IVisualNovelPerformanceEnterBlackScreen GetRootAsIVisualNovelPerformanceEnterBlackScreen(ByteBuffer _bb, IVisualNovelPerformanceEnterBlackScreen obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036D00 RID: 224512 RVA: 0x00770CB9 File Offset: 0x0076EEB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036D01 RID: 224513 RVA: 0x00770CC8 File Offset: 0x0076EEC8
		public IVisualNovelPerformanceEnterBlackScreen __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E47C RID: 58492
		// (get) Token: 0x06036D02 RID: 224514 RVA: 0x00770CD8 File Offset: 0x0076EED8
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

		// Token: 0x1700E47D RID: 58493
		// (get) Token: 0x06036D03 RID: 224515 RVA: 0x00770D14 File Offset: 0x0076EF14
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

		// Token: 0x1700E47E RID: 58494
		// (get) Token: 0x06036D04 RID: 224516 RVA: 0x00770D54 File Offset: 0x0076EF54
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

		// Token: 0x06036D05 RID: 224517 RVA: 0x00770D90 File Offset: 0x0076EF90
		public TTable? EaseCurve<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06036D06 RID: 224518 RVA: 0x00770DD8 File Offset: 0x0076EFD8
		public IEaseCurveCustom EaseCurveAsIEaseCurveCustom()
		{
			return this.EaseCurve<IEaseCurveCustom>().Value;
		}

		// Token: 0x06036D07 RID: 224519 RVA: 0x00770DF4 File Offset: 0x0076EFF4
		public IEaseCurvePreset EaseCurveAsIEaseCurvePreset()
		{
			return this.EaseCurve<IEaseCurvePreset>().Value;
		}

		// Token: 0x1700E47F RID: 58495
		// (get) Token: 0x06036D08 RID: 224520 RVA: 0x00770E10 File Offset: 0x0076F010
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

		// Token: 0x1700E480 RID: 58496
		// (get) Token: 0x06036D09 RID: 224521 RVA: 0x00770E54 File Offset: 0x0076F054
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

		// Token: 0x1700E481 RID: 58497
		// (get) Token: 0x06036D0A RID: 224522 RVA: 0x00770E94 File Offset: 0x0076F094
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

		// Token: 0x06036D0B RID: 224523 RVA: 0x00770ED4 File Offset: 0x0076F0D4
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

		// Token: 0x06036D0C RID: 224524 RVA: 0x00770F23 File Offset: 0x0076F123
		public static void StartIVisualNovelPerformanceEnterBlackScreen(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06036D0D RID: 224525 RVA: 0x00770F2C File Offset: 0x0076F12C
		public static void AddType(FlatBufferBuilder builder, EVisualNovelPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036D0E RID: 224526 RVA: 0x00770F37 File Offset: 0x0076F137
		public static void AddStartTime(FlatBufferBuilder builder, float startTime)
		{
			builder.AddFloat(1, startTime, 0.0);
		}

		// Token: 0x06036D0F RID: 224527 RVA: 0x00770F4A File Offset: 0x0076F14A
		public static void AddEaseCurveType(FlatBufferBuilder builder, TEaseCurveType easeCurveType)
		{
			builder.AddByte(2, (byte)easeCurveType, 0);
		}

		// Token: 0x06036D10 RID: 224528 RVA: 0x00770F55 File Offset: 0x0076F155
		public static void AddEaseCurve(FlatBufferBuilder builder, int easeCurveOffset)
		{
			builder.AddOffset(3, easeCurveOffset, 0);
		}

		// Token: 0x06036D11 RID: 224529 RVA: 0x00770F60 File Offset: 0x0076F160
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(4, fadeInTime, 0.0);
		}

		// Token: 0x06036D12 RID: 224530 RVA: 0x00770F73 File Offset: 0x0076F173
		public static void AddScreenType(FlatBufferBuilder builder, EVisualNovelBlackScreenType screenType)
		{
			builder.AddByte(5, (byte)screenType, 0);
		}

		// Token: 0x06036D13 RID: 224531 RVA: 0x00770F7E File Offset: 0x0076F17E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06036D14 RID: 224532 RVA: 0x00770F89 File Offset: 0x0076F189
		public static Offset<IVisualNovelPerformanceEnterBlackScreen> EndIVisualNovelPerformanceEnterBlackScreen(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelPerformanceEnterBlackScreen>(builder.EndTable());
		}

		// Token: 0x06036D15 RID: 224533 RVA: 0x00770F98 File Offset: 0x0076F198
		public IVisualNovelPerformanceEnterBlackScreenT UnPack()
		{
			IVisualNovelPerformanceEnterBlackScreenT visualNovelPerformanceEnterBlackScreenT = new IVisualNovelPerformanceEnterBlackScreenT();
			this.UnPackTo(visualNovelPerformanceEnterBlackScreenT);
			return visualNovelPerformanceEnterBlackScreenT;
		}

		// Token: 0x06036D16 RID: 224534 RVA: 0x00770FB4 File Offset: 0x0076F1B4
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

		// Token: 0x06036D17 RID: 224535 RVA: 0x00771098 File Offset: 0x0076F298
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

		// Token: 0x040124D6 RID: 74966
		private Table __p;
	}
}
