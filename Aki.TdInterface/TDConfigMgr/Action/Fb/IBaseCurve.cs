using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028A2 RID: 10402
	[NullableContext(2)]
	[Nullable(0)]
	public class IBaseCurve
	{
		// Token: 0x0600E646 RID: 58950 RVA: 0x0021D5BC File Offset: 0x0021B7BC
		[NullableContext(1)]
		public static IBaseCurve Create(IBaseCurve? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBaseCurve
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170046C4 RID: 18116
		// (get) Token: 0x0600E647 RID: 58951 RVA: 0x0021D5DB File Offset: 0x0021B7DB
		public virtual EBaseCurveType Type
		{
			get
			{
				return (EBaseCurveType)this.Instance.Type;
			}
		}

		// Token: 0x170046C5 RID: 18117
		// (get) Token: 0x0600E648 RID: 58952 RVA: 0x0021D5E8 File Offset: 0x0021B7E8
		public virtual float N
		{
			get
			{
				return this.Instance.N;
			}
		}

		// Token: 0x170046C6 RID: 18118
		// (get) Token: 0x0600E649 RID: 58953 RVA: 0x0021D5F5 File Offset: 0x0021B7F5
		public virtual string CurveAsset
		{
			get
			{
				return this.Instance.CurveAsset;
			}
		}

		// Token: 0x04007F52 RID: 32594
		private IBaseCurve Instance;
	}
}
