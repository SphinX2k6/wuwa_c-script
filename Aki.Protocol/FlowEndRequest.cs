using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005F8 RID: 1528
	[NetMessage(EMessageId.FlowEndRequest)]
	public sealed class FlowEndRequest : IMessage<FlowEndRequest>, IMessage, IEquatable<FlowEndRequest>, IDeepCloneable<FlowEndRequest>, IBufferMessage
	{
		// Token: 0x06008D70 RID: 36208 RVA: 0x00157066 File Offset: 0x00155266
		[NullableContext(1)]
		public static FlowEndRequest Create()
		{
			return new FlowEndRequest();
		}

		// Token: 0x17001C0B RID: 7179
		// (get) Token: 0x06008D71 RID: 36209 RVA: 0x0015706D File Offset: 0x0015526D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C0C RID: 7180
		// (get) Token: 0x06008D72 RID: 36210 RVA: 0x00157070 File Offset: 0x00155270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlowEndRequest.Descriptor;
			}
		}

		// Token: 0x06008D73 RID: 36211 RVA: 0x00157077 File Offset: 0x00155277
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowEndRequest()
		{
		}

		// Token: 0x06008D74 RID: 36212 RVA: 0x0015708C File Offset: 0x0015528C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowEndRequest(FlowEndRequest other) : this()
		{
			this.flowIncId_ = other.flowIncId_;
			this.isSkip_ = other.isSkip_;
			this.optionInfos_ = other.optionInfos_.Clone();
			this.clientError_ = other.clientError_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008D75 RID: 36213 RVA: 0x001570E5 File Offset: 0x001552E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowEndRequest Clone()
		{
			return new FlowEndRequest(this);
		}

		// Token: 0x17001C0D RID: 7181
		// (get) Token: 0x06008D76 RID: 36214 RVA: 0x001570ED File Offset: 0x001552ED
		// (set) Token: 0x06008D77 RID: 36215 RVA: 0x001570F5 File Offset: 0x001552F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long FlowIncId
		{
			get
			{
				return this.flowIncId_;
			}
			set
			{
				this.flowIncId_ = value;
			}
		}

		// Token: 0x17001C0E RID: 7182
		// (get) Token: 0x06008D78 RID: 36216 RVA: 0x001570FE File Offset: 0x001552FE
		// (set) Token: 0x06008D79 RID: 36217 RVA: 0x00157106 File Offset: 0x00155306
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSkip
		{
			get
			{
				return this.isSkip_;
			}
			set
			{
				this.isSkip_ = value;
			}
		}

		// Token: 0x17001C0F RID: 7183
		// (get) Token: 0x06008D7A RID: 36218 RVA: 0x0015710F File Offset: 0x0015530F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, FlowOptionInfoList> OptionInfos
		{
			get
			{
				return this.optionInfos_;
			}
		}

		// Token: 0x17001C10 RID: 7184
		// (get) Token: 0x06008D7B RID: 36219 RVA: 0x00157117 File Offset: 0x00155317
		// (set) Token: 0x06008D7C RID: 36220 RVA: 0x0015711F File Offset: 0x0015531F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ClientError
		{
			get
			{
				return this.clientError_;
			}
			set
			{
				this.clientError_ = value;
			}
		}

		// Token: 0x06008D7D RID: 36221 RVA: 0x00157128 File Offset: 0x00155328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlowEndRequest);
		}

		// Token: 0x06008D7E RID: 36222 RVA: 0x00157138 File Offset: 0x00155338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlowEndRequest other)
		{
			return other != null && (other == this || (this.FlowIncId == other.FlowIncId && this.IsSkip == other.IsSkip && this.OptionInfos.Equals(other.OptionInfos) && this.ClientError == other.ClientError && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008D7F RID: 36223 RVA: 0x001571A8 File Offset: 0x001553A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FlowIncId != 0L)
			{
				num ^= this.FlowIncId.GetHashCode();
			}
			if (this.IsSkip)
			{
				num ^= this.IsSkip.GetHashCode();
			}
			num ^= this.OptionInfos.GetHashCode();
			if (this.ClientError)
			{
				num ^= this.ClientError.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008D80 RID: 36224 RVA: 0x00157227 File Offset: 0x00155427
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008D81 RID: 36225 RVA: 0x00157234 File Offset: 0x00155434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008D82 RID: 36226 RVA: 0x00157240 File Offset: 0x00155440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ClientError)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.ClientError);
			}
			if (this.IsSkip)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsSkip);
			}
			if (this.FlowIncId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.FlowIncId);
			}
			this.optionInfos_.WriteTo(ref output, FlowEndRequest._map_optionInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008D83 RID: 36227 RVA: 0x001572C8 File Offset: 0x001554C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FlowIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.FlowIncId);
			}
			if (this.IsSkip)
			{
				num += 2;
			}
			num += this.optionInfos_.CalculateSize(FlowEndRequest._map_optionInfos_codec);
			if (this.ClientError)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008D84 RID: 36228 RVA: 0x00157334 File Offset: 0x00155534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlowEndRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FlowIncId != 0L)
			{
				this.FlowIncId = other.FlowIncId;
			}
			if (other.IsSkip)
			{
				this.IsSkip = other.IsSkip;
			}
			this.optionInfos_.MergeFrom(other.optionInfos_);
			if (other.ClientError)
			{
				this.ClientError = other.ClientError;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008D85 RID: 36229 RVA: 0x001573A9 File Offset: 0x001555A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008D86 RID: 36230 RVA: 0x001573B4 File Offset: 0x001555B4
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
				if (num <= 64U)
				{
					if (num == 32U)
					{
						this.ClientError = input.ReadBool();
						continue;
					}
					if (num == 64U)
					{
						this.IsSkip = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.FlowIncId = input.ReadInt64();
						continue;
					}
					if (num == 122U)
					{
						this.optionInfos_.AddEntriesFrom(ref input, FlowEndRequest._map_optionInfos_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400450D RID: 17677
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400450E RID: 17678
		public const int FlowIncIdFieldNumber = 11;

		// Token: 0x0400450F RID: 17679
		private long flowIncId_;

		// Token: 0x04004510 RID: 17680
		public const int IsSkipFieldNumber = 8;

		// Token: 0x04004511 RID: 17681
		private bool isSkip_;

		// Token: 0x04004512 RID: 17682
		public const int OptionInfosFieldNumber = 15;

		// Token: 0x04004513 RID: 17683
		private static readonly MapField<int, FlowOptionInfoList>.Codec _map_optionInfos_codec = new MapField<int, FlowOptionInfoList>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<FlowOptionInfoList>(18U, FlowOptionInfoList.Parser), 122U);

		// Token: 0x04004514 RID: 17684
		private readonly MapField<int, FlowOptionInfoList> optionInfos_ = new MapField<int, FlowOptionInfoList>();

		// Token: 0x04004515 RID: 17685
		public const int ClientErrorFieldNumber = 4;

		// Token: 0x04004516 RID: 17686
		private bool clientError_;
	}
}
