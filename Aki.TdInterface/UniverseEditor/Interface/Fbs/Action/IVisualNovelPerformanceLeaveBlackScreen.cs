using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075AD RID: 30125
	public struct IVisualNovelPerformanceLeaveBlackScreen : IFlatbufferObject
	{
		// Token: 0x1700E497 RID: 58519
		// (get) Token: 0x06036D50 RID: 224592 RVA: 0x007717CE File Offset: 0x0076F9CE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036D51 RID: 224593 RVA: 0x007717DB File Offset: 0x0076F9DB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036D52 RID: 224594 RVA: 0x007717E4 File Offset: 0x0076F9E4
		public static IVisualNovelPerformanceLeaveBlackScreen GetRootAsIVisualNovelPerformanceLeaveBlackScreen(ByteBuffer _bb)
		{
			return IVisualNovelPerformanceLeaveBlackScreen.GetRootAsIVisualNovelPerformanceLeaveBlackScreen(_bb, default(IVisualNovelPerformanceLeaveBlackScreen));
		}

		// Token: 0x06036D53 RID: 224595 RVA: 0x00771800 File Offset: 0x0076FA00
		public static IVisualNovelPerformanceLeaveBlackScreen GetRootAsIVisualNovelPerformanceLeaveBlackScreen(ByteBuffer _bb, IVisualNovelPerformanceLeaveBlackScreen obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036D54 RID: 224596 RVA: 0x0077181D File Offset: 0x0076FA1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036D55 RID: 224597 RVA: 0x0077182C File Offset: 0x0076FA2C
		public IVisualNovelPerformanceLeaveBlackScreen __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E498 RID: 58520
		// (get) Token: 0x06036D56 RID: 224598 RVA: 0x0077183C File Offset: 0x0076FA3C
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

		// Token: 0x1700E499 RID: 58521
		// (get) Token: 0x06036D57 RID: 224599 RVA: 0x00771878 File Offset: 0x0076FA78
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

		// Token: 0x1700E49A RID: 58522
		// (get) Token: 0x06036D58 RID: 224600 RVA: 0x007718B8 File Offset: 0x0076FAB8
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

		// Token: 0x06036D59 RID: 224601 RVA: 0x007718F4 File Offset: 0x0076FAF4
		public TTable? EaseCurve<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06036D5A RID: 224602 RVA: 0x0077193C File Offset: 0x0076FB3C
		public IEaseCurveCustom EaseCurveAsIEaseCurveCustom()
		{
			return this.EaseCurve<IEaseCurveCustom>().Value;
		}

		// Token: 0x06036D5B RID: 224603 RVA: 0x00771958 File Offset: 0x0076FB58
		public IEaseCurvePreset EaseCurveAsIEaseCurvePreset()
		{
			return this.EaseCurve<IEaseCurvePreset>().Value;
		}

		// Token: 0x1700E49B RID: 58523
		// (get) Token: 0x06036D5C RID: 224604 RVA: 0x00771974 File Offset: 0x0076FB74
		public float FadeOutTime
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

		// Token: 0x1700E49C RID: 58524
		// (get) Token: 0x06036D5D RID: 224605 RVA: 0x007719B8 File Offset: 0x0076FBB8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036D5E RID: 224606 RVA: 0x007719F5 File Offset: 0x0076FBF5
		public static Offset<IVisualNovelPerformanceLeaveBlackScreen> CreateIVisualNovelPerformanceLeaveBlackScreen(FlatBufferBuilder builder, EVisualNovelPerformanceType Type = EVisualNovelPerformanceType.Enter, float StartTime = 0f, TEaseCurveType EaseCurve_type = TEaseCurveType.NONE, int EaseCurveOffset = 0, float FadeOutTime = 0f, byte NullMask = 0)
		{
			builder.StartTable(6);
			IVisualNovelPerformanceLeaveBlackScreen.AddFadeOutTime(builder, FadeOutTime);
			IVisualNovelPerformanceLeaveBlackScreen.AddEaseCurve(builder, EaseCurveOffset);
			IVisualNovelPerformanceLeaveBlackScreen.AddStartTime(builder, StartTime);
			IVisualNovelPerformanceLeaveBlackScreen.AddNullMask(builder, NullMask);
			IVisualNovelPerformanceLeaveBlackScreen.AddEaseCurveType(builder, EaseCurve_type);
			IVisualNovelPerformanceLeaveBlackScreen.AddType(builder, Type);
			return IVisualNovelPerformanceLeaveBlackScreen.EndIVisualNovelPerformanceLeaveBlackScreen(builder);
		}

		// Token: 0x06036D5F RID: 224607 RVA: 0x00771A31 File Offset: 0x0076FC31
		public static void StartIVisualNovelPerformanceLeaveBlackScreen(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06036D60 RID: 224608 RVA: 0x00771A3A File Offset: 0x0076FC3A
		public static void AddType(FlatBufferBuilder builder, EVisualNovelPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036D61 RID: 224609 RVA: 0x00771A45 File Offset: 0x0076FC45
		public static void AddStartTime(FlatBufferBuilder builder, float startTime)
		{
			builder.AddFloat(1, startTime, 0.0);
		}

		// Token: 0x06036D62 RID: 224610 RVA: 0x00771A58 File Offset: 0x0076FC58
		public static void AddEaseCurveType(FlatBufferBuilder builder, TEaseCurveType easeCurveType)
		{
			builder.AddByte(2, (byte)easeCurveType, 0);
		}

		// Token: 0x06036D63 RID: 224611 RVA: 0x00771A63 File Offset: 0x0076FC63
		public static void AddEaseCurve(FlatBufferBuilder builder, int easeCurveOffset)
		{
			builder.AddOffset(3, easeCurveOffset, 0);
		}

		// Token: 0x06036D64 RID: 224612 RVA: 0x00771A6E File Offset: 0x0076FC6E
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(4, fadeOutTime, 0.0);
		}

		// Token: 0x06036D65 RID: 224613 RVA: 0x00771A81 File Offset: 0x0076FC81
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06036D66 RID: 224614 RVA: 0x00771A8C File Offset: 0x0076FC8C
		public static Offset<IVisualNovelPerformanceLeaveBlackScreen> EndIVisualNovelPerformanceLeaveBlackScreen(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelPerformanceLeaveBlackScreen>(builder.EndTable());
		}

		// Token: 0x06036D67 RID: 224615 RVA: 0x00771A9C File Offset: 0x0076FC9C
		public IVisualNovelPerformanceLeaveBlackScreenT UnPack()
		{
			IVisualNovelPerformanceLeaveBlackScreenT visualNovelPerformanceLeaveBlackScreenT = new IVisualNovelPerformanceLeaveBlackScreenT();
			this.UnPackTo(visualNovelPerformanceLeaveBlackScreenT);
			return visualNovelPerformanceLeaveBlackScreenT;
		}

		// Token: 0x06036D68 RID: 224616 RVA: 0x00771AB8 File Offset: 0x0076FCB8
		public void UnPackTo(IVisualNovelPerformanceLeaveBlackScreenT _o)
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
			_o.FadeOutTime = this.FadeOutTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06036D69 RID: 224617 RVA: 0x00771B90 File Offset: 0x0076FD90
		public static Offset<IVisualNovelPerformanceLeaveBlackScreen> Pack(FlatBufferBuilder builder, IVisualNovelPerformanceLeaveBlackScreenT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelPerformanceLeaveBlackScreen>);
			}
			TEaseCurveType easeCurve_type = (_o.EaseCurve == null) ? TEaseCurveType.NONE : _o.EaseCurve.Type;
			int easeCurveOffset = (_o.EaseCurve == null) ? 0 : TEaseCurveTypeUnion.Pack(builder, _o.EaseCurve);
			return IVisualNovelPerformanceLeaveBlackScreen.CreateIVisualNovelPerformanceLeaveBlackScreen(builder, _o.Type, _o.StartTime, easeCurve_type, easeCurveOffset, _o.FadeOutTime, _o.NullMask);
		}

		// Token: 0x040124E5 RID: 74981
		private Table __p;
	}
}
