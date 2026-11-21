using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006B4 RID: 1716
	[NetMessage(EMessageId.GetFormationDataResponse)]
	public sealed class GetFormationDataResponse : IMessage<GetFormationDataResponse>, IMessage, IEquatable<GetFormationDataResponse>, IDeepCloneable<GetFormationDataResponse>, IBufferMessage
	{
		// Token: 0x06009D73 RID: 40307 RVA: 0x0017E91E File Offset: 0x0017CB1E
		[NullableContext(1)]
		public static GetFormationDataResponse Create()
		{
			return new GetFormationDataResponse();
		}

		// Token: 0x17001F9D RID: 8093
		// (get) Token: 0x06009D74 RID: 40308 RVA: 0x0017E925 File Offset: 0x0017CB25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F9E RID: 8094
		// (get) Token: 0x06009D75 RID: 40309 RVA: 0x0017E928 File Offset: 0x0017CB28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetFormationDataResponse.Descriptor;
			}
		}

		// Token: 0x06009D76 RID: 40310 RVA: 0x0017E92F File Offset: 0x0017CB2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFormationDataResponse()
		{
		}

		// Token: 0x06009D77 RID: 40311 RVA: 0x0017E942 File Offset: 0x0017CB42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFormationDataResponse(GetFormationDataResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.formations_ = other.formations_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009D78 RID: 40312 RVA: 0x0017E978 File Offset: 0x0017CB78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFormationDataResponse Clone()
		{
			return new GetFormationDataResponse(this);
		}

		// Token: 0x17001F9F RID: 8095
		// (get) Token: 0x06009D79 RID: 40313 RVA: 0x0017E980 File Offset: 0x0017CB80
		// (set) Token: 0x06009D7A RID: 40314 RVA: 0x0017E988 File Offset: 0x0017CB88
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

		// Token: 0x17001FA0 RID: 8096
		// (get) Token: 0x06009D7B RID: 40315 RVA: 0x0017E991 File Offset: 0x0017CB91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FightFormation> Formations
		{
			get
			{
				return this.formations_;
			}
		}

		// Token: 0x06009D7C RID: 40316 RVA: 0x0017E999 File Offset: 0x0017CB99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetFormationDataResponse);
		}

		// Token: 0x06009D7D RID: 40317 RVA: 0x0017E9A8 File Offset: 0x0017CBA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetFormationDataResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.formations_.Equals(other.formations_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009D7E RID: 40318 RVA: 0x0017E9F8 File Offset: 0x0017CBF8
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

		// Token: 0x06009D7F RID: 40319 RVA: 0x0017EA4B File Offset: 0x0017CC4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009D80 RID: 40320 RVA: 0x0017EA58 File Offset: 0x0017CC58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009D81 RID: 40321 RVA: 0x0017EA64 File Offset: 0x0017CC64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.formations_.WriteTo(ref output, GetFormationDataResponse._repeated_formations_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009D82 RID: 40322 RVA: 0x0017EAB4 File Offset: 0x0017CCB4
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

		// Token: 0x06009D83 RID: 40323 RVA: 0x0017EB08 File Offset: 0x0017CD08
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

		// Token: 0x06009D84 RID: 40324 RVA: 0x0017EB55 File Offset: 0x0017CD55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009D85 RID: 40325 RVA: 0x0017EB60 File Offset: 0x0017CD60
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
				if (num != 24U)
				{
					if (num != 66U)
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

		// Token: 0x04004A3E RID: 19006
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A3F RID: 19007
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04004A40 RID: 19008
		private ErrorCode errorCode_;

		// Token: 0x04004A41 RID: 19009
		public const int FormationsFieldNumber = 8;

		// Token: 0x04004A42 RID: 19010
		private static readonly FieldCodec<FightFormation> _repeated_formations_codec = FieldCodec.ForMessage<FightFormation>(66U, FightFormation.Parser);

		// Token: 0x04004A43 RID: 19011
		private readonly RepeatedField<FightFormation> formations_ = new RepeatedField<FightFormation>();
	}
}
