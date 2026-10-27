using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004D8 RID: 1240
	[NetMessage(EMessageId.EquipSkinUnLoadResponse)]
	public sealed class EquipSkinUnLoadResponse : IMessage<EquipSkinUnLoadResponse>, IMessage, IEquatable<EquipSkinUnLoadResponse>, IDeepCloneable<EquipSkinUnLoadResponse>, IBufferMessage
	{
		// Token: 0x060075AC RID: 30124 RVA: 0x0011FF89 File Offset: 0x0011E189
		[NullableContext(1)]
		public static EquipSkinUnLoadResponse Create()
		{
			return new EquipSkinUnLoadResponse();
		}

		// Token: 0x170016D1 RID: 5841
		// (get) Token: 0x060075AD RID: 30125 RVA: 0x0011FF90 File Offset: 0x0011E190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016D2 RID: 5842
		// (get) Token: 0x060075AE RID: 30126 RVA: 0x0011FF93 File Offset: 0x0011E193
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EquipSkinUnLoadResponse.Descriptor;
			}
		}

		// Token: 0x060075AF RID: 30127 RVA: 0x0011FF9A File Offset: 0x0011E19A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipSkinUnLoadResponse()
		{
		}

		// Token: 0x060075B0 RID: 30128 RVA: 0x0011FFA2 File Offset: 0x0011E1A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipSkinUnLoadResponse(EquipSkinUnLoadResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060075B1 RID: 30129 RVA: 0x0011FFC7 File Offset: 0x0011E1C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipSkinUnLoadResponse Clone()
		{
			return new EquipSkinUnLoadResponse(this);
		}

		// Token: 0x170016D3 RID: 5843
		// (get) Token: 0x060075B2 RID: 30130 RVA: 0x0011FFCF File Offset: 0x0011E1CF
		// (set) Token: 0x060075B3 RID: 30131 RVA: 0x0011FFD7 File Offset: 0x0011E1D7
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

		// Token: 0x060075B4 RID: 30132 RVA: 0x0011FFE0 File Offset: 0x0011E1E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EquipSkinUnLoadResponse);
		}

		// Token: 0x060075B5 RID: 30133 RVA: 0x0011FFEE File Offset: 0x0011E1EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EquipSkinUnLoadResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060075B6 RID: 30134 RVA: 0x0012001C File Offset: 0x0011E21C
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

		// Token: 0x060075B7 RID: 30135 RVA: 0x00120061 File Offset: 0x0011E261
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060075B8 RID: 30136 RVA: 0x0012006E File Offset: 0x0011E26E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060075B9 RID: 30137 RVA: 0x00120077 File Offset: 0x0011E277
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060075BA RID: 30138 RVA: 0x001200AC File Offset: 0x0011E2AC
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

		// Token: 0x060075BB RID: 30139 RVA: 0x001200EA File Offset: 0x0011E2EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EquipSkinUnLoadResponse other)
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

		// Token: 0x060075BC RID: 30140 RVA: 0x0012011B File Offset: 0x0011E31B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060075BD RID: 30141 RVA: 0x00120124 File Offset: 0x0011E324
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003DBF RID: 15807
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DC0 RID: 15808
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04003DC1 RID: 15809
		private ErrorCode errorCode_;
	}
}
