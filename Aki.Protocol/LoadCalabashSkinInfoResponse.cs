using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200092A RID: 2346
	[NetMessage(EMessageId.LoadCalabashSkinInfoResponse)]
	public sealed class LoadCalabashSkinInfoResponse : IMessage<LoadCalabashSkinInfoResponse>, IMessage, IEquatable<LoadCalabashSkinInfoResponse>, IDeepCloneable<LoadCalabashSkinInfoResponse>, IBufferMessage
	{
		// Token: 0x0600CF1E RID: 53022 RVA: 0x001E81E2 File Offset: 0x001E63E2
		[NullableContext(1)]
		public static LoadCalabashSkinInfoResponse Create()
		{
			return new LoadCalabashSkinInfoResponse();
		}

		// Token: 0x170029D2 RID: 10706
		// (get) Token: 0x0600CF1F RID: 53023 RVA: 0x001E81E9 File Offset: 0x001E63E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029D3 RID: 10707
		// (get) Token: 0x0600CF20 RID: 53024 RVA: 0x001E81EC File Offset: 0x001E63EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LoadCalabashSkinInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600CF21 RID: 53025 RVA: 0x001E81F3 File Offset: 0x001E63F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoadCalabashSkinInfoResponse()
		{
		}

		// Token: 0x0600CF22 RID: 53026 RVA: 0x001E8208 File Offset: 0x001E6408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoadCalabashSkinInfoResponse(LoadCalabashSkinInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.equipSkinId_ = other.equipSkinId_;
			this.skinItemIds_ = other.skinItemIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CF23 RID: 53027 RVA: 0x001E8255 File Offset: 0x001E6455
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoadCalabashSkinInfoResponse Clone()
		{
			return new LoadCalabashSkinInfoResponse(this);
		}

		// Token: 0x170029D4 RID: 10708
		// (get) Token: 0x0600CF24 RID: 53028 RVA: 0x001E825D File Offset: 0x001E645D
		// (set) Token: 0x0600CF25 RID: 53029 RVA: 0x001E8265 File Offset: 0x001E6465
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

		// Token: 0x170029D5 RID: 10709
		// (get) Token: 0x0600CF26 RID: 53030 RVA: 0x001E826E File Offset: 0x001E646E
		// (set) Token: 0x0600CF27 RID: 53031 RVA: 0x001E8276 File Offset: 0x001E6476
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EquipSkinId
		{
			get
			{
				return this.equipSkinId_;
			}
			set
			{
				this.equipSkinId_ = value;
			}
		}

		// Token: 0x170029D6 RID: 10710
		// (get) Token: 0x0600CF28 RID: 53032 RVA: 0x001E827F File Offset: 0x001E647F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkinItemIds
		{
			get
			{
				return this.skinItemIds_;
			}
		}

		// Token: 0x0600CF29 RID: 53033 RVA: 0x001E8287 File Offset: 0x001E6487
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LoadCalabashSkinInfoResponse);
		}

		// Token: 0x0600CF2A RID: 53034 RVA: 0x001E8298 File Offset: 0x001E6498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LoadCalabashSkinInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.EquipSkinId == other.EquipSkinId && this.skinItemIds_.Equals(other.skinItemIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CF2B RID: 53035 RVA: 0x001E82F8 File Offset: 0x001E64F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.EquipSkinId != 0)
			{
				num ^= this.EquipSkinId.GetHashCode();
			}
			num ^= this.skinItemIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CF2C RID: 53036 RVA: 0x001E8364 File Offset: 0x001E6564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CF2D RID: 53037 RVA: 0x001E8371 File Offset: 0x001E6571
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CF2E RID: 53038 RVA: 0x001E837C File Offset: 0x001E657C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.skinItemIds_.WriteTo(ref output, LoadCalabashSkinInfoResponse._repeated_skinItemIds_codec);
			if (this.EquipSkinId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.EquipSkinId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CF2F RID: 53039 RVA: 0x001E83E8 File Offset: 0x001E65E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.EquipSkinId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EquipSkinId);
			}
			num += this.skinItemIds_.CalculateSize(LoadCalabashSkinInfoResponse._repeated_skinItemIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CF30 RID: 53040 RVA: 0x001E8454 File Offset: 0x001E6654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LoadCalabashSkinInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.EquipSkinId != 0)
			{
				this.EquipSkinId = other.EquipSkinId;
			}
			this.skinItemIds_.Add(other.skinItemIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CF31 RID: 53041 RVA: 0x001E84B5 File Offset: 0x001E66B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CF32 RID: 53042 RVA: 0x001E84C0 File Offset: 0x001E66C0
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
				if (num <= 72U)
				{
					if (num == 32U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 72U)
					{
						goto IL_46;
					}
				}
				else
				{
					if (num == 74U)
					{
						goto IL_46;
					}
					if (num == 80U)
					{
						this.EquipSkinId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_46:
				this.skinItemIds_.AddEntriesFrom(ref input, LoadCalabashSkinInfoResponse._repeated_skinItemIds_codec);
			}
		}

		// Token: 0x040057C2 RID: 22466
		private UnknownFieldSet _unknownFields;

		// Token: 0x040057C3 RID: 22467
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x040057C4 RID: 22468
		private ErrorCode errorCode_;

		// Token: 0x040057C5 RID: 22469
		public const int EquipSkinIdFieldNumber = 10;

		// Token: 0x040057C6 RID: 22470
		private int equipSkinId_;

		// Token: 0x040057C7 RID: 22471
		public const int SkinItemIdsFieldNumber = 9;

		// Token: 0x040057C8 RID: 22472
		private static readonly FieldCodec<int> _repeated_skinItemIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x040057C9 RID: 22473
		private readonly RepeatedField<int> skinItemIds_ = new RepeatedField<int>();
	}
}
