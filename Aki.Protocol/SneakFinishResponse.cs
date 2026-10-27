using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200125A RID: 4698
	[NetMessage(EMessageId.SneakFinishResponse)]
	public sealed class SneakFinishResponse : IMessage<SneakFinishResponse>, IMessage, IEquatable<SneakFinishResponse>, IDeepCloneable<SneakFinishResponse>, IBufferMessage
	{
		// Token: 0x0601907F RID: 102527 RVA: 0x003A45F8 File Offset: 0x003A27F8
		[NullableContext(1)]
		public static SneakFinishResponse Create()
		{
			return new SneakFinishResponse();
		}

		// Token: 0x1700546C RID: 21612
		// (get) Token: 0x06019080 RID: 102528 RVA: 0x003A45FF File Offset: 0x003A27FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700546D RID: 21613
		// (get) Token: 0x06019081 RID: 102529 RVA: 0x003A4602 File Offset: 0x003A2802
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SneakFinishResponse.Descriptor;
			}
		}

		// Token: 0x06019082 RID: 102530 RVA: 0x003A4609 File Offset: 0x003A2809
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakFinishResponse()
		{
		}

		// Token: 0x06019083 RID: 102531 RVA: 0x003A4611 File Offset: 0x003A2811
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakFinishResponse(SneakFinishResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019084 RID: 102532 RVA: 0x003A4636 File Offset: 0x003A2836
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakFinishResponse Clone()
		{
			return new SneakFinishResponse(this);
		}

		// Token: 0x1700546E RID: 21614
		// (get) Token: 0x06019085 RID: 102533 RVA: 0x003A463E File Offset: 0x003A283E
		// (set) Token: 0x06019086 RID: 102534 RVA: 0x003A4646 File Offset: 0x003A2846
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

		// Token: 0x06019087 RID: 102535 RVA: 0x003A464F File Offset: 0x003A284F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SneakFinishResponse);
		}

		// Token: 0x06019088 RID: 102536 RVA: 0x003A465D File Offset: 0x003A285D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SneakFinishResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019089 RID: 102537 RVA: 0x003A468C File Offset: 0x003A288C
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

		// Token: 0x0601908A RID: 102538 RVA: 0x003A46D1 File Offset: 0x003A28D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601908B RID: 102539 RVA: 0x003A46DE File Offset: 0x003A28DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601908C RID: 102540 RVA: 0x003A46E7 File Offset: 0x003A28E7
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

		// Token: 0x0601908D RID: 102541 RVA: 0x003A471C File Offset: 0x003A291C
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

		// Token: 0x0601908E RID: 102542 RVA: 0x003A475A File Offset: 0x003A295A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SneakFinishResponse other)
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

		// Token: 0x0601908F RID: 102543 RVA: 0x003A478B File Offset: 0x003A298B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019090 RID: 102544 RVA: 0x003A4794 File Offset: 0x003A2994
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

		// Token: 0x0400937E RID: 37758
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400937F RID: 37759
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04009380 RID: 37760
		private ErrorCode errorCode_;
	}
}
