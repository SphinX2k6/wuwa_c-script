using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039E3 RID: 14819
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefensePlayerMarkItem : TrapDefenseMarkItem
	{
		// Token: 0x060262F3 RID: 156403 RVA: 0x00AB54CF File Offset: 0x00AB36CF
		[NullableContext(2)]
		public TrapDefensePlayerMarkItem(int markId, object extraParam = null) : base(markId, extraParam)
		{
		}

		// Token: 0x060262F4 RID: 156404 RVA: 0x00AB54D9 File Offset: 0x00AB36D9
		protected override void OnInitialize()
		{
		}

		// Token: 0x17004DF5 RID: 19957
		// (get) Token: 0x060262F5 RID: 156405 RVA: 0x00AB54DB File Offset: 0x00AB36DB
		public override TrapDefenseDefine.ETrapDefenseMarkType MarkType
		{
			get
			{
				return TrapDefenseDefine.ETrapDefenseMarkType.Player;
			}
		}

		// Token: 0x17004DF6 RID: 19958
		// (get) Token: 0x060262F6 RID: 156406 RVA: 0x00AB54DE File Offset: 0x00AB36DE
		public override Vector WorldPosition
		{
			get
			{
				return GeneralLogicTreeUtil.Instance.GetPlayerLocation() ?? Vector.ZeroVectorProxy;
			}
		}
	}
}
