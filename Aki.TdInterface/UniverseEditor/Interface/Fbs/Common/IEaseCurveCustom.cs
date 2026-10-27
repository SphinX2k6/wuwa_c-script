using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D94 RID: 23956
	public struct IEaseCurveCustom : IFlatbufferObject
	{
		// Token: 0x1700B36C RID: 45932
		// (get) Token: 0x06028FF4 RID: 167924 RVA: 0x005A18F6 File Offset: 0x0059FAF6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028FF5 RID: 167925 RVA: 0x005A1903 File Offset: 0x0059FB03
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028FF6 RID: 167926 RVA: 0x005A190C File Offset: 0x0059FB0C
		public static IEaseCurveCustom GetRootAsIEaseCurveCustom(ByteBuffer _bb)
		{
			return IEaseCurveCustom.GetRootAsIEaseCurveCustom(_bb, default(IEaseCurveCustom));
		}

		// Token: 0x06028FF7 RID: 167927 RVA: 0x005A1928 File Offset: 0x0059FB28
		public static IEaseCurveCustom GetRootAsIEaseCurveCustom(ByteBuffer _bb, IEaseCurveCustom obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028FF8 RID: 167928 RVA: 0x005A1945 File Offset: 0x0059FB45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028FF9 RID: 167929 RVA: 0x005A1954 File Offset: 0x0059FB54
		public IEaseCurveCustom __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B36D RID: 45933
		// (get) Token: 0x06028FFA RID: 167930 RVA: 0x005A1964 File Offset: 0x0059FB64
		public EEaseCurveType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEaseCurveType.Preset;
				}
				return (EEaseCurveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B36E RID: 45934
		// (get) Token: 0x06028FFB RID: 167931 RVA: 0x005A19A0 File Offset: 0x0059FBA0
		public string CustomCurve
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028FFC RID: 167932 RVA: 0x005A19D7 File Offset: 0x0059FBD7
		public Span<byte> GetCustomCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06028FFD RID: 167933 RVA: 0x005A19E6 File Offset: 0x0059FBE6
		public byte[] GetCustomCurveArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06028FFE RID: 167934 RVA: 0x005A19F4 File Offset: 0x0059FBF4
		public static Offset<IEaseCurveCustom> CreateIEaseCurveCustom(FlatBufferBuilder builder, EEaseCurveType Type = EEaseCurveType.Preset, StringOffset CustomCurveOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IEaseCurveCustom.AddCustomCurve(builder, CustomCurveOffset);
			IEaseCurveCustom.AddType(builder, Type);
			return IEaseCurveCustom.EndIEaseCurveCustom(builder);
		}

		// Token: 0x06028FFF RID: 167935 RVA: 0x005A1A11 File Offset: 0x0059FC11
		public static void StartIEaseCurveCustom(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06029000 RID: 167936 RVA: 0x005A1A1A File Offset: 0x0059FC1A
		public static void AddType(FlatBufferBuilder builder, EEaseCurveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029001 RID: 167937 RVA: 0x005A1A25 File Offset: 0x0059FC25
		public static void AddCustomCurve(FlatBufferBuilder builder, StringOffset customCurveOffset)
		{
			builder.AddOffset(1, customCurveOffset.Value, 0);
		}

		// Token: 0x06029002 RID: 167938 RVA: 0x005A1A35 File Offset: 0x0059FC35
		public static Offset<IEaseCurveCustom> EndIEaseCurveCustom(FlatBufferBuilder builder)
		{
			return new Offset<IEaseCurveCustom>(builder.EndTable());
		}

		// Token: 0x06029003 RID: 167939 RVA: 0x005A1A44 File Offset: 0x0059FC44
		public IEaseCurveCustomT UnPack()
		{
			IEaseCurveCustomT easeCurveCustomT = new IEaseCurveCustomT();
			this.UnPackTo(easeCurveCustomT);
			return easeCurveCustomT;
		}

		// Token: 0x06029004 RID: 167940 RVA: 0x005A1A5F File Offset: 0x0059FC5F
		public void UnPackTo(IEaseCurveCustomT _o)
		{
			_o.Type = this.Type;
			_o.CustomCurve = this.CustomCurve;
		}

		// Token: 0x06029005 RID: 167941 RVA: 0x005A1A7C File Offset: 0x0059FC7C
		public static Offset<IEaseCurveCustom> Pack(FlatBufferBuilder builder, IEaseCurveCustomT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEaseCurveCustom>);
			}
			StringOffset customCurveOffset = (_o.CustomCurve == null) ? default(StringOffset) : builder.CreateString(_o.CustomCurve);
			return IEaseCurveCustom.CreateIEaseCurveCustom(builder, _o.Type, customCurveOffset);
		}

		// Token: 0x0400F768 RID: 63336
		private Table __p;
	}
}
