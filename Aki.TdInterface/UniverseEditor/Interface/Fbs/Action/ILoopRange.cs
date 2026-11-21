using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007184 RID: 29060
	public struct ILoopRange : IFlatbufferObject
	{
		// Token: 0x1700D4B4 RID: 54452
		// (get) Token: 0x06032838 RID: 206904 RVA: 0x006D39F4 File Offset: 0x006D1BF4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032839 RID: 206905 RVA: 0x006D3A01 File Offset: 0x006D1C01
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603283A RID: 206906 RVA: 0x006D3A08 File Offset: 0x006D1C08
		public static ILoopRange GetRootAsILoopRange(ByteBuffer _bb)
		{
			return ILoopRange.GetRootAsILoopRange(_bb, default(ILoopRange));
		}

		// Token: 0x0603283B RID: 206907 RVA: 0x006D3A24 File Offset: 0x006D1C24
		public static ILoopRange GetRootAsILoopRange(ByteBuffer _bb, ILoopRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603283C RID: 206908 RVA: 0x006D3A41 File Offset: 0x006D1C41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603283D RID: 206909 RVA: 0x006D3A50 File Offset: 0x006D1C50
		public ILoopRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D4B5 RID: 54453
		// (get) Token: 0x0603283E RID: 206910 RVA: 0x006D3A60 File Offset: 0x006D1C60
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

		// Token: 0x0603283F RID: 206911 RVA: 0x006D3A97 File Offset: 0x006D1C97
		public Span<byte> GetLeftMarkBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06032840 RID: 206912 RVA: 0x006D3AA6 File Offset: 0x006D1CA6
		public byte[] GetLeftMarkArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700D4B6 RID: 54454
		// (get) Token: 0x06032841 RID: 206913 RVA: 0x006D3AB4 File Offset: 0x006D1CB4
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

		// Token: 0x06032842 RID: 206914 RVA: 0x006D3AEB File Offset: 0x006D1CEB
		public Span<byte> GetRightMarkBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06032843 RID: 206915 RVA: 0x006D3AFA File Offset: 0x006D1CFA
		public byte[] GetRightMarkArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06032844 RID: 206916 RVA: 0x006D3B08 File Offset: 0x006D1D08
		public static Offset<ILoopRange> CreateILoopRange(FlatBufferBuilder builder, StringOffset LeftMarkOffset = default(StringOffset), StringOffset RightMarkOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ILoopRange.AddRightMark(builder, RightMarkOffset);
			ILoopRange.AddLeftMark(builder, LeftMarkOffset);
			return ILoopRange.EndILoopRange(builder);
		}

		// Token: 0x06032845 RID: 206917 RVA: 0x006D3B25 File Offset: 0x006D1D25
		public static void StartILoopRange(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06032846 RID: 206918 RVA: 0x006D3B2E File Offset: 0x006D1D2E
		public static void AddLeftMark(FlatBufferBuilder builder, StringOffset leftMarkOffset)
		{
			builder.AddOffset(0, leftMarkOffset.Value, 0);
		}

		// Token: 0x06032847 RID: 206919 RVA: 0x006D3B3E File Offset: 0x006D1D3E
		public static void AddRightMark(FlatBufferBuilder builder, StringOffset rightMarkOffset)
		{
			builder.AddOffset(1, rightMarkOffset.Value, 0);
		}

		// Token: 0x06032848 RID: 206920 RVA: 0x006D3B4E File Offset: 0x006D1D4E
		public static Offset<ILoopRange> EndILoopRange(FlatBufferBuilder builder)
		{
			return new Offset<ILoopRange>(builder.EndTable());
		}

		// Token: 0x06032849 RID: 206921 RVA: 0x006D3B5C File Offset: 0x006D1D5C
		public ILoopRangeT UnPack()
		{
			ILoopRangeT loopRangeT = new ILoopRangeT();
			this.UnPackTo(loopRangeT);
			return loopRangeT;
		}

		// Token: 0x0603284A RID: 206922 RVA: 0x006D3B77 File Offset: 0x006D1D77
		public void UnPackTo(ILoopRangeT _o)
		{
			_o.LeftMark = this.LeftMark;
			_o.RightMark = this.RightMark;
		}

		// Token: 0x0603284B RID: 206923 RVA: 0x006D3B94 File Offset: 0x006D1D94
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

		// Token: 0x0401217B RID: 74107
		private Table __p;
	}
}
