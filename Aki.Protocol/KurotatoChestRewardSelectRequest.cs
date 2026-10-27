using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000889 RID: 2185
	[NetMessage(EMessageId.KurotatoChestRewardSelectRequest)]
	public sealed class KurotatoChestRewardSelectRequest : IMessage<KurotatoChestRewardSelectRequest>, IMessage, IEquatable<KurotatoChestRewardSelectRequest>, IDeepCloneable<KurotatoChestRewardSelectRequest>, IBufferMessage
	{
		// Token: 0x0600C273 RID: 49779 RVA: 0x001CDEE1 File Offset: 0x001CC0E1
		[NullableContext(1)]
		public static KurotatoChestRewardSelectRequest Create()
		{
			return new KurotatoChestRewardSelectRequest();
		}

		// Token: 0x17002754 RID: 10068
		// (get) Token: 0x0600C274 RID: 49780 RVA: 0x001CDEE8 File Offset: 0x001CC0E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002755 RID: 10069
		// (get) Token: 0x0600C275 RID: 49781 RVA: 0x001CDEEB File Offset: 0x001CC0EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoChestRewardSelectRequest.Descriptor;
			}
		}

		// Token: 0x0600C276 RID: 49782 RVA: 0x001CDEF2 File Offset: 0x001CC0F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoChestRewardSelectRequest()
		{
		}

		// Token: 0x0600C277 RID: 49783 RVA: 0x001CDEFA File Offset: 0x001CC0FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoChestRewardSelectRequest(KurotatoChestRewardSelectRequest other) : this()
		{
			this.willSold_ = other.willSold_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C278 RID: 49784 RVA: 0x001CDF1F File Offset: 0x001CC11F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoChestRewardSelectRequest Clone()
		{
			return new KurotatoChestRewardSelectRequest(this);
		}

		// Token: 0x17002756 RID: 10070
		// (get) Token: 0x0600C279 RID: 49785 RVA: 0x001CDF27 File Offset: 0x001CC127
		// (set) Token: 0x0600C27A RID: 49786 RVA: 0x001CDF2F File Offset: 0x001CC12F
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

		// Token: 0x0600C27B RID: 49787 RVA: 0x001CDF38 File Offset: 0x001CC138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoChestRewardSelectRequest);
		}

		// Token: 0x0600C27C RID: 49788 RVA: 0x001CDF46 File Offset: 0x001CC146
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoChestRewardSelectRequest other)
		{
			return other != null && (other == this || (this.WillSold == other.WillSold && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C27D RID: 49789 RVA: 0x001CDF74 File Offset: 0x001CC174
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

		// Token: 0x0600C27E RID: 49790 RVA: 0x001CDFB3 File Offset: 0x001CC1B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C27F RID: 49791 RVA: 0x001CDFC0 File Offset: 0x001CC1C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C280 RID: 49792 RVA: 0x001CDFC9 File Offset: 0x001CC1C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WillSold)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.WillSold);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C281 RID: 49793 RVA: 0x001CDFFC File Offset: 0x001CC1FC
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

		// Token: 0x0600C282 RID: 49794 RVA: 0x001CE02E File Offset: 0x001CC22E
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

		// Token: 0x0600C283 RID: 49795 RVA: 0x001CE05F File Offset: 0x001CC25F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C284 RID: 49796 RVA: 0x001CE068 File Offset: 0x001CC268
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.WillSold = input.ReadBool();
				}
			}
		}

		// Token: 0x04005440 RID: 21568
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005441 RID: 21569
		public const int WillSoldFieldNumber = 13;

		// Token: 0x04005442 RID: 21570
		private bool willSold_;
	}
}
