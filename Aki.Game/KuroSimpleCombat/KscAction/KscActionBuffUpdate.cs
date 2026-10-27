using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.KuroSimpleCombat;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace KuroSimpleCombat.KscAction
{
	// Token: 0x020044E5 RID: 17637
	[NullableContext(1)]
	[Nullable(0)]
	public class KscActionBuffUpdate : KscActionBase
	{
		// Token: 0x0602D6E2 RID: 186082 RVA: 0x00A411A3 File Offset: 0x00A3F3A3
		public KscActionBuffUpdate(SimpleCombatEntityBuffUpdateNotify params_) : base(params_.EntityId)
		{
			this.Params = params_;
		}

		// Token: 0x0602D6E3 RID: 186083 RVA: 0x00A411B8 File Offset: 0x00A3F3B8
		protected override UniTask RunContent()
		{
			KscActionBuffUpdate.<RunContent>d__2 <RunContent>d__;
			<RunContent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RunContent>d__.<>4__this = this;
			<RunContent>d__.<>1__state = -1;
			<RunContent>d__.<>t__builder.Start<KscActionBuffUpdate.<RunContent>d__2>(ref <RunContent>d__);
			return <RunContent>d__.<>t__builder.Task;
		}

		// Token: 0x0602D6E4 RID: 186084 RVA: 0x00A411FC File Offset: 0x00A3F3FC
		private unsafe void ModifyBuffAsync(int kscEntityId)
		{
			bool isAdd = this.Params.IsBuffAdd;
			int buffId = this.Params.BuffId;
			KscEntityHandle kscEntityHandle;
			if (!this.KscCtrl.CurSubModel.KscEntities.TryGetValue(kscEntityId, out kscEntityHandle) || !kscEntityHandle.Valid)
			{
				KscLog.EModule flag = KscLog.EModule.Skill;
				string log = "刷新buff时失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("id", kscEntityId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Params", this.Params);
				base.Warn(flag, log, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				base.SetResult();
				return;
			}
			KSCBuff? kscbuff;
			string text = (ConfigKSCBuffById.GetConfig(buffId, true) != null) ? kscbuff.GetValueOrDefault().AssetPath : null;
			if (string.IsNullOrEmpty(text))
			{
				KscLog.EModule flag2 = KscLog.EModule.Skill;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Buff");
				defaultInterpolatedStringHandler.AppendFormatted<int>(buffId);
				defaultInterpolatedStringHandler.AppendLiteral("安全加载路径非法");
				string log2 = defaultInterpolatedStringHandler.ToStringAndClear();
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Params", this.Params);
				base.Warn(flag2, log2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				base.SetResult();
				return;
			}
			LoadAssetParams<UKSC_DA_Buff> loadAssetParams = new LoadAssetParams<UKSC_DA_Buff>();
			loadAssetParams.Context = KscEnv.Instance.KscWorld;
			loadAssetParams.Id = buffId;
			loadAssetParams.Path = text;
			UKSC_World kscWorld = KscEnv.Instance.KscWorld;
			loadAssetParams.NativeContainer = ((kscWorld != null) ? kscWorld.LoadedBuffDa : null);
			loadAssetParams.Callback = delegate(UKSC_DA_Buff resultAsset)
			{
				if (!this.KscCtrl.WorldInit)
				{
					this.Warn(KscLog.EModule.Load, "战斗实体加载失败，KSC世界已清理", default(ReadOnlySpan<ValueTuple<string, object>>));
					this.SetResult();
					return;
				}
				UKSC_World kscWorld2 = KscEnv.Instance.KscWorld;
				if (kscWorld2 != null)
				{
					UKSC_BuffId buffData = kscWorld2.BuffData;
					if (buffData != null)
					{
						buffData.AddBuffDA((long)buffId, resultAsset);
					}
				}
				if (isAdd)
				{
					kscEntityHandle.KscEntity.ApplyBuffSelf(resultAsset);
				}
				else
				{
					kscEntityHandle.KscEntity.RemoveBuffSelf(resultAsset);
				}
				this.SetResult();
			};
			loadAssetParams.FailCallback = delegate(string error)
			{
				KscActionBase <>4__this = this;
				KscLog.EModule flag3 = KscLog.EModule.Skill;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(22, 1);
				defaultInterpolatedStringHandler2.AppendLiteral("添加buff失败,未查到资产,BuffId:");
				defaultInterpolatedStringHandler2.AppendFormatted<int>(buffId);
				string log3 = defaultInterpolatedStringHandler2.ToStringAndClear();
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Params", this.Params);
				<>4__this.Warn(flag3, log3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				this.SetResult();
			};
			loadAssetParams.KscWorldHandle = KscEnv.Instance.KscWorldHandle;
			KscUtil.AsyncLoadKscAsset<UKSC_DA_Buff>(loadAssetParams);
		}

		// Token: 0x040184B2 RID: 99506
		public SimpleCombatEntityBuffUpdateNotify Params;
	}
}
