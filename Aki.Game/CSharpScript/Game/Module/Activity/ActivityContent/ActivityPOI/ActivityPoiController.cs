using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.ActivityPOI
{
	// Token: 0x0200692D RID: 26925
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ActivityPoiController : ActivityControllerBase
	{
		// Token: 0x060431D9 RID: 274905 RVA: 0x0105B768 File Offset: 0x01059968
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x060431DA RID: 274906 RVA: 0x0105B76C File Offset: 0x0105996C
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			RoleGuideActivity? config = ConfigRoleGuideActivityById.GetConfig(data.Id, true);
			if (!(((config != null) ? new int?(config.GetValueOrDefault().ClientPrefabType) : null) != 1))
			{
				return "UiItem_Activity37POI";
			}
			return "UiItem_ActivityRoleGuide";
		}

		// Token: 0x060431DB RID: 274907 RVA: 0x0105B7D0 File Offset: 0x010599D0
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			RoleGuideActivity? config = ConfigRoleGuideActivityById.GetConfig(data.Id, true);
			if (!(((config != null) ? new int?(config.GetValueOrDefault().ClientPrefabType) : null) != 1))
			{
				return new ActivityPoiSubView();
			}
			return new ActivitySubViewRoleGuide();
		}

		// Token: 0x060431DC RID: 274908 RVA: 0x0105B834 File Offset: 0x01059A34
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			RoleGuideActivity? config = ConfigRoleGuideActivityById.GetConfig(data.Id, true);
			if (!(((config != null) ? new int?(config.GetValueOrDefault().ClientPrefabType) : null) != 1))
			{
				return new ActivityPoiData();
			}
			return new ActivityRoleGuideData();
		}

		// Token: 0x060431DD RID: 274909 RVA: 0x0105B895 File Offset: 0x01059A95
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x170097EE RID: 38894
		// (get) Token: 0x060431DE RID: 274910 RVA: 0x0105B898 File Offset: 0x01059A98
		public static ActivityPoiController Instance
		{
			get
			{
				return ActivityPoiController._Instance;
			}
		}

		// Token: 0x060431DF RID: 274911 RVA: 0x0105B89F File Offset: 0x01059A9F
		public static ActivityPoiController GetOrCreateInstance()
		{
			if (ActivityPoiController._Instance == null)
			{
				ActivityPoiController.CreateInstance();
			}
			return ActivityPoiController._Instance;
		}

		// Token: 0x060431E0 RID: 274912 RVA: 0x0105B8B3 File Offset: 0x01059AB3
		public static bool CreateInstance()
		{
			if (ActivityPoiController._Instance != null)
			{
				return true;
			}
			ActivityPoiController._Instance = new ActivityPoiController();
			return true;
		}

		// Token: 0x060431E1 RID: 274913 RVA: 0x0105B8C9 File Offset: 0x01059AC9
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060431E2 RID: 274914 RVA: 0x0105B8CB File Offset: 0x01059ACB
		public static void ResetStaticDefaultValue()
		{
			ActivityPoiController._Instance = null;
		}

		// Token: 0x060431E3 RID: 274915 RVA: 0x0105B8D3 File Offset: 0x01059AD3
		static ActivityPoiController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityPoiController.CreateStaticDefaultValue), new Action(ActivityPoiController.ResetStaticDefaultValue));
		}

		// Token: 0x04022F04 RID: 143108
		[Nullable(2)]
		private static ActivityPoiController _Instance;
	}
}
