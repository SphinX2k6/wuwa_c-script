using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004C4 RID: 1220
	[NetMessage(EMessageId.EquipTakeOnResponse)]
	public sealed class EquipTakeOnResponse : IMessage<EquipTakeOnResponse>, IMessage, IEquatable<EquipTakeOnResponse>, IDeepCloneable<EquipTakeOnResponse>, IBufferMessage
	{
		// Token: 0x06007452 RID: 29778 RVA: 0x0011D458 File Offset: 0x0011B658
		[NullableContext(1)]
		public static EquipTakeOnResponse Create()
		{
			return new EquipTakeOnResponse();
		}

		// Token: 0x17001685 RID: 5765
		// (get) Token: 0x06007453 RID: 29779 RVA: 0x0011D45F File Offset: 0x0011B65F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001686 RID: 5766
		// (get) Token: 0x06007454 RID: 29780 RVA: 0x0011D462 File Offset: 0x0011B662
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EquipTakeOnResponse.Descriptor;
			}
		}

		// Token: 0x06007455 RID: 29781 RVA: 0x0011D469 File Offset: 0x0011B669
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipTakeOnResponse()
		{
		}

		// Token: 0x06007456 RID: 29782 RVA: 0x0011D47C File Offset: 0x0011B67C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipTakeOnResponse(EquipTakeOnResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.dataList_ = other.dataList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007457 RID: 29783 RVA: 0x0011D4B2 File Offset: 0x0011B6B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipTakeOnResponse Clone()
		{
			return new EquipTakeOnResponse(this);
		}

		// Token: 0x17001687 RID: 5767
		// (get) Token: 0x06007458 RID: 29784 RVA: 0x0011D4BA File Offset: 0x0011B6BA
		// (set) Token: 0x06007459 RID: 29785 RVA: 0x0011D4C2 File Offset: 0x0011B6C2
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

		// Token: 0x17001688 RID: 5768
		// (get) Token: 0x0600745A RID: 29786 RVA: 0x0011D4CB File Offset: 0x0011B6CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleLoadEquipData> DataList
		{
			get
			{
				return this.dataList_;
			}
		}

		// Token: 0x0600745B RID: 29787 RVA: 0x0011D4D3 File Offset: 0x0011B6D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EquipTakeOnResponse);
		}

		// Token: 0x0600745C RID: 29788 RVA: 0x0011D4E4 File Offset: 0x0011B6E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EquipTakeOnResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.dataList_.Equals(other.dataList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600745D RID: 29789 RVA: 0x0011D534 File Offset: 0x0011B734
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

		// Token: 0x0600745E RID: 29790 RVA: 0x0011D587 File Offset: 0x0011B787
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600745F RID: 29791 RVA: 0x0011D594 File Offset: 0x0011B794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007460 RID: 29792 RVA: 0x0011D5A0 File Offset: 0x0011B7A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.dataList_.WriteTo(ref output, EquipTakeOnResponse._repeated_dataList_codec);
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

		// Token: 0x06007461 RID: 29793 RVA: 0x0011D5F0 File Offset: 0x0011B7F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.dataList_.CalculateSize(EquipTakeOnResponse._repeated_dataList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007462 RID: 29794 RVA: 0x0011D644 File Offset: 0x0011B844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EquipTakeOnResponse other)
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

		// Token: 0x06007463 RID: 29795 RVA: 0x0011D691 File Offset: 0x0011B891
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007464 RID: 29796 RVA: 0x0011D69C File Offset: 0x0011B89C
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
				if (num != 42U)
				{
					if (num != 112U)
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
					this.dataList_.AddEntriesFrom(ref input, EquipTakeOnResponse._repeated_dataList_codec);
				}
			}
		}

		// Token: 0x04003DB5 RID: 15797
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DB6 RID: 15798
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04003DB7 RID: 15799
		private ErrorCode errorCode_;

		// Token: 0x04003DB8 RID: 15800
		public const int DataListFieldNumber = 5;

		// Token: 0x04003DB9 RID: 15801
		private static readonly FieldCodec<RoleLoadEquipData> _repeated_dataList_codec = FieldCodec.ForMessage<RoleLoadEquipData>(42U, RoleLoadEquipData.Parser);

		// Token: 0x04003DBA RID: 15802
		private readonly RepeatedField<RoleLoadEquipData> dataList_ = new RepeatedField<RoleLoadEquipData>();
	}
}
