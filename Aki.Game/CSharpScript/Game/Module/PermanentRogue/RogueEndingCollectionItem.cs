using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x020042DF RID: 17119
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueEndingCollectionItem : GridProxyAbstract<IRogueEndingItemParam>
	{
		// Token: 0x0602B533 RID: 177459 RVA: 0x00C2BEE2 File Offset: 0x00C2A0E2
		protected override void OnStart()
		{
			EventSystem.Instance.Add(EEventName.RogueResEndingRedDotUpdate, new Action(this.RefreshEndingRedDot));
		}

		// Token: 0x0602B534 RID: 177460 RVA: 0x00C2BF00 File Offset: 0x00C2A100
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.RogueResEndingRedDotUpdate, new Action(this.RefreshEndingRedDot));
		}

		// Token: 0x0602B535 RID: 177461 RVA: 0x00C2BF20 File Offset: 0x00C2A120
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUITextureTransitionComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIArtText)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtn))
			};
		}

		// Token: 0x0602B536 RID: 177462 RVA: 0x00C2C00C File Offset: 0x00C2A20C
		[NullableContext(1)]
		public override void Refresh(IRogueEndingItemParam data, bool isSelected, int gridIndex)
		{
			this.Config = data;
			int index = this.Config.Index;
			string text;
			if (index < 10)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendLiteral("0");
				defaultInterpolatedStringHandler.AppendFormatted<int>(index);
				text = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			else
			{
				text = index.ToString();
			}
			string text2 = text;
			UUIArtText artText = base.GetArtText(2);
			if (artText != null)
			{
				artText.SetText(text2);
			}
			RogueResEnd value = ConfigRogueResEndById.GetConfig(this.Config.ConfigId, true).Value;
			string text3 = (PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Female) ? value.CGF : value.CGM;
			if (!StringUtils.IsBlank(text3) && data.IsUnlock)
			{
				UUITextureTransitionComponent uiTextureTransitionComponent = base.GetUiTextureTransitionComponent(1);
				if (uiTextureTransitionComponent != null)
				{
					uiTextureTransitionComponent.RootUIComp.Get().SetUIActive(true);
				}
				base.SetTextureTransitionByPath(text3, base.GetUiTextureTransitionComponent(1), EUISelectableSelectionState.EUISelectableSelectionState_MAX);
			}
			else
			{
				UUITextureTransitionComponent uiTextureTransitionComponent2 = base.GetUiTextureTransitionComponent(1);
				if (uiTextureTransitionComponent2 != null)
				{
					uiTextureTransitionComponent2.RootUIComp.Get().SetUIActive(false);
				}
			}
			string textStringId = data.IsUnlock ? value.Title : "RogueRes_CollectionEventLock";
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), textStringId, Array.Empty<object>());
			RogueResDungeonConfig value2 = ConfigRogueResDungeonConfigById.GetConfig(value.InstId, true).Value;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), value2.Title, Array.Empty<object>());
			this.SetRedDotActive();
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				item.SetUIActive(!data.IsUnlock);
			}
			UUIItem item2 = base.GetItem(7);
			if (item2 != null)
			{
				item2.SetUIActive(!data.IsUnlock);
			}
			UUIButtonComponent button = base.GetButton(0);
			if (button != null)
			{
				button.SetSelfInteractive(!data.IsSubView);
			}
			if (data.IsSubView)
			{
				return;
			}
			Rotator rotator = Rotator.Create();
			rotator.Pitch = data.Rotation.Value;
			rotator.Yaw = 0f;
			rotator.Roll = -90f;
			AActor owner = base.GetButton(0).GetOwner();
			if (owner == null)
			{
				return;
			}
			owner.K2_SetActorRotation(rotator.ToUeRotator(), false);
		}

		// Token: 0x0602B537 RID: 177463 RVA: 0x00C2C227 File Offset: 0x00C2A427
		private void OnClickBtn()
		{
			if (this.OnItemClickCall != null)
			{
				this.OnItemClickCall(this.Config.ConfigId);
			}
		}

		// Token: 0x0602B538 RID: 177464 RVA: 0x00C2C248 File Offset: 0x00C2A448
		private void SetRedDotActive()
		{
			if (this.Config.IsSubView)
			{
				UUIItem item = base.GetItem(5);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(false);
				return;
			}
			else
			{
				bool cacheEndingOpen = ActivityPermanentRogueModel.Instance.GetCacheEndingOpen(this.Config.ConfigId);
				bool isUnlock = this.Config.IsUnlock;
				UUIItem item2 = base.GetItem(5);
				if (item2 == null)
				{
					return;
				}
				bool uiactive;
				if (!cacheEndingOpen && isUnlock)
				{
					float? rotation = this.Config.Rotation;
					float num = 0f;
					uiactive = !(rotation.GetValueOrDefault() == num & rotation != null);
				}
				else
				{
					uiactive = false;
				}
				item2.SetUIActive(uiactive);
				return;
			}
		}

		// Token: 0x0602B539 RID: 177465 RVA: 0x00C2C2DA File Offset: 0x00C2A4DA
		private void RefreshEndingRedDot()
		{
			this.SetRedDotActive();
		}

		// Token: 0x04017605 RID: 95749
		private IRogueEndingItemParam Config;

		// Token: 0x04017606 RID: 95750
		public Action<int> OnItemClickCall;
	}
}
