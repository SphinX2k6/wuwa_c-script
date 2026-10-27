using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002824 RID: 10276
	public class IMoveSceneItemType
	{
		// Token: 0x0600E3EB RID: 58347 RVA: 0x00219213 File Offset: 0x00217413
		[NullableContext(1)]
		public static IMoveSceneItemType Create(IMoveSceneItemType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMoveSceneItemType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004565 RID: 17765
		// (get) Token: 0x0600E3EC RID: 58348 RVA: 0x00219232 File Offset: 0x00217432
		public virtual EMoveSceneItemType Type
		{
			get
			{
				return (EMoveSceneItemType)this.Instance.Type;
			}
		}

		// Token: 0x04007E20 RID: 32288
		private IMoveSceneItemType Instance;
	}
}
