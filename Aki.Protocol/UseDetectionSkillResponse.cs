using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014B1 RID: 5297
	[NetMessage(EMessageId.UseDetectionSkillResponse)]
	public sealed class UseDetectionSkillResponse : IMessage<UseDetectionSkillResponse>, IMessage, IEquatable<UseDetectionSkillResponse>, IDeepCloneable<UseDetectionSkillResponse>, IBufferMessage
	{
		// Token: 0x0601C031 RID: 114737 RVA: 0x0040C731 File Offset: 0x0040A931
		[NullableContext(1)]
		public static UseDetectionSkillResponse Create()
		{
			return new UseDetectionSkillResponse();
		}

		// Token: 0x17005E66 RID: 24166
		// (get) Token: 0x0601C032 RID: 114738 RVA: 0x0040C738 File Offset: 0x0040A938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E67 RID: 24167
		// (get) Token: 0x0601C033 RID: 114739 RVA: 0x0040C73B File Offset: 0x0040A93B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UseDetectionSkillResponse.Descriptor;
			}
		}

		// Token: 0x0601C034 RID: 114740 RVA: 0x0040C742 File Offset: 0x0040A942
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseDetectionSkillResponse()
		{
		}

		// Token: 0x0601C035 RID: 114741 RVA: 0x0040C758 File Offset: 0x0040A958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseDetectionSkillResponse(UseDetectionSkillResponse other) : this()
		{
			this.code_ = other.code_;
			this.detectionEntityPosInfo_ = other.detectionEntityPosInfo_.Clone();
			this.detectionSlotId_ = other.detectionSlotId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C036 RID: 114742 RVA: 0x0040C7A5 File Offset: 0x0040A9A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseDetectionSkillResponse Clone()
		{
			return new UseDetectionSkillResponse(this);
		}

		// Token: 0x17005E68 RID: 24168
		// (get) Token: 0x0601C037 RID: 114743 RVA: 0x0040C7AD File Offset: 0x0040A9AD
		// (set) Token: 0x0601C038 RID: 114744 RVA: 0x0040C7B5 File Offset: 0x0040A9B5
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

		// Token: 0x17005E69 RID: 24169
		// (get) Token: 0x0601C039 RID: 114745 RVA: 0x0040C7BE File Offset: 0x0040A9BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DetectionEntityPosInfo> DetectionEntityPosInfo
		{
			get
			{
				return this.detectionEntityPosInfo_;
			}
		}

		// Token: 0x17005E6A RID: 24170
		// (get) Token: 0x0601C03A RID: 114746 RVA: 0x0040C7C6 File Offset: 0x0040A9C6
		// (set) Token: 0x0601C03B RID: 114747 RVA: 0x0040C7CE File Offset: 0x0040A9CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long DetectionSlotId
		{
			get
			{
				return this.detectionSlotId_;
			}
			set
			{
				this.detectionSlotId_ = value;
			}
		}

		// Token: 0x0601C03C RID: 114748 RVA: 0x0040C7D7 File Offset: 0x0040A9D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UseDetectionSkillResponse);
		}

		// Token: 0x0601C03D RID: 114749 RVA: 0x0040C7E8 File Offset: 0x0040A9E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UseDetectionSkillResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.detectionEntityPosInfo_.Equals(other.detectionEntityPosInfo_) && this.DetectionSlotId == other.DetectionSlotId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C03E RID: 114750 RVA: 0x0040C848 File Offset: 0x0040AA48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			num ^= this.detectionEntityPosInfo_.GetHashCode();
			if (this.DetectionSlotId != 0L)
			{
				num ^= this.DetectionSlotId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C03F RID: 114751 RVA: 0x0040C8B4 File Offset: 0x0040AAB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C040 RID: 114752 RVA: 0x0040C8C1 File Offset: 0x0040AAC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C041 RID: 114753 RVA: 0x0040C8CC File Offset: 0x0040AACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DetectionSlotId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.DetectionSlotId);
			}
			this.detectionEntityPosInfo_.WriteTo(ref output, UseDetectionSkillResponse._repeated_detectionEntityPosInfo_codec);
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C042 RID: 114754 RVA: 0x0040C938 File Offset: 0x0040AB38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			num += this.detectionEntityPosInfo_.CalculateSize(UseDetectionSkillResponse._repeated_detectionEntityPosInfo_codec);
			if (this.DetectionSlotId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.DetectionSlotId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C043 RID: 114755 RVA: 0x0040C9A4 File Offset: 0x0040ABA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UseDetectionSkillResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this.detectionEntityPosInfo_.Add(other.detectionEntityPosInfo_);
			if (other.DetectionSlotId != 0L)
			{
				this.DetectionSlotId = other.DetectionSlotId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C044 RID: 114756 RVA: 0x0040CA05 File Offset: 0x0040AC05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C045 RID: 114757 RVA: 0x0040CA10 File Offset: 0x0040AC10
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
				if (num != 32U)
				{
					if (num != 58U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Code = (ErrorCode)input.ReadEnum();
						}
					}
					else
					{
						this.detectionEntityPosInfo_.AddEntriesFrom(ref input, UseDetectionSkillResponse._repeated_detectionEntityPosInfo_codec);
					}
				}
				else
				{
					this.DetectionSlotId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400A0DF RID: 41183
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A0E0 RID: 41184
		public const int CodeFieldNumber = 11;

		// Token: 0x0400A0E1 RID: 41185
		private ErrorCode code_;

		// Token: 0x0400A0E2 RID: 41186
		public const int DetectionEntityPosInfoFieldNumber = 7;

		// Token: 0x0400A0E3 RID: 41187
		private static readonly FieldCodec<DetectionEntityPosInfo> _repeated_detectionEntityPosInfo_codec = FieldCodec.ForMessage<DetectionEntityPosInfo>(58U, Aki.Protocol.DetectionEntityPosInfo.Parser);

		// Token: 0x0400A0E4 RID: 41188
		private readonly RepeatedField<DetectionEntityPosInfo> detectionEntityPosInfo_ = new RepeatedField<DetectionEntityPosInfo>();

		// Token: 0x0400A0E5 RID: 41189
		public const int DetectionSlotIdFieldNumber = 4;

		// Token: 0x0400A0E6 RID: 41190
		private long detectionSlotId_;
	}
}
