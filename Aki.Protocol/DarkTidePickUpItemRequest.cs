using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003AF RID: 943
	[NetMessage(EMessageId.DarkTidePickUpItemRequest)]
	public sealed class DarkTidePickUpItemRequest : IMessage<DarkTidePickUpItemRequest>, IMessage, IEquatable<DarkTidePickUpItemRequest>, IDeepCloneable<DarkTidePickUpItemRequest>, IBufferMessage
	{
		// Token: 0x06005CA2 RID: 23714 RVA: 0x000E10E7 File Offset: 0x000DF2E7
		[NullableContext(1)]
		public static DarkTidePickUpItemRequest Create()
		{
			return new DarkTidePickUpItemRequest();
		}

		// Token: 0x17001131 RID: 4401
		// (get) Token: 0x06005CA3 RID: 23715 RVA: 0x000E10EE File Offset: 0x000DF2EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001132 RID: 4402
		// (get) Token: 0x06005CA4 RID: 23716 RVA: 0x000E10F1 File Offset: 0x000DF2F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DarkTidePickUpItemRequest.Descriptor;
			}
		}

		// Token: 0x06005CA5 RID: 23717 RVA: 0x000E10F8 File Offset: 0x000DF2F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTidePickUpItemRequest()
		{
		}

		// Token: 0x06005CA6 RID: 23718 RVA: 0x000E1100 File Offset: 0x000DF300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTidePickUpItemRequest(DarkTidePickUpItemRequest other) : this()
		{
			this.dropEntityId_ = other.dropEntityId_;
			this.replaceSlotId_ = other.replaceSlotId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005CA7 RID: 23719 RVA: 0x000E1131 File Offset: 0x000DF331
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTidePickUpItemRequest Clone()
		{
			return new DarkTidePickUpItemRequest(this);
		}

		// Token: 0x17001133 RID: 4403
		// (get) Token: 0x06005CA8 RID: 23720 RVA: 0x000E1139 File Offset: 0x000DF339
		// (set) Token: 0x06005CA9 RID: 23721 RVA: 0x000E1141 File Offset: 0x000DF341
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

		// Token: 0x17001134 RID: 4404
		// (get) Token: 0x06005CAA RID: 23722 RVA: 0x000E114A File Offset: 0x000DF34A
		// (set) Token: 0x06005CAB RID: 23723 RVA: 0x000E1152 File Offset: 0x000DF352
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ReplaceSlotId
		{
			get
			{
				return this.replaceSlotId_;
			}
			set
			{
				this.replaceSlotId_ = value;
			}
		}

		// Token: 0x06005CAC RID: 23724 RVA: 0x000E115B File Offset: 0x000DF35B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DarkTidePickUpItemRequest);
		}

		// Token: 0x06005CAD RID: 23725 RVA: 0x000E1169 File Offset: 0x000DF369
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DarkTidePickUpItemRequest other)
		{
			return other != null && (other == this || (this.DropEntityId == other.DropEntityId && this.ReplaceSlotId == other.ReplaceSlotId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005CAE RID: 23726 RVA: 0x000E11A8 File Offset: 0x000DF3A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DropEntityId != 0L)
			{
				num ^= this.DropEntityId.GetHashCode();
			}
			if (this.ReplaceSlotId != 0)
			{
				num ^= this.ReplaceSlotId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005CAF RID: 23727 RVA: 0x000E1200 File Offset: 0x000DF400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005CB0 RID: 23728 RVA: 0x000E120D File Offset: 0x000DF40D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005CB1 RID: 23729 RVA: 0x000E1218 File Offset: 0x000DF418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DropEntityId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.DropEntityId);
			}
			if (this.ReplaceSlotId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ReplaceSlotId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005CB2 RID: 23730 RVA: 0x000E1274 File Offset: 0x000DF474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DropEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.DropEntityId);
			}
			if (this.ReplaceSlotId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ReplaceSlotId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005CB3 RID: 23731 RVA: 0x000E12CC File Offset: 0x000DF4CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DarkTidePickUpItemRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DropEntityId != 0L)
			{
				this.DropEntityId = other.DropEntityId;
			}
			if (other.ReplaceSlotId != 0)
			{
				this.ReplaceSlotId = other.ReplaceSlotId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005CB4 RID: 23732 RVA: 0x000E131C File Offset: 0x000DF51C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005CB5 RID: 23733 RVA: 0x000E1328 File Offset: 0x000DF528
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
				if (num != 40U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ReplaceSlotId = input.ReadInt32();
					}
				}
				else
				{
					this.DropEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003659 RID: 13913
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400365A RID: 13914
		public const int DropEntityIdFieldNumber = 5;

		// Token: 0x0400365B RID: 13915
		private long dropEntityId_;

		// Token: 0x0400365C RID: 13916
		public const int ReplaceSlotIdFieldNumber = 12;

		// Token: 0x0400365D RID: 13917
		private int replaceSlotId_;
	}
}
