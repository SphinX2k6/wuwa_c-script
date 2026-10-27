using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025E7 RID: 9703
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlayScreenEffect : PlayEffect2
	{
		// Token: 0x0600DA10 RID: 55824 RVA: 0x002081FA File Offset: 0x002063FA
		public static IPlayScreenEffect Create(IPlayScreenEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayScreenEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004004 RID: 16388
		// (get) Token: 0x0600DA11 RID: 55825 RVA: 0x00208219 File Offset: 0x00206419
		public override EEffectType Type
		{
			get
			{
				return (EEffectType)this.Instance.Type;
			}
		}

		// Token: 0x17004005 RID: 16389
		// (get) Token: 0x0600DA12 RID: 55826 RVA: 0x00208226 File Offset: 0x00206426
		public override string Path
		{
			get
			{
				return this.Instance.Path;
			}
		}

		// Token: 0x17004006 RID: 16390
		// (get) Token: 0x0600DA13 RID: 55827 RVA: 0x00208234 File Offset: 0x00206434
		public virtual float? DestroyTime
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.DestroyTime);
			}
		}

		// Token: 0x17004007 RID: 16391
		// (get) Token: 0x0600DA14 RID: 55828 RVA: 0x0020826A File Offset: 0x0020646A
		[Nullable(2)]
		public virtual string BindSubScreenKey
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.BindSubScreenKey;
			}
		}

		// Token: 0x0400791B RID: 31003
		private IPlayScreenEffect Instance;
	}
}
