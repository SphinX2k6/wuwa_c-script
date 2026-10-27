using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001534 RID: 5428
	[NetMessage(EMessageId.ZitherPlayStateResponse)]
	public sealed class ZitherPlayStateResponse : IMessage<ZitherPlayStateResponse>, IMessage, IEquatable<ZitherPlayStateResponse>, IDeepCloneable<ZitherPlayStateResponse>, IBufferMessage
	{
		// Token: 0x0601CAD0 RID: 117456 RVA: 0x00423AE1 File Offset: 0x00421CE1
		[NullableContext(1)]
		public static ZitherPlayStateResponse Create()
		{
			return new ZitherPlayStateResponse();
		}

		// Token: 0x170060A7 RID: 24743
		// (get) Token: 0x0601CAD1 RID: 117457 RVA: 0x00423AE8 File Offset: 0x00421CE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170060A8 RID: 24744
		// (get) Token: 0x0601CAD2 RID: 117458 RVA: 0x00423AEB File Offset: 0x00421CEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ZitherPlayStateResponse.Descriptor;
			}
		}

		// Token: 0x0601CAD3 RID: 117459 RVA: 0x00423AF2 File Offset: 0x00421CF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ZitherPlayStateResponse()
		{
		}

		// Token: 0x0601CAD4 RID: 117460 RVA: 0x00423AFA File Offset: 0x00421CFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ZitherPlayStateResponse(ZitherPlayStateResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CAD5 RID: 117461 RVA: 0x00423B1F File Offset: 0x00421D1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ZitherPlayStateResponse Clone()
		{
			return new ZitherPlayStateResponse(this);
		}

		// Token: 0x170060A9 RID: 24745
		// (get) Token: 0x0601CAD6 RID: 117462 RVA: 0x00423B27 File Offset: 0x00421D27
		// (set) Token: 0x0601CAD7 RID: 117463 RVA: 0x00423B2F File Offset: 0x00421D2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x0601CAD8 RID: 117464 RVA: 0x00423B38 File Offset: 0x00421D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ZitherPlayStateResponse);
		}

		// Token: 0x0601CAD9 RID: 117465 RVA: 0x00423B46 File Offset: 0x00421D46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ZitherPlayStateResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CADA RID: 117466 RVA: 0x00423B74 File Offset: 0x00421D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CADB RID: 117467 RVA: 0x00423BB9 File Offset: 0x00421DB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CADC RID: 117468 RVA: 0x00423BC6 File Offset: 0x00421DC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CADD RID: 117469 RVA: 0x00423BCF File Offset: 0x00421DCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CADE RID: 117470 RVA: 0x00423C04 File Offset: 0x00421E04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CADF RID: 117471 RVA: 0x00423C42 File Offset: 0x00421E42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ZitherPlayStateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CAE0 RID: 117472 RVA: 0x00423C73 File Offset: 0x00421E73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CAE1 RID: 117473 RVA: 0x00423C7C File Offset: 0x00421E7C
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
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A3D9 RID: 41945
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A3DA RID: 41946
		public const int ErrCodeFieldNumber = 14;

		// Token: 0x0400A3DB RID: 41947
		private ErrorCode errCode_;
	}
}
