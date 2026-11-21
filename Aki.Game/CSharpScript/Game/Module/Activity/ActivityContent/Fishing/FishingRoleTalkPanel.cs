using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200554C RID: 21836
	public class FishingRoleTalkPanel : UiPanelBase
	{
		// Token: 0x060362A4 RID: 221860 RVA: 0x00F1E498 File Offset: 0x00F1C698
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060362A5 RID: 221861 RVA: 0x00F1E501 File Offset: 0x00F1C701
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x060362A6 RID: 221862 RVA: 0x00F1E514 File Offset: 0x00F1C714
		public void SetRoleHead(int roleId)
		{
			base.SetRoleIcon(RoleConfig.Instance.GetRoleConfig(roleId).Value.RoleHeadIconCircle, base.GetTexture(0), roleId, null, null);
		}

		// Token: 0x060362A7 RID: 221863 RVA: 0x00F1E554 File Offset: 0x00F1C754
		[NullableContext(1)]
		public void SetTxtInfo(string textId, params object[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, args);
		}

		// Token: 0x060362A8 RID: 221864 RVA: 0x00F1E56C File Offset: 0x00F1C76C
		[NullableContext(1)]
		public void PlayAnim(string sequenceName, [Nullable(2)] Action callback = null)
		{
			CustomPromise<bool> stopPromise = new CustomPromise<bool>();
			this.LevelSequencePlayer.PlaySequenceAsync(sequenceName, stopPromise, false, false, null, false).ContinueWith(delegate()
			{
				Action callback2 = callback;
				if (callback2 == null)
				{
					return;
				}
				callback2();
			});
		}

		// Token: 0x0401C954 RID: 117076
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200B1D9 RID: 45529
		private class EComponentDefine
		{
			// Token: 0x04036F91 RID: 225169
			public const int TexRoleHead = 0;

			// Token: 0x04036F92 RID: 225170
			public const int TxtInfo = 1;
		}
	}
}
