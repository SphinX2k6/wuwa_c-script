using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D16 RID: 23830
	public struct IAvgInterjection : IFlatbufferObject
	{
		// Token: 0x1700B291 RID: 45713
		// (get) Token: 0x06028B59 RID: 166745 RVA: 0x00597787 File Offset: 0x00595987
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028B5A RID: 166746 RVA: 0x00597794 File Offset: 0x00595994
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028B5B RID: 166747 RVA: 0x0059779C File Offset: 0x0059599C
		public static IAvgInterjection GetRootAsIAvgInterjection(ByteBuffer _bb)
		{
			return IAvgInterjection.GetRootAsIAvgInterjection(_bb, default(IAvgInterjection));
		}

		// Token: 0x06028B5C RID: 166748 RVA: 0x005977B8 File Offset: 0x005959B8
		public static IAvgInterjection GetRootAsIAvgInterjection(ByteBuffer _bb, IAvgInterjection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028B5D RID: 166749 RVA: 0x005977D5 File Offset: 0x005959D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028B5E RID: 166750 RVA: 0x005977E4 File Offset: 0x005959E4
		public IAvgInterjection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B292 RID: 45714
		// (get) Token: 0x06028B5F RID: 166751 RVA: 0x005977F4 File Offset: 0x005959F4
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

		// Token: 0x06028B60 RID: 166752 RVA: 0x0059782B File Offset: 0x00595A2B
		public Span<byte> GetWordBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06028B61 RID: 166753 RVA: 0x0059783A File Offset: 0x00595A3A
		public byte[] GetWordArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700B293 RID: 45715
		// (get) Token: 0x06028B62 RID: 166754 RVA: 0x00597848 File Offset: 0x00595A48
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

		// Token: 0x06028B63 RID: 166755 RVA: 0x0059787F File Offset: 0x00595A7F
		public Span<byte> GetAkEventBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06028B64 RID: 166756 RVA: 0x0059788E File Offset: 0x00595A8E
		public byte[] GetAkEventArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06028B65 RID: 166757 RVA: 0x0059789C File Offset: 0x00595A9C
		public static Offset<IAvgInterjection> CreateIAvgInterjection(FlatBufferBuilder builder, StringOffset WordOffset = default(StringOffset), StringOffset AkEventOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IAvgInterjection.AddAkEvent(builder, AkEventOffset);
			IAvgInterjection.AddWord(builder, WordOffset);
			return IAvgInterjection.EndIAvgInterjection(builder);
		}

		// Token: 0x06028B66 RID: 166758 RVA: 0x005978B9 File Offset: 0x00595AB9
		public static void StartIAvgInterjection(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06028B67 RID: 166759 RVA: 0x005978C2 File Offset: 0x00595AC2
		public static void AddWord(FlatBufferBuilder builder, StringOffset wordOffset)
		{
			builder.AddOffset(0, wordOffset.Value, 0);
		}

		// Token: 0x06028B68 RID: 166760 RVA: 0x005978D2 File Offset: 0x00595AD2
		public static void AddAkEvent(FlatBufferBuilder builder, StringOffset akEventOffset)
		{
			builder.AddOffset(1, akEventOffset.Value, 0);
		}

		// Token: 0x06028B69 RID: 166761 RVA: 0x005978E2 File Offset: 0x00595AE2
		public static Offset<IAvgInterjection> EndIAvgInterjection(FlatBufferBuilder builder)
		{
			return new Offset<IAvgInterjection>(builder.EndTable());
		}

		// Token: 0x06028B6A RID: 166762 RVA: 0x005978F0 File Offset: 0x00595AF0
		public IAvgInterjectionT UnPack()
		{
			IAvgInterjectionT avgInterjectionT = new IAvgInterjectionT();
			this.UnPackTo(avgInterjectionT);
			return avgInterjectionT;
		}

		// Token: 0x06028B6B RID: 166763 RVA: 0x0059790B File Offset: 0x00595B0B
		public void UnPackTo(IAvgInterjectionT _o)
		{
			_o.Word = this.Word;
			_o.AkEvent = this.AkEvent;
		}

		// Token: 0x06028B6C RID: 166764 RVA: 0x00597928 File Offset: 0x00595B28
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

		// Token: 0x0400F6BE RID: 63166
		private Table __p;
	}
}
