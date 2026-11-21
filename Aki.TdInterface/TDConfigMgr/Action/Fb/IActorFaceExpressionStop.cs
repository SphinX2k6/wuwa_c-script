using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027CE RID: 10190
	public class IActorFaceExpressionStop : IActorFaceExpressionType
	{
		// Token: 0x0600E174 RID: 57716 RVA: 0x002122CA File Offset: 0x002104CA
		public static IActorFaceExpressionStop Create(IActorFaceExpressionStop? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorFaceExpressionStop
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E86 RID: 16006
		// (get) Token: 0x0600E175 RID: 57717 RVA: 0x002122E9 File Offset: 0x002104E9
		public override EActorFaceExpressionType Type
		{
			get
			{
				return (EActorFaceExpressionType)this.Instance.Type;
			}
		}

		// Token: 0x17003E87 RID: 16007
		// (get) Token: 0x0600E176 RID: 57718 RVA: 0x002122F8 File Offset: 0x002104F8
		public virtual float? DelayTime
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.DelayTime);
			}
		}

		// Token: 0x04007A82 RID: 31362
		private IActorFaceExpressionStop Instance;
	}
}
