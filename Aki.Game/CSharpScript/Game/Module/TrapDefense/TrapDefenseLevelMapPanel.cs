using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004AAE RID: 19118
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseLevelMapPanel : UiPanelBase
	{
		// Token: 0x06031895 RID: 202901 RVA: 0x00B7CA68 File Offset: 0x00B7AC68
		public UniTask Init(UUIItem item)
		{
			TrapDefenseLevelMapPanel.<Init>d__3 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.item = item;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<TrapDefenseLevelMapPanel.<Init>d__3>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06031896 RID: 202902 RVA: 0x00B7CAB3 File Offset: 0x00B7ACB3
		protected override void OnBeforeCreate()
		{
		}

		// Token: 0x06031897 RID: 202903 RVA: 0x00B7CAB8 File Offset: 0x00B7ACB8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickBtnMonsterDesc));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06031898 RID: 202904 RVA: 0x00B7CBA0 File Offset: 0x00B7ADA0
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseLevelMapPanel.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseLevelMapPanel.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031899 RID: 202905 RVA: 0x00B7CBE3 File Offset: 0x00B7ADE3
		protected override void OnStart()
		{
		}

		// Token: 0x0603189A RID: 202906 RVA: 0x00B7CBE5 File Offset: 0x00B7ADE5
		protected override void OnBeforeShow()
		{
		}

		// Token: 0x0603189B RID: 202907 RVA: 0x00B7CBE7 File Offset: 0x00B7ADE7
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x0603189C RID: 202908 RVA: 0x00B7CBEC File Offset: 0x00B7ADEC
		public void UpdateData(TrapDefenseLevelData data)
		{
			this.LevelData = data;
			UUITexture uiMap = base.GetTexture(0);
			base.SetTextureByPath(data.GetPreviewMapResource(), uiMap, null, delegate(bool ret)
			{
				if (ret)
				{
					uiMap.SetSizeFromTexture();
				}
			});
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.ShowTextNew(ETrapDefenseTextKey.LevelDescTitle.ToString());
			}
			UUIText text2 = base.GetText(3);
			LguiUtil.Instance.SetLocalTextNew(text2, data.Config.DifficultyDesc, data.Config.DifficultyDescArgs());
		}

		// Token: 0x0603189D RID: 202909 RVA: 0x00B7CC88 File Offset: 0x00B7AE88
		public void OnClickBtnMonsterDesc()
		{
			TrapDefenseModel.Instance.OpenViewMonster(new int?(this.LevelData.Config.InstId), null, new bool?(this.IsInstance));
		}

		// Token: 0x0401A79B RID: 108443
		public TrapDefenseLevelData LevelData;

		// Token: 0x0401A79C RID: 108444
		public bool IsInstance;

		// Token: 0x0200AC06 RID: 44038
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04034465 RID: 214117
			public const int TextureMap = 0;

			// Token: 0x04034466 RID: 214118
			public const int BtnMonsterDesc = 1;

			// Token: 0x04034467 RID: 214119
			public const int TextTitle = 2;

			// Token: 0x04034468 RID: 214120
			public const int TextDesc = 3;
		}
	}
}
