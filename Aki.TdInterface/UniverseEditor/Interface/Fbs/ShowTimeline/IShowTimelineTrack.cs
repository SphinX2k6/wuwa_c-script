using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FD9 RID: 16345
	public struct IShowTimelineTrack : IFlatbufferObject
	{
		// Token: 0x17006EBC RID: 28348
		// (get) Token: 0x060165B7 RID: 91575 RVA: 0x00333D16 File Offset: 0x00331F16
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060165B8 RID: 91576 RVA: 0x00333D23 File Offset: 0x00331F23
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060165B9 RID: 91577 RVA: 0x00333D2C File Offset: 0x00331F2C
		public static IShowTimelineTrack GetRootAsIShowTimelineTrack(ByteBuffer _bb)
		{
			return IShowTimelineTrack.GetRootAsIShowTimelineTrack(_bb, default(IShowTimelineTrack));
		}

		// Token: 0x060165BA RID: 91578 RVA: 0x00333D48 File Offset: 0x00331F48
		public static IShowTimelineTrack GetRootAsIShowTimelineTrack(ByteBuffer _bb, IShowTimelineTrack obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060165BB RID: 91579 RVA: 0x00333D65 File Offset: 0x00331F65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060165BC RID: 91580 RVA: 0x00333D74 File Offset: 0x00331F74
		public IShowTimelineTrack __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x060165BD RID: 91581 RVA: 0x00333D84 File Offset: 0x00331F84
		public IShowTimelineFrame? Frames(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IShowTimelineFrame?(default(IShowTimelineFrame).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006EBD RID: 28349
		// (get) Token: 0x060165BE RID: 91582 RVA: 0x00333DE4 File Offset: 0x00331FE4
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

		// Token: 0x060165BF RID: 91583 RVA: 0x00333E0F File Offset: 0x0033200F
		public static Offset<IShowTimelineTrack> CreateIShowTimelineTrack(FlatBufferBuilder builder, VectorOffset FramesOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IShowTimelineTrack.AddFrames(builder, FramesOffset);
			return IShowTimelineTrack.EndIShowTimelineTrack(builder);
		}

		// Token: 0x060165C0 RID: 91584 RVA: 0x00333E25 File Offset: 0x00332025
		public static void StartIShowTimelineTrack(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060165C1 RID: 91585 RVA: 0x00333E2E File Offset: 0x0033202E
		public static void AddFrames(FlatBufferBuilder builder, VectorOffset framesOffset)
		{
			builder.AddOffset(0, framesOffset.Value, 0);
		}

		// Token: 0x060165C2 RID: 91586 RVA: 0x00333E40 File Offset: 0x00332040
		public static VectorOffset CreateFramesVector(FlatBufferBuilder builder, Offset<IShowTimelineFrame>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060165C3 RID: 91587 RVA: 0x00333E80 File Offset: 0x00332080
		public static VectorOffset CreateFramesVectorBlock(FlatBufferBuilder builder, Offset<IShowTimelineFrame>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IShowTimelineFrame>>(data);
			return builder.EndVector();
		}

		// Token: 0x060165C4 RID: 91588 RVA: 0x00333E9A File Offset: 0x0033209A
		public static VectorOffset CreateFramesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IShowTimelineFrame>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IShowTimelineFrame>>(data);
			return builder.EndVector();
		}

		// Token: 0x060165C5 RID: 91589 RVA: 0x00333EB8 File Offset: 0x003320B8
		public static VectorOffset CreateFramesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IShowTimelineFrame>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060165C6 RID: 91590 RVA: 0x00333ED1 File Offset: 0x003320D1
		public static void StartFramesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060165C7 RID: 91591 RVA: 0x00333EDC File Offset: 0x003320DC
		public static Offset<IShowTimelineTrack> EndIShowTimelineTrack(FlatBufferBuilder builder)
		{
			return new Offset<IShowTimelineTrack>(builder.EndTable());
		}

		// Token: 0x060165C8 RID: 91592 RVA: 0x00333EEC File Offset: 0x003320EC
		public IShowTimelineTrackT UnPack()
		{
			IShowTimelineTrackT showTimelineTrackT = new IShowTimelineTrackT();
			this.UnPackTo(showTimelineTrackT);
			return showTimelineTrackT;
		}

		// Token: 0x060165C9 RID: 91593 RVA: 0x00333F08 File Offset: 0x00332108
		public void UnPackTo(IShowTimelineTrackT _o)
		{
			_o.Frames = new List<IShowTimelineFrameT>();
			for (int i = 0; i < this.FramesLength; i++)
			{
				_o.Frames.Add((this.Frames(i) != null) ? this.Frames(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060165CA RID: 91594 RVA: 0x00333F68 File Offset: 0x00332168
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

		// Token: 0x0400BAE1 RID: 47841
		private Table __p;
	}
}
