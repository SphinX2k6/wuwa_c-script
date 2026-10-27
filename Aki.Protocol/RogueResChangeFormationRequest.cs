using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FD1 RID: 4049
	[NetMessage(EMessageId.RogueResChangeFormationRequest)]
	public sealed class RogueResChangeFormationRequest : IMessage<RogueResChangeFormationRequest>, IMessage, IEquatable<RogueResChangeFormationRequest>, IDeepCloneable<RogueResChangeFormationRequest>, IBufferMessage
	{
		// Token: 0x06015A4A RID: 88650 RVA: 0x00324223 File Offset: 0x00322423
		[NullableContext(1)]
		public static RogueResChangeFormationRequest Create()
		{
			return new RogueResChangeFormationRequest();
		}

		// Token: 0x1700482D RID: 18477
		// (get) Token: 0x06015A4B RID: 88651 RVA: 0x0032422A File Offset: 0x0032242A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700482E RID: 18478
		// (get) Token: 0x06015A4C RID: 88652 RVA: 0x0032422D File Offset: 0x0032242D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResChangeFormationRequest.Descriptor;
			}
		}

		// Token: 0x06015A4D RID: 88653 RVA: 0x00324234 File Offset: 0x00322434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResChangeFormationRequest()
		{
		}

		// Token: 0x06015A4E RID: 88654 RVA: 0x0032423C File Offset: 0x0032243C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResChangeFormationRequest(RogueResChangeFormationRequest other) : this()
		{
			this.index_ = other.index_;
			this.rogueResFormation_ = ((other.rogueResFormation_ != null) ? other.rogueResFormation_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015A4F RID: 88655 RVA: 0x00324288 File Offset: 0x00322488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResChangeFormationRequest Clone()
		{
			return new RogueResChangeFormationRequest(this);
		}

		// Token: 0x1700482F RID: 18479
		// (get) Token: 0x06015A50 RID: 88656 RVA: 0x00324290 File Offset: 0x00322490
		// (set) Token: 0x06015A51 RID: 88657 RVA: 0x00324298 File Offset: 0x00322498
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

		// Token: 0x17004830 RID: 18480
		// (get) Token: 0x06015A52 RID: 88658 RVA: 0x003242A1 File Offset: 0x003224A1
		// (set) Token: 0x06015A53 RID: 88659 RVA: 0x003242A9 File Offset: 0x003224A9
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

		// Token: 0x06015A54 RID: 88660 RVA: 0x003242B2 File Offset: 0x003224B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResChangeFormationRequest);
		}

		// Token: 0x06015A55 RID: 88661 RVA: 0x003242C0 File Offset: 0x003224C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResChangeFormationRequest other)
		{
			return other != null && (other == this || (this.Index == other.Index && object.Equals(this.RogueResFormation, other.RogueResFormation) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015A56 RID: 88662 RVA: 0x00324310 File Offset: 0x00322510
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

		// Token: 0x06015A57 RID: 88663 RVA: 0x00324365 File Offset: 0x00322565
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015A58 RID: 88664 RVA: 0x00324372 File Offset: 0x00322572
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015A59 RID: 88665 RVA: 0x0032437C File Offset: 0x0032257C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueResFormation_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.RogueResFormation);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015A5A RID: 88666 RVA: 0x003243D8 File Offset: 0x003225D8
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

		// Token: 0x06015A5B RID: 88667 RVA: 0x00324430 File Offset: 0x00322630
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

		// Token: 0x06015A5C RID: 88668 RVA: 0x00324498 File Offset: 0x00322698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015A5D RID: 88669 RVA: 0x003244A4 File Offset: 0x003226A4
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
				if (num != 18U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Index = input.ReadInt32();
					}
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
		}

		// Token: 0x040081F2 RID: 33266
		private UnknownFieldSet _unknownFields;

		// Token: 0x040081F3 RID: 33267
		public const int IndexFieldNumber = 9;

		// Token: 0x040081F4 RID: 33268
		private int index_;

		// Token: 0x040081F5 RID: 33269
		public const int RogueResFormationFieldNumber = 2;

		// Token: 0x040081F6 RID: 33270
		private RogueResFormation rogueResFormation_;
	}
}
