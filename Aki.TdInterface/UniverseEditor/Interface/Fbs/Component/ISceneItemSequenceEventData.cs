using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EE3 RID: 24291
	public struct ISceneItemSequenceEventData : IFlatbufferObject
	{
		// Token: 0x1700B37F RID: 45951
		// (get) Token: 0x06028B8C RID: 166796 RVA: 0x00590E60 File Offset: 0x0058F060
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028B8D RID: 166797 RVA: 0x00590E6D File Offset: 0x0058F06D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028B8E RID: 166798 RVA: 0x00590E74 File Offset: 0x0058F074
		public static ISceneItemSequenceEventData GetRootAsISceneItemSequenceEventData(ByteBuffer _bb)
		{
			return ISceneItemSequenceEventData.GetRootAsISceneItemSequenceEventData(_bb, default(ISceneItemSequenceEventData));
		}

		// Token: 0x06028B8F RID: 166799 RVA: 0x00590E90 File Offset: 0x0058F090
		public static ISceneItemSequenceEventData GetRootAsISceneItemSequenceEventData(ByteBuffer _bb, ISceneItemSequenceEventData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028B90 RID: 166800 RVA: 0x00590EAD File Offset: 0x0058F0AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028B91 RID: 166801 RVA: 0x00590EBC File Offset: 0x0058F0BC
		public ISceneItemSequenceEventData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B380 RID: 45952
		// (get) Token: 0x06028B92 RID: 166802 RVA: 0x00590ECC File Offset: 0x0058F0CC
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

		// Token: 0x06028B93 RID: 166803 RVA: 0x00590F03 File Offset: 0x0058F103
		public Span<byte> GetSeqGuidBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06028B94 RID: 166804 RVA: 0x00590F12 File Offset: 0x0058F112
		public byte[] GetSeqGuidArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700B381 RID: 45953
		// (get) Token: 0x06028B95 RID: 166805 RVA: 0x00590F20 File Offset: 0x0058F120
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

		// Token: 0x06028B96 RID: 166806 RVA: 0x00590F57 File Offset: 0x0058F157
		public Span<byte> GetSeqPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06028B97 RID: 166807 RVA: 0x00590F66 File Offset: 0x0058F166
		public byte[] GetSeqPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06028B98 RID: 166808 RVA: 0x00590F74 File Offset: 0x0058F174
		public TSceneItemSeqEventCbType EventCallbacksType(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return TSceneItemSeqEventCbType.NONE;
			}
			return (TSceneItemSeqEventCbType)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700B382 RID: 45954
		// (get) Token: 0x06028B99 RID: 166809 RVA: 0x00590FB4 File Offset: 0x0058F1B4
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

		// Token: 0x06028B9A RID: 166810 RVA: 0x00590FDF File Offset: 0x0058F1DF
		public Span<TSceneItemSeqEventCbType> GetEventCallbacksTypeBytes()
		{
			return this.__p.__vector_as_span<TSceneItemSeqEventCbType>(8, 1);
		}

		// Token: 0x06028B9B RID: 166811 RVA: 0x00590FF0 File Offset: 0x0058F1F0
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

		// Token: 0x06028B9C RID: 166812 RVA: 0x0059105C File Offset: 0x0058F25C
		public TTable? EventCallbacks<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700B383 RID: 45955
		// (get) Token: 0x06028B9D RID: 166813 RVA: 0x005910A4 File Offset: 0x0058F2A4
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

		// Token: 0x06028B9E RID: 166814 RVA: 0x005910D0 File Offset: 0x0058F2D0
		public static Offset<ISceneItemSequenceEventData> CreateISceneItemSequenceEventData(FlatBufferBuilder builder, StringOffset SeqGuidOffset = default(StringOffset), StringOffset SeqPathOffset = default(StringOffset), VectorOffset EventCallbacks_typeOffset = default(VectorOffset), VectorOffset EventCallbacksOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			ISceneItemSequenceEventData.AddEventCallbacks(builder, EventCallbacksOffset);
			ISceneItemSequenceEventData.AddEventCallbacksType(builder, EventCallbacks_typeOffset);
			ISceneItemSequenceEventData.AddSeqPath(builder, SeqPathOffset);
			ISceneItemSequenceEventData.AddSeqGuid(builder, SeqGuidOffset);
			return ISceneItemSequenceEventData.EndISceneItemSequenceEventData(builder);
		}

		// Token: 0x06028B9F RID: 166815 RVA: 0x005910FC File Offset: 0x0058F2FC
		public static void StartISceneItemSequenceEventData(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06028BA0 RID: 166816 RVA: 0x00591105 File Offset: 0x0058F305
		public static void AddSeqGuid(FlatBufferBuilder builder, StringOffset seqGuidOffset)
		{
			builder.AddOffset(0, seqGuidOffset.Value, 0);
		}

		// Token: 0x06028BA1 RID: 166817 RVA: 0x00591115 File Offset: 0x0058F315
		public static void AddSeqPath(FlatBufferBuilder builder, StringOffset seqPathOffset)
		{
			builder.AddOffset(1, seqPathOffset.Value, 0);
		}

		// Token: 0x06028BA2 RID: 166818 RVA: 0x00591125 File Offset: 0x0058F325
		public static void AddEventCallbacksType(FlatBufferBuilder builder, VectorOffset eventCallbacksTypeOffset)
		{
			builder.AddOffset(2, eventCallbacksTypeOffset.Value, 0);
		}

		// Token: 0x06028BA3 RID: 166819 RVA: 0x00591138 File Offset: 0x0058F338
		public static VectorOffset CreateEventCallbacksTypeVector(FlatBufferBuilder builder, TSceneItemSeqEventCbType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06028BA4 RID: 166820 RVA: 0x0059116F File Offset: 0x0058F36F
		public static VectorOffset CreateEventCallbacksTypeVectorBlock(FlatBufferBuilder builder, TSceneItemSeqEventCbType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TSceneItemSeqEventCbType>(data);
			return builder.EndVector();
		}

		// Token: 0x06028BA5 RID: 166821 RVA: 0x00591189 File Offset: 0x0058F389
		public static VectorOffset CreateEventCallbacksTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TSceneItemSeqEventCbType> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TSceneItemSeqEventCbType>(data);
			return builder.EndVector();
		}

		// Token: 0x06028BA6 RID: 166822 RVA: 0x005911A7 File Offset: 0x0058F3A7
		public static VectorOffset CreateEventCallbacksTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TSceneItemSeqEventCbType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06028BA7 RID: 166823 RVA: 0x005911C0 File Offset: 0x0058F3C0
		public static void StartEventCallbacksTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06028BA8 RID: 166824 RVA: 0x005911CB File Offset: 0x0058F3CB
		public static void AddEventCallbacks(FlatBufferBuilder builder, VectorOffset eventCallbacksOffset)
		{
			builder.AddOffset(3, eventCallbacksOffset.Value, 0);
		}

		// Token: 0x06028BA9 RID: 166825 RVA: 0x005911DC File Offset: 0x0058F3DC
		public static VectorOffset CreateEventCallbacksVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06028BAA RID: 166826 RVA: 0x00591213 File Offset: 0x0058F413
		public static VectorOffset CreateEventCallbacksVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06028BAB RID: 166827 RVA: 0x0059122D File Offset: 0x0058F42D
		public static VectorOffset CreateEventCallbacksVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06028BAC RID: 166828 RVA: 0x0059124B File Offset: 0x0058F44B
		public static VectorOffset CreateEventCallbacksVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06028BAD RID: 166829 RVA: 0x00591264 File Offset: 0x0058F464
		public static void StartEventCallbacksVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06028BAE RID: 166830 RVA: 0x0059126F File Offset: 0x0058F46F
		public static Offset<ISceneItemSequenceEventData> EndISceneItemSequenceEventData(FlatBufferBuilder builder)
		{
			return new Offset<ISceneItemSequenceEventData>(builder.EndTable());
		}

		// Token: 0x06028BAF RID: 166831 RVA: 0x0059127C File Offset: 0x0058F47C
		public ISceneItemSequenceEventDataT UnPack()
		{
			ISceneItemSequenceEventDataT sceneItemSequenceEventDataT = new ISceneItemSequenceEventDataT();
			this.UnPackTo(sceneItemSequenceEventDataT);
			return sceneItemSequenceEventDataT;
		}

		// Token: 0x06028BB0 RID: 166832 RVA: 0x00591298 File Offset: 0x0058F498
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

		// Token: 0x06028BB1 RID: 166833 RVA: 0x00591378 File Offset: 0x0058F578
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

		// Token: 0x0400FB4B RID: 64331
		private Table __p;
	}
}
