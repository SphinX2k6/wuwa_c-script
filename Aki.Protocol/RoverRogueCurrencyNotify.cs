using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010F9 RID: 4345
	[NetMessage(EMessageId.RoverRogueCurrencyNotify)]
	public sealed class RoverRogueCurrencyNotify : IMessage<RoverRogueCurrencyNotify>, IMessage, IEquatable<RoverRogueCurrencyNotify>, IDeepCloneable<RoverRogueCurrencyNotify>, IBufferMessage
	{
		// Token: 0x060172BB RID: 94907 RVA: 0x0035CE20 File Offset: 0x0035B020
		[NullableContext(1)]
		public static RoverRogueCurrencyNotify Create()
		{
			return new RoverRogueCurrencyNotify();
		}

		// Token: 0x17004DA3 RID: 19875
		// (get) Token: 0x060172BC RID: 94908 RVA: 0x0035CE27 File Offset: 0x0035B027
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004DA4 RID: 19876
		// (get) Token: 0x060172BD RID: 94909 RVA: 0x0035CE2A File Offset: 0x0035B02A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueCurrencyNotify.Descriptor;
			}
		}

		// Token: 0x060172BE RID: 94910 RVA: 0x0035CE31 File Offset: 0x0035B031
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueCurrencyNotify()
		{
		}

		// Token: 0x060172BF RID: 94911 RVA: 0x0035CE44 File Offset: 0x0035B044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueCurrencyNotify(RoverRogueCurrencyNotify other) : this()
		{
			this.resurrectionRest_ = other.resurrectionRest_;
			this.itemData_ = other.itemData_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060172C0 RID: 94912 RVA: 0x0035CE7A File Offset: 0x0035B07A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueCurrencyNotify Clone()
		{
			return new RoverRogueCurrencyNotify(this);
		}

		// Token: 0x17004DA5 RID: 19877
		// (get) Token: 0x060172C1 RID: 94913 RVA: 0x0035CE82 File Offset: 0x0035B082
		// (set) Token: 0x060172C2 RID: 94914 RVA: 0x0035CE8A File Offset: 0x0035B08A
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

		// Token: 0x17004DA6 RID: 19878
		// (get) Token: 0x060172C3 RID: 94915 RVA: 0x0035CE93 File Offset: 0x0035B093
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueItemCurrencyData> ItemData
		{
			get
			{
				return this.itemData_;
			}
		}

		// Token: 0x060172C4 RID: 94916 RVA: 0x0035CE9B File Offset: 0x0035B09B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueCurrencyNotify);
		}

		// Token: 0x060172C5 RID: 94917 RVA: 0x0035CEAC File Offset: 0x0035B0AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueCurrencyNotify other)
		{
			return other != null && (other == this || (this.ResurrectionRest == other.ResurrectionRest && this.itemData_.Equals(other.itemData_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060172C6 RID: 94918 RVA: 0x0035CEFC File Offset: 0x0035B0FC
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

		// Token: 0x060172C7 RID: 94919 RVA: 0x0035CF49 File Offset: 0x0035B149
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060172C8 RID: 94920 RVA: 0x0035CF56 File Offset: 0x0035B156
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060172C9 RID: 94921 RVA: 0x0035CF60 File Offset: 0x0035B160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemData_.WriteTo(ref output, RoverRogueCurrencyNotify._repeated_itemData_codec);
			if (this.ResurrectionRest != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ResurrectionRest);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060172CA RID: 94922 RVA: 0x0035CFB0 File Offset: 0x0035B1B0
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

		// Token: 0x060172CB RID: 94923 RVA: 0x0035D004 File Offset: 0x0035B204
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

		// Token: 0x060172CC RID: 94924 RVA: 0x0035D051 File Offset: 0x0035B251
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060172CD RID: 94925 RVA: 0x0035D05C File Offset: 0x0035B25C
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
				if (num != 90U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ResurrectionRest = input.ReadInt32();
					}
				}
				else
				{
					this.itemData_.AddEntriesFrom(ref input, RoverRogueCurrencyNotify._repeated_itemData_codec);
				}
			}
		}

		// Token: 0x040089CE RID: 35278
		private UnknownFieldSet _unknownFields;

		// Token: 0x040089CF RID: 35279
		public const int ResurrectionRestFieldNumber = 15;

		// Token: 0x040089D0 RID: 35280
		private int resurrectionRest_;

		// Token: 0x040089D1 RID: 35281
		public const int ItemDataFieldNumber = 11;

		// Token: 0x040089D2 RID: 35282
		private static readonly FieldCodec<RoverRogueItemCurrencyData> _repeated_itemData_codec = FieldCodec.ForMessage<RoverRogueItemCurrencyData>(90U, RoverRogueItemCurrencyData.Parser);

		// Token: 0x040089D3 RID: 35283
		private readonly RepeatedField<RoverRogueItemCurrencyData> itemData_ = new RepeatedField<RoverRogueItemCurrencyData>();
	}
}
