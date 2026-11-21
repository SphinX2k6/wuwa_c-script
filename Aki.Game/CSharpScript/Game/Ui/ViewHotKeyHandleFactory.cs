using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035CC RID: 13772
	[NullableContext(1)]
	[Nullable(0)]
	public class ViewHotKeyHandleFactory
	{
		// Token: 0x06023120 RID: 143648 RVA: 0x009F96B0 File Offset: 0x009F78B0
		public static ViewHotKeyHandle CreateViewHotKeyHandle(IOpenAndCloseViewHotKey parameters, string handleType)
		{
			Type typeFromHandle;
			if (!ViewHotKeyHandleFactory.ViewHotKeyHandleTypeMap.TryGetValue(handleType, out typeFromHandle))
			{
				typeFromHandle = typeof(ViewHotKeyHandle);
			}
			return (ViewHotKeyHandle)Activator.CreateInstance(typeFromHandle, new object[]
			{
				parameters
			});
		}

		// Token: 0x06023122 RID: 143650 RVA: 0x009F96F4 File Offset: 0x009F78F4
		// Note: this type is marked as 'beforefieldinit'.
		static ViewHotKeyHandleFactory()
		{
			Dictionary<string, Type> dictionary = new Dictionary<string, Type>();
			string key = EViewHotKeyHandleType.ViewHotKeyHandle.ToString();
			dictionary[key] = typeof(ViewHotKeyHandle);
			string key2 = EViewHotKeyHandleType.ViewHotKeyHandleRoulette.ToString();
			dictionary[key2] = typeof(ViewHotKeyHandleRoulette);
			string key3 = EViewHotKeyHandleType.ViewHotKeyHandleFunctionMenu.ToString();
			dictionary[key3] = typeof(ViewHotKeyHandleFunctionMenu);
			string key4 = EViewHotKeyHandleType.ViewHotKeyHandleMapView.ToString();
			dictionary[key4] = typeof(ViewHotKeyHandleMapView);
			string key5 = EViewHotKeyHandleType.ViewHotKeyHandleRoleRootView.ToString();
			dictionary[key5] = typeof(ViewHotKeyHandleRoleRootView);
			string key6 = EViewHotKeyHandleType.ViewHotKeyHandleTrapDefenseRoulette.ToString();
			dictionary[key6] = typeof(ViewHotKeyHandleTrapDefenseRoulette);
			string key7 = EViewHotKeyHandleType.ViewHotKeyHandleBackpackView.ToString();
			dictionary[key7] = typeof(ViewHotKeyHandleBackpackView);
			string key8 = EViewHotKeyHandleType.ViewHotKeyHandleQuestView.ToString();
			dictionary[key8] = typeof(ViewHotKeyHandleQuestView);
			string key9 = EViewHotKeyHandleType.ViewHotKeyHandleFormation.ToString();
			dictionary[key9] = typeof(ViewHotKeyHandleFormation);
			ViewHotKeyHandleFactory.ViewHotKeyHandleTypeMap = dictionary;
		}

		// Token: 0x04013CFD RID: 81149
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<string, Type> ViewHotKeyHandleTypeMap;
	}
}
