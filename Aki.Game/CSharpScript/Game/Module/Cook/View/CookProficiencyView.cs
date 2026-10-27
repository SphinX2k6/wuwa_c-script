using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Cook.View
{
	// Token: 0x02005B1F RID: 23327
	[NullableContext(2)]
	[Nullable(0)]
	public class CookProficiencyView : UiPanelBase
	{
		// Token: 0x0603B0CB RID: 241867 RVA: 0x00E14110 File Offset: 0x00E12310
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
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(delegate()
			{
				this.OnChangeRoleClick();
			}));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603B0CC RID: 241868 RVA: 0x00E141F8 File Offset: 0x00E123F8
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(base.GetButton(2).GetRootComponent());
		}

		// Token: 0x0603B0CD RID: 241869 RVA: 0x00E14211 File Offset: 0x00E12411
		protected override void OnBeforeDestroy()
		{
			this.SequencePlayer.Clear();
		}

		// Token: 0x0603B0CE RID: 241870 RVA: 0x00E1421E File Offset: 0x00E1241E
		private void OnChangeRoleClick()
		{
			Action changeClickCall = this.ChangeClickCall;
			if (changeClickCall == null)
			{
				return;
			}
			changeClickCall();
		}

		// Token: 0x0603B0CF RID: 241871 RVA: 0x00E14230 File Offset: 0x00E12430
		[NullableContext(1)]
		public void BindChangeRoleClick(Action func)
		{
			this.ChangeClickCall = func;
		}

		// Token: 0x0603B0D0 RID: 241872 RVA: 0x00E1423C File Offset: 0x00E1243C
		public void SetExpNum(int cookCount, int single, int sum, int times)
		{
			int num = single * sum;
			int num2 = cookCount * single;
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

		// Token: 0x0603B0D1 RID: 241873 RVA: 0x00E14344 File Offset: 0x00E12544
		public void SetRoleTexture(int roleId, int itemId)
		{
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleId, true);
			base.SetRoleIcon(roleDataById.GetRoleConfig().RoleHeadIconLarge, base.GetTexture(1), roleId, null, null);
			if (CookController.Instance.CheckIsBuffEx(roleId, itemId))
			{
				if (this.SequencePlayer.GetCurrentSequence() == null)
				{
					this.SequencePlayer.PlayLevelSequenceByName("Show", false, null, false);
					return;
				}
				this.SequencePlayer.ReplaySequenceByKey("Show");
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

		// Token: 0x0603B0D2 RID: 241874 RVA: 0x00E143E0 File Offset: 0x00E125E0
		public void SetTypeContent(string content = null)
		{
			UUIText text = base.GetText(3);
			if (content != null)
			{
				text.SetUIActive(true);
				text.SetText(content, true);
				return;
			}
			text.SetUIActive(false);
		}

		// Token: 0x0401ECC4 RID: 126148
		private Action ChangeClickCall;

		// Token: 0x0401ECC5 RID: 126149
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0200BD57 RID: 48471
		[NullableContext(0)]
		private enum EProficiencyViewComponents
		{
			// Token: 0x040391B8 RID: 233912
			TxtAddNum,
			// Token: 0x040391B9 RID: 233913
			TexRole,
			// Token: 0x040391BA RID: 233914
			BtnChange,
			// Token: 0x040391BB RID: 233915
			TxtType
		}
	}
}
