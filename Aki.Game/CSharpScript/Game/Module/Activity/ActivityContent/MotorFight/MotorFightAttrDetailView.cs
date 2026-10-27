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
	// Token: 0x02006423 RID: 25635
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorFightAttrDetailView : UiViewBase
	{
		// Token: 0x06040757 RID: 264023 RVA: 0x00F991B8 File Offset: 0x00F973B8
		public MotorFightAttrDetailView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06040758 RID: 264024 RVA: 0x00F991D8 File Offset: 0x00F973D8
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

		// Token: 0x06040759 RID: 264025 RVA: 0x00F99264 File Offset: 0x00F97464
		protected override UniTask OnBeforeStartAsync()
		{
			MotorFightAttrDetailView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorFightAttrDetailView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604075A RID: 264026 RVA: 0x00F992A8 File Offset: 0x00F974A8
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

		// Token: 0x0604075B RID: 264027 RVA: 0x00F99380 File Offset: 0x00F97580
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

		// Token: 0x0604075C RID: 264028 RVA: 0x00F993BA File Offset: 0x00F975BA
		private MotorFightAttrTabItem CreateTabItem()
		{
			return new MotorFightAttrTabItem
			{
				OnToggleClickCallBack = new Action<EMotorFightAttrShowType>(this.OnTabClickCallBack)
			};
		}

		// Token: 0x0604075D RID: 264029 RVA: 0x00F993D3 File Offset: 0x00F975D3
		private MotorFightDetailAttrItem CreateAttrItem()
		{
			return new MotorFightDetailAttrItem();
		}

		// Token: 0x0604075E RID: 264030 RVA: 0x00F993DA File Offset: 0x00F975DA
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x04021830 RID: 137264
		private readonly Dictionary<EMotorFightAttrShowType, List<MotorFightDetailAttrDetailData>> AttrInfoMap = new Dictionary<EMotorFightAttrShowType, List<MotorFightDetailAttrDetailData>>();

		// Token: 0x04021831 RID: 137265
		private List<MotorFightAttrShow> AllAttrInfo = new List<MotorFightAttrShow>();

		// Token: 0x04021832 RID: 137266
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04021833 RID: 137267
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<MotorFightAttrTabItem, EMotorFightAttrShowType> TabLayout;

		// Token: 0x04021834 RID: 137268
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<MotorFightDetailAttrItem, MotorFightDetailAttrDetailData> AttrLayout;

		// Token: 0x0200C651 RID: 50769
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403BDEF RID: 245231
			public const int ItemCaption = 0;

			// Token: 0x0403BDF0 RID: 245232
			public const int LayoutAttrInfo = 1;

			// Token: 0x0403BDF1 RID: 245233
			public const int LayoutTab = 2;
		}
	}
}
