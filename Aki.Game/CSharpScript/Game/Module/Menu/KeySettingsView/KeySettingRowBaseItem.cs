using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.KeySettingsView
{
	// Token: 0x02005465 RID: 21605
	public class KeySettingRowBaseItem : UiPanelBase, IDynamicScrollBaseItem<KeySettingRowData>
	{
		// Token: 0x06037244 RID: 225860 RVA: 0x00D11F50 File Offset: 0x00D10150
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x06037245 RID: 225861 RVA: 0x00D11FAC File Offset: 0x00D101AC
		[NullableContext(1)]
		public UniTask Init(UUIItem actor)
		{
			KeySettingRowBaseItem.<Init>d__2 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.actor = actor;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<KeySettingRowBaseItem.<Init>d__2>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06037246 RID: 225862 RVA: 0x00D11FF7 File Offset: 0x00D101F7
		public void ClearItem()
		{
		}

		// Token: 0x06037247 RID: 225863 RVA: 0x00D11FFC File Offset: 0x00D101FC
		[NullableContext(1)]
		public FVector2D GetItemSize(KeySettingRowData data)
		{
			Vector2D vector2D = Vector2D.Create(0.0, 0.0);
			UUIItem uuiitem = null;
			EKeySettingRowType rowType = data.GetRowType();
			if (rowType != EKeySettingRowType.KeyType)
			{
				if (rowType == EKeySettingRowType.KeySetting)
				{
					uuiitem = base.GetItem(2);
				}
			}
			else
			{
				uuiitem = base.GetItem(1);
			}
			if (uuiitem == null)
			{
				return vector2D.ToUeVector2D(false);
			}
			vector2D.X = (double)uuiitem.GetWidth();
			vector2D.Y = (double)uuiitem.GetHeight();
			return vector2D.ToUeVector2D(false);
		}

		// Token: 0x0200B6DB RID: 46811
		public class EChidType
		{
			// Token: 0x04037651 RID: 226897
			public const int Toggle = 0;

			// Token: 0x04037652 RID: 226898
			public const int TitleItem = 1;

			// Token: 0x04037653 RID: 226899
			public const int KeySettingItem = 2;
		}
	}
}
