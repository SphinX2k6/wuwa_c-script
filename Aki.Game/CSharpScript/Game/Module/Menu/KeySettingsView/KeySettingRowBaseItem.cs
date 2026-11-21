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
	// Token: 0x02004448 RID: 17480
	public class KeySettingRowBaseItem : UiPanelBase, IDynamicScrollBaseItem<KeySettingRowData>
	{
		// Token: 0x0602C18D RID: 180621 RVA: 0x00C61368 File Offset: 0x00C5F568
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x0602C18E RID: 180622 RVA: 0x00C613C4 File Offset: 0x00C5F5C4
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

		// Token: 0x0602C18F RID: 180623 RVA: 0x00C6140F File Offset: 0x00C5F60F
		public void ClearItem()
		{
		}

		// Token: 0x0602C190 RID: 180624 RVA: 0x00C61414 File Offset: 0x00C5F614
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

		// Token: 0x0200A113 RID: 41235
		public class EChidType
		{
			// Token: 0x040320A6 RID: 204966
			public const int Toggle = 0;

			// Token: 0x040320A7 RID: 204967
			public const int TitleItem = 1;

			// Token: 0x040320A8 RID: 204968
			public const int KeySettingItem = 2;
		}
	}
}
