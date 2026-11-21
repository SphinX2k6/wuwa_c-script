using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x02000751 RID: 1873
	[NullableContext(1)]
	public interface IReflect
	{
		// Token: 0x06007926 RID: 31014
		[NullableContext(2)]
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)]
		MethodInfo GetMethod([Nullable(1)] string name, BindingFlags bindingAttr, Binder binder, [Nullable(1)] Type[] types, ParameterModifier[] modifiers);

		// Token: 0x06007927 RID: 31015
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)]
		[return: Nullable(2)]
		MethodInfo GetMethod(string name, BindingFlags bindingAttr);

		// Token: 0x06007928 RID: 31016
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)]
		MethodInfo[] GetMethods(BindingFlags bindingAttr);

		// Token: 0x06007929 RID: 31017
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields)]
		[return: Nullable(2)]
		FieldInfo GetField(string name, BindingFlags bindingAttr);

		// Token: 0x0600792A RID: 31018
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields)]
		FieldInfo[] GetFields(BindingFlags bindingAttr);

		// Token: 0x0600792B RID: 31019
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)]
		[return: Nullable(2)]
		PropertyInfo GetProperty(string name, BindingFlags bindingAttr);

		// Token: 0x0600792C RID: 31020
		[NullableContext(2)]
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)]
		PropertyInfo GetProperty([Nullable(1)] string name, BindingFlags bindingAttr, Binder binder, Type returnType, [Nullable(1)] Type[] types, ParameterModifier[] modifiers);

		// Token: 0x0600792D RID: 31021
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)]
		PropertyInfo[] GetProperties(BindingFlags bindingAttr);

		// Token: 0x0600792E RID: 31022
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)8191)]
		MemberInfo[] GetMember(string name, BindingFlags bindingAttr);

		// Token: 0x0600792F RID: 31023
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)8191)]
		MemberInfo[] GetMembers(BindingFlags bindingAttr);

		// Token: 0x06007930 RID: 31024
		[NullableContext(2)]
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
		object InvokeMember([Nullable(1)] string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, [Nullable(new byte[]
		{
			2,
			1
		})] string[] namedParameters);

		// Token: 0x17000F71 RID: 3953
		// (get) Token: 0x06007931 RID: 31025
		Type UnderlyingSystemType { get; }
	}
}
