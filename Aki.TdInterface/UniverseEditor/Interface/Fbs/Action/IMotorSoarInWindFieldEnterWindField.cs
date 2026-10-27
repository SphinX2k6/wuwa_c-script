using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B3C RID: 27452
	public struct IMotorSoarInWindFieldEnterWindField : IFlatbufferObject
	{
		// Token: 0x1700CBF4 RID: 52212
		// (get) Token: 0x060302DF RID: 197343 RVA: 0x0068C418 File Offset: 0x0068A618
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060302E0 RID: 197344 RVA: 0x0068C425 File Offset: 0x0068A625
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060302E1 RID: 197345 RVA: 0x0068C42C File Offset: 0x0068A62C
		public static IMotorSoarInWindFieldEnterWindField GetRootAsIMotorSoarInWindFieldEnterWindField(ByteBuffer _bb)
		{
			return IMotorSoarInWindFieldEnterWindField.GetRootAsIMotorSoarInWindFieldEnterWindField(_bb, default(IMotorSoarInWindFieldEnterWindField));
		}

		// Token: 0x060302E2 RID: 197346 RVA: 0x0068C448 File Offset: 0x0068A648
		public static IMotorSoarInWindFieldEnterWindField GetRootAsIMotorSoarInWindFieldEnterWindField(ByteBuffer _bb, IMotorSoarInWindFieldEnterWindField obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060302E3 RID: 197347 RVA: 0x0068C465 File Offset: 0x0068A665
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060302E4 RID: 197348 RVA: 0x0068C474 File Offset: 0x0068A674
		public IMotorSoarInWindFieldEnterWindField __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CBF5 RID: 52213
		// (get) Token: 0x060302E5 RID: 197349 RVA: 0x0068C484 File Offset: 0x0068A684
		public EMotorSoarInWindFieldControlType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMotorSoarInWindFieldControlType.EnterWindField;
				}
				return (EMotorSoarInWindFieldControlType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CBF6 RID: 52214
		// (get) Token: 0x060302E6 RID: 197350 RVA: 0x0068C4C0 File Offset: 0x0068A6C0
		public IVectorInfo? Direction
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CBF7 RID: 52215
		// (get) Token: 0x060302E7 RID: 197351 RVA: 0x0068C520 File Offset: 0x0068A720
		public IVectorInfo? Offset
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CBF8 RID: 52216
		// (get) Token: 0x060302E8 RID: 197352 RVA: 0x0068C580 File Offset: 0x0068A780
		public float WindFieldDepth
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

		// Token: 0x1700CBF9 RID: 52217
		// (get) Token: 0x060302E9 RID: 197353 RVA: 0x0068C5C4 File Offset: 0x0068A7C4
		public float MaxAdditionalSpeed
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

		// Token: 0x1700CBFA RID: 52218
		// (get) Token: 0x060302EA RID: 197354 RVA: 0x0068C608 File Offset: 0x0068A808
		public string SpeedCurve
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060302EB RID: 197355 RVA: 0x0068C640 File Offset: 0x0068A840
		public Span<byte> GetSpeedCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060302EC RID: 197356 RVA: 0x0068C650 File Offset: 0x0068A850
		public byte[] GetSpeedCurveArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x1700CBFB RID: 52219
		// (get) Token: 0x060302ED RID: 197357 RVA: 0x0068C660 File Offset: 0x0068A860
		public float SpeedTolerance
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

		// Token: 0x060302EE RID: 197358 RVA: 0x0068C6A4 File Offset: 0x0068A8A4
		public static Offset<IMotorSoarInWindFieldEnterWindField> CreateIMotorSoarInWindFieldEnterWindField(FlatBufferBuilder builder, EMotorSoarInWindFieldControlType Type = EMotorSoarInWindFieldControlType.EnterWindField, Offset<IVectorInfo> DirectionOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>), float WindFieldDepth = 0f, float MaxAdditionalSpeed = 0f, StringOffset SpeedCurveOffset = default(StringOffset), float SpeedTolerance = 0f)
		{
			builder.StartTable(7);
			IMotorSoarInWindFieldEnterWindField.AddSpeedTolerance(builder, SpeedTolerance);
			IMotorSoarInWindFieldEnterWindField.AddSpeedCurve(builder, SpeedCurveOffset);
			IMotorSoarInWindFieldEnterWindField.AddMaxAdditionalSpeed(builder, MaxAdditionalSpeed);
			IMotorSoarInWindFieldEnterWindField.AddWindFieldDepth(builder, WindFieldDepth);
			IMotorSoarInWindFieldEnterWindField.AddOffset(builder, OffsetOffset);
			IMotorSoarInWindFieldEnterWindField.AddDirection(builder, DirectionOffset);
			IMotorSoarInWindFieldEnterWindField.AddType(builder, Type);
			return IMotorSoarInWindFieldEnterWindField.EndIMotorSoarInWindFieldEnterWindField(builder);
		}

		// Token: 0x060302EF RID: 197359 RVA: 0x0068C6F3 File Offset: 0x0068A8F3
		public static void StartIMotorSoarInWindFieldEnterWindField(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x060302F0 RID: 197360 RVA: 0x0068C6FC File Offset: 0x0068A8FC
		public static void AddType(FlatBufferBuilder builder, EMotorSoarInWindFieldControlType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060302F1 RID: 197361 RVA: 0x0068C707 File Offset: 0x0068A907
		public static void AddDirection(FlatBufferBuilder builder, Offset<IVectorInfo> directionOffset)
		{
			builder.AddOffset(1, directionOffset.Value, 0);
		}

		// Token: 0x060302F2 RID: 197362 RVA: 0x0068C717 File Offset: 0x0068A917
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(2, offsetOffset.Value, 0);
		}

		// Token: 0x060302F3 RID: 197363 RVA: 0x0068C727 File Offset: 0x0068A927
		public static void AddWindFieldDepth(FlatBufferBuilder builder, float windFieldDepth)
		{
			builder.AddFloat(3, windFieldDepth, 0.0);
		}

		// Token: 0x060302F4 RID: 197364 RVA: 0x0068C73A File Offset: 0x0068A93A
		public static void AddMaxAdditionalSpeed(FlatBufferBuilder builder, float maxAdditionalSpeed)
		{
			builder.AddFloat(4, maxAdditionalSpeed, 0.0);
		}

		// Token: 0x060302F5 RID: 197365 RVA: 0x0068C74D File Offset: 0x0068A94D
		public static void AddSpeedCurve(FlatBufferBuilder builder, StringOffset speedCurveOffset)
		{
			builder.AddOffset(5, speedCurveOffset.Value, 0);
		}

		// Token: 0x060302F6 RID: 197366 RVA: 0x0068C75D File Offset: 0x0068A95D
		public static void AddSpeedTolerance(FlatBufferBuilder builder, float speedTolerance)
		{
			builder.AddFloat(6, speedTolerance, 0.0);
		}

		// Token: 0x060302F7 RID: 197367 RVA: 0x0068C770 File Offset: 0x0068A970
		public static Offset<IMotorSoarInWindFieldEnterWindField> EndIMotorSoarInWindFieldEnterWindField(FlatBufferBuilder builder)
		{
			return new Offset<IMotorSoarInWindFieldEnterWindField>(builder.EndTable());
		}

		// Token: 0x060302F8 RID: 197368 RVA: 0x0068C780 File Offset: 0x0068A980
		public IMotorSoarInWindFieldEnterWindFieldT UnPack()
		{
			IMotorSoarInWindFieldEnterWindFieldT motorSoarInWindFieldEnterWindFieldT = new IMotorSoarInWindFieldEnterWindFieldT();
			this.UnPackTo(motorSoarInWindFieldEnterWindFieldT);
			return motorSoarInWindFieldEnterWindFieldT;
		}

		// Token: 0x060302F9 RID: 197369 RVA: 0x0068C79C File Offset: 0x0068A99C
		public void UnPackTo(IMotorSoarInWindFieldEnterWindFieldT _o)
		{
			_o.Type = this.Type;
			_o.Direction = ((this.Direction != null) ? this.Direction.Value.UnPack() : null);
			_o.Offset = ((this.Offset != null) ? this.Offset.Value.UnPack() : null);
			_o.WindFieldDepth = this.WindFieldDepth;
			_o.MaxAdditionalSpeed = this.MaxAdditionalSpeed;
			_o.SpeedCurve = this.SpeedCurve;
			_o.SpeedTolerance = this.SpeedTolerance;
		}

		// Token: 0x060302FA RID: 197370 RVA: 0x0068C844 File Offset: 0x0068AA44
		public static Offset<IMotorSoarInWindFieldEnterWindField> Pack(FlatBufferBuilder builder, IMotorSoarInWindFieldEnterWindFieldT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorSoarInWindFieldEnterWindField>);
			}
			Offset<IVectorInfo> directionOffset = (_o.Direction == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Direction);
			Offset<IVectorInfo> offsetOffset = (_o.Offset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Offset);
			StringOffset speedCurveOffset = (_o.SpeedCurve == null) ? default(StringOffset) : builder.CreateString(_o.SpeedCurve);
			return IMotorSoarInWindFieldEnterWindField.CreateIMotorSoarInWindFieldEnterWindField(builder, _o.Type, directionOffset, offsetOffset, _o.WindFieldDepth, _o.MaxAdditionalSpeed, speedCurveOffset, _o.SpeedTolerance);
		}

		// Token: 0x040113D6 RID: 70614
		private Table __p;
	}
}
