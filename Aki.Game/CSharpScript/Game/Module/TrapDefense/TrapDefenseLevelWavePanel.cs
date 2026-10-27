using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004AB6 RID: 19126
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseLevelWavePanel : UiPanelBase
	{
		// Token: 0x060318E1 RID: 202977 RVA: 0x00B7DC24 File Offset: 0x00B7BE24
		public UniTask Init(UUIItem item)
		{
			TrapDefenseLevelWavePanel.<Init>d__2 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.item = item;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<TrapDefenseLevelWavePanel.<Init>d__2>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x060318E2 RID: 202978 RVA: 0x00B7DC70 File Offset: 0x00B7BE70
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIArtText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060318E3 RID: 202979 RVA: 0x00B7DCFC File Offset: 0x00B7BEFC
		public void UpdateData(TrapDefenseLevelData data)
		{
			this.SetActive(data.IsEndless);
			this.LevelData = data;
			if (!data.IsEndless)
			{
				return;
			}
			bool flag = data.MaxFinishWaveTimes > 0;
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(!flag);
			}
			UUIItem item2 = base.GetItem(1);
			if (item2 != null)
			{
				item2.SetUIActive(flag);
			}
			if (flag)
			{
				UUIArtText artText = base.GetArtText(2);
				if (artText == null)
				{
					return;
				}
				artText.SetText(data.MaxFinishWaveTimes.ToString());
			}
		}

		// Token: 0x0401A7B2 RID: 108466
		public TrapDefenseLevelData LevelData;

		// Token: 0x0200AC1C RID: 44060
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x040344C2 RID: 214210
			public const int ItemEmpty = 0;

			// Token: 0x040344C3 RID: 214211
			public const int ItemWaveRoot = 1;

			// Token: 0x040344C4 RID: 214212
			public const int ArtTextWave = 2;
		}
	}
}
