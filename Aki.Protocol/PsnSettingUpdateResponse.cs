using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DE0 RID: 3552
	[NetMessage(EMessageId.PsnSettingUpdateResponse)]
	public sealed class PsnSettingUpdateResponse : IMessage<PsnSettingUpdateResponse>, IMessage, IEquatable<PsnSettingUpdateResponse>, IDeepCloneable<PsnSettingUpdateResponse>, IBufferMessage
	{
		// Token: 0x06013226 RID: 78374 RVA: 0x002C9EFD File Offset: 0x002C80FD
		[NullableContext(1)]
		public static PsnSettingUpdateResponse Create()
		{
			return new PsnSettingUpdateResponse();
		}

		// Token: 0x17003F7E RID: 16254
		// (get) Token: 0x06013227 RID: 78375 RVA: 0x002C9F04 File Offset: 0x002C8104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F7F RID: 16255
		// (get) Token: 0x06013228 RID: 78376 RVA: 0x002C9F07 File Offset: 0x002C8107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PsnSettingUpdateResponse.Descriptor;
			}
		}

		// Token: 0x06013229 RID: 78377 RVA: 0x002C9F0E File Offset: 0x002C810E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PsnSettingUpdateResponse()
		{
		}

		// Token: 0x0601322A RID: 78378 RVA: 0x002C9F16 File Offset: 0x002C8116
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PsnSettingUpdateResponse(PsnSettingUpdateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601322B RID: 78379 RVA: 0x002C9F3B File Offset: 0x002C813B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PsnSettingUpdateResponse Clone()
		{
			return new PsnSettingUpdateResponse(this);
		}

		// Token: 0x17003F80 RID: 16256
		// (get) Token: 0x0601322C RID: 78380 RVA: 0x002C9F43 File Offset: 0x002C8143
		// (set) Token: 0x0601322D RID: 78381 RVA: 0x002C9F4B File Offset: 0x002C814B
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

		// Token: 0x0601322E RID: 78382 RVA: 0x002C9F54 File Offset: 0x002C8154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PsnSettingUpdateResponse);
		}

		// Token: 0x0601322F RID: 78383 RVA: 0x002C9F62 File Offset: 0x002C8162
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PsnSettingUpdateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013230 RID: 78384 RVA: 0x002C9F90 File Offset: 0x002C8190
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

		// Token: 0x06013231 RID: 78385 RVA: 0x002C9FD5 File Offset: 0x002C81D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013232 RID: 78386 RVA: 0x002C9FE2 File Offset: 0x002C81E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013233 RID: 78387 RVA: 0x002C9FEB File Offset: 0x002C81EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013234 RID: 78388 RVA: 0x002CA020 File Offset: 0x002C8220
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

		// Token: 0x06013235 RID: 78389 RVA: 0x002CA05E File Offset: 0x002C825E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PsnSettingUpdateResponse other)
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

		// Token: 0x06013236 RID: 78390 RVA: 0x002CA08F File Offset: 0x002C828F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013237 RID: 78391 RVA: 0x002CA098 File Offset: 0x002C8298
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400764B RID: 30283
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400764C RID: 30284
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x0400764D RID: 30285
		private ErrorCode errorCode_;
	}
}
