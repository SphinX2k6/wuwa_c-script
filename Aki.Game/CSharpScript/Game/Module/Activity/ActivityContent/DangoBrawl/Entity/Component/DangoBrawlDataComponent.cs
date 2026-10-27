using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.ActivityGamePlay.ActivityGameplayEntity.Component;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Entity.Component
{
	// Token: 0x02006896 RID: 26774
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DangoBrawlDataComponent : ActivityGameplayComponentBase<IDangoBrawlEntityData>
	{
		// Token: 0x170097BC RID: 38844
		// (get) Token: 0x06042D24 RID: 273700 RVA: 0x01043FBE File Offset: 0x010421BE
		public IDangoBrawlEntityData Data
		{
			get
			{
				return this.DataInternal;
			}
		}

		// Token: 0x170097BD RID: 38845
		// (get) Token: 0x06042D25 RID: 273701 RVA: 0x01043FC6 File Offset: 0x010421C6
		public int? Uid
		{
			get
			{
				return this.UidInternal;
			}
		}

		// Token: 0x06042D26 RID: 273702 RVA: 0x01043FCE File Offset: 0x010421CE
		public void SetUid(int uid)
		{
			this.UidInternal = new int?(uid);
		}

		// Token: 0x06042D27 RID: 273703 RVA: 0x01043FDC File Offset: 0x010421DC
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

		// Token: 0x06042D28 RID: 273704 RVA: 0x01044013 File Offset: 0x01042213
		protected override void OnEnd()
		{
			this.DataInternal = null;
			this.UidInternal = null;
		}

		// Token: 0x04022C50 RID: 142416
		[Nullable(2)]
		private IDangoBrawlEntityData DataInternal;

		// Token: 0x04022C51 RID: 142417
		private int? UidInternal;
	}
}
