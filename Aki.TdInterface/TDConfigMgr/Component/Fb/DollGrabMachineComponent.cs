using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EF5 RID: 3829
	public class DollGrabMachineComponent : IComponentBase
	{
		// Token: 0x0600562B RID: 22059 RVA: 0x000D3886 File Offset: 0x000D1A86
		public static DollGrabMachineComponent Create(IDollGrabMachineComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DollGrabMachineComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001C3C RID: 7228
		// (get) Token: 0x0600562C RID: 22060 RVA: 0x000D38A8 File Offset: 0x000D1AA8
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17001C3D RID: 7229
		// (get) Token: 0x0600562D RID: 22061 RVA: 0x000D38E0 File Offset: 0x000D1AE0
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C3E RID: 7230
		// (get) Token: 0x0600562E RID: 22062 RVA: 0x000D38F6 File Offset: 0x000D1AF6
		public virtual EDollGrabShowcaseBelongType BelongType
		{
			get
			{
				return (EDollGrabShowcaseBelongType)this.Instance.BelongType;
			}
		}

		// Token: 0x17001C3F RID: 7231
		// (get) Token: 0x0600562F RID: 22063 RVA: 0x000D3903 File Offset: 0x000D1B03
		public virtual float TimeLimit
		{
			get
			{
				return this.Instance.TimeLimit;
			}
		}

		// Token: 0x17001C40 RID: 7232
		// (get) Token: 0x06005630 RID: 22064 RVA: 0x000D3910 File Offset: 0x000D1B10
		public virtual float? PlayCost
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new float?(this.Instance.PlayCost);
			}
		}

		// Token: 0x17001C41 RID: 7233
		// (get) Token: 0x06005631 RID: 22065 RVA: 0x000D3948 File Offset: 0x000D1B48
		public virtual List<IDollGrabItem> Items
		{
			get
			{
				if (this._ItemsInited)
				{
					return this._ItemsCache;
				}
				this._ItemsInited = true;
				int itemsLength = this.Instance.ItemsLength;
				this._ItemsCache = new List<IDollGrabItem>(itemsLength);
				for (int i = 0; i < itemsLength; i++)
				{
					this._ItemsCache.Add(IDollGrabItem.Create(this.Instance.Items(i)));
				}
				return this._ItemsCache;
			}
		}

		// Token: 0x17001C42 RID: 7234
		// (get) Token: 0x06005632 RID: 22066 RVA: 0x000D39B1 File Offset: 0x000D1BB1
		[Nullable(2)]
		public virtual IDollGrabInfiniteModeData InfiniteModeData
		{
			[NullableContext(2)]
			get
			{
				if (this._InfiniteModeDataInited)
				{
					return this._InfiniteModeDataCache;
				}
				this._InfiniteModeDataInited = true;
				this._InfiniteModeDataCache = IDollGrabInfiniteModeData.Create(this.Instance.InfiniteModeData);
				return this._InfiniteModeDataCache;
			}
		}

		// Token: 0x17001C43 RID: 7235
		// (get) Token: 0x06005633 RID: 22067 RVA: 0x000D39E5 File Offset: 0x000D1BE5
		[Nullable(2)]
		public virtual string AkEvent
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.AkEvent;
			}
		}

		// Token: 0x0400315C RID: 12636
		private IDollGrabMachineComponent Instance;

		// Token: 0x0400315D RID: 12637
		private List<IDollGrabItem> _ItemsCache;

		// Token: 0x0400315E RID: 12638
		private bool _ItemsInited;

		// Token: 0x0400315F RID: 12639
		[Nullable(2)]
		private IDollGrabInfiniteModeData _InfiniteModeDataCache;

		// Token: 0x04003160 RID: 12640
		private bool _InfiniteModeDataInited;
	}
}
