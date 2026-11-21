using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf.Collections;
using UnrealEngine;

namespace CSharpScript.Game.Module.SurvivorsRogue.RogueFlow.View
{
	// Token: 0x02003B1F RID: 15135
	[NullableContext(1)]
	[Nullable(0)]
	public class SurvivorsRogueEvolveView : UiViewBase, ISurvivorsRogueCommandView
	{
		// Token: 0x06026E51 RID: 159313 RVA: 0x00AE2BFF File Offset: 0x00AE0DFF
		public SurvivorsRogueEvolveView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x17004FD3 RID: 20435
		// (get) Token: 0x06026E52 RID: 159314 RVA: 0x00AE2C1A File Offset: 0x00AE0E1A
		int ISurvivorsRogueCommandView.CommandIncId
		{
			get
			{
				return this.CommandIncId;
			}
		}

		// Token: 0x17004FD4 RID: 20436
		// (get) Token: 0x06026E53 RID: 159315 RVA: 0x00AE2C22 File Offset: 0x00AE0E22
		SurvivorsRogueCommandBase ISurvivorsRogueCommandView.Command
		{
			get
			{
				return this.Command;
			}
		}

		// Token: 0x06026E54 RID: 159316 RVA: 0x00AE2C2C File Offset: 0x00AE0E2C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUITexture)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUITexture)),
				new ValueTuple<int, Type>(7, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(1, new Action(this.OnClickBtnClose))
			};
		}

		// Token: 0x06026E55 RID: 159317 RVA: 0x00AE2D17 File Offset: 0x00AE0F17
		public void CloseView()
		{
			base.CloseMe(null);
		}

		// Token: 0x06026E56 RID: 159318 RVA: 0x00AE2D20 File Offset: 0x00AE0F20
		private void OnClickBtnClose()
		{
			this.EndEvolveFlow().ContinueWith(delegate()
			{
				this.CurrentViewInfoIndex++;
				if (this.CurrentViewInfoIndex >= this.ViewInfoList.Count)
				{
					this.UiViewSequence.CloseSequenceName = (this.ViewAnimVisibleState ? "Close" : "Close01");
					this.Command.Execute();
					return;
				}
				this.RefreshNextView(true, true);
			});
		}

		// Token: 0x06026E57 RID: 159319 RVA: 0x00AE2D3C File Offset: 0x00AE0F3C
		private UniTask EndEvolveFlow()
		{
			SurvivorsRogueEvolveView.<EndEvolveFlow>d__16 <EndEvolveFlow>d__;
			<EndEvolveFlow>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<EndEvolveFlow>d__.<>4__this = this;
			<EndEvolveFlow>d__.<>1__state = -1;
			<EndEvolveFlow>d__.<>t__builder.Start<SurvivorsRogueEvolveView.<EndEvolveFlow>d__16>(ref <EndEvolveFlow>d__);
			return <EndEvolveFlow>d__.<>t__builder.Task;
		}

		// Token: 0x06026E58 RID: 159320 RVA: 0x00AE2D80 File Offset: 0x00AE0F80
		protected override UniTask OnBeforeStartAsync()
		{
			SurvivorsRogueEvolveView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsRogueEvolveView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026E59 RID: 159321 RVA: 0x00AE2DC4 File Offset: 0x00AE0FC4
		private void GetViewInfo()
		{
			List<SurvivorsEvolveViewInfo> viewInfoList = this.Command.GetViewInfoList();
			this.ViewInfoList = viewInfoList;
			this.CurrentViewInfoIndex = 0;
		}

		// Token: 0x06026E5A RID: 159322 RVA: 0x00AE2DEB File Offset: 0x00AE0FEB
		protected override void OnBeforeShow()
		{
		}

		// Token: 0x06026E5B RID: 159323 RVA: 0x00AE2DED File Offset: 0x00AE0FED
		protected override void OnAfterShow()
		{
		}

		// Token: 0x06026E5C RID: 159324 RVA: 0x00AE2DEF File Offset: 0x00AE0FEF
		protected override void OnBeforeDestroy()
		{
			this.RootActor.OnSequencePlayEvent.Unbind();
			SurvivorsRogueCommandEvolve command = this.Command;
			if (command == null)
			{
				return;
			}
			command.BindView(null);
		}

		// Token: 0x06026E5D RID: 159325 RVA: 0x00AE2E14 File Offset: 0x00AE1014
		private void OnEventSequence(string sequenceName, string eventName)
		{
			if (sequenceName == "LevelUp" && eventName == "LevelUp")
			{
				SurvivorsEvolveViewInfo survivorsEvolveViewInfo = (this.CurrentViewInfoIndex < this.ViewInfoList.Count) ? this.ViewInfoList[this.CurrentViewInfoIndex] : null;
				if (survivorsEvolveViewInfo == null || !survivorsEvolveViewInfo.PlayTween.GetValueOrDefault())
				{
					return;
				}
				int sourceId = survivorsEvolveViewInfo.SourceId;
				int evolveQualityId = this.GetEvolveQualityId(survivorsEvolveViewInfo.WeaponEvolveIds);
				SurvivorsRogueWeaponStateGrid weaponGrid = this.RoleStatePanel.GetWeaponGrid(sourceId);
				if (weaponGrid != null)
				{
					weaponGrid.SetQualityById(evolveQualityId);
					weaponGrid.SetLevelUp();
				}
			}
		}

		// Token: 0x06026E5E RID: 159326 RVA: 0x00AE2EA9 File Offset: 0x00AE10A9
		public void Refresh()
		{
			this.GetViewInfo();
			this.RefreshWeaponQuality();
			this.RefreshNextView(false, true);
		}

		// Token: 0x06026E5F RID: 159327 RVA: 0x00AE2EC0 File Offset: 0x00AE10C0
		private void RefreshNextView(bool playSwitch, bool refreshContent)
		{
			SurvivorsRogueEvolveView.<>c__DisplayClass24_0 CS$<>8__locals1 = new SurvivorsRogueEvolveView.<>c__DisplayClass24_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.refreshContent = refreshContent;
			CS$<>8__locals1.playSwitch = playSwitch;
			UiAsyncTask task = new UiAsyncTask("SurvivorsRogueEvolveView.Refresh", delegate()
			{
				SurvivorsRogueEvolveView.<>c__DisplayClass24_0.<<RefreshNextView>b__0>d <<RefreshNextView>b__0>d;
				<<RefreshNextView>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<RefreshNextView>b__0>d.<>4__this = CS$<>8__locals1;
				<<RefreshNextView>b__0>d.<>1__state = -1;
				<<RefreshNextView>b__0>d.<>t__builder.Start<SurvivorsRogueEvolveView.<>c__DisplayClass24_0.<<RefreshNextView>b__0>d>(ref <<RefreshNextView>b__0>d);
				return <<RefreshNextView>b__0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task);
		}

		// Token: 0x06026E60 RID: 159328 RVA: 0x00AE2F08 File Offset: 0x00AE1108
		private UniTask RefreshAsync()
		{
			SurvivorsRogueEvolveView.<RefreshAsync>d__25 <RefreshAsync>d__;
			<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshAsync>d__.<>4__this = this;
			<RefreshAsync>d__.<>1__state = -1;
			<RefreshAsync>d__.<>t__builder.Start<SurvivorsRogueEvolveView.<RefreshAsync>d__25>(ref <RefreshAsync>d__);
			return <RefreshAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026E61 RID: 159329 RVA: 0x00AE2F4C File Offset: 0x00AE114C
		private void PlayTween(int weaponId)
		{
			SurvivorsWeapon? survivorsWeapon = SurvivorsRogueConfig.Instance.GetSurvivorsWeapon(weaponId);
			UUITexture texture = base.GetTexture(6);
			base.SetTextureShowUntilLoaded(survivorsWeapon.Value.Icon, texture, null);
			TArray<UActorComponent> tarray = texture.GetOwner().K2_GetComponentsByClass(ULGUIPlayTweenComponent.StaticClass());
			int num = tarray.Num();
			for (int i = 0; i < num; i++)
			{
				ULGUIPlayTweenComponent ulguiplayTweenComponent = tarray.Get(i) as ULGUIPlayTweenComponent;
				if (ulguiplayTweenComponent != null)
				{
					ULGUIPlayTween_Vector3 ulguiplayTween_Vector = ulguiplayTweenComponent.GetPlayTween() as ULGUIPlayTween_Vector3;
					UUIItem textureIconItem = this.CardItem.GetTextureIconItem();
					UUIItem rootItem = this.RoleStatePanel.GetWeaponGrid(weaponId).GetRootItem();
					ulguiplayTween_Vector.from = global::Vector.Create(textureIconItem.GetLGUISpaceAbsolutePosition()).ToUeVectorOld();
					ulguiplayTween_Vector.to = global::Vector.Create(rootItem.GetLGUISpaceAbsolutePosition()).ToUeVectorOld();
					ulguiplayTweenComponent.Stop();
					ulguiplayTweenComponent.Play();
				}
			}
		}

		// Token: 0x06026E62 RID: 159330 RVA: 0x00AE303C File Offset: 0x00AE123C
		private void RefreshWeaponQuality()
		{
			foreach (SurvivorsEvolveViewInfo survivorsEvolveViewInfo in this.ViewInfoList)
			{
				if (survivorsEvolveViewInfo.WeaponEvolveIds != null)
				{
					int sourceId = survivorsEvolveViewInfo.SourceId;
					SurvivorsWeaponGainData weaponDataByWeaponId = SurvivorsRogueModel.Instance.GainData.GetWeaponDataByWeaponId(sourceId);
					if (weaponDataByWeaponId != null)
					{
						RepeatedField<int> evolves = weaponDataByWeaponId.Data.Evolves;
						List<int> list = new List<int>();
						foreach (int num in evolves)
						{
							bool flag = false;
							foreach (int num2 in survivorsEvolveViewInfo.WeaponEvolveIds)
							{
								if (num == num2)
								{
									flag = true;
									break;
								}
							}
							if (!flag)
							{
								list.Add(num);
							}
						}
						int evolveQualityId = this.GetEvolveQualityId(list.ToArray());
						SurvivorsRogueWeaponStateGrid weaponGrid = this.RoleStatePanel.GetWeaponGrid(sourceId);
						if (weaponGrid != null)
						{
							weaponGrid.SetQualityById(evolveQualityId);
						}
					}
				}
			}
		}

		// Token: 0x06026E63 RID: 159331 RVA: 0x00AE3164 File Offset: 0x00AE1364
		private int GetEvolveQualityId(int[] evolveIds)
		{
			int num = 0;
			foreach (int evolveId in evolveIds)
			{
				num = Math.Max(num, SurvivorsRogueConfig.Instance.GetSurvivorsWeaponEvolve(evolveId).Value.Quality);
			}
			return num;
		}

		// Token: 0x0401540C RID: 87052
		public int CommandIncId;

		// Token: 0x0401540D RID: 87053
		public SurvivorsRogueCommandEvolve Command;

		// Token: 0x0401540E RID: 87054
		[Nullable(2)]
		private SurvivorsRogueCardBase CardItem;

		// Token: 0x0401540F RID: 87055
		[Nullable(2)]
		private SurvivorsRogueRoleStatePanel RoleStatePanel;

		// Token: 0x04015410 RID: 87056
		private List<SurvivorsEvolveViewInfo> ViewInfoList = new List<SurvivorsEvolveViewInfo>();

		// Token: 0x04015411 RID: 87057
		private int CurrentViewInfoIndex;

		// Token: 0x04015412 RID: 87058
		private bool IsSpecialEvolve;

		// Token: 0x04015413 RID: 87059
		private bool ViewAnimVisibleState = true;
	}
}
