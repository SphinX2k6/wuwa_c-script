using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013D2 RID: 5074
	[NetMessage(EMessageId.ThirdPartyShareRequest)]
	public sealed class ThirdPartyShareRequest : IMessage<ThirdPartyShareRequest>, IMessage, IEquatable<ThirdPartyShareRequest>, IDeepCloneable<ThirdPartyShareRequest>, IBufferMessage
	{
		// Token: 0x0601AFFE RID: 110590 RVA: 0x003EE979 File Offset: 0x003ECB79
		[NullableContext(1)]
		public static ThirdPartyShareRequest Create()
		{
			return new ThirdPartyShareRequest();
		}

		// Token: 0x17005B72 RID: 23410
		// (get) Token: 0x0601AFFF RID: 110591 RVA: 0x003EE980 File Offset: 0x003ECB80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B73 RID: 23411
		// (get) Token: 0x0601B000 RID: 110592 RVA: 0x003EE983 File Offset: 0x003ECB83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ThirdPartyShareRequest.Descriptor;
			}
		}

		// Token: 0x0601B001 RID: 110593 RVA: 0x003EE98A File Offset: 0x003ECB8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThirdPartyShareRequest()
		{
		}

		// Token: 0x0601B002 RID: 110594 RVA: 0x003EE992 File Offset: 0x003ECB92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThirdPartyShareRequest(ThirdPartyShareRequest other) : this()
		{
			this.sharedId_ = other.sharedId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B003 RID: 110595 RVA: 0x003EE9B7 File Offset: 0x003ECBB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThirdPartyShareRequest Clone()
		{
			return new ThirdPartyShareRequest(this);
		}

		// Token: 0x17005B74 RID: 23412
		// (get) Token: 0x0601B004 RID: 110596 RVA: 0x003EE9BF File Offset: 0x003ECBBF
		// (set) Token: 0x0601B005 RID: 110597 RVA: 0x003EE9C7 File Offset: 0x003ECBC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SharedId
		{
			get
			{
				return this.sharedId_;
			}
			set
			{
				this.sharedId_ = value;
			}
		}

		// Token: 0x0601B006 RID: 110598 RVA: 0x003EE9D0 File Offset: 0x003ECBD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ThirdPartyShareRequest);
		}

		// Token: 0x0601B007 RID: 110599 RVA: 0x003EE9DE File Offset: 0x003ECBDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ThirdPartyShareRequest other)
		{
			return other != null && (other == this || (this.SharedId == other.SharedId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B008 RID: 110600 RVA: 0x003EEA0C File Offset: 0x003ECC0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SharedId != 0)
			{
				num ^= this.SharedId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B009 RID: 110601 RVA: 0x003EEA4B File Offset: 0x003ECC4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B00A RID: 110602 RVA: 0x003EEA58 File Offset: 0x003ECC58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B00B RID: 110603 RVA: 0x003EEA61 File Offset: 0x003ECC61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SharedId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.SharedId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B00C RID: 110604 RVA: 0x003EEA94 File Offset: 0x003ECC94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SharedId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SharedId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B00D RID: 110605 RVA: 0x003EEAD2 File Offset: 0x003ECCD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ThirdPartyShareRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SharedId != 0)
			{
				this.SharedId = other.SharedId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B00E RID: 110606 RVA: 0x003EEB03 File Offset: 0x003ECD03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B00F RID: 110607 RVA: 0x003EEB0C File Offset: 0x003ECD0C
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SharedId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009DCE RID: 40398
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009DCF RID: 40399
		public const int SharedIdFieldNumber = 9;

		// Token: 0x04009DD0 RID: 40400
		private int sharedId_;
	}
}
