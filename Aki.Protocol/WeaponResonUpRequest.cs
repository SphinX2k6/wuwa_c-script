using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014F6 RID: 5366
	[NetMessage(EMessageId.WeaponResonUpRequest)]
	public sealed class WeaponResonUpRequest : IMessage<WeaponResonUpRequest>, IMessage, IEquatable<WeaponResonUpRequest>, IDeepCloneable<WeaponResonUpRequest>, IBufferMessage
	{
		// Token: 0x0601C5E9 RID: 116201 RVA: 0x00419459 File Offset: 0x00417659
		[NullableContext(1)]
		public static WeaponResonUpRequest Create()
		{
			return new WeaponResonUpRequest();
		}

		// Token: 0x17005FA5 RID: 24485
		// (get) Token: 0x0601C5EA RID: 116202 RVA: 0x00419460 File Offset: 0x00417660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005FA6 RID: 24486
		// (get) Token: 0x0601C5EB RID: 116203 RVA: 0x00419463 File Offset: 0x00417663
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeaponResonUpRequest.Descriptor;
			}
		}

		// Token: 0x0601C5EC RID: 116204 RVA: 0x0041946A File Offset: 0x0041766A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponResonUpRequest()
		{
		}

		// Token: 0x0601C5ED RID: 116205 RVA: 0x00419488 File Offset: 0x00417688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponResonUpRequest(WeaponResonUpRequest other) : this()
		{
			this.incId_ = other.incId_;
			this.consumeList_ = other.consumeList_.Clone();
			this.consumeItemList_ = other.consumeItemList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C5EE RID: 116206 RVA: 0x004194DA File Offset: 0x004176DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponResonUpRequest Clone()
		{
			return new WeaponResonUpRequest(this);
		}

		// Token: 0x17005FA7 RID: 24487
		// (get) Token: 0x0601C5EF RID: 116207 RVA: 0x004194E2 File Offset: 0x004176E2
		// (set) Token: 0x0601C5F0 RID: 116208 RVA: 0x004194EA File Offset: 0x004176EA
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

		// Token: 0x17005FA8 RID: 24488
		// (get) Token: 0x0601C5F1 RID: 116209 RVA: 0x004194F3 File Offset: 0x004176F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ConsumeList
		{
			get
			{
				return this.consumeList_;
			}
		}

		// Token: 0x17005FA9 RID: 24489
		// (get) Token: 0x0601C5F2 RID: 116210 RVA: 0x004194FB File Offset: 0x004176FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<WeaponConsumeItem> ConsumeItemList
		{
			get
			{
				return this.consumeItemList_;
			}
		}

		// Token: 0x0601C5F3 RID: 116211 RVA: 0x00419503 File Offset: 0x00417703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeaponResonUpRequest);
		}

		// Token: 0x0601C5F4 RID: 116212 RVA: 0x00419514 File Offset: 0x00417714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeaponResonUpRequest other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && this.consumeList_.Equals(other.consumeList_) && this.consumeItemList_.Equals(other.consumeItemList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C5F5 RID: 116213 RVA: 0x00419578 File Offset: 0x00417778
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
			num ^= this.consumeItemList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C5F6 RID: 116214 RVA: 0x004195D3 File Offset: 0x004177D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C5F7 RID: 116215 RVA: 0x004195E0 File Offset: 0x004177E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C5F8 RID: 116216 RVA: 0x004195EC File Offset: 0x004177EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.consumeList_.WriteTo(ref output, WeaponResonUpRequest._repeated_consumeList_codec);
			if (this.IncId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.IncId);
			}
			this.consumeItemList_.WriteTo(ref output, WeaponResonUpRequest._repeated_consumeItemList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C5F9 RID: 116217 RVA: 0x0041964C File Offset: 0x0041784C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			num += this.consumeList_.CalculateSize(WeaponResonUpRequest._repeated_consumeList_codec);
			num += this.consumeItemList_.CalculateSize(WeaponResonUpRequest._repeated_consumeItemList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C5FA RID: 116218 RVA: 0x004196B0 File Offset: 0x004178B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeaponResonUpRequest other)
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
			this.consumeItemList_.Add(other.consumeItemList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C5FB RID: 116219 RVA: 0x0041970E File Offset: 0x0041790E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C5FC RID: 116220 RVA: 0x00419718 File Offset: 0x00417918
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
				if (num <= 50U)
				{
					if (num == 48U || num == 50U)
					{
						this.consumeList_.AddEntriesFrom(ref input, WeaponResonUpRequest._repeated_consumeList_codec);
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.IncId = input.ReadInt32();
						continue;
					}
					if (num == 74U)
					{
						this.consumeItemList_.AddEntriesFrom(ref input, WeaponResonUpRequest._repeated_consumeItemList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A282 RID: 41602
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A283 RID: 41603
		public const int IncIdFieldNumber = 7;

		// Token: 0x0400A284 RID: 41604
		private int incId_;

		// Token: 0x0400A285 RID: 41605
		public const int ConsumeListFieldNumber = 6;

		// Token: 0x0400A286 RID: 41606
		private static readonly FieldCodec<int> _repeated_consumeList_codec = FieldCodec.ForInt32(50U);

		// Token: 0x0400A287 RID: 41607
		private readonly RepeatedField<int> consumeList_ = new RepeatedField<int>();

		// Token: 0x0400A288 RID: 41608
		public const int ConsumeItemListFieldNumber = 9;

		// Token: 0x0400A289 RID: 41609
		private static readonly FieldCodec<WeaponConsumeItem> _repeated_consumeItemList_codec = FieldCodec.ForMessage<WeaponConsumeItem>(74U, WeaponConsumeItem.Parser);

		// Token: 0x0400A28A RID: 41610
		private readonly RepeatedField<WeaponConsumeItem> consumeItemList_ = new RepeatedField<WeaponConsumeItem>();
	}
}
