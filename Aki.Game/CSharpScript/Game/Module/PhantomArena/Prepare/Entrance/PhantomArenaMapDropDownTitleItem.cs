using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x02004147 RID: 16711
	public class PhantomArenaMapDropDownTitleItem : TitleItemBase<int>
	{
		// Token: 0x0602A443 RID: 173123 RVA: 0x00BEF2F2 File Offset: 0x00BED4F2
		[NullableContext(1)]
		public PhantomArenaMapDropDownTitleItem(UUIItem uiItem) : base(uiItem)
		{
		}

		// Token: 0x0602A444 RID: 173124 RVA: 0x00BEF2FB File Offset: 0x00BED4FB
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText))
			};
		}

		// Token: 0x0602A445 RID: 173125 RVA: 0x00BEF320 File Offset: 0x00BED520
		[NullableContext(1)]
		public override void ShowTemp(int mapId, DropDownItemBase<int> selectedItemObj)
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
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), mapName, new <>z__ReadOnlyArray<object>(new object[]
			{
				num,
				num2
			}));
		}

		// Token: 0x02009D21 RID: 40225
		private class EPhantomArenaMapDropDownTitleItemComp
		{
			// Token: 0x04030DB4 RID: 200116
			public const int Title = 0;
		}
	}
}
