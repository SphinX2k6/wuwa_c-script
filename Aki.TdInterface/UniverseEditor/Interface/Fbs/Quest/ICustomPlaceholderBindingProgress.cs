using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041D8 RID: 16856
	public struct ICustomPlaceholderBindingProgress : IFlatbufferObject
	{
		// Token: 0x170072DD RID: 29405
		// (get) Token: 0x0601762A RID: 95786 RVA: 0x00357DCF File Offset: 0x00355FCF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601762B RID: 95787 RVA: 0x00357DDC File Offset: 0x00355FDC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601762C RID: 95788 RVA: 0x00357DE4 File Offset: 0x00355FE4
		public static ICustomPlaceholderBindingProgress GetRootAsICustomPlaceholderBindingProgress(ByteBuffer _bb)
		{
			return ICustomPlaceholderBindingProgress.GetRootAsICustomPlaceholderBindingProgress(_bb, default(ICustomPlaceholderBindingProgress));
		}

		// Token: 0x0601762D RID: 95789 RVA: 0x00357E00 File Offset: 0x00356000
		public static ICustomPlaceholderBindingProgress GetRootAsICustomPlaceholderBindingProgress(ByteBuffer _bb, ICustomPlaceholderBindingProgress obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601762E RID: 95790 RVA: 0x00357E1D File Offset: 0x0035601D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601762F RID: 95791 RVA: 0x00357E2C File Offset: 0x0035602C
		public ICustomPlaceholderBindingProgress __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170072DE RID: 29406
		// (get) Token: 0x06017630 RID: 95792 RVA: 0x00357E3C File Offset: 0x0035603C
		public string PlaceHolderName
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

		// Token: 0x06017631 RID: 95793 RVA: 0x00357E73 File Offset: 0x00356073
		public Span<byte> GetPlaceHolderNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06017632 RID: 95794 RVA: 0x00357E82 File Offset: 0x00356082
		public byte[] GetPlaceHolderNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x170072DF RID: 29407
		// (get) Token: 0x06017633 RID: 95795 RVA: 0x00357E90 File Offset: 0x00356090
		public IPlayerHavingItemCount? BindingProgressType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPlayerHavingItemCount?(default(IPlayerHavingItemCount).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06017634 RID: 95796 RVA: 0x00357EED File Offset: 0x003560ED
		public static Offset<ICustomPlaceholderBindingProgress> CreateICustomPlaceholderBindingProgress(FlatBufferBuilder builder, StringOffset PlaceHolderNameOffset = default(StringOffset), Offset<IPlayerHavingItemCount> BindingProgressTypeOffset = default(Offset<IPlayerHavingItemCount>))
		{
			builder.StartTable(2);
			ICustomPlaceholderBindingProgress.AddBindingProgressType(builder, BindingProgressTypeOffset);
			ICustomPlaceholderBindingProgress.AddPlaceHolderName(builder, PlaceHolderNameOffset);
			return ICustomPlaceholderBindingProgress.EndICustomPlaceholderBindingProgress(builder);
		}

		// Token: 0x06017635 RID: 95797 RVA: 0x00357F0A File Offset: 0x0035610A
		public static void StartICustomPlaceholderBindingProgress(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06017636 RID: 95798 RVA: 0x00357F13 File Offset: 0x00356113
		public static void AddPlaceHolderName(FlatBufferBuilder builder, StringOffset placeHolderNameOffset)
		{
			builder.AddOffset(0, placeHolderNameOffset.Value, 0);
		}

		// Token: 0x06017637 RID: 95799 RVA: 0x00357F23 File Offset: 0x00356123
		public static void AddBindingProgressType(FlatBufferBuilder builder, Offset<IPlayerHavingItemCount> bindingProgressTypeOffset)
		{
			builder.AddOffset(1, bindingProgressTypeOffset.Value, 0);
		}

		// Token: 0x06017638 RID: 95800 RVA: 0x00357F33 File Offset: 0x00356133
		public static Offset<ICustomPlaceholderBindingProgress> EndICustomPlaceholderBindingProgress(FlatBufferBuilder builder)
		{
			return new Offset<ICustomPlaceholderBindingProgress>(builder.EndTable());
		}

		// Token: 0x06017639 RID: 95801 RVA: 0x00357F40 File Offset: 0x00356140
		public ICustomPlaceholderBindingProgressT UnPack()
		{
			ICustomPlaceholderBindingProgressT customPlaceholderBindingProgressT = new ICustomPlaceholderBindingProgressT();
			this.UnPackTo(customPlaceholderBindingProgressT);
			return customPlaceholderBindingProgressT;
		}

		// Token: 0x0601763A RID: 95802 RVA: 0x00357F5C File Offset: 0x0035615C
		public void UnPackTo(ICustomPlaceholderBindingProgressT _o)
		{
			_o.PlaceHolderName = this.PlaceHolderName;
			_o.BindingProgressType = ((this.BindingProgressType != null) ? this.BindingProgressType.Value.UnPack() : null);
		}

		// Token: 0x0601763B RID: 95803 RVA: 0x00357FA4 File Offset: 0x003561A4
		public static Offset<ICustomPlaceholderBindingProgress> Pack(FlatBufferBuilder builder, ICustomPlaceholderBindingProgressT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICustomPlaceholderBindingProgress>);
			}
			StringOffset placeHolderNameOffset = (_o.PlaceHolderName == null) ? default(StringOffset) : builder.CreateString(_o.PlaceHolderName);
			Offset<IPlayerHavingItemCount> bindingProgressTypeOffset = (_o.BindingProgressType == null) ? default(Offset<IPlayerHavingItemCount>) : IPlayerHavingItemCount.Pack(builder, _o.BindingProgressType);
			return ICustomPlaceholderBindingProgress.CreateICustomPlaceholderBindingProgress(builder, placeHolderNameOffset, bindingProgressTypeOffset);
		}

		// Token: 0x0400C0B0 RID: 49328
		private Table __p;
	}
}
