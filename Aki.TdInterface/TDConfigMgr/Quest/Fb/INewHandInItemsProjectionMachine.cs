using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200137D RID: 4989
	public class INewHandInItemsProjectionMachine : INewHandInItemsBase
	{
		// Token: 0x0600722A RID: 29226 RVA: 0x00112D12 File Offset: 0x00110F12
		[NullableContext(1)]
		public static INewHandInItemsProjectionMachine Create(INewHandInItemsProjectionMachine? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INewHandInItemsProjectionMachine
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002503 RID: 9475
		// (get) Token: 0x0600722B RID: 29227 RVA: 0x00112D31 File Offset: 0x00110F31
		public override ENewHandInItemsType Type
		{
			get
			{
				return (ENewHandInItemsType)this.Instance.Type;
			}
		}

		// Token: 0x17002504 RID: 9476
		// (get) Token: 0x0600722C RID: 29228 RVA: 0x00112D3E File Offset: 0x00110F3E
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17002505 RID: 9477
		// (get) Token: 0x0600722D RID: 29229 RVA: 0x00112D4B File Offset: 0x00110F4B
		public virtual int ItemId
		{
			get
			{
				return this.Instance.ItemId;
			}
		}

		// Token: 0x04004201 RID: 16897
		private INewHandInItemsProjectionMachine Instance;
	}
}
