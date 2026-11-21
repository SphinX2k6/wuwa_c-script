using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200010B RID: 267
	[NetMessage(EMessageId.ApplySceneClientEntityIncIdResponse)]
	public sealed class ApplySceneClientEntityIncIdResponse : IMessage<ApplySceneClientEntityIncIdResponse>, IMessage, IEquatable<ApplySceneClientEntityIncIdResponse>, IDeepCloneable<ApplySceneClientEntityIncIdResponse>, IBufferMessage
	{
		// Token: 0x06002551 RID: 9553 RVA: 0x00063C1D File Offset: 0x00061E1D
		[NullableContext(1)]
		public static ApplySceneClientEntityIncIdResponse Create()
		{
			return new ApplySceneClientEntityIncIdResponse();
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06002552 RID: 9554 RVA: 0x00063C24 File Offset: 0x00061E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06002553 RID: 9555 RVA: 0x00063C27 File Offset: 0x00061E27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ApplySceneClientEntityIncIdResponse.Descriptor;
			}
		}

		// Token: 0x06002554 RID: 9556 RVA: 0x00063C2E File Offset: 0x00061E2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplySceneClientEntityIncIdResponse()
		{
		}

		// Token: 0x06002555 RID: 9557 RVA: 0x00063C44 File Offset: 0x00061E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplySceneClientEntityIncIdResponse(ApplySceneClientEntityIncIdResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.instId_ = other.instId_;
			this.clientEntityInfo_ = other.clientEntityInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002556 RID: 9558 RVA: 0x00063C91 File Offset: 0x00061E91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplySceneClientEntityIncIdResponse Clone()
		{
			return new ApplySceneClientEntityIncIdResponse(this);
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06002557 RID: 9559 RVA: 0x00063C99 File Offset: 0x00061E99
		// (set) Token: 0x06002558 RID: 9560 RVA: 0x00063CA1 File Offset: 0x00061EA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06002559 RID: 9561 RVA: 0x00063CAA File Offset: 0x00061EAA
		// (set) Token: 0x0600255A RID: 9562 RVA: 0x00063CB2 File Offset: 0x00061EB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x0600255B RID: 9563 RVA: 0x00063CBB File Offset: 0x00061EBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ClientEntityInfoPb> ClientEntityInfo
		{
			get
			{
				return this.clientEntityInfo_;
			}
		}

		// Token: 0x0600255C RID: 9564 RVA: 0x00063CC3 File Offset: 0x00061EC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ApplySceneClientEntityIncIdResponse);
		}

		// Token: 0x0600255D RID: 9565 RVA: 0x00063CD4 File Offset: 0x00061ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ApplySceneClientEntityIncIdResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.InstId == other.InstId && this.clientEntityInfo_.Equals(other.clientEntityInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600255E RID: 9566 RVA: 0x00063D34 File Offset: 0x00061F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			num ^= this.clientEntityInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600255F RID: 9567 RVA: 0x00063DA0 File Offset: 0x00061FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002560 RID: 9568 RVA: 0x00063DAD File Offset: 0x00061FAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002561 RID: 9569 RVA: 0x00063DB8 File Offset: 0x00061FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.clientEntityInfo_.WriteTo(ref output, ApplySceneClientEntityIncIdResponse._repeated_clientEntityInfo_codec);
			if (this.InstId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002562 RID: 9570 RVA: 0x00063E24 File Offset: 0x00062024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			num += this.clientEntityInfo_.CalculateSize(ApplySceneClientEntityIncIdResponse._repeated_clientEntityInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002563 RID: 9571 RVA: 0x00063E90 File Offset: 0x00062090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ApplySceneClientEntityIncIdResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			this.clientEntityInfo_.Add(other.clientEntityInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002564 RID: 9572 RVA: 0x00063EF1 File Offset: 0x000620F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002565 RID: 9573 RVA: 0x00063EFC File Offset: 0x000620FC
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
					if (num != 106U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.InstId = input.ReadInt32();
						}
					}
					else
					{
						this.clientEntityInfo_.AddEntriesFrom(ref input, ApplySceneClientEntityIncIdResponse._repeated_clientEntityInfo_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002606 RID: 9734
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002607 RID: 9735
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04002608 RID: 9736
		private ErrorCode errorCode_;

		// Token: 0x04002609 RID: 9737
		public const int InstIdFieldNumber = 15;

		// Token: 0x0400260A RID: 9738
		private int instId_;

		// Token: 0x0400260B RID: 9739
		public const int ClientEntityInfoFieldNumber = 13;

		// Token: 0x0400260C RID: 9740
		private static readonly FieldCodec<ClientEntityInfoPb> _repeated_clientEntityInfo_codec = FieldCodec.ForMessage<ClientEntityInfoPb>(106U, ClientEntityInfoPb.Parser);

		// Token: 0x0400260D RID: 9741
		private readonly RepeatedField<ClientEntityInfoPb> clientEntityInfo_ = new RepeatedField<ClientEntityInfoPb>();
	}
}
