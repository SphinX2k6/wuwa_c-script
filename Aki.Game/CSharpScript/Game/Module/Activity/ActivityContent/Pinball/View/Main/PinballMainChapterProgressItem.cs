using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Main
{
	// Token: 0x020052B0 RID: 21168
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PinballMainChapterProgressItem : GridProxyAbstract<PinballLevelRecordData>
	{
		// Token: 0x06034AF7 RID: 215799 RVA: 0x00EBBD94 File Offset: 0x00EB9F94
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06034AF8 RID: 215800 RVA: 0x00EBBDFD File Offset: 0x00EB9FFD
		[NullableContext(1)]
		public override void Refresh(PinballLevelRecordData levelData, bool isSelected, int gridIndex)
		{
			base.GetSprite(1).SetUIActive(levelData.PassStatus == EPinballLevelPassStatus.Finished);
			base.GetSprite(0).SetUIActive(levelData.PassStatus == EPinballLevelPassStatus.Perfect);
		}

		// Token: 0x0200AF14 RID: 44820
		private enum EComponent
		{
			// Token: 0x04036196 RID: 221590
			SprPointPerfect,
			// Token: 0x04036197 RID: 221591
			SprPointFinish
		}
	}
}
