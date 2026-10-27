using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004DB RID: 1243
	[NetMessage(EMessageId.EquipTakeOnResponse)]
	public sealed class EquipTakeOnResponse : IMessage<EquipTakeOnResponse>, IMessage, IEquatable<EquipTakeOnResponse>, IDeepCloneable<EquipTakeOnResponse>, IBufferMessage
	{
		// Token: 0x060075E2 RID: 30178 RVA: 0x00120570 File Offset: 0x0011E770
		[NullableContext(1)]
		public static EquipTakeOnResponse Create()
		{
			return new EquipTakeOnResponse();
		}

		// Token: 0x170016DA RID: 5850
		// (get) Token: 0x060075E3 RID: 30179 RVA: 0x00120577 File Offset: 0x0011E777
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016DB RID: 5851
		// (get) Token: 0x060075E4 RID: 30180 RVA: 0x0012057A File Offset: 0x0011E77A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EquipTakeOnResponse.Descriptor;
			}
		}

		// Token: 0x060075E5 RID: 30181 RVA: 0x00120581 File Offset: 0x0011E781
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipTakeOnResponse()
		{
		}

		// Token: 0x060075E6 RID: 30182 RVA: 0x00120594 File Offset: 0x0011E794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipTakeOnResponse(EquipTakeOnResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.dataList_ = other.dataList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060075E7 RID: 30183 RVA: 0x001205CA File Offset: 0x0011E7CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipTakeOnResponse Clone()
		{
			return new EquipTakeOnResponse(this);
		}

		// Token: 0x170016DC RID: 5852
		// (get) Token: 0x060075E8 RID: 30184 RVA: 0x001205D2 File Offset: 0x0011E7D2
		// (set) Token: 0x060075E9 RID: 30185 RVA: 0x001205DA File Offset: 0x0011E7DA
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

		// Token: 0x170016DD RID: 5853
		// (get) Token: 0x060075EA RID: 30186 RVA: 0x001205E3 File Offset: 0x0011E7E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleLoadEquipData> DataList
		{
			get
			{
				return this.dataList_;
			}
		}

		// Token: 0x060075EB RID: 30187 RVA: 0x001205EB File Offset: 0x0011E7EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EquipTakeOnResponse);
		}

		// Token: 0x060075EC RID: 30188 RVA: 0x001205FC File Offset: 0x0011E7FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EquipTakeOnResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.dataList_.Equals(other.dataList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060075ED RID: 30189 RVA: 0x0012064C File Offset: 0x0011E84C
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

		// Token: 0x060075EE RID: 30190 RVA: 0x0012069F File Offset: 0x0011E89F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060075EF RID: 30191 RVA: 0x001206AC File Offset: 0x0011E8AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060075F0 RID: 30192 RVA: 0x001206B8 File Offset: 0x0011E8B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.dataList_.WriteTo(ref output, EquipTakeOnResponse._repeated_dataList_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060075F1 RID: 30193 RVA: 0x00120708 File Offset: 0x0011E908
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

		// Token: 0x060075F2 RID: 30194 RVA: 0x0012075C File Offset: 0x0011E95C
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

		// Token: 0x060075F3 RID: 30195 RVA: 0x001207A9 File Offset: 0x0011E9A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060075F4 RID: 30196 RVA: 0x001207B4 File Offset: 0x0011E9B4
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
				if (num != 10U)
				{
					if (num != 16U)
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

		// Token: 0x04003DC9 RID: 15817
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DCA RID: 15818
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04003DCB RID: 15819
		private ErrorCode errorCode_;

		// Token: 0x04003DCC RID: 15820
		public const int DataListFieldNumber = 1;

		// Token: 0x04003DCD RID: 15821
		private static readonly FieldCodec<RoleLoadEquipData> _repeated_dataList_codec = FieldCodec.ForMessage<RoleLoadEquipData>(10U, RoleLoadEquipData.Parser);

		// Token: 0x04003DCE RID: 15822
		private readonly RepeatedField<RoleLoadEquipData> dataList_ = new RepeatedField<RoleLoadEquipData>();
	}
}
