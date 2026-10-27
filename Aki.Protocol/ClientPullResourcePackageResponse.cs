using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200029F RID: 671
	[NetMessage(EMessageId.ClientPullResourcePackageResponse)]
	public sealed class ClientPullResourcePackageResponse : IMessage<ClientPullResourcePackageResponse>, IMessage, IEquatable<ClientPullResourcePackageResponse>, IDeepCloneable<ClientPullResourcePackageResponse>, IBufferMessage
	{
		// Token: 0x060045D2 RID: 17874 RVA: 0x000AB9E5 File Offset: 0x000A9BE5
		[NullableContext(1)]
		public static ClientPullResourcePackageResponse Create()
		{
			return new ClientPullResourcePackageResponse();
		}

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x060045D3 RID: 17875 RVA: 0x000AB9EC File Offset: 0x000A9BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x060045D4 RID: 17876 RVA: 0x000AB9EF File Offset: 0x000A9BEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientPullResourcePackageResponse.Descriptor;
			}
		}

		// Token: 0x060045D5 RID: 17877 RVA: 0x000AB9F6 File Offset: 0x000A9BF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientPullResourcePackageResponse()
		{
		}

		// Token: 0x060045D6 RID: 17878 RVA: 0x000ABA14 File Offset: 0x000A9C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientPullResourcePackageResponse(ClientPullResourcePackageResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this.finishMp4QuestIds_ = other.finishMp4QuestIds_.Clone();
			this.needConfirmQuestIds_ = other.needConfirmQuestIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060045D7 RID: 17879 RVA: 0x000ABA66 File Offset: 0x000A9C66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientPullResourcePackageResponse Clone()
		{
			return new ClientPullResourcePackageResponse(this);
		}

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x060045D8 RID: 17880 RVA: 0x000ABA6E File Offset: 0x000A9C6E
		// (set) Token: 0x060045D9 RID: 17881 RVA: 0x000ABA76 File Offset: 0x000A9C76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorId
		{
			get
			{
				return this.errorId_;
			}
			set
			{
				this.errorId_ = value;
			}
		}

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x060045DA RID: 17882 RVA: 0x000ABA7F File Offset: 0x000A9C7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> FinishMp4QuestIds
		{
			get
			{
				return this.finishMp4QuestIds_;
			}
		}

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x060045DB RID: 17883 RVA: 0x000ABA87 File Offset: 0x000A9C87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> NeedConfirmQuestIds
		{
			get
			{
				return this.needConfirmQuestIds_;
			}
		}

		// Token: 0x060045DC RID: 17884 RVA: 0x000ABA8F File Offset: 0x000A9C8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientPullResourcePackageResponse);
		}

		// Token: 0x060045DD RID: 17885 RVA: 0x000ABAA0 File Offset: 0x000A9CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientPullResourcePackageResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && this.finishMp4QuestIds_.Equals(other.finishMp4QuestIds_) && this.needConfirmQuestIds_.Equals(other.needConfirmQuestIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060045DE RID: 17886 RVA: 0x000ABB04 File Offset: 0x000A9D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorId != ErrorCode.Success)
			{
				num ^= this.ErrorId.GetHashCode();
			}
			num ^= this.finishMp4QuestIds_.GetHashCode();
			num ^= this.needConfirmQuestIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060045DF RID: 17887 RVA: 0x000ABB65 File Offset: 0x000A9D65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060045E0 RID: 17888 RVA: 0x000ABB72 File Offset: 0x000A9D72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060045E1 RID: 17889 RVA: 0x000ABB7C File Offset: 0x000A9D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.needConfirmQuestIds_.WriteTo(ref output, ClientPullResourcePackageResponse._repeated_needConfirmQuestIds_codec);
			this.finishMp4QuestIds_.WriteTo(ref output, ClientPullResourcePackageResponse._repeated_finishMp4QuestIds_codec);
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060045E2 RID: 17890 RVA: 0x000ABBDC File Offset: 0x000A9DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorId != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorId);
			}
			num += this.finishMp4QuestIds_.CalculateSize(ClientPullResourcePackageResponse._repeated_finishMp4QuestIds_codec);
			num += this.needConfirmQuestIds_.CalculateSize(ClientPullResourcePackageResponse._repeated_needConfirmQuestIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060045E3 RID: 17891 RVA: 0x000ABC40 File Offset: 0x000A9E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClientPullResourcePackageResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorId != ErrorCode.Success)
			{
				this.ErrorId = other.ErrorId;
			}
			this.finishMp4QuestIds_.Add(other.finishMp4QuestIds_);
			this.needConfirmQuestIds_.Add(other.needConfirmQuestIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060045E4 RID: 17892 RVA: 0x000ABC9E File Offset: 0x000A9E9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060045E5 RID: 17893 RVA: 0x000ABCA8 File Offset: 0x000A9EA8
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
				if (num <= 18U)
				{
					if (num == 16U || num == 18U)
					{
						this.needConfirmQuestIds_.AddEntriesFrom(ref input, ClientPullResourcePackageResponse._repeated_needConfirmQuestIds_codec);
						continue;
					}
				}
				else
				{
					if (num == 88U || num == 90U)
					{
						this.finishMp4QuestIds_.AddEntriesFrom(ref input, ClientPullResourcePackageResponse._repeated_finishMp4QuestIds_codec);
						continue;
					}
					if (num == 120U)
					{
						this.ErrorId = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002F27 RID: 12071
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F28 RID: 12072
		public const int ErrorIdFieldNumber = 15;

		// Token: 0x04002F29 RID: 12073
		private ErrorCode errorId_;

		// Token: 0x04002F2A RID: 12074
		public const int FinishMp4QuestIdsFieldNumber = 11;

		// Token: 0x04002F2B RID: 12075
		private static readonly FieldCodec<int> _repeated_finishMp4QuestIds_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04002F2C RID: 12076
		private readonly RepeatedField<int> finishMp4QuestIds_ = new RepeatedField<int>();

		// Token: 0x04002F2D RID: 12077
		public const int NeedConfirmQuestIdsFieldNumber = 2;

		// Token: 0x04002F2E RID: 12078
		private static readonly FieldCodec<int> _repeated_needConfirmQuestIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04002F2F RID: 12079
		private readonly RepeatedField<int> needConfirmQuestIds_ = new RepeatedField<int>();
	}
}
