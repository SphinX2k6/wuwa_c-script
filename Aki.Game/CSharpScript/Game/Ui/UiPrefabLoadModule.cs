using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046DA RID: 18138
	[NullableContext(1)]
	[Nullable(0)]
	public class UiPrefabLoadModule
	{
		// Token: 0x0602EC9F RID: 191647 RVA: 0x00AD5474 File Offset: 0x00AD3674
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public UniTask<AActor> LoadPrefabAsync(string path, [Nullable(2)] UUIItem parent, string memoryTag = "js_undefined")
		{
			UiPrefabLoadModule.<LoadPrefabAsync>d__1 <LoadPrefabAsync>d__;
			<LoadPrefabAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<AActor>.Create();
			<LoadPrefabAsync>d__.<>4__this = this;
			<LoadPrefabAsync>d__.path = path;
			<LoadPrefabAsync>d__.parent = parent;
			<LoadPrefabAsync>d__.memoryTag = memoryTag;
			<LoadPrefabAsync>d__.<>1__state = -1;
			<LoadPrefabAsync>d__.<>t__builder.Start<UiPrefabLoadModule.<LoadPrefabAsync>d__1>(ref <LoadPrefabAsync>d__);
			return <LoadPrefabAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602ECA0 RID: 191648 RVA: 0x00AD54D0 File Offset: 0x00AD36D0
		public void Clear()
		{
			foreach (KeyValuePair<int, string> keyValuePair in this.PrefabIdSet)
			{
				int key = keyValuePair.Key;
				string value = keyValuePair.Value;
				ResourceSystem.Instance.CancelAsyncLoad(key);
			}
			this.PrefabIdSet.Clear();
		}

		// Token: 0x0401974A RID: 104266
		private readonly Dictionary<int, string> PrefabIdSet = new Dictionary<int, string>();
	}
}
