using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.MapRogue;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf.Collections;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004EE8 RID: 20200
	public class RogueBattleLinkUnlockView : UiViewBase
	{
		// Token: 0x06033D64 RID: 212324 RVA: 0x00C240A7 File Offset: 0x00C222A7
		[NullableContext(1)]
		public RogueBattleLinkUnlockView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06033D65 RID: 212325 RVA: 0x00C240B0 File Offset: 0x00C222B0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUITexture)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(5, new Action(this.OnClickConfirm))
			};
		}

		// Token: 0x06033D66 RID: 212326 RVA: 0x00C24170 File Offset: 0x00C22370
		protected override UniTask OnBeforeStartAsync()
		{
			RogueBattleLinkUnlockView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleLinkUnlockView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033D67 RID: 212327 RVA: 0x00C241B3 File Offset: 0x00C223B3
		protected override void OnBeforeHide()
		{
			if (this.UiViewSequence.HasSequenceNameInPlaying("Start"))
			{
				this.UiViewSequence.StopSequenceByKey("Start", false, true);
			}
		}

		// Token: 0x06033D68 RID: 212328 RVA: 0x00C241DC File Offset: 0x00C223DC
		protected void RefreshLinkInfo()
		{
			MapRogueOpRoleBuffBondLinkId mapRogueOpRoleBuffBondLinkId = (MapRogueOpRoleBuffBondLinkId)MapRogueModel.Instance.GetOpData((int)this.OpenParam);
			if (mapRogueOpRoleBuffBondLinkId == null)
			{
				return;
			}
			RepeatedField<int> linkId = mapRogueOpRoleBuffBondLinkId.Data.RollBuffBondLinkIdOp.LinkId;
			if (linkId == null || this.CurrentIndex >= linkId.Count)
			{
				return;
			}
			int id = linkId[this.CurrentIndex];
			RogueResBond? rogueResBond = RogueBattleConfig.Instance.GetRogueResBond(id);
			if (rogueResBond == null)
			{
				return;
			}
			base.SetTextureShowUntilLoaded(rogueResBond.Value.Icon, base.GetTexture(3), null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), rogueResBond.Value.Name, Array.Empty<object>());
			RoleBondInfo roleBondDataById = RogueBattleModel.Instance.GetRoleBondDataById(id);
			if (roleBondDataById == null)
			{
				return;
			}
			int level = roleBondDataById.Level;
			string linkEffectDesc = rogueResBond.Value.GetLinkEffectDesc(level);
			string linkEffectDescParam = rogueResBond.Value.GetLinkEffectDescParam(level);
			if (linkEffectDesc != null && linkEffectDescParam != null)
			{
				string[] args = linkEffectDescParam.Split('#', StringSplitOptions.None);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(4), linkEffectDesc, args);
			}
		}

		// Token: 0x06033D69 RID: 212329 RVA: 0x00C24300 File Offset: 0x00C22500
		protected void OnClickConfirm()
		{
			MapRogueOpRoleBuffBondLinkId mapRogueOpRoleBuffBondLinkId = (MapRogueOpRoleBuffBondLinkId)MapRogueModel.Instance.GetOpData((int)this.OpenParam);
			if (mapRogueOpRoleBuffBondLinkId == null)
			{
				return;
			}
			RepeatedField<int> linkId = mapRogueOpRoleBuffBondLinkId.Data.RollBuffBondLinkIdOp.LinkId;
			if (linkId == null || this.CurrentIndex >= linkId.Count - 1)
			{
				MapRogueModel.Instance.ExecuteOpData((int)this.OpenParam, null);
				return;
			}
			this.CurrentIndex++;
			this.RefreshLinkInfo();
			if (this.UiViewSequence.HasSequenceNameInPlaying("Start"))
			{
				this.UiViewSequence.ReplaySequence("Start");
				return;
			}
			this.UiViewSequence.PlaySequence("Start", false, null);
		}

		// Token: 0x0401B891 RID: 112785
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401B892 RID: 112786
		private int CurrentIndex;
	}
}
