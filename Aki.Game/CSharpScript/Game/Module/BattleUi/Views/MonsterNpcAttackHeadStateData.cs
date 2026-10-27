using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D4C RID: 23884
	[NullableContext(2)]
	[Nullable(0)]
	public class MonsterNpcAttackHeadStateData : HeadStateData
	{
		// Token: 0x0603CA3B RID: 248379 RVA: 0x00E8DAF5 File Offset: 0x00E8BCF5
		public override void UnBindAllCallback()
		{
			base.UnBindAllCallback();
			this.OnSpecialEnergy4ChangedCallback = null;
			this.OnSlowChargeStateChangedCallback = null;
			this.OnFastChargeStateChangedCallback = null;
			this.OnAttackReadyStateChangedCallback = null;
			this.OnAttackBeginStateChangedCallback = null;
			this.OnAttackEndStateChangedCallback = null;
			this.OnAttackBrokenStateChangedCallback = null;
		}

		// Token: 0x0603CA3C RID: 248380 RVA: 0x00E8DB30 File Offset: 0x00E8BD30
		protected override void AddEntityEvents()
		{
			base.AddEntityEvents();
			Entity entity = this.Entity;
			BaseAttributeComponent baseAttributeComponent = (entity != null) ? entity.GetComponent<BaseAttributeComponent>() : null;
			if (baseAttributeComponent != null && baseAttributeComponent.Valid)
			{
				baseAttributeComponent.AddListener(EAttributeType.SpecialEnergy4, new Action<EAttributeType, float, float>(this.OnSpecialEnergy4Changed), "SpecialEnergy4.MonsterNpcAttackHeadState");
				baseAttributeComponent.AddListener(EAttributeType.SpecialEnergy4Max, new Action<EAttributeType, float, float>(this.OnSpecialEnergy4Changed), "SpecialEnergy4Max.HeadState");
			}
			Entity entity2 = this.Entity;
			BaseTagComponent baseTagComponent = (entity2 != null) ? entity2.GetComponent<BaseTagComponent>() : null;
			if (baseTagComponent != null && baseTagComponent.Valid)
			{
				this.SlowChargeListenTask = baseTagComponent.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["怪物.角色怪.未出手状态_慢充"]), new BaseTagComponent.TTagSwitchedCallback(this.OnSlowChargeStateChanged), null);
				this.FastChargeListenTask = baseTagComponent.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["怪物.角色怪.未出手状态_快充"]), new BaseTagComponent.TTagSwitchedCallback(this.OnFastChargeStateChanged), null);
				this.AttackReadyListenTask = baseTagComponent.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["怪物.角色怪.准备状态"]), new BaseTagComponent.TTagSwitchedCallback(this.OnAttackReadyStateChanged), null);
				this.AttackBeginListenTask = baseTagComponent.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["怪物.角色怪.出手状态"]), new BaseTagComponent.TTagSwitchedCallback(this.OnAttackBeginStateChanged), null);
				this.AttackEndListenTask = baseTagComponent.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["怪物.角色怪.出手状态退出_弱"]), new BaseTagComponent.TTagSwitchedCallback(this.OnAttackEndStateChanged), null);
				this.AttackBrokenListenTask = baseTagComponent.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["怪物.角色怪.出手状态退出_强"]), new BaseTagComponent.TTagSwitchedCallback(this.OnAttackBrokenStateChanged), null);
			}
		}

		// Token: 0x0603CA3D RID: 248381 RVA: 0x00E8DCC8 File Offset: 0x00E8BEC8
		protected override void RemoveEntityEvents()
		{
			base.RemoveEntityEvents();
			Entity entity = this.Entity;
			BaseAttributeComponent baseAttributeComponent = (entity != null) ? entity.GetComponent<BaseAttributeComponent>() : null;
			if (baseAttributeComponent != null && baseAttributeComponent.Valid)
			{
				baseAttributeComponent.RemoveListener(EAttributeType.SpecialEnergy4, new Action<EAttributeType, float, float>(this.OnSpecialEnergy4Changed));
				baseAttributeComponent.RemoveListener(EAttributeType.SpecialEnergy4Max, new Action<EAttributeType, float, float>(this.OnSpecialEnergy4Changed));
			}
			ITagTask fastChargeListenTask = this.FastChargeListenTask;
			if (fastChargeListenTask != null)
			{
				fastChargeListenTask.EndTask();
			}
			this.FastChargeListenTask = null;
			ITagTask slowChargeListenTask = this.SlowChargeListenTask;
			if (slowChargeListenTask != null)
			{
				slowChargeListenTask.EndTask();
			}
			this.SlowChargeListenTask = null;
			ITagTask attackReadyListenTask = this.AttackReadyListenTask;
			if (attackReadyListenTask != null)
			{
				attackReadyListenTask.EndTask();
			}
			this.AttackReadyListenTask = null;
			ITagTask attackBeginListenTask = this.AttackBeginListenTask;
			if (attackBeginListenTask != null)
			{
				attackBeginListenTask.EndTask();
			}
			this.AttackBeginListenTask = null;
			ITagTask attackEndListenTask = this.AttackEndListenTask;
			if (attackEndListenTask != null)
			{
				attackEndListenTask.EndTask();
			}
			this.AttackEndListenTask = null;
			ITagTask attackBrokenListenTask = this.AttackBrokenListenTask;
			if (attackBrokenListenTask != null)
			{
				attackBrokenListenTask.EndTask();
			}
			this.AttackBrokenListenTask = null;
		}

		// Token: 0x0603CA3E RID: 248382 RVA: 0x00E8DDB3 File Offset: 0x00E8BFB3
		[NullableContext(1)]
		public void BindOnSpecialEnergy4Changed(Action<EAttributeType, float, float> callback)
		{
			this.OnSpecialEnergy4ChangedCallback = callback;
		}

		// Token: 0x0603CA3F RID: 248383 RVA: 0x00E8DDBC File Offset: 0x00E8BFBC
		[NullableContext(1)]
		public void BindOnSlowChargeStateChanged(Action<int, bool> callback)
		{
			this.OnSlowChargeStateChangedCallback = callback;
		}

		// Token: 0x0603CA40 RID: 248384 RVA: 0x00E8DDC5 File Offset: 0x00E8BFC5
		[NullableContext(1)]
		public void BindOnFastChargeStateChanged(Action<int, bool> callback)
		{
			this.OnFastChargeStateChangedCallback = callback;
		}

		// Token: 0x0603CA41 RID: 248385 RVA: 0x00E8DDCE File Offset: 0x00E8BFCE
		[NullableContext(1)]
		public void BindOnAttackReadyStateChanged(Action<int, bool> callback)
		{
			this.OnAttackReadyStateChangedCallback = callback;
		}

		// Token: 0x0603CA42 RID: 248386 RVA: 0x00E8DDD7 File Offset: 0x00E8BFD7
		[NullableContext(1)]
		public void BindOnAttackBeginStateChanged(Action<int, bool> callback)
		{
			this.OnAttackBeginStateChangedCallback = callback;
		}

		// Token: 0x0603CA43 RID: 248387 RVA: 0x00E8DDE0 File Offset: 0x00E8BFE0
		[NullableContext(1)]
		public void BindOnAttackEndStateChanged(Action<int, bool> callback)
		{
			this.OnAttackEndStateChangedCallback = callback;
		}

		// Token: 0x0603CA44 RID: 248388 RVA: 0x00E8DDE9 File Offset: 0x00E8BFE9
		[NullableContext(1)]
		public void BindOnAttackBrokenStateChanged(Action<int, bool> callback)
		{
			this.OnAttackBrokenStateChangedCallback = callback;
		}

		// Token: 0x0603CA45 RID: 248389 RVA: 0x00E8DDF2 File Offset: 0x00E8BFF2
		private void OnSpecialEnergy4Changed(EAttributeType attributeId, float newValue, float oldValue)
		{
			Action<EAttributeType, float, float> onSpecialEnergy4ChangedCallback = this.OnSpecialEnergy4ChangedCallback;
			if (onSpecialEnergy4ChangedCallback == null)
			{
				return;
			}
			onSpecialEnergy4ChangedCallback(attributeId, newValue, oldValue);
		}

		// Token: 0x0603CA46 RID: 248390 RVA: 0x00E8DE07 File Offset: 0x00E8C007
		private void OnSlowChargeStateChanged(int tagId, bool bTagExists)
		{
			Action<int, bool> onSlowChargeStateChangedCallback = this.OnSlowChargeStateChangedCallback;
			if (onSlowChargeStateChangedCallback == null)
			{
				return;
			}
			onSlowChargeStateChangedCallback(tagId, bTagExists);
		}

		// Token: 0x0603CA47 RID: 248391 RVA: 0x00E8DE1B File Offset: 0x00E8C01B
		private void OnFastChargeStateChanged(int tagId, bool bTagExists)
		{
			Action<int, bool> onFastChargeStateChangedCallback = this.OnFastChargeStateChangedCallback;
			if (onFastChargeStateChangedCallback == null)
			{
				return;
			}
			onFastChargeStateChangedCallback(tagId, bTagExists);
		}

		// Token: 0x0603CA48 RID: 248392 RVA: 0x00E8DE2F File Offset: 0x00E8C02F
		private void OnAttackReadyStateChanged(int tagId, bool bTagExists)
		{
			Action<int, bool> onAttackReadyStateChangedCallback = this.OnAttackReadyStateChangedCallback;
			if (onAttackReadyStateChangedCallback == null)
			{
				return;
			}
			onAttackReadyStateChangedCallback(tagId, bTagExists);
		}

		// Token: 0x0603CA49 RID: 248393 RVA: 0x00E8DE43 File Offset: 0x00E8C043
		private void OnAttackBeginStateChanged(int tagId, bool bTagExists)
		{
			Action<int, bool> onAttackBeginStateChangedCallback = this.OnAttackBeginStateChangedCallback;
			if (onAttackBeginStateChangedCallback == null)
			{
				return;
			}
			onAttackBeginStateChangedCallback(tagId, bTagExists);
		}

		// Token: 0x0603CA4A RID: 248394 RVA: 0x00E8DE57 File Offset: 0x00E8C057
		private void OnAttackEndStateChanged(int tagId, bool bTagExists)
		{
			Action<int, bool> onAttackEndStateChangedCallback = this.OnAttackEndStateChangedCallback;
			if (onAttackEndStateChangedCallback == null)
			{
				return;
			}
			onAttackEndStateChangedCallback(tagId, bTagExists);
		}

		// Token: 0x0603CA4B RID: 248395 RVA: 0x00E8DE6B File Offset: 0x00E8C06B
		private void OnAttackBrokenStateChanged(int tagId, bool bTagExists)
		{
			Action<int, bool> onAttackBrokenStateChangedCallback = this.OnAttackBrokenStateChangedCallback;
			if (onAttackBrokenStateChangedCallback == null)
			{
				return;
			}
			onAttackBrokenStateChangedCallback(tagId, bTagExists);
		}

		// Token: 0x0401F954 RID: 129364
		private ITagTask SlowChargeListenTask;

		// Token: 0x0401F955 RID: 129365
		private ITagTask FastChargeListenTask;

		// Token: 0x0401F956 RID: 129366
		private ITagTask AttackReadyListenTask;

		// Token: 0x0401F957 RID: 129367
		private ITagTask AttackBeginListenTask;

		// Token: 0x0401F958 RID: 129368
		private ITagTask AttackEndListenTask;

		// Token: 0x0401F959 RID: 129369
		private ITagTask AttackBrokenListenTask;

		// Token: 0x0401F95A RID: 129370
		private Action<EAttributeType, float, float> OnSpecialEnergy4ChangedCallback;

		// Token: 0x0401F95B RID: 129371
		private Action<int, bool> OnSlowChargeStateChangedCallback;

		// Token: 0x0401F95C RID: 129372
		private Action<int, bool> OnFastChargeStateChangedCallback;

		// Token: 0x0401F95D RID: 129373
		private Action<int, bool> OnAttackReadyStateChangedCallback;

		// Token: 0x0401F95E RID: 129374
		private Action<int, bool> OnAttackBeginStateChangedCallback;

		// Token: 0x0401F95F RID: 129375
		private Action<int, bool> OnAttackEndStateChangedCallback;

		// Token: 0x0401F960 RID: 129376
		private Action<int, bool> OnAttackBrokenStateChangedCallback;
	}
}
