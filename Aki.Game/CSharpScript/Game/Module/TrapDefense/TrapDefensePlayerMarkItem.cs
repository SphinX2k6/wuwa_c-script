using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A3B RID: 19003
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefensePlayerMarkItem : TrapDefenseMarkItem
	{
		// Token: 0x06031563 RID: 202083 RVA: 0x00B71555 File Offset: 0x00B6F755
		[NullableContext(2)]
		public TrapDefensePlayerMarkItem(int markId, object extraParam = null) : base(markId, extraParam)
		{
		}

		// Token: 0x06031564 RID: 202084 RVA: 0x00B7155F File Offset: 0x00B6F75F
		protected override void OnInitialize()
		{
		}

		// Token: 0x17007A48 RID: 31304
		// (get) Token: 0x06031565 RID: 202085 RVA: 0x00B71561 File Offset: 0x00B6F761
		public override TrapDefenseDefine.ETrapDefenseMarkType MarkType
		{
			get
			{
				return TrapDefenseDefine.ETrapDefenseMarkType.Player;
			}
		}

		// Token: 0x17007A49 RID: 31305
		// (get) Token: 0x06031566 RID: 202086 RVA: 0x00B71564 File Offset: 0x00B6F764
		public override Vector WorldPosition
		{
			get
			{
				return GeneralLogicTreeUtil.Instance.GetPlayerLocation() ?? Vector.ZeroVectorProxy;
			}
		}
	}
}
