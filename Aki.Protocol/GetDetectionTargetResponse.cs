using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006B2 RID: 1714
	[NetMessage(EMessageId.GetDetectionTargetResponse)]
	public sealed class GetDetectionTargetResponse : IMessage<GetDetectionTargetResponse>, IMessage, IEquatable<GetDetectionTargetResponse>, IDeepCloneable<GetDetectionTargetResponse>, IBufferMessage
	{
		// Token: 0x06009D4B RID: 40267 RVA: 0x0017E3D8 File Offset: 0x0017C5D8
		[NullableContext(1)]
		public static GetDetectionTargetResponse Create()
		{
			return new GetDetectionTargetResponse();
		}

		// Token: 0x17001F95 RID: 8085
		// (get) Token: 0x06009D4C RID: 40268 RVA: 0x0017E3DF File Offset: 0x0017C5DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F96 RID: 8086
		// (get) Token: 0x06009D4D RID: 40269 RVA: 0x0017E3E2 File Offset: 0x0017C5E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetDetectionTargetResponse.Descriptor;
			}
		}

		// Token: 0x06009D4E RID: 40270 RVA: 0x0017E3E9 File Offset: 0x0017C5E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetDetectionTargetResponse()
		{
		}

		// Token: 0x06009D4F RID: 40271 RVA: 0x0017E3FC File Offset: 0x0017C5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetDetectionTargetResponse(GetDetectionTargetResponse other) : this()
		{
			this.code_ = other.code_;
			this.detectionId_ = other.detectionId_;
			this.type_ = other.type_;
			this.detectionTargetDatas_ = other.detectionTargetDatas_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009D50 RID: 40272 RVA: 0x0017E455 File Offset: 0x0017C655
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetDetectionTargetResponse Clone()
		{
			return new GetDetectionTargetResponse(this);
		}

		// Token: 0x17001F97 RID: 8087
		// (get) Token: 0x06009D51 RID: 40273 RVA: 0x0017E45D File Offset: 0x0017C65D
		// (set) Token: 0x06009D52 RID: 40274 RVA: 0x0017E465 File Offset: 0x0017C665
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x17001F98 RID: 8088
		// (get) Token: 0x06009D53 RID: 40275 RVA: 0x0017E46E File Offset: 0x0017C66E
		// (set) Token: 0x06009D54 RID: 40276 RVA: 0x0017E476 File Offset: 0x0017C676
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DetectionId
		{
			get
			{
				return this.detectionId_;
			}
			set
			{
				this.detectionId_ = value;
			}
		}

		// Token: 0x17001F99 RID: 8089
		// (get) Token: 0x06009D55 RID: 40277 RVA: 0x0017E47F File Offset: 0x0017C67F
		// (set) Token: 0x06009D56 RID: 40278 RVA: 0x0017E487 File Offset: 0x0017C687
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17001F9A RID: 8090
		// (get) Token: 0x06009D57 RID: 40279 RVA: 0x0017E490 File Offset: 0x0017C690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DetectionTargetData> DetectionTargetDatas
		{
			get
			{
				return this.detectionTargetDatas_;
			}
		}

		// Token: 0x06009D58 RID: 40280 RVA: 0x0017E498 File Offset: 0x0017C698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetDetectionTargetResponse);
		}

		// Token: 0x06009D59 RID: 40281 RVA: 0x0017E4A8 File Offset: 0x0017C6A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetDetectionTargetResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.DetectionId == other.DetectionId && this.Type == other.Type && this.detectionTargetDatas_.Equals(other.detectionTargetDatas_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009D5A RID: 40282 RVA: 0x0017E518 File Offset: 0x0017C718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this.DetectionId != 0)
			{
				num ^= this.DetectionId.GetHashCode();
			}
			if (this.Type != DetectionType.NormalMonster)
			{
				num ^= this.Type.GetHashCode();
			}
			num ^= this.detectionTargetDatas_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009D5B RID: 40283 RVA: 0x0017E5A3 File Offset: 0x0017C7A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009D5C RID: 40284 RVA: 0x0017E5B0 File Offset: 0x0017C7B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009D5D RID: 40285 RVA: 0x0017E5BC File Offset: 0x0017C7BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != DetectionType.NormalMonster)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Type);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Code);
			}
			if (this.DetectionId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.DetectionId);
			}
			this.detectionTargetDatas_.WriteTo(ref output, GetDetectionTargetResponse._repeated_detectionTargetDatas_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009D5E RID: 40286 RVA: 0x0017E644 File Offset: 0x0017C844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this.DetectionId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DetectionId);
			}
			if (this.Type != DetectionType.NormalMonster)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			num += this.detectionTargetDatas_.CalculateSize(GetDetectionTargetResponse._repeated_detectionTargetDatas_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009D5F RID: 40287 RVA: 0x0017E6C8 File Offset: 0x0017C8C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetDetectionTargetResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.DetectionId != 0)
			{
				this.DetectionId = other.DetectionId;
			}
			if (other.Type != DetectionType.NormalMonster)
			{
				this.Type = other.Type;
			}
			this.detectionTargetDatas_.Add(other.detectionTargetDatas_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009D60 RID: 40288 RVA: 0x0017E73D File Offset: 0x0017C93D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009D61 RID: 40289 RVA: 0x0017E748 File Offset: 0x0017C948
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.Type = (DetectionType)input.ReadEnum();
						continue;
					}
					if (num == 16U)
					{
						this.Code = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.DetectionId = input.ReadInt32();
						continue;
					}
					if (num == 50U)
					{
						this.detectionTargetDatas_.AddEntriesFrom(ref input, GetDetectionTargetResponse._repeated_detectionTargetDatas_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004A33 RID: 18995
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A34 RID: 18996
		public const int CodeFieldNumber = 2;

		// Token: 0x04004A35 RID: 18997
		private ErrorCode code_;

		// Token: 0x04004A36 RID: 18998
		public const int DetectionIdFieldNumber = 4;

		// Token: 0x04004A37 RID: 18999
		private int detectionId_;

		// Token: 0x04004A38 RID: 19000
		public const int TypeFieldNumber = 1;

		// Token: 0x04004A39 RID: 19001
		private DetectionType type_;

		// Token: 0x04004A3A RID: 19002
		public const int DetectionTargetDatasFieldNumber = 6;

		// Token: 0x04004A3B RID: 19003
		private static readonly FieldCodec<DetectionTargetData> _repeated_detectionTargetDatas_codec = FieldCodec.ForMessage<DetectionTargetData>(50U, DetectionTargetData.Parser);

		// Token: 0x04004A3C RID: 19004
		private readonly RepeatedField<DetectionTargetData> detectionTargetDatas_ = new RepeatedField<DetectionTargetData>();
	}
}
