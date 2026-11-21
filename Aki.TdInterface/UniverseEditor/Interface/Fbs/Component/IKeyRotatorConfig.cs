using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A3B RID: 23099
	public struct IKeyRotatorConfig : IFlatbufferObject
	{
		// Token: 0x1700A7F7 RID: 42999
		// (get) Token: 0x06025C34 RID: 154676 RVA: 0x0052D4EC File Offset: 0x0052B6EC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025C35 RID: 154677 RVA: 0x0052D4F9 File Offset: 0x0052B6F9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025C36 RID: 154678 RVA: 0x0052D500 File Offset: 0x0052B700
		public static IKeyRotatorConfig GetRootAsIKeyRotatorConfig(ByteBuffer _bb)
		{
			return IKeyRotatorConfig.GetRootAsIKeyRotatorConfig(_bb, default(IKeyRotatorConfig));
		}

		// Token: 0x06025C37 RID: 154679 RVA: 0x0052D51C File Offset: 0x0052B71C
		public static IKeyRotatorConfig GetRootAsIKeyRotatorConfig(ByteBuffer _bb, IKeyRotatorConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025C38 RID: 154680 RVA: 0x0052D539 File Offset: 0x0052B739
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025C39 RID: 154681 RVA: 0x0052D548 File Offset: 0x0052B748
		public IKeyRotatorConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A7F8 RID: 43000
		// (get) Token: 0x06025C3A RID: 154682 RVA: 0x0052D558 File Offset: 0x0052B758
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

		// Token: 0x1700A7F9 RID: 43001
		// (get) Token: 0x06025C3B RID: 154683 RVA: 0x0052D594 File Offset: 0x0052B794
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

		// Token: 0x1700A7FA RID: 43002
		// (get) Token: 0x06025C3C RID: 154684 RVA: 0x0052D5D4 File Offset: 0x0052B7D4
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

		// Token: 0x1700A7FB RID: 43003
		// (get) Token: 0x06025C3D RID: 154685 RVA: 0x0052D614 File Offset: 0x0052B814
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

		// Token: 0x06025C3E RID: 154686 RVA: 0x0052D64C File Offset: 0x0052B84C
		public Span<byte> GetCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06025C3F RID: 154687 RVA: 0x0052D65C File Offset: 0x0052B85C
		public byte[] GetCurveArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700A7FC RID: 43004
		// (get) Token: 0x06025C40 RID: 154688 RVA: 0x0052D66C File Offset: 0x0052B86C
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

		// Token: 0x1700A7FD RID: 43005
		// (get) Token: 0x06025C41 RID: 154689 RVA: 0x0052D6CC File Offset: 0x0052B8CC
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

		// Token: 0x06025C42 RID: 154690 RVA: 0x0052D709 File Offset: 0x0052B909
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

		// Token: 0x06025C43 RID: 154691 RVA: 0x0052D745 File Offset: 0x0052B945
		public static void StartIKeyRotatorConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06025C44 RID: 154692 RVA: 0x0052D74E File Offset: 0x0052B94E
		public static void AddType(FlatBufferBuilder builder, ERotationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025C45 RID: 154693 RVA: 0x0052D759 File Offset: 0x0052B959
		public static void AddTime(FlatBufferBuilder builder, float time)
		{
			builder.AddFloat(1, time, 0.0);
		}

		// Token: 0x06025C46 RID: 154694 RVA: 0x0052D76C File Offset: 0x0052B96C
		public static void AddCd(FlatBufferBuilder builder, float cd)
		{
			builder.AddFloat(2, cd, 0.0);
		}

		// Token: 0x06025C47 RID: 154695 RVA: 0x0052D77F File Offset: 0x0052B97F
		public static void AddCurve(FlatBufferBuilder builder, StringOffset curveOffset)
		{
			builder.AddOffset(3, curveOffset.Value, 0);
		}

		// Token: 0x06025C48 RID: 154696 RVA: 0x0052D78F File Offset: 0x0052B98F
		public static void AddKeyRotator(FlatBufferBuilder builder, Offset<IVectorInfo> keyRotatorOffset)
		{
			builder.AddOffset(4, keyRotatorOffset.Value, 0);
		}

		// Token: 0x06025C49 RID: 154697 RVA: 0x0052D79F File Offset: 0x0052B99F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06025C4A RID: 154698 RVA: 0x0052D7AA File Offset: 0x0052B9AA
		public static Offset<IKeyRotatorConfig> EndIKeyRotatorConfig(FlatBufferBuilder builder)
		{
			return new Offset<IKeyRotatorConfig>(builder.EndTable());
		}

		// Token: 0x06025C4B RID: 154699 RVA: 0x0052D7B8 File Offset: 0x0052B9B8
		public IKeyRotatorConfigT UnPack()
		{
			IKeyRotatorConfigT keyRotatorConfigT = new IKeyRotatorConfigT();
			this.UnPackTo(keyRotatorConfigT);
			return keyRotatorConfigT;
		}

		// Token: 0x06025C4C RID: 154700 RVA: 0x0052D7D4 File Offset: 0x0052B9D4
		public void UnPackTo(IKeyRotatorConfigT _o)
		{
			_o.Type = this.Type;
			_o.Time = this.Time;
			_o.Cd = this.Cd;
			_o.Curve = this.Curve;
			_o.KeyRotator = ((this.KeyRotator != null) ? this.KeyRotator.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06025C4D RID: 154701 RVA: 0x0052D84C File Offset: 0x0052BA4C
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

		// Token: 0x0400F394 RID: 62356
		private Table __p;
	}
}
