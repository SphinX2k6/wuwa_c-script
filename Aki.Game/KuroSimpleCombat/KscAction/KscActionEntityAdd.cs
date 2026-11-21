using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Effect;
using CSharpScript.Game.KuroSimpleCombat;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace KuroSimpleCombat.KscAction
{
	// Token: 0x02003032 RID: 12338
	[NullableContext(1)]
	[Nullable(0)]
	public class KscActionEntityAdd : KscActionBase
	{
		// Token: 0x0601D42F RID: 119855 RVA: 0x008EF265 File Offset: 0x008ED465
		public KscActionEntityAdd(IKscEntityParam params_) : base(params_.CreatureId)
		{
			this.Params = params_;
		}

		// Token: 0x0601D430 RID: 119856 RVA: 0x008EF27A File Offset: 0x008ED47A
		protected override void CancelContent()
		{
			if (this.WarningTimerHandle != null)
			{
				TimerSystem.Instance.Remove(this.WarningTimerHandle);
				this.WarningTimerHandle = null;
			}
			this.StopWarningEffect();
			UniTaskCompletionSource warningPromise = this.WarningPromise;
			if (warningPromise == null)
			{
				return;
			}
			warningPromise.TrySetResult();
		}

		// Token: 0x0601D431 RID: 119857 RVA: 0x008EF2B4 File Offset: 0x008ED4B4
		protected override UniTask RunContent()
		{
			KscActionEntityAdd.<RunContent>d__6 <RunContent>d__;
			<RunContent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RunContent>d__.<>4__this = this;
			<RunContent>d__.<>1__state = -1;
			<RunContent>d__.<>t__builder.Start<KscActionEntityAdd.<RunContent>d__6>(ref <RunContent>d__);
			return <RunContent>d__.<>t__builder.Task;
		}

		// Token: 0x0601D432 RID: 119858 RVA: 0x008EF2F8 File Offset: 0x008ED4F8
		private unsafe void LoadKscAssetCallback(UKSC_DA_Entity resultAsset)
		{
			if (!this.KscCtrl.WorldInit)
			{
				base.Warn(KscLog.EModule.Load, "战斗实体加载失败，KSC世界已清理", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.SetResult();
				return;
			}
			if (resultAsset == null || !resultAsset.IsValid())
			{
				KscLog.EModule flag = KscLog.EModule.Load;
				string log = "战斗实体加载失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Path", this.Params.AssetPath);
				base.Warn(flag, log, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				base.SetResult();
				return;
			}
			if (this.IsCancel)
			{
				KscLog.EModule flag2 = KscLog.EModule.Load;
				string log2 = "战斗实体加载完成任务被取消";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", this.EntityId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Class", base.GetType().Name);
				base.Warn(flag2, log2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				base.SetResult();
				return;
			}
			this.AddEntitySafe(resultAsset, this.Params).Then(delegate(AKSC_Entity kscEntity)
			{
				if (this.Params.FinishCallback != null && kscEntity != null)
				{
					this.Params.FinishCallback(kscEntity);
				}
			}).Finally(new Action(base.SetResult)).Forget(delegate(Exception error)
			{
				KscLog.EModule flag3 = KscLog.EModule.Load;
				string log3 = "安全加入战斗实体失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Path", this.Params.AssetPath);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("reason", error.Message);
				base.Warn(flag3, log3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			}, true);
		}

		// Token: 0x0601D433 RID: 119859 RVA: 0x008EF41A File Offset: 0x008ED61A
		private void LoadKscAssetFailCallback(string error)
		{
			base.SetResult();
		}

		// Token: 0x0601D434 RID: 119860 RVA: 0x008EF424 File Offset: 0x008ED624
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private UniTask<AKSC_Entity> AddEntitySafe(UKSC_DA_Entity asset, IKscEntityParam params_)
		{
			KscActionEntityAdd.<AddEntitySafe>d__9 <AddEntitySafe>d__;
			<AddEntitySafe>d__.<>t__builder = AsyncUniTaskMethodBuilder<AKSC_Entity>.Create();
			<AddEntitySafe>d__.<>4__this = this;
			<AddEntitySafe>d__.asset = asset;
			<AddEntitySafe>d__.params_ = params_;
			<AddEntitySafe>d__.<>1__state = -1;
			<AddEntitySafe>d__.<>t__builder.Start<KscActionEntityAdd.<AddEntitySafe>d__9>(ref <AddEntitySafe>d__);
			return <AddEntitySafe>d__.<>t__builder.Task;
		}

		// Token: 0x0601D435 RID: 119861 RVA: 0x008EF478 File Offset: 0x008ED678
		private UniTask PlayAppearWarning(UKSC_DA_Entity asset, IKscEntityParam params_)
		{
			KscActionEntityAdd.<PlayAppearWarning>d__10 <PlayAppearWarning>d__;
			<PlayAppearWarning>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayAppearWarning>d__.<>4__this = this;
			<PlayAppearWarning>d__.asset = asset;
			<PlayAppearWarning>d__.params_ = params_;
			<PlayAppearWarning>d__.<>1__state = -1;
			<PlayAppearWarning>d__.<>t__builder.Start<KscActionEntityAdd.<PlayAppearWarning>d__10>(ref <PlayAppearWarning>d__);
			return <PlayAppearWarning>d__.<>t__builder.Task;
		}

		// Token: 0x0601D436 RID: 119862 RVA: 0x008EF4CB File Offset: 0x008ED6CB
		private void StopWarningEffect()
		{
			if (this.WarningEffectId != 0)
			{
				EffectSystem.Instance.StopEffectById(this.WarningEffectId, "KSC_AppearWarning_Stop", true, new bool?(true));
				this.WarningEffectId = 0;
			}
		}

		// Token: 0x0400F67E RID: 63102
		public IKscEntityParam Params;

		// Token: 0x0400F67F RID: 63103
		[Nullable(2)]
		private UniTaskCompletionSource WarningPromise;

		// Token: 0x0400F680 RID: 63104
		[Nullable(2)]
		private TimerHandle WarningTimerHandle;

		// Token: 0x0400F681 RID: 63105
		private int WarningEffectId;
	}
}
