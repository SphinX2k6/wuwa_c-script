using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200297A RID: 10618
	public class IFaceExpressionTextureConfig : IFaceExpressionConfig
	{
		// Token: 0x0600EB43 RID: 60227 RVA: 0x00226B77 File Offset: 0x00224D77
		[NullableContext(1)]
		public static IFaceExpressionTextureConfig Create(IFaceExpressionTextureConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFaceExpressionTextureConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A11 RID: 18961
		// (get) Token: 0x0600EB44 RID: 60228 RVA: 0x00226B96 File Offset: 0x00224D96
		public override EFaceExpressionConfigType Type
		{
			get
			{
				return (EFaceExpressionConfigType)this.Instance.Type;
			}
		}

		// Token: 0x17004A12 RID: 18962
		// (get) Token: 0x0600EB45 RID: 60229 RVA: 0x00226BA3 File Offset: 0x00224DA3
		public virtual int FaceIndex
		{
			get
			{
				return this.Instance.FaceIndex;
			}
		}

		// Token: 0x04008192 RID: 33170
		private IFaceExpressionTextureConfig Instance;
	}
}
