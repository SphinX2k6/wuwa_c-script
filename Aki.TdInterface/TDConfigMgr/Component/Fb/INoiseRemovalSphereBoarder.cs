using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E4A RID: 3658
	public class INoiseRemovalSphereBoarder : INoiseRemovalBoarderBase
	{
		// Token: 0x0600529A RID: 21146 RVA: 0x000CB437 File Offset: 0x000C9637
		[NullableContext(1)]
		public static INoiseRemovalSphereBoarder Create(INoiseRemovalSphereBoarder? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INoiseRemovalSphereBoarder
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001BC3 RID: 7107
		// (get) Token: 0x0600529B RID: 21147 RVA: 0x000CB456 File Offset: 0x000C9656
		public override ENoiseRemovalBoarderShape Type
		{
			get
			{
				return (ENoiseRemovalBoarderShape)this.Instance.Type;
			}
		}

		// Token: 0x17001BC4 RID: 7108
		// (get) Token: 0x0600529C RID: 21148 RVA: 0x000CB463 File Offset: 0x000C9663
		public virtual float Radius
		{
			get
			{
				return this.Instance.Radius;
			}
		}

		// Token: 0x04002F9D RID: 12189
		private INoiseRemovalSphereBoarder Instance;
	}
}
