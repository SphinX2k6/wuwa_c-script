using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.ActivityGamePlay.ActivityGameplayEntity.Component;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Entity.Component
{
	// Token: 0x020057E6 RID: 22502
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DangoBrawlDataComponent : ActivityGameplayComponentBase<IDangoBrawlEntityData>
	{
		// Token: 0x17006AFC RID: 27388
		// (get) Token: 0x0603787C RID: 227452 RVA: 0x00F8553A File Offset: 0x00F8373A
		public IDangoBrawlEntityData Data
		{
			get
			{
				return this.DataInternal;
			}
		}

		// Token: 0x17006AFD RID: 27389
		// (get) Token: 0x0603787D RID: 227453 RVA: 0x00F85542 File Offset: 0x00F83742
		public int? Uid
		{
			get
			{
				return this.UidInternal;
			}
		}

		// Token: 0x0603787E RID: 227454 RVA: 0x00F8554A File Offset: 0x00F8374A
		public void SetUid(int uid)
		{
			this.UidInternal = new int?(uid);
		}

		// Token: 0x0603787F RID: 227455 RVA: 0x00F85558 File Offset: 0x00F83758
		[NullableContext(2)]
		protected override void OnCreate(IDangoBrawlEntityData args = null)
		{
			if (args == null)
			{
				Log.Instance.Error(ELogModule.DangoBrawl, ELogAuthor.WHJ, "DangoBrawlDataComponent 缺少入参", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.DataInternal = args;
		}

		// Token: 0x06037880 RID: 227456 RVA: 0x00F8558F File Offset: 0x00F8378F
		protected override void OnEnd()
		{
			this.DataInternal = null;
			this.UidInternal = null;
		}

		// Token: 0x0401D4AC RID: 119980
		[Nullable(2)]
		private IDangoBrawlEntityData DataInternal;

		// Token: 0x0401D4AD RID: 119981
		private int? UidInternal;
	}
}
