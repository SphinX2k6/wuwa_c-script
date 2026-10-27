using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200724D RID: 29261
	public struct ISwitchDataLayers : IFlatbufferObject
	{
		// Token: 0x1700D91B RID: 55579
		// (get) Token: 0x06033E5E RID: 212574 RVA: 0x006FB2A5 File Offset: 0x006F94A5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033E5F RID: 212575 RVA: 0x006FB2B2 File Offset: 0x006F94B2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033E60 RID: 212576 RVA: 0x006FB2BC File Offset: 0x006F94BC
		public static ISwitchDataLayers GetRootAsISwitchDataLayers(ByteBuffer _bb)
		{
			return ISwitchDataLayers.GetRootAsISwitchDataLayers(_bb, default(ISwitchDataLayers));
		}

		// Token: 0x06033E61 RID: 212577 RVA: 0x006FB2D8 File Offset: 0x006F94D8
		public static ISwitchDataLayers GetRootAsISwitchDataLayers(ByteBuffer _bb, ISwitchDataLayers obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033E62 RID: 212578 RVA: 0x006FB2F5 File Offset: 0x006F94F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033E63 RID: 212579 RVA: 0x006FB304 File Offset: 0x006F9504
		public ISwitchDataLayers __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06033E64 RID: 212580 RVA: 0x006FB314 File Offset: 0x006F9514
		public int LoadDataLayers(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D91C RID: 55580
		// (get) Token: 0x06033E65 RID: 212581 RVA: 0x006FB354 File Offset: 0x006F9554
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

		// Token: 0x06033E66 RID: 212582 RVA: 0x006FB37F File Offset: 0x006F957F
		public Span<int> GetLoadDataLayersBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x06033E67 RID: 212583 RVA: 0x006FB38E File Offset: 0x006F958E
		public int[] GetLoadDataLayersArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x06033E68 RID: 212584 RVA: 0x006FB39C File Offset: 0x006F959C
		public int UnloadDataLayers(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D91D RID: 55581
		// (get) Token: 0x06033E69 RID: 212585 RVA: 0x006FB3DC File Offset: 0x006F95DC
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

		// Token: 0x06033E6A RID: 212586 RVA: 0x006FB407 File Offset: 0x006F9607
		public Span<int> GetUnloadDataLayersBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06033E6B RID: 212587 RVA: 0x006FB416 File Offset: 0x006F9616
		public int[] GetUnloadDataLayersArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700D91E RID: 55582
		// (get) Token: 0x06033E6C RID: 212588 RVA: 0x006FB424 File Offset: 0x006F9624
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

		// Token: 0x1700D91F RID: 55583
		// (get) Token: 0x06033E6D RID: 212589 RVA: 0x006FB484 File Offset: 0x006F9684
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

		// Token: 0x06033E6E RID: 212590 RVA: 0x006FB4BC File Offset: 0x006F96BC
		public Span<byte> GetMaterialDataForLoadedLayersBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06033E6F RID: 212591 RVA: 0x006FB4CC File Offset: 0x006F96CC
		public byte[] GetMaterialDataForLoadedLayersArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700D920 RID: 55584
		// (get) Token: 0x06033E70 RID: 212592 RVA: 0x006FB4DC File Offset: 0x006F96DC
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

		// Token: 0x06033E71 RID: 212593 RVA: 0x006FB514 File Offset: 0x006F9714
		public Span<byte> GetMaterialDataForUnloadLayersBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06033E72 RID: 212594 RVA: 0x006FB524 File Offset: 0x006F9724
		public byte[] GetMaterialDataForUnloadLayersArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x06033E73 RID: 212595 RVA: 0x006FB533 File Offset: 0x006F9733
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

		// Token: 0x06033E74 RID: 212596 RVA: 0x006FB567 File Offset: 0x006F9767
		public static void StartISwitchDataLayers(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06033E75 RID: 212597 RVA: 0x006FB570 File Offset: 0x006F9770
		public static void AddLoadDataLayers(FlatBufferBuilder builder, VectorOffset loadDataLayersOffset)
		{
			builder.AddOffset(0, loadDataLayersOffset.Value, 0);
		}

		// Token: 0x06033E76 RID: 212598 RVA: 0x006FB580 File Offset: 0x006F9780
		public static VectorOffset CreateLoadDataLayersVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06033E77 RID: 212599 RVA: 0x006FB5B7 File Offset: 0x006F97B7
		public static VectorOffset CreateLoadDataLayersVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06033E78 RID: 212600 RVA: 0x006FB5D1 File Offset: 0x006F97D1
		public static VectorOffset CreateLoadDataLayersVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06033E79 RID: 212601 RVA: 0x006FB5EF File Offset: 0x006F97EF
		public static VectorOffset CreateLoadDataLayersVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06033E7A RID: 212602 RVA: 0x006FB608 File Offset: 0x006F9808
		public static void StartLoadDataLayersVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06033E7B RID: 212603 RVA: 0x006FB613 File Offset: 0x006F9813
		public static void AddUnloadDataLayers(FlatBufferBuilder builder, VectorOffset unloadDataLayersOffset)
		{
			builder.AddOffset(1, unloadDataLayersOffset.Value, 0);
		}

		// Token: 0x06033E7C RID: 212604 RVA: 0x006FB624 File Offset: 0x006F9824
		public static VectorOffset CreateUnloadDataLayersVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06033E7D RID: 212605 RVA: 0x006FB65B File Offset: 0x006F985B
		public static VectorOffset CreateUnloadDataLayersVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06033E7E RID: 212606 RVA: 0x006FB675 File Offset: 0x006F9875
		public static VectorOffset CreateUnloadDataLayersVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06033E7F RID: 212607 RVA: 0x006FB693 File Offset: 0x006F9893
		public static VectorOffset CreateUnloadDataLayersVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06033E80 RID: 212608 RVA: 0x006FB6AC File Offset: 0x006F98AC
		public static void StartUnloadDataLayersVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06033E81 RID: 212609 RVA: 0x006FB6B7 File Offset: 0x006F98B7
		public static void AddTransitionOption(FlatBufferBuilder builder, Offset<ISwitchDataLayersTransitionWithSequence> transitionOptionOffset)
		{
			builder.AddOffset(2, transitionOptionOffset.Value, 0);
		}

		// Token: 0x06033E82 RID: 212610 RVA: 0x006FB6C7 File Offset: 0x006F98C7
		public static void AddMaterialDataForLoadedLayers(FlatBufferBuilder builder, StringOffset materialDataForLoadedLayersOffset)
		{
			builder.AddOffset(3, materialDataForLoadedLayersOffset.Value, 0);
		}

		// Token: 0x06033E83 RID: 212611 RVA: 0x006FB6D7 File Offset: 0x006F98D7
		public static void AddMaterialDataForUnloadLayers(FlatBufferBuilder builder, StringOffset materialDataForUnloadLayersOffset)
		{
			builder.AddOffset(4, materialDataForUnloadLayersOffset.Value, 0);
		}

		// Token: 0x06033E84 RID: 212612 RVA: 0x006FB6E7 File Offset: 0x006F98E7
		public static Offset<ISwitchDataLayers> EndISwitchDataLayers(FlatBufferBuilder builder)
		{
			return new Offset<ISwitchDataLayers>(builder.EndTable());
		}

		// Token: 0x06033E85 RID: 212613 RVA: 0x006FB6F4 File Offset: 0x006F98F4
		public ISwitchDataLayersT UnPack()
		{
			ISwitchDataLayersT switchDataLayersT = new ISwitchDataLayersT();
			this.UnPackTo(switchDataLayersT);
			return switchDataLayersT;
		}

		// Token: 0x06033E86 RID: 212614 RVA: 0x006FB710 File Offset: 0x006F9910
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

		// Token: 0x06033E87 RID: 212615 RVA: 0x006FB7C0 File Offset: 0x006F99C0
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

		// Token: 0x04011D3E RID: 73022
		private Table __p;
	}
}
