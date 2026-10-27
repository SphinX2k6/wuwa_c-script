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
	// Token: 0x02005511 RID: 21777
	[NullableContext(1)]
	[Nullable(0)]
	public class HonamiScanItemMarkItemView : ServerMarkItemView
	{
		// Token: 0x060379C5 RID: 227781 RVA: 0x00D33AAA File Offset: 0x00D31CAA
		public HonamiScanItemMarkItemView(HonamiScanItemMarkItem markItem) : base(markItem)
		{
		}

		// Token: 0x060379C6 RID: 227782 RVA: 0x00D33AC0 File Offset: 0x00D31CC0
		public override void RegisterEvents()
		{
			EventSystem.Instance.Add(EEventName.WorldMapViewOpened, new Action(this.LoadEffect));
			MarkItem holder = this.Holder;
			if (holder != null && holder.MapType == EMapType.WorldMap)
			{
				EventSystem.Instance.Add<int>(EEventName.WorldMapSubMapChangedFromUpdate, new Action<int>(this.OnSubMapChanged));
			}
		}

		// Token: 0x060379C7 RID: 227783 RVA: 0x00D33B1C File Offset: 0x00D31D1C
		public override void UnRegisterEvents()
		{
			EventSystem.Instance.Remove(EEventName.WorldMapViewOpened, new Action(this.LoadEffect));
			MarkItem holder = this.Holder;
			if (holder != null && holder.MapType == EMapType.WorldMap)
			{
				EventSystem.Instance.Remove<int>(EEventName.WorldMapSubMapChangedFromUpdate, new Action<int>(this.OnSubMapChanged));
			}
		}

		// Token: 0x060379C8 RID: 227784 RVA: 0x00D33B78 File Offset: 0x00D31D78
		protected override UniTask OnBeforeStartAsync()
		{
			HonamiScanItemMarkItemView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiScanItemMarkItemView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060379C9 RID: 227785 RVA: 0x00D33BBC File Offset: 0x00D31DBC
		private void LoadEffect()
		{
			MarkItem holder = this.Holder;
			if (holder == null || holder.MapType != EMapType.WorldMap)
			{
				return;
			}
			if (!HonamiStoryModel.Instance.ScanMarkItemIds.Contains(this.Holder.MarkId))
			{
				this.EffectPanel.SetUiActive(false);
				return;
			}
			this.EffectPanel.SetUiActive(true);
			HonamiStoryModel.Instance.ScanMarkItemIds.Remove(this.Holder.MarkId);
			this.EffectPanel.SetNiagaraAndShow("NS_Fx_LGUI_HonamiStory_Map_Burst", null);
		}

		// Token: 0x060379CA RID: 227786 RVA: 0x00D33C46 File Offset: 0x00D31E46
		public override void OnIconPathChanged(string iconPath)
		{
			base.OnIconPathChanged(iconPath);
			base.MarkItemChildIconHandle.Update();
			base.MarkItemChildIconHandle.ApplyModified();
		}

		// Token: 0x060379CB RID: 227787 RVA: 0x00D33C65 File Offset: 0x00D31E65
		protected void OnSubMapChanged(int floorIndex)
		{
			HonamiScanItemMarkItem honamiScanItemMarkItem = this.Holder as HonamiScanItemMarkItem;
			if (honamiScanItemMarkItem == null)
			{
				return;
			}
			honamiScanItemMarkItem.RefreshSubMapState();
		}

		// Token: 0x0401D40C RID: 119820
		private readonly HonamiNiagaraPanel EffectPanel = new HonamiNiagaraPanel();
	}
}
