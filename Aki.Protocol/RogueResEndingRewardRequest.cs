using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FD7 RID: 4055
	[NetMessage(EMessageId.RogueResEndingRewardRequest)]
	public sealed class RogueResEndingRewardRequest : IMessage<RogueResEndingRewardRequest>, IMessage, IEquatable<RogueResEndingRewardRequest>, IDeepCloneable<RogueResEndingRewardRequest>, IBufferMessage
	{
		// Token: 0x06015AC4 RID: 88772 RVA: 0x00325309 File Offset: 0x00323509
		[NullableContext(1)]
		public static RogueResEndingRewardRequest Create()
		{
			return new RogueResEndingRewardRequest();
		}

		// Token: 0x17004846 RID: 18502
		// (get) Token: 0x06015AC5 RID: 88773 RVA: 0x00325310 File Offset: 0x00323510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004847 RID: 18503
		// (get) Token: 0x06015AC6 RID: 88774 RVA: 0x00325313 File Offset: 0x00323513
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResEndingRewardRequest.Descriptor;
			}
		}

		// Token: 0x06015AC7 RID: 88775 RVA: 0x0032531A File Offset: 0x0032351A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResEndingRewardRequest()
		{
		}

		// Token: 0x06015AC8 RID: 88776 RVA: 0x00325322 File Offset: 0x00323522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResEndingRewardRequest(RogueResEndingRewardRequest other) : this()
		{
			this.seasonId_ = other.seasonId_;
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015AC9 RID: 88777 RVA: 0x00325353 File Offset: 0x00323553
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResEndingRewardRequest Clone()
		{
			return new RogueResEndingRewardRequest(this);
		}

		// Token: 0x17004848 RID: 18504
		// (get) Token: 0x06015ACA RID: 88778 RVA: 0x0032535B File Offset: 0x0032355B
		// (set) Token: 0x06015ACB RID: 88779 RVA: 0x00325363 File Offset: 0x00323563
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SeasonId
		{
			get
			{
				return this.seasonId_;
			}
			set
			{
				this.seasonId_ = value;
			}
		}

		// Token: 0x17004849 RID: 18505
		// (get) Token: 0x06015ACC RID: 88780 RVA: 0x0032536C File Offset: 0x0032356C
		// (set) Token: 0x06015ACD RID: 88781 RVA: 0x00325374 File Offset: 0x00323574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x06015ACE RID: 88782 RVA: 0x0032537D File Offset: 0x0032357D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResEndingRewardRequest);
		}

		// Token: 0x06015ACF RID: 88783 RVA: 0x0032538B File Offset: 0x0032358B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResEndingRewardRequest other)
		{
			return other != null && (other == this || (this.SeasonId == other.SeasonId && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015AD0 RID: 88784 RVA: 0x003253CC File Offset: 0x003235CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SeasonId != 0)
			{
				num ^= this.SeasonId.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015AD1 RID: 88785 RVA: 0x00325424 File Offset: 0x00323624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015AD2 RID: 88786 RVA: 0x00325431 File Offset: 0x00323631
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015AD3 RID: 88787 RVA: 0x0032543C File Offset: 0x0032363C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Index);
			}
			if (this.SeasonId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.SeasonId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015AD4 RID: 88788 RVA: 0x00325498 File Offset: 0x00323698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SeasonId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SeasonId);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015AD5 RID: 88789 RVA: 0x003254F0 File Offset: 0x003236F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResEndingRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SeasonId != 0)
			{
				this.SeasonId = other.SeasonId;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015AD6 RID: 88790 RVA: 0x00325540 File Offset: 0x00323740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015AD7 RID: 88791 RVA: 0x0032554C File Offset: 0x0032374C
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
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SeasonId = input.ReadInt32();
					}
				}
				else
				{
					this.Index = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008215 RID: 33301
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008216 RID: 33302
		public const int SeasonIdFieldNumber = 13;

		// Token: 0x04008217 RID: 33303
		private int seasonId_;

		// Token: 0x04008218 RID: 33304
		public const int IndexFieldNumber = 3;

		// Token: 0x04008219 RID: 33305
		private int index_;
	}
}
