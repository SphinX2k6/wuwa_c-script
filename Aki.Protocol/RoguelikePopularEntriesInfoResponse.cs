using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FA8 RID: 4008
	[NetMessage(EMessageId.RoguelikePopularEntriesInfoResponse)]
	public sealed class RoguelikePopularEntriesInfoResponse : IMessage<RoguelikePopularEntriesInfoResponse>, IMessage, IEquatable<RoguelikePopularEntriesInfoResponse>, IDeepCloneable<RoguelikePopularEntriesInfoResponse>, IBufferMessage
	{
		// Token: 0x060156EB RID: 87787 RVA: 0x0031C5C8 File Offset: 0x0031A7C8
		[NullableContext(1)]
		public static RoguelikePopularEntriesInfoResponse Create()
		{
			return new RoguelikePopularEntriesInfoResponse();
		}

		// Token: 0x17004772 RID: 18290
		// (get) Token: 0x060156EC RID: 87788 RVA: 0x0031C5CF File Offset: 0x0031A7CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004773 RID: 18291
		// (get) Token: 0x060156ED RID: 87789 RVA: 0x0031C5D2 File Offset: 0x0031A7D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikePopularEntriesInfoResponse.Descriptor;
			}
		}

		// Token: 0x060156EE RID: 87790 RVA: 0x0031C5D9 File Offset: 0x0031A7D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikePopularEntriesInfoResponse()
		{
		}

		// Token: 0x060156EF RID: 87791 RVA: 0x0031C5E4 File Offset: 0x0031A7E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikePopularEntriesInfoResponse(RoguelikePopularEntriesInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.popularEntrie_ = ((other.popularEntrie_ != null) ? other.popularEntrie_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060156F0 RID: 87792 RVA: 0x0031C630 File Offset: 0x0031A830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikePopularEntriesInfoResponse Clone()
		{
			return new RoguelikePopularEntriesInfoResponse(this);
		}

		// Token: 0x17004774 RID: 18292
		// (get) Token: 0x060156F1 RID: 87793 RVA: 0x0031C638 File Offset: 0x0031A838
		// (set) Token: 0x060156F2 RID: 87794 RVA: 0x0031C640 File Offset: 0x0031A840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17004775 RID: 18293
		// (get) Token: 0x060156F3 RID: 87795 RVA: 0x0031C649 File Offset: 0x0031A849
		// (set) Token: 0x060156F4 RID: 87796 RVA: 0x0031C651 File Offset: 0x0031A851
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PopularEntrie PopularEntrie
		{
			get
			{
				return this.popularEntrie_;
			}
			set
			{
				this.popularEntrie_ = value;
			}
		}

		// Token: 0x060156F5 RID: 87797 RVA: 0x0031C65A File Offset: 0x0031A85A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikePopularEntriesInfoResponse);
		}

		// Token: 0x060156F6 RID: 87798 RVA: 0x0031C668 File Offset: 0x0031A868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikePopularEntriesInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.PopularEntrie, other.PopularEntrie) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060156F7 RID: 87799 RVA: 0x0031C6B8 File Offset: 0x0031A8B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.popularEntrie_ != null)
			{
				num ^= this.PopularEntrie.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060156F8 RID: 87800 RVA: 0x0031C713 File Offset: 0x0031A913
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060156F9 RID: 87801 RVA: 0x0031C720 File Offset: 0x0031A920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060156FA RID: 87802 RVA: 0x0031C72C File Offset: 0x0031A92C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.popularEntrie_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.PopularEntrie);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060156FB RID: 87803 RVA: 0x0031C788 File Offset: 0x0031A988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.popularEntrie_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PopularEntrie);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060156FC RID: 87804 RVA: 0x0031C7E0 File Offset: 0x0031A9E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikePopularEntriesInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.popularEntrie_ != null)
			{
				if (this.popularEntrie_ == null)
				{
					this.PopularEntrie = new PopularEntrie();
				}
				this.PopularEntrie.MergeFrom(other.PopularEntrie);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060156FD RID: 87805 RVA: 0x0031C848 File Offset: 0x0031AA48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060156FE RID: 87806 RVA: 0x0031C854 File Offset: 0x0031AA54
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
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					if (this.popularEntrie_ == null)
					{
						this.PopularEntrie = new PopularEntrie();
					}
					input.ReadMessage(this.PopularEntrie);
				}
			}
		}

		// Token: 0x040080E9 RID: 33001
		private UnknownFieldSet _unknownFields;

		// Token: 0x040080EA RID: 33002
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x040080EB RID: 33003
		private ErrorCode errorCode_;

		// Token: 0x040080EC RID: 33004
		public const int PopularEntrieFieldNumber = 2;

		// Token: 0x040080ED RID: 33005
		private PopularEntrie popularEntrie_;
	}
}
