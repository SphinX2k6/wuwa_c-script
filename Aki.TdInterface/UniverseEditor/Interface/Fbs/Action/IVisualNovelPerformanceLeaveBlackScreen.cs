using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DA6 RID: 32166
	public struct IVisualNovelPerformanceLeaveBlackScreen : IFlatbufferObject
	{
		// Token: 0x1700F0C4 RID: 61636
		// (get) Token: 0x0603A17E RID: 237950 RVA: 0x007D4D4E File Offset: 0x007D2F4E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A17F RID: 237951 RVA: 0x007D4D5B File Offset: 0x007D2F5B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A180 RID: 237952 RVA: 0x007D4D64 File Offset: 0x007D2F64
		public static IVisualNovelPerformanceLeaveBlackScreen GetRootAsIVisualNovelPerformanceLeaveBlackScreen(ByteBuffer _bb)
		{
			return IVisualNovelPerformanceLeaveBlackScreen.GetRootAsIVisualNovelPerformanceLeaveBlackScreen(_bb, default(IVisualNovelPerformanceLeaveBlackScreen));
		}

		// Token: 0x0603A181 RID: 237953 RVA: 0x007D4D80 File Offset: 0x007D2F80
		public static IVisualNovelPerformanceLeaveBlackScreen GetRootAsIVisualNovelPerformanceLeaveBlackScreen(ByteBuffer _bb, IVisualNovelPerformanceLeaveBlackScreen obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A182 RID: 237954 RVA: 0x007D4D9D File Offset: 0x007D2F9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A183 RID: 237955 RVA: 0x007D4DAC File Offset: 0x007D2FAC
		public IVisualNovelPerformanceLeaveBlackScreen __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F0C5 RID: 61637
		// (get) Token: 0x0603A184 RID: 237956 RVA: 0x007D4DBC File Offset: 0x007D2FBC
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

		// Token: 0x1700F0C6 RID: 61638
		// (get) Token: 0x0603A185 RID: 237957 RVA: 0x007D4DF8 File Offset: 0x007D2FF8
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

		// Token: 0x1700F0C7 RID: 61639
		// (get) Token: 0x0603A186 RID: 237958 RVA: 0x007D4E38 File Offset: 0x007D3038
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

		// Token: 0x0603A187 RID: 237959 RVA: 0x007D4E74 File Offset: 0x007D3074
		public TTable? EaseCurve<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603A188 RID: 237960 RVA: 0x007D4EBC File Offset: 0x007D30BC
		public IEaseCurveCustom EaseCurveAsIEaseCurveCustom()
		{
			return this.EaseCurve<IEaseCurveCustom>().Value;
		}

		// Token: 0x0603A189 RID: 237961 RVA: 0x007D4ED8 File Offset: 0x007D30D8
		public IEaseCurvePreset EaseCurveAsIEaseCurvePreset()
		{
			return this.EaseCurve<IEaseCurvePreset>().Value;
		}

		// Token: 0x1700F0C8 RID: 61640
		// (get) Token: 0x0603A18A RID: 237962 RVA: 0x007D4EF4 File Offset: 0x007D30F4
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

		// Token: 0x1700F0C9 RID: 61641
		// (get) Token: 0x0603A18B RID: 237963 RVA: 0x007D4F38 File Offset: 0x007D3138
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

		// Token: 0x0603A18C RID: 237964 RVA: 0x007D4F75 File Offset: 0x007D3175
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

		// Token: 0x0603A18D RID: 237965 RVA: 0x007D4FB1 File Offset: 0x007D31B1
		public static void StartIVisualNovelPerformanceLeaveBlackScreen(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0603A18E RID: 237966 RVA: 0x007D4FBA File Offset: 0x007D31BA
		public static void AddType(FlatBufferBuilder builder, EVisualNovelPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603A18F RID: 237967 RVA: 0x007D4FC5 File Offset: 0x007D31C5
		public static void AddStartTime(FlatBufferBuilder builder, float startTime)
		{
			builder.AddFloat(1, startTime, 0.0);
		}

		// Token: 0x0603A190 RID: 237968 RVA: 0x007D4FD8 File Offset: 0x007D31D8
		public static void AddEaseCurveType(FlatBufferBuilder builder, TEaseCurveType easeCurveType)
		{
			builder.AddByte(2, (byte)easeCurveType, 0);
		}

		// Token: 0x0603A191 RID: 237969 RVA: 0x007D4FE3 File Offset: 0x007D31E3
		public static void AddEaseCurve(FlatBufferBuilder builder, int easeCurveOffset)
		{
			builder.AddOffset(3, easeCurveOffset, 0);
		}

		// Token: 0x0603A192 RID: 237970 RVA: 0x007D4FEE File Offset: 0x007D31EE
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(4, fadeOutTime, 0.0);
		}

		// Token: 0x0603A193 RID: 237971 RVA: 0x007D5001 File Offset: 0x007D3201
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0603A194 RID: 237972 RVA: 0x007D500C File Offset: 0x007D320C
		public static Offset<IVisualNovelPerformanceLeaveBlackScreen> EndIVisualNovelPerformanceLeaveBlackScreen(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelPerformanceLeaveBlackScreen>(builder.EndTable());
		}

		// Token: 0x0603A195 RID: 237973 RVA: 0x007D501C File Offset: 0x007D321C
		public IVisualNovelPerformanceLeaveBlackScreenT UnPack()
		{
			IVisualNovelPerformanceLeaveBlackScreenT visualNovelPerformanceLeaveBlackScreenT = new IVisualNovelPerformanceLeaveBlackScreenT();
			this.UnPackTo(visualNovelPerformanceLeaveBlackScreenT);
			return visualNovelPerformanceLeaveBlackScreenT;
		}

		// Token: 0x0603A196 RID: 237974 RVA: 0x007D5038 File Offset: 0x007D3238
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

		// Token: 0x0603A197 RID: 237975 RVA: 0x007D5110 File Offset: 0x007D3310
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

		// Token: 0x04013518 RID: 79128
		private Table __p;
	}
}
