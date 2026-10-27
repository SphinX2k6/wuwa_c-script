using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074DE RID: 29918
	public struct IUnlockSystemItem : IFlatbufferObject
	{
		// Token: 0x1700E303 RID: 58115
		// (get) Token: 0x06036637 RID: 222775 RVA: 0x00763AC2 File Offset: 0x00761CC2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036638 RID: 222776 RVA: 0x00763ACF File Offset: 0x00761CCF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036639 RID: 222777 RVA: 0x00763AD8 File Offset: 0x00761CD8
		public static IUnlockSystemItem GetRootAsIUnlockSystemItem(ByteBuffer _bb)
		{
			return IUnlockSystemItem.GetRootAsIUnlockSystemItem(_bb, default(IUnlockSystemItem));
		}

		// Token: 0x0603663A RID: 222778 RVA: 0x00763AF4 File Offset: 0x00761CF4
		public static IUnlockSystemItem GetRootAsIUnlockSystemItem(ByteBuffer _bb, IUnlockSystemItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603663B RID: 222779 RVA: 0x00763B11 File Offset: 0x00761D11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603663C RID: 222780 RVA: 0x00763B20 File Offset: 0x00761D20
		public IUnlockSystemItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E304 RID: 58116
		// (get) Token: 0x0603663D RID: 222781 RVA: 0x00763B30 File Offset: 0x00761D30
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

		// Token: 0x0603663E RID: 222782 RVA: 0x00763B6C File Offset: 0x00761D6C
		public TTable? SystemOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603663F RID: 222783 RVA: 0x00763BB0 File Offset: 0x00761DB0
		public IUnlockAchievementSystemItem SystemOptionAsIUnlockAchievementSystemItem()
		{
			return this.SystemOption<IUnlockAchievementSystemItem>().Value;
		}

		// Token: 0x06036640 RID: 222784 RVA: 0x00763BCC File Offset: 0x00761DCC
		public IUnlockAtlasSystemItem SystemOptionAsIUnlockAtlasSystemItem()
		{
			return this.SystemOption<IUnlockAtlasSystemItem>().Value;
		}

		// Token: 0x06036641 RID: 222785 RVA: 0x00763BE8 File Offset: 0x00761DE8
		public IUnLockCookSystemItem SystemOptionAsIUnLockCookSystemItem()
		{
			return this.SystemOption<IUnLockCookSystemItem>().Value;
		}

		// Token: 0x06036642 RID: 222786 RVA: 0x00763C04 File Offset: 0x00761E04
		public IUnLockDangoCollectSystemItem SystemOptionAsIUnLockDangoCollectSystemItem()
		{
			return this.SystemOption<IUnLockDangoCollectSystemItem>().Value;
		}

		// Token: 0x06036643 RID: 222787 RVA: 0x00763C20 File Offset: 0x00761E20
		public IUnlockPhotoMemoryCollectSystemItem SystemOptionAsIUnlockPhotoMemoryCollectSystemItem()
		{
			return this.SystemOption<IUnlockPhotoMemoryCollectSystemItem>().Value;
		}

		// Token: 0x06036644 RID: 222788 RVA: 0x00763C3B File Offset: 0x00761E3B
		public static Offset<IUnlockSystemItem> CreateIUnlockSystemItem(FlatBufferBuilder builder, TUnlockSystemOption SystemOption_type = TUnlockSystemOption.NONE, int SystemOptionOffset = 0)
		{
			builder.StartTable(2);
			IUnlockSystemItem.AddSystemOption(builder, SystemOptionOffset);
			IUnlockSystemItem.AddSystemOptionType(builder, SystemOption_type);
			return IUnlockSystemItem.EndIUnlockSystemItem(builder);
		}

		// Token: 0x06036645 RID: 222789 RVA: 0x00763C58 File Offset: 0x00761E58
		public static void StartIUnlockSystemItem(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06036646 RID: 222790 RVA: 0x00763C61 File Offset: 0x00761E61
		public static void AddSystemOptionType(FlatBufferBuilder builder, TUnlockSystemOption systemOptionType)
		{
			builder.AddByte(0, (byte)systemOptionType, 0);
		}

		// Token: 0x06036647 RID: 222791 RVA: 0x00763C6C File Offset: 0x00761E6C
		public static void AddSystemOption(FlatBufferBuilder builder, int systemOptionOffset)
		{
			builder.AddOffset(1, systemOptionOffset, 0);
		}

		// Token: 0x06036648 RID: 222792 RVA: 0x00763C77 File Offset: 0x00761E77
		public static Offset<IUnlockSystemItem> EndIUnlockSystemItem(FlatBufferBuilder builder)
		{
			return new Offset<IUnlockSystemItem>(builder.EndTable());
		}

		// Token: 0x06036649 RID: 222793 RVA: 0x00763C84 File Offset: 0x00761E84
		public IUnlockSystemItemT UnPack()
		{
			IUnlockSystemItemT unlockSystemItemT = new IUnlockSystemItemT();
			this.UnPackTo(unlockSystemItemT);
			return unlockSystemItemT;
		}

		// Token: 0x0603664A RID: 222794 RVA: 0x00763CA0 File Offset: 0x00761EA0
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

		// Token: 0x0603664B RID: 222795 RVA: 0x00763E00 File Offset: 0x00762000
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

		// Token: 0x040123A6 RID: 74662
		private Table __p;
	}
}
