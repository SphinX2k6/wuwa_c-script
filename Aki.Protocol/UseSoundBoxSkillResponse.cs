using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014BD RID: 5309
	[NetMessage(EMessageId.UseSoundBoxSkillResponse)]
	public sealed class UseSoundBoxSkillResponse : IMessage<UseSoundBoxSkillResponse>, IMessage, IEquatable<UseSoundBoxSkillResponse>, IDeepCloneable<UseSoundBoxSkillResponse>, IBufferMessage
	{
		// Token: 0x0601C137 RID: 114999 RVA: 0x0040F0EA File Offset: 0x0040D2EA
		[NullableContext(1)]
		public static UseSoundBoxSkillResponse Create()
		{
			return new UseSoundBoxSkillResponse();
		}

		// Token: 0x17005EA2 RID: 24226
		// (get) Token: 0x0601C138 RID: 115000 RVA: 0x0040F0F1 File Offset: 0x0040D2F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005EA3 RID: 24227
		// (get) Token: 0x0601C139 RID: 115001 RVA: 0x0040F0F4 File Offset: 0x0040D2F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UseSoundBoxSkillResponse.Descriptor;
			}
		}

		// Token: 0x0601C13A RID: 115002 RVA: 0x0040F0FB File Offset: 0x0040D2FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSoundBoxSkillResponse()
		{
		}

		// Token: 0x0601C13B RID: 115003 RVA: 0x0040F104 File Offset: 0x0040D304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSoundBoxSkillResponse(UseSoundBoxSkillResponse other) : this()
		{
			this.code_ = other.code_;
			this.detectionEntityPosInfo_ = ((other.detectionEntityPosInfo_ != null) ? other.detectionEntityPosInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C13C RID: 115004 RVA: 0x0040F150 File Offset: 0x0040D350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSoundBoxSkillResponse Clone()
		{
			return new UseSoundBoxSkillResponse(this);
		}

		// Token: 0x17005EA4 RID: 24228
		// (get) Token: 0x0601C13D RID: 115005 RVA: 0x0040F158 File Offset: 0x0040D358
		// (set) Token: 0x0601C13E RID: 115006 RVA: 0x0040F160 File Offset: 0x0040D360
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

		// Token: 0x17005EA5 RID: 24229
		// (get) Token: 0x0601C13F RID: 115007 RVA: 0x0040F169 File Offset: 0x0040D369
		// (set) Token: 0x0601C140 RID: 115008 RVA: 0x0040F171 File Offset: 0x0040D371
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

		// Token: 0x0601C141 RID: 115009 RVA: 0x0040F17A File Offset: 0x0040D37A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UseSoundBoxSkillResponse);
		}

		// Token: 0x0601C142 RID: 115010 RVA: 0x0040F188 File Offset: 0x0040D388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UseSoundBoxSkillResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this.DetectionEntityPosInfo, other.DetectionEntityPosInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C143 RID: 115011 RVA: 0x0040F1D8 File Offset: 0x0040D3D8
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

		// Token: 0x0601C144 RID: 115012 RVA: 0x0040F233 File Offset: 0x0040D433
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C145 RID: 115013 RVA: 0x0040F240 File Offset: 0x0040D440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C146 RID: 115014 RVA: 0x0040F24C File Offset: 0x0040D44C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.detectionEntityPosInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.DetectionEntityPosInfo);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C147 RID: 115015 RVA: 0x0040F2A8 File Offset: 0x0040D4A8
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

		// Token: 0x0601C148 RID: 115016 RVA: 0x0040F300 File Offset: 0x0040D500
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

		// Token: 0x0601C149 RID: 115017 RVA: 0x0040F368 File Offset: 0x0040D568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C14A RID: 115018 RVA: 0x0040F374 File Offset: 0x0040D574
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
					if (num != 80U)
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
					if (this.detectionEntityPosInfo_ == null)
					{
						this.DetectionEntityPosInfo = new DetectionEntityPosInfo();
					}
					input.ReadMessage(this.DetectionEntityPosInfo);
				}
			}
		}

		// Token: 0x0400A138 RID: 41272
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A139 RID: 41273
		public const int CodeFieldNumber = 10;

		// Token: 0x0400A13A RID: 41274
		private ErrorCode code_;

		// Token: 0x0400A13B RID: 41275
		public const int DetectionEntityPosInfoFieldNumber = 4;

		// Token: 0x0400A13C RID: 41276
		private DetectionEntityPosInfo detectionEntityPosInfo_;
	}
}
