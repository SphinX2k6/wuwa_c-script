using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000878 RID: 2168
	[NetMessage(EMessageId.KurotatoChestRewardSelectRequest)]
	public sealed class KurotatoChestRewardSelectRequest : IMessage<KurotatoChestRewardSelectRequest>, IMessage, IEquatable<KurotatoChestRewardSelectRequest>, IDeepCloneable<KurotatoChestRewardSelectRequest>, IBufferMessage
	{
		// Token: 0x0600C157 RID: 49495 RVA: 0x001CBBF9 File Offset: 0x001C9DF9
		[NullableContext(1)]
		public static KurotatoChestRewardSelectRequest Create()
		{
			return new KurotatoChestRewardSelectRequest();
		}

		// Token: 0x17002715 RID: 10005
		// (get) Token: 0x0600C158 RID: 49496 RVA: 0x001CBC00 File Offset: 0x001C9E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002716 RID: 10006
		// (get) Token: 0x0600C159 RID: 49497 RVA: 0x001CBC03 File Offset: 0x001C9E03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoChestRewardSelectRequest.Descriptor;
			}
		}

		// Token: 0x0600C15A RID: 49498 RVA: 0x001CBC0A File Offset: 0x001C9E0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoChestRewardSelectRequest()
		{
		}

		// Token: 0x0600C15B RID: 49499 RVA: 0x001CBC12 File Offset: 0x001C9E12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoChestRewardSelectRequest(KurotatoChestRewardSelectRequest other) : this()
		{
			this.willSold_ = other.willSold_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C15C RID: 49500 RVA: 0x001CBC37 File Offset: 0x001C9E37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoChestRewardSelectRequest Clone()
		{
			return new KurotatoChestRewardSelectRequest(this);
		}

		// Token: 0x17002717 RID: 10007
		// (get) Token: 0x0600C15D RID: 49501 RVA: 0x001CBC3F File Offset: 0x001C9E3F
		// (set) Token: 0x0600C15E RID: 49502 RVA: 0x001CBC47 File Offset: 0x001C9E47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool WillSold
		{
			get
			{
				return this.willSold_;
			}
			set
			{
				this.willSold_ = value;
			}
		}

		// Token: 0x0600C15F RID: 49503 RVA: 0x001CBC50 File Offset: 0x001C9E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoChestRewardSelectRequest);
		}

		// Token: 0x0600C160 RID: 49504 RVA: 0x001CBC5E File Offset: 0x001C9E5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoChestRewardSelectRequest other)
		{
			return other != null && (other == this || (this.WillSold == other.WillSold && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C161 RID: 49505 RVA: 0x001CBC8C File Offset: 0x001C9E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WillSold)
			{
				num ^= this.WillSold.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C162 RID: 49506 RVA: 0x001CBCCB File Offset: 0x001C9ECB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C163 RID: 49507 RVA: 0x001CBCD8 File Offset: 0x001C9ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C164 RID: 49508 RVA: 0x001CBCE1 File Offset: 0x001C9EE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WillSold)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.WillSold);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C165 RID: 49509 RVA: 0x001CBD14 File Offset: 0x001C9F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WillSold)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C166 RID: 49510 RVA: 0x001CBD46 File Offset: 0x001C9F46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoChestRewardSelectRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WillSold)
			{
				this.WillSold = other.WillSold;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C167 RID: 49511 RVA: 0x001CBD77 File Offset: 0x001C9F77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C168 RID: 49512 RVA: 0x001CBD80 File Offset: 0x001C9F80
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.WillSold = input.ReadBool();
				}
			}
		}

		// Token: 0x04005447 RID: 21575
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005448 RID: 21576
		public const int WillSoldFieldNumber = 12;

		// Token: 0x04005449 RID: 21577
		private bool willSold_;
	}
}
