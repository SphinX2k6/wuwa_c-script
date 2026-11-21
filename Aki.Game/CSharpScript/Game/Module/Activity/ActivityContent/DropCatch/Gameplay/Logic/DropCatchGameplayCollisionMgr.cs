using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x02005668 RID: 22120
	[NullableContext(1)]
	[Nullable(0)]
	public class DropCatchGameplayCollisionMgr : DropCatchGameplayBaseMgr
	{
		// Token: 0x060369D5 RID: 223701 RVA: 0x00F3DBE9 File Offset: 0x00F3BDE9
		public DropCatchGameplayCollisionMgr(IGameplayLogicContext context) : base(context)
		{
		}

		// Token: 0x060369D6 RID: 223702 RVA: 0x00F3DC08 File Offset: 0x00F3BE08
		public override void Init()
		{
			this.TmpCollisionList.Clear();
			this.CheckCollisionDropItemInstanceIds.Clear();
		}

		// Token: 0x060369D7 RID: 223703 RVA: 0x00F3DC20 File Offset: 0x00F3BE20
		public override void OnTick(float deltaTime)
		{
			this.UpdateCollisions();
		}

		// Token: 0x060369D8 RID: 223704 RVA: 0x00F3DC28 File Offset: 0x00F3BE28
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

		// Token: 0x060369D9 RID: 223705 RVA: 0x00F3DD74 File Offset: 0x00F3BF74
		private bool CheckCollision(IDropCatchBounds collisionA, IDropCatchBounds collisionB)
		{
			return collisionA.Left <= collisionB.Right && collisionA.Right >= collisionB.Left && collisionA.Bottom <= collisionB.Top && collisionA.Top >= collisionB.Bottom;
		}

		// Token: 0x060369DA RID: 223706 RVA: 0x00F3DDB3 File Offset: 0x00F3BFB3
		public void AddCheckCollisionDropItemInstanceId(int instanceId)
		{
			this.CheckCollisionDropItemInstanceIds.Add(instanceId);
		}

		// Token: 0x060369DB RID: 223707 RVA: 0x00F3DDC2 File Offset: 0x00F3BFC2
		public void RemoveCheckCollisionDropItemInstanceId(int instanceId)
		{
			this.CheckCollisionDropItemInstanceIds.Remove(instanceId);
		}

		// Token: 0x0401CDD8 RID: 118232
		private readonly List<int> TmpCollisionList = new List<int>();

		// Token: 0x0401CDD9 RID: 118233
		private readonly HashSet<int> CheckCollisionDropItemInstanceIds = new HashSet<int>();
	}
}
