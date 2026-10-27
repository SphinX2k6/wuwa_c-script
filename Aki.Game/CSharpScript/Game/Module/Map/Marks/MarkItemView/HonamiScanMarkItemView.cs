using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Map.Marks.SubPanel;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x02005512 RID: 21778
	[NullableContext(1)]
	[Nullable(0)]
	public class HonamiScanMarkItemView : ConfigMarkItemView
	{
		// Token: 0x060379CC RID: 227788 RVA: 0x00D33C7C File Offset: 0x00D31E7C
		public HonamiScanMarkItemView(HonamiScanMarkItem markItem) : base(markItem)
		{
		}

		// Token: 0x060379CD RID: 227789 RVA: 0x00D33C90 File Offset: 0x00D31E90
		public override void RegisterEvents()
		{
			EventSystem.Instance.Add(EEventName.OnHonamiScanMarkInfoUpdate, new Action<int>(this.OnHonamiScanMarkItemView));
			EventSystem.Instance.Add(EEventName.WorldMapViewOpened, new Action(this.LoadEffect));
		}

		// Token: 0x060379CE RID: 227790 RVA: 0x00D33CCA File Offset: 0x00D31ECA
		public override void UnRegisterEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnHonamiScanMarkInfoUpdate, new Action<int>(this.OnHonamiScanMarkItemView));
			EventSystem.Instance.Remove(EEventName.WorldMapViewOpened, new Action(this.LoadEffect));
		}

		// Token: 0x060379CF RID: 227791 RVA: 0x00D33D04 File Offset: 0x00D31F04
		protected override UniTask OnBeforeStartAsync()
		{
			HonamiScanMarkItemView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiScanMarkItemView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060379D0 RID: 227792 RVA: 0x00D33D48 File Offset: 0x00D31F48
		private void OnHonamiScanMarkItemView(int markId)
		{
			if (base.MarkConfig.Value.MarkId == markId)
			{
				HonamiScanMarkItem honamiScanMarkItem = (HonamiScanMarkItem)this.Holder;
				honamiScanMarkItem.UpdateIcon();
				this.OnIconPathChanged(honamiScanMarkItem.IconPath);
			}
		}

		// Token: 0x060379D1 RID: 227793 RVA: 0x00D33D8C File Offset: 0x00D31F8C
		protected override void OnBeforeDestroy()
		{
			this.EffectPanel.SetUiActive(false);
		}

		// Token: 0x060379D2 RID: 227794 RVA: 0x00D33D9C File Offset: 0x00D31F9C
		private void LoadEffect()
		{
			MarkItem holder = this.Holder;
			if (holder == null || holder.MapType != EMapType.WorldMap)
			{
				return;
			}
			int? scanMarkId = HonamiStoryModel.Instance.ScanMarkId;
			int markId = this.Holder.MarkId;
			if (!(scanMarkId.GetValueOrDefault() == markId & scanMarkId != null))
			{
				this.EffectPanel.SetUiActive(false);
				return;
			}
			this.EffectPanel.SetUiActive(true);
			HonamiStoryModel.Instance.ScanMarkId = null;
			this.EffectPanel.SetNiagaraAndShow("NS_Fx_LGUI_HonamiStory_Map_Kuosan", "play_ui_honamistory_scan_mark_start");
		}

		// Token: 0x0401D40D RID: 119821
		private readonly HonamiNiagaraPanel EffectPanel = new HonamiNiagaraPanel();
	}
}
