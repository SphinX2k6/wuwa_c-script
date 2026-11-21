using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001527 RID: 5415
	[NetMessage(EMessageId.UseDetectionSkillResponse)]
	public sealed class UseDetectionSkillResponse : IMessage<UseDetectionSkillResponse>, IMessage, IEquatable<UseDetectionSkillResponse>, IDeepCloneable<UseDetectionSkillResponse>, IBufferMessage
	{
		// Token: 0x0601CAF8 RID: 117496 RVA: 0x004281E9 File Offset: 0x004263E9
		[NullableContext(1)]
		public static UseDetectionSkillResponse Create()
		{
			return new UseDetectionSkillResponse();
		}

		// Token: 0x17006107 RID: 24839
		// (get) Token: 0x0601CAF9 RID: 117497 RVA: 0x004281F0 File Offset: 0x004263F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006108 RID: 24840
		// (get) Token: 0x0601CAFA RID: 117498 RVA: 0x004281F3 File Offset: 0x004263F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UseDetectionSkillResponse.Descriptor;
			}
		}

		// Token: 0x0601CAFB RID: 117499 RVA: 0x004281FA File Offset: 0x004263FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseDetectionSkillResponse()
		{
		}

		// Token: 0x0601CAFC RID: 117500 RVA: 0x00428210 File Offset: 0x00426410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseDetectionSkillResponse(UseDetectionSkillResponse other) : this()
		{
			this.code_ = other.code_;
			this.detectionEntityPosInfo_ = other.detectionEntityPosInfo_.Clone();
			this.detectionSlotId_ = other.detectionSlotId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CAFD RID: 117501 RVA: 0x0042825D File Offset: 0x0042645D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseDetectionSkillResponse Clone()
		{
			return new UseDetectionSkillResponse(this);
		}

		// Token: 0x17006109 RID: 24841
		// (get) Token: 0x0601CAFE RID: 117502 RVA: 0x00428265 File Offset: 0x00426465
		// (set) Token: 0x0601CAFF RID: 117503 RVA: 0x0042826D File Offset: 0x0042646D
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

		// Token: 0x1700610A RID: 24842
		// (get) Token: 0x0601CB00 RID: 117504 RVA: 0x00428276 File Offset: 0x00426476
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DetectionEntityPosInfo> DetectionEntityPosInfo
		{
			get
			{
				return this.detectionEntityPosInfo_;
			}
		}

		// Token: 0x1700610B RID: 24843
		// (get) Token: 0x0601CB01 RID: 117505 RVA: 0x0042827E File Offset: 0x0042647E
		// (set) Token: 0x0601CB02 RID: 117506 RVA: 0x00428286 File Offset: 0x00426486
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

		// Token: 0x0601CB03 RID: 117507 RVA: 0x0042828F File Offset: 0x0042648F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UseDetectionSkillResponse);
		}

		// Token: 0x0601CB04 RID: 117508 RVA: 0x004282A0 File Offset: 0x004264A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UseDetectionSkillResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.detectionEntityPosInfo_.Equals(other.detectionEntityPosInfo_) && this.DetectionSlotId == other.DetectionSlotId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CB05 RID: 117509 RVA: 0x00428300 File Offset: 0x00426500
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

		// Token: 0x0601CB06 RID: 117510 RVA: 0x0042836C File Offset: 0x0042656C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CB07 RID: 117511 RVA: 0x00428379 File Offset: 0x00426579
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CB08 RID: 117512 RVA: 0x00428384 File Offset: 0x00426584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Code);
			}
			if (this.DetectionSlotId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.DetectionSlotId);
			}
			this.detectionEntityPosInfo_.WriteTo(ref output, UseDetectionSkillResponse._repeated_detectionEntityPosInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CB09 RID: 117513 RVA: 0x004283F0 File Offset: 0x004265F0
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

		// Token: 0x0601CB0A RID: 117514 RVA: 0x0042845C File Offset: 0x0042665C
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

		// Token: 0x0601CB0B RID: 117515 RVA: 0x004284BD File Offset: 0x004266BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CB0C RID: 117516 RVA: 0x004284C8 File Offset: 0x004266C8
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
				if (num != 16U)
				{
					if (num != 24U)
					{
						if (num != 90U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A538 RID: 42296
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A539 RID: 42297
		public const int CodeFieldNumber = 2;

		// Token: 0x0400A53A RID: 42298
		private ErrorCode code_;

		// Token: 0x0400A53B RID: 42299
		public const int DetectionEntityPosInfoFieldNumber = 11;

		// Token: 0x0400A53C RID: 42300
		private static readonly FieldCodec<DetectionEntityPosInfo> _repeated_detectionEntityPosInfo_codec = FieldCodec.ForMessage<DetectionEntityPosInfo>(90U, Aki.Protocol.DetectionEntityPosInfo.Parser);

		// Token: 0x0400A53D RID: 42301
		private readonly RepeatedField<DetectionEntityPosInfo> detectionEntityPosInfo_ = new RepeatedField<DetectionEntityPosInfo>();

		// Token: 0x0400A53E RID: 42302
		public const int DetectionSlotIdFieldNumber = 3;

		// Token: 0x0400A53F RID: 42303
		private long detectionSlotId_;
	}
}
