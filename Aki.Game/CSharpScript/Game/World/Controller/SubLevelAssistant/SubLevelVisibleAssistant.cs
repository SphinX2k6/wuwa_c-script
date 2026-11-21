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
	// Token: 0x0200346A RID: 13418
	[NullableContext(1)]
	[Nullable(0)]
	public class SubLevelVisibleAssistant : ControllerAssistantBase
	{
		// Token: 0x0602242F RID: 140335 RVA: 0x009B45F1 File Offset: 0x009B27F1
		protected override void OnDestroy()
		{
			this.ClearPromise();
		}

		// Token: 0x06022430 RID: 140336 RVA: 0x009B45FC File Offset: 0x009B27FC
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

		// Token: 0x06022431 RID: 140337 RVA: 0x009B4648 File Offset: 0x009B2848
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

		// Token: 0x06022432 RID: 140338 RVA: 0x009B4693 File Offset: 0x009B2893
		private void InitPromise()
		{
			this.WaitSceneShotLoadedPromise = new CustomPromise<ELoadEffectResult>();
		}

		// Token: 0x06022433 RID: 140339 RVA: 0x009B46A0 File Offset: 0x009B28A0
		private void ClearPromise()
		{
			this.WaitSceneShotLoadedPromise = null;
		}

		// Token: 0x06022434 RID: 140340 RVA: 0x009B46AC File Offset: 0x009B28AC
		private void BeforeStartSetSubLevelsVisible(ClientPreEnableSubLevels @params)
		{
			IEnableSubLevelTransitionWithSceneCapture transitionOption = @params.TransitionOption;
			bool subLevelSwitching = (((transitionOption != null) ? new EEnableSubLevelTransitionType?(transitionOption.Type) : null) ?? ((EEnableSubLevelTransitionType)1)) != EEnableSubLevelTransitionType.SceneCapture || !transitionOption.IsAllowInput.GetValueOrDefault();
			SubLevelModel.Instance.SetSubLevelSwitching(subLevelSwitching);
			InputDistributeController.Instance.RefreshInputTag();
		}

		// Token: 0x06022435 RID: 140341 RVA: 0x009B471A File Offset: 0x009B291A
		private void AfterStartSetSubLevelsVisible(ClientPreEnableSubLevels @params)
		{
			SubLevelModel.Instance.UnsetSubLevelSwitching();
			InputDistributeController.Instance.RefreshInputTag();
		}

		// Token: 0x06022436 RID: 140342 RVA: 0x009B4730 File Offset: 0x009B2930
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

		// Token: 0x06022437 RID: 140343 RVA: 0x009B477C File Offset: 0x009B297C
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

		// Token: 0x06022438 RID: 140344 RVA: 0x009B47C8 File Offset: 0x009B29C8
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

		// Token: 0x06022439 RID: 140345 RVA: 0x009B4814 File Offset: 0x009B2A14
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

		// Token: 0x0602243A RID: 140346 RVA: 0x009B4860 File Offset: 0x009B2A60
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

		// Token: 0x0602243B RID: 140347 RVA: 0x009B48AC File Offset: 0x009B2AAC
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

		// Token: 0x0602243C RID: 140348 RVA: 0x009B4A08 File Offset: 0x009B2C08
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

		// Token: 0x04012DB0 RID: 77232
		[Nullable(2)]
		private CustomPromise<ELoadEffectResult> WaitSceneShotLoadedPromise;

		// Token: 0x04012DB1 RID: 77233
		private int ScreenCaptureEffectHandle;

		// Token: 0x04012DB2 RID: 77234
		private int Id;

		// Token: 0x04012DB3 RID: 77235
		private int GroupId;

		// Token: 0x04012DB4 RID: 77236
		[Nullable(2)]
		private GeneralContext Context;
	}
}
