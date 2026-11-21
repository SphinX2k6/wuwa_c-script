using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x02005179 RID: 20857
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TabGridItem : GridProxyAbstract<MotorChallengePlayData>
	{
		// Token: 0x0603415C RID: 213340 RVA: 0x00E92199 File Offset: 0x00E90399
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x0603415D RID: 213341 RVA: 0x00E921D4 File Offset: 0x00E903D4
		protected override UniTask OnBeforeStartAsync()
		{
			TabGridItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TabGridItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603415E RID: 213342 RVA: 0x00E92217 File Offset: 0x00E90417
		public void SetItemNewVisible(bool bVisible)
		{
			if (!this.Data.IsUnlock)
			{
				return;
			}
			this.NormalToggle.SetItemNewVisible(bVisible);
		}

		// Token: 0x0603415F RID: 213343 RVA: 0x00E92234 File Offset: 0x00E90434
		public override void Refresh(MotorChallengePlayData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			if (data.IsUnlock)
			{
				this.NormalToggle.Refresh(data);
			}
			else
			{
				this.LockToggle.Refresh(data);
			}
			if (this.Data.IsUnlock)
			{
				this.NormalToggle.SetIsSelect(isSelected, false);
			}
			else
			{
				this.LockToggle.SetIsSelect(isSelected, false);
			}
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(data.IsUnlock);
			}
			UUIItem item2 = base.GetItem(1);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(!data.IsUnlock);
		}

		// Token: 0x06034160 RID: 213344 RVA: 0x00E922C5 File Offset: 0x00E904C5
		public override void OnSelected(bool fireEvent)
		{
			if (this.Data.IsUnlock)
			{
				this.NormalToggle.SetIsSelect(true, fireEvent);
				return;
			}
			this.LockToggle.SetIsSelect(true, fireEvent);
		}

		// Token: 0x0401B964 RID: 112996
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Action<MotorChallengePlayData, MenuTabToggleItem> OnChildToggleCallback;

		// Token: 0x0401B965 RID: 112997
		private MenuTabToggleItem NormalToggle;

		// Token: 0x0401B966 RID: 112998
		private MenuTabToggleItem LockToggle;

		// Token: 0x0401B967 RID: 112999
		[Nullable(2)]
		private MotorChallengePlayData Data;
	}
}
