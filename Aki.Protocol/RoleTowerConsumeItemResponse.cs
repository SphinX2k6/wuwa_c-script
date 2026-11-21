using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010C4 RID: 4292
	[NetMessage(EMessageId.RoleTowerConsumeItemResponse)]
	public sealed class RoleTowerConsumeItemResponse : IMessage<RoleTowerConsumeItemResponse>, IMessage, IEquatable<RoleTowerConsumeItemResponse>, IDeepCloneable<RoleTowerConsumeItemResponse>, IBufferMessage
	{
		// Token: 0x06016F0D RID: 93965 RVA: 0x003560C4 File Offset: 0x003542C4
		[NullableContext(1)]
		public static RoleTowerConsumeItemResponse Create()
		{
			return new RoleTowerConsumeItemResponse();
		}

		// Token: 0x17004CF0 RID: 19696
		// (get) Token: 0x06016F0E RID: 93966 RVA: 0x003560CB File Offset: 0x003542CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004CF1 RID: 19697
		// (get) Token: 0x06016F0F RID: 93967 RVA: 0x003560CE File Offset: 0x003542CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerConsumeItemResponse.Descriptor;
			}
		}

		// Token: 0x06016F10 RID: 93968 RVA: 0x003560D5 File Offset: 0x003542D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerConsumeItemResponse()
		{
		}

		// Token: 0x06016F11 RID: 93969 RVA: 0x003560DD File Offset: 0x003542DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerConsumeItemResponse(RoleTowerConsumeItemResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016F12 RID: 93970 RVA: 0x00356102 File Offset: 0x00354302
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerConsumeItemResponse Clone()
		{
			return new RoleTowerConsumeItemResponse(this);
		}

		// Token: 0x17004CF2 RID: 19698
		// (get) Token: 0x06016F13 RID: 93971 RVA: 0x0035610A File Offset: 0x0035430A
		// (set) Token: 0x06016F14 RID: 93972 RVA: 0x00356112 File Offset: 0x00354312
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

		// Token: 0x06016F15 RID: 93973 RVA: 0x0035611B File Offset: 0x0035431B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerConsumeItemResponse);
		}

		// Token: 0x06016F16 RID: 93974 RVA: 0x00356129 File Offset: 0x00354329
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerConsumeItemResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016F17 RID: 93975 RVA: 0x00356158 File Offset: 0x00354358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016F18 RID: 93976 RVA: 0x0035619D File Offset: 0x0035439D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016F19 RID: 93977 RVA: 0x003561AA File Offset: 0x003543AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016F1A RID: 93978 RVA: 0x003561B3 File Offset: 0x003543B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016F1B RID: 93979 RVA: 0x003561E4 File Offset: 0x003543E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016F1C RID: 93980 RVA: 0x00356222 File Offset: 0x00354422
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerConsumeItemResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016F1D RID: 93981 RVA: 0x00356253 File Offset: 0x00354453
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016F1E RID: 93982 RVA: 0x0035625C File Offset: 0x0035445C
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008950 RID: 35152
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008951 RID: 35153
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04008952 RID: 35154
		private ErrorCode errorCode_;
	}
}
