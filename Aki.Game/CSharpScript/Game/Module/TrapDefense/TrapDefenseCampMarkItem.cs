using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A37 RID: 18999
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseCampMarkItem : TrapDefenseMarkItem
	{
		// Token: 0x06031545 RID: 202053 RVA: 0x00B712DF File Offset: 0x00B6F4DF
		[NullableContext(2)]
		public TrapDefenseCampMarkItem(int markId, object extraParam = null) : base(markId, extraParam)
		{
		}

		// Token: 0x06031546 RID: 202054 RVA: 0x00B712E9 File Offset: 0x00B6F4E9
		protected override void OnInitialize()
		{
			this.EnableCachePosition = true;
		}

		// Token: 0x17007A39 RID: 31289
		// (get) Token: 0x06031547 RID: 202055 RVA: 0x00B712F2 File Offset: 0x00B6F4F2
		public override TrapDefenseDefine.ETrapDefenseMarkType MarkType
		{
			get
			{
				return TrapDefenseDefine.ETrapDefenseMarkType.Camp;
			}
		}

		// Token: 0x17007A3A RID: 31290
		// (get) Token: 0x06031548 RID: 202056 RVA: 0x00B712F5 File Offset: 0x00B6F4F5
		public override Vector WorldPosition
		{
			get
			{
				return TrapDefenseModel.Instance.MapData.CampPosition;
			}
		}
	}
}
