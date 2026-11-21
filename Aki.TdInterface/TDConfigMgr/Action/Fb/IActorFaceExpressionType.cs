using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027CC RID: 10188
	public class IActorFaceExpressionType
	{
		// Token: 0x0600E16C RID: 57708 RVA: 0x0021221F File Offset: 0x0021041F
		public static IActorFaceExpressionType Create(IActorFaceExpressionType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorFaceExpressionType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E82 RID: 16002
		// (get) Token: 0x0600E16D RID: 57709 RVA: 0x0021223E File Offset: 0x0021043E
		public virtual EActorFaceExpressionType Type
		{
			get
			{
				return (EActorFaceExpressionType)this.Instance.Type;
			}
		}

		// Token: 0x04007A80 RID: 31360
		private IActorFaceExpressionType Instance;
	}
}
