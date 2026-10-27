using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028D2 RID: 10450
	[NullableContext(1)]
	[Nullable(0)]
	public class IEnterOrbitalCameraControlByMove : IEnterOrbitalCameraType
	{
		// Token: 0x0600E815 RID: 59413 RVA: 0x002210FE File Offset: 0x0021F2FE
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

		// Token: 0x17004833 RID: 18483
		// (get) Token: 0x0600E816 RID: 59414 RVA: 0x0022111D File Offset: 0x0021F31D
		public override EEnterOrbitalCameraType Type
		{
			get
			{
				return (EEnterOrbitalCameraType)this.Instance.Type;
			}
		}

		// Token: 0x17004834 RID: 18484
		// (get) Token: 0x0600E817 RID: 59415 RVA: 0x0022112A File Offset: 0x0021F32A
		public virtual string LevelSequence
		{
			get
			{
				return this.Instance.LevelSequence;
			}
		}

		// Token: 0x17004835 RID: 18485
		// (get) Token: 0x0600E818 RID: 59416 RVA: 0x00221137 File Offset: 0x0021F337
		public virtual float BlendInTime
		{
			get
			{
				return this.Instance.BlendInTime;
			}
		}

		// Token: 0x17004836 RID: 18486
		// (get) Token: 0x0600E819 RID: 59417 RVA: 0x00221144 File Offset: 0x0021F344
		public virtual float BlendOutTime
		{
			get
			{
				return this.Instance.BlendOutTime;
			}
		}

		// Token: 0x17004837 RID: 18487
		// (get) Token: 0x0600E81A RID: 59418 RVA: 0x00221151 File Offset: 0x0021F351
		public virtual int BegEntity
		{
			get
			{
				return this.Instance.BegEntity;
			}
		}

		// Token: 0x17004838 RID: 18488
		// (get) Token: 0x0600E81B RID: 59419 RVA: 0x0022115E File Offset: 0x0021F35E
		public virtual int EndEntity
		{
			get
			{
				return this.Instance.EndEntity;
			}
		}

		// Token: 0x0400804C RID: 32844
		private IEnterOrbitalCameraControlByMove Instance;
	}
}
