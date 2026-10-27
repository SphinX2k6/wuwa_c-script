using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefenseUi.HeadState
{
	// Token: 0x02004AFD RID: 19197
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseHeadStateData
	{
		// Token: 0x06031B70 RID: 203632 RVA: 0x00B8B937 File Offset: 0x00B89B37
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

		// Token: 0x06031B71 RID: 203633 RVA: 0x00B8B96C File Offset: 0x00B89B6C
		public void UpdatePosition(Vector position)
		{
			this.Position.FromUeVector(position);
		}

		// Token: 0x06031B72 RID: 203634 RVA: 0x00B8B97A File Offset: 0x00B89B7A
		public void RefreshDistance(Vector cameraLocation)
		{
			this.DistanceSquared = Vector.DistSquared(this.Position, cameraLocation);
		}

		// Token: 0x06031B73 RID: 203635 RVA: 0x00B8B98E File Offset: 0x00B89B8E
		public void Destroy()
		{
		}

		// Token: 0x06031B74 RID: 203636 RVA: 0x00B8B990 File Offset: 0x00B89B90
		public void SetVisible(bool visible)
		{
			this.Visible = visible;
		}

		// Token: 0x06031B75 RID: 203637 RVA: 0x00B8B99C File Offset: 0x00B89B9C
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

		// Token: 0x06031B76 RID: 203638 RVA: 0x00B8B9F3 File Offset: 0x00B89BF3
		public void Tick(float delta)
		{
			this.RefreshHpBuffer(delta);
			this.RefreshScale();
		}

		// Token: 0x06031B77 RID: 203639 RVA: 0x00B8BA04 File Offset: 0x00B89C04
		private void RefreshScale()
		{
			float floatValue = this.ScaleCurve.GetFloatValue((float)this.DistanceSquared);
			this.ActorScale.X = (double)floatValue;
			this.ActorScale.Y = (double)floatValue;
			this.ActorScale.Z = (double)floatValue;
		}

		// Token: 0x06031B78 RID: 203640 RVA: 0x00B8BA4C File Offset: 0x00B89C4C
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

		// Token: 0x0401A8BA RID: 108730
		private const float HP_BUFFER_SPEED = 0.001f;

		// Token: 0x0401A8BB RID: 108731
		public int EntityId;

		// Token: 0x0401A8BC RID: 108732
		public Vector Position = Vector.Create(0.0, 0.0, 0.0);

		// Token: 0x0401A8BD RID: 108733
		public int MaxHp;

		// Token: 0x0401A8BE RID: 108734
		public int Hp;

		// Token: 0x0401A8BF RID: 108735
		public int Shield;

		// Token: 0x0401A8C0 RID: 108736
		public double DistanceSquared;

		// Token: 0x0401A8C1 RID: 108737
		[Nullable(2)]
		public UCurveFloat ScaleCurve;

		// Token: 0x0401A8C2 RID: 108738
		public bool Visible;

		// Token: 0x0401A8C3 RID: 108739
		public float HpPercent;

		// Token: 0x0401A8C4 RID: 108740
		public float HpBufferPercent;

		// Token: 0x0401A8C5 RID: 108741
		public float ShieldPercent;

		// Token: 0x0401A8C6 RID: 108742
		public readonly Vector ActorScale = Vector.Create();
	}
}
