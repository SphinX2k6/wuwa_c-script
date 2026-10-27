using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A92 RID: 2706
	[NullableContext(1)]
	[Nullable(0)]
	public class IStateRepPerfMontagePath : IStateRepPerfBase
	{
		// Token: 0x06003E3E RID: 15934 RVA: 0x0009F603 File Offset: 0x0009D803
		public static IStateRepPerfMontagePath Create(IStateRepPerfMontagePath? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStateRepPerfMontagePath
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000ED7 RID: 3799
		// (get) Token: 0x06003E3F RID: 15935 RVA: 0x0009F622 File Offset: 0x0009D822
		public override EStateRepPerfType Type
		{
			get
			{
				return (EStateRepPerfType)this.Instance.Type;
			}
		}

		// Token: 0x17000ED8 RID: 3800
		// (get) Token: 0x06003E40 RID: 15936 RVA: 0x0009F62F File Offset: 0x0009D82F
		public virtual string MontagePath
		{
			get
			{
				return this.Instance.MontagePath;
			}
		}

		// Token: 0x17000ED9 RID: 3801
		// (get) Token: 0x06003E41 RID: 15937 RVA: 0x0009F63C File Offset: 0x0009D83C
		public virtual string MontageName
		{
			get
			{
				return this.Instance.MontageName;
			}
		}

		// Token: 0x040022AB RID: 8875
		private IStateRepPerfMontagePath Instance;
	}
}
