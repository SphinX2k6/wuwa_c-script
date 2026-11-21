using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Forging.View
{
	// Token: 0x02004622 RID: 17954
	public class ProficiencyView : UiPanelBase
	{
		// Token: 0x0602D1AA RID: 184746 RVA: 0x00C9BB3C File Offset: 0x00C99D3C
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

		// Token: 0x0602D1AB RID: 184747 RVA: 0x00C9BC24 File Offset: 0x00C99E24
		public void OnChangeRoleClick()
		{
			if (this.ChangeClickCall != null)
			{
				this.ChangeClickCall();
			}
		}

		// Token: 0x0602D1AC RID: 184748 RVA: 0x00C9BC39 File Offset: 0x00C99E39
		[NullableContext(1)]
		public void BindChangeRoleClick(Action func)
		{
			this.ChangeClickCall = func;
		}

		// Token: 0x0602D1AD RID: 184749 RVA: 0x00C9BC42 File Offset: 0x00C99E42
		public void SetExpNumVisible(bool visible)
		{
			base.GetText(0).SetUIActive(visible);
		}

		// Token: 0x0602D1AE RID: 184750 RVA: 0x00C9BC54 File Offset: 0x00C99E54
		public unsafe void SetExpNum(int count, int single, int sum, int times)
		{
			int num = single * sum;
			int num2 = count * single;
			if (num2 != num)
			{
				string textById = TextConfig.Instance.GetTextById("AddProficiency");
				string[] array = new string[1];
				int num3 = 0;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendLiteral("+");
				defaultInterpolatedStringHandler.AppendFormatted<int>(single * times);
				array[num3] = defaultInterpolatedStringHandler.ToStringAndClear();
				string text = StringUtils.Format(textById, array);
				string text2 = StringUtils.Format(TextConfig.Instance.GetTextById("CumulativeProficiency"), new string[]
				{
					num2.ToString(),
					num.ToString()
				});
				<>y__InlineArray5<string> <>y__InlineArray = default(<>y__InlineArray5<string>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<string>, string>(ref <>y__InlineArray, 0) = text;
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<string>, string>(ref <>y__InlineArray, 1) = " ";
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<string>, string>(ref <>y__InlineArray, 2) = "(";
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<string>, string>(ref <>y__InlineArray, 3) = text2;
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<string>, string>(ref <>y__InlineArray, 4) = ")";
				string newText = string.Concat(<PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<string>, string>(<>y__InlineArray, 5));
				base.GetText(0).SetText(newText, true);
				return;
			}
			LguiUtil.Instance.SetLocalText(base.GetText(0), "Proficiency", Array.Empty<object>());
		}

		// Token: 0x0602D1AF RID: 184751 RVA: 0x00C9BD68 File Offset: 0x00C99F68
		public void SetRoleTexture(int roleId)
		{
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleId, true);
			base.SetRoleIcon(roleDataById.GetRoleConfig().RoleHeadIconLarge, base.GetTexture(1), roleId, null, null);
		}

		// Token: 0x0401834D RID: 99149
		[Nullable(2)]
		private Action ChangeClickCall;

		// Token: 0x0200A22A RID: 41514
		public class EProficiencyViewComponents
		{
			// Token: 0x040324C7 RID: 206023
			public const int TxtAddNum = 0;

			// Token: 0x040324C8 RID: 206024
			public const int TexRole = 1;

			// Token: 0x040324C9 RID: 206025
			public const int BtnChange = 2;

			// Token: 0x040324CA RID: 206026
			public const int TxtType = 3;
		}
	}
}
