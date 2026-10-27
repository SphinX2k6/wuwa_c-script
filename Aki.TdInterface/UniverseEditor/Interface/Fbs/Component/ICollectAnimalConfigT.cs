using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FB0 RID: 20400
	public class ICollectAnimalConfigT
	{
		// Token: 0x170093C1 RID: 37825
		// (get) Token: 0x0602078D RID: 133005 RVA: 0x004849B7 File Offset: 0x00482BB7
		// (set) Token: 0x0602078E RID: 133006 RVA: 0x004849BF File Offset: 0x00482BBF
		public ESpecialAnimalType Type { get; set; }

		// Token: 0x170093C2 RID: 37826
		// (get) Token: 0x0602078F RID: 133007 RVA: 0x004849C8 File Offset: 0x00482BC8
		// (set) Token: 0x06020790 RID: 133008 RVA: 0x004849D0 File Offset: 0x00482BD0
		public List<ICollectAnimalPartsConfigT> PartsMap { get; set; }

		// Token: 0x06020791 RID: 133009 RVA: 0x004849D9 File Offset: 0x00482BD9
		public ICollectAnimalConfigT()
		{
			this.Type = ESpecialAnimalType.CollectAnimal;
			this.PartsMap = null;
		}
	}
}
