using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.SunSpirit.SunSpiritPerform;

namespace CSharpScript.Game.LevelGamePlay.SunSpirit.SunSpiritState
{
	// Token: 0x020069FE RID: 27134
	public class SunSpiritNoneState : SunSpiritBaseState
	{
		// Token: 0x060437FA RID: 276474 RVA: 0x01081AF3 File Offset: 0x0107FCF3
		[NullableContext(1)]
		public SunSpiritNoneState(SunSpiritData sunSpiritData) : base(ESunSpiritStateType.None, sunSpiritData)
		{
		}

		// Token: 0x060437FB RID: 276475 RVA: 0x01081B00 File Offset: 0x0107FD00
		protected override bool OnEnter()
		{
			if (!(this.SunSpiritData.GetSunSpiritPerform() is SunSpiritNonePerform))
			{
				Transform transform = Transform.Create();
				((ISunSpiritScenePerform)this.SunSpiritData.GetSunSpiritPerform()).GetTransform(transform);
				this.SunSpiritData.ChangeSunSpiritPerform(new SunSpiritNonePerform(this.SunSpiritData, transform));
			}
			return true;
		}
	}
}
