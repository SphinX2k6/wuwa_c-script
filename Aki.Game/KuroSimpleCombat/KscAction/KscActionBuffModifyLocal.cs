using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.KuroSimpleCombat;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace KuroSimpleCombat.KscAction
{
	// Token: 0x0200302F RID: 12335
	public class KscActionBuffModifyLocal : KscActionBase
	{
		// Token: 0x0601D426 RID: 119846 RVA: 0x008EED91 File Offset: 0x008ECF91
		public KscActionBuffModifyLocal(long creatureId, int kscEntityId, bool isAdd, int buffId) : base(creatureId)
		{
			this.KscEntityId = kscEntityId;
			this.IsAdd = isAdd;
			this.BuffId = buffId;
		}

		// Token: 0x0601D427 RID: 119847 RVA: 0x008EEDB0 File Offset: 0x008ECFB0
		protected override UniTask RunContent()
		{
			KscActionBuffModifyLocal.<RunContent>d__4 <RunContent>d__;
			<RunContent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RunContent>d__.<>4__this = this;
			<RunContent>d__.<>1__state = -1;
			<RunContent>d__.<>t__builder.Start<KscActionBuffModifyLocal.<RunContent>d__4>(ref <RunContent>d__);
			return <RunContent>d__.<>t__builder.Task;
		}

		// Token: 0x0601D428 RID: 119848 RVA: 0x008EEDF4 File Offset: 0x008ECFF4
		private unsafe void ModifyBuffAsync(int kscEntityId)
		{
			bool isAdd = this.IsAdd;
			int buffId = this.BuffId;
			KscEntityHandle kscEntityHandle;
			if (!this.KscCtrl.CurSubModel.KscEntities.TryGetValue(kscEntityId, out kscEntityHandle) || !kscEntityHandle.Valid)
			{
				KscLog.EModule flag = KscLog.EModule.Skill;
				string log = "刷新buff时失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("id", kscEntityId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("buffId", this.BuffId);
				base.Warn(flag, log, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				base.SetResult();
				return;
			}
			KSCBuff? kscbuff;
			string text = (ConfigKSCBuffById.GetConfig(buffId, true) != null) ? kscbuff.GetValueOrDefault().AssetPath : null;
			if (string.IsNullOrEmpty(text))
			{
				KscLog.EModule flag2 = KscLog.EModule.Skill;
				string log2 = "Buff路径非法";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("buffId", buffId);
				base.Error(flag2, log2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
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
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
				defaultInterpolatedStringHandler.AppendLiteral("添加buff失败,未查到资产,BuffId:");
				defaultInterpolatedStringHandler.AppendFormatted<int>(buffId);
				<>4__this.Warn(flag3, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				this.SetResult();
			};
			loadAssetParams.KscWorldHandle = KscEnv.Instance.KscWorldHandle;
			KscUtil.AsyncLoadKscAsset<UKSC_DA_Buff>(loadAssetParams);
		}

		// Token: 0x0400F679 RID: 63097
		public int KscEntityId;

		// Token: 0x0400F67A RID: 63098
		public bool IsAdd;

		// Token: 0x0400F67B RID: 63099
		public int BuffId;
	}
}
