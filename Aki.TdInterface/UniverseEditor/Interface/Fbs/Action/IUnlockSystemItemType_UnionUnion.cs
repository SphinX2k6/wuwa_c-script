using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CDB RID: 31963
	public class IUnlockSystemItemType_UnionUnion
	{
		// Token: 0x1700EF33 RID: 61235
		// (get) Token: 0x06039A77 RID: 236151 RVA: 0x007C7291 File Offset: 0x007C5491
		// (set) Token: 0x06039A78 RID: 236152 RVA: 0x007C7299 File Offset: 0x007C5499
		public IUnlockSystemItemType_Union Type { get; set; }

		// Token: 0x1700EF34 RID: 61236
		// (get) Token: 0x06039A79 RID: 236153 RVA: 0x007C72A2 File Offset: 0x007C54A2
		// (set) Token: 0x06039A7A RID: 236154 RVA: 0x007C72AA File Offset: 0x007C54AA
		public object Value { get; set; }

		// Token: 0x06039A7B RID: 236155 RVA: 0x007C72B3 File Offset: 0x007C54B3
		public IUnlockSystemItemType_UnionUnion()
		{
			this.Type = IUnlockSystemItemType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06039A7C RID: 236156 RVA: 0x007C72C9 File Offset: 0x007C54C9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06039A7D RID: 236157 RVA: 0x007C72DB File Offset: 0x007C54DB
		public IUnlockSystemItemTypeT AsIUnlockSystemItemType()
		{
			return this.As<IUnlockSystemItemTypeT>();
		}

		// Token: 0x06039A7E RID: 236158 RVA: 0x007C72E3 File Offset: 0x007C54E3
		public static IUnlockSystemItemType_UnionUnion FromIUnlockSystemItemType(IUnlockSystemItemTypeT _iunlocksystemitemtype)
		{
			return new IUnlockSystemItemType_UnionUnion
			{
				Type = IUnlockSystemItemType_Union.IUnlockSystemItemType,
				Value = _iunlocksystemitemtype
			};
		}

		// Token: 0x06039A7F RID: 236159 RVA: 0x007C72F8 File Offset: 0x007C54F8
		public IUnLockCookSystemItemT AsIUnLockCookSystemItem()
		{
			return this.As<IUnLockCookSystemItemT>();
		}

		// Token: 0x06039A80 RID: 236160 RVA: 0x007C7300 File Offset: 0x007C5500
		public static IUnlockSystemItemType_UnionUnion FromIUnLockCookSystemItem(IUnLockCookSystemItemT _iunlockcooksystemitem)
		{
			return new IUnlockSystemItemType_UnionUnion
			{
				Type = IUnlockSystemItemType_Union.IUnLockCookSystemItem,
				Value = _iunlockcooksystemitem
			};
		}

		// Token: 0x06039A81 RID: 236161 RVA: 0x007C7315 File Offset: 0x007C5515
		public IUnlockAtlasSystemItemT AsIUnlockAtlasSystemItem()
		{
			return this.As<IUnlockAtlasSystemItemT>();
		}

		// Token: 0x06039A82 RID: 236162 RVA: 0x007C731D File Offset: 0x007C551D
		public static IUnlockSystemItemType_UnionUnion FromIUnlockAtlasSystemItem(IUnlockAtlasSystemItemT _iunlockatlassystemitem)
		{
			return new IUnlockSystemItemType_UnionUnion
			{
				Type = IUnlockSystemItemType_Union.IUnlockAtlasSystemItem,
				Value = _iunlockatlassystemitem
			};
		}

		// Token: 0x06039A83 RID: 236163 RVA: 0x007C7332 File Offset: 0x007C5532
		public IUnlockAchievementSystemItemT AsIUnlockAchievementSystemItem()
		{
			return this.As<IUnlockAchievementSystemItemT>();
		}

		// Token: 0x06039A84 RID: 236164 RVA: 0x007C733A File Offset: 0x007C553A
		public static IUnlockSystemItemType_UnionUnion FromIUnlockAchievementSystemItem(IUnlockAchievementSystemItemT _iunlockachievementsystemitem)
		{
			return new IUnlockSystemItemType_UnionUnion
			{
				Type = IUnlockSystemItemType_Union.IUnlockAchievementSystemItem,
				Value = _iunlockachievementsystemitem
			};
		}

		// Token: 0x06039A85 RID: 236165 RVA: 0x007C734F File Offset: 0x007C554F
		public IUnlockPhotoMemoryCollectSystemItemT AsIUnlockPhotoMemoryCollectSystemItem()
		{
			return this.As<IUnlockPhotoMemoryCollectSystemItemT>();
		}

		// Token: 0x06039A86 RID: 236166 RVA: 0x007C7357 File Offset: 0x007C5557
		public static IUnlockSystemItemType_UnionUnion FromIUnlockPhotoMemoryCollectSystemItem(IUnlockPhotoMemoryCollectSystemItemT _iunlockphotomemorycollectsystemitem)
		{
			return new IUnlockSystemItemType_UnionUnion
			{
				Type = IUnlockSystemItemType_Union.IUnlockPhotoMemoryCollectSystemItem,
				Value = _iunlockphotomemorycollectsystemitem
			};
		}

		// Token: 0x06039A87 RID: 236167 RVA: 0x007C736C File Offset: 0x007C556C
		public IUnLockDangoCollectSystemItemT AsIUnLockDangoCollectSystemItem()
		{
			return this.As<IUnLockDangoCollectSystemItemT>();
		}

		// Token: 0x06039A88 RID: 236168 RVA: 0x007C7374 File Offset: 0x007C5574
		public static IUnlockSystemItemType_UnionUnion FromIUnLockDangoCollectSystemItem(IUnLockDangoCollectSystemItemT _iunlockdangocollectsystemitem)
		{
			return new IUnlockSystemItemType_UnionUnion
			{
				Type = IUnlockSystemItemType_Union.IUnLockDangoCollectSystemItem,
				Value = _iunlockdangocollectsystemitem
			};
		}

		// Token: 0x06039A89 RID: 236169 RVA: 0x007C738C File Offset: 0x007C558C
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
