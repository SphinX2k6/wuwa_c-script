using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003ED RID: 1005
	[NetMessage(EMessageId.DollGarbStartResponse)]
	public sealed class DollGarbStartResponse : IMessage<DollGarbStartResponse>, IMessage, IEquatable<DollGarbStartResponse>, IDeepCloneable<DollGarbStartResponse>, IBufferMessage
	{
		// Token: 0x06006171 RID: 24945 RVA: 0x000EB1ED File Offset: 0x000E93ED
		[NullableContext(1)]
		public static DollGarbStartResponse Create()
		{
			return new DollGarbStartResponse();
		}

		// Token: 0x17001228 RID: 4648
		// (get) Token: 0x06006172 RID: 24946 RVA: 0x000EB1F4 File Offset: 0x000E93F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001229 RID: 4649
		// (get) Token: 0x06006173 RID: 24947 RVA: 0x000EB1F7 File Offset: 0x000E93F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DollGarbStartResponse.Descriptor;
			}
		}

		// Token: 0x06006174 RID: 24948 RVA: 0x000EB1FE File Offset: 0x000E93FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGarbStartResponse()
		{
		}

		// Token: 0x06006175 RID: 24949 RVA: 0x000EB206 File Offset: 0x000E9406
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGarbStartResponse(DollGarbStartResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006176 RID: 24950 RVA: 0x000EB22B File Offset: 0x000E942B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGarbStartResponse Clone()
		{
			return new DollGarbStartResponse(this);
		}

		// Token: 0x1700122A RID: 4650
		// (get) Token: 0x06006177 RID: 24951 RVA: 0x000EB233 File Offset: 0x000E9433
		// (set) Token: 0x06006178 RID: 24952 RVA: 0x000EB23B File Offset: 0x000E943B
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

		// Token: 0x06006179 RID: 24953 RVA: 0x000EB244 File Offset: 0x000E9444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DollGarbStartResponse);
		}

		// Token: 0x0600617A RID: 24954 RVA: 0x000EB252 File Offset: 0x000E9452
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DollGarbStartResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600617B RID: 24955 RVA: 0x000EB280 File Offset: 0x000E9480
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

		// Token: 0x0600617C RID: 24956 RVA: 0x000EB2C5 File Offset: 0x000E94C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600617D RID: 24957 RVA: 0x000EB2D2 File Offset: 0x000E94D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600617E RID: 24958 RVA: 0x000EB2DB File Offset: 0x000E94DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600617F RID: 24959 RVA: 0x000EB310 File Offset: 0x000E9510
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

		// Token: 0x06006180 RID: 24960 RVA: 0x000EB34E File Offset: 0x000E954E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DollGarbStartResponse other)
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

		// Token: 0x06006181 RID: 24961 RVA: 0x000EB37F File Offset: 0x000E957F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006182 RID: 24962 RVA: 0x000EB388 File Offset: 0x000E9588
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400379D RID: 14237
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400379E RID: 14238
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x0400379F RID: 14239
		private ErrorCode errorCode_;
	}
}
