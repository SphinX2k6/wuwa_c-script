using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E98 RID: 24216
	public struct IRotationConfig : IFlatbufferObject
	{
		// Token: 0x1700B2B1 RID: 45745
		// (get) Token: 0x06028874 RID: 166004 RVA: 0x0058A68A File Offset: 0x0058888A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028875 RID: 166005 RVA: 0x0058A697 File Offset: 0x00588897
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028876 RID: 166006 RVA: 0x0058A6A0 File Offset: 0x005888A0
		public static IRotationConfig GetRootAsIRotationConfig(ByteBuffer _bb)
		{
			return IRotationConfig.GetRootAsIRotationConfig(_bb, default(IRotationConfig));
		}

		// Token: 0x06028877 RID: 166007 RVA: 0x0058A6BC File Offset: 0x005888BC
		public static IRotationConfig GetRootAsIRotationConfig(ByteBuffer _bb, IRotationConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028878 RID: 166008 RVA: 0x0058A6D9 File Offset: 0x005888D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028879 RID: 166009 RVA: 0x0058A6E8 File Offset: 0x005888E8
		public IRotationConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B2B2 RID: 45746
		// (get) Token: 0x0602887A RID: 166010 RVA: 0x0058A6F8 File Offset: 0x005888F8
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

		// Token: 0x1700B2B3 RID: 45747
		// (get) Token: 0x0602887B RID: 166011 RVA: 0x0058A734 File Offset: 0x00588934
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

		// Token: 0x1700B2B4 RID: 45748
		// (get) Token: 0x0602887C RID: 166012 RVA: 0x0058A774 File Offset: 0x00588974
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

		// Token: 0x1700B2B5 RID: 45749
		// (get) Token: 0x0602887D RID: 166013 RVA: 0x0058A7B4 File Offset: 0x005889B4
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

		// Token: 0x0602887E RID: 166014 RVA: 0x0058A7EC File Offset: 0x005889EC
		public Span<byte> GetCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0602887F RID: 166015 RVA: 0x0058A7FC File Offset: 0x005889FC
		public byte[] GetCurveArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700B2B6 RID: 45750
		// (get) Token: 0x06028880 RID: 166016 RVA: 0x0058A80C File Offset: 0x00588A0C
		public IVectorInfo? Axis
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

		// Token: 0x1700B2B7 RID: 45751
		// (get) Token: 0x06028881 RID: 166017 RVA: 0x0058A86C File Offset: 0x00588A6C
		public float Angle
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B2B8 RID: 45752
		// (get) Token: 0x06028882 RID: 166018 RVA: 0x0058A8B0 File Offset: 0x00588AB0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028883 RID: 166019 RVA: 0x0058A8F0 File Offset: 0x00588AF0
		public static Offset<IRotationConfig> CreateIRotationConfig(FlatBufferBuilder builder, ERotationType Type = ERotationType.Relative, float Time = 0f, float Cd = 0f, StringOffset CurveOffset = default(StringOffset), Offset<IVectorInfo> AxisOffset = default(Offset<IVectorInfo>), float Angle = 0f, byte NullMask = 0)
		{
			builder.StartTable(7);
			IRotationConfig.AddAngle(builder, Angle);
			IRotationConfig.AddAxis(builder, AxisOffset);
			IRotationConfig.AddCurve(builder, CurveOffset);
			IRotationConfig.AddCd(builder, Cd);
			IRotationConfig.AddTime(builder, Time);
			IRotationConfig.AddNullMask(builder, NullMask);
			IRotationConfig.AddType(builder, Type);
			return IRotationConfig.EndIRotationConfig(builder);
		}

		// Token: 0x06028884 RID: 166020 RVA: 0x0058A93F File Offset: 0x00588B3F
		public static void StartIRotationConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06028885 RID: 166021 RVA: 0x0058A948 File Offset: 0x00588B48
		public static void AddType(FlatBufferBuilder builder, ERotationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028886 RID: 166022 RVA: 0x0058A953 File Offset: 0x00588B53
		public static void AddTime(FlatBufferBuilder builder, float time)
		{
			builder.AddFloat(1, time, 0.0);
		}

		// Token: 0x06028887 RID: 166023 RVA: 0x0058A966 File Offset: 0x00588B66
		public static void AddCd(FlatBufferBuilder builder, float cd)
		{
			builder.AddFloat(2, cd, 0.0);
		}

		// Token: 0x06028888 RID: 166024 RVA: 0x0058A979 File Offset: 0x00588B79
		public static void AddCurve(FlatBufferBuilder builder, StringOffset curveOffset)
		{
			builder.AddOffset(3, curveOffset.Value, 0);
		}

		// Token: 0x06028889 RID: 166025 RVA: 0x0058A989 File Offset: 0x00588B89
		public static void AddAxis(FlatBufferBuilder builder, Offset<IVectorInfo> axisOffset)
		{
			builder.AddOffset(4, axisOffset.Value, 0);
		}

		// Token: 0x0602888A RID: 166026 RVA: 0x0058A999 File Offset: 0x00588B99
		public static void AddAngle(FlatBufferBuilder builder, float angle)
		{
			builder.AddFloat(5, angle, 0.0);
		}

		// Token: 0x0602888B RID: 166027 RVA: 0x0058A9AC File Offset: 0x00588BAC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0602888C RID: 166028 RVA: 0x0058A9B7 File Offset: 0x00588BB7
		public static Offset<IRotationConfig> EndIRotationConfig(FlatBufferBuilder builder)
		{
			return new Offset<IRotationConfig>(builder.EndTable());
		}

		// Token: 0x0602888D RID: 166029 RVA: 0x0058A9C4 File Offset: 0x00588BC4
		public IRotationConfigT UnPack()
		{
			IRotationConfigT rotationConfigT = new IRotationConfigT();
			this.UnPackTo(rotationConfigT);
			return rotationConfigT;
		}

		// Token: 0x0602888E RID: 166030 RVA: 0x0058A9E0 File Offset: 0x00588BE0
		public void UnPackTo(IRotationConfigT _o)
		{
			_o.Type = this.Type;
			_o.Time = this.Time;
			_o.Cd = this.Cd;
			_o.Curve = this.Curve;
			_o.Axis = ((this.Axis != null) ? this.Axis.Value.UnPack() : null);
			_o.Angle = this.Angle;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602888F RID: 166031 RVA: 0x0058AA64 File Offset: 0x00588C64
		public static Offset<IRotationConfig> Pack(FlatBufferBuilder builder, IRotationConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRotationConfig>);
			}
			StringOffset curveOffset = (_o.Curve == null) ? default(StringOffset) : builder.CreateString(_o.Curve);
			Offset<IVectorInfo> axisOffset = (_o.Axis == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Axis);
			return IRotationConfig.CreateIRotationConfig(builder, _o.Type, _o.Time, _o.Cd, curveOffset, axisOffset, _o.Angle, _o.NullMask);
		}

		// Token: 0x0400FAC9 RID: 64201
		private Table __p;
	}
}
