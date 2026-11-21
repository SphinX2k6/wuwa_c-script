using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039DF RID: 14815
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseCampMarkItem : TrapDefenseMarkItem
	{
		// Token: 0x060262D5 RID: 156373 RVA: 0x00AB5253 File Offset: 0x00AB3453
		[NullableContext(2)]
		public TrapDefenseCampMarkItem(int markId, object extraParam = null) : base(markId, extraParam)
		{
		}

		// Token: 0x060262D6 RID: 156374 RVA: 0x00AB525D File Offset: 0x00AB345D
		protected override void OnInitialize()
		{
			this.EnableCachePosition = true;
		}

		// Token: 0x17004DE6 RID: 19942
		// (get) Token: 0x060262D7 RID: 156375 RVA: 0x00AB5266 File Offset: 0x00AB3466
		public override TrapDefenseDefine.ETrapDefenseMarkType MarkType
		{
			get
			{
				return TrapDefenseDefine.ETrapDefenseMarkType.Camp;
			}
		}

		// Token: 0x17004DE7 RID: 19943
		// (get) Token: 0x060262D8 RID: 156376 RVA: 0x00AB5269 File Offset: 0x00AB3469
		public override Vector WorldPosition
		{
			get
			{
				return TrapDefenseModel.Instance.MapData.CampPosition;
			}
		}
	}
}
