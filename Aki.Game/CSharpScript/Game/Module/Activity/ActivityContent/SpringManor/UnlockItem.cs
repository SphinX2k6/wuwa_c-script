using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02004FFF RID: 20479
	public class UnlockItem : GridProxyAbstract<int>
	{
		// Token: 0x0603343F RID: 209983 RVA: 0x00E5F7E4 File Offset: 0x00E5D9E4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnButtonClick))
			};
		}

		// Token: 0x06033440 RID: 209984 RVA: 0x00E5F877 File Offset: 0x00E5DA77
		private void OnButtonClick()
		{
			if (this.SkipEntryId <= 0)
			{
				return;
			}
			SpringManorController instance = SpringManorController.Instance;
			if (instance == null)
			{
				return;
			}
			instance.ExecuteSkipEntry(this.SkipEntryId, this.OnTrackPositionCallback);
		}

		// Token: 0x06033441 RID: 209985 RVA: 0x00E5F8A0 File Offset: 0x00E5DAA0
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			this.SkipEntryId = data;
			SpringFestivalSkipEntry? skipEntryConfigById = SpringManorConfig.Instance.GetSkipEntryConfigById(data);
			if (skipEntryConfigById == null)
			{
				return;
			}
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.ShowTextNew(skipEntryConfigById.Value.Name);
			}
			bool flag = SpringManorModel.Instance.ActivityData.IsSkipEntryUnLock(data);
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(!flag);
			}
			if (!flag)
			{
				UUIButtonComponent button = base.GetButton(0);
				if (button == null)
				{
					return;
				}
				button.SetSelfInteractive(false);
				return;
			}
			else
			{
				bool flag2 = skipEntryConfigById.Value.JumpId > 0;
				bool flag3 = skipEntryConfigById.Value.TrackPositionLength > 0;
				bool flag4 = flag2 || flag3;
				UUIButtonComponent button2 = base.GetButton(0);
				if (button2 != null)
				{
					button2.SetSelfInteractive(flag4);
				}
				UUIItem item2 = base.GetItem(3);
				if (item2 == null)
				{
					return;
				}
				item2.SetAlpha(flag4 ? 1f : 0.3f);
				return;
			}
		}

		// Token: 0x0401B402 RID: 111618
		private const float ARROW_DISABLE_ALPHA = 0.3f;

		// Token: 0x0401B403 RID: 111619
		private int SkipEntryId;

		// Token: 0x0401B404 RID: 111620
		[Nullable(2)]
		public Action OnTrackPositionCallback;
	}
}
