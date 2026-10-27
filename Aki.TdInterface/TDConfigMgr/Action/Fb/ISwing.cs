using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027F2 RID: 10226
	[NullableContext(1)]
	[Nullable(0)]
	public class ISwing : ILeisureInteractType
	{
		// Token: 0x0600E31C RID: 58140 RVA: 0x00218017 File Offset: 0x00216217
		public static ISwing Create(ISwing? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISwing
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044FA RID: 17658
		// (get) Token: 0x0600E31D RID: 58141 RVA: 0x00218036 File Offset: 0x00216236
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x170044FB RID: 17659
		// (get) Token: 0x0600E31E RID: 58142 RVA: 0x00218043 File Offset: 0x00216243
		public virtual string SwingDa
		{
			get
			{
				return this.Instance.SwingDa;
			}
		}

		// Token: 0x170044FC RID: 17660
		// (get) Token: 0x0600E31F RID: 58143 RVA: 0x00218050 File Offset: 0x00216250
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x04007DD6 RID: 32214
		private ISwing Instance;
	}
}
