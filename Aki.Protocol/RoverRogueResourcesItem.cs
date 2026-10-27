using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001119 RID: 4377
	public sealed class RoverRogueResourcesItem : IMessage<RoverRogueResourcesItem>, IMessage, IEquatable<RoverRogueResourcesItem>, IDeepCloneable<RoverRogueResourcesItem>, IBufferMessage
	{
		// Token: 0x06017576 RID: 95606 RVA: 0x003636D7 File Offset: 0x003618D7
		[NullableContext(1)]
		public static RoverRogueResourcesItem Create()
		{
			return new RoverRogueResourcesItem();
		}

		// Token: 0x17004E46 RID: 20038
		// (get) Token: 0x06017577 RID: 95607 RVA: 0x003636DE File Offset: 0x003618DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoverRogueResourcesItem> Parser
		{
			get
			{
				return RoverRogueResourcesItem._parser;
			}
		}

		// Token: 0x17004E47 RID: 20039
		// (get) Token: 0x06017578 RID: 95608 RVA: 0x003636E5 File Offset: 0x003618E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E48 RID: 20040
		// (get) Token: 0x06017579 RID: 95609 RVA: 0x003636E8 File Offset: 0x003618E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueResourcesItem.Descriptor;
			}
		}

		// Token: 0x0601757A RID: 95610 RVA: 0x003636EF File Offset: 0x003618EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueResourcesItem()
		{
		}

		// Token: 0x0601757B RID: 95611 RVA: 0x003636F7 File Offset: 0x003618F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueResourcesItem(RoverRogueResourcesItem other) : this()
		{
			this.confId_ = other.confId_;
			this.roundNum_ = other.roundNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601757C RID: 95612 RVA: 0x00363728 File Offset: 0x00361928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueResourcesItem Clone()
		{
			return new RoverRogueResourcesItem(this);
		}

		// Token: 0x17004E49 RID: 20041
		// (get) Token: 0x0601757D RID: 95613 RVA: 0x00363730 File Offset: 0x00361930
		// (set) Token: 0x0601757E RID: 95614 RVA: 0x00363738 File Offset: 0x00361938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfId
		{
			get
			{
				return this.confId_;
			}
			set
			{
				this.confId_ = value;
			}
		}

		// Token: 0x17004E4A RID: 20042
		// (get) Token: 0x0601757F RID: 95615 RVA: 0x00363741 File Offset: 0x00361941
		// (set) Token: 0x06017580 RID: 95616 RVA: 0x00363749 File Offset: 0x00361949
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoundNum
		{
			get
			{
				return this.roundNum_;
			}
			set
			{
				this.roundNum_ = value;
			}
		}

		// Token: 0x06017581 RID: 95617 RVA: 0x00363752 File Offset: 0x00361952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueResourcesItem);
		}

		// Token: 0x06017582 RID: 95618 RVA: 0x00363760 File Offset: 0x00361960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueResourcesItem other)
		{
			return other != null && (other == this || (this.ConfId == other.ConfId && this.RoundNum == other.RoundNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017583 RID: 95619 RVA: 0x003637A0 File Offset: 0x003619A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfId != 0)
			{
				num ^= this.ConfId.GetHashCode();
			}
			if (this.RoundNum != 0)
			{
				num ^= this.RoundNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017584 RID: 95620 RVA: 0x003637F8 File Offset: 0x003619F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017585 RID: 95621 RVA: 0x00363805 File Offset: 0x00361A05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017586 RID: 95622 RVA: 0x00363810 File Offset: 0x00361A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConfId);
			}
			if (this.RoundNum != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RoundNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017587 RID: 95623 RVA: 0x00363868 File Offset: 0x00361A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfId);
			}
			if (this.RoundNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoundNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017588 RID: 95624 RVA: 0x003638C0 File Offset: 0x00361AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueResourcesItem other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfId != 0)
			{
				this.ConfId = other.ConfId;
			}
			if (other.RoundNum != 0)
			{
				this.RoundNum = other.RoundNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017589 RID: 95625 RVA: 0x00363910 File Offset: 0x00361B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601758A RID: 95626 RVA: 0x0036391C File Offset: 0x00361B1C
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RoundNum = input.ReadInt32();
					}
				}
				else
				{
					this.ConfId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008AC2 RID: 35522
		private static readonly MessageParser<RoverRogueResourcesItem> _parser = new MessageParser<RoverRogueResourcesItem>(() => new RoverRogueResourcesItem());

		// Token: 0x04008AC3 RID: 35523
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008AC4 RID: 35524
		public const int ConfIdFieldNumber = 1;

		// Token: 0x04008AC5 RID: 35525
		private int confId_;

		// Token: 0x04008AC6 RID: 35526
		public const int RoundNumFieldNumber = 2;

		// Token: 0x04008AC7 RID: 35527
		private int roundNum_;
	}
}
