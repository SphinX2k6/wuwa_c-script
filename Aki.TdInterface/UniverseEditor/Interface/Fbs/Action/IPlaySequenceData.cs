using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D3E RID: 27966
	public struct IPlaySequenceData : IFlatbufferObject
	{
		// Token: 0x1700D081 RID: 53377
		// (get) Token: 0x060315D1 RID: 202193 RVA: 0x006B1DF8 File Offset: 0x006AFFF8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060315D2 RID: 202194 RVA: 0x006B1E05 File Offset: 0x006B0005
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060315D3 RID: 202195 RVA: 0x006B1E0C File Offset: 0x006B000C
		public static IPlaySequenceData GetRootAsIPlaySequenceData(ByteBuffer _bb)
		{
			return IPlaySequenceData.GetRootAsIPlaySequenceData(_bb, default(IPlaySequenceData));
		}

		// Token: 0x060315D4 RID: 202196 RVA: 0x006B1E28 File Offset: 0x006B0028
		public static IPlaySequenceData GetRootAsIPlaySequenceData(ByteBuffer _bb, IPlaySequenceData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060315D5 RID: 202197 RVA: 0x006B1E45 File Offset: 0x006B0045
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060315D6 RID: 202198 RVA: 0x006B1E54 File Offset: 0x006B0054
		public IPlaySequenceData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D082 RID: 53378
		// (get) Token: 0x060315D7 RID: 202199 RVA: 0x006B1E64 File Offset: 0x006B0064
		public string Path
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

		// Token: 0x060315D8 RID: 202200 RVA: 0x006B1E9B File Offset: 0x006B009B
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060315D9 RID: 202201 RVA: 0x006B1EAA File Offset: 0x006B00AA
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700D083 RID: 53379
		// (get) Token: 0x060315DA RID: 202202 RVA: 0x006B1EB8 File Offset: 0x006B00B8
		public bool ResetCamera
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D084 RID: 53380
		// (get) Token: 0x060315DB RID: 202203 RVA: 0x006B1EF8 File Offset: 0x006B00F8
		public bool KeepCamera
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D085 RID: 53381
		// (get) Token: 0x060315DC RID: 202204 RVA: 0x006B1F38 File Offset: 0x006B0138
		public bool PreLoadRenderAssets
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060315DD RID: 202205 RVA: 0x006B1F78 File Offset: 0x006B0178
		public ISequenceFrameEvent? FrameEvents(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new ISequenceFrameEvent?(default(ISequenceFrameEvent).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D086 RID: 53382
		// (get) Token: 0x060315DE RID: 202206 RVA: 0x006B1FDC File Offset: 0x006B01DC
		public int FrameEventsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700D087 RID: 53383
		// (get) Token: 0x060315DF RID: 202207 RVA: 0x006B2008 File Offset: 0x006B0208
		public bool SaveFinalPos
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D088 RID: 53384
		// (get) Token: 0x060315E0 RID: 202208 RVA: 0x006B2048 File Offset: 0x006B0248
		public ISetBlendAnim? SeqBlendAnim
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new ISetBlendAnim?(default(ISetBlendAnim).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D089 RID: 53385
		// (get) Token: 0x060315E1 RID: 202209 RVA: 0x006B20A8 File Offset: 0x006B02A8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060315E2 RID: 202210 RVA: 0x006B20E8 File Offset: 0x006B02E8
		public static Offset<IPlaySequenceData> CreateIPlaySequenceData(FlatBufferBuilder builder, StringOffset PathOffset = default(StringOffset), bool ResetCamera = false, bool KeepCamera = false, bool PreLoadRenderAssets = false, VectorOffset FrameEventsOffset = default(VectorOffset), bool SaveFinalPos = false, Offset<ISetBlendAnim> SeqBlendAnimOffset = default(Offset<ISetBlendAnim>), byte NullMask = 0)
		{
			builder.StartTable(8);
			IPlaySequenceData.AddSeqBlendAnim(builder, SeqBlendAnimOffset);
			IPlaySequenceData.AddFrameEvents(builder, FrameEventsOffset);
			IPlaySequenceData.AddPath(builder, PathOffset);
			IPlaySequenceData.AddNullMask(builder, NullMask);
			IPlaySequenceData.AddSaveFinalPos(builder, SaveFinalPos);
			IPlaySequenceData.AddPreLoadRenderAssets(builder, PreLoadRenderAssets);
			IPlaySequenceData.AddKeepCamera(builder, KeepCamera);
			IPlaySequenceData.AddResetCamera(builder, ResetCamera);
			return IPlaySequenceData.EndIPlaySequenceData(builder);
		}

		// Token: 0x060315E3 RID: 202211 RVA: 0x006B213F File Offset: 0x006B033F
		public static void StartIPlaySequenceData(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x060315E4 RID: 202212 RVA: 0x006B2148 File Offset: 0x006B0348
		public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset)
		{
			builder.AddOffset(0, pathOffset.Value, 0);
		}

		// Token: 0x060315E5 RID: 202213 RVA: 0x006B2158 File Offset: 0x006B0358
		public static void AddResetCamera(FlatBufferBuilder builder, bool resetCamera)
		{
			builder.AddBool(1, resetCamera, false);
		}

		// Token: 0x060315E6 RID: 202214 RVA: 0x006B2163 File Offset: 0x006B0363
		public static void AddKeepCamera(FlatBufferBuilder builder, bool keepCamera)
		{
			builder.AddBool(2, keepCamera, false);
		}

		// Token: 0x060315E7 RID: 202215 RVA: 0x006B216E File Offset: 0x006B036E
		public static void AddPreLoadRenderAssets(FlatBufferBuilder builder, bool preLoadRenderAssets)
		{
			builder.AddBool(3, preLoadRenderAssets, false);
		}

		// Token: 0x060315E8 RID: 202216 RVA: 0x006B2179 File Offset: 0x006B0379
		public static void AddFrameEvents(FlatBufferBuilder builder, VectorOffset frameEventsOffset)
		{
			builder.AddOffset(4, frameEventsOffset.Value, 0);
		}

		// Token: 0x060315E9 RID: 202217 RVA: 0x006B218C File Offset: 0x006B038C
		public static VectorOffset CreateFrameEventsVector(FlatBufferBuilder builder, Offset<ISequenceFrameEvent>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060315EA RID: 202218 RVA: 0x006B21CC File Offset: 0x006B03CC
		public static VectorOffset CreateFrameEventsVectorBlock(FlatBufferBuilder builder, Offset<ISequenceFrameEvent>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISequenceFrameEvent>>(data);
			return builder.EndVector();
		}

		// Token: 0x060315EB RID: 202219 RVA: 0x006B21E6 File Offset: 0x006B03E6
		public static VectorOffset CreateFrameEventsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISequenceFrameEvent>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISequenceFrameEvent>>(data);
			return builder.EndVector();
		}

		// Token: 0x060315EC RID: 202220 RVA: 0x006B2204 File Offset: 0x006B0404
		public static VectorOffset CreateFrameEventsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISequenceFrameEvent>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060315ED RID: 202221 RVA: 0x006B221D File Offset: 0x006B041D
		public static void StartFrameEventsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060315EE RID: 202222 RVA: 0x006B2228 File Offset: 0x006B0428
		public static void AddSaveFinalPos(FlatBufferBuilder builder, bool saveFinalPos)
		{
			builder.AddBool(5, saveFinalPos, false);
		}

		// Token: 0x060315EF RID: 202223 RVA: 0x006B2233 File Offset: 0x006B0433
		public static void AddSeqBlendAnim(FlatBufferBuilder builder, Offset<ISetBlendAnim> seqBlendAnimOffset)
		{
			builder.AddOffset(6, seqBlendAnimOffset.Value, 0);
		}

		// Token: 0x060315F0 RID: 202224 RVA: 0x006B2243 File Offset: 0x006B0443
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x060315F1 RID: 202225 RVA: 0x006B224E File Offset: 0x006B044E
		public static Offset<IPlaySequenceData> EndIPlaySequenceData(FlatBufferBuilder builder)
		{
			return new Offset<IPlaySequenceData>(builder.EndTable());
		}

		// Token: 0x060315F2 RID: 202226 RVA: 0x006B225C File Offset: 0x006B045C
		public IPlaySequenceDataT UnPack()
		{
			IPlaySequenceDataT playSequenceDataT = new IPlaySequenceDataT();
			this.UnPackTo(playSequenceDataT);
			return playSequenceDataT;
		}

		// Token: 0x060315F3 RID: 202227 RVA: 0x006B2278 File Offset: 0x006B0478
		public void UnPackTo(IPlaySequenceDataT _o)
		{
			_o.Path = this.Path;
			_o.ResetCamera = this.ResetCamera;
			_o.KeepCamera = this.KeepCamera;
			_o.PreLoadRenderAssets = this.PreLoadRenderAssets;
			_o.FrameEvents = new List<ISequenceFrameEventT>();
			for (int i = 0; i < this.FrameEventsLength; i++)
			{
				_o.FrameEvents.Add((this.FrameEvents(i) != null) ? this.FrameEvents(i).Value.UnPack() : null);
			}
			_o.SaveFinalPos = this.SaveFinalPos;
			_o.SeqBlendAnim = ((this.SeqBlendAnim != null) ? this.SeqBlendAnim.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060315F4 RID: 202228 RVA: 0x006B2350 File Offset: 0x006B0550
		public static Offset<IPlaySequenceData> Pack(FlatBufferBuilder builder, IPlaySequenceDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlaySequenceData>);
			}
			StringOffset pathOffset = (_o.Path == null) ? default(StringOffset) : builder.CreateString(_o.Path);
			VectorOffset frameEventsOffset = default(VectorOffset);
			if (_o.FrameEvents != null)
			{
				Offset<ISequenceFrameEvent>[] array = new Offset<ISequenceFrameEvent>[_o.FrameEvents.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ISequenceFrameEvent.Pack(builder, _o.FrameEvents[i]);
				}
				frameEventsOffset = IPlaySequenceData.CreateFrameEventsVector(builder, array);
			}
			Offset<ISetBlendAnim> seqBlendAnimOffset = (_o.SeqBlendAnim == null) ? default(Offset<ISetBlendAnim>) : ISetBlendAnim.Pack(builder, _o.SeqBlendAnim);
			return IPlaySequenceData.CreateIPlaySequenceData(builder, pathOffset, _o.ResetCamera, _o.KeepCamera, _o.PreLoadRenderAssets, frameEventsOffset, _o.SaveFinalPos, seqBlendAnimOffset, _o.NullMask);
		}

		// Token: 0x040116E5 RID: 71397
		private Table __p;
	}
}
