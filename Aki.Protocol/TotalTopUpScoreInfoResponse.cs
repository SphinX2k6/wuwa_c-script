using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001405 RID: 5125
	[NetMessage(EMessageId.TotalTopUpScoreInfoResponse)]
	public sealed class TotalTopUpScoreInfoResponse : IMessage<TotalTopUpScoreInfoResponse>, IMessage, IEquatable<TotalTopUpScoreInfoResponse>, IDeepCloneable<TotalTopUpScoreInfoResponse>, IBufferMessage
	{
		// Token: 0x0601B3EF RID: 111599 RVA: 0x003F69A5 File Offset: 0x003F4BA5
		[NullableContext(1)]
		public static TotalTopUpScoreInfoResponse Create()
		{
			return new TotalTopUpScoreInfoResponse();
		}

		// Token: 0x17005C3A RID: 23610
		// (get) Token: 0x0601B3F0 RID: 111600 RVA: 0x003F69AC File Offset: 0x003F4BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C3B RID: 23611
		// (get) Token: 0x0601B3F1 RID: 111601 RVA: 0x003F69AF File Offset: 0x003F4BAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TotalTopUpScoreInfoResponse.Descriptor;
			}
		}

		// Token: 0x0601B3F2 RID: 111602 RVA: 0x003F69B6 File Offset: 0x003F4BB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpScoreInfoResponse()
		{
		}

		// Token: 0x0601B3F3 RID: 111603 RVA: 0x003F69C9 File Offset: 0x003F4BC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpScoreInfoResponse(TotalTopUpScoreInfoResponse other) : this()
		{
			this.infos_ = other.infos_.Clone();
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B3F4 RID: 111604 RVA: 0x003F69FF File Offset: 0x003F4BFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpScoreInfoResponse Clone()
		{
			return new TotalTopUpScoreInfoResponse(this);
		}

		// Token: 0x17005C3C RID: 23612
		// (get) Token: 0x0601B3F5 RID: 111605 RVA: 0x003F6A07 File Offset: 0x003F4C07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TotalTopUpScoreInfo> Infos
		{
			get
			{
				return this.infos_;
			}
		}

		// Token: 0x17005C3D RID: 23613
		// (get) Token: 0x0601B3F6 RID: 111606 RVA: 0x003F6A0F File Offset: 0x003F4C0F
		// (set) Token: 0x0601B3F7 RID: 111607 RVA: 0x003F6A17 File Offset: 0x003F4C17
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

		// Token: 0x0601B3F8 RID: 111608 RVA: 0x003F6A20 File Offset: 0x003F4C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TotalTopUpScoreInfoResponse);
		}

		// Token: 0x0601B3F9 RID: 111609 RVA: 0x003F6A30 File Offset: 0x003F4C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TotalTopUpScoreInfoResponse other)
		{
			return other != null && (other == this || (this.infos_.Equals(other.infos_) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B3FA RID: 111610 RVA: 0x003F6A80 File Offset: 0x003F4C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.infos_.GetHashCode();
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B3FB RID: 111611 RVA: 0x003F6AD3 File Offset: 0x003F4CD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B3FC RID: 111612 RVA: 0x003F6AE0 File Offset: 0x003F4CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B3FD RID: 111613 RVA: 0x003F6AEC File Offset: 0x003F4CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.infos_.WriteTo(ref output, TotalTopUpScoreInfoResponse._repeated_infos_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B3FE RID: 111614 RVA: 0x003F6B3C File Offset: 0x003F4D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.infos_.CalculateSize(TotalTopUpScoreInfoResponse._repeated_infos_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B3FF RID: 111615 RVA: 0x003F6B90 File Offset: 0x003F4D90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TotalTopUpScoreInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.infos_.Add(other.infos_);
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B400 RID: 111616 RVA: 0x003F6BDD File Offset: 0x003F4DDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B401 RID: 111617 RVA: 0x003F6BE8 File Offset: 0x003F4DE8
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
				if (num != 10U)
				{
					if (num != 32U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.infos_.AddEntriesFrom(ref input, TotalTopUpScoreInfoResponse._repeated_infos_codec);
				}
			}
		}

		// Token: 0x04009ECF RID: 40655
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009ED0 RID: 40656
		public const int InfosFieldNumber = 1;

		// Token: 0x04009ED1 RID: 40657
		private static readonly FieldCodec<TotalTopUpScoreInfo> _repeated_infos_codec = FieldCodec.ForMessage<TotalTopUpScoreInfo>(10U, TotalTopUpScoreInfo.Parser);

		// Token: 0x04009ED2 RID: 40658
		private readonly RepeatedField<TotalTopUpScoreInfo> infos_ = new RepeatedField<TotalTopUpScoreInfo>();

		// Token: 0x04009ED3 RID: 40659
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04009ED4 RID: 40660
		private ErrorCode errorCode_;
	}
}
