using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200491B RID: 18715
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationSelectableCreator : IStaticVariableResetter
	{
		// Token: 0x06030E6D RID: 200301 RVA: 0x00B5ABF2 File Offset: 0x00B58DF2
		static NavigationSelectableCreator()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(NavigationSelectableCreator.CreateStaticDefaultValue), new Action(NavigationSelectableCreator.ResetStaticDefaultValue));
		}

		// Token: 0x170079C7 RID: 31175
		// (get) Token: 0x06030E6E RID: 200302 RVA: 0x00B5AC11 File Offset: 0x00B58E11
		private static Dictionary<string, Type> NavigationBehaviorMap
		{
			get
			{
				return NavigationSelectableCreator._navigationBehaviorMap;
			}
		}

		// Token: 0x06030E6F RID: 200303 RVA: 0x00B5AC18 File Offset: 0x00B58E18
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		private static ValueTuple<Type, string> GetBaseBehaviorCtorData(ULGUIBehaviour behavior)
		{
			ENavigationSelectableDefine enavigationSelectableDefine;
			if (behavior is UUIExtendToggle)
			{
				enavigationSelectableDefine = ENavigationSelectableDefine.Toggle;
			}
			else if (behavior is UUIButtonComponent)
			{
				enavigationSelectableDefine = ENavigationSelectableDefine.Button;
			}
			else if (behavior is UUIScrollViewWithScrollbarComponent)
			{
				enavigationSelectableDefine = ENavigationSelectableDefine.Scrollbar;
			}
			else if (behavior is UUISliderComponent)
			{
				enavigationSelectableDefine = ENavigationSelectableDefine.Slider;
			}
			else if (behavior is UUIDraggableComponent)
			{
				enavigationSelectableDefine = ENavigationSelectableDefine.DragComponent;
			}
			else
			{
				enavigationSelectableDefine = ENavigationSelectableDefine.Selectable;
			}
			return new ValueTuple<Type, string>(NavigationSelectableCreator.NavigationBehaviorMap[enavigationSelectableDefine.ToString()], enavigationSelectableDefine.ToString());
		}

		// Token: 0x06030E70 RID: 200304 RVA: 0x00B5AC8C File Offset: 0x00B58E8C
		[return: Nullable(2)]
		private unsafe static ULGUIBehaviour GetActorBehavior(AActor actor)
		{
			ULGUIBehaviour ulguibehaviour = actor.GetComponentByClass(UUISelectableComponent.StaticClass()) as UUISelectableComponent;
			if (ulguibehaviour == null)
			{
				ulguibehaviour = (actor.GetComponentByClass(UUIScrollViewComponent.StaticClass()) as UUIScrollViewComponent);
			}
			if (ulguibehaviour == null)
			{
				ulguibehaviour = (actor.GetComponentByClass(UUIDraggableComponent.StaticClass()) as UUIDraggableComponent);
			}
			if (ulguibehaviour == null)
			{
				UUIItem uuiitem = actor.GetComponentByClass(UUIItem.StaticClass()) as UUIItem;
				AUIBaseActor actor2 = ((uuiitem != null) ? uuiitem.GetOwner() : null) as AUIBaseActor;
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiNavigation;
				ELogAuthor author = ELogAuthor.SYB;
				string message = "监听组件挂载节点获取不到交互组件";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("节点名", (uuiitem != null) ? uuiitem.displayName : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("节点路径", LguiUtil.Instance.GetActorFullPath(actor2));
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			return ulguibehaviour;
		}

		// Token: 0x06030E71 RID: 200305 RVA: 0x00B5AD7B File Offset: 0x00B58F7B
		public static void RegisterNavigationBehavior(string type, Type ctor)
		{
			NavigationSelectableCreator.NavigationBehaviorMap[type] = ctor;
		}

		// Token: 0x06030E72 RID: 200306 RVA: 0x00B5AD8C File Offset: 0x00B58F8C
		[return: Nullable(2)]
		public static NavigationSelectableBase CreateNavigationBehavior([Nullable(2)] AActor actor, string tag, List<string> paramList)
		{
			if (actor == null)
			{
				return null;
			}
			ULGUIBehaviour actorBehavior = NavigationSelectableCreator.GetActorBehavior(actor);
			if (actorBehavior == null)
			{
				return null;
			}
			string text = tag;
			Type type;
			if (string.IsNullOrEmpty(tag) || !NavigationSelectableCreator.NavigationBehaviorMap.TryGetValue(tag, out type))
			{
				ValueTuple<Type, string> baseBehaviorCtorData = NavigationSelectableCreator.GetBaseBehaviorCtorData(actorBehavior);
				Type item = baseBehaviorCtorData.Item1;
				string item2 = baseBehaviorCtorData.Item2;
				type = item;
				text = item2;
			}
			return Activator.CreateInstance(type, new object[]
			{
				actorBehavior,
				text,
				paramList
			}) as NavigationSelectableBase;
		}

		// Token: 0x06030E73 RID: 200307 RVA: 0x00B5ADF5 File Offset: 0x00B58FF5
		public static void CreateStaticDefaultValue()
		{
			NavigationSelectableCreator._navigationBehaviorMap = new Dictionary<string, Type>();
		}

		// Token: 0x06030E74 RID: 200308 RVA: 0x00B5AE01 File Offset: 0x00B59001
		public static void ResetStaticDefaultValue()
		{
			NavigationSelectableCreator._navigationBehaviorMap = null;
		}

		// Token: 0x0401A3D9 RID: 107481
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private static Dictionary<string, Type> _navigationBehaviorMap;
	}
}
