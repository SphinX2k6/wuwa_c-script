using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02006195 RID: 24981
	[NullableContext(1)]
	[Nullable(0)]
	public class TouchUiEditApplyHelper : IStaticVariableResetter
	{
		// Token: 0x0603BEEE RID: 245486 RVA: 0x01107C1C File Offset: 0x01105E1C
		static TouchUiEditApplyHelper()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TouchUiEditApplyHelper.CreateStaticDefaultValue), new Action(TouchUiEditApplyHelper.ResetStaticDefaultValue));
		}

		// Token: 0x0603BEEF RID: 245487 RVA: 0x01107C3B File Offset: 0x01105E3B
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

		// Token: 0x0603BEF0 RID: 245488 RVA: 0x01107C6C File Offset: 0x01105E6C
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

		// Token: 0x0603BEF1 RID: 245489 RVA: 0x01107D5C File Offset: 0x01105F5C
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

		// Token: 0x0603BEF2 RID: 245490 RVA: 0x01107EEC File Offset: 0x011060EC
		public static void ApplyCommonTouchUiEditData(ECommonTouchUiEditGroup group, UiPanelBase panel, string resId)
		{
			CommonTouchUiEditDataFacade commonTouchUiEditDataFacade;
			if (!TouchUiEditApplyHelper.TryGetDataFacade(group, out commonTouchUiEditDataFacade) || commonTouchUiEditDataFacade == null)
			{
				return;
			}
			TouchUiEditApplyHelper.ApplyData(panel, resId, commonTouchUiEditDataFacade);
		}

		// Token: 0x0603BEF3 RID: 245491 RVA: 0x01107F10 File Offset: 0x01106110
		public static void CacheTouchUiEditInitData(ECommonTouchUiEditGroup group, UiPanelBase panel, string resId)
		{
			CommonTouchUiEditDataFacade commonTouchUiEditDataFacade;
			if (!TouchUiEditApplyHelper.TryGetDataFacade(group, out commonTouchUiEditDataFacade) || commonTouchUiEditDataFacade == null)
			{
				return;
			}
			TouchUiEditApplyHelper.CacheData(panel, resId, commonTouchUiEditDataFacade);
		}

		// Token: 0x0603BEF4 RID: 245492 RVA: 0x01107F33 File Offset: 0x01106133
		public static void CreateStaticDefaultValue()
		{
			TouchUiEditApplyHelper.OriginalOffsetCache = new Dictionary<int, ValueTuple<float, float>>();
		}

		// Token: 0x0603BEF5 RID: 245493 RVA: 0x01107F3F File Offset: 0x0110613F
		public static void ResetStaticDefaultValue()
		{
			TouchUiEditApplyHelper.OriginalOffsetCache = null;
		}

		// Token: 0x0401FAD9 RID: 129753
		[Nullable(new byte[]
		{
			1,
			0
		})]
		private static Dictionary<int, ValueTuple<float, float>> OriginalOffsetCache;
	}
}
