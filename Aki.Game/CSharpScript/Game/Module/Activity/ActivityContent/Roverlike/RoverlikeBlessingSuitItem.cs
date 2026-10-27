using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020060F5 RID: 24821
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoverlikeBlessingSuitItem : GridProxyAbstract<IRoverlikeBlessingSuitData>
	{
		// Token: 0x0603EC51 RID: 257105 RVA: 0x00F296B9 File Offset: 0x00F278B9
		public void BindOnSuitClick(Action<IRoverlikeBlessingSuitData> callback)
		{
			this.OnSuitClick = callback;
		}

		// Token: 0x0603EC52 RID: 257106 RVA: 0x00F296C4 File Offset: 0x00F278C4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnBtnRoleClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603EC53 RID: 257107 RVA: 0x00F297F0 File Offset: 0x00F279F0
		public override void Refresh(IRoverlikeBlessingSuitData data, bool isSelected, int gridIndex)
		{
			this.CurrentData = data;
			RoverRogueBlessGroup? blessGroupConfig = RoverlikeConfig.Instance.GetBlessGroupConfig(data.SuitId);
			if (blessGroupConfig != null)
			{
				RoverRogueBlessRole? blessRoleConfig = RoverlikeConfig.Instance.GetBlessRoleConfig(blessGroupConfig.Value.BlessRoleId);
				if (blessRoleConfig != null)
				{
					LguiUtil.Instance.SetLocalTextNew(base.GetText(1), blessRoleConfig.Value.BlessRoleName, Array.Empty<object>());
					base.SetTextureShowUntilLoaded(blessRoleConfig.Value.Stand, base.GetTexture(2), null);
					base.SetTextureByPath(blessRoleConfig.Value.IconPath, base.GetTexture(5), null, null);
				}
			}
			this.RefreshSkillLayout(data.BlessingIdList);
		}

		// Token: 0x0603EC54 RID: 257108 RVA: 0x00F298B9 File Offset: 0x00F27AB9
		private void OnBtnRoleClick()
		{
			if (this.CurrentData != null)
			{
				Action<IRoverlikeBlessingSuitData> onSuitClick = this.OnSuitClick;
				if (onSuitClick == null)
				{
					return;
				}
				onSuitClick(this.CurrentData);
			}
		}

		// Token: 0x0603EC55 RID: 257109 RVA: 0x00F298D9 File Offset: 0x00F27AD9
		private RoverlikeBlessingSuitBlessItem CreateSkillItem()
		{
			return new RoverlikeBlessingSuitBlessItem();
		}

		// Token: 0x0603EC56 RID: 257110 RVA: 0x00F298E0 File Offset: 0x00F27AE0
		private void RefreshSkillLayout(List<int> blessingIdList)
		{
			this.SkillLayout.RefreshByData(blessingIdList, null, false);
		}

		// Token: 0x0603EC57 RID: 257111 RVA: 0x00F298F0 File Offset: 0x00F27AF0
		protected override void OnStart()
		{
			this.SkillLayout = new GenericLayout<RoverlikeBlessingSuitBlessItem, int>(base.GetHorizontalLayout(3), new Func<RoverlikeBlessingSuitBlessItem>(this.CreateSkillItem), null, false, true);
		}

		// Token: 0x0603EC58 RID: 257112 RVA: 0x00F29913 File Offset: 0x00F27B13
		protected override void OnBeforeDestroy()
		{
			this.OnSuitClick = null;
		}

		// Token: 0x04020CCC RID: 134348
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RoverlikeBlessingSuitBlessItem, int> SkillLayout;

		// Token: 0x04020CCD RID: 134349
		[Nullable(2)]
		private IRoverlikeBlessingSuitData CurrentData;

		// Token: 0x04020CCE RID: 134350
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<IRoverlikeBlessingSuitData> OnSuitClick;

		// Token: 0x0200C352 RID: 50002
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403AF36 RID: 241462
			public const int BtnRole = 0;

			// Token: 0x0403AF37 RID: 241463
			public const int TxtRoleName = 1;

			// Token: 0x0403AF38 RID: 241464
			public const int TexRole = 2;

			// Token: 0x0403AF39 RID: 241465
			public const int SkillLayout = 3;

			// Token: 0x0403AF3A RID: 241466
			public const int SkillItem = 4;

			// Token: 0x0403AF3B RID: 241467
			public const int TexIconType = 5;
		}
	}
}
