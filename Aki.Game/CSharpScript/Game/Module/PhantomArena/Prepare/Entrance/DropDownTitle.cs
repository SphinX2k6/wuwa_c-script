using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x02004132 RID: 16690
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DropDownTitle : TitleItemBase<GymChallengeData>
	{
		// Token: 0x0602A341 RID: 172865 RVA: 0x00BEA9AD File Offset: 0x00BE8BAD
		public DropDownTitle(UUIItem uiItem) : base(uiItem)
		{
		}

		// Token: 0x0602A342 RID: 172866 RVA: 0x00BEA9B6 File Offset: 0x00BE8BB6
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText))
			};
		}

		// Token: 0x0602A343 RID: 172867 RVA: 0x00BEA9DC File Offset: 0x00BE8BDC
		public override void ShowTemp(GymChallengeData data, DropDownItemBase<GymChallengeData> selectedItemObj)
		{
			string textStringId = data.IsLast ? "PhantomBattle_1115" : "PhantomBattle_1114";
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textStringId, Array.Empty<object>());
		}
	}
}
