using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200634D RID: 25421
	public struct IAvgInterjection : IFlatbufferObject
	{
		// Token: 0x1700BBF2 RID: 48114
		// (get) Token: 0x0602B1C3 RID: 176579 RVA: 0x005E01F6 File Offset: 0x005DE3F6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B1C4 RID: 176580 RVA: 0x005E0203 File Offset: 0x005DE403
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B1C5 RID: 176581 RVA: 0x005E020C File Offset: 0x005DE40C
		public static IAvgInterjection GetRootAsIAvgInterjection(ByteBuffer _bb)
		{
			return IAvgInterjection.GetRootAsIAvgInterjection(_bb, default(IAvgInterjection));
		}

		// Token: 0x0602B1C6 RID: 176582 RVA: 0x005E0228 File Offset: 0x005DE428
		public static IAvgInterjection GetRootAsIAvgInterjection(ByteBuffer _bb, IAvgInterjection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B1C7 RID: 176583 RVA: 0x005E0245 File Offset: 0x005DE445
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B1C8 RID: 176584 RVA: 0x005E0254 File Offset: 0x005DE454
		public IAvgInterjection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BBF3 RID: 48115
		// (get) Token: 0x0602B1C9 RID: 176585 RVA: 0x005E0264 File Offset: 0x005DE464
		public string Word
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

		// Token: 0x0602B1CA RID: 176586 RVA: 0x005E029B File Offset: 0x005DE49B
		public Span<byte> GetWordBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602B1CB RID: 176587 RVA: 0x005E02AA File Offset: 0x005DE4AA
		public byte[] GetWordArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700BBF4 RID: 48116
		// (get) Token: 0x0602B1CC RID: 176588 RVA: 0x005E02B8 File Offset: 0x005DE4B8
		public string AkEvent
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

		// Token: 0x0602B1CD RID: 176589 RVA: 0x005E02EF File Offset: 0x005DE4EF
		public Span<byte> GetAkEventBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602B1CE RID: 176590 RVA: 0x005E02FE File Offset: 0x005DE4FE
		public byte[] GetAkEventArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602B1CF RID: 176591 RVA: 0x005E030C File Offset: 0x005DE50C
		public static Offset<IAvgInterjection> CreateIAvgInterjection(FlatBufferBuilder builder, StringOffset WordOffset = default(StringOffset), StringOffset AkEventOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IAvgInterjection.AddAkEvent(builder, AkEventOffset);
			IAvgInterjection.AddWord(builder, WordOffset);
			return IAvgInterjection.EndIAvgInterjection(builder);
		}

		// Token: 0x0602B1D0 RID: 176592 RVA: 0x005E0329 File Offset: 0x005DE529
		public static void StartIAvgInterjection(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602B1D1 RID: 176593 RVA: 0x005E0332 File Offset: 0x005DE532
		public static void AddWord(FlatBufferBuilder builder, StringOffset wordOffset)
		{
			builder.AddOffset(0, wordOffset.Value, 0);
		}

		// Token: 0x0602B1D2 RID: 176594 RVA: 0x005E0342 File Offset: 0x005DE542
		public static void AddAkEvent(FlatBufferBuilder builder, StringOffset akEventOffset)
		{
			builder.AddOffset(1, akEventOffset.Value, 0);
		}

		// Token: 0x0602B1D3 RID: 176595 RVA: 0x005E0352 File Offset: 0x005DE552
		public static Offset<IAvgInterjection> EndIAvgInterjection(FlatBufferBuilder builder)
		{
			return new Offset<IAvgInterjection>(builder.EndTable());
		}

		// Token: 0x0602B1D4 RID: 176596 RVA: 0x005E0360 File Offset: 0x005DE560
		public IAvgInterjectionT UnPack()
		{
			IAvgInterjectionT avgInterjectionT = new IAvgInterjectionT();
			this.UnPackTo(avgInterjectionT);
			return avgInterjectionT;
		}

		// Token: 0x0602B1D5 RID: 176597 RVA: 0x005E037B File Offset: 0x005DE57B
		public void UnPackTo(IAvgInterjectionT _o)
		{
			_o.Word = this.Word;
			_o.AkEvent = this.AkEvent;
		}

		// Token: 0x0602B1D6 RID: 176598 RVA: 0x005E0398 File Offset: 0x005DE598
		public static Offset<IAvgInterjection> Pack(FlatBufferBuilder builder, IAvgInterjectionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAvgInterjection>);
			}
			StringOffset wordOffset = (_o.Word == null) ? default(StringOffset) : builder.CreateString(_o.Word);
			StringOffset akEventOffset = (_o.AkEvent == null) ? default(StringOffset) : builder.CreateString(_o.AkEvent);
			return IAvgInterjection.CreateIAvgInterjection(builder, wordOffset, akEventOffset);
		}

		// Token: 0x04010410 RID: 66576
		private Table __p;
	}
}
