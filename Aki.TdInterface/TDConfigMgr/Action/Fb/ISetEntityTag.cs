using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026DF RID: 9951
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetEntityTag
	{
		// Token: 0x0600DE52 RID: 56914 RVA: 0x0020FC77 File Offset: 0x0020DE77
		public static ISetEntityTag Create(ISetEntityTag? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetEntityTag
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004256 RID: 16982
		// (get) Token: 0x0600DE53 RID: 56915 RVA: 0x0020FC96 File Offset: 0x0020DE96
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17004257 RID: 16983
		// (get) Token: 0x0600DE54 RID: 56916 RVA: 0x0020FCA3 File Offset: 0x0020DEA3
		public virtual string GameplayTag
		{
			get
			{
				return this.Instance.GameplayTag;
			}
		}

		// Token: 0x17004258 RID: 16984
		// (get) Token: 0x0600DE55 RID: 56917 RVA: 0x0020FCB0 File Offset: 0x0020DEB0
		public virtual ESetEntityTagType SetType
		{
			get
			{
				return (ESetEntityTagType)this.Instance.SetType;
			}
		}

		// Token: 0x17004259 RID: 16985
		// (get) Token: 0x0600DE56 RID: 56918 RVA: 0x0020FCC0 File Offset: 0x0020DEC0
		public virtual float? DelayTime
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

		// Token: 0x1700425A RID: 16986
		// (get) Token: 0x0600DE57 RID: 56919 RVA: 0x0020FCF8 File Offset: 0x0020DEF8
		public virtual bool? BeforeHide
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.BeforeHide);
			}
		}

		// Token: 0x04007B6B RID: 31595
		private ISetEntityTag Instance;
	}
}
