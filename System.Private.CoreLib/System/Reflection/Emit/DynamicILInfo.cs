using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	// Token: 0x0200079C RID: 1948
	[NullableContext(1)]
	[Nullable(0)]
	[ComVisible(true)]
	public class DynamicILInfo
	{
		// Token: 0x06007C02 RID: 31746 RVA: 0x00125468 File Offset: 0x00123668
		internal DynamicILInfo(DynamicMethod method)
		{
			this.method = method;
		}

		// Token: 0x17001055 RID: 4181
		// (get) Token: 0x06007C03 RID: 31747 RVA: 0x00125477 File Offset: 0x00123677
		public DynamicMethod DynamicMethod
		{
			get
			{
				return this.method;
			}
		}

		// Token: 0x06007C04 RID: 31748 RVA: 0x0000FD41 File Offset: 0x0000DF41
		public int GetTokenFor(byte[] signature)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06007C05 RID: 31749 RVA: 0x0012547F File Offset: 0x0012367F
		public int GetTokenFor(DynamicMethod method)
		{
			return this.method.GetRuntimeILGenerator().TokenGenerator.GetToken(method, false);
		}

		// Token: 0x06007C06 RID: 31750 RVA: 0x00125498 File Offset: 0x00123698
		public int GetTokenFor(RuntimeFieldHandle field)
		{
			return this.method.GetRuntimeILGenerator().TokenGenerator.GetToken(FieldInfo.GetFieldFromHandle(field), false);
		}

		// Token: 0x06007C07 RID: 31751 RVA: 0x001254B8 File Offset: 0x001236B8
		public int GetTokenFor(RuntimeMethodHandle method)
		{
			MethodBase methodFromHandle = MethodBase.GetMethodFromHandle(method);
			return this.method.GetRuntimeILGenerator().TokenGenerator.GetToken(methodFromHandle, false);
		}

		// Token: 0x06007C08 RID: 31752 RVA: 0x001254E4 File Offset: 0x001236E4
		public int GetTokenFor(RuntimeTypeHandle type)
		{
			Type typeFromHandle = Type.GetTypeFromHandle(type);
			return this.method.GetRuntimeILGenerator().TokenGenerator.GetToken(typeFromHandle, false);
		}

		// Token: 0x06007C09 RID: 31753 RVA: 0x0012550F File Offset: 0x0012370F
		public int GetTokenFor(string literal)
		{
			return this.method.GetRuntimeILGenerator().TokenGenerator.GetToken(literal);
		}

		// Token: 0x06007C0A RID: 31754 RVA: 0x0000FD41 File Offset: 0x0000DF41
		public int GetTokenFor(RuntimeMethodHandle method, RuntimeTypeHandle contextType)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06007C0B RID: 31755 RVA: 0x0000FD41 File Offset: 0x0000DF41
		public int GetTokenFor(RuntimeFieldHandle field, RuntimeTypeHandle contextType)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06007C0C RID: 31756 RVA: 0x00125527 File Offset: 0x00123727
		[NullableContext(2)]
		public void SetCode(byte[] code, int maxStackSize)
		{
			this.method.GetRuntimeILGenerator().SetCode(code, maxStackSize);
		}

		// Token: 0x06007C0D RID: 31757 RVA: 0x0012553B File Offset: 0x0012373B
		[NullableContext(0)]
		[CLSCompliant(false)]
		public unsafe void SetCode(byte* code, int codeSize, int maxStackSize)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(codeSize, "codeSize");
			if (codeSize > 0)
			{
				ArgumentNullException.ThrowIfNull((void*)code, "code");
			}
			this.method.GetRuntimeILGenerator().SetCode(code, codeSize, maxStackSize);
		}

		// Token: 0x06007C0E RID: 31758 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[NullableContext(2)]
		public void SetExceptions(byte[] exceptions)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06007C0F RID: 31759 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[NullableContext(0)]
		[CLSCompliant(false)]
		public unsafe void SetExceptions(byte* exceptions, int exceptionsSize)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06007C10 RID: 31760 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[NullableContext(2)]
		public void SetLocalSignature(byte[] localSignature)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06007C11 RID: 31761 RVA: 0x0012556C File Offset: 0x0012376C
		[NullableContext(0)]
		[CLSCompliant(false)]
		public unsafe void SetLocalSignature(byte* localSignature, int signatureSize)
		{
			byte[] array = new byte[signatureSize];
			for (int i = 0; i < signatureSize; i++)
			{
				array[i] = localSignature[i];
			}
		}

		// Token: 0x04001790 RID: 6032
		private DynamicMethod method;
	}
}
