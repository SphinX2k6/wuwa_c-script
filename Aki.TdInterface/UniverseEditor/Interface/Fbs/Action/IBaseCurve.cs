using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061DF RID: 25055
	public struct IBaseCurve : IFlatbufferObject
	{
		// Token: 0x1700BACF RID: 47823
		// (get) Token: 0x0602B2F3 RID: 176883 RVA: 0x005F3BC9 File Offset: 0x005F1DC9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B2F4 RID: 176884 RVA: 0x005F3BD6 File Offset: 0x005F1DD6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B2F5 RID: 176885 RVA: 0x005F3BE0 File Offset: 0x005F1DE0
		public static IBaseCurve GetRootAsIBaseCurve(ByteBuffer _bb)
		{
			return IBaseCurve.GetRootAsIBaseCurve(_bb, default(IBaseCurve));
		}

		// Token: 0x0602B2F6 RID: 176886 RVA: 0x005F3BFC File Offset: 0x005F1DFC
		public static IBaseCurve GetRootAsIBaseCurve(ByteBuffer _bb, IBaseCurve obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B2F7 RID: 176887 RVA: 0x005F3C19 File Offset: 0x005F1E19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B2F8 RID: 176888 RVA: 0x005F3C28 File Offset: 0x005F1E28
		public IBaseCurve __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BAD0 RID: 47824
		// (get) Token: 0x0602B2F9 RID: 176889 RVA: 0x005F3C38 File Offset: 0x005F1E38
		public EBaseCurveType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBaseCurveType.None;
				}
				return (EBaseCurveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BAD1 RID: 47825
		// (get) Token: 0x0602B2FA RID: 176890 RVA: 0x005F3C74 File Offset: 0x005F1E74
		public float N
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

		// Token: 0x1700BAD2 RID: 47826
		// (get) Token: 0x0602B2FB RID: 176891 RVA: 0x005F3CB4 File Offset: 0x005F1EB4
		public string CurveAsset
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B2FC RID: 176892 RVA: 0x005F3CEB File Offset: 0x005F1EEB
		public Span<byte> GetCurveAssetBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602B2FD RID: 176893 RVA: 0x005F3CFA File Offset: 0x005F1EFA
		public byte[] GetCurveAssetArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0602B2FE RID: 176894 RVA: 0x005F3D08 File Offset: 0x005F1F08
		public static Offset<IBaseCurve> CreateIBaseCurve(FlatBufferBuilder builder, EBaseCurveType Type = EBaseCurveType.None, float N = 0f, StringOffset CurveAssetOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IBaseCurve.AddCurveAsset(builder, CurveAssetOffset);
			IBaseCurve.AddN(builder, N);
			IBaseCurve.AddType(builder, Type);
			return IBaseCurve.EndIBaseCurve(builder);
		}

		// Token: 0x0602B2FF RID: 176895 RVA: 0x005F3D2C File Offset: 0x005F1F2C
		public static void StartIBaseCurve(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602B300 RID: 176896 RVA: 0x005F3D35 File Offset: 0x005F1F35
		public static void AddType(FlatBufferBuilder builder, EBaseCurveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B301 RID: 176897 RVA: 0x005F3D40 File Offset: 0x005F1F40
		public static void AddN(FlatBufferBuilder builder, float n)
		{
			builder.AddFloat(1, n, 0.0);
		}

		// Token: 0x0602B302 RID: 176898 RVA: 0x005F3D53 File Offset: 0x005F1F53
		public static void AddCurveAsset(FlatBufferBuilder builder, StringOffset curveAssetOffset)
		{
			builder.AddOffset(2, curveAssetOffset.Value, 0);
		}

		// Token: 0x0602B303 RID: 176899 RVA: 0x005F3D63 File Offset: 0x005F1F63
		public static Offset<IBaseCurve> EndIBaseCurve(FlatBufferBuilder builder)
		{
			return new Offset<IBaseCurve>(builder.EndTable());
		}

		// Token: 0x0602B304 RID: 176900 RVA: 0x005F3D70 File Offset: 0x005F1F70
		public IBaseCurveT UnPack()
		{
			IBaseCurveT baseCurveT = new IBaseCurveT();
			this.UnPackTo(baseCurveT);
			return baseCurveT;
		}

		// Token: 0x0602B305 RID: 176901 RVA: 0x005F3D8B File Offset: 0x005F1F8B
		public void UnPackTo(IBaseCurveT _o)
		{
			_o.Type = this.Type;
			_o.N = this.N;
			_o.CurveAsset = this.CurveAsset;
		}

		// Token: 0x0602B306 RID: 176902 RVA: 0x005F3DB4 File Offset: 0x005F1FB4
		public static Offset<IBaseCurve> Pack(FlatBufferBuilder builder, IBaseCurveT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBaseCurve>);
			}
			StringOffset curveAssetOffset = (_o.CurveAsset == null) ? default(StringOffset) : builder.CreateString(_o.CurveAsset);
			return IBaseCurve.CreateIBaseCurve(builder, _o.Type, _o.N, curveAssetOffset);
		}

		// Token: 0x0401070B RID: 67339
		private Table __p;
	}
}
