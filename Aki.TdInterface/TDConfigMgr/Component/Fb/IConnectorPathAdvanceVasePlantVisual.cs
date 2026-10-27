using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D1A RID: 3354
	public class IConnectorPathAdvanceVasePlantVisual : IConnectorPathAdvanceVisual
	{
		// Token: 0x06004C8A RID: 19594 RVA: 0x000BEA50 File Offset: 0x000BCC50
		[NullableContext(1)]
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

		// Token: 0x17001813 RID: 6163
		// (get) Token: 0x06004C8B RID: 19595 RVA: 0x000BEA6F File Offset: 0x000BCC6F
		public override EConnectorPathAdvanceVisualType Type
		{
			get
			{
				return (EConnectorPathAdvanceVisualType)this.Instance.Type;
			}
		}

		// Token: 0x17001814 RID: 6164
		// (get) Token: 0x06004C8C RID: 19596 RVA: 0x000BEA7C File Offset: 0x000BCC7C
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

		// Token: 0x17001815 RID: 6165
		// (get) Token: 0x06004C8D RID: 19597 RVA: 0x000BEAB4 File Offset: 0x000BCCB4
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

		// Token: 0x17001816 RID: 6166
		// (get) Token: 0x06004C8E RID: 19598 RVA: 0x000BEAEC File Offset: 0x000BCCEC
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

		// Token: 0x17001817 RID: 6167
		// (get) Token: 0x06004C8F RID: 19599 RVA: 0x000BEB24 File Offset: 0x000BCD24
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

		// Token: 0x17001818 RID: 6168
		// (get) Token: 0x06004C90 RID: 19600 RVA: 0x000BEB5C File Offset: 0x000BCD5C
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<string> PathRtList
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x04002BCF RID: 11215
		private IConnectorPathAdvanceVasePlantVisual Instance;

		// Token: 0x04002BD0 RID: 11216
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<string> _PathRtListCache;

		// Token: 0x04002BD1 RID: 11217
		private bool _PathRtListInited;
	}
}
