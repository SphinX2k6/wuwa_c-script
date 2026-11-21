using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002A5 RID: 677
	[NetMessage(EMessageId.ClientPullResourcePackageResponse)]
	public sealed class ClientPullResourcePackageResponse : IMessage<ClientPullResourcePackageResponse>, IMessage, IEquatable<ClientPullResourcePackageResponse>, IDeepCloneable<ClientPullResourcePackageResponse>, IBufferMessage
	{
		// Token: 0x06004699 RID: 18073 RVA: 0x000ADBF5 File Offset: 0x000ABDF5
		[NullableContext(1)]
		public static ClientPullResourcePackageResponse Create()
		{
			return new ClientPullResourcePackageResponse();
		}

		// Token: 0x17000C3D RID: 3133
		// (get) Token: 0x0600469A RID: 18074 RVA: 0x000ADBFC File Offset: 0x000ABDFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C3E RID: 3134
		// (get) Token: 0x0600469B RID: 18075 RVA: 0x000ADBFF File Offset: 0x000ABDFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientPullResourcePackageResponse.Descriptor;
			}
		}

		// Token: 0x0600469C RID: 18076 RVA: 0x000ADC06 File Offset: 0x000ABE06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientPullResourcePackageResponse()
		{
		}

		// Token: 0x0600469D RID: 18077 RVA: 0x000ADC24 File Offset: 0x000ABE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientPullResourcePackageResponse(ClientPullResourcePackageResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this.finishMp4QuestIds_ = other.finishMp4QuestIds_.Clone();
			this.needConfirmQuestIds_ = other.needConfirmQuestIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600469E RID: 18078 RVA: 0x000ADC76 File Offset: 0x000ABE76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientPullResourcePackageResponse Clone()
		{
			return new ClientPullResourcePackageResponse(this);
		}

		// Token: 0x17000C3F RID: 3135
		// (get) Token: 0x0600469F RID: 18079 RVA: 0x000ADC7E File Offset: 0x000ABE7E
		// (set) Token: 0x060046A0 RID: 18080 RVA: 0x000ADC86 File Offset: 0x000ABE86
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

		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x060046A1 RID: 18081 RVA: 0x000ADC8F File Offset: 0x000ABE8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> FinishMp4QuestIds
		{
			get
			{
				return this.finishMp4QuestIds_;
			}
		}

		// Token: 0x17000C41 RID: 3137
		// (get) Token: 0x060046A2 RID: 18082 RVA: 0x000ADC97 File Offset: 0x000ABE97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> NeedConfirmQuestIds
		{
			get
			{
				return this.needConfirmQuestIds_;
			}
		}

		// Token: 0x060046A3 RID: 18083 RVA: 0x000ADC9F File Offset: 0x000ABE9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientPullResourcePackageResponse);
		}

		// Token: 0x060046A4 RID: 18084 RVA: 0x000ADCB0 File Offset: 0x000ABEB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientPullResourcePackageResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && this.finishMp4QuestIds_.Equals(other.finishMp4QuestIds_) && this.needConfirmQuestIds_.Equals(other.needConfirmQuestIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060046A5 RID: 18085 RVA: 0x000ADD14 File Offset: 0x000ABF14
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

		// Token: 0x060046A6 RID: 18086 RVA: 0x000ADD75 File Offset: 0x000ABF75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060046A7 RID: 18087 RVA: 0x000ADD82 File Offset: 0x000ABF82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060046A8 RID: 18088 RVA: 0x000ADD8C File Offset: 0x000ABF8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.finishMp4QuestIds_.WriteTo(ref output, ClientPullResourcePackageResponse._repeated_finishMp4QuestIds_codec);
			this.needConfirmQuestIds_.WriteTo(ref output, ClientPullResourcePackageResponse._repeated_needConfirmQuestIds_codec);
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060046A9 RID: 18089 RVA: 0x000ADDEC File Offset: 0x000ABFEC
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

		// Token: 0x060046AA RID: 18090 RVA: 0x000ADE50 File Offset: 0x000AC050
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

		// Token: 0x060046AB RID: 18091 RVA: 0x000ADEAE File Offset: 0x000AC0AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060046AC RID: 18092 RVA: 0x000ADEB8 File Offset: 0x000AC0B8
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
				if (num <= 58U)
				{
					if (num == 56U || num == 58U)
					{
						this.finishMp4QuestIds_.AddEntriesFrom(ref input, ClientPullResourcePackageResponse._repeated_finishMp4QuestIds_codec);
						continue;
					}
				}
				else
				{
					if (num == 72U || num == 74U)
					{
						this.needConfirmQuestIds_.AddEntriesFrom(ref input, ClientPullResourcePackageResponse._repeated_needConfirmQuestIds_codec);
						continue;
					}
					if (num == 104U)
					{
						this.ErrorId = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002FBA RID: 12218
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FBB RID: 12219
		public const int ErrorIdFieldNumber = 13;

		// Token: 0x04002FBC RID: 12220
		private ErrorCode errorId_;

		// Token: 0x04002FBD RID: 12221
		public const int FinishMp4QuestIdsFieldNumber = 7;

		// Token: 0x04002FBE RID: 12222
		private static readonly FieldCodec<int> _repeated_finishMp4QuestIds_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04002FBF RID: 12223
		private readonly RepeatedField<int> finishMp4QuestIds_ = new RepeatedField<int>();

		// Token: 0x04002FC0 RID: 12224
		public const int NeedConfirmQuestIdsFieldNumber = 9;

		// Token: 0x04002FC1 RID: 12225
		private static readonly FieldCodec<int> _repeated_needConfirmQuestIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04002FC2 RID: 12226
		private readonly RepeatedField<int> needConfirmQuestIds_ = new RepeatedField<int>();
	}
}
