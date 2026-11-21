using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B01 RID: 11009
	public class ILiftMoveType
	{
		// Token: 0x0600F240 RID: 62016 RVA: 0x002365C6 File Offset: 0x002347C6
		public static ILiftMoveType Create(ILiftMoveType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiftMoveType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170048EC RID: 18668
		// (get) Token: 0x0600F241 RID: 62017 RVA: 0x002365E5 File Offset: 0x002347E5
		public virtual ELiftMoveType Type
		{
			get
			{
				return (ELiftMoveType)this.Instance.Type;
			}
		}

		// Token: 0x040084F9 RID: 34041
		private ILiftMoveType Instance;
	}
}
