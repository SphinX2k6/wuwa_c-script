using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200140E RID: 5134
	[NetMessage(EMessageId.TrapDefenseBuildingBranchResponse)]
	public sealed class TrapDefenseBuildingBranchResponse : IMessage<TrapDefenseBuildingBranchResponse>, IMessage, IEquatable<TrapDefenseBuildingBranchResponse>, IDeepCloneable<TrapDefenseBuildingBranchResponse>, IBufferMessage
	{
		// Token: 0x0601B367 RID: 111463 RVA: 0x003F1844 File Offset: 0x003EFA44
		[NullableContext(1)]
		public static TrapDefenseBuildingBranchResponse Create()
		{
			return new TrapDefenseBuildingBranchResponse();
		}

		// Token: 0x17005BC7 RID: 23495
		// (get) Token: 0x0601B368 RID: 111464 RVA: 0x003F184B File Offset: 0x003EFA4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005BC8 RID: 23496
		// (get) Token: 0x0601B369 RID: 111465 RVA: 0x003F184E File Offset: 0x003EFA4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseBuildingBranchResponse.Descriptor;
			}
		}

		// Token: 0x0601B36A RID: 111466 RVA: 0x003F1855 File Offset: 0x003EFA55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingBranchResponse()
		{
		}

		// Token: 0x0601B36B RID: 111467 RVA: 0x003F185D File Offset: 0x003EFA5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingBranchResponse(TrapDefenseBuildingBranchResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B36C RID: 111468 RVA: 0x003F1882 File Offset: 0x003EFA82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingBranchResponse Clone()
		{
			return new TrapDefenseBuildingBranchResponse(this);
		}

		// Token: 0x17005BC9 RID: 23497
		// (get) Token: 0x0601B36D RID: 111469 RVA: 0x003F188A File Offset: 0x003EFA8A
		// (set) Token: 0x0601B36E RID: 111470 RVA: 0x003F1892 File Offset: 0x003EFA92
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

		// Token: 0x0601B36F RID: 111471 RVA: 0x003F189B File Offset: 0x003EFA9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseBuildingBranchResponse);
		}

		// Token: 0x0601B370 RID: 111472 RVA: 0x003F18A9 File Offset: 0x003EFAA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseBuildingBranchResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B371 RID: 111473 RVA: 0x003F18D8 File Offset: 0x003EFAD8
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

		// Token: 0x0601B372 RID: 111474 RVA: 0x003F191D File Offset: 0x003EFB1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B373 RID: 111475 RVA: 0x003F192A File Offset: 0x003EFB2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B374 RID: 111476 RVA: 0x003F1933 File Offset: 0x003EFB33
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

		// Token: 0x0601B375 RID: 111477 RVA: 0x003F1968 File Offset: 0x003EFB68
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

		// Token: 0x0601B376 RID: 111478 RVA: 0x003F19A6 File Offset: 0x003EFBA6
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

		// Token: 0x0601B377 RID: 111479 RVA: 0x003F19D7 File Offset: 0x003EFBD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B378 RID: 111480 RVA: 0x003F19E0 File Offset: 0x003EFBE0
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

		// Token: 0x04009D69 RID: 40297
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009D6A RID: 40298
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04009D6B RID: 40299
		private ErrorCode errorCode_;
	}
}
