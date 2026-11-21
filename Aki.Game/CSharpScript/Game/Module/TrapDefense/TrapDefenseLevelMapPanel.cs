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
	// Token: 0x02003A56 RID: 14934
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseLevelMapPanel : UiPanelBase
	{
		// Token: 0x06026625 RID: 157221 RVA: 0x00AC0A1C File Offset: 0x00ABEC1C
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

		// Token: 0x06026626 RID: 157222 RVA: 0x00AC0A67 File Offset: 0x00ABEC67
		protected override void OnBeforeCreate()
		{
		}

		// Token: 0x06026627 RID: 157223 RVA: 0x00AC0A6C File Offset: 0x00ABEC6C
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

		// Token: 0x06026628 RID: 157224 RVA: 0x00AC0B54 File Offset: 0x00ABED54
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseLevelMapPanel.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseLevelMapPanel.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026629 RID: 157225 RVA: 0x00AC0B97 File Offset: 0x00ABED97
		protected override void OnStart()
		{
		}

		// Token: 0x0602662A RID: 157226 RVA: 0x00AC0B99 File Offset: 0x00ABED99
		protected override void OnBeforeShow()
		{
		}

		// Token: 0x0602662B RID: 157227 RVA: 0x00AC0B9B File Offset: 0x00ABED9B
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x0602662C RID: 157228 RVA: 0x00AC0BA0 File Offset: 0x00ABEDA0
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

		// Token: 0x0602662D RID: 157229 RVA: 0x00AC0C3C File Offset: 0x00ABEE3C
		public void OnClickBtnMonsterDesc()
		{
			TrapDefenseModel.Instance.OpenViewMonster(new int?(this.LevelData.Config.InstId), null, new bool?(this.IsInstance));
		}

		// Token: 0x040150ED RID: 86253
		public TrapDefenseLevelData LevelData;

		// Token: 0x040150EE RID: 86254
		public bool IsInstance;

		// Token: 0x02009626 RID: 38438
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x0402EE16 RID: 192022
			public const int TextureMap = 0;

			// Token: 0x0402EE17 RID: 192023
			public const int BtnMonsterDesc = 1;

			// Token: 0x0402EE18 RID: 192024
			public const int TextTitle = 2;

			// Token: 0x0402EE19 RID: 192025
			public const int TextDesc = 3;
		}
	}
}
