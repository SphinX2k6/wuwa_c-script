using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200082E RID: 2094
	[NetMessage(EMessageId.InstTeleportToResetPointResponse)]
	public sealed class InstTeleportToResetPointResponse : IMessage<InstTeleportToResetPointResponse>, IMessage, IEquatable<InstTeleportToResetPointResponse>, IDeepCloneable<InstTeleportToResetPointResponse>, IBufferMessage
	{
		// Token: 0x0600BB31 RID: 47921 RVA: 0x001BE07A File Offset: 0x001BC27A
		[NullableContext(1)]
		public static InstTeleportToResetPointResponse Create()
		{
			return new InstTeleportToResetPointResponse();
		}

		// Token: 0x170025CF RID: 9679
		// (get) Token: 0x0600BB32 RID: 47922 RVA: 0x001BE081 File Offset: 0x001BC281
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170025D0 RID: 9680
		// (get) Token: 0x0600BB33 RID: 47923 RVA: 0x001BE084 File Offset: 0x001BC284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InstTeleportToResetPointResponse.Descriptor;
			}
		}

		// Token: 0x0600BB34 RID: 47924 RVA: 0x001BE08B File Offset: 0x001BC28B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstTeleportToResetPointResponse()
		{
		}

		// Token: 0x0600BB35 RID: 47925 RVA: 0x001BE093 File Offset: 0x001BC293
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstTeleportToResetPointResponse(InstTeleportToResetPointResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BB36 RID: 47926 RVA: 0x001BE0B8 File Offset: 0x001BC2B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstTeleportToResetPointResponse Clone()
		{
			return new InstTeleportToResetPointResponse(this);
		}

		// Token: 0x170025D1 RID: 9681
		// (get) Token: 0x0600BB37 RID: 47927 RVA: 0x001BE0C0 File Offset: 0x001BC2C0
		// (set) Token: 0x0600BB38 RID: 47928 RVA: 0x001BE0C8 File Offset: 0x001BC2C8
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

		// Token: 0x0600BB39 RID: 47929 RVA: 0x001BE0D1 File Offset: 0x001BC2D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InstTeleportToResetPointResponse);
		}

		// Token: 0x0600BB3A RID: 47930 RVA: 0x001BE0DF File Offset: 0x001BC2DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InstTeleportToResetPointResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BB3B RID: 47931 RVA: 0x001BE110 File Offset: 0x001BC310
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

		// Token: 0x0600BB3C RID: 47932 RVA: 0x001BE155 File Offset: 0x001BC355
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BB3D RID: 47933 RVA: 0x001BE162 File Offset: 0x001BC362
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BB3E RID: 47934 RVA: 0x001BE16B File Offset: 0x001BC36B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BB3F RID: 47935 RVA: 0x001BE1A0 File Offset: 0x001BC3A0
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

		// Token: 0x0600BB40 RID: 47936 RVA: 0x001BE1DE File Offset: 0x001BC3DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InstTeleportToResetPointResponse other)
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

		// Token: 0x0600BB41 RID: 47937 RVA: 0x001BE20F File Offset: 0x001BC40F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BB42 RID: 47938 RVA: 0x001BE218 File Offset: 0x001BC418
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005238 RID: 21048
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005239 RID: 21049
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x0400523A RID: 21050
		private ErrorCode errorCode_;
	}
}
