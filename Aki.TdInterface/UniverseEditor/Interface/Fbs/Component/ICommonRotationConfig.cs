using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005529 RID: 21801
	public struct ICommonRotationConfig : IFlatbufferObject
	{
		// Token: 0x17009BD3 RID: 39891
		// (get) Token: 0x0602277F RID: 141183 RVA: 0x004BF944 File Offset: 0x004BDB44
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022780 RID: 141184 RVA: 0x004BF951 File Offset: 0x004BDB51
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022781 RID: 141185 RVA: 0x004BF958 File Offset: 0x004BDB58
		public static ICommonRotationConfig GetRootAsICommonRotationConfig(ByteBuffer _bb)
		{
			return ICommonRotationConfig.GetRootAsICommonRotationConfig(_bb, default(ICommonRotationConfig));
		}

		// Token: 0x06022782 RID: 141186 RVA: 0x004BF974 File Offset: 0x004BDB74
		public static ICommonRotationConfig GetRootAsICommonRotationConfig(ByteBuffer _bb, ICommonRotationConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022783 RID: 141187 RVA: 0x004BF991 File Offset: 0x004BDB91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022784 RID: 141188 RVA: 0x004BF9A0 File Offset: 0x004BDBA0
		public ICommonRotationConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009BD4 RID: 39892
		// (get) Token: 0x06022785 RID: 141189 RVA: 0x004BF9B0 File Offset: 0x004BDBB0
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

		// Token: 0x17009BD5 RID: 39893
		// (get) Token: 0x06022786 RID: 141190 RVA: 0x004BF9EC File Offset: 0x004BDBEC
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

		// Token: 0x17009BD6 RID: 39894
		// (get) Token: 0x06022787 RID: 141191 RVA: 0x004BFA2C File Offset: 0x004BDC2C
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

		// Token: 0x17009BD7 RID: 39895
		// (get) Token: 0x06022788 RID: 141192 RVA: 0x004BFA6C File Offset: 0x004BDC6C
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

		// Token: 0x06022789 RID: 141193 RVA: 0x004BFAA4 File Offset: 0x004BDCA4
		public Span<byte> GetCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0602278A RID: 141194 RVA: 0x004BFAB4 File Offset: 0x004BDCB4
		public byte[] GetCurveArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x17009BD8 RID: 39896
		// (get) Token: 0x0602278B RID: 141195 RVA: 0x004BFAC4 File Offset: 0x004BDCC4
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

		// Token: 0x0602278C RID: 141196 RVA: 0x004BFB01 File Offset: 0x004BDD01
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

		// Token: 0x0602278D RID: 141197 RVA: 0x004BFB35 File Offset: 0x004BDD35
		public static void StartICommonRotationConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602278E RID: 141198 RVA: 0x004BFB3E File Offset: 0x004BDD3E
		public static void AddType(FlatBufferBuilder builder, ERotationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602278F RID: 141199 RVA: 0x004BFB49 File Offset: 0x004BDD49
		public static void AddTime(FlatBufferBuilder builder, float time)
		{
			builder.AddFloat(1, time, 0.0);
		}

		// Token: 0x06022790 RID: 141200 RVA: 0x004BFB5C File Offset: 0x004BDD5C
		public static void AddCd(FlatBufferBuilder builder, float cd)
		{
			builder.AddFloat(2, cd, 0.0);
		}

		// Token: 0x06022791 RID: 141201 RVA: 0x004BFB6F File Offset: 0x004BDD6F
		public static void AddCurve(FlatBufferBuilder builder, StringOffset curveOffset)
		{
			builder.AddOffset(3, curveOffset.Value, 0);
		}

		// Token: 0x06022792 RID: 141202 RVA: 0x004BFB7F File Offset: 0x004BDD7F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06022793 RID: 141203 RVA: 0x004BFB8A File Offset: 0x004BDD8A
		public static Offset<ICommonRotationConfig> EndICommonRotationConfig(FlatBufferBuilder builder)
		{
			return new Offset<ICommonRotationConfig>(builder.EndTable());
		}

		// Token: 0x06022794 RID: 141204 RVA: 0x004BFB98 File Offset: 0x004BDD98
		public ICommonRotationConfigT UnPack()
		{
			ICommonRotationConfigT commonRotationConfigT = new ICommonRotationConfigT();
			this.UnPackTo(commonRotationConfigT);
			return commonRotationConfigT;
		}

		// Token: 0x06022795 RID: 141205 RVA: 0x004BFBB3 File Offset: 0x004BDDB3
		public void UnPackTo(ICommonRotationConfigT _o)
		{
			_o.Type = this.Type;
			_o.Time = this.Time;
			_o.Cd = this.Cd;
			_o.Curve = this.Curve;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06022796 RID: 141206 RVA: 0x004BFBF4 File Offset: 0x004BDDF4
		public static Offset<ICommonRotationConfig> Pack(FlatBufferBuilder builder, ICommonRotationConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonRotationConfig>);
			}
			StringOffset curveOffset = (_o.Curve == null) ? default(StringOffset) : builder.CreateString(_o.Curve);
			return ICommonRotationConfig.CreateICommonRotationConfig(builder, _o.Type, _o.Time, _o.Cd, curveOffset, _o.NullMask);
		}

		// Token: 0x0400EA9E RID: 60062
		private Table __p;
	}
}
