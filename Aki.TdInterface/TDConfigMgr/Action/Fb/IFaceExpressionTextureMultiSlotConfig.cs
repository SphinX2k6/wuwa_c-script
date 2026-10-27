using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200297C RID: 10620
	public class IFaceExpressionTextureMultiSlotConfig : IFaceExpressionConfig
	{
		// Token: 0x0600EB4B RID: 60235 RVA: 0x00226BF9 File Offset: 0x00224DF9
		[NullableContext(1)]
		public static IFaceExpressionTextureMultiSlotConfig Create(IFaceExpressionTextureMultiSlotConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFaceExpressionTextureMultiSlotConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A15 RID: 18965
		// (get) Token: 0x0600EB4C RID: 60236 RVA: 0x00226C18 File Offset: 0x00224E18
		public override EFaceExpressionConfigType Type
		{
			get
			{
				return (EFaceExpressionConfigType)this.Instance.Type;
			}
		}

		// Token: 0x17004A16 RID: 18966
		// (get) Token: 0x0600EB4D RID: 60237 RVA: 0x00226C25 File Offset: 0x00224E25
		public virtual int SlotIndex
		{
			get
			{
				return this.Instance.SlotIndex;
			}
		}

		// Token: 0x17004A17 RID: 18967
		// (get) Token: 0x0600EB4E RID: 60238 RVA: 0x00226C32 File Offset: 0x00224E32
		public virtual int FaceIndex
		{
			get
			{
				return this.Instance.FaceIndex;
			}
		}

		// Token: 0x04008194 RID: 33172
		private IFaceExpressionTextureMultiSlotConfig Instance;
	}
}
