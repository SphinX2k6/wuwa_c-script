using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001268 RID: 4712
	[NetMessage(EMessageId.SpecialItemEquipResponse)]
	public sealed class SpecialItemEquipResponse : IMessage<SpecialItemEquipResponse>, IMessage, IEquatable<SpecialItemEquipResponse>, IDeepCloneable<SpecialItemEquipResponse>, IBufferMessage
	{
		// Token: 0x060191A6 RID: 102822 RVA: 0x003A6E81 File Offset: 0x003A5081
		[NullableContext(1)]
		public static SpecialItemEquipResponse Create()
		{
			return new SpecialItemEquipResponse();
		}

		// Token: 0x170054AC RID: 21676
		// (get) Token: 0x060191A7 RID: 102823 RVA: 0x003A6E88 File Offset: 0x003A5088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170054AD RID: 21677
		// (get) Token: 0x060191A8 RID: 102824 RVA: 0x003A6E8B File Offset: 0x003A508B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpecialItemEquipResponse.Descriptor;
			}
		}

		// Token: 0x060191A9 RID: 102825 RVA: 0x003A6E92 File Offset: 0x003A5092
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpecialItemEquipResponse()
		{
		}

		// Token: 0x060191AA RID: 102826 RVA: 0x003A6E9A File Offset: 0x003A509A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpecialItemEquipResponse(SpecialItemEquipResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060191AB RID: 102827 RVA: 0x003A6EBF File Offset: 0x003A50BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpecialItemEquipResponse Clone()
		{
			return new SpecialItemEquipResponse(this);
		}

		// Token: 0x170054AE RID: 21678
		// (get) Token: 0x060191AC RID: 102828 RVA: 0x003A6EC7 File Offset: 0x003A50C7
		// (set) Token: 0x060191AD RID: 102829 RVA: 0x003A6ECF File Offset: 0x003A50CF
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

		// Token: 0x060191AE RID: 102830 RVA: 0x003A6ED8 File Offset: 0x003A50D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpecialItemEquipResponse);
		}

		// Token: 0x060191AF RID: 102831 RVA: 0x003A6EE6 File Offset: 0x003A50E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpecialItemEquipResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060191B0 RID: 102832 RVA: 0x003A6F14 File Offset: 0x003A5114
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

		// Token: 0x060191B1 RID: 102833 RVA: 0x003A6F59 File Offset: 0x003A5159
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060191B2 RID: 102834 RVA: 0x003A6F66 File Offset: 0x003A5166
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060191B3 RID: 102835 RVA: 0x003A6F6F File Offset: 0x003A516F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060191B4 RID: 102836 RVA: 0x003A6FA4 File Offset: 0x003A51A4
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

		// Token: 0x060191B5 RID: 102837 RVA: 0x003A6FE2 File Offset: 0x003A51E2
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

		// Token: 0x060191B6 RID: 102838 RVA: 0x003A7013 File Offset: 0x003A5213
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060191B7 RID: 102839 RVA: 0x003A701C File Offset: 0x003A521C
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040093D2 RID: 37842
		private UnknownFieldSet _unknownFields;

		// Token: 0x040093D3 RID: 37843
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x040093D4 RID: 37844
		private ErrorCode errorCode_;
	}
}
