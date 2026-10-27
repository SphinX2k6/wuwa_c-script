using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DF9 RID: 3577
	[NullableContext(2)]
	[Nullable(0)]
	public class DollGrabMachineComponent : IComponentBase
	{
		// Token: 0x06005104 RID: 20740 RVA: 0x000C7FBE File Offset: 0x000C61BE
		[NullableContext(1)]
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

		// Token: 0x17001ACF RID: 6863
		// (get) Token: 0x06005105 RID: 20741 RVA: 0x000C7FE0 File Offset: 0x000C61E0
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

		// Token: 0x17001AD0 RID: 6864
		// (get) Token: 0x06005106 RID: 20742 RVA: 0x000C8018 File Offset: 0x000C6218
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001AD1 RID: 6865
		// (get) Token: 0x06005107 RID: 20743 RVA: 0x000C802E File Offset: 0x000C622E
		public virtual EDollGrabShowcaseBelongType BelongType
		{
			get
			{
				return (EDollGrabShowcaseBelongType)this.Instance.BelongType;
			}
		}

		// Token: 0x17001AD2 RID: 6866
		// (get) Token: 0x06005108 RID: 20744 RVA: 0x000C803B File Offset: 0x000C623B
		public virtual float TimeLimit
		{
			get
			{
				return this.Instance.TimeLimit;
			}
		}

		// Token: 0x17001AD3 RID: 6867
		// (get) Token: 0x06005109 RID: 20745 RVA: 0x000C8048 File Offset: 0x000C6248
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

		// Token: 0x17001AD4 RID: 6868
		// (get) Token: 0x0600510A RID: 20746 RVA: 0x000C8080 File Offset: 0x000C6280
		[Nullable(1)]
		public virtual List<IDollGrabItem> Items
		{
			[NullableContext(1)]
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

		// Token: 0x17001AD5 RID: 6869
		// (get) Token: 0x0600510B RID: 20747 RVA: 0x000C80E9 File Offset: 0x000C62E9
		public virtual IDollGrabInfiniteModeData InfiniteModeData
		{
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

		// Token: 0x17001AD6 RID: 6870
		// (get) Token: 0x0600510C RID: 20748 RVA: 0x000C811D File Offset: 0x000C631D
		public virtual string AkEvent
		{
			get
			{
				return this.Instance.AkEvent;
			}
		}

		// Token: 0x04002E94 RID: 11924
		private IDollGrabMachineComponent Instance;

		// Token: 0x04002E95 RID: 11925
		[Nullable(1)]
		private List<IDollGrabItem> _ItemsCache;

		// Token: 0x04002E96 RID: 11926
		private bool _ItemsInited;

		// Token: 0x04002E97 RID: 11927
		private IDollGrabInfiniteModeData _InfiniteModeDataCache;

		// Token: 0x04002E98 RID: 11928
		private bool _InfiniteModeDataInited;
	}
}
