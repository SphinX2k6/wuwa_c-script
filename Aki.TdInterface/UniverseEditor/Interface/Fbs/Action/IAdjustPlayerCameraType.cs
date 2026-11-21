using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067D2 RID: 26578
	public struct IAdjustPlayerCameraType : IFlatbufferObject
	{
		// Token: 0x1700C310 RID: 49936
		// (get) Token: 0x0602D57F RID: 185727 RVA: 0x00635694 File Offset: 0x00633894
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D580 RID: 185728 RVA: 0x006356A1 File Offset: 0x006338A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D581 RID: 185729 RVA: 0x006356A8 File Offset: 0x006338A8
		public static IAdjustPlayerCameraType GetRootAsIAdjustPlayerCameraType(ByteBuffer _bb)
		{
			return IAdjustPlayerCameraType.GetRootAsIAdjustPlayerCameraType(_bb, default(IAdjustPlayerCameraType));
		}

		// Token: 0x0602D582 RID: 185730 RVA: 0x006356C4 File Offset: 0x006338C4
		public static IAdjustPlayerCameraType GetRootAsIAdjustPlayerCameraType(ByteBuffer _bb, IAdjustPlayerCameraType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D583 RID: 185731 RVA: 0x006356E1 File Offset: 0x006338E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D584 RID: 185732 RVA: 0x006356F0 File Offset: 0x006338F0
		public IAdjustPlayerCameraType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C311 RID: 49937
		// (get) Token: 0x0602D585 RID: 185733 RVA: 0x00635700 File Offset: 0x00633900
		public EAdjustPlayerCamera Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAdjustPlayerCamera.Basic;
				}
				return (EAdjustPlayerCamera)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C312 RID: 49938
		// (get) Token: 0x0602D586 RID: 185734 RVA: 0x0063573C File Offset: 0x0063393C
		public int Priority
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

		// Token: 0x1700C313 RID: 49939
		// (get) Token: 0x0602D587 RID: 185735 RVA: 0x00635778 File Offset: 0x00633978
		public float FadeInTime
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C314 RID: 49940
		// (get) Token: 0x0602D588 RID: 185736 RVA: 0x006357B8 File Offset: 0x006339B8
		public IBaseCurve? FadeInCurve
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IBaseCurve?(default(IBaseCurve).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C315 RID: 49941
		// (get) Token: 0x0602D589 RID: 185737 RVA: 0x00635818 File Offset: 0x00633A18
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

		// Token: 0x1700C316 RID: 49942
		// (get) Token: 0x0602D58A RID: 185738 RVA: 0x0063585C File Offset: 0x00633A5C
		public IBaseCurve? FadeOutCurve
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IBaseCurve?(default(IBaseCurve).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C317 RID: 49943
		// (get) Token: 0x0602D58B RID: 185739 RVA: 0x006358BC File Offset: 0x00633ABC
		public float ArmLength
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

		// Token: 0x1700C318 RID: 49944
		// (get) Token: 0x0602D58C RID: 185740 RVA: 0x00635900 File Offset: 0x00633B00
		public float MinumArmLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C319 RID: 49945
		// (get) Token: 0x0602D58D RID: 185741 RVA: 0x00635944 File Offset: 0x00633B44
		public float MaxiumArmLength
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

		// Token: 0x1700C31A RID: 49946
		// (get) Token: 0x0602D58E RID: 185742 RVA: 0x00635988 File Offset: 0x00633B88
		public IVectorInfo? Offset
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C31B RID: 49947
		// (get) Token: 0x0602D58F RID: 185743 RVA: 0x006359E8 File Offset: 0x00633BE8
		public IVectorInfo? ArmOffset
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C31C RID: 49948
		// (get) Token: 0x0602D590 RID: 185744 RVA: 0x00635A48 File Offset: 0x00633C48
		public float YawLimitMin
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C31D RID: 49949
		// (get) Token: 0x0602D591 RID: 185745 RVA: 0x00635A8C File Offset: 0x00633C8C
		public float YawLimitMax
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

		// Token: 0x1700C31E RID: 49950
		// (get) Token: 0x0602D592 RID: 185746 RVA: 0x00635AD0 File Offset: 0x00633CD0
		public float PitchLimitMin
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

		// Token: 0x1700C31F RID: 49951
		// (get) Token: 0x0602D593 RID: 185747 RVA: 0x00635B14 File Offset: 0x00633D14
		public float PitchLimitMax
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C320 RID: 49952
		// (get) Token: 0x0602D594 RID: 185748 RVA: 0x00635B58 File Offset: 0x00633D58
		public float Fov
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C321 RID: 49953
		// (get) Token: 0x0602D595 RID: 185749 RVA: 0x00635B9C File Offset: 0x00633D9C
		public bool IsDisableResetFocus
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C322 RID: 49954
		// (get) Token: 0x0602D596 RID: 185750 RVA: 0x00635BDC File Offset: 0x00633DDC
		public TGravityDirection GravityDirectionType
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return TGravityDirection.NONE;
				}
				return (TGravityDirection)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D597 RID: 185751 RVA: 0x00635C1C File Offset: 0x00633E1C
		public TTable? GravityDirection<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602D598 RID: 185752 RVA: 0x00635C64 File Offset: 0x00633E64
		public IGravityDirectionByEntityGravity GravityDirectionAsIGravityDirectionByEntityGravity()
		{
			return this.GravityDirection<IGravityDirectionByEntityGravity>().Value;
		}

		// Token: 0x0602D599 RID: 185753 RVA: 0x00635C80 File Offset: 0x00633E80
		public IGravityDirectionSelfRotation GravityDirectionAsIGravityDirectionSelfRotation()
		{
			return this.GravityDirection<IGravityDirectionSelfRotation>().Value;
		}

		// Token: 0x0602D59A RID: 185754 RVA: 0x00635C9C File Offset: 0x00633E9C
		public IGravityDirectionVectorInfo GravityDirectionAsIGravityDirectionVectorInfo()
		{
			return this.GravityDirection<IGravityDirectionVectorInfo>().Value;
		}

		// Token: 0x0602D59B RID: 185755 RVA: 0x00635CB8 File Offset: 0x00633EB8
		public IGravityDirectionWorldAxis GravityDirectionAsIGravityDirectionWorldAxis()
		{
			return this.GravityDirection<IGravityDirectionWorldAxis>().Value;
		}

		// Token: 0x1700C323 RID: 49955
		// (get) Token: 0x0602D59C RID: 185756 RVA: 0x00635CD4 File Offset: 0x00633ED4
		public bool IsDisableCollision
		{
			get
			{
				int num = this.__p.__offset(42);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C324 RID: 49956
		// (get) Token: 0x0602D59D RID: 185757 RVA: 0x00635D14 File Offset: 0x00633F14
		public bool IsDisableDither
		{
			get
			{
				int num = this.__p.__offset(44);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C325 RID: 49957
		// (get) Token: 0x0602D59E RID: 185758 RVA: 0x00635D54 File Offset: 0x00633F54
		public string SubScreenBindKey
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D59F RID: 185759 RVA: 0x00635D8C File Offset: 0x00633F8C
		public Span<byte> GetSubScreenBindKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0602D5A0 RID: 185760 RVA: 0x00635D9C File Offset: 0x00633F9C
		public byte[] GetSubScreenBindKeyArray()
		{
			return this.__p.__vector_as_array<byte>(46);
		}

		// Token: 0x1700C326 RID: 49958
		// (get) Token: 0x0602D5A1 RID: 185761 RVA: 0x00635DAC File Offset: 0x00633FAC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D5A2 RID: 185762 RVA: 0x00635DEC File Offset: 0x00633FEC
		public static Offset<IAdjustPlayerCameraType> CreateIAdjustPlayerCameraType(FlatBufferBuilder builder, EAdjustPlayerCamera Type = EAdjustPlayerCamera.Basic, int Priority = 0, float FadeInTime = 0f, Offset<IBaseCurve> FadeInCurveOffset = default(Offset<IBaseCurve>), float FadeOutTime = 0f, Offset<IBaseCurve> FadeOutCurveOffset = default(Offset<IBaseCurve>), float ArmLength = 0f, float MinumArmLength = 0f, float MaxiumArmLength = 0f, Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> ArmOffsetOffset = default(Offset<IVectorInfo>), float YawLimitMin = 0f, float YawLimitMax = 0f, float PitchLimitMin = 0f, float PitchLimitMax = 0f, float Fov = 0f, bool IsDisableResetFocus = false, TGravityDirection GravityDirection_type = TGravityDirection.NONE, int GravityDirectionOffset = 0, bool IsDisableCollision = false, bool IsDisableDither = false, StringOffset SubScreenBindKeyOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(23);
			IAdjustPlayerCameraType.AddSubScreenBindKey(builder, SubScreenBindKeyOffset);
			IAdjustPlayerCameraType.AddGravityDirection(builder, GravityDirectionOffset);
			IAdjustPlayerCameraType.AddFov(builder, Fov);
			IAdjustPlayerCameraType.AddPitchLimitMax(builder, PitchLimitMax);
			IAdjustPlayerCameraType.AddPitchLimitMin(builder, PitchLimitMin);
			IAdjustPlayerCameraType.AddYawLimitMax(builder, YawLimitMax);
			IAdjustPlayerCameraType.AddYawLimitMin(builder, YawLimitMin);
			IAdjustPlayerCameraType.AddArmOffset(builder, ArmOffsetOffset);
			IAdjustPlayerCameraType.AddOffset(builder, OffsetOffset);
			IAdjustPlayerCameraType.AddMaxiumArmLength(builder, MaxiumArmLength);
			IAdjustPlayerCameraType.AddMinumArmLength(builder, MinumArmLength);
			IAdjustPlayerCameraType.AddArmLength(builder, ArmLength);
			IAdjustPlayerCameraType.AddFadeOutCurve(builder, FadeOutCurveOffset);
			IAdjustPlayerCameraType.AddFadeOutTime(builder, FadeOutTime);
			IAdjustPlayerCameraType.AddFadeInCurve(builder, FadeInCurveOffset);
			IAdjustPlayerCameraType.AddFadeInTime(builder, FadeInTime);
			IAdjustPlayerCameraType.AddPriority(builder, Priority);
			IAdjustPlayerCameraType.AddNullMask(builder, NullMask);
			IAdjustPlayerCameraType.AddIsDisableDither(builder, IsDisableDither);
			IAdjustPlayerCameraType.AddIsDisableCollision(builder, IsDisableCollision);
			IAdjustPlayerCameraType.AddGravityDirectionType(builder, GravityDirection_type);
			IAdjustPlayerCameraType.AddIsDisableResetFocus(builder, IsDisableResetFocus);
			IAdjustPlayerCameraType.AddType(builder, Type);
			return IAdjustPlayerCameraType.EndIAdjustPlayerCameraType(builder);
		}

		// Token: 0x0602D5A3 RID: 185763 RVA: 0x00635EBC File Offset: 0x006340BC
		public static void StartIAdjustPlayerCameraType(FlatBufferBuilder builder)
		{
			builder.StartTable(23);
		}

		// Token: 0x0602D5A4 RID: 185764 RVA: 0x00635EC6 File Offset: 0x006340C6
		public static void AddType(FlatBufferBuilder builder, EAdjustPlayerCamera type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D5A5 RID: 185765 RVA: 0x00635ED1 File Offset: 0x006340D1
		public static void AddPriority(FlatBufferBuilder builder, int priority)
		{
			builder.AddInt(1, priority, 0);
		}

		// Token: 0x0602D5A6 RID: 185766 RVA: 0x00635EDC File Offset: 0x006340DC
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(2, fadeInTime, 0.0);
		}

		// Token: 0x0602D5A7 RID: 185767 RVA: 0x00635EEF File Offset: 0x006340EF
		public static void AddFadeInCurve(FlatBufferBuilder builder, Offset<IBaseCurve> fadeInCurveOffset)
		{
			builder.AddOffset(3, fadeInCurveOffset.Value, 0);
		}

		// Token: 0x0602D5A8 RID: 185768 RVA: 0x00635EFF File Offset: 0x006340FF
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(4, fadeOutTime, 0.0);
		}

		// Token: 0x0602D5A9 RID: 185769 RVA: 0x00635F12 File Offset: 0x00634112
		public static void AddFadeOutCurve(FlatBufferBuilder builder, Offset<IBaseCurve> fadeOutCurveOffset)
		{
			builder.AddOffset(5, fadeOutCurveOffset.Value, 0);
		}

		// Token: 0x0602D5AA RID: 185770 RVA: 0x00635F22 File Offset: 0x00634122
		public static void AddArmLength(FlatBufferBuilder builder, float armLength)
		{
			builder.AddFloat(6, armLength, 0.0);
		}

		// Token: 0x0602D5AB RID: 185771 RVA: 0x00635F35 File Offset: 0x00634135
		public static void AddMinumArmLength(FlatBufferBuilder builder, float minumArmLength)
		{
			builder.AddFloat(7, minumArmLength, 0.0);
		}

		// Token: 0x0602D5AC RID: 185772 RVA: 0x00635F48 File Offset: 0x00634148
		public static void AddMaxiumArmLength(FlatBufferBuilder builder, float maxiumArmLength)
		{
			builder.AddFloat(8, maxiumArmLength, 0.0);
		}

		// Token: 0x0602D5AD RID: 185773 RVA: 0x00635F5B File Offset: 0x0063415B
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(9, offsetOffset.Value, 0);
		}

		// Token: 0x0602D5AE RID: 185774 RVA: 0x00635F6C File Offset: 0x0063416C
		public static void AddArmOffset(FlatBufferBuilder builder, Offset<IVectorInfo> armOffsetOffset)
		{
			builder.AddOffset(10, armOffsetOffset.Value, 0);
		}

		// Token: 0x0602D5AF RID: 185775 RVA: 0x00635F7D File Offset: 0x0063417D
		public static void AddYawLimitMin(FlatBufferBuilder builder, float yawLimitMin)
		{
			builder.AddFloat(11, yawLimitMin, 0.0);
		}

		// Token: 0x0602D5B0 RID: 185776 RVA: 0x00635F91 File Offset: 0x00634191
		public static void AddYawLimitMax(FlatBufferBuilder builder, float yawLimitMax)
		{
			builder.AddFloat(12, yawLimitMax, 0.0);
		}

		// Token: 0x0602D5B1 RID: 185777 RVA: 0x00635FA5 File Offset: 0x006341A5
		public static void AddPitchLimitMin(FlatBufferBuilder builder, float pitchLimitMin)
		{
			builder.AddFloat(13, pitchLimitMin, 0.0);
		}

		// Token: 0x0602D5B2 RID: 185778 RVA: 0x00635FB9 File Offset: 0x006341B9
		public static void AddPitchLimitMax(FlatBufferBuilder builder, float pitchLimitMax)
		{
			builder.AddFloat(14, pitchLimitMax, 0.0);
		}

		// Token: 0x0602D5B3 RID: 185779 RVA: 0x00635FCD File Offset: 0x006341CD
		public static void AddFov(FlatBufferBuilder builder, float fov)
		{
			builder.AddFloat(15, fov, 0.0);
		}

		// Token: 0x0602D5B4 RID: 185780 RVA: 0x00635FE1 File Offset: 0x006341E1
		public static void AddIsDisableResetFocus(FlatBufferBuilder builder, bool isDisableResetFocus)
		{
			builder.AddBool(16, isDisableResetFocus, false);
		}

		// Token: 0x0602D5B5 RID: 185781 RVA: 0x00635FED File Offset: 0x006341ED
		public static void AddGravityDirectionType(FlatBufferBuilder builder, TGravityDirection gravityDirectionType)
		{
			builder.AddByte(17, (byte)gravityDirectionType, 0);
		}

		// Token: 0x0602D5B6 RID: 185782 RVA: 0x00635FF9 File Offset: 0x006341F9
		public static void AddGravityDirection(FlatBufferBuilder builder, int gravityDirectionOffset)
		{
			builder.AddOffset(18, gravityDirectionOffset, 0);
		}

		// Token: 0x0602D5B7 RID: 185783 RVA: 0x00636005 File Offset: 0x00634205
		public static void AddIsDisableCollision(FlatBufferBuilder builder, bool isDisableCollision)
		{
			builder.AddBool(19, isDisableCollision, false);
		}

		// Token: 0x0602D5B8 RID: 185784 RVA: 0x00636011 File Offset: 0x00634211
		public static void AddIsDisableDither(FlatBufferBuilder builder, bool isDisableDither)
		{
			builder.AddBool(20, isDisableDither, false);
		}

		// Token: 0x0602D5B9 RID: 185785 RVA: 0x0063601D File Offset: 0x0063421D
		public static void AddSubScreenBindKey(FlatBufferBuilder builder, StringOffset subScreenBindKeyOffset)
		{
			builder.AddOffset(21, subScreenBindKeyOffset.Value, 0);
		}

		// Token: 0x0602D5BA RID: 185786 RVA: 0x0063602E File Offset: 0x0063422E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(22, nullMask, 0);
		}

		// Token: 0x0602D5BB RID: 185787 RVA: 0x0063603A File Offset: 0x0063423A
		public static Offset<IAdjustPlayerCameraType> EndIAdjustPlayerCameraType(FlatBufferBuilder builder)
		{
			return new Offset<IAdjustPlayerCameraType>(builder.EndTable());
		}

		// Token: 0x0602D5BC RID: 185788 RVA: 0x00636048 File Offset: 0x00634248
		public IAdjustPlayerCameraTypeT UnPack()
		{
			IAdjustPlayerCameraTypeT adjustPlayerCameraTypeT = new IAdjustPlayerCameraTypeT();
			this.UnPackTo(adjustPlayerCameraTypeT);
			return adjustPlayerCameraTypeT;
		}

		// Token: 0x0602D5BD RID: 185789 RVA: 0x00636064 File Offset: 0x00634264
		public void UnPackTo(IAdjustPlayerCameraTypeT _o)
		{
			_o.Type = this.Type;
			_o.Priority = this.Priority;
			_o.FadeInTime = this.FadeInTime;
			_o.FadeInCurve = ((this.FadeInCurve != null) ? this.FadeInCurve.Value.UnPack() : null);
			_o.FadeOutTime = this.FadeOutTime;
			_o.FadeOutCurve = ((this.FadeOutCurve != null) ? this.FadeOutCurve.Value.UnPack() : null);
			_o.ArmLength = this.ArmLength;
			_o.MinumArmLength = this.MinumArmLength;
			_o.MaxiumArmLength = this.MaxiumArmLength;
			_o.Offset = ((this.Offset != null) ? this.Offset.Value.UnPack() : null);
			_o.ArmOffset = ((this.ArmOffset != null) ? this.ArmOffset.Value.UnPack() : null);
			_o.YawLimitMin = this.YawLimitMin;
			_o.YawLimitMax = this.YawLimitMax;
			_o.PitchLimitMin = this.PitchLimitMin;
			_o.PitchLimitMax = this.PitchLimitMax;
			_o.Fov = this.Fov;
			_o.IsDisableResetFocus = this.IsDisableResetFocus;
			_o.GravityDirection = new TGravityDirectionUnion();
			_o.GravityDirection.Type = this.GravityDirectionType;
			switch (this.GravityDirectionType)
			{
			case TGravityDirection.IGravityDirectionByEntityGravity:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionByEntityGravity>() != null) ? this.GravityDirection<IGravityDirectionByEntityGravity>().Value.UnPack() : null);
				break;
			case TGravityDirection.IGravityDirectionSelfRotation:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionSelfRotation>() != null) ? this.GravityDirection<IGravityDirectionSelfRotation>().Value.UnPack() : null);
				break;
			case TGravityDirection.IGravityDirectionVectorInfo:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionVectorInfo>() != null) ? this.GravityDirection<IGravityDirectionVectorInfo>().Value.UnPack() : null);
				break;
			case TGravityDirection.IGravityDirectionWorldAxis:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionWorldAxis>() != null) ? this.GravityDirection<IGravityDirectionWorldAxis>().Value.UnPack() : null);
				break;
			}
			_o.IsDisableCollision = this.IsDisableCollision;
			_o.IsDisableDither = this.IsDisableDither;
			_o.SubScreenBindKey = this.SubScreenBindKey;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602D5BE RID: 185790 RVA: 0x00636320 File Offset: 0x00634520
		public static Offset<IAdjustPlayerCameraType> Pack(FlatBufferBuilder builder, IAdjustPlayerCameraTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAdjustPlayerCameraType>);
			}
			Offset<IBaseCurve> fadeInCurveOffset = (_o.FadeInCurve == null) ? default(Offset<IBaseCurve>) : IBaseCurve.Pack(builder, _o.FadeInCurve);
			Offset<IBaseCurve> fadeOutCurveOffset = (_o.FadeOutCurve == null) ? default(Offset<IBaseCurve>) : IBaseCurve.Pack(builder, _o.FadeOutCurve);
			Offset<IVectorInfo> offsetOffset = (_o.Offset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Offset);
			Offset<IVectorInfo> armOffsetOffset = (_o.ArmOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.ArmOffset);
			TGravityDirection gravityDirection_type = (_o.GravityDirection == null) ? TGravityDirection.NONE : _o.GravityDirection.Type;
			int gravityDirectionOffset = (_o.GravityDirection == null) ? 0 : TGravityDirectionUnion.Pack(builder, _o.GravityDirection);
			StringOffset subScreenBindKeyOffset = (_o.SubScreenBindKey == null) ? default(StringOffset) : builder.CreateString(_o.SubScreenBindKey);
			return IAdjustPlayerCameraType.CreateIAdjustPlayerCameraType(builder, _o.Type, _o.Priority, _o.FadeInTime, fadeInCurveOffset, _o.FadeOutTime, fadeOutCurveOffset, _o.ArmLength, _o.MinumArmLength, _o.MaxiumArmLength, offsetOffset, armOffsetOffset, _o.YawLimitMin, _o.YawLimitMax, _o.PitchLimitMin, _o.PitchLimitMax, _o.Fov, _o.IsDisableResetFocus, gravityDirection_type, gravityDirectionOffset, _o.IsDisableCollision, _o.IsDisableDither, subScreenBindKeyOffset, _o.NullMask);
		}

		// Token: 0x0401143B RID: 70715
		private Table __p;
	}
}
