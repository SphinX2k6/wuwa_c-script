using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200116D RID: 4461
	[NetMessage(EMessageId.RoverRogueUpdateReviveTimesNotify)]
	public sealed class RoverRogueUpdateReviveTimesNotify : IMessage<RoverRogueUpdateReviveTimesNotify>, IMessage, IEquatable<RoverRogueUpdateReviveTimesNotify>, IDeepCloneable<RoverRogueUpdateReviveTimesNotify>, IBufferMessage
	{
		// Token: 0x06017D63 RID: 97635 RVA: 0x00378781 File Offset: 0x00376981
		[NullableContext(1)]
		public static RoverRogueUpdateReviveTimesNotify Create()
		{
			return new RoverRogueUpdateReviveTimesNotify();
		}

		// Token: 0x17005040 RID: 20544
		// (get) Token: 0x06017D64 RID: 97636 RVA: 0x00378788 File Offset: 0x00376988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005041 RID: 20545
		// (get) Token: 0x06017D65 RID: 97637 RVA: 0x0037878B File Offset: 0x0037698B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueUpdateReviveTimesNotify.Descriptor;
			}
		}

		// Token: 0x06017D66 RID: 97638 RVA: 0x00378792 File Offset: 0x00376992
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueUpdateReviveTimesNotify()
		{
		}

		// Token: 0x06017D67 RID: 97639 RVA: 0x0037879A File Offset: 0x0037699A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueUpdateReviveTimesNotify(RoverRogueUpdateReviveTimesNotify other) : this()
		{
			this.reviveTimes_ = other.reviveTimes_;
			this.reviveTimesMax_ = other.reviveTimesMax_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017D68 RID: 97640 RVA: 0x003787CB File Offset: 0x003769CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueUpdateReviveTimesNotify Clone()
		{
			return new RoverRogueUpdateReviveTimesNotify(this);
		}

		// Token: 0x17005042 RID: 20546
		// (get) Token: 0x06017D69 RID: 97641 RVA: 0x003787D3 File Offset: 0x003769D3
		// (set) Token: 0x06017D6A RID: 97642 RVA: 0x003787DB File Offset: 0x003769DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ReviveTimes
		{
			get
			{
				return this.reviveTimes_;
			}
			set
			{
				this.reviveTimes_ = value;
			}
		}

		// Token: 0x17005043 RID: 20547
		// (get) Token: 0x06017D6B RID: 97643 RVA: 0x003787E4 File Offset: 0x003769E4
		// (set) Token: 0x06017D6C RID: 97644 RVA: 0x003787EC File Offset: 0x003769EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ReviveTimesMax
		{
			get
			{
				return this.reviveTimesMax_;
			}
			set
			{
				this.reviveTimesMax_ = value;
			}
		}

		// Token: 0x06017D6D RID: 97645 RVA: 0x003787F5 File Offset: 0x003769F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueUpdateReviveTimesNotify);
		}

		// Token: 0x06017D6E RID: 97646 RVA: 0x00378803 File Offset: 0x00376A03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueUpdateReviveTimesNotify other)
		{
			return other != null && (other == this || (this.ReviveTimes == other.ReviveTimes && this.ReviveTimesMax == other.ReviveTimesMax && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017D6F RID: 97647 RVA: 0x00378844 File Offset: 0x00376A44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ReviveTimes != 0)
			{
				num ^= this.ReviveTimes.GetHashCode();
			}
			if (this.ReviveTimesMax != 0)
			{
				num ^= this.ReviveTimesMax.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017D70 RID: 97648 RVA: 0x0037889C File Offset: 0x00376A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017D71 RID: 97649 RVA: 0x003788A9 File Offset: 0x00376AA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017D72 RID: 97650 RVA: 0x003788B4 File Offset: 0x00376AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ReviveTimes != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ReviveTimes);
			}
			if (this.ReviveTimesMax != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ReviveTimesMax);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017D73 RID: 97651 RVA: 0x00378910 File Offset: 0x00376B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ReviveTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ReviveTimes);
			}
			if (this.ReviveTimesMax != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ReviveTimesMax);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017D74 RID: 97652 RVA: 0x00378968 File Offset: 0x00376B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueUpdateReviveTimesNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ReviveTimes != 0)
			{
				this.ReviveTimes = other.ReviveTimes;
			}
			if (other.ReviveTimesMax != 0)
			{
				this.ReviveTimesMax = other.ReviveTimesMax;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017D75 RID: 97653 RVA: 0x003789B8 File Offset: 0x00376BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017D76 RID: 97654 RVA: 0x003789C4 File Offset: 0x00376BC4
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
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ReviveTimesMax = input.ReadInt32();
					}
				}
				else
				{
					this.ReviveTimes = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008E32 RID: 36402
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E33 RID: 36403
		public const int ReviveTimesFieldNumber = 12;

		// Token: 0x04008E34 RID: 36404
		private int reviveTimes_;

		// Token: 0x04008E35 RID: 36405
		public const int ReviveTimesMaxFieldNumber = 14;

		// Token: 0x04008E36 RID: 36406
		private int reviveTimesMax_;
	}
}
