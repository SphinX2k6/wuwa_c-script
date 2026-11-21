using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004676 RID: 18038
	public struct ITrackTarget : IFlatbufferObject
	{
		// Token: 0x17007E60 RID: 32352
		// (get) Token: 0x0601A785 RID: 108421 RVA: 0x003C4930 File Offset: 0x003C2B30
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A786 RID: 108422 RVA: 0x003C493D File Offset: 0x003C2B3D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A787 RID: 108423 RVA: 0x003C4944 File Offset: 0x003C2B44
		public static ITrackTarget GetRootAsITrackTarget(ByteBuffer _bb)
		{
			return ITrackTarget.GetRootAsITrackTarget(_bb, default(ITrackTarget));
		}

		// Token: 0x0601A788 RID: 108424 RVA: 0x003C4960 File Offset: 0x003C2B60
		public static ITrackTarget GetRootAsITrackTarget(ByteBuffer _bb, ITrackTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A789 RID: 108425 RVA: 0x003C497D File Offset: 0x003C2B7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A78A RID: 108426 RVA: 0x003C498C File Offset: 0x003C2B8C
		public ITrackTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007E61 RID: 32353
		// (get) Token: 0x0601A78B RID: 108427 RVA: 0x003C499C File Offset: 0x003C2B9C
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

		// Token: 0x0601A78C RID: 108428 RVA: 0x003C49D8 File Offset: 0x003C2BD8
		public TTable? TrackType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601A78D RID: 108429 RVA: 0x003C4A1C File Offset: 0x003C2C1C
		public ITrackCaptureVisions TrackTypeAsITrackCaptureVisions()
		{
			return this.TrackType<ITrackCaptureVisions>().Value;
		}

		// Token: 0x0601A78E RID: 108430 RVA: 0x003C4A38 File Offset: 0x003C2C38
		public ITrackEntities TrackTypeAsITrackEntities()
		{
			return this.TrackType<ITrackEntities>().Value;
		}

		// Token: 0x0601A78F RID: 108431 RVA: 0x003C4A54 File Offset: 0x003C2C54
		public ITrackEntityGroup TrackTypeAsITrackEntityGroup()
		{
			return this.TrackType<ITrackEntityGroup>().Value;
		}

		// Token: 0x0601A790 RID: 108432 RVA: 0x003C4A70 File Offset: 0x003C2C70
		public ITrackLevelPlay TrackTypeAsITrackLevelPlay()
		{
			return this.TrackType<ITrackLevelPlay>().Value;
		}

		// Token: 0x0601A791 RID: 108433 RVA: 0x003C4A8C File Offset: 0x003C2C8C
		public ITrackLocations TrackTypeAsITrackLocations()
		{
			return this.TrackType<ITrackLocations>().Value;
		}

		// Token: 0x17007E62 RID: 32354
		// (get) Token: 0x0601A792 RID: 108434 RVA: 0x003C4AA8 File Offset: 0x003C2CA8
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

		// Token: 0x17007E63 RID: 32355
		// (get) Token: 0x0601A793 RID: 108435 RVA: 0x003C4AE4 File Offset: 0x003C2CE4
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

		// Token: 0x17007E64 RID: 32356
		// (get) Token: 0x0601A794 RID: 108436 RVA: 0x003C4B28 File Offset: 0x003C2D28
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

		// Token: 0x17007E65 RID: 32357
		// (get) Token: 0x0601A795 RID: 108437 RVA: 0x003C4B6C File Offset: 0x003C2D6C
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

		// Token: 0x17007E66 RID: 32358
		// (get) Token: 0x0601A796 RID: 108438 RVA: 0x003C4BCC File Offset: 0x003C2DCC
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

		// Token: 0x17007E67 RID: 32359
		// (get) Token: 0x0601A797 RID: 108439 RVA: 0x003C4C0C File Offset: 0x003C2E0C
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

		// Token: 0x17007E68 RID: 32360
		// (get) Token: 0x0601A798 RID: 108440 RVA: 0x003C4C6C File Offset: 0x003C2E6C
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

		// Token: 0x0601A799 RID: 108441 RVA: 0x003C4CAC File Offset: 0x003C2EAC
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

		// Token: 0x0601A79A RID: 108442 RVA: 0x003C4D0C File Offset: 0x003C2F0C
		public static void StartITrackTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x0601A79B RID: 108443 RVA: 0x003C4D16 File Offset: 0x003C2F16
		public static void AddTrackTypeType(FlatBufferBuilder builder, TTrackType trackTypeType)
		{
			builder.AddByte(0, (byte)trackTypeType, 0);
		}

		// Token: 0x0601A79C RID: 108444 RVA: 0x003C4D21 File Offset: 0x003C2F21
		public static void AddTrackType(FlatBufferBuilder builder, int trackTypeOffset)
		{
			builder.AddOffset(1, trackTypeOffset, 0);
		}

		// Token: 0x0601A79D RID: 108445 RVA: 0x003C4D2C File Offset: 0x003C2F2C
		public static void AddTrackViewMode(FlatBufferBuilder builder, ETrackViewMode trackViewMode)
		{
			builder.AddByte(2, (byte)trackViewMode, 0);
		}

		// Token: 0x0601A79E RID: 108446 RVA: 0x003C4D37 File Offset: 0x003C2F37
		public static void AddRange(FlatBufferBuilder builder, float range)
		{
			builder.AddFloat(3, range, 0.0);
		}

		// Token: 0x0601A79F RID: 108447 RVA: 0x003C4D4A File Offset: 0x003C2F4A
		public static void AddViewRange(FlatBufferBuilder builder, float viewRange)
		{
			builder.AddFloat(4, viewRange, 0.0);
		}

		// Token: 0x0601A7A0 RID: 108448 RVA: 0x003C4D5D File Offset: 0x003C2F5D
		public static void AddZaxisViewRange(FlatBufferBuilder builder, Offset<IZaxisViewRange> zaxisViewRangeOffset)
		{
			builder.AddOffset(5, zaxisViewRangeOffset.Value, 0);
		}

		// Token: 0x0601A7A1 RID: 108449 RVA: 0x003C4D6D File Offset: 0x003C2F6D
		public static void AddEffect(FlatBufferBuilder builder, ETrackEffect effect)
		{
			builder.AddByte(6, (byte)effect, 0);
		}

		// Token: 0x0601A7A2 RID: 108450 RVA: 0x003C4D78 File Offset: 0x003C2F78
		public static void AddEffectOption(FlatBufferBuilder builder, Offset<ITrackEffectAutoChange> effectOptionOffset)
		{
			builder.AddOffset(7, effectOptionOffset.Value, 0);
		}

		// Token: 0x0601A7A3 RID: 108451 RVA: 0x003C4D88 File Offset: 0x003C2F88
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x0601A7A4 RID: 108452 RVA: 0x003C4D93 File Offset: 0x003C2F93
		public static Offset<ITrackTarget> EndITrackTarget(FlatBufferBuilder builder)
		{
			return new Offset<ITrackTarget>(builder.EndTable());
		}

		// Token: 0x0601A7A5 RID: 108453 RVA: 0x003C4DA0 File Offset: 0x003C2FA0
		public ITrackTargetT UnPack()
		{
			ITrackTargetT trackTargetT = new ITrackTargetT();
			this.UnPackTo(trackTargetT);
			return trackTargetT;
		}

		// Token: 0x0601A7A6 RID: 108454 RVA: 0x003C4DBC File Offset: 0x003C2FBC
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

		// Token: 0x0601A7A7 RID: 108455 RVA: 0x003C4FCC File Offset: 0x003C31CC
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

		// Token: 0x0400C89B RID: 51355
		private Table __p;
	}
}
