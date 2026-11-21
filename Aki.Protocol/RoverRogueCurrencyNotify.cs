using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001133 RID: 4403
	[NetMessage(EMessageId.RoverRogueCurrencyNotify)]
	public sealed class RoverRogueCurrencyNotify : IMessage<RoverRogueCurrencyNotify>, IMessage, IEquatable<RoverRogueCurrencyNotify>, IDeepCloneable<RoverRogueCurrencyNotify>, IBufferMessage
	{
		// Token: 0x0601785C RID: 96348 RVA: 0x0036C178 File Offset: 0x0036A378
		[NullableContext(1)]
		public static RoverRogueCurrencyNotify Create()
		{
			return new RoverRogueCurrencyNotify();
		}

		// Token: 0x17004F0F RID: 20239
		// (get) Token: 0x0601785D RID: 96349 RVA: 0x0036C17F File Offset: 0x0036A37F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F10 RID: 20240
		// (get) Token: 0x0601785E RID: 96350 RVA: 0x0036C182 File Offset: 0x0036A382
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueCurrencyNotify.Descriptor;
			}
		}

		// Token: 0x0601785F RID: 96351 RVA: 0x0036C189 File Offset: 0x0036A389
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueCurrencyNotify()
		{
		}

		// Token: 0x06017860 RID: 96352 RVA: 0x0036C19C File Offset: 0x0036A39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueCurrencyNotify(RoverRogueCurrencyNotify other) : this()
		{
			this.resurrectionRest_ = other.resurrectionRest_;
			this.itemData_ = other.itemData_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017861 RID: 96353 RVA: 0x0036C1D2 File Offset: 0x0036A3D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueCurrencyNotify Clone()
		{
			return new RoverRogueCurrencyNotify(this);
		}

		// Token: 0x17004F11 RID: 20241
		// (get) Token: 0x06017862 RID: 96354 RVA: 0x0036C1DA File Offset: 0x0036A3DA
		// (set) Token: 0x06017863 RID: 96355 RVA: 0x0036C1E2 File Offset: 0x0036A3E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ResurrectionRest
		{
			get
			{
				return this.resurrectionRest_;
			}
			set
			{
				this.resurrectionRest_ = value;
			}
		}

		// Token: 0x17004F12 RID: 20242
		// (get) Token: 0x06017864 RID: 96356 RVA: 0x0036C1EB File Offset: 0x0036A3EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueItemCurrencyData> ItemData
		{
			get
			{
				return this.itemData_;
			}
		}

		// Token: 0x06017865 RID: 96357 RVA: 0x0036C1F3 File Offset: 0x0036A3F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueCurrencyNotify);
		}

		// Token: 0x06017866 RID: 96358 RVA: 0x0036C204 File Offset: 0x0036A404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueCurrencyNotify other)
		{
			return other != null && (other == this || (this.ResurrectionRest == other.ResurrectionRest && this.itemData_.Equals(other.itemData_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017867 RID: 96359 RVA: 0x0036C254 File Offset: 0x0036A454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ResurrectionRest != 0)
			{
				num ^= this.ResurrectionRest.GetHashCode();
			}
			num ^= this.itemData_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017868 RID: 96360 RVA: 0x0036C2A1 File Offset: 0x0036A4A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017869 RID: 96361 RVA: 0x0036C2AE File Offset: 0x0036A4AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601786A RID: 96362 RVA: 0x0036C2B8 File Offset: 0x0036A4B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ResurrectionRest != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ResurrectionRest);
			}
			this.itemData_.WriteTo(ref output, RoverRogueCurrencyNotify._repeated_itemData_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601786B RID: 96363 RVA: 0x0036C308 File Offset: 0x0036A508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ResurrectionRest != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ResurrectionRest);
			}
			num += this.itemData_.CalculateSize(RoverRogueCurrencyNotify._repeated_itemData_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601786C RID: 96364 RVA: 0x0036C35C File Offset: 0x0036A55C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueCurrencyNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ResurrectionRest != 0)
			{
				this.ResurrectionRest = other.ResurrectionRest;
			}
			this.itemData_.Add(other.itemData_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601786D RID: 96365 RVA: 0x0036C3A9 File Offset: 0x0036A5A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601786E RID: 96366 RVA: 0x0036C3B4 File Offset: 0x0036A5B4
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
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.itemData_.AddEntriesFrom(ref input, RoverRogueCurrencyNotify._repeated_itemData_codec);
					}
				}
				else
				{
					this.ResurrectionRest = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008C61 RID: 35937
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008C62 RID: 35938
		public const int ResurrectionRestFieldNumber = 1;

		// Token: 0x04008C63 RID: 35939
		private int resurrectionRest_;

		// Token: 0x04008C64 RID: 35940
		public const int ItemDataFieldNumber = 13;

		// Token: 0x04008C65 RID: 35941
		private static readonly FieldCodec<RoverRogueItemCurrencyData> _repeated_itemData_codec = FieldCodec.ForMessage<RoverRogueItemCurrencyData>(106U, RoverRogueItemCurrencyData.Parser);

		// Token: 0x04008C66 RID: 35942
		private readonly RepeatedField<RoverRogueItemCurrencyData> itemData_ = new RepeatedField<RoverRogueItemCurrencyData>();
	}
}
