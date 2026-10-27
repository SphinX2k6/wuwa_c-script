using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x0200515F RID: 20831
	public class EntranceBackgroundPanel : UiPanelBase
	{
		// Token: 0x06035428 RID: 218152 RVA: 0x00C9CC9C File Offset: 0x00C9AE9C
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

		// Token: 0x06035429 RID: 218153 RVA: 0x00C9CD38 File Offset: 0x00C9AF38
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

		// Token: 0x0603542A RID: 218154 RVA: 0x00C9CD90 File Offset: 0x00C9AF90
		[NullableContext(1)]
		private void SetTextureById(string resourceId, [Nullable(2)] UUITexture icon)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			base.SetTextureByPath(resourcePath, icon, null, null);
		}

		// Token: 0x0603542B RID: 218155 RVA: 0x00C9CDBC File Offset: 0x00C9AFBC
		public void SetLeft(bool isStart)
		{
			UUITexture icon = isStart ? base.GetTexture(3) : base.GetTexture(0);
			UUITexture icon2 = isStart ? base.GetTexture(4) : base.GetTexture(1);
			UUITexture icon3 = isStart ? base.GetTexture(5) : base.GetTexture(2);
			this.SetTextureById("GymTabViewTextureBgLeftColor", icon);
			this.SetTextureById("GymTabViewTextureBgMiddleWhite", icon2);
			this.SetTextureById("GymTabViewTextureBgRightGray", icon3);
		}

		// Token: 0x0603542C RID: 218156 RVA: 0x00C9CE2C File Offset: 0x00C9B02C
		public void SetMiddle(bool isStart)
		{
			UUITexture icon = isStart ? base.GetTexture(3) : base.GetTexture(0);
			UUITexture icon2 = isStart ? base.GetTexture(4) : base.GetTexture(1);
			UUITexture icon3 = isStart ? base.GetTexture(5) : base.GetTexture(2);
			this.SetTextureById("GymTabViewTextureBgLeftWhite", icon);
			this.SetTextureById("GymTabViewTextureBgMiddleColor", icon2);
			this.SetTextureById("GymTabViewTextureBgRightGray", icon3);
		}

		// Token: 0x0603542D RID: 218157 RVA: 0x00C9CE9C File Offset: 0x00C9B09C
		public void SetRight(bool isStart)
		{
			UUITexture icon = isStart ? base.GetTexture(3) : base.GetTexture(0);
			UUITexture icon2 = isStart ? base.GetTexture(4) : base.GetTexture(1);
			UUITexture icon3 = isStart ? base.GetTexture(5) : base.GetTexture(2);
			this.SetTextureById("GymTabViewTextureBgLeftGray", icon);
			this.SetTextureById("GymTabViewTextureBgMiddleWhite", icon2);
			this.SetTextureById("GymTabViewTextureBgRightColor", icon3);
		}

		// Token: 0x0200B2C0 RID: 45760
		private class EBgComponent
		{
			// Token: 0x0403628F RID: 221839
			public const int IconLeftA = 0;

			// Token: 0x04036290 RID: 221840
			public const int IconMiddleA = 1;

			// Token: 0x04036291 RID: 221841
			public const int IconRightA = 2;

			// Token: 0x04036292 RID: 221842
			public const int IconLeftB = 3;

			// Token: 0x04036293 RID: 221843
			public const int IconMiddleB = 4;

			// Token: 0x04036294 RID: 221844
			public const int IconRightB = 5;
		}
	}
}
