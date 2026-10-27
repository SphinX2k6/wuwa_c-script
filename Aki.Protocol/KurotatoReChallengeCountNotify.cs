using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008AC RID: 2220
	[NetMessage(EMessageId.KurotatoReChallengeCountNotify)]
	public sealed class KurotatoReChallengeCountNotify : IMessage<KurotatoReChallengeCountNotify>, IMessage, IEquatable<KurotatoReChallengeCountNotify>, IDeepCloneable<KurotatoReChallengeCountNotify>, IBufferMessage
	{
		// Token: 0x0600C51D RID: 50461 RVA: 0x001D3156 File Offset: 0x001D1356
		[NullableContext(1)]
		public static KurotatoReChallengeCountNotify Create()
		{
			return new KurotatoReChallengeCountNotify();
		}

		// Token: 0x170027D8 RID: 10200
		// (get) Token: 0x0600C51E RID: 50462 RVA: 0x001D315D File Offset: 0x001D135D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027D9 RID: 10201
		// (get) Token: 0x0600C51F RID: 50463 RVA: 0x001D3160 File Offset: 0x001D1360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoReChallengeCountNotify.Descriptor;
			}
		}

		// Token: 0x0600C520 RID: 50464 RVA: 0x001D3167 File Offset: 0x001D1367
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoReChallengeCountNotify()
		{
		}

		// Token: 0x0600C521 RID: 50465 RVA: 0x001D316F File Offset: 0x001D136F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoReChallengeCountNotify(KurotatoReChallengeCountNotify other) : this()
		{
			this.maxReChallengeCount_ = other.maxReChallengeCount_;
			this.usedReChallengeCount_ = other.usedReChallengeCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C522 RID: 50466 RVA: 0x001D31A0 File Offset: 0x001D13A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoReChallengeCountNotify Clone()
		{
			return new KurotatoReChallengeCountNotify(this);
		}

		// Token: 0x170027DA RID: 10202
		// (get) Token: 0x0600C523 RID: 50467 RVA: 0x001D31A8 File Offset: 0x001D13A8
		// (set) Token: 0x0600C524 RID: 50468 RVA: 0x001D31B0 File Offset: 0x001D13B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxReChallengeCount
		{
			get
			{
				return this.maxReChallengeCount_;
			}
			set
			{
				this.maxReChallengeCount_ = value;
			}
		}

		// Token: 0x170027DB RID: 10203
		// (get) Token: 0x0600C525 RID: 50469 RVA: 0x001D31B9 File Offset: 0x001D13B9
		// (set) Token: 0x0600C526 RID: 50470 RVA: 0x001D31C1 File Offset: 0x001D13C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UsedReChallengeCount
		{
			get
			{
				return this.usedReChallengeCount_;
			}
			set
			{
				this.usedReChallengeCount_ = value;
			}
		}

		// Token: 0x0600C527 RID: 50471 RVA: 0x001D31CA File Offset: 0x001D13CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoReChallengeCountNotify);
		}

		// Token: 0x0600C528 RID: 50472 RVA: 0x001D31D8 File Offset: 0x001D13D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoReChallengeCountNotify other)
		{
			return other != null && (other == this || (this.MaxReChallengeCount == other.MaxReChallengeCount && this.UsedReChallengeCount == other.UsedReChallengeCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C529 RID: 50473 RVA: 0x001D3218 File Offset: 0x001D1418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MaxReChallengeCount != 0)
			{
				num ^= this.MaxReChallengeCount.GetHashCode();
			}
			if (this.UsedReChallengeCount != 0)
			{
				num ^= this.UsedReChallengeCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C52A RID: 50474 RVA: 0x001D3270 File Offset: 0x001D1470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C52B RID: 50475 RVA: 0x001D327D File Offset: 0x001D147D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C52C RID: 50476 RVA: 0x001D3288 File Offset: 0x001D1488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.UsedReChallengeCount != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.UsedReChallengeCount);
			}
			if (this.MaxReChallengeCount != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.MaxReChallengeCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C52D RID: 50477 RVA: 0x001D32E4 File Offset: 0x001D14E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MaxReChallengeCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxReChallengeCount);
			}
			if (this.UsedReChallengeCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UsedReChallengeCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C52E RID: 50478 RVA: 0x001D333C File Offset: 0x001D153C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoReChallengeCountNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MaxReChallengeCount != 0)
			{
				this.MaxReChallengeCount = other.MaxReChallengeCount;
			}
			if (other.UsedReChallengeCount != 0)
			{
				this.UsedReChallengeCount = other.UsedReChallengeCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C52F RID: 50479 RVA: 0x001D338C File Offset: 0x001D158C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C530 RID: 50480 RVA: 0x001D3398 File Offset: 0x001D1598
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
				if (num != 40U)
				{
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.MaxReChallengeCount = input.ReadInt32();
					}
				}
				else
				{
					this.UsedReChallengeCount = input.ReadInt32();
				}
			}
		}

		// Token: 0x040054E4 RID: 21732
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054E5 RID: 21733
		public const int MaxReChallengeCountFieldNumber = 8;

		// Token: 0x040054E6 RID: 21734
		private int maxReChallengeCount_;

		// Token: 0x040054E7 RID: 21735
		public const int UsedReChallengeCountFieldNumber = 5;

		// Token: 0x040054E8 RID: 21736
		private int usedReChallengeCount_;
	}
}
