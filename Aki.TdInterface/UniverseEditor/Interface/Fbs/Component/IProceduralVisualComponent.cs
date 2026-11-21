using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D9D RID: 23965
	public struct IProceduralVisualComponent : IFlatbufferObject
	{
		// Token: 0x1700B059 RID: 45145
		// (get) Token: 0x06027E89 RID: 163465 RVA: 0x00575424 File Offset: 0x00573624
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027E8A RID: 163466 RVA: 0x00575431 File Offset: 0x00573631
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027E8B RID: 163467 RVA: 0x00575438 File Offset: 0x00573638
		public static IProceduralVisualComponent GetRootAsIProceduralVisualComponent(ByteBuffer _bb)
		{
			return IProceduralVisualComponent.GetRootAsIProceduralVisualComponent(_bb, default(IProceduralVisualComponent));
		}

		// Token: 0x06027E8C RID: 163468 RVA: 0x00575454 File Offset: 0x00573654
		public static IProceduralVisualComponent GetRootAsIProceduralVisualComponent(ByteBuffer _bb, IProceduralVisualComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027E8D RID: 163469 RVA: 0x00575471 File Offset: 0x00573671
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027E8E RID: 163470 RVA: 0x00575480 File Offset: 0x00573680
		public IProceduralVisualComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B05A RID: 45146
		// (get) Token: 0x06027E8F RID: 163471 RVA: 0x00575490 File Offset: 0x00573690
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06027E90 RID: 163472 RVA: 0x005754D0 File Offset: 0x005736D0
		public TProceduralVisual ConfigsType(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return TProceduralVisual.NONE;
			}
			return (TProceduralVisual)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700B05B RID: 45147
		// (get) Token: 0x06027E91 RID: 163473 RVA: 0x00575510 File Offset: 0x00573710
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

		// Token: 0x06027E92 RID: 163474 RVA: 0x0057553B File Offset: 0x0057373B
		public Span<TProceduralVisual> GetConfigsTypeBytes()
		{
			return this.__p.__vector_as_span<TProceduralVisual>(6, 1);
		}

		// Token: 0x06027E93 RID: 163475 RVA: 0x0057554C File Offset: 0x0057374C
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

		// Token: 0x06027E94 RID: 163476 RVA: 0x005755B8 File Offset: 0x005737B8
		public TTable? Configs<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700B05C RID: 45148
		// (get) Token: 0x06027E95 RID: 163477 RVA: 0x00575600 File Offset: 0x00573800
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

		// Token: 0x1700B05D RID: 45149
		// (get) Token: 0x06027E96 RID: 163478 RVA: 0x0057562C File Offset: 0x0057382C
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

		// Token: 0x06027E97 RID: 163479 RVA: 0x00575669 File Offset: 0x00573869
		public static Offset<IProceduralVisualComponent> CreateIProceduralVisualComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset Configs_typeOffset = default(VectorOffset), VectorOffset ConfigsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IProceduralVisualComponent.AddConfigs(builder, ConfigsOffset);
			IProceduralVisualComponent.AddConfigsType(builder, Configs_typeOffset);
			IProceduralVisualComponent.AddNullMask(builder, NullMask);
			IProceduralVisualComponent.AddDisabled(builder, Disabled);
			return IProceduralVisualComponent.EndIProceduralVisualComponent(builder);
		}

		// Token: 0x06027E98 RID: 163480 RVA: 0x00575695 File Offset: 0x00573895
		public static void StartIProceduralVisualComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06027E99 RID: 163481 RVA: 0x0057569E File Offset: 0x0057389E
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06027E9A RID: 163482 RVA: 0x005756A9 File Offset: 0x005738A9
		public static void AddConfigsType(FlatBufferBuilder builder, VectorOffset configsTypeOffset)
		{
			builder.AddOffset(1, configsTypeOffset.Value, 0);
		}

		// Token: 0x06027E9B RID: 163483 RVA: 0x005756BC File Offset: 0x005738BC
		public static VectorOffset CreateConfigsTypeVector(FlatBufferBuilder builder, TProceduralVisual[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06027E9C RID: 163484 RVA: 0x005756F3 File Offset: 0x005738F3
		public static VectorOffset CreateConfigsTypeVectorBlock(FlatBufferBuilder builder, TProceduralVisual[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TProceduralVisual>(data);
			return builder.EndVector();
		}

		// Token: 0x06027E9D RID: 163485 RVA: 0x0057570D File Offset: 0x0057390D
		public static VectorOffset CreateConfigsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TProceduralVisual> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TProceduralVisual>(data);
			return builder.EndVector();
		}

		// Token: 0x06027E9E RID: 163486 RVA: 0x0057572B File Offset: 0x0057392B
		public static VectorOffset CreateConfigsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TProceduralVisual>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027E9F RID: 163487 RVA: 0x00575744 File Offset: 0x00573944
		public static void StartConfigsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06027EA0 RID: 163488 RVA: 0x0057574F File Offset: 0x0057394F
		public static void AddConfigs(FlatBufferBuilder builder, VectorOffset configsOffset)
		{
			builder.AddOffset(2, configsOffset.Value, 0);
		}

		// Token: 0x06027EA1 RID: 163489 RVA: 0x00575760 File Offset: 0x00573960
		public static VectorOffset CreateConfigsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06027EA2 RID: 163490 RVA: 0x00575797 File Offset: 0x00573997
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06027EA3 RID: 163491 RVA: 0x005757B1 File Offset: 0x005739B1
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06027EA4 RID: 163492 RVA: 0x005757CF File Offset: 0x005739CF
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027EA5 RID: 163493 RVA: 0x005757E8 File Offset: 0x005739E8
		public static void StartConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027EA6 RID: 163494 RVA: 0x005757F3 File Offset: 0x005739F3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06027EA7 RID: 163495 RVA: 0x005757FE File Offset: 0x005739FE
		public static Offset<IProceduralVisualComponent> EndIProceduralVisualComponent(FlatBufferBuilder builder)
		{
			return new Offset<IProceduralVisualComponent>(builder.EndTable());
		}

		// Token: 0x06027EA8 RID: 163496 RVA: 0x0057580C File Offset: 0x00573A0C
		public IProceduralVisualComponentT UnPack()
		{
			IProceduralVisualComponentT proceduralVisualComponentT = new IProceduralVisualComponentT();
			this.UnPackTo(proceduralVisualComponentT);
			return proceduralVisualComponentT;
		}

		// Token: 0x06027EA9 RID: 163497 RVA: 0x00575828 File Offset: 0x00573A28
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

		// Token: 0x06027EAA RID: 163498 RVA: 0x00575908 File Offset: 0x00573B08
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

		// Token: 0x0400F936 RID: 63798
		private Table __p;
	}
}
