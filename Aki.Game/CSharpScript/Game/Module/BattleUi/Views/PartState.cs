using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D89 RID: 19849
	[NullableContext(1)]
	[Nullable(0)]
	public class PartState : BattleVisibleChildView
	{
		// Token: 0x06031D63 RID: 204131 RVA: 0x00DF00D4 File Offset: 0x00DEE2D4
		public PartState(Entity entity, CharacterPart part)
		{
			PartState.<>c__DisplayClass18_0 CS$<>8__locals1 = new PartState.<>c__DisplayClass18_0();
			CS$<>8__locals1.entity = entity;
			CS$<>8__locals1.part = part;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.path = UiResourceConfig.Instance.GetResourcePath("UiItem_PartState_Prefab");
			UniTask.Create(delegate()
			{
				PartState.<>c__DisplayClass18_0.<<-ctor>b__0>d <<-ctor>b__0>d;
				<<-ctor>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<-ctor>b__0>d.<>4__this = CS$<>8__locals1;
				<<-ctor>b__0>d.<>1__state = -1;
				<<-ctor>b__0>d.<>t__builder.Start<PartState.<>c__DisplayClass18_0.<<-ctor>b__0>d>(ref <<-ctor>b__0>d);
				return <<-ctor>b__0>d.<>t__builder.Task;
			});
		}

		// Token: 0x06031D64 RID: 204132 RVA: 0x00DF0140 File Offset: 0x00DEE340
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031D65 RID: 204133 RVA: 0x00DF01CA File Offset: 0x00DEE3CA
		protected override void OnStart()
		{
			this.HpParentWidth = base.GetSprite(2).GetParentAsUIItem().GetWidth();
		}

		// Token: 0x06031D66 RID: 204134 RVA: 0x00DF01E3 File Offset: 0x00DEE3E3
		protected override void OnBeforeDestroy()
		{
			this.ResetPartState();
		}

		// Token: 0x06031D67 RID: 204135 RVA: 0x00DF01EC File Offset: 0x00DEE3EC
		public void InitializePartState(Entity entity, CharacterPart part)
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem == null || !rootItem.IsValid())
			{
				return;
			}
			this.Entity = entity;
			this.Part = part;
			this.PlayerController = Global.CharacterController;
			this.SocketName = part.PartSocketName;
			TsBaseCharacter actor = this.Entity.GetComponent<CharacterActorComponent>().Actor;
			this.SkeletalMesh = actor.Mesh;
			base.InitChildType(EBattleUiChild.PartState);
			this.RefreshValid();
			if (!this.IsPartValid)
			{
				this.HideBattleVisibleChildView();
				return;
			}
			this.RefreshHpBar(false);
			this.RefreshPosition();
			this.ShowBattleVisibleChildView(false);
			if (part.HitPartStateVisibleDuration > 0f)
			{
				base.SetVisible(3, false);
			}
			this.AddEvents();
		}

		// Token: 0x06031D68 RID: 204136 RVA: 0x00DF02A0 File Offset: 0x00DEE4A0
		private void RefreshValid()
		{
			if (this.Entity == null)
			{
				this.IsPartValid = false;
				Log.Instance.Warn(ELogModule.Battle, ELogAuthor.CFT, "怪物部位血条非法：不存在Entity", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (this.SkeletalMesh == null)
			{
				this.IsPartValid = false;
				Log.Instance.Warn(ELogModule.Battle, ELogAuthor.CFT, "怪物部位血条非法：不存在SkeletalMesh", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (!this.SkeletalMesh.DoesSocketExist(this.SocketName.Value))
			{
				this.IsPartValid = false;
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.CFT;
				string message = "怪物部位血条非法：不存在SocketName";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(string.Empty, this.SocketName.Value);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.IsPartValid = true;
		}

		// Token: 0x06031D69 RID: 204137 RVA: 0x00DF0364 File Offset: 0x00DEE564
		public void ResetPartState()
		{
			if (this.IsPartValid)
			{
				this.RemoveEvents();
				this.StopBarLerpAnimation();
			}
			this.Entity = null;
			this.Part = null;
			this.PlayerController = null;
			this.SkeletalMesh = null;
			this.CurrentBarPercent = null;
			this.IsPartValid = false;
		}

		// Token: 0x06031D6A RID: 204138 RVA: 0x00DF03B4 File Offset: 0x00DEE5B4
		private void AddEvents()
		{
			if (!EventSystem.Instance.HasWithTarget<float, CharacterPart>(this.Entity, EEventName.CharPartDamage, new Action<float, CharacterPart>(this.OnCharacterApplyDamage)))
			{
				EventSystem.Instance.AddWithTarget<float, CharacterPart>(this.Entity, EEventName.CharPartDamage, new Action<float, CharacterPart>(this.OnCharacterApplyDamage));
			}
		}

		// Token: 0x06031D6B RID: 204139 RVA: 0x00DF0400 File Offset: 0x00DEE600
		private void RemoveEvents()
		{
			EventSystem.Instance.RemoveWithTarget<float, CharacterPart>(this.Entity, EEventName.CharPartDamage, new Action<float, CharacterPart>(this.OnCharacterApplyDamage));
		}

		// Token: 0x06031D6C RID: 204140 RVA: 0x00DF0424 File Offset: 0x00DEE624
		private void OnCharacterApplyDamage(float damage, CharacterPart part)
		{
			float life = this.Part.Life;
			base.SetVisible(2, life > 0f);
			this.RefreshHpBar(true);
			this.HandleHitTimerOnDamage(part, damage);
		}

		// Token: 0x06031D6D RID: 204141 RVA: 0x00DF045C File Offset: 0x00DEE65C
		private void HandleHitTimerOnDamage(CharacterPart part, float damage)
		{
			if (part.Index != this.Part.Index)
			{
				return;
			}
			if (damage <= 0f)
			{
				return;
			}
			float hitPartStateVisibleDuration = this.Part.HitPartStateVisibleDuration;
			if (hitPartStateVisibleDuration > 0f)
			{
				this.HitTimerRemaining = hitPartStateVisibleDuration * 1000f;
				base.SetVisible(3, true);
			}
		}

		// Token: 0x06031D6E RID: 204142 RVA: 0x00DF04B0 File Offset: 0x00DEE6B0
		private void RefreshHpBar(bool bPlayBarAnimation = false)
		{
			UUISprite sprite = base.GetSprite(0);
			if (sprite == null)
			{
				return;
			}
			float life = this.Part.Life;
			float lifeMax = this.Part.LifeMax;
			float num = life / lifeMax;
			sprite.SetFillAmount(life / lifeMax);
			if (bPlayBarAnimation)
			{
				double value = this.CurrentBarPercent.GetValueOrDefault();
				if (this.CurrentBarPercent == null)
				{
					value = (double)num;
					this.CurrentBarPercent = new double?(value);
				}
				this.PlayBarAnimation((double)num);
				return;
			}
			this.StopBarLerpAnimation();
			this.CurrentBarPercent = new double?((double)num);
		}

		// Token: 0x06031D6F RID: 204143 RVA: 0x00DF0538 File Offset: 0x00DEE738
		private void PlayBarAnimation(double hpPercent)
		{
			double value = this.CurrentBarPercent.Value;
			bool flag = this.HpMachine.IsOriginState();
			if (hpPercent >= value)
			{
				if (flag)
				{
					this.CurrentBarPercent = new double?(hpPercent);
				}
				return;
			}
			this.HpMachine.GetHit((float)hpPercent, (float)value);
			this.TargetBarPercent = hpPercent;
			this.SourceBarPercent = value;
			this.CurrentBarPercent = new double?(hpPercent);
			this.AnimTime = 0f;
			if (flag && !this.HpMachine.IsOriginState())
			{
				this.OnBeginBarAnimation(value);
			}
		}

		// Token: 0x06031D70 RID: 204144 RVA: 0x00DF05BE File Offset: 0x00DEE7BE
		private void OnBeginBarAnimation(double hpPercent)
		{
			this.SetBarBufferPercent(hpPercent);
		}

		// Token: 0x06031D71 RID: 204145 RVA: 0x00DF05C8 File Offset: 0x00DEE7C8
		private void StopBarLerpAnimation()
		{
			this.TargetBarPercent = 0.0;
			this.SourceBarPercent = 0.0;
			this.AnimTime = -1f;
			this.HpMachine.Reset();
			base.GetSprite(1).SetUIActive(false);
		}

		// Token: 0x06031D72 RID: 204146 RVA: 0x00DF0618 File Offset: 0x00DEE818
		private void RefreshBarBuffPercent(double? percent = null)
		{
			if (percent != null && Math.Abs(this.BufferPercent - percent.Value) < 0.009999999776482582)
			{
				return;
			}
			if (percent == null)
			{
				this.OnLerpBarBufferPercent(this.CurrentBarPercent.Value);
			}
			else
			{
				this.OnLerpBarBufferPercent(percent.Value);
			}
			this.BufferPercent = percent.GetValueOrDefault();
		}

		// Token: 0x06031D73 RID: 204147 RVA: 0x00DF0683 File Offset: 0x00DEE883
		private void OnLerpBarBufferPercent(double percent)
		{
			this.SetBarBufferPercent(percent);
		}

		// Token: 0x06031D74 RID: 204148 RVA: 0x00DF068C File Offset: 0x00DEE88C
		private void SetBarBufferPercent(double percent)
		{
			UUISprite sprite = base.GetSprite(1);
			sprite.SetFillAmount((float)percent);
			if (!sprite.IsUIActiveSelf())
			{
				sprite.SetUIActive(true);
			}
			UUISprite sprite2 = base.GetSprite(2);
			sprite2.SetStretchLeft((float)((double)this.HpParentWidth * this.CurrentBarPercent - (double)2).Value);
			sprite2.SetStretchRight((float)((double)this.HpParentWidth * (1.0 - percent) - 2.0));
		}

		// Token: 0x06031D75 RID: 204149 RVA: 0x00DF074C File Offset: 0x00DEE94C
		public void RefreshPosition()
		{
			if (!this.IsPartValid)
			{
				return;
			}
			UUIItem uiRootItem = UiLayer.Instance.UiRootItem;
			if (uiRootItem == null)
			{
				return;
			}
			FVectorDouble fvectorDouble = this.SkeletalMesh.D_GetSocketLocation(this.SocketName.Value);
			if (!UGameplayStatics.D_ProjectWorldToScreen(this.PlayerController, fvectorDouble, ref this.PositionRef, false))
			{
				base.SetVisible(1, false);
				return;
			}
			FVector2D anchorOffset = uiRootItem.GetCanvasScaler().ConvertPositionFromViewportToLGUICanvas(this.PositionRef);
			this.RootItem.SetAnchorOffset(anchorOffset);
			base.SetVisible(1, true);
		}

		// Token: 0x06031D76 RID: 204150 RVA: 0x00DF07D0 File Offset: 0x00DEE9D0
		public void Tick(float delta)
		{
			if (!this.IsPartValid)
			{
				return;
			}
			this.RefreshPosition();
			this.LerpBarPercent(delta);
			if (this.HitTimerRemaining > 0f)
			{
				this.HitTimerRemaining -= delta;
				if (this.HitTimerRemaining <= 0f)
				{
					this.HitTimerRemaining = 0f;
					base.SetVisible(3, false);
				}
			}
		}

		// Token: 0x06031D77 RID: 204151 RVA: 0x00DF0830 File Offset: 0x00DEEA30
		private void LerpBarPercent(float delta)
		{
			if (this.AnimTime == -1f)
			{
				return;
			}
			float num = this.HpMachine.UpdatePercent(delta);
			if (num < 0f)
			{
				this.StopBarLerpAnimation();
			}
			else
			{
				this.RefreshBarBuffPercent(new double?((double)num));
			}
			if (this.TargetBarPercent >= this.SourceBarPercent)
			{
				return;
			}
			this.AnimTime += delta;
		}

		// Token: 0x0401A616 RID: 108054
		private const float PERCENT_TOLERATION = 0.01f;

		// Token: 0x0401A617 RID: 108055
		[Nullable(2)]
		private Entity Entity;

		// Token: 0x0401A618 RID: 108056
		[Nullable(2)]
		private CharacterPart Part;

		// Token: 0x0401A619 RID: 108057
		[Nullable(2)]
		private APlayerController PlayerController;

		// Token: 0x0401A61A RID: 108058
		private FName? SocketName;

		// Token: 0x0401A61B RID: 108059
		private FVector2D PositionRef;

		// Token: 0x0401A61C RID: 108060
		[Nullable(2)]
		private USkeletalMeshComponent SkeletalMesh;

		// Token: 0x0401A61D RID: 108061
		private bool IsPartValid;

		// Token: 0x0401A61E RID: 108062
		private float HitTimerRemaining;

		// Token: 0x0401A61F RID: 108063
		private double? CurrentBarPercent;

		// Token: 0x0401A620 RID: 108064
		private double TargetBarPercent;

		// Token: 0x0401A621 RID: 108065
		private double SourceBarPercent;

		// Token: 0x0401A622 RID: 108066
		private float AnimTime = -1f;

		// Token: 0x0401A623 RID: 108067
		private double BufferPercent;

		// Token: 0x0401A624 RID: 108068
		private readonly HpBufferStateMachine HpMachine = new HpBufferStateMachine();

		// Token: 0x0401A625 RID: 108069
		private float HpParentWidth;

		// Token: 0x0200AA87 RID: 43655
		[NullableContext(0)]
		private enum EChildComponentType
		{
			// Token: 0x04034B3B RID: 215867
			HpBarSprite,
			// Token: 0x04034B3C RID: 215868
			BarBufferSprite,
			// Token: 0x04034B3D RID: 215869
			HpLight
		}

		// Token: 0x0200AA88 RID: 43656
		[NullableContext(0)]
		private enum EVisibleReason
		{
			// Token: 0x04034B3F RID: 215871
			Default,
			// Token: 0x04034B40 RID: 215872
			Outside,
			// Token: 0x04034B41 RID: 215873
			Hp,
			// Token: 0x04034B42 RID: 215874
			HitTimer
		}
	}
}
