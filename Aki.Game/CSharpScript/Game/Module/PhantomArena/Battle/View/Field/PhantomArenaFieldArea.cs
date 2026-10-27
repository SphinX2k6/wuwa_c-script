using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Field
{
	// Token: 0x02005260 RID: 21088
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaFieldArea : UiPanelBase
	{
		// Token: 0x06035E8C RID: 220812 RVA: 0x00CC1B5C File Offset: 0x00CBFD5C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUINiagara)),
				new ValueTuple<int, Type>(3, typeof(UUINiagara)),
				new ValueTuple<int, Type>(4, typeof(UUITexture)),
				new ValueTuple<int, Type>(5, typeof(UUITexture)),
				new ValueTuple<int, Type>(6, typeof(UUITexture)),
				new ValueTuple<int, Type>(7, typeof(UUITexture))
			};
		}

		// Token: 0x06035E8D RID: 220813 RVA: 0x00CC1C24 File Offset: 0x00CBFE24
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaFieldArea.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaFieldArea.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035E8E RID: 220814 RVA: 0x00CC1C67 File Offset: 0x00CBFE67
		private void FieldPointerEnter(PhantomArenaFieldData fieldData, UUIItem attachItem)
		{
			this.ViewProxy.FieldPointerEnter(fieldData, attachItem, false);
		}

		// Token: 0x06035E8F RID: 220815 RVA: 0x00CC1C77 File Offset: 0x00CBFE77
		protected override void OnStart()
		{
			this.Sequence = new UiSequencePlayer(this.RootItem);
			this.Sequence.BindOnEndSequenceEvent(new Action<string>(this.OnSequenceEndEvent));
		}

		// Token: 0x06035E90 RID: 220816 RVA: 0x00CC1CA1 File Offset: 0x00CBFEA1
		protected override void OnBeforeDestroy()
		{
			this.Sequence.Clear();
		}

		// Token: 0x06035E91 RID: 220817 RVA: 0x00CC1CAE File Offset: 0x00CBFEAE
		private void OnSequenceEndEvent(string sequenceName)
		{
			if (sequenceName == "Close")
			{
				this.FieldItem.SetFieldItemActive(false);
			}
		}

		// Token: 0x06035E92 RID: 220818 RVA: 0x00CC1CCC File Offset: 0x00CBFECC
		private void RefreshNiagaraState()
		{
			if (this.FieldData.CardData != null)
			{
				UUINiagara uiNiagara = base.GetUiNiagara(2);
				UUINiagara uiNiagara2 = base.GetUiNiagara(3);
				if (!StringUtils.IsBlank(this.FieldData.FieldLightColor))
				{
					uiNiagara.SetColor(FColor.FromHex(this.FieldData.FieldLightColor));
				}
				if (!StringUtils.IsBlank(this.FieldData.FieldReleaseColor))
				{
					uiNiagara2.SetColor(FColor.FromHex(this.FieldData.FieldReleaseColor));
				}
			}
		}

		// Token: 0x06035E93 RID: 220819 RVA: 0x00CC1D48 File Offset: 0x00CBFF48
		private UniTask RefreshTexState()
		{
			PhantomArenaFieldArea.<RefreshTexState>d__12 <RefreshTexState>d__;
			<RefreshTexState>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshTexState>d__.<>4__this = this;
			<RefreshTexState>d__.<>1__state = -1;
			<RefreshTexState>d__.<>t__builder.Start<PhantomArenaFieldArea.<RefreshTexState>d__12>(ref <RefreshTexState>d__);
			return <RefreshTexState>d__.<>t__builder.Task;
		}

		// Token: 0x06035E94 RID: 220820 RVA: 0x00CC1D8C File Offset: 0x00CBFF8C
		private UniTask PlayReleaseSequence()
		{
			PhantomArenaFieldArea.<PlayReleaseSequence>d__13 <PlayReleaseSequence>d__;
			<PlayReleaseSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayReleaseSequence>d__.<>4__this = this;
			<PlayReleaseSequence>d__.<>1__state = -1;
			<PlayReleaseSequence>d__.<>t__builder.Start<PhantomArenaFieldArea.<PlayReleaseSequence>d__13>(ref <PlayReleaseSequence>d__);
			return <PlayReleaseSequence>d__.<>t__builder.Task;
		}

		// Token: 0x06035E95 RID: 220821 RVA: 0x00CC1DD0 File Offset: 0x00CBFFD0
		public UniTask Refresh(PhantomArenaFieldData filedData)
		{
			PhantomArenaFieldArea.<Refresh>d__14 <Refresh>d__;
			<Refresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Refresh>d__.<>4__this = this;
			<Refresh>d__.filedData = filedData;
			<Refresh>d__.<>1__state = -1;
			<Refresh>d__.<>t__builder.Start<PhantomArenaFieldArea.<Refresh>d__14>(ref <Refresh>d__);
			return <Refresh>d__.<>t__builder.Task;
		}

		// Token: 0x06035E96 RID: 220822 RVA: 0x00CC1E1C File Offset: 0x00CC001C
		public UniTask RefreshSelf()
		{
			PhantomArenaFieldArea.<RefreshSelf>d__15 <RefreshSelf>d__;
			<RefreshSelf>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshSelf>d__.<>4__this = this;
			<RefreshSelf>d__.<>1__state = -1;
			<RefreshSelf>d__.<>t__builder.Start<PhantomArenaFieldArea.<RefreshSelf>d__15>(ref <RefreshSelf>d__);
			return <RefreshSelf>d__.<>t__builder.Task;
		}

		// Token: 0x06035E97 RID: 220823 RVA: 0x00CC1E60 File Offset: 0x00CC0060
		public UniTask TriggerSkill()
		{
			PhantomArenaFieldArea.<TriggerSkill>d__16 <TriggerSkill>d__;
			<TriggerSkill>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TriggerSkill>d__.<>4__this = this;
			<TriggerSkill>d__.<>1__state = -1;
			<TriggerSkill>d__.<>t__builder.Start<PhantomArenaFieldArea.<TriggerSkill>d__16>(ref <TriggerSkill>d__);
			return <TriggerSkill>d__.<>t__builder.Task;
		}

		// Token: 0x06035E98 RID: 220824 RVA: 0x00CC1EA3 File Offset: 0x00CC00A3
		public void ResetSkillTrigger()
		{
			this.FieldItem.ResetSkill();
		}

		// Token: 0x06035E99 RID: 220825 RVA: 0x00CC1EB0 File Offset: 0x00CC00B0
		public void RegisterViewProxy(PhantomArenaBattleProxy proxy)
		{
			this.ViewProxy = proxy;
		}

		// Token: 0x06035E9A RID: 220826 RVA: 0x00CC1EBC File Offset: 0x00CC00BC
		public void SwitchFieldState(bool active)
		{
			if (this.FieldData.CardData != null && active)
			{
				this.FieldItem.SetFieldItemActive(true);
				this.Sequence.PlaySequence("Start", false, null);
				return;
			}
			this.Sequence.PlaySequence("Close", false, null);
		}

		// Token: 0x0401C8F1 RID: 116977
		public PhantomArenaBattleProxy ViewProxy;

		// Token: 0x0401C8F2 RID: 116978
		protected PhantomArenaFieldItem FieldItem;

		// Token: 0x0401C8F3 RID: 116979
		protected UiSequencePlayer Sequence;

		// Token: 0x0401C8F4 RID: 116980
		protected PhantomArenaFieldData FieldData;

		// Token: 0x0200B43A RID: 46138
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x040369B5 RID: 223669
			public const int FieldItem = 0;

			// Token: 0x040369B6 RID: 223670
			public const int SkillName = 1;

			// Token: 0x040369B7 RID: 223671
			public const int NiagaraLight = 2;

			// Token: 0x040369B8 RID: 223672
			public const int NiagaraRelease = 3;

			// Token: 0x040369B9 RID: 223673
			public const int TextRelease = 4;

			// Token: 0x040369BA RID: 223674
			public const int TexBg = 5;

			// Token: 0x040369BB RID: 223675
			public const int TexIcon = 6;

			// Token: 0x040369BC RID: 223676
			public const int TexSmoke = 7;
		}
	}
}
