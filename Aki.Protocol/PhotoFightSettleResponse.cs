using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D1E RID: 3358
	[NetMessage(EMessageId.PhotoFightSettleResponse)]
	public sealed class PhotoFightSettleResponse : IMessage<PhotoFightSettleResponse>, IMessage, IEquatable<PhotoFightSettleResponse>, IDeepCloneable<PhotoFightSettleResponse>, IBufferMessage
	{
		// Token: 0x06012283 RID: 74371 RVA: 0x002A766A File Offset: 0x002A586A
		[NullableContext(1)]
		public static PhotoFightSettleResponse Create()
		{
			return new PhotoFightSettleResponse();
		}

		// Token: 0x17003C2C RID: 15404
		// (get) Token: 0x06012284 RID: 74372 RVA: 0x002A7671 File Offset: 0x002A5871
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C2D RID: 15405
		// (get) Token: 0x06012285 RID: 74373 RVA: 0x002A7674 File Offset: 0x002A5874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhotoFightSettleResponse.Descriptor;
			}
		}

		// Token: 0x06012286 RID: 74374 RVA: 0x002A767B File Offset: 0x002A587B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightSettleResponse()
		{
		}

		// Token: 0x06012287 RID: 74375 RVA: 0x002A7683 File Offset: 0x002A5883
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightSettleResponse(PhotoFightSettleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012288 RID: 74376 RVA: 0x002A76A8 File Offset: 0x002A58A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightSettleResponse Clone()
		{
			return new PhotoFightSettleResponse(this);
		}

		// Token: 0x17003C2E RID: 15406
		// (get) Token: 0x06012289 RID: 74377 RVA: 0x002A76B0 File Offset: 0x002A58B0
		// (set) Token: 0x0601228A RID: 74378 RVA: 0x002A76B8 File Offset: 0x002A58B8
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

		// Token: 0x0601228B RID: 74379 RVA: 0x002A76C1 File Offset: 0x002A58C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhotoFightSettleResponse);
		}

		// Token: 0x0601228C RID: 74380 RVA: 0x002A76CF File Offset: 0x002A58CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhotoFightSettleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601228D RID: 74381 RVA: 0x002A7700 File Offset: 0x002A5900
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

		// Token: 0x0601228E RID: 74382 RVA: 0x002A7745 File Offset: 0x002A5945
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601228F RID: 74383 RVA: 0x002A7752 File Offset: 0x002A5952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012290 RID: 74384 RVA: 0x002A775B File Offset: 0x002A595B
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

		// Token: 0x06012291 RID: 74385 RVA: 0x002A7790 File Offset: 0x002A5990
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

		// Token: 0x06012292 RID: 74386 RVA: 0x002A77CE File Offset: 0x002A59CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhotoFightSettleResponse other)
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

		// Token: 0x06012293 RID: 74387 RVA: 0x002A77FF File Offset: 0x002A59FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012294 RID: 74388 RVA: 0x002A7808 File Offset: 0x002A5A08
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

		// Token: 0x040071DB RID: 29147
		private UnknownFieldSet _unknownFields;

		// Token: 0x040071DC RID: 29148
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x040071DD RID: 29149
		private ErrorCode errorCode_;
	}
}
