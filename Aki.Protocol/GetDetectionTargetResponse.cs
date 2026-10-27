using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006C6 RID: 1734
	[NetMessage(EMessageId.GetDetectionTargetResponse)]
	public sealed class GetDetectionTargetResponse : IMessage<GetDetectionTargetResponse>, IMessage, IEquatable<GetDetectionTargetResponse>, IDeepCloneable<GetDetectionTargetResponse>, IBufferMessage
	{
		// Token: 0x06009EA1 RID: 40609 RVA: 0x00180E0C File Offset: 0x0017F00C
		[NullableContext(1)]
		public static GetDetectionTargetResponse Create()
		{
			return new GetDetectionTargetResponse();
		}

		// Token: 0x17001FDF RID: 8159
		// (get) Token: 0x06009EA2 RID: 40610 RVA: 0x00180E13 File Offset: 0x0017F013
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FE0 RID: 8160
		// (get) Token: 0x06009EA3 RID: 40611 RVA: 0x00180E16 File Offset: 0x0017F016
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetDetectionTargetResponse.Descriptor;
			}
		}

		// Token: 0x06009EA4 RID: 40612 RVA: 0x00180E1D File Offset: 0x0017F01D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetDetectionTargetResponse()
		{
		}

		// Token: 0x06009EA5 RID: 40613 RVA: 0x00180E30 File Offset: 0x0017F030
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

		// Token: 0x06009EA6 RID: 40614 RVA: 0x00180E89 File Offset: 0x0017F089
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetDetectionTargetResponse Clone()
		{
			return new GetDetectionTargetResponse(this);
		}

		// Token: 0x17001FE1 RID: 8161
		// (get) Token: 0x06009EA7 RID: 40615 RVA: 0x00180E91 File Offset: 0x0017F091
		// (set) Token: 0x06009EA8 RID: 40616 RVA: 0x00180E99 File Offset: 0x0017F099
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

		// Token: 0x17001FE2 RID: 8162
		// (get) Token: 0x06009EA9 RID: 40617 RVA: 0x00180EA2 File Offset: 0x0017F0A2
		// (set) Token: 0x06009EAA RID: 40618 RVA: 0x00180EAA File Offset: 0x0017F0AA
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

		// Token: 0x17001FE3 RID: 8163
		// (get) Token: 0x06009EAB RID: 40619 RVA: 0x00180EB3 File Offset: 0x0017F0B3
		// (set) Token: 0x06009EAC RID: 40620 RVA: 0x00180EBB File Offset: 0x0017F0BB
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

		// Token: 0x17001FE4 RID: 8164
		// (get) Token: 0x06009EAD RID: 40621 RVA: 0x00180EC4 File Offset: 0x0017F0C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DetectionTargetData> DetectionTargetDatas
		{
			get
			{
				return this.detectionTargetDatas_;
			}
		}

		// Token: 0x06009EAE RID: 40622 RVA: 0x00180ECC File Offset: 0x0017F0CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetDetectionTargetResponse);
		}

		// Token: 0x06009EAF RID: 40623 RVA: 0x00180EDC File Offset: 0x0017F0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetDetectionTargetResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.DetectionId == other.DetectionId && this.Type == other.Type && this.detectionTargetDatas_.Equals(other.detectionTargetDatas_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009EB0 RID: 40624 RVA: 0x00180F4C File Offset: 0x0017F14C
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

		// Token: 0x06009EB1 RID: 40625 RVA: 0x00180FD7 File Offset: 0x0017F1D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009EB2 RID: 40626 RVA: 0x00180FE4 File Offset: 0x0017F1E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009EB3 RID: 40627 RVA: 0x00180FF0 File Offset: 0x0017F1F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != DetectionType.NormalMonster)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.Type);
			}
			this.detectionTargetDatas_.WriteTo(ref output, GetDetectionTargetResponse._repeated_detectionTargetDatas_codec);
			if (this.DetectionId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.DetectionId);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009EB4 RID: 40628 RVA: 0x00181078 File Offset: 0x0017F278
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

		// Token: 0x06009EB5 RID: 40629 RVA: 0x001810FC File Offset: 0x0017F2FC
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

		// Token: 0x06009EB6 RID: 40630 RVA: 0x00181171 File Offset: 0x0017F371
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009EB7 RID: 40631 RVA: 0x0018117C File Offset: 0x0017F37C
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
				if (num <= 90U)
				{
					if (num == 40U)
					{
						this.Type = (DetectionType)input.ReadEnum();
						continue;
					}
					if (num == 90U)
					{
						this.detectionTargetDatas_.AddEntriesFrom(ref input, GetDetectionTargetResponse._repeated_detectionTargetDatas_codec);
						continue;
					}
				}
				else
				{
					if (num == 112U)
					{
						this.DetectionId = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.Code = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004A3A RID: 19002
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A3B RID: 19003
		public const int CodeFieldNumber = 15;

		// Token: 0x04004A3C RID: 19004
		private ErrorCode code_;

		// Token: 0x04004A3D RID: 19005
		public const int DetectionIdFieldNumber = 14;

		// Token: 0x04004A3E RID: 19006
		private int detectionId_;

		// Token: 0x04004A3F RID: 19007
		public const int TypeFieldNumber = 5;

		// Token: 0x04004A40 RID: 19008
		private DetectionType type_;

		// Token: 0x04004A41 RID: 19009
		public const int DetectionTargetDatasFieldNumber = 11;

		// Token: 0x04004A42 RID: 19010
		private static readonly FieldCodec<DetectionTargetData> _repeated_detectionTargetDatas_codec = FieldCodec.ForMessage<DetectionTargetData>(90U, DetectionTargetData.Parser);

		// Token: 0x04004A43 RID: 19011
		private readonly RepeatedField<DetectionTargetData> detectionTargetDatas_ = new RepeatedField<DetectionTargetData>();
	}
}
