using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BA7 RID: 11175
	public class IEnterOrbitalCameraControlByMove : IEnterOrbitalCameraType
	{
		// Token: 0x0600F644 RID: 63044 RVA: 0x0023E07E File Offset: 0x0023C27E
		public static IEnterOrbitalCameraControlByMove Create(IEnterOrbitalCameraControlByMove? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnterOrbitalCameraControlByMove
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004BA4 RID: 19364
		// (get) Token: 0x0600F645 RID: 63045 RVA: 0x0023E09D File Offset: 0x0023C29D
		public override EEnterOrbitalCameraType Type
		{
			get
			{
				return (EEnterOrbitalCameraType)this.Instance.Type;
			}
		}

		// Token: 0x17004BA5 RID: 19365
		// (get) Token: 0x0600F646 RID: 63046 RVA: 0x0023E0AA File Offset: 0x0023C2AA
		public virtual string LevelSequence
		{
			get
			{
				return this.Instance.LevelSequence;
			}
		}

		// Token: 0x17004BA6 RID: 19366
		// (get) Token: 0x0600F647 RID: 63047 RVA: 0x0023E0B7 File Offset: 0x0023C2B7
		public virtual float BlendInTime
		{
			get
			{
				return this.Instance.BlendInTime;
			}
		}

		// Token: 0x17004BA7 RID: 19367
		// (get) Token: 0x0600F648 RID: 63048 RVA: 0x0023E0C4 File Offset: 0x0023C2C4
		public virtual float BlendOutTime
		{
			get
			{
				return this.Instance.BlendOutTime;
			}
		}

		// Token: 0x17004BA8 RID: 19368
		// (get) Token: 0x0600F649 RID: 63049 RVA: 0x0023E0D1 File Offset: 0x0023C2D1
		public virtual int BegEntity
		{
			get
			{
				return this.Instance.BegEntity;
			}
		}

		// Token: 0x17004BA9 RID: 19369
		// (get) Token: 0x0600F64A RID: 63050 RVA: 0x0023E0DE File Offset: 0x0023C2DE
		public virtual int EndEntity
		{
			get
			{
				return this.Instance.EndEntity;
			}
		}

		// Token: 0x0400870B RID: 34571
		private IEnterOrbitalCameraControlByMove Instance;
	}
}
