using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FCA RID: 20426
	public struct ICommonRotationConfig : IFlatbufferObject
	{
		// Token: 0x170093F2 RID: 37874
		// (get) Token: 0x06020865 RID: 133221 RVA: 0x00485FC8 File Offset: 0x004841C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020866 RID: 133222 RVA: 0x00485FD5 File Offset: 0x004841D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020867 RID: 133223 RVA: 0x00485FDC File Offset: 0x004841DC
		public static ICommonRotationConfig GetRootAsICommonRotationConfig(ByteBuffer _bb)
		{
			return ICommonRotationConfig.GetRootAsICommonRotationConfig(_bb, default(ICommonRotationConfig));
		}

		// Token: 0x06020868 RID: 133224 RVA: 0x00485FF8 File Offset: 0x004841F8
		public static ICommonRotationConfig GetRootAsICommonRotationConfig(ByteBuffer _bb, ICommonRotationConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020869 RID: 133225 RVA: 0x00486015 File Offset: 0x00484215
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602086A RID: 133226 RVA: 0x00486024 File Offset: 0x00484224
		public ICommonRotationConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170093F3 RID: 37875
		// (get) Token: 0x0602086B RID: 133227 RVA: 0x00486034 File Offset: 0x00484234
		public ERotationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERotationType.Relative;
				}
				return (ERotationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170093F4 RID: 37876
		// (get) Token: 0x0602086C RID: 133228 RVA: 0x00486070 File Offset: 0x00484270
		public float Time
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

		// Token: 0x170093F5 RID: 37877
		// (get) Token: 0x0602086D RID: 133229 RVA: 0x004860B0 File Offset: 0x004842B0
		public float Cd
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

		// Token: 0x170093F6 RID: 37878
		// (get) Token: 0x0602086E RID: 133230 RVA: 0x004860F0 File Offset: 0x004842F0
		public string Curve
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602086F RID: 133231 RVA: 0x00486128 File Offset: 0x00484328
		public Span<byte> GetCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06020870 RID: 133232 RVA: 0x00486138 File Offset: 0x00484338
		public byte[] GetCurveArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x170093F7 RID: 37879
		// (get) Token: 0x06020871 RID: 133233 RVA: 0x00486148 File Offset: 0x00484348
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020872 RID: 133234 RVA: 0x00486185 File Offset: 0x00484385
		public static Offset<ICommonRotationConfig> CreateICommonRotationConfig(FlatBufferBuilder builder, ERotationType Type = ERotationType.Relative, float Time = 0f, float Cd = 0f, StringOffset CurveOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			ICommonRotationConfig.AddCurve(builder, CurveOffset);
			ICommonRotationConfig.AddCd(builder, Cd);
			ICommonRotationConfig.AddTime(builder, Time);
			ICommonRotationConfig.AddNullMask(builder, NullMask);
			ICommonRotationConfig.AddType(builder, Type);
			return ICommonRotationConfig.EndICommonRotationConfig(builder);
		}

		// Token: 0x06020873 RID: 133235 RVA: 0x004861B9 File Offset: 0x004843B9
		public static void StartICommonRotationConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06020874 RID: 133236 RVA: 0x004861C2 File Offset: 0x004843C2
		public static void AddType(FlatBufferBuilder builder, ERotationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020875 RID: 133237 RVA: 0x004861CD File Offset: 0x004843CD
		public static void AddTime(FlatBufferBuilder builder, float time)
		{
			builder.AddFloat(1, time, 0.0);
		}

		// Token: 0x06020876 RID: 133238 RVA: 0x004861E0 File Offset: 0x004843E0
		public static void AddCd(FlatBufferBuilder builder, float cd)
		{
			builder.AddFloat(2, cd, 0.0);
		}

		// Token: 0x06020877 RID: 133239 RVA: 0x004861F3 File Offset: 0x004843F3
		public static void AddCurve(FlatBufferBuilder builder, StringOffset curveOffset)
		{
			builder.AddOffset(3, curveOffset.Value, 0);
		}

		// Token: 0x06020878 RID: 133240 RVA: 0x00486203 File Offset: 0x00484403
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06020879 RID: 133241 RVA: 0x0048620E File Offset: 0x0048440E
		public static Offset<ICommonRotationConfig> EndICommonRotationConfig(FlatBufferBuilder builder)
		{
			return new Offset<ICommonRotationConfig>(builder.EndTable());
		}

		// Token: 0x0602087A RID: 133242 RVA: 0x0048621C File Offset: 0x0048441C
		public ICommonRotationConfigT UnPack()
		{
			ICommonRotationConfigT commonRotationConfigT = new ICommonRotationConfigT();
			this.UnPackTo(commonRotationConfigT);
			return commonRotationConfigT;
		}

		// Token: 0x0602087B RID: 133243 RVA: 0x00486237 File Offset: 0x00484437
		public void UnPackTo(ICommonRotationConfigT _o)
		{
			_o.Type = this.Type;
			_o.Time = this.Time;
			_o.Cd = this.Cd;
			_o.Curve = this.Curve;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602087C RID: 133244 RVA: 0x00486278 File Offset: 0x00484478
		public static Offset<ICommonRotationConfig> Pack(FlatBufferBuilder builder, ICommonRotationConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonRotationConfig>);
			}
			StringOffset curveOffset = (_o.Curve == null) ? default(StringOffset) : builder.CreateString(_o.Curve);
			return ICommonRotationConfig.CreateICommonRotationConfig(builder, _o.Type, _o.Time, _o.Cd, curveOffset, _o.NullMask);
		}

		// Token: 0x0400DEAB RID: 57003
		private Table __p;
	}
}
