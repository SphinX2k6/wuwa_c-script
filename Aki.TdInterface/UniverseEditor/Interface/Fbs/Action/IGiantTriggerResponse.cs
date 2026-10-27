using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006891 RID: 26769
	public struct IGiantTriggerResponse : IFlatbufferObject
	{
		// Token: 0x1700C6C0 RID: 50880
		// (get) Token: 0x0602EAEA RID: 191210 RVA: 0x0065D635 File Offset: 0x0065B835
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EAEB RID: 191211 RVA: 0x0065D642 File Offset: 0x0065B842
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EAEC RID: 191212 RVA: 0x0065D64C File Offset: 0x0065B84C
		public static IGiantTriggerResponse GetRootAsIGiantTriggerResponse(ByteBuffer _bb)
		{
			return IGiantTriggerResponse.GetRootAsIGiantTriggerResponse(_bb, default(IGiantTriggerResponse));
		}

		// Token: 0x0602EAED RID: 191213 RVA: 0x0065D668 File Offset: 0x0065B868
		public static IGiantTriggerResponse GetRootAsIGiantTriggerResponse(ByteBuffer _bb, IGiantTriggerResponse obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EAEE RID: 191214 RVA: 0x0065D685 File Offset: 0x0065B885
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EAEF RID: 191215 RVA: 0x0065D694 File Offset: 0x0065B894
		public IGiantTriggerResponse __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602EAF0 RID: 191216 RVA: 0x0065D6A4 File Offset: 0x0065B8A4
		public TGiantResponseFunction ResponseFunctionsType(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return TGiantResponseFunction.NONE;
			}
			return (TGiantResponseFunction)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700C6C1 RID: 50881
		// (get) Token: 0x0602EAF1 RID: 191217 RVA: 0x0065D6E4 File Offset: 0x0065B8E4
		public int ResponseFunctionsTypeLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602EAF2 RID: 191218 RVA: 0x0065D70F File Offset: 0x0065B90F
		public Span<TGiantResponseFunction> GetResponseFunctionsTypeBytes()
		{
			return this.__p.__vector_as_span<TGiantResponseFunction>(4, 1);
		}

		// Token: 0x0602EAF3 RID: 191219 RVA: 0x0065D720 File Offset: 0x0065B920
		public TGiantResponseFunction[] GetResponseFunctionsTypeArray()
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TGiantResponseFunction[] array = new TGiantResponseFunction[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TGiantResponseFunction)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x0602EAF4 RID: 191220 RVA: 0x0065D78C File Offset: 0x0065B98C
		public TTable? ResponseFunctions<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700C6C2 RID: 50882
		// (get) Token: 0x0602EAF5 RID: 191221 RVA: 0x0065D7D4 File Offset: 0x0065B9D4
		public int ResponseFunctionsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602EAF6 RID: 191222 RVA: 0x0065D7FF File Offset: 0x0065B9FF
		public static Offset<IGiantTriggerResponse> CreateIGiantTriggerResponse(FlatBufferBuilder builder, VectorOffset ResponseFunctions_typeOffset = default(VectorOffset), VectorOffset ResponseFunctionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IGiantTriggerResponse.AddResponseFunctions(builder, ResponseFunctionsOffset);
			IGiantTriggerResponse.AddResponseFunctionsType(builder, ResponseFunctions_typeOffset);
			return IGiantTriggerResponse.EndIGiantTriggerResponse(builder);
		}

		// Token: 0x0602EAF7 RID: 191223 RVA: 0x0065D81C File Offset: 0x0065BA1C
		public static void StartIGiantTriggerResponse(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602EAF8 RID: 191224 RVA: 0x0065D825 File Offset: 0x0065BA25
		public static void AddResponseFunctionsType(FlatBufferBuilder builder, VectorOffset responseFunctionsTypeOffset)
		{
			builder.AddOffset(0, responseFunctionsTypeOffset.Value, 0);
		}

		// Token: 0x0602EAF9 RID: 191225 RVA: 0x0065D838 File Offset: 0x0065BA38
		public static VectorOffset CreateResponseFunctionsTypeVector(FlatBufferBuilder builder, TGiantResponseFunction[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602EAFA RID: 191226 RVA: 0x0065D86F File Offset: 0x0065BA6F
		public static VectorOffset CreateResponseFunctionsTypeVectorBlock(FlatBufferBuilder builder, TGiantResponseFunction[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TGiantResponseFunction>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EAFB RID: 191227 RVA: 0x0065D889 File Offset: 0x0065BA89
		public static VectorOffset CreateResponseFunctionsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TGiantResponseFunction> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TGiantResponseFunction>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EAFC RID: 191228 RVA: 0x0065D8A7 File Offset: 0x0065BAA7
		public static VectorOffset CreateResponseFunctionsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TGiantResponseFunction>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602EAFD RID: 191229 RVA: 0x0065D8C0 File Offset: 0x0065BAC0
		public static void StartResponseFunctionsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0602EAFE RID: 191230 RVA: 0x0065D8CB File Offset: 0x0065BACB
		public static void AddResponseFunctions(FlatBufferBuilder builder, VectorOffset responseFunctionsOffset)
		{
			builder.AddOffset(1, responseFunctionsOffset.Value, 0);
		}

		// Token: 0x0602EAFF RID: 191231 RVA: 0x0065D8DC File Offset: 0x0065BADC
		public static VectorOffset CreateResponseFunctionsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602EB00 RID: 191232 RVA: 0x0065D913 File Offset: 0x0065BB13
		public static VectorOffset CreateResponseFunctionsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EB01 RID: 191233 RVA: 0x0065D92D File Offset: 0x0065BB2D
		public static VectorOffset CreateResponseFunctionsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EB02 RID: 191234 RVA: 0x0065D94B File Offset: 0x0065BB4B
		public static VectorOffset CreateResponseFunctionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602EB03 RID: 191235 RVA: 0x0065D964 File Offset: 0x0065BB64
		public static void StartResponseFunctionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602EB04 RID: 191236 RVA: 0x0065D96F File Offset: 0x0065BB6F
		public static Offset<IGiantTriggerResponse> EndIGiantTriggerResponse(FlatBufferBuilder builder)
		{
			return new Offset<IGiantTriggerResponse>(builder.EndTable());
		}

		// Token: 0x0602EB05 RID: 191237 RVA: 0x0065D97C File Offset: 0x0065BB7C
		public IGiantTriggerResponseT UnPack()
		{
			IGiantTriggerResponseT giantTriggerResponseT = new IGiantTriggerResponseT();
			this.UnPackTo(giantTriggerResponseT);
			return giantTriggerResponseT;
		}

		// Token: 0x0602EB06 RID: 191238 RVA: 0x0065D998 File Offset: 0x0065BB98
		public void UnPackTo(IGiantTriggerResponseT _o)
		{
			_o.ResponseFunctions = new List<TGiantResponseFunctionUnion>();
			for (int i = 0; i < this.ResponseFunctionsLength; i++)
			{
				TGiantResponseFunctionUnion tgiantResponseFunctionUnion = new TGiantResponseFunctionUnion();
				tgiantResponseFunctionUnion.Type = this.ResponseFunctionsType(i);
				TGiantResponseFunction tgiantResponseFunction = this.ResponseFunctionsType(i);
				if (tgiantResponseFunction != TGiantResponseFunction.IGiantResponsePlayAnimation)
				{
					if (tgiantResponseFunction == TGiantResponseFunction.IGiantResponsePlayFlow)
					{
						tgiantResponseFunctionUnion.Value = ((this.ResponseFunctions<IGiantResponsePlayFlow>(i) != null) ? this.ResponseFunctions<IGiantResponsePlayFlow>(i).Value.UnPack() : null);
					}
				}
				else
				{
					tgiantResponseFunctionUnion.Value = ((this.ResponseFunctions<IGiantResponsePlayAnimation>(i) != null) ? this.ResponseFunctions<IGiantResponsePlayAnimation>(i).Value.UnPack() : null);
				}
				_o.ResponseFunctions.Add(tgiantResponseFunctionUnion);
			}
		}

		// Token: 0x0602EB07 RID: 191239 RVA: 0x0065DA60 File Offset: 0x0065BC60
		public static Offset<IGiantTriggerResponse> Pack(FlatBufferBuilder builder, IGiantTriggerResponseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGiantTriggerResponse>);
			}
			VectorOffset responseFunctions_typeOffset = default(VectorOffset);
			if (_o.ResponseFunctions != null)
			{
				TGiantResponseFunction[] array = new TGiantResponseFunction[_o.ResponseFunctions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.ResponseFunctions[i].Type;
				}
				responseFunctions_typeOffset = IGiantTriggerResponse.CreateResponseFunctionsTypeVector(builder, array);
			}
			VectorOffset responseFunctionsOffset = default(VectorOffset);
			if (_o.ResponseFunctions != null)
			{
				int[] array2 = new int[_o.ResponseFunctions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TGiantResponseFunctionUnion.Pack(builder, _o.ResponseFunctions[j]);
				}
				responseFunctionsOffset = IGiantTriggerResponse.CreateResponseFunctionsVector(builder, array2);
			}
			return IGiantTriggerResponse.CreateIGiantTriggerResponse(builder, responseFunctions_typeOffset, responseFunctionsOffset);
		}

		// Token: 0x04010FE2 RID: 69602
		private Table __p;
	}
}
