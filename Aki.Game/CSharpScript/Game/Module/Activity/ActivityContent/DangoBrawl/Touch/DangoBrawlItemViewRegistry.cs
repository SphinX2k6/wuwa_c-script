using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch
{
	// Token: 0x020057A8 RID: 22440
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlItemViewRegistry
	{
		// Token: 0x0603764C RID: 226892 RVA: 0x00F7A1D1 File Offset: 0x00F783D1
		public void Start()
		{
		}

		// Token: 0x0603764D RID: 226893 RVA: 0x00F7A1D4 File Offset: 0x00F783D4
		public void Stop()
		{
			this.Views.Clear();
			this.LineOwners.Clear();
			foreach (IDragVisual dragVisual in this.PendingProxies.Values)
			{
				dragVisual.Destroy();
			}
			this.PendingProxies.Clear();
			this.ItemZones.Clear();
			this.ProxyTemplates.Clear();
			this.BackpackView = null;
		}

		// Token: 0x0603764E RID: 226894 RVA: 0x00F7A268 File Offset: 0x00F78468
		public void Register(int uid, IDangoBrawlDraggableView view)
		{
			if (uid <= 0)
			{
				return;
			}
			this.Views[uid] = view;
		}

		// Token: 0x0603764F RID: 226895 RVA: 0x00F7A27C File Offset: 0x00F7847C
		public void Unregister(int uid)
		{
			this.Views.Remove(uid);
		}

		// Token: 0x06037650 RID: 226896 RVA: 0x00F7A28C File Offset: 0x00F7848C
		[NullableContext(2)]
		public IDangoBrawlDraggableView GetView(int uid)
		{
			IDangoBrawlDraggableView result;
			if (!this.Views.TryGetValue(uid, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06037651 RID: 226897 RVA: 0x00F7A2AC File Offset: 0x00F784AC
		[NullableContext(2)]
		public DangoBrawlItemBase GetItemData(int uid)
		{
			IDangoBrawlDraggableView dangoBrawlDraggableView;
			if (!this.Views.TryGetValue(uid, out dangoBrawlDraggableView))
			{
				return null;
			}
			return dangoBrawlDraggableView.MyItemData;
		}

		// Token: 0x06037652 RID: 226898 RVA: 0x00F7A2D1 File Offset: 0x00F784D1
		public void RegisterBackpackView(DangoBrawlBackpackView view)
		{
			this.BackpackView = view;
		}

		// Token: 0x06037653 RID: 226899 RVA: 0x00F7A2DA File Offset: 0x00F784DA
		public void UnregisterBackpackView(DangoBrawlBackpackView view)
		{
			if (this.BackpackView == view)
			{
				this.BackpackView = null;
			}
		}

		// Token: 0x06037654 RID: 226900 RVA: 0x00F7A2EC File Offset: 0x00F784EC
		[NullableContext(2)]
		public DangoBrawlBackpackView GetBackpackView()
		{
			return this.BackpackView;
		}

		// Token: 0x06037655 RID: 226901 RVA: 0x00F7A2F4 File Offset: 0x00F784F4
		public void RegisterItemZone(EDragTargetKind kind, IDangoBrawlItemZone zone)
		{
			this.ItemZones[kind] = zone;
		}

		// Token: 0x06037656 RID: 226902 RVA: 0x00F7A303 File Offset: 0x00F78503
		public void UnregisterItemZone(EDragTargetKind kind)
		{
			this.ItemZones.Remove(kind);
		}

		// Token: 0x06037657 RID: 226903 RVA: 0x00F7A314 File Offset: 0x00F78514
		[NullableContext(2)]
		public IDangoBrawlItemZone GetItemZone(EDragTargetKind kind)
		{
			IDangoBrawlItemZone result;
			if (!this.ItemZones.TryGetValue(kind, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06037658 RID: 226904 RVA: 0x00F7A334 File Offset: 0x00F78534
		public void RegisterLineOwner(int uid, ICombineLineOwner owner)
		{
			if (uid <= 0)
			{
				return;
			}
			this.LineOwners[uid] = owner;
		}

		// Token: 0x06037659 RID: 226905 RVA: 0x00F7A348 File Offset: 0x00F78548
		public void UnregisterLineOwner(int uid, ICombineLineOwner owner)
		{
			ICombineLineOwner combineLineOwner;
			if (this.LineOwners.TryGetValue(uid, out combineLineOwner) && combineLineOwner == owner)
			{
				this.LineOwners.Remove(uid);
			}
		}

		// Token: 0x0603765A RID: 226906 RVA: 0x00F7A378 File Offset: 0x00F78578
		[NullableContext(2)]
		public ICombineLineOwner GetLineOwner(int uid)
		{
			ICombineLineOwner result;
			if (!this.LineOwners.TryGetValue(uid, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0603765B RID: 226907 RVA: 0x00F7A398 File Offset: 0x00F78598
		public void RegisterPendingProxy(int slotUid, IDragVisual proxy)
		{
			if (slotUid <= 0)
			{
				return;
			}
			IDragVisual dragVisual;
			if (this.PendingProxies.TryGetValue(slotUid, out dragVisual))
			{
				dragVisual.Destroy();
			}
			this.PendingProxies[slotUid] = proxy;
		}

		// Token: 0x0603765C RID: 226908 RVA: 0x00F7A3D0 File Offset: 0x00F785D0
		[NullableContext(2)]
		public IDragVisual ConsumePendingProxy(int slotUid)
		{
			IDragVisual result;
			if (!this.PendingProxies.TryGetValue(slotUid, out result))
			{
				return null;
			}
			this.PendingProxies.Remove(slotUid);
			return result;
		}

		// Token: 0x0603765D RID: 226909 RVA: 0x00F7A3FD File Offset: 0x00F785FD
		public bool HasPendingProxy(int slotUid)
		{
			return this.PendingProxies.ContainsKey(slotUid);
		}

		// Token: 0x0603765E RID: 226910 RVA: 0x00F7A40B File Offset: 0x00F7860B
		public void SetProxyTemplate(EDangoBrawlTemplateType type, UUIItem template)
		{
			this.ProxyTemplates[type] = template;
		}

		// Token: 0x0603765F RID: 226911 RVA: 0x00F7A41C File Offset: 0x00F7861C
		[NullableContext(2)]
		public UUIItem GetProxyTemplate(EDangoBrawlTemplateType type)
		{
			UUIItem result;
			if (!this.ProxyTemplates.TryGetValue(type, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0401D3E7 RID: 119783
		private readonly Dictionary<int, IDangoBrawlDraggableView> Views = new Dictionary<int, IDangoBrawlDraggableView>();

		// Token: 0x0401D3E8 RID: 119784
		private readonly Dictionary<int, ICombineLineOwner> LineOwners = new Dictionary<int, ICombineLineOwner>();

		// Token: 0x0401D3E9 RID: 119785
		private readonly Dictionary<int, IDragVisual> PendingProxies = new Dictionary<int, IDragVisual>();

		// Token: 0x0401D3EA RID: 119786
		private readonly Dictionary<EDragTargetKind, IDangoBrawlItemZone> ItemZones = new Dictionary<EDragTargetKind, IDangoBrawlItemZone>();

		// Token: 0x0401D3EB RID: 119787
		private readonly Dictionary<EDangoBrawlTemplateType, UUIItem> ProxyTemplates = new Dictionary<EDangoBrawlTemplateType, UUIItem>();

		// Token: 0x0401D3EC RID: 119788
		[Nullable(2)]
		private DangoBrawlBackpackView BackpackView;
	}
}
