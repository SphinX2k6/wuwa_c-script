using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000156 RID: 342
	[NetMessage(EMessageId.BabelTowerTaskRewardResponse)]
	public sealed class BabelTowerTaskRewardResponse : IMessage<BabelTowerTaskRewardResponse>, IMessage, IEquatable<BabelTowerTaskRewardResponse>, IDeepCloneable<BabelTowerTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x06002B43 RID: 11075 RVA: 0x00070EAA File Offset: 0x0006F0AA
		[NullableContext(1)]
		public static BabelTowerTaskRewardResponse Create()
		{
			return new BabelTowerTaskRewardResponse();
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06002B44 RID: 11076 RVA: 0x00070EB1 File Offset: 0x0006F0B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06002B45 RID: 11077 RVA: 0x00070EB4 File Offset: 0x0006F0B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelTowerTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x06002B46 RID: 11078 RVA: 0x00070EBB File Offset: 0x0006F0BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerTaskRewardResponse()
		{
		}

		// Token: 0x06002B47 RID: 11079 RVA: 0x00070EC3 File Offset: 0x0006F0C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerTaskRewardResponse(BabelTowerTaskRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002B48 RID: 11080 RVA: 0x00070EE8 File Offset: 0x0006F0E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerTaskRewardResponse Clone()
		{
			return new BabelTowerTaskRewardResponse(this);
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06002B49 RID: 11081 RVA: 0x00070EF0 File Offset: 0x0006F0F0
		// (set) Token: 0x06002B4A RID: 11082 RVA: 0x00070EF8 File Offset: 0x0006F0F8
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

		// Token: 0x06002B4B RID: 11083 RVA: 0x00070F01 File Offset: 0x0006F101
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelTowerTaskRewardResponse);
		}

		// Token: 0x06002B4C RID: 11084 RVA: 0x00070F0F File Offset: 0x0006F10F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelTowerTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002B4D RID: 11085 RVA: 0x00070F40 File Offset: 0x0006F140
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

		// Token: 0x06002B4E RID: 11086 RVA: 0x00070F85 File Offset: 0x0006F185
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002B4F RID: 11087 RVA: 0x00070F92 File Offset: 0x0006F192
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002B50 RID: 11088 RVA: 0x00070F9B File Offset: 0x0006F19B
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

		// Token: 0x06002B51 RID: 11089 RVA: 0x00070FD0 File Offset: 0x0006F1D0
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

		// Token: 0x06002B52 RID: 11090 RVA: 0x0007100E File Offset: 0x0006F20E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BabelTowerTaskRewardResponse other)
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

		// Token: 0x06002B53 RID: 11091 RVA: 0x0007103F File Offset: 0x0006F23F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002B54 RID: 11092 RVA: 0x00071048 File Offset: 0x0006F248
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

		// Token: 0x04002795 RID: 10133
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002796 RID: 10134
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04002797 RID: 10135
		private ErrorCode errorCode_;
	}
}
