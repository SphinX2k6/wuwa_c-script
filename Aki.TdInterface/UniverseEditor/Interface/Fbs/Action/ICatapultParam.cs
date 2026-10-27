using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062B7 RID: 25271
	public struct ICatapultParam : IFlatbufferObject
	{
		// Token: 0x1700BCA4 RID: 48292
		// (get) Token: 0x0602BAB5 RID: 178869 RVA: 0x00602BF8 File Offset: 0x00600DF8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BAB6 RID: 178870 RVA: 0x00602C05 File Offset: 0x00600E05
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BAB7 RID: 178871 RVA: 0x00602C0C File Offset: 0x00600E0C
		public static ICatapultParam GetRootAsICatapultParam(ByteBuffer _bb)
		{
			return ICatapultParam.GetRootAsICatapultParam(_bb, default(ICatapultParam));
		}

		// Token: 0x0602BAB8 RID: 178872 RVA: 0x00602C28 File Offset: 0x00600E28
		public static ICatapultParam GetRootAsICatapultParam(ByteBuffer _bb, ICatapultParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BAB9 RID: 178873 RVA: 0x00602C45 File Offset: 0x00600E45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BABA RID: 178874 RVA: 0x00602C54 File Offset: 0x00600E54
		public ICatapultParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BCA5 RID: 48293
		// (get) Token: 0x0602BABB RID: 178875 RVA: 0x00602C64 File Offset: 0x00600E64
		public IVectorInfo? P1
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700BCA6 RID: 48294
		// (get) Token: 0x0602BABC RID: 178876 RVA: 0x00602CC4 File Offset: 0x00600EC4
		public IVectorInfo? P2
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

		// Token: 0x1700BCA7 RID: 48295
		// (get) Token: 0x0602BABD RID: 178877 RVA: 0x00602D24 File Offset: 0x00600F24
		public float Gravity
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

		// Token: 0x1700BCA8 RID: 48296
		// (get) Token: 0x0602BABE RID: 178878 RVA: 0x00602D64 File Offset: 0x00600F64
		public float Time
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

		// Token: 0x1700BCA9 RID: 48297
		// (get) Token: 0x0602BABF RID: 178879 RVA: 0x00602DA8 File Offset: 0x00600FA8
		public string MotionCurve
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602BAC0 RID: 178880 RVA: 0x00602DE0 File Offset: 0x00600FE0
		public Span<byte> GetMotionCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0602BAC1 RID: 178881 RVA: 0x00602DF0 File Offset: 0x00600FF0
		public byte[] GetMotionCurveArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700BCAA RID: 48298
		// (get) Token: 0x0602BAC2 RID: 178882 RVA: 0x00602E00 File Offset: 0x00601000
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602BAC3 RID: 178883 RVA: 0x00602E3D File Offset: 0x0060103D
		public static Offset<ICatapultParam> CreateICatapultParam(FlatBufferBuilder builder, Offset<IVectorInfo> P1Offset = default(Offset<IVectorInfo>), Offset<IVectorInfo> P2Offset = default(Offset<IVectorInfo>), float Gravity = 0f, float Time = 0f, StringOffset MotionCurveOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			ICatapultParam.AddMotionCurve(builder, MotionCurveOffset);
			ICatapultParam.AddTime(builder, Time);
			ICatapultParam.AddGravity(builder, Gravity);
			ICatapultParam.AddP2(builder, P2Offset);
			ICatapultParam.AddP1(builder, P1Offset);
			ICatapultParam.AddNullMask(builder, NullMask);
			return ICatapultParam.EndICatapultParam(builder);
		}

		// Token: 0x0602BAC4 RID: 178884 RVA: 0x00602E79 File Offset: 0x00601079
		public static void StartICatapultParam(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602BAC5 RID: 178885 RVA: 0x00602E82 File Offset: 0x00601082
		public static void AddP1(FlatBufferBuilder builder, Offset<IVectorInfo> p1Offset)
		{
			builder.AddOffset(0, p1Offset.Value, 0);
		}

		// Token: 0x0602BAC6 RID: 178886 RVA: 0x00602E92 File Offset: 0x00601092
		public static void AddP2(FlatBufferBuilder builder, Offset<IVectorInfo> p2Offset)
		{
			builder.AddOffset(1, p2Offset.Value, 0);
		}

		// Token: 0x0602BAC7 RID: 178887 RVA: 0x00602EA2 File Offset: 0x006010A2
		public static void AddGravity(FlatBufferBuilder builder, float gravity)
		{
			builder.AddFloat(2, gravity, 0.0);
		}

		// Token: 0x0602BAC8 RID: 178888 RVA: 0x00602EB5 File Offset: 0x006010B5
		public static void AddTime(FlatBufferBuilder builder, float time)
		{
			builder.AddFloat(3, time, 0.0);
		}

		// Token: 0x0602BAC9 RID: 178889 RVA: 0x00602EC8 File Offset: 0x006010C8
		public static void AddMotionCurve(FlatBufferBuilder builder, StringOffset motionCurveOffset)
		{
			builder.AddOffset(4, motionCurveOffset.Value, 0);
		}

		// Token: 0x0602BACA RID: 178890 RVA: 0x00602ED8 File Offset: 0x006010D8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602BACB RID: 178891 RVA: 0x00602EE3 File Offset: 0x006010E3
		public static Offset<ICatapultParam> EndICatapultParam(FlatBufferBuilder builder)
		{
			return new Offset<ICatapultParam>(builder.EndTable());
		}

		// Token: 0x0602BACC RID: 178892 RVA: 0x00602EF0 File Offset: 0x006010F0
		public ICatapultParamT UnPack()
		{
			ICatapultParamT catapultParamT = new ICatapultParamT();
			this.UnPackTo(catapultParamT);
			return catapultParamT;
		}

		// Token: 0x0602BACD RID: 178893 RVA: 0x00602F0C File Offset: 0x0060110C
		public void UnPackTo(ICatapultParamT _o)
		{
			_o.P1 = ((this.P1 != null) ? this.P1.Value.UnPack() : null);
			_o.P2 = ((this.P2 != null) ? this.P2.Value.UnPack() : null);
			_o.Gravity = this.Gravity;
			_o.Time = this.Time;
			_o.MotionCurve = this.MotionCurve;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602BACE RID: 178894 RVA: 0x00602FA8 File Offset: 0x006011A8
		public static Offset<ICatapultParam> Pack(FlatBufferBuilder builder, ICatapultParamT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICatapultParam>);
			}
			Offset<IVectorInfo> p1Offset = (_o.P1 == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.P1);
			Offset<IVectorInfo> p2Offset = (_o.P2 == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.P2);
			StringOffset motionCurveOffset = (_o.MotionCurve == null) ? default(StringOffset) : builder.CreateString(_o.MotionCurve);
			return ICatapultParam.CreateICatapultParam(builder, p1Offset, p2Offset, _o.Gravity, _o.Time, motionCurveOffset, _o.NullMask);
		}

		// Token: 0x04010855 RID: 67669
		private Table __p;
	}
}
