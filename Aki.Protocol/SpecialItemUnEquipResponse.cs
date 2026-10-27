using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200126B RID: 4715
	[NetMessage(EMessageId.SpecialItemUnEquipResponse)]
	public sealed class SpecialItemUnEquipResponse : IMessage<SpecialItemUnEquipResponse>, IMessage, IEquatable<SpecialItemUnEquipResponse>, IDeepCloneable<SpecialItemUnEquipResponse>, IBufferMessage
	{
		// Token: 0x060191DA RID: 102874 RVA: 0x003A7372 File Offset: 0x003A5572
		[NullableContext(1)]
		public static SpecialItemUnEquipResponse Create()
		{
			return new SpecialItemUnEquipResponse();
		}

		// Token: 0x170054B4 RID: 21684
		// (get) Token: 0x060191DB RID: 102875 RVA: 0x003A7379 File Offset: 0x003A5579
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170054B5 RID: 21685
		// (get) Token: 0x060191DC RID: 102876 RVA: 0x003A737C File Offset: 0x003A557C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpecialItemUnEquipResponse.Descriptor;
			}
		}

		// Token: 0x060191DD RID: 102877 RVA: 0x003A7383 File Offset: 0x003A5583
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpecialItemUnEquipResponse()
		{
		}

		// Token: 0x060191DE RID: 102878 RVA: 0x003A738B File Offset: 0x003A558B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpecialItemUnEquipResponse(SpecialItemUnEquipResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060191DF RID: 102879 RVA: 0x003A73B0 File Offset: 0x003A55B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpecialItemUnEquipResponse Clone()
		{
			return new SpecialItemUnEquipResponse(this);
		}

		// Token: 0x170054B6 RID: 21686
		// (get) Token: 0x060191E0 RID: 102880 RVA: 0x003A73B8 File Offset: 0x003A55B8
		// (set) Token: 0x060191E1 RID: 102881 RVA: 0x003A73C0 File Offset: 0x003A55C0
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

		// Token: 0x060191E2 RID: 102882 RVA: 0x003A73C9 File Offset: 0x003A55C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpecialItemUnEquipResponse);
		}

		// Token: 0x060191E3 RID: 102883 RVA: 0x003A73D7 File Offset: 0x003A55D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpecialItemUnEquipResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060191E4 RID: 102884 RVA: 0x003A7408 File Offset: 0x003A5608
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

		// Token: 0x060191E5 RID: 102885 RVA: 0x003A744D File Offset: 0x003A564D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060191E6 RID: 102886 RVA: 0x003A745A File Offset: 0x003A565A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060191E7 RID: 102887 RVA: 0x003A7463 File Offset: 0x003A5663
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

		// Token: 0x060191E8 RID: 102888 RVA: 0x003A7498 File Offset: 0x003A5698
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

		// Token: 0x060191E9 RID: 102889 RVA: 0x003A74D6 File Offset: 0x003A56D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpecialItemUnEquipResponse other)
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

		// Token: 0x060191EA RID: 102890 RVA: 0x003A7507 File Offset: 0x003A5707
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060191EB RID: 102891 RVA: 0x003A7510 File Offset: 0x003A5710
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

		// Token: 0x040093D9 RID: 37849
		private UnknownFieldSet _unknownFields;

		// Token: 0x040093DA RID: 37850
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x040093DB RID: 37851
		private ErrorCode errorCode_;
	}
}
