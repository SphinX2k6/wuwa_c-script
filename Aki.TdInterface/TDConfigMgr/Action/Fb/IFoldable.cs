using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024D3 RID: 9427
	public class IFoldable
	{
		// Token: 0x0600D293 RID: 53907 RVA: 0x001F3DF4 File Offset: 0x001F1FF4
		[NullableContext(1)]
		public static IFoldable Create(IFoldable? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFoldable
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003AAF RID: 15023
		// (get) Token: 0x0600D294 RID: 53908 RVA: 0x001F3E14 File Offset: 0x001F2014
		public virtual bool? _Folded
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance._Folded);
			}
		}

		// Token: 0x0400737F RID: 29567
		private IFoldable Instance;
	}
}
