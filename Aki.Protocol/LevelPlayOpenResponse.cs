using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008F0 RID: 2288
	[NetMessage(EMessageId.LevelPlayOpenResponse)]
	public sealed class LevelPlayOpenResponse : IMessage<LevelPlayOpenResponse>, IMessage, IEquatable<LevelPlayOpenResponse>, IDeepCloneable<LevelPlayOpenResponse>, IBufferMessage
	{
		// Token: 0x0600CA80 RID: 51840 RVA: 0x001DE4F8 File Offset: 0x001DC6F8
		[NullableContext(1)]
		public static LevelPlayOpenResponse Create()
		{
			return new LevelPlayOpenResponse();
		}

		// Token: 0x170028DE RID: 10462
		// (get) Token: 0x0600CA81 RID: 51841 RVA: 0x001DE4FF File Offset: 0x001DC6FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028DF RID: 10463
		// (get) Token: 0x0600CA82 RID: 51842 RVA: 0x001DE502 File Offset: 0x001DC702
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayOpenResponse.Descriptor;
			}
		}

		// Token: 0x0600CA83 RID: 51843 RVA: 0x001DE509 File Offset: 0x001DC709
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayOpenResponse()
		{
		}

		// Token: 0x0600CA84 RID: 51844 RVA: 0x001DE511 File Offset: 0x001DC711
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayOpenResponse(LevelPlayOpenResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.levelPlayId_ = other.levelPlayId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CA85 RID: 51845 RVA: 0x001DE542 File Offset: 0x001DC742
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayOpenResponse Clone()
		{
			return new LevelPlayOpenResponse(this);
		}

		// Token: 0x170028E0 RID: 10464
		// (get) Token: 0x0600CA86 RID: 51846 RVA: 0x001DE54A File Offset: 0x001DC74A
		// (set) Token: 0x0600CA87 RID: 51847 RVA: 0x001DE552 File Offset: 0x001DC752
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

		// Token: 0x170028E1 RID: 10465
		// (get) Token: 0x0600CA88 RID: 51848 RVA: 0x001DE55B File Offset: 0x001DC75B
		// (set) Token: 0x0600CA89 RID: 51849 RVA: 0x001DE563 File Offset: 0x001DC763
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelPlayId
		{
			get
			{
				return this.levelPlayId_;
			}
			set
			{
				this.levelPlayId_ = value;
			}
		}

		// Token: 0x0600CA8A RID: 51850 RVA: 0x001DE56C File Offset: 0x001DC76C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayOpenResponse);
		}

		// Token: 0x0600CA8B RID: 51851 RVA: 0x001DE57A File Offset: 0x001DC77A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayOpenResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.LevelPlayId == other.LevelPlayId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CA8C RID: 51852 RVA: 0x001DE5B8 File Offset: 0x001DC7B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.LevelPlayId != 0)
			{
				num ^= this.LevelPlayId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CA8D RID: 51853 RVA: 0x001DE616 File Offset: 0x001DC816
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CA8E RID: 51854 RVA: 0x001DE623 File Offset: 0x001DC823
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CA8F RID: 51855 RVA: 0x001DE62C File Offset: 0x001DC82C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelPlayId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.LevelPlayId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CA90 RID: 51856 RVA: 0x001DE688 File Offset: 0x001DC888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.LevelPlayId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelPlayId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CA91 RID: 51857 RVA: 0x001DE6E0 File Offset: 0x001DC8E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlayOpenResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.LevelPlayId != 0)
			{
				this.LevelPlayId = other.LevelPlayId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CA92 RID: 51858 RVA: 0x001DE730 File Offset: 0x001DC930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CA93 RID: 51859 RVA: 0x001DE73C File Offset: 0x001DC93C
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
				if (num != 48U)
				{
					if (num != 72U)
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
					this.LevelPlayId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400567C RID: 22140
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400567D RID: 22141
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x0400567E RID: 22142
		private ErrorCode errorCode_;

		// Token: 0x0400567F RID: 22143
		public const int LevelPlayIdFieldNumber = 6;

		// Token: 0x04005680 RID: 22144
		private int levelPlayId_;
	}
}
