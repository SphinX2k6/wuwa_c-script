using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DDC RID: 3548
	public class ICombineDaNpcModel : INpcModelConfig
	{
		// Token: 0x0600506B RID: 20587 RVA: 0x000C7854 File Offset: 0x000C5A54
		public static ICombineDaNpcModel Create(ICombineDaNpcModel? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICombineDaNpcModel
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170018AE RID: 6318
		// (get) Token: 0x0600506C RID: 20588 RVA: 0x000C7873 File Offset: 0x000C5A73
		public override ENpcModelType Type
		{
			get
			{
				return (ENpcModelType)this.Instance.Type;
			}
		}

		// Token: 0x170018AF RID: 6319
		// (get) Token: 0x0600506D RID: 20589 RVA: 0x000C7880 File Offset: 0x000C5A80
		public virtual string Da
		{
			get
			{
				return this.Instance.Da;
			}
		}

		// Token: 0x170018B0 RID: 6320
		// (get) Token: 0x0600506E RID: 20590 RVA: 0x000C7890 File Offset: 0x000C5A90
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<string> InitialHiddenAttachTypes
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._InitialHiddenAttachTypesInited)
				{
					return this._InitialHiddenAttachTypesCache;
				}
				this._InitialHiddenAttachTypesInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int initialHiddenAttachTypesLength = this.Instance.InitialHiddenAttachTypesLength;
				this._InitialHiddenAttachTypesCache = new List<string>(initialHiddenAttachTypesLength);
				for (int i = 0; i < initialHiddenAttachTypesLength; i++)
				{
					this._InitialHiddenAttachTypesCache.Add(this.Instance.InitialHiddenAttachTypes(i));
				}
				return this._InitialHiddenAttachTypesCache;
			}
		}

		// Token: 0x04002DD1 RID: 11729
		private ICombineDaNpcModel Instance;

		// Token: 0x04002DD2 RID: 11730
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<string> _InitialHiddenAttachTypesCache;

		// Token: 0x04002DD3 RID: 11731
		private bool _InitialHiddenAttachTypesInited;
	}
}
