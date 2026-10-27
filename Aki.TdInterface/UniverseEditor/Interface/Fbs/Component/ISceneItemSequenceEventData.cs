using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058D6 RID: 22742
	public struct ISceneItemSequenceEventData : IFlatbufferObject
	{
		// Token: 0x1700AA4F RID: 43599
		// (get) Token: 0x0602662A RID: 157226 RVA: 0x0054A314 File Offset: 0x00548514
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602662B RID: 157227 RVA: 0x0054A321 File Offset: 0x00548521
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602662C RID: 157228 RVA: 0x0054A328 File Offset: 0x00548528
		public static ISceneItemSequenceEventData GetRootAsISceneItemSequenceEventData(ByteBuffer _bb)
		{
			return ISceneItemSequenceEventData.GetRootAsISceneItemSequenceEventData(_bb, default(ISceneItemSequenceEventData));
		}

		// Token: 0x0602662D RID: 157229 RVA: 0x0054A344 File Offset: 0x00548544
		public static ISceneItemSequenceEventData GetRootAsISceneItemSequenceEventData(ByteBuffer _bb, ISceneItemSequenceEventData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602662E RID: 157230 RVA: 0x0054A361 File Offset: 0x00548561
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602662F RID: 157231 RVA: 0x0054A370 File Offset: 0x00548570
		public ISceneItemSequenceEventData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AA50 RID: 43600
		// (get) Token: 0x06026630 RID: 157232 RVA: 0x0054A380 File Offset: 0x00548580
		public string SeqGuid
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026631 RID: 157233 RVA: 0x0054A3B7 File Offset: 0x005485B7
		public Span<byte> GetSeqGuidBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06026632 RID: 157234 RVA: 0x0054A3C6 File Offset: 0x005485C6
		public byte[] GetSeqGuidArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700AA51 RID: 43601
		// (get) Token: 0x06026633 RID: 157235 RVA: 0x0054A3D4 File Offset: 0x005485D4
		public string SeqPath
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026634 RID: 157236 RVA: 0x0054A40B File Offset: 0x0054860B
		public Span<byte> GetSeqPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06026635 RID: 157237 RVA: 0x0054A41A File Offset: 0x0054861A
		public byte[] GetSeqPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06026636 RID: 157238 RVA: 0x0054A428 File Offset: 0x00548628
		public TSceneItemSeqEventCbType EventCallbacksType(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return TSceneItemSeqEventCbType.NONE;
			}
			return (TSceneItemSeqEventCbType)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700AA52 RID: 43602
		// (get) Token: 0x06026637 RID: 157239 RVA: 0x0054A468 File Offset: 0x00548668
		public int EventCallbacksTypeLength
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

		// Token: 0x06026638 RID: 157240 RVA: 0x0054A493 File Offset: 0x00548693
		public Span<TSceneItemSeqEventCbType> GetEventCallbacksTypeBytes()
		{
			return this.__p.__vector_as_span<TSceneItemSeqEventCbType>(8, 1);
		}

		// Token: 0x06026639 RID: 157241 RVA: 0x0054A4A4 File Offset: 0x005486A4
		public TSceneItemSeqEventCbType[] GetEventCallbacksTypeArray()
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TSceneItemSeqEventCbType[] array = new TSceneItemSeqEventCbType[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TSceneItemSeqEventCbType)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x0602663A RID: 157242 RVA: 0x0054A510 File Offset: 0x00548710
		public TTable? EventCallbacks<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700AA53 RID: 43603
		// (get) Token: 0x0602663B RID: 157243 RVA: 0x0054A558 File Offset: 0x00548758
		public int EventCallbacksLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602663C RID: 157244 RVA: 0x0054A584 File Offset: 0x00548784
		public static Offset<ISceneItemSequenceEventData> CreateISceneItemSequenceEventData(FlatBufferBuilder builder, StringOffset SeqGuidOffset = default(StringOffset), StringOffset SeqPathOffset = default(StringOffset), VectorOffset EventCallbacks_typeOffset = default(VectorOffset), VectorOffset EventCallbacksOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			ISceneItemSequenceEventData.AddEventCallbacks(builder, EventCallbacksOffset);
			ISceneItemSequenceEventData.AddEventCallbacksType(builder, EventCallbacks_typeOffset);
			ISceneItemSequenceEventData.AddSeqPath(builder, SeqPathOffset);
			ISceneItemSequenceEventData.AddSeqGuid(builder, SeqGuidOffset);
			return ISceneItemSequenceEventData.EndISceneItemSequenceEventData(builder);
		}

		// Token: 0x0602663D RID: 157245 RVA: 0x0054A5B0 File Offset: 0x005487B0
		public static void StartISceneItemSequenceEventData(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602663E RID: 157246 RVA: 0x0054A5B9 File Offset: 0x005487B9
		public static void AddSeqGuid(FlatBufferBuilder builder, StringOffset seqGuidOffset)
		{
			builder.AddOffset(0, seqGuidOffset.Value, 0);
		}

		// Token: 0x0602663F RID: 157247 RVA: 0x0054A5C9 File Offset: 0x005487C9
		public static void AddSeqPath(FlatBufferBuilder builder, StringOffset seqPathOffset)
		{
			builder.AddOffset(1, seqPathOffset.Value, 0);
		}

		// Token: 0x06026640 RID: 157248 RVA: 0x0054A5D9 File Offset: 0x005487D9
		public static void AddEventCallbacksType(FlatBufferBuilder builder, VectorOffset eventCallbacksTypeOffset)
		{
			builder.AddOffset(2, eventCallbacksTypeOffset.Value, 0);
		}

		// Token: 0x06026641 RID: 157249 RVA: 0x0054A5EC File Offset: 0x005487EC
		public static VectorOffset CreateEventCallbacksTypeVector(FlatBufferBuilder builder, TSceneItemSeqEventCbType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06026642 RID: 157250 RVA: 0x0054A623 File Offset: 0x00548823
		public static VectorOffset CreateEventCallbacksTypeVectorBlock(FlatBufferBuilder builder, TSceneItemSeqEventCbType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TSceneItemSeqEventCbType>(data);
			return builder.EndVector();
		}

		// Token: 0x06026643 RID: 157251 RVA: 0x0054A63D File Offset: 0x0054883D
		public static VectorOffset CreateEventCallbacksTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TSceneItemSeqEventCbType> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TSceneItemSeqEventCbType>(data);
			return builder.EndVector();
		}

		// Token: 0x06026644 RID: 157252 RVA: 0x0054A65B File Offset: 0x0054885B
		public static VectorOffset CreateEventCallbacksTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TSceneItemSeqEventCbType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026645 RID: 157253 RVA: 0x0054A674 File Offset: 0x00548874
		public static void StartEventCallbacksTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06026646 RID: 157254 RVA: 0x0054A67F File Offset: 0x0054887F
		public static void AddEventCallbacks(FlatBufferBuilder builder, VectorOffset eventCallbacksOffset)
		{
			builder.AddOffset(3, eventCallbacksOffset.Value, 0);
		}

		// Token: 0x06026647 RID: 157255 RVA: 0x0054A690 File Offset: 0x00548890
		public static VectorOffset CreateEventCallbacksVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06026648 RID: 157256 RVA: 0x0054A6C7 File Offset: 0x005488C7
		public static VectorOffset CreateEventCallbacksVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06026649 RID: 157257 RVA: 0x0054A6E1 File Offset: 0x005488E1
		public static VectorOffset CreateEventCallbacksVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602664A RID: 157258 RVA: 0x0054A6FF File Offset: 0x005488FF
		public static VectorOffset CreateEventCallbacksVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602664B RID: 157259 RVA: 0x0054A718 File Offset: 0x00548918
		public static void StartEventCallbacksVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602664C RID: 157260 RVA: 0x0054A723 File Offset: 0x00548923
		public static Offset<ISceneItemSequenceEventData> EndISceneItemSequenceEventData(FlatBufferBuilder builder)
		{
			return new Offset<ISceneItemSequenceEventData>(builder.EndTable());
		}

		// Token: 0x0602664D RID: 157261 RVA: 0x0054A730 File Offset: 0x00548930
		public ISceneItemSequenceEventDataT UnPack()
		{
			ISceneItemSequenceEventDataT sceneItemSequenceEventDataT = new ISceneItemSequenceEventDataT();
			this.UnPackTo(sceneItemSequenceEventDataT);
			return sceneItemSequenceEventDataT;
		}

		// Token: 0x0602664E RID: 157262 RVA: 0x0054A74C File Offset: 0x0054894C
		public void UnPackTo(ISceneItemSequenceEventDataT _o)
		{
			_o.SeqGuid = this.SeqGuid;
			_o.SeqPath = this.SeqPath;
			_o.EventCallbacks = new List<TSceneItemSeqEventCbTypeUnion>();
			for (int i = 0; i < this.EventCallbacksLength; i++)
			{
				TSceneItemSeqEventCbTypeUnion tsceneItemSeqEventCbTypeUnion = new TSceneItemSeqEventCbTypeUnion();
				tsceneItemSeqEventCbTypeUnion.Type = this.EventCallbacksType(i);
				TSceneItemSeqEventCbType tsceneItemSeqEventCbType = this.EventCallbacksType(i);
				if (tsceneItemSeqEventCbType != TSceneItemSeqEventCbType.IAnEvent)
				{
					if (tsceneItemSeqEventCbType == TSceneItemSeqEventCbType.IAnsEvent)
					{
						tsceneItemSeqEventCbTypeUnion.Value = ((this.EventCallbacks<IAnsEvent>(i) != null) ? this.EventCallbacks<IAnsEvent>(i).Value.UnPack() : null);
					}
				}
				else
				{
					tsceneItemSeqEventCbTypeUnion.Value = ((this.EventCallbacks<IAnEvent>(i) != null) ? this.EventCallbacks<IAnEvent>(i).Value.UnPack() : null);
				}
				_o.EventCallbacks.Add(tsceneItemSeqEventCbTypeUnion);
			}
		}

		// Token: 0x0602664F RID: 157263 RVA: 0x0054A82C File Offset: 0x00548A2C
		public static Offset<ISceneItemSequenceEventData> Pack(FlatBufferBuilder builder, ISceneItemSequenceEventDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneItemSequenceEventData>);
			}
			StringOffset seqGuidOffset = (_o.SeqGuid == null) ? default(StringOffset) : builder.CreateString(_o.SeqGuid);
			StringOffset seqPathOffset = (_o.SeqPath == null) ? default(StringOffset) : builder.CreateString(_o.SeqPath);
			VectorOffset eventCallbacks_typeOffset = default(VectorOffset);
			if (_o.EventCallbacks != null)
			{
				TSceneItemSeqEventCbType[] array = new TSceneItemSeqEventCbType[_o.EventCallbacks.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.EventCallbacks[i].Type;
				}
				eventCallbacks_typeOffset = ISceneItemSequenceEventData.CreateEventCallbacksTypeVector(builder, array);
			}
			VectorOffset eventCallbacksOffset = default(VectorOffset);
			if (_o.EventCallbacks != null)
			{
				int[] array2 = new int[_o.EventCallbacks.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TSceneItemSeqEventCbTypeUnion.Pack(builder, _o.EventCallbacks[j]);
				}
				eventCallbacksOffset = ISceneItemSequenceEventData.CreateEventCallbacksVector(builder, array2);
			}
			return ISceneItemSequenceEventData.CreateISceneItemSequenceEventData(builder, seqGuidOffset, seqPathOffset, eventCallbacks_typeOffset, eventCallbacksOffset);
		}

		// Token: 0x0400EE58 RID: 61016
		private Table __p;
	}
}
