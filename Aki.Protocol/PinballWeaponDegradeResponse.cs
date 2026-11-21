using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D5D RID: 3421
	[NetMessage(EMessageId.PinballWeaponDegradeResponse)]
	public sealed class PinballWeaponDegradeResponse : IMessage<PinballWeaponDegradeResponse>, IMessage, IEquatable<PinballWeaponDegradeResponse>, IDeepCloneable<PinballWeaponDegradeResponse>, IBufferMessage
	{
		// Token: 0x06012784 RID: 75652 RVA: 0x002B2511 File Offset: 0x002B0711
		[NullableContext(1)]
		public static PinballWeaponDegradeResponse Create()
		{
			return new PinballWeaponDegradeResponse();
		}

		// Token: 0x17003D38 RID: 15672
		// (get) Token: 0x06012785 RID: 75653 RVA: 0x002B2518 File Offset: 0x002B0718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D39 RID: 15673
		// (get) Token: 0x06012786 RID: 75654 RVA: 0x002B251B File Offset: 0x002B071B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballWeaponDegradeResponse.Descriptor;
			}
		}

		// Token: 0x06012787 RID: 75655 RVA: 0x002B2522 File Offset: 0x002B0722
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballWeaponDegradeResponse()
		{
		}

		// Token: 0x06012788 RID: 75656 RVA: 0x002B252A File Offset: 0x002B072A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballWeaponDegradeResponse(PinballWeaponDegradeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012789 RID: 75657 RVA: 0x002B254F File Offset: 0x002B074F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballWeaponDegradeResponse Clone()
		{
			return new PinballWeaponDegradeResponse(this);
		}

		// Token: 0x17003D3A RID: 15674
		// (get) Token: 0x0601278A RID: 75658 RVA: 0x002B2557 File Offset: 0x002B0757
		// (set) Token: 0x0601278B RID: 75659 RVA: 0x002B255F File Offset: 0x002B075F
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

		// Token: 0x0601278C RID: 75660 RVA: 0x002B2568 File Offset: 0x002B0768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballWeaponDegradeResponse);
		}

		// Token: 0x0601278D RID: 75661 RVA: 0x002B2576 File Offset: 0x002B0776
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballWeaponDegradeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601278E RID: 75662 RVA: 0x002B25A4 File Offset: 0x002B07A4
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

		// Token: 0x0601278F RID: 75663 RVA: 0x002B25E9 File Offset: 0x002B07E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012790 RID: 75664 RVA: 0x002B25F6 File Offset: 0x002B07F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012791 RID: 75665 RVA: 0x002B25FF File Offset: 0x002B07FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012792 RID: 75666 RVA: 0x002B2634 File Offset: 0x002B0834
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

		// Token: 0x06012793 RID: 75667 RVA: 0x002B2672 File Offset: 0x002B0872
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballWeaponDegradeResponse other)
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

		// Token: 0x06012794 RID: 75668 RVA: 0x002B26A3 File Offset: 0x002B08A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012795 RID: 75669 RVA: 0x002B26AC File Offset: 0x002B08AC
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400733B RID: 29499
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400733C RID: 29500
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x0400733D RID: 29501
		private ErrorCode errorCode_;
	}
}
