using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ActivityGamePlay.ActivityGameplayEntity.Component
{
	// Token: 0x0200588E RID: 22670
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class ActivityGameplayComponentBase
	{
		// Token: 0x17006B33 RID: 27443
		// (get) Token: 0x06037DB9 RID: 228793 RVA: 0x00F9F998 File Offset: 0x00F9DB98
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual Type[] Dependencies
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

		// Token: 0x17006B34 RID: 27444
		// (get) Token: 0x06037DBA RID: 228794 RVA: 0x00F9F99B File Offset: 0x00F9DB9B
		public bool NeedTick
		{
			get
			{
				return this.NeedTickInternal;
			}
		}

		// Token: 0x17006B35 RID: 27445
		// (get) Token: 0x06037DBB RID: 228795 RVA: 0x00F9F9A3 File Offset: 0x00F9DBA3
		protected ActivityGameplayEntity OwnerEntity
		{
			get
			{
				return this.OwnerEntityInternal;
			}
		}

		// Token: 0x06037DBC RID: 228796 RVA: 0x00F9F9AB File Offset: 0x00F9DBAB
		public virtual void Create(ActivityGameplayEntity ownerEntity, [Nullable(2)] object args = null)
		{
			this.OwnerEntityInternal = ownerEntity;
		}

		// Token: 0x06037DBD RID: 228797 RVA: 0x00F9F9B4 File Offset: 0x00F9DBB4
		public void Init()
		{
			this.OnInit();
		}

		// Token: 0x06037DBE RID: 228798 RVA: 0x00F9F9BC File Offset: 0x00F9DBBC
		public void Tick(float deltaTime)
		{
			if (!this.NeedTickInternal)
			{
				return;
			}
			this.OnTick(deltaTime);
		}

		// Token: 0x06037DBF RID: 228799 RVA: 0x00F9F9CE File Offset: 0x00F9DBCE
		public void End()
		{
			this.OnEnd();
			this.OwnerEntityInternal = null;
		}

		// Token: 0x06037DC0 RID: 228800 RVA: 0x00F9F9DD File Offset: 0x00F9DBDD
		protected void SetNeedTick(bool value)
		{
			this.NeedTickInternal = value;
		}

		// Token: 0x06037DC1 RID: 228801 RVA: 0x00F9F9E6 File Offset: 0x00F9DBE6
		protected virtual void OnInit()
		{
		}

		// Token: 0x06037DC2 RID: 228802 RVA: 0x00F9F9E8 File Offset: 0x00F9DBE8
		protected virtual void OnTick(float deltaTime)
		{
		}

		// Token: 0x06037DC3 RID: 228803 RVA: 0x00F9F9EA File Offset: 0x00F9DBEA
		protected virtual void OnEnd()
		{
		}

		// Token: 0x0401D7BB RID: 120763
		private bool NeedTickInternal;

		// Token: 0x0401D7BC RID: 120764
		[Nullable(2)]
		private ActivityGameplayEntity OwnerEntityInternal;
	}
}
