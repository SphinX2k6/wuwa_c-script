using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x02005162 RID: 20834
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DropDownTitle : TitleItemBase<GymChallengeData>
	{
		// Token: 0x06035445 RID: 218181 RVA: 0x00C9D47D File Offset: 0x00C9B67D
		public DropDownTitle(UUIItem uiItem) : base(uiItem)
		{
		}

		// Token: 0x06035446 RID: 218182 RVA: 0x00C9D486 File Offset: 0x00C9B686
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText))
			};
		}

		// Token: 0x06035447 RID: 218183 RVA: 0x00C9D4AC File Offset: 0x00C9B6AC
		public override void ShowTemp(GymChallengeData data, DropDownItemBase<GymChallengeData> selectedItemObj)
		{
			string textStringId = data.IsLast ? "PhantomBattle_1115" : "PhantomBattle_1114";
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textStringId, Array.Empty<object>());
		}
	}
}
