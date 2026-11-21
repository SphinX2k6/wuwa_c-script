using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B3D RID: 2877
	public class IInteractPlayerDiractionToLeisure : IInteractPlayerDiractionType
	{
		// Token: 0x060041CC RID: 16844 RVA: 0x000A77E1 File Offset: 0x000A59E1
		public static IInteractPlayerDiractionToLeisure Create(IInteractPlayerDiractionToLeisure? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractPlayerDiractionToLeisure
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000F4D RID: 3917
		// (get) Token: 0x060041CD RID: 16845 RVA: 0x000A7800 File Offset: 0x000A5A00
		public override EInteractPlayerDiractionType Type
		{
			get
			{
				return (EInteractPlayerDiractionType)this.Instance.Type;
			}
		}

		// Token: 0x17000F4E RID: 3918
		// (get) Token: 0x060041CE RID: 16846 RVA: 0x000A780D File Offset: 0x000A5A0D
		public virtual int Begin
		{
			get
			{
				return this.Instance.Begin;
			}
		}

		// Token: 0x17000F4F RID: 3919
		// (get) Token: 0x060041CF RID: 16847 RVA: 0x000A781A File Offset: 0x000A5A1A
		public virtual int End
		{
			get
			{
				return this.Instance.End;
			}
		}

		// Token: 0x04002470 RID: 9328
		private IInteractPlayerDiractionToLeisure Instance;
	}
}
