using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000154 RID: 340
	[NetMessage(EMessageId.BabelTowerShowNameResponse)]
	public sealed class BabelTowerShowNameResponse : IMessage<BabelTowerShowNameResponse>, IMessage, IEquatable<BabelTowerShowNameResponse>, IDeepCloneable<BabelTowerShowNameResponse>, IBufferMessage
	{
		// Token: 0x06002B1B RID: 11035 RVA: 0x00070968 File Offset: 0x0006EB68
		[NullableContext(1)]
		public static BabelTowerShowNameResponse Create()
		{
			return new BabelTowerShowNameResponse();
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06002B1C RID: 11036 RVA: 0x0007096F File Offset: 0x0006EB6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06002B1D RID: 11037 RVA: 0x00070972 File Offset: 0x0006EB72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelTowerShowNameResponse.Descriptor;
			}
		}

		// Token: 0x06002B1E RID: 11038 RVA: 0x00070979 File Offset: 0x0006EB79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerShowNameResponse()
		{
		}

		// Token: 0x06002B1F RID: 11039 RVA: 0x00070981 File Offset: 0x0006EB81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerShowNameResponse(BabelTowerShowNameResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002B20 RID: 11040 RVA: 0x000709A6 File Offset: 0x0006EBA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerShowNameResponse Clone()
		{
			return new BabelTowerShowNameResponse(this);
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06002B21 RID: 11041 RVA: 0x000709AE File Offset: 0x0006EBAE
		// (set) Token: 0x06002B22 RID: 11042 RVA: 0x000709B6 File Offset: 0x0006EBB6
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

		// Token: 0x06002B23 RID: 11043 RVA: 0x000709BF File Offset: 0x0006EBBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelTowerShowNameResponse);
		}

		// Token: 0x06002B24 RID: 11044 RVA: 0x000709CD File Offset: 0x0006EBCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelTowerShowNameResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002B25 RID: 11045 RVA: 0x000709FC File Offset: 0x0006EBFC
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

		// Token: 0x06002B26 RID: 11046 RVA: 0x00070A41 File Offset: 0x0006EC41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002B27 RID: 11047 RVA: 0x00070A4E File Offset: 0x0006EC4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002B28 RID: 11048 RVA: 0x00070A57 File Offset: 0x0006EC57
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

		// Token: 0x06002B29 RID: 11049 RVA: 0x00070A8C File Offset: 0x0006EC8C
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

		// Token: 0x06002B2A RID: 11050 RVA: 0x00070ACA File Offset: 0x0006ECCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BabelTowerShowNameResponse other)
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

		// Token: 0x06002B2B RID: 11051 RVA: 0x00070AFB File Offset: 0x0006ECFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002B2C RID: 11052 RVA: 0x00070B04 File Offset: 0x0006ED04
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

		// Token: 0x0400278A RID: 10122
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400278B RID: 10123
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x0400278C RID: 10124
		private ErrorCode errorCode_;
	}
}
