using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005900 RID: 22784
	public struct ISequenceTrackControlPoint : IFlatbufferObject
	{
		// Token: 0x1700AAC7 RID: 43719
		// (get) Token: 0x0602680A RID: 157706 RVA: 0x0054E1E7 File Offset: 0x0054C3E7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602680B RID: 157707 RVA: 0x0054E1F4 File Offset: 0x0054C3F4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602680C RID: 157708 RVA: 0x0054E1FC File Offset: 0x0054C3FC
		public static ISequenceTrackControlPoint GetRootAsISequenceTrackControlPoint(ByteBuffer _bb)
		{
			return ISequenceTrackControlPoint.GetRootAsISequenceTrackControlPoint(_bb, default(ISequenceTrackControlPoint));
		}

		// Token: 0x0602680D RID: 157709 RVA: 0x0054E218 File Offset: 0x0054C418
		public static ISequenceTrackControlPoint GetRootAsISequenceTrackControlPoint(ByteBuffer _bb, ISequenceTrackControlPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602680E RID: 157710 RVA: 0x0054E235 File Offset: 0x0054C435
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602680F RID: 157711 RVA: 0x0054E244 File Offset: 0x0054C444
		public ISequenceTrackControlPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AAC8 RID: 43720
		// (get) Token: 0x06026810 RID: 157712 RVA: 0x0054E254 File Offset: 0x0054C454
		public string Mark
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

		// Token: 0x06026811 RID: 157713 RVA: 0x0054E28B File Offset: 0x0054C48B
		public Span<byte> GetMarkBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06026812 RID: 157714 RVA: 0x0054E29A File Offset: 0x0054C49A
		public byte[] GetMarkArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06026813 RID: 157715 RVA: 0x0054E2A8 File Offset: 0x0054C4A8
		public static Offset<ISequenceTrackControlPoint> CreateISequenceTrackControlPoint(FlatBufferBuilder builder, StringOffset MarkOffset = default(StringOffset))
		{
			builder.StartTable(1);
			ISequenceTrackControlPoint.AddMark(builder, MarkOffset);
			return ISequenceTrackControlPoint.EndISequenceTrackControlPoint(builder);
		}

		// Token: 0x06026814 RID: 157716 RVA: 0x0054E2BE File Offset: 0x0054C4BE
		public static void StartISequenceTrackControlPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06026815 RID: 157717 RVA: 0x0054E2C7 File Offset: 0x0054C4C7
		public static void AddMark(FlatBufferBuilder builder, StringOffset markOffset)
		{
			builder.AddOffset(0, markOffset.Value, 0);
		}

		// Token: 0x06026816 RID: 157718 RVA: 0x0054E2D7 File Offset: 0x0054C4D7
		public static Offset<ISequenceTrackControlPoint> EndISequenceTrackControlPoint(FlatBufferBuilder builder)
		{
			return new Offset<ISequenceTrackControlPoint>(builder.EndTable());
		}

		// Token: 0x06026817 RID: 157719 RVA: 0x0054E2E4 File Offset: 0x0054C4E4
		public ISequenceTrackControlPointT UnPack()
		{
			ISequenceTrackControlPointT sequenceTrackControlPointT = new ISequenceTrackControlPointT();
			this.UnPackTo(sequenceTrackControlPointT);
			return sequenceTrackControlPointT;
		}

		// Token: 0x06026818 RID: 157720 RVA: 0x0054E2FF File Offset: 0x0054C4FF
		public void UnPackTo(ISequenceTrackControlPointT _o)
		{
			_o.Mark = this.Mark;
		}

		// Token: 0x06026819 RID: 157721 RVA: 0x0054E310 File Offset: 0x0054C510
		public static Offset<ISequenceTrackControlPoint> Pack(FlatBufferBuilder builder, ISequenceTrackControlPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISequenceTrackControlPoint>);
			}
			StringOffset markOffset = (_o.Mark == null) ? default(StringOffset) : builder.CreateString(_o.Mark);
			return ISequenceTrackControlPoint.CreateISequenceTrackControlPoint(builder, markOffset);
		}

		// Token: 0x0400EEA0 RID: 61088
		private Table __p;
	}
}
