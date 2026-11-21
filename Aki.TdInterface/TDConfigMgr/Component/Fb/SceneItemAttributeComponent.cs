using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B9F RID: 2975
	public class SceneItemAttributeComponent : IComponentBase
	{
		// Token: 0x06004410 RID: 17424 RVA: 0x000ACC33 File Offset: 0x000AAE33
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

		// Token: 0x170010CD RID: 4301
		// (get) Token: 0x06004411 RID: 17425 RVA: 0x000ACC54 File Offset: 0x000AAE54
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

		// Token: 0x170010CE RID: 4302
		// (get) Token: 0x06004412 RID: 17426 RVA: 0x000ACC8C File Offset: 0x000AAE8C
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010CF RID: 4303
		// (get) Token: 0x06004413 RID: 17427 RVA: 0x000ACCA2 File Offset: 0x000AAEA2
		public virtual string AttributeType
		{
			get
			{
				return this.Instance.AttributeType;
			}
		}

		// Token: 0x170010D0 RID: 4304
		// (get) Token: 0x06004414 RID: 17428 RVA: 0x000ACCB0 File Offset: 0x000AAEB0
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

		// Token: 0x040025B2 RID: 9650
		private ISceneItemAttributeComponent Instance;

		// Token: 0x040025B3 RID: 9651
		[Nullable(2)]
		private List<int> _DefaultTagsCache;

		// Token: 0x040025B4 RID: 9652
		private bool _DefaultTagsInited;
	}
}
