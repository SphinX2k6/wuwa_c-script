using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x02005176 RID: 20854
	public class PhantomArenaMapDropDownItem : DropDownItemBase<int>
	{
		// Token: 0x06035543 RID: 218435 RVA: 0x00CA1C11 File Offset: 0x00C9FE11
		[NullableContext(1)]
		public PhantomArenaMapDropDownItem(UUIItem uiItem) : base(uiItem)
		{
		}

		// Token: 0x06035544 RID: 218436 RVA: 0x00CA1C1C File Offset: 0x00C9FE1C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x06035545 RID: 218437 RVA: 0x00CA1C76 File Offset: 0x00C9FE76
		[NullableContext(2)]
		protected override UUIExtendToggle GetDropDownToggle()
		{
			return base.GetExtendToggle(0);
		}

		// Token: 0x06035546 RID: 218438 RVA: 0x00CA1C80 File Offset: 0x00C9FE80
		protected override void OnShowDropDownItemBase(int mapId)
		{
			PhantomArenaConfig instance = PhantomArenaConfig.Instance;
			PhantomBattleMapParam? phantomBattleMapParam = (instance != null) ? instance.GetPhantomBattleMapParamById(mapId) : null;
			if (phantomBattleMapParam == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module = ELogModule.PhantomArena;
				ELogAuthor author = ELogAuthor.CB;
				string message = "对应mapId的MapParam为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("mapId", mapId);
				instance2.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			string mapName = phantomBattleMapParam.Value.MapName;
			PhantomArenaModel instance3 = PhantomArenaModel.Instance;
			int? num = (instance3 != null) ? new int?(instance3.GetPermanentFinishedChallengeCount(mapId)) : null;
			PhantomArenaModel instance4 = PhantomArenaModel.Instance;
			int? num2 = (instance4 != null) ? new int?(instance4.GetPermanentAllChallengeCount(mapId)) : null;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), mapName, new <>z__ReadOnlyArray<object>(new object[]
			{
				num,
				num2
			}));
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x0200B2E6 RID: 45798
		private class EPhantomArenaMapDropDownItemComp
		{
			// Token: 0x0403635A RID: 222042
			public const int Toggle = 0;

			// Token: 0x0403635B RID: 222043
			public const int Content = 1;

			// Token: 0x0403635C RID: 222044
			public const int RedDot = 2;
		}
	}
}
