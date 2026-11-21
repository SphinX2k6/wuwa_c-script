using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027CD RID: 10189
	public class IActorFaceExpressionPlay : IActorFaceExpressionType
	{
		// Token: 0x0600E16F RID: 57711 RVA: 0x00212253 File Offset: 0x00210453
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

		// Token: 0x17003E83 RID: 16003
		// (get) Token: 0x0600E170 RID: 57712 RVA: 0x00212272 File Offset: 0x00210472
		public override EActorFaceExpressionType Type
		{
			get
			{
				return (EActorFaceExpressionType)this.Instance.Type;
			}
		}

		// Token: 0x17003E84 RID: 16004
		// (get) Token: 0x0600E171 RID: 57713 RVA: 0x0021227F File Offset: 0x0021047F
		public virtual int FaceExpressionId
		{
			get
			{
				return this.Instance.FaceExpressionId;
			}
		}

		// Token: 0x17003E85 RID: 16005
		// (get) Token: 0x0600E172 RID: 57714 RVA: 0x0021228C File Offset: 0x0021048C
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

		// Token: 0x04007A81 RID: 31361
		private IActorFaceExpressionPlay Instance;
	}
}
