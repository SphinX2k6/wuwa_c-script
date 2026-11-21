using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200684D RID: 26701
	public struct IBaseCurve : IFlatbufferObject
	{
		// Token: 0x1700C452 RID: 50258
		// (get) Token: 0x0602DA3A RID: 186938 RVA: 0x0063E63D File Offset: 0x0063C83D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DA3B RID: 186939 RVA: 0x0063E64A File Offset: 0x0063C84A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DA3C RID: 186940 RVA: 0x0063E654 File Offset: 0x0063C854
		public static IBaseCurve GetRootAsIBaseCurve(ByteBuffer _bb)
		{
			return IBaseCurve.GetRootAsIBaseCurve(_bb, default(IBaseCurve));
		}

		// Token: 0x0602DA3D RID: 186941 RVA: 0x0063E670 File Offset: 0x0063C870
		public static IBaseCurve GetRootAsIBaseCurve(ByteBuffer _bb, IBaseCurve obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DA3E RID: 186942 RVA: 0x0063E68D File Offset: 0x0063C88D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DA3F RID: 186943 RVA: 0x0063E69C File Offset: 0x0063C89C
		public IBaseCurve __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C453 RID: 50259
		// (get) Token: 0x0602DA40 RID: 186944 RVA: 0x0063E6AC File Offset: 0x0063C8AC
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

		// Token: 0x1700C454 RID: 50260
		// (get) Token: 0x0602DA41 RID: 186945 RVA: 0x0063E6E8 File Offset: 0x0063C8E8
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

		// Token: 0x1700C455 RID: 50261
		// (get) Token: 0x0602DA42 RID: 186946 RVA: 0x0063E728 File Offset: 0x0063C928
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

		// Token: 0x0602DA43 RID: 186947 RVA: 0x0063E75F File Offset: 0x0063C95F
		public Span<byte> GetCurveAssetBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602DA44 RID: 186948 RVA: 0x0063E76E File Offset: 0x0063C96E
		public byte[] GetCurveAssetArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0602DA45 RID: 186949 RVA: 0x0063E77C File Offset: 0x0063C97C
		public static Offset<IBaseCurve> CreateIBaseCurve(FlatBufferBuilder builder, EBaseCurveType Type = EBaseCurveType.None, float N = 0f, StringOffset CurveAssetOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IBaseCurve.AddCurveAsset(builder, CurveAssetOffset);
			IBaseCurve.AddN(builder, N);
			IBaseCurve.AddType(builder, Type);
			return IBaseCurve.EndIBaseCurve(builder);
		}

		// Token: 0x0602DA46 RID: 186950 RVA: 0x0063E7A0 File Offset: 0x0063C9A0
		public static void StartIBaseCurve(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602DA47 RID: 186951 RVA: 0x0063E7A9 File Offset: 0x0063C9A9
		public static void AddType(FlatBufferBuilder builder, EBaseCurveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DA48 RID: 186952 RVA: 0x0063E7B4 File Offset: 0x0063C9B4
		public static void AddN(FlatBufferBuilder builder, float n)
		{
			builder.AddFloat(1, n, 0.0);
		}

		// Token: 0x0602DA49 RID: 186953 RVA: 0x0063E7C7 File Offset: 0x0063C9C7
		public static void AddCurveAsset(FlatBufferBuilder builder, StringOffset curveAssetOffset)
		{
			builder.AddOffset(2, curveAssetOffset.Value, 0);
		}

		// Token: 0x0602DA4A RID: 186954 RVA: 0x0063E7D7 File Offset: 0x0063C9D7
		public static Offset<IBaseCurve> EndIBaseCurve(FlatBufferBuilder builder)
		{
			return new Offset<IBaseCurve>(builder.EndTable());
		}

		// Token: 0x0602DA4B RID: 186955 RVA: 0x0063E7E4 File Offset: 0x0063C9E4
		public IBaseCurveT UnPack()
		{
			IBaseCurveT baseCurveT = new IBaseCurveT();
			this.UnPackTo(baseCurveT);
			return baseCurveT;
		}

		// Token: 0x0602DA4C RID: 186956 RVA: 0x0063E7FF File Offset: 0x0063C9FF
		public void UnPackTo(IBaseCurveT _o)
		{
			_o.Type = this.Type;
			_o.N = this.N;
			_o.CurveAsset = this.CurveAsset;
		}

		// Token: 0x0602DA4D RID: 186957 RVA: 0x0063E828 File Offset: 0x0063CA28
		public static Offset<IBaseCurve> Pack(FlatBufferBuilder builder, IBaseCurveT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBaseCurve>);
			}
			StringOffset curveAssetOffset = (_o.CurveAsset == null) ? default(StringOffset) : builder.CreateString(_o.CurveAsset);
			return IBaseCurve.CreateIBaseCurve(builder, _o.Type, _o.N, curveAssetOffset);
		}

		// Token: 0x0401151D RID: 70941
		private Table __p;
	}
}
