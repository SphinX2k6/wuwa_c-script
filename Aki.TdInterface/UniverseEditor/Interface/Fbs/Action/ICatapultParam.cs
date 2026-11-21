using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006928 RID: 26920
	public struct ICatapultParam : IFlatbufferObject
	{
		// Token: 0x1700C62E RID: 50734
		// (get) Token: 0x0602E21E RID: 188958 RVA: 0x0064DC03 File Offset: 0x0064BE03
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E21F RID: 188959 RVA: 0x0064DC10 File Offset: 0x0064BE10
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E220 RID: 188960 RVA: 0x0064DC18 File Offset: 0x0064BE18
		public static ICatapultParam GetRootAsICatapultParam(ByteBuffer _bb)
		{
			return ICatapultParam.GetRootAsICatapultParam(_bb, default(ICatapultParam));
		}

		// Token: 0x0602E221 RID: 188961 RVA: 0x0064DC34 File Offset: 0x0064BE34
		public static ICatapultParam GetRootAsICatapultParam(ByteBuffer _bb, ICatapultParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E222 RID: 188962 RVA: 0x0064DC51 File Offset: 0x0064BE51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E223 RID: 188963 RVA: 0x0064DC60 File Offset: 0x0064BE60
		public ICatapultParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C62F RID: 50735
		// (get) Token: 0x0602E224 RID: 188964 RVA: 0x0064DC70 File Offset: 0x0064BE70
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

		// Token: 0x1700C630 RID: 50736
		// (get) Token: 0x0602E225 RID: 188965 RVA: 0x0064DCD0 File Offset: 0x0064BED0
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

		// Token: 0x1700C631 RID: 50737
		// (get) Token: 0x0602E226 RID: 188966 RVA: 0x0064DD30 File Offset: 0x0064BF30
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

		// Token: 0x1700C632 RID: 50738
		// (get) Token: 0x0602E227 RID: 188967 RVA: 0x0064DD70 File Offset: 0x0064BF70
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

		// Token: 0x1700C633 RID: 50739
		// (get) Token: 0x0602E228 RID: 188968 RVA: 0x0064DDB4 File Offset: 0x0064BFB4
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

		// Token: 0x0602E229 RID: 188969 RVA: 0x0064DDEC File Offset: 0x0064BFEC
		public Span<byte> GetMotionCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0602E22A RID: 188970 RVA: 0x0064DDFC File Offset: 0x0064BFFC
		public byte[] GetMotionCurveArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700C634 RID: 50740
		// (get) Token: 0x0602E22B RID: 188971 RVA: 0x0064DE0C File Offset: 0x0064C00C
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

		// Token: 0x0602E22C RID: 188972 RVA: 0x0064DE49 File Offset: 0x0064C049
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

		// Token: 0x0602E22D RID: 188973 RVA: 0x0064DE85 File Offset: 0x0064C085
		public static void StartICatapultParam(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602E22E RID: 188974 RVA: 0x0064DE8E File Offset: 0x0064C08E
		public static void AddP1(FlatBufferBuilder builder, Offset<IVectorInfo> p1Offset)
		{
			builder.AddOffset(0, p1Offset.Value, 0);
		}

		// Token: 0x0602E22F RID: 188975 RVA: 0x0064DE9E File Offset: 0x0064C09E
		public static void AddP2(FlatBufferBuilder builder, Offset<IVectorInfo> p2Offset)
		{
			builder.AddOffset(1, p2Offset.Value, 0);
		}

		// Token: 0x0602E230 RID: 188976 RVA: 0x0064DEAE File Offset: 0x0064C0AE
		public static void AddGravity(FlatBufferBuilder builder, float gravity)
		{
			builder.AddFloat(2, gravity, 0.0);
		}

		// Token: 0x0602E231 RID: 188977 RVA: 0x0064DEC1 File Offset: 0x0064C0C1
		public static void AddTime(FlatBufferBuilder builder, float time)
		{
			builder.AddFloat(3, time, 0.0);
		}

		// Token: 0x0602E232 RID: 188978 RVA: 0x0064DED4 File Offset: 0x0064C0D4
		public static void AddMotionCurve(FlatBufferBuilder builder, StringOffset motionCurveOffset)
		{
			builder.AddOffset(4, motionCurveOffset.Value, 0);
		}

		// Token: 0x0602E233 RID: 188979 RVA: 0x0064DEE4 File Offset: 0x0064C0E4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602E234 RID: 188980 RVA: 0x0064DEEF File Offset: 0x0064C0EF
		public static Offset<ICatapultParam> EndICatapultParam(FlatBufferBuilder builder)
		{
			return new Offset<ICatapultParam>(builder.EndTable());
		}

		// Token: 0x0602E235 RID: 188981 RVA: 0x0064DEFC File Offset: 0x0064C0FC
		public ICatapultParamT UnPack()
		{
			ICatapultParamT catapultParamT = new ICatapultParamT();
			this.UnPackTo(catapultParamT);
			return catapultParamT;
		}

		// Token: 0x0602E236 RID: 188982 RVA: 0x0064DF18 File Offset: 0x0064C118
		public void UnPackTo(ICatapultParamT _o)
		{
			_o.P1 = ((this.P1 != null) ? this.P1.Value.UnPack() : null);
			_o.P2 = ((this.P2 != null) ? this.P2.Value.UnPack() : null);
			_o.Gravity = this.Gravity;
			_o.Time = this.Time;
			_o.MotionCurve = this.MotionCurve;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602E237 RID: 188983 RVA: 0x0064DFB4 File Offset: 0x0064C1B4
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

		// Token: 0x0401166B RID: 71275
		private Table __p;
	}
}
