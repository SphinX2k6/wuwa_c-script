using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.BlackScreen
{
	// Token: 0x02004C0B RID: 19467
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class BlackScreenController : UiControllerBase
	{
		// Token: 0x060308E0 RID: 198880 RVA: 0x00D8809D File Offset: 0x00D8629D
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.UiManagerInit, new Action(this.PreloadBlackScreen));
		}

		// Token: 0x060308E1 RID: 198881 RVA: 0x00D880B8 File Offset: 0x00D862B8
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.UiManagerInit, new Action(this.PreloadBlackScreen));
		}

		// Token: 0x060308E2 RID: 198882 RVA: 0x00D880D3 File Offset: 0x00D862D3
		private void PreloadBlackScreen()
		{
			this.GetOrCreateBlackScreen("Default");
		}

		// Token: 0x060308E3 RID: 198883 RVA: 0x00D880E4 File Offset: 0x00D862E4
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

		// Token: 0x060308E4 RID: 198884 RVA: 0x00D88148 File Offset: 0x00D86348
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

		// Token: 0x060308E5 RID: 198885 RVA: 0x00D8817C File Offset: 0x00D8637C
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
			else if (showAnimType == "None")
			{
				this.GetOrCreateBlackScreen(style).CompleteShowImmediately();
			}
			int num;
			if (tagSet.TryGetValue(tag, out num))
			{
				num = (tagSet[tag] = num + 1);
				return;
			}
			tagSet[tag] = 1;
		}

		// Token: 0x060308E6 RID: 198886 RVA: 0x00D8826C File Offset: 0x00D8646C
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

		// Token: 0x060308E7 RID: 198887 RVA: 0x00D88304 File Offset: 0x00D86504
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

		// Token: 0x060308E8 RID: 198888 RVA: 0x00D88368 File Offset: 0x00D86568
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

		// Token: 0x060308E9 RID: 198889 RVA: 0x00D883CC File Offset: 0x00D865CC
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

		// Token: 0x060308EA RID: 198890 RVA: 0x00D884C0 File Offset: 0x00D866C0
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

		// Token: 0x060308EB RID: 198891 RVA: 0x00D88520 File Offset: 0x00D86720
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

		// Token: 0x1700617C RID: 24956
		// (get) Token: 0x060308EC RID: 198892 RVA: 0x00D88594 File Offset: 0x00D86794
		public static BlackScreenController Instance
		{
			get
			{
				return BlackScreenController._Instance;
			}
		}

		// Token: 0x060308ED RID: 198893 RVA: 0x00D8859B File Offset: 0x00D8679B
		public static BlackScreenController GetOrCreateInstance()
		{
			if (BlackScreenController._Instance == null)
			{
				BlackScreenController.CreateInstance();
			}
			return BlackScreenController._Instance;
		}

		// Token: 0x060308EE RID: 198894 RVA: 0x00D885AF File Offset: 0x00D867AF
		public static bool CreateInstance()
		{
			if (BlackScreenController._Instance != null)
			{
				return true;
			}
			BlackScreenController._Instance = new BlackScreenController();
			return true;
		}

		// Token: 0x060308EF RID: 198895 RVA: 0x00D885C5 File Offset: 0x00D867C5
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060308F0 RID: 198896 RVA: 0x00D885C7 File Offset: 0x00D867C7
		public static void ResetStaticDefaultValue()
		{
			BlackScreenController._Instance = null;
		}

		// Token: 0x060308F1 RID: 198897 RVA: 0x00D885CF File Offset: 0x00D867CF
		static BlackScreenController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BlackScreenController.CreateStaticDefaultValue), new Action(BlackScreenController.ResetStaticDefaultValue));
		}

		// Token: 0x060308F2 RID: 198898 RVA: 0x00D885F0 File Offset: 0x00D867F0
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

		// Token: 0x04019B24 RID: 105252
		private readonly Dictionary<string, BlackScreenController.BlackScreenStyleConfig> BlackScreenStyleConfigs;

		// Token: 0x04019B25 RID: 105253
		private readonly Dictionary<string, BlackScreenViewBase> BlackScreens;

		// Token: 0x04019B26 RID: 105254
		private readonly Dictionary<string, Dictionary<string, int>> TagSets;

		// Token: 0x04019B27 RID: 105255
		[Nullable(2)]
		private string PendingDeferredTag;

		// Token: 0x04019B28 RID: 105256
		private string PendingDeferredAnimType;

		// Token: 0x04019B29 RID: 105257
		[Nullable(2)]
		private static BlackScreenController _Instance;

		// Token: 0x0200A81D RID: 43037
		[Nullable(0)]
		private class BlackScreenStyleConfig
		{
			// Token: 0x04033EE5 RID: 212709
			public string ResourceId = "";

			// Token: 0x04033EE6 RID: 212710
			public Func<BlackScreenViewBase> CreateView;
		}
	}
}
