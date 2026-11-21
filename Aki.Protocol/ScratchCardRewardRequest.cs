using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011DA RID: 4570
	[NetMessage(EMessageId.ScratchCardRewardRequest)]
	public sealed class ScratchCardRewardRequest : IMessage<ScratchCardRewardRequest>, IMessage, IEquatable<ScratchCardRewardRequest>, IDeepCloneable<ScratchCardRewardRequest>, IBufferMessage
	{
		// Token: 0x06018647 RID: 99911 RVA: 0x0038CBD3 File Offset: 0x0038ADD3
		[NullableContext(1)]
		public static ScratchCardRewardRequest Create()
		{
			return new ScratchCardRewardRequest();
		}

		// Token: 0x17005233 RID: 21043
		// (get) Token: 0x06018648 RID: 99912 RVA: 0x0038CBDA File Offset: 0x0038ADDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005234 RID: 21044
		// (get) Token: 0x06018649 RID: 99913 RVA: 0x0038CBDD File Offset: 0x0038ADDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ScratchCardRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601864A RID: 99914 RVA: 0x0038CBE4 File Offset: 0x0038ADE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardRewardRequest()
		{
		}

		// Token: 0x0601864B RID: 99915 RVA: 0x0038CBEC File Offset: 0x0038ADEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardRewardRequest(ScratchCardRewardRequest other) : this()
		{
			this.roundId_ = other.roundId_;
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601864C RID: 99916 RVA: 0x0038CC1D File Offset: 0x0038AE1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardRewardRequest Clone()
		{
			return new ScratchCardRewardRequest(this);
		}

		// Token: 0x17005235 RID: 21045
		// (get) Token: 0x0601864D RID: 99917 RVA: 0x0038CC25 File Offset: 0x0038AE25
		// (set) Token: 0x0601864E RID: 99918 RVA: 0x0038CC2D File Offset: 0x0038AE2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoundId
		{
			get
			{
				return this.roundId_;
			}
			set
			{
				this.roundId_ = value;
			}
		}

		// Token: 0x17005236 RID: 21046
		// (get) Token: 0x0601864F RID: 99919 RVA: 0x0038CC36 File Offset: 0x0038AE36
		// (set) Token: 0x06018650 RID: 99920 RVA: 0x0038CC3E File Offset: 0x0038AE3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x06018651 RID: 99921 RVA: 0x0038CC47 File Offset: 0x0038AE47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ScratchCardRewardRequest);
		}

		// Token: 0x06018652 RID: 99922 RVA: 0x0038CC55 File Offset: 0x0038AE55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ScratchCardRewardRequest other)
		{
			return other != null && (other == this || (this.RoundId == other.RoundId && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018653 RID: 99923 RVA: 0x0038CC94 File Offset: 0x0038AE94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoundId != 0)
			{
				num ^= this.RoundId.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018654 RID: 99924 RVA: 0x0038CCEC File Offset: 0x0038AEEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018655 RID: 99925 RVA: 0x0038CCF9 File Offset: 0x0038AEF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018656 RID: 99926 RVA: 0x0038CD04 File Offset: 0x0038AF04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Index);
			}
			if (this.RoundId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.RoundId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018657 RID: 99927 RVA: 0x0038CD60 File Offset: 0x0038AF60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoundId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoundId);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018658 RID: 99928 RVA: 0x0038CDB8 File Offset: 0x0038AFB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ScratchCardRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoundId != 0)
			{
				this.RoundId = other.RoundId;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018659 RID: 99929 RVA: 0x0038CE08 File Offset: 0x0038B008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601865A RID: 99930 RVA: 0x0038CE14 File Offset: 0x0038B014
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
				if (num != 32U)
				{
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RoundId = input.ReadInt32();
					}
				}
				else
				{
					this.Index = input.ReadInt32();
				}
			}
		}

		// Token: 0x040090E0 RID: 37088
		private UnknownFieldSet _unknownFields;

		// Token: 0x040090E1 RID: 37089
		public const int RoundIdFieldNumber = 5;

		// Token: 0x040090E2 RID: 37090
		private int roundId_;

		// Token: 0x040090E3 RID: 37091
		public const int IndexFieldNumber = 4;

		// Token: 0x040090E4 RID: 37092
		private int index_;
	}
}
