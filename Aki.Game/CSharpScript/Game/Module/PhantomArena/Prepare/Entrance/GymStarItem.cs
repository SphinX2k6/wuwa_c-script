using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x02005170 RID: 20848
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class GymStarItem : GridProxyAbstract<GymChallengeData>
	{
		// Token: 0x060354D2 RID: 218322 RVA: 0x00C9F2B4 File Offset: 0x00C9D4B4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUISprite))
			};
		}

		// Token: 0x060354D3 RID: 218323 RVA: 0x00C9F2ED File Offset: 0x00C9D4ED
		[NullableContext(1)]
		public override void Refresh(GymChallengeData data, bool isSelected, int gridIndex)
		{
			base.GetSprite(0).SetUIActive(true);
			base.GetSprite(1).SetUIActive(data.State == EChallengeState.Finish);
		}

		// Token: 0x060354D4 RID: 218324 RVA: 0x00C9F311 File Offset: 0x00C9D511
		public override void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x060354D5 RID: 218325 RVA: 0x00C9F313 File Offset: 0x00C9D513
		public override void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x0200B2D4 RID: 45780
		private class EComponent
		{
			// Token: 0x040362ED RID: 221933
			public const int SpriteBg = 0;

			// Token: 0x040362EE RID: 221934
			public const int SpriteIcon = 1;
		}
	}
}
