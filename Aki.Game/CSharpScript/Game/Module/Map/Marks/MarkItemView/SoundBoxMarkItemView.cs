using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x02005523 RID: 21795
	[NullableContext(1)]
	[Nullable(0)]
	public class SoundBoxMarkItemView : ServerMarkItemView
	{
		// Token: 0x06037A69 RID: 227945 RVA: 0x00D35BE0 File Offset: 0x00D33DE0
		public SoundBoxMarkItemView(SoundBoxMarkItem holder) : base(holder)
		{
		}

		// Token: 0x06037A6A RID: 227946 RVA: 0x00D35BEC File Offset: 0x00D33DEC
		protected override UniTask OnCreateAsync()
		{
			SoundBoxMarkItemView.<OnCreateAsync>d__3 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>4__this = this;
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<SoundBoxMarkItemView.<OnCreateAsync>d__3>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037A6B RID: 227947 RVA: 0x00D35C2F File Offset: 0x00D33E2F
		protected override void OnStart()
		{
			this.RadarEffect.SetUIParent(base.GetRootItem(), false);
			base.OnStart();
		}

		// Token: 0x06037A6C RID: 227948 RVA: 0x00D35C49 File Offset: 0x00D33E49
		protected override void OnViewRefresh()
		{
			this.OnIconPathChanged(this.Holder.IconPath);
		}

		// Token: 0x06037A6D RID: 227949 RVA: 0x00D35C5C File Offset: 0x00D33E5C
		protected override void OnSafeUpdate(Vector playerLocation, bool bDragging = false, bool bIsScale = false)
		{
			int? soundBoxEntityId = ((SoundBoxMarkItem)this.Holder).GetSoundBoxEntityId();
			if (soundBoxEntityId != null)
			{
				object entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(soundBoxEntityId.Value);
				this.SwitchSleepState(entityByPbDataId == null);
			}
		}

		// Token: 0x06037A6E RID: 227950 RVA: 0x00D35CA0 File Offset: 0x00D33EA0
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

		// Token: 0x06037A6F RID: 227951 RVA: 0x00D35D0D File Offset: 0x00D33F0D
		public override bool GetInteractiveFlag()
		{
			return false;
		}

		// Token: 0x06037A70 RID: 227952 RVA: 0x00D35D10 File Offset: 0x00D33F10
		protected override void OnBeforeDestroy()
		{
			if (this.RadarEffect != null)
			{
				ULGUIBPLibrary.DestroyActorWithHierarchy(this.RadarEffect.GetOwner(), true);
			}
			this.RadarEffect = null;
			base.OnBeforeDestroy();
		}

		// Token: 0x0401D42B RID: 119851
		[Nullable(2)]
		private UUIItem RadarEffect;

		// Token: 0x0401D42C RID: 119852
		private bool IsSleepState;
	}
}
