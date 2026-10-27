using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x02006718 RID: 26392
	[NullableContext(1)]
	[Nullable(0)]
	public class DropCatchGameplayCollisionMgr : DropCatchGameplayBaseMgr
	{
		// Token: 0x06041E89 RID: 269961 RVA: 0x00FFC81D File Offset: 0x00FFAA1D
		public DropCatchGameplayCollisionMgr(IGameplayLogicContext context) : base(context)
		{
		}

		// Token: 0x06041E8A RID: 269962 RVA: 0x00FFC83C File Offset: 0x00FFAA3C
		public override void Init()
		{
			this.TmpCollisionList.Clear();
			this.CheckCollisionDropItemInstanceIds.Clear();
		}

		// Token: 0x06041E8B RID: 269963 RVA: 0x00FFC854 File Offset: 0x00FFAA54
		public override void OnTick(float deltaTime)
		{
			this.UpdateCollisions();
		}

		// Token: 0x06041E8C RID: 269964 RVA: 0x00FFC85C File Offset: 0x00FFAA5C
		private void UpdateCollisions()
		{
			IRoleInstance role = this.Context.GetGameplayRoleMgr().GetRole();
			if (role == null)
			{
				Log.Instance.Error(ELogModule.DropCatch, ELogAuthor.CB, "Role is null", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			IDropCatchBounds bowlBounds = role.GetBowlBounds();
			IDropCatchBounds roleBounds = role.GetRoleBounds();
			this.TmpCollisionList.Clear();
			foreach (int num in this.CheckCollisionDropItemInstanceIds)
			{
				IDropItemInstance dropItem = this.Context.GetGameplayDropItemMgr().GetDropItem(num);
				if (dropItem != null)
				{
					IDropCatchBounds itemBounds = dropItem.GetItemBounds();
					if (this.CheckCollision(bowlBounds, itemBounds))
					{
						this.TmpCollisionList.Add(num);
					}
					else if (this.CheckCollision(roleBounds, itemBounds))
					{
						this.TmpCollisionList.Add(num);
					}
				}
			}
			foreach (int instanceId in this.TmpCollisionList)
			{
				IDropItemInstance dropItem2 = this.Context.GetGameplayDropItemMgr().GetDropItem(instanceId);
				if (dropItem2 != null)
				{
					dropItem2.OnCollision(role);
				}
			}
		}

		// Token: 0x06041E8D RID: 269965 RVA: 0x00FFC9A8 File Offset: 0x00FFABA8
		private bool CheckCollision(IDropCatchBounds collisionA, IDropCatchBounds collisionB)
		{
			return collisionA.Left <= collisionB.Right && collisionA.Right >= collisionB.Left && collisionA.Bottom <= collisionB.Top && collisionA.Top >= collisionB.Bottom;
		}

		// Token: 0x06041E8E RID: 269966 RVA: 0x00FFC9E7 File Offset: 0x00FFABE7
		public void AddCheckCollisionDropItemInstanceId(int instanceId)
		{
			this.CheckCollisionDropItemInstanceIds.Add(instanceId);
		}

		// Token: 0x06041E8F RID: 269967 RVA: 0x00FFC9F6 File Offset: 0x00FFABF6
		public void RemoveCheckCollisionDropItemInstanceId(int instanceId)
		{
			this.CheckCollisionDropItemInstanceIds.Remove(instanceId);
		}

		// Token: 0x0402257F RID: 140671
		private readonly List<int> TmpCollisionList = new List<int>();

		// Token: 0x04022580 RID: 140672
		private readonly HashSet<int> CheckCollisionDropItemInstanceIds = new HashSet<int>();
	}
}
