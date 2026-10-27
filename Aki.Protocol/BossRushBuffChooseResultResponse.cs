using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001D1 RID: 465
	[NetMessage(EMessageId.BossRushBuffChooseResultResponse)]
	public sealed class BossRushBuffChooseResultResponse : IMessage<BossRushBuffChooseResultResponse>, IMessage, IEquatable<BossRushBuffChooseResultResponse>, IDeepCloneable<BossRushBuffChooseResultResponse>, IBufferMessage
	{
		// Token: 0x060034E8 RID: 13544 RVA: 0x00085381 File Offset: 0x00083581
		[NullableContext(1)]
		public static BossRushBuffChooseResultResponse Create()
		{
			return new BossRushBuffChooseResultResponse();
		}

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x060034E9 RID: 13545 RVA: 0x00085388 File Offset: 0x00083588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x060034EA RID: 13546 RVA: 0x0008538B File Offset: 0x0008358B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossRushBuffChooseResultResponse.Descriptor;
			}
		}

		// Token: 0x060034EB RID: 13547 RVA: 0x00085392 File Offset: 0x00083592
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushBuffChooseResultResponse()
		{
		}

		// Token: 0x060034EC RID: 13548 RVA: 0x0008539A File Offset: 0x0008359A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushBuffChooseResultResponse(BossRushBuffChooseResultResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060034ED RID: 13549 RVA: 0x000853BF File Offset: 0x000835BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushBuffChooseResultResponse Clone()
		{
			return new BossRushBuffChooseResultResponse(this);
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x060034EE RID: 13550 RVA: 0x000853C7 File Offset: 0x000835C7
		// (set) Token: 0x060034EF RID: 13551 RVA: 0x000853CF File Offset: 0x000835CF
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

		// Token: 0x060034F0 RID: 13552 RVA: 0x000853D8 File Offset: 0x000835D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossRushBuffChooseResultResponse);
		}

		// Token: 0x060034F1 RID: 13553 RVA: 0x000853E6 File Offset: 0x000835E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossRushBuffChooseResultResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060034F2 RID: 13554 RVA: 0x00085414 File Offset: 0x00083614
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

		// Token: 0x060034F3 RID: 13555 RVA: 0x00085459 File Offset: 0x00083659
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060034F4 RID: 13556 RVA: 0x00085466 File Offset: 0x00083666
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060034F5 RID: 13557 RVA: 0x0008546F File Offset: 0x0008366F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060034F6 RID: 13558 RVA: 0x000854A4 File Offset: 0x000836A4
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

		// Token: 0x060034F7 RID: 13559 RVA: 0x000854E2 File Offset: 0x000836E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossRushBuffChooseResultResponse other)
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

		// Token: 0x060034F8 RID: 13560 RVA: 0x00085513 File Offset: 0x00083713
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060034F9 RID: 13561 RVA: 0x0008551C File Offset: 0x0008371C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002A28 RID: 10792
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A29 RID: 10793
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04002A2A RID: 10794
		private ErrorCode errorCode_;
	}
}
