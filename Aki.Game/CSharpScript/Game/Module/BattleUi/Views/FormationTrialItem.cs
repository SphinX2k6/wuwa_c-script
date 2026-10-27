using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D29 RID: 23849
	[NullableContext(1)]
	[Nullable(0)]
	public class FormationTrialItem : UiPanelBase
	{
		// Token: 0x0603C799 RID: 247705 RVA: 0x00E819B4 File Offset: 0x00E7FBB4
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

		// Token: 0x0603C79A RID: 247706 RVA: 0x00E81A20 File Offset: 0x00E7FC20
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

		// Token: 0x0603C79B RID: 247707 RVA: 0x00E81A6D File Offset: 0x00E7FC6D
		public void SetNameText(string name)
		{
			if (base.InAsyncLoading())
			{
				this.NameHandle = name;
				return;
			}
			this.SetNameTextInternal(name);
		}

		// Token: 0x0603C79C RID: 247708 RVA: 0x00E81A86 File Offset: 0x00E7FC86
		public void SetTrialIcon(string resourceId)
		{
			if (base.InAsyncLoading())
			{
				this.IconHandle = resourceId;
				return;
			}
			this.SetTrialIconInternal(resourceId);
		}

		// Token: 0x0603C79D RID: 247709 RVA: 0x00E81A9F File Offset: 0x00E7FC9F
		private void SetNameTextInternal(string name)
		{
			base.GetText(0).SetText(name, true);
		}

		// Token: 0x0603C79E RID: 247710 RVA: 0x00E81AB0 File Offset: 0x00E7FCB0
		private void SetTrialIconInternal(string resourceId)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			this.SetSpriteByPath(resourcePath, base.GetSprite(1), false, null, null);
		}

		// Token: 0x0401F82B RID: 129067
		[Nullable(2)]
		private string NameHandle;

		// Token: 0x0401F82C RID: 129068
		[Nullable(2)]
		private string IconHandle;

		// Token: 0x0200BFB6 RID: 49078
		[NullableContext(0)]
		private enum EFormationTrialItem
		{
			// Token: 0x04039D6B RID: 236907
			NameText,
			// Token: 0x04039D6C RID: 236908
			IconImg
		}
	}
}
