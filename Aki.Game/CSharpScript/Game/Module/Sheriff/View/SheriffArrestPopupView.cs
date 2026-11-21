using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Sheriff.View
{
	// Token: 0x02003C06 RID: 15366
	public class SheriffArrestPopupView : UiViewBase
	{
		// Token: 0x06027615 RID: 161301 RVA: 0x00B0981B File Offset: 0x00B07A1B
		[NullableContext(1)]
		public SheriffArrestPopupView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06027616 RID: 161302 RVA: 0x00B09824 File Offset: 0x00B07A24
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06027617 RID: 161303 RVA: 0x00B098B0 File Offset: 0x00B07AB0
		protected override void OnStart()
		{
			SheriffArrestPopupViewData sheriffArrestPopupViewData = this.OpenParam as SheriffArrestPopupViewData;
			if (sheriffArrestPopupViewData == null)
			{
				return;
			}
			int identity = SheriffModel.Instance.GetCriminalInfo(sheriffArrestPopupViewData.CriminalId).Identity;
			SheriffCriminal? criminalConfigById = SheriffConfig.Instance.GetCriminalConfigById(sheriffArrestPopupViewData.CriminalId);
			int id = (criminalConfigById != null) ? criminalConfigById.GetValueOrDefault().DropId : 0;
			Dictionary<int, int> dropPackagePreview = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreview(id);
			int num = 0;
			if (dropPackagePreview != null)
			{
				using (Dictionary<int, int>.Enumerator enumerator = dropPackagePreview.GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						KeyValuePair<int, int> keyValuePair = enumerator.Current;
						num = keyValuePair.Value;
					}
				}
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Sheriff_HudDesc_8", new <>z__ReadOnlySingleElementList<object>(num));
			SheriffIdentity? identityConfigById = SheriffConfig.Instance.GetIdentityConfigById(identity);
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(0), (identityConfigById != null) ? identityConfigById.GetValueOrDefault().Name : null, Array.Empty<object>());
			if (identityConfigById != null && !string.IsNullOrEmpty(identityConfigById.Value.IconConfirm))
			{
				base.SetTextureByPath(identityConfigById.Value.IconConfirm, base.GetTexture(2), null, null);
			}
		}

		// Token: 0x06027618 RID: 161304 RVA: 0x00B09A18 File Offset: 0x00B07C18
		protected override void OnFinishShow()
		{
			base.CloseMe(null);
		}

		// Token: 0x02009817 RID: 38935
		private static class EComponents
		{
			// Token: 0x0402F71E RID: 194334
			public const int TxtName = 0;

			// Token: 0x0402F71F RID: 194335
			public const int TxtTips = 1;

			// Token: 0x0402F720 RID: 194336
			public const int ImgIcon = 2;
		}
	}
}
