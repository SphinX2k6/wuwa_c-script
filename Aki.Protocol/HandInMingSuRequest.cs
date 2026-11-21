using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000726 RID: 1830
	[NetMessage(EMessageId.HandInMingSuRequest)]
	public sealed class HandInMingSuRequest : IMessage<HandInMingSuRequest>, IMessage, IEquatable<HandInMingSuRequest>, IDeepCloneable<HandInMingSuRequest>, IBufferMessage
	{
		// Token: 0x0600A65D RID: 42589 RVA: 0x00190FE5 File Offset: 0x0018F1E5
		[NullableContext(1)]
		public static HandInMingSuRequest Create()
		{
			return new HandInMingSuRequest();
		}

		// Token: 0x1700216D RID: 8557
		// (get) Token: 0x0600A65E RID: 42590 RVA: 0x00190FEC File Offset: 0x0018F1EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700216E RID: 8558
		// (get) Token: 0x0600A65F RID: 42591 RVA: 0x00190FEF File Offset: 0x0018F1EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HandInMingSuRequest.Descriptor;
			}
		}

		// Token: 0x0600A660 RID: 42592 RVA: 0x00190FF6 File Offset: 0x0018F1F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandInMingSuRequest()
		{
		}

		// Token: 0x0600A661 RID: 42593 RVA: 0x00190FFE File Offset: 0x0018F1FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandInMingSuRequest(HandInMingSuRequest other) : this()
		{
			this.dragonPoolId_ = other.dragonPoolId_;
			this.interactEntityId_ = other.interactEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A662 RID: 42594 RVA: 0x0019102F File Offset: 0x0018F22F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandInMingSuRequest Clone()
		{
			return new HandInMingSuRequest(this);
		}

		// Token: 0x1700216F RID: 8559
		// (get) Token: 0x0600A663 RID: 42595 RVA: 0x00191037 File Offset: 0x0018F237
		// (set) Token: 0x0600A664 RID: 42596 RVA: 0x0019103F File Offset: 0x0018F23F
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

		// Token: 0x17002170 RID: 8560
		// (get) Token: 0x0600A665 RID: 42597 RVA: 0x00191048 File Offset: 0x0018F248
		// (set) Token: 0x0600A666 RID: 42598 RVA: 0x00191050 File Offset: 0x0018F250
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

		// Token: 0x0600A667 RID: 42599 RVA: 0x00191059 File Offset: 0x0018F259
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HandInMingSuRequest);
		}

		// Token: 0x0600A668 RID: 42600 RVA: 0x00191067 File Offset: 0x0018F267
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HandInMingSuRequest other)
		{
			return other != null && (other == this || (this.DragonPoolId == other.DragonPoolId && this.InteractEntityId == other.InteractEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A669 RID: 42601 RVA: 0x001910A8 File Offset: 0x0018F2A8
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

		// Token: 0x0600A66A RID: 42602 RVA: 0x00191100 File Offset: 0x0018F300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A66B RID: 42603 RVA: 0x0019110D File Offset: 0x0018F30D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A66C RID: 42604 RVA: 0x00191118 File Offset: 0x0018F318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InteractEntityId != 0L)
			{
				output.WriteRawTag(24);
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

		// Token: 0x0600A66D RID: 42605 RVA: 0x00191174 File Offset: 0x0018F374
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

		// Token: 0x0600A66E RID: 42606 RVA: 0x001911CC File Offset: 0x0018F3CC
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

		// Token: 0x0600A66F RID: 42607 RVA: 0x0019121C File Offset: 0x0018F41C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A670 RID: 42608 RVA: 0x00191228 File Offset: 0x0018F428
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
				if (num != 24U)
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

		// Token: 0x04004C99 RID: 19609
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C9A RID: 19610
		public const int DragonPoolIdFieldNumber = 5;

		// Token: 0x04004C9B RID: 19611
		private int dragonPoolId_;

		// Token: 0x04004C9C RID: 19612
		public const int InteractEntityIdFieldNumber = 3;

		// Token: 0x04004C9D RID: 19613
		private long interactEntityId_;
	}
}
