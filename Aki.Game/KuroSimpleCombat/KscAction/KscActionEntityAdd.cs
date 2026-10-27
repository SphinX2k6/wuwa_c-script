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
	// Token: 0x020044E6 RID: 17638
	[NullableContext(1)]
	[Nullable(0)]
	public class KscActionEntityAdd : KscActionBase
	{
		// Token: 0x0602D6E5 RID: 186085 RVA: 0x00A413CD File Offset: 0x00A3F5CD
		public KscActionEntityAdd(IKscEntityParam params_) : base(params_.CreatureId)
		{
			this.Params = params_;
		}

		// Token: 0x0602D6E6 RID: 186086 RVA: 0x00A413E2 File Offset: 0x00A3F5E2
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

		// Token: 0x0602D6E7 RID: 186087 RVA: 0x00A4141C File Offset: 0x00A3F61C
		protected override UniTask RunContent()
		{
			KscActionEntityAdd.<RunContent>d__6 <RunContent>d__;
			<RunContent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RunContent>d__.<>4__this = this;
			<RunContent>d__.<>1__state = -1;
			<RunContent>d__.<>t__builder.Start<KscActionEntityAdd.<RunContent>d__6>(ref <RunContent>d__);
			return <RunContent>d__.<>t__builder.Task;
		}

		// Token: 0x0602D6E8 RID: 186088 RVA: 0x00A41460 File Offset: 0x00A3F660
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

		// Token: 0x0602D6E9 RID: 186089 RVA: 0x00A41582 File Offset: 0x00A3F782
		private void LoadKscAssetFailCallback(string error)
		{
			base.SetResult();
		}

		// Token: 0x0602D6EA RID: 186090 RVA: 0x00A4158C File Offset: 0x00A3F78C
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

		// Token: 0x0602D6EB RID: 186091 RVA: 0x00A415E0 File Offset: 0x00A3F7E0
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

		// Token: 0x0602D6EC RID: 186092 RVA: 0x00A41633 File Offset: 0x00A3F833
		private void StopWarningEffect()
		{
			if (this.WarningEffectId != 0)
			{
				EffectSystem.Instance.StopEffectById(this.WarningEffectId, "KSC_AppearWarning_Stop", true, new bool?(true));
				this.WarningEffectId = 0;
			}
		}

		// Token: 0x040184B3 RID: 99507
		public IKscEntityParam Params;

		// Token: 0x040184B4 RID: 99508
		[Nullable(2)]
		private UniTaskCompletionSource WarningPromise;

		// Token: 0x040184B5 RID: 99509
		[Nullable(2)]
		private TimerHandle WarningTimerHandle;

		// Token: 0x040184B6 RID: 99510
		private int WarningEffectId;
	}
}
