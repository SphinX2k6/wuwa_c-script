using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B72 RID: 2930
	public class VisionComponent : IComponentBase
	{
		// Token: 0x06004382 RID: 17282 RVA: 0x000AC183 File Offset: 0x000AA383
		[NullableContext(1)]
		public static VisionComponent Create(IVisionComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new VisionComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700125B RID: 4699
		// (get) Token: 0x06004383 RID: 17283 RVA: 0x000AC1A4 File Offset: 0x000AA3A4
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

		// Token: 0x1700125C RID: 4700
		// (get) Token: 0x06004384 RID: 17284 RVA: 0x000AC1DC File Offset: 0x000AA3DC
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700125D RID: 4701
		// (get) Token: 0x06004385 RID: 17285 RVA: 0x000AC1F2 File Offset: 0x000AA3F2
		public virtual int VisionId
		{
			get
			{
				return this.Instance.VisionId;
			}
		}

		// Token: 0x04002619 RID: 9753
		private IVisionComponent Instance;
	}
}
