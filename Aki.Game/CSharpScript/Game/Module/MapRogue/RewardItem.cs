using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02005603 RID: 22019
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RewardItem : GridProxyAbstract<ChangeItemInfoData>
	{
		// Token: 0x060380BD RID: 229565 RVA: 0x00D46004 File Offset: 0x00D44204
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText))
			};
		}

		// Token: 0x060380BE RID: 229566 RVA: 0x00D4605E File Offset: 0x00D4425E
		public override void Refresh(ChangeItemInfoData data, bool isSelected, int gridIndex)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.TitleId, Array.Empty<object>());
			base.GetText(2).SetText(data.Value, true);
		}
	}
}
