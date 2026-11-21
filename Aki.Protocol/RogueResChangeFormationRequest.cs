using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FC1 RID: 4033
	[NetMessage(EMessageId.RogueResChangeFormationRequest)]
	public sealed class RogueResChangeFormationRequest : IMessage<RogueResChangeFormationRequest>, IMessage, IEquatable<RogueResChangeFormationRequest>, IDeepCloneable<RogueResChangeFormationRequest>, IBufferMessage
	{
		// Token: 0x06015965 RID: 88421 RVA: 0x00322B6F File Offset: 0x00320D6F
		[NullableContext(1)]
		public static RogueResChangeFormationRequest Create()
		{
			return new RogueResChangeFormationRequest();
		}

		// Token: 0x17004803 RID: 18435
		// (get) Token: 0x06015966 RID: 88422 RVA: 0x00322B76 File Offset: 0x00320D76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004804 RID: 18436
		// (get) Token: 0x06015967 RID: 88423 RVA: 0x00322B79 File Offset: 0x00320D79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResChangeFormationRequest.Descriptor;
			}
		}

		// Token: 0x06015968 RID: 88424 RVA: 0x00322B80 File Offset: 0x00320D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResChangeFormationRequest()
		{
		}

		// Token: 0x06015969 RID: 88425 RVA: 0x00322B88 File Offset: 0x00320D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResChangeFormationRequest(RogueResChangeFormationRequest other) : this()
		{
			this.index_ = other.index_;
			this.rogueResFormation_ = ((other.rogueResFormation_ != null) ? other.rogueResFormation_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601596A RID: 88426 RVA: 0x00322BD4 File Offset: 0x00320DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResChangeFormationRequest Clone()
		{
			return new RogueResChangeFormationRequest(this);
		}

		// Token: 0x17004805 RID: 18437
		// (get) Token: 0x0601596B RID: 88427 RVA: 0x00322BDC File Offset: 0x00320DDC
		// (set) Token: 0x0601596C RID: 88428 RVA: 0x00322BE4 File Offset: 0x00320DE4
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

		// Token: 0x17004806 RID: 18438
		// (get) Token: 0x0601596D RID: 88429 RVA: 0x00322BED File Offset: 0x00320DED
		// (set) Token: 0x0601596E RID: 88430 RVA: 0x00322BF5 File Offset: 0x00320DF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResFormation RogueResFormation
		{
			get
			{
				return this.rogueResFormation_;
			}
			set
			{
				this.rogueResFormation_ = value;
			}
		}

		// Token: 0x0601596F RID: 88431 RVA: 0x00322BFE File Offset: 0x00320DFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResChangeFormationRequest);
		}

		// Token: 0x06015970 RID: 88432 RVA: 0x00322C0C File Offset: 0x00320E0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResChangeFormationRequest other)
		{
			return other != null && (other == this || (this.Index == other.Index && object.Equals(this.RogueResFormation, other.RogueResFormation) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015971 RID: 88433 RVA: 0x00322C5C File Offset: 0x00320E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.rogueResFormation_ != null)
			{
				num ^= this.RogueResFormation.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015972 RID: 88434 RVA: 0x00322CB1 File Offset: 0x00320EB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015973 RID: 88435 RVA: 0x00322CBE File Offset: 0x00320EBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015974 RID: 88436 RVA: 0x00322CC8 File Offset: 0x00320EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Index);
			}
			if (this.rogueResFormation_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.RogueResFormation);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015975 RID: 88437 RVA: 0x00322D24 File Offset: 0x00320F24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this.rogueResFormation_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueResFormation);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015976 RID: 88438 RVA: 0x00322D7C File Offset: 0x00320F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResChangeFormationRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			if (other.rogueResFormation_ != null)
			{
				if (this.rogueResFormation_ == null)
				{
					this.RogueResFormation = new RogueResFormation();
				}
				this.RogueResFormation.MergeFrom(other.RogueResFormation);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015977 RID: 88439 RVA: 0x00322DE4 File Offset: 0x00320FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015978 RID: 88440 RVA: 0x00322DF0 File Offset: 0x00320FF0
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
					if (num != 34U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.rogueResFormation_ == null)
						{
							this.RogueResFormation = new RogueResFormation();
						}
						input.ReadMessage(this.RogueResFormation);
					}
				}
				else
				{
					this.Index = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400821C RID: 33308
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400821D RID: 33309
		public const int IndexFieldNumber = 3;

		// Token: 0x0400821E RID: 33310
		private int index_;

		// Token: 0x0400821F RID: 33311
		public const int RogueResFormationFieldNumber = 4;

		// Token: 0x04008220 RID: 33312
		private RogueResFormation rogueResFormation_;
	}
}
