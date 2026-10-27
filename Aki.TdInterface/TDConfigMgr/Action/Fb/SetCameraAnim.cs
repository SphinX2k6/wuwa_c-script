using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027B8 RID: 10168
	[NullableContext(1)]
	[Nullable(0)]
	public class SetCameraAnim : ActionParams
	{
		// Token: 0x0600E23A RID: 57914 RVA: 0x00216C12 File Offset: 0x00214E12
		public static SetCameraAnim Create(ISetCameraAnim? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetCameraAnim
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700448C RID: 17548
		// (get) Token: 0x0600E23B RID: 57915 RVA: 0x00216C31 File Offset: 0x00214E31
		public virtual string CameraAnimDataAsset
		{
			get
			{
				return this.Instance.CameraAnimDataAsset;
			}
		}

		// Token: 0x1700448D RID: 17549
		// (get) Token: 0x0600E23C RID: 57916 RVA: 0x00216C3E File Offset: 0x00214E3E
		public virtual float Speed
		{
			get
			{
				return this.Instance.Speed;
			}
		}

		// Token: 0x1700448E RID: 17550
		// (get) Token: 0x0600E23D RID: 57917 RVA: 0x00216C4C File Offset: 0x00214E4C
		public virtual bool? UseNoise
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.UseNoise);
			}
		}

		// Token: 0x04007D78 RID: 32120
		private ISetCameraAnim Instance;
	}
}
