using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D98 RID: 19864
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemDurabilityStatePanel : BattleChildViewPanel
	{
		// Token: 0x06031E5F RID: 204383 RVA: 0x00DF4C00 File Offset: 0x00DF2E00
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031E60 RID: 204384 RVA: 0x00DF4D10 File Offset: 0x00DF2F10
		public override void InitializeTemp()
		{
			this.HitLargePercent = (float)ConfigCommonParamById.GetIntConfig("HitLargeBufferPercent").Value / 10000f;
			this.InitDurabilityParentWidth();
			this.InitDurabilityLightTween();
			this.InitTweenAnim(5);
			this.InitTweenAnim(6);
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.VisibleMachine = new VisibleAnimMachine();
			this.VisibleMachine.InitCallback(new Action<bool>(this.OnRealVisibleChanged), new Action<bool>(this.OnPlayVisibleAnim), new Action<bool>(this.OnStopVisibleAnim));
			this.VisibleMachine.InitVisible(false);
		}

		// Token: 0x06031E61 RID: 204385 RVA: 0x00DF4DB0 File Offset: 0x00DF2FB0
		public override void Reset()
		{
			this.CandidateMap.Clear();
			this.CurrentEntityId = -1;
			this.StopBarLerpAnimation();
			this.StopDurabilityLight();
			VisibleAnimMachine visibleMachine = this.VisibleMachine;
			if (visibleMachine != null)
			{
				visibleMachine.Reset();
			}
			this.VisibleMachine = null;
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
			base.Reset();
		}

		// Token: 0x06031E62 RID: 204386 RVA: 0x00DF4E14 File Offset: 0x00DF3014
		protected override void AddEvents()
		{
			EventSystem.Instance.Add<EntityHandle, int, int>(EEventName.OnAnySceneItemDurabilityChange, new Action<EntityHandle, int, int>(this.OnAnySceneItemDurabilityChange));
			EventSystem.Instance.Add<string, string>(EEventName.TextLanguageChange, new Action<string, string>(this.OnLanguageChange));
			EventSystem.Instance.Add<ERemoveEntityType, EntityHandle>(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
			EventSystem.Instance.Add<Entity>(EEventName.OnSceneItemDurabilityEmpty, new Action<Entity>(this.OnSceneItemDurabilityEmpty));
		}

		// Token: 0x06031E63 RID: 204387 RVA: 0x00DF4E94 File Offset: 0x00DF3094
		protected override void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnAnySceneItemDurabilityChange, new Action<EntityHandle, int, int>(this.OnAnySceneItemDurabilityChange));
			EventSystem.Instance.Remove(EEventName.TextLanguageChange, new Action<string, string>(this.OnLanguageChange));
			EventSystem.Instance.Remove(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
			EventSystem.Instance.Remove(EEventName.OnSceneItemDurabilityEmpty, new Action<Entity>(this.OnSceneItemDurabilityEmpty));
		}

		// Token: 0x06031E64 RID: 204388 RVA: 0x00DF4F11 File Offset: 0x00DF3111
		[NullableContext(2)]
		public void OnEnableSceneItemDurabilityUI(int entityId, bool enable, int? durability, int? maxDurability, string tidName)
		{
			if (enable)
			{
				this.RegisterEntity(entityId, durability.Value, maxDurability.Value, tidName);
				return;
			}
			this.UnregisterEntity(entityId);
		}

		// Token: 0x06031E65 RID: 204389 RVA: 0x00DF4F35 File Offset: 0x00DF3135
		private void RegisterEntity(int entityId, int durability, int maxDurability, string tidName)
		{
			this.CandidateMap[entityId] = new SceneItemDurabilityStatePanel.SceneItemDurabilityStateInfo
			{
				Durability = durability,
				MaxDurability = maxDurability,
				TidName = tidName
			};
			if (this.CurrentEntityId == -1)
			{
				this.ActivateDurabilityView(entityId);
			}
		}

		// Token: 0x06031E66 RID: 204390 RVA: 0x00DF4F70 File Offset: 0x00DF3170
		private void UnregisterEntity(int entityId)
		{
			this.CandidateMap.Remove(entityId);
			if (entityId == this.CurrentEntityId)
			{
				if (this.CandidateMap.Count > 0)
				{
					Dictionary<int, SceneItemDurabilityStatePanel.SceneItemDurabilityStateInfo>.KeyCollection.Enumerator enumerator = this.CandidateMap.Keys.GetEnumerator();
					enumerator.MoveNext();
					int entityId2 = enumerator.Current;
					this.SwitchToEntity(entityId2);
					return;
				}
				this.DeactivateDurabilityView();
			}
		}

		// Token: 0x06031E67 RID: 204391 RVA: 0x00DF4FD0 File Offset: 0x00DF31D0
		private void OnAnySceneItemDurabilityChange(EntityHandle entityHandle, int newDurability, int _curDurability)
		{
			int id = entityHandle.Id;
			if (!this.CandidateMap.ContainsKey(id))
			{
				return;
			}
			this.CandidateMap[id].Durability = newDurability;
			if (id != this.CurrentEntityId)
			{
				this.SwitchToEntity(id);
				return;
			}
			this.UpdateDurabilityBar(newDurability);
		}

		// Token: 0x06031E68 RID: 204392 RVA: 0x00DF5020 File Offset: 0x00DF3220
		private void OnRemoveEntity(ERemoveEntityType _removeType, EntityHandle handle)
		{
			if (handle == null || !handle.Valid)
			{
				return;
			}
			int id = handle.Id;
			if (!this.CandidateMap.ContainsKey(id))
			{
				return;
			}
			this.UnregisterEntity(id);
		}

		// Token: 0x06031E69 RID: 204393 RVA: 0x00DF505C File Offset: 0x00DF325C
		private void OnSceneItemDurabilityEmpty(Entity entity)
		{
			int id = entity.Id;
			if (!this.CandidateMap.ContainsKey(id))
			{
				return;
			}
			this.UnregisterEntity(id);
		}

		// Token: 0x06031E6A RID: 204394 RVA: 0x00DF5088 File Offset: 0x00DF3288
		private void ActivateDurabilityView(int entityId)
		{
			SceneItemDurabilityStatePanel.SceneItemDurabilityStateInfo sceneItemDurabilityStateInfo;
			if (!this.CandidateMap.TryGetValue(entityId, out sceneItemDurabilityStateInfo))
			{
				return;
			}
			this.CurrentEntityId = entityId;
			this.MaxDurability = sceneItemDurabilityStateInfo.MaxDurability;
			this.CurrentPercent = ((sceneItemDurabilityStateInfo.MaxDurability > 0) ? ((float)sceneItemDurabilityStateInfo.Durability / (float)sceneItemDurabilityStateInfo.MaxDurability) : 0f);
			this.SetDurabilityBarPercent(this.CurrentPercent);
			this.StopBarLerpAnimation();
			this.RefreshName(sceneItemDurabilityStateInfo.TidName);
			base.ShowBattleChildViewPanel();
			this.VisibleMachine.SetVisible(true, 667f);
		}

		// Token: 0x06031E6B RID: 204395 RVA: 0x00DF5113 File Offset: 0x00DF3313
		private void DeactivateDurabilityView()
		{
			this.CurrentEntityId = -1;
			this.StopBarLerpAnimation();
			this.StopDurabilityLight();
			this.VisibleMachine.SetVisible(false, 167f);
		}

		// Token: 0x06031E6C RID: 204396 RVA: 0x00DF5139 File Offset: 0x00DF3339
		private void SwitchToEntity(int entityId)
		{
			this.StopBarLerpAnimation();
			this.StopDurabilityLight();
			this.ActivateDurabilityView(entityId);
		}

		// Token: 0x06031E6D RID: 204397 RVA: 0x00DF5150 File Offset: 0x00DF3350
		private void UpdateDurabilityBar(int newDurability)
		{
			float currentPercent = this.CurrentPercent;
			this.CurrentPercent = ((this.MaxDurability > 0) ? ((float)newDurability / (float)this.MaxDurability) : 0f);
			this.SetDurabilityBarPercent(this.CurrentPercent);
			if (this.CurrentPercent < currentPercent)
			{
				this.PlayBarAnimation(this.CurrentPercent, currentPercent);
			}
		}

		// Token: 0x06031E6E RID: 204398 RVA: 0x00DF51A6 File Offset: 0x00DF33A6
		private void SetDurabilityBarPercent(float percent)
		{
			UUISprite sprite = base.GetSprite(1);
			if (sprite == null)
			{
				return;
			}
			sprite.SetFillAmount(percent);
		}

		// Token: 0x06031E6F RID: 204399 RVA: 0x00DF51BC File Offset: 0x00DF33BC
		private void PlayBarAnimation(float durabilityPercent, float oldPercent)
		{
			bool flag = this.DurabilityStateMachine.IsOriginState();
			this.DurabilityStateMachine.GetHit(durabilityPercent, oldPercent);
			if (flag && !this.DurabilityStateMachine.IsOriginState())
			{
				this.SetBarBufferPercent(oldPercent, oldPercent);
			}
			this.IsPlayingDurabilityBarAnim = true;
			if (oldPercent - durabilityPercent < this.HitLargePercent)
			{
				this.PlayTweenAnim(5);
				return;
			}
			this.PlayTweenAnim(6);
			this.PlayDurabilityLight();
		}

		// Token: 0x06031E70 RID: 204400 RVA: 0x00DF5220 File Offset: 0x00DF3420
		private void SetBarBufferPercent(float pctBuffer, float pctReal)
		{
			float num = this.DurabilityParentWidth * pctReal;
			float num2 = this.DurabilityParentWidth * pctBuffer;
			float num3 = num2 - num;
			float num4 = num2 - (this.DurabilityParentWidth + num3) / 2f;
			UUIItem item = base.GetItem(2);
			item.SetAnchorOffsetX(num4);
			item.SetWidth(num3);
			item.SetUIActive(true);
			base.GetSprite(3).SetAnchorOffsetX(-num4);
		}

		// Token: 0x06031E71 RID: 204401 RVA: 0x00DF527B File Offset: 0x00DF347B
		private void StopBarLerpAnimation()
		{
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			this.DurabilityStateMachine.Reset();
			this.IsPlayingDurabilityBarAnim = false;
		}

		// Token: 0x06031E72 RID: 204402 RVA: 0x00DF52A4 File Offset: 0x00DF34A4
		private void InitDurabilityLightTween()
		{
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				AActor owner = item.GetOwner();
				this.DurabilityLightTweenComponent = (((owner != null) ? owner.GetComponentByClass(ULGUIPlayTweenComponent.StaticClass()) : null) as ULGUIPlayTweenComponent);
			}
		}

		// Token: 0x06031E73 RID: 204403 RVA: 0x00DF52E4 File Offset: 0x00DF34E4
		private void PlayDurabilityLight()
		{
			UUIItem item = base.GetItem(4);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(true);
			ULGUIPlayTweenComponent durabilityLightTweenComponent = this.DurabilityLightTweenComponent;
			if (durabilityLightTweenComponent == null)
			{
				return;
			}
			durabilityLightTweenComponent.Play();
		}

		// Token: 0x06031E74 RID: 204404 RVA: 0x00DF5314 File Offset: 0x00DF3514
		private void StopDurabilityLight()
		{
			UUIItem item = base.GetItem(4);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
			ULGUIPlayTweenComponent durabilityLightTweenComponent = this.DurabilityLightTweenComponent;
			if (durabilityLightTweenComponent == null)
			{
				return;
			}
			durabilityLightTweenComponent.Stop();
		}

		// Token: 0x06031E75 RID: 204405 RVA: 0x00DF5344 File Offset: 0x00DF3544
		private void InitDurabilityParentWidth()
		{
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				UUIItem parentAsUIItem = item.GetParentAsUIItem();
				if (parentAsUIItem != null)
				{
					this.DurabilityParentWidth = parentAsUIItem.GetWidth();
				}
			}
		}

		// Token: 0x06031E76 RID: 204406 RVA: 0x00DF5372 File Offset: 0x00DF3572
		private void OnRealVisibleChanged(bool visible)
		{
			if (!visible)
			{
				base.HideBattleChildViewPanel();
			}
		}

		// Token: 0x06031E77 RID: 204407 RVA: 0x00DF5380 File Offset: 0x00DF3580
		private void OnPlayVisibleAnim(bool visible)
		{
			if (visible)
			{
				this.SequencePlayer.PlaySequencePurely("ShowView", false, false, null, null, false);
				return;
			}
			this.SequencePlayer.PlaySequencePurely("CloseView", false, false, null, null, false);
		}

		// Token: 0x06031E78 RID: 204408 RVA: 0x00DF53CB File Offset: 0x00DF35CB
		private void OnStopVisibleAnim(bool _visible)
		{
			this.SequencePlayer.StopCurrentSequence(false, false);
		}

		// Token: 0x06031E79 RID: 204409 RVA: 0x00DF53DC File Offset: 0x00DF35DC
		private void RefreshName(string tidName)
		{
			UUIText text = base.GetText(0);
			string configTextByKey = PublicUtil.Instance.GetConfigTextByKey(tidName);
			if (text != null)
			{
				text.SetText(configTextByKey, true);
			}
		}

		// Token: 0x06031E7A RID: 204410 RVA: 0x00DF5408 File Offset: 0x00DF3608
		private void OnLanguageChange(string _oldLang, string _newLang)
		{
			if (this.CurrentEntityId == -1)
			{
				return;
			}
			SceneItemDurabilityStatePanel.SceneItemDurabilityStateInfo sceneItemDurabilityStateInfo;
			if (this.CandidateMap.TryGetValue(this.CurrentEntityId, out sceneItemDurabilityStateInfo))
			{
				this.RefreshName(sceneItemDurabilityStateInfo.TidName);
			}
		}

		// Token: 0x06031E7B RID: 204411 RVA: 0x00DF5440 File Offset: 0x00DF3640
		private void InitTweenAnim(int componentType)
		{
			TArray<UActorComponent> tarray = base.GetItem(componentType).GetOwner().K2_GetComponentsByClass(ULGUIPlayTweenComponent.StaticClass());
			List<ULGUIPlayTweenComponent> list = new List<ULGUIPlayTweenComponent>(tarray.Count);
			foreach (UActorComponent uactorComponent in tarray)
			{
				list.Add((ULGUIPlayTweenComponent)uactorComponent);
			}
			this.TweenAnimMap[componentType] = list;
		}

		// Token: 0x06031E7C RID: 204412 RVA: 0x00DF54C8 File Offset: 0x00DF36C8
		private void PlayTweenAnim(int componentType)
		{
			List<ULGUIPlayTweenComponent> list;
			if (this.TweenAnimMap.TryGetValue(componentType, out list))
			{
				foreach (ULGUIPlayTweenComponent ulguiplayTweenComponent in list)
				{
					ulguiplayTweenComponent.Play();
				}
			}
		}

		// Token: 0x06031E7D RID: 204413 RVA: 0x00DF5524 File Offset: 0x00DF3724
		public override void OnTickBattleChildViewPanel(float delta)
		{
			if (this.CurrentEntityId == -1)
			{
				return;
			}
			if (this.IsPlayingDurabilityBarAnim)
			{
				float num = this.DurabilityStateMachine.UpdatePercent(delta);
				if (num < 0f)
				{
					this.StopBarLerpAnimation();
					return;
				}
				if (num <= 1f)
				{
					this.SetBarBufferPercent(num, this.CurrentPercent);
				}
			}
		}

		// Token: 0x0401A67C RID: 108156
		private const int SHOW_VIEW_ANIM_TIME = 667;

		// Token: 0x0401A67D RID: 108157
		private const int CLOSE_VIEW_ANIM_TIME = 167;

		// Token: 0x0401A67E RID: 108158
		private readonly Dictionary<int, SceneItemDurabilityStatePanel.SceneItemDurabilityStateInfo> CandidateMap = new Dictionary<int, SceneItemDurabilityStatePanel.SceneItemDurabilityStateInfo>();

		// Token: 0x0401A67F RID: 108159
		private int CurrentEntityId = -1;

		// Token: 0x0401A680 RID: 108160
		private readonly HpBufferStateMachine DurabilityStateMachine = new HpBufferStateMachine();

		// Token: 0x0401A681 RID: 108161
		private float CurrentPercent = 1f;

		// Token: 0x0401A682 RID: 108162
		private int MaxDurability;

		// Token: 0x0401A683 RID: 108163
		private float DurabilityParentWidth;

		// Token: 0x0401A684 RID: 108164
		private bool IsPlayingDurabilityBarAnim;

		// Token: 0x0401A685 RID: 108165
		private float HitLargePercent;

		// Token: 0x0401A686 RID: 108166
		[Nullable(2)]
		private ULGUIPlayTweenComponent DurabilityLightTweenComponent;

		// Token: 0x0401A687 RID: 108167
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0401A688 RID: 108168
		[Nullable(2)]
		private VisibleAnimMachine VisibleMachine;

		// Token: 0x0401A689 RID: 108169
		private readonly Dictionary<int, List<ULGUIPlayTweenComponent>> TweenAnimMap = new Dictionary<int, List<ULGUIPlayTweenComponent>>();

		// Token: 0x0200AA9E RID: 43678
		[NullableContext(0)]
		private enum EChildComponentType
		{
			// Token: 0x04034BAC RID: 215980
			NameText,
			// Token: 0x04034BAD RID: 215981
			BarSprite,
			// Token: 0x04034BAE RID: 215982
			BarBufferCanvas,
			// Token: 0x04034BAF RID: 215983
			BarBufferSprite,
			// Token: 0x04034BB0 RID: 215984
			Light,
			// Token: 0x04034BB1 RID: 215985
			AnimSmallHit,
			// Token: 0x04034BB2 RID: 215986
			AnimBigHit
		}

		// Token: 0x0200AA9F RID: 43679
		[NullableContext(0)]
		[RequiredMember]
		private class SceneItemDurabilityStateInfo
		{
			// Token: 0x0604689F RID: 288927 RVA: 0x01544C93 File Offset: 0x01542E93
			[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
			[CompilerFeatureRequired("RequiredMembers")]
			public SceneItemDurabilityStateInfo()
			{
			}

			// Token: 0x04034BB3 RID: 215987
			[RequiredMember]
			public int Durability;

			// Token: 0x04034BB4 RID: 215988
			[RequiredMember]
			public int MaxDurability;

			// Token: 0x04034BB5 RID: 215989
			[Nullable(1)]
			[RequiredMember]
			public string TidName;
		}
	}
}
