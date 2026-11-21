using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021F5 RID: 8693
	public class ITeleportTransitionWithFadeInScreen : ITeleportTransitionType
	{
		// Token: 0x0600BD76 RID: 48502 RVA: 0x001B6150 File Offset: 0x001B4350
		private ITeleportTransitionWithFadeInScreen_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITeleportTransitionWithFadeInScreen 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITeleportTransitionWithFadeInScreen_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITeleportTransitionWithFadeInScreen_SetValue());
			}
			return result;
		}

		// Token: 0x0600BD77 RID: 48503 RVA: 0x001B6188 File Offset: 0x001B4388
		public static ITeleportTransitionWithFadeInScreen Create([Nullable(2)] ITeleportTransitionWithFadeInScreen instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportTransitionWithFadeInScreen
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BD78 RID: 48504 RVA: 0x001B619B File Offset: 0x001B439B
		public static ITeleportTransitionWithFadeInScreen CreateFromSetValue([Nullable(2)] ITeleportTransitionWithFadeInScreen_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITeleportTransitionWithFadeInScreen
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BD79 RID: 48505 RVA: 0x001B61AE File Offset: 0x001B43AE
		public new ITeleportTransitionWithFadeInScreen_SetValue ToSetValue()
		{
			return new ITeleportTransitionWithFadeInScreen_SetValue
			{
				Type = this.Type,
				ScreenType = this.ScreenType
			};
		}

		// Token: 0x170039DB RID: 14811
		// (get) Token: 0x0600BD7A RID: 48506 RVA: 0x001B61CD File Offset: 0x001B43CD
		// (set) Token: 0x0600BD7B RID: 48507 RVA: 0x001B61F8 File Offset: 0x001B43F8
		public override ETeleportTransitionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETeleportTransitionType.PlayMp4;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170039DC RID: 14812
		// (get) Token: 0x0600BD7C RID: 48508 RVA: 0x001B6208 File Offset: 0x001B4408
		// (set) Token: 0x0600BD7D RID: 48509 RVA: 0x001B6242 File Offset: 0x001B4442
		public virtual EFadeInScreenShowType? ScreenType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ScreenType;
				}
				ITeleportTransitionWithFadeInScreen_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ScreenType;
			}
			set
			{
				this.GetOrCreatePoco().ScreenType = value;
			}
		}

		// Token: 0x040071BE RID: 29118
		[Nullable(2)]
		protected new ITeleportTransitionWithFadeInScreen FbInstance;

		// Token: 0x040071BF RID: 29119
		[Nullable(2)]
		protected new ITeleportTransitionWithFadeInScreen_SetValue PocoInterface;
	}
}
