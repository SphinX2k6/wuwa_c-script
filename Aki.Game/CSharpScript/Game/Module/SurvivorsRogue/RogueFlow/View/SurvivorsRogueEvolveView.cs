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
	// Token: 0x02004B75 RID: 19317
	[NullableContext(1)]
	[Nullable(0)]
	public class SurvivorsRogueEvolveView : UiViewBase, ISurvivorsRogueCommandView
	{
		// Token: 0x060320C0 RID: 204992 RVA: 0x00B9EA4F File Offset: 0x00B9CC4F
		public SurvivorsRogueEvolveView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x17007C29 RID: 31785
		// (get) Token: 0x060320C1 RID: 204993 RVA: 0x00B9EA6A File Offset: 0x00B9CC6A
		int ISurvivorsRogueCommandView.CommandIncId
		{
			get
			{
				return this.CommandIncId;
			}
		}

		// Token: 0x17007C2A RID: 31786
		// (get) Token: 0x060320C2 RID: 204994 RVA: 0x00B9EA72 File Offset: 0x00B9CC72
		SurvivorsRogueCommandBase ISurvivorsRogueCommandView.Command
		{
			get
			{
				return this.Command;
			}
		}

		// Token: 0x060320C3 RID: 204995 RVA: 0x00B9EA7C File Offset: 0x00B9CC7C
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

		// Token: 0x060320C4 RID: 204996 RVA: 0x00B9EB67 File Offset: 0x00B9CD67
		public void CloseView()
		{
			base.CloseMe(null);
		}

		// Token: 0x060320C5 RID: 204997 RVA: 0x00B9EB70 File Offset: 0x00B9CD70
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

		// Token: 0x060320C6 RID: 204998 RVA: 0x00B9EB8C File Offset: 0x00B9CD8C
		private UniTask EndEvolveFlow()
		{
			SurvivorsRogueEvolveView.<EndEvolveFlow>d__16 <EndEvolveFlow>d__;
			<EndEvolveFlow>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<EndEvolveFlow>d__.<>4__this = this;
			<EndEvolveFlow>d__.<>1__state = -1;
			<EndEvolveFlow>d__.<>t__builder.Start<SurvivorsRogueEvolveView.<EndEvolveFlow>d__16>(ref <EndEvolveFlow>d__);
			return <EndEvolveFlow>d__.<>t__builder.Task;
		}

		// Token: 0x060320C7 RID: 204999 RVA: 0x00B9EBD0 File Offset: 0x00B9CDD0
		protected override UniTask OnBeforeStartAsync()
		{
			SurvivorsRogueEvolveView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsRogueEvolveView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060320C8 RID: 205000 RVA: 0x00B9EC14 File Offset: 0x00B9CE14
		private void GetViewInfo()
		{
			List<SurvivorsEvolveViewInfo> viewInfoList = this.Command.GetViewInfoList();
			this.ViewInfoList = viewInfoList;
			this.CurrentViewInfoIndex = 0;
		}

		// Token: 0x060320C9 RID: 205001 RVA: 0x00B9EC3B File Offset: 0x00B9CE3B
		protected override void OnBeforeShow()
		{
		}

		// Token: 0x060320CA RID: 205002 RVA: 0x00B9EC3D File Offset: 0x00B9CE3D
		protected override void OnAfterShow()
		{
		}

		// Token: 0x060320CB RID: 205003 RVA: 0x00B9EC3F File Offset: 0x00B9CE3F
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

		// Token: 0x060320CC RID: 205004 RVA: 0x00B9EC64 File Offset: 0x00B9CE64
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

		// Token: 0x060320CD RID: 205005 RVA: 0x00B9ECF9 File Offset: 0x00B9CEF9
		public void Refresh()
		{
			this.GetViewInfo();
			this.RefreshWeaponQuality();
			this.RefreshNextView(false, true);
		}

		// Token: 0x060320CE RID: 205006 RVA: 0x00B9ED10 File Offset: 0x00B9CF10
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

		// Token: 0x060320CF RID: 205007 RVA: 0x00B9ED58 File Offset: 0x00B9CF58
		private UniTask RefreshAsync()
		{
			SurvivorsRogueEvolveView.<RefreshAsync>d__25 <RefreshAsync>d__;
			<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshAsync>d__.<>4__this = this;
			<RefreshAsync>d__.<>1__state = -1;
			<RefreshAsync>d__.<>t__builder.Start<SurvivorsRogueEvolveView.<RefreshAsync>d__25>(ref <RefreshAsync>d__);
			return <RefreshAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060320D0 RID: 205008 RVA: 0x00B9ED9C File Offset: 0x00B9CF9C
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

		// Token: 0x060320D1 RID: 205009 RVA: 0x00B9EE8C File Offset: 0x00B9D08C
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

		// Token: 0x060320D2 RID: 205010 RVA: 0x00B9EFB4 File Offset: 0x00B9D1B4
		private int GetEvolveQualityId(int[] evolveIds)
		{
			int num = 0;
			foreach (int evolveId in evolveIds)
			{
				num = Math.Max(num, SurvivorsRogueConfig.Instance.GetSurvivorsWeaponEvolve(evolveId).Value.Quality);
			}
			return num;
		}

		// Token: 0x0401AAB8 RID: 109240
		public int CommandIncId;

		// Token: 0x0401AAB9 RID: 109241
		public SurvivorsRogueCommandEvolve Command;

		// Token: 0x0401AABA RID: 109242
		[Nullable(2)]
		private SurvivorsRogueCardBase CardItem;

		// Token: 0x0401AABB RID: 109243
		[Nullable(2)]
		private SurvivorsRogueRoleStatePanel RoleStatePanel;

		// Token: 0x0401AABC RID: 109244
		private List<SurvivorsEvolveViewInfo> ViewInfoList = new List<SurvivorsEvolveViewInfo>();

		// Token: 0x0401AABD RID: 109245
		private int CurrentViewInfoIndex;

		// Token: 0x0401AABE RID: 109246
		private bool IsSpecialEvolve;

		// Token: 0x0401AABF RID: 109247
		private bool ViewAnimVisibleState = true;
	}
}
