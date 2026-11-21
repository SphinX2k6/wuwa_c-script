using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.ResManager.Model
{
	// Token: 0x02003EDA RID: 16090
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class ResourceManagerModel : ModelBase
	{
		// Token: 0x06028CD5 RID: 167125 RVA: 0x00B72C40 File Offset: 0x00B70E40
		protected override bool OnInit()
		{
			IReadOnlyList<MapBlockInfo> configList = ConfigMapBlockInfoAll.GetConfigList(false);
			if (configList == null)
			{
				Log.Instance.Error(ELogModule.QuestResource, ELogAuthor.HWK, "找不到地块配置", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			foreach (MapBlockInfo mapBlockInfo in configList)
			{
				this.BlockIdToPackName[mapBlockInfo.BlockId] = mapBlockInfo.PakName;
			}
			IReadOnlyList<QuestRefMapBlockConfig> configList2 = ConfigQuestRefMapBlockConfigAll.GetConfigList(false);
			if (configList2 == null)
			{
				Log.Instance.Error(ELogModule.QuestResource, ELogAuthor.HWK, "找不到任务地块引用配置", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			foreach (QuestRefMapBlockConfig questRefMapBlockConfig in configList2)
			{
				this.QuestsRefBlocks[questRefMapBlockConfig.QuestId] = questRefMapBlockConfig.GetMapBlockIdArray();
			}
			return true;
		}

		// Token: 0x06028CD6 RID: 167126 RVA: 0x00B72D3C File Offset: 0x00B70F3C
		public unsafe void FillLoginInfo(int[] quests, ConfirmResourceSceneInfo[] sceneInfos)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.QuestResource;
			ELogAuthor author = ELogAuthor.HWK;
			string message = "填充登录资源信息";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("quests", quests);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("sceneInfos", sceneInfos);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.LoginQuestsInternal.Clear();
			foreach (int item in quests)
			{
				this.LoginQuestsInternal.Add(item);
			}
			this.LoginSceneInfosInternal.Clear();
			this.LoginSceneInfosInternal.AddRange(sceneInfos);
		}

		// Token: 0x170052EA RID: 21226
		// (get) Token: 0x06028CD7 RID: 167127 RVA: 0x00B72DDF File Offset: 0x00B70FDF
		public List<ConfirmResourceSceneInfo> LoginSceneInfos
		{
			get
			{
				return this.LoginSceneInfosInternal;
			}
		}

		// Token: 0x170052EB RID: 21227
		// (get) Token: 0x06028CD8 RID: 167128 RVA: 0x00B72DE7 File Offset: 0x00B70FE7
		public Dictionary<int, string> MapBlockIdToPackName
		{
			get
			{
				return this.BlockIdToPackName;
			}
		}

		// Token: 0x170052EC RID: 21228
		// (get) Token: 0x06028CD9 RID: 167129 RVA: 0x00B72DEF File Offset: 0x00B70FEF
		public HashSet<int> LoginQuests
		{
			get
			{
				return this.LoginQuestsInternal;
			}
		}

		// Token: 0x06028CDA RID: 167130 RVA: 0x00B72DF8 File Offset: 0x00B70FF8
		public void SetBlockDownloadState(int blockId, bool state)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.QuestResource;
			ELogAuthor author = ELogAuthor.HWK;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("设置地块下载状态: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(blockId);
			defaultInterpolatedStringHandler.AppendLiteral(" => ");
			defaultInterpolatedStringHandler.AppendFormatted<bool>(state);
			instance.Info(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			this.BlockDownloadState[blockId] = state;
		}

		// Token: 0x06028CDB RID: 167131 RVA: 0x00B72E64 File Offset: 0x00B71064
		public bool GetBlockDownloadState(int blockId)
		{
			bool result;
			if (!this.BlockDownloadState.TryGetValue(blockId, out result))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.QuestResource;
				ELogAuthor author = ELogAuthor.HWK;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
				defaultInterpolatedStringHandler.AppendLiteral("未知或未分包的地块ID: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(blockId);
				instance.Warn(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return true;
			}
			return result;
		}

		// Token: 0x06028CDC RID: 167132 RVA: 0x00B72EC0 File Offset: 0x00B710C0
		protected override bool OnClear()
		{
			return true;
		}

		// Token: 0x06028CDD RID: 167133 RVA: 0x00B72EC3 File Offset: 0x00B710C3
		protected override bool OnLeaveLevel()
		{
			return true;
		}

		// Token: 0x06028CDE RID: 167134 RVA: 0x00B72EC6 File Offset: 0x00B710C6
		protected override bool OnChangeMode()
		{
			return true;
		}

		// Token: 0x170052ED RID: 21229
		// (get) Token: 0x06028CDF RID: 167135 RVA: 0x00B72EC9 File Offset: 0x00B710C9
		public static ResourceManagerModel Instance
		{
			get
			{
				return ResourceManagerModel._Instance;
			}
		}

		// Token: 0x06028CE0 RID: 167136 RVA: 0x00B72ED0 File Offset: 0x00B710D0
		public static ResourceManagerModel GetOrCreateInstance()
		{
			if (ResourceManagerModel._Instance == null)
			{
				ResourceManagerModel.CreateInstance();
			}
			return ResourceManagerModel._Instance;
		}

		// Token: 0x06028CE1 RID: 167137 RVA: 0x00B72EE4 File Offset: 0x00B710E4
		public static bool CreateInstance()
		{
			if (ResourceManagerModel._Instance != null)
			{
				return true;
			}
			ResourceManagerModel._Instance = new ResourceManagerModel();
			return true;
		}

		// Token: 0x06028CE2 RID: 167138 RVA: 0x00B72EFA File Offset: 0x00B710FA
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06028CE3 RID: 167139 RVA: 0x00B72EFC File Offset: 0x00B710FC
		public static void ResetStaticDefaultValue()
		{
			ResourceManagerModel._Instance = null;
		}

		// Token: 0x06028CE4 RID: 167140 RVA: 0x00B72F04 File Offset: 0x00B71104
		static ResourceManagerModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ResourceManagerModel.CreateStaticDefaultValue), new Action(ResourceManagerModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401632E RID: 90926
		private readonly Dictionary<int, string> BlockIdToPackName = new Dictionary<int, string>();

		// Token: 0x0401632F RID: 90927
		private readonly HashSet<int> LoginQuestsInternal = new HashSet<int>();

		// Token: 0x04016330 RID: 90928
		private readonly List<ConfirmResourceSceneInfo> LoginSceneInfosInternal = new List<ConfirmResourceSceneInfo>();

		// Token: 0x04016331 RID: 90929
		private readonly Dictionary<int, bool> BlockDownloadState = new Dictionary<int, bool>();

		// Token: 0x04016332 RID: 90930
		public readonly Dictionary<int, int[]> QuestsRefBlocks = new Dictionary<int, int[]>();

		// Token: 0x04016333 RID: 90931
		public readonly HashSet<int> BlockNeedReOpenMap = new HashSet<int>();

		// Token: 0x04016334 RID: 90932
		[Nullable(2)]
		private static ResourceManagerModel _Instance;
	}
}
