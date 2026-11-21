using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200295C RID: 10588
	[NullableContext(2)]
	[Nullable(0)]
	public class ICustomScreenTextSetting
	{
		// Token: 0x0600EB05 RID: 60165 RVA: 0x0022A5E5 File Offset: 0x002287E5
		[NullableContext(0)]
		public static ICustomScreenTextSetting Create(ICustomScreenTextSetting? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomScreenTextSetting
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044FB RID: 17659
		// (get) Token: 0x0600EB06 RID: 60166 RVA: 0x0022A604 File Offset: 0x00228804
		public virtual bool? IsShowTextInfo
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsShowTextInfo);
			}
		}

		// Token: 0x170044FC RID: 17660
		// (get) Token: 0x0600EB07 RID: 60167 RVA: 0x0022A63A File Offset: 0x0022883A
		public virtual string TidTextContent
		{
			get
			{
				return this.Instance.TidTextContent;
			}
		}

		// Token: 0x170044FD RID: 17661
		// (get) Token: 0x0600EB08 RID: 60168 RVA: 0x0022A647 File Offset: 0x00228847
		public virtual string EdTidTextContent
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04008178 RID: 33144
		private ICustomScreenTextSetting Instance;
	}
}
