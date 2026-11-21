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
	// Token: 0x02003EB1 RID: 16049
	public class RogueBattleLinkUnlockView : UiViewBase
	{
		// Token: 0x06028BCF RID: 166863 RVA: 0x00B6D64F File Offset: 0x00B6B84F
		[NullableContext(1)]
		public RogueBattleLinkUnlockView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06028BD0 RID: 166864 RVA: 0x00B6D658 File Offset: 0x00B6B858
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

		// Token: 0x06028BD1 RID: 166865 RVA: 0x00B6D718 File Offset: 0x00B6B918
		protected override UniTask OnBeforeStartAsync()
		{
			RogueBattleLinkUnlockView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleLinkUnlockView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06028BD2 RID: 166866 RVA: 0x00B6D75B File Offset: 0x00B6B95B
		protected override void OnBeforeHide()
		{
			if (this.UiViewSequence.HasSequenceNameInPlaying("Start"))
			{
				this.UiViewSequence.StopSequenceByKey("Start", false, true);
			}
		}

		// Token: 0x06028BD3 RID: 166867 RVA: 0x00B6D784 File Offset: 0x00B6B984
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

		// Token: 0x06028BD4 RID: 166868 RVA: 0x00B6D8A8 File Offset: 0x00B6BAA8
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

		// Token: 0x04016264 RID: 90724
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04016265 RID: 90725
		private int CurrentIndex;
	}
}
