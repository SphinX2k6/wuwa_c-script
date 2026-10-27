using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006212 RID: 25106
	public struct IBlendFunction : IFlatbufferObject
	{
		// Token: 0x1700BB1A RID: 47898
		// (get) Token: 0x0602B463 RID: 177251 RVA: 0x005F5F68 File Offset: 0x005F4168
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B464 RID: 177252 RVA: 0x005F5F75 File Offset: 0x005F4175
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B465 RID: 177253 RVA: 0x005F5F7C File Offset: 0x005F417C
		public static IBlendFunction GetRootAsIBlendFunction(ByteBuffer _bb)
		{
			return IBlendFunction.GetRootAsIBlendFunction(_bb, default(IBlendFunction));
		}

		// Token: 0x0602B466 RID: 177254 RVA: 0x005F5F98 File Offset: 0x005F4198
		public static IBlendFunction GetRootAsIBlendFunction(ByteBuffer _bb, IBlendFunction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B467 RID: 177255 RVA: 0x005F5FB5 File Offset: 0x005F41B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B468 RID: 177256 RVA: 0x005F5FC4 File Offset: 0x005F41C4
		public IBlendFunction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BB1B RID: 47899
		// (get) Token: 0x0602B469 RID: 177257 RVA: 0x005F5FD4 File Offset: 0x005F41D4
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

		// Token: 0x1700BB1C RID: 47900
		// (get) Token: 0x0602B46A RID: 177258 RVA: 0x005F6010 File Offset: 0x005F4210
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

		// Token: 0x1700BB1D RID: 47901
		// (get) Token: 0x0602B46B RID: 177259 RVA: 0x005F6050 File Offset: 0x005F4250
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

		// Token: 0x0602B46C RID: 177260 RVA: 0x005F6087 File Offset: 0x005F4287
		public Span<byte> GetCurveAssetBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602B46D RID: 177261 RVA: 0x005F6096 File Offset: 0x005F4296
		public byte[] GetCurveAssetArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0602B46E RID: 177262 RVA: 0x005F60A4 File Offset: 0x005F42A4
		public static Offset<IBlendFunction> CreateIBlendFunction(FlatBufferBuilder builder, EViewTargetBlendFunction Type = EViewTargetBlendFunction.Linear, float BlendExp = 0f, StringOffset CurveAssetOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IBlendFunction.AddCurveAsset(builder, CurveAssetOffset);
			IBlendFunction.AddBlendExp(builder, BlendExp);
			IBlendFunction.AddType(builder, Type);
			return IBlendFunction.EndIBlendFunction(builder);
		}

		// Token: 0x0602B46F RID: 177263 RVA: 0x005F60C8 File Offset: 0x005F42C8
		public static void StartIBlendFunction(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602B470 RID: 177264 RVA: 0x005F60D1 File Offset: 0x005F42D1
		public static void AddType(FlatBufferBuilder builder, EViewTargetBlendFunction type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B471 RID: 177265 RVA: 0x005F60DC File Offset: 0x005F42DC
		public static void AddBlendExp(FlatBufferBuilder builder, float blendExp)
		{
			builder.AddFloat(1, blendExp, 0.0);
		}

		// Token: 0x0602B472 RID: 177266 RVA: 0x005F60EF File Offset: 0x005F42EF
		public static void AddCurveAsset(FlatBufferBuilder builder, StringOffset curveAssetOffset)
		{
			builder.AddOffset(2, curveAssetOffset.Value, 0);
		}

		// Token: 0x0602B473 RID: 177267 RVA: 0x005F60FF File Offset: 0x005F42FF
		public static Offset<IBlendFunction> EndIBlendFunction(FlatBufferBuilder builder)
		{
			return new Offset<IBlendFunction>(builder.EndTable());
		}

		// Token: 0x0602B474 RID: 177268 RVA: 0x005F610C File Offset: 0x005F430C
		public IBlendFunctionT UnPack()
		{
			IBlendFunctionT blendFunctionT = new IBlendFunctionT();
			this.UnPackTo(blendFunctionT);
			return blendFunctionT;
		}

		// Token: 0x0602B475 RID: 177269 RVA: 0x005F6127 File Offset: 0x005F4327
		public void UnPackTo(IBlendFunctionT _o)
		{
			_o.Type = this.Type;
			_o.BlendExp = this.BlendExp;
			_o.CurveAsset = this.CurveAsset;
		}

		// Token: 0x0602B476 RID: 177270 RVA: 0x005F6150 File Offset: 0x005F4350
		public static Offset<IBlendFunction> Pack(FlatBufferBuilder builder, IBlendFunctionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBlendFunction>);
			}
			StringOffset curveAssetOffset = (_o.CurveAsset == null) ? default(StringOffset) : builder.CreateString(_o.CurveAsset);
			return IBlendFunction.CreateIBlendFunction(builder, _o.Type, _o.BlendExp, curveAssetOffset);
		}

		// Token: 0x04010751 RID: 67409
		private Table __p;
	}
}
