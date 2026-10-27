using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014F3 RID: 5363
	[NetMessage(EMessageId.WeaponLevelUpRequest)]
	public sealed class WeaponLevelUpRequest : IMessage<WeaponLevelUpRequest>, IMessage, IEquatable<WeaponLevelUpRequest>, IDeepCloneable<WeaponLevelUpRequest>, IBufferMessage
	{
		// Token: 0x0601C5A9 RID: 116137 RVA: 0x00418B21 File Offset: 0x00416D21
		[NullableContext(1)]
		public static WeaponLevelUpRequest Create()
		{
			return new WeaponLevelUpRequest();
		}

		// Token: 0x17005F97 RID: 24471
		// (get) Token: 0x0601C5AA RID: 116138 RVA: 0x00418B28 File Offset: 0x00416D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F98 RID: 24472
		// (get) Token: 0x0601C5AB RID: 116139 RVA: 0x00418B2B File Offset: 0x00416D2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeaponLevelUpRequest.Descriptor;
			}
		}

		// Token: 0x0601C5AC RID: 116140 RVA: 0x00418B32 File Offset: 0x00416D32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponLevelUpRequest()
		{
		}

		// Token: 0x0601C5AD RID: 116141 RVA: 0x00418B45 File Offset: 0x00416D45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponLevelUpRequest(WeaponLevelUpRequest other) : this()
		{
			this.incId_ = other.incId_;
			this.consumeList_ = other.consumeList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C5AE RID: 116142 RVA: 0x00418B7B File Offset: 0x00416D7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponLevelUpRequest Clone()
		{
			return new WeaponLevelUpRequest(this);
		}

		// Token: 0x17005F99 RID: 24473
		// (get) Token: 0x0601C5AF RID: 116143 RVA: 0x00418B83 File Offset: 0x00416D83
		// (set) Token: 0x0601C5B0 RID: 116144 RVA: 0x00418B8B File Offset: 0x00416D8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x17005F9A RID: 24474
		// (get) Token: 0x0601C5B1 RID: 116145 RVA: 0x00418B94 File Offset: 0x00416D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<WeaponConsumeItem> ConsumeList
		{
			get
			{
				return this.consumeList_;
			}
		}

		// Token: 0x0601C5B2 RID: 116146 RVA: 0x00418B9C File Offset: 0x00416D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeaponLevelUpRequest);
		}

		// Token: 0x0601C5B3 RID: 116147 RVA: 0x00418BAC File Offset: 0x00416DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeaponLevelUpRequest other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && this.consumeList_.Equals(other.consumeList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C5B4 RID: 116148 RVA: 0x00418BFC File Offset: 0x00416DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			num ^= this.consumeList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C5B5 RID: 116149 RVA: 0x00418C49 File Offset: 0x00416E49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C5B6 RID: 116150 RVA: 0x00418C56 File Offset: 0x00416E56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C5B7 RID: 116151 RVA: 0x00418C60 File Offset: 0x00416E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.IncId);
			}
			this.consumeList_.WriteTo(ref output, WeaponLevelUpRequest._repeated_consumeList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C5B8 RID: 116152 RVA: 0x00418CB0 File Offset: 0x00416EB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			num += this.consumeList_.CalculateSize(WeaponLevelUpRequest._repeated_consumeList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C5B9 RID: 116153 RVA: 0x00418D04 File Offset: 0x00416F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeaponLevelUpRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			this.consumeList_.Add(other.consumeList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C5BA RID: 116154 RVA: 0x00418D51 File Offset: 0x00416F51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C5BB RID: 116155 RVA: 0x00418D5C File Offset: 0x00416F5C
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
				if (num != 8U)
				{
					if (num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.consumeList_.AddEntriesFrom(ref input, WeaponLevelUpRequest._repeated_consumeList_codec);
					}
				}
				else
				{
					this.IncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A26D RID: 41581
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A26E RID: 41582
		public const int IncIdFieldNumber = 1;

		// Token: 0x0400A26F RID: 41583
		private int incId_;

		// Token: 0x0400A270 RID: 41584
		public const int ConsumeListFieldNumber = 9;

		// Token: 0x0400A271 RID: 41585
		private static readonly FieldCodec<WeaponConsumeItem> _repeated_consumeList_codec = FieldCodec.ForMessage<WeaponConsumeItem>(74U, WeaponConsumeItem.Parser);

		// Token: 0x0400A272 RID: 41586
		private readonly RepeatedField<WeaponConsumeItem> consumeList_ = new RepeatedField<WeaponConsumeItem>();
	}
}
