using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x02004146 RID: 16710
	public class PhantomArenaMapDropDownItem : DropDownItemBase<int>
	{
		// Token: 0x0602A43F RID: 173119 RVA: 0x00BEF18D File Offset: 0x00BED38D
		[NullableContext(1)]
		public PhantomArenaMapDropDownItem(UUIItem uiItem) : base(uiItem)
		{
		}

		// Token: 0x0602A440 RID: 173120 RVA: 0x00BEF198 File Offset: 0x00BED398
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x0602A441 RID: 173121 RVA: 0x00BEF1F2 File Offset: 0x00BED3F2
		[NullableContext(2)]
		protected override UUIExtendToggle GetDropDownToggle()
		{
			return base.GetExtendToggle(0);
		}

		// Token: 0x0602A442 RID: 173122 RVA: 0x00BEF1FC File Offset: 0x00BED3FC
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

		// Token: 0x02009D20 RID: 40224
		private class EPhantomArenaMapDropDownItemComp
		{
			// Token: 0x04030DB1 RID: 200113
			public const int Toggle = 0;

			// Token: 0x04030DB2 RID: 200114
			public const int Content = 1;

			// Token: 0x04030DB3 RID: 200115
			public const int RedDot = 2;
		}
	}
}
