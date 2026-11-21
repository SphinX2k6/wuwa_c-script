using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001357 RID: 4951
	[NetMessage(EMessageId.SurvivorsStepAdvanceResponse)]
	public sealed class SurvivorsStepAdvanceResponse : IMessage<SurvivorsStepAdvanceResponse>, IMessage, IEquatable<SurvivorsStepAdvanceResponse>, IDeepCloneable<SurvivorsStepAdvanceResponse>, IBufferMessage
	{
		// Token: 0x0601A60E RID: 108046 RVA: 0x003D83D7 File Offset: 0x003D65D7
		[NullableContext(1)]
		public static SurvivorsStepAdvanceResponse Create()
		{
			return new SurvivorsStepAdvanceResponse();
		}

		// Token: 0x17005954 RID: 22868
		// (get) Token: 0x0601A60F RID: 108047 RVA: 0x003D83DE File Offset: 0x003D65DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005955 RID: 22869
		// (get) Token: 0x0601A610 RID: 108048 RVA: 0x003D83E1 File Offset: 0x003D65E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsStepAdvanceResponse.Descriptor;
			}
		}

		// Token: 0x0601A611 RID: 108049 RVA: 0x003D83E8 File Offset: 0x003D65E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsStepAdvanceResponse()
		{
		}

		// Token: 0x0601A612 RID: 108050 RVA: 0x003D83F0 File Offset: 0x003D65F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsStepAdvanceResponse(SurvivorsStepAdvanceResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A613 RID: 108051 RVA: 0x003D8415 File Offset: 0x003D6615
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsStepAdvanceResponse Clone()
		{
			return new SurvivorsStepAdvanceResponse(this);
		}

		// Token: 0x17005956 RID: 22870
		// (get) Token: 0x0601A614 RID: 108052 RVA: 0x003D841D File Offset: 0x003D661D
		// (set) Token: 0x0601A615 RID: 108053 RVA: 0x003D8425 File Offset: 0x003D6625
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

		// Token: 0x0601A616 RID: 108054 RVA: 0x003D842E File Offset: 0x003D662E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsStepAdvanceResponse);
		}

		// Token: 0x0601A617 RID: 108055 RVA: 0x003D843C File Offset: 0x003D663C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsStepAdvanceResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A618 RID: 108056 RVA: 0x003D846C File Offset: 0x003D666C
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

		// Token: 0x0601A619 RID: 108057 RVA: 0x003D84B1 File Offset: 0x003D66B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A61A RID: 108058 RVA: 0x003D84BE File Offset: 0x003D66BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A61B RID: 108059 RVA: 0x003D84C7 File Offset: 0x003D66C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A61C RID: 108060 RVA: 0x003D84FC File Offset: 0x003D66FC
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

		// Token: 0x0601A61D RID: 108061 RVA: 0x003D853A File Offset: 0x003D673A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsStepAdvanceResponse other)
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

		// Token: 0x0601A61E RID: 108062 RVA: 0x003D856B File Offset: 0x003D676B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A61F RID: 108063 RVA: 0x003D8574 File Offset: 0x003D6774
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
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009AE9 RID: 39657
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009AEA RID: 39658
		public const int ErrCodeFieldNumber = 4;

		// Token: 0x04009AEB RID: 39659
		private ErrorCode errCode_;
	}
}
