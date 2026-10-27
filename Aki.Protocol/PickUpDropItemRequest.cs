using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D3B RID: 3387
	[NetMessage(EMessageId.PickUpDropItemRequest)]
	public sealed class PickUpDropItemRequest : IMessage<PickUpDropItemRequest>, IMessage, IEquatable<PickUpDropItemRequest>, IDeepCloneable<PickUpDropItemRequest>, IBufferMessage
	{
		// Token: 0x06012479 RID: 74873 RVA: 0x002AB045 File Offset: 0x002A9245
		[NullableContext(1)]
		public static PickUpDropItemRequest Create()
		{
			return new PickUpDropItemRequest();
		}

		// Token: 0x17003C91 RID: 15505
		// (get) Token: 0x0601247A RID: 74874 RVA: 0x002AB04C File Offset: 0x002A924C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C92 RID: 15506
		// (get) Token: 0x0601247B RID: 74875 RVA: 0x002AB04F File Offset: 0x002A924F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PickUpDropItemRequest.Descriptor;
			}
		}

		// Token: 0x0601247C RID: 74876 RVA: 0x002AB056 File Offset: 0x002A9256
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PickUpDropItemRequest()
		{
		}

		// Token: 0x0601247D RID: 74877 RVA: 0x002AB060 File Offset: 0x002A9260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PickUpDropItemRequest(PickUpDropItemRequest other) : this()
		{
			this.dropEntityId_ = other.dropEntityId_;
			this.itemGetFlow_ = ((other.itemGetFlow_ != null) ? other.itemGetFlow_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601247E RID: 74878 RVA: 0x002AB0AC File Offset: 0x002A92AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PickUpDropItemRequest Clone()
		{
			return new PickUpDropItemRequest(this);
		}

		// Token: 0x17003C93 RID: 15507
		// (get) Token: 0x0601247F RID: 74879 RVA: 0x002AB0B4 File Offset: 0x002A92B4
		// (set) Token: 0x06012480 RID: 74880 RVA: 0x002AB0BC File Offset: 0x002A92BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long DropEntityId
		{
			get
			{
				return this.dropEntityId_;
			}
			set
			{
				this.dropEntityId_ = value;
			}
		}

		// Token: 0x17003C94 RID: 15508
		// (get) Token: 0x06012481 RID: 74881 RVA: 0x002AB0C5 File Offset: 0x002A92C5
		// (set) Token: 0x06012482 RID: 74882 RVA: 0x002AB0CD File Offset: 0x002A92CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecItemGetFlowData ItemGetFlow
		{
			get
			{
				return this.itemGetFlow_;
			}
			set
			{
				this.itemGetFlow_ = value;
			}
		}

		// Token: 0x06012483 RID: 74883 RVA: 0x002AB0D6 File Offset: 0x002A92D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PickUpDropItemRequest);
		}

		// Token: 0x06012484 RID: 74884 RVA: 0x002AB0E4 File Offset: 0x002A92E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PickUpDropItemRequest other)
		{
			return other != null && (other == this || (this.DropEntityId == other.DropEntityId && object.Equals(this.ItemGetFlow, other.ItemGetFlow) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012485 RID: 74885 RVA: 0x002AB134 File Offset: 0x002A9334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DropEntityId != 0L)
			{
				num ^= this.DropEntityId.GetHashCode();
			}
			if (this.itemGetFlow_ != null)
			{
				num ^= this.ItemGetFlow.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012486 RID: 74886 RVA: 0x002AB189 File Offset: 0x002A9389
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012487 RID: 74887 RVA: 0x002AB196 File Offset: 0x002A9396
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012488 RID: 74888 RVA: 0x002AB1A0 File Offset: 0x002A93A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DropEntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.DropEntityId);
			}
			if (this.itemGetFlow_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ItemGetFlow);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012489 RID: 74889 RVA: 0x002AB1F8 File Offset: 0x002A93F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DropEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.DropEntityId);
			}
			if (this.itemGetFlow_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ItemGetFlow);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601248A RID: 74890 RVA: 0x002AB250 File Offset: 0x002A9450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PickUpDropItemRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DropEntityId != 0L)
			{
				this.DropEntityId = other.DropEntityId;
			}
			if (other.itemGetFlow_ != null)
			{
				if (this.itemGetFlow_ == null)
				{
					this.ItemGetFlow = new SecItemGetFlowData();
				}
				this.ItemGetFlow.MergeFrom(other.ItemGetFlow);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601248B RID: 74891 RVA: 0x002AB2B8 File Offset: 0x002A94B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601248C RID: 74892 RVA: 0x002AB2C4 File Offset: 0x002A94C4
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.itemGetFlow_ == null)
						{
							this.ItemGetFlow = new SecItemGetFlowData();
						}
						input.ReadMessage(this.ItemGetFlow);
					}
				}
				else
				{
					this.DropEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04007200 RID: 29184
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007201 RID: 29185
		public const int DropEntityIdFieldNumber = 1;

		// Token: 0x04007202 RID: 29186
		private long dropEntityId_;

		// Token: 0x04007203 RID: 29187
		public const int ItemGetFlowFieldNumber = 2;

		// Token: 0x04007204 RID: 29188
		private SecItemGetFlowData itemGetFlow_;
	}
}
