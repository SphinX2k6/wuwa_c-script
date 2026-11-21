using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001481 RID: 5249
	[NetMessage(EMessageId.TrapDefenseBuildingBranchResponse)]
	public sealed class TrapDefenseBuildingBranchResponse : IMessage<TrapDefenseBuildingBranchResponse>, IMessage, IEquatable<TrapDefenseBuildingBranchResponse>, IDeepCloneable<TrapDefenseBuildingBranchResponse>, IBufferMessage
	{
		// Token: 0x0601BDF2 RID: 114162 RVA: 0x0040CB18 File Offset: 0x0040AD18
		[NullableContext(1)]
		public static TrapDefenseBuildingBranchResponse Create()
		{
			return new TrapDefenseBuildingBranchResponse();
		}

		// Token: 0x17005E5C RID: 24156
		// (get) Token: 0x0601BDF3 RID: 114163 RVA: 0x0040CB1F File Offset: 0x0040AD1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E5D RID: 24157
		// (get) Token: 0x0601BDF4 RID: 114164 RVA: 0x0040CB22 File Offset: 0x0040AD22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseBuildingBranchResponse.Descriptor;
			}
		}

		// Token: 0x0601BDF5 RID: 114165 RVA: 0x0040CB29 File Offset: 0x0040AD29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingBranchResponse()
		{
		}

		// Token: 0x0601BDF6 RID: 114166 RVA: 0x0040CB31 File Offset: 0x0040AD31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingBranchResponse(TrapDefenseBuildingBranchResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BDF7 RID: 114167 RVA: 0x0040CB56 File Offset: 0x0040AD56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingBranchResponse Clone()
		{
			return new TrapDefenseBuildingBranchResponse(this);
		}

		// Token: 0x17005E5E RID: 24158
		// (get) Token: 0x0601BDF8 RID: 114168 RVA: 0x0040CB5E File Offset: 0x0040AD5E
		// (set) Token: 0x0601BDF9 RID: 114169 RVA: 0x0040CB66 File Offset: 0x0040AD66
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

		// Token: 0x0601BDFA RID: 114170 RVA: 0x0040CB6F File Offset: 0x0040AD6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseBuildingBranchResponse);
		}

		// Token: 0x0601BDFB RID: 114171 RVA: 0x0040CB7D File Offset: 0x0040AD7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseBuildingBranchResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BDFC RID: 114172 RVA: 0x0040CBAC File Offset: 0x0040ADAC
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

		// Token: 0x0601BDFD RID: 114173 RVA: 0x0040CBF1 File Offset: 0x0040ADF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BDFE RID: 114174 RVA: 0x0040CBFE File Offset: 0x0040ADFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BDFF RID: 114175 RVA: 0x0040CC07 File Offset: 0x0040AE07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BE00 RID: 114176 RVA: 0x0040CC3C File Offset: 0x0040AE3C
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

		// Token: 0x0601BE01 RID: 114177 RVA: 0x0040CC7A File Offset: 0x0040AE7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseBuildingBranchResponse other)
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

		// Token: 0x0601BE02 RID: 114178 RVA: 0x0040CCAB File Offset: 0x0040AEAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BE03 RID: 114179 RVA: 0x0040CCB4 File Offset: 0x0040AEB4
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A1B0 RID: 41392
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A1B1 RID: 41393
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x0400A1B2 RID: 41394
		private ErrorCode errorCode_;
	}
}
