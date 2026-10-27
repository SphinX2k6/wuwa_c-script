using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002527 RID: 9511
	public class IActorFaceExpressionStop : IActorFaceExpressionType
	{
		// Token: 0x0600D414 RID: 54292 RVA: 0x001F686A File Offset: 0x001F4A6A
		[NullableContext(1)]
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

		// Token: 0x17003B88 RID: 15240
		// (get) Token: 0x0600D415 RID: 54293 RVA: 0x001F6889 File Offset: 0x001F4A89
		public override EActorFaceExpressionType Type
		{
			get
			{
				return (EActorFaceExpressionType)this.Instance.Type;
			}
		}

		// Token: 0x17003B89 RID: 15241
		// (get) Token: 0x0600D416 RID: 54294 RVA: 0x001F6898 File Offset: 0x001F4A98
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

		// Token: 0x0400742D RID: 29741
		private IActorFaceExpressionStop Instance;
	}
}
