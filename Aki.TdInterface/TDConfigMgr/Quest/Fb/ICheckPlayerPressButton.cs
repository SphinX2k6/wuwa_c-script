using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013C6 RID: 5062
	public class ICheckPlayerPressButton : ICheckPlayerInputBase
	{
		// Token: 0x0600739A RID: 29594 RVA: 0x001155D1 File Offset: 0x001137D1
		[NullableContext(1)]
		public static ICheckPlayerPressButton Create(ICheckPlayerPressButton? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICheckPlayerPressButton
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170025E1 RID: 9697
		// (get) Token: 0x0600739B RID: 29595 RVA: 0x001155F0 File Offset: 0x001137F0
		public override ECheckPlayerInputType Type
		{
			get
			{
				return (ECheckPlayerInputType)this.Instance.Type;
			}
		}

		// Token: 0x170025E2 RID: 9698
		// (get) Token: 0x0600739C RID: 29596 RVA: 0x001155FD File Offset: 0x001137FD
		public virtual EPlayerButtonType ButtonType
		{
			get
			{
				return (EPlayerButtonType)this.Instance.ButtonType;
			}
		}

		// Token: 0x040042EC RID: 17132
		private ICheckPlayerPressButton Instance;
	}
}
