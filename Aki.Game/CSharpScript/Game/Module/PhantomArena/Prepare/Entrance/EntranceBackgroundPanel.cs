using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x0200412F RID: 16687
	public class EntranceBackgroundPanel : UiPanelBase
	{
		// Token: 0x0602A324 RID: 172836 RVA: 0x00BEA19C File Offset: 0x00BE839C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUITexture)),
				new ValueTuple<int, Type>(3, typeof(UUITexture)),
				new ValueTuple<int, Type>(4, typeof(UUITexture)),
				new ValueTuple<int, Type>(5, typeof(UUITexture))
			};
		}

		// Token: 0x0602A325 RID: 172837 RVA: 0x00BEA238 File Offset: 0x00BE8438
		public void RefreshBg(bool isStart, int level)
		{
			string a = PhantomArenaDefine.positionGymLevel[level - 1];
			if (a == "left")
			{
				this.SetLeft(isStart);
				return;
			}
			if (a == "middle")
			{
				this.SetMiddle(isStart);
				return;
			}
			if (!(a == "right"))
			{
				return;
			}
			this.SetRight(isStart);
		}

		// Token: 0x0602A326 RID: 172838 RVA: 0x00BEA290 File Offset: 0x00BE8490
		[NullableContext(1)]
		private void SetTextureById(string resourceId, [Nullable(2)] UUITexture icon)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			base.SetTextureByPath(resourcePath, icon, null, null);
		}

		// Token: 0x0602A327 RID: 172839 RVA: 0x00BEA2BC File Offset: 0x00BE84BC
		public void SetLeft(bool isStart)
		{
			UUITexture icon = isStart ? base.GetTexture(3) : base.GetTexture(0);
			UUITexture icon2 = isStart ? base.GetTexture(4) : base.GetTexture(1);
			UUITexture icon3 = isStart ? base.GetTexture(5) : base.GetTexture(2);
			this.SetTextureById("GymTabViewTextureBgLeftColor", icon);
			this.SetTextureById("GymTabViewTextureBgMiddleWhite", icon2);
			this.SetTextureById("GymTabViewTextureBgRightGray", icon3);
		}

		// Token: 0x0602A328 RID: 172840 RVA: 0x00BEA32C File Offset: 0x00BE852C
		public void SetMiddle(bool isStart)
		{
			UUITexture icon = isStart ? base.GetTexture(3) : base.GetTexture(0);
			UUITexture icon2 = isStart ? base.GetTexture(4) : base.GetTexture(1);
			UUITexture icon3 = isStart ? base.GetTexture(5) : base.GetTexture(2);
			this.SetTextureById("GymTabViewTextureBgLeftWhite", icon);
			this.SetTextureById("GymTabViewTextureBgMiddleColor", icon2);
			this.SetTextureById("GymTabViewTextureBgRightGray", icon3);
		}

		// Token: 0x0602A329 RID: 172841 RVA: 0x00BEA39C File Offset: 0x00BE859C
		public void SetRight(bool isStart)
		{
			UUITexture icon = isStart ? base.GetTexture(3) : base.GetTexture(0);
			UUITexture icon2 = isStart ? base.GetTexture(4) : base.GetTexture(1);
			UUITexture icon3 = isStart ? base.GetTexture(5) : base.GetTexture(2);
			this.SetTextureById("GymTabViewTextureBgLeftGray", icon);
			this.SetTextureById("GymTabViewTextureBgMiddleWhite", icon2);
			this.SetTextureById("GymTabViewTextureBgRightColor", icon3);
		}

		// Token: 0x02009CF9 RID: 40185
		private class EBgComponent
		{
			// Token: 0x04030CE4 RID: 199908
			public const int IconLeftA = 0;

			// Token: 0x04030CE5 RID: 199909
			public const int IconMiddleA = 1;

			// Token: 0x04030CE6 RID: 199910
			public const int IconRightA = 2;

			// Token: 0x04030CE7 RID: 199911
			public const int IconLeftB = 3;

			// Token: 0x04030CE8 RID: 199912
			public const int IconMiddleB = 4;

			// Token: 0x04030CE9 RID: 199913
			public const int IconRightB = 5;
		}
	}
}
