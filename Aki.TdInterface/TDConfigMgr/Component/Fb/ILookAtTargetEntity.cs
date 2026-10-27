using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DC2 RID: 3522
	public class ILookAtTargetEntity : ILookAtTargetBase
	{
		// Token: 0x06004FEB RID: 20459 RVA: 0x000C5A73 File Offset: 0x000C3C73
		[NullableContext(1)]
		public static ILookAtTargetEntity Create(ILookAtTargetEntity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILookAtTargetEntity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A24 RID: 6692
		// (get) Token: 0x06004FEC RID: 20460 RVA: 0x000C5A92 File Offset: 0x000C3C92
		public override ELookAtTargetType Type
		{
			get
			{
				return (ELookAtTargetType)this.Instance.Type;
			}
		}

		// Token: 0x17001A25 RID: 6693
		// (get) Token: 0x06004FED RID: 20461 RVA: 0x000C5A9F File Offset: 0x000C3C9F
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x04002DD5 RID: 11733
		private ILookAtTargetEntity Instance;
	}
}
