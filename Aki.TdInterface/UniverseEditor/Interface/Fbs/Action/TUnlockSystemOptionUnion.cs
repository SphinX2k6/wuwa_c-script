using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02008037 RID: 32823
	public class TUnlockSystemOptionUnion
	{
		// Token: 0x1700F347 RID: 62279
		// (get) Token: 0x0603B0E3 RID: 241891 RVA: 0x007ED982 File Offset: 0x007EBB82
		// (set) Token: 0x0603B0E4 RID: 241892 RVA: 0x007ED98A File Offset: 0x007EBB8A
		public TUnlockSystemOption Type { get; set; }

		// Token: 0x1700F348 RID: 62280
		// (get) Token: 0x0603B0E5 RID: 241893 RVA: 0x007ED993 File Offset: 0x007EBB93
		// (set) Token: 0x0603B0E6 RID: 241894 RVA: 0x007ED99B File Offset: 0x007EBB9B
		public object Value { get; set; }

		// Token: 0x0603B0E7 RID: 241895 RVA: 0x007ED9A4 File Offset: 0x007EBBA4
		public TUnlockSystemOptionUnion()
		{
			this.Type = TUnlockSystemOption.NONE;
			this.Value = null;
		}

		// Token: 0x0603B0E8 RID: 241896 RVA: 0x007ED9BA File Offset: 0x007EBBBA
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603B0E9 RID: 241897 RVA: 0x007ED9CC File Offset: 0x007EBBCC
		public IUnlockAchievementSystemItemT AsIUnlockAchievementSystemItem()
		{
			return this.As<IUnlockAchievementSystemItemT>();
		}

		// Token: 0x0603B0EA RID: 241898 RVA: 0x007ED9D4 File Offset: 0x007EBBD4
		public static TUnlockSystemOptionUnion FromIUnlockAchievementSystemItem(IUnlockAchievementSystemItemT _iunlockachievementsystemitem)
		{
			return new TUnlockSystemOptionUnion
			{
				Type = TUnlockSystemOption.IUnlockAchievementSystemItem,
				Value = _iunlockachievementsystemitem
			};
		}

		// Token: 0x0603B0EB RID: 241899 RVA: 0x007ED9E9 File Offset: 0x007EBBE9
		public IUnlockAtlasSystemItemT AsIUnlockAtlasSystemItem()
		{
			return this.As<IUnlockAtlasSystemItemT>();
		}

		// Token: 0x0603B0EC RID: 241900 RVA: 0x007ED9F1 File Offset: 0x007EBBF1
		public static TUnlockSystemOptionUnion FromIUnlockAtlasSystemItem(IUnlockAtlasSystemItemT _iunlockatlassystemitem)
		{
			return new TUnlockSystemOptionUnion
			{
				Type = TUnlockSystemOption.IUnlockAtlasSystemItem,
				Value = _iunlockatlassystemitem
			};
		}

		// Token: 0x0603B0ED RID: 241901 RVA: 0x007EDA06 File Offset: 0x007EBC06
		public IUnLockCookSystemItemT AsIUnLockCookSystemItem()
		{
			return this.As<IUnLockCookSystemItemT>();
		}

		// Token: 0x0603B0EE RID: 241902 RVA: 0x007EDA0E File Offset: 0x007EBC0E
		public static TUnlockSystemOptionUnion FromIUnLockCookSystemItem(IUnLockCookSystemItemT _iunlockcooksystemitem)
		{
			return new TUnlockSystemOptionUnion
			{
				Type = TUnlockSystemOption.IUnLockCookSystemItem,
				Value = _iunlockcooksystemitem
			};
		}

		// Token: 0x0603B0EF RID: 241903 RVA: 0x007EDA23 File Offset: 0x007EBC23
		public IUnLockDangoCollectSystemItemT AsIUnLockDangoCollectSystemItem()
		{
			return this.As<IUnLockDangoCollectSystemItemT>();
		}

		// Token: 0x0603B0F0 RID: 241904 RVA: 0x007EDA2B File Offset: 0x007EBC2B
		public static TUnlockSystemOptionUnion FromIUnLockDangoCollectSystemItem(IUnLockDangoCollectSystemItemT _iunlockdangocollectsystemitem)
		{
			return new TUnlockSystemOptionUnion
			{
				Type = TUnlockSystemOption.IUnLockDangoCollectSystemItem,
				Value = _iunlockdangocollectsystemitem
			};
		}

		// Token: 0x0603B0F1 RID: 241905 RVA: 0x007EDA40 File Offset: 0x007EBC40
		public IUnlockPhotoMemoryCollectSystemItemT AsIUnlockPhotoMemoryCollectSystemItem()
		{
			return this.As<IUnlockPhotoMemoryCollectSystemItemT>();
		}

		// Token: 0x0603B0F2 RID: 241906 RVA: 0x007EDA48 File Offset: 0x007EBC48
		public static TUnlockSystemOptionUnion FromIUnlockPhotoMemoryCollectSystemItem(IUnlockPhotoMemoryCollectSystemItemT _iunlockphotomemorycollectsystemitem)
		{
			return new TUnlockSystemOptionUnion
			{
				Type = TUnlockSystemOption.IUnlockPhotoMemoryCollectSystemItem,
				Value = _iunlockphotomemorycollectsystemitem
			};
		}

		// Token: 0x0603B0F3 RID: 241907 RVA: 0x007EDA60 File Offset: 0x007EBC60
		public static int Pack(FlatBufferBuilder builder, TUnlockSystemOptionUnion _o)
		{
			switch (_o.Type)
			{
			case TUnlockSystemOption.IUnlockAchievementSystemItem:
				return IUnlockAchievementSystemItem.Pack(builder, _o.AsIUnlockAchievementSystemItem()).Value;
			case TUnlockSystemOption.IUnlockAtlasSystemItem:
				return IUnlockAtlasSystemItem.Pack(builder, _o.AsIUnlockAtlasSystemItem()).Value;
			case TUnlockSystemOption.IUnLockCookSystemItem:
				return IUnLockCookSystemItem.Pack(builder, _o.AsIUnLockCookSystemItem()).Value;
			case TUnlockSystemOption.IUnLockDangoCollectSystemItem:
				return IUnLockDangoCollectSystemItem.Pack(builder, _o.AsIUnLockDangoCollectSystemItem()).Value;
			case TUnlockSystemOption.IUnlockPhotoMemoryCollectSystemItem:
				return IUnlockPhotoMemoryCollectSystemItem.Pack(builder, _o.AsIUnlockPhotoMemoryCollectSystemItem()).Value;
			default:
				return 0;
			}
		}
	}
}
