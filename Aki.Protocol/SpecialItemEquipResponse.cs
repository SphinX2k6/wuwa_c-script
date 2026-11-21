using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012D7 RID: 4823
	[NetMessage(EMessageId.SpecialItemEquipResponse)]
	public sealed class SpecialItemEquipResponse : IMessage<SpecialItemEquipResponse>, IMessage, IEquatable<SpecialItemEquipResponse>, IDeepCloneable<SpecialItemEquipResponse>, IBufferMessage
	{
		// Token: 0x06019BDC RID: 105436 RVA: 0x003C15C5 File Offset: 0x003BF7C5
		[NullableContext(1)]
		public static SpecialItemEquipResponse Create()
		{
			return new SpecialItemEquipResponse();
		}

		// Token: 0x1700572D RID: 22317
		// (get) Token: 0x06019BDD RID: 105437 RVA: 0x003C15CC File Offset: 0x003BF7CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700572E RID: 22318
		// (get) Token: 0x06019BDE RID: 105438 RVA: 0x003C15CF File Offset: 0x003BF7CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpecialItemEquipResponse.Descriptor;
			}
		}

		// Token: 0x06019BDF RID: 105439 RVA: 0x003C15D6 File Offset: 0x003BF7D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpecialItemEquipResponse()
		{
		}

		// Token: 0x06019BE0 RID: 105440 RVA: 0x003C15DE File Offset: 0x003BF7DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpecialItemEquipResponse(SpecialItemEquipResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019BE1 RID: 105441 RVA: 0x003C1603 File Offset: 0x003BF803
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpecialItemEquipResponse Clone()
		{
			return new SpecialItemEquipResponse(this);
		}

		// Token: 0x1700572F RID: 22319
		// (get) Token: 0x06019BE2 RID: 105442 RVA: 0x003C160B File Offset: 0x003BF80B
		// (set) Token: 0x06019BE3 RID: 105443 RVA: 0x003C1613 File Offset: 0x003BF813
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

		// Token: 0x06019BE4 RID: 105444 RVA: 0x003C161C File Offset: 0x003BF81C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpecialItemEquipResponse);
		}

		// Token: 0x06019BE5 RID: 105445 RVA: 0x003C162A File Offset: 0x003BF82A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpecialItemEquipResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019BE6 RID: 105446 RVA: 0x003C1658 File Offset: 0x003BF858
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

		// Token: 0x06019BE7 RID: 105447 RVA: 0x003C169D File Offset: 0x003BF89D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019BE8 RID: 105448 RVA: 0x003C16AA File Offset: 0x003BF8AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019BE9 RID: 105449 RVA: 0x003C16B3 File Offset: 0x003BF8B3
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

		// Token: 0x06019BEA RID: 105450 RVA: 0x003C16E8 File Offset: 0x003BF8E8
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

		// Token: 0x06019BEB RID: 105451 RVA: 0x003C1726 File Offset: 0x003BF926
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpecialItemEquipResponse other)
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

		// Token: 0x06019BEC RID: 105452 RVA: 0x003C1757 File Offset: 0x003BF957
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019BED RID: 105453 RVA: 0x003C1760 File Offset: 0x003BF960
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

		// Token: 0x040097FC RID: 38908
		private UnknownFieldSet _unknownFields;

		// Token: 0x040097FD RID: 38909
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x040097FE RID: 38910
		private ErrorCode errorCode_;
	}
}
