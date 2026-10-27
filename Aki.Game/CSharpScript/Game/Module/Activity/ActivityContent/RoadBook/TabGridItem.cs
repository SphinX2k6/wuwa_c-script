using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x020061FB RID: 25083
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TabGridItem : GridProxyAbstract<MotorChallengePlayData>
	{
		// Token: 0x0603F49B RID: 259227 RVA: 0x00F4B241 File Offset: 0x00F49441
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x0603F49C RID: 259228 RVA: 0x00F4B27C File Offset: 0x00F4947C
		protected override UniTask OnBeforeStartAsync()
		{
			TabGridItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TabGridItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F49D RID: 259229 RVA: 0x00F4B2BF File Offset: 0x00F494BF
		public void SetItemNewVisible(bool bVisible)
		{
			if (!this.Data.IsUnlock)
			{
				return;
			}
			this.NormalToggle.SetItemNewVisible(bVisible);
		}

		// Token: 0x0603F49E RID: 259230 RVA: 0x00F4B2DC File Offset: 0x00F494DC
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

		// Token: 0x0603F49F RID: 259231 RVA: 0x00F4B36D File Offset: 0x00F4956D
		public override void OnSelected(bool fireEvent)
		{
			if (this.Data.IsUnlock)
			{
				this.NormalToggle.SetIsSelect(true, fireEvent);
				return;
			}
			this.LockToggle.SetIsSelect(true, fireEvent);
		}

		// Token: 0x04021035 RID: 135221
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Action<MotorChallengePlayData, MenuTabToggleItem> OnChildToggleCallback;

		// Token: 0x04021036 RID: 135222
		private MenuTabToggleItem NormalToggle;

		// Token: 0x04021037 RID: 135223
		private MenuTabToggleItem LockToggle;

		// Token: 0x04021038 RID: 135224
		[Nullable(2)]
		private MotorChallengePlayData Data;
	}
}
