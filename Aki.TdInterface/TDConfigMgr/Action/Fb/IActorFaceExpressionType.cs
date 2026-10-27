using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002525 RID: 9509
	public class IActorFaceExpressionType
	{
		// Token: 0x0600D40C RID: 54284 RVA: 0x001F67BF File Offset: 0x001F49BF
		[NullableContext(1)]
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

		// Token: 0x17003B84 RID: 15236
		// (get) Token: 0x0600D40D RID: 54285 RVA: 0x001F67DE File Offset: 0x001F49DE
		public virtual EActorFaceExpressionType Type
		{
			get
			{
				return (EActorFaceExpressionType)this.Instance.Type;
			}
		}

		// Token: 0x0400742B RID: 29739
		private IActorFaceExpressionType Instance;
	}
}
