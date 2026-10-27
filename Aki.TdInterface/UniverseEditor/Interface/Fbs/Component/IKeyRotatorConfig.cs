using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054B5 RID: 21685
	public struct IKeyRotatorConfig : IFlatbufferObject
	{
		// Token: 0x17009FBD RID: 40893
		// (get) Token: 0x06023B7C RID: 146300 RVA: 0x004F0478 File Offset: 0x004EE678
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023B7D RID: 146301 RVA: 0x004F0485 File Offset: 0x004EE685
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023B7E RID: 146302 RVA: 0x004F048C File Offset: 0x004EE68C
		public static IKeyRotatorConfig GetRootAsIKeyRotatorConfig(ByteBuffer _bb)
		{
			return IKeyRotatorConfig.GetRootAsIKeyRotatorConfig(_bb, default(IKeyRotatorConfig));
		}

		// Token: 0x06023B7F RID: 146303 RVA: 0x004F04A8 File Offset: 0x004EE6A8
		public static IKeyRotatorConfig GetRootAsIKeyRotatorConfig(ByteBuffer _bb, IKeyRotatorConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023B80 RID: 146304 RVA: 0x004F04C5 File Offset: 0x004EE6C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023B81 RID: 146305 RVA: 0x004F04D4 File Offset: 0x004EE6D4
		public IKeyRotatorConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009FBE RID: 40894
		// (get) Token: 0x06023B82 RID: 146306 RVA: 0x004F04E4 File Offset: 0x004EE6E4
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

		// Token: 0x17009FBF RID: 40895
		// (get) Token: 0x06023B83 RID: 146307 RVA: 0x004F0520 File Offset: 0x004EE720
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

		// Token: 0x17009FC0 RID: 40896
		// (get) Token: 0x06023B84 RID: 146308 RVA: 0x004F0560 File Offset: 0x004EE760
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

		// Token: 0x17009FC1 RID: 40897
		// (get) Token: 0x06023B85 RID: 146309 RVA: 0x004F05A0 File Offset: 0x004EE7A0
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

		// Token: 0x06023B86 RID: 146310 RVA: 0x004F05D8 File Offset: 0x004EE7D8
		public Span<byte> GetCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06023B87 RID: 146311 RVA: 0x004F05E8 File Offset: 0x004EE7E8
		public byte[] GetCurveArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x17009FC2 RID: 40898
		// (get) Token: 0x06023B88 RID: 146312 RVA: 0x004F05F8 File Offset: 0x004EE7F8
		public IVectorInfo? KeyRotator
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009FC3 RID: 40899
		// (get) Token: 0x06023B89 RID: 146313 RVA: 0x004F0658 File Offset: 0x004EE858
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

		// Token: 0x06023B8A RID: 146314 RVA: 0x004F0695 File Offset: 0x004EE895
		public static Offset<IKeyRotatorConfig> CreateIKeyRotatorConfig(FlatBufferBuilder builder, ERotationType Type = ERotationType.Relative, float Time = 0f, float Cd = 0f, StringOffset CurveOffset = default(StringOffset), Offset<IVectorInfo> KeyRotatorOffset = default(Offset<IVectorInfo>), byte NullMask = 0)
		{
			builder.StartTable(6);
			IKeyRotatorConfig.AddKeyRotator(builder, KeyRotatorOffset);
			IKeyRotatorConfig.AddCurve(builder, CurveOffset);
			IKeyRotatorConfig.AddCd(builder, Cd);
			IKeyRotatorConfig.AddTime(builder, Time);
			IKeyRotatorConfig.AddNullMask(builder, NullMask);
			IKeyRotatorConfig.AddType(builder, Type);
			return IKeyRotatorConfig.EndIKeyRotatorConfig(builder);
		}

		// Token: 0x06023B8B RID: 146315 RVA: 0x004F06D1 File Offset: 0x004EE8D1
		public static void StartIKeyRotatorConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06023B8C RID: 146316 RVA: 0x004F06DA File Offset: 0x004EE8DA
		public static void AddType(FlatBufferBuilder builder, ERotationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023B8D RID: 146317 RVA: 0x004F06E5 File Offset: 0x004EE8E5
		public static void AddTime(FlatBufferBuilder builder, float time)
		{
			builder.AddFloat(1, time, 0.0);
		}

		// Token: 0x06023B8E RID: 146318 RVA: 0x004F06F8 File Offset: 0x004EE8F8
		public static void AddCd(FlatBufferBuilder builder, float cd)
		{
			builder.AddFloat(2, cd, 0.0);
		}

		// Token: 0x06023B8F RID: 146319 RVA: 0x004F070B File Offset: 0x004EE90B
		public static void AddCurve(FlatBufferBuilder builder, StringOffset curveOffset)
		{
			builder.AddOffset(3, curveOffset.Value, 0);
		}

		// Token: 0x06023B90 RID: 146320 RVA: 0x004F071B File Offset: 0x004EE91B
		public static void AddKeyRotator(FlatBufferBuilder builder, Offset<IVectorInfo> keyRotatorOffset)
		{
			builder.AddOffset(4, keyRotatorOffset.Value, 0);
		}

		// Token: 0x06023B91 RID: 146321 RVA: 0x004F072B File Offset: 0x004EE92B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06023B92 RID: 146322 RVA: 0x004F0736 File Offset: 0x004EE936
		public static Offset<IKeyRotatorConfig> EndIKeyRotatorConfig(FlatBufferBuilder builder)
		{
			return new Offset<IKeyRotatorConfig>(builder.EndTable());
		}

		// Token: 0x06023B93 RID: 146323 RVA: 0x004F0744 File Offset: 0x004EE944
		public IKeyRotatorConfigT UnPack()
		{
			IKeyRotatorConfigT keyRotatorConfigT = new IKeyRotatorConfigT();
			this.UnPackTo(keyRotatorConfigT);
			return keyRotatorConfigT;
		}

		// Token: 0x06023B94 RID: 146324 RVA: 0x004F0760 File Offset: 0x004EE960
		public void UnPackTo(IKeyRotatorConfigT _o)
		{
			_o.Type = this.Type;
			_o.Time = this.Time;
			_o.Cd = this.Cd;
			_o.Curve = this.Curve;
			_o.KeyRotator = ((this.KeyRotator != null) ? this.KeyRotator.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023B95 RID: 146325 RVA: 0x004F07D8 File Offset: 0x004EE9D8
		public static Offset<IKeyRotatorConfig> Pack(FlatBufferBuilder builder, IKeyRotatorConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IKeyRotatorConfig>);
			}
			StringOffset curveOffset = (_o.Curve == null) ? default(StringOffset) : builder.CreateString(_o.Curve);
			Offset<IVectorInfo> keyRotatorOffset = (_o.KeyRotator == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.KeyRotator);
			return IKeyRotatorConfig.CreateIKeyRotatorConfig(builder, _o.Type, _o.Time, _o.Cd, curveOffset, keyRotatorOffset, _o.NullMask);
		}

		// Token: 0x0400E763 RID: 59235
		private Table __p;
	}
}
