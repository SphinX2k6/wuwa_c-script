using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200038E RID: 910
	[NetMessage(EMessageId.DangoMonopolyDiceResponse)]
	public sealed class DangoMonopolyDiceResponse : IMessage<DangoMonopolyDiceResponse>, IMessage, IEquatable<DangoMonopolyDiceResponse>, IDeepCloneable<DangoMonopolyDiceResponse>, IBufferMessage
	{
		// Token: 0x06005A2E RID: 23086 RVA: 0x000DBCE9 File Offset: 0x000D9EE9
		[NullableContext(1)]
		public static DangoMonopolyDiceResponse Create()
		{
			return new DangoMonopolyDiceResponse();
		}

		// Token: 0x170010A6 RID: 4262
		// (get) Token: 0x06005A2F RID: 23087 RVA: 0x000DBCF0 File Offset: 0x000D9EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010A7 RID: 4263
		// (get) Token: 0x06005A30 RID: 23088 RVA: 0x000DBCF3 File Offset: 0x000D9EF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoMonopolyDiceResponse.Descriptor;
			}
		}

		// Token: 0x06005A31 RID: 23089 RVA: 0x000DBCFA File Offset: 0x000D9EFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyDiceResponse()
		{
		}

		// Token: 0x06005A32 RID: 23090 RVA: 0x000DBD10 File Offset: 0x000D9F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyDiceResponse(DangoMonopolyDiceResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.diceNum_ = other.diceNum_;
			this.propertyData_ = ((other.propertyData_ != null) ? other.propertyData_.Clone() : null);
			this.propertyIds_ = other.propertyIds_.Clone();
			this.moveGridNum_ = other.moveGridNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005A33 RID: 23091 RVA: 0x000DBD85 File Offset: 0x000D9F85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyDiceResponse Clone()
		{
			return new DangoMonopolyDiceResponse(this);
		}

		// Token: 0x170010A8 RID: 4264
		// (get) Token: 0x06005A34 RID: 23092 RVA: 0x000DBD8D File Offset: 0x000D9F8D
		// (set) Token: 0x06005A35 RID: 23093 RVA: 0x000DBD95 File Offset: 0x000D9F95
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

		// Token: 0x170010A9 RID: 4265
		// (get) Token: 0x06005A36 RID: 23094 RVA: 0x000DBD9E File Offset: 0x000D9F9E
		// (set) Token: 0x06005A37 RID: 23095 RVA: 0x000DBDA6 File Offset: 0x000D9FA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DiceNum
		{
			get
			{
				return this.diceNum_;
			}
			set
			{
				this.diceNum_ = value;
			}
		}

		// Token: 0x170010AA RID: 4266
		// (get) Token: 0x06005A38 RID: 23096 RVA: 0x000DBDAF File Offset: 0x000D9FAF
		// (set) Token: 0x06005A39 RID: 23097 RVA: 0x000DBDB7 File Offset: 0x000D9FB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyPropertyData PropertyData
		{
			get
			{
				return this.propertyData_;
			}
			set
			{
				this.propertyData_ = value;
			}
		}

		// Token: 0x170010AB RID: 4267
		// (get) Token: 0x06005A3A RID: 23098 RVA: 0x000DBDC0 File Offset: 0x000D9FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PropertyIds
		{
			get
			{
				return this.propertyIds_;
			}
		}

		// Token: 0x170010AC RID: 4268
		// (get) Token: 0x06005A3B RID: 23099 RVA: 0x000DBDC8 File Offset: 0x000D9FC8
		// (set) Token: 0x06005A3C RID: 23100 RVA: 0x000DBDD0 File Offset: 0x000D9FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MoveGridNum
		{
			get
			{
				return this.moveGridNum_;
			}
			set
			{
				this.moveGridNum_ = value;
			}
		}

		// Token: 0x06005A3D RID: 23101 RVA: 0x000DBDD9 File Offset: 0x000D9FD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoMonopolyDiceResponse);
		}

		// Token: 0x06005A3E RID: 23102 RVA: 0x000DBDE8 File Offset: 0x000D9FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoMonopolyDiceResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.DiceNum == other.DiceNum && object.Equals(this.PropertyData, other.PropertyData) && this.propertyIds_.Equals(other.propertyIds_) && this.MoveGridNum == other.MoveGridNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005A3F RID: 23103 RVA: 0x000DBE6C File Offset: 0x000DA06C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.DiceNum != 0)
			{
				num ^= this.DiceNum.GetHashCode();
			}
			if (this.propertyData_ != null)
			{
				num ^= this.PropertyData.GetHashCode();
			}
			num ^= this.propertyIds_.GetHashCode();
			if (this.MoveGridNum != 0)
			{
				num ^= this.MoveGridNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005A40 RID: 23104 RVA: 0x000DBF07 File Offset: 0x000DA107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005A41 RID: 23105 RVA: 0x000DBF14 File Offset: 0x000DA114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005A42 RID: 23106 RVA: 0x000DBF20 File Offset: 0x000DA120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DiceNum != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.DiceNum);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.propertyData_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.PropertyData);
			}
			if (this.MoveGridNum != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.MoveGridNum);
			}
			this.propertyIds_.WriteTo(ref output, DangoMonopolyDiceResponse._repeated_propertyIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005A43 RID: 23107 RVA: 0x000DBFC4 File Offset: 0x000DA1C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.DiceNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DiceNum);
			}
			if (this.propertyData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PropertyData);
			}
			num += this.propertyIds_.CalculateSize(DangoMonopolyDiceResponse._repeated_propertyIds_codec);
			if (this.MoveGridNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MoveGridNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005A44 RID: 23108 RVA: 0x000DC060 File Offset: 0x000DA260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoMonopolyDiceResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.DiceNum != 0)
			{
				this.DiceNum = other.DiceNum;
			}
			if (other.propertyData_ != null)
			{
				if (this.propertyData_ == null)
				{
					this.PropertyData = new DangoMonopolyPropertyData();
				}
				this.PropertyData.MergeFrom(other.PropertyData);
			}
			this.propertyIds_.Add(other.propertyIds_);
			if (other.MoveGridNum != 0)
			{
				this.MoveGridNum = other.MoveGridNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005A45 RID: 23109 RVA: 0x000DC101 File Offset: 0x000DA301
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005A46 RID: 23110 RVA: 0x000DC10C File Offset: 0x000DA30C
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
				if (num <= 58U)
				{
					if (num == 8U)
					{
						this.DiceNum = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 58U)
					{
						if (this.propertyData_ == null)
						{
							this.PropertyData = new DangoMonopolyPropertyData();
						}
						input.ReadMessage(this.PropertyData);
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.MoveGridNum = input.ReadInt32();
						continue;
					}
					if (num == 104U || num == 106U)
					{
						this.propertyIds_.AddEntriesFrom(ref input, DangoMonopolyDiceResponse._repeated_propertyIds_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040035F1 RID: 13809
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035F2 RID: 13810
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x040035F3 RID: 13811
		private ErrorCode errorCode_;

		// Token: 0x040035F4 RID: 13812
		public const int DiceNumFieldNumber = 1;

		// Token: 0x040035F5 RID: 13813
		private int diceNum_;

		// Token: 0x040035F6 RID: 13814
		public const int PropertyDataFieldNumber = 7;

		// Token: 0x040035F7 RID: 13815
		private DangoMonopolyPropertyData propertyData_;

		// Token: 0x040035F8 RID: 13816
		public const int PropertyIdsFieldNumber = 13;

		// Token: 0x040035F9 RID: 13817
		private static readonly FieldCodec<int> _repeated_propertyIds_codec = FieldCodec.ForInt32(106U);

		// Token: 0x040035FA RID: 13818
		private readonly RepeatedField<int> propertyIds_ = new RepeatedField<int>();

		// Token: 0x040035FB RID: 13819
		public const int MoveGridNumFieldNumber = 8;

		// Token: 0x040035FC RID: 13820
		private int moveGridNum_;
	}
}
