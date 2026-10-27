using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.BlackScreen
{
	// Token: 0x02005C2B RID: 23595
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class BlackScreenController : UiControllerBase
	{
		// Token: 0x0603B995 RID: 244117 RVA: 0x00E37D35 File Offset: 0x00E35F35
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.UiManagerInit, new Action(this.PreloadBlackScreen));
		}

		// Token: 0x0603B996 RID: 244118 RVA: 0x00E37D50 File Offset: 0x00E35F50
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.UiManagerInit, new Action(this.PreloadBlackScreen));
		}

		// Token: 0x0603B997 RID: 244119 RVA: 0x00E37D6B File Offset: 0x00E35F6B
		private void PreloadBlackScreen()
		{
			this.GetOrCreateBlackScreen("Default");
		}

		// Token: 0x0603B998 RID: 244120 RVA: 0x00E37D7C File Offset: 0x00E35F7C
		private BlackScreenViewBase GetOrCreateBlackScreen(string style)
		{
			BlackScreenViewBase blackScreenViewBase;
			if (this.BlackScreens.TryGetValue(style, out blackScreenViewBase))
			{
				return blackScreenViewBase;
			}
			BlackScreenController.BlackScreenStyleConfig blackScreenStyleConfig = this.BlackScreenStyleConfigs[style];
			blackScreenViewBase = blackScreenStyleConfig.CreateView();
			this.BlackScreens[style] = blackScreenViewBase;
			blackScreenViewBase.CreateByResourceIdAsync(blackScreenStyleConfig.ResourceId, UiLayer.Instance.GetLayerRootUiItem(ELayerType.CG), true);
			return blackScreenViewBase;
		}

		// Token: 0x0603B999 RID: 244121 RVA: 0x00E37DE0 File Offset: 0x00E35FE0
		private Dictionary<string, int> GetTagSet(string style)
		{
			Dictionary<string, int> dictionary;
			if (!this.TagSets.TryGetValue(style, out dictionary))
			{
				dictionary = new Dictionary<string, int>();
				this.TagSets[style] = dictionary;
			}
			return dictionary;
		}

		// Token: 0x0603B99A RID: 244122 RVA: 0x00E37E14 File Offset: 0x00E36014
		public unsafe void AddBlackScreen(string showAnimType, string tag, string colorType = "Black", string style = "Default")
		{
			if (this.PendingDeferredTag == tag)
			{
				this.PendingDeferredTag = null;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BlackScreen;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "触发开始黑屏";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("标签", tag);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("颜色", colorType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("样式", style);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			Dictionary<string, int> tagSet = this.GetTagSet(style);
			if (tagSet.Count == 0)
			{
				this.GetOrCreateBlackScreen(style).ShowTemp(showAnimType, colorType);
			}
			int num;
			if (tagSet.TryGetValue(tag, out num))
			{
				num = (tagSet[tag] = num + 1);
				return;
			}
			tagSet[tag] = 1;
		}

		// Token: 0x0603B99B RID: 244123 RVA: 0x00E37EE8 File Offset: 0x00E360E8
		public void AddBlackScreenDeferred(string showAnimType, string tag)
		{
			if (this.GetTagSet("Default").Count > 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.BlackScreen;
				ELogAuthor author = ELogAuthor.HYF;
				string message = "触发延迟黑屏,但系统黑幕已打开,直接引用计数";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("标签", tag);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.AddBlackScreen(showAnimType, tag, "Black", "Default");
				return;
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.BlackScreen;
			ELogAuthor author2 = ELogAuthor.HYF;
			string message2 = "触发延迟黑屏,等待演出黑幕关闭时打开";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("标签", tag);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			this.PendingDeferredTag = tag;
			this.PendingDeferredAnimType = showAnimType;
		}

		// Token: 0x0603B99C RID: 244124 RVA: 0x00E37F80 File Offset: 0x00E36180
		public void ConsumePendingBlackScreen(string colorType)
		{
			if (this.PendingDeferredTag == null)
			{
				return;
			}
			string pendingDeferredTag = this.PendingDeferredTag;
			this.PendingDeferredTag = null;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BlackScreen;
			ELogAuthor author = ELogAuthor.HYF;
			string message = "演出黑幕关闭,消费延迟黑屏标记打开系统黑幕";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("标签", pendingDeferredTag);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.AddBlackScreen(this.PendingDeferredAnimType, pendingDeferredTag, colorType, "Default");
		}

		// Token: 0x0603B99D RID: 244125 RVA: 0x00E37FE4 File Offset: 0x00E361E4
		public UniTask AddBlackScreenAsync(string showAnimType, string tag, string colorType = "Black", string style = "Default")
		{
			BlackScreenController.<AddBlackScreenAsync>d__14 <AddBlackScreenAsync>d__;
			<AddBlackScreenAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AddBlackScreenAsync>d__.<>4__this = this;
			<AddBlackScreenAsync>d__.showAnimType = showAnimType;
			<AddBlackScreenAsync>d__.tag = tag;
			<AddBlackScreenAsync>d__.colorType = colorType;
			<AddBlackScreenAsync>d__.style = style;
			<AddBlackScreenAsync>d__.<>1__state = -1;
			<AddBlackScreenAsync>d__.<>t__builder.Start<BlackScreenController.<AddBlackScreenAsync>d__14>(ref <AddBlackScreenAsync>d__);
			return <AddBlackScreenAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B99E RID: 244126 RVA: 0x00E38048 File Offset: 0x00E36248
		public unsafe void RemoveBlackScreen(string hideAnimType, string tag, string style = "Default")
		{
			if (this.PendingDeferredTag == tag)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.BlackScreen;
				ELogAuthor author = ELogAuthor.HYF;
				string message = "取消未消费的延迟黑屏标记";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("标签", tag);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.PendingDeferredTag = null;
			}
			BlackScreenViewBase blackScreenViewBase;
			if (!this.BlackScreens.TryGetValue(style, out blackScreenViewBase))
			{
				return;
			}
			Dictionary<string, int> tagSet = this.GetTagSet(style);
			int num;
			if (!tagSet.TryGetValue(tag, out num) || num == 0)
			{
				return;
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.BlackScreen;
			ELogAuthor author2 = ELogAuthor.XXJ;
			string message2 = "触发结束黑屏";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("标签", tag);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("样式", style);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			if (num == 1)
			{
				tagSet.Remove(tag);
			}
			else
			{
				num = (tagSet[tag] = num - 1);
			}
			if (tagSet.Count == 0)
			{
				blackScreenViewBase.HideTemp(hideAnimType);
			}
		}

		// Token: 0x0603B99F RID: 244127 RVA: 0x00E3813C File Offset: 0x00E3633C
		public bool IsBlackScreenActive()
		{
			using (Dictionary<string, BlackScreenViewBase>.ValueCollection.Enumerator enumerator = this.BlackScreens.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsUiActiveInHierarchy())
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0603B9A0 RID: 244128 RVA: 0x00E3819C File Offset: 0x00E3639C
		protected override bool OnClear()
		{
			this.PendingDeferredTag = null;
			foreach (BlackScreenViewBase blackScreenViewBase in this.BlackScreens.Values)
			{
				blackScreenViewBase.Destroy(null);
			}
			this.BlackScreens.Clear();
			this.TagSets.Clear();
			return true;
		}

		// Token: 0x17008DAA RID: 36266
		// (get) Token: 0x0603B9A1 RID: 244129 RVA: 0x00E38210 File Offset: 0x00E36410
		public static BlackScreenController Instance
		{
			get
			{
				return BlackScreenController._Instance;
			}
		}

		// Token: 0x0603B9A2 RID: 244130 RVA: 0x00E38217 File Offset: 0x00E36417
		public static BlackScreenController GetOrCreateInstance()
		{
			if (BlackScreenController._Instance == null)
			{
				BlackScreenController.CreateInstance();
			}
			return BlackScreenController._Instance;
		}

		// Token: 0x0603B9A3 RID: 244131 RVA: 0x00E3822B File Offset: 0x00E3642B
		public static bool CreateInstance()
		{
			if (BlackScreenController._Instance != null)
			{
				return true;
			}
			BlackScreenController._Instance = new BlackScreenController();
			return true;
		}

		// Token: 0x0603B9A4 RID: 244132 RVA: 0x00E38241 File Offset: 0x00E36441
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603B9A5 RID: 244133 RVA: 0x00E38243 File Offset: 0x00E36443
		public static void ResetStaticDefaultValue()
		{
			BlackScreenController._Instance = null;
		}

		// Token: 0x0603B9A6 RID: 244134 RVA: 0x00E3824B File Offset: 0x00E3644B
		static BlackScreenController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BlackScreenController.CreateStaticDefaultValue), new Action(BlackScreenController.ResetStaticDefaultValue));
		}

		// Token: 0x0603B9A7 RID: 244135 RVA: 0x00E3826C File Offset: 0x00E3646C
		public BlackScreenController()
		{
			Dictionary<string, BlackScreenController.BlackScreenStyleConfig> dictionary = new Dictionary<string, BlackScreenController.BlackScreenStyleConfig>();
			string key = "Default";
			BlackScreenController.BlackScreenStyleConfig blackScreenStyleConfig = new BlackScreenController.BlackScreenStyleConfig();
			blackScreenStyleConfig.ResourceId = "UiView_BlackScreen_Prefab";
			blackScreenStyleConfig.CreateView = (() => new BlackScreenTransitionView());
			dictionary.Add(key, blackScreenStyleConfig);
			string key2 = "Formation3D";
			BlackScreenController.BlackScreenStyleConfig blackScreenStyleConfig2 = new BlackScreenController.BlackScreenStyleConfig();
			blackScreenStyleConfig2.ResourceId = "UiView_TeamSwitchLoading";
			blackScreenStyleConfig2.CreateView = (() => new BlackScreenFormationView());
			dictionary.Add(key2, blackScreenStyleConfig2);
			this.BlackScreenStyleConfigs = dictionary;
			this.BlackScreens = new Dictionary<string, BlackScreenViewBase>();
			this.TagSets = new Dictionary<string, Dictionary<string, int>>();
			this.PendingDeferredAnimType = "None";
			base..ctor();
		}

		// Token: 0x0401F073 RID: 127091
		private readonly Dictionary<string, BlackScreenController.BlackScreenStyleConfig> BlackScreenStyleConfigs;

		// Token: 0x0401F074 RID: 127092
		private readonly Dictionary<string, BlackScreenViewBase> BlackScreens;

		// Token: 0x0401F075 RID: 127093
		private readonly Dictionary<string, Dictionary<string, int>> TagSets;

		// Token: 0x0401F076 RID: 127094
		[Nullable(2)]
		private string PendingDeferredTag;

		// Token: 0x0401F077 RID: 127095
		private string PendingDeferredAnimType;

		// Token: 0x0401F078 RID: 127096
		[Nullable(2)]
		private static BlackScreenController _Instance;

		// Token: 0x0200BE15 RID: 48661
		[Nullable(0)]
		private class BlackScreenStyleConfig
		{
			// Token: 0x04039522 RID: 234786
			public string ResourceId = "";

			// Token: 0x04039523 RID: 234787
			public Func<BlackScreenViewBase> CreateView;
		}
	}
}
