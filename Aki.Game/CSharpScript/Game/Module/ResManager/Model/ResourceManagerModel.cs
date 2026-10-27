using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.ResManager.Model
{
	// Token: 0x02004F11 RID: 20241
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class ResourceManagerModel : ModelBase
	{
		// Token: 0x06033E6A RID: 212586 RVA: 0x00C29650 File Offset: 0x00C27850
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

		// Token: 0x06033E6B RID: 212587 RVA: 0x00C2974C File Offset: 0x00C2794C
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

		// Token: 0x17007F3A RID: 32570
		// (get) Token: 0x06033E6C RID: 212588 RVA: 0x00C297EF File Offset: 0x00C279EF
		public List<ConfirmResourceSceneInfo> LoginSceneInfos
		{
			get
			{
				return this.LoginSceneInfosInternal;
			}
		}

		// Token: 0x17007F3B RID: 32571
		// (get) Token: 0x06033E6D RID: 212589 RVA: 0x00C297F7 File Offset: 0x00C279F7
		public Dictionary<int, string> MapBlockIdToPackName
		{
			get
			{
				return this.BlockIdToPackName;
			}
		}

		// Token: 0x17007F3C RID: 32572
		// (get) Token: 0x06033E6E RID: 212590 RVA: 0x00C297FF File Offset: 0x00C279FF
		public HashSet<int> LoginQuests
		{
			get
			{
				return this.LoginQuestsInternal;
			}
		}

		// Token: 0x06033E6F RID: 212591 RVA: 0x00C29808 File Offset: 0x00C27A08
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

		// Token: 0x06033E70 RID: 212592 RVA: 0x00C29874 File Offset: 0x00C27A74
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

		// Token: 0x06033E71 RID: 212593 RVA: 0x00C298D0 File Offset: 0x00C27AD0
		protected override bool OnClear()
		{
			return true;
		}

		// Token: 0x06033E72 RID: 212594 RVA: 0x00C298D3 File Offset: 0x00C27AD3
		protected override bool OnLeaveLevel()
		{
			return true;
		}

		// Token: 0x06033E73 RID: 212595 RVA: 0x00C298D6 File Offset: 0x00C27AD6
		protected override bool OnChangeMode()
		{
			return true;
		}

		// Token: 0x17007F3D RID: 32573
		// (get) Token: 0x06033E74 RID: 212596 RVA: 0x00C298D9 File Offset: 0x00C27AD9
		public static ResourceManagerModel Instance
		{
			get
			{
				return ResourceManagerModel._Instance;
			}
		}

		// Token: 0x06033E75 RID: 212597 RVA: 0x00C298E0 File Offset: 0x00C27AE0
		public static ResourceManagerModel GetOrCreateInstance()
		{
			if (ResourceManagerModel._Instance == null)
			{
				ResourceManagerModel.CreateInstance();
			}
			return ResourceManagerModel._Instance;
		}

		// Token: 0x06033E76 RID: 212598 RVA: 0x00C298F4 File Offset: 0x00C27AF4
		public static bool CreateInstance()
		{
			if (ResourceManagerModel._Instance != null)
			{
				return true;
			}
			ResourceManagerModel._Instance = new ResourceManagerModel();
			return true;
		}

		// Token: 0x06033E77 RID: 212599 RVA: 0x00C2990A File Offset: 0x00C27B0A
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06033E78 RID: 212600 RVA: 0x00C2990C File Offset: 0x00C27B0C
		public static void ResetStaticDefaultValue()
		{
			ResourceManagerModel._Instance = null;
		}

		// Token: 0x06033E79 RID: 212601 RVA: 0x00C29914 File Offset: 0x00C27B14
		static ResourceManagerModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ResourceManagerModel.CreateStaticDefaultValue), new Action(ResourceManagerModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401B95B RID: 112987
		private readonly Dictionary<int, string> BlockIdToPackName = new Dictionary<int, string>();

		// Token: 0x0401B95C RID: 112988
		private readonly HashSet<int> LoginQuestsInternal = new HashSet<int>();

		// Token: 0x0401B95D RID: 112989
		private readonly List<ConfirmResourceSceneInfo> LoginSceneInfosInternal = new List<ConfirmResourceSceneInfo>();

		// Token: 0x0401B95E RID: 112990
		private readonly Dictionary<int, bool> BlockDownloadState = new Dictionary<int, bool>();

		// Token: 0x0401B95F RID: 112991
		public readonly Dictionary<int, int[]> QuestsRefBlocks = new Dictionary<int, int[]>();

		// Token: 0x0401B960 RID: 112992
		public readonly HashSet<int> BlockNeedReOpenMap = new HashSet<int>();

		// Token: 0x0401B961 RID: 112993
		[Nullable(2)]
		private static ResourceManagerModel _Instance;
	}
}
