using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02007014 RID: 28692
	[NullableContext(1)]
	[Nullable(0)]
	public class TouchUiEditApplyHelper : IStaticVariableResetter
	{
		// Token: 0x06045D38 RID: 286008 RVA: 0x0115D820 File Offset: 0x0115BA20
		static TouchUiEditApplyHelper()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TouchUiEditApplyHelper.CreateStaticDefaultValue), new Action(TouchUiEditApplyHelper.ResetStaticDefaultValue));
		}

		// Token: 0x06045D39 RID: 286009 RVA: 0x0115D83F File Offset: 0x0115BA3F
		[NullableContext(2)]
		private static bool TryGetDataFacade(ECommonTouchUiEditGroup group, out CommonTouchUiEditDataFacade dataFacade)
		{
			dataFacade = null;
			if (!Info.Instance.IsInTouch())
			{
				return false;
			}
			dataFacade = TouchUiEditController.Instance.GetDataFacade<CommonTouchUiEditDataFacade>();
			if (dataFacade == null)
			{
				return false;
			}
			dataFacade.SetGroup((int)group);
			return true;
		}

		// Token: 0x06045D3A RID: 286010 RVA: 0x0115D870 File Offset: 0x0115BA70
		private static void CacheData(UiPanelBase panel, string resId, ITouchUiEditDataFacade dataFacade)
		{
			AActor rootActor = panel.GetRootActor();
			if (rootActor == null || !rootActor.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.TouchUiEdit;
				ELogAuthor author = ELogAuthor.HYF;
				string message = "遍历触屏键位失败, 传入的Panel可能已经销毁, 请检查调用时机";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Panel", resId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			ULGUIComponentsRegistry ulguicomponentsRegistry = rootActor.GetComponentByClass(ULGUIComponentsRegistry.StaticClass()) as ULGUIComponentsRegistry;
			if (ulguicomponentsRegistry == null)
			{
				return;
			}
			for (int i = -1; i < ulguicomponentsRegistry.Components.Num(); i++)
			{
				int storageId = dataFacade.GetStorageId(resId, i);
				if (storageId != 0)
				{
					AActor aactor = (i == -1) ? rootActor : ulguicomponentsRegistry.Components.Get(i);
					if (aactor != null)
					{
						UUIItem uuiitem = aactor.GetComponentByClass(UUIItem.StaticClass()) as UUIItem;
						if (uuiitem != null && !TouchUiEditApplyHelper.OriginalOffsetCache.ContainsKey(storageId))
						{
							TouchUiEditApplyHelper.OriginalOffsetCache[storageId] = new ValueTuple<float, float>(uuiitem.GetAnchorOffsetX(), uuiitem.GetAnchorOffsetY());
						}
					}
				}
			}
		}

		// Token: 0x06045D3B RID: 286011 RVA: 0x0115D960 File Offset: 0x0115BB60
		private static void ApplyData(UiPanelBase panel, string resId, ITouchUiEditDataFacade dataFacade)
		{
			AActor rootActor = panel.GetRootActor();
			if (rootActor == null || !rootActor.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.TouchUiEdit;
				ELogAuthor author = ELogAuthor.HYF;
				string message = "遍历触屏键位失败, 传入的Panel可能已经销毁, 请检查调用时机";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Panel", resId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			ULGUIComponentsRegistry ulguicomponentsRegistry = rootActor.GetComponentByClass(ULGUIComponentsRegistry.StaticClass()) as ULGUIComponentsRegistry;
			if (ulguicomponentsRegistry == null)
			{
				return;
			}
			for (int i = -1; i < ulguicomponentsRegistry.Components.Num(); i++)
			{
				int storageId = dataFacade.GetStorageId(resId, i);
				if (storageId != 0)
				{
					AActor aactor;
					if (i == -1)
					{
						aactor = rootActor;
					}
					else
					{
						aactor = ulguicomponentsRegistry.Components.Get(i);
					}
					if (aactor != null)
					{
						UUIItem uuiitem = aactor.GetComponentByClass(UUIItem.StaticClass()) as UUIItem;
						if (uuiitem != null && storageId != 0)
						{
							if (!TouchUiEditApplyHelper.OriginalOffsetCache.ContainsKey(storageId))
							{
								TouchUiEditApplyHelper.OriginalOffsetCache[storageId] = new ValueTuple<float, float>(uuiitem.GetAnchorOffsetX(), uuiitem.GetAnchorOffsetY());
							}
							ITouchUiEditData data = dataFacade.GetData(resId, i);
							if (data.Editable)
							{
								uuiitem.SetUIItemScale(new FVector(data.Scale, data.Scale, data.Scale));
								ValueTuple<float, float> valueTuple2 = TouchUiEditApplyHelper.OriginalOffsetCache[storageId];
								uuiitem.SetAnchorOffsetX(valueTuple2.Item1 + data.OffsetX);
								uuiitem.SetAnchorOffsetY(valueTuple2.Item2 + data.OffsetY);
								uuiitem.SetUIItemAlpha(data.Alpha);
								uuiitem.SetHierarchyIndex(data.HierarchyIndex);
							}
						}
					}
				}
			}
		}

		// Token: 0x06045D3C RID: 286012 RVA: 0x0115DAF0 File Offset: 0x0115BCF0
		public static void ApplyCommonTouchUiEditData(ECommonTouchUiEditGroup group, UiPanelBase panel, string resId)
		{
			CommonTouchUiEditDataFacade commonTouchUiEditDataFacade;
			if (!TouchUiEditApplyHelper.TryGetDataFacade(group, out commonTouchUiEditDataFacade) || commonTouchUiEditDataFacade == null)
			{
				return;
			}
			TouchUiEditApplyHelper.ApplyData(panel, resId, commonTouchUiEditDataFacade);
		}

		// Token: 0x06045D3D RID: 286013 RVA: 0x0115DB14 File Offset: 0x0115BD14
		public static void CacheTouchUiEditInitData(ECommonTouchUiEditGroup group, UiPanelBase panel, string resId)
		{
			CommonTouchUiEditDataFacade commonTouchUiEditDataFacade;
			if (!TouchUiEditApplyHelper.TryGetDataFacade(group, out commonTouchUiEditDataFacade) || commonTouchUiEditDataFacade == null)
			{
				return;
			}
			TouchUiEditApplyHelper.CacheData(panel, resId, commonTouchUiEditDataFacade);
		}

		// Token: 0x06045D3E RID: 286014 RVA: 0x0115DB37 File Offset: 0x0115BD37
		public static void CreateStaticDefaultValue()
		{
			TouchUiEditApplyHelper.OriginalOffsetCache = new Dictionary<int, ValueTuple<float, float>>();
		}

		// Token: 0x06045D3F RID: 286015 RVA: 0x0115DB43 File Offset: 0x0115BD43
		public static void ResetStaticDefaultValue()
		{
			TouchUiEditApplyHelper.OriginalOffsetCache = null;
		}

		// Token: 0x04024823 RID: 149539
		[Nullable(new byte[]
		{
			1,
			0
		})]
		private static Dictionary<int, ValueTuple<float, float>> OriginalOffsetCache;
	}
}
