using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefenseUi.HeadState
{
	// Token: 0x02003AA5 RID: 15013
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseHeadStateData
	{
		// Token: 0x06026900 RID: 157952 RVA: 0x00ACF993 File Offset: 0x00ACDB93
		public bool UpdateHp(int hp, int maxHp, int shield)
		{
			if (this.Hp == hp && this.MaxHp == maxHp && this.Shield == shield)
			{
				return false;
			}
			this.Hp = hp;
			this.MaxHp = maxHp;
			this.Shield = shield;
			return true;
		}

		// Token: 0x06026901 RID: 157953 RVA: 0x00ACF9C8 File Offset: 0x00ACDBC8
		public void UpdatePosition(Vector position)
		{
			this.Position.FromUeVector(position);
		}

		// Token: 0x06026902 RID: 157954 RVA: 0x00ACF9D6 File Offset: 0x00ACDBD6
		public void RefreshDistance(Vector cameraLocation)
		{
			this.DistanceSquared = Vector.DistSquared(this.Position, cameraLocation);
		}

		// Token: 0x06026903 RID: 157955 RVA: 0x00ACF9EA File Offset: 0x00ACDBEA
		public void Destroy()
		{
		}

		// Token: 0x06026904 RID: 157956 RVA: 0x00ACF9EC File Offset: 0x00ACDBEC
		public void SetVisible(bool visible)
		{
			this.Visible = visible;
		}

		// Token: 0x06026905 RID: 157957 RVA: 0x00ACF9F8 File Offset: 0x00ACDBF8
		public void RefreshHpAndShield()
		{
			if (this.MaxHp <= 0)
			{
				this.HpPercent = 0f;
				this.ShieldPercent = 0f;
				return;
			}
			this.HpPercent = (float)this.Hp / (float)this.MaxHp;
			this.ShieldPercent = (float)this.Shield / (float)this.MaxHp;
		}

		// Token: 0x06026906 RID: 157958 RVA: 0x00ACFA4F File Offset: 0x00ACDC4F
		public void Tick(float delta)
		{
			this.RefreshHpBuffer(delta);
			this.RefreshScale();
		}

		// Token: 0x06026907 RID: 157959 RVA: 0x00ACFA60 File Offset: 0x00ACDC60
		private void RefreshScale()
		{
			float floatValue = this.ScaleCurve.GetFloatValue((float)this.DistanceSquared);
			this.ActorScale.X = (double)floatValue;
			this.ActorScale.Y = (double)floatValue;
			this.ActorScale.Z = (double)floatValue;
		}

		// Token: 0x06026908 RID: 157960 RVA: 0x00ACFAA8 File Offset: 0x00ACDCA8
		private void RefreshHpBuffer(float delta)
		{
			if (this.HpBufferPercent == this.HpPercent)
			{
				return;
			}
			if (this.HpBufferPercent < this.HpPercent)
			{
				this.HpBufferPercent = this.HpPercent;
				return;
			}
			this.HpBufferPercent -= 0.001f * delta;
			if (this.HpBufferPercent < this.HpPercent)
			{
				this.HpBufferPercent = this.HpPercent;
			}
		}

		// Token: 0x0401520C RID: 86540
		private const float HP_BUFFER_SPEED = 0.001f;

		// Token: 0x0401520D RID: 86541
		public int EntityId;

		// Token: 0x0401520E RID: 86542
		public Vector Position = Vector.Create(0.0, 0.0, 0.0);

		// Token: 0x0401520F RID: 86543
		public int MaxHp;

		// Token: 0x04015210 RID: 86544
		public int Hp;

		// Token: 0x04015211 RID: 86545
		public int Shield;

		// Token: 0x04015212 RID: 86546
		public double DistanceSquared;

		// Token: 0x04015213 RID: 86547
		[Nullable(2)]
		public UCurveFloat ScaleCurve;

		// Token: 0x04015214 RID: 86548
		public bool Visible;

		// Token: 0x04015215 RID: 86549
		public float HpPercent;

		// Token: 0x04015216 RID: 86550
		public float HpBufferPercent;

		// Token: 0x04015217 RID: 86551
		public float ShieldPercent;

		// Token: 0x04015218 RID: 86552
		public readonly Vector ActorScale = Vector.Create();
	}
}
