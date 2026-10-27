using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077F9 RID: 30713
	public class TUnlockSystemOptionUnion
	{
		// Token: 0x1700E6E9 RID: 59113
		// (get) Token: 0x06037B3E RID: 228158 RVA: 0x0078800A File Offset: 0x0078620A
		// (set) Token: 0x06037B3F RID: 228159 RVA: 0x00788012 File Offset: 0x00786212
		public TUnlockSystemOption Type { get; set; }

		// Token: 0x1700E6EA RID: 59114
		// (get) Token: 0x06037B40 RID: 228160 RVA: 0x0078801B File Offset: 0x0078621B
		// (set) Token: 0x06037B41 RID: 228161 RVA: 0x00788023 File Offset: 0x00786223
		public object Value { get; set; }

		// Token: 0x06037B42 RID: 228162 RVA: 0x0078802C File Offset: 0x0078622C
		public TUnlockSystemOptionUnion()
		{
			this.Type = TUnlockSystemOption.NONE;
			this.Value = null;
		}

		// Token: 0x06037B43 RID: 228163 RVA: 0x00788042 File Offset: 0x00786242
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037B44 RID: 228164 RVA: 0x00788054 File Offset: 0x00786254
		public IUnlockAchievementSystemItemT AsIUnlockAchievementSystemItem()
		{
			return this.As<IUnlockAchievementSystemItemT>();
		}

		// Token: 0x06037B45 RID: 228165 RVA: 0x0078805C File Offset: 0x0078625C
		public static TUnlockSystemOptionUnion FromIUnlockAchievementSystemItem(IUnlockAchievementSystemItemT _iunlockachievementsystemitem)
		{
			return new TUnlockSystemOptionUnion
			{
				Type = TUnlockSystemOption.IUnlockAchievementSystemItem,
				Value = _iunlockachievementsystemitem
			};
		}

		// Token: 0x06037B46 RID: 228166 RVA: 0x00788071 File Offset: 0x00786271
		public IUnlockAtlasSystemItemT AsIUnlockAtlasSystemItem()
		{
			return this.As<IUnlockAtlasSystemItemT>();
		}

		// Token: 0x06037B47 RID: 228167 RVA: 0x00788079 File Offset: 0x00786279
		public static TUnlockSystemOptionUnion FromIUnlockAtlasSystemItem(IUnlockAtlasSystemItemT _iunlockatlassystemitem)
		{
			return new TUnlockSystemOptionUnion
			{
				Type = TUnlockSystemOption.IUnlockAtlasSystemItem,
				Value = _iunlockatlassystemitem
			};
		}

		// Token: 0x06037B48 RID: 228168 RVA: 0x0078808E File Offset: 0x0078628E
		public IUnLockCookSystemItemT AsIUnLockCookSystemItem()
		{
			return this.As<IUnLockCookSystemItemT>();
		}

		// Token: 0x06037B49 RID: 228169 RVA: 0x00788096 File Offset: 0x00786296
		public static TUnlockSystemOptionUnion FromIUnLockCookSystemItem(IUnLockCookSystemItemT _iunlockcooksystemitem)
		{
			return new TUnlockSystemOptionUnion
			{
				Type = TUnlockSystemOption.IUnLockCookSystemItem,
				Value = _iunlockcooksystemitem
			};
		}

		// Token: 0x06037B4A RID: 228170 RVA: 0x007880AB File Offset: 0x007862AB
		public IUnLockDangoCollectSystemItemT AsIUnLockDangoCollectSystemItem()
		{
			return this.As<IUnLockDangoCollectSystemItemT>();
		}

		// Token: 0x06037B4B RID: 228171 RVA: 0x007880B3 File Offset: 0x007862B3
		public static TUnlockSystemOptionUnion FromIUnLockDangoCollectSystemItem(IUnLockDangoCollectSystemItemT _iunlockdangocollectsystemitem)
		{
			return new TUnlockSystemOptionUnion
			{
				Type = TUnlockSystemOption.IUnLockDangoCollectSystemItem,
				Value = _iunlockdangocollectsystemitem
			};
		}

		// Token: 0x06037B4C RID: 228172 RVA: 0x007880C8 File Offset: 0x007862C8
		public IUnlockPhotoMemoryCollectSystemItemT AsIUnlockPhotoMemoryCollectSystemItem()
		{
			return this.As<IUnlockPhotoMemoryCollectSystemItemT>();
		}

		// Token: 0x06037B4D RID: 228173 RVA: 0x007880D0 File Offset: 0x007862D0
		public static TUnlockSystemOptionUnion FromIUnlockPhotoMemoryCollectSystemItem(IUnlockPhotoMemoryCollectSystemItemT _iunlockphotomemorycollectsystemitem)
		{
			return new TUnlockSystemOptionUnion
			{
				Type = TUnlockSystemOption.IUnlockPhotoMemoryCollectSystemItem,
				Value = _iunlockphotomemorycollectsystemitem
			};
		}

		// Token: 0x06037B4E RID: 228174 RVA: 0x007880E8 File Offset: 0x007862E8
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
