using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Reflection.Emit
{
	// Token: 0x020007BF RID: 1983
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class EnumBuilder : TypeInfo
	{
		// Token: 0x1700112B RID: 4395
		// (get) Token: 0x06007F84 RID: 32644 RVA: 0x0012D8B7 File Offset: 0x0012BAB7
		public FieldBuilder UnderlyingField
		{
			get
			{
				return this.UnderlyingFieldCore;
			}
		}

		// Token: 0x1700112C RID: 4396
		// (get) Token: 0x06007F85 RID: 32645
		protected abstract FieldBuilder UnderlyingFieldCore { get; }

		// Token: 0x06007F86 RID: 32646 RVA: 0x0012D8BF File Offset: 0x0012BABF
		[return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
		public Type CreateType()
		{
			return this.CreateTypeInfoCore();
		}

		// Token: 0x06007F87 RID: 32647 RVA: 0x0012D8BF File Offset: 0x0012BABF
		[return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
		public TypeInfo CreateTypeInfo()
		{
			return this.CreateTypeInfoCore();
		}

		// Token: 0x06007F88 RID: 32648
		[return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
		protected abstract TypeInfo CreateTypeInfoCore();

		// Token: 0x06007F89 RID: 32649 RVA: 0x0012D8C7 File Offset: 0x0012BAC7
		public FieldBuilder DefineLiteral(string literalName, [Nullable(2)] object literalValue)
		{
			return this.DefineLiteralCore(literalName, literalValue);
		}

		// Token: 0x06007F8A RID: 32650
		protected abstract FieldBuilder DefineLiteralCore(string literalName, [Nullable(2)] object literalValue);

		// Token: 0x06007F8B RID: 32651 RVA: 0x0012D8D1 File Offset: 0x0012BAD1
		public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute)
		{
			this.SetCustomAttributeCore(con, binaryAttribute);
		}

		// Token: 0x06007F8C RID: 32652
		[NullableContext(0)]
		protected abstract void SetCustomAttributeCore([Nullable(1)] ConstructorInfo con, ReadOnlySpan<byte> binaryAttribute);

		// Token: 0x06007F8D RID: 32653 RVA: 0x0012D8E0 File Offset: 0x0012BAE0
		public void SetCustomAttribute(CustomAttributeBuilder customBuilder)
		{
			this.SetCustomAttributeCore(customBuilder.Ctor, customBuilder.Data);
		}

		// Token: 0x06007F8E RID: 32654 RVA: 0x001276AB File Offset: 0x001258AB
		public override Type MakePointerType()
		{
			return SymbolType.FormCompoundType("*", this, 0);
		}

		// Token: 0x06007F8F RID: 32655 RVA: 0x0012768B File Offset: 0x0012588B
		public override Type MakeByRefType()
		{
			return SymbolType.FormCompoundType("&", this, 0);
		}

		// Token: 0x06007F90 RID: 32656 RVA: 0x0012766E File Offset: 0x0012586E
		[RequiresDynamicCode("The code for an array of the specified type might not be available.")]
		public override Type MakeArrayType()
		{
			return SymbolType.FormCompoundType("[]", this, 0);
		}

		// Token: 0x06007F91 RID: 32657 RVA: 0x0012767C File Offset: 0x0012587C
		[RequiresDynamicCode("The code for an array of the specified type might not be available.")]
		public override Type MakeArrayType(int rank)
		{
			return SymbolType.FormCompoundType(TypeInfo.GetRankString(rank), this, 0);
		}
	}
}
