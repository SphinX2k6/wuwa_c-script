using System;

namespace Sharphereal.AOTRedirector.Attributes
{
	// Token: 0x0200000B RID: 11
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Event)]
	public class DontRedirectAttribute : Attribute
	{
	}
}
