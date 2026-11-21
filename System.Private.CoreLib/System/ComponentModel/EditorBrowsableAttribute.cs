using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.ComponentModel
{
	// Token: 0x0200032A RID: 810
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
	public sealed class EditorBrowsableAttribute : Attribute
	{
		// Token: 0x06003A21 RID: 14881 RVA: 0x000C1428 File Offset: 0x000BF628
		public EditorBrowsableAttribute(EditorBrowsableState state)
		{
			this.State = state;
		}

		// Token: 0x06003A22 RID: 14882 RVA: 0x000C1437 File Offset: 0x000BF637
		public EditorBrowsableAttribute() : this(EditorBrowsableState.Always)
		{
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x06003A23 RID: 14883 RVA: 0x000C1440 File Offset: 0x000BF640
		public EditorBrowsableState State { get; }

		// Token: 0x06003A24 RID: 14884 RVA: 0x000C1448 File Offset: 0x000BF648
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			if (obj == this)
			{
				return true;
			}
			EditorBrowsableAttribute editorBrowsableAttribute = obj as EditorBrowsableAttribute;
			return editorBrowsableAttribute != null && editorBrowsableAttribute.State == this.State;
		}

		// Token: 0x06003A25 RID: 14885 RVA: 0x000C1376 File Offset: 0x000BF576
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
	}
}
