using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000637 RID: 1591
	public sealed class FriendApply : IMessage<FriendApply>, IMessage, IEquatable<FriendApply>, IDeepCloneable<FriendApply>, IBufferMessage
	{
		// Token: 0x060092E0 RID: 37600 RVA: 0x00163A31 File Offset: 0x00161C31
		[NullableContext(1)]
		public static FriendApply Create()
		{
			return new FriendApply();
		}

		// Token: 0x17001D37 RID: 7479
		// (get) Token: 0x060092E1 RID: 37601 RVA: 0x00163A38 File Offset: 0x00161C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FriendApply> Parser
		{
			get
			{
				return FriendApply._parser;
			}
		}

		// Token: 0x17001D38 RID: 7480
		// (get) Token: 0x060092E2 RID: 37602 RVA: 0x00163A3F File Offset: 0x00161C3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D39 RID: 7481
		// (get) Token: 0x060092E3 RID: 37603 RVA: 0x00163A42 File Offset: 0x00161C42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendApply.Descriptor;
			}
		}

		// Token: 0x060092E4 RID: 37604 RVA: 0x00163A49 File Offset: 0x00161C49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApply()
		{
		}

		// Token: 0x060092E5 RID: 37605 RVA: 0x00163A54 File Offset: 0x00161C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApply(FriendApply other) : this()
		{
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this.createdTime_ = other.createdTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060092E6 RID: 37606 RVA: 0x00163AA0 File Offset: 0x00161CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApply Clone()
		{
			return new FriendApply(this);
		}

		// Token: 0x17001D3A RID: 7482
		// (get) Token: 0x060092E7 RID: 37607 RVA: 0x00163AA8 File Offset: 0x00161CA8
		// (set) Token: 0x060092E8 RID: 37608 RVA: 0x00163AB0 File Offset: 0x00161CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerDetails Info
		{
			get
			{
				return this.info_;
			}
			set
			{
				this.info_ = value;
			}
		}

		// Token: 0x17001D3B RID: 7483
		// (get) Token: 0x060092E9 RID: 37609 RVA: 0x00163AB9 File Offset: 0x00161CB9
		// (set) Token: 0x060092EA RID: 37610 RVA: 0x00163AC1 File Offset: 0x00161CC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CreatedTime
		{
			get
			{
				return this.createdTime_;
			}
			set
			{
				this.createdTime_ = value;
			}
		}

		// Token: 0x060092EB RID: 37611 RVA: 0x00163ACA File Offset: 0x00161CCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendApply);
		}

		// Token: 0x060092EC RID: 37612 RVA: 0x00163AD8 File Offset: 0x00161CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendApply other)
		{
			return other != null && (other == this || (object.Equals(this.Info, other.Info) && this.CreatedTime == other.CreatedTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060092ED RID: 37613 RVA: 0x00163B28 File Offset: 0x00161D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.info_ != null)
			{
				num ^= this.Info.GetHashCode();
			}
			if (this.CreatedTime != 0L)
			{
				num ^= this.CreatedTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060092EE RID: 37614 RVA: 0x00163B7D File Offset: 0x00161D7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060092EF RID: 37615 RVA: 0x00163B8A File Offset: 0x00161D8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060092F0 RID: 37616 RVA: 0x00163B94 File Offset: 0x00161D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.info_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Info);
			}
			if (this.CreatedTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.CreatedTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060092F1 RID: 37617 RVA: 0x00163BF0 File Offset: 0x00161DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.info_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Info);
			}
			if (this.CreatedTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CreatedTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060092F2 RID: 37618 RVA: 0x00163C48 File Offset: 0x00161E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FriendApply other)
		{
			if (other == null)
			{
				return;
			}
			if (other.info_ != null)
			{
				if (this.info_ == null)
				{
					this.Info = new PlayerDetails();
				}
				this.Info.MergeFrom(other.Info);
			}
			if (other.CreatedTime != 0L)
			{
				this.CreatedTime = other.CreatedTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060092F3 RID: 37619 RVA: 0x00163CB0 File Offset: 0x00161EB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060092F4 RID: 37620 RVA: 0x00163CBC File Offset: 0x00161EBC
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
				if (num != 10U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CreatedTime = input.ReadInt64();
					}
				}
				else
				{
					if (this.info_ == null)
					{
						this.Info = new PlayerDetails();
					}
					input.ReadMessage(this.Info);
				}
			}
		}

		// Token: 0x04004712 RID: 18194
		private static readonly MessageParser<FriendApply> _parser = new MessageParser<FriendApply>(() => new FriendApply());

		// Token: 0x04004713 RID: 18195
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004714 RID: 18196
		public const int InfoFieldNumber = 1;

		// Token: 0x04004715 RID: 18197
		private PlayerDetails info_;

		// Token: 0x04004716 RID: 18198
		public const int CreatedTimeFieldNumber = 2;

		// Token: 0x04004717 RID: 18199
		private long createdTime_;
	}
}
