using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x02004140 RID: 16704
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class GymStarItem : GridProxyAbstract<GymChallengeData>
	{
		// Token: 0x0602A3CE RID: 173006 RVA: 0x00BEC800 File Offset: 0x00BEAA00
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUISprite))
			};
		}

		// Token: 0x0602A3CF RID: 173007 RVA: 0x00BEC839 File Offset: 0x00BEAA39
		[NullableContext(1)]
		public override void Refresh(GymChallengeData data, bool isSelected, int gridIndex)
		{
			base.GetSprite(0).SetUIActive(true);
			base.GetSprite(1).SetUIActive(data.State == EChallengeState.Finish);
		}

		// Token: 0x0602A3D0 RID: 173008 RVA: 0x00BEC85D File Offset: 0x00BEAA5D
		public override void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x0602A3D1 RID: 173009 RVA: 0x00BEC85F File Offset: 0x00BEAA5F
		public override void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x02009D0E RID: 40206
		private class EComponent
		{
			// Token: 0x04030D44 RID: 200004
			public const int SpriteBg = 0;

			// Token: 0x04030D45 RID: 200005
			public const int SpriteIcon = 1;
		}
	}
}
