using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001AF RID: 431
	[NetMessage(EMessageId.BlackSwordChallengeMarkItemPanelInfoRequest)]
	public sealed class BlackSwordChallengeMarkItemPanelInfoRequest : IMessage<BlackSwordChallengeMarkItemPanelInfoRequest>, IMessage, IEquatable<BlackSwordChallengeMarkItemPanelInfoRequest>, IDeepCloneable<BlackSwordChallengeMarkItemPanelInfoRequest>, IBufferMessage
	{
		// Token: 0x06003249 RID: 12873 RVA: 0x0007FCAB File Offset: 0x0007DEAB
		[NullableContext(1)]
		public static BlackSwordChallengeMarkItemPanelInfoRequest Create()
		{
			return new BlackSwordChallengeMarkItemPanelInfoRequest();
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x0600324A RID: 12874 RVA: 0x0007FCB2 File Offset: 0x0007DEB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x0600324B RID: 12875 RVA: 0x0007FCB5 File Offset: 0x0007DEB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlackSwordChallengeMarkItemPanelInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600324C RID: 12876 RVA: 0x0007FCBC File Offset: 0x0007DEBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackSwordChallengeMarkItemPanelInfoRequest()
		{
		}

		// Token: 0x0600324D RID: 12877 RVA: 0x0007FCC4 File Offset: 0x0007DEC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackSwordChallengeMarkItemPanelInfoRequest(BlackSwordChallengeMarkItemPanelInfoRequest other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600324E RID: 12878 RVA: 0x0007FCE9 File Offset: 0x0007DEE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackSwordChallengeMarkItemPanelInfoRequest Clone()
		{
			return new BlackSwordChallengeMarkItemPanelInfoRequest(this);
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x0600324F RID: 12879 RVA: 0x0007FCF1 File Offset: 0x0007DEF1
		// (set) Token: 0x06003250 RID: 12880 RVA: 0x0007FCF9 File Offset: 0x0007DEF9
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

		// Token: 0x06003251 RID: 12881 RVA: 0x0007FD02 File Offset: 0x0007DF02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlackSwordChallengeMarkItemPanelInfoRequest);
		}

		// Token: 0x06003252 RID: 12882 RVA: 0x0007FD10 File Offset: 0x0007DF10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BlackSwordChallengeMarkItemPanelInfoRequest other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003253 RID: 12883 RVA: 0x0007FD40 File Offset: 0x0007DF40
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

		// Token: 0x06003254 RID: 12884 RVA: 0x0007FD7F File Offset: 0x0007DF7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003255 RID: 12885 RVA: 0x0007FD8C File Offset: 0x0007DF8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003256 RID: 12886 RVA: 0x0007FD95 File Offset: 0x0007DF95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003257 RID: 12887 RVA: 0x0007FDC8 File Offset: 0x0007DFC8
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

		// Token: 0x06003258 RID: 12888 RVA: 0x0007FE06 File Offset: 0x0007E006
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BlackSwordChallengeMarkItemPanelInfoRequest other)
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

		// Token: 0x06003259 RID: 12889 RVA: 0x0007FE37 File Offset: 0x0007E037
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600325A RID: 12890 RVA: 0x0007FE40 File Offset: 0x0007E040
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
					this.ChallengeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400296F RID: 10607
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002970 RID: 10608
		public const int ChallengeIdFieldNumber = 13;

		// Token: 0x04002971 RID: 10609
		private int challengeId_;
	}
}
