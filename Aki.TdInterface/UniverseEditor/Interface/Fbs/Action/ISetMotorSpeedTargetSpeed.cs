using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077EB RID: 30699
	public struct ISetMotorSpeedTargetSpeed : IFlatbufferObject
	{
		// Token: 0x1700E0FC RID: 57596
		// (get) Token: 0x06035ED1 RID: 220881 RVA: 0x007395F7 File Offset: 0x007377F7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035ED2 RID: 220882 RVA: 0x00739604 File Offset: 0x00737804
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035ED3 RID: 220883 RVA: 0x0073960C File Offset: 0x0073780C
		public static ISetMotorSpeedTargetSpeed GetRootAsISetMotorSpeedTargetSpeed(ByteBuffer _bb)
		{
			return ISetMotorSpeedTargetSpeed.GetRootAsISetMotorSpeedTargetSpeed(_bb, default(ISetMotorSpeedTargetSpeed));
		}

		// Token: 0x06035ED4 RID: 220884 RVA: 0x00739628 File Offset: 0x00737828
		public static ISetMotorSpeedTargetSpeed GetRootAsISetMotorSpeedTargetSpeed(ByteBuffer _bb, ISetMotorSpeedTargetSpeed obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035ED5 RID: 220885 RVA: 0x00739645 File Offset: 0x00737845
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035ED6 RID: 220886 RVA: 0x00739654 File Offset: 0x00737854
		public ISetMotorSpeedTargetSpeed __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E0FD RID: 57597
		// (get) Token: 0x06035ED7 RID: 220887 RVA: 0x00739664 File Offset: 0x00737864
		public EMotorSpeedType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMotorSpeedType.TargetSpeed;
				}
				return (EMotorSpeedType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E0FE RID: 57598
		// (get) Token: 0x06035ED8 RID: 220888 RVA: 0x007396A0 File Offset: 0x007378A0
		public float TargetSpeed
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

		// Token: 0x1700E0FF RID: 57599
		// (get) Token: 0x06035ED9 RID: 220889 RVA: 0x007396E0 File Offset: 0x007378E0
		public float TransitionTime
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

		// Token: 0x1700E100 RID: 57600
		// (get) Token: 0x06035EDA RID: 220890 RVA: 0x00739720 File Offset: 0x00737920
		public TEaseCurveType ChangeSpeedCurveType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TEaseCurveType.NONE;
				}
				return (TEaseCurveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035EDB RID: 220891 RVA: 0x00739760 File Offset: 0x00737960
		public TTable? ChangeSpeedCurve<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06035EDC RID: 220892 RVA: 0x007397A8 File Offset: 0x007379A8
		public IEaseCurveCustom ChangeSpeedCurveAsIEaseCurveCustom()
		{
			return this.ChangeSpeedCurve<IEaseCurveCustom>().Value;
		}

		// Token: 0x06035EDD RID: 220893 RVA: 0x007397C4 File Offset: 0x007379C4
		public IEaseCurvePreset ChangeSpeedCurveAsIEaseCurvePreset()
		{
			return this.ChangeSpeedCurve<IEaseCurvePreset>().Value;
		}

		// Token: 0x1700E101 RID: 57601
		// (get) Token: 0x06035EDE RID: 220894 RVA: 0x007397E0 File Offset: 0x007379E0
		public bool NotAllowSpeedAdjustmentIfExceed
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E102 RID: 57602
		// (get) Token: 0x06035EDF RID: 220895 RVA: 0x00739820 File Offset: 0x00737A20
		public bool NotAllowSpeedAdjustmentIfBelow
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E103 RID: 57603
		// (get) Token: 0x06035EE0 RID: 220896 RVA: 0x00739860 File Offset: 0x00737A60
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035EE1 RID: 220897 RVA: 0x007398A0 File Offset: 0x00737AA0
		public static Offset<ISetMotorSpeedTargetSpeed> CreateISetMotorSpeedTargetSpeed(FlatBufferBuilder builder, EMotorSpeedType Type = EMotorSpeedType.TargetSpeed, float TargetSpeed = 0f, float TransitionTime = 0f, TEaseCurveType ChangeSpeedCurve_type = TEaseCurveType.NONE, int ChangeSpeedCurveOffset = 0, bool NotAllowSpeedAdjustmentIfExceed = false, bool NotAllowSpeedAdjustmentIfBelow = false, byte NullMask = 0)
		{
			builder.StartTable(8);
			ISetMotorSpeedTargetSpeed.AddChangeSpeedCurve(builder, ChangeSpeedCurveOffset);
			ISetMotorSpeedTargetSpeed.AddTransitionTime(builder, TransitionTime);
			ISetMotorSpeedTargetSpeed.AddTargetSpeed(builder, TargetSpeed);
			ISetMotorSpeedTargetSpeed.AddNullMask(builder, NullMask);
			ISetMotorSpeedTargetSpeed.AddNotAllowSpeedAdjustmentIfBelow(builder, NotAllowSpeedAdjustmentIfBelow);
			ISetMotorSpeedTargetSpeed.AddNotAllowSpeedAdjustmentIfExceed(builder, NotAllowSpeedAdjustmentIfExceed);
			ISetMotorSpeedTargetSpeed.AddChangeSpeedCurveType(builder, ChangeSpeedCurve_type);
			ISetMotorSpeedTargetSpeed.AddType(builder, Type);
			return ISetMotorSpeedTargetSpeed.EndISetMotorSpeedTargetSpeed(builder);
		}

		// Token: 0x06035EE2 RID: 220898 RVA: 0x007398F7 File Offset: 0x00737AF7
		public static void StartISetMotorSpeedTargetSpeed(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06035EE3 RID: 220899 RVA: 0x00739900 File Offset: 0x00737B00
		public static void AddType(FlatBufferBuilder builder, EMotorSpeedType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035EE4 RID: 220900 RVA: 0x0073990B File Offset: 0x00737B0B
		public static void AddTargetSpeed(FlatBufferBuilder builder, float targetSpeed)
		{
			builder.AddFloat(1, targetSpeed, 0.0);
		}

		// Token: 0x06035EE5 RID: 220901 RVA: 0x0073991E File Offset: 0x00737B1E
		public static void AddTransitionTime(FlatBufferBuilder builder, float transitionTime)
		{
			builder.AddFloat(2, transitionTime, 0.0);
		}

		// Token: 0x06035EE6 RID: 220902 RVA: 0x00739931 File Offset: 0x00737B31
		public static void AddChangeSpeedCurveType(FlatBufferBuilder builder, TEaseCurveType changeSpeedCurveType)
		{
			builder.AddByte(3, (byte)changeSpeedCurveType, 0);
		}

		// Token: 0x06035EE7 RID: 220903 RVA: 0x0073993C File Offset: 0x00737B3C
		public static void AddChangeSpeedCurve(FlatBufferBuilder builder, int changeSpeedCurveOffset)
		{
			builder.AddOffset(4, changeSpeedCurveOffset, 0);
		}

		// Token: 0x06035EE8 RID: 220904 RVA: 0x00739947 File Offset: 0x00737B47
		public static void AddNotAllowSpeedAdjustmentIfExceed(FlatBufferBuilder builder, bool notAllowSpeedAdjustmentIfExceed)
		{
			builder.AddBool(5, notAllowSpeedAdjustmentIfExceed, false);
		}

		// Token: 0x06035EE9 RID: 220905 RVA: 0x00739952 File Offset: 0x00737B52
		public static void AddNotAllowSpeedAdjustmentIfBelow(FlatBufferBuilder builder, bool notAllowSpeedAdjustmentIfBelow)
		{
			builder.AddBool(6, notAllowSpeedAdjustmentIfBelow, false);
		}

		// Token: 0x06035EEA RID: 220906 RVA: 0x0073995D File Offset: 0x00737B5D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06035EEB RID: 220907 RVA: 0x00739968 File Offset: 0x00737B68
		public static Offset<ISetMotorSpeedTargetSpeed> EndISetMotorSpeedTargetSpeed(FlatBufferBuilder builder)
		{
			return new Offset<ISetMotorSpeedTargetSpeed>(builder.EndTable());
		}

		// Token: 0x06035EEC RID: 220908 RVA: 0x00739978 File Offset: 0x00737B78
		public ISetMotorSpeedTargetSpeedT UnPack()
		{
			ISetMotorSpeedTargetSpeedT setMotorSpeedTargetSpeedT = new ISetMotorSpeedTargetSpeedT();
			this.UnPackTo(setMotorSpeedTargetSpeedT);
			return setMotorSpeedTargetSpeedT;
		}

		// Token: 0x06035EED RID: 220909 RVA: 0x00739994 File Offset: 0x00737B94
		public void UnPackTo(ISetMotorSpeedTargetSpeedT _o)
		{
			_o.Type = this.Type;
			_o.TargetSpeed = this.TargetSpeed;
			_o.TransitionTime = this.TransitionTime;
			_o.ChangeSpeedCurve = new TEaseCurveTypeUnion();
			_o.ChangeSpeedCurve.Type = this.ChangeSpeedCurveType;
			TEaseCurveType changeSpeedCurveType = this.ChangeSpeedCurveType;
			if (changeSpeedCurveType != TEaseCurveType.IEaseCurveCustom)
			{
				if (changeSpeedCurveType == TEaseCurveType.IEaseCurvePreset)
				{
					_o.ChangeSpeedCurve.Value = ((this.ChangeSpeedCurve<IEaseCurvePreset>() != null) ? this.ChangeSpeedCurve<IEaseCurvePreset>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.ChangeSpeedCurve.Value = ((this.ChangeSpeedCurve<IEaseCurveCustom>() != null) ? this.ChangeSpeedCurve<IEaseCurveCustom>().Value.UnPack() : null);
			}
			_o.NotAllowSpeedAdjustmentIfExceed = this.NotAllowSpeedAdjustmentIfExceed;
			_o.NotAllowSpeedAdjustmentIfBelow = this.NotAllowSpeedAdjustmentIfBelow;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06035EEE RID: 220910 RVA: 0x00739A84 File Offset: 0x00737C84
		public static Offset<ISetMotorSpeedTargetSpeed> Pack(FlatBufferBuilder builder, ISetMotorSpeedTargetSpeedT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetMotorSpeedTargetSpeed>);
			}
			TEaseCurveType changeSpeedCurve_type = (_o.ChangeSpeedCurve == null) ? TEaseCurveType.NONE : _o.ChangeSpeedCurve.Type;
			int changeSpeedCurveOffset = (_o.ChangeSpeedCurve == null) ? 0 : TEaseCurveTypeUnion.Pack(builder, _o.ChangeSpeedCurve);
			return ISetMotorSpeedTargetSpeed.CreateISetMotorSpeedTargetSpeed(builder, _o.Type, _o.TargetSpeed, _o.TransitionTime, changeSpeedCurve_type, changeSpeedCurveOffset, _o.NotAllowSpeedAdjustmentIfExceed, _o.NotAllowSpeedAdjustmentIfBelow, _o.NullMask);
		}

		// Token: 0x04012A30 RID: 76336
		private Table __p;
	}
}
