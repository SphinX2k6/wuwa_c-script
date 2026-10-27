using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006302 RID: 25346
	public struct IChangeInteractOptionText : IFlatbufferObject
	{
		// Token: 0x1700BD33 RID: 48435
		// (get) Token: 0x0602BD37 RID: 179511 RVA: 0x00607087 File Offset: 0x00605287
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BD38 RID: 179512 RVA: 0x00607094 File Offset: 0x00605294
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BD39 RID: 179513 RVA: 0x0060709C File Offset: 0x0060529C
		public static IChangeInteractOptionText GetRootAsIChangeInteractOptionText(ByteBuffer _bb)
		{
			return IChangeInteractOptionText.GetRootAsIChangeInteractOptionText(_bb, default(IChangeInteractOptionText));
		}

		// Token: 0x0602BD3A RID: 179514 RVA: 0x006070B8 File Offset: 0x006052B8
		public static IChangeInteractOptionText GetRootAsIChangeInteractOptionText(ByteBuffer _bb, IChangeInteractOptionText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BD3B RID: 179515 RVA: 0x006070D5 File Offset: 0x006052D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BD3C RID: 179516 RVA: 0x006070E4 File Offset: 0x006052E4
		public IChangeInteractOptionText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD34 RID: 48436
		// (get) Token: 0x0602BD3D RID: 179517 RVA: 0x006070F4 File Offset: 0x006052F4
		public string TidContent
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

		// Token: 0x0602BD3E RID: 179518 RVA: 0x0060712B File Offset: 0x0060532B
		public Span<byte> GetTidContentBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602BD3F RID: 179519 RVA: 0x0060713A File Offset: 0x0060533A
		public byte[] GetTidContentArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0602BD40 RID: 179520 RVA: 0x00607148 File Offset: 0x00605348
		public static Offset<IChangeInteractOptionText> CreateIChangeInteractOptionText(FlatBufferBuilder builder, StringOffset TidContentOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IChangeInteractOptionText.AddTidContent(builder, TidContentOffset);
			return IChangeInteractOptionText.EndIChangeInteractOptionText(builder);
		}

		// Token: 0x0602BD41 RID: 179521 RVA: 0x0060715E File Offset: 0x0060535E
		public static void StartIChangeInteractOptionText(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602BD42 RID: 179522 RVA: 0x00607167 File Offset: 0x00605367
		public static void AddTidContent(FlatBufferBuilder builder, StringOffset tidContentOffset)
		{
			builder.AddOffset(0, tidContentOffset.Value, 0);
		}

		// Token: 0x0602BD43 RID: 179523 RVA: 0x00607177 File Offset: 0x00605377
		public static Offset<IChangeInteractOptionText> EndIChangeInteractOptionText(FlatBufferBuilder builder)
		{
			return new Offset<IChangeInteractOptionText>(builder.EndTable());
		}

		// Token: 0x0602BD44 RID: 179524 RVA: 0x00607184 File Offset: 0x00605384
		public IChangeInteractOptionTextT UnPack()
		{
			IChangeInteractOptionTextT changeInteractOptionTextT = new IChangeInteractOptionTextT();
			this.UnPackTo(changeInteractOptionTextT);
			return changeInteractOptionTextT;
		}

		// Token: 0x0602BD45 RID: 179525 RVA: 0x0060719F File Offset: 0x0060539F
		public void UnPackTo(IChangeInteractOptionTextT _o)
		{
			_o.TidContent = this.TidContent;
		}

		// Token: 0x0602BD46 RID: 179526 RVA: 0x006071B0 File Offset: 0x006053B0
		public static Offset<IChangeInteractOptionText> Pack(FlatBufferBuilder builder, IChangeInteractOptionTextT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeInteractOptionText>);
			}
			StringOffset tidContentOffset = (_o.TidContent == null) ? default(StringOffset) : builder.CreateString(_o.TidContent);
			return IChangeInteractOptionText.CreateIChangeInteractOptionText(builder, tidContentOffset);
		}

		// Token: 0x040108C1 RID: 67777
		private Table __p;
	}
}
