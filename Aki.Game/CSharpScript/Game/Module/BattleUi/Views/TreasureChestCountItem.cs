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
	// Token: 0x02004D92 RID: 19858
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TreasureChestCountItem : GridProxyAbstract<TreasureChestRowData>
	{
		// Token: 0x06031E02 RID: 204290 RVA: 0x00DF28B4 File Offset: 0x00DF0AB4
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

		// Token: 0x06031E03 RID: 204291 RVA: 0x00DF2960 File Offset: 0x00DF0B60
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

		// Token: 0x06031E04 RID: 204292 RVA: 0x00DF29F8 File Offset: 0x00DF0BF8
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

		// Token: 0x06031E05 RID: 204293 RVA: 0x00DF2A40 File Offset: 0x00DF0C40
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

		// Token: 0x0200AA97 RID: 43671
		private enum EChildComponent
		{
			// Token: 0x04034B83 RID: 215939
			SprIcon,
			// Token: 0x04034B84 RID: 215940
			TxtProgress,
			// Token: 0x04034B85 RID: 215941
			SprCutLine,
			// Token: 0x04034B86 RID: 215942
			NiaChange
		}
	}
}
