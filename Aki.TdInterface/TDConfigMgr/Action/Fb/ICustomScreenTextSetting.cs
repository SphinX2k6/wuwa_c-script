using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002699 RID: 9881
	[NullableContext(2)]
	[Nullable(0)]
	public class ICustomScreenTextSetting
	{
		// Token: 0x0600DD2E RID: 56622 RVA: 0x0020DE45 File Offset: 0x0020C045
		[NullableContext(1)]
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

		// Token: 0x170041BE RID: 16830
		// (get) Token: 0x0600DD2F RID: 56623 RVA: 0x0020DE64 File Offset: 0x0020C064
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

		// Token: 0x170041BF RID: 16831
		// (get) Token: 0x0600DD30 RID: 56624 RVA: 0x0020DE9A File Offset: 0x0020C09A
		public virtual string TidTextContent
		{
			get
			{
				return this.Instance.TidTextContent;
			}
		}

		// Token: 0x170041C0 RID: 16832
		// (get) Token: 0x0600DD31 RID: 56625 RVA: 0x0020DEA7 File Offset: 0x0020C0A7
		public virtual string EdTidTextContent
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04007ADB RID: 31451
		private ICustomScreenTextSetting Instance;
	}
}
