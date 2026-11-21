using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CD4 RID: 31956
	public struct IUnlockSystemItem : IFlatbufferObject
	{
		// Token: 0x1700EF2D RID: 61229
		// (get) Token: 0x06039A4C RID: 236108 RVA: 0x007C6D12 File Offset: 0x007C4F12
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039A4D RID: 236109 RVA: 0x007C6D1F File Offset: 0x007C4F1F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039A4E RID: 236110 RVA: 0x007C6D28 File Offset: 0x007C4F28
		public static IUnlockSystemItem GetRootAsIUnlockSystemItem(ByteBuffer _bb)
		{
			return IUnlockSystemItem.GetRootAsIUnlockSystemItem(_bb, default(IUnlockSystemItem));
		}

		// Token: 0x06039A4F RID: 236111 RVA: 0x007C6D44 File Offset: 0x007C4F44
		public static IUnlockSystemItem GetRootAsIUnlockSystemItem(ByteBuffer _bb, IUnlockSystemItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039A50 RID: 236112 RVA: 0x007C6D61 File Offset: 0x007C4F61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039A51 RID: 236113 RVA: 0x007C6D70 File Offset: 0x007C4F70
		public IUnlockSystemItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EF2E RID: 61230
		// (get) Token: 0x06039A52 RID: 236114 RVA: 0x007C6D80 File Offset: 0x007C4F80
		public TUnlockSystemOption SystemOptionType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TUnlockSystemOption.NONE;
				}
				return (TUnlockSystemOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06039A53 RID: 236115 RVA: 0x007C6DBC File Offset: 0x007C4FBC
		public TTable? SystemOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06039A54 RID: 236116 RVA: 0x007C6E00 File Offset: 0x007C5000
		public IUnlockAchievementSystemItem SystemOptionAsIUnlockAchievementSystemItem()
		{
			return this.SystemOption<IUnlockAchievementSystemItem>().Value;
		}

		// Token: 0x06039A55 RID: 236117 RVA: 0x007C6E1C File Offset: 0x007C501C
		public IUnlockAtlasSystemItem SystemOptionAsIUnlockAtlasSystemItem()
		{
			return this.SystemOption<IUnlockAtlasSystemItem>().Value;
		}

		// Token: 0x06039A56 RID: 236118 RVA: 0x007C6E38 File Offset: 0x007C5038
		public IUnLockCookSystemItem SystemOptionAsIUnLockCookSystemItem()
		{
			return this.SystemOption<IUnLockCookSystemItem>().Value;
		}

		// Token: 0x06039A57 RID: 236119 RVA: 0x007C6E54 File Offset: 0x007C5054
		public IUnLockDangoCollectSystemItem SystemOptionAsIUnLockDangoCollectSystemItem()
		{
			return this.SystemOption<IUnLockDangoCollectSystemItem>().Value;
		}

		// Token: 0x06039A58 RID: 236120 RVA: 0x007C6E70 File Offset: 0x007C5070
		public IUnlockPhotoMemoryCollectSystemItem SystemOptionAsIUnlockPhotoMemoryCollectSystemItem()
		{
			return this.SystemOption<IUnlockPhotoMemoryCollectSystemItem>().Value;
		}

		// Token: 0x06039A59 RID: 236121 RVA: 0x007C6E8B File Offset: 0x007C508B
		public static Offset<IUnlockSystemItem> CreateIUnlockSystemItem(FlatBufferBuilder builder, TUnlockSystemOption SystemOption_type = TUnlockSystemOption.NONE, int SystemOptionOffset = 0)
		{
			builder.StartTable(2);
			IUnlockSystemItem.AddSystemOption(builder, SystemOptionOffset);
			IUnlockSystemItem.AddSystemOptionType(builder, SystemOption_type);
			return IUnlockSystemItem.EndIUnlockSystemItem(builder);
		}

		// Token: 0x06039A5A RID: 236122 RVA: 0x007C6EA8 File Offset: 0x007C50A8
		public static void StartIUnlockSystemItem(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06039A5B RID: 236123 RVA: 0x007C6EB1 File Offset: 0x007C50B1
		public static void AddSystemOptionType(FlatBufferBuilder builder, TUnlockSystemOption systemOptionType)
		{
			builder.AddByte(0, (byte)systemOptionType, 0);
		}

		// Token: 0x06039A5C RID: 236124 RVA: 0x007C6EBC File Offset: 0x007C50BC
		public static void AddSystemOption(FlatBufferBuilder builder, int systemOptionOffset)
		{
			builder.AddOffset(1, systemOptionOffset, 0);
		}

		// Token: 0x06039A5D RID: 236125 RVA: 0x007C6EC7 File Offset: 0x007C50C7
		public static Offset<IUnlockSystemItem> EndIUnlockSystemItem(FlatBufferBuilder builder)
		{
			return new Offset<IUnlockSystemItem>(builder.EndTable());
		}

		// Token: 0x06039A5E RID: 236126 RVA: 0x007C6ED4 File Offset: 0x007C50D4
		public IUnlockSystemItemT UnPack()
		{
			IUnlockSystemItemT unlockSystemItemT = new IUnlockSystemItemT();
			this.UnPackTo(unlockSystemItemT);
			return unlockSystemItemT;
		}

		// Token: 0x06039A5F RID: 236127 RVA: 0x007C6EF0 File Offset: 0x007C50F0
		public void UnPackTo(IUnlockSystemItemT _o)
		{
			_o.SystemOption = new TUnlockSystemOptionUnion();
			_o.SystemOption.Type = this.SystemOptionType;
			switch (this.SystemOptionType)
			{
			case TUnlockSystemOption.IUnlockAchievementSystemItem:
				_o.SystemOption.Value = ((this.SystemOption<IUnlockAchievementSystemItem>() != null) ? this.SystemOption<IUnlockAchievementSystemItem>().Value.UnPack() : null);
				return;
			case TUnlockSystemOption.IUnlockAtlasSystemItem:
				_o.SystemOption.Value = ((this.SystemOption<IUnlockAtlasSystemItem>() != null) ? this.SystemOption<IUnlockAtlasSystemItem>().Value.UnPack() : null);
				return;
			case TUnlockSystemOption.IUnLockCookSystemItem:
				_o.SystemOption.Value = ((this.SystemOption<IUnLockCookSystemItem>() != null) ? this.SystemOption<IUnLockCookSystemItem>().Value.UnPack() : null);
				return;
			case TUnlockSystemOption.IUnLockDangoCollectSystemItem:
				_o.SystemOption.Value = ((this.SystemOption<IUnLockDangoCollectSystemItem>() != null) ? this.SystemOption<IUnLockDangoCollectSystemItem>().Value.UnPack() : null);
				return;
			case TUnlockSystemOption.IUnlockPhotoMemoryCollectSystemItem:
				_o.SystemOption.Value = ((this.SystemOption<IUnlockPhotoMemoryCollectSystemItem>() != null) ? this.SystemOption<IUnlockPhotoMemoryCollectSystemItem>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06039A60 RID: 236128 RVA: 0x007C7050 File Offset: 0x007C5250
		public static Offset<IUnlockSystemItem> Pack(FlatBufferBuilder builder, IUnlockSystemItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUnlockSystemItem>);
			}
			TUnlockSystemOption systemOption_type = (_o.SystemOption == null) ? TUnlockSystemOption.NONE : _o.SystemOption.Type;
			int systemOptionOffset = (_o.SystemOption == null) ? 0 : TUnlockSystemOptionUnion.Pack(builder, _o.SystemOption);
			return IUnlockSystemItem.CreateIUnlockSystemItem(builder, systemOption_type, systemOptionOffset);
		}

		// Token: 0x040133D7 RID: 78807
		private Table __p;
	}
}
