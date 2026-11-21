using System;
using System.Collections.Generic;
using System.Globalization;

namespace System.Resources
{
	// Token: 0x02000279 RID: 633
	internal interface IResourceGroveler
	{
		// Token: 0x06002E29 RID: 11817
		ResourceSet GrovelForResourceSet(CultureInfo culture, Dictionary<string, ResourceSet> localResourceSets, bool tryParents, bool createIfNotExists);
	}
}
