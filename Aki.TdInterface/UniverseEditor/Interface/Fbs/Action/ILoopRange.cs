using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A62 RID: 27234
	public struct ILoopRange : IFlatbufferObject
	{
		// Token: 0x1700CA09 RID: 51721
		// (get) Token: 0x0602FB12 RID: 195346 RVA: 0x0067D934 File Offset: 0x0067BB34
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FB13 RID: 195347 RVA: 0x0067D941 File Offset: 0x0067BB41
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FB14 RID: 195348 RVA: 0x0067D948 File Offset: 0x0067BB48
		public static ILoopRange GetRootAsILoopRange(ByteBuffer _bb)
		{
			return ILoopRange.GetRootAsILoopRange(_bb, default(ILoopRange));
		}

		// Token: 0x0602FB15 RID: 195349 RVA: 0x0067D964 File Offset: 0x0067BB64
		public static ILoopRange GetRootAsILoopRange(ByteBuffer _bb, ILoopRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FB16 RID: 195350 RVA: 0x0067D981 File Offset: 0x0067BB81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FB17 RID: 195351 RVA: 0x0067D990 File Offset: 0x0067BB90
		public ILoopRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA0A RID: 51722
		// (get) Token: 0x0602FB18 RID: 195352 RVA: 0x0067D9A0 File Offset: 0x0067BBA0
		public string LeftMark
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

		// Token: 0x0602FB19 RID: 195353 RVA: 0x0067D9D7 File Offset: 0x0067BBD7
		public Span<byte> GetLeftMarkBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602FB1A RID: 195354 RVA: 0x0067D9E6 File Offset: 0x0067BBE6
		public byte[] GetLeftMarkArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700CA0B RID: 51723
		// (get) Token: 0x0602FB1B RID: 195355 RVA: 0x0067D9F4 File Offset: 0x0067BBF4
		public string RightMark
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

		// Token: 0x0602FB1C RID: 195356 RVA: 0x0067DA2B File Offset: 0x0067BC2B
		public Span<byte> GetRightMarkBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602FB1D RID: 195357 RVA: 0x0067DA3A File Offset: 0x0067BC3A
		public byte[] GetRightMarkArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602FB1E RID: 195358 RVA: 0x0067DA48 File Offset: 0x0067BC48
		public static Offset<ILoopRange> CreateILoopRange(FlatBufferBuilder builder, StringOffset LeftMarkOffset = default(StringOffset), StringOffset RightMarkOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ILoopRange.AddRightMark(builder, RightMarkOffset);
			ILoopRange.AddLeftMark(builder, LeftMarkOffset);
			return ILoopRange.EndILoopRange(builder);
		}

		// Token: 0x0602FB1F RID: 195359 RVA: 0x0067DA65 File Offset: 0x0067BC65
		public static void StartILoopRange(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602FB20 RID: 195360 RVA: 0x0067DA6E File Offset: 0x0067BC6E
		public static void AddLeftMark(FlatBufferBuilder builder, StringOffset leftMarkOffset)
		{
			builder.AddOffset(0, leftMarkOffset.Value, 0);
		}

		// Token: 0x0602FB21 RID: 195361 RVA: 0x0067DA7E File Offset: 0x0067BC7E
		public static void AddRightMark(FlatBufferBuilder builder, StringOffset rightMarkOffset)
		{
			builder.AddOffset(1, rightMarkOffset.Value, 0);
		}

		// Token: 0x0602FB22 RID: 195362 RVA: 0x0067DA8E File Offset: 0x0067BC8E
		public static Offset<ILoopRange> EndILoopRange(FlatBufferBuilder builder)
		{
			return new Offset<ILoopRange>(builder.EndTable());
		}

		// Token: 0x0602FB23 RID: 195363 RVA: 0x0067DA9C File Offset: 0x0067BC9C
		public ILoopRangeT UnPack()
		{
			ILoopRangeT loopRangeT = new ILoopRangeT();
			this.UnPackTo(loopRangeT);
			return loopRangeT;
		}

		// Token: 0x0602FB24 RID: 195364 RVA: 0x0067DAB7 File Offset: 0x0067BCB7
		public void UnPackTo(ILoopRangeT _o)
		{
			_o.LeftMark = this.LeftMark;
			_o.RightMark = this.RightMark;
		}

		// Token: 0x0602FB25 RID: 195365 RVA: 0x0067DAD4 File Offset: 0x0067BCD4
		public static Offset<ILoopRange> Pack(FlatBufferBuilder builder, ILoopRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILoopRange>);
			}
			StringOffset leftMarkOffset = (_o.LeftMark == null) ? default(StringOffset) : builder.CreateString(_o.LeftMark);
			StringOffset rightMarkOffset = (_o.RightMark == null) ? default(StringOffset) : builder.CreateString(_o.RightMark);
			return ILoopRange.CreateILoopRange(builder, leftMarkOffset, rightMarkOffset);
		}

		// Token: 0x04011283 RID: 70275
		private Table __p;
	}
}
