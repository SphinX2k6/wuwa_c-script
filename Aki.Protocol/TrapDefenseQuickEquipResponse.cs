using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014AC RID: 5292
	[NetMessage(EMessageId.TrapDefenseQuickEquipResponse)]
	public sealed class TrapDefenseQuickEquipResponse : IMessage<TrapDefenseQuickEquipResponse>, IMessage, IEquatable<TrapDefenseQuickEquipResponse>, IDeepCloneable<TrapDefenseQuickEquipResponse>, IBufferMessage
	{
		// Token: 0x0601C157 RID: 115031 RVA: 0x00413B66 File Offset: 0x00411D66
		[NullableContext(1)]
		public static TrapDefenseQuickEquipResponse Create()
		{
			return new TrapDefenseQuickEquipResponse();
		}

		// Token: 0x17005F0E RID: 24334
		// (get) Token: 0x0601C158 RID: 115032 RVA: 0x00413B6D File Offset: 0x00411D6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F0F RID: 24335
		// (get) Token: 0x0601C159 RID: 115033 RVA: 0x00413B70 File Offset: 0x00411D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseQuickEquipResponse.Descriptor;
			}
		}

		// Token: 0x0601C15A RID: 115034 RVA: 0x00413B77 File Offset: 0x00411D77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseQuickEquipResponse()
		{
		}

		// Token: 0x0601C15B RID: 115035 RVA: 0x00413B7F File Offset: 0x00411D7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseQuickEquipResponse(TrapDefenseQuickEquipResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C15C RID: 115036 RVA: 0x00413BA4 File Offset: 0x00411DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseQuickEquipResponse Clone()
		{
			return new TrapDefenseQuickEquipResponse(this);
		}

		// Token: 0x17005F10 RID: 24336
		// (get) Token: 0x0601C15D RID: 115037 RVA: 0x00413BAC File Offset: 0x00411DAC
		// (set) Token: 0x0601C15E RID: 115038 RVA: 0x00413BB4 File Offset: 0x00411DB4
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

		// Token: 0x0601C15F RID: 115039 RVA: 0x00413BBD File Offset: 0x00411DBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseQuickEquipResponse);
		}

		// Token: 0x0601C160 RID: 115040 RVA: 0x00413BCB File Offset: 0x00411DCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseQuickEquipResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C161 RID: 115041 RVA: 0x00413BFC File Offset: 0x00411DFC
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

		// Token: 0x0601C162 RID: 115042 RVA: 0x00413C41 File Offset: 0x00411E41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C163 RID: 115043 RVA: 0x00413C4E File Offset: 0x00411E4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C164 RID: 115044 RVA: 0x00413C57 File Offset: 0x00411E57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C165 RID: 115045 RVA: 0x00413C8C File Offset: 0x00411E8C
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

		// Token: 0x0601C166 RID: 115046 RVA: 0x00413CCA File Offset: 0x00411ECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseQuickEquipResponse other)
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

		// Token: 0x0601C167 RID: 115047 RVA: 0x00413CFB File Offset: 0x00411EFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C168 RID: 115048 RVA: 0x00413D04 File Offset: 0x00411F04
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A28D RID: 41613
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A28E RID: 41614
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x0400A28F RID: 41615
		private ErrorCode errorCode_;
	}
}
