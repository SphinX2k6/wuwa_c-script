using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000157 RID: 343
	[NetMessage(EMessageId.BanChatNotify)]
	public sealed class BanChatNotify : IMessage<BanChatNotify>, IMessage, IEquatable<BanChatNotify>, IDeepCloneable<BanChatNotify>, IBufferMessage
	{
		// Token: 0x06002B55 RID: 11093 RVA: 0x0007108D File Offset: 0x0006F28D
		[NullableContext(1)]
		public static BanChatNotify Create()
		{
			return new BanChatNotify();
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06002B56 RID: 11094 RVA: 0x00071094 File Offset: 0x0006F294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06002B57 RID: 11095 RVA: 0x00071097 File Offset: 0x0006F297
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BanChatNotify.Descriptor;
			}
		}

		// Token: 0x06002B58 RID: 11096 RVA: 0x0007109E File Offset: 0x0006F29E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BanChatNotify()
		{
		}

		// Token: 0x06002B59 RID: 11097 RVA: 0x000710A6 File Offset: 0x0006F2A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BanChatNotify(BanChatNotify other) : this()
		{
			this.banEndTime_ = other.banEndTime_;
			this.banChatType_ = other.banChatType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002B5A RID: 11098 RVA: 0x000710D7 File Offset: 0x0006F2D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BanChatNotify Clone()
		{
			return new BanChatNotify(this);
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06002B5B RID: 11099 RVA: 0x000710DF File Offset: 0x0006F2DF
		// (set) Token: 0x06002B5C RID: 11100 RVA: 0x000710E7 File Offset: 0x0006F2E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BanEndTime
		{
			get
			{
				return this.banEndTime_;
			}
			set
			{
				this.banEndTime_ = value;
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06002B5D RID: 11101 RVA: 0x000710F0 File Offset: 0x0006F2F0
		// (set) Token: 0x06002B5E RID: 11102 RVA: 0x000710F8 File Offset: 0x0006F2F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BanChatType BanChatType
		{
			get
			{
				return this.banChatType_;
			}
			set
			{
				this.banChatType_ = value;
			}
		}

		// Token: 0x06002B5F RID: 11103 RVA: 0x00071101 File Offset: 0x0006F301
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BanChatNotify);
		}

		// Token: 0x06002B60 RID: 11104 RVA: 0x0007110F File Offset: 0x0006F30F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BanChatNotify other)
		{
			return other != null && (other == this || (this.BanEndTime == other.BanEndTime && this.BanChatType == other.BanChatType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002B61 RID: 11105 RVA: 0x00071150 File Offset: 0x0006F350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BanEndTime != 0L)
			{
				num ^= this.BanEndTime.GetHashCode();
			}
			if (this.BanChatType != BanChatType.None)
			{
				num ^= this.BanChatType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002B62 RID: 11106 RVA: 0x000711AE File Offset: 0x0006F3AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002B63 RID: 11107 RVA: 0x000711BB File Offset: 0x0006F3BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002B64 RID: 11108 RVA: 0x000711C4 File Offset: 0x0006F3C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BanChatType != BanChatType.None)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.BanChatType);
			}
			if (this.BanEndTime != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.BanEndTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002B65 RID: 11109 RVA: 0x0007121C File Offset: 0x0006F41C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BanEndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BanEndTime);
			}
			if (this.BanChatType != BanChatType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.BanChatType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002B66 RID: 11110 RVA: 0x00071274 File Offset: 0x0006F474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BanChatNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BanEndTime != 0L)
			{
				this.BanEndTime = other.BanEndTime;
			}
			if (other.BanChatType != BanChatType.None)
			{
				this.BanChatType = other.BanChatType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002B67 RID: 11111 RVA: 0x000712C4 File Offset: 0x0006F4C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002B68 RID: 11112 RVA: 0x000712D0 File Offset: 0x0006F4D0
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
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.BanEndTime = input.ReadInt64();
					}
				}
				else
				{
					this.BanChatType = (BanChatType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002798 RID: 10136
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002799 RID: 10137
		public const int BanEndTimeFieldNumber = 6;

		// Token: 0x0400279A RID: 10138
		private long banEndTime_;

		// Token: 0x0400279B RID: 10139
		public const int BanChatTypeFieldNumber = 1;

		// Token: 0x0400279C RID: 10140
		private BanChatType banChatType_;
	}
}
