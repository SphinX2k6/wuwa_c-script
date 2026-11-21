using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006883 RID: 26755
	public struct IBlendFunction : IFlatbufferObject
	{
		// Token: 0x1700C4A0 RID: 50336
		// (get) Token: 0x0602DBBC RID: 187324 RVA: 0x00640B54 File Offset: 0x0063ED54
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DBBD RID: 187325 RVA: 0x00640B61 File Offset: 0x0063ED61
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DBBE RID: 187326 RVA: 0x00640B68 File Offset: 0x0063ED68
		public static IBlendFunction GetRootAsIBlendFunction(ByteBuffer _bb)
		{
			return IBlendFunction.GetRootAsIBlendFunction(_bb, default(IBlendFunction));
		}

		// Token: 0x0602DBBF RID: 187327 RVA: 0x00640B84 File Offset: 0x0063ED84
		public static IBlendFunction GetRootAsIBlendFunction(ByteBuffer _bb, IBlendFunction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DBC0 RID: 187328 RVA: 0x00640BA1 File Offset: 0x0063EDA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DBC1 RID: 187329 RVA: 0x00640BB0 File Offset: 0x0063EDB0
		public IBlendFunction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C4A1 RID: 50337
		// (get) Token: 0x0602DBC2 RID: 187330 RVA: 0x00640BC0 File Offset: 0x0063EDC0
		public EViewTargetBlendFunction Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EViewTargetBlendFunction.Linear;
				}
				return (EViewTargetBlendFunction)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C4A2 RID: 50338
		// (get) Token: 0x0602DBC3 RID: 187331 RVA: 0x00640BFC File Offset: 0x0063EDFC
		public float BlendExp
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

		// Token: 0x1700C4A3 RID: 50339
		// (get) Token: 0x0602DBC4 RID: 187332 RVA: 0x00640C3C File Offset: 0x0063EE3C
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

		// Token: 0x0602DBC5 RID: 187333 RVA: 0x00640C73 File Offset: 0x0063EE73
		public Span<byte> GetCurveAssetBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602DBC6 RID: 187334 RVA: 0x00640C82 File Offset: 0x0063EE82
		public byte[] GetCurveAssetArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0602DBC7 RID: 187335 RVA: 0x00640C90 File Offset: 0x0063EE90
		public static Offset<IBlendFunction> CreateIBlendFunction(FlatBufferBuilder builder, EViewTargetBlendFunction Type = EViewTargetBlendFunction.Linear, float BlendExp = 0f, StringOffset CurveAssetOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IBlendFunction.AddCurveAsset(builder, CurveAssetOffset);
			IBlendFunction.AddBlendExp(builder, BlendExp);
			IBlendFunction.AddType(builder, Type);
			return IBlendFunction.EndIBlendFunction(builder);
		}

		// Token: 0x0602DBC8 RID: 187336 RVA: 0x00640CB4 File Offset: 0x0063EEB4
		public static void StartIBlendFunction(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602DBC9 RID: 187337 RVA: 0x00640CBD File Offset: 0x0063EEBD
		public static void AddType(FlatBufferBuilder builder, EViewTargetBlendFunction type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DBCA RID: 187338 RVA: 0x00640CC8 File Offset: 0x0063EEC8
		public static void AddBlendExp(FlatBufferBuilder builder, float blendExp)
		{
			builder.AddFloat(1, blendExp, 0.0);
		}

		// Token: 0x0602DBCB RID: 187339 RVA: 0x00640CDB File Offset: 0x0063EEDB
		public static void AddCurveAsset(FlatBufferBuilder builder, StringOffset curveAssetOffset)
		{
			builder.AddOffset(2, curveAssetOffset.Value, 0);
		}

		// Token: 0x0602DBCC RID: 187340 RVA: 0x00640CEB File Offset: 0x0063EEEB
		public static Offset<IBlendFunction> EndIBlendFunction(FlatBufferBuilder builder)
		{
			return new Offset<IBlendFunction>(builder.EndTable());
		}

		// Token: 0x0602DBCD RID: 187341 RVA: 0x00640CF8 File Offset: 0x0063EEF8
		public IBlendFunctionT UnPack()
		{
			IBlendFunctionT blendFunctionT = new IBlendFunctionT();
			this.UnPackTo(blendFunctionT);
			return blendFunctionT;
		}

		// Token: 0x0602DBCE RID: 187342 RVA: 0x00640D13 File Offset: 0x0063EF13
		public void UnPackTo(IBlendFunctionT _o)
		{
			_o.Type = this.Type;
			_o.BlendExp = this.BlendExp;
			_o.CurveAsset = this.CurveAsset;
		}

		// Token: 0x0602DBCF RID: 187343 RVA: 0x00640D3C File Offset: 0x0063EF3C
		public static Offset<IBlendFunction> Pack(FlatBufferBuilder builder, IBlendFunctionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBlendFunction>);
			}
			StringOffset curveAssetOffset = (_o.CurveAsset == null) ? default(StringOffset) : builder.CreateString(_o.CurveAsset);
			return IBlendFunction.CreateIBlendFunction(builder, _o.Type, _o.BlendExp, curveAssetOffset);
		}

		// Token: 0x04011565 RID: 71013
		private Table __p;
	}
}
