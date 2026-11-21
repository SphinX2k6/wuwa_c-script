using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x02000734 RID: 1844
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class Binder
	{
		// Token: 0x0600788D RID: 30861
		public abstract FieldInfo BindToField(BindingFlags bindingAttr, FieldInfo[] match, object value, [Nullable(2)] CultureInfo culture);

		// Token: 0x0600788E RID: 30862
		[NullableContext(2)]
		[return: Nullable(1)]
		public abstract MethodBase BindToMethod(BindingFlags bindingAttr, [Nullable(1)] MethodBase[] match, [Nullable(new byte[]
		{
			1,
			2
		})] ref object[] args, ParameterModifier[] modifiers, CultureInfo culture, [Nullable(new byte[]
		{
			2,
			1
		})] string[] names, out object state);

		// Token: 0x0600788F RID: 30863
		public abstract object ChangeType(object value, Type type, [Nullable(2)] CultureInfo culture);

		// Token: 0x06007890 RID: 30864
		public abstract void ReorderArgumentArray([Nullable(new byte[]
		{
			1,
			2
		})] ref object[] args, object state);

		// Token: 0x06007891 RID: 30865
		[return: Nullable(2)]
		public abstract MethodBase SelectMethod(BindingFlags bindingAttr, MethodBase[] match, Type[] types, [Nullable(2)] ParameterModifier[] modifiers);

		// Token: 0x06007892 RID: 30866
		[NullableContext(2)]
		public abstract PropertyInfo SelectProperty(BindingFlags bindingAttr, [Nullable(1)] PropertyInfo[] match, Type returnType, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] indexes, ParameterModifier[] modifiers);
	}
}
