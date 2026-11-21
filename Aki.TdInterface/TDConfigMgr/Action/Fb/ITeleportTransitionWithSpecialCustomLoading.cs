using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200295A RID: 10586
	public class ITeleportTransitionWithSpecialCustomLoading : ITeleportTransitionType
	{
		// Token: 0x0600EAFB RID: 60155 RVA: 0x0022A4AD File Offset: 0x002286AD
		public static ITeleportTransitionWithSpecialCustomLoading Create(ITeleportTransitionWithSpecialCustomLoading? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportTransitionWithSpecialCustomLoading
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044F5 RID: 17653
		// (get) Token: 0x0600EAFC RID: 60156 RVA: 0x0022A4CC File Offset: 0x002286CC
		public override ETeleportTransitionType Type
		{
			get
			{
				return (ETeleportTransitionType)this.Instance.Type;
			}
		}

		// Token: 0x170044F6 RID: 17654
		// (get) Token: 0x0600EAFD RID: 60157 RVA: 0x0022A4D9 File Offset: 0x002286D9
		public virtual IHonamiStoryCustomLoading LoadingType
		{
			get
			{
				if (this._LoadingTypeInited)
				{
					return this._LoadingTypeCache;
				}
				this._LoadingTypeInited = true;
				this._LoadingTypeCache = IHonamiStoryCustomLoading.Create(this.Instance.LoadingType);
				return this._LoadingTypeCache;
			}
		}

		// Token: 0x0400816E RID: 33134
		private ITeleportTransitionWithSpecialCustomLoading Instance;

		// Token: 0x0400816F RID: 33135
		[Nullable(2)]
		private IHonamiStoryCustomLoading _LoadingTypeCache;

		// Token: 0x04008170 RID: 33136
		private bool _LoadingTypeInited;
	}
}
