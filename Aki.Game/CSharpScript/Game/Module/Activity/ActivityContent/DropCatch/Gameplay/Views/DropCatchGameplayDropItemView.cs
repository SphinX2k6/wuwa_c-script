using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views
{
	// Token: 0x02005646 RID: 22086
	public class DropCatchGameplayDropItemView : UiPanelBase
	{
		// Token: 0x0603690B RID: 223499 RVA: 0x00F39E70 File Offset: 0x00F38070
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUINiagara)),
				new ValueTuple<int, Type>(2, typeof(UUINiagara)),
				new ValueTuple<int, Type>(3, typeof(UUINiagara)),
				new ValueTuple<int, Type>(4, typeof(UUINiagara))
			};
		}

		// Token: 0x0603690C RID: 223500 RVA: 0x00F39EF8 File Offset: 0x00F380F8
		protected override void OnBeforeShow()
		{
			int num = (int)this.OpenParam;
			DropCatchDropItem? dropCatchDropItemById = DropCatchConfig.Instance.GetDropCatchDropItemById(num);
			if (dropCatchDropItemById == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DropCatch;
				ELogAuthor author = ELogAuthor.CB;
				string message = "找不到掉落物配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("itemId", num);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (!StringUtils.IsEmpty(dropCatchDropItemById.Value.Icon))
			{
				base.TrySetSpriteByPath(dropCatchDropItemById.Value.Icon, base.GetSprite(0), true, null, null);
			}
			this.RefreshTail((EDropCatchDropItemNiagaraType)dropCatchDropItemById.Value.NiagaraType);
		}

		// Token: 0x0603690D RID: 223501 RVA: 0x00F39FAC File Offset: 0x00F381AC
		private void RefreshTail(EDropCatchDropItemNiagaraType type)
		{
			base.GetUiNiagara(1).SetUIActive(type == EDropCatchDropItemNiagaraType.Nor);
			base.GetUiNiagara(2).SetUIActive(type == EDropCatchDropItemNiagaraType.Mid);
			base.GetUiNiagara(3).SetUIActive(type == EDropCatchDropItemNiagaraType.High);
			base.GetUiNiagara(4).SetUIActive(type == EDropCatchDropItemNiagaraType.Bad);
		}
	}
}
