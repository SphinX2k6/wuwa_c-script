using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025C6 RID: 9670
	public class ISubtitleStyleNewLevelB : ISubtitleStyleBase
	{
		// Token: 0x0600D968 RID: 55656 RVA: 0x00206CD4 File Offset: 0x00204ED4
		[NullableContext(1)]
		public static ISubtitleStyleNewLevelB Create(ISubtitleStyleNewLevelB? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISubtitleStyleNewLevelB
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003F9E RID: 16286
		// (get) Token: 0x0600D969 RID: 55657 RVA: 0x00206CF3 File Offset: 0x00204EF3
		public override ESubtitleStyle Type
		{
			get
			{
				return (ESubtitleStyle)this.Instance.Type;
			}
		}

		// Token: 0x040078BE RID: 30910
		private ISubtitleStyleNewLevelB Instance;
	}
}
