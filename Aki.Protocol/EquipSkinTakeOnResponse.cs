using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004BF RID: 1215
	[NetMessage(EMessageId.EquipSkinTakeOnResponse)]
	public sealed class EquipSkinTakeOnResponse : IMessage<EquipSkinTakeOnResponse>, IMessage, IEquatable<EquipSkinTakeOnResponse>, IDeepCloneable<EquipSkinTakeOnResponse>, IBufferMessage
	{
		// Token: 0x060073F6 RID: 29686 RVA: 0x0011C9E4 File Offset: 0x0011ABE4
		[NullableContext(1)]
		public static EquipSkinTakeOnResponse Create()
		{
			return new EquipSkinTakeOnResponse();
		}

		// Token: 0x17001675 RID: 5749
		// (get) Token: 0x060073F7 RID: 29687 RVA: 0x0011C9EB File Offset: 0x0011ABEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001676 RID: 5750
		// (get) Token: 0x060073F8 RID: 29688 RVA: 0x0011C9EE File Offset: 0x0011ABEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EquipSkinTakeOnResponse.Descriptor;
			}
		}

		// Token: 0x060073F9 RID: 29689 RVA: 0x0011C9F5 File Offset: 0x0011ABF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipSkinTakeOnResponse()
		{
		}

		// Token: 0x060073FA RID: 29690 RVA: 0x0011CA08 File Offset: 0x0011AC08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipSkinTakeOnResponse(EquipSkinTakeOnResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.dataList_ = other.dataList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060073FB RID: 29691 RVA: 0x0011CA3E File Offset: 0x0011AC3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipSkinTakeOnResponse Clone()
		{
			return new EquipSkinTakeOnResponse(this);
		}

		// Token: 0x17001677 RID: 5751
		// (get) Token: 0x060073FC RID: 29692 RVA: 0x0011CA46 File Offset: 0x0011AC46
		// (set) Token: 0x060073FD RID: 29693 RVA: 0x0011CA4E File Offset: 0x0011AC4E
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

		// Token: 0x17001678 RID: 5752
		// (get) Token: 0x060073FE RID: 29694 RVA: 0x0011CA57 File Offset: 0x0011AC57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleSkinEquipData> DataList
		{
			get
			{
				return this.dataList_;
			}
		}

		// Token: 0x060073FF RID: 29695 RVA: 0x0011CA5F File Offset: 0x0011AC5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EquipSkinTakeOnResponse);
		}

		// Token: 0x06007400 RID: 29696 RVA: 0x0011CA70 File Offset: 0x0011AC70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EquipSkinTakeOnResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.dataList_.Equals(other.dataList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007401 RID: 29697 RVA: 0x0011CAC0 File Offset: 0x0011ACC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.dataList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007402 RID: 29698 RVA: 0x0011CB13 File Offset: 0x0011AD13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007403 RID: 29699 RVA: 0x0011CB20 File Offset: 0x0011AD20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007404 RID: 29700 RVA: 0x0011CB2C File Offset: 0x0011AD2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.dataList_.WriteTo(ref output, EquipSkinTakeOnResponse._repeated_dataList_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007405 RID: 29701 RVA: 0x0011CB7C File Offset: 0x0011AD7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.dataList_.CalculateSize(EquipSkinTakeOnResponse._repeated_dataList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007406 RID: 29702 RVA: 0x0011CBD0 File Offset: 0x0011ADD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EquipSkinTakeOnResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.dataList_.Add(other.dataList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007407 RID: 29703 RVA: 0x0011CC1D File Offset: 0x0011AE1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007408 RID: 29704 RVA: 0x0011CC28 File Offset: 0x0011AE28
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
				if (num != 82U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.dataList_.AddEntriesFrom(ref input, EquipSkinTakeOnResponse._repeated_dataList_codec);
				}
			}
		}

		// Token: 0x04003DA2 RID: 15778
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DA3 RID: 15779
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04003DA4 RID: 15780
		private ErrorCode errorCode_;

		// Token: 0x04003DA5 RID: 15781
		public const int DataListFieldNumber = 10;

		// Token: 0x04003DA6 RID: 15782
		private static readonly FieldCodec<RoleSkinEquipData> _repeated_dataList_codec = FieldCodec.ForMessage<RoleSkinEquipData>(82U, RoleSkinEquipData.Parser);

		// Token: 0x04003DA7 RID: 15783
		private readonly RepeatedField<RoleSkinEquipData> dataList_ = new RepeatedField<RoleSkinEquipData>();
	}
}
