using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200080E RID: 2062
	[NetMessage(EMessageId.InstEntityTeleportResponse)]
	public sealed class InstEntityTeleportResponse : IMessage<InstEntityTeleportResponse>, IMessage, IEquatable<InstEntityTeleportResponse>, IDeepCloneable<InstEntityTeleportResponse>, IBufferMessage
	{
		// Token: 0x0600B8AC RID: 47276 RVA: 0x001B7FB0 File Offset: 0x001B61B0
		[NullableContext(1)]
		public static InstEntityTeleportResponse Create()
		{
			return new InstEntityTeleportResponse();
		}

		// Token: 0x17002531 RID: 9521
		// (get) Token: 0x0600B8AD RID: 47277 RVA: 0x001B7FB7 File Offset: 0x001B61B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002532 RID: 9522
		// (get) Token: 0x0600B8AE RID: 47278 RVA: 0x001B7FBA File Offset: 0x001B61BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InstEntityTeleportResponse.Descriptor;
			}
		}

		// Token: 0x0600B8AF RID: 47279 RVA: 0x001B7FC1 File Offset: 0x001B61C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstEntityTeleportResponse()
		{
		}

		// Token: 0x0600B8B0 RID: 47280 RVA: 0x001B7FC9 File Offset: 0x001B61C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstEntityTeleportResponse(InstEntityTeleportResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B8B1 RID: 47281 RVA: 0x001B7FEE File Offset: 0x001B61EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstEntityTeleportResponse Clone()
		{
			return new InstEntityTeleportResponse(this);
		}

		// Token: 0x17002533 RID: 9523
		// (get) Token: 0x0600B8B2 RID: 47282 RVA: 0x001B7FF6 File Offset: 0x001B61F6
		// (set) Token: 0x0600B8B3 RID: 47283 RVA: 0x001B7FFE File Offset: 0x001B61FE
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

		// Token: 0x0600B8B4 RID: 47284 RVA: 0x001B8007 File Offset: 0x001B6207
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InstEntityTeleportResponse);
		}

		// Token: 0x0600B8B5 RID: 47285 RVA: 0x001B8015 File Offset: 0x001B6215
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InstEntityTeleportResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B8B6 RID: 47286 RVA: 0x001B8044 File Offset: 0x001B6244
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

		// Token: 0x0600B8B7 RID: 47287 RVA: 0x001B8089 File Offset: 0x001B6289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B8B8 RID: 47288 RVA: 0x001B8096 File Offset: 0x001B6296
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B8B9 RID: 47289 RVA: 0x001B809F File Offset: 0x001B629F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B8BA RID: 47290 RVA: 0x001B80D4 File Offset: 0x001B62D4
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

		// Token: 0x0600B8BB RID: 47291 RVA: 0x001B8112 File Offset: 0x001B6312
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InstEntityTeleportResponse other)
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

		// Token: 0x0600B8BC RID: 47292 RVA: 0x001B8143 File Offset: 0x001B6343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B8BD RID: 47293 RVA: 0x001B814C File Offset: 0x001B634C
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040051A2 RID: 20898
		private UnknownFieldSet _unknownFields;

		// Token: 0x040051A3 RID: 20899
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x040051A4 RID: 20900
		private ErrorCode errorCode_;
	}
}
