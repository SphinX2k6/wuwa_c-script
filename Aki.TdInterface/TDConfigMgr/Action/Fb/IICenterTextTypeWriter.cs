using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026CF RID: 9935
	public class IICenterTextTypeWriter : ICenterTextShowType
	{
		// Token: 0x0600DE19 RID: 56857 RVA: 0x0020F61C File Offset: 0x0020D81C
		[NullableContext(1)]
		public static IICenterTextTypeWriter Create(IICenterTextTypeWriter? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IICenterTextTypeWriter
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700423D RID: 16957
		// (get) Token: 0x0600DE1A RID: 56858 RVA: 0x0020F63B File Offset: 0x0020D83B
		public override ECenterTextShowAnim Type
		{
			get
			{
				return (ECenterTextShowAnim)this.Instance.Type;
			}
		}

		// Token: 0x1700423E RID: 16958
		// (get) Token: 0x0600DE1B RID: 56859 RVA: 0x0020F648 File Offset: 0x0020D848
		public virtual int TextCountPerSecond
		{
			get
			{
				return this.Instance.TextCountPerSecond;
			}
		}

		// Token: 0x04007B4D RID: 31565
		private IICenterTextTypeWriter Instance;
	}
}
