using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F32 RID: 28466
	public struct IGiantTriggerResponse : IFlatbufferObject
	{
		// Token: 0x1700D0A6 RID: 53414
		// (get) Token: 0x06031424 RID: 201764 RVA: 0x006AC6B5 File Offset: 0x006AA8B5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031425 RID: 201765 RVA: 0x006AC6C2 File Offset: 0x006AA8C2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031426 RID: 201766 RVA: 0x006AC6CC File Offset: 0x006AA8CC
		public static IGiantTriggerResponse GetRootAsIGiantTriggerResponse(ByteBuffer _bb)
		{
			return IGiantTriggerResponse.GetRootAsIGiantTriggerResponse(_bb, default(IGiantTriggerResponse));
		}

		// Token: 0x06031427 RID: 201767 RVA: 0x006AC6E8 File Offset: 0x006AA8E8
		public static IGiantTriggerResponse GetRootAsIGiantTriggerResponse(ByteBuffer _bb, IGiantTriggerResponse obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031428 RID: 201768 RVA: 0x006AC705 File Offset: 0x006AA905
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031429 RID: 201769 RVA: 0x006AC714 File Offset: 0x006AA914
		public IGiantTriggerResponse __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0603142A RID: 201770 RVA: 0x006AC724 File Offset: 0x006AA924
		public TGiantResponseFunction ResponseFunctionsType(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return TGiantResponseFunction.NONE;
			}
			return (TGiantResponseFunction)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700D0A7 RID: 53415
		// (get) Token: 0x0603142B RID: 201771 RVA: 0x006AC764 File Offset: 0x006AA964
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

		// Token: 0x0603142C RID: 201772 RVA: 0x006AC78F File Offset: 0x006AA98F
		public Span<TGiantResponseFunction> GetResponseFunctionsTypeBytes()
		{
			return this.__p.__vector_as_span<TGiantResponseFunction>(4, 1);
		}

		// Token: 0x0603142D RID: 201773 RVA: 0x006AC7A0 File Offset: 0x006AA9A0
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

		// Token: 0x0603142E RID: 201774 RVA: 0x006AC80C File Offset: 0x006AAA0C
		public TTable? ResponseFunctions<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700D0A8 RID: 53416
		// (get) Token: 0x0603142F RID: 201775 RVA: 0x006AC854 File Offset: 0x006AAA54
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

		// Token: 0x06031430 RID: 201776 RVA: 0x006AC87F File Offset: 0x006AAA7F
		public static Offset<IGiantTriggerResponse> CreateIGiantTriggerResponse(FlatBufferBuilder builder, VectorOffset ResponseFunctions_typeOffset = default(VectorOffset), VectorOffset ResponseFunctionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IGiantTriggerResponse.AddResponseFunctions(builder, ResponseFunctionsOffset);
			IGiantTriggerResponse.AddResponseFunctionsType(builder, ResponseFunctions_typeOffset);
			return IGiantTriggerResponse.EndIGiantTriggerResponse(builder);
		}

		// Token: 0x06031431 RID: 201777 RVA: 0x006AC89C File Offset: 0x006AAA9C
		public static void StartIGiantTriggerResponse(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031432 RID: 201778 RVA: 0x006AC8A5 File Offset: 0x006AAAA5
		public static void AddResponseFunctionsType(FlatBufferBuilder builder, VectorOffset responseFunctionsTypeOffset)
		{
			builder.AddOffset(0, responseFunctionsTypeOffset.Value, 0);
		}

		// Token: 0x06031433 RID: 201779 RVA: 0x006AC8B8 File Offset: 0x006AAAB8
		public static VectorOffset CreateResponseFunctionsTypeVector(FlatBufferBuilder builder, TGiantResponseFunction[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06031434 RID: 201780 RVA: 0x006AC8EF File Offset: 0x006AAAEF
		public static VectorOffset CreateResponseFunctionsTypeVectorBlock(FlatBufferBuilder builder, TGiantResponseFunction[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TGiantResponseFunction>(data);
			return builder.EndVector();
		}

		// Token: 0x06031435 RID: 201781 RVA: 0x006AC909 File Offset: 0x006AAB09
		public static VectorOffset CreateResponseFunctionsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TGiantResponseFunction> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TGiantResponseFunction>(data);
			return builder.EndVector();
		}

		// Token: 0x06031436 RID: 201782 RVA: 0x006AC927 File Offset: 0x006AAB27
		public static VectorOffset CreateResponseFunctionsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TGiantResponseFunction>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06031437 RID: 201783 RVA: 0x006AC940 File Offset: 0x006AAB40
		public static void StartResponseFunctionsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06031438 RID: 201784 RVA: 0x006AC94B File Offset: 0x006AAB4B
		public static void AddResponseFunctions(FlatBufferBuilder builder, VectorOffset responseFunctionsOffset)
		{
			builder.AddOffset(1, responseFunctionsOffset.Value, 0);
		}

		// Token: 0x06031439 RID: 201785 RVA: 0x006AC95C File Offset: 0x006AAB5C
		public static VectorOffset CreateResponseFunctionsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0603143A RID: 201786 RVA: 0x006AC993 File Offset: 0x006AAB93
		public static VectorOffset CreateResponseFunctionsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603143B RID: 201787 RVA: 0x006AC9AD File Offset: 0x006AABAD
		public static VectorOffset CreateResponseFunctionsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603143C RID: 201788 RVA: 0x006AC9CB File Offset: 0x006AABCB
		public static VectorOffset CreateResponseFunctionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603143D RID: 201789 RVA: 0x006AC9E4 File Offset: 0x006AABE4
		public static void StartResponseFunctionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603143E RID: 201790 RVA: 0x006AC9EF File Offset: 0x006AABEF
		public static Offset<IGiantTriggerResponse> EndIGiantTriggerResponse(FlatBufferBuilder builder)
		{
			return new Offset<IGiantTriggerResponse>(builder.EndTable());
		}

		// Token: 0x0603143F RID: 201791 RVA: 0x006AC9FC File Offset: 0x006AABFC
		public IGiantTriggerResponseT UnPack()
		{
			IGiantTriggerResponseT giantTriggerResponseT = new IGiantTriggerResponseT();
			this.UnPackTo(giantTriggerResponseT);
			return giantTriggerResponseT;
		}

		// Token: 0x06031440 RID: 201792 RVA: 0x006ACA18 File Offset: 0x006AAC18
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

		// Token: 0x06031441 RID: 201793 RVA: 0x006ACAE0 File Offset: 0x006AACE0
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

		// Token: 0x04011E37 RID: 73271
		private Table __p;
	}
}
