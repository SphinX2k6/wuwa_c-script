using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000362 RID: 866
	[NetMessage(EMessageId.DangoBrawlLoseCountUpdateNotify)]
	public sealed class DangoBrawlLoseCountUpdateNotify : IMessage<DangoBrawlLoseCountUpdateNotify>, IMessage, IEquatable<DangoBrawlLoseCountUpdateNotify>, IDeepCloneable<DangoBrawlLoseCountUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600565E RID: 22110 RVA: 0x000D3041 File Offset: 0x000D1241
		[NullableContext(1)]
		public static DangoBrawlLoseCountUpdateNotify Create()
		{
			return new DangoBrawlLoseCountUpdateNotify();
		}

		// Token: 0x17000FD8 RID: 4056
		// (get) Token: 0x0600565F RID: 22111 RVA: 0x000D3048 File Offset: 0x000D1248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000FD9 RID: 4057
		// (get) Token: 0x06005660 RID: 22112 RVA: 0x000D304B File Offset: 0x000D124B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlLoseCountUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06005661 RID: 22113 RVA: 0x000D3052 File Offset: 0x000D1252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlLoseCountUpdateNotify()
		{
		}

		// Token: 0x06005662 RID: 22114 RVA: 0x000D305A File Offset: 0x000D125A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlLoseCountUpdateNotify(DangoBrawlLoseCountUpdateNotify other) : this()
		{
			this.loseCount_ = other.loseCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005663 RID: 22115 RVA: 0x000D307F File Offset: 0x000D127F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlLoseCountUpdateNotify Clone()
		{
			return new DangoBrawlLoseCountUpdateNotify(this);
		}

		// Token: 0x17000FDA RID: 4058
		// (get) Token: 0x06005664 RID: 22116 RVA: 0x000D3087 File Offset: 0x000D1287
		// (set) Token: 0x06005665 RID: 22117 RVA: 0x000D308F File Offset: 0x000D128F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LoseCount
		{
			get
			{
				return this.loseCount_;
			}
			set
			{
				this.loseCount_ = value;
			}
		}

		// Token: 0x06005666 RID: 22118 RVA: 0x000D3098 File Offset: 0x000D1298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlLoseCountUpdateNotify);
		}

		// Token: 0x06005667 RID: 22119 RVA: 0x000D30A6 File Offset: 0x000D12A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlLoseCountUpdateNotify other)
		{
			return other != null && (other == this || (this.LoseCount == other.LoseCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005668 RID: 22120 RVA: 0x000D30D4 File Offset: 0x000D12D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LoseCount != 0)
			{
				num ^= this.LoseCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005669 RID: 22121 RVA: 0x000D3113 File Offset: 0x000D1313
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600566A RID: 22122 RVA: 0x000D3120 File Offset: 0x000D1320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600566B RID: 22123 RVA: 0x000D3129 File Offset: 0x000D1329
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LoseCount != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.LoseCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600566C RID: 22124 RVA: 0x000D315C File Offset: 0x000D135C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LoseCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LoseCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600566D RID: 22125 RVA: 0x000D319A File Offset: 0x000D139A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlLoseCountUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LoseCount != 0)
			{
				this.LoseCount = other.LoseCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600566E RID: 22126 RVA: 0x000D31CB File Offset: 0x000D13CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600566F RID: 22127 RVA: 0x000D31D4 File Offset: 0x000D13D4
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.LoseCount = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003477 RID: 13431
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003478 RID: 13432
		public const int LoseCountFieldNumber = 9;

		// Token: 0x04003479 RID: 13433
		private int loseCount_;
	}
}
