using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200421A RID: 16922
	public struct ITrackTarget : IFlatbufferObject
	{
		// Token: 0x1700782F RID: 30767
		// (get) Token: 0x06019019 RID: 102425 RVA: 0x00399258 File Offset: 0x00397458
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601901A RID: 102426 RVA: 0x00399265 File Offset: 0x00397465
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601901B RID: 102427 RVA: 0x0039926C File Offset: 0x0039746C
		public static ITrackTarget GetRootAsITrackTarget(ByteBuffer _bb)
		{
			return ITrackTarget.GetRootAsITrackTarget(_bb, default(ITrackTarget));
		}

		// Token: 0x0601901C RID: 102428 RVA: 0x00399288 File Offset: 0x00397488
		public static ITrackTarget GetRootAsITrackTarget(ByteBuffer _bb, ITrackTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601901D RID: 102429 RVA: 0x003992A5 File Offset: 0x003974A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601901E RID: 102430 RVA: 0x003992B4 File Offset: 0x003974B4
		public ITrackTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007830 RID: 30768
		// (get) Token: 0x0601901F RID: 102431 RVA: 0x003992C4 File Offset: 0x003974C4
		public TTrackType TrackTypeType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TTrackType.NONE;
				}
				return (TTrackType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019020 RID: 102432 RVA: 0x00399300 File Offset: 0x00397500
		public TTable? TrackType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06019021 RID: 102433 RVA: 0x00399344 File Offset: 0x00397544
		public ITrackCaptureVisions TrackTypeAsITrackCaptureVisions()
		{
			return this.TrackType<ITrackCaptureVisions>().Value;
		}

		// Token: 0x06019022 RID: 102434 RVA: 0x00399360 File Offset: 0x00397560
		public ITrackEntities TrackTypeAsITrackEntities()
		{
			return this.TrackType<ITrackEntities>().Value;
		}

		// Token: 0x06019023 RID: 102435 RVA: 0x0039937C File Offset: 0x0039757C
		public ITrackEntityGroup TrackTypeAsITrackEntityGroup()
		{
			return this.TrackType<ITrackEntityGroup>().Value;
		}

		// Token: 0x06019024 RID: 102436 RVA: 0x00399398 File Offset: 0x00397598
		public ITrackLevelPlay TrackTypeAsITrackLevelPlay()
		{
			return this.TrackType<ITrackLevelPlay>().Value;
		}

		// Token: 0x06019025 RID: 102437 RVA: 0x003993B4 File Offset: 0x003975B4
		public ITrackLocations TrackTypeAsITrackLocations()
		{
			return this.TrackType<ITrackLocations>().Value;
		}

		// Token: 0x17007831 RID: 30769
		// (get) Token: 0x06019026 RID: 102438 RVA: 0x003993D0 File Offset: 0x003975D0
		public ETrackViewMode TrackViewMode
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ETrackViewMode.All;
				}
				return (ETrackViewMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007832 RID: 30770
		// (get) Token: 0x06019027 RID: 102439 RVA: 0x0039940C File Offset: 0x0039760C
		public float Range
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007833 RID: 30771
		// (get) Token: 0x06019028 RID: 102440 RVA: 0x00399450 File Offset: 0x00397650
		public float ViewRange
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

		// Token: 0x17007834 RID: 30772
		// (get) Token: 0x06019029 RID: 102441 RVA: 0x00399494 File Offset: 0x00397694
		public IZaxisViewRange? ZaxisViewRange
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IZaxisViewRange?(default(IZaxisViewRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007835 RID: 30773
		// (get) Token: 0x0601902A RID: 102442 RVA: 0x003994F4 File Offset: 0x003976F4
		public ETrackEffect Effect
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return ETrackEffect.LongLightBeam;
				}
				return (ETrackEffect)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007836 RID: 30774
		// (get) Token: 0x0601902B RID: 102443 RVA: 0x00399534 File Offset: 0x00397734
		public ITrackEffectAutoChange? EffectOption
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return new ITrackEffectAutoChange?(default(ITrackEffectAutoChange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007837 RID: 30775
		// (get) Token: 0x0601902C RID: 102444 RVA: 0x00399594 File Offset: 0x00397794
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

		// Token: 0x0601902D RID: 102445 RVA: 0x003995D4 File Offset: 0x003977D4
		public static Offset<ITrackTarget> CreateITrackTarget(FlatBufferBuilder builder, TTrackType TrackType_type = TTrackType.NONE, int TrackTypeOffset = 0, ETrackViewMode TrackViewMode = ETrackViewMode.All, float Range = 0f, float ViewRange = 0f, Offset<IZaxisViewRange> ZaxisViewRangeOffset = default(Offset<IZaxisViewRange>), ETrackEffect Effect = ETrackEffect.LongLightBeam, Offset<ITrackEffectAutoChange> EffectOptionOffset = default(Offset<ITrackEffectAutoChange>), byte NullMask = 0)
		{
			builder.StartTable(9);
			ITrackTarget.AddEffectOption(builder, EffectOptionOffset);
			ITrackTarget.AddZaxisViewRange(builder, ZaxisViewRangeOffset);
			ITrackTarget.AddViewRange(builder, ViewRange);
			ITrackTarget.AddRange(builder, Range);
			ITrackTarget.AddTrackType(builder, TrackTypeOffset);
			ITrackTarget.AddNullMask(builder, NullMask);
			ITrackTarget.AddEffect(builder, Effect);
			ITrackTarget.AddTrackViewMode(builder, TrackViewMode);
			ITrackTarget.AddTrackTypeType(builder, TrackType_type);
			return ITrackTarget.EndITrackTarget(builder);
		}

		// Token: 0x0601902E RID: 102446 RVA: 0x00399634 File Offset: 0x00397834
		public static void StartITrackTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x0601902F RID: 102447 RVA: 0x0039963E File Offset: 0x0039783E
		public static void AddTrackTypeType(FlatBufferBuilder builder, TTrackType trackTypeType)
		{
			builder.AddByte(0, (byte)trackTypeType, 0);
		}

		// Token: 0x06019030 RID: 102448 RVA: 0x00399649 File Offset: 0x00397849
		public static void AddTrackType(FlatBufferBuilder builder, int trackTypeOffset)
		{
			builder.AddOffset(1, trackTypeOffset, 0);
		}

		// Token: 0x06019031 RID: 102449 RVA: 0x00399654 File Offset: 0x00397854
		public static void AddTrackViewMode(FlatBufferBuilder builder, ETrackViewMode trackViewMode)
		{
			builder.AddByte(2, (byte)trackViewMode, 0);
		}

		// Token: 0x06019032 RID: 102450 RVA: 0x0039965F File Offset: 0x0039785F
		public static void AddRange(FlatBufferBuilder builder, float range)
		{
			builder.AddFloat(3, range, 0.0);
		}

		// Token: 0x06019033 RID: 102451 RVA: 0x00399672 File Offset: 0x00397872
		public static void AddViewRange(FlatBufferBuilder builder, float viewRange)
		{
			builder.AddFloat(4, viewRange, 0.0);
		}

		// Token: 0x06019034 RID: 102452 RVA: 0x00399685 File Offset: 0x00397885
		public static void AddZaxisViewRange(FlatBufferBuilder builder, Offset<IZaxisViewRange> zaxisViewRangeOffset)
		{
			builder.AddOffset(5, zaxisViewRangeOffset.Value, 0);
		}

		// Token: 0x06019035 RID: 102453 RVA: 0x00399695 File Offset: 0x00397895
		public static void AddEffect(FlatBufferBuilder builder, ETrackEffect effect)
		{
			builder.AddByte(6, (byte)effect, 0);
		}

		// Token: 0x06019036 RID: 102454 RVA: 0x003996A0 File Offset: 0x003978A0
		public static void AddEffectOption(FlatBufferBuilder builder, Offset<ITrackEffectAutoChange> effectOptionOffset)
		{
			builder.AddOffset(7, effectOptionOffset.Value, 0);
		}

		// Token: 0x06019037 RID: 102455 RVA: 0x003996B0 File Offset: 0x003978B0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06019038 RID: 102456 RVA: 0x003996BB File Offset: 0x003978BB
		public static Offset<ITrackTarget> EndITrackTarget(FlatBufferBuilder builder)
		{
			return new Offset<ITrackTarget>(builder.EndTable());
		}

		// Token: 0x06019039 RID: 102457 RVA: 0x003996C8 File Offset: 0x003978C8
		public ITrackTargetT UnPack()
		{
			ITrackTargetT trackTargetT = new ITrackTargetT();
			this.UnPackTo(trackTargetT);
			return trackTargetT;
		}

		// Token: 0x0601903A RID: 102458 RVA: 0x003996E4 File Offset: 0x003978E4
		public void UnPackTo(ITrackTargetT _o)
		{
			_o.TrackType = new TTrackTypeUnion();
			_o.TrackType.Type = this.TrackTypeType;
			switch (this.TrackTypeType)
			{
			case TTrackType.ITrackCaptureVisions:
				_o.TrackType.Value = ((this.TrackType<ITrackCaptureVisions>() != null) ? this.TrackType<ITrackCaptureVisions>().Value.UnPack() : null);
				break;
			case TTrackType.ITrackEntities:
				_o.TrackType.Value = ((this.TrackType<ITrackEntities>() != null) ? this.TrackType<ITrackEntities>().Value.UnPack() : null);
				break;
			case TTrackType.ITrackEntityGroup:
				_o.TrackType.Value = ((this.TrackType<ITrackEntityGroup>() != null) ? this.TrackType<ITrackEntityGroup>().Value.UnPack() : null);
				break;
			case TTrackType.ITrackLevelPlay:
				_o.TrackType.Value = ((this.TrackType<ITrackLevelPlay>() != null) ? this.TrackType<ITrackLevelPlay>().Value.UnPack() : null);
				break;
			case TTrackType.ITrackLocations:
				_o.TrackType.Value = ((this.TrackType<ITrackLocations>() != null) ? this.TrackType<ITrackLocations>().Value.UnPack() : null);
				break;
			}
			_o.TrackViewMode = this.TrackViewMode;
			_o.Range = this.Range;
			_o.ViewRange = this.ViewRange;
			_o.ZaxisViewRange = ((this.ZaxisViewRange != null) ? this.ZaxisViewRange.Value.UnPack() : null);
			_o.Effect = this.Effect;
			_o.EffectOption = ((this.EffectOption != null) ? this.EffectOption.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601903B RID: 102459 RVA: 0x003998F4 File Offset: 0x00397AF4
		public static Offset<ITrackTarget> Pack(FlatBufferBuilder builder, ITrackTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrackTarget>);
			}
			TTrackType trackType_type = (_o.TrackType == null) ? TTrackType.NONE : _o.TrackType.Type;
			int trackTypeOffset = (_o.TrackType == null) ? 0 : TTrackTypeUnion.Pack(builder, _o.TrackType);
			Offset<IZaxisViewRange> zaxisViewRangeOffset = (_o.ZaxisViewRange == null) ? default(Offset<IZaxisViewRange>) : IZaxisViewRange.Pack(builder, _o.ZaxisViewRange);
			Offset<ITrackEffectAutoChange> effectOptionOffset = (_o.EffectOption == null) ? default(Offset<ITrackEffectAutoChange>) : ITrackEffectAutoChange.Pack(builder, _o.EffectOption);
			return ITrackTarget.CreateITrackTarget(builder, trackType_type, trackTypeOffset, _o.TrackViewMode, _o.Range, _o.ViewRange, zaxisViewRangeOffset, _o.Effect, effectOptionOffset, _o.NullMask);
		}

		// Token: 0x0400BE8E RID: 48782
		private Table __p;
	}
}
