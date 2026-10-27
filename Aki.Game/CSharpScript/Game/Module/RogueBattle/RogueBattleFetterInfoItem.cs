using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.MapRogue;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004E55 RID: 20053
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueBattleFetterInfoItem : GridProxyAbstract<IRogueBattleRoleBondInfo>
	{
		// Token: 0x06033ABC RID: 211644 RVA: 0x00C19198 File Offset: 0x00C17398
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUISprite)),
				new ValueTuple<int, Type>(5, typeof(UUISprite)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUITexture)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(10, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(9, new Action(this.OnClicked))
			};
		}

		// Token: 0x06033ABD RID: 211645 RVA: 0x00C192C8 File Offset: 0x00C174C8
		[NullableContext(1)]
		public override void Refresh(IRogueBattleRoleBondInfo data, bool isSelected, int gridIndex)
		{
			RoleBondInfo roleBondDataById = RogueBattleModel.Instance.GetRoleBondDataById(data.Id);
			this.Data = data;
			if (roleBondDataById == null)
			{
				return;
			}
			bool uiactive = data.AddStar + roleBondDataById.CurStar >= roleBondDataById.TargetStar && roleBondDataById.TargetStar != 0;
			base.GetItem(8).SetUIActive(uiactive);
			base.GetItem(10).SetUIActive(uiactive);
			UUIText text = base.GetText(1);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(roleBondDataById.Level + 1);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			if (roleBondDataById.TargetStar == 0)
			{
				base.GetSprite(4).SetFillAmount(1f);
				base.GetSprite(5).SetFillAmount(1f);
				this.TargetFillAmount = 1f;
				LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "RogueBattleFetterUpItem_ExpMaxLevel", Array.Empty<object>());
				UUIText text2 = base.GetText(3);
				if (text2 != null)
				{
					text2.SetUIActive(false);
				}
			}
			else
			{
				base.GetSprite(4).SetFillAmount((float)roleBondDataById.CurStar / (float)roleBondDataById.TargetStar);
				base.GetSprite(5).SetFillAmount((float)roleBondDataById.CurStar / (float)roleBondDataById.TargetStar);
				this.TargetFillAmount = (float)(roleBondDataById.CurStar + data.AddStar) / (float)roleBondDataById.TargetStar;
				UUIText text3 = base.GetText(3);
				if (text3 != null)
				{
					text3.SetUIActive(true);
				}
				LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "RogueBattle_FetterInfo_Exp", new <>z__ReadOnlyArray<object>(new object[]
				{
					(roleBondDataById.CurStar + data.AddStar).ToString(),
					roleBondDataById.TargetStar.ToString()
				}));
				this.PlayExpChangeAnim();
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "RogueRes_FightFormation_RoleLevel", new <>z__ReadOnlySingleElementList<object>(roleBondDataById.Level));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "RogueBattle_FetterInfo_Exp_AddLevel", new <>z__ReadOnlySingleElementList<object>(data.AddStar.ToString()));
			RogueResBond? rogueResBond = RogueBattleConfig.Instance.GetRogueResBond(data.Id);
			if (rogueResBond != null)
			{
				base.SetTextureShowUntilLoaded(rogueResBond.Value.Icon, base.GetTexture(7), null);
			}
		}

		// Token: 0x06033ABE RID: 211646 RVA: 0x00C19504 File Offset: 0x00C17704
		protected override void OnBeforeHide()
		{
			this.RemoveAnim();
		}

		// Token: 0x06033ABF RID: 211647 RVA: 0x00C1950C File Offset: 0x00C1770C
		public void PlayExpChangeAnim()
		{
			this.RemoveAnim();
			float fillAmount = base.GetSprite(5).GetFillAmount();
			float animSpeed = Math.Abs(this.TargetFillAmount - fillAmount) / 200f;
			this.AnimationTimer = TimerSystem.GameplayTimeInstance.Forever(delegate(float delta)
			{
				float fillAmount2 = this.GetSprite(5).GetFillAmount();
				if (Math.Abs(fillAmount2 - this.TargetFillAmount) < 0.01f)
				{
					this.RemoveAnim();
					return;
				}
				float fillAmount3 = fillAmount2 + animSpeed * delta;
				this.GetSprite(5).SetFillAmount(fillAmount3);
			}, 20f, 1f, null, null, true);
		}

		// Token: 0x06033AC0 RID: 211648 RVA: 0x00C1957C File Offset: 0x00C1777C
		private void RemoveAnim()
		{
			if (this.AnimationTimer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.AnimationTimer);
				this.AnimationTimer = null;
			}
		}

		// Token: 0x06033AC1 RID: 211649 RVA: 0x00C195A0 File Offset: 0x00C177A0
		private void OnClicked()
		{
			MapRogueController instance = MapRogueController.Instance;
			IRogueBattleRoleBondInfo data = this.Data;
			instance.OpenRogueFetterView((data != null) ? new int?(data.Id) : null);
		}

		// Token: 0x0401B67E RID: 112254
		private TimerHandle AnimationTimer;

		// Token: 0x0401B67F RID: 112255
		private IRogueBattleRoleBondInfo Data;

		// Token: 0x0401B680 RID: 112256
		private float TargetFillAmount;
	}
}
