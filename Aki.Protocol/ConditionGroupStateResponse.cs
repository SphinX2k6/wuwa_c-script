using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002D2 RID: 722
	[NetMessage(EMessageId.ConditionGroupStateResponse)]
	public sealed class ConditionGroupStateResponse : IMessage<ConditionGroupStateResponse>, IMessage, IEquatable<ConditionGroupStateResponse>, IDeepCloneable<ConditionGroupStateResponse>, IBufferMessage
	{
		// Token: 0x06004A3B RID: 19003 RVA: 0x000B5DDC File Offset: 0x000B3FDC
		[NullableContext(1)]
		public static ConditionGroupStateResponse Create()
		{
			return new ConditionGroupStateResponse();
		}

		// Token: 0x17000D04 RID: 3332
		// (get) Token: 0x06004A3C RID: 19004 RVA: 0x000B5DE3 File Offset: 0x000B3FE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D05 RID: 3333
		// (get) Token: 0x06004A3D RID: 19005 RVA: 0x000B5DE6 File Offset: 0x000B3FE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConditionGroupStateResponse.Descriptor;
			}
		}

		// Token: 0x06004A3E RID: 19006 RVA: 0x000B5DED File Offset: 0x000B3FED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionGroupStateResponse()
		{
		}

		// Token: 0x06004A3F RID: 19007 RVA: 0x000B5E00 File Offset: 0x000B4000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionGroupStateResponse(ConditionGroupStateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.conditionGroupFinishInfos_ = other.conditionGroupFinishInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004A40 RID: 19008 RVA: 0x000B5E36 File Offset: 0x000B4036
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionGroupStateResponse Clone()
		{
			return new ConditionGroupStateResponse(this);
		}

		// Token: 0x17000D06 RID: 3334
		// (get) Token: 0x06004A41 RID: 19009 RVA: 0x000B5E3E File Offset: 0x000B403E
		// (set) Token: 0x06004A42 RID: 19010 RVA: 0x000B5E46 File Offset: 0x000B4046
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

		// Token: 0x17000D07 RID: 3335
		// (get) Token: 0x06004A43 RID: 19011 RVA: 0x000B5E4F File Offset: 0x000B404F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionGroupFinishInfo> ConditionGroupFinishInfos
		{
			get
			{
				return this.conditionGroupFinishInfos_;
			}
		}

		// Token: 0x06004A44 RID: 19012 RVA: 0x000B5E57 File Offset: 0x000B4057
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConditionGroupStateResponse);
		}

		// Token: 0x06004A45 RID: 19013 RVA: 0x000B5E68 File Offset: 0x000B4068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConditionGroupStateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.conditionGroupFinishInfos_.Equals(other.conditionGroupFinishInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004A46 RID: 19014 RVA: 0x000B5EB8 File Offset: 0x000B40B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.conditionGroupFinishInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004A47 RID: 19015 RVA: 0x000B5F0B File Offset: 0x000B410B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004A48 RID: 19016 RVA: 0x000B5F18 File Offset: 0x000B4118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004A49 RID: 19017 RVA: 0x000B5F24 File Offset: 0x000B4124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.conditionGroupFinishInfos_.WriteTo(ref output, ConditionGroupStateResponse._repeated_conditionGroupFinishInfos_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004A4A RID: 19018 RVA: 0x000B5F74 File Offset: 0x000B4174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.conditionGroupFinishInfos_.CalculateSize(ConditionGroupStateResponse._repeated_conditionGroupFinishInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004A4B RID: 19019 RVA: 0x000B5FC8 File Offset: 0x000B41C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConditionGroupStateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.conditionGroupFinishInfos_.Add(other.conditionGroupFinishInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004A4C RID: 19020 RVA: 0x000B6015 File Offset: 0x000B4215
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004A4D RID: 19021 RVA: 0x000B6020 File Offset: 0x000B4220
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
				if (num != 42U)
				{
					if (num != 64U)
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
					this.conditionGroupFinishInfos_.AddEntriesFrom(ref input, ConditionGroupStateResponse._repeated_conditionGroupFinishInfos_codec);
				}
			}
		}

		// Token: 0x040030C1 RID: 12481
		private UnknownFieldSet _unknownFields;

		// Token: 0x040030C2 RID: 12482
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x040030C3 RID: 12483
		private ErrorCode errorCode_;

		// Token: 0x040030C4 RID: 12484
		public const int ConditionGroupFinishInfosFieldNumber = 5;

		// Token: 0x040030C5 RID: 12485
		private static readonly FieldCodec<ConditionGroupFinishInfo> _repeated_conditionGroupFinishInfos_codec = FieldCodec.ForMessage<ConditionGroupFinishInfo>(42U, ConditionGroupFinishInfo.Parser);

		// Token: 0x040030C6 RID: 12486
		private readonly RepeatedField<ConditionGroupFinishInfo> conditionGroupFinishInfos_ = new RepeatedField<ConditionGroupFinishInfo>();
	}
}
