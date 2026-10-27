using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003BCE RID: 15310
	public struct IShowTimelineTrack : IFlatbufferObject
	{
		// Token: 0x17006914 RID: 26900
		// (get) Token: 0x060150C1 RID: 86209 RVA: 0x0030D18E File Offset: 0x0030B38E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060150C2 RID: 86210 RVA: 0x0030D19B File Offset: 0x0030B39B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060150C3 RID: 86211 RVA: 0x0030D1A4 File Offset: 0x0030B3A4
		public static IShowTimelineTrack GetRootAsIShowTimelineTrack(ByteBuffer _bb)
		{
			return IShowTimelineTrack.GetRootAsIShowTimelineTrack(_bb, default(IShowTimelineTrack));
		}

		// Token: 0x060150C4 RID: 86212 RVA: 0x0030D1C0 File Offset: 0x0030B3C0
		public static IShowTimelineTrack GetRootAsIShowTimelineTrack(ByteBuffer _bb, IShowTimelineTrack obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060150C5 RID: 86213 RVA: 0x0030D1DD File Offset: 0x0030B3DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060150C6 RID: 86214 RVA: 0x0030D1EC File Offset: 0x0030B3EC
		public IShowTimelineTrack __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x060150C7 RID: 86215 RVA: 0x0030D1FC File Offset: 0x0030B3FC
		public IShowTimelineFrame? Frames(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IShowTimelineFrame?(default(IShowTimelineFrame).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006915 RID: 26901
		// (get) Token: 0x060150C8 RID: 86216 RVA: 0x0030D25C File Offset: 0x0030B45C
		public int FramesLength
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

		// Token: 0x060150C9 RID: 86217 RVA: 0x0030D287 File Offset: 0x0030B487
		public static Offset<IShowTimelineTrack> CreateIShowTimelineTrack(FlatBufferBuilder builder, VectorOffset FramesOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IShowTimelineTrack.AddFrames(builder, FramesOffset);
			return IShowTimelineTrack.EndIShowTimelineTrack(builder);
		}

		// Token: 0x060150CA RID: 86218 RVA: 0x0030D29D File Offset: 0x0030B49D
		public static void StartIShowTimelineTrack(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060150CB RID: 86219 RVA: 0x0030D2A6 File Offset: 0x0030B4A6
		public static void AddFrames(FlatBufferBuilder builder, VectorOffset framesOffset)
		{
			builder.AddOffset(0, framesOffset.Value, 0);
		}

		// Token: 0x060150CC RID: 86220 RVA: 0x0030D2B8 File Offset: 0x0030B4B8
		public static VectorOffset CreateFramesVector(FlatBufferBuilder builder, Offset<IShowTimelineFrame>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060150CD RID: 86221 RVA: 0x0030D2F8 File Offset: 0x0030B4F8
		public static VectorOffset CreateFramesVectorBlock(FlatBufferBuilder builder, Offset<IShowTimelineFrame>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IShowTimelineFrame>>(data);
			return builder.EndVector();
		}

		// Token: 0x060150CE RID: 86222 RVA: 0x0030D312 File Offset: 0x0030B512
		public static VectorOffset CreateFramesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IShowTimelineFrame>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IShowTimelineFrame>>(data);
			return builder.EndVector();
		}

		// Token: 0x060150CF RID: 86223 RVA: 0x0030D330 File Offset: 0x0030B530
		public static VectorOffset CreateFramesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IShowTimelineFrame>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060150D0 RID: 86224 RVA: 0x0030D349 File Offset: 0x0030B549
		public static void StartFramesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060150D1 RID: 86225 RVA: 0x0030D354 File Offset: 0x0030B554
		public static Offset<IShowTimelineTrack> EndIShowTimelineTrack(FlatBufferBuilder builder)
		{
			return new Offset<IShowTimelineTrack>(builder.EndTable());
		}

		// Token: 0x060150D2 RID: 86226 RVA: 0x0030D364 File Offset: 0x0030B564
		public IShowTimelineTrackT UnPack()
		{
			IShowTimelineTrackT showTimelineTrackT = new IShowTimelineTrackT();
			this.UnPackTo(showTimelineTrackT);
			return showTimelineTrackT;
		}

		// Token: 0x060150D3 RID: 86227 RVA: 0x0030D380 File Offset: 0x0030B580
		public void UnPackTo(IShowTimelineTrackT _o)
		{
			_o.Frames = new List<IShowTimelineFrameT>();
			for (int i = 0; i < this.FramesLength; i++)
			{
				_o.Frames.Add((this.Frames(i) != null) ? this.Frames(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060150D4 RID: 86228 RVA: 0x0030D3E0 File Offset: 0x0030B5E0
		public static Offset<IShowTimelineTrack> Pack(FlatBufferBuilder builder, IShowTimelineTrackT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowTimelineTrack>);
			}
			VectorOffset framesOffset = default(VectorOffset);
			if (_o.Frames != null)
			{
				Offset<IShowTimelineFrame>[] array = new Offset<IShowTimelineFrame>[_o.Frames.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IShowTimelineFrame.Pack(builder, _o.Frames[i]);
				}
				framesOffset = IShowTimelineTrack.CreateFramesVector(builder, array);
			}
			return IShowTimelineTrack.CreateIShowTimelineTrack(builder, framesOffset);
		}

		// Token: 0x0400B15F RID: 45407
		private Table __p;
	}
}
