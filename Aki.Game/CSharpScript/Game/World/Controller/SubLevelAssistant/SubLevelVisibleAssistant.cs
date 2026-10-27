using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect.Data;
using CSharpScript.Game.Effect;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Ui;
using CSharpScript.Game.World.Model;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.World.Controller.SubLevelAssistant
{
	// Token: 0x02004542 RID: 17730
	[NullableContext(1)]
	[Nullable(0)]
	public class SubLevelVisibleAssistant : ControllerAssistantBase
	{
		// Token: 0x0602DD4D RID: 187725 RVA: 0x00A88EBD File Offset: 0x00A870BD
		protected override void OnDestroy()
		{
			this.ClearPromise();
		}

		// Token: 0x0602DD4E RID: 187726 RVA: 0x00A88EC8 File Offset: 0x00A870C8
		[NullableContext(0)]
		public UniTask<bool> SetSubLevelVisible([Nullable(1)] SetSubLevelVisibleParams @params)
		{
			SubLevelVisibleAssistant.<SetSubLevelVisible>d__6 <SetSubLevelVisible>d__;
			<SetSubLevelVisible>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<SetSubLevelVisible>d__.<>4__this = this;
			<SetSubLevelVisible>d__.@params = @params;
			<SetSubLevelVisible>d__.<>1__state = -1;
			<SetSubLevelVisible>d__.<>t__builder.Start<SubLevelVisibleAssistant.<SetSubLevelVisible>d__6>(ref <SetSubLevelVisible>d__);
			return <SetSubLevelVisible>d__.<>t__builder.Task;
		}

		// Token: 0x0602DD4F RID: 187727 RVA: 0x00A88F14 File Offset: 0x00A87114
		[NullableContext(0)]
		private UniTask<bool> ExecuteImp([Nullable(1)] SetSubLevelVisibleParams @params)
		{
			SubLevelVisibleAssistant.<ExecuteImp>d__7 <ExecuteImp>d__;
			<ExecuteImp>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteImp>d__.<>4__this = this;
			<ExecuteImp>d__.@params = @params;
			<ExecuteImp>d__.<>1__state = -1;
			<ExecuteImp>d__.<>t__builder.Start<SubLevelVisibleAssistant.<ExecuteImp>d__7>(ref <ExecuteImp>d__);
			return <ExecuteImp>d__.<>t__builder.Task;
		}

		// Token: 0x0602DD50 RID: 187728 RVA: 0x00A88F5F File Offset: 0x00A8715F
		private void InitPromise()
		{
			this.WaitSceneShotLoadedPromise = new CustomPromise<ELoadEffectResult>();
		}

		// Token: 0x0602DD51 RID: 187729 RVA: 0x00A88F6C File Offset: 0x00A8716C
		private void ClearPromise()
		{
			this.WaitSceneShotLoadedPromise = null;
		}

		// Token: 0x0602DD52 RID: 187730 RVA: 0x00A88F78 File Offset: 0x00A87178
		private void BeforeStartSetSubLevelsVisible(ClientPreEnableSubLevels @params)
		{
			IEnableSubLevelTransitionWithSceneCapture transitionOption = @params.TransitionOption;
			bool subLevelSwitching = (((transitionOption != null) ? new EEnableSubLevelTransitionType?(transitionOption.Type) : null) ?? ((EEnableSubLevelTransitionType)1)) != EEnableSubLevelTransitionType.SceneCapture || !transitionOption.IsAllowInput.GetValueOrDefault();
			SubLevelModel.Instance.SetSubLevelSwitching(subLevelSwitching);
			InputDistributeController.Instance.RefreshInputTag();
		}

		// Token: 0x0602DD53 RID: 187731 RVA: 0x00A88FE6 File Offset: 0x00A871E6
		private void AfterStartSetSubLevelsVisible(ClientPreEnableSubLevels @params)
		{
			SubLevelModel.Instance.UnsetSubLevelSwitching();
			InputDistributeController.Instance.RefreshInputTag();
		}

		// Token: 0x0602DD54 RID: 187732 RVA: 0x00A88FFC File Offset: 0x00A871FC
		private UniTask StartSetSubLevelsVisible(ClientPreEnableSubLevels @params)
		{
			SubLevelVisibleAssistant.<StartSetSubLevelsVisible>d__12 <StartSetSubLevelsVisible>d__;
			<StartSetSubLevelsVisible>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<StartSetSubLevelsVisible>d__.<>4__this = this;
			<StartSetSubLevelsVisible>d__.@params = @params;
			<StartSetSubLevelsVisible>d__.<>1__state = -1;
			<StartSetSubLevelsVisible>d__.<>t__builder.Start<SubLevelVisibleAssistant.<StartSetSubLevelsVisible>d__12>(ref <StartSetSubLevelsVisible>d__);
			return <StartSetSubLevelsVisible>d__.<>t__builder.Task;
		}

		// Token: 0x0602DD55 RID: 187733 RVA: 0x00A89048 File Offset: 0x00A87248
		private UniTask SetVisibleImp(ClientPreEnableSubLevels @params)
		{
			SubLevelVisibleAssistant.<SetVisibleImp>d__13 <SetVisibleImp>d__;
			<SetVisibleImp>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetVisibleImp>d__.<>4__this = this;
			<SetVisibleImp>d__.@params = @params;
			<SetVisibleImp>d__.<>1__state = -1;
			<SetVisibleImp>d__.<>t__builder.Start<SubLevelVisibleAssistant.<SetVisibleImp>d__13>(ref <SetVisibleImp>d__);
			return <SetVisibleImp>d__.<>t__builder.Task;
		}

		// Token: 0x0602DD56 RID: 187734 RVA: 0x00A89094 File Offset: 0x00A87294
		private UniTask EnableLevel(string levelPath)
		{
			SubLevelVisibleAssistant.<EnableLevel>d__14 <EnableLevel>d__;
			<EnableLevel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<EnableLevel>d__.<>4__this = this;
			<EnableLevel>d__.levelPath = levelPath;
			<EnableLevel>d__.<>1__state = -1;
			<EnableLevel>d__.<>t__builder.Start<SubLevelVisibleAssistant.<EnableLevel>d__14>(ref <EnableLevel>d__);
			return <EnableLevel>d__.<>t__builder.Task;
		}

		// Token: 0x0602DD57 RID: 187735 RVA: 0x00A890E0 File Offset: 0x00A872E0
		private UniTask DisableLevel(string levelPath)
		{
			SubLevelVisibleAssistant.<DisableLevel>d__15 <DisableLevel>d__;
			<DisableLevel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DisableLevel>d__.<>4__this = this;
			<DisableLevel>d__.levelPath = levelPath;
			<DisableLevel>d__.<>1__state = -1;
			<DisableLevel>d__.<>t__builder.Start<SubLevelVisibleAssistant.<DisableLevel>d__15>(ref <DisableLevel>d__);
			return <DisableLevel>d__.<>t__builder.Task;
		}

		// Token: 0x0602DD58 RID: 187736 RVA: 0x00A8912C File Offset: 0x00A8732C
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<EffectScreenPlayData_C> PlayScreenEffect(string screenEffectPath)
		{
			SubLevelVisibleAssistant.<PlayScreenEffect>d__16 <PlayScreenEffect>d__;
			<PlayScreenEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder<EffectScreenPlayData_C>.Create();
			<PlayScreenEffect>d__.<>4__this = this;
			<PlayScreenEffect>d__.screenEffectPath = screenEffectPath;
			<PlayScreenEffect>d__.<>1__state = -1;
			<PlayScreenEffect>d__.<>t__builder.Start<SubLevelVisibleAssistant.<PlayScreenEffect>d__16>(ref <PlayScreenEffect>d__);
			return <PlayScreenEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602DD59 RID: 187737 RVA: 0x00A89178 File Offset: 0x00A87378
		private unsafe bool CheckLevelPathEmpty(string path, string enableOrDisable)
		{
			if (!StringUtils.IsBlank(path))
			{
				return false;
			}
			string text = "";
			if (this.Context != null)
			{
				EGeneralContextType? type = this.Context.Type;
				if (type != null)
				{
					EGeneralContextType valueOrDefault = type.GetValueOrDefault();
					if (valueOrDefault != EGeneralContextType.Entity)
					{
						if (valueOrDefault == EGeneralContextType.GeneralLogicTree)
						{
							GeneralLogicTreeContext generalLogicTreeContext = (GeneralLogicTreeContext)this.Context;
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
							defaultInterpolatedStringHandler.AppendFormatted<int>(generalLogicTreeContext.TreeConfigId);
							defaultInterpolatedStringHandler.AppendLiteral("_");
							defaultInterpolatedStringHandler.AppendFormatted<int>(generalLogicTreeContext.NodeId);
							text = defaultInterpolatedStringHandler.ToStringAndClear();
						}
					}
					else
					{
						EntityContext entityContext = (EntityContext)this.Context;
						Entity entity = EntitySystem.Instance.Get(entityContext.EntityId.Value);
						CreatureDataComponent creatureDataComponent = (entity != null) ? entity.GetComponent<CreatureDataComponent>() : null;
						text = ((creatureDataComponent != null) ? creatureDataComponent.GetPbDataId() : 0).ToString();
					}
				}
			}
			string obj = "想要" + enableOrDisable + "的子关卡路径为空,配置来源：" + text;
			ErrorCodeController.Instance.OpenConfirmBoxByText(obj);
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.LevelEvent;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "SubLevelController.SubLevelVisibleAssistant 想要disable的子关卡路径为空";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("subLevelPath", path);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("source", text);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return true;
		}

		// Token: 0x0602DD5A RID: 187738 RVA: 0x00A892D4 File Offset: 0x00A874D4
		private void RequestSetSubLevelVisible([Nullable(new byte[]
		{
			2,
			1
		})] IList<string> showSubLevels, [Nullable(new byte[]
		{
			2,
			1
		})] IList<string> hideSubLevels)
		{
			SceneSubLevelsRequest sceneSubLevelsRequest = SceneSubLevelsRequest.Create();
			if (showSubLevels != null && showSubLevels.Count > 0)
			{
				sceneSubLevelsRequest.ShowSubLevels.AddRange(showSubLevels);
			}
			if (hideSubLevels != null && hideSubLevels.Count > 0)
			{
				sceneSubLevelsRequest.HideSubLevels.AddRange(hideSubLevels);
			}
			Net.Instance.Call(ERequestMessageId.SceneSubLevelsRequest, sceneSubLevelsRequest, delegate(IMessage response, Net.CallbackStatus _)
			{
			}, 0);
		}

		// Token: 0x04018776 RID: 100214
		[Nullable(2)]
		private CustomPromise<ELoadEffectResult> WaitSceneShotLoadedPromise;

		// Token: 0x04018777 RID: 100215
		private int ScreenCaptureEffectHandle;

		// Token: 0x04018778 RID: 100216
		private int Id;

		// Token: 0x04018779 RID: 100217
		private int GroupId;

		// Token: 0x0401877A RID: 100218
		[Nullable(2)]
		private GeneralContext Context;
	}
}
