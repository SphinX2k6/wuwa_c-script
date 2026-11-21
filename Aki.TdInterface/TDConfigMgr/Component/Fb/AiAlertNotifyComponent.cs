using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D82 RID: 3458
	[NullableContext(2)]
	[Nullable(0)]
	public class AiAlertNotifyComponent : IComponentBase
	{
		// Token: 0x06004E93 RID: 20115 RVA: 0x000C3D8A File Offset: 0x000C1F8A
		[NullableContext(0)]
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

		// Token: 0x1700178A RID: 6026
		// (get) Token: 0x06004E94 RID: 20116 RVA: 0x000C3DAC File Offset: 0x000C1FAC
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

		// Token: 0x1700178B RID: 6027
		// (get) Token: 0x06004E95 RID: 20117 RVA: 0x000C3DE4 File Offset: 0x000C1FE4
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700178C RID: 6028
		// (get) Token: 0x06004E96 RID: 20118 RVA: 0x000C3DFA File Offset: 0x000C1FFA
		[Nullable(0)]
		public virtual IExtraAiAlert ExtraAiAlert
		{
			[NullableContext(0)]
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

		// Token: 0x1700178D RID: 6029
		// (get) Token: 0x06004E97 RID: 20119 RVA: 0x000C3E30 File Offset: 0x000C2030
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

		// Token: 0x1700178E RID: 6030
		// (get) Token: 0x06004E98 RID: 20120 RVA: 0x000C3EA5 File Offset: 0x000C20A5
		public virtual string AlertSound
		{
			get
			{
				return this.Instance.AlertSound;
			}
		}

		// Token: 0x04002CAF RID: 11439
		private IAiAlertNotifyComponent Instance;

		// Token: 0x04002CB0 RID: 11440
		private IExtraAiAlert _ExtraAiAlertCache;

		// Token: 0x04002CB1 RID: 11441
		private bool _ExtraAiAlertInited;

		// Token: 0x04002CB2 RID: 11442
		private List<int> _ExcludeEntitiesCache;

		// Token: 0x04002CB3 RID: 11443
		private bool _ExcludeEntitiesInited;
	}
}
