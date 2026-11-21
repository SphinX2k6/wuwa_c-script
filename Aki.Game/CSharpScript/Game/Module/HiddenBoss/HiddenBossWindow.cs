using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.HiddenBoss
{
	// Token: 0x0200492F RID: 18735
	public class HiddenBossWindow : UiViewBase
	{
		// Token: 0x0602EF8C RID: 192396 RVA: 0x00D1A044 File Offset: 0x00D18244
		[NullableContext(1)]
		public HiddenBossWindow(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602EF8D RID: 192397 RVA: 0x00D1A050 File Offset: 0x00D18250
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnPanelTipsBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602EF8E RID: 192398 RVA: 0x00D1A118 File Offset: 0x00D18318
		protected override void OnStart()
		{
			IHiddenBossUiParams hiddenBossUiParams = this.OpenParam as IHiddenBossUiParams;
			HiddenBossWindow value = LevelPlayReportConfig.Instance.GetHiddenBossWindowConfig(hiddenBossUiParams.UiId).Value;
			this.SetTexNameByTextId(value.BossName, Array.Empty<string>());
			UUITexture texture = base.GetTexture(2);
			base.SetTextureByPath(value.IconRefPath, texture, null, null);
		}

		// Token: 0x0602EF8F RID: 192399 RVA: 0x00D1A180 File Offset: 0x00D18380
		private unsafe void OnPanelTipsBtnClick()
		{
			IHiddenBossUiParams hiddenBossUiParams = this.OpenParam as IHiddenBossUiParams;
			HiddenBossWindow value = LevelPlayReportConfig.Instance.GetHiddenBossWindowConfig(hiddenBossUiParams.UiId).Value;
			int markId = value.MarkId;
			OneOf<MapMark, DynamicMapMark>? oneOf = MapConfig.Instance.SearchMarkConfig(markId);
			if (oneOf == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelPlayReport;
				ELogAuthor author = ELogAuthor.LRX;
				string message = "[讨伐报告]隐藏boss解锁弹窗找不到对应的标记配置";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("弹窗Id", hiddenBossUiParams.UiId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("标记Id", value.MarkId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			base.CloseMe(null);
			int markType = 0;
			if (oneOf.Value.IsT1)
			{
				markType = oneOf.Value.AsT1.ObjectType;
			}
			else if (oneOf.Value.IsT2)
			{
				markType = oneOf.Value.AsT2.ObjectType;
			}
			WorldMapViewOpenParams data = new WorldMapViewOpenParams
			{
				MarkId = new int?(markId),
				MarkType = (EMarkType)markType
			};
			WorldMapController.Instance.OpenView(EOpenMapType.Other, false, data, null);
		}

		// Token: 0x0602EF90 RID: 192400 RVA: 0x00D1A2CC File Offset: 0x00D184CC
		[NullableContext(1)]
		private void SetTexNameByTextId(string textId, params string[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, args);
		}

		// Token: 0x0602EF91 RID: 192401 RVA: 0x00D1A2E1 File Offset: 0x00D184E1
		protected override void OnAfterShow()
		{
			TimerSystem.GameplayTimeInstance.Next(delegate(float _)
			{
				base.CloseMe(null);
			}, null, null);
		}

		// Token: 0x0200A5F3 RID: 42483
		private enum EComponents
		{
			// Token: 0x04033591 RID: 210321
			PanelTips,
			// Token: 0x04033592 RID: 210322
			TxtName,
			// Token: 0x04033593 RID: 210323
			TexHeadIcon
		}
	}
}
