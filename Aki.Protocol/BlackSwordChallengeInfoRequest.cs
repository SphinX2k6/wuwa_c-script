using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001B1 RID: 433
	[NetMessage(EMessageId.BlackSwordChallengeInfoRequest)]
	public sealed class BlackSwordChallengeInfoRequest : IMessage<BlackSwordChallengeInfoRequest>, IMessage, IEquatable<BlackSwordChallengeInfoRequest>, IDeepCloneable<BlackSwordChallengeInfoRequest>, IBufferMessage
	{
		// Token: 0x060032AE RID: 12974 RVA: 0x00080EDA File Offset: 0x0007F0DA
		[NullableContext(1)]
		public static BlackSwordChallengeInfoRequest Create()
		{
			return new BlackSwordChallengeInfoRequest();
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x060032AF RID: 12975 RVA: 0x00080EE1 File Offset: 0x0007F0E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x060032B0 RID: 12976 RVA: 0x00080EE4 File Offset: 0x0007F0E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlackSwordChallengeInfoRequest.Descriptor;
			}
		}

		// Token: 0x060032B1 RID: 12977 RVA: 0x00080EEB File Offset: 0x0007F0EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackSwordChallengeInfoRequest()
		{
		}

		// Token: 0x060032B2 RID: 12978 RVA: 0x00080EF3 File Offset: 0x0007F0F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackSwordChallengeInfoRequest(BlackSwordChallengeInfoRequest other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060032B3 RID: 12979 RVA: 0x00080F18 File Offset: 0x0007F118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackSwordChallengeInfoRequest Clone()
		{
			return new BlackSwordChallengeInfoRequest(this);
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x060032B4 RID: 12980 RVA: 0x00080F20 File Offset: 0x0007F120
		// (set) Token: 0x060032B5 RID: 12981 RVA: 0x00080F28 File Offset: 0x0007F128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChallengeId
		{
			get
			{
				return this.challengeId_;
			}
			set
			{
				this.challengeId_ = value;
			}
		}

		// Token: 0x060032B6 RID: 12982 RVA: 0x00080F31 File Offset: 0x0007F131
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlackSwordChallengeInfoRequest);
		}

		// Token: 0x060032B7 RID: 12983 RVA: 0x00080F3F File Offset: 0x0007F13F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BlackSwordChallengeInfoRequest other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060032B8 RID: 12984 RVA: 0x00080F70 File Offset: 0x0007F170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060032B9 RID: 12985 RVA: 0x00080FAF File Offset: 0x0007F1AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060032BA RID: 12986 RVA: 0x00080FBC File Offset: 0x0007F1BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060032BB RID: 12987 RVA: 0x00080FC5 File Offset: 0x0007F1C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060032BC RID: 12988 RVA: 0x00080FF8 File Offset: 0x0007F1F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060032BD RID: 12989 RVA: 0x00081036 File Offset: 0x0007F236
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BlackSwordChallengeInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060032BE RID: 12990 RVA: 0x00081067 File Offset: 0x0007F267
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060032BF RID: 12991 RVA: 0x00081070 File Offset: 0x0007F270
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ChallengeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040029DF RID: 10719
		private UnknownFieldSet _unknownFields;

		// Token: 0x040029E0 RID: 10720
		public const int ChallengeIdFieldNumber = 14;

		// Token: 0x040029E1 RID: 10721
		private int challengeId_;
	}
}
