using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002960 RID: 10592
	public class IShowMapMark : ToggleMapMarkState
	{
		// Token: 0x0600EAD3 RID: 60115 RVA: 0x00226158 File Offset: 0x00224358
		[NullableContext(1)]
		public static IShowMapMark Create(IShowMapMark? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowMapMark
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049D5 RID: 18901
		// (get) Token: 0x0600EAD4 RID: 60116 RVA: 0x00226177 File Offset: 0x00224377
		public override EMapMarkState Type
		{
			get
			{
				return (EMapMarkState)this.Instance.Type;
			}
		}

		// Token: 0x170049D6 RID: 18902
		// (get) Token: 0x0600EAD5 RID: 60117 RVA: 0x00226184 File Offset: 0x00224384
		public virtual int MarkId
		{
			get
			{
				return this.Instance.MarkId;
			}
		}

		// Token: 0x170049D7 RID: 18903
		// (get) Token: 0x0600EAD6 RID: 60118 RVA: 0x00226194 File Offset: 0x00224394
		public virtual bool? IsFocusOnFirstShow
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsFocusOnFirstShow);
			}
		}

		// Token: 0x04008168 RID: 33128
		private IShowMapMark Instance;
	}
}
