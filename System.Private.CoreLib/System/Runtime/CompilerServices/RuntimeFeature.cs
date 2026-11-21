using System;
using System.Diagnostics.CodeAnalysis;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020006C6 RID: 1734
	[NullableContext(1)]
	[Nullable(0)]
	public static class RuntimeFeature
	{
		// Token: 0x0600747D RID: 29821 RVA: 0x001157C0 File Offset: 0x001139C0
		public static bool IsSupported(string feature)
		{
			if (feature != null)
			{
				int length = feature.Length;
				if (length <= 17)
				{
					if (length != 11)
					{
						if (length != 13)
						{
							if (length != 17)
							{
								goto IL_124;
							}
							if (!(feature == "ByRefLikeGenerics"))
							{
								goto IL_124;
							}
						}
						else if (!(feature == "NumericIntPtr"))
						{
							goto IL_124;
						}
					}
					else
					{
						char c = feature[0];
						if (c != 'B')
						{
							if (c != 'P')
							{
								goto IL_124;
							}
							if (!(feature == "PortablePdb"))
							{
								goto IL_124;
							}
						}
						else if (!(feature == "ByRefFields"))
						{
							goto IL_124;
						}
					}
				}
				else
				{
					switch (length)
					{
					case 21:
						if (!(feature == "IsDynamicCodeCompiled"))
						{
							goto IL_124;
						}
						return RuntimeFeature.IsDynamicCodeCompiled;
					case 22:
						if (!(feature == "IsDynamicCodeSupported"))
						{
							goto IL_124;
						}
						return RuntimeFeature.IsDynamicCodeSupported;
					case 23:
					case 24:
						goto IL_124;
					case 25:
						if (!(feature == "CovariantReturnsOfClasses"))
						{
							goto IL_124;
						}
						break;
					case 26:
						if (!(feature == "VirtualStaticsInInterfaces"))
						{
							goto IL_124;
						}
						break;
					default:
						if (length != 34)
						{
							if (length != 35)
							{
								goto IL_124;
							}
							if (!(feature == "UnmanagedSignatureCallingConvention"))
							{
								goto IL_124;
							}
						}
						else if (!(feature == "DefaultImplementationsOfInterfaces"))
						{
							goto IL_124;
						}
						break;
					}
				}
				return true;
			}
			IL_124:
			return false;
		}

		// Token: 0x17000E53 RID: 3667
		// (get) Token: 0x0600747E RID: 29822 RVA: 0x001158F4 File Offset: 0x00113AF4
		[FeatureSwitchDefinition("System.Runtime.CompilerServices.RuntimeFeature.IsDynamicCodeSupported")]
		public static bool IsDynamicCodeSupported { [Intrinsic] get; }

		// Token: 0x17000E54 RID: 3668
		// (get) Token: 0x0600747F RID: 29823 RVA: 0x001158FB File Offset: 0x00113AFB
		[FeatureGuard(typeof(RequiresDynamicCodeAttribute))]
		public static bool IsDynamicCodeCompiled
		{
			[Intrinsic]
			get
			{
				return RuntimeFeature.IsDynamicCodeSupported;
			}
		}

		// Token: 0x06007480 RID: 29824 RVA: 0x00115904 File Offset: 0x00113B04
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeFeature()
		{
			bool flag;
			RuntimeFeature.IsDynamicCodeSupported = (!AppContext.TryGetSwitch("System.Runtime.CompilerServices.RuntimeFeature.IsDynamicCodeSupported", out flag) || flag);
		}

		// Token: 0x040014E6 RID: 5350
		public const string PortablePdb = "PortablePdb";

		// Token: 0x040014E7 RID: 5351
		public const string DefaultImplementationsOfInterfaces = "DefaultImplementationsOfInterfaces";

		// Token: 0x040014E8 RID: 5352
		public const string UnmanagedSignatureCallingConvention = "UnmanagedSignatureCallingConvention";

		// Token: 0x040014E9 RID: 5353
		public const string CovariantReturnsOfClasses = "CovariantReturnsOfClasses";

		// Token: 0x040014EA RID: 5354
		public const string ByRefFields = "ByRefFields";

		// Token: 0x040014EB RID: 5355
		public const string ByRefLikeGenerics = "ByRefLikeGenerics";

		// Token: 0x040014EC RID: 5356
		public const string VirtualStaticsInInterfaces = "VirtualStaticsInInterfaces";

		// Token: 0x040014ED RID: 5357
		public const string NumericIntPtr = "NumericIntPtr";
	}
}
