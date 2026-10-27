using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000529 RID: 1321
	[NetMessage(EMessageId.FarmGoldPointResponse)]
	public sealed class FarmGoldPointResponse : IMessage<FarmGoldPointResponse>, IMessage, IEquatable<FarmGoldPointResponse>, IDeepCloneable<FarmGoldPointResponse>, IBufferMessage
	{
		// Token: 0x06007BE0 RID: 31712 RVA: 0x0012C528 File Offset: 0x0012A728
		[NullableContext(1)]
		public static FarmGoldPointResponse Create()
		{
			return new FarmGoldPointResponse();
		}

		// Token: 0x17001808 RID: 6152
		// (get) Token: 0x06007BE1 RID: 31713 RVA: 0x0012C52F File Offset: 0x0012A72F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001809 RID: 6153
		// (get) Token: 0x06007BE2 RID: 31714 RVA: 0x0012C532 File Offset: 0x0012A732
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FarmGoldPointResponse.Descriptor;
			}
		}

		// Token: 0x06007BE3 RID: 31715 RVA: 0x0012C539 File Offset: 0x0012A739
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldPointResponse()
		{
		}

		// Token: 0x06007BE4 RID: 31716 RVA: 0x0012C541 File Offset: 0x0012A741
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldPointResponse(FarmGoldPointResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007BE5 RID: 31717 RVA: 0x0012C566 File Offset: 0x0012A766
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldPointResponse Clone()
		{
			return new FarmGoldPointResponse(this);
		}

		// Token: 0x1700180A RID: 6154
		// (get) Token: 0x06007BE6 RID: 31718 RVA: 0x0012C56E File Offset: 0x0012A76E
		// (set) Token: 0x06007BE7 RID: 31719 RVA: 0x0012C576 File Offset: 0x0012A776
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

		// Token: 0x06007BE8 RID: 31720 RVA: 0x0012C57F File Offset: 0x0012A77F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FarmGoldPointResponse);
		}

		// Token: 0x06007BE9 RID: 31721 RVA: 0x0012C58D File Offset: 0x0012A78D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FarmGoldPointResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007BEA RID: 31722 RVA: 0x0012C5BC File Offset: 0x0012A7BC
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

		// Token: 0x06007BEB RID: 31723 RVA: 0x0012C601 File Offset: 0x0012A801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007BEC RID: 31724 RVA: 0x0012C60E File Offset: 0x0012A80E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007BED RID: 31725 RVA: 0x0012C617 File Offset: 0x0012A817
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007BEE RID: 31726 RVA: 0x0012C64C File Offset: 0x0012A84C
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

		// Token: 0x06007BEF RID: 31727 RVA: 0x0012C68A File Offset: 0x0012A88A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FarmGoldPointResponse other)
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

		// Token: 0x06007BF0 RID: 31728 RVA: 0x0012C6BB File Offset: 0x0012A8BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007BF1 RID: 31729 RVA: 0x0012C6C4 File Offset: 0x0012A8C4
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003F49 RID: 16201
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F4A RID: 16202
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04003F4B RID: 16203
		private ErrorCode errorCode_;
	}
}
