using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D22 RID: 23842
	public struct IPerformanceOptimizationComponent : IFlatbufferObject
	{
		// Token: 0x1700AF42 RID: 44866
		// (get) Token: 0x060279E9 RID: 162281 RVA: 0x0056B90D File Offset: 0x00569B0D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060279EA RID: 162282 RVA: 0x0056B91A File Offset: 0x00569B1A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060279EB RID: 162283 RVA: 0x0056B924 File Offset: 0x00569B24
		public static IPerformanceOptimizationComponent GetRootAsIPerformanceOptimizationComponent(ByteBuffer _bb)
		{
			return IPerformanceOptimizationComponent.GetRootAsIPerformanceOptimizationComponent(_bb, default(IPerformanceOptimizationComponent));
		}

		// Token: 0x060279EC RID: 162284 RVA: 0x0056B940 File Offset: 0x00569B40
		public static IPerformanceOptimizationComponent GetRootAsIPerformanceOptimizationComponent(ByteBuffer _bb, IPerformanceOptimizationComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060279ED RID: 162285 RVA: 0x0056B95D File Offset: 0x00569B5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060279EE RID: 162286 RVA: 0x0056B96C File Offset: 0x00569B6C
		public IPerformanceOptimizationComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AF43 RID: 44867
		// (get) Token: 0x060279EF RID: 162287 RVA: 0x0056B97C File Offset: 0x00569B7C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060279F0 RID: 162288 RVA: 0x0056B9BC File Offset: 0x00569BBC
		public TPerformanceOptimizationType PerformanceOptimizationListType(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return TPerformanceOptimizationType.NONE;
			}
			return (TPerformanceOptimizationType)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700AF44 RID: 44868
		// (get) Token: 0x060279F1 RID: 162289 RVA: 0x0056B9FC File Offset: 0x00569BFC
		public int PerformanceOptimizationListTypeLength
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

		// Token: 0x060279F2 RID: 162290 RVA: 0x0056BA27 File Offset: 0x00569C27
		public Span<TPerformanceOptimizationType> GetPerformanceOptimizationListTypeBytes()
		{
			return this.__p.__vector_as_span<TPerformanceOptimizationType>(6, 1);
		}

		// Token: 0x060279F3 RID: 162291 RVA: 0x0056BA38 File Offset: 0x00569C38
		public TPerformanceOptimizationType[] GetPerformanceOptimizationListTypeArray()
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TPerformanceOptimizationType[] array = new TPerformanceOptimizationType[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TPerformanceOptimizationType)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x060279F4 RID: 162292 RVA: 0x0056BAA4 File Offset: 0x00569CA4
		public TTable? PerformanceOptimizationList<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700AF45 RID: 44869
		// (get) Token: 0x060279F5 RID: 162293 RVA: 0x0056BAEC File Offset: 0x00569CEC
		public int PerformanceOptimizationListLength
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

		// Token: 0x1700AF46 RID: 44870
		// (get) Token: 0x060279F6 RID: 162294 RVA: 0x0056BB18 File Offset: 0x00569D18
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

		// Token: 0x060279F7 RID: 162295 RVA: 0x0056BB55 File Offset: 0x00569D55
		public static Offset<IPerformanceOptimizationComponent> CreateIPerformanceOptimizationComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset PerformanceOptimizationList_typeOffset = default(VectorOffset), VectorOffset PerformanceOptimizationListOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IPerformanceOptimizationComponent.AddPerformanceOptimizationList(builder, PerformanceOptimizationListOffset);
			IPerformanceOptimizationComponent.AddPerformanceOptimizationListType(builder, PerformanceOptimizationList_typeOffset);
			IPerformanceOptimizationComponent.AddNullMask(builder, NullMask);
			IPerformanceOptimizationComponent.AddDisabled(builder, Disabled);
			return IPerformanceOptimizationComponent.EndIPerformanceOptimizationComponent(builder);
		}

		// Token: 0x060279F8 RID: 162296 RVA: 0x0056BB81 File Offset: 0x00569D81
		public static void StartIPerformanceOptimizationComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060279F9 RID: 162297 RVA: 0x0056BB8A File Offset: 0x00569D8A
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060279FA RID: 162298 RVA: 0x0056BB95 File Offset: 0x00569D95
		public static void AddPerformanceOptimizationListType(FlatBufferBuilder builder, VectorOffset performanceOptimizationListTypeOffset)
		{
			builder.AddOffset(1, performanceOptimizationListTypeOffset.Value, 0);
		}

		// Token: 0x060279FB RID: 162299 RVA: 0x0056BBA8 File Offset: 0x00569DA8
		public static VectorOffset CreatePerformanceOptimizationListTypeVector(FlatBufferBuilder builder, TPerformanceOptimizationType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060279FC RID: 162300 RVA: 0x0056BBDF File Offset: 0x00569DDF
		public static VectorOffset CreatePerformanceOptimizationListTypeVectorBlock(FlatBufferBuilder builder, TPerformanceOptimizationType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TPerformanceOptimizationType>(data);
			return builder.EndVector();
		}

		// Token: 0x060279FD RID: 162301 RVA: 0x0056BBF9 File Offset: 0x00569DF9
		public static VectorOffset CreatePerformanceOptimizationListTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TPerformanceOptimizationType> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TPerformanceOptimizationType>(data);
			return builder.EndVector();
		}

		// Token: 0x060279FE RID: 162302 RVA: 0x0056BC17 File Offset: 0x00569E17
		public static VectorOffset CreatePerformanceOptimizationListTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TPerformanceOptimizationType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060279FF RID: 162303 RVA: 0x0056BC30 File Offset: 0x00569E30
		public static void StartPerformanceOptimizationListTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06027A00 RID: 162304 RVA: 0x0056BC3B File Offset: 0x00569E3B
		public static void AddPerformanceOptimizationList(FlatBufferBuilder builder, VectorOffset performanceOptimizationListOffset)
		{
			builder.AddOffset(2, performanceOptimizationListOffset.Value, 0);
		}

		// Token: 0x06027A01 RID: 162305 RVA: 0x0056BC4C File Offset: 0x00569E4C
		public static VectorOffset CreatePerformanceOptimizationListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06027A02 RID: 162306 RVA: 0x0056BC83 File Offset: 0x00569E83
		public static VectorOffset CreatePerformanceOptimizationListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06027A03 RID: 162307 RVA: 0x0056BC9D File Offset: 0x00569E9D
		public static VectorOffset CreatePerformanceOptimizationListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06027A04 RID: 162308 RVA: 0x0056BCBB File Offset: 0x00569EBB
		public static VectorOffset CreatePerformanceOptimizationListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027A05 RID: 162309 RVA: 0x0056BCD4 File Offset: 0x00569ED4
		public static void StartPerformanceOptimizationListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027A06 RID: 162310 RVA: 0x0056BCDF File Offset: 0x00569EDF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06027A07 RID: 162311 RVA: 0x0056BCEA File Offset: 0x00569EEA
		public static Offset<IPerformanceOptimizationComponent> EndIPerformanceOptimizationComponent(FlatBufferBuilder builder)
		{
			return new Offset<IPerformanceOptimizationComponent>(builder.EndTable());
		}

		// Token: 0x06027A08 RID: 162312 RVA: 0x0056BCF8 File Offset: 0x00569EF8
		public IPerformanceOptimizationComponentT UnPack()
		{
			IPerformanceOptimizationComponentT performanceOptimizationComponentT = new IPerformanceOptimizationComponentT();
			this.UnPackTo(performanceOptimizationComponentT);
			return performanceOptimizationComponentT;
		}

		// Token: 0x06027A09 RID: 162313 RVA: 0x0056BD14 File Offset: 0x00569F14
		public void UnPackTo(IPerformanceOptimizationComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.PerformanceOptimizationList = new List<TPerformanceOptimizationTypeUnion>();
			for (int i = 0; i < this.PerformanceOptimizationListLength; i++)
			{
				TPerformanceOptimizationTypeUnion tperformanceOptimizationTypeUnion = new TPerformanceOptimizationTypeUnion();
				tperformanceOptimizationTypeUnion.Type = this.PerformanceOptimizationListType(i);
				TPerformanceOptimizationType tperformanceOptimizationType = this.PerformanceOptimizationListType(i);
				if (tperformanceOptimizationType != TPerformanceOptimizationType.IDamageTextOptimizationConfig)
				{
					if (tperformanceOptimizationType == TPerformanceOptimizationType.IPlaneMovementOptimizationConfig)
					{
						tperformanceOptimizationTypeUnion.Value = ((this.PerformanceOptimizationList<IPlaneMovementOptimizationConfig>(i) != null) ? this.PerformanceOptimizationList<IPlaneMovementOptimizationConfig>(i).Value.UnPack() : null);
					}
				}
				else
				{
					tperformanceOptimizationTypeUnion.Value = ((this.PerformanceOptimizationList<IDamageTextOptimizationConfig>(i) != null) ? this.PerformanceOptimizationList<IDamageTextOptimizationConfig>(i).Value.UnPack() : null);
				}
				_o.PerformanceOptimizationList.Add(tperformanceOptimizationTypeUnion);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06027A0A RID: 162314 RVA: 0x0056BDF4 File Offset: 0x00569FF4
		public static Offset<IPerformanceOptimizationComponent> Pack(FlatBufferBuilder builder, IPerformanceOptimizationComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerformanceOptimizationComponent>);
			}
			VectorOffset performanceOptimizationList_typeOffset = default(VectorOffset);
			if (_o.PerformanceOptimizationList != null)
			{
				TPerformanceOptimizationType[] array = new TPerformanceOptimizationType[_o.PerformanceOptimizationList.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.PerformanceOptimizationList[i].Type;
				}
				performanceOptimizationList_typeOffset = IPerformanceOptimizationComponent.CreatePerformanceOptimizationListTypeVector(builder, array);
			}
			VectorOffset performanceOptimizationListOffset = default(VectorOffset);
			if (_o.PerformanceOptimizationList != null)
			{
				int[] array2 = new int[_o.PerformanceOptimizationList.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TPerformanceOptimizationTypeUnion.Pack(builder, _o.PerformanceOptimizationList[j]);
				}
				performanceOptimizationListOffset = IPerformanceOptimizationComponent.CreatePerformanceOptimizationListVector(builder, array2);
			}
			return IPerformanceOptimizationComponent.CreateIPerformanceOptimizationComponent(builder, _o.Disabled, performanceOptimizationList_typeOffset, performanceOptimizationListOffset, _o.NullMask);
		}

		// Token: 0x0400F874 RID: 63604
		private Table __p;
	}
}
