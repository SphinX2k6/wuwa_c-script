using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F98 RID: 3992
	[NetMessage(EMessageId.RoguelikePopularEntriesInfoResponse)]
	public sealed class RoguelikePopularEntriesInfoResponse : IMessage<RoguelikePopularEntriesInfoResponse>, IMessage, IEquatable<RoguelikePopularEntriesInfoResponse>, IDeepCloneable<RoguelikePopularEntriesInfoResponse>, IBufferMessage
	{
		// Token: 0x06015606 RID: 87558 RVA: 0x0031AF1C File Offset: 0x0031911C
		[NullableContext(1)]
		public static RoguelikePopularEntriesInfoResponse Create()
		{
			return new RoguelikePopularEntriesInfoResponse();
		}

		// Token: 0x17004748 RID: 18248
		// (get) Token: 0x06015607 RID: 87559 RVA: 0x0031AF23 File Offset: 0x00319123
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004749 RID: 18249
		// (get) Token: 0x06015608 RID: 87560 RVA: 0x0031AF26 File Offset: 0x00319126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikePopularEntriesInfoResponse.Descriptor;
			}
		}

		// Token: 0x06015609 RID: 87561 RVA: 0x0031AF2D File Offset: 0x0031912D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikePopularEntriesInfoResponse()
		{
		}

		// Token: 0x0601560A RID: 87562 RVA: 0x0031AF38 File Offset: 0x00319138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikePopularEntriesInfoResponse(RoguelikePopularEntriesInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.popularEntrie_ = ((other.popularEntrie_ != null) ? other.popularEntrie_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601560B RID: 87563 RVA: 0x0031AF84 File Offset: 0x00319184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikePopularEntriesInfoResponse Clone()
		{
			return new RoguelikePopularEntriesInfoResponse(this);
		}

		// Token: 0x1700474A RID: 18250
		// (get) Token: 0x0601560C RID: 87564 RVA: 0x0031AF8C File Offset: 0x0031918C
		// (set) Token: 0x0601560D RID: 87565 RVA: 0x0031AF94 File Offset: 0x00319194
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

		// Token: 0x1700474B RID: 18251
		// (get) Token: 0x0601560E RID: 87566 RVA: 0x0031AF9D File Offset: 0x0031919D
		// (set) Token: 0x0601560F RID: 87567 RVA: 0x0031AFA5 File Offset: 0x003191A5
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

		// Token: 0x06015610 RID: 87568 RVA: 0x0031AFAE File Offset: 0x003191AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikePopularEntriesInfoResponse);
		}

		// Token: 0x06015611 RID: 87569 RVA: 0x0031AFBC File Offset: 0x003191BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikePopularEntriesInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.PopularEntrie, other.PopularEntrie) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015612 RID: 87570 RVA: 0x0031B00C File Offset: 0x0031920C
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

		// Token: 0x06015613 RID: 87571 RVA: 0x0031B067 File Offset: 0x00319267
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015614 RID: 87572 RVA: 0x0031B074 File Offset: 0x00319274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015615 RID: 87573 RVA: 0x0031B080 File Offset: 0x00319280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.popularEntrie_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.PopularEntrie);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015616 RID: 87574 RVA: 0x0031B0DC File Offset: 0x003192DC
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

		// Token: 0x06015617 RID: 87575 RVA: 0x0031B134 File Offset: 0x00319334
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

		// Token: 0x06015618 RID: 87576 RVA: 0x0031B19C File Offset: 0x0031939C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015619 RID: 87577 RVA: 0x0031B1A8 File Offset: 0x003193A8
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
				if (num != 74U)
				{
					if (num != 88U)
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

		// Token: 0x04008113 RID: 33043
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008114 RID: 33044
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04008115 RID: 33045
		private ErrorCode errorCode_;

		// Token: 0x04008116 RID: 33046
		public const int PopularEntrieFieldNumber = 9;

		// Token: 0x04008117 RID: 33047
		private PopularEntrie popularEntrie_;
	}
}
