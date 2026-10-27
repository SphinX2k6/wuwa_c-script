using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BlackScreen;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004944 RID: 18756
	public class UiNavigationGlobalData : IStaticVariableResetter
	{
		// Token: 0x06030F08 RID: 200456 RVA: 0x00B5C5E1 File Offset: 0x00B5A7E1
		static UiNavigationGlobalData()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UiNavigationGlobalData.CreateStaticDefaultValue), new Action(UiNavigationGlobalData.ResetStaticDefaultValue));
		}

		// Token: 0x06030F09 RID: 200457 RVA: 0x00B5C600 File Offset: 0x00B5A800
		public static int GetListenerInstanceId()
		{
			return ++UiNavigationGlobalData.ListenerInstanceId;
		}

		// Token: 0x06030F0A RID: 200458 RVA: 0x00B5C610 File Offset: 0x00B5A810
		[NullableContext(1)]
		public static void AddBlockListenerFocusTag(string tag)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiNavigation;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "添加禁止切换导航对象标签";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("标签", tag);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			UiNavigationGlobalData.BlockListenerFocusTagList.Add(tag);
		}

		// Token: 0x06030F0B RID: 200459 RVA: 0x00B5C654 File Offset: 0x00B5A854
		[NullableContext(1)]
		public static void DeleteBlockListenerFocusTag(string tag)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiNavigation;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "移除禁止切换导航对象标签";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("标签", tag);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			UiNavigationGlobalData.BlockListenerFocusTagList.Remove(tag);
		}

		// Token: 0x170079D2 RID: 31186
		// (get) Token: 0x06030F0C RID: 200460 RVA: 0x00B5C697 File Offset: 0x00B5A897
		public static bool IsBlockNavigation
		{
			get
			{
				return UiNavigationGlobalData.BlockListenerFocusTagList.Count > 0 || BlackScreenController.Instance.IsBlackScreenActive() || UiLayer.Instance.IsInMask();
			}
		}

		// Token: 0x06030F0D RID: 200461 RVA: 0x00B5C6BE File Offset: 0x00B5A8BE
		public static void ClearBlockListener()
		{
			UiNavigationGlobalData.BlockListenerFocusTagList.Clear();
		}

		// Token: 0x06030F0E RID: 200462 RVA: 0x00B5C6CA File Offset: 0x00B5A8CA
		public static void CreateStaticDefaultValue()
		{
			UiNavigationGlobalData.BlockListenerFocusTagList = new HashSet<string>();
		}

		// Token: 0x06030F0F RID: 200463 RVA: 0x00B5C6D6 File Offset: 0x00B5A8D6
		public static void ResetStaticDefaultValue()
		{
			UiNavigationGlobalData.NeedCalculateCurrentPanel = false;
			UiNavigationGlobalData.NeedRefreshPanelId = 0;
			UiNavigationGlobalData.IsAllowCrossNavigationGroup = false;
			UiNavigationGlobalData.IsAllowLoopScrollInteractHighlight = false;
			UiNavigationGlobalData.VisionReplaceViewFindDefault = true;
			UiNavigationGlobalData.ListenerInstanceId = 0;
			UiNavigationGlobalData.BlockListenerFocusTagList = null;
		}

		// Token: 0x0401A44C RID: 107596
		public static bool NeedCalculateCurrentPanel;

		// Token: 0x0401A44D RID: 107597
		public static int NeedRefreshPanelId;

		// Token: 0x0401A44E RID: 107598
		public static bool IsAllowCrossNavigationGroup;

		// Token: 0x0401A44F RID: 107599
		public static bool IsAllowLoopScrollInteractHighlight;

		// Token: 0x0401A450 RID: 107600
		public static bool VisionReplaceViewFindDefault;

		// Token: 0x0401A451 RID: 107601
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static HashSet<string> BlockListenerFocusTagList;

		// Token: 0x0401A452 RID: 107602
		private static int ListenerInstanceId;
	}
}
