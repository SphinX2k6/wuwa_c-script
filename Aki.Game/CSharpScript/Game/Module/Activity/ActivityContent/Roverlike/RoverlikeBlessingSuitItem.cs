using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005073 RID: 20595
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoverlikeBlessingSuitItem : GridProxyAbstract<IRoverlikeBlessingSuitData>
	{
		// Token: 0x06033913 RID: 211219 RVA: 0x00E704CD File Offset: 0x00E6E6CD
		public void BindOnSuitClick(Action<IRoverlikeBlessingSuitData> callback)
		{
			this.OnSuitClick = callback;
		}

		// Token: 0x06033914 RID: 211220 RVA: 0x00E704D8 File Offset: 0x00E6E6D8
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

		// Token: 0x06033915 RID: 211221 RVA: 0x00E70604 File Offset: 0x00E6E804
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

		// Token: 0x06033916 RID: 211222 RVA: 0x00E706CD File Offset: 0x00E6E8CD
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

		// Token: 0x06033917 RID: 211223 RVA: 0x00E706ED File Offset: 0x00E6E8ED
		private RoverlikeBlessingSuitBlessItem CreateSkillItem()
		{
			return new RoverlikeBlessingSuitBlessItem();
		}

		// Token: 0x06033918 RID: 211224 RVA: 0x00E706F4 File Offset: 0x00E6E8F4
		private void RefreshSkillLayout(List<int> blessingIdList)
		{
			this.SkillLayout.RefreshByData(blessingIdList, null, false);
		}

		// Token: 0x06033919 RID: 211225 RVA: 0x00E70704 File Offset: 0x00E6E904
		protected override void OnStart()
		{
			this.SkillLayout = new GenericLayout<RoverlikeBlessingSuitBlessItem, int>(base.GetHorizontalLayout(3), new Func<RoverlikeBlessingSuitBlessItem>(this.CreateSkillItem), null, false, true);
		}

		// Token: 0x0603391A RID: 211226 RVA: 0x00E70727 File Offset: 0x00E6E927
		protected override void OnBeforeDestroy()
		{
			this.OnSuitClick = null;
		}

		// Token: 0x0401B5F9 RID: 112121
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RoverlikeBlessingSuitBlessItem, int> SkillLayout;

		// Token: 0x0401B5FA RID: 112122
		[Nullable(2)]
		private IRoverlikeBlessingSuitData CurrentData;

		// Token: 0x0401B5FB RID: 112123
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<IRoverlikeBlessingSuitData> OnSuitClick;

		// Token: 0x0200AD3A RID: 44346
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403589B RID: 219291
			public const int BtnRole = 0;

			// Token: 0x0403589C RID: 219292
			public const int TxtRoleName = 1;

			// Token: 0x0403589D RID: 219293
			public const int TexRole = 2;

			// Token: 0x0403589E RID: 219294
			public const int SkillLayout = 3;

			// Token: 0x0403589F RID: 219295
			public const int SkillItem = 4;

			// Token: 0x040358A0 RID: 219296
			public const int TexIconType = 5;
		}
	}
}
