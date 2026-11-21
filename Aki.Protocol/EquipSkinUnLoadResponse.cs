using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004C1 RID: 1217
	[NetMessage(EMessageId.EquipSkinUnLoadResponse)]
	public sealed class EquipSkinUnLoadResponse : IMessage<EquipSkinUnLoadResponse>, IMessage, IEquatable<EquipSkinUnLoadResponse>, IDeepCloneable<EquipSkinUnLoadResponse>, IBufferMessage
	{
		// Token: 0x0600741C RID: 29724 RVA: 0x0011CE71 File Offset: 0x0011B071
		[NullableContext(1)]
		public static EquipSkinUnLoadResponse Create()
		{
			return new EquipSkinUnLoadResponse();
		}

		// Token: 0x1700167C RID: 5756
		// (get) Token: 0x0600741D RID: 29725 RVA: 0x0011CE78 File Offset: 0x0011B078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700167D RID: 5757
		// (get) Token: 0x0600741E RID: 29726 RVA: 0x0011CE7B File Offset: 0x0011B07B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EquipSkinUnLoadResponse.Descriptor;
			}
		}

		// Token: 0x0600741F RID: 29727 RVA: 0x0011CE82 File Offset: 0x0011B082
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipSkinUnLoadResponse()
		{
		}

		// Token: 0x06007420 RID: 29728 RVA: 0x0011CE8A File Offset: 0x0011B08A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipSkinUnLoadResponse(EquipSkinUnLoadResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007421 RID: 29729 RVA: 0x0011CEAF File Offset: 0x0011B0AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipSkinUnLoadResponse Clone()
		{
			return new EquipSkinUnLoadResponse(this);
		}

		// Token: 0x1700167E RID: 5758
		// (get) Token: 0x06007422 RID: 29730 RVA: 0x0011CEB7 File Offset: 0x0011B0B7
		// (set) Token: 0x06007423 RID: 29731 RVA: 0x0011CEBF File Offset: 0x0011B0BF
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

		// Token: 0x06007424 RID: 29732 RVA: 0x0011CEC8 File Offset: 0x0011B0C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EquipSkinUnLoadResponse);
		}

		// Token: 0x06007425 RID: 29733 RVA: 0x0011CED6 File Offset: 0x0011B0D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EquipSkinUnLoadResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007426 RID: 29734 RVA: 0x0011CF04 File Offset: 0x0011B104
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

		// Token: 0x06007427 RID: 29735 RVA: 0x0011CF49 File Offset: 0x0011B149
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007428 RID: 29736 RVA: 0x0011CF56 File Offset: 0x0011B156
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007429 RID: 29737 RVA: 0x0011CF5F File Offset: 0x0011B15F
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

		// Token: 0x0600742A RID: 29738 RVA: 0x0011CF94 File Offset: 0x0011B194
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

		// Token: 0x0600742B RID: 29739 RVA: 0x0011CFD2 File Offset: 0x0011B1D2
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

		// Token: 0x0600742C RID: 29740 RVA: 0x0011D003 File Offset: 0x0011B203
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600742D RID: 29741 RVA: 0x0011D00C File Offset: 0x0011B20C
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

		// Token: 0x04003DAB RID: 15787
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DAC RID: 15788
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04003DAD RID: 15789
		private ErrorCode errorCode_;
	}
}
