using System;
using System.Buffers.Binary;
using System.Security;

namespace System.Reflection
{
	// Token: 0x0200072C RID: 1836
	internal static class AssemblyNameHelpers
	{
		// Token: 0x0600787A RID: 30842 RVA: 0x0011E7D8 File Offset: 0x0011C9D8
		public unsafe static byte[] ComputePublicKeyToken(byte[] publicKey)
		{
			if (publicKey == null)
			{
				return null;
			}
			if (publicKey.Length == 0)
			{
				return Array.Empty<byte>();
			}
			if (!AssemblyNameHelpers.IsValidPublicKey(publicKey))
			{
				throw new SecurityException(SR.Security_InvalidAssemblyPublicKey);
			}
			Span<byte> output = new Span<byte>(stackalloc byte[(UIntPtr)20], 20);
			Sha1ForNonSecretPurposes sha1ForNonSecretPurposes = default(Sha1ForNonSecretPurposes);
			sha1ForNonSecretPurposes.Start();
			sha1ForNonSecretPurposes.Append(publicKey);
			sha1ForNonSecretPurposes.Finish(output);
			byte[] array = new byte[8];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = *output[output.Length - 1 - i];
			}
			return array;
		}

		// Token: 0x0600787B RID: 30843 RVA: 0x0011E864 File Offset: 0x0011CA64
		private static bool IsValidPublicKey(byte[] publicKey)
		{
			uint num = (uint)publicKey.Length;
			if (num < 16U)
			{
				return false;
			}
			ReadOnlySpan<byte> readOnlySpan = new ReadOnlySpan<byte>(publicKey);
			uint num2 = BinaryPrimitives.ReadUInt32LittleEndian(readOnlySpan);
			uint num3 = BinaryPrimitives.ReadUInt32LittleEndian(readOnlySpan.Slice(4));
			if (BinaryPrimitives.ReadUInt32LittleEndian(readOnlySpan.Slice(8)) != num - 12U)
			{
				return false;
			}
			if (AssemblyNameHelpers.EcmaKey.SequenceEqual(readOnlySpan))
			{
				return true;
			}
			bool flag = AssemblyNameHelpers.GetAlgClass(num3) == 32768U && AssemblyNameHelpers.GetAlgSid(num3) >= 4U;
			if (num3 != 0U && !flag)
			{
				return false;
			}
			bool flag2 = AssemblyNameHelpers.GetAlgClass(num2) == 8192U;
			return (num2 == 0U || flag2) && publicKey[12] == 6;
		}

		// Token: 0x0600787C RID: 30844 RVA: 0x0011E906 File Offset: 0x0011CB06
		private static uint GetAlgClass(uint x)
		{
			return x & 57344U;
		}

		// Token: 0x0600787D RID: 30845 RVA: 0x0011E90F File Offset: 0x0011CB0F
		private static uint GetAlgSid(uint x)
		{
			return x & 511U;
		}

		// Token: 0x17000F4E RID: 3918
		// (get) Token: 0x0600787E RID: 30846 RVA: 0x0011E918 File Offset: 0x0011CB18
		private unsafe static ReadOnlySpan<byte> EcmaKey
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.F7548C023E431138B11357593F5CCEB9DD35EB0B0A2041F0B1560212EEB6F13E), 16);
			}
		}
	}
}
