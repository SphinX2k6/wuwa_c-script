using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001112 RID: 4370
	[NetMessage(EMessageId.RoverRogueLootInfoResponse)]
	public sealed class RoverRogueLootInfoResponse : IMessage<RoverRogueLootInfoResponse>, IMessage, IEquatable<RoverRogueLootInfoResponse>, IDeepCloneable<RoverRogueLootInfoResponse>, IBufferMessage
	{
		// Token: 0x060174EC RID: 95468 RVA: 0x003625A5 File Offset: 0x003607A5
		[NullableContext(1)]
		public static RoverRogueLootInfoResponse Create()
		{
			return new RoverRogueLootInfoResponse();
		}

		// Token: 0x17004E2B RID: 20011
		// (get) Token: 0x060174ED RID: 95469 RVA: 0x003625AC File Offset: 0x003607AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E2C RID: 20012
		// (get) Token: 0x060174EE RID: 95470 RVA: 0x003625AF File Offset: 0x003607AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueLootInfoResponse.Descriptor;
			}
		}

		// Token: 0x060174EF RID: 95471 RVA: 0x003625B6 File Offset: 0x003607B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueLootInfoResponse()
		{
		}

		// Token: 0x060174F0 RID: 95472 RVA: 0x003625C9 File Offset: 0x003607C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueLootInfoResponse(RoverRogueLootInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.loots_ = other.loots_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060174F1 RID: 95473 RVA: 0x003625FF File Offset: 0x003607FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueLootInfoResponse Clone()
		{
			return new RoverRogueLootInfoResponse(this);
		}

		// Token: 0x17004E2D RID: 20013
		// (get) Token: 0x060174F2 RID: 95474 RVA: 0x00362607 File Offset: 0x00360807
		// (set) Token: 0x060174F3 RID: 95475 RVA: 0x0036260F File Offset: 0x0036080F
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

		// Token: 0x17004E2E RID: 20014
		// (get) Token: 0x060174F4 RID: 95476 RVA: 0x00362618 File Offset: 0x00360818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueGainEntry> Loots
		{
			get
			{
				return this.loots_;
			}
		}

		// Token: 0x060174F5 RID: 95477 RVA: 0x00362620 File Offset: 0x00360820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueLootInfoResponse);
		}

		// Token: 0x060174F6 RID: 95478 RVA: 0x00362630 File Offset: 0x00360830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueLootInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.loots_.Equals(other.loots_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060174F7 RID: 95479 RVA: 0x00362680 File Offset: 0x00360880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.loots_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060174F8 RID: 95480 RVA: 0x003626D3 File Offset: 0x003608D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060174F9 RID: 95481 RVA: 0x003626E0 File Offset: 0x003608E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060174FA RID: 95482 RVA: 0x003626EC File Offset: 0x003608EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.loots_.WriteTo(ref output, RoverRogueLootInfoResponse._repeated_loots_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060174FB RID: 95483 RVA: 0x0036273C File Offset: 0x0036093C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.loots_.CalculateSize(RoverRogueLootInfoResponse._repeated_loots_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060174FC RID: 95484 RVA: 0x00362790 File Offset: 0x00360990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueLootInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.loots_.Add(other.loots_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060174FD RID: 95485 RVA: 0x003627DD File Offset: 0x003609DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060174FE RID: 95486 RVA: 0x003627E8 File Offset: 0x003609E8
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
				if (num != 34U)
				{
					if (num != 56U)
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
					this.loots_.AddEntriesFrom(ref input, RoverRogueLootInfoResponse._repeated_loots_codec);
				}
			}
		}

		// Token: 0x04008AA1 RID: 35489
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008AA2 RID: 35490
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04008AA3 RID: 35491
		private ErrorCode errorCode_;

		// Token: 0x04008AA4 RID: 35492
		public const int LootsFieldNumber = 4;

		// Token: 0x04008AA5 RID: 35493
		private static readonly FieldCodec<RoverRogueGainEntry> _repeated_loots_codec = FieldCodec.ForMessage<RoverRogueGainEntry>(34U, RoverRogueGainEntry.Parser);

		// Token: 0x04008AA6 RID: 35494
		private readonly RepeatedField<RoverRogueGainEntry> loots_ = new RepeatedField<RoverRogueGainEntry>();
	}
}
