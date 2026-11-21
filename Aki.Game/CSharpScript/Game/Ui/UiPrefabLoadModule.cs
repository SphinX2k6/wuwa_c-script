using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200360A RID: 13834
	[NullableContext(1)]
	[Nullable(0)]
	public class UiPrefabLoadModule
	{
		// Token: 0x060233D9 RID: 144345 RVA: 0x00A02F18 File Offset: 0x00A01118
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

		// Token: 0x060233DA RID: 144346 RVA: 0x00A02F74 File Offset: 0x00A01174
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

		// Token: 0x04013DE8 RID: 81384
		private readonly Dictionary<int, string> PrefabIdSet = new Dictionary<int, string>();
	}
}
