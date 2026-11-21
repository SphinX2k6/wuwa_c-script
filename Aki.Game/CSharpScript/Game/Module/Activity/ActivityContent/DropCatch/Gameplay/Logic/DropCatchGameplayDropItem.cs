using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x0200567D RID: 22141
	[NullableContext(1)]
	[Nullable(0)]
	public class DropCatchGameplayDropItem : IDropItemInstance
	{
		// Token: 0x06036A11 RID: 223761 RVA: 0x00F3EBC8 File Offset: 0x00F3CDC8
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

		// Token: 0x06036A12 RID: 223762 RVA: 0x00F3EC14 File Offset: 0x00F3CE14
		private UniTask InitView()
		{
			DropCatchGameplayDropItem.<InitView>d__14 <InitView>d__;
			<InitView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitView>d__.<>4__this = this;
			<InitView>d__.<>1__state = -1;
			<InitView>d__.<>t__builder.Start<DropCatchGameplayDropItem.<InitView>d__14>(ref <InitView>d__);
			return <InitView>d__.<>t__builder.Task;
		}

		// Token: 0x06036A13 RID: 223763 RVA: 0x00F3EC57 File Offset: 0x00F3CE57
		public void OnTick(float deltaTime)
		{
			this.UpdatePosition(deltaTime);
			this.UpdateBounds();
		}

		// Token: 0x06036A14 RID: 223764 RVA: 0x00F3EC68 File Offset: 0x00F3CE68
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

		// Token: 0x06036A15 RID: 223765 RVA: 0x00F3ECC8 File Offset: 0x00F3CEC8
		private void UpdateBounds()
		{
			DropCatchGameplayHelper.CalculateBounds(this.Pos, this.ItemSize, this.ItemBounds);
		}

		// Token: 0x06036A16 RID: 223766 RVA: 0x00F3ECE4 File Offset: 0x00F3CEE4
		private bool CheckDestroy(double posY)
		{
			if (posY + this.ItemSize.Y / 2.0 < this.Context.GetGameplayArea().MinY)
			{
				this.Context.GetGameplayDropItemMgr().RecycleDropItem(this.InstanceId);
				return true;
			}
			return false;
		}

		// Token: 0x06036A17 RID: 223767 RVA: 0x00F3ED34 File Offset: 0x00F3CF34
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

		// Token: 0x06036A18 RID: 223768 RVA: 0x00F3EDD2 File Offset: 0x00F3CFD2
		public IDropCatchBounds GetItemBounds()
		{
			return this.ItemBounds;
		}

		// Token: 0x06036A19 RID: 223769 RVA: 0x00F3EDDA File Offset: 0x00F3CFDA
		public int GetInstanceId()
		{
			return this.InstanceId;
		}

		// Token: 0x06036A1A RID: 223770 RVA: 0x00F3EDE2 File Offset: 0x00F3CFE2
		public int GetItemId()
		{
			return this.ItemId;
		}

		// Token: 0x06036A1B RID: 223771 RVA: 0x00F3EDEC File Offset: 0x00F3CFEC
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

		// Token: 0x06036A1C RID: 223772 RVA: 0x00F3EEFF File Offset: 0x00F3D0FF
		protected void OnAddScore()
		{
			if (this.Score == 0)
			{
				return;
			}
			this.Context.GetProxy().AddScore((float)this.Score);
		}

		// Token: 0x06036A1D RID: 223773 RVA: 0x00F3EF21 File Offset: 0x00F3D121
		protected void OnAddEnergy()
		{
			IRoleInstance role = this.Context.GetGameplayRoleMgr().GetRole();
			if (role == null)
			{
				return;
			}
			role.AddEnergy((float)this.Energy, true);
		}

		// Token: 0x06036A1E RID: 223774 RVA: 0x00F3EF45 File Offset: 0x00F3D145
		private void ExecuteEffectCommands()
		{
			this.Context.GetGameplayCommandMgr().ExecuteDropItemEffectCommand(this.ItemId);
		}

		// Token: 0x06036A1F RID: 223775 RVA: 0x00F3EF60 File Offset: 0x00F3D160
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

		// Token: 0x06036A20 RID: 223776 RVA: 0x00F3F018 File Offset: 0x00F3D218
		public void OnRecycle()
		{
			DropCatchGameplayDropItemView view = this.View;
			if (view == null)
			{
				return;
			}
			view.Hide(null);
		}

		// Token: 0x06036A21 RID: 223777 RVA: 0x00F3F02B File Offset: 0x00F3D22B
		public void Destroy()
		{
			DropCatchGameplayDropItemView view = this.View;
			if (view != null)
			{
				view.Destroy(null);
			}
			this.View = null;
		}

		// Token: 0x0401CDDF RID: 118239
		private int InstanceId;

		// Token: 0x0401CDE0 RID: 118240
		private int ItemId;

		// Token: 0x0401CDE1 RID: 118241
		private EDropCatchDropItemEffectType ItemEffectType;

		// Token: 0x0401CDE2 RID: 118242
		private float Speed;

		// Token: 0x0401CDE3 RID: 118243
		private readonly Vector2D Pos = Vector2D.Create();

		// Token: 0x0401CDE4 RID: 118244
		private readonly Vector2D ItemSize = Vector2D.Create();

		// Token: 0x0401CDE5 RID: 118245
		private readonly IDropCatchBounds ItemBounds = new IDropCatchBounds
		{
			Left = 0.0,
			Right = 0.0,
			Top = 0.0,
			Bottom = 0.0
		};

		// Token: 0x0401CDE6 RID: 118246
		[Nullable(2)]
		private DropCatchGameplayDropItemView View;

		// Token: 0x0401CDE7 RID: 118247
		private IGameplayLogicContext Context;

		// Token: 0x0401CDE8 RID: 118248
		private int Score;

		// Token: 0x0401CDE9 RID: 118249
		private int Energy;

		// Token: 0x0401CDEA RID: 118250
		private EDropCatchDropItemNiagaraType? NiagaraType;

		// Token: 0x0401CDEB RID: 118251
		private int ItemTemplate;
	}
}
