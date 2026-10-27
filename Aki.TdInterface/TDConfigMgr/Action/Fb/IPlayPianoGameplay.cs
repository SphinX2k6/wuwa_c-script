using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200286F RID: 10351
	public class IPlayPianoGameplay : IUiGame
	{
		// Token: 0x0600E55E RID: 58718 RVA: 0x0021B9E8 File Offset: 0x00219BE8
		[NullableContext(1)]
		public static IPlayPianoGameplay Create(IPlayPianoGameplay? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayPianoGameplay
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004642 RID: 17986
		// (get) Token: 0x0600E55F RID: 58719 RVA: 0x0021BA07 File Offset: 0x00219C07
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x17004643 RID: 17987
		// (get) Token: 0x0600E560 RID: 58720 RVA: 0x0021BA14 File Offset: 0x00219C14
		public virtual int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x17004644 RID: 17988
		// (get) Token: 0x0600E561 RID: 58721 RVA: 0x0021BA21 File Offset: 0x00219C21
		public virtual int RangeEntityId
		{
			get
			{
				return this.Instance.RangeEntityId;
			}
		}

		// Token: 0x04007ED5 RID: 32469
		private IPlayPianoGameplay Instance;
	}
}
