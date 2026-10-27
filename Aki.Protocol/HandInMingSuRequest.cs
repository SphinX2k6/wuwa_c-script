using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200073A RID: 1850
	[NetMessage(EMessageId.HandInMingSuRequest)]
	public sealed class HandInMingSuRequest : IMessage<HandInMingSuRequest>, IMessage, IEquatable<HandInMingSuRequest>, IDeepCloneable<HandInMingSuRequest>, IBufferMessage
	{
		// Token: 0x0600A7B3 RID: 42931 RVA: 0x00193A19 File Offset: 0x00191C19
		[NullableContext(1)]
		public static HandInMingSuRequest Create()
		{
			return new HandInMingSuRequest();
		}

		// Token: 0x170021B7 RID: 8631
		// (get) Token: 0x0600A7B4 RID: 42932 RVA: 0x00193A20 File Offset: 0x00191C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170021B8 RID: 8632
		// (get) Token: 0x0600A7B5 RID: 42933 RVA: 0x00193A23 File Offset: 0x00191C23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HandInMingSuRequest.Descriptor;
			}
		}

		// Token: 0x0600A7B6 RID: 42934 RVA: 0x00193A2A File Offset: 0x00191C2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandInMingSuRequest()
		{
		}

		// Token: 0x0600A7B7 RID: 42935 RVA: 0x00193A32 File Offset: 0x00191C32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandInMingSuRequest(HandInMingSuRequest other) : this()
		{
			this.dragonPoolId_ = other.dragonPoolId_;
			this.interactEntityId_ = other.interactEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A7B8 RID: 42936 RVA: 0x00193A63 File Offset: 0x00191C63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandInMingSuRequest Clone()
		{
			return new HandInMingSuRequest(this);
		}

		// Token: 0x170021B9 RID: 8633
		// (get) Token: 0x0600A7B9 RID: 42937 RVA: 0x00193A6B File Offset: 0x00191C6B
		// (set) Token: 0x0600A7BA RID: 42938 RVA: 0x00193A73 File Offset: 0x00191C73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DragonPoolId
		{
			get
			{
				return this.dragonPoolId_;
			}
			set
			{
				this.dragonPoolId_ = value;
			}
		}

		// Token: 0x170021BA RID: 8634
		// (get) Token: 0x0600A7BB RID: 42939 RVA: 0x00193A7C File Offset: 0x00191C7C
		// (set) Token: 0x0600A7BC RID: 42940 RVA: 0x00193A84 File Offset: 0x00191C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long InteractEntityId
		{
			get
			{
				return this.interactEntityId_;
			}
			set
			{
				this.interactEntityId_ = value;
			}
		}

		// Token: 0x0600A7BD RID: 42941 RVA: 0x00193A8D File Offset: 0x00191C8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HandInMingSuRequest);
		}

		// Token: 0x0600A7BE RID: 42942 RVA: 0x00193A9B File Offset: 0x00191C9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HandInMingSuRequest other)
		{
			return other != null && (other == this || (this.DragonPoolId == other.DragonPoolId && this.InteractEntityId == other.InteractEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A7BF RID: 42943 RVA: 0x00193ADC File Offset: 0x00191CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DragonPoolId != 0)
			{
				num ^= this.DragonPoolId.GetHashCode();
			}
			if (this.InteractEntityId != 0L)
			{
				num ^= this.InteractEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A7C0 RID: 42944 RVA: 0x00193B34 File Offset: 0x00191D34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A7C1 RID: 42945 RVA: 0x00193B41 File Offset: 0x00191D41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A7C2 RID: 42946 RVA: 0x00193B4C File Offset: 0x00191D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InteractEntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.InteractEntityId);
			}
			if (this.DragonPoolId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.DragonPoolId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A7C3 RID: 42947 RVA: 0x00193BA4 File Offset: 0x00191DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DragonPoolId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DragonPoolId);
			}
			if (this.InteractEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.InteractEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A7C4 RID: 42948 RVA: 0x00193BFC File Offset: 0x00191DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HandInMingSuRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DragonPoolId != 0)
			{
				this.DragonPoolId = other.DragonPoolId;
			}
			if (other.InteractEntityId != 0L)
			{
				this.InteractEntityId = other.InteractEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A7C5 RID: 42949 RVA: 0x00193C4C File Offset: 0x00191E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A7C6 RID: 42950 RVA: 0x00193C58 File Offset: 0x00191E58
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
				if (num != 8U)
				{
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.DragonPoolId = input.ReadInt32();
					}
				}
				else
				{
					this.InteractEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04004CA0 RID: 19616
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004CA1 RID: 19617
		public const int DragonPoolIdFieldNumber = 5;

		// Token: 0x04004CA2 RID: 19618
		private int dragonPoolId_;

		// Token: 0x04004CA3 RID: 19619
		public const int InteractEntityIdFieldNumber = 1;

		// Token: 0x04004CA4 RID: 19620
		private long interactEntityId_;
	}
}
