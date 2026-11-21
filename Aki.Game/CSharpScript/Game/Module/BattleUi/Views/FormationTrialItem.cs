using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D0B RID: 19723
	[NullableContext(1)]
	[Nullable(0)]
	public class FormationTrialItem : UiPanelBase
	{
		// Token: 0x060316F2 RID: 202482 RVA: 0x00DD2154 File Offset: 0x00DD0354
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060316F3 RID: 202483 RVA: 0x00DD21C0 File Offset: 0x00DD03C0
		protected override void OnStart()
		{
			if (!string.IsNullOrEmpty(this.NameHandle))
			{
				this.SetNameTextInternal(this.NameHandle);
			}
			this.NameHandle = null;
			if (!string.IsNullOrEmpty(this.IconHandle))
			{
				this.SetTrialIconInternal(this.IconHandle);
			}
			this.IconHandle = null;
		}

		// Token: 0x060316F4 RID: 202484 RVA: 0x00DD220D File Offset: 0x00DD040D
		public void SetNameText(string name)
		{
			if (base.InAsyncLoading())
			{
				this.NameHandle = name;
				return;
			}
			this.SetNameTextInternal(name);
		}

		// Token: 0x060316F5 RID: 202485 RVA: 0x00DD2226 File Offset: 0x00DD0426
		public void SetTrialIcon(string resourceId)
		{
			if (base.InAsyncLoading())
			{
				this.IconHandle = resourceId;
				return;
			}
			this.SetTrialIconInternal(resourceId);
		}

		// Token: 0x060316F6 RID: 202486 RVA: 0x00DD223F File Offset: 0x00DD043F
		private void SetNameTextInternal(string name)
		{
			base.GetText(0).SetText(name, true);
		}

		// Token: 0x060316F7 RID: 202487 RVA: 0x00DD2250 File Offset: 0x00DD0450
		private void SetTrialIconInternal(string resourceId)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			this.SetSpriteByPath(resourcePath, base.GetSprite(1), false, null, null);
		}

		// Token: 0x0401A2E4 RID: 107236
		[Nullable(2)]
		private string NameHandle;

		// Token: 0x0401A2E5 RID: 107237
		[Nullable(2)]
		private string IconHandle;

		// Token: 0x0200A9BC RID: 43452
		[NullableContext(0)]
		private enum EFormationTrialItem
		{
			// Token: 0x0403472D RID: 214829
			NameText,
			// Token: 0x0403472E RID: 214830
			IconImg
		}
	}
}
