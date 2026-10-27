using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DAE RID: 23982
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TreasureChestCountItem : GridProxyAbstract<TreasureChestRowData>
	{
		// Token: 0x0603CE8B RID: 249483 RVA: 0x00EA19E0 File Offset: 0x00E9FBE0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUINiagara));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603CE8C RID: 249484 RVA: 0x00EA1A8C File Offset: 0x00E9FC8C
		[NullableContext(1)]
		public override void Refresh(TreasureChestRowData data, bool isSelected, int gridIndex)
		{
			this.RefreshIcon(data.Count.StatType);
			UUIText text = base.GetText(1);
			if (text != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(data.Count.CurrentCount);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(data.Count.TotalCount);
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			UUISprite sprite = base.GetSprite(2);
			if (sprite != null)
			{
				sprite.SetUIActive(!data.IsLast);
			}
			this.RefreshNumChangeEffect(data.Gained);
		}

		// Token: 0x0603CE8D RID: 249485 RVA: 0x00EA1B24 File Offset: 0x00E9FD24
		private void RefreshIcon(TreasureChestStatType statType)
		{
			UUISprite sprite = base.GetSprite(0);
			string resourceId;
			if (sprite == null || !MapDefine.TreasureChestIconResourceId.TryGetValue(statType, out resourceId))
			{
				return;
			}
			this.SetSpriteByPath(UiResourceConfig.Instance.GetResourcePath(resourceId), sprite, false, null, null);
		}

		// Token: 0x0603CE8E RID: 249486 RVA: 0x00EA1B6C File Offset: 0x00E9FD6C
		private void RefreshNumChangeEffect(bool gained)
		{
			UUINiagara uiNiagara = base.GetUiNiagara(3);
			if (uiNiagara == null)
			{
				return;
			}
			uiNiagara.SetUIActive(gained);
			if (gained)
			{
				uiNiagara.ActivateSystem(true);
			}
		}

		// Token: 0x0200C08E RID: 49294
		private enum EChildComponent
		{
			// Token: 0x0403A1B1 RID: 238001
			SprIcon,
			// Token: 0x0403A1B2 RID: 238002
			TxtProgress,
			// Token: 0x0403A1B3 RID: 238003
			SprCutLine,
			// Token: 0x0403A1B4 RID: 238004
			NiaChange
		}
	}
}
