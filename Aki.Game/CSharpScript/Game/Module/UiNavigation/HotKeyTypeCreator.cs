using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049EE RID: 18926
	public class HotKeyTypeCreator
	{
		// Token: 0x06031258 RID: 201304 RVA: 0x00B66814 File Offset: 0x00B64A14
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public static UniTask<HotKeyTypeBase> CreateHotKeyType(AActor actor, int typeId, bool isMultiKeyItem)
		{
			HotKeyTypeCreator.<CreateHotKeyType>d__0 <CreateHotKeyType>d__;
			<CreateHotKeyType>d__.<>t__builder = AsyncUniTaskMethodBuilder<HotKeyTypeBase>.Create();
			<CreateHotKeyType>d__.actor = actor;
			<CreateHotKeyType>d__.typeId = typeId;
			<CreateHotKeyType>d__.isMultiKeyItem = isMultiKeyItem;
			<CreateHotKeyType>d__.<>1__state = -1;
			<CreateHotKeyType>d__.<>t__builder.Start<HotKeyTypeCreator.<CreateHotKeyType>d__0>(ref <CreateHotKeyType>d__);
			return <CreateHotKeyType>d__.<>t__builder.Task;
		}
	}
}
