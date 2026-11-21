using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk
{
	// Token: 0x020057F7 RID: 22519
	[NullableContext(1)]
	[Nullable(0)]
	public class AdamFormationRoleSizeItem : UiPanelBase, IDynamicScrollBaseItem<AdamFormationRoleGroupInfo>
	{
		// Token: 0x060378FE RID: 227582 RVA: 0x00F87ED4 File Offset: 0x00F860D4
		public UniTask Init(UUIItem actor)
		{
			AdamFormationRoleSizeItem.<Init>d__1 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.actor = actor;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<AdamFormationRoleSizeItem.<Init>d__1>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x060378FF RID: 227583 RVA: 0x00F87F20 File Offset: 0x00F86120
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIGridLayout)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIItem))
			};
		}

		// Token: 0x06037900 RID: 227584 RVA: 0x00F87FA8 File Offset: 0x00F861A8
		public FVector2D GetItemSize(AdamFormationRoleGroupInfo data)
		{
			if (this.ItemSizeVector == null)
			{
				this.ItemSizeVector = Vector2D.Create();
			}
			if (data.IsTitleType)
			{
				UUIItem item = base.GetItem(2);
				this.ItemSizeVector.Set((double)item.GetWidth(), (double)item.GetHeight());
				return this.ItemSizeVector.ToUeVector2D(false);
			}
			TWeakObjectPtr<UUIItem> rootUIComp = base.GetGridLayout(0).RootUIComp;
			this.ItemSizeVector.Set((double)rootUIComp.Get().GetWidth(), (double)rootUIComp.Get().GetHeight());
			return this.ItemSizeVector.ToUeVector2D(false);
		}

		// Token: 0x06037901 RID: 227585 RVA: 0x00F8803C File Offset: 0x00F8623C
		public void ClearItem()
		{
		}

		// Token: 0x0401D4FE RID: 120062
		[Nullable(2)]
		private Vector2D ItemSizeVector;
	}
}
