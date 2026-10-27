using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001AD RID: 429
	[NetMessage(EMessageId.BlackSwordChallengeInfoRequest)]
	public sealed class BlackSwordChallengeInfoRequest : IMessage<BlackSwordChallengeInfoRequest>, IMessage, IEquatable<BlackSwordChallengeInfoRequest>, IDeepCloneable<BlackSwordChallengeInfoRequest>, IBufferMessage
	{
		// Token: 0x06003221 RID: 12833 RVA: 0x0007F76E File Offset: 0x0007D96E
		[NullableContext(1)]
		public static BlackSwordChallengeInfoRequest Create()
		{
			return new BlackSwordChallengeInfoRequest();
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x06003222 RID: 12834 RVA: 0x0007F775 File Offset: 0x0007D975
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x06003223 RID: 12835 RVA: 0x0007F778 File Offset: 0x0007D978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlackSwordChallengeInfoRequest.Descriptor;
			}
		}

		// Token: 0x06003224 RID: 12836 RVA: 0x0007F77F File Offset: 0x0007D97F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackSwordChallengeInfoRequest()
		{
		}

		// Token: 0x06003225 RID: 12837 RVA: 0x0007F787 File Offset: 0x0007D987
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackSwordChallengeInfoRequest(BlackSwordChallengeInfoRequest other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003226 RID: 12838 RVA: 0x0007F7AC File Offset: 0x0007D9AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackSwordChallengeInfoRequest Clone()
		{
			return new BlackSwordChallengeInfoRequest(this);
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x06003227 RID: 12839 RVA: 0x0007F7B4 File Offset: 0x0007D9B4
		// (set) Token: 0x06003228 RID: 12840 RVA: 0x0007F7BC File Offset: 0x0007D9BC
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

		// Token: 0x06003229 RID: 12841 RVA: 0x0007F7C5 File Offset: 0x0007D9C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlackSwordChallengeInfoRequest);
		}

		// Token: 0x0600322A RID: 12842 RVA: 0x0007F7D3 File Offset: 0x0007D9D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BlackSwordChallengeInfoRequest other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600322B RID: 12843 RVA: 0x0007F804 File Offset: 0x0007DA04
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

		// Token: 0x0600322C RID: 12844 RVA: 0x0007F843 File Offset: 0x0007DA43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600322D RID: 12845 RVA: 0x0007F850 File Offset: 0x0007DA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600322E RID: 12846 RVA: 0x0007F859 File Offset: 0x0007DA59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600322F RID: 12847 RVA: 0x0007F88C File Offset: 0x0007DA8C
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

		// Token: 0x06003230 RID: 12848 RVA: 0x0007F8CA File Offset: 0x0007DACA
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

		// Token: 0x06003231 RID: 12849 RVA: 0x0007F8FB File Offset: 0x0007DAFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003232 RID: 12850 RVA: 0x0007F904 File Offset: 0x0007DB04
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ChallengeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002964 RID: 10596
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002965 RID: 10597
		public const int ChallengeIdFieldNumber = 6;

		// Token: 0x04002966 RID: 10598
		private int challengeId_;
	}
}
