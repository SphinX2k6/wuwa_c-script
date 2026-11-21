using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200150A RID: 5386
	[NetMessage(EMessageId.UpdateFightRoleResponse)]
	public sealed class UpdateFightRoleResponse : IMessage<UpdateFightRoleResponse>, IMessage, IEquatable<UpdateFightRoleResponse>, IDeepCloneable<UpdateFightRoleResponse>, IBufferMessage
	{
		// Token: 0x0601C8AE RID: 116910 RVA: 0x004231E0 File Offset: 0x004213E0
		[NullableContext(1)]
		public static UpdateFightRoleResponse Create()
		{
			return new UpdateFightRoleResponse();
		}

		// Token: 0x17006090 RID: 24720
		// (get) Token: 0x0601C8AF RID: 116911 RVA: 0x004231E7 File Offset: 0x004213E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006091 RID: 24721
		// (get) Token: 0x0601C8B0 RID: 116912 RVA: 0x004231EA File Offset: 0x004213EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateFightRoleResponse.Descriptor;
			}
		}

		// Token: 0x0601C8B1 RID: 116913 RVA: 0x004231F1 File Offset: 0x004213F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateFightRoleResponse()
		{
		}

		// Token: 0x0601C8B2 RID: 116914 RVA: 0x004231F9 File Offset: 0x004213F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateFightRoleResponse(UpdateFightRoleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C8B3 RID: 116915 RVA: 0x0042321E File Offset: 0x0042141E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateFightRoleResponse Clone()
		{
			return new UpdateFightRoleResponse(this);
		}

		// Token: 0x17006092 RID: 24722
		// (get) Token: 0x0601C8B4 RID: 116916 RVA: 0x00423226 File Offset: 0x00421426
		// (set) Token: 0x0601C8B5 RID: 116917 RVA: 0x0042322E File Offset: 0x0042142E
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

		// Token: 0x0601C8B6 RID: 116918 RVA: 0x00423237 File Offset: 0x00421437
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateFightRoleResponse);
		}

		// Token: 0x0601C8B7 RID: 116919 RVA: 0x00423245 File Offset: 0x00421445
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateFightRoleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C8B8 RID: 116920 RVA: 0x00423274 File Offset: 0x00421474
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

		// Token: 0x0601C8B9 RID: 116921 RVA: 0x004232B9 File Offset: 0x004214B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C8BA RID: 116922 RVA: 0x004232C6 File Offset: 0x004214C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C8BB RID: 116923 RVA: 0x004232CF File Offset: 0x004214CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C8BC RID: 116924 RVA: 0x00423304 File Offset: 0x00421504
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

		// Token: 0x0601C8BD RID: 116925 RVA: 0x00423342 File Offset: 0x00421542
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateFightRoleResponse other)
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

		// Token: 0x0601C8BE RID: 116926 RVA: 0x00423373 File Offset: 0x00421573
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C8BF RID: 116927 RVA: 0x0042337C File Offset: 0x0042157C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A495 RID: 42133
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A496 RID: 42134
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x0400A497 RID: 42135
		private ErrorCode errorCode_;
	}
}
