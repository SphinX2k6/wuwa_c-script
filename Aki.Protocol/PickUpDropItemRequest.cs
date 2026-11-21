using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D2B RID: 3371
	[NetMessage(EMessageId.PickUpDropItemRequest)]
	public sealed class PickUpDropItemRequest : IMessage<PickUpDropItemRequest>, IMessage, IEquatable<PickUpDropItemRequest>, IDeepCloneable<PickUpDropItemRequest>, IBufferMessage
	{
		// Token: 0x0601237D RID: 74621 RVA: 0x002A941D File Offset: 0x002A761D
		[NullableContext(1)]
		public static PickUpDropItemRequest Create()
		{
			return new PickUpDropItemRequest();
		}

		// Token: 0x17003C5C RID: 15452
		// (get) Token: 0x0601237E RID: 74622 RVA: 0x002A9424 File Offset: 0x002A7624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C5D RID: 15453
		// (get) Token: 0x0601237F RID: 74623 RVA: 0x002A9427 File Offset: 0x002A7627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PickUpDropItemRequest.Descriptor;
			}
		}

		// Token: 0x06012380 RID: 74624 RVA: 0x002A942E File Offset: 0x002A762E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PickUpDropItemRequest()
		{
		}

		// Token: 0x06012381 RID: 74625 RVA: 0x002A9438 File Offset: 0x002A7638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PickUpDropItemRequest(PickUpDropItemRequest other) : this()
		{
			this.dropEntityId_ = other.dropEntityId_;
			this.itemGetFlow_ = ((other.itemGetFlow_ != null) ? other.itemGetFlow_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012382 RID: 74626 RVA: 0x002A9484 File Offset: 0x002A7684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PickUpDropItemRequest Clone()
		{
			return new PickUpDropItemRequest(this);
		}

		// Token: 0x17003C5E RID: 15454
		// (get) Token: 0x06012383 RID: 74627 RVA: 0x002A948C File Offset: 0x002A768C
		// (set) Token: 0x06012384 RID: 74628 RVA: 0x002A9494 File Offset: 0x002A7694
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

		// Token: 0x17003C5F RID: 15455
		// (get) Token: 0x06012385 RID: 74629 RVA: 0x002A949D File Offset: 0x002A769D
		// (set) Token: 0x06012386 RID: 74630 RVA: 0x002A94A5 File Offset: 0x002A76A5
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

		// Token: 0x06012387 RID: 74631 RVA: 0x002A94AE File Offset: 0x002A76AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PickUpDropItemRequest);
		}

		// Token: 0x06012388 RID: 74632 RVA: 0x002A94BC File Offset: 0x002A76BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PickUpDropItemRequest other)
		{
			return other != null && (other == this || (this.DropEntityId == other.DropEntityId && object.Equals(this.ItemGetFlow, other.ItemGetFlow) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012389 RID: 74633 RVA: 0x002A950C File Offset: 0x002A770C
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

		// Token: 0x0601238A RID: 74634 RVA: 0x002A9561 File Offset: 0x002A7761
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601238B RID: 74635 RVA: 0x002A956E File Offset: 0x002A776E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601238C RID: 74636 RVA: 0x002A9578 File Offset: 0x002A7778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DropEntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.DropEntityId);
			}
			if (this.itemGetFlow_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.ItemGetFlow);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601238D RID: 74637 RVA: 0x002A95D4 File Offset: 0x002A77D4
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

		// Token: 0x0601238E RID: 74638 RVA: 0x002A962C File Offset: 0x002A782C
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

		// Token: 0x0601238F RID: 74639 RVA: 0x002A9694 File Offset: 0x002A7894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012390 RID: 74640 RVA: 0x002A96A0 File Offset: 0x002A78A0
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
				if (num != 16U)
				{
					if (num != 90U)
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

		// Token: 0x04007218 RID: 29208
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007219 RID: 29209
		public const int DropEntityIdFieldNumber = 2;

		// Token: 0x0400721A RID: 29210
		private long dropEntityId_;

		// Token: 0x0400721B RID: 29211
		public const int ItemGetFlowFieldNumber = 11;

		// Token: 0x0400721C RID: 29212
		private SecItemGetFlowData itemGetFlow_;
	}
}
