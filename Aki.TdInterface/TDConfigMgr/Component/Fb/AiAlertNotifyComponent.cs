using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CA0 RID: 3232
	[NullableContext(2)]
	[Nullable(0)]
	public class AiAlertNotifyComponent : IComponentBase
	{
		// Token: 0x060049E5 RID: 18917 RVA: 0x000B937A File Offset: 0x000B757A
		[NullableContext(1)]
		public static AiAlertNotifyComponent Create(IAiAlertNotifyComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AiAlertNotifyComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001662 RID: 5730
		// (get) Token: 0x060049E6 RID: 18918 RVA: 0x000B939C File Offset: 0x000B759C
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

		// Token: 0x17001663 RID: 5731
		// (get) Token: 0x060049E7 RID: 18919 RVA: 0x000B93D4 File Offset: 0x000B75D4
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001664 RID: 5732
		// (get) Token: 0x060049E8 RID: 18920 RVA: 0x000B93EA File Offset: 0x000B75EA
		[Nullable(1)]
		public virtual IExtraAiAlert ExtraAiAlert
		{
			[NullableContext(1)]
			get
			{
				if (this._ExtraAiAlertInited)
				{
					return this._ExtraAiAlertCache;
				}
				this._ExtraAiAlertInited = true;
				this._ExtraAiAlertCache = IExtraAiAlert.Create(this.Instance.ExtraAiAlert);
				return this._ExtraAiAlertCache;
			}
		}

		// Token: 0x17001665 RID: 5733
		// (get) Token: 0x060049E9 RID: 18921 RVA: 0x000B9420 File Offset: 0x000B7620
		public virtual List<int> ExcludeEntities
		{
			get
			{
				if (this._ExcludeEntitiesInited)
				{
					return this._ExcludeEntitiesCache;
				}
				this._ExcludeEntitiesInited = true;
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int excludeEntitiesLength = this.Instance.ExcludeEntitiesLength;
				this._ExcludeEntitiesCache = new List<int>(excludeEntitiesLength);
				for (int i = 0; i < excludeEntitiesLength; i++)
				{
					this._ExcludeEntitiesCache.Add(this.Instance.ExcludeEntities(i));
				}
				return this._ExcludeEntitiesCache;
			}
		}

		// Token: 0x17001666 RID: 5734
		// (get) Token: 0x060049EA RID: 18922 RVA: 0x000B9495 File Offset: 0x000B7695
		public virtual string AlertSound
		{
			get
			{
				return this.Instance.AlertSound;
			}
		}

		// Token: 0x04002A35 RID: 10805
		private IAiAlertNotifyComponent Instance;

		// Token: 0x04002A36 RID: 10806
		private IExtraAiAlert _ExtraAiAlertCache;

		// Token: 0x04002A37 RID: 10807
		private bool _ExtraAiAlertInited;

		// Token: 0x04002A38 RID: 10808
		private List<int> _ExcludeEntitiesCache;

		// Token: 0x04002A39 RID: 10809
		private bool _ExcludeEntitiesInited;
	}
}
