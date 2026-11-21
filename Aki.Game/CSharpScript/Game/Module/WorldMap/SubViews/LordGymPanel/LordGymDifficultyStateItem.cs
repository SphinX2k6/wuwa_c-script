using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.LordGymPanel
{
	// Token: 0x0200373A RID: 14138
	public class LordGymDifficultyStateItem : GridProxyAbstract<ELordGymDifficultyState>
	{
		// Token: 0x06024C66 RID: 150630 RVA: 0x00A62E4C File Offset: 0x00A6104C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06024C67 RID: 150631 RVA: 0x00A62E94 File Offset: 0x00A61094
		public override void Refresh(ELordGymDifficultyState state, bool isSelected, int gridIndex)
		{
			string resourceId = "";
			switch (state)
			{
			case ELordGymDifficultyState.Lock:
				resourceId = "T_MapDifficultyLock";
				break;
			case ELordGymDifficultyState.Empty:
				resourceId = "T_MapDifficultyEmpty";
				break;
			case ELordGymDifficultyState.Ticked:
				resourceId = "T_MapDifficultyTick";
				break;
			}
			UiResourceConfig instance = UiResourceConfig.Instance;
			string path = (instance != null) ? instance.GetResourcePath(resourceId) : null;
			base.SetTextureByPath(path, base.GetTexture(0), null, null);
		}

		// Token: 0x0200948A RID: 38026
		public static class EComponent
		{
			// Token: 0x0402E6D3 RID: 190163
			public const int TexState = 0;
		}
	}
}
