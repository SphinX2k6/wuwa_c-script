using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002526 RID: 9510
	public class IActorFaceExpressionPlay : IActorFaceExpressionType
	{
		// Token: 0x0600D40F RID: 54287 RVA: 0x001F67F3 File Offset: 0x001F49F3
		[NullableContext(1)]
		public static IActorFaceExpressionPlay Create(IActorFaceExpressionPlay? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorFaceExpressionPlay
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B85 RID: 15237
		// (get) Token: 0x0600D410 RID: 54288 RVA: 0x001F6812 File Offset: 0x001F4A12
		public override EActorFaceExpressionType Type
		{
			get
			{
				return (EActorFaceExpressionType)this.Instance.Type;
			}
		}

		// Token: 0x17003B86 RID: 15238
		// (get) Token: 0x0600D411 RID: 54289 RVA: 0x001F681F File Offset: 0x001F4A1F
		public virtual int FaceExpressionId
		{
			get
			{
				return this.Instance.FaceExpressionId;
			}
		}

		// Token: 0x17003B87 RID: 15239
		// (get) Token: 0x0600D412 RID: 54290 RVA: 0x001F682C File Offset: 0x001F4A2C
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

		// Token: 0x0400742C RID: 29740
		private IActorFaceExpressionPlay Instance;
	}
}
