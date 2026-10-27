using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200137C RID: 4988
	public class INewHandInItemsBase
	{
		// Token: 0x06007227 RID: 29223 RVA: 0x00112CDE File Offset: 0x00110EDE
		[NullableContext(1)]
		public static INewHandInItemsBase Create(INewHandInItemsBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INewHandInItemsBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002502 RID: 9474
		// (get) Token: 0x06007228 RID: 29224 RVA: 0x00112CFD File Offset: 0x00110EFD
		public virtual ENewHandInItemsType Type
		{
			get
			{
				return (ENewHandInItemsType)this.Instance.Type;
			}
		}

		// Token: 0x04004200 RID: 16896
		private INewHandInItemsBase Instance;
	}
}
