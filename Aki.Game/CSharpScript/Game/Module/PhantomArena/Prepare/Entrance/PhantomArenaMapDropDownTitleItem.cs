using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x02005177 RID: 20855
	public class PhantomArenaMapDropDownTitleItem : TitleItemBase<int>
	{
		// Token: 0x06035547 RID: 218439 RVA: 0x00CA1D76 File Offset: 0x00C9FF76
		[NullableContext(1)]
		public PhantomArenaMapDropDownTitleItem(UUIItem uiItem) : base(uiItem)
		{
		}

		// Token: 0x06035548 RID: 218440 RVA: 0x00CA1D7F File Offset: 0x00C9FF7F
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText))
			};
		}

		// Token: 0x06035549 RID: 218441 RVA: 0x00CA1DA4 File Offset: 0x00C9FFA4
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

		// Token: 0x0200B2E7 RID: 45799
		private class EPhantomArenaMapDropDownTitleItemComp
		{
			// Token: 0x0403635D RID: 222045
			public const int Title = 0;
		}
	}
}
