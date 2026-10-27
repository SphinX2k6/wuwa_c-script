using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A73 RID: 2675
	public class IInteractPlayerDiractionToLeisure : IInteractPlayerDiractionType
	{
		// Token: 0x06003DA3 RID: 15779 RVA: 0x0009E229 File Offset: 0x0009C429
		[NullableContext(1)]
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

		// Token: 0x17000E7A RID: 3706
		// (get) Token: 0x06003DA4 RID: 15780 RVA: 0x0009E248 File Offset: 0x0009C448
		public override EInteractPlayerDiractionType Type
		{
			get
			{
				return (EInteractPlayerDiractionType)this.Instance.Type;
			}
		}

		// Token: 0x17000E7B RID: 3707
		// (get) Token: 0x06003DA5 RID: 15781 RVA: 0x0009E255 File Offset: 0x0009C455
		public virtual int Begin
		{
			get
			{
				return this.Instance.Begin;
			}
		}

		// Token: 0x17000E7C RID: 3708
		// (get) Token: 0x06003DA6 RID: 15782 RVA: 0x0009E262 File Offset: 0x0009C462
		public virtual int End
		{
			get
			{
				return this.Instance.End;
			}
		}

		// Token: 0x04002254 RID: 8788
		private IInteractPlayerDiractionToLeisure Instance;
	}
}
