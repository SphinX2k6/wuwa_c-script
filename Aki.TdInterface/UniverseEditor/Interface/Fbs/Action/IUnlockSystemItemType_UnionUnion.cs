using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074E5 RID: 29925
	public class IUnlockSystemItemType_UnionUnion
	{
		// Token: 0x1700E309 RID: 58121
		// (get) Token: 0x06036662 RID: 222818 RVA: 0x00764041 File Offset: 0x00762241
		// (set) Token: 0x06036663 RID: 222819 RVA: 0x00764049 File Offset: 0x00762249
		public IUnlockSystemItemType_Union Type { get; set; }

		// Token: 0x1700E30A RID: 58122
		// (get) Token: 0x06036664 RID: 222820 RVA: 0x00764052 File Offset: 0x00762252
		// (set) Token: 0x06036665 RID: 222821 RVA: 0x0076405A File Offset: 0x0076225A
		public object Value { get; set; }

		// Token: 0x06036666 RID: 222822 RVA: 0x00764063 File Offset: 0x00762263
		public IUnlockSystemItemType_UnionUnion()
		{
			this.Type = IUnlockSystemItemType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06036667 RID: 222823 RVA: 0x00764079 File Offset: 0x00762279
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06036668 RID: 222824 RVA: 0x0076408B File Offset: 0x0076228B
		public IUnlockSystemItemTypeT AsIUnlockSystemItemType()
		{
			return this.As<IUnlockSystemItemTypeT>();
		}

		// Token: 0x06036669 RID: 222825 RVA: 0x00764093 File Offset: 0x00762293
		public static IUnlockSystemItemType_UnionUnion FromIUnlockSystemItemType(IUnlockSystemItemTypeT _iunlocksystemitemtype)
		{
			return new IUnlockSystemItemType_UnionUnion
			{
				Type = IUnlockSystemItemType_Union.IUnlockSystemItemType,
				Value = _iunlocksystemitemtype
			};
		}

		// Token: 0x0603666A RID: 222826 RVA: 0x007640A8 File Offset: 0x007622A8
		public IUnLockCookSystemItemT AsIUnLockCookSystemItem()
		{
			return this.As<IUnLockCookSystemItemT>();
		}

		// Token: 0x0603666B RID: 222827 RVA: 0x007640B0 File Offset: 0x007622B0
		public static IUnlockSystemItemType_UnionUnion FromIUnLockCookSystemItem(IUnLockCookSystemItemT _iunlockcooksystemitem)
		{
			return new IUnlockSystemItemType_UnionUnion
			{
				Type = IUnlockSystemItemType_Union.IUnLockCookSystemItem,
				Value = _iunlockcooksystemitem
			};
		}

		// Token: 0x0603666C RID: 222828 RVA: 0x007640C5 File Offset: 0x007622C5
		public IUnlockAtlasSystemItemT AsIUnlockAtlasSystemItem()
		{
			return this.As<IUnlockAtlasSystemItemT>();
		}

		// Token: 0x0603666D RID: 222829 RVA: 0x007640CD File Offset: 0x007622CD
		public static IUnlockSystemItemType_UnionUnion FromIUnlockAtlasSystemItem(IUnlockAtlasSystemItemT _iunlockatlassystemitem)
		{
			return new IUnlockSystemItemType_UnionUnion
			{
				Type = IUnlockSystemItemType_Union.IUnlockAtlasSystemItem,
				Value = _iunlockatlassystemitem
			};
		}

		// Token: 0x0603666E RID: 222830 RVA: 0x007640E2 File Offset: 0x007622E2
		public IUnlockAchievementSystemItemT AsIUnlockAchievementSystemItem()
		{
			return this.As<IUnlockAchievementSystemItemT>();
		}

		// Token: 0x0603666F RID: 222831 RVA: 0x007640EA File Offset: 0x007622EA
		public static IUnlockSystemItemType_UnionUnion FromIUnlockAchievementSystemItem(IUnlockAchievementSystemItemT _iunlockachievementsystemitem)
		{
			return new IUnlockSystemItemType_UnionUnion
			{
				Type = IUnlockSystemItemType_Union.IUnlockAchievementSystemItem,
				Value = _iunlockachievementsystemitem
			};
		}

		// Token: 0x06036670 RID: 222832 RVA: 0x007640FF File Offset: 0x007622FF
		public IUnlockPhotoMemoryCollectSystemItemT AsIUnlockPhotoMemoryCollectSystemItem()
		{
			return this.As<IUnlockPhotoMemoryCollectSystemItemT>();
		}

		// Token: 0x06036671 RID: 222833 RVA: 0x00764107 File Offset: 0x00762307
		public static IUnlockSystemItemType_UnionUnion FromIUnlockPhotoMemoryCollectSystemItem(IUnlockPhotoMemoryCollectSystemItemT _iunlockphotomemorycollectsystemitem)
		{
			return new IUnlockSystemItemType_UnionUnion
			{
				Type = IUnlockSystemItemType_Union.IUnlockPhotoMemoryCollectSystemItem,
				Value = _iunlockphotomemorycollectsystemitem
			};
		}

		// Token: 0x06036672 RID: 222834 RVA: 0x0076411C File Offset: 0x0076231C
		public IUnLockDangoCollectSystemItemT AsIUnLockDangoCollectSystemItem()
		{
			return this.As<IUnLockDangoCollectSystemItemT>();
		}

		// Token: 0x06036673 RID: 222835 RVA: 0x00764124 File Offset: 0x00762324
		public static IUnlockSystemItemType_UnionUnion FromIUnLockDangoCollectSystemItem(IUnLockDangoCollectSystemItemT _iunlockdangocollectsystemitem)
		{
			return new IUnlockSystemItemType_UnionUnion
			{
				Type = IUnlockSystemItemType_Union.IUnLockDangoCollectSystemItem,
				Value = _iunlockdangocollectsystemitem
			};
		}

		// Token: 0x06036674 RID: 222836 RVA: 0x0076413C File Offset: 0x0076233C
		public static int Pack(FlatBufferBuilder builder, IUnlockSystemItemType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IUnlockSystemItemType_Union.IUnlockSystemItemType:
				return IUnlockSystemItemType.Pack(builder, _o.AsIUnlockSystemItemType()).Value;
			case IUnlockSystemItemType_Union.IUnLockCookSystemItem:
				return IUnLockCookSystemItem.Pack(builder, _o.AsIUnLockCookSystemItem()).Value;
			case IUnlockSystemItemType_Union.IUnlockAtlasSystemItem:
				return IUnlockAtlasSystemItem.Pack(builder, _o.AsIUnlockAtlasSystemItem()).Value;
			case IUnlockSystemItemType_Union.IUnlockAchievementSystemItem:
				return IUnlockAchievementSystemItem.Pack(builder, _o.AsIUnlockAchievementSystemItem()).Value;
			case IUnlockSystemItemType_Union.IUnlockPhotoMemoryCollectSystemItem:
				return IUnlockPhotoMemoryCollectSystemItem.Pack(builder, _o.AsIUnlockPhotoMemoryCollectSystemItem()).Value;
			case IUnlockSystemItemType_Union.IUnLockDangoCollectSystemItem:
				return IUnLockDangoCollectSystemItem.Pack(builder, _o.AsIUnLockDangoCollectSystemItem()).Value;
			default:
				return 0;
			}
		}
	}
}
