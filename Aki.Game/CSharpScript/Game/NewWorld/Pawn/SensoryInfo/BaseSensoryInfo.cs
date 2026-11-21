using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Pawn.Controllers;

namespace CSharpScript.Game.NewWorld.Pawn.SensoryInfo
{
	// Token: 0x020061E0 RID: 25056
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class BaseSensoryInfo
	{
		// Token: 0x1700717B RID: 29051
		// (get) Token: 0x0603C22E RID: 246318 RVA: 0x0111DA8B File Offset: 0x0111BC8B
		public virtual ERangePerceptionType RangePerceptionType
		{
			get
			{
				return ERangePerceptionType.Dynamic;
			}
		}

		// Token: 0x1700717C RID: 29052
		// (get) Token: 0x0603C22F RID: 246319 RVA: 0x0111DA8E File Offset: 0x0111BC8E
		public virtual ESensoryInfoType SensoryInfoType
		{
			get
			{
				return ESensoryInfoType.EnterAndExit;
			}
		}

		// Token: 0x0603C230 RID: 246320 RVA: 0x0111DA91 File Offset: 0x0111BC91
		public void Init(params object[] @params)
		{
			this.OnInit(@params);
		}

		// Token: 0x0603C231 RID: 246321 RVA: 0x0111DA9A File Offset: 0x0111BC9A
		public void Tick(float delta)
		{
			if ((this.SensoryInfoType & ESensoryInfoType.Tick) != (ESensoryInfoType)0)
			{
				this.OnTick(delta);
			}
		}

		// Token: 0x0603C232 RID: 246322 RVA: 0x0111DAAD File Offset: 0x0111BCAD
		public void Clear()
		{
			this.InRange = false;
			this.SensoryRange = 0.0;
			this.OnClear();
		}

		// Token: 0x0603C233 RID: 246323
		protected abstract void OnInit(params object[] @params);

		// Token: 0x0603C234 RID: 246324
		protected abstract void OnTick(float delta);

		// Token: 0x0603C235 RID: 246325
		protected abstract void OnClear();

		// Token: 0x0603C236 RID: 246326 RVA: 0x0111DACB File Offset: 0x0111BCCB
		public bool CheckInRange()
		{
			return this.InRange;
		}

		// Token: 0x0603C237 RID: 246327 RVA: 0x0111DAD3 File Offset: 0x0111BCD3
		public virtual void ClearCacheList()
		{
		}

		// Token: 0x0603C238 RID: 246328
		public abstract bool CheckEntity(Entity entity);

		// Token: 0x0603C239 RID: 246329
		public abstract void EnterRange(Entity entity);

		// Token: 0x0603C23A RID: 246330
		public abstract void ExitRange();

		// Token: 0x0401FD31 RID: 130353
		public double SensoryRange;

		// Token: 0x0401FD32 RID: 130354
		protected bool InRange;
	}
}
