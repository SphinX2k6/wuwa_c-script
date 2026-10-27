using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x0200672D RID: 26413
	[NullableContext(1)]
	[Nullable(0)]
	public class DropCatchGameplayDropItem : IDropItemInstance
	{
		// Token: 0x06041EC5 RID: 270021 RVA: 0x00FFD7FC File Offset: 0x00FFB9FC
		public UniTask OnInit(IDropCatchDropItemParams @params)
		{
			DropCatchGameplayDropItem.<OnInit>d__13 <OnInit>d__;
			<OnInit>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnInit>d__.<>4__this = this;
			<OnInit>d__.@params = @params;
			<OnInit>d__.<>1__state = -1;
			<OnInit>d__.<>t__builder.Start<DropCatchGameplayDropItem.<OnInit>d__13>(ref <OnInit>d__);
			return <OnInit>d__.<>t__builder.Task;
		}

		// Token: 0x06041EC6 RID: 270022 RVA: 0x00FFD848 File Offset: 0x00FFBA48
		private UniTask InitView()
		{
			DropCatchGameplayDropItem.<InitView>d__14 <InitView>d__;
			<InitView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitView>d__.<>4__this = this;
			<InitView>d__.<>1__state = -1;
			<InitView>d__.<>t__builder.Start<DropCatchGameplayDropItem.<InitView>d__14>(ref <InitView>d__);
			return <InitView>d__.<>t__builder.Task;
		}

		// Token: 0x06041EC7 RID: 270023 RVA: 0x00FFD88B File Offset: 0x00FFBA8B
		public void OnTick(float deltaTime)
		{
			this.UpdatePosition(deltaTime);
			this.UpdateBounds();
		}

		// Token: 0x06041EC8 RID: 270024 RVA: 0x00FFD89C File Offset: 0x00FFBA9C
		private void UpdatePosition(float deltaTime)
		{
			double num = this.Pos.Y - (double)(this.Speed * deltaTime);
			if (this.CheckDestroy(num))
			{
				return;
			}
			this.CheckEnableCollision();
			this.Pos.Y = num;
			DropCatchGameplayDropItemView view = this.View;
			if (view == null)
			{
				return;
			}
			view.GetRootItem().SetAnchorOffset(this.Pos.ToUeVector2D(false));
		}

		// Token: 0x06041EC9 RID: 270025 RVA: 0x00FFD8FC File Offset: 0x00FFBAFC
		private void UpdateBounds()
		{
			DropCatchGameplayHelper.CalculateBounds(this.Pos, this.ItemSize, this.ItemBounds);
		}

		// Token: 0x06041ECA RID: 270026 RVA: 0x00FFD918 File Offset: 0x00FFBB18
		private bool CheckDestroy(double posY)
		{
			if (posY + this.ItemSize.Y / 2.0 < this.Context.GetGameplayArea().MinY)
			{
				this.Context.GetGameplayDropItemMgr().RecycleDropItem(this.InstanceId);
				return true;
			}
			return false;
		}

		// Token: 0x06041ECB RID: 270027 RVA: 0x00FFD968 File Offset: 0x00FFBB68
		private void CheckEnableCollision()
		{
			IRoleInstance role = this.Context.GetGameplayRoleMgr().GetRole();
			if (role == null)
			{
				Log.Instance.Error(ELogModule.DropCatch, ELogAuthor.CB, "Role is null", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (this.ItemBounds.Bottom <= role.GetBowlBounds().Top)
			{
				this.Context.GetGameplayCollisionMgr().AddCheckCollisionDropItemInstanceId(this.InstanceId);
				return;
			}
			if (this.ItemBounds.Top < role.GetBowlBounds().Bottom)
			{
				this.Context.GetGameplayCollisionMgr().RemoveCheckCollisionDropItemInstanceId(this.InstanceId);
			}
		}

		// Token: 0x06041ECC RID: 270028 RVA: 0x00FFDA06 File Offset: 0x00FFBC06
		public IDropCatchBounds GetItemBounds()
		{
			return this.ItemBounds;
		}

		// Token: 0x06041ECD RID: 270029 RVA: 0x00FFDA0E File Offset: 0x00FFBC0E
		public int GetInstanceId()
		{
			return this.InstanceId;
		}

		// Token: 0x06041ECE RID: 270030 RVA: 0x00FFDA16 File Offset: 0x00FFBC16
		public int GetItemId()
		{
			return this.ItemId;
		}

		// Token: 0x06041ECF RID: 270031 RVA: 0x00FFDA20 File Offset: 0x00FFBC20
		public unsafe void OnCollision(IRoleInstance role)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.DropCatch;
			ELogAuthor author = ELogAuthor.CB;
			string message = "道具与角色碰撞";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ItemId", this.ItemId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("InstanceId", this.InstanceId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("RoleId", role.GetRoleId());
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			if (this.ItemEffectType == EDropCatchDropItemEffectType.Negative)
			{
				if (role.IsInShield())
				{
					role.RemoveShield();
				}
				else if (role.GetSkillState() != EDropCatchRoleSkillState.InSkill)
				{
					this.ExecuteEffectCommands();
					this.OnAddScore();
					this.OnAddEnergy();
				}
			}
			else
			{
				this.ExecuteEffectCommands();
				this.OnAddScore();
				this.OnAddEnergy();
			}
			this.OnPerformance();
			this.Context.GetGameplayDropItemMgr().RecycleDropItem(this.InstanceId);
			this.Context.GetProxy().AddDropItemRecord(this.ItemTemplate);
		}

		// Token: 0x06041ED0 RID: 270032 RVA: 0x00FFDB33 File Offset: 0x00FFBD33
		protected void OnAddScore()
		{
			if (this.Score == 0)
			{
				return;
			}
			this.Context.GetProxy().AddScore((float)this.Score);
		}

		// Token: 0x06041ED1 RID: 270033 RVA: 0x00FFDB55 File Offset: 0x00FFBD55
		protected void OnAddEnergy()
		{
			IRoleInstance role = this.Context.GetGameplayRoleMgr().GetRole();
			if (role == null)
			{
				return;
			}
			role.AddEnergy((float)this.Energy, true);
		}

		// Token: 0x06041ED2 RID: 270034 RVA: 0x00FFDB79 File Offset: 0x00FFBD79
		private void ExecuteEffectCommands()
		{
			this.Context.GetGameplayCommandMgr().ExecuteDropItemEffectCommand(this.ItemId);
		}

		// Token: 0x06041ED3 RID: 270035 RVA: 0x00FFDB94 File Offset: 0x00FFBD94
		protected void OnPerformance()
		{
			if (!(this.NiagaraType != EDropCatchDropItemNiagaraType.High))
			{
				DropCatchGameplayView gameplayView = this.Context.GetProxy().GetGameplayView();
				if (gameplayView != null)
				{
					DropCatchGameplayRoleView roleView = gameplayView.GetRoleView();
					if (roleView != null)
					{
						DropCatchGameplayRoleFxView fxView = roleView.GetFxView();
						if (fxView != null)
						{
							fxView.PlayAdd();
						}
					}
				}
			}
			DropCatchGameplayView gameplayView2 = this.Context.GetProxy().GetGameplayView();
			if (gameplayView2 != null)
			{
				gameplayView2.CreateDropItemFxView(this.NiagaraType.Value, this.Pos);
			}
			EDropCatchItemDefine itemTemplate = (EDropCatchItemDefine)this.ItemTemplate;
			if (itemTemplate == EDropCatchItemDefine.Bomb)
			{
				AudioSystem.Instance.PostEvent("play_ui_goldcatch_efx_debuff");
				return;
			}
			if (itemTemplate - EDropCatchItemDefine.Energy > 2)
			{
				return;
			}
			AudioSystem.Instance.PostEvent("play_ui_goldcatch_com_tip");
		}

		// Token: 0x06041ED4 RID: 270036 RVA: 0x00FFDC4C File Offset: 0x00FFBE4C
		public void OnRecycle()
		{
			DropCatchGameplayDropItemView view = this.View;
			if (view == null)
			{
				return;
			}
			view.Hide(null);
		}

		// Token: 0x06041ED5 RID: 270037 RVA: 0x00FFDC5F File Offset: 0x00FFBE5F
		public void Destroy()
		{
			DropCatchGameplayDropItemView view = this.View;
			if (view != null)
			{
				view.Destroy(null);
			}
			this.View = null;
		}

		// Token: 0x04022586 RID: 140678
		private int InstanceId;

		// Token: 0x04022587 RID: 140679
		private int ItemId;

		// Token: 0x04022588 RID: 140680
		private EDropCatchDropItemEffectType ItemEffectType;

		// Token: 0x04022589 RID: 140681
		private float Speed;

		// Token: 0x0402258A RID: 140682
		private readonly Vector2D Pos = Vector2D.Create();

		// Token: 0x0402258B RID: 140683
		private readonly Vector2D ItemSize = Vector2D.Create();

		// Token: 0x0402258C RID: 140684
		private readonly IDropCatchBounds ItemBounds = new IDropCatchBounds
		{
			Left = 0.0,
			Right = 0.0,
			Top = 0.0,
			Bottom = 0.0
		};

		// Token: 0x0402258D RID: 140685
		[Nullable(2)]
		private DropCatchGameplayDropItemView View;

		// Token: 0x0402258E RID: 140686
		private IGameplayLogicContext Context;

		// Token: 0x0402258F RID: 140687
		private int Score;

		// Token: 0x04022590 RID: 140688
		private int Energy;

		// Token: 0x04022591 RID: 140689
		private EDropCatchDropItemNiagaraType? NiagaraType;

		// Token: 0x04022592 RID: 140690
		private int ItemTemplate;
	}
}
