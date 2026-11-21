using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007282 RID: 29314
	public struct IMotorSoarInWindFieldEnterWindField : IFlatbufferObject
	{
		// Token: 0x1700D6D9 RID: 55001
		// (get) Token: 0x06033136 RID: 209206 RVA: 0x006E49D4 File Offset: 0x006E2BD4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033137 RID: 209207 RVA: 0x006E49E1 File Offset: 0x006E2BE1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033138 RID: 209208 RVA: 0x006E49E8 File Offset: 0x006E2BE8
		public static IMotorSoarInWindFieldEnterWindField GetRootAsIMotorSoarInWindFieldEnterWindField(ByteBuffer _bb)
		{
			return IMotorSoarInWindFieldEnterWindField.GetRootAsIMotorSoarInWindFieldEnterWindField(_bb, default(IMotorSoarInWindFieldEnterWindField));
		}

		// Token: 0x06033139 RID: 209209 RVA: 0x006E4A04 File Offset: 0x006E2C04
		public static IMotorSoarInWindFieldEnterWindField GetRootAsIMotorSoarInWindFieldEnterWindField(ByteBuffer _bb, IMotorSoarInWindFieldEnterWindField obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603313A RID: 209210 RVA: 0x006E4A21 File Offset: 0x006E2C21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603313B RID: 209211 RVA: 0x006E4A30 File Offset: 0x006E2C30
		public IMotorSoarInWindFieldEnterWindField __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D6DA RID: 55002
		// (get) Token: 0x0603313C RID: 209212 RVA: 0x006E4A40 File Offset: 0x006E2C40
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

		// Token: 0x1700D6DB RID: 55003
		// (get) Token: 0x0603313D RID: 209213 RVA: 0x006E4A7C File Offset: 0x006E2C7C
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

		// Token: 0x1700D6DC RID: 55004
		// (get) Token: 0x0603313E RID: 209214 RVA: 0x006E4ADC File Offset: 0x006E2CDC
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

		// Token: 0x1700D6DD RID: 55005
		// (get) Token: 0x0603313F RID: 209215 RVA: 0x006E4B3C File Offset: 0x006E2D3C
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

		// Token: 0x1700D6DE RID: 55006
		// (get) Token: 0x06033140 RID: 209216 RVA: 0x006E4B80 File Offset: 0x006E2D80
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

		// Token: 0x1700D6DF RID: 55007
		// (get) Token: 0x06033141 RID: 209217 RVA: 0x006E4BC4 File Offset: 0x006E2DC4
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

		// Token: 0x06033142 RID: 209218 RVA: 0x006E4BFC File Offset: 0x006E2DFC
		public Span<byte> GetSpeedCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06033143 RID: 209219 RVA: 0x006E4C0C File Offset: 0x006E2E0C
		public byte[] GetSpeedCurveArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x1700D6E0 RID: 55008
		// (get) Token: 0x06033144 RID: 209220 RVA: 0x006E4C1C File Offset: 0x006E2E1C
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

		// Token: 0x06033145 RID: 209221 RVA: 0x006E4C60 File Offset: 0x006E2E60
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

		// Token: 0x06033146 RID: 209222 RVA: 0x006E4CAF File Offset: 0x006E2EAF
		public static void StartIMotorSoarInWindFieldEnterWindField(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06033147 RID: 209223 RVA: 0x006E4CB8 File Offset: 0x006E2EB8
		public static void AddType(FlatBufferBuilder builder, EMotorSoarInWindFieldControlType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033148 RID: 209224 RVA: 0x006E4CC3 File Offset: 0x006E2EC3
		public static void AddDirection(FlatBufferBuilder builder, Offset<IVectorInfo> directionOffset)
		{
			builder.AddOffset(1, directionOffset.Value, 0);
		}

		// Token: 0x06033149 RID: 209225 RVA: 0x006E4CD3 File Offset: 0x006E2ED3
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(2, offsetOffset.Value, 0);
		}

		// Token: 0x0603314A RID: 209226 RVA: 0x006E4CE3 File Offset: 0x006E2EE3
		public static void AddWindFieldDepth(FlatBufferBuilder builder, float windFieldDepth)
		{
			builder.AddFloat(3, windFieldDepth, 0.0);
		}

		// Token: 0x0603314B RID: 209227 RVA: 0x006E4CF6 File Offset: 0x006E2EF6
		public static void AddMaxAdditionalSpeed(FlatBufferBuilder builder, float maxAdditionalSpeed)
		{
			builder.AddFloat(4, maxAdditionalSpeed, 0.0);
		}

		// Token: 0x0603314C RID: 209228 RVA: 0x006E4D09 File Offset: 0x006E2F09
		public static void AddSpeedCurve(FlatBufferBuilder builder, StringOffset speedCurveOffset)
		{
			builder.AddOffset(5, speedCurveOffset.Value, 0);
		}

		// Token: 0x0603314D RID: 209229 RVA: 0x006E4D19 File Offset: 0x006E2F19
		public static void AddSpeedTolerance(FlatBufferBuilder builder, float speedTolerance)
		{
			builder.AddFloat(6, speedTolerance, 0.0);
		}

		// Token: 0x0603314E RID: 209230 RVA: 0x006E4D2C File Offset: 0x006E2F2C
		public static Offset<IMotorSoarInWindFieldEnterWindField> EndIMotorSoarInWindFieldEnterWindField(FlatBufferBuilder builder)
		{
			return new Offset<IMotorSoarInWindFieldEnterWindField>(builder.EndTable());
		}

		// Token: 0x0603314F RID: 209231 RVA: 0x006E4D3C File Offset: 0x006E2F3C
		public IMotorSoarInWindFieldEnterWindFieldT UnPack()
		{
			IMotorSoarInWindFieldEnterWindFieldT motorSoarInWindFieldEnterWindFieldT = new IMotorSoarInWindFieldEnterWindFieldT();
			this.UnPackTo(motorSoarInWindFieldEnterWindFieldT);
			return motorSoarInWindFieldEnterWindFieldT;
		}

		// Token: 0x06033150 RID: 209232 RVA: 0x006E4D58 File Offset: 0x006E2F58
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

		// Token: 0x06033151 RID: 209233 RVA: 0x006E4E00 File Offset: 0x006E3000
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

		// Token: 0x040122FF RID: 74495
		private Table __p;
	}
}
