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
	// Token: 0x02004BA3 RID: 19363
	public class SkipTaskManager : IStaticVariableResetter
	{
		// Token: 0x060322B8 RID: 205496 RVA: 0x00BA7FA4 File Offset: 0x00BA61A4
		static SkipTaskManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SkipTaskManager.CreateStaticDefaultValue), new Action(SkipTaskManager.ResetStaticDefaultValue));
		}

		// Token: 0x060322B9 RID: 205497 RVA: 0x00BA7FC4 File Offset: 0x00BA61C4
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
		}

		// Token: 0x060322BA RID: 205498 RVA: 0x00BA80B1 File Offset: 0x00BA62B1
		public static void ResetStaticDefaultValue()
		{
			SkipTaskManager.SkipTaskMap = null;
			SkipTaskManager.LimitRingViewNameList = null;
		}

		// Token: 0x060322BB RID: 205499 RVA: 0x00BA80BF File Offset: 0x00BA62BF
		public static void CheckContainRingView(EUiViewName viewName)
		{
			if (SkipTaskManager.CheckContainLimitViewName(viewName))
			{
				UiManager.Instance.CloseHistoryRingView(viewName, null);
			}
		}

		// Token: 0x060322BC RID: 205500 RVA: 0x00BA80D5 File Offset: 0x00BA62D5
		public static bool CheckContainLimitViewName(EUiViewName viewName)
		{
			return SkipTaskManager.LimitRingViewNameList.Contains(viewName);
		}

		// Token: 0x060322BD RID: 205501 RVA: 0x00BA80E4 File Offset: 0x00BA62E4
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

		// Token: 0x060322BE RID: 205502 RVA: 0x00BA82C4 File Offset: 0x00BA64C4
		public static void Run(ESkipName name, [Nullable(new byte[]
		{
			1,
			2
		})] params object[] @params)
		{
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

		// Token: 0x060322BF RID: 205503 RVA: 0x00BA82EC File Offset: 0x00BA64EC
		public static UniTask<ESkipTaskFinishType?> AsyncRun(ESkipName name, [Nullable(new byte[]
		{
			1,
			2
		})] params object[] @params)
		{
			SkipTaskManager.<AsyncRun>d__9 <AsyncRun>d__;
			<AsyncRun>d__.<>t__builder = AsyncUniTaskMethodBuilder<ESkipTaskFinishType?>.Create();
			<AsyncRun>d__.name = name;
			<AsyncRun>d__.@params = @params;
			<AsyncRun>d__.<>1__state = -1;
			<AsyncRun>d__.<>t__builder.Start<SkipTaskManager.<AsyncRun>d__9>(ref <AsyncRun>d__);
			return <AsyncRun>d__.<>t__builder.Task;
		}

		// Token: 0x060322C0 RID: 205504 RVA: 0x00BA8338 File Offset: 0x00BA6538
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

		// Token: 0x060322C1 RID: 205505 RVA: 0x00BA83B4 File Offset: 0x00BA65B4
		[NullableContext(2)]
		private static SkipTask GetSkipTask(ESkipName name)
		{
			SkipTask result;
			SkipTaskManager.SkipTaskMap.TryGetValue(name, out result);
			return result;
		}

		// Token: 0x060322C2 RID: 205506 RVA: 0x00BA83D0 File Offset: 0x00BA65D0
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

		// Token: 0x060322C3 RID: 205507 RVA: 0x00BA83FC File Offset: 0x00BA65FC
		public static void Clear()
		{
			foreach (SkipTask skipTask in SkipTaskManager.SkipTaskMap.Values)
			{
				skipTask.Destroy();
			}
			SkipTaskManager.SkipTaskMap.Clear();
			Log.Instance.Info(ELogModule.SkipInterface, ELogAuthor.TL, "[Clear] 清理所有跳转任务", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0401AB81 RID: 109441
		[Nullable(1)]
		private static Dictionary<ESkipName, SkipTask> SkipTaskMap;

		// Token: 0x0401AB82 RID: 109442
		[Nullable(1)]
		private static HashSet<EUiViewName> LimitRingViewNameList;
	}
}
