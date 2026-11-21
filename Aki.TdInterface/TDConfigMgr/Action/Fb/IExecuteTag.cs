using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B1A RID: 11034
	public class IExecuteTag : IInteractEffect
	{
		// Token: 0x0600F2B8 RID: 62136 RVA: 0x0023716F File Offset: 0x0023536F
		public static IExecuteTag Create(IExecuteTag? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExecuteTag
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004932 RID: 18738
		// (get) Token: 0x0600F2B9 RID: 62137 RVA: 0x0023718E File Offset: 0x0023538E
		public override EInteractEffectType Type
		{
			get
			{
				return (EInteractEffectType)this.Instance.Type;
			}
		}

		// Token: 0x17004933 RID: 18739
		// (get) Token: 0x0600F2BA RID: 62138 RVA: 0x0023719C File Offset: 0x0023539C
		public override float? DelayTime
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.DelayTime);
			}
		}

		// Token: 0x17004934 RID: 18740
		// (get) Token: 0x0600F2BB RID: 62139 RVA: 0x002371D4 File Offset: 0x002353D4
		public virtual List<int> Tags
		{
			get
			{
				if (this._TagsInited)
				{
					return this._TagsCache;
				}
				this._TagsInited = true;
				int tagsLength = this.Instance.TagsLength;
				this._TagsCache = new List<int>(tagsLength);
				for (int i = 0; i < tagsLength; i++)
				{
					this._TagsCache.Add(this.Instance.Tags(i));
				}
				return this._TagsCache;
			}
		}

		// Token: 0x0400852E RID: 34094
		private IExecuteTag Instance;

		// Token: 0x0400852F RID: 34095
		private List<int> _TagsCache;

		// Token: 0x04008530 RID: 34096
		private bool _TagsInited;
	}
}
