using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200724F RID: 29263
	public struct IMotorcycleTrack : IFlatbufferObject
	{
		// Token: 0x1700D676 RID: 54902
		// (get) Token: 0x06032F7A RID: 208762 RVA: 0x006E164F File Offset: 0x006DF84F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032F7B RID: 208763 RVA: 0x006E165C File Offset: 0x006DF85C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032F7C RID: 208764 RVA: 0x006E1664 File Offset: 0x006DF864
		public static IMotorcycleTrack GetRootAsIMotorcycleTrack(ByteBuffer _bb)
		{
			return IMotorcycleTrack.GetRootAsIMotorcycleTrack(_bb, default(IMotorcycleTrack));
		}

		// Token: 0x06032F7D RID: 208765 RVA: 0x006E1680 File Offset: 0x006DF880
		public static IMotorcycleTrack GetRootAsIMotorcycleTrack(ByteBuffer _bb, IMotorcycleTrack obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032F7E RID: 208766 RVA: 0x006E169D File Offset: 0x006DF89D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032F7F RID: 208767 RVA: 0x006E16AC File Offset: 0x006DF8AC
		public IMotorcycleTrack __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D677 RID: 54903
		// (get) Token: 0x06032F80 RID: 208768 RVA: 0x006E16BC File Offset: 0x006DF8BC
		public ESplineMovePattern Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESplineMovePattern.PathLine;
				}
				return (ESplineMovePattern)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D678 RID: 54904
		// (get) Token: 0x06032F81 RID: 208769 RVA: 0x006E16F8 File Offset: 0x006DF8F8
		public float MaxOffsetDistance
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

		// Token: 0x1700D679 RID: 54905
		// (get) Token: 0x06032F82 RID: 208770 RVA: 0x006E1738 File Offset: 0x006DF938
		public bool IsOneWay
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D67A RID: 54906
		// (get) Token: 0x06032F83 RID: 208771 RVA: 0x006E1778 File Offset: 0x006DF978
		public float LayerVerticalLimit
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

		// Token: 0x1700D67B RID: 54907
		// (get) Token: 0x06032F84 RID: 208772 RVA: 0x006E17BC File Offset: 0x006DF9BC
		public bool DynamicGravity
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D67C RID: 54908
		// (get) Token: 0x06032F85 RID: 208773 RVA: 0x006E17FC File Offset: 0x006DF9FC
		public float GravitySwitchAngularVelocity
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D67D RID: 54909
		// (get) Token: 0x06032F86 RID: 208774 RVA: 0x006E1840 File Offset: 0x006DFA40
		public int AutoExitDistance
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D67E RID: 54910
		// (get) Token: 0x06032F87 RID: 208775 RVA: 0x006E1880 File Offset: 0x006DFA80
		public bool DisableAutoForward
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D67F RID: 54911
		// (get) Token: 0x06032F88 RID: 208776 RVA: 0x006E18C0 File Offset: 0x006DFAC0
		public float LongitudinalAngleLimit
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D680 RID: 54912
		// (get) Token: 0x06032F89 RID: 208777 RVA: 0x006E1904 File Offset: 0x006DFB04
		public float ForwardAngleLimit
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D681 RID: 54913
		// (get) Token: 0x06032F8A RID: 208778 RVA: 0x006E1948 File Offset: 0x006DFB48
		public string ForwardAngleLimitCurve
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032F8B RID: 208779 RVA: 0x006E1980 File Offset: 0x006DFB80
		public Span<byte> GetForwardAngleLimitCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06032F8C RID: 208780 RVA: 0x006E1990 File Offset: 0x006DFB90
		public byte[] GetForwardAngleLimitCurveArray()
		{
			return this.__p.__vector_as_array<byte>(24);
		}

		// Token: 0x1700D682 RID: 54914
		// (get) Token: 0x06032F8D RID: 208781 RVA: 0x006E19A0 File Offset: 0x006DFBA0
		public string InputCorrectionCurve
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032F8E RID: 208782 RVA: 0x006E19D8 File Offset: 0x006DFBD8
		public Span<byte> GetInputCorrectionCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06032F8F RID: 208783 RVA: 0x006E19E8 File Offset: 0x006DFBE8
		public byte[] GetInputCorrectionCurveArray()
		{
			return this.__p.__vector_as_array<byte>(26);
		}

		// Token: 0x1700D683 RID: 54915
		// (get) Token: 0x06032F90 RID: 208784 RVA: 0x006E19F8 File Offset: 0x006DFBF8
		public float InputCorrectionBaseAngle
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D684 RID: 54916
		// (get) Token: 0x06032F91 RID: 208785 RVA: 0x006E1A3C File Offset: 0x006DFC3C
		public float CorrectionPredictionDistance
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D685 RID: 54917
		// (get) Token: 0x06032F92 RID: 208786 RVA: 0x006E1A80 File Offset: 0x006DFC80
		public string AccelerationCorrectionCurve
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032F93 RID: 208787 RVA: 0x006E1AB8 File Offset: 0x006DFCB8
		public Span<byte> GetAccelerationCorrectionCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06032F94 RID: 208788 RVA: 0x006E1AC8 File Offset: 0x006DFCC8
		public byte[] GetAccelerationCorrectionCurveArray()
		{
			return this.__p.__vector_as_array<byte>(32);
		}

		// Token: 0x1700D686 RID: 54918
		// (get) Token: 0x06032F95 RID: 208789 RVA: 0x006E1AD8 File Offset: 0x006DFCD8
		public IAutomaticDrive? AutomaticDrive
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return new IAutomaticDrive?(default(IAutomaticDrive).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D687 RID: 54919
		// (get) Token: 0x06032F96 RID: 208790 RVA: 0x006E1B38 File Offset: 0x006DFD38
		public ushort NullMask
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetUshort(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032F97 RID: 208791 RVA: 0x006E1B78 File Offset: 0x006DFD78
		public static Offset<IMotorcycleTrack> CreateIMotorcycleTrack(FlatBufferBuilder builder, ESplineMovePattern Type = ESplineMovePattern.PathLine, float MaxOffsetDistance = 0f, bool IsOneWay = false, float LayerVerticalLimit = 0f, bool DynamicGravity = false, float GravitySwitchAngularVelocity = 0f, int AutoExitDistance = 0, bool DisableAutoForward = false, float LongitudinalAngleLimit = 0f, float ForwardAngleLimit = 0f, StringOffset ForwardAngleLimitCurveOffset = default(StringOffset), StringOffset InputCorrectionCurveOffset = default(StringOffset), float InputCorrectionBaseAngle = 0f, float CorrectionPredictionDistance = 0f, StringOffset AccelerationCorrectionCurveOffset = default(StringOffset), Offset<IAutomaticDrive> AutomaticDriveOffset = default(Offset<IAutomaticDrive>), ushort NullMask = 0)
		{
			builder.StartTable(17);
			IMotorcycleTrack.AddAutomaticDrive(builder, AutomaticDriveOffset);
			IMotorcycleTrack.AddAccelerationCorrectionCurve(builder, AccelerationCorrectionCurveOffset);
			IMotorcycleTrack.AddCorrectionPredictionDistance(builder, CorrectionPredictionDistance);
			IMotorcycleTrack.AddInputCorrectionBaseAngle(builder, InputCorrectionBaseAngle);
			IMotorcycleTrack.AddInputCorrectionCurve(builder, InputCorrectionCurveOffset);
			IMotorcycleTrack.AddForwardAngleLimitCurve(builder, ForwardAngleLimitCurveOffset);
			IMotorcycleTrack.AddForwardAngleLimit(builder, ForwardAngleLimit);
			IMotorcycleTrack.AddLongitudinalAngleLimit(builder, LongitudinalAngleLimit);
			IMotorcycleTrack.AddAutoExitDistance(builder, AutoExitDistance);
			IMotorcycleTrack.AddGravitySwitchAngularVelocity(builder, GravitySwitchAngularVelocity);
			IMotorcycleTrack.AddLayerVerticalLimit(builder, LayerVerticalLimit);
			IMotorcycleTrack.AddMaxOffsetDistance(builder, MaxOffsetDistance);
			IMotorcycleTrack.AddNullMask(builder, NullMask);
			IMotorcycleTrack.AddDisableAutoForward(builder, DisableAutoForward);
			IMotorcycleTrack.AddDynamicGravity(builder, DynamicGravity);
			IMotorcycleTrack.AddIsOneWay(builder, IsOneWay);
			IMotorcycleTrack.AddType(builder, Type);
			return IMotorcycleTrack.EndIMotorcycleTrack(builder);
		}

		// Token: 0x06032F98 RID: 208792 RVA: 0x006E1C18 File Offset: 0x006DFE18
		public static void StartIMotorcycleTrack(FlatBufferBuilder builder)
		{
			builder.StartTable(17);
		}

		// Token: 0x06032F99 RID: 208793 RVA: 0x006E1C22 File Offset: 0x006DFE22
		public static void AddType(FlatBufferBuilder builder, ESplineMovePattern type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032F9A RID: 208794 RVA: 0x006E1C2D File Offset: 0x006DFE2D
		public static void AddMaxOffsetDistance(FlatBufferBuilder builder, float maxOffsetDistance)
		{
			builder.AddFloat(1, maxOffsetDistance, 0.0);
		}

		// Token: 0x06032F9B RID: 208795 RVA: 0x006E1C40 File Offset: 0x006DFE40
		public static void AddIsOneWay(FlatBufferBuilder builder, bool isOneWay)
		{
			builder.AddBool(2, isOneWay, false);
		}

		// Token: 0x06032F9C RID: 208796 RVA: 0x006E1C4B File Offset: 0x006DFE4B
		public static void AddLayerVerticalLimit(FlatBufferBuilder builder, float layerVerticalLimit)
		{
			builder.AddFloat(3, layerVerticalLimit, 0.0);
		}

		// Token: 0x06032F9D RID: 208797 RVA: 0x006E1C5E File Offset: 0x006DFE5E
		public static void AddDynamicGravity(FlatBufferBuilder builder, bool dynamicGravity)
		{
			builder.AddBool(4, dynamicGravity, false);
		}

		// Token: 0x06032F9E RID: 208798 RVA: 0x006E1C69 File Offset: 0x006DFE69
		public static void AddGravitySwitchAngularVelocity(FlatBufferBuilder builder, float gravitySwitchAngularVelocity)
		{
			builder.AddFloat(5, gravitySwitchAngularVelocity, 0.0);
		}

		// Token: 0x06032F9F RID: 208799 RVA: 0x006E1C7C File Offset: 0x006DFE7C
		public static void AddAutoExitDistance(FlatBufferBuilder builder, int autoExitDistance)
		{
			builder.AddInt(6, autoExitDistance, 0);
		}

		// Token: 0x06032FA0 RID: 208800 RVA: 0x006E1C87 File Offset: 0x006DFE87
		public static void AddDisableAutoForward(FlatBufferBuilder builder, bool disableAutoForward)
		{
			builder.AddBool(7, disableAutoForward, false);
		}

		// Token: 0x06032FA1 RID: 208801 RVA: 0x006E1C92 File Offset: 0x006DFE92
		public static void AddLongitudinalAngleLimit(FlatBufferBuilder builder, float longitudinalAngleLimit)
		{
			builder.AddFloat(8, longitudinalAngleLimit, 0.0);
		}

		// Token: 0x06032FA2 RID: 208802 RVA: 0x006E1CA5 File Offset: 0x006DFEA5
		public static void AddForwardAngleLimit(FlatBufferBuilder builder, float forwardAngleLimit)
		{
			builder.AddFloat(9, forwardAngleLimit, 0.0);
		}

		// Token: 0x06032FA3 RID: 208803 RVA: 0x006E1CB9 File Offset: 0x006DFEB9
		public static void AddForwardAngleLimitCurve(FlatBufferBuilder builder, StringOffset forwardAngleLimitCurveOffset)
		{
			builder.AddOffset(10, forwardAngleLimitCurveOffset.Value, 0);
		}

		// Token: 0x06032FA4 RID: 208804 RVA: 0x006E1CCA File Offset: 0x006DFECA
		public static void AddInputCorrectionCurve(FlatBufferBuilder builder, StringOffset inputCorrectionCurveOffset)
		{
			builder.AddOffset(11, inputCorrectionCurveOffset.Value, 0);
		}

		// Token: 0x06032FA5 RID: 208805 RVA: 0x006E1CDB File Offset: 0x006DFEDB
		public static void AddInputCorrectionBaseAngle(FlatBufferBuilder builder, float inputCorrectionBaseAngle)
		{
			builder.AddFloat(12, inputCorrectionBaseAngle, 0.0);
		}

		// Token: 0x06032FA6 RID: 208806 RVA: 0x006E1CEF File Offset: 0x006DFEEF
		public static void AddCorrectionPredictionDistance(FlatBufferBuilder builder, float correctionPredictionDistance)
		{
			builder.AddFloat(13, correctionPredictionDistance, 0.0);
		}

		// Token: 0x06032FA7 RID: 208807 RVA: 0x006E1D03 File Offset: 0x006DFF03
		public static void AddAccelerationCorrectionCurve(FlatBufferBuilder builder, StringOffset accelerationCorrectionCurveOffset)
		{
			builder.AddOffset(14, accelerationCorrectionCurveOffset.Value, 0);
		}

		// Token: 0x06032FA8 RID: 208808 RVA: 0x006E1D14 File Offset: 0x006DFF14
		public static void AddAutomaticDrive(FlatBufferBuilder builder, Offset<IAutomaticDrive> automaticDriveOffset)
		{
			builder.AddOffset(15, automaticDriveOffset.Value, 0);
		}

		// Token: 0x06032FA9 RID: 208809 RVA: 0x006E1D25 File Offset: 0x006DFF25
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(16, nullMask, 0);
		}

		// Token: 0x06032FAA RID: 208810 RVA: 0x006E1D31 File Offset: 0x006DFF31
		public static Offset<IMotorcycleTrack> EndIMotorcycleTrack(FlatBufferBuilder builder)
		{
			return new Offset<IMotorcycleTrack>(builder.EndTable());
		}

		// Token: 0x06032FAB RID: 208811 RVA: 0x006E1D40 File Offset: 0x006DFF40
		public IMotorcycleTrackT UnPack()
		{
			IMotorcycleTrackT motorcycleTrackT = new IMotorcycleTrackT();
			this.UnPackTo(motorcycleTrackT);
			return motorcycleTrackT;
		}

		// Token: 0x06032FAC RID: 208812 RVA: 0x006E1D5C File Offset: 0x006DFF5C
		public void UnPackTo(IMotorcycleTrackT _o)
		{
			_o.Type = this.Type;
			_o.MaxOffsetDistance = this.MaxOffsetDistance;
			_o.IsOneWay = this.IsOneWay;
			_o.LayerVerticalLimit = this.LayerVerticalLimit;
			_o.DynamicGravity = this.DynamicGravity;
			_o.GravitySwitchAngularVelocity = this.GravitySwitchAngularVelocity;
			_o.AutoExitDistance = this.AutoExitDistance;
			_o.DisableAutoForward = this.DisableAutoForward;
			_o.LongitudinalAngleLimit = this.LongitudinalAngleLimit;
			_o.ForwardAngleLimit = this.ForwardAngleLimit;
			_o.ForwardAngleLimitCurve = this.ForwardAngleLimitCurve;
			_o.InputCorrectionCurve = this.InputCorrectionCurve;
			_o.InputCorrectionBaseAngle = this.InputCorrectionBaseAngle;
			_o.CorrectionPredictionDistance = this.CorrectionPredictionDistance;
			_o.AccelerationCorrectionCurve = this.AccelerationCorrectionCurve;
			_o.AutomaticDrive = ((this.AutomaticDrive != null) ? this.AutomaticDrive.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06032FAD RID: 208813 RVA: 0x006E1E58 File Offset: 0x006E0058
		public static Offset<IMotorcycleTrack> Pack(FlatBufferBuilder builder, IMotorcycleTrackT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorcycleTrack>);
			}
			StringOffset forwardAngleLimitCurveOffset = (_o.ForwardAngleLimitCurve == null) ? default(StringOffset) : builder.CreateString(_o.ForwardAngleLimitCurve);
			StringOffset inputCorrectionCurveOffset = (_o.InputCorrectionCurve == null) ? default(StringOffset) : builder.CreateString(_o.InputCorrectionCurve);
			StringOffset accelerationCorrectionCurveOffset = (_o.AccelerationCorrectionCurve == null) ? default(StringOffset) : builder.CreateString(_o.AccelerationCorrectionCurve);
			Offset<IAutomaticDrive> automaticDriveOffset = (_o.AutomaticDrive == null) ? default(Offset<IAutomaticDrive>) : IAutomaticDrive.Pack(builder, _o.AutomaticDrive);
			return IMotorcycleTrack.CreateIMotorcycleTrack(builder, _o.Type, _o.MaxOffsetDistance, _o.IsOneWay, _o.LayerVerticalLimit, _o.DynamicGravity, _o.GravitySwitchAngularVelocity, _o.AutoExitDistance, _o.DisableAutoForward, _o.LongitudinalAngleLimit, _o.ForwardAngleLimit, forwardAngleLimitCurveOffset, inputCorrectionCurveOffset, _o.InputCorrectionBaseAngle, _o.CorrectionPredictionDistance, accelerationCorrectionCurveOffset, automaticDriveOffset, _o.NullMask);
		}

		// Token: 0x040122AC RID: 74412
		private Table __p;
	}
}
