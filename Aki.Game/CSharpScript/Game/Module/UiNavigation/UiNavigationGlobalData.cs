using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BlackScreen;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038BB RID: 14523
	public class UiNavigationGlobalData : IStaticVariableResetter
	{
		// Token: 0x06025A35 RID: 154165 RVA: 0x00A97451 File Offset: 0x00A95651
		static UiNavigationGlobalData()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UiNavigationGlobalData.CreateStaticDefaultValue), new Action(UiNavigationGlobalData.ResetStaticDefaultValue));
		}

		// Token: 0x06025A36 RID: 154166 RVA: 0x00A97470 File Offset: 0x00A95670
		public static int GetListenerInstanceId()
		{
			return ++UiNavigationGlobalData.ListenerInstanceId;
		}

		// Token: 0x06025A37 RID: 154167 RVA: 0x00A97480 File Offset: 0x00A95680
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

		// Token: 0x06025A38 RID: 154168 RVA: 0x00A974C4 File Offset: 0x00A956C4
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

		// Token: 0x17004D3A RID: 19770
		// (get) Token: 0x06025A39 RID: 154169 RVA: 0x00A97507 File Offset: 0x00A95707
		public static bool IsBlockNavigation
		{
			get
			{
				return UiNavigationGlobalData.BlockListenerFocusTagList.Count > 0 || BlackScreenController.Instance.IsBlackScreenActive() || UiLayer.Instance.IsInMask();
			}
		}

		// Token: 0x06025A3A RID: 154170 RVA: 0x00A9752E File Offset: 0x00A9572E
		public static void ClearBlockListener()
		{
			UiNavigationGlobalData.BlockListenerFocusTagList.Clear();
		}

		// Token: 0x06025A3B RID: 154171 RVA: 0x00A9753A File Offset: 0x00A9573A
		public static void CreateStaticDefaultValue()
		{
			UiNavigationGlobalData.BlockListenerFocusTagList = new HashSet<string>();
		}

		// Token: 0x06025A3C RID: 154172 RVA: 0x00A97546 File Offset: 0x00A95746
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

		// Token: 0x04014CBF RID: 85183
		public static bool NeedCalculateCurrentPanel;

		// Token: 0x04014CC0 RID: 85184
		public static int NeedRefreshPanelId;

		// Token: 0x04014CC1 RID: 85185
		public static bool IsAllowCrossNavigationGroup;

		// Token: 0x04014CC2 RID: 85186
		public static bool IsAllowLoopScrollInteractHighlight;

		// Token: 0x04014CC3 RID: 85187
		public static bool VisionReplaceViewFindDefault;

		// Token: 0x04014CC4 RID: 85188
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static HashSet<string> BlockListenerFocusTagList;

		// Token: 0x04014CC5 RID: 85189
		private static int ListenerInstanceId;
	}
}
