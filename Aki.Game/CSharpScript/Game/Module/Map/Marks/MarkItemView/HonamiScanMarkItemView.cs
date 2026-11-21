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
	// Token: 0x020044E5 RID: 17637
	[NullableContext(1)]
	[Nullable(0)]
	public class HonamiScanMarkItemView : ConfigMarkItemView
	{
		// Token: 0x0602C89A RID: 182426 RVA: 0x00C81B58 File Offset: 0x00C7FD58
		public HonamiScanMarkItemView(HonamiScanMarkItem markItem) : base(markItem)
		{
		}

		// Token: 0x0602C89B RID: 182427 RVA: 0x00C81B6C File Offset: 0x00C7FD6C
		public override void RegisterEvents()
		{
			EventSystem.Instance.Add(EEventName.OnHonamiScanMarkInfoUpdate, new Action<int>(this.OnHonamiScanMarkItemView));
			EventSystem.Instance.Add(EEventName.WorldMapViewOpened, new Action(this.LoadEffect));
		}

		// Token: 0x0602C89C RID: 182428 RVA: 0x00C81BA6 File Offset: 0x00C7FDA6
		public override void UnRegisterEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnHonamiScanMarkInfoUpdate, new Action<int>(this.OnHonamiScanMarkItemView));
			EventSystem.Instance.Remove(EEventName.WorldMapViewOpened, new Action(this.LoadEffect));
		}

		// Token: 0x0602C89D RID: 182429 RVA: 0x00C81BE0 File Offset: 0x00C7FDE0
		protected override UniTask OnBeforeStartAsync()
		{
			HonamiScanMarkItemView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiScanMarkItemView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602C89E RID: 182430 RVA: 0x00C81C24 File Offset: 0x00C7FE24
		private void OnHonamiScanMarkItemView(int markId)
		{
			if (this.Holder.MarkId == markId)
			{
				HonamiScanMarkItem honamiScanMarkItem = (HonamiScanMarkItem)this.Holder;
				honamiScanMarkItem.UpdateIcon();
				this.OnIconPathChanged(honamiScanMarkItem.IconPath);
			}
		}

		// Token: 0x0602C89F RID: 182431 RVA: 0x00C81C5D File Offset: 0x00C7FE5D
		protected override void OnBeforeDestroy()
		{
			this.EffectPanel.SetUiActive(false);
		}

		// Token: 0x0602C8A0 RID: 182432 RVA: 0x00C81C6C File Offset: 0x00C7FE6C
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

		// Token: 0x04017E91 RID: 97937
		private readonly HonamiNiagaraPanel EffectPanel = new HonamiNiagaraPanel();
	}
}
