using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B71 RID: 2929
	[NetMessage(EMessageId.OccupyRewardResponse)]
	public sealed class OccupyRewardResponse : IMessage<OccupyRewardResponse>, IMessage, IEquatable<OccupyRewardResponse>, IDeepCloneable<OccupyRewardResponse>, IBufferMessage
	{
		// Token: 0x0600FE38 RID: 65080 RVA: 0x00251989 File Offset: 0x0024FB89
		[NullableContext(1)]
		public static OccupyRewardResponse Create()
		{
			return new OccupyRewardResponse();
		}

		// Token: 0x170033E4 RID: 13284
		// (get) Token: 0x0600FE39 RID: 65081 RVA: 0x00251990 File Offset: 0x0024FB90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170033E5 RID: 13285
		// (get) Token: 0x0600FE3A RID: 65082 RVA: 0x00251993 File Offset: 0x0024FB93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OccupyRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600FE3B RID: 65083 RVA: 0x0025199A File Offset: 0x0024FB9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OccupyRewardResponse()
		{
		}

		// Token: 0x0600FE3C RID: 65084 RVA: 0x002519AD File Offset: 0x0024FBAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OccupyRewardResponse(OccupyRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FE3D RID: 65085 RVA: 0x002519E3 File Offset: 0x0024FBE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OccupyRewardResponse Clone()
		{
			return new OccupyRewardResponse(this);
		}

		// Token: 0x170033E6 RID: 13286
		// (get) Token: 0x0600FE3E RID: 65086 RVA: 0x002519EB File Offset: 0x0024FBEB
		// (set) Token: 0x0600FE3F RID: 65087 RVA: 0x002519F3 File Offset: 0x0024FBF3
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

		// Token: 0x170033E7 RID: 13287
		// (get) Token: 0x0600FE40 RID: 65088 RVA: 0x002519FC File Offset: 0x0024FBFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x0600FE41 RID: 65089 RVA: 0x00251A04 File Offset: 0x0024FC04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OccupyRewardResponse);
		}

		// Token: 0x0600FE42 RID: 65090 RVA: 0x00251A14 File Offset: 0x0024FC14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OccupyRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FE43 RID: 65091 RVA: 0x00251A64 File Offset: 0x0024FC64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.ids_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FE44 RID: 65092 RVA: 0x00251AB7 File Offset: 0x0024FCB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FE45 RID: 65093 RVA: 0x00251AC4 File Offset: 0x0024FCC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FE46 RID: 65094 RVA: 0x00251AD0 File Offset: 0x0024FCD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ids_.WriteTo(ref output, OccupyRewardResponse._repeated_ids_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FE47 RID: 65095 RVA: 0x00251B20 File Offset: 0x0024FD20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.ids_.CalculateSize(OccupyRewardResponse._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FE48 RID: 65096 RVA: 0x00251B74 File Offset: 0x0024FD74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OccupyRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.ids_.Add(other.ids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FE49 RID: 65097 RVA: 0x00251BC1 File Offset: 0x0024FDC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FE4A RID: 65098 RVA: 0x00251BCC File Offset: 0x0024FDCC
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
				if (num != 80U && num != 82U)
				{
					if (num != 96U)
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
					this.ids_.AddEntriesFrom(ref input, OccupyRewardResponse._repeated_ids_codec);
				}
			}
		}

		// Token: 0x040065B8 RID: 26040
		private UnknownFieldSet _unknownFields;

		// Token: 0x040065B9 RID: 26041
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x040065BA RID: 26042
		private ErrorCode errorCode_;

		// Token: 0x040065BB RID: 26043
		public const int IdsFieldNumber = 10;

		// Token: 0x040065BC RID: 26044
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(82U);

		// Token: 0x040065BD RID: 26045
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
