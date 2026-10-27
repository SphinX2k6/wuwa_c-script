using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Ui.HotFix;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Ui
{
	// Token: 0x020000C2 RID: 194
	[NullableContext(2)]
	[Nullable(0)]
	public class LaunchComponentsAction
	{
		// Token: 0x06000650 RID: 1616 RVA: 0x00037217 File Offset: 0x00035417
		protected virtual void OnStart()
		{
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x00037219 File Offset: 0x00035419
		protected virtual void OnBeforeDestroy()
		{
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x0003721B File Offset: 0x0003541B
		[NullableContext(1)]
		public void SetRootActorLaunchComponentsAction(AActor actor)
		{
			this.InitRootActor(actor);
			this.InitSequencePlayer();
			this.CheckHasRegistry();
			this.OnStart();
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x00037236 File Offset: 0x00035436
		[NullableContext(1)]
		private void InitRootActor(AActor actor)
		{
			this.RootActor = actor;
			this.RootItem = (actor.GetComponentByClass(UUIItem.StaticClass()) as UUIItem);
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x0003725A File Offset: 0x0003545A
		private void InitSequencePlayer()
		{
			this.SequencePlayer = new HotFixSequencePlayer(this.RootItem);
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x0003726D File Offset: 0x0003546D
		private void CheckHasRegistry()
		{
			this.ComponentsRegistry = (this.RootActor.GetComponentByClass(ULGUIComponentsRegistry.StaticClass()) as ULGUIComponentsRegistry);
			if (this.ComponentsRegistry != null)
			{
				this.ComponentsRegistry.TsClassName = base.GetType().Name;
			}
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x000372AD File Offset: 0x000354AD
		[NullableContext(1)]
		public TChildComponentAction GetElement<[Nullable(0)] TChildComponentAction>(int index) where TChildComponentAction : LaunchComponentsAction
		{
			return (TChildComponentAction)((object)this.ElementMap[index]);
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x000372C0 File Offset: 0x000354C0
		protected UUIItem GetItem(int index)
		{
			AActor actorFromRegistryComponent = this.GetActorFromRegistryComponent(index);
			if (actorFromRegistryComponent != null)
			{
				return actorFromRegistryComponent.GetComponentByClass(UUIItem.StaticClass()) as UUIItem;
			}
			return null;
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x000372F0 File Offset: 0x000354F0
		protected UUITexture GetTexture(int index)
		{
			AActor actorFromRegistryComponent = this.GetActorFromRegistryComponent(index);
			if (actorFromRegistryComponent != null)
			{
				return actorFromRegistryComponent.GetComponentByClass(UUITexture.StaticClass()) as UUITexture;
			}
			return null;
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00037320 File Offset: 0x00035520
		protected UUIText GetText(int index)
		{
			AActor actorFromRegistryComponent = this.GetActorFromRegistryComponent(index);
			if (actorFromRegistryComponent != null)
			{
				return actorFromRegistryComponent.GetComponentByClass(UUIText.StaticClass()) as UUIText;
			}
			return null;
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00037350 File Offset: 0x00035550
		protected UUIButtonComponent GetButton(int index)
		{
			AActor actorFromRegistryComponent = this.GetActorFromRegistryComponent(index);
			if (actorFromRegistryComponent != null)
			{
				return actorFromRegistryComponent.GetComponentByClass(UUIButtonComponent.StaticClass()) as UUIButtonComponent;
			}
			return null;
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00037380 File Offset: 0x00035580
		protected UUIExtendToggle GetExtendToggle(int index)
		{
			AActor actorFromRegistryComponent = this.GetActorFromRegistryComponent(index);
			if (actorFromRegistryComponent != null)
			{
				return actorFromRegistryComponent.GetComponentByClass(UUIExtendToggle.StaticClass()) as UUIExtendToggle;
			}
			return null;
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x000373B0 File Offset: 0x000355B0
		protected UUILayoutBase GetLayout(int index)
		{
			AActor actorFromRegistryComponent = this.GetActorFromRegistryComponent(index);
			if (actorFromRegistryComponent != null)
			{
				return actorFromRegistryComponent.GetComponentByClass(UUILayoutBase.StaticClass()) as UUILayoutBase;
			}
			return null;
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x000373E0 File Offset: 0x000355E0
		protected UUIDynScrollViewComponent GetUIDynScrollViewComponent(int index)
		{
			AActor actorFromRegistryComponent = this.GetActorFromRegistryComponent(index);
			if (actorFromRegistryComponent != null)
			{
				return actorFromRegistryComponent.GetComponentByClass(UUIDynScrollViewComponent.StaticClass()) as UUIDynScrollViewComponent;
			}
			return null;
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x00037410 File Offset: 0x00035610
		protected UUIScrollViewWithScrollbarComponent GetUiScrollViewWithScrollBar(int index)
		{
			AActor actorFromRegistryComponent = this.GetActorFromRegistryComponent(index);
			if (actorFromRegistryComponent != null)
			{
				return actorFromRegistryComponent.GetComponentByClass(UUIScrollViewWithScrollbarComponent.StaticClass()) as UUIScrollViewWithScrollbarComponent;
			}
			return null;
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00037440 File Offset: 0x00035640
		protected UUIScrollbarComponent GetUiScrollbarComponent(int index)
		{
			AActor actorFromRegistryComponent = this.GetActorFromRegistryComponent(index);
			if (actorFromRegistryComponent != null)
			{
				return actorFromRegistryComponent.GetComponentByClass(UUIScrollbarComponent.StaticClass()) as UUIScrollbarComponent;
			}
			return null;
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x0003746F File Offset: 0x0003566F
		private AActor GetActorFromRegistryComponent(int index)
		{
			if (this.ComponentsRegistry == null || index >= this.ComponentsRegistry.Components.Num())
			{
				return null;
			}
			return this.ComponentsRegistry.Components.Get(index);
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x000374A0 File Offset: 0x000356A0
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

		// Token: 0x06000662 RID: 1634 RVA: 0x000374ED File Offset: 0x000356ED
		protected virtual void OnShow()
		{
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x000374EF File Offset: 0x000356EF
		protected virtual void OnHide()
		{
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x000374F1 File Offset: 0x000356F1
		public UUIItem GetRootItem()
		{
			return this.RootItem;
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000665 RID: 1637 RVA: 0x000374F9 File Offset: 0x000356F9
		protected bool IsClear
		{
			get
			{
				return this.IsClearData;
			}
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x00037504 File Offset: 0x00035704
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

		// Token: 0x06000667 RID: 1639 RVA: 0x0003754C File Offset: 0x0003574C
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public UniTask<TChildComponentAction> AttachElementAsyncFromPath<[Nullable(0)] TChildComponentAction>(int index, string path) where TChildComponentAction : LaunchComponentsAction, new()
		{
			LaunchComponentsAction.<AttachElementAsyncFromPath>d__30<TChildComponentAction> <AttachElementAsyncFromPath>d__;
			<AttachElementAsyncFromPath>d__.<>t__builder = AsyncUniTaskMethodBuilder<TChildComponentAction>.Create();
			<AttachElementAsyncFromPath>d__.<>4__this = this;
			<AttachElementAsyncFromPath>d__.index = index;
			<AttachElementAsyncFromPath>d__.path = path;
			<AttachElementAsyncFromPath>d__.<>1__state = -1;
			<AttachElementAsyncFromPath>d__.<>t__builder.Start<LaunchComponentsAction.<AttachElementAsyncFromPath>d__30<TChildComponentAction>>(ref <AttachElementAsyncFromPath>d__);
			return <AttachElementAsyncFromPath>d__.<>t__builder.Task;
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x0003759F File Offset: 0x0003579F
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

		// Token: 0x06000669 RID: 1641 RVA: 0x000375C8 File Offset: 0x000357C8
		private void ClearElementMap()
		{
			foreach (KeyValuePair<int, LaunchComponentsAction> keyValuePair in this.ElementMap)
			{
				keyValuePair.Value.Destroy();
			}
			this.ElementMap.Clear();
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x0003762C File Offset: 0x0003582C
		private void ClearSequencePlayer()
		{
			HotFixSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.ClearSequence();
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x0003763E File Offset: 0x0003583E
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

		// Token: 0x040003DB RID: 987
		private bool IsClearData;

		// Token: 0x040003DC RID: 988
		protected UUIItem RootItem;

		// Token: 0x040003DD RID: 989
		protected AActor RootActor;

		// Token: 0x040003DE RID: 990
		private ULGUIComponentsRegistry ComponentsRegistry;

		// Token: 0x040003DF RID: 991
		[Nullable(1)]
		protected Dictionary<int, LaunchComponentsAction> ElementMap = new Dictionary<int, LaunchComponentsAction>();

		// Token: 0x040003E0 RID: 992
		protected HotFixSequencePlayer SequencePlayer;
	}
}
