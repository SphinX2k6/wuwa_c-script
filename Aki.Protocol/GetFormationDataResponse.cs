using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006C8 RID: 1736
	[NetMessage(EMessageId.GetFormationDataResponse)]
	public sealed class GetFormationDataResponse : IMessage<GetFormationDataResponse>, IMessage, IEquatable<GetFormationDataResponse>, IDeepCloneable<GetFormationDataResponse>, IBufferMessage
	{
		// Token: 0x06009EC9 RID: 40649 RVA: 0x00181352 File Offset: 0x0017F552
		[NullableContext(1)]
		public static GetFormationDataResponse Create()
		{
			return new GetFormationDataResponse();
		}

		// Token: 0x17001FE7 RID: 8167
		// (get) Token: 0x06009ECA RID: 40650 RVA: 0x00181359 File Offset: 0x0017F559
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FE8 RID: 8168
		// (get) Token: 0x06009ECB RID: 40651 RVA: 0x0018135C File Offset: 0x0017F55C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetFormationDataResponse.Descriptor;
			}
		}

		// Token: 0x06009ECC RID: 40652 RVA: 0x00181363 File Offset: 0x0017F563
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFormationDataResponse()
		{
		}

		// Token: 0x06009ECD RID: 40653 RVA: 0x00181376 File Offset: 0x0017F576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFormationDataResponse(GetFormationDataResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.formations_ = other.formations_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009ECE RID: 40654 RVA: 0x001813AC File Offset: 0x0017F5AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFormationDataResponse Clone()
		{
			return new GetFormationDataResponse(this);
		}

		// Token: 0x17001FE9 RID: 8169
		// (get) Token: 0x06009ECF RID: 40655 RVA: 0x001813B4 File Offset: 0x0017F5B4
		// (set) Token: 0x06009ED0 RID: 40656 RVA: 0x001813BC File Offset: 0x0017F5BC
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

		// Token: 0x17001FEA RID: 8170
		// (get) Token: 0x06009ED1 RID: 40657 RVA: 0x001813C5 File Offset: 0x0017F5C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FightFormation> Formations
		{
			get
			{
				return this.formations_;
			}
		}

		// Token: 0x06009ED2 RID: 40658 RVA: 0x001813CD File Offset: 0x0017F5CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetFormationDataResponse);
		}

		// Token: 0x06009ED3 RID: 40659 RVA: 0x001813DC File Offset: 0x0017F5DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetFormationDataResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.formations_.Equals(other.formations_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009ED4 RID: 40660 RVA: 0x0018142C File Offset: 0x0017F62C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.formations_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009ED5 RID: 40661 RVA: 0x0018147F File Offset: 0x0017F67F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009ED6 RID: 40662 RVA: 0x0018148C File Offset: 0x0017F68C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009ED7 RID: 40663 RVA: 0x00181498 File Offset: 0x0017F698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.formations_.WriteTo(ref output, GetFormationDataResponse._repeated_formations_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009ED8 RID: 40664 RVA: 0x001814E8 File Offset: 0x0017F6E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.formations_.CalculateSize(GetFormationDataResponse._repeated_formations_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009ED9 RID: 40665 RVA: 0x0018153C File Offset: 0x0017F73C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetFormationDataResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.formations_.Add(other.formations_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009EDA RID: 40666 RVA: 0x00181589 File Offset: 0x0017F789
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009EDB RID: 40667 RVA: 0x00181594 File Offset: 0x0017F794
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
				if (num != 64U)
				{
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.formations_.AddEntriesFrom(ref input, GetFormationDataResponse._repeated_formations_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004A45 RID: 19013
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A46 RID: 19014
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04004A47 RID: 19015
		private ErrorCode errorCode_;

		// Token: 0x04004A48 RID: 19016
		public const int FormationsFieldNumber = 10;

		// Token: 0x04004A49 RID: 19017
		private static readonly FieldCodec<FightFormation> _repeated_formations_codec = FieldCodec.ForMessage<FightFormation>(82U, FightFormation.Parser);

		// Token: 0x04004A4A RID: 19018
		private readonly RepeatedField<FightFormation> formations_ = new RepeatedField<FightFormation>();
	}
}
