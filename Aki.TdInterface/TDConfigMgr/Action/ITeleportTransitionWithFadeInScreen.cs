using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FB2 RID: 8114
	[NullableContext(1)]
	[Nullable(0)]
	public class ITeleportTransitionWithFadeInScreen : ITeleportTransitionType
	{
		// Token: 0x0600B272 RID: 45682 RVA: 0x0019FDA0 File Offset: 0x0019DFA0
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

		// Token: 0x0600B273 RID: 45683 RVA: 0x0019FDD8 File Offset: 0x0019DFD8
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

		// Token: 0x0600B274 RID: 45684 RVA: 0x0019FDEB File Offset: 0x0019DFEB
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

		// Token: 0x0600B275 RID: 45685 RVA: 0x0019FDFE File Offset: 0x0019DFFE
		public new ITeleportTransitionWithFadeInScreen_SetValue ToSetValue()
		{
			return new ITeleportTransitionWithFadeInScreen_SetValue
			{
				Type = this.Type,
				ScreenType = this.ScreenType
			};
		}

		// Token: 0x17003706 RID: 14086
		// (get) Token: 0x0600B276 RID: 45686 RVA: 0x0019FE1D File Offset: 0x0019E01D
		// (set) Token: 0x0600B277 RID: 45687 RVA: 0x0019FE48 File Offset: 0x0019E048
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

		// Token: 0x17003707 RID: 14087
		// (get) Token: 0x0600B278 RID: 45688 RVA: 0x0019FE58 File Offset: 0x0019E058
		// (set) Token: 0x0600B279 RID: 45689 RVA: 0x0019FE92 File Offset: 0x0019E092
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

		// Token: 0x04006BC3 RID: 27587
		[Nullable(2)]
		protected new ITeleportTransitionWithFadeInScreen FbInstance;

		// Token: 0x04006BC4 RID: 27588
		[Nullable(2)]
		protected new ITeleportTransitionWithFadeInScreen_SetValue PocoInterface;
	}
}
