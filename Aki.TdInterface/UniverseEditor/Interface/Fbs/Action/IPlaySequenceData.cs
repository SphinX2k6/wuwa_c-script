using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074B9 RID: 29881
	public struct IPlaySequenceData : IFlatbufferObject
	{
		// Token: 0x1700DBC9 RID: 56265
		// (get) Token: 0x060345CD RID: 214477 RVA: 0x0070D4E0 File Offset: 0x0070B6E0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060345CE RID: 214478 RVA: 0x0070D4ED File Offset: 0x0070B6ED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060345CF RID: 214479 RVA: 0x0070D4F4 File Offset: 0x0070B6F4
		public static IPlaySequenceData GetRootAsIPlaySequenceData(ByteBuffer _bb)
		{
			return IPlaySequenceData.GetRootAsIPlaySequenceData(_bb, default(IPlaySequenceData));
		}

		// Token: 0x060345D0 RID: 214480 RVA: 0x0070D510 File Offset: 0x0070B710
		public static IPlaySequenceData GetRootAsIPlaySequenceData(ByteBuffer _bb, IPlaySequenceData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060345D1 RID: 214481 RVA: 0x0070D52D File Offset: 0x0070B72D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060345D2 RID: 214482 RVA: 0x0070D53C File Offset: 0x0070B73C
		public IPlaySequenceData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DBCA RID: 56266
		// (get) Token: 0x060345D3 RID: 214483 RVA: 0x0070D54C File Offset: 0x0070B74C
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

		// Token: 0x060345D4 RID: 214484 RVA: 0x0070D583 File Offset: 0x0070B783
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060345D5 RID: 214485 RVA: 0x0070D592 File Offset: 0x0070B792
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700DBCB RID: 56267
		// (get) Token: 0x060345D6 RID: 214486 RVA: 0x0070D5A0 File Offset: 0x0070B7A0
		public bool ResetCamera
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DBCC RID: 56268
		// (get) Token: 0x060345D7 RID: 214487 RVA: 0x0070D5E0 File Offset: 0x0070B7E0
		public bool KeepCamera
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DBCD RID: 56269
		// (get) Token: 0x060345D8 RID: 214488 RVA: 0x0070D620 File Offset: 0x0070B820
		public bool PreLoadRenderAssets
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060345D9 RID: 214489 RVA: 0x0070D660 File Offset: 0x0070B860
		public ISequenceFrameEvent? FrameEvents(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new ISequenceFrameEvent?(default(ISequenceFrameEvent).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DBCE RID: 56270
		// (get) Token: 0x060345DA RID: 214490 RVA: 0x0070D6C4 File Offset: 0x0070B8C4
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

		// Token: 0x1700DBCF RID: 56271
		// (get) Token: 0x060345DB RID: 214491 RVA: 0x0070D6F0 File Offset: 0x0070B8F0
		public bool SaveFinalPos
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DBD0 RID: 56272
		// (get) Token: 0x060345DC RID: 214492 RVA: 0x0070D730 File Offset: 0x0070B930
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

		// Token: 0x1700DBD1 RID: 56273
		// (get) Token: 0x060345DD RID: 214493 RVA: 0x0070D790 File Offset: 0x0070B990
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

		// Token: 0x060345DE RID: 214494 RVA: 0x0070D7D0 File Offset: 0x0070B9D0
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

		// Token: 0x060345DF RID: 214495 RVA: 0x0070D827 File Offset: 0x0070BA27
		public static void StartIPlaySequenceData(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x060345E0 RID: 214496 RVA: 0x0070D830 File Offset: 0x0070BA30
		public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset)
		{
			builder.AddOffset(0, pathOffset.Value, 0);
		}

		// Token: 0x060345E1 RID: 214497 RVA: 0x0070D840 File Offset: 0x0070BA40
		public static void AddResetCamera(FlatBufferBuilder builder, bool resetCamera)
		{
			builder.AddBool(1, resetCamera, false);
		}

		// Token: 0x060345E2 RID: 214498 RVA: 0x0070D84B File Offset: 0x0070BA4B
		public static void AddKeepCamera(FlatBufferBuilder builder, bool keepCamera)
		{
			builder.AddBool(2, keepCamera, false);
		}

		// Token: 0x060345E3 RID: 214499 RVA: 0x0070D856 File Offset: 0x0070BA56
		public static void AddPreLoadRenderAssets(FlatBufferBuilder builder, bool preLoadRenderAssets)
		{
			builder.AddBool(3, preLoadRenderAssets, false);
		}

		// Token: 0x060345E4 RID: 214500 RVA: 0x0070D861 File Offset: 0x0070BA61
		public static void AddFrameEvents(FlatBufferBuilder builder, VectorOffset frameEventsOffset)
		{
			builder.AddOffset(4, frameEventsOffset.Value, 0);
		}

		// Token: 0x060345E5 RID: 214501 RVA: 0x0070D874 File Offset: 0x0070BA74
		public static VectorOffset CreateFrameEventsVector(FlatBufferBuilder builder, Offset<ISequenceFrameEvent>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060345E6 RID: 214502 RVA: 0x0070D8B4 File Offset: 0x0070BAB4
		public static VectorOffset CreateFrameEventsVectorBlock(FlatBufferBuilder builder, Offset<ISequenceFrameEvent>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISequenceFrameEvent>>(data);
			return builder.EndVector();
		}

		// Token: 0x060345E7 RID: 214503 RVA: 0x0070D8CE File Offset: 0x0070BACE
		public static VectorOffset CreateFrameEventsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISequenceFrameEvent>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISequenceFrameEvent>>(data);
			return builder.EndVector();
		}

		// Token: 0x060345E8 RID: 214504 RVA: 0x0070D8EC File Offset: 0x0070BAEC
		public static VectorOffset CreateFrameEventsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISequenceFrameEvent>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060345E9 RID: 214505 RVA: 0x0070D905 File Offset: 0x0070BB05
		public static void StartFrameEventsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060345EA RID: 214506 RVA: 0x0070D910 File Offset: 0x0070BB10
		public static void AddSaveFinalPos(FlatBufferBuilder builder, bool saveFinalPos)
		{
			builder.AddBool(5, saveFinalPos, false);
		}

		// Token: 0x060345EB RID: 214507 RVA: 0x0070D91B File Offset: 0x0070BB1B
		public static void AddSeqBlendAnim(FlatBufferBuilder builder, Offset<ISetBlendAnim> seqBlendAnimOffset)
		{
			builder.AddOffset(6, seqBlendAnimOffset.Value, 0);
		}

		// Token: 0x060345EC RID: 214508 RVA: 0x0070D92B File Offset: 0x0070BB2B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x060345ED RID: 214509 RVA: 0x0070D936 File Offset: 0x0070BB36
		public static Offset<IPlaySequenceData> EndIPlaySequenceData(FlatBufferBuilder builder)
		{
			return new Offset<IPlaySequenceData>(builder.EndTable());
		}

		// Token: 0x060345EE RID: 214510 RVA: 0x0070D944 File Offset: 0x0070BB44
		public IPlaySequenceDataT UnPack()
		{
			IPlaySequenceDataT playSequenceDataT = new IPlaySequenceDataT();
			this.UnPackTo(playSequenceDataT);
			return playSequenceDataT;
		}

		// Token: 0x060345EF RID: 214511 RVA: 0x0070D960 File Offset: 0x0070BB60
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

		// Token: 0x060345F0 RID: 214512 RVA: 0x0070DA38 File Offset: 0x0070BC38
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

		// Token: 0x04012661 RID: 75361
		private Table __p;
	}
}
