using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.JoinTeam;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x0200484E RID: 18510
	[NullableContext(1)]
	[Nullable(0)]
	public class InstanceDungeonGuideController : ControllerBase
	{
		// Token: 0x0602E90B RID: 190731 RVA: 0x00D006F1 File Offset: 0x00CFE8F1
		protected override bool OnInit()
		{
			InstanceDungeonGuideController.AddEvent();
			return true;
		}

		// Token: 0x0602E90C RID: 190732 RVA: 0x00D006F9 File Offset: 0x00CFE8F9
		protected override bool OnClear()
		{
			InstanceDungeonGuideController.RemoveEvent();
			return true;
		}

		// Token: 0x0602E90D RID: 190733 RVA: 0x00D00701 File Offset: 0x00CFE901
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

		// Token: 0x0602E90E RID: 190734 RVA: 0x00D0072E File Offset: 0x00CFE92E
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

		// Token: 0x0602E90F RID: 190735 RVA: 0x00D0075B File Offset: 0x00CFE95B
		public static void StartReplayGuide()
		{
			GuideModel.Instance.ClearAllGroup();
			InstanceDungeonGuideController.CheckAndRunGuide();
		}

		// Token: 0x0602E910 RID: 190736 RVA: 0x00D0076C File Offset: 0x00CFE96C
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

		// Token: 0x0602E911 RID: 190737 RVA: 0x00D007FE File Offset: 0x00CFE9FE
		private static void OnWorldDone()
		{
			InstanceDungeonGuideModel.Instance.RefreshCurrentDungeonGuide();
			if (InstanceDungeonGuideModel.Instance.GetHaveGuide())
			{
				InstanceDungeonGuideController.StartReplayGuide();
			}
		}

		// Token: 0x0602E912 RID: 190738 RVA: 0x00D0081B File Offset: 0x00CFEA1B
		public static bool GetHaveGuide()
		{
			return InstanceDungeonGuideModel.Instance.GetCurrentInstanceDungeonGuideType() != 0;
		}

		// Token: 0x17005E34 RID: 24116
		// (get) Token: 0x0602E913 RID: 190739 RVA: 0x00D0082A File Offset: 0x00CFEA2A
		public static InstanceDungeonGuideController Instance
		{
			get
			{
				return InstanceDungeonGuideController._Instance;
			}
		}

		// Token: 0x0602E914 RID: 190740 RVA: 0x00D00831 File Offset: 0x00CFEA31
		public static InstanceDungeonGuideController GetOrCreateInstance()
		{
			if (InstanceDungeonGuideController._Instance == null)
			{
				InstanceDungeonGuideController.CreateInstance();
			}
			return InstanceDungeonGuideController._Instance;
		}

		// Token: 0x0602E915 RID: 190741 RVA: 0x00D00845 File Offset: 0x00CFEA45
		public static bool CreateInstance()
		{
			if (InstanceDungeonGuideController._Instance != null)
			{
				return true;
			}
			InstanceDungeonGuideController._Instance = new InstanceDungeonGuideController();
			return true;
		}

		// Token: 0x0602E916 RID: 190742 RVA: 0x00D0085B File Offset: 0x00CFEA5B
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602E917 RID: 190743 RVA: 0x00D0085D File Offset: 0x00CFEA5D
		public static void ResetStaticDefaultValue()
		{
			InstanceDungeonGuideController._Instance = null;
		}

		// Token: 0x0602E918 RID: 190744 RVA: 0x00D00865 File Offset: 0x00CFEA65
		static InstanceDungeonGuideController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InstanceDungeonGuideController.CreateStaticDefaultValue), new Action(InstanceDungeonGuideController.ResetStaticDefaultValue));
		}

		// Token: 0x04018C80 RID: 101504
		[Nullable(2)]
		private static InstanceDungeonGuideController _Instance;

		// Token: 0x0200A4EB RID: 42219
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403314B RID: 209227
			[Nullable(0)]
			public static Action <0>__OnWorldDone;
		}
	}
}
