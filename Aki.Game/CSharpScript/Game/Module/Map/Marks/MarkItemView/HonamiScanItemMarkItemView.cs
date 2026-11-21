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
	// Token: 0x020044E4 RID: 17636
	[NullableContext(1)]
	[Nullable(0)]
	public class HonamiScanItemMarkItemView : ServerMarkItemView
	{
		// Token: 0x0602C893 RID: 182419 RVA: 0x00C81986 File Offset: 0x00C7FB86
		public HonamiScanItemMarkItemView(HonamiScanItemMarkItem markItem) : base(markItem)
		{
		}

		// Token: 0x0602C894 RID: 182420 RVA: 0x00C8199C File Offset: 0x00C7FB9C
		public override void RegisterEvents()
		{
			EventSystem.Instance.Add(EEventName.WorldMapViewOpened, new Action(this.LoadEffect));
			MarkItem holder = this.Holder;
			if (holder != null && holder.MapType == EMapType.WorldMap)
			{
				EventSystem.Instance.Add<int>(EEventName.WorldMapSubMapChangedFromUpdate, new Action<int>(this.OnSubMapChanged));
			}
		}

		// Token: 0x0602C895 RID: 182421 RVA: 0x00C819F8 File Offset: 0x00C7FBF8
		public override void UnRegisterEvents()
		{
			EventSystem.Instance.Remove(EEventName.WorldMapViewOpened, new Action(this.LoadEffect));
			MarkItem holder = this.Holder;
			if (holder != null && holder.MapType == EMapType.WorldMap)
			{
				EventSystem.Instance.Remove<int>(EEventName.WorldMapSubMapChangedFromUpdate, new Action<int>(this.OnSubMapChanged));
			}
		}

		// Token: 0x0602C896 RID: 182422 RVA: 0x00C81A54 File Offset: 0x00C7FC54
		protected override UniTask OnBeforeStartAsync()
		{
			HonamiScanItemMarkItemView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiScanItemMarkItemView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602C897 RID: 182423 RVA: 0x00C81A98 File Offset: 0x00C7FC98
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

		// Token: 0x0602C898 RID: 182424 RVA: 0x00C81B22 File Offset: 0x00C7FD22
		public override void OnIconPathChanged(string iconPath)
		{
			base.OnIconPathChanged(iconPath);
			base.MarkItemChildIconHandle.Update();
			base.MarkItemChildIconHandle.ApplyModified();
		}

		// Token: 0x0602C899 RID: 182425 RVA: 0x00C81B41 File Offset: 0x00C7FD41
		protected void OnSubMapChanged(int floorIndex)
		{
			HonamiScanItemMarkItem honamiScanItemMarkItem = this.Holder as HonamiScanItemMarkItem;
			if (honamiScanItemMarkItem == null)
			{
				return;
			}
			honamiScanItemMarkItem.RefreshSubMapState();
		}

		// Token: 0x04017E90 RID: 97936
		private readonly HonamiNiagaraPanel EffectPanel = new HonamiNiagaraPanel();
	}
}
