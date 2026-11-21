using System;
using System.Runtime.CompilerServices;

namespace System.Security
{
	// Token: 0x02000259 RID: 601
	[NullableContext(1)]
	public interface ISecurityEncodable
	{
		// Token: 0x06002D55 RID: 11605
		void FromXml(SecurityElement e);

		// Token: 0x06002D56 RID: 11606
		[NullableContext(2)]
		SecurityElement ToXml();
	}
}
