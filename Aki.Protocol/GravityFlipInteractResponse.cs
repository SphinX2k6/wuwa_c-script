using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006FC RID: 1788
	[NetMessage(EMessageId.GravityFlipInteractResponse)]
	public sealed class GravityFlipInteractResponse : IMessage<GravityFlipInteractResponse>, IMessage, IEquatable<GravityFlipInteractResponse>, IDeepCloneable<GravityFlipInteractResponse>, IBufferMessage
	{
		// Token: 0x0600A31A RID: 41754 RVA: 0x0018A540 File Offset: 0x00188740
		[NullableContext(1)]
		public static GravityFlipInteractResponse Create()
		{
			return new GravityFlipInteractResponse();
		}

		// Token: 0x170020C6 RID: 8390
		// (get) Token: 0x0600A31B RID: 41755 RVA: 0x0018A547 File Offset: 0x00188747
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170020C7 RID: 8391
		// (get) Token: 0x0600A31C RID: 41756 RVA: 0x0018A54A File Offset: 0x0018874A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GravityFlipInteractResponse.Descriptor;
			}
		}

		// Token: 0x0600A31D RID: 41757 RVA: 0x0018A551 File Offset: 0x00188751
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityFlipInteractResponse()
		{
		}

		// Token: 0x0600A31E RID: 41758 RVA: 0x0018A559 File Offset: 0x00188759
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityFlipInteractResponse(GravityFlipInteractResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.curGravityFlipType_ = other.curGravityFlipType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A31F RID: 41759 RVA: 0x0018A58A File Offset: 0x0018878A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityFlipInteractResponse Clone()
		{
			return new GravityFlipInteractResponse(this);
		}

		// Token: 0x170020C8 RID: 8392
		// (get) Token: 0x0600A320 RID: 41760 RVA: 0x0018A592 File Offset: 0x00188792
		// (set) Token: 0x0600A321 RID: 41761 RVA: 0x0018A59A File Offset: 0x0018879A
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

		// Token: 0x170020C9 RID: 8393
		// (get) Token: 0x0600A322 RID: 41762 RVA: 0x0018A5A3 File Offset: 0x001887A3
		// (set) Token: 0x0600A323 RID: 41763 RVA: 0x0018A5AB File Offset: 0x001887AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityFlipType CurGravityFlipType
		{
			get
			{
				return this.curGravityFlipType_;
			}
			set
			{
				this.curGravityFlipType_ = value;
			}
		}

		// Token: 0x0600A324 RID: 41764 RVA: 0x0018A5B4 File Offset: 0x001887B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GravityFlipInteractResponse);
		}

		// Token: 0x0600A325 RID: 41765 RVA: 0x0018A5C2 File Offset: 0x001887C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GravityFlipInteractResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.CurGravityFlipType == other.CurGravityFlipType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A326 RID: 41766 RVA: 0x0018A600 File Offset: 0x00188800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.CurGravityFlipType != GravityFlipType.GravityUp)
			{
				num ^= this.CurGravityFlipType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A327 RID: 41767 RVA: 0x0018A664 File Offset: 0x00188864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A328 RID: 41768 RVA: 0x0018A671 File Offset: 0x00188871
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A329 RID: 41769 RVA: 0x0018A67C File Offset: 0x0018887C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurGravityFlipType != GravityFlipType.GravityUp)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.CurGravityFlipType);
			}
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

		// Token: 0x0600A32A RID: 41770 RVA: 0x0018A6D8 File Offset: 0x001888D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.CurGravityFlipType != GravityFlipType.GravityUp)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.CurGravityFlipType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A32B RID: 41771 RVA: 0x0018A730 File Offset: 0x00188930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GravityFlipInteractResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.CurGravityFlipType != GravityFlipType.GravityUp)
			{
				this.CurGravityFlipType = other.CurGravityFlipType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A32C RID: 41772 RVA: 0x0018A780 File Offset: 0x00188980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A32D RID: 41773 RVA: 0x0018A78C File Offset: 0x0018898C
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
				if (num != 64U)
				{
					if (num != 80U)
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
					this.CurGravityFlipType = (GravityFlipType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004BC5 RID: 19397
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BC6 RID: 19398
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04004BC7 RID: 19399
		private ErrorCode errorCode_;

		// Token: 0x04004BC8 RID: 19400
		public const int CurGravityFlipTypeFieldNumber = 8;

		// Token: 0x04004BC9 RID: 19401
		private GravityFlipType curGravityFlipType_;
	}
}
