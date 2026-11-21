using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.SunSpirit.SunSpiritPerform;

namespace CSharpScript.Game.LevelGamePlay.SunSpirit.SunSpiritState
{
	// Token: 0x02005B5B RID: 23387
	public class SunSpiritNoneState : SunSpiritBaseState
	{
		// Token: 0x06039846 RID: 235590 RVA: 0x01026117 File Offset: 0x01024317
		[NullableContext(1)]
		public SunSpiritNoneState(SunSpiritData sunSpiritData) : base(ESunSpiritStateType.None, sunSpiritData)
		{
		}

		// Token: 0x06039847 RID: 235591 RVA: 0x01026124 File Offset: 0x01024324
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
