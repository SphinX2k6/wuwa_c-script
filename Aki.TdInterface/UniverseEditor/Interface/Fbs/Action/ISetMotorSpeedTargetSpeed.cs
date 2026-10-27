using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007022 RID: 28706
	public struct ISetMotorSpeedTargetSpeed : IFlatbufferObject
	{
		// Token: 0x1700D528 RID: 54568
		// (get) Token: 0x06032C6B RID: 207979 RVA: 0x006D99B3 File Offset: 0x006D7BB3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032C6C RID: 207980 RVA: 0x006D99C0 File Offset: 0x006D7BC0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032C6D RID: 207981 RVA: 0x006D99C8 File Offset: 0x006D7BC8
		public static ISetMotorSpeedTargetSpeed GetRootAsISetMotorSpeedTargetSpeed(ByteBuffer _bb)
		{
			return ISetMotorSpeedTargetSpeed.GetRootAsISetMotorSpeedTargetSpeed(_bb, default(ISetMotorSpeedTargetSpeed));
		}

		// Token: 0x06032C6E RID: 207982 RVA: 0x006D99E4 File Offset: 0x006D7BE4
		public static ISetMotorSpeedTargetSpeed GetRootAsISetMotorSpeedTargetSpeed(ByteBuffer _bb, ISetMotorSpeedTargetSpeed obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032C6F RID: 207983 RVA: 0x006D9A01 File Offset: 0x006D7C01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032C70 RID: 207984 RVA: 0x006D9A10 File Offset: 0x006D7C10
		public ISetMotorSpeedTargetSpeed __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D529 RID: 54569
		// (get) Token: 0x06032C71 RID: 207985 RVA: 0x006D9A20 File Offset: 0x006D7C20
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

		// Token: 0x1700D52A RID: 54570
		// (get) Token: 0x06032C72 RID: 207986 RVA: 0x006D9A5C File Offset: 0x006D7C5C
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

		// Token: 0x1700D52B RID: 54571
		// (get) Token: 0x06032C73 RID: 207987 RVA: 0x006D9A9C File Offset: 0x006D7C9C
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

		// Token: 0x1700D52C RID: 54572
		// (get) Token: 0x06032C74 RID: 207988 RVA: 0x006D9ADC File Offset: 0x006D7CDC
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

		// Token: 0x06032C75 RID: 207989 RVA: 0x006D9B1C File Offset: 0x006D7D1C
		public TTable? ChangeSpeedCurve<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06032C76 RID: 207990 RVA: 0x006D9B64 File Offset: 0x006D7D64
		public IEaseCurveCustom ChangeSpeedCurveAsIEaseCurveCustom()
		{
			return this.ChangeSpeedCurve<IEaseCurveCustom>().Value;
		}

		// Token: 0x06032C77 RID: 207991 RVA: 0x006D9B80 File Offset: 0x006D7D80
		public IEaseCurvePreset ChangeSpeedCurveAsIEaseCurvePreset()
		{
			return this.ChangeSpeedCurve<IEaseCurvePreset>().Value;
		}

		// Token: 0x1700D52D RID: 54573
		// (get) Token: 0x06032C78 RID: 207992 RVA: 0x006D9B9C File Offset: 0x006D7D9C
		public bool NotAllowSpeedAdjustmentIfExceed
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D52E RID: 54574
		// (get) Token: 0x06032C79 RID: 207993 RVA: 0x006D9BDC File Offset: 0x006D7DDC
		public bool NotAllowSpeedAdjustmentIfBelow
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D52F RID: 54575
		// (get) Token: 0x06032C7A RID: 207994 RVA: 0x006D9C1C File Offset: 0x006D7E1C
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

		// Token: 0x06032C7B RID: 207995 RVA: 0x006D9C5C File Offset: 0x006D7E5C
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

		// Token: 0x06032C7C RID: 207996 RVA: 0x006D9CB3 File Offset: 0x006D7EB3
		public static void StartISetMotorSpeedTargetSpeed(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06032C7D RID: 207997 RVA: 0x006D9CBC File Offset: 0x006D7EBC
		public static void AddType(FlatBufferBuilder builder, EMotorSpeedType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032C7E RID: 207998 RVA: 0x006D9CC7 File Offset: 0x006D7EC7
		public static void AddTargetSpeed(FlatBufferBuilder builder, float targetSpeed)
		{
			builder.AddFloat(1, targetSpeed, 0.0);
		}

		// Token: 0x06032C7F RID: 207999 RVA: 0x006D9CDA File Offset: 0x006D7EDA
		public static void AddTransitionTime(FlatBufferBuilder builder, float transitionTime)
		{
			builder.AddFloat(2, transitionTime, 0.0);
		}

		// Token: 0x06032C80 RID: 208000 RVA: 0x006D9CED File Offset: 0x006D7EED
		public static void AddChangeSpeedCurveType(FlatBufferBuilder builder, TEaseCurveType changeSpeedCurveType)
		{
			builder.AddByte(3, (byte)changeSpeedCurveType, 0);
		}

		// Token: 0x06032C81 RID: 208001 RVA: 0x006D9CF8 File Offset: 0x006D7EF8
		public static void AddChangeSpeedCurve(FlatBufferBuilder builder, int changeSpeedCurveOffset)
		{
			builder.AddOffset(4, changeSpeedCurveOffset, 0);
		}

		// Token: 0x06032C82 RID: 208002 RVA: 0x006D9D03 File Offset: 0x006D7F03
		public static void AddNotAllowSpeedAdjustmentIfExceed(FlatBufferBuilder builder, bool notAllowSpeedAdjustmentIfExceed)
		{
			builder.AddBool(5, notAllowSpeedAdjustmentIfExceed, false);
		}

		// Token: 0x06032C83 RID: 208003 RVA: 0x006D9D0E File Offset: 0x006D7F0E
		public static void AddNotAllowSpeedAdjustmentIfBelow(FlatBufferBuilder builder, bool notAllowSpeedAdjustmentIfBelow)
		{
			builder.AddBool(6, notAllowSpeedAdjustmentIfBelow, false);
		}

		// Token: 0x06032C84 RID: 208004 RVA: 0x006D9D19 File Offset: 0x006D7F19
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06032C85 RID: 208005 RVA: 0x006D9D24 File Offset: 0x006D7F24
		public static Offset<ISetMotorSpeedTargetSpeed> EndISetMotorSpeedTargetSpeed(FlatBufferBuilder builder)
		{
			return new Offset<ISetMotorSpeedTargetSpeed>(builder.EndTable());
		}

		// Token: 0x06032C86 RID: 208006 RVA: 0x006D9D34 File Offset: 0x006D7F34
		public ISetMotorSpeedTargetSpeedT UnPack()
		{
			ISetMotorSpeedTargetSpeedT setMotorSpeedTargetSpeedT = new ISetMotorSpeedTargetSpeedT();
			this.UnPackTo(setMotorSpeedTargetSpeedT);
			return setMotorSpeedTargetSpeedT;
		}

		// Token: 0x06032C87 RID: 208007 RVA: 0x006D9D50 File Offset: 0x006D7F50
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

		// Token: 0x06032C88 RID: 208008 RVA: 0x006D9E40 File Offset: 0x006D8040
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

		// Token: 0x04011A4B RID: 72267
		private Table __p;
	}
}
