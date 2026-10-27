using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ActivityGamePlay.ActivityGameplayEntity.Component
{
	// Token: 0x0200693D RID: 26941
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class ActivityGameplayComponentBase
	{
		// Token: 0x170097F3 RID: 38899
		// (get) Token: 0x0604325C RID: 275036 RVA: 0x0105E328 File Offset: 0x0105C528
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static List<Type> Dependencies
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				return null;
			}
		}

		// Token: 0x170097F4 RID: 38900
		// (get) Token: 0x0604325D RID: 275037 RVA: 0x0105E32B File Offset: 0x0105C52B
		public bool NeedTick
		{
			get
			{
				return this.NeedTickInternal;
			}
		}

		// Token: 0x170097F5 RID: 38901
		// (get) Token: 0x0604325E RID: 275038 RVA: 0x0105E333 File Offset: 0x0105C533
		protected ActivityGameplayEntity OwnerEntity
		{
			get
			{
				return this.OwnerEntityInternal;
			}
		}

		// Token: 0x0604325F RID: 275039 RVA: 0x0105E33B File Offset: 0x0105C53B
		public virtual void Create(ActivityGameplayEntity ownerEntity, [Nullable(2)] object args = null)
		{
			this.OwnerEntityInternal = ownerEntity;
		}

		// Token: 0x06043260 RID: 275040 RVA: 0x0105E344 File Offset: 0x0105C544
		public void Init()
		{
			this.OnInit();
		}

		// Token: 0x06043261 RID: 275041 RVA: 0x0105E34C File Offset: 0x0105C54C
		public void Tick(float deltaTime)
		{
			if (!this.NeedTickInternal)
			{
				return;
			}
			this.OnTick(deltaTime);
		}

		// Token: 0x06043262 RID: 275042 RVA: 0x0105E35E File Offset: 0x0105C55E
		public void End()
		{
			this.OnEnd();
			this.OwnerEntityInternal = null;
		}

		// Token: 0x06043263 RID: 275043 RVA: 0x0105E36D File Offset: 0x0105C56D
		protected void SetNeedTick(bool value)
		{
			this.NeedTickInternal = value;
		}

		// Token: 0x06043264 RID: 275044 RVA: 0x0105E376 File Offset: 0x0105C576
		protected virtual void OnInit()
		{
		}

		// Token: 0x06043265 RID: 275045 RVA: 0x0105E378 File Offset: 0x0105C578
		protected virtual void OnTick(float deltaTime)
		{
		}

		// Token: 0x06043266 RID: 275046 RVA: 0x0105E37A File Offset: 0x0105C57A
		protected virtual void OnEnd()
		{
		}

		// Token: 0x04022F5E RID: 143198
		private bool NeedTickInternal;

		// Token: 0x04022F5F RID: 143199
		[Nullable(2)]
		private ActivityGameplayEntity OwnerEntityInternal;
	}
}
