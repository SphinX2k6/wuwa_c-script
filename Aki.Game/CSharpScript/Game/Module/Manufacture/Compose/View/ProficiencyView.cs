using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Manufacture.Common;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Compose.View
{
	// Token: 0x02004646 RID: 17990
	[NullableContext(2)]
	[Nullable(0)]
	public class ProficiencyView : UiPanelBase
	{
		// Token: 0x0602D3C1 RID: 185281 RVA: 0x00CA839C File Offset: 0x00CA659C
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

		// Token: 0x0602D3C2 RID: 185282 RVA: 0x00CA8484 File Offset: 0x00CA6684
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(base.GetButton(2).RootUIComp);
		}

		// Token: 0x0602D3C3 RID: 185283 RVA: 0x00CA84A2 File Offset: 0x00CA66A2
		protected override void OnBeforeDestroy()
		{
			this.SequencePlayer.Clear();
		}

		// Token: 0x0602D3C4 RID: 185284 RVA: 0x00CA84AF File Offset: 0x00CA66AF
		private void OnChangeRoleClick()
		{
			if (this.ChangeClickCall != null)
			{
				this.ChangeClickCall();
			}
		}

		// Token: 0x0602D3C5 RID: 185285 RVA: 0x00CA84C4 File Offset: 0x00CA66C4
		[NullableContext(1)]
		public void BindChangeRoleClick(Action func)
		{
			this.ChangeClickCall = func;
		}

		// Token: 0x0602D3C6 RID: 185286 RVA: 0x00CA84D0 File Offset: 0x00CA66D0
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

		// Token: 0x0602D3C7 RID: 185287 RVA: 0x00CA85D5 File Offset: 0x00CA67D5
		public void SetExpVisible(bool visible)
		{
			base.GetText(0).SetUIActive(visible);
		}

		// Token: 0x0602D3C8 RID: 185288 RVA: 0x00CA85E4 File Offset: 0x00CA67E4
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

		// Token: 0x0602D3C9 RID: 185289 RVA: 0x00CA8680 File Offset: 0x00CA6880
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

		// Token: 0x0401841A RID: 99354
		private Action ChangeClickCall;

		// Token: 0x0401841B RID: 99355
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0200A258 RID: 41560
		[NullableContext(0)]
		private class EProficiencyViewComponents
		{
			// Token: 0x040325FA RID: 206330
			public const int TxtAddNum = 0;

			// Token: 0x040325FB RID: 206331
			public const int TexRole = 1;

			// Token: 0x040325FC RID: 206332
			public const int BtnChange = 2;

			// Token: 0x040325FD RID: 206333
			public const int TxtType = 3;
		}
	}
}
