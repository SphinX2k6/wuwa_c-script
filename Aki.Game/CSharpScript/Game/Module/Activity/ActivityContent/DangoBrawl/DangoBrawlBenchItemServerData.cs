using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067BF RID: 26559
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlBenchItemServerData
	{
		// Token: 0x06042268 RID: 270952 RVA: 0x0100AAE9 File Offset: 0x01008CE9
		public DangoBrawlBenchItemServerData(DangoBrawlBenchItemInfo data)
		{
			this.ServerData = data;
		}

		// Token: 0x170096B1 RID: 38577
		// (get) Token: 0x06042269 RID: 270953 RVA: 0x0100AAF8 File Offset: 0x01008CF8
		public int Uid
		{
			get
			{
				return this.ServerData.Inst.Uid;
			}
		}

		// Token: 0x170096B2 RID: 38578
		// (get) Token: 0x0604226A RID: 270954 RVA: 0x0100AB0A File Offset: 0x01008D0A
		public int ConfigId
		{
			get
			{
				return this.ServerData.Inst.ConfigId;
			}
		}

		// Token: 0x0402289C RID: 141468
		private readonly DangoBrawlBenchItemInfo ServerData;
	}
}
