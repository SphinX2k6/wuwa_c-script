using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200073E RID: 1854
	[NetMessage(EMessageId.HitEndResponse)]
	public sealed class HitEndResponse : IMessage<HitEndResponse>, IMessage, IEquatable<HitEndResponse>, IDeepCloneable<HitEndResponse>, IBufferMessage
	{
		// Token: 0x0600A840 RID: 43072 RVA: 0x00194F67 File Offset: 0x00193167
		[NullableContext(1)]
		public static HitEndResponse Create()
		{
			return new HitEndResponse();
		}

		// Token: 0x170021CF RID: 8655
		// (get) Token: 0x0600A841 RID: 43073 RVA: 0x00194F6E File Offset: 0x0019316E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170021D0 RID: 8656
		// (get) Token: 0x0600A842 RID: 43074 RVA: 0x00194F71 File Offset: 0x00193171
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HitEndResponse.Descriptor;
			}
		}

		// Token: 0x0600A843 RID: 43075 RVA: 0x00194F78 File Offset: 0x00193178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitEndResponse()
		{
		}

		// Token: 0x0600A844 RID: 43076 RVA: 0x00194F80 File Offset: 0x00193180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitEndResponse(HitEndResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A845 RID: 43077 RVA: 0x00194FA5 File Offset: 0x001931A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitEndResponse Clone()
		{
			return new HitEndResponse(this);
		}

		// Token: 0x170021D1 RID: 8657
		// (get) Token: 0x0600A846 RID: 43078 RVA: 0x00194FAD File Offset: 0x001931AD
		// (set) Token: 0x0600A847 RID: 43079 RVA: 0x00194FB5 File Offset: 0x001931B5
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

		// Token: 0x0600A848 RID: 43080 RVA: 0x00194FBE File Offset: 0x001931BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HitEndResponse);
		}

		// Token: 0x0600A849 RID: 43081 RVA: 0x00194FCC File Offset: 0x001931CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HitEndResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A84A RID: 43082 RVA: 0x00194FFC File Offset: 0x001931FC
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

		// Token: 0x0600A84B RID: 43083 RVA: 0x00195041 File Offset: 0x00193241
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A84C RID: 43084 RVA: 0x0019504E File Offset: 0x0019324E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A84D RID: 43085 RVA: 0x00195057 File Offset: 0x00193257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A84E RID: 43086 RVA: 0x0019508C File Offset: 0x0019328C
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

		// Token: 0x0600A84F RID: 43087 RVA: 0x001950CA File Offset: 0x001932CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HitEndResponse other)
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

		// Token: 0x0600A850 RID: 43088 RVA: 0x001950FB File Offset: 0x001932FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A851 RID: 43089 RVA: 0x00195104 File Offset: 0x00193304
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004D19 RID: 19737
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D1A RID: 19738
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04004D1B RID: 19739
		private ErrorCode errorCode_;
	}
}
