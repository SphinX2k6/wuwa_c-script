using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001533 RID: 5427
	[NetMessage(EMessageId.UseSoundBoxSkillResponse)]
	public sealed class UseSoundBoxSkillResponse : IMessage<UseSoundBoxSkillResponse>, IMessage, IEquatable<UseSoundBoxSkillResponse>, IDeepCloneable<UseSoundBoxSkillResponse>, IBufferMessage
	{
		// Token: 0x0601CBFE RID: 117758 RVA: 0x0042ABA2 File Offset: 0x00428DA2
		[NullableContext(1)]
		public static UseSoundBoxSkillResponse Create()
		{
			return new UseSoundBoxSkillResponse();
		}

		// Token: 0x17006143 RID: 24899
		// (get) Token: 0x0601CBFF RID: 117759 RVA: 0x0042ABA9 File Offset: 0x00428DA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006144 RID: 24900
		// (get) Token: 0x0601CC00 RID: 117760 RVA: 0x0042ABAC File Offset: 0x00428DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UseSoundBoxSkillResponse.Descriptor;
			}
		}

		// Token: 0x0601CC01 RID: 117761 RVA: 0x0042ABB3 File Offset: 0x00428DB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSoundBoxSkillResponse()
		{
		}

		// Token: 0x0601CC02 RID: 117762 RVA: 0x0042ABBC File Offset: 0x00428DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSoundBoxSkillResponse(UseSoundBoxSkillResponse other) : this()
		{
			this.code_ = other.code_;
			this.detectionEntityPosInfo_ = ((other.detectionEntityPosInfo_ != null) ? other.detectionEntityPosInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CC03 RID: 117763 RVA: 0x0042AC08 File Offset: 0x00428E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSoundBoxSkillResponse Clone()
		{
			return new UseSoundBoxSkillResponse(this);
		}

		// Token: 0x17006145 RID: 24901
		// (get) Token: 0x0601CC04 RID: 117764 RVA: 0x0042AC10 File Offset: 0x00428E10
		// (set) Token: 0x0601CC05 RID: 117765 RVA: 0x0042AC18 File Offset: 0x00428E18
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

		// Token: 0x17006146 RID: 24902
		// (get) Token: 0x0601CC06 RID: 117766 RVA: 0x0042AC21 File Offset: 0x00428E21
		// (set) Token: 0x0601CC07 RID: 117767 RVA: 0x0042AC29 File Offset: 0x00428E29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionEntityPosInfo DetectionEntityPosInfo
		{
			get
			{
				return this.detectionEntityPosInfo_;
			}
			set
			{
				this.detectionEntityPosInfo_ = value;
			}
		}

		// Token: 0x0601CC08 RID: 117768 RVA: 0x0042AC32 File Offset: 0x00428E32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UseSoundBoxSkillResponse);
		}

		// Token: 0x0601CC09 RID: 117769 RVA: 0x0042AC40 File Offset: 0x00428E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UseSoundBoxSkillResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this.DetectionEntityPosInfo, other.DetectionEntityPosInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CC0A RID: 117770 RVA: 0x0042AC90 File Offset: 0x00428E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this.detectionEntityPosInfo_ != null)
			{
				num ^= this.DetectionEntityPosInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CC0B RID: 117771 RVA: 0x0042ACEB File Offset: 0x00428EEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CC0C RID: 117772 RVA: 0x0042ACF8 File Offset: 0x00428EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CC0D RID: 117773 RVA: 0x0042AD04 File Offset: 0x00428F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Code);
			}
			if (this.detectionEntityPosInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.DetectionEntityPosInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CC0E RID: 117774 RVA: 0x0042AD60 File Offset: 0x00428F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this.detectionEntityPosInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DetectionEntityPosInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CC0F RID: 117775 RVA: 0x0042ADB8 File Offset: 0x00428FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UseSoundBoxSkillResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.detectionEntityPosInfo_ != null)
			{
				if (this.detectionEntityPosInfo_ == null)
				{
					this.DetectionEntityPosInfo = new DetectionEntityPosInfo();
				}
				this.DetectionEntityPosInfo.MergeFrom(other.DetectionEntityPosInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CC10 RID: 117776 RVA: 0x0042AE20 File Offset: 0x00429020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CC11 RID: 117777 RVA: 0x0042AE2C File Offset: 0x0042902C
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
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.detectionEntityPosInfo_ == null)
						{
							this.DetectionEntityPosInfo = new DetectionEntityPosInfo();
						}
						input.ReadMessage(this.DetectionEntityPosInfo);
					}
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A591 RID: 42385
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A592 RID: 42386
		public const int CodeFieldNumber = 2;

		// Token: 0x0400A593 RID: 42387
		private ErrorCode code_;

		// Token: 0x0400A594 RID: 42388
		public const int DetectionEntityPosInfoFieldNumber = 14;

		// Token: 0x0400A595 RID: 42389
		private DetectionEntityPosInfo detectionEntityPosInfo_;
	}
}
