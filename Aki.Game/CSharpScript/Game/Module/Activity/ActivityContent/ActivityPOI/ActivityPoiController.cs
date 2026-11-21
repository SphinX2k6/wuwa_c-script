using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.ActivityPOI
{
	// Token: 0x0200587D RID: 22653
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ActivityPoiController : ActivityControllerBase
	{
		// Token: 0x06037D31 RID: 228657 RVA: 0x00F9CD94 File Offset: 0x00F9AF94
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x06037D32 RID: 228658 RVA: 0x00F9CD98 File Offset: 0x00F9AF98
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			RoleGuideActivity? config = ConfigRoleGuideActivityById.GetConfig(data.Id, true);
			if (!(((config != null) ? new int?(config.GetValueOrDefault().ClientPrefabType) : null) != 1))
			{
				return "UiItem_Activity37POI";
			}
			return "UiItem_ActivityRoleGuide";
		}

		// Token: 0x06037D33 RID: 228659 RVA: 0x00F9CDFC File Offset: 0x00F9AFFC
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			RoleGuideActivity? config = ConfigRoleGuideActivityById.GetConfig(data.Id, true);
			if (!(((config != null) ? new int?(config.GetValueOrDefault().ClientPrefabType) : null) != 1))
			{
				return new ActivityPoiSubView();
			}
			return new ActivitySubViewRoleGuide();
		}

		// Token: 0x06037D34 RID: 228660 RVA: 0x00F9CE60 File Offset: 0x00F9B060
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			RoleGuideActivity? config = ConfigRoleGuideActivityById.GetConfig(data.Id, true);
			if (!(((config != null) ? new int?(config.GetValueOrDefault().ClientPrefabType) : null) != 1))
			{
				return new ActivityPoiData();
			}
			return new ActivityRoleGuideData();
		}

		// Token: 0x06037D35 RID: 228661 RVA: 0x00F9CEC1 File Offset: 0x00F9B0C1
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x17006B2E RID: 27438
		// (get) Token: 0x06037D36 RID: 228662 RVA: 0x00F9CEC4 File Offset: 0x00F9B0C4
		public static ActivityPoiController Instance
		{
			get
			{
				return ActivityPoiController._Instance;
			}
		}

		// Token: 0x06037D37 RID: 228663 RVA: 0x00F9CECB File Offset: 0x00F9B0CB
		public static ActivityPoiController GetOrCreateInstance()
		{
			if (ActivityPoiController._Instance == null)
			{
				ActivityPoiController.CreateInstance();
			}
			return ActivityPoiController._Instance;
		}

		// Token: 0x06037D38 RID: 228664 RVA: 0x00F9CEDF File Offset: 0x00F9B0DF
		public static bool CreateInstance()
		{
			if (ActivityPoiController._Instance != null)
			{
				return true;
			}
			ActivityPoiController._Instance = new ActivityPoiController();
			return true;
		}

		// Token: 0x06037D39 RID: 228665 RVA: 0x00F9CEF5 File Offset: 0x00F9B0F5
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06037D3A RID: 228666 RVA: 0x00F9CEF7 File Offset: 0x00F9B0F7
		public static void ResetStaticDefaultValue()
		{
			ActivityPoiController._Instance = null;
		}

		// Token: 0x06037D3B RID: 228667 RVA: 0x00F9CEFF File Offset: 0x00F9B0FF
		static ActivityPoiController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityPoiController.CreateStaticDefaultValue), new Action(ActivityPoiController.ResetStaticDefaultValue));
		}

		// Token: 0x0401D760 RID: 120672
		[Nullable(2)]
		private static ActivityPoiController _Instance;
	}
}
