using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010E7 RID: 4327
	[NetMessage(EMessageId.RoleTowerSaveDeleteResponse)]
	public sealed class RoleTowerSaveDeleteResponse : IMessage<RoleTowerSaveDeleteResponse>, IMessage, IEquatable<RoleTowerSaveDeleteResponse>, IDeepCloneable<RoleTowerSaveDeleteResponse>, IBufferMessage
	{
		// Token: 0x06017222 RID: 94754 RVA: 0x0035DA2D File Offset: 0x0035BC2D
		[NullableContext(1)]
		public static RoleTowerSaveDeleteResponse Create()
		{
			return new RoleTowerSaveDeleteResponse();
		}

		// Token: 0x17004DAF RID: 19887
		// (get) Token: 0x06017223 RID: 94755 RVA: 0x0035DA34 File Offset: 0x0035BC34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004DB0 RID: 19888
		// (get) Token: 0x06017224 RID: 94756 RVA: 0x0035DA37 File Offset: 0x0035BC37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerSaveDeleteResponse.Descriptor;
			}
		}

		// Token: 0x06017225 RID: 94757 RVA: 0x0035DA3E File Offset: 0x0035BC3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerSaveDeleteResponse()
		{
		}

		// Token: 0x06017226 RID: 94758 RVA: 0x0035DA46 File Offset: 0x0035BC46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerSaveDeleteResponse(RoleTowerSaveDeleteResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017227 RID: 94759 RVA: 0x0035DA6B File Offset: 0x0035BC6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerSaveDeleteResponse Clone()
		{
			return new RoleTowerSaveDeleteResponse(this);
		}

		// Token: 0x17004DB1 RID: 19889
		// (get) Token: 0x06017228 RID: 94760 RVA: 0x0035DA73 File Offset: 0x0035BC73
		// (set) Token: 0x06017229 RID: 94761 RVA: 0x0035DA7B File Offset: 0x0035BC7B
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

		// Token: 0x0601722A RID: 94762 RVA: 0x0035DA84 File Offset: 0x0035BC84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerSaveDeleteResponse);
		}

		// Token: 0x0601722B RID: 94763 RVA: 0x0035DA92 File Offset: 0x0035BC92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerSaveDeleteResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601722C RID: 94764 RVA: 0x0035DAC0 File Offset: 0x0035BCC0
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

		// Token: 0x0601722D RID: 94765 RVA: 0x0035DB05 File Offset: 0x0035BD05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601722E RID: 94766 RVA: 0x0035DB12 File Offset: 0x0035BD12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601722F RID: 94767 RVA: 0x0035DB1B File Offset: 0x0035BD1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017230 RID: 94768 RVA: 0x0035DB50 File Offset: 0x0035BD50
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

		// Token: 0x06017231 RID: 94769 RVA: 0x0035DB8E File Offset: 0x0035BD8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerSaveDeleteResponse other)
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

		// Token: 0x06017232 RID: 94770 RVA: 0x0035DBBF File Offset: 0x0035BDBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017233 RID: 94771 RVA: 0x0035DBC8 File Offset: 0x0035BDC8
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008A73 RID: 35443
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008A74 RID: 35444
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04008A75 RID: 35445
		private ErrorCode errorCode_;
	}
}
