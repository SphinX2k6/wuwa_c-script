using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E14 RID: 3604
	public class IConnectorPathAdvanceVasePlantVisual : IConnectorPathAdvanceVisual
	{
		// Token: 0x060051A4 RID: 20900 RVA: 0x000CA124 File Offset: 0x000C8324
		public static IConnectorPathAdvanceVasePlantVisual Create(IConnectorPathAdvanceVasePlantVisual? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IConnectorPathAdvanceVasePlantVisual
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001977 RID: 6519
		// (get) Token: 0x060051A5 RID: 20901 RVA: 0x000CA143 File Offset: 0x000C8343
		public override EConnectorPathAdvanceVisualType Type
		{
			get
			{
				return (EConnectorPathAdvanceVisualType)this.Instance.Type;
			}
		}

		// Token: 0x17001978 RID: 6520
		// (get) Token: 0x060051A6 RID: 20902 RVA: 0x000CA150 File Offset: 0x000C8350
		public virtual float? ScatterWidth
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.ScatterWidth);
			}
		}

		// Token: 0x17001979 RID: 6521
		// (get) Token: 0x060051A7 RID: 20903 RVA: 0x000CA188 File Offset: 0x000C8388
		public virtual float? ScatterDensity
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new float?(this.Instance.ScatterDensity);
			}
		}

		// Token: 0x1700197A RID: 6522
		// (get) Token: 0x060051A8 RID: 20904 RVA: 0x000CA1C0 File Offset: 0x000C83C0
		public virtual float? Scale
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new float?(this.Instance.Scale);
			}
		}

		// Token: 0x1700197B RID: 6523
		// (get) Token: 0x060051A9 RID: 20905 RVA: 0x000CA1F8 File Offset: 0x000C83F8
		public virtual bool? SnapToSurface
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.SnapToSurface);
			}
		}

		// Token: 0x1700197C RID: 6524
		// (get) Token: 0x060051AA RID: 20906 RVA: 0x000CA230 File Offset: 0x000C8430
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<string> PathRtList
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._PathRtListInited)
				{
					return this._PathRtListCache;
				}
				this._PathRtListInited = true;
				if ((this.Instance.NullMask & 16) == 0)
				{
					return null;
				}
				int pathRtListLength = this.Instance.PathRtListLength;
				this._PathRtListCache = new List<string>(pathRtListLength);
				for (int i = 0; i < pathRtListLength; i++)
				{
					this._PathRtListCache.Add(this.Instance.PathRtList(i));
				}
				return this._PathRtListCache;
			}
		}

		// Token: 0x04002E8F RID: 11919
		private IConnectorPathAdvanceVasePlantVisual Instance;

		// Token: 0x04002E90 RID: 11920
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<string> _PathRtListCache;

		// Token: 0x04002E91 RID: 11921
		private bool _PathRtListInited;
	}
}
