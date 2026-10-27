using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000139 RID: 313
	[NetMessage(EMessageId.AwakeDynamicPortalResponse)]
	public sealed class AwakeDynamicPortalResponse : IMessage<AwakeDynamicPortalResponse>, IMessage, IEquatable<AwakeDynamicPortalResponse>, IDeepCloneable<AwakeDynamicPortalResponse>, IBufferMessage
	{
		// Token: 0x060028ED RID: 10477 RVA: 0x0006BA63 File Offset: 0x00069C63
		[NullableContext(1)]
		public static AwakeDynamicPortalResponse Create()
		{
			return new AwakeDynamicPortalResponse();
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x060028EE RID: 10478 RVA: 0x0006BA6A File Offset: 0x00069C6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x060028EF RID: 10479 RVA: 0x0006BA6D File Offset: 0x00069C6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AwakeDynamicPortalResponse.Descriptor;
			}
		}

		// Token: 0x060028F0 RID: 10480 RVA: 0x0006BA74 File Offset: 0x00069C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AwakeDynamicPortalResponse()
		{
		}

		// Token: 0x060028F1 RID: 10481 RVA: 0x0006BA7C File Offset: 0x00069C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AwakeDynamicPortalResponse(AwakeDynamicPortalResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060028F2 RID: 10482 RVA: 0x0006BAA1 File Offset: 0x00069CA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AwakeDynamicPortalResponse Clone()
		{
			return new AwakeDynamicPortalResponse(this);
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x060028F3 RID: 10483 RVA: 0x0006BAA9 File Offset: 0x00069CA9
		// (set) Token: 0x060028F4 RID: 10484 RVA: 0x0006BAB1 File Offset: 0x00069CB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x060028F5 RID: 10485 RVA: 0x0006BABA File Offset: 0x00069CBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AwakeDynamicPortalResponse);
		}

		// Token: 0x060028F6 RID: 10486 RVA: 0x0006BAC8 File Offset: 0x00069CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AwakeDynamicPortalResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060028F7 RID: 10487 RVA: 0x0006BAF8 File Offset: 0x00069CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060028F8 RID: 10488 RVA: 0x0006BB3D File Offset: 0x00069D3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060028F9 RID: 10489 RVA: 0x0006BB4A File Offset: 0x00069D4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060028FA RID: 10490 RVA: 0x0006BB53 File Offset: 0x00069D53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060028FB RID: 10491 RVA: 0x0006BB88 File Offset: 0x00069D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060028FC RID: 10492 RVA: 0x0006BBC6 File Offset: 0x00069DC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AwakeDynamicPortalResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060028FD RID: 10493 RVA: 0x0006BBF7 File Offset: 0x00069DF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060028FE RID: 10494 RVA: 0x0006BC00 File Offset: 0x00069E00
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040026CF RID: 9935
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026D0 RID: 9936
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x040026D1 RID: 9937
		private ErrorCode errorCode_;
	}
}
