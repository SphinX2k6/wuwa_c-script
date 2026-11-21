using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x020044F6 RID: 17654
	[NullableContext(1)]
	[Nullable(0)]
	public class SoundBoxMarkItemView : ServerMarkItemView
	{
		// Token: 0x0602C939 RID: 182585 RVA: 0x00C839EC File Offset: 0x00C81BEC
		public SoundBoxMarkItemView(SoundBoxMarkItem holder) : base(holder)
		{
		}

		// Token: 0x0602C93A RID: 182586 RVA: 0x00C839F8 File Offset: 0x00C81BF8
		protected override UniTask OnCreateAsync()
		{
			SoundBoxMarkItemView.<OnCreateAsync>d__3 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>4__this = this;
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<SoundBoxMarkItemView.<OnCreateAsync>d__3>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602C93B RID: 182587 RVA: 0x00C83A3B File Offset: 0x00C81C3B
		protected override void OnStart()
		{
			this.RadarEffect.SetUIParent(base.GetRootItem(), false);
			base.OnStart();
		}

		// Token: 0x0602C93C RID: 182588 RVA: 0x00C83A55 File Offset: 0x00C81C55
		protected override void OnViewRefresh()
		{
			this.OnIconPathChanged(this.Holder.IconPath);
		}

		// Token: 0x0602C93D RID: 182589 RVA: 0x00C83A68 File Offset: 0x00C81C68
		protected override void OnSafeUpdate(Vector playerLocation, bool bDragging = false, bool bIsScale = false)
		{
			int? soundBoxEntityId = ((SoundBoxMarkItem)this.Holder).GetSoundBoxEntityId();
			if (soundBoxEntityId != null)
			{
				object entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(soundBoxEntityId.Value);
				this.SwitchSleepState(entityByPbDataId == null);
			}
		}

		// Token: 0x0602C93E RID: 182590 RVA: 0x00C83AAC File Offset: 0x00C81CAC
		public void SwitchSleepState(bool isSleep)
		{
			if (this.IsSleepState == isSleep)
			{
				return;
			}
			this.IsSleepState = isSleep;
			if (isSleep)
			{
				this.SetSpriteByPath(UiResourceConfig.Instance.GetResourcePath(isSleep ? "SP_MarkSleep" : "SP_MarkNormal"), base.GetSprite(2), false, null, null);
				base.GetSprite(2).SetUIActive(true);
				return;
			}
			base.GetSprite(2).SetUIActive(false);
		}

		// Token: 0x0602C93F RID: 182591 RVA: 0x00C83B19 File Offset: 0x00C81D19
		public override bool GetInteractiveFlag()
		{
			return false;
		}

		// Token: 0x0602C940 RID: 182592 RVA: 0x00C83B1C File Offset: 0x00C81D1C
		protected override void OnBeforeDestroy()
		{
			if (this.RadarEffect != null)
			{
				ULGUIBPLibrary.DestroyActorWithHierarchy(this.RadarEffect.GetOwner(), true);
			}
			this.RadarEffect = null;
			base.OnBeforeDestroy();
		}

		// Token: 0x04017EAE RID: 97966
		[Nullable(2)]
		private UUIItem RadarEffect;

		// Token: 0x04017EAF RID: 97967
		private bool IsSleepState;
	}
}
