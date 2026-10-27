using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Manufacture.Common;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Compose.View
{
	// Token: 0x02005670 RID: 22128
	[NullableContext(2)]
	[Nullable(0)]
	public class ProficiencyView : UiPanelBase
	{
		// Token: 0x060384C4 RID: 230596 RVA: 0x00D5A29C File Offset: 0x00D5849C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnChangeRoleClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060384C5 RID: 230597 RVA: 0x00D5A384 File Offset: 0x00D58584
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(base.GetButton(2).RootUIComp);
		}

		// Token: 0x060384C6 RID: 230598 RVA: 0x00D5A3A2 File Offset: 0x00D585A2
		protected override void OnBeforeDestroy()
		{
			this.SequencePlayer.Clear();
		}

		// Token: 0x060384C7 RID: 230599 RVA: 0x00D5A3AF File Offset: 0x00D585AF
		private void OnChangeRoleClick()
		{
			if (this.ChangeClickCall != null)
			{
				this.ChangeClickCall();
			}
		}

		// Token: 0x060384C8 RID: 230600 RVA: 0x00D5A3C4 File Offset: 0x00D585C4
		[NullableContext(1)]
		public void BindChangeRoleClick(Action func)
		{
			this.ChangeClickCall = func;
		}

		// Token: 0x060384C9 RID: 230601 RVA: 0x00D5A3D0 File Offset: 0x00D585D0
		public void SetExpNum(int count, int single, int sum, int times)
		{
			int num = single * sum;
			int num2 = count * single;
			int num3 = num - num2;
			string str = StringUtils.Format(TextConfig.Instance.GetTextById("CumulativeProficiency"), new string[]
			{
				num2.ToString(),
				num.ToString()
			});
			if (num3 > 0)
			{
				int val = Math.Min(num3, single * times);
				string textById = TextConfig.Instance.GetTextById("AddProficiency");
				string[] array = new string[1];
				int num4 = 0;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendLiteral("+");
				defaultInterpolatedStringHandler.AppendFormatted<int>(Math.Min(val, num3));
				array[num4] = defaultInterpolatedStringHandler.ToStringAndClear();
				string newText = StringUtils.Format(textById, array) + " (" + str + ")";
				base.GetText(0).SetText(newText, true);
				return;
			}
			string newText2 = StringUtils.Format(TextConfig.Instance.GetTextById("AddProficiency"), new string[]
			{
				""
			}) + " (" + str + ")";
			base.GetText(0).SetText(newText2, true);
		}

		// Token: 0x060384CA RID: 230602 RVA: 0x00D5A4D5 File Offset: 0x00D586D5
		public void SetExpVisible(bool visible)
		{
			base.GetText(0).SetUIActive(visible);
		}

		// Token: 0x060384CB RID: 230603 RVA: 0x00D5A4E4 File Offset: 0x00D586E4
		public void SetRoleTexture(int roleId, int itemId)
		{
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleId, true);
			base.SetRoleIcon(roleDataById.GetRoleConfig().RoleHeadIconLarge, base.GetTexture(1), roleId, null, null);
			if (CommonManager.Instance.CheckIsBuffEx(roleId, itemId))
			{
				if (this.SequencePlayer.GetCurrentSequence() != null)
				{
					this.SequencePlayer.ReplaySequenceByKey("Show");
					return;
				}
				this.SequencePlayer.PlayLevelSequenceByName("Show", false, null, false);
				return;
			}
			else
			{
				LevelSequencePlayer sequencePlayer = this.SequencePlayer;
				if (sequencePlayer == null)
				{
					return;
				}
				sequencePlayer.StopCurrentSequence(false, true);
				return;
			}
		}

		// Token: 0x060384CC RID: 230604 RVA: 0x00D5A580 File Offset: 0x00D58780
		public void SetTypeContent(string content = null)
		{
			UUIText text = base.GetText(3);
			if (!string.IsNullOrEmpty(content))
			{
				text.SetUIActive(true);
				text.SetText(content, true);
				return;
			}
			text.SetUIActive(false);
		}

		// Token: 0x0401D98F RID: 121231
		private Action ChangeClickCall;

		// Token: 0x0401D990 RID: 121232
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0200B830 RID: 47152
		[NullableContext(0)]
		private class EProficiencyViewComponents
		{
			// Token: 0x04037BDC RID: 228316
			public const int TxtAddNum = 0;

			// Token: 0x04037BDD RID: 228317
			public const int TexRole = 1;

			// Token: 0x04037BDE RID: 228318
			public const int BtnChange = 2;

			// Token: 0x04037BDF RID: 228319
			public const int TxtType = 3;
		}
	}
}
