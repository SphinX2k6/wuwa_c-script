using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.JoinTeam;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x02005876 RID: 22646
	[NullableContext(1)]
	[Nullable(0)]
	public class InstanceDungeonGuideController : ControllerBase
	{
		// Token: 0x060399EA RID: 236010 RVA: 0x00DB1821 File Offset: 0x00DAFA21
		protected override bool OnInit()
		{
			InstanceDungeonGuideController.AddEvent();
			return true;
		}

		// Token: 0x060399EB RID: 236011 RVA: 0x00DB1829 File Offset: 0x00DAFA29
		protected override bool OnClear()
		{
			InstanceDungeonGuideController.RemoveEvent();
			return true;
		}

		// Token: 0x060399EC RID: 236012 RVA: 0x00DB1831 File Offset: 0x00DAFA31
		private static void AddEvent()
		{
			EventSystem instance = EventSystem.Instance;
			EEventName name = EEventName.WorldDoneAndCloseLoading;
			Action handle;
			if ((handle = InstanceDungeonGuideController.<>O.<0>__OnWorldDone) == null)
			{
				handle = (InstanceDungeonGuideController.<>O.<0>__OnWorldDone = new Action(InstanceDungeonGuideController.OnWorldDone));
			}
			instance.Add(name, handle);
		}

		// Token: 0x060399ED RID: 236013 RVA: 0x00DB185E File Offset: 0x00DAFA5E
		private static void RemoveEvent()
		{
			EventSystem instance = EventSystem.Instance;
			EEventName name = EEventName.WorldDoneAndCloseLoading;
			Action handle;
			if ((handle = InstanceDungeonGuideController.<>O.<0>__OnWorldDone) == null)
			{
				handle = (InstanceDungeonGuideController.<>O.<0>__OnWorldDone = new Action(InstanceDungeonGuideController.OnWorldDone));
			}
			instance.Remove(name, handle);
		}

		// Token: 0x060399EE RID: 236014 RVA: 0x00DB188B File Offset: 0x00DAFA8B
		public static void StartReplayGuide()
		{
			GuideModel.Instance.ClearAllGroup();
			InstanceDungeonGuideController.CheckAndRunGuide();
		}

		// Token: 0x060399EF RID: 236015 RVA: 0x00DB189C File Offset: 0x00DAFA9C
		private static void CheckAndRunGuide()
		{
			int currentInstanceDungeonGuideType = InstanceDungeonGuideModel.Instance.GetCurrentInstanceDungeonGuideType();
			int currentInstanceDungeonGuideValue = InstanceDungeonGuideModel.Instance.GetCurrentInstanceDungeonGuideValue();
			switch (currentInstanceDungeonGuideType)
			{
			case 0:
				break;
			case 1:
				JoinTeamController.Instance.OpenJoinTeamView(currentInstanceDungeonGuideValue, false);
				return;
			case 2:
				UiManager.Instance.OpenView(EUiViewName.InstanceDungeonGuideView, null, null);
				return;
			case 3:
				if (!UiManager.Instance.IsViewShow(EUiViewName.GuideTutorialTipsView))
				{
					GuideController.Instance.TryStartGuide(currentInstanceDungeonGuideValue);
					return;
				}
				break;
			case 4:
				UiManager.Instance.OpenView(EUiViewName.RoleIntroductionView, currentInstanceDungeonGuideValue, null);
				break;
			default:
				return;
			}
		}

		// Token: 0x060399F0 RID: 236016 RVA: 0x00DB192E File Offset: 0x00DAFB2E
		private static void OnWorldDone()
		{
			InstanceDungeonGuideModel.Instance.RefreshCurrentDungeonGuide();
			if (InstanceDungeonGuideModel.Instance.GetHaveGuide())
			{
				InstanceDungeonGuideController.StartReplayGuide();
			}
		}

		// Token: 0x060399F1 RID: 236017 RVA: 0x00DB194B File Offset: 0x00DAFB4B
		public static bool GetHaveGuide()
		{
			return InstanceDungeonGuideModel.Instance.GetCurrentInstanceDungeonGuideType() != 0;
		}

		// Token: 0x17008A68 RID: 35432
		// (get) Token: 0x060399F2 RID: 236018 RVA: 0x00DB195A File Offset: 0x00DAFB5A
		public static InstanceDungeonGuideController Instance
		{
			get
			{
				return InstanceDungeonGuideController._Instance;
			}
		}

		// Token: 0x060399F3 RID: 236019 RVA: 0x00DB1961 File Offset: 0x00DAFB61
		public static InstanceDungeonGuideController GetOrCreateInstance()
		{
			if (InstanceDungeonGuideController._Instance == null)
			{
				InstanceDungeonGuideController.CreateInstance();
			}
			return InstanceDungeonGuideController._Instance;
		}

		// Token: 0x060399F4 RID: 236020 RVA: 0x00DB1975 File Offset: 0x00DAFB75
		public static bool CreateInstance()
		{
			if (InstanceDungeonGuideController._Instance != null)
			{
				return true;
			}
			InstanceDungeonGuideController._Instance = new InstanceDungeonGuideController();
			return true;
		}

		// Token: 0x060399F5 RID: 236021 RVA: 0x00DB198B File Offset: 0x00DAFB8B
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060399F6 RID: 236022 RVA: 0x00DB198D File Offset: 0x00DAFB8D
		public static void ResetStaticDefaultValue()
		{
			InstanceDungeonGuideController._Instance = null;
		}

		// Token: 0x060399F7 RID: 236023 RVA: 0x00DB1995 File Offset: 0x00DAFB95
		static InstanceDungeonGuideController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InstanceDungeonGuideController.CreateStaticDefaultValue), new Action(InstanceDungeonGuideController.ResetStaticDefaultValue));
		}

		// Token: 0x0401E1E3 RID: 123363
		[Nullable(2)]
		private static InstanceDungeonGuideController _Instance;

		// Token: 0x0200BAD2 RID: 47826
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403874A RID: 231242
			[Nullable(0)]
			public static Action <0>__OnWorldDone;
		}
	}
}
