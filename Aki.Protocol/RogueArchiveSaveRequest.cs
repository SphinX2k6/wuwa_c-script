using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F6E RID: 3950
	[NetMessage(EMessageId.RogueArchiveSaveRequest)]
	public sealed class RogueArchiveSaveRequest : IMessage<RogueArchiveSaveRequest>, IMessage, IEquatable<RogueArchiveSaveRequest>, IDeepCloneable<RogueArchiveSaveRequest>, IBufferMessage
	{
		// Token: 0x06015259 RID: 86617 RVA: 0x00311968 File Offset: 0x0030FB68
		[NullableContext(1)]
		public static RogueArchiveSaveRequest Create()
		{
			return new RogueArchiveSaveRequest();
		}

		// Token: 0x17004663 RID: 18019
		// (get) Token: 0x0601525A RID: 86618 RVA: 0x0031196F File Offset: 0x0030FB6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004664 RID: 18020
		// (get) Token: 0x0601525B RID: 86619 RVA: 0x00311972 File Offset: 0x0030FB72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueArchiveSaveRequest.Descriptor;
			}
		}

		// Token: 0x0601525C RID: 86620 RVA: 0x00311979 File Offset: 0x0030FB79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArchiveSaveRequest()
		{
		}

		// Token: 0x0601525D RID: 86621 RVA: 0x00311981 File Offset: 0x0030FB81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArchiveSaveRequest(RogueArchiveSaveRequest other) : this()
		{
			this.slotId_ = other.slotId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601525E RID: 86622 RVA: 0x003119A6 File Offset: 0x0030FBA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArchiveSaveRequest Clone()
		{
			return new RogueArchiveSaveRequest(this);
		}

		// Token: 0x17004665 RID: 18021
		// (get) Token: 0x0601525F RID: 86623 RVA: 0x003119AE File Offset: 0x0030FBAE
		// (set) Token: 0x06015260 RID: 86624 RVA: 0x003119B6 File Offset: 0x0030FBB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SlotId
		{
			get
			{
				return this.slotId_;
			}
			set
			{
				this.slotId_ = value;
			}
		}

		// Token: 0x06015261 RID: 86625 RVA: 0x003119BF File Offset: 0x0030FBBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueArchiveSaveRequest);
		}

		// Token: 0x06015262 RID: 86626 RVA: 0x003119CD File Offset: 0x0030FBCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueArchiveSaveRequest other)
		{
			return other != null && (other == this || (this.SlotId == other.SlotId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015263 RID: 86627 RVA: 0x003119FC File Offset: 0x0030FBFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SlotId != 0)
			{
				num ^= this.SlotId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015264 RID: 86628 RVA: 0x00311A3B File Offset: 0x0030FC3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015265 RID: 86629 RVA: 0x00311A48 File Offset: 0x0030FC48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015266 RID: 86630 RVA: 0x00311A51 File Offset: 0x0030FC51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SlotId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SlotId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015267 RID: 86631 RVA: 0x00311A84 File Offset: 0x0030FC84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SlotId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SlotId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015268 RID: 86632 RVA: 0x00311AC2 File Offset: 0x0030FCC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueArchiveSaveRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SlotId != 0)
			{
				this.SlotId = other.SlotId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015269 RID: 86633 RVA: 0x00311AF3 File Offset: 0x0030FCF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601526A RID: 86634 RVA: 0x00311AFC File Offset: 0x0030FCFC
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SlotId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007FAB RID: 32683
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007FAC RID: 32684
		public const int SlotIdFieldNumber = 3;

		// Token: 0x04007FAD RID: 32685
		private int slotId_;
	}
}
