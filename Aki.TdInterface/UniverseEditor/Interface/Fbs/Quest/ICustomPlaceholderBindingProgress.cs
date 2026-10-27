using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DC1 RID: 15809
	public struct ICustomPlaceholderBindingProgress : IFlatbufferObject
	{
		// Token: 0x17006D23 RID: 27939
		// (get) Token: 0x060160F1 RID: 90353 RVA: 0x00330A47 File Offset: 0x0032EC47
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060160F2 RID: 90354 RVA: 0x00330A54 File Offset: 0x0032EC54
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060160F3 RID: 90355 RVA: 0x00330A5C File Offset: 0x0032EC5C
		public static ICustomPlaceholderBindingProgress GetRootAsICustomPlaceholderBindingProgress(ByteBuffer _bb)
		{
			return ICustomPlaceholderBindingProgress.GetRootAsICustomPlaceholderBindingProgress(_bb, default(ICustomPlaceholderBindingProgress));
		}

		// Token: 0x060160F4 RID: 90356 RVA: 0x00330A78 File Offset: 0x0032EC78
		public static ICustomPlaceholderBindingProgress GetRootAsICustomPlaceholderBindingProgress(ByteBuffer _bb, ICustomPlaceholderBindingProgress obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060160F5 RID: 90357 RVA: 0x00330A95 File Offset: 0x0032EC95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060160F6 RID: 90358 RVA: 0x00330AA4 File Offset: 0x0032ECA4
		public ICustomPlaceholderBindingProgress __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006D24 RID: 27940
		// (get) Token: 0x060160F7 RID: 90359 RVA: 0x00330AB4 File Offset: 0x0032ECB4
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

		// Token: 0x060160F8 RID: 90360 RVA: 0x00330AEB File Offset: 0x0032ECEB
		public Span<byte> GetPlaceHolderNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060160F9 RID: 90361 RVA: 0x00330AFA File Offset: 0x0032ECFA
		public byte[] GetPlaceHolderNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17006D25 RID: 27941
		// (get) Token: 0x060160FA RID: 90362 RVA: 0x00330B08 File Offset: 0x0032ED08
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

		// Token: 0x060160FB RID: 90363 RVA: 0x00330B65 File Offset: 0x0032ED65
		public static Offset<ICustomPlaceholderBindingProgress> CreateICustomPlaceholderBindingProgress(FlatBufferBuilder builder, StringOffset PlaceHolderNameOffset = default(StringOffset), Offset<IPlayerHavingItemCount> BindingProgressTypeOffset = default(Offset<IPlayerHavingItemCount>))
		{
			builder.StartTable(2);
			ICustomPlaceholderBindingProgress.AddBindingProgressType(builder, BindingProgressTypeOffset);
			ICustomPlaceholderBindingProgress.AddPlaceHolderName(builder, PlaceHolderNameOffset);
			return ICustomPlaceholderBindingProgress.EndICustomPlaceholderBindingProgress(builder);
		}

		// Token: 0x060160FC RID: 90364 RVA: 0x00330B82 File Offset: 0x0032ED82
		public static void StartICustomPlaceholderBindingProgress(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060160FD RID: 90365 RVA: 0x00330B8B File Offset: 0x0032ED8B
		public static void AddPlaceHolderName(FlatBufferBuilder builder, StringOffset placeHolderNameOffset)
		{
			builder.AddOffset(0, placeHolderNameOffset.Value, 0);
		}

		// Token: 0x060160FE RID: 90366 RVA: 0x00330B9B File Offset: 0x0032ED9B
		public static void AddBindingProgressType(FlatBufferBuilder builder, Offset<IPlayerHavingItemCount> bindingProgressTypeOffset)
		{
			builder.AddOffset(1, bindingProgressTypeOffset.Value, 0);
		}

		// Token: 0x060160FF RID: 90367 RVA: 0x00330BAB File Offset: 0x0032EDAB
		public static Offset<ICustomPlaceholderBindingProgress> EndICustomPlaceholderBindingProgress(FlatBufferBuilder builder)
		{
			return new Offset<ICustomPlaceholderBindingProgress>(builder.EndTable());
		}

		// Token: 0x06016100 RID: 90368 RVA: 0x00330BB8 File Offset: 0x0032EDB8
		public ICustomPlaceholderBindingProgressT UnPack()
		{
			ICustomPlaceholderBindingProgressT customPlaceholderBindingProgressT = new ICustomPlaceholderBindingProgressT();
			this.UnPackTo(customPlaceholderBindingProgressT);
			return customPlaceholderBindingProgressT;
		}

		// Token: 0x06016101 RID: 90369 RVA: 0x00330BD4 File Offset: 0x0032EDD4
		public void UnPackTo(ICustomPlaceholderBindingProgressT _o)
		{
			_o.PlaceHolderName = this.PlaceHolderName;
			_o.BindingProgressType = ((this.BindingProgressType != null) ? this.BindingProgressType.Value.UnPack() : null);
		}

		// Token: 0x06016102 RID: 90370 RVA: 0x00330C1C File Offset: 0x0032EE1C
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

		// Token: 0x0400B703 RID: 46851
		private Table __p;
	}
}
