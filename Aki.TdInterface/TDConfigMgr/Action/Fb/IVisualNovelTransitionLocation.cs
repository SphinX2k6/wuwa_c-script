using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002584 RID: 9604
	public class IVisualNovelTransitionLocation : IVisualNovelTransitionConfigBase
	{
		// Token: 0x0600D790 RID: 55184 RVA: 0x00201AB2 File Offset: 0x001FFCB2
		[NullableContext(1)]
		public static IVisualNovelTransitionLocation Create(IVisualNovelTransitionLocation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelTransitionLocation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E4A RID: 15946
		// (get) Token: 0x0600D791 RID: 55185 RVA: 0x00201AD1 File Offset: 0x001FFCD1
		public override EVisualNovelTransitionType Type
		{
			get
			{
				return (EVisualNovelTransitionType)this.Instance.Type;
			}
		}

		// Token: 0x17003E4B RID: 15947
		// (get) Token: 0x0600D792 RID: 55186 RVA: 0x00201ADE File Offset: 0x001FFCDE
		public virtual int LocationId
		{
			get
			{
				return this.Instance.LocationId;
			}
		}

		// Token: 0x17003E4C RID: 15948
		// (get) Token: 0x0600D793 RID: 55187 RVA: 0x00201AEC File Offset: 0x001FFCEC
		public virtual int? TransitionBackgroundId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.TransitionBackgroundId);
			}
		}

		// Token: 0x04007748 RID: 30536
		private IVisualNovelTransitionLocation Instance;
	}
}
