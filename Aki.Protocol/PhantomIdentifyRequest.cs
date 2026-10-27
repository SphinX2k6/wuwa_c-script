using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CD5 RID: 3285
	[NetMessage(EMessageId.PhantomIdentifyRequest)]
	public sealed class PhantomIdentifyRequest : IMessage<PhantomIdentifyRequest>, IMessage, IEquatable<PhantomIdentifyRequest>, IDeepCloneable<PhantomIdentifyRequest>, IBufferMessage
	{
		// Token: 0x06011C79 RID: 72825 RVA: 0x00299FC9 File Offset: 0x002981C9
		[NullableContext(1)]
		public static PhantomIdentifyRequest Create()
		{
			return new PhantomIdentifyRequest();
		}

		// Token: 0x17003AE9 RID: 15081
		// (get) Token: 0x06011C7A RID: 72826 RVA: 0x00299FD0 File Offset: 0x002981D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003AEA RID: 15082
		// (get) Token: 0x06011C7B RID: 72827 RVA: 0x00299FD3 File Offset: 0x002981D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomIdentifyRequest.Descriptor;
			}
		}

		// Token: 0x06011C7C RID: 72828 RVA: 0x00299FDA File Offset: 0x002981DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomIdentifyRequest()
		{
		}

		// Token: 0x06011C7D RID: 72829 RVA: 0x00299FE2 File Offset: 0x002981E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomIdentifyRequest(PhantomIdentifyRequest other) : this()
		{
			this.incrId_ = other.incrId_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011C7E RID: 72830 RVA: 0x0029A013 File Offset: 0x00298213
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomIdentifyRequest Clone()
		{
			return new PhantomIdentifyRequest(this);
		}

		// Token: 0x17003AEB RID: 15083
		// (get) Token: 0x06011C7F RID: 72831 RVA: 0x0029A01B File Offset: 0x0029821B
		// (set) Token: 0x06011C80 RID: 72832 RVA: 0x0029A023 File Offset: 0x00298223
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncrId
		{
			get
			{
				return this.incrId_;
			}
			set
			{
				this.incrId_ = value;
			}
		}

		// Token: 0x17003AEC RID: 15084
		// (get) Token: 0x06011C81 RID: 72833 RVA: 0x0029A02C File Offset: 0x0029822C
		// (set) Token: 0x06011C82 RID: 72834 RVA: 0x0029A034 File Offset: 0x00298234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x06011C83 RID: 72835 RVA: 0x0029A03D File Offset: 0x0029823D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomIdentifyRequest);
		}

		// Token: 0x06011C84 RID: 72836 RVA: 0x0029A04B File Offset: 0x0029824B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomIdentifyRequest other)
		{
			return other != null && (other == this || (this.IncrId == other.IncrId && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011C85 RID: 72837 RVA: 0x0029A08C File Offset: 0x0029828C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncrId != 0)
			{
				num ^= this.IncrId.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011C86 RID: 72838 RVA: 0x0029A0E4 File Offset: 0x002982E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011C87 RID: 72839 RVA: 0x0029A0F1 File Offset: 0x002982F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011C88 RID: 72840 RVA: 0x0029A0FC File Offset: 0x002982FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Count != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Count);
			}
			if (this.IncrId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.IncrId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011C89 RID: 72841 RVA: 0x0029A158 File Offset: 0x00298358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncrId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncrId);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011C8A RID: 72842 RVA: 0x0029A1B0 File Offset: 0x002983B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomIdentifyRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncrId != 0)
			{
				this.IncrId = other.IncrId;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011C8B RID: 72843 RVA: 0x0029A200 File Offset: 0x00298400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011C8C RID: 72844 RVA: 0x0029A20C File Offset: 0x0029840C
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
				if (num != 88U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IncrId = input.ReadInt32();
					}
				}
				else
				{
					this.Count = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006FB2 RID: 28594
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006FB3 RID: 28595
		public const int IncrIdFieldNumber = 15;

		// Token: 0x04006FB4 RID: 28596
		private int incrId_;

		// Token: 0x04006FB5 RID: 28597
		public const int CountFieldNumber = 11;

		// Token: 0x04006FB6 RID: 28598
		private int count_;
	}
}
