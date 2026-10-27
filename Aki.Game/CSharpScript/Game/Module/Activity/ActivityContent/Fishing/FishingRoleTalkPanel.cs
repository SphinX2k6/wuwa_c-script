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
	// Token: 0x020065CE RID: 26062
	public class FishingRoleTalkPanel : UiPanelBase
	{
		// Token: 0x060415DF RID: 267743 RVA: 0x00FD7458 File Offset: 0x00FD5658
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

		// Token: 0x060415E0 RID: 267744 RVA: 0x00FD74C1 File Offset: 0x00FD56C1
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x060415E1 RID: 267745 RVA: 0x00FD74D4 File Offset: 0x00FD56D4
		public void SetRoleHead(int roleId)
		{
			base.SetRoleIcon(RoleConfig.Instance.GetRoleConfig(roleId).Value.RoleHeadIconCircle, base.GetTexture(0), roleId, null, null);
		}

		// Token: 0x060415E2 RID: 267746 RVA: 0x00FD7514 File Offset: 0x00FD5714
		[NullableContext(1)]
		public void SetTxtInfo(string textId, params object[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, args);
		}

		// Token: 0x060415E3 RID: 267747 RVA: 0x00FD752C File Offset: 0x00FD572C
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

		// Token: 0x04022023 RID: 139299
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200C7F6 RID: 51190
		private class EComponentDefine
		{
			// Token: 0x0403C643 RID: 247363
			public const int TexRoleHead = 0;

			// Token: 0x0403C644 RID: 247364
			public const int TxtInfo = 1;
		}
	}
}
