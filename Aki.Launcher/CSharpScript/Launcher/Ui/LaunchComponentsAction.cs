using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Ui.HotFix;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Ui
{
	// Token: 0x020000C5 RID: 197
	[NullableContext(2)]
	[Nullable(0)]
	public class LaunchComponentsAction
	{
		// Token: 0x0600066B RID: 1643 RVA: 0x00038D17 File Offset: 0x00036F17
		protected virtual void OnStart()
		{
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x00038D19 File Offset: 0x00036F19
		protected virtual void OnBeforeDestroy()
		{
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x00038D1B File Offset: 0x00036F1B
		[NullableContext(1)]
		public void SetRootActorLaunchComponentsAction(AActor actor)
		{
			this.InitRootActor(actor);
			this.InitSequencePlayer();
			this.CheckHasRegistry();
			this.OnStart();
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x00038D36 File Offset: 0x00036F36
		[NullableContext(1)]
		private void InitRootActor(AActor actor)
		{
			this.RootActor = actor;
			this.RootItem = (actor.GetComponentByClass(UUIItem.StaticClass()) as UUIItem);
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x00038D5A File Offset: 0x00036F5A
		private void InitSequencePlayer()
		{
			this.SequencePlayer = new HotFixSequencePlayer(this.RootItem);
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00038D6D File Offset: 0x00036F6D
		private void CheckHasRegistry()
		{
			this.ComponentsRegistry = (this.RootActor.GetComponentByClass(ULGUIComponentsRegistry.StaticClass()) as ULGUIComponentsRegistry);
			if (this.ComponentsRegistry != null)
			{
				this.ComponentsRegistry.TsClassName = base.GetType().Name;
			}
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x00038DAD File Offset: 0x00036FAD
		[NullableContext(1)]
		public TChildComponentAction GetElement<[Nullable(0)] TChildComponentAction>(int index) where TChildComponentAction : LaunchComponentsAction
		{
			return (TChildComponentAction)((object)this.ElementMap[index]);
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x00038DC0 File Offset: 0x00036FC0
		protected UUIItem GetItem(int index)
		{
			AActor actorFromRegistryComponent = this.GetActorFromRegistryComponent(index);
			if (actorFromRegistryComponent != null)
			{
				return actorFromRegistryComponent.GetComponentByClass(UUIItem.StaticClass()) as UUIItem;
			}
			return null;
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x00038DF0 File Offset: 0x00036FF0
		protected UUITexture GetTexture(int index)
		{
			AActor actorFromRegistryComponent = this.GetActorFromRegistryComponent(index);
			if (actorFromRegistryComponent != null)
			{
				return actorFromRegistryComponent.GetComponentByClass(UUITexture.StaticClass()) as UUITexture;
			}
			return null;
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x00038E20 File Offset: 0x00037020
		protected UUIText GetText(int index)
		{
			AActor actorFromRegistryComponent = this.GetActorFromRegistryComponent(index);
			if (actorFromRegistryComponent != null)
			{
				return actorFromRegistryComponent.GetComponentByClass(UUIText.StaticClass()) as UUIText;
			}
			return null;
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x00038E50 File Offset: 0x00037050
		protected UUISprite GetSprite(int index)
		{
			AActor actorFromRegistryComponent = this.GetActorFromRegistryComponent(index);
			if (actorFromRegistryComponent != null)
			{
				return actorFromRegistryComponent.GetComponentByClass(UUISprite.StaticClass()) as UUISprite;
			}
			return null;
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x00038E80 File Offset: 0x00037080
		protected UUIButtonComponent GetButton(int index)
		{
			AActor actorFromRegistryComponent = this.GetActorFromRegistryComponent(index);
			if (actorFromRegistryComponent != null)
			{
				return actorFromRegistryComponent.GetComponentByClass(UUIButtonComponent.StaticClass()) as UUIButtonComponent;
			}
			return null;
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x00038EB0 File Offset: 0x000370B0
		protected UUIExtendToggle GetExtendToggle(int index)
		{
			AActor actorFromRegistryComponent = this.GetActorFromRegistryComponent(index);
			if (actorFromRegistryComponent != null)
			{
				return actorFromRegistryComponent.GetComponentByClass(UUIExtendToggle.StaticClass()) as UUIExtendToggle;
			}
			return null;
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x00038EE0 File Offset: 0x000370E0
		protected UUILayoutBase GetLayout(int index)
		{
			AActor actorFromRegistryComponent = this.GetActorFromRegistryComponent(index);
			if (actorFromRegistryComponent != null)
			{
				return actorFromRegistryComponent.GetComponentByClass(UUILayoutBase.StaticClass()) as UUILayoutBase;
			}
			return null;
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x00038F10 File Offset: 0x00037110
		protected UUIDynScrollViewComponent GetUIDynScrollViewComponent(int index)
		{
			AActor actorFromRegistryComponent = this.GetActorFromRegistryComponent(index);
			if (actorFromRegistryComponent != null)
			{
				return actorFromRegistryComponent.GetComponentByClass(UUIDynScrollViewComponent.StaticClass()) as UUIDynScrollViewComponent;
			}
			return null;
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x00038F40 File Offset: 0x00037140
		protected UUIScrollViewWithScrollbarComponent GetUiScrollViewWithScrollBar(int index)
		{
			AActor actorFromRegistryComponent = this.GetActorFromRegistryComponent(index);
			if (actorFromRegistryComponent != null)
			{
				return actorFromRegistryComponent.GetComponentByClass(UUIScrollViewWithScrollbarComponent.StaticClass()) as UUIScrollViewWithScrollbarComponent;
			}
			return null;
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x00038F70 File Offset: 0x00037170
		protected UUIScrollbarComponent GetUiScrollbarComponent(int index)
		{
			AActor actorFromRegistryComponent = this.GetActorFromRegistryComponent(index);
			if (actorFromRegistryComponent != null)
			{
				return actorFromRegistryComponent.GetComponentByClass(UUIScrollbarComponent.StaticClass()) as UUIScrollbarComponent;
			}
			return null;
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x00038F9F File Offset: 0x0003719F
		private AActor GetActorFromRegistryComponent(int index)
		{
			if (this.ComponentsRegistry == null || index >= this.ComponentsRegistry.Components.Num())
			{
				return null;
			}
			return this.ComponentsRegistry.Components.Get(index);
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x00038FD0 File Offset: 0x000371D0
		public void SetActive(bool visibility)
		{
			if (this.RootItem == null || !this.RootItem.IsValid())
			{
				return;
			}
			bool flag = this.RootItem.IsUIActiveSelf();
			this.RootItem.SetUIActive(visibility);
			if (flag != visibility)
			{
				if (visibility)
				{
					this.OnShow();
					return;
				}
				this.OnHide();
			}
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x0003901D File Offset: 0x0003721D
		protected virtual void OnShow()
		{
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x0003901F File Offset: 0x0003721F
		protected virtual void OnHide()
		{
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00039021 File Offset: 0x00037221
		public UUIItem GetRootItem()
		{
			return this.RootItem;
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000681 RID: 1665 RVA: 0x00039029 File Offset: 0x00037229
		protected bool IsClear
		{
			get
			{
				return this.IsClearData;
			}
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x00039034 File Offset: 0x00037234
		[NullableContext(0)]
		[return: Nullable(2)]
		public TChildComponentAction AttachElement<TChildComponentAction>(int index) where TChildComponentAction : LaunchComponentsAction, new()
		{
			AActor actorFromRegistryComponent = this.GetActorFromRegistryComponent(index);
			if (actorFromRegistryComponent == null)
			{
				return default(TChildComponentAction);
			}
			TChildComponentAction tchildComponentAction = Activator.CreateInstance<TChildComponentAction>();
			tchildComponentAction.SetRootActorLaunchComponentsAction(actorFromRegistryComponent);
			this.ElementMap[index] = tchildComponentAction;
			return tchildComponentAction;
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x0003907C File Offset: 0x0003727C
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public UniTask<TChildComponentAction> AttachElementAsyncFromPath<[Nullable(0)] TChildComponentAction>(int index, string path) where TChildComponentAction : LaunchComponentsAction, new()
		{
			LaunchComponentsAction.<AttachElementAsyncFromPath>d__31<TChildComponentAction> <AttachElementAsyncFromPath>d__;
			<AttachElementAsyncFromPath>d__.<>t__builder = AsyncUniTaskMethodBuilder<TChildComponentAction>.Create();
			<AttachElementAsyncFromPath>d__.<>4__this = this;
			<AttachElementAsyncFromPath>d__.index = index;
			<AttachElementAsyncFromPath>d__.path = path;
			<AttachElementAsyncFromPath>d__.<>1__state = -1;
			<AttachElementAsyncFromPath>d__.<>t__builder.Start<LaunchComponentsAction.<AttachElementAsyncFromPath>d__31<TChildComponentAction>>(ref <AttachElementAsyncFromPath>d__);
			return <AttachElementAsyncFromPath>d__.<>t__builder.Task;
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x000390CF File Offset: 0x000372CF
		public bool DestroyTemp()
		{
			if (this.IsClearData)
			{
				return false;
			}
			this.OnBeforeDestroy();
			this.ClearElementMap();
			this.ClearSequencePlayer();
			this.IsClearData = true;
			return true;
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x000390F8 File Offset: 0x000372F8
		private void ClearElementMap()
		{
			foreach (KeyValuePair<int, LaunchComponentsAction> keyValuePair in this.ElementMap)
			{
				keyValuePair.Value.Destroy();
			}
			this.ElementMap.Clear();
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x0003915C File Offset: 0x0003735C
		private void ClearSequencePlayer()
		{
			HotFixSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.ClearSequence();
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x0003916E File Offset: 0x0003736E
		public virtual void Destroy()
		{
			this.DestroyTemp();
			if (this.RootActor != null)
			{
				ULGUIBPLibrary.DestroyActorWithHierarchy(this.RootActor, true);
			}
			this.RootActor = null;
			this.RootItem = null;
		}

		// Token: 0x0400040A RID: 1034
		private bool IsClearData;

		// Token: 0x0400040B RID: 1035
		protected UUIItem RootItem;

		// Token: 0x0400040C RID: 1036
		protected AActor RootActor;

		// Token: 0x0400040D RID: 1037
		private ULGUIComponentsRegistry ComponentsRegistry;

		// Token: 0x0400040E RID: 1038
		[Nullable(1)]
		protected Dictionary<int, LaunchComponentsAction> ElementMap = new Dictionary<int, LaunchComponentsAction>();

		// Token: 0x0400040F RID: 1039
		protected HotFixSequencePlayer SequencePlayer;
	}
}
