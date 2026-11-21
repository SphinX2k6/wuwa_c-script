using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C62 RID: 11362
	public class IFaceExpressionTextureMultiSlotConfig : IFaceExpressionConfig
	{
		// Token: 0x0600F9C6 RID: 63942 RVA: 0x00244351 File Offset: 0x00242551
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

		// Token: 0x17004DB0 RID: 19888
		// (get) Token: 0x0600F9C7 RID: 63943 RVA: 0x00244370 File Offset: 0x00242570
		public override EFaceExpressionConfigType Type
		{
			get
			{
				return (EFaceExpressionConfigType)this.Instance.Type;
			}
		}

		// Token: 0x17004DB1 RID: 19889
		// (get) Token: 0x0600F9C8 RID: 63944 RVA: 0x0024437D File Offset: 0x0024257D
		public virtual int SlotIndex
		{
			get
			{
				return this.Instance.SlotIndex;
			}
		}

		// Token: 0x17004DB2 RID: 19890
		// (get) Token: 0x0600F9C9 RID: 63945 RVA: 0x0024438A File Offset: 0x0024258A
		public virtual int FaceIndex
		{
			get
			{
				return this.Instance.FaceIndex;
			}
		}

		// Token: 0x04008878 RID: 34936
		private IFaceExpressionTextureMultiSlotConfig Instance;
	}
}
