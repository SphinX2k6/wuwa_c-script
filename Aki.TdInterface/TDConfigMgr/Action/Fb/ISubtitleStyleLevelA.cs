using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025C5 RID: 9669
	public class ISubtitleStyleLevelA : ISubtitleStyleBase
	{
		// Token: 0x0600D965 RID: 55653 RVA: 0x00206CA0 File Offset: 0x00204EA0
		[NullableContext(1)]
		public static ISubtitleStyleLevelA Create(ISubtitleStyleLevelA? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISubtitleStyleLevelA
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003F9D RID: 16285
		// (get) Token: 0x0600D966 RID: 55654 RVA: 0x00206CBF File Offset: 0x00204EBF
		public override ESubtitleStyle Type
		{
			get
			{
				return (ESubtitleStyle)this.Instance.Type;
			}
		}

		// Token: 0x040078BD RID: 30909
		private ISubtitleStyleLevelA Instance;
	}
}
