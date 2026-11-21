using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001D5 RID: 469
	[NetMessage(EMessageId.BossRushBuffChooseResultResponse)]
	public sealed class BossRushBuffChooseResultResponse : IMessage<BossRushBuffChooseResultResponse>, IMessage, IEquatable<BossRushBuffChooseResultResponse>, IDeepCloneable<BossRushBuffChooseResultResponse>, IBufferMessage
	{
		// Token: 0x06003575 RID: 13685 RVA: 0x00086AF5 File Offset: 0x00084CF5
		[NullableContext(1)]
		public static BossRushBuffChooseResultResponse Create()
		{
			return new BossRushBuffChooseResultResponse();
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x06003576 RID: 13686 RVA: 0x00086AFC File Offset: 0x00084CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x06003577 RID: 13687 RVA: 0x00086AFF File Offset: 0x00084CFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossRushBuffChooseResultResponse.Descriptor;
			}
		}

		// Token: 0x06003578 RID: 13688 RVA: 0x00086B06 File Offset: 0x00084D06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushBuffChooseResultResponse()
		{
		}

		// Token: 0x06003579 RID: 13689 RVA: 0x00086B0E File Offset: 0x00084D0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushBuffChooseResultResponse(BossRushBuffChooseResultResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600357A RID: 13690 RVA: 0x00086B33 File Offset: 0x00084D33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushBuffChooseResultResponse Clone()
		{
			return new BossRushBuffChooseResultResponse(this);
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x0600357B RID: 13691 RVA: 0x00086B3B File Offset: 0x00084D3B
		// (set) Token: 0x0600357C RID: 13692 RVA: 0x00086B43 File Offset: 0x00084D43
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

		// Token: 0x0600357D RID: 13693 RVA: 0x00086B4C File Offset: 0x00084D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossRushBuffChooseResultResponse);
		}

		// Token: 0x0600357E RID: 13694 RVA: 0x00086B5A File Offset: 0x00084D5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossRushBuffChooseResultResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600357F RID: 13695 RVA: 0x00086B88 File Offset: 0x00084D88
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

		// Token: 0x06003580 RID: 13696 RVA: 0x00086BCD File Offset: 0x00084DCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003581 RID: 13697 RVA: 0x00086BDA File Offset: 0x00084DDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003582 RID: 13698 RVA: 0x00086BE3 File Offset: 0x00084DE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003583 RID: 13699 RVA: 0x00086C18 File Offset: 0x00084E18
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

		// Token: 0x06003584 RID: 13700 RVA: 0x00086C56 File Offset: 0x00084E56
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

		// Token: 0x06003585 RID: 13701 RVA: 0x00086C87 File Offset: 0x00084E87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003586 RID: 13702 RVA: 0x00086C90 File Offset: 0x00084E90
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002AA3 RID: 10915
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002AA4 RID: 10916
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04002AA5 RID: 10917
		private ErrorCode errorCode_;
	}
}
