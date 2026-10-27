using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027D6 RID: 10198
	[NullableContext(2)]
	[Nullable(0)]
	public class IBounce : ILeisureInteractType
	{
		// Token: 0x0600E2AA RID: 58026 RVA: 0x002175AE File Offset: 0x002157AE
		[NullableContext(1)]
		public static IBounce Create(IBounce? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBounce
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044C0 RID: 17600
		// (get) Token: 0x0600E2AB RID: 58027 RVA: 0x002175CD File Offset: 0x002157CD
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x170044C1 RID: 17601
		// (get) Token: 0x0600E2AC RID: 58028 RVA: 0x002175DA File Offset: 0x002157DA
		public virtual int Height
		{
			get
			{
				return this.Instance.Height;
			}
		}

		// Token: 0x170044C2 RID: 17602
		// (get) Token: 0x0600E2AD RID: 58029 RVA: 0x002175E8 File Offset: 0x002157E8
		public virtual float? Time
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.Time);
			}
		}

		// Token: 0x170044C3 RID: 17603
		// (get) Token: 0x0600E2AE RID: 58030 RVA: 0x0021761E File Offset: 0x0021581E
		public virtual string MotionCurve
		{
			get
			{
				return this.Instance.MotionCurve;
			}
		}

		// Token: 0x04007DA8 RID: 32168
		private IBounce Instance;
	}
}
