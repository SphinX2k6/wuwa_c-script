using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000410 RID: 1040
	[NetMessage(EMessageId.EdgeRunnerScoreRewardRequest)]
	public sealed class EdgeRunnerScoreRewardRequest : IMessage<EdgeRunnerScoreRewardRequest>, IMessage, IEquatable<EdgeRunnerScoreRewardRequest>, IDeepCloneable<EdgeRunnerScoreRewardRequest>, IBufferMessage
	{
		// Token: 0x06006493 RID: 25747 RVA: 0x000F2AA9 File Offset: 0x000F0CA9
		[NullableContext(1)]
		public static EdgeRunnerScoreRewardRequest Create()
		{
			return new EdgeRunnerScoreRewardRequest();
		}

		// Token: 0x170012D9 RID: 4825
		// (get) Token: 0x06006494 RID: 25748 RVA: 0x000F2AB0 File Offset: 0x000F0CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170012DA RID: 4826
		// (get) Token: 0x06006495 RID: 25749 RVA: 0x000F2AB3 File Offset: 0x000F0CB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EdgeRunnerScoreRewardRequest.Descriptor;
			}
		}

		// Token: 0x06006496 RID: 25750 RVA: 0x000F2ABA File Offset: 0x000F0CBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerScoreRewardRequest()
		{
		}

		// Token: 0x06006497 RID: 25751 RVA: 0x000F2AC2 File Offset: 0x000F0CC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerScoreRewardRequest(EdgeRunnerScoreRewardRequest other) : this()
		{
			this.scoreId_ = other.scoreId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006498 RID: 25752 RVA: 0x000F2AE7 File Offset: 0x000F0CE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerScoreRewardRequest Clone()
		{
			return new EdgeRunnerScoreRewardRequest(this);
		}

		// Token: 0x170012DB RID: 4827
		// (get) Token: 0x06006499 RID: 25753 RVA: 0x000F2AEF File Offset: 0x000F0CEF
		// (set) Token: 0x0600649A RID: 25754 RVA: 0x000F2AF7 File Offset: 0x000F0CF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ScoreId
		{
			get
			{
				return this.scoreId_;
			}
			set
			{
				this.scoreId_ = value;
			}
		}

		// Token: 0x0600649B RID: 25755 RVA: 0x000F2B00 File Offset: 0x000F0D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EdgeRunnerScoreRewardRequest);
		}

		// Token: 0x0600649C RID: 25756 RVA: 0x000F2B0E File Offset: 0x000F0D0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EdgeRunnerScoreRewardRequest other)
		{
			return other != null && (other == this || (this.ScoreId == other.ScoreId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600649D RID: 25757 RVA: 0x000F2B3C File Offset: 0x000F0D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ScoreId != 0)
			{
				num ^= this.ScoreId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600649E RID: 25758 RVA: 0x000F2B7B File Offset: 0x000F0D7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600649F RID: 25759 RVA: 0x000F2B88 File Offset: 0x000F0D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060064A0 RID: 25760 RVA: 0x000F2B91 File Offset: 0x000F0D91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ScoreId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ScoreId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060064A1 RID: 25761 RVA: 0x000F2BC4 File Offset: 0x000F0DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ScoreId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ScoreId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060064A2 RID: 25762 RVA: 0x000F2C02 File Offset: 0x000F0E02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EdgeRunnerScoreRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ScoreId != 0)
			{
				this.ScoreId = other.ScoreId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060064A3 RID: 25763 RVA: 0x000F2C33 File Offset: 0x000F0E33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060064A4 RID: 25764 RVA: 0x000F2C3C File Offset: 0x000F0E3C
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ScoreId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003900 RID: 14592
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003901 RID: 14593
		public const int ScoreIdFieldNumber = 1;

		// Token: 0x04003902 RID: 14594
		private int scoreId_;
	}
}
