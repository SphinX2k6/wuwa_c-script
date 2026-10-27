using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004D6 RID: 1238
	[NetMessage(EMessageId.EquipSkinTakeOnResponse)]
	public sealed class EquipSkinTakeOnResponse : IMessage<EquipSkinTakeOnResponse>, IMessage, IEquatable<EquipSkinTakeOnResponse>, IDeepCloneable<EquipSkinTakeOnResponse>, IBufferMessage
	{
		// Token: 0x06007586 RID: 30086 RVA: 0x0011FAFC File Offset: 0x0011DCFC
		[NullableContext(1)]
		public static EquipSkinTakeOnResponse Create()
		{
			return new EquipSkinTakeOnResponse();
		}

		// Token: 0x170016CA RID: 5834
		// (get) Token: 0x06007587 RID: 30087 RVA: 0x0011FB03 File Offset: 0x0011DD03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016CB RID: 5835
		// (get) Token: 0x06007588 RID: 30088 RVA: 0x0011FB06 File Offset: 0x0011DD06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EquipSkinTakeOnResponse.Descriptor;
			}
		}

		// Token: 0x06007589 RID: 30089 RVA: 0x0011FB0D File Offset: 0x0011DD0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipSkinTakeOnResponse()
		{
		}

		// Token: 0x0600758A RID: 30090 RVA: 0x0011FB20 File Offset: 0x0011DD20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipSkinTakeOnResponse(EquipSkinTakeOnResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.dataList_ = other.dataList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600758B RID: 30091 RVA: 0x0011FB56 File Offset: 0x0011DD56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipSkinTakeOnResponse Clone()
		{
			return new EquipSkinTakeOnResponse(this);
		}

		// Token: 0x170016CC RID: 5836
		// (get) Token: 0x0600758C RID: 30092 RVA: 0x0011FB5E File Offset: 0x0011DD5E
		// (set) Token: 0x0600758D RID: 30093 RVA: 0x0011FB66 File Offset: 0x0011DD66
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

		// Token: 0x170016CD RID: 5837
		// (get) Token: 0x0600758E RID: 30094 RVA: 0x0011FB6F File Offset: 0x0011DD6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleSkinEquipData> DataList
		{
			get
			{
				return this.dataList_;
			}
		}

		// Token: 0x0600758F RID: 30095 RVA: 0x0011FB77 File Offset: 0x0011DD77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EquipSkinTakeOnResponse);
		}

		// Token: 0x06007590 RID: 30096 RVA: 0x0011FB88 File Offset: 0x0011DD88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EquipSkinTakeOnResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.dataList_.Equals(other.dataList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007591 RID: 30097 RVA: 0x0011FBD8 File Offset: 0x0011DDD8
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

		// Token: 0x06007592 RID: 30098 RVA: 0x0011FC2B File Offset: 0x0011DE2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007593 RID: 30099 RVA: 0x0011FC38 File Offset: 0x0011DE38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007594 RID: 30100 RVA: 0x0011FC44 File Offset: 0x0011DE44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.dataList_.WriteTo(ref output, EquipSkinTakeOnResponse._repeated_dataList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007595 RID: 30101 RVA: 0x0011FC94 File Offset: 0x0011DE94
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

		// Token: 0x06007596 RID: 30102 RVA: 0x0011FCE8 File Offset: 0x0011DEE8
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

		// Token: 0x06007597 RID: 30103 RVA: 0x0011FD35 File Offset: 0x0011DF35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007598 RID: 30104 RVA: 0x0011FD40 File Offset: 0x0011DF40
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
				if (num != 72U)
				{
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.dataList_.AddEntriesFrom(ref input, EquipSkinTakeOnResponse._repeated_dataList_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003DB6 RID: 15798
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DB7 RID: 15799
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04003DB8 RID: 15800
		private ErrorCode errorCode_;

		// Token: 0x04003DB9 RID: 15801
		public const int DataListFieldNumber = 10;

		// Token: 0x04003DBA RID: 15802
		private static readonly FieldCodec<RoleSkinEquipData> _repeated_dataList_codec = FieldCodec.ForMessage<RoleSkinEquipData>(82U, RoleSkinEquipData.Parser);

		// Token: 0x04003DBB RID: 15803
		private readonly RepeatedField<RoleSkinEquipData> dataList_ = new RepeatedField<RoleSkinEquipData>();
	}
}
