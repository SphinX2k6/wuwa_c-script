using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Item
{
	// Token: 0x020066E5 RID: 26341
	public class DropCatchRoleBarItem : GridProxyAbstract<int>
	{
		// Token: 0x06041D51 RID: 269649 RVA: 0x00FF727A File Offset: 0x00FF547A
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite))
			};
		}

		// Token: 0x06041D52 RID: 269650 RVA: 0x00FF729D File Offset: 0x00FF549D
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
		}

		// Token: 0x06041D53 RID: 269651 RVA: 0x00FF729F File Offset: 0x00FF549F
		public override UniTask RefreshAsync(int data, bool isSelected, int gridIndex)
		{
			return UniTask.CompletedTask;
		}
	}
}
