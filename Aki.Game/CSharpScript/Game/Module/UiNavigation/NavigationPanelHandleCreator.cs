using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020048FE RID: 18686
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationPanelHandleCreator : IStaticVariableResetter
	{
		// Token: 0x06030DAD RID: 200109 RVA: 0x00B58888 File Offset: 0x00B56A88
		static NavigationPanelHandleCreator()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(NavigationPanelHandleCreator.CreateStaticDefaultValue), new Action(NavigationPanelHandleCreator.ResetStaticDefaultValue));
		}

		// Token: 0x170079C0 RID: 31168
		// (get) Token: 0x06030DAE RID: 200110 RVA: 0x00B588A7 File Offset: 0x00B56AA7
		private static Dictionary<string, Type> SpecialPanelHandleMap
		{
			get
			{
				return NavigationPanelHandleCreator._specialPanelHandleMap;
			}
		}

		// Token: 0x06030DAF RID: 200111 RVA: 0x00B588AE File Offset: 0x00B56AAE
		public static void RegisterSpecialPanelHandle(string tag, Type ctor)
		{
			NavigationPanelHandleCreator.SpecialPanelHandleMap[tag] = ctor;
		}

		// Token: 0x06030DB0 RID: 200112 RVA: 0x00B588BC File Offset: 0x00B56ABC
		[return: Nullable(2)]
		public static SpecialPanelHandleBase GetPanelHandle(string tag)
		{
			Type type;
			if (!NavigationPanelHandleCreator.SpecialPanelHandleMap.TryGetValue(tag, out type))
			{
				type = NavigationPanelHandleCreator.SpecialPanelHandleMap["Default"];
				tag = "Default";
			}
			return Activator.CreateInstance(type, new object[]
			{
				tag
			}) as SpecialPanelHandleBase;
		}

		// Token: 0x06030DB1 RID: 200113 RVA: 0x00B58904 File Offset: 0x00B56B04
		public static void CreateStaticDefaultValue()
		{
			NavigationPanelHandleCreator._specialPanelHandleMap = new Dictionary<string, Type>();
		}

		// Token: 0x06030DB2 RID: 200114 RVA: 0x00B58910 File Offset: 0x00B56B10
		public static void ResetStaticDefaultValue()
		{
			NavigationPanelHandleCreator._specialPanelHandleMap = null;
		}

		// Token: 0x0401A3B9 RID: 107449
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private static Dictionary<string, Type> _specialPanelHandleMap;
	}
}
