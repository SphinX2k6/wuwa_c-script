using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200124C RID: 4684
	[NetMessage(EMessageId.SlashAndTowerRecommendRequest)]
	public sealed class SlashAndTowerRecommendRequest : IMessage<SlashAndTowerRecommendRequest>, IMessage, IEquatable<SlashAndTowerRecommendRequest>, IDeepCloneable<SlashAndTowerRecommendRequest>, IBufferMessage
	{
		// Token: 0x06018F55 RID: 102229 RVA: 0x003A1B5A File Offset: 0x0039FD5A
		[NullableContext(1)]
		public static SlashAndTowerRecommendRequest Create()
		{
			return new SlashAndTowerRecommendRequest();
		}

		// Token: 0x1700542B RID: 21547
		// (get) Token: 0x06018F56 RID: 102230 RVA: 0x003A1B61 File Offset: 0x0039FD61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700542C RID: 21548
		// (get) Token: 0x06018F57 RID: 102231 RVA: 0x003A1B64 File Offset: 0x0039FD64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SlashAndTowerRecommendRequest.Descriptor;
			}
		}

		// Token: 0x06018F58 RID: 102232 RVA: 0x003A1B6B File Offset: 0x0039FD6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerRecommendRequest()
		{
		}

		// Token: 0x06018F59 RID: 102233 RVA: 0x003A1B73 File Offset: 0x0039FD73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerRecommendRequest(SlashAndTowerRecommendRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018F5A RID: 102234 RVA: 0x003A1B98 File Offset: 0x0039FD98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerRecommendRequest Clone()
		{
			return new SlashAndTowerRecommendRequest(this);
		}

		// Token: 0x1700542D RID: 21549
		// (get) Token: 0x06018F5B RID: 102235 RVA: 0x003A1BA0 File Offset: 0x0039FDA0
		// (set) Token: 0x06018F5C RID: 102236 RVA: 0x003A1BA8 File Offset: 0x0039FDA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x06018F5D RID: 102237 RVA: 0x003A1BB1 File Offset: 0x0039FDB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SlashAndTowerRecommendRequest);
		}

		// Token: 0x06018F5E RID: 102238 RVA: 0x003A1BBF File Offset: 0x0039FDBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SlashAndTowerRecommendRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018F5F RID: 102239 RVA: 0x003A1BF0 File Offset: 0x0039FDF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018F60 RID: 102240 RVA: 0x003A1C2F File Offset: 0x0039FE2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018F61 RID: 102241 RVA: 0x003A1C3C File Offset: 0x0039FE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018F62 RID: 102242 RVA: 0x003A1C45 File Offset: 0x0039FE45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018F63 RID: 102243 RVA: 0x003A1C78 File Offset: 0x0039FE78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018F64 RID: 102244 RVA: 0x003A1CB6 File Offset: 0x0039FEB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SlashAndTowerRecommendRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018F65 RID: 102245 RVA: 0x003A1CE7 File Offset: 0x0039FEE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018F66 RID: 102246 RVA: 0x003A1CF0 File Offset: 0x0039FEF0
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009325 RID: 37669
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009326 RID: 37670
		public const int IdFieldNumber = 6;

		// Token: 0x04009327 RID: 37671
		private int id_;
	}
}
