using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007AA RID: 1962
	public sealed class ICustomScreenLoadingCyberpunkPb : IMessage<ICustomScreenLoadingCyberpunkPb>, IMessage, IEquatable<ICustomScreenLoadingCyberpunkPb>, IDeepCloneable<ICustomScreenLoadingCyberpunkPb>, IBufferMessage
	{
		// Token: 0x0600B101 RID: 45313 RVA: 0x001A86F1 File Offset: 0x001A68F1
		[NullableContext(1)]
		public static ICustomScreenLoadingCyberpunkPb Create()
		{
			return new ICustomScreenLoadingCyberpunkPb();
		}

		// Token: 0x170023AF RID: 9135
		// (get) Token: 0x0600B102 RID: 45314 RVA: 0x001A86F8 File Offset: 0x001A68F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023B0 RID: 9136
		// (get) Token: 0x0600B103 RID: 45315 RVA: 0x001A86FB File Offset: 0x001A68FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ICustomScreenLoadingCyberpunkPb.Descriptor;
			}
		}

		// Token: 0x0600B104 RID: 45316 RVA: 0x001A8702 File Offset: 0x001A6902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenLoadingCyberpunkPb()
		{
		}

		// Token: 0x0600B105 RID: 45317 RVA: 0x001A870A File Offset: 0x001A690A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenLoadingCyberpunkPb(ICustomScreenLoadingCyberpunkPb other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B106 RID: 45318 RVA: 0x001A8723 File Offset: 0x001A6923
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenLoadingCyberpunkPb Clone()
		{
			return new ICustomScreenLoadingCyberpunkPb(this);
		}

		// Token: 0x0600B107 RID: 45319 RVA: 0x001A872B File Offset: 0x001A692B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ICustomScreenLoadingCyberpunkPb);
		}

		// Token: 0x0600B108 RID: 45320 RVA: 0x001A8739 File Offset: 0x001A6939
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ICustomScreenLoadingCyberpunkPb other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600B109 RID: 45321 RVA: 0x001A8758 File Offset: 0x001A6958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B10A RID: 45322 RVA: 0x001A877E File Offset: 0x001A697E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B10B RID: 45323 RVA: 0x001A878B File Offset: 0x001A698B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B10C RID: 45324 RVA: 0x001A8794 File Offset: 0x001A6994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B10D RID: 45325 RVA: 0x001A87AC File Offset: 0x001A69AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B10E RID: 45326 RVA: 0x001A87D2 File Offset: 0x001A69D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ICustomScreenLoadingCyberpunkPb other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B10F RID: 45327 RVA: 0x001A87EF File Offset: 0x001A69EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B110 RID: 45328 RVA: 0x001A87F8 File Offset: 0x001A69F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004FB7 RID: 20407
		private UnknownFieldSet _unknownFields;
	}
}
