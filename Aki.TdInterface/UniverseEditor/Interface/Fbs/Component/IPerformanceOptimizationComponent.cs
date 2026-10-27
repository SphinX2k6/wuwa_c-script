using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200571B RID: 22299
	public struct IPerformanceOptimizationComponent : IFlatbufferObject
	{
		// Token: 0x1700A622 RID: 42530
		// (get) Token: 0x060254DA RID: 152794 RVA: 0x00525C05 File Offset: 0x00523E05
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060254DB RID: 152795 RVA: 0x00525C12 File Offset: 0x00523E12
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060254DC RID: 152796 RVA: 0x00525C1C File Offset: 0x00523E1C
		public static IPerformanceOptimizationComponent GetRootAsIPerformanceOptimizationComponent(ByteBuffer _bb)
		{
			return IPerformanceOptimizationComponent.GetRootAsIPerformanceOptimizationComponent(_bb, default(IPerformanceOptimizationComponent));
		}

		// Token: 0x060254DD RID: 152797 RVA: 0x00525C38 File Offset: 0x00523E38
		public static IPerformanceOptimizationComponent GetRootAsIPerformanceOptimizationComponent(ByteBuffer _bb, IPerformanceOptimizationComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060254DE RID: 152798 RVA: 0x00525C55 File Offset: 0x00523E55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060254DF RID: 152799 RVA: 0x00525C64 File Offset: 0x00523E64
		public IPerformanceOptimizationComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A623 RID: 42531
		// (get) Token: 0x060254E0 RID: 152800 RVA: 0x00525C74 File Offset: 0x00523E74
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060254E1 RID: 152801 RVA: 0x00525CB4 File Offset: 0x00523EB4
		public TPerformanceOptimizationType PerformanceOptimizationListType(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return TPerformanceOptimizationType.NONE;
			}
			return (TPerformanceOptimizationType)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700A624 RID: 42532
		// (get) Token: 0x060254E2 RID: 152802 RVA: 0x00525CF4 File Offset: 0x00523EF4
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

		// Token: 0x060254E3 RID: 152803 RVA: 0x00525D1F File Offset: 0x00523F1F
		public Span<TPerformanceOptimizationType> GetPerformanceOptimizationListTypeBytes()
		{
			return this.__p.__vector_as_span<TPerformanceOptimizationType>(6, 1);
		}

		// Token: 0x060254E4 RID: 152804 RVA: 0x00525D30 File Offset: 0x00523F30
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

		// Token: 0x060254E5 RID: 152805 RVA: 0x00525D9C File Offset: 0x00523F9C
		public TTable? PerformanceOptimizationList<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700A625 RID: 42533
		// (get) Token: 0x060254E6 RID: 152806 RVA: 0x00525DE4 File Offset: 0x00523FE4
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

		// Token: 0x1700A626 RID: 42534
		// (get) Token: 0x060254E7 RID: 152807 RVA: 0x00525E10 File Offset: 0x00524010
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

		// Token: 0x060254E8 RID: 152808 RVA: 0x00525E4D File Offset: 0x0052404D
		public static Offset<IPerformanceOptimizationComponent> CreateIPerformanceOptimizationComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset PerformanceOptimizationList_typeOffset = default(VectorOffset), VectorOffset PerformanceOptimizationListOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IPerformanceOptimizationComponent.AddPerformanceOptimizationList(builder, PerformanceOptimizationListOffset);
			IPerformanceOptimizationComponent.AddPerformanceOptimizationListType(builder, PerformanceOptimizationList_typeOffset);
			IPerformanceOptimizationComponent.AddNullMask(builder, NullMask);
			IPerformanceOptimizationComponent.AddDisabled(builder, Disabled);
			return IPerformanceOptimizationComponent.EndIPerformanceOptimizationComponent(builder);
		}

		// Token: 0x060254E9 RID: 152809 RVA: 0x00525E79 File Offset: 0x00524079
		public static void StartIPerformanceOptimizationComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060254EA RID: 152810 RVA: 0x00525E82 File Offset: 0x00524082
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060254EB RID: 152811 RVA: 0x00525E8D File Offset: 0x0052408D
		public static void AddPerformanceOptimizationListType(FlatBufferBuilder builder, VectorOffset performanceOptimizationListTypeOffset)
		{
			builder.AddOffset(1, performanceOptimizationListTypeOffset.Value, 0);
		}

		// Token: 0x060254EC RID: 152812 RVA: 0x00525EA0 File Offset: 0x005240A0
		public static VectorOffset CreatePerformanceOptimizationListTypeVector(FlatBufferBuilder builder, TPerformanceOptimizationType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060254ED RID: 152813 RVA: 0x00525ED7 File Offset: 0x005240D7
		public static VectorOffset CreatePerformanceOptimizationListTypeVectorBlock(FlatBufferBuilder builder, TPerformanceOptimizationType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TPerformanceOptimizationType>(data);
			return builder.EndVector();
		}

		// Token: 0x060254EE RID: 152814 RVA: 0x00525EF1 File Offset: 0x005240F1
		public static VectorOffset CreatePerformanceOptimizationListTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TPerformanceOptimizationType> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TPerformanceOptimizationType>(data);
			return builder.EndVector();
		}

		// Token: 0x060254EF RID: 152815 RVA: 0x00525F0F File Offset: 0x0052410F
		public static VectorOffset CreatePerformanceOptimizationListTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TPerformanceOptimizationType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060254F0 RID: 152816 RVA: 0x00525F28 File Offset: 0x00524128
		public static void StartPerformanceOptimizationListTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x060254F1 RID: 152817 RVA: 0x00525F33 File Offset: 0x00524133
		public static void AddPerformanceOptimizationList(FlatBufferBuilder builder, VectorOffset performanceOptimizationListOffset)
		{
			builder.AddOffset(2, performanceOptimizationListOffset.Value, 0);
		}

		// Token: 0x060254F2 RID: 152818 RVA: 0x00525F44 File Offset: 0x00524144
		public static VectorOffset CreatePerformanceOptimizationListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060254F3 RID: 152819 RVA: 0x00525F7B File Offset: 0x0052417B
		public static VectorOffset CreatePerformanceOptimizationListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060254F4 RID: 152820 RVA: 0x00525F95 File Offset: 0x00524195
		public static VectorOffset CreatePerformanceOptimizationListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060254F5 RID: 152821 RVA: 0x00525FB3 File Offset: 0x005241B3
		public static VectorOffset CreatePerformanceOptimizationListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060254F6 RID: 152822 RVA: 0x00525FCC File Offset: 0x005241CC
		public static void StartPerformanceOptimizationListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060254F7 RID: 152823 RVA: 0x00525FD7 File Offset: 0x005241D7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060254F8 RID: 152824 RVA: 0x00525FE2 File Offset: 0x005241E2
		public static Offset<IPerformanceOptimizationComponent> EndIPerformanceOptimizationComponent(FlatBufferBuilder builder)
		{
			return new Offset<IPerformanceOptimizationComponent>(builder.EndTable());
		}

		// Token: 0x060254F9 RID: 152825 RVA: 0x00525FF0 File Offset: 0x005241F0
		public IPerformanceOptimizationComponentT UnPack()
		{
			IPerformanceOptimizationComponentT performanceOptimizationComponentT = new IPerformanceOptimizationComponentT();
			this.UnPackTo(performanceOptimizationComponentT);
			return performanceOptimizationComponentT;
		}

		// Token: 0x060254FA RID: 152826 RVA: 0x0052600C File Offset: 0x0052420C
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

		// Token: 0x060254FB RID: 152827 RVA: 0x005260EC File Offset: 0x005242EC
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

		// Token: 0x0400EB8B RID: 60299
		private Table __p;
	}
}
