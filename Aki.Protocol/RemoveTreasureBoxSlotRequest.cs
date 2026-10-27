using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F10 RID: 3856
	[NetMessage(EMessageId.RemoveTreasureBoxSlotRequest)]
	public sealed class RemoveTreasureBoxSlotRequest : IMessage<RemoveTreasureBoxSlotRequest>, IMessage, IEquatable<RemoveTreasureBoxSlotRequest>, IDeepCloneable<RemoveTreasureBoxSlotRequest>, IBufferMessage
	{
		// Token: 0x06014A56 RID: 84566 RVA: 0x002FF4D9 File Offset: 0x002FD6D9
		[NullableContext(1)]
		public static RemoveTreasureBoxSlotRequest Create()
		{
			return new RemoveTreasureBoxSlotRequest();
		}

		// Token: 0x170044A2 RID: 17570
		// (get) Token: 0x06014A57 RID: 84567 RVA: 0x002FF4E0 File Offset: 0x002FD6E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170044A3 RID: 17571
		// (get) Token: 0x06014A58 RID: 84568 RVA: 0x002FF4E3 File Offset: 0x002FD6E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveTreasureBoxSlotRequest.Descriptor;
			}
		}

		// Token: 0x06014A59 RID: 84569 RVA: 0x002FF4EA File Offset: 0x002FD6EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveTreasureBoxSlotRequest()
		{
		}

		// Token: 0x06014A5A RID: 84570 RVA: 0x002FF4F2 File Offset: 0x002FD6F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveTreasureBoxSlotRequest(RemoveTreasureBoxSlotRequest other) : this()
		{
			this.detectionSlotId_ = other.detectionSlotId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014A5B RID: 84571 RVA: 0x002FF517 File Offset: 0x002FD717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveTreasureBoxSlotRequest Clone()
		{
			return new RemoveTreasureBoxSlotRequest(this);
		}

		// Token: 0x170044A4 RID: 17572
		// (get) Token: 0x06014A5C RID: 84572 RVA: 0x002FF51F File Offset: 0x002FD71F
		// (set) Token: 0x06014A5D RID: 84573 RVA: 0x002FF527 File Offset: 0x002FD727
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long DetectionSlotId
		{
			get
			{
				return this.detectionSlotId_;
			}
			set
			{
				this.detectionSlotId_ = value;
			}
		}

		// Token: 0x06014A5E RID: 84574 RVA: 0x002FF530 File Offset: 0x002FD730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveTreasureBoxSlotRequest);
		}

		// Token: 0x06014A5F RID: 84575 RVA: 0x002FF53E File Offset: 0x002FD73E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveTreasureBoxSlotRequest other)
		{
			return other != null && (other == this || (this.DetectionSlotId == other.DetectionSlotId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014A60 RID: 84576 RVA: 0x002FF56C File Offset: 0x002FD76C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DetectionSlotId != 0L)
			{
				num ^= this.DetectionSlotId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014A61 RID: 84577 RVA: 0x002FF5AB File Offset: 0x002FD7AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014A62 RID: 84578 RVA: 0x002FF5B8 File Offset: 0x002FD7B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014A63 RID: 84579 RVA: 0x002FF5C1 File Offset: 0x002FD7C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DetectionSlotId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.DetectionSlotId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014A64 RID: 84580 RVA: 0x002FF5F4 File Offset: 0x002FD7F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DetectionSlotId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.DetectionSlotId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014A65 RID: 84581 RVA: 0x002FF632 File Offset: 0x002FD832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveTreasureBoxSlotRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DetectionSlotId != 0L)
			{
				this.DetectionSlotId = other.DetectionSlotId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014A66 RID: 84582 RVA: 0x002FF663 File Offset: 0x002FD863
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014A67 RID: 84583 RVA: 0x002FF66C File Offset: 0x002FD86C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.DetectionSlotId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04007CE6 RID: 31974
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007CE7 RID: 31975
		public const int DetectionSlotIdFieldNumber = 5;

		// Token: 0x04007CE8 RID: 31976
		private long detectionSlotId_;
	}
}
