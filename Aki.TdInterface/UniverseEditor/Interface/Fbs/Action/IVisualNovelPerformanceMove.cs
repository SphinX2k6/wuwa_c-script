using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DAC RID: 32172
	public struct IVisualNovelPerformanceMove : IFlatbufferObject
	{
		// Token: 0x1700F0DC RID: 61660
		// (get) Token: 0x0603A1CA RID: 238026 RVA: 0x007D57E0 File Offset: 0x007D39E0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A1CB RID: 238027 RVA: 0x007D57ED File Offset: 0x007D39ED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A1CC RID: 238028 RVA: 0x007D57F4 File Offset: 0x007D39F4
		public static IVisualNovelPerformanceMove GetRootAsIVisualNovelPerformanceMove(ByteBuffer _bb)
		{
			return IVisualNovelPerformanceMove.GetRootAsIVisualNovelPerformanceMove(_bb, default(IVisualNovelPerformanceMove));
		}

		// Token: 0x0603A1CD RID: 238029 RVA: 0x007D5810 File Offset: 0x007D3A10
		public static IVisualNovelPerformanceMove GetRootAsIVisualNovelPerformanceMove(ByteBuffer _bb, IVisualNovelPerformanceMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A1CE RID: 238030 RVA: 0x007D582D File Offset: 0x007D3A2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A1CF RID: 238031 RVA: 0x007D583C File Offset: 0x007D3A3C
		public IVisualNovelPerformanceMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F0DD RID: 61661
		// (get) Token: 0x0603A1D0 RID: 238032 RVA: 0x007D584C File Offset: 0x007D3A4C
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

		// Token: 0x1700F0DE RID: 61662
		// (get) Token: 0x0603A1D1 RID: 238033 RVA: 0x007D5888 File Offset: 0x007D3A88
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

		// Token: 0x1700F0DF RID: 61663
		// (get) Token: 0x0603A1D2 RID: 238034 RVA: 0x007D58C8 File Offset: 0x007D3AC8
		public int WhoId
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

		// Token: 0x1700F0E0 RID: 61664
		// (get) Token: 0x0603A1D3 RID: 238035 RVA: 0x007D5904 File Offset: 0x007D3B04
		public IVisualNovelPortraitTransform? Transform
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IVisualNovelPortraitTransform?(default(IVisualNovelPortraitTransform).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700F0E1 RID: 61665
		// (get) Token: 0x0603A1D4 RID: 238036 RVA: 0x007D5964 File Offset: 0x007D3B64
		public TEaseCurveType EaseCurveType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return TEaseCurveType.NONE;
				}
				return (TEaseCurveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603A1D5 RID: 238037 RVA: 0x007D59A4 File Offset: 0x007D3BA4
		public TTable? EaseCurve<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603A1D6 RID: 238038 RVA: 0x007D59EC File Offset: 0x007D3BEC
		public IEaseCurveCustom EaseCurveAsIEaseCurveCustom()
		{
			return this.EaseCurve<IEaseCurveCustom>().Value;
		}

		// Token: 0x0603A1D7 RID: 238039 RVA: 0x007D5A08 File Offset: 0x007D3C08
		public IEaseCurvePreset EaseCurveAsIEaseCurvePreset()
		{
			return this.EaseCurve<IEaseCurvePreset>().Value;
		}

		// Token: 0x1700F0E2 RID: 61666
		// (get) Token: 0x0603A1D8 RID: 238040 RVA: 0x007D5A24 File Offset: 0x007D3C24
		public float Duration
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700F0E3 RID: 61667
		// (get) Token: 0x0603A1D9 RID: 238041 RVA: 0x007D5A68 File Offset: 0x007D3C68
		public IVisualNovelRoleConfig? RoleConfig
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return new IVisualNovelRoleConfig?(default(IVisualNovelRoleConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700F0E4 RID: 61668
		// (get) Token: 0x0603A1DA RID: 238042 RVA: 0x007D5AC8 File Offset: 0x007D3CC8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603A1DB RID: 238043 RVA: 0x007D5B08 File Offset: 0x007D3D08
		public static Offset<IVisualNovelPerformanceMove> CreateIVisualNovelPerformanceMove(FlatBufferBuilder builder, EVisualNovelPerformanceType Type = EVisualNovelPerformanceType.Enter, float StartTime = 0f, int WhoId = 0, Offset<IVisualNovelPortraitTransform> TransformOffset = default(Offset<IVisualNovelPortraitTransform>), TEaseCurveType EaseCurve_type = TEaseCurveType.NONE, int EaseCurveOffset = 0, float Duration = 0f, Offset<IVisualNovelRoleConfig> RoleConfigOffset = default(Offset<IVisualNovelRoleConfig>), byte NullMask = 0)
		{
			builder.StartTable(9);
			IVisualNovelPerformanceMove.AddRoleConfig(builder, RoleConfigOffset);
			IVisualNovelPerformanceMove.AddDuration(builder, Duration);
			IVisualNovelPerformanceMove.AddEaseCurve(builder, EaseCurveOffset);
			IVisualNovelPerformanceMove.AddTransform(builder, TransformOffset);
			IVisualNovelPerformanceMove.AddWhoId(builder, WhoId);
			IVisualNovelPerformanceMove.AddStartTime(builder, StartTime);
			IVisualNovelPerformanceMove.AddNullMask(builder, NullMask);
			IVisualNovelPerformanceMove.AddEaseCurveType(builder, EaseCurve_type);
			IVisualNovelPerformanceMove.AddType(builder, Type);
			return IVisualNovelPerformanceMove.EndIVisualNovelPerformanceMove(builder);
		}

		// Token: 0x0603A1DC RID: 238044 RVA: 0x007D5B68 File Offset: 0x007D3D68
		public static void StartIVisualNovelPerformanceMove(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x0603A1DD RID: 238045 RVA: 0x007D5B72 File Offset: 0x007D3D72
		public static void AddType(FlatBufferBuilder builder, EVisualNovelPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603A1DE RID: 238046 RVA: 0x007D5B7D File Offset: 0x007D3D7D
		public static void AddStartTime(FlatBufferBuilder builder, float startTime)
		{
			builder.AddFloat(1, startTime, 0.0);
		}

		// Token: 0x0603A1DF RID: 238047 RVA: 0x007D5B90 File Offset: 0x007D3D90
		public static void AddWhoId(FlatBufferBuilder builder, int whoId)
		{
			builder.AddInt(2, whoId, 0);
		}

		// Token: 0x0603A1E0 RID: 238048 RVA: 0x007D5B9B File Offset: 0x007D3D9B
		public static void AddTransform(FlatBufferBuilder builder, Offset<IVisualNovelPortraitTransform> transformOffset)
		{
			builder.AddOffset(3, transformOffset.Value, 0);
		}

		// Token: 0x0603A1E1 RID: 238049 RVA: 0x007D5BAB File Offset: 0x007D3DAB
		public static void AddEaseCurveType(FlatBufferBuilder builder, TEaseCurveType easeCurveType)
		{
			builder.AddByte(4, (byte)easeCurveType, 0);
		}

		// Token: 0x0603A1E2 RID: 238050 RVA: 0x007D5BB6 File Offset: 0x007D3DB6
		public static void AddEaseCurve(FlatBufferBuilder builder, int easeCurveOffset)
		{
			builder.AddOffset(5, easeCurveOffset, 0);
		}

		// Token: 0x0603A1E3 RID: 238051 RVA: 0x007D5BC1 File Offset: 0x007D3DC1
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(6, duration, 0.0);
		}

		// Token: 0x0603A1E4 RID: 238052 RVA: 0x007D5BD4 File Offset: 0x007D3DD4
		public static void AddRoleConfig(FlatBufferBuilder builder, Offset<IVisualNovelRoleConfig> roleConfigOffset)
		{
			builder.AddOffset(7, roleConfigOffset.Value, 0);
		}

		// Token: 0x0603A1E5 RID: 238053 RVA: 0x007D5BE4 File Offset: 0x007D3DE4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x0603A1E6 RID: 238054 RVA: 0x007D5BEF File Offset: 0x007D3DEF
		public static Offset<IVisualNovelPerformanceMove> EndIVisualNovelPerformanceMove(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelPerformanceMove>(builder.EndTable());
		}

		// Token: 0x0603A1E7 RID: 238055 RVA: 0x007D5BFC File Offset: 0x007D3DFC
		public IVisualNovelPerformanceMoveT UnPack()
		{
			IVisualNovelPerformanceMoveT visualNovelPerformanceMoveT = new IVisualNovelPerformanceMoveT();
			this.UnPackTo(visualNovelPerformanceMoveT);
			return visualNovelPerformanceMoveT;
		}

		// Token: 0x0603A1E8 RID: 238056 RVA: 0x007D5C18 File Offset: 0x007D3E18
		public void UnPackTo(IVisualNovelPerformanceMoveT _o)
		{
			_o.Type = this.Type;
			_o.StartTime = this.StartTime;
			_o.WhoId = this.WhoId;
			_o.Transform = ((this.Transform != null) ? this.Transform.Value.UnPack() : null);
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
			_o.Duration = this.Duration;
			_o.RoleConfig = ((this.RoleConfig != null) ? this.RoleConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603A1E9 RID: 238057 RVA: 0x007D5D60 File Offset: 0x007D3F60
		public static Offset<IVisualNovelPerformanceMove> Pack(FlatBufferBuilder builder, IVisualNovelPerformanceMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelPerformanceMove>);
			}
			Offset<IVisualNovelPortraitTransform> transformOffset = (_o.Transform == null) ? default(Offset<IVisualNovelPortraitTransform>) : IVisualNovelPortraitTransform.Pack(builder, _o.Transform);
			TEaseCurveType easeCurve_type = (_o.EaseCurve == null) ? TEaseCurveType.NONE : _o.EaseCurve.Type;
			int easeCurveOffset = (_o.EaseCurve == null) ? 0 : TEaseCurveTypeUnion.Pack(builder, _o.EaseCurve);
			Offset<IVisualNovelRoleConfig> roleConfigOffset = (_o.RoleConfig == null) ? default(Offset<IVisualNovelRoleConfig>) : IVisualNovelRoleConfig.Pack(builder, _o.RoleConfig);
			return IVisualNovelPerformanceMove.CreateIVisualNovelPerformanceMove(builder, _o.Type, _o.StartTime, _o.WhoId, transformOffset, easeCurve_type, easeCurveOffset, _o.Duration, roleConfigOffset, _o.NullMask);
		}

		// Token: 0x04013525 RID: 79141
		private Table __p;
	}
}
