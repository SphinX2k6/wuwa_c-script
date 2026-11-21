using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Item
{
	// Token: 0x02005635 RID: 22069
	public class DropCatchRoleBarItem : GridProxyAbstract<int>
	{
		// Token: 0x0603689D RID: 223389 RVA: 0x00F3867E File Offset: 0x00F3687E
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite))
			};
		}

		// Token: 0x0603689E RID: 223390 RVA: 0x00F386A1 File Offset: 0x00F368A1
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
		}

		// Token: 0x0603689F RID: 223391 RVA: 0x00F386A3 File Offset: 0x00F368A3
		public override UniTask RefreshAsync(int data, bool isSelected, int gridIndex)
		{
			return UniTask.CompletedTask;
		}
	}
}
