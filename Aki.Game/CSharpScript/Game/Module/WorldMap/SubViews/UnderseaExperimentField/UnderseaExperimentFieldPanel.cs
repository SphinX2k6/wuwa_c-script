using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.UnderseaExperimentField
{
	// Token: 0x02003714 RID: 14100
	[NullableContext(1)]
	[Nullable(0)]
	public class UnderseaExperimentFieldPanel : UiPanelBase
	{
		// Token: 0x06024B1A RID: 150298 RVA: 0x00A5C398 File Offset: 0x00A5A598
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIExtendToggle));
			this.ComponentRegisterInfos = list;
			num2 = 5;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(delegate(EToggleState toggleState)
			{
				this.RefreshToggleItem(EDeepSeaMapId.Graveyard);
			}));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(delegate(EToggleState toggleState)
			{
				this.RefreshToggleItem(EDeepSeaMapId.CultivationField);
			}));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action<EToggleState>(delegate(EToggleState toggleState)
			{
				this.RefreshToggleItem(EDeepSeaMapId.EnergyField);
			}));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action<EToggleState>(delegate(EToggleState toggleState)
			{
				this.RefreshToggleItem(EDeepSeaMapId.Sanctuary);
			}));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action<EToggleState>(delegate(EToggleState toggleState)
			{
				this.RefreshToggleItem(EDeepSeaMapId.MainTower);
			}));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06024B1B RID: 150299 RVA: 0x00A5C530 File Offset: 0x00A5A730
		public UniTask Initialize(UUIItem uiRoot, Action<int> checkedCallback)
		{
			UnderseaExperimentFieldPanel.<Initialize>d__6 <Initialize>d__;
			<Initialize>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Initialize>d__.<>4__this = this;
			<Initialize>d__.uiRoot = uiRoot;
			<Initialize>d__.checkedCallback = checkedCallback;
			<Initialize>d__.<>1__state = -1;
			<Initialize>d__.<>t__builder.Start<UnderseaExperimentFieldPanel.<Initialize>d__6>(ref <Initialize>d__);
			return <Initialize>d__.<>t__builder.Task;
		}

		// Token: 0x06024B1C RID: 150300 RVA: 0x00A5C584 File Offset: 0x00A5A784
		private UniTask InitializeToggleItem(EDeepSeaMapId mapId, UUIExtendToggle uiRoot)
		{
			UnderseaExperimentFieldPanel.<InitializeToggleItem>d__7 <InitializeToggleItem>d__;
			<InitializeToggleItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeToggleItem>d__.<>4__this = this;
			<InitializeToggleItem>d__.mapId = mapId;
			<InitializeToggleItem>d__.uiRoot = uiRoot;
			<InitializeToggleItem>d__.<>1__state = -1;
			<InitializeToggleItem>d__.<>t__builder.Start<UnderseaExperimentFieldPanel.<InitializeToggleItem>d__7>(ref <InitializeToggleItem>d__);
			return <InitializeToggleItem>d__.<>t__builder.Task;
		}

		// Token: 0x06024B1D RID: 150301 RVA: 0x00A5C5D8 File Offset: 0x00A5A7D8
		private void RefreshToggleItem(EDeepSeaMapId deepSeaMapId)
		{
			this.CurrentMapId = deepSeaMapId;
			WorldMapConfig instance = WorldMapConfig.Instance;
			CustomizedThumbnail? customizedThumbnail = (instance != null) ? instance.GetCustomizedThumbnailConfig(deepSeaMapId) : null;
			Action<int> checkedCallback = this.CheckedCallback;
			if (checkedCallback != null)
			{
				checkedCallback((customizedThumbnail != null) ? customizedThumbnail.GetValueOrDefault().MarkId : 0);
			}
			this.RefreshToggleState();
		}

		// Token: 0x06024B1E RID: 150302 RVA: 0x00A5C63C File Offset: 0x00A5A83C
		private void RefreshToggleState()
		{
			foreach (KeyValuePair<EDeepSeaMapId, int> keyValuePair in this.SeaMapIdToComponent)
			{
				EDeepSeaMapId edeepSeaMapId;
				int num;
				keyValuePair.Deconstruct(out edeepSeaMapId, out num);
				EDeepSeaMapId edeepSeaMapId2 = edeepSeaMapId;
				int name = num;
				UUIExtendToggle extendToggle = base.GetExtendToggle(name);
				EToggleState state = (this.CurrentMapId == edeepSeaMapId2) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
				if (extendToggle != null)
				{
					extendToggle.SetToggleState(state, false, false, false);
				}
			}
		}

		// Token: 0x06024B1F RID: 150303 RVA: 0x00A5C6C0 File Offset: 0x00A5A8C0
		public UnderseaExperimentFieldPanel()
		{
			Dictionary<EDeepSeaMapId, int> dictionary = new Dictionary<EDeepSeaMapId, int>();
			dictionary[EDeepSeaMapId.Graveyard] = 0;
			dictionary[EDeepSeaMapId.CultivationField] = 1;
			dictionary[EDeepSeaMapId.EnergyField] = 2;
			dictionary[EDeepSeaMapId.Sanctuary] = 3;
			dictionary[EDeepSeaMapId.MainTower] = 4;
			this.SeaMapIdToComponent = dictionary;
			this.Toggles = new Dictionary<EDeepSeaMapId, UnderseaExperimentToggleItem>();
			base..ctor();
		}

		// Token: 0x0401460C RID: 83468
		private EDeepSeaMapId CurrentMapId;

		// Token: 0x0401460D RID: 83469
		private readonly Dictionary<EDeepSeaMapId, int> SeaMapIdToComponent;

		// Token: 0x0401460E RID: 83470
		private readonly Dictionary<EDeepSeaMapId, UnderseaExperimentToggleItem> Toggles;

		// Token: 0x0401460F RID: 83471
		[Nullable(2)]
		private Action<int> CheckedCallback;

		// Token: 0x02009452 RID: 37970
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x0402E60C RID: 189964
			public const int TogGraveyard = 0;

			// Token: 0x0402E60D RID: 189965
			public const int TogCultivationField = 1;

			// Token: 0x0402E60E RID: 189966
			public const int TogEnergyField = 2;

			// Token: 0x0402E60F RID: 189967
			public const int TogSanctuary = 3;

			// Token: 0x0402E610 RID: 189968
			public const int TogMainTower = 4;
		}
	}
}
