using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008CB RID: 2251
	[NetMessage(EMessageId.KurotatoShopRewardSelectRequest)]
	public sealed class KurotatoShopRewardSelectRequest : IMessage<KurotatoShopRewardSelectRequest>, IMessage, IEquatable<KurotatoShopRewardSelectRequest>, IDeepCloneable<KurotatoShopRewardSelectRequest>, IBufferMessage
	{
		// Token: 0x0600C780 RID: 51072 RVA: 0x001D8153 File Offset: 0x001D6353
		[NullableContext(1)]
		public static KurotatoShopRewardSelectRequest Create()
		{
			return new KurotatoShopRewardSelectRequest();
		}

		// Token: 0x17002851 RID: 10321
		// (get) Token: 0x0600C781 RID: 51073 RVA: 0x001D815A File Offset: 0x001D635A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002852 RID: 10322
		// (get) Token: 0x0600C782 RID: 51074 RVA: 0x001D815D File Offset: 0x001D635D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoShopRewardSelectRequest.Descriptor;
			}
		}

		// Token: 0x0600C783 RID: 51075 RVA: 0x001D8164 File Offset: 0x001D6364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopRewardSelectRequest()
		{
		}

		// Token: 0x0600C784 RID: 51076 RVA: 0x001D816C File Offset: 0x001D636C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopRewardSelectRequest(KurotatoShopRewardSelectRequest other) : this()
		{
			this.selectionId_ = other.selectionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C785 RID: 51077 RVA: 0x001D8191 File Offset: 0x001D6391
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopRewardSelectRequest Clone()
		{
			return new KurotatoShopRewardSelectRequest(this);
		}

		// Token: 0x17002853 RID: 10323
		// (get) Token: 0x0600C786 RID: 51078 RVA: 0x001D8199 File Offset: 0x001D6399
		// (set) Token: 0x0600C787 RID: 51079 RVA: 0x001D81A1 File Offset: 0x001D63A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SelectionId
		{
			get
			{
				return this.selectionId_;
			}
			set
			{
				this.selectionId_ = value;
			}
		}

		// Token: 0x0600C788 RID: 51080 RVA: 0x001D81AA File Offset: 0x001D63AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoShopRewardSelectRequest);
		}

		// Token: 0x0600C789 RID: 51081 RVA: 0x001D81B8 File Offset: 0x001D63B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoShopRewardSelectRequest other)
		{
			return other != null && (other == this || (this.SelectionId == other.SelectionId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C78A RID: 51082 RVA: 0x001D81E8 File Offset: 0x001D63E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SelectionId != 0)
			{
				num ^= this.SelectionId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C78B RID: 51083 RVA: 0x001D8227 File Offset: 0x001D6427
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C78C RID: 51084 RVA: 0x001D8234 File Offset: 0x001D6434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C78D RID: 51085 RVA: 0x001D823D File Offset: 0x001D643D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SelectionId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.SelectionId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C78E RID: 51086 RVA: 0x001D8270 File Offset: 0x001D6470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SelectionId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SelectionId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C78F RID: 51087 RVA: 0x001D82AE File Offset: 0x001D64AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoShopRewardSelectRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SelectionId != 0)
			{
				this.SelectionId = other.SelectionId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C790 RID: 51088 RVA: 0x001D82DF File Offset: 0x001D64DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C791 RID: 51089 RVA: 0x001D82E8 File Offset: 0x001D64E8
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SelectionId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005580 RID: 21888
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005581 RID: 21889
		public const int SelectionIdFieldNumber = 8;

		// Token: 0x04005582 RID: 21890
		private int selectionId_;
	}
}
