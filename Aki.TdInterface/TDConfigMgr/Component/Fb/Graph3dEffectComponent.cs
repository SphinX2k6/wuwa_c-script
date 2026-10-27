using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E46 RID: 3654
	[NullableContext(1)]
	[Nullable(0)]
	public class Graph3dEffectComponent : IComponentBase
	{
		// Token: 0x06005288 RID: 21128 RVA: 0x000CB247 File Offset: 0x000C9447
		public static Graph3dEffectComponent Create(IGraph3dEffectComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new Graph3dEffectComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001BB9 RID: 7097
		// (get) Token: 0x06005289 RID: 21129 RVA: 0x000CB268 File Offset: 0x000C9468
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

		// Token: 0x17001BBA RID: 7098
		// (get) Token: 0x0600528A RID: 21130 RVA: 0x000CB2A0 File Offset: 0x000C94A0
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001BBB RID: 7099
		// (get) Token: 0x0600528B RID: 21131 RVA: 0x000CB2B6 File Offset: 0x000C94B6
		public virtual int Graph3dEntityId
		{
			get
			{
				return this.Instance.Graph3dEntityId;
			}
		}

		// Token: 0x17001BBC RID: 7100
		// (get) Token: 0x0600528C RID: 21132 RVA: 0x000CB2C3 File Offset: 0x000C94C3
		public virtual IFireBoxFishEffect EffectType
		{
			get
			{
				if (this._EffectTypeInited)
				{
					return this._EffectTypeCache;
				}
				this._EffectTypeInited = true;
				this._EffectTypeCache = IFireBoxFishEffect.Create(this.Instance.EffectType);
				return this._EffectTypeCache;
			}
		}

		// Token: 0x04002F91 RID: 12177
		private IGraph3dEffectComponent Instance;

		// Token: 0x04002F92 RID: 12178
		[Nullable(2)]
		private IFireBoxFishEffect _EffectTypeCache;

		// Token: 0x04002F93 RID: 12179
		private bool _EffectTypeInited;
	}
}
