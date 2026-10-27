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
	// Token: 0x02005956 RID: 22870
	public class HiddenBossWindow : UiViewBase
	{
		// Token: 0x0603A069 RID: 237673 RVA: 0x00DCAD90 File Offset: 0x00DC8F90
		[NullableContext(1)]
		public HiddenBossWindow(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603A06A RID: 237674 RVA: 0x00DCAD9C File Offset: 0x00DC8F9C
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

		// Token: 0x0603A06B RID: 237675 RVA: 0x00DCAE64 File Offset: 0x00DC9064
		protected override void OnStart()
		{
			IHiddenBossUiParams hiddenBossUiParams = this.OpenParam as IHiddenBossUiParams;
			HiddenBossWindow value = LevelPlayReportConfig.Instance.GetHiddenBossWindowConfig(hiddenBossUiParams.UiId).Value;
			this.SetTexNameByTextId(value.BossName, Array.Empty<string>());
			UUITexture texture = base.GetTexture(2);
			base.SetTextureByPath(value.IconRefPath, texture, null, null);
		}

		// Token: 0x0603A06C RID: 237676 RVA: 0x00DCAECC File Offset: 0x00DC90CC
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

		// Token: 0x0603A06D RID: 237677 RVA: 0x00DCB018 File Offset: 0x00DC9218
		[NullableContext(1)]
		private void SetTexNameByTextId(string textId, params string[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, args);
		}

		// Token: 0x0603A06E RID: 237678 RVA: 0x00DCB02D File Offset: 0x00DC922D
		protected override void OnAfterShow()
		{
			TimerSystem.GameplayTimeInstance.Next(delegate(float _)
			{
				base.CloseMe(null);
			}, null, null);
		}

		// Token: 0x0200BBE4 RID: 48100
		private enum EComponents
		{
			// Token: 0x04038BB2 RID: 232370
			PanelTips,
			// Token: 0x04038BB3 RID: 232371
			TxtName,
			// Token: 0x04038BB4 RID: 232372
			TexHeadIcon
		}
	}
}
