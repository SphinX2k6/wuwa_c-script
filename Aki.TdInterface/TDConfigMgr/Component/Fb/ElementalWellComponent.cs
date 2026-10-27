using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E3B RID: 3643
	[NullableContext(2)]
	[Nullable(0)]
	public class ElementalWellComponent : IComponentBase
	{
		// Token: 0x06005250 RID: 21072 RVA: 0x000CABB7 File Offset: 0x000C8DB7
		[NullableContext(1)]
		public static ElementalWellComponent Create(IElementalWellComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ElementalWellComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B97 RID: 7063
		// (get) Token: 0x06005251 RID: 21073 RVA: 0x000CABD8 File Offset: 0x000C8DD8
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

		// Token: 0x17001B98 RID: 7064
		// (get) Token: 0x06005252 RID: 21074 RVA: 0x000CAC10 File Offset: 0x000C8E10
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B99 RID: 7065
		// (get) Token: 0x06005253 RID: 21075 RVA: 0x000CAC26 File Offset: 0x000C8E26
		public virtual EElementalWellEntryType WellType
		{
			get
			{
				return (EElementalWellEntryType)this.Instance.WellType;
			}
		}

		// Token: 0x17001B9A RID: 7066
		// (get) Token: 0x06005254 RID: 21076 RVA: 0x000CAC33 File Offset: 0x000C8E33
		[Nullable(1)]
		public virtual IWellStreamingRenderConfig StreamingRenderConfig
		{
			[NullableContext(1)]
			get
			{
				if (this._StreamingRenderConfigInited)
				{
					return this._StreamingRenderConfigCache;
				}
				this._StreamingRenderConfigInited = true;
				this._StreamingRenderConfigCache = IWellStreamingRenderConfig.Create(this.Instance.StreamingRenderConfig);
				return this._StreamingRenderConfigCache;
			}
		}

		// Token: 0x17001B9B RID: 7067
		// (get) Token: 0x06005255 RID: 21077 RVA: 0x000CAC67 File Offset: 0x000C8E67
		[Nullable(1)]
		public virtual IStreamingWaitConfig StreamWaitConfig
		{
			[NullableContext(1)]
			get
			{
				if (this._StreamWaitConfigInited)
				{
					return this._StreamWaitConfigCache;
				}
				this._StreamWaitConfigInited = true;
				this._StreamWaitConfigCache = IStreamingWaitConfig.Create(this.Instance.StreamWaitConfig);
				return this._StreamWaitConfigCache;
			}
		}

		// Token: 0x17001B9C RID: 7068
		// (get) Token: 0x06005256 RID: 21078 RVA: 0x000CAC9B File Offset: 0x000C8E9B
		public virtual string StreamingFinishedToState
		{
			get
			{
				return this.Instance.StreamingFinishedToState;
			}
		}

		// Token: 0x17001B9D RID: 7069
		// (get) Token: 0x06005257 RID: 21079 RVA: 0x000CACA8 File Offset: 0x000C8EA8
		public virtual string LeaveRangeToState
		{
			get
			{
				return this.Instance.LeaveRangeToState;
			}
		}

		// Token: 0x17001B9E RID: 7070
		// (get) Token: 0x06005258 RID: 21080 RVA: 0x000CACB5 File Offset: 0x000C8EB5
		public virtual string PrefabBindPointKey
		{
			get
			{
				return this.Instance.PrefabBindPointKey;
			}
		}

		// Token: 0x04002F72 RID: 12146
		private IElementalWellComponent Instance;

		// Token: 0x04002F73 RID: 12147
		private IWellStreamingRenderConfig _StreamingRenderConfigCache;

		// Token: 0x04002F74 RID: 12148
		private bool _StreamingRenderConfigInited;

		// Token: 0x04002F75 RID: 12149
		private IStreamingWaitConfig _StreamWaitConfigCache;

		// Token: 0x04002F76 RID: 12150
		private bool _StreamWaitConfigInited;
	}
}
