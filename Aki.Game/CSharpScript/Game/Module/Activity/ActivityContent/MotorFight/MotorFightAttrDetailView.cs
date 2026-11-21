using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x020053A1 RID: 21409
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorFightAttrDetailView : UiViewBase
	{
		// Token: 0x06035418 RID: 218136 RVA: 0x00EE0158 File Offset: 0x00EDE358
		public MotorFightAttrDetailView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06035419 RID: 218137 RVA: 0x00EE0178 File Offset: 0x00EDE378
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603541A RID: 218138 RVA: 0x00EE0204 File Offset: 0x00EDE404
		protected override UniTask OnBeforeStartAsync()
		{
			MotorFightAttrDetailView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorFightAttrDetailView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603541B RID: 218139 RVA: 0x00EE0248 File Offset: 0x00EDE448
		private List<MotorFightDetailAttrDetailData> GetAttrInfoByType(EMotorFightAttrShowType type)
		{
			List<MotorFightDetailAttrDetailData> result;
			if (this.AttrInfoMap.TryGetValue(type, out result))
			{
				return result;
			}
			if (this.AllAttrInfo.Count == 0)
			{
				this.AllAttrInfo = new List<MotorFightAttrShow>(MotorFightConfig.Instance.GetMotorFightAttrShow());
			}
			List<MotorFightDetailAttrDetailData> list = new List<MotorFightDetailAttrDetailData>();
			foreach (MotorFightAttrShow config in this.AllAttrInfo)
			{
				if ((type == EMotorFightAttrShowType.MainGun && config.ShowInMainGun) || (type == EMotorFightAttrShowType.Wingman && config.ShowInWingman) || (type == EMotorFightAttrShowType.Common && config.ShowInCommon))
				{
					MotorFightDetailAttrDetailData item = new MotorFightDetailAttrDetailData
					{
						Type = type,
						Config = config
					};
					list.Add(item);
				}
			}
			this.AttrInfoMap[type] = list;
			return list;
		}

		// Token: 0x0603541C RID: 218140 RVA: 0x00EE0320 File Offset: 0x00EDE520
		private void OnTabClickCallBack(EMotorFightAttrShowType type)
		{
			this.TabLayout.SelectGridProxyByKey(type, false);
			List<MotorFightDetailAttrDetailData> attrInfoByType = this.GetAttrInfoByType(type);
			GenericLayout<MotorFightDetailAttrItem, MotorFightDetailAttrDetailData> attrLayout = this.AttrLayout;
			if (attrLayout == null)
			{
				return;
			}
			attrLayout.RefreshByData(attrInfoByType, null, false);
		}

		// Token: 0x0603541D RID: 218141 RVA: 0x00EE035A File Offset: 0x00EDE55A
		private MotorFightAttrTabItem CreateTabItem()
		{
			return new MotorFightAttrTabItem
			{
				OnToggleClickCallBack = new Action<EMotorFightAttrShowType>(this.OnTabClickCallBack)
			};
		}

		// Token: 0x0603541E RID: 218142 RVA: 0x00EE0373 File Offset: 0x00EDE573
		private MotorFightDetailAttrItem CreateAttrItem()
		{
			return new MotorFightDetailAttrItem();
		}

		// Token: 0x0603541F RID: 218143 RVA: 0x00EE037A File Offset: 0x00EDE57A
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401C15F RID: 115039
		private readonly Dictionary<EMotorFightAttrShowType, List<MotorFightDetailAttrDetailData>> AttrInfoMap = new Dictionary<EMotorFightAttrShowType, List<MotorFightDetailAttrDetailData>>();

		// Token: 0x0401C160 RID: 115040
		private List<MotorFightAttrShow> AllAttrInfo = new List<MotorFightAttrShow>();

		// Token: 0x0401C161 RID: 115041
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401C162 RID: 115042
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<MotorFightAttrTabItem, EMotorFightAttrShowType> TabLayout;

		// Token: 0x0401C163 RID: 115043
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<MotorFightDetailAttrItem, MotorFightDetailAttrDetailData> AttrLayout;

		// Token: 0x0200B038 RID: 45112
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403674C RID: 223052
			public const int ItemCaption = 0;

			// Token: 0x0403674D RID: 223053
			public const int LayoutAttrInfo = 1;

			// Token: 0x0403674E RID: 223054
			public const int LayoutTab = 2;
		}
	}
}
