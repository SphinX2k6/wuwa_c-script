using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075B3 RID: 30131
	public struct IVisualNovelPerformanceMove : IFlatbufferObject
	{
		// Token: 0x1700E4AF RID: 58543
		// (get) Token: 0x06036D9C RID: 224668 RVA: 0x00772260 File Offset: 0x00770460
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036D9D RID: 224669 RVA: 0x0077226D File Offset: 0x0077046D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036D9E RID: 224670 RVA: 0x00772274 File Offset: 0x00770474
		public static IVisualNovelPerformanceMove GetRootAsIVisualNovelPerformanceMove(ByteBuffer _bb)
		{
			return IVisualNovelPerformanceMove.GetRootAsIVisualNovelPerformanceMove(_bb, default(IVisualNovelPerformanceMove));
		}

		// Token: 0x06036D9F RID: 224671 RVA: 0x00772290 File Offset: 0x00770490
		public static IVisualNovelPerformanceMove GetRootAsIVisualNovelPerformanceMove(ByteBuffer _bb, IVisualNovelPerformanceMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036DA0 RID: 224672 RVA: 0x007722AD File Offset: 0x007704AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036DA1 RID: 224673 RVA: 0x007722BC File Offset: 0x007704BC
		public IVisualNovelPerformanceMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E4B0 RID: 58544
		// (get) Token: 0x06036DA2 RID: 224674 RVA: 0x007722CC File Offset: 0x007704CC
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

		// Token: 0x1700E4B1 RID: 58545
		// (get) Token: 0x06036DA3 RID: 224675 RVA: 0x00772308 File Offset: 0x00770508
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

		// Token: 0x1700E4B2 RID: 58546
		// (get) Token: 0x06036DA4 RID: 224676 RVA: 0x00772348 File Offset: 0x00770548
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

		// Token: 0x1700E4B3 RID: 58547
		// (get) Token: 0x06036DA5 RID: 224677 RVA: 0x00772384 File Offset: 0x00770584
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

		// Token: 0x1700E4B4 RID: 58548
		// (get) Token: 0x06036DA6 RID: 224678 RVA: 0x007723E4 File Offset: 0x007705E4
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

		// Token: 0x06036DA7 RID: 224679 RVA: 0x00772424 File Offset: 0x00770624
		public TTable? EaseCurve<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06036DA8 RID: 224680 RVA: 0x0077246C File Offset: 0x0077066C
		public IEaseCurveCustom EaseCurveAsIEaseCurveCustom()
		{
			return this.EaseCurve<IEaseCurveCustom>().Value;
		}

		// Token: 0x06036DA9 RID: 224681 RVA: 0x00772488 File Offset: 0x00770688
		public IEaseCurvePreset EaseCurveAsIEaseCurvePreset()
		{
			return this.EaseCurve<IEaseCurvePreset>().Value;
		}

		// Token: 0x1700E4B5 RID: 58549
		// (get) Token: 0x06036DAA RID: 224682 RVA: 0x007724A4 File Offset: 0x007706A4
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

		// Token: 0x1700E4B6 RID: 58550
		// (get) Token: 0x06036DAB RID: 224683 RVA: 0x007724E8 File Offset: 0x007706E8
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

		// Token: 0x1700E4B7 RID: 58551
		// (get) Token: 0x06036DAC RID: 224684 RVA: 0x00772548 File Offset: 0x00770748
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

		// Token: 0x06036DAD RID: 224685 RVA: 0x00772588 File Offset: 0x00770788
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

		// Token: 0x06036DAE RID: 224686 RVA: 0x007725E8 File Offset: 0x007707E8
		public static void StartIVisualNovelPerformanceMove(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06036DAF RID: 224687 RVA: 0x007725F2 File Offset: 0x007707F2
		public static void AddType(FlatBufferBuilder builder, EVisualNovelPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036DB0 RID: 224688 RVA: 0x007725FD File Offset: 0x007707FD
		public static void AddStartTime(FlatBufferBuilder builder, float startTime)
		{
			builder.AddFloat(1, startTime, 0.0);
		}

		// Token: 0x06036DB1 RID: 224689 RVA: 0x00772610 File Offset: 0x00770810
		public static void AddWhoId(FlatBufferBuilder builder, int whoId)
		{
			builder.AddInt(2, whoId, 0);
		}

		// Token: 0x06036DB2 RID: 224690 RVA: 0x0077261B File Offset: 0x0077081B
		public static void AddTransform(FlatBufferBuilder builder, Offset<IVisualNovelPortraitTransform> transformOffset)
		{
			builder.AddOffset(3, transformOffset.Value, 0);
		}

		// Token: 0x06036DB3 RID: 224691 RVA: 0x0077262B File Offset: 0x0077082B
		public static void AddEaseCurveType(FlatBufferBuilder builder, TEaseCurveType easeCurveType)
		{
			builder.AddByte(4, (byte)easeCurveType, 0);
		}

		// Token: 0x06036DB4 RID: 224692 RVA: 0x00772636 File Offset: 0x00770836
		public static void AddEaseCurve(FlatBufferBuilder builder, int easeCurveOffset)
		{
			builder.AddOffset(5, easeCurveOffset, 0);
		}

		// Token: 0x06036DB5 RID: 224693 RVA: 0x00772641 File Offset: 0x00770841
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(6, duration, 0.0);
		}

		// Token: 0x06036DB6 RID: 224694 RVA: 0x00772654 File Offset: 0x00770854
		public static void AddRoleConfig(FlatBufferBuilder builder, Offset<IVisualNovelRoleConfig> roleConfigOffset)
		{
			builder.AddOffset(7, roleConfigOffset.Value, 0);
		}

		// Token: 0x06036DB7 RID: 224695 RVA: 0x00772664 File Offset: 0x00770864
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06036DB8 RID: 224696 RVA: 0x0077266F File Offset: 0x0077086F
		public static Offset<IVisualNovelPerformanceMove> EndIVisualNovelPerformanceMove(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelPerformanceMove>(builder.EndTable());
		}

		// Token: 0x06036DB9 RID: 224697 RVA: 0x0077267C File Offset: 0x0077087C
		public IVisualNovelPerformanceMoveT UnPack()
		{
			IVisualNovelPerformanceMoveT visualNovelPerformanceMoveT = new IVisualNovelPerformanceMoveT();
			this.UnPackTo(visualNovelPerformanceMoveT);
			return visualNovelPerformanceMoveT;
		}

		// Token: 0x06036DBA RID: 224698 RVA: 0x00772698 File Offset: 0x00770898
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

		// Token: 0x06036DBB RID: 224699 RVA: 0x007727E0 File Offset: 0x007709E0
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

		// Token: 0x040124F2 RID: 74994
		private Table __p;
	}
}
