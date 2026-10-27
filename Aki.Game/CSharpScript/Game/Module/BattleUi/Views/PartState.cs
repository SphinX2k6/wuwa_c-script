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
	// Token: 0x02005DA7 RID: 23975
	[NullableContext(1)]
	[Nullable(0)]
	public class PartState : BattleVisibleChildView
	{
		// Token: 0x0603CE06 RID: 249350 RVA: 0x00E9F81C File Offset: 0x00E9DA1C
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

		// Token: 0x0603CE07 RID: 249351 RVA: 0x00E9F888 File Offset: 0x00E9DA88
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

		// Token: 0x0603CE08 RID: 249352 RVA: 0x00E9F912 File Offset: 0x00E9DB12
		protected override void OnStart()
		{
			this.HpParentWidth = base.GetSprite(2).GetParentAsUIItem().GetWidth();
		}

		// Token: 0x0603CE09 RID: 249353 RVA: 0x00E9F92B File Offset: 0x00E9DB2B
		protected override void OnBeforeDestroy()
		{
			this.ResetPartState();
		}

		// Token: 0x0603CE0A RID: 249354 RVA: 0x00E9F934 File Offset: 0x00E9DB34
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

		// Token: 0x0603CE0B RID: 249355 RVA: 0x00E9F9E8 File Offset: 0x00E9DBE8
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

		// Token: 0x0603CE0C RID: 249356 RVA: 0x00E9FAAC File Offset: 0x00E9DCAC
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

		// Token: 0x0603CE0D RID: 249357 RVA: 0x00E9FAFC File Offset: 0x00E9DCFC
		private void AddEvents()
		{
			if (!EventSystem.Instance.HasWithTarget<float, CharacterPart>(this.Entity, EEventName.CharPartDamage, new Action<float, CharacterPart>(this.OnCharacterApplyDamage)))
			{
				EventSystem.Instance.AddWithTarget<float, CharacterPart>(this.Entity, EEventName.CharPartDamage, new Action<float, CharacterPart>(this.OnCharacterApplyDamage));
			}
		}

		// Token: 0x0603CE0E RID: 249358 RVA: 0x00E9FB48 File Offset: 0x00E9DD48
		private void RemoveEvents()
		{
			EventSystem.Instance.RemoveWithTarget<float, CharacterPart>(this.Entity, EEventName.CharPartDamage, new Action<float, CharacterPart>(this.OnCharacterApplyDamage));
		}

		// Token: 0x0603CE0F RID: 249359 RVA: 0x00E9FB6C File Offset: 0x00E9DD6C
		private void OnCharacterApplyDamage(float damage, CharacterPart part)
		{
			float life = this.Part.Life;
			base.SetVisible(2, life > 0f);
			this.RefreshHpBar(true);
			this.HandleHitTimerOnDamage(part, damage);
		}

		// Token: 0x0603CE10 RID: 249360 RVA: 0x00E9FBA4 File Offset: 0x00E9DDA4
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

		// Token: 0x0603CE11 RID: 249361 RVA: 0x00E9FBF8 File Offset: 0x00E9DDF8
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

		// Token: 0x0603CE12 RID: 249362 RVA: 0x00E9FC80 File Offset: 0x00E9DE80
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

		// Token: 0x0603CE13 RID: 249363 RVA: 0x00E9FD06 File Offset: 0x00E9DF06
		private void OnBeginBarAnimation(double hpPercent)
		{
			this.SetBarBufferPercent(hpPercent);
		}

		// Token: 0x0603CE14 RID: 249364 RVA: 0x00E9FD10 File Offset: 0x00E9DF10
		private void StopBarLerpAnimation()
		{
			this.TargetBarPercent = 0.0;
			this.SourceBarPercent = 0.0;
			this.AnimTime = -1f;
			this.HpMachine.Reset();
			base.GetSprite(1).SetUIActive(false);
		}

		// Token: 0x0603CE15 RID: 249365 RVA: 0x00E9FD60 File Offset: 0x00E9DF60
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

		// Token: 0x0603CE16 RID: 249366 RVA: 0x00E9FDCB File Offset: 0x00E9DFCB
		private void OnLerpBarBufferPercent(double percent)
		{
			this.SetBarBufferPercent(percent);
		}

		// Token: 0x0603CE17 RID: 249367 RVA: 0x00E9FDD4 File Offset: 0x00E9DFD4
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

		// Token: 0x0603CE18 RID: 249368 RVA: 0x00E9FE94 File Offset: 0x00E9E094
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

		// Token: 0x0603CE19 RID: 249369 RVA: 0x00E9FF18 File Offset: 0x00E9E118
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

		// Token: 0x0603CE1A RID: 249370 RVA: 0x00E9FF78 File Offset: 0x00E9E178
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

		// Token: 0x0401FB5E RID: 129886
		private const float PERCENT_TOLERATION = 0.01f;

		// Token: 0x0401FB5F RID: 129887
		[Nullable(2)]
		private Entity Entity;

		// Token: 0x0401FB60 RID: 129888
		[Nullable(2)]
		private CharacterPart Part;

		// Token: 0x0401FB61 RID: 129889
		[Nullable(2)]
		private APlayerController PlayerController;

		// Token: 0x0401FB62 RID: 129890
		private FName? SocketName;

		// Token: 0x0401FB63 RID: 129891
		private FVector2D PositionRef;

		// Token: 0x0401FB64 RID: 129892
		[Nullable(2)]
		private USkeletalMeshComponent SkeletalMesh;

		// Token: 0x0401FB65 RID: 129893
		private bool IsPartValid;

		// Token: 0x0401FB66 RID: 129894
		private float HitTimerRemaining;

		// Token: 0x0401FB67 RID: 129895
		private double? CurrentBarPercent;

		// Token: 0x0401FB68 RID: 129896
		private double TargetBarPercent;

		// Token: 0x0401FB69 RID: 129897
		private double SourceBarPercent;

		// Token: 0x0401FB6A RID: 129898
		private float AnimTime = -1f;

		// Token: 0x0401FB6B RID: 129899
		private double BufferPercent;

		// Token: 0x0401FB6C RID: 129900
		private readonly HpBufferStateMachine HpMachine = new HpBufferStateMachine();

		// Token: 0x0401FB6D RID: 129901
		private float HpParentWidth;

		// Token: 0x0200C081 RID: 49281
		[NullableContext(0)]
		private enum EChildComponentType
		{
			// Token: 0x0403A178 RID: 237944
			HpBarSprite,
			// Token: 0x0403A179 RID: 237945
			BarBufferSprite,
			// Token: 0x0403A17A RID: 237946
			HpLight
		}

		// Token: 0x0200C082 RID: 49282
		[NullableContext(0)]
		private enum EVisibleReason
		{
			// Token: 0x0403A17C RID: 237948
			Default,
			// Token: 0x0403A17D RID: 237949
			Outside,
			// Token: 0x0403A17E RID: 237950
			Hp,
			// Token: 0x0403A17F RID: 237951
			HitTimer
		}
	}
}
