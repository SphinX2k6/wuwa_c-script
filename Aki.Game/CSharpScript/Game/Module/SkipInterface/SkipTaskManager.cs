using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.SkipInterface
{
	// Token: 0x02003B4D RID: 15181
	public class SkipTaskManager : IStaticVariableResetter
	{
		// Token: 0x06027048 RID: 159816 RVA: 0x00AEC110 File Offset: 0x00AEA310
		static SkipTaskManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SkipTaskManager.CreateStaticDefaultValue), new Action(SkipTaskManager.ResetStaticDefaultValue));
		}

		// Token: 0x06027049 RID: 159817 RVA: 0x00AEC130 File Offset: 0x00AEA330
		public static void CreateStaticDefaultValue()
		{
			SkipTaskManager.SkipTaskMap = new Dictionary<ESkipName, SkipTask>();
			SkipTaskManager.LimitRingViewNameList = new HashSet<EUiViewName>
			{
				EUiViewName.RoleRootView,
				EUiViewName.RoleDevelopRootView,
				EUiViewName.CalabashRootView,
				EUiViewName.SkinBuyDetailView,
				EUiViewName.FlySkinBuyDetailView,
				EUiViewName.SkinRootView,
				EUiViewName.MotorcycleRootView,
				EUiViewName.SpringManorAtmosphereLevelView,
				EUiViewName.FurnitureAreaSelectView,
				EUiViewName.CumulativeShopTaskView,
				EUiViewName.AdventureGuideView,
				EUiViewName.ActivityRecommendView,
				EUiViewName.RoleOrnamentShowView,
				EUiViewName.CommonActivityView,
				EUiViewName.GachaMainView,
				EUiViewName.MoonChasingTaskView,
				EUiViewName.BuildingTipsInfoView
			};
			SkipTaskManager.SkipForbiddenViewNameList = new HashSet<EUiViewName>
			{
				EUiViewName.SolarSchoolRootView,
				EUiViewName.SolarSchoolGalleryView
			};
		}

		// Token: 0x0602704A RID: 159818 RVA: 0x00AEC23F File Offset: 0x00AEA43F
		public static void ResetStaticDefaultValue()
		{
			SkipTaskManager.SkipTaskMap = null;
			SkipTaskManager.LimitRingViewNameList = null;
			SkipTaskManager.SkipForbiddenViewNameList = null;
		}

		// Token: 0x0602704B RID: 159819 RVA: 0x00AEC253 File Offset: 0x00AEA453
		public static void CheckContainRingView(EUiViewName viewName)
		{
			if (SkipTaskManager.CheckContainLimitViewName(viewName))
			{
				UiManager.Instance.CloseHistoryRingView(viewName, null);
			}
		}

		// Token: 0x0602704C RID: 159820 RVA: 0x00AEC269 File Offset: 0x00AEA469
		public static bool CheckContainLimitViewName(EUiViewName viewName)
		{
			return SkipTaskManager.LimitRingViewNameList.Contains(viewName);
		}

		// Token: 0x0602704D RID: 159821 RVA: 0x00AEC278 File Offset: 0x00AEA478
		private static bool CheckSkipForbidden()
		{
			foreach (EUiViewName euiViewName in SkipTaskManager.SkipForbiddenViewNameList)
			{
				if (UiManager.Instance.GetViewByName(euiViewName) != null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SkipInterface;
					ELogAuthor author = ELogAuthor.YYZ;
					string message = "存在黑名单界面，禁止跳转";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("viewName", euiViewName);
					instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					ScrollingTipsController.Instance.ShowTipsByTextId("SkipTask_Prevent", Array.Empty<object>());
					return true;
				}
			}
			return false;
		}

		// Token: 0x0602704E RID: 159822 RVA: 0x00AEC31C File Offset: 0x00AEA51C
		[NullableContext(2)]
		public unsafe static void RunByConfigId(int id, object @params = null)
		{
			AccessPath? accessPathConfig = SkipInterfaceConfig.Instance.GetAccessPathConfig(id);
			if (accessPathConfig == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SkipInterface;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "开始跳转任务时,没有在途径表中找到对应配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			ESkipName skipName = (ESkipName)accessPathConfig.Value.SkipName;
			if (skipName == ESkipName.NoSkip)
			{
				return;
			}
			if (SkipTaskManager.CheckSkipForbidden())
			{
				return;
			}
			FunctionModel instance2 = FunctionModel.Instance;
			foreach (KeyValuePair<int, string> keyValuePair in accessPathConfig.Value.FunctionOpenCheckMap())
			{
				int key = keyValuePair.Key;
				string value = keyValuePair.Value;
				if (!instance2.IsOpen(key))
				{
					Log instance3 = Log.Instance;
					ELogModule module2 = ELogModule.SkipInterface;
					ELogAuthor author2 = ELogAuthor.XXJ;
					string message2 = "开始跳转任务时,对应功能未开启，不会跳转";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("skipTaskName", skipName);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("functionId", key);
					instance3.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					GenericPromptController.Instance.ShowPromptByCode(value, Array.Empty<object>());
					return;
				}
			}
			SkipTask skipTask = SkipTaskManager.GetSkipTask(skipName);
			if (skipTask == null)
			{
				skipTask = SkipTaskManager.NewSkipTask(skipName);
			}
			if (skipTask == null)
			{
				Log instance4 = Log.Instance;
				ELogModule module3 = ELogModule.SkipInterface;
				ELogAuthor author3 = ELogAuthor.XXJ;
				string message3 = "开始跳转任务时,没有配对应的跳转任务";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("途径表Id", id);
				instance4.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			skipTask.Run(new object[]
			{
				accessPathConfig.Value.Val1,
				accessPathConfig.Value.Val2,
				accessPathConfig.Value.Val3,
				@params
			});
		}

		// Token: 0x0602704F RID: 159823 RVA: 0x00AEC504 File Offset: 0x00AEA704
		public static void Run(ESkipName name, [Nullable(new byte[]
		{
			1,
			2
		})] params object[] @params)
		{
			if (SkipTaskManager.CheckSkipForbidden())
			{
				return;
			}
			SkipTask skipTask = SkipTaskManager.GetSkipTask(name);
			if (skipTask == null)
			{
				skipTask = SkipTaskManager.NewSkipTask(name);
			}
			if (skipTask != null)
			{
				skipTask.Run(@params);
			}
		}

		// Token: 0x06027050 RID: 159824 RVA: 0x00AEC534 File Offset: 0x00AEA734
		public static UniTask<ESkipTaskFinishType?> AsyncRun(ESkipName name, [Nullable(new byte[]
		{
			1,
			2
		})] params object[] @params)
		{
			SkipTaskManager.<AsyncRun>d__11 <AsyncRun>d__;
			<AsyncRun>d__.<>t__builder = AsyncUniTaskMethodBuilder<ESkipTaskFinishType?>.Create();
			<AsyncRun>d__.name = name;
			<AsyncRun>d__.@params = @params;
			<AsyncRun>d__.<>1__state = -1;
			<AsyncRun>d__.<>t__builder.Start<SkipTaskManager.<AsyncRun>d__11>(ref <AsyncRun>d__);
			return <AsyncRun>d__.<>t__builder.Task;
		}

		// Token: 0x06027051 RID: 159825 RVA: 0x00AEC580 File Offset: 0x00AEA780
		[NullableContext(2)]
		private static SkipTask NewSkipTask(ESkipName name)
		{
			if (name < ESkipName.SkipToWorldMapView)
			{
				return null;
			}
			Dictionary<ESkipName, Type> skipClassMap = SkipInterfaceDefine.GetSkipClassMap();
			Type type;
			if (skipClassMap == null || !skipClassMap.TryGetValue(name, out type))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SkipInterface;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "创建跳转任务时，skipClassMap中找不到对应类";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Name", name);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			SkipTask skipTask = (SkipTask)Activator.CreateInstance(type);
			if (skipTask == null)
			{
				return null;
			}
			SkipTaskManager.SkipTaskMap[name] = skipTask;
			skipTask.Initialize();
			return skipTask;
		}

		// Token: 0x06027052 RID: 159826 RVA: 0x00AEC5FC File Offset: 0x00AEA7FC
		[NullableContext(2)]
		private static SkipTask GetSkipTask(ESkipName name)
		{
			SkipTask result;
			SkipTaskManager.SkipTaskMap.TryGetValue(name, out result);
			return result;
		}

		// Token: 0x06027053 RID: 159827 RVA: 0x00AEC618 File Offset: 0x00AEA818
		public static void Stop(ESkipName name)
		{
			SkipTask skipTask;
			if (!SkipTaskManager.SkipTaskMap.TryGetValue(name, out skipTask))
			{
				return;
			}
			if (!skipTask.GetIsRunning())
			{
				return;
			}
			skipTask.Stop();
		}

		// Token: 0x06027054 RID: 159828 RVA: 0x00AEC644 File Offset: 0x00AEA844
		public static void Clear()
		{
			foreach (SkipTask skipTask in SkipTaskManager.SkipTaskMap.Values)
			{
				skipTask.Destroy();
			}
			SkipTaskManager.SkipTaskMap.Clear();
			Log.Instance.Info(ELogModule.SkipInterface, ELogAuthor.TL, "[Clear] 清理所有跳转任务", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x040154D5 RID: 87253
		[Nullable(1)]
		private static Dictionary<ESkipName, SkipTask> SkipTaskMap;

		// Token: 0x040154D6 RID: 87254
		[Nullable(1)]
		private static HashSet<EUiViewName> LimitRingViewNameList;

		// Token: 0x040154D7 RID: 87255
		[Nullable(1)]
		private static HashSet<EUiViewName> SkipForbiddenViewNameList;
	}
}
