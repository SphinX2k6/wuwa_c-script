using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200093B RID: 2363
	[NetMessage(EMessageId.LoadCalabashSkinInfoResponse)]
	public sealed class LoadCalabashSkinInfoResponse : IMessage<LoadCalabashSkinInfoResponse>, IMessage, IEquatable<LoadCalabashSkinInfoResponse>, IDeepCloneable<LoadCalabashSkinInfoResponse>, IBufferMessage
	{
		// Token: 0x0600D03A RID: 53306 RVA: 0x001EA4B6 File Offset: 0x001E86B6
		[NullableContext(1)]
		public static LoadCalabashSkinInfoResponse Create()
		{
			return new LoadCalabashSkinInfoResponse();
		}

		// Token: 0x17002A11 RID: 10769
		// (get) Token: 0x0600D03B RID: 53307 RVA: 0x001EA4BD File Offset: 0x001E86BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A12 RID: 10770
		// (get) Token: 0x0600D03C RID: 53308 RVA: 0x001EA4C0 File Offset: 0x001E86C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LoadCalabashSkinInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600D03D RID: 53309 RVA: 0x001EA4C7 File Offset: 0x001E86C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoadCalabashSkinInfoResponse()
		{
		}

		// Token: 0x0600D03E RID: 53310 RVA: 0x001EA4DC File Offset: 0x001E86DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoadCalabashSkinInfoResponse(LoadCalabashSkinInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.equipSkinId_ = other.equipSkinId_;
			this.skinItemIds_ = other.skinItemIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D03F RID: 53311 RVA: 0x001EA529 File Offset: 0x001E8729
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoadCalabashSkinInfoResponse Clone()
		{
			return new LoadCalabashSkinInfoResponse(this);
		}

		// Token: 0x17002A13 RID: 10771
		// (get) Token: 0x0600D040 RID: 53312 RVA: 0x001EA531 File Offset: 0x001E8731
		// (set) Token: 0x0600D041 RID: 53313 RVA: 0x001EA539 File Offset: 0x001E8739
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

		// Token: 0x17002A14 RID: 10772
		// (get) Token: 0x0600D042 RID: 53314 RVA: 0x001EA542 File Offset: 0x001E8742
		// (set) Token: 0x0600D043 RID: 53315 RVA: 0x001EA54A File Offset: 0x001E874A
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

		// Token: 0x17002A15 RID: 10773
		// (get) Token: 0x0600D044 RID: 53316 RVA: 0x001EA553 File Offset: 0x001E8753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkinItemIds
		{
			get
			{
				return this.skinItemIds_;
			}
		}

		// Token: 0x0600D045 RID: 53317 RVA: 0x001EA55B File Offset: 0x001E875B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LoadCalabashSkinInfoResponse);
		}

		// Token: 0x0600D046 RID: 53318 RVA: 0x001EA56C File Offset: 0x001E876C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LoadCalabashSkinInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.EquipSkinId == other.EquipSkinId && this.skinItemIds_.Equals(other.skinItemIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D047 RID: 53319 RVA: 0x001EA5CC File Offset: 0x001E87CC
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

		// Token: 0x0600D048 RID: 53320 RVA: 0x001EA638 File Offset: 0x001E8838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D049 RID: 53321 RVA: 0x001EA645 File Offset: 0x001E8845
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D04A RID: 53322 RVA: 0x001EA650 File Offset: 0x001E8850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
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

		// Token: 0x0600D04B RID: 53323 RVA: 0x001EA6BC File Offset: 0x001E88BC
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

		// Token: 0x0600D04C RID: 53324 RVA: 0x001EA728 File Offset: 0x001E8928
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

		// Token: 0x0600D04D RID: 53325 RVA: 0x001EA789 File Offset: 0x001E8989
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D04E RID: 53326 RVA: 0x001EA794 File Offset: 0x001E8994
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
				if (num <= 56U)
				{
					if (num == 48U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 56U)
					{
						goto IL_46;
					}
				}
				else
				{
					if (num == 58U)
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

		// Token: 0x040057BB RID: 22459
		private UnknownFieldSet _unknownFields;

		// Token: 0x040057BC RID: 22460
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x040057BD RID: 22461
		private ErrorCode errorCode_;

		// Token: 0x040057BE RID: 22462
		public const int EquipSkinIdFieldNumber = 10;

		// Token: 0x040057BF RID: 22463
		private int equipSkinId_;

		// Token: 0x040057C0 RID: 22464
		public const int SkinItemIdsFieldNumber = 7;

		// Token: 0x040057C1 RID: 22465
		private static readonly FieldCodec<int> _repeated_skinItemIds_codec = FieldCodec.ForInt32(58U);

		// Token: 0x040057C2 RID: 22466
		private readonly RepeatedField<int> skinItemIds_ = new RepeatedField<int>();
	}
}
