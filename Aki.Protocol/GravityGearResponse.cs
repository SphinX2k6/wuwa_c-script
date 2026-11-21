using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006FF RID: 1791
	[NetMessage(EMessageId.GravityGearResponse)]
	public sealed class GravityGearResponse : IMessage<GravityGearResponse>, IMessage, IEquatable<GravityGearResponse>, IDeepCloneable<GravityGearResponse>, IBufferMessage
	{
		// Token: 0x0600A356 RID: 41814 RVA: 0x0018AD1C File Offset: 0x00188F1C
		[NullableContext(1)]
		public static GravityGearResponse Create()
		{
			return new GravityGearResponse();
		}

		// Token: 0x170020D2 RID: 8402
		// (get) Token: 0x0600A357 RID: 41815 RVA: 0x0018AD23 File Offset: 0x00188F23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170020D3 RID: 8403
		// (get) Token: 0x0600A358 RID: 41816 RVA: 0x0018AD26 File Offset: 0x00188F26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GravityGearResponse.Descriptor;
			}
		}

		// Token: 0x0600A359 RID: 41817 RVA: 0x0018AD2D File Offset: 0x00188F2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityGearResponse()
		{
		}

		// Token: 0x0600A35A RID: 41818 RVA: 0x0018AD35 File Offset: 0x00188F35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityGearResponse(GravityGearResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A35B RID: 41819 RVA: 0x0018AD5A File Offset: 0x00188F5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityGearResponse Clone()
		{
			return new GravityGearResponse(this);
		}

		// Token: 0x170020D4 RID: 8404
		// (get) Token: 0x0600A35C RID: 41820 RVA: 0x0018AD62 File Offset: 0x00188F62
		// (set) Token: 0x0600A35D RID: 41821 RVA: 0x0018AD6A File Offset: 0x00188F6A
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

		// Token: 0x0600A35E RID: 41822 RVA: 0x0018AD73 File Offset: 0x00188F73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GravityGearResponse);
		}

		// Token: 0x0600A35F RID: 41823 RVA: 0x0018AD81 File Offset: 0x00188F81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GravityGearResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A360 RID: 41824 RVA: 0x0018ADB0 File Offset: 0x00188FB0
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

		// Token: 0x0600A361 RID: 41825 RVA: 0x0018ADF5 File Offset: 0x00188FF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A362 RID: 41826 RVA: 0x0018AE02 File Offset: 0x00189002
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A363 RID: 41827 RVA: 0x0018AE0B File Offset: 0x0018900B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A364 RID: 41828 RVA: 0x0018AE40 File Offset: 0x00189040
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

		// Token: 0x0600A365 RID: 41829 RVA: 0x0018AE7E File Offset: 0x0018907E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GravityGearResponse other)
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

		// Token: 0x0600A366 RID: 41830 RVA: 0x0018AEAF File Offset: 0x001890AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A367 RID: 41831 RVA: 0x0018AEB8 File Offset: 0x001890B8
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004BD4 RID: 19412
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BD5 RID: 19413
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04004BD6 RID: 19414
		private ErrorCode errorCode_;
	}
}
