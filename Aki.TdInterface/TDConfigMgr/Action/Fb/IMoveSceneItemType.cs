using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AF7 RID: 10999
	public class IMoveSceneItemType
	{
		// Token: 0x0600F210 RID: 61968 RVA: 0x00236077 File Offset: 0x00234277
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

		// Token: 0x170048D0 RID: 18640
		// (get) Token: 0x0600F211 RID: 61969 RVA: 0x00236096 File Offset: 0x00234296
		public virtual EMoveSceneItemType Type
		{
			get
			{
				return (EMoveSceneItemType)this.Instance.Type;
			}
		}

		// Token: 0x040084DD RID: 34013
		private IMoveSceneItemType Instance;
	}
}
