using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A22 RID: 31266
	public struct ISwitchDataLayers : IFlatbufferObject
	{
		// Token: 0x1700E514 RID: 58644
		// (get) Token: 0x06037160 RID: 225632 RVA: 0x0075C605 File Offset: 0x0075A805
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06037161 RID: 225633 RVA: 0x0075C612 File Offset: 0x0075A812
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06037162 RID: 225634 RVA: 0x0075C61C File Offset: 0x0075A81C
		public static ISwitchDataLayers GetRootAsISwitchDataLayers(ByteBuffer _bb)
		{
			return ISwitchDataLayers.GetRootAsISwitchDataLayers(_bb, default(ISwitchDataLayers));
		}

		// Token: 0x06037163 RID: 225635 RVA: 0x0075C638 File Offset: 0x0075A838
		public static ISwitchDataLayers GetRootAsISwitchDataLayers(ByteBuffer _bb, ISwitchDataLayers obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06037164 RID: 225636 RVA: 0x0075C655 File Offset: 0x0075A855
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06037165 RID: 225637 RVA: 0x0075C664 File Offset: 0x0075A864
		public ISwitchDataLayers __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06037166 RID: 225638 RVA: 0x0075C674 File Offset: 0x0075A874
		public int LoadDataLayers(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700E515 RID: 58645
		// (get) Token: 0x06037167 RID: 225639 RVA: 0x0075C6B4 File Offset: 0x0075A8B4
		public int LoadDataLayersLength
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

		// Token: 0x06037168 RID: 225640 RVA: 0x0075C6DF File Offset: 0x0075A8DF
		public Span<int> GetLoadDataLayersBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x06037169 RID: 225641 RVA: 0x0075C6EE File Offset: 0x0075A8EE
		public int[] GetLoadDataLayersArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x0603716A RID: 225642 RVA: 0x0075C6FC File Offset: 0x0075A8FC
		public int UnloadDataLayers(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700E516 RID: 58646
		// (get) Token: 0x0603716B RID: 225643 RVA: 0x0075C73C File Offset: 0x0075A93C
		public int UnloadDataLayersLength
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

		// Token: 0x0603716C RID: 225644 RVA: 0x0075C767 File Offset: 0x0075A967
		public Span<int> GetUnloadDataLayersBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0603716D RID: 225645 RVA: 0x0075C776 File Offset: 0x0075A976
		public int[] GetUnloadDataLayersArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700E517 RID: 58647
		// (get) Token: 0x0603716E RID: 225646 RVA: 0x0075C784 File Offset: 0x0075A984
		public ISwitchDataLayersTransitionWithSequence? TransitionOption
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new ISwitchDataLayersTransitionWithSequence?(default(ISwitchDataLayersTransitionWithSequence).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700E518 RID: 58648
		// (get) Token: 0x0603716F RID: 225647 RVA: 0x0075C7E4 File Offset: 0x0075A9E4
		public string MaterialDataForLoadedLayers
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06037170 RID: 225648 RVA: 0x0075C81C File Offset: 0x0075AA1C
		public Span<byte> GetMaterialDataForLoadedLayersBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06037171 RID: 225649 RVA: 0x0075C82C File Offset: 0x0075AA2C
		public byte[] GetMaterialDataForLoadedLayersArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700E519 RID: 58649
		// (get) Token: 0x06037172 RID: 225650 RVA: 0x0075C83C File Offset: 0x0075AA3C
		public string MaterialDataForUnloadLayers
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06037173 RID: 225651 RVA: 0x0075C874 File Offset: 0x0075AA74
		public Span<byte> GetMaterialDataForUnloadLayersBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06037174 RID: 225652 RVA: 0x0075C884 File Offset: 0x0075AA84
		public byte[] GetMaterialDataForUnloadLayersArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x06037175 RID: 225653 RVA: 0x0075C893 File Offset: 0x0075AA93
		public static Offset<ISwitchDataLayers> CreateISwitchDataLayers(FlatBufferBuilder builder, VectorOffset LoadDataLayersOffset = default(VectorOffset), VectorOffset UnloadDataLayersOffset = default(VectorOffset), Offset<ISwitchDataLayersTransitionWithSequence> TransitionOptionOffset = default(Offset<ISwitchDataLayersTransitionWithSequence>), StringOffset MaterialDataForLoadedLayersOffset = default(StringOffset), StringOffset MaterialDataForUnloadLayersOffset = default(StringOffset))
		{
			builder.StartTable(5);
			ISwitchDataLayers.AddMaterialDataForUnloadLayers(builder, MaterialDataForUnloadLayersOffset);
			ISwitchDataLayers.AddMaterialDataForLoadedLayers(builder, MaterialDataForLoadedLayersOffset);
			ISwitchDataLayers.AddTransitionOption(builder, TransitionOptionOffset);
			ISwitchDataLayers.AddUnloadDataLayers(builder, UnloadDataLayersOffset);
			ISwitchDataLayers.AddLoadDataLayers(builder, LoadDataLayersOffset);
			return ISwitchDataLayers.EndISwitchDataLayers(builder);
		}

		// Token: 0x06037176 RID: 225654 RVA: 0x0075C8C7 File Offset: 0x0075AAC7
		public static void StartISwitchDataLayers(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06037177 RID: 225655 RVA: 0x0075C8D0 File Offset: 0x0075AAD0
		public static void AddLoadDataLayers(FlatBufferBuilder builder, VectorOffset loadDataLayersOffset)
		{
			builder.AddOffset(0, loadDataLayersOffset.Value, 0);
		}

		// Token: 0x06037178 RID: 225656 RVA: 0x0075C8E0 File Offset: 0x0075AAE0
		public static VectorOffset CreateLoadDataLayersVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06037179 RID: 225657 RVA: 0x0075C917 File Offset: 0x0075AB17
		public static VectorOffset CreateLoadDataLayersVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603717A RID: 225658 RVA: 0x0075C931 File Offset: 0x0075AB31
		public static VectorOffset CreateLoadDataLayersVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603717B RID: 225659 RVA: 0x0075C94F File Offset: 0x0075AB4F
		public static VectorOffset CreateLoadDataLayersVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603717C RID: 225660 RVA: 0x0075C968 File Offset: 0x0075AB68
		public static void StartLoadDataLayersVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603717D RID: 225661 RVA: 0x0075C973 File Offset: 0x0075AB73
		public static void AddUnloadDataLayers(FlatBufferBuilder builder, VectorOffset unloadDataLayersOffset)
		{
			builder.AddOffset(1, unloadDataLayersOffset.Value, 0);
		}

		// Token: 0x0603717E RID: 225662 RVA: 0x0075C984 File Offset: 0x0075AB84
		public static VectorOffset CreateUnloadDataLayersVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0603717F RID: 225663 RVA: 0x0075C9BB File Offset: 0x0075ABBB
		public static VectorOffset CreateUnloadDataLayersVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06037180 RID: 225664 RVA: 0x0075C9D5 File Offset: 0x0075ABD5
		public static VectorOffset CreateUnloadDataLayersVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06037181 RID: 225665 RVA: 0x0075C9F3 File Offset: 0x0075ABF3
		public static VectorOffset CreateUnloadDataLayersVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06037182 RID: 225666 RVA: 0x0075CA0C File Offset: 0x0075AC0C
		public static void StartUnloadDataLayersVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06037183 RID: 225667 RVA: 0x0075CA17 File Offset: 0x0075AC17
		public static void AddTransitionOption(FlatBufferBuilder builder, Offset<ISwitchDataLayersTransitionWithSequence> transitionOptionOffset)
		{
			builder.AddOffset(2, transitionOptionOffset.Value, 0);
		}

		// Token: 0x06037184 RID: 225668 RVA: 0x0075CA27 File Offset: 0x0075AC27
		public static void AddMaterialDataForLoadedLayers(FlatBufferBuilder builder, StringOffset materialDataForLoadedLayersOffset)
		{
			builder.AddOffset(3, materialDataForLoadedLayersOffset.Value, 0);
		}

		// Token: 0x06037185 RID: 225669 RVA: 0x0075CA37 File Offset: 0x0075AC37
		public static void AddMaterialDataForUnloadLayers(FlatBufferBuilder builder, StringOffset materialDataForUnloadLayersOffset)
		{
			builder.AddOffset(4, materialDataForUnloadLayersOffset.Value, 0);
		}

		// Token: 0x06037186 RID: 225670 RVA: 0x0075CA47 File Offset: 0x0075AC47
		public static Offset<ISwitchDataLayers> EndISwitchDataLayers(FlatBufferBuilder builder)
		{
			return new Offset<ISwitchDataLayers>(builder.EndTable());
		}

		// Token: 0x06037187 RID: 225671 RVA: 0x0075CA54 File Offset: 0x0075AC54
		public ISwitchDataLayersT UnPack()
		{
			ISwitchDataLayersT switchDataLayersT = new ISwitchDataLayersT();
			this.UnPackTo(switchDataLayersT);
			return switchDataLayersT;
		}

		// Token: 0x06037188 RID: 225672 RVA: 0x0075CA70 File Offset: 0x0075AC70
		public void UnPackTo(ISwitchDataLayersT _o)
		{
			_o.LoadDataLayers = new List<int>();
			for (int i = 0; i < this.LoadDataLayersLength; i++)
			{
				_o.LoadDataLayers.Add(this.LoadDataLayers(i));
			}
			_o.UnloadDataLayers = new List<int>();
			for (int j = 0; j < this.UnloadDataLayersLength; j++)
			{
				_o.UnloadDataLayers.Add(this.UnloadDataLayers(j));
			}
			_o.TransitionOption = ((this.TransitionOption != null) ? this.TransitionOption.Value.UnPack() : null);
			_o.MaterialDataForLoadedLayers = this.MaterialDataForLoadedLayers;
			_o.MaterialDataForUnloadLayers = this.MaterialDataForUnloadLayers;
		}

		// Token: 0x06037189 RID: 225673 RVA: 0x0075CB20 File Offset: 0x0075AD20
		public static Offset<ISwitchDataLayers> Pack(FlatBufferBuilder builder, ISwitchDataLayersT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISwitchDataLayers>);
			}
			VectorOffset loadDataLayersOffset = default(VectorOffset);
			if (_o.LoadDataLayers != null)
			{
				int[] data = _o.LoadDataLayers.ToArray();
				loadDataLayersOffset = ISwitchDataLayers.CreateLoadDataLayersVector(builder, data);
			}
			VectorOffset unloadDataLayersOffset = default(VectorOffset);
			if (_o.UnloadDataLayers != null)
			{
				int[] data2 = _o.UnloadDataLayers.ToArray();
				unloadDataLayersOffset = ISwitchDataLayers.CreateUnloadDataLayersVector(builder, data2);
			}
			Offset<ISwitchDataLayersTransitionWithSequence> transitionOptionOffset = (_o.TransitionOption == null) ? default(Offset<ISwitchDataLayersTransitionWithSequence>) : ISwitchDataLayersTransitionWithSequence.Pack(builder, _o.TransitionOption);
			StringOffset materialDataForLoadedLayersOffset = (_o.MaterialDataForLoadedLayers == null) ? default(StringOffset) : builder.CreateString(_o.MaterialDataForLoadedLayers);
			StringOffset materialDataForUnloadLayersOffset = (_o.MaterialDataForUnloadLayers == null) ? default(StringOffset) : builder.CreateString(_o.MaterialDataForUnloadLayers);
			return ISwitchDataLayers.CreateISwitchDataLayers(builder, loadDataLayersOffset, unloadDataLayersOffset, transitionOptionOffset, materialDataForLoadedLayersOffset, materialDataForUnloadLayersOffset);
		}

		// Token: 0x04012D40 RID: 77120
		private Table __p;
	}
}
