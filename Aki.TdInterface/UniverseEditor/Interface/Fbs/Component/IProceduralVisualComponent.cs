using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005796 RID: 22422
	public struct IProceduralVisualComponent : IFlatbufferObject
	{
		// Token: 0x1700A735 RID: 42805
		// (get) Token: 0x06025969 RID: 153961 RVA: 0x0052F298 File Offset: 0x0052D498
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602596A RID: 153962 RVA: 0x0052F2A5 File Offset: 0x0052D4A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602596B RID: 153963 RVA: 0x0052F2AC File Offset: 0x0052D4AC
		public static IProceduralVisualComponent GetRootAsIProceduralVisualComponent(ByteBuffer _bb)
		{
			return IProceduralVisualComponent.GetRootAsIProceduralVisualComponent(_bb, default(IProceduralVisualComponent));
		}

		// Token: 0x0602596C RID: 153964 RVA: 0x0052F2C8 File Offset: 0x0052D4C8
		public static IProceduralVisualComponent GetRootAsIProceduralVisualComponent(ByteBuffer _bb, IProceduralVisualComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602596D RID: 153965 RVA: 0x0052F2E5 File Offset: 0x0052D4E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602596E RID: 153966 RVA: 0x0052F2F4 File Offset: 0x0052D4F4
		public IProceduralVisualComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A736 RID: 42806
		// (get) Token: 0x0602596F RID: 153967 RVA: 0x0052F304 File Offset: 0x0052D504
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06025970 RID: 153968 RVA: 0x0052F344 File Offset: 0x0052D544
		public TProceduralVisual ConfigsType(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return TProceduralVisual.NONE;
			}
			return (TProceduralVisual)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700A737 RID: 42807
		// (get) Token: 0x06025971 RID: 153969 RVA: 0x0052F384 File Offset: 0x0052D584
		public int ConfigsTypeLength
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

		// Token: 0x06025972 RID: 153970 RVA: 0x0052F3AF File Offset: 0x0052D5AF
		public Span<TProceduralVisual> GetConfigsTypeBytes()
		{
			return this.__p.__vector_as_span<TProceduralVisual>(6, 1);
		}

		// Token: 0x06025973 RID: 153971 RVA: 0x0052F3C0 File Offset: 0x0052D5C0
		public TProceduralVisual[] GetConfigsTypeArray()
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TProceduralVisual[] array = new TProceduralVisual[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TProceduralVisual)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x06025974 RID: 153972 RVA: 0x0052F42C File Offset: 0x0052D62C
		public TTable? Configs<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700A738 RID: 42808
		// (get) Token: 0x06025975 RID: 153973 RVA: 0x0052F474 File Offset: 0x0052D674
		public int ConfigsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700A739 RID: 42809
		// (get) Token: 0x06025976 RID: 153974 RVA: 0x0052F4A0 File Offset: 0x0052D6A0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025977 RID: 153975 RVA: 0x0052F4DD File Offset: 0x0052D6DD
		public static Offset<IProceduralVisualComponent> CreateIProceduralVisualComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset Configs_typeOffset = default(VectorOffset), VectorOffset ConfigsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IProceduralVisualComponent.AddConfigs(builder, ConfigsOffset);
			IProceduralVisualComponent.AddConfigsType(builder, Configs_typeOffset);
			IProceduralVisualComponent.AddNullMask(builder, NullMask);
			IProceduralVisualComponent.AddDisabled(builder, Disabled);
			return IProceduralVisualComponent.EndIProceduralVisualComponent(builder);
		}

		// Token: 0x06025978 RID: 153976 RVA: 0x0052F509 File Offset: 0x0052D709
		public static void StartIProceduralVisualComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06025979 RID: 153977 RVA: 0x0052F512 File Offset: 0x0052D712
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602597A RID: 153978 RVA: 0x0052F51D File Offset: 0x0052D71D
		public static void AddConfigsType(FlatBufferBuilder builder, VectorOffset configsTypeOffset)
		{
			builder.AddOffset(1, configsTypeOffset.Value, 0);
		}

		// Token: 0x0602597B RID: 153979 RVA: 0x0052F530 File Offset: 0x0052D730
		public static VectorOffset CreateConfigsTypeVector(FlatBufferBuilder builder, TProceduralVisual[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602597C RID: 153980 RVA: 0x0052F567 File Offset: 0x0052D767
		public static VectorOffset CreateConfigsTypeVectorBlock(FlatBufferBuilder builder, TProceduralVisual[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TProceduralVisual>(data);
			return builder.EndVector();
		}

		// Token: 0x0602597D RID: 153981 RVA: 0x0052F581 File Offset: 0x0052D781
		public static VectorOffset CreateConfigsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TProceduralVisual> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TProceduralVisual>(data);
			return builder.EndVector();
		}

		// Token: 0x0602597E RID: 153982 RVA: 0x0052F59F File Offset: 0x0052D79F
		public static VectorOffset CreateConfigsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TProceduralVisual>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602597F RID: 153983 RVA: 0x0052F5B8 File Offset: 0x0052D7B8
		public static void StartConfigsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06025980 RID: 153984 RVA: 0x0052F5C3 File Offset: 0x0052D7C3
		public static void AddConfigs(FlatBufferBuilder builder, VectorOffset configsOffset)
		{
			builder.AddOffset(2, configsOffset.Value, 0);
		}

		// Token: 0x06025981 RID: 153985 RVA: 0x0052F5D4 File Offset: 0x0052D7D4
		public static VectorOffset CreateConfigsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06025982 RID: 153986 RVA: 0x0052F60B File Offset: 0x0052D80B
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06025983 RID: 153987 RVA: 0x0052F625 File Offset: 0x0052D825
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06025984 RID: 153988 RVA: 0x0052F643 File Offset: 0x0052D843
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025985 RID: 153989 RVA: 0x0052F65C File Offset: 0x0052D85C
		public static void StartConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025986 RID: 153990 RVA: 0x0052F667 File Offset: 0x0052D867
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06025987 RID: 153991 RVA: 0x0052F672 File Offset: 0x0052D872
		public static Offset<IProceduralVisualComponent> EndIProceduralVisualComponent(FlatBufferBuilder builder)
		{
			return new Offset<IProceduralVisualComponent>(builder.EndTable());
		}

		// Token: 0x06025988 RID: 153992 RVA: 0x0052F680 File Offset: 0x0052D880
		public IProceduralVisualComponentT UnPack()
		{
			IProceduralVisualComponentT proceduralVisualComponentT = new IProceduralVisualComponentT();
			this.UnPackTo(proceduralVisualComponentT);
			return proceduralVisualComponentT;
		}

		// Token: 0x06025989 RID: 153993 RVA: 0x0052F69C File Offset: 0x0052D89C
		public void UnPackTo(IProceduralVisualComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Configs = new List<TProceduralVisualUnion>();
			for (int i = 0; i < this.ConfigsLength; i++)
			{
				TProceduralVisualUnion tproceduralVisualUnion = new TProceduralVisualUnion();
				tproceduralVisualUnion.Type = this.ConfigsType(i);
				TProceduralVisual tproceduralVisual = this.ConfigsType(i);
				if (tproceduralVisual != TProceduralVisual.IProceduralVisualLookAt)
				{
					if (tproceduralVisual == TProceduralVisual.ISearchlightRotate)
					{
						tproceduralVisualUnion.Value = ((this.Configs<ISearchlightRotate>(i) != null) ? this.Configs<ISearchlightRotate>(i).Value.UnPack() : null);
					}
				}
				else
				{
					tproceduralVisualUnion.Value = ((this.Configs<IProceduralVisualLookAt>(i) != null) ? this.Configs<IProceduralVisualLookAt>(i).Value.UnPack() : null);
				}
				_o.Configs.Add(tproceduralVisualUnion);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602598A RID: 153994 RVA: 0x0052F77C File Offset: 0x0052D97C
		public static Offset<IProceduralVisualComponent> Pack(FlatBufferBuilder builder, IProceduralVisualComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IProceduralVisualComponent>);
			}
			VectorOffset configs_typeOffset = default(VectorOffset);
			if (_o.Configs != null)
			{
				TProceduralVisual[] array = new TProceduralVisual[_o.Configs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.Configs[i].Type;
				}
				configs_typeOffset = IProceduralVisualComponent.CreateConfigsTypeVector(builder, array);
			}
			VectorOffset configsOffset = default(VectorOffset);
			if (_o.Configs != null)
			{
				int[] array2 = new int[_o.Configs.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TProceduralVisualUnion.Pack(builder, _o.Configs[j]);
				}
				configsOffset = IProceduralVisualComponent.CreateConfigsVector(builder, array2);
			}
			return IProceduralVisualComponent.CreateIProceduralVisualComponent(builder, _o.Disabled, configs_typeOffset, configsOffset, _o.NullMask);
		}

		// Token: 0x0400EC4B RID: 60491
		private Table __p;
	}
}
