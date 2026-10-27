using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch
{
	// Token: 0x02006858 RID: 26712
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlItemViewRegistry
	{
		// Token: 0x06042AF7 RID: 273143 RVA: 0x01038C85 File Offset: 0x01036E85
		public void Start()
		{
		}

		// Token: 0x06042AF8 RID: 273144 RVA: 0x01038C88 File Offset: 0x01036E88
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

		// Token: 0x06042AF9 RID: 273145 RVA: 0x01038D1C File Offset: 0x01036F1C
		public void Register(int uid, IDangoBrawlDraggableView view)
		{
			if (uid <= 0)
			{
				return;
			}
			this.Views[uid] = view;
		}

		// Token: 0x06042AFA RID: 273146 RVA: 0x01038D30 File Offset: 0x01036F30
		public void Unregister(int uid)
		{
			this.Views.Remove(uid);
		}

		// Token: 0x06042AFB RID: 273147 RVA: 0x01038D40 File Offset: 0x01036F40
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

		// Token: 0x06042AFC RID: 273148 RVA: 0x01038D60 File Offset: 0x01036F60
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

		// Token: 0x06042AFD RID: 273149 RVA: 0x01038D85 File Offset: 0x01036F85
		public void RegisterBackpackView(DangoBrawlBackpackView view)
		{
			this.BackpackView = view;
		}

		// Token: 0x06042AFE RID: 273150 RVA: 0x01038D8E File Offset: 0x01036F8E
		public void UnregisterBackpackView(DangoBrawlBackpackView view)
		{
			if (this.BackpackView == view)
			{
				this.BackpackView = null;
			}
		}

		// Token: 0x06042AFF RID: 273151 RVA: 0x01038DA0 File Offset: 0x01036FA0
		[NullableContext(2)]
		public DangoBrawlBackpackView GetBackpackView()
		{
			return this.BackpackView;
		}

		// Token: 0x06042B00 RID: 273152 RVA: 0x01038DA8 File Offset: 0x01036FA8
		public void RegisterItemZone(EDragTargetKind kind, IDangoBrawlItemZone zone)
		{
			this.ItemZones[kind] = zone;
		}

		// Token: 0x06042B01 RID: 273153 RVA: 0x01038DB7 File Offset: 0x01036FB7
		public void UnregisterItemZone(EDragTargetKind kind)
		{
			this.ItemZones.Remove(kind);
		}

		// Token: 0x06042B02 RID: 273154 RVA: 0x01038DC8 File Offset: 0x01036FC8
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

		// Token: 0x06042B03 RID: 273155 RVA: 0x01038DE8 File Offset: 0x01036FE8
		public void RegisterLineOwner(int uid, ICombineLineOwner owner)
		{
			if (uid <= 0)
			{
				return;
			}
			this.LineOwners[uid] = owner;
		}

		// Token: 0x06042B04 RID: 273156 RVA: 0x01038DFC File Offset: 0x01036FFC
		public void UnregisterLineOwner(int uid, ICombineLineOwner owner)
		{
			ICombineLineOwner combineLineOwner;
			if (this.LineOwners.TryGetValue(uid, out combineLineOwner) && combineLineOwner == owner)
			{
				this.LineOwners.Remove(uid);
			}
		}

		// Token: 0x06042B05 RID: 273157 RVA: 0x01038E2C File Offset: 0x0103702C
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

		// Token: 0x06042B06 RID: 273158 RVA: 0x01038E4C File Offset: 0x0103704C
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

		// Token: 0x06042B07 RID: 273159 RVA: 0x01038E84 File Offset: 0x01037084
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

		// Token: 0x06042B08 RID: 273160 RVA: 0x01038EB1 File Offset: 0x010370B1
		public bool HasPendingProxy(int slotUid)
		{
			return this.PendingProxies.ContainsKey(slotUid);
		}

		// Token: 0x06042B09 RID: 273161 RVA: 0x01038EBF File Offset: 0x010370BF
		public void SetProxyTemplate(EDangoBrawlTemplateType type, UUIItem template)
		{
			this.ProxyTemplates[type] = template;
		}

		// Token: 0x06042B0A RID: 273162 RVA: 0x01038ED0 File Offset: 0x010370D0
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

		// Token: 0x04022B8A RID: 142218
		private readonly Dictionary<int, IDangoBrawlDraggableView> Views = new Dictionary<int, IDangoBrawlDraggableView>();

		// Token: 0x04022B8B RID: 142219
		private readonly Dictionary<int, ICombineLineOwner> LineOwners = new Dictionary<int, ICombineLineOwner>();

		// Token: 0x04022B8C RID: 142220
		private readonly Dictionary<int, IDragVisual> PendingProxies = new Dictionary<int, IDragVisual>();

		// Token: 0x04022B8D RID: 142221
		private readonly Dictionary<EDragTargetKind, IDangoBrawlItemZone> ItemZones = new Dictionary<EDragTargetKind, IDangoBrawlItemZone>();

		// Token: 0x04022B8E RID: 142222
		private readonly Dictionary<EDangoBrawlTemplateType, UUIItem> ProxyTemplates = new Dictionary<EDangoBrawlTemplateType, UUIItem>();

		// Token: 0x04022B8F RID: 142223
		[Nullable(2)]
		private DangoBrawlBackpackView BackpackView;
	}
}
