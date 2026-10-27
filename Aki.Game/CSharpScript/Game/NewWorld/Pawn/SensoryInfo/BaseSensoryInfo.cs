using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Pawn.Controllers;

namespace CSharpScript.Game.NewWorld.Pawn.SensoryInfo
{
	// Token: 0x0200705F RID: 28767
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class BaseSensoryInfo
	{
		// Token: 0x17009BF7 RID: 39927
		// (get) Token: 0x06046035 RID: 286773 RVA: 0x01173E8C File Offset: 0x0117208C
		public virtual ERangePerceptionType RangePerceptionType
		{
			get
			{
				return ERangePerceptionType.Dynamic;
			}
		}

		// Token: 0x17009BF8 RID: 39928
		// (get) Token: 0x06046036 RID: 286774 RVA: 0x01173E8F File Offset: 0x0117208F
		public virtual ESensoryInfoType SensoryInfoType
		{
			get
			{
				return ESensoryInfoType.EnterAndExit;
			}
		}

		// Token: 0x06046037 RID: 286775 RVA: 0x01173E92 File Offset: 0x01172092
		public void Init(params object[] @params)
		{
			this.OnInit(@params);
		}

		// Token: 0x06046038 RID: 286776 RVA: 0x01173E9B File Offset: 0x0117209B
		public void Tick(float delta)
		{
			if ((this.SensoryInfoType & ESensoryInfoType.Tick) != (ESensoryInfoType)0)
			{
				this.OnTick(delta);
			}
		}

		// Token: 0x06046039 RID: 286777 RVA: 0x01173EAE File Offset: 0x011720AE
		public void Clear()
		{
			this.InRange = false;
			this.SensoryRange = 0.0;
			this.OnClear();
		}

		// Token: 0x0604603A RID: 286778
		protected abstract void OnInit(params object[] @params);

		// Token: 0x0604603B RID: 286779
		protected abstract void OnTick(float delta);

		// Token: 0x0604603C RID: 286780
		protected abstract void OnClear();

		// Token: 0x0604603D RID: 286781 RVA: 0x01173ECC File Offset: 0x011720CC
		public bool CheckInRange()
		{
			return this.InRange;
		}

		// Token: 0x0604603E RID: 286782 RVA: 0x01173ED4 File Offset: 0x011720D4
		public virtual void ClearCacheList()
		{
		}

		// Token: 0x0604603F RID: 286783
		public abstract bool CheckEntity(Entity entity);

		// Token: 0x06046040 RID: 286784
		public abstract void EnterRange(Entity entity);

		// Token: 0x06046041 RID: 286785
		public abstract void ExitRange();

		// Token: 0x04024A7B RID: 150139
		public double SensoryRange;

		// Token: 0x04024A7C RID: 150140
		protected bool InRange;
	}
}
