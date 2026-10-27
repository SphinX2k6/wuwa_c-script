using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200201D RID: 8221
	[NullableContext(1)]
	[Nullable(0)]
	public class IUnlockAchievementSystemItem : IUnlockSystemItemType
	{
		// Token: 0x0600B4C2 RID: 46274 RVA: 0x001A42C8 File Offset: 0x001A24C8
		private IUnlockAchievementSystemItem_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IUnlockAchievementSystemItem 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IUnlockAchievementSystemItem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IUnlockAchievementSystemItem_SetValue());
			}
			return result;
		}

		// Token: 0x0600B4C3 RID: 46275 RVA: 0x001A4300 File Offset: 0x001A2500
		public static IUnlockAchievementSystemItem Create([Nullable(2)] IUnlockAchievementSystemItem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUnlockAchievementSystemItem
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B4C4 RID: 46276 RVA: 0x001A4313 File Offset: 0x001A2513
		public static IUnlockAchievementSystemItem CreateFromSetValue([Nullable(2)] IUnlockAchievementSystemItem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IUnlockAchievementSystemItem
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B4C5 RID: 46277 RVA: 0x001A4326 File Offset: 0x001A2526
		public new IUnlockAchievementSystemItem_SetValue ToSetValue()
		{
			return new IUnlockAchievementSystemItem_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x1700378E RID: 14222
		// (get) Token: 0x0600B4C6 RID: 46278 RVA: 0x001A4345 File Offset: 0x001A2545
		// (set) Token: 0x0600B4C7 RID: 46279 RVA: 0x001A4370 File Offset: 0x001A2570
		public override EUnlockSystemItemType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EUnlockSystemItemType.CookSystem;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700378F RID: 14223
		// (get) Token: 0x0600B4C8 RID: 46280 RVA: 0x001A437E File Offset: 0x001A257E
		// (set) Token: 0x0600B4C9 RID: 46281 RVA: 0x001A43A9 File Offset: 0x001A25A9
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x04006CE3 RID: 27875
		[Nullable(2)]
		protected new IUnlockAchievementSystemItem FbInstance;

		// Token: 0x04006CE4 RID: 27876
		[Nullable(2)]
		protected new IUnlockAchievementSystemItem_SetValue PocoInterface;
	}
}
