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
	// Token: 0x02005DB4 RID: 23988
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemDurabilityStatePanel : BattleChildViewPanel
	{
		// Token: 0x0603CEE8 RID: 249576 RVA: 0x00EA3D2C File Offset: 0x00EA1F2C
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

		// Token: 0x0603CEE9 RID: 249577 RVA: 0x00EA3E3C File Offset: 0x00EA203C
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

		// Token: 0x0603CEEA RID: 249578 RVA: 0x00EA3EDC File Offset: 0x00EA20DC
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

		// Token: 0x0603CEEB RID: 249579 RVA: 0x00EA3F40 File Offset: 0x00EA2140
		protected override void AddEvents()
		{
			EventSystem.Instance.Add<EntityHandle, int, int>(EEventName.OnAnySceneItemDurabilityChange, new Action<EntityHandle, int, int>(this.OnAnySceneItemDurabilityChange));
			EventSystem.Instance.Add<string, string>(EEventName.TextLanguageChange, new Action<string, string>(this.OnLanguageChange));
			EventSystem.Instance.Add<ERemoveEntityType, EntityHandle>(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
			EventSystem.Instance.Add<Entity>(EEventName.OnSceneItemDurabilityEmpty, new Action<Entity>(this.OnSceneItemDurabilityEmpty));
		}

		// Token: 0x0603CEEC RID: 249580 RVA: 0x00EA3FC0 File Offset: 0x00EA21C0
		protected override void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnAnySceneItemDurabilityChange, new Action<EntityHandle, int, int>(this.OnAnySceneItemDurabilityChange));
			EventSystem.Instance.Remove(EEventName.TextLanguageChange, new Action<string, string>(this.OnLanguageChange));
			EventSystem.Instance.Remove(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
			EventSystem.Instance.Remove(EEventName.OnSceneItemDurabilityEmpty, new Action<Entity>(this.OnSceneItemDurabilityEmpty));
		}

		// Token: 0x0603CEED RID: 249581 RVA: 0x00EA403D File Offset: 0x00EA223D
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

		// Token: 0x0603CEEE RID: 249582 RVA: 0x00EA4061 File Offset: 0x00EA2261
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

		// Token: 0x0603CEEF RID: 249583 RVA: 0x00EA409C File Offset: 0x00EA229C
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

		// Token: 0x0603CEF0 RID: 249584 RVA: 0x00EA40FC File Offset: 0x00EA22FC
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

		// Token: 0x0603CEF1 RID: 249585 RVA: 0x00EA414C File Offset: 0x00EA234C
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

		// Token: 0x0603CEF2 RID: 249586 RVA: 0x00EA4188 File Offset: 0x00EA2388
		private void OnSceneItemDurabilityEmpty(Entity entity)
		{
			int id = entity.Id;
			if (!this.CandidateMap.ContainsKey(id))
			{
				return;
			}
			this.UnregisterEntity(id);
		}

		// Token: 0x0603CEF3 RID: 249587 RVA: 0x00EA41B4 File Offset: 0x00EA23B4
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

		// Token: 0x0603CEF4 RID: 249588 RVA: 0x00EA423F File Offset: 0x00EA243F
		private void DeactivateDurabilityView()
		{
			this.CurrentEntityId = -1;
			this.StopBarLerpAnimation();
			this.StopDurabilityLight();
			this.VisibleMachine.SetVisible(false, 167f);
		}

		// Token: 0x0603CEF5 RID: 249589 RVA: 0x00EA4265 File Offset: 0x00EA2465
		private void SwitchToEntity(int entityId)
		{
			this.StopBarLerpAnimation();
			this.StopDurabilityLight();
			this.ActivateDurabilityView(entityId);
		}

		// Token: 0x0603CEF6 RID: 249590 RVA: 0x00EA427C File Offset: 0x00EA247C
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

		// Token: 0x0603CEF7 RID: 249591 RVA: 0x00EA42D2 File Offset: 0x00EA24D2
		private void SetDurabilityBarPercent(float percent)
		{
			UUISprite sprite = base.GetSprite(1);
			if (sprite == null)
			{
				return;
			}
			sprite.SetFillAmount(percent);
		}

		// Token: 0x0603CEF8 RID: 249592 RVA: 0x00EA42E8 File Offset: 0x00EA24E8
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

		// Token: 0x0603CEF9 RID: 249593 RVA: 0x00EA434C File Offset: 0x00EA254C
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

		// Token: 0x0603CEFA RID: 249594 RVA: 0x00EA43A7 File Offset: 0x00EA25A7
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

		// Token: 0x0603CEFB RID: 249595 RVA: 0x00EA43D0 File Offset: 0x00EA25D0
		private void InitDurabilityLightTween()
		{
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				AActor owner = item.GetOwner();
				this.DurabilityLightTweenComponent = (((owner != null) ? owner.GetComponentByClass(ULGUIPlayTweenComponent.StaticClass()) : null) as ULGUIPlayTweenComponent);
			}
		}

		// Token: 0x0603CEFC RID: 249596 RVA: 0x00EA4410 File Offset: 0x00EA2610
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

		// Token: 0x0603CEFD RID: 249597 RVA: 0x00EA4440 File Offset: 0x00EA2640
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

		// Token: 0x0603CEFE RID: 249598 RVA: 0x00EA4470 File Offset: 0x00EA2670
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

		// Token: 0x0603CEFF RID: 249599 RVA: 0x00EA449E File Offset: 0x00EA269E
		private void OnRealVisibleChanged(bool visible)
		{
			if (!visible)
			{
				base.HideBattleChildViewPanel();
			}
		}

		// Token: 0x0603CF00 RID: 249600 RVA: 0x00EA44AC File Offset: 0x00EA26AC
		private void OnPlayVisibleAnim(bool visible)
		{
			if (visible)
			{
				this.SequencePlayer.PlaySequencePurely("ShowView", false, false, null, null, false);
				return;
			}
			this.SequencePlayer.PlaySequencePurely("CloseView", false, false, null, null, false);
		}

		// Token: 0x0603CF01 RID: 249601 RVA: 0x00EA44F7 File Offset: 0x00EA26F7
		private void OnStopVisibleAnim(bool _visible)
		{
			this.SequencePlayer.StopCurrentSequence(false, false);
		}

		// Token: 0x0603CF02 RID: 249602 RVA: 0x00EA4508 File Offset: 0x00EA2708
		private void RefreshName(string tidName)
		{
			UUIText text = base.GetText(0);
			string configTextByKey = PublicUtil.Instance.GetConfigTextByKey(tidName);
			if (text != null)
			{
				text.SetText(configTextByKey, true);
			}
		}

		// Token: 0x0603CF03 RID: 249603 RVA: 0x00EA4534 File Offset: 0x00EA2734
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

		// Token: 0x0603CF04 RID: 249604 RVA: 0x00EA456C File Offset: 0x00EA276C
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

		// Token: 0x0603CF05 RID: 249605 RVA: 0x00EA45EC File Offset: 0x00EA27EC
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

		// Token: 0x0603CF06 RID: 249606 RVA: 0x00EA4648 File Offset: 0x00EA2848
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

		// Token: 0x0401FBBF RID: 129983
		private const int SHOW_VIEW_ANIM_TIME = 667;

		// Token: 0x0401FBC0 RID: 129984
		private const int CLOSE_VIEW_ANIM_TIME = 167;

		// Token: 0x0401FBC1 RID: 129985
		private readonly Dictionary<int, SceneItemDurabilityStatePanel.SceneItemDurabilityStateInfo> CandidateMap = new Dictionary<int, SceneItemDurabilityStatePanel.SceneItemDurabilityStateInfo>();

		// Token: 0x0401FBC2 RID: 129986
		private int CurrentEntityId = -1;

		// Token: 0x0401FBC3 RID: 129987
		private readonly HpBufferStateMachine DurabilityStateMachine = new HpBufferStateMachine();

		// Token: 0x0401FBC4 RID: 129988
		private float CurrentPercent = 1f;

		// Token: 0x0401FBC5 RID: 129989
		private int MaxDurability;

		// Token: 0x0401FBC6 RID: 129990
		private float DurabilityParentWidth;

		// Token: 0x0401FBC7 RID: 129991
		private bool IsPlayingDurabilityBarAnim;

		// Token: 0x0401FBC8 RID: 129992
		private float HitLargePercent;

		// Token: 0x0401FBC9 RID: 129993
		[Nullable(2)]
		private ULGUIPlayTweenComponent DurabilityLightTweenComponent;

		// Token: 0x0401FBCA RID: 129994
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0401FBCB RID: 129995
		[Nullable(2)]
		private VisibleAnimMachine VisibleMachine;

		// Token: 0x0401FBCC RID: 129996
		private readonly Dictionary<int, List<ULGUIPlayTweenComponent>> TweenAnimMap = new Dictionary<int, List<ULGUIPlayTweenComponent>>();

		// Token: 0x0200C095 RID: 49301
		[NullableContext(0)]
		private enum EChildComponentType
		{
			// Token: 0x0403A1DA RID: 238042
			NameText,
			// Token: 0x0403A1DB RID: 238043
			BarSprite,
			// Token: 0x0403A1DC RID: 238044
			BarBufferCanvas,
			// Token: 0x0403A1DD RID: 238045
			BarBufferSprite,
			// Token: 0x0403A1DE RID: 238046
			Light,
			// Token: 0x0403A1DF RID: 238047
			AnimSmallHit,
			// Token: 0x0403A1E0 RID: 238048
			AnimBigHit
		}

		// Token: 0x0200C096 RID: 49302
		[NullableContext(0)]
		[RequiredMember]
		private class SceneItemDurabilityStateInfo
		{
			// Token: 0x06050358 RID: 328536 RVA: 0x0158B67F File Offset: 0x0158987F
			[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
			[CompilerFeatureRequired("RequiredMembers")]
			public SceneItemDurabilityStateInfo()
			{
			}

			// Token: 0x0403A1E1 RID: 238049
			[RequiredMember]
			public int Durability;

			// Token: 0x0403A1E2 RID: 238050
			[RequiredMember]
			public int MaxDurability;

			// Token: 0x0403A1E3 RID: 238051
			[Nullable(1)]
			[RequiredMember]
			public string TidName;
		}
	}
}
