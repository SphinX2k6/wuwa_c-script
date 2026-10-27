using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AD5 RID: 2773
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemAttributeComponent : IComponentBase
	{
		// Token: 0x06003FE6 RID: 16358 RVA: 0x000A363F File Offset: 0x000A183F
		public static SceneItemAttributeComponent Create(ISceneItemAttributeComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SceneItemAttributeComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000FF9 RID: 4089
		// (get) Token: 0x06003FE7 RID: 16359 RVA: 0x000A3660 File Offset: 0x000A1860
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

		// Token: 0x17000FFA RID: 4090
		// (get) Token: 0x06003FE8 RID: 16360 RVA: 0x000A3698 File Offset: 0x000A1898
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000FFB RID: 4091
		// (get) Token: 0x06003FE9 RID: 16361 RVA: 0x000A36AE File Offset: 0x000A18AE
		public virtual string AttributeType
		{
			get
			{
				return this.Instance.AttributeType;
			}
		}

		// Token: 0x17000FFC RID: 4092
		// (get) Token: 0x06003FEA RID: 16362 RVA: 0x000A36BC File Offset: 0x000A18BC
		[Nullable(2)]
		public virtual List<int> DefaultTags
		{
			[NullableContext(2)]
			get
			{
				if (this._DefaultTagsInited)
				{
					return this._DefaultTagsCache;
				}
				this._DefaultTagsInited = true;
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int defaultTagsLength = this.Instance.DefaultTagsLength;
				this._DefaultTagsCache = new List<int>(defaultTagsLength);
				for (int i = 0; i < defaultTagsLength; i++)
				{
					this._DefaultTagsCache.Add(this.Instance.DefaultTags(i));
				}
				return this._DefaultTagsCache;
			}
		}

		// Token: 0x04002396 RID: 9110
		private ISceneItemAttributeComponent Instance;

		// Token: 0x04002397 RID: 9111
		[Nullable(2)]
		private List<int> _DefaultTagsCache;

		// Token: 0x04002398 RID: 9112
		private bool _DefaultTagsInited;
	}
}
