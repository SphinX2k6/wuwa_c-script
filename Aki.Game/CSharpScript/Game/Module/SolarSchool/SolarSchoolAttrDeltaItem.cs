using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x0200598D RID: 22925
	public class SolarSchoolAttrDeltaItem : GridProxyAbstract<SolarSchoolAttrDeltaItemData>
	{
		// Token: 0x06038867 RID: 231527 RVA: 0x00FD09A8 File Offset: 0x00FCEBA8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038868 RID: 231528 RVA: 0x00FD0AFC File Offset: 0x00FCECFC
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolAttrDeltaItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolAttrDeltaItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038869 RID: 231529 RVA: 0x00FD0B3F File Offset: 0x00FCED3F
		protected override void OnStart()
		{
			EventSystem.Instance.Add<ESolarSchoolSecondAttr>(EEventName.SolarSchoolAttrImportantChanged, new Action<ESolarSchoolSecondAttr>(this.OnAttrImportantChanged));
		}

		// Token: 0x0603886A RID: 231530 RVA: 0x00FD0B5D File Offset: 0x00FCED5D
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove<ESolarSchoolSecondAttr>(EEventName.SolarSchoolAttrImportantChanged, new Action<ESolarSchoolSecondAttr>(this.OnAttrImportantChanged));
			this.FatigueState = null;
		}

		// Token: 0x0603886B RID: 231531 RVA: 0x00FD0B84 File Offset: 0x00FCED84
		public override void Refresh(SolarSchoolAttrDeltaItemData data, bool isSelected, int gridIndex)
		{
			this.CurrentAttr = data.Attr;
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			this.RefreshScratch();
			SolarSchoolAttr? solarSchoolAttr = SolarSchoolConfig.Instance.TryGetAttrByType(instance.ActivityId, (int)data.Attr);
			if (solarSchoolAttr == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), solarSchoolAttr.Value.Name, Array.Empty<object>());
			int delta = data.Delta;
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.SetText(SolarSchoolAttrDeltaItem.GetDeltaText(data.Attr, delta), true);
			}
			this.RefreshArrow(data.Attr, delta);
			this.RefreshIcon(solarSchoolAttr.Value, data);
		}

		// Token: 0x0603886C RID: 231532 RVA: 0x00FD0C30 File Offset: 0x00FCEE30
		private void OnAttrImportantChanged(ESolarSchoolSecondAttr attr)
		{
			if (attr == this.CurrentAttr)
			{
				this.RefreshScratch();
			}
		}

		// Token: 0x0603886D RID: 231533 RVA: 0x00FD0C41 File Offset: 0x00FCEE41
		private void RefreshScratch()
		{
			UUISprite sprite = base.GetSprite(8);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(SolarSchoolGamePlayModel.Instance.PlayerData.IsAttrImportant(this.CurrentAttr));
		}

		// Token: 0x0603886E RID: 231534 RVA: 0x00FD0C6C File Offset: 0x00FCEE6C
		private void RefreshArrow(ESolarSchoolSecondAttr attr, int delta)
		{
			bool flag = attr == ESolarSchoolSecondAttr.Fatigue;
			UUISprite sprite = base.GetSprite(3);
			if (sprite != null)
			{
				sprite.SetUIActive(delta > 0);
			}
			if (sprite != null)
			{
				UUIItem uuiitem = sprite;
				bool bUseChangeColor = flag;
				FColor? fcolor = new FColor?(sprite.changeColor);
				uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			}
			UUISprite sprite2 = base.GetSprite(4);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(delta < 0);
			}
			if (sprite2 != null)
			{
				UUIItem uuiitem2 = sprite2;
				bool bUseChangeColor2 = flag;
				FColor? fcolor = new FColor?(sprite2.changeColor);
				uuiitem2.SetChangeColor(bUseChangeColor2, fcolor);
			}
		}

		// Token: 0x0603886F RID: 231535 RVA: 0x00FD0CD8 File Offset: 0x00FCEED8
		[NullableContext(1)]
		private static string GetDeltaText(ESolarSchoolSecondAttr attr, int delta)
		{
			if (attr != ESolarSchoolSecondAttr.Fatigue)
			{
				return Math.Abs(delta).ToString();
			}
			return SolarSchoolUtils.GetAttrDeltaText(attr, delta);
		}

		// Token: 0x06038870 RID: 231536 RVA: 0x00FD0D00 File Offset: 0x00FCEF00
		private void RefreshIcon(SolarSchoolAttr config, SolarSchoolAttrDeltaItemData data)
		{
			bool flag = data.Attr == ESolarSchoolSecondAttr.Fatigue;
			UUITexture texture = base.GetTexture(6);
			if (texture != null)
			{
				texture.SetUIActive(!flag);
			}
			UUITexture texture2 = base.GetTexture(1);
			if (texture2 != null)
			{
				texture2.SetUIActive(false);
			}
			UUIItem item = base.GetItem(7);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			if (!flag)
			{
				base.SetTextureByPath(config.IconSmall, base.GetTexture(6), null, null);
				return;
			}
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			int paramInt = SolarSchoolConfig.Instance.GetParamInt(instance.ActivityId, "TiredThreshold", 0);
			int paramInt2 = SolarSchoolConfig.Instance.GetParamInt(instance.ActivityId, "SickThreshold", 0);
			int p = data.HasFatigueBase ? data.FatigueBase : instance.PlayerData.GetAttr(ESolarSchoolSecondAttr.Fatigue);
			SolarSchoolFatigueStateItem fatigueState = this.FatigueState;
			if (fatigueState == null)
			{
				return;
			}
			fatigueState.SetStage(SolarSchoolUtils.CalcFatigueStage(p, paramInt, paramInt2));
		}

		// Token: 0x0401DC73 RID: 121971
		[Nullable(2)]
		private SolarSchoolFatigueStateItem FatigueState;

		// Token: 0x0401DC74 RID: 121972
		private ESolarSchoolSecondAttr CurrentAttr;

		// Token: 0x0200B531 RID: 46385
		private class EComponents
		{
			// Token: 0x04038057 RID: 229463
			public const int TxtConsum = 0;

			// Token: 0x04038058 RID: 229464
			public const int TexStateIcon = 1;

			// Token: 0x04038059 RID: 229465
			public const int TxtValue = 2;

			// Token: 0x0403805A RID: 229466
			public const int SprUp = 3;

			// Token: 0x0403805B RID: 229467
			public const int SprDown = 4;

			// Token: 0x0403805C RID: 229468
			public const int SprBg = 5;

			// Token: 0x0403805D RID: 229469
			public const int TexIcon = 6;

			// Token: 0x0403805E RID: 229470
			public const int StateItem = 7;

			// Token: 0x0403805F RID: 229471
			public const int SprScratch = 8;
		}
	}
}
