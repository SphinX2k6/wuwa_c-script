using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.NewWorld.SceneItem;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02003F51 RID: 16209
	[NullableContext(1)]
	[Nullable(0)]
	public class QuickHackMarksItem : UiPanelBase
	{
		// Token: 0x06029086 RID: 168070 RVA: 0x00B85438 File Offset: 0x00B83638
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06029087 RID: 168071 RVA: 0x00B854A1 File Offset: 0x00B836A1
		protected override void OnStart()
		{
			base.GetItem(1).SetUIActive(false);
		}

		// Token: 0x06029088 RID: 168072 RVA: 0x00B854B0 File Offset: 0x00B836B0
		protected override void OnBeforeDestroy()
		{
			this.Owner = null;
			this.OnMarksFinish = null;
			this.SocketName = null;
			this.WorldLocationOffset = null;
		}

		// Token: 0x06029089 RID: 168073 RVA: 0x00B854D4 File Offset: 0x00B836D4
		public void RegisterMarkOwner(EntityHandle owner, Action<EntityHandle> onMarksFinish)
		{
			this.Owner = owner;
			this.OnMarksFinish = onMarksFinish;
			WorldEntity entity = owner.Entity;
			SceneItemQuickHackComponent component = entity.GetComponent<SceneItemQuickHackComponent>();
			if (component != null)
			{
				Vector hackIconOffset = component.GetHackIconOffset();
				if (hackIconOffset != null)
				{
					this.WorldLocationOffset = Vector.Create();
					this.WorldLocationOffset.DeepCopy(hackIconOffset);
				}
				return;
			}
			BaseActorComponent component2 = entity.GetComponent<BaseActorComponent>();
			AActor aactor = (component2 != null) ? component2.Owner : null;
			BaseInfoComponent baseInfo = entity.GetComponent<CreatureDataComponent>().GetBaseInfo();
			IHeadStateViewConfig headStateViewConfig = (baseInfo != null) ? baseInfo.HeadStateViewConfig : null;
			if (headStateViewConfig != null)
			{
				this.WorldLocationOffset = Vector.Create();
				this.WorldLocationOffset.Z = (double)(headStateViewConfig.ZOffset + 30);
				TsBaseCharacter tsBaseCharacter = aactor as TsBaseCharacter;
				if (tsBaseCharacter != null)
				{
					string headStateSocketName = headStateViewConfig.HeadStateSocketName;
					FName? fname = (headStateSocketName != null) ? FNameUtil.GetDynamicFName(headStateSocketName) : null;
					FName? socketName = (fname != null) ? fname : FNameUtil.GetDynamicFName("MarkCase");
					USkeletalMeshComponent mesh = tsBaseCharacter.Mesh;
					if (mesh != null && mesh.DoesSocketExist(socketName.Value))
					{
						this.SocketName = socketName;
					}
				}
			}
		}

		// Token: 0x0602908A RID: 168074 RVA: 0x00B855E4 File Offset: 0x00B837E4
		public bool GetWorldLocation(Vector outVector)
		{
			if (this.Owner == null || !this.Owner.Valid)
			{
				return false;
			}
			BaseActorComponent component = this.Owner.Entity.GetComponent<BaseActorComponent>();
			AActor aactor = (component != null) ? component.Owner : null;
			if (aactor == null)
			{
				return false;
			}
			bool flag = false;
			TsBaseCharacter tsBaseCharacter = aactor as TsBaseCharacter;
			if (tsBaseCharacter != null && this.SocketName != null)
			{
				USkeletalMeshComponent mesh = tsBaseCharacter.Mesh;
				if (mesh != null)
				{
					FVectorDouble fvectorDouble = mesh.D_GetSocketLocation(this.SocketName.Value);
					outVector.FromUeVector(fvectorDouble);
					flag = true;
				}
			}
			if (!flag)
			{
				outVector.FromUeVector(component.ActorLocationProxy);
			}
			if (this.WorldLocationOffset != null)
			{
				outVector.AdditionEqual(this.WorldLocationOffset);
			}
			return true;
		}

		// Token: 0x0602908B RID: 168075 RVA: 0x00B85694 File Offset: 0x00B83894
		public UniTask StartMarkAsync(QuickHackMarkInstance mark)
		{
			QuickHackMarksItem.<StartMarkAsync>d__15 <StartMarkAsync>d__;
			<StartMarkAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<StartMarkAsync>d__.<>4__this = this;
			<StartMarkAsync>d__.mark = mark;
			<StartMarkAsync>d__.<>1__state = -1;
			<StartMarkAsync>d__.<>t__builder.Start<QuickHackMarksItem.<StartMarkAsync>d__15>(ref <StartMarkAsync>d__);
			return <StartMarkAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602908C RID: 168076 RVA: 0x00B856E0 File Offset: 0x00B838E0
		private void OnFinishMark(int markId)
		{
			int count = this.ShowingIconIndices.Count;
			for (int i = 0; i < count; i++)
			{
				int num = this.ShowingIconIndices[i];
				QuickHackMarksIconItem quickHackMarksIconItem = this.IconList[num];
				if (quickHackMarksIconItem.GetMarkId() == markId)
				{
					quickHackMarksIconItem.SetActive(false);
					this.ShowingIconIndices.RemoveAt(i);
					this.ShowingMarkIdSet.Remove(markId);
					this.IdleIndexQueue.Push(num);
					break;
				}
			}
			if (this.ShowingIconIndices.Count <= 0 && this.OnMarksFinish != null && this.Owner != null)
			{
				this.OnMarksFinish(this.Owner);
			}
		}

		// Token: 0x0401654D RID: 91469
		private const int HEAD_DEFAULT_OFFSET = 30;

		// Token: 0x0401654E RID: 91470
		[Nullable(2)]
		private EntityHandle Owner;

		// Token: 0x0401654F RID: 91471
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<EntityHandle> OnMarksFinish;

		// Token: 0x04016550 RID: 91472
		private readonly List<QuickHackMarksIconItem> IconList = new List<QuickHackMarksIconItem>();

		// Token: 0x04016551 RID: 91473
		private readonly List<int> ShowingIconIndices = new List<int>();

		// Token: 0x04016552 RID: 91474
		private readonly HashSet<int> ShowingMarkIdSet = new HashSet<int>();

		// Token: 0x04016553 RID: 91475
		private readonly Queue<int> IdleIndexQueue = new Queue<int>(4);

		// Token: 0x04016554 RID: 91476
		private FName? SocketName;

		// Token: 0x04016555 RID: 91477
		[Nullable(2)]
		private Vector WorldLocationOffset;

		// Token: 0x02009ACB RID: 39627
		[NullableContext(0)]
		private class EComponentType
		{
			// Token: 0x040303AA RID: 197546
			public const int IconLayout = 0;

			// Token: 0x040303AB RID: 197547
			public const int IconItem = 1;
		}
	}
}
