using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000685 RID: 1669
	[NetMessage(EMessageId.FurnitureUnlockNotify)]
	public sealed class FurnitureUnlockNotify : IMessage<FurnitureUnlockNotify>, IMessage, IEquatable<FurnitureUnlockNotify>, IDeepCloneable<FurnitureUnlockNotify>, IBufferMessage
	{
		// Token: 0x060098D1 RID: 39121 RVA: 0x0017022F File Offset: 0x0016E42F
		[NullableContext(1)]
		public static FurnitureUnlockNotify Create()
		{
			return new FurnitureUnlockNotify();
		}

		// Token: 0x17001E75 RID: 7797
		// (get) Token: 0x060098D2 RID: 39122 RVA: 0x00170236 File Offset: 0x0016E436
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E76 RID: 7798
		// (get) Token: 0x060098D3 RID: 39123 RVA: 0x00170239 File Offset: 0x0016E439
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FurnitureUnlockNotify.Descriptor;
			}
		}

		// Token: 0x060098D4 RID: 39124 RVA: 0x00170240 File Offset: 0x0016E440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FurnitureUnlockNotify()
		{
		}

		// Token: 0x060098D5 RID: 39125 RVA: 0x00170253 File Offset: 0x0016E453
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FurnitureUnlockNotify(FurnitureUnlockNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.furnitureIds_ = other.furnitureIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060098D6 RID: 39126 RVA: 0x00170289 File Offset: 0x0016E489
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FurnitureUnlockNotify Clone()
		{
			return new FurnitureUnlockNotify(this);
		}

		// Token: 0x17001E77 RID: 7799
		// (get) Token: 0x060098D7 RID: 39127 RVA: 0x00170291 File Offset: 0x0016E491
		// (set) Token: 0x060098D8 RID: 39128 RVA: 0x00170299 File Offset: 0x0016E499
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17001E78 RID: 7800
		// (get) Token: 0x060098D9 RID: 39129 RVA: 0x001702A2 File Offset: 0x0016E4A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> FurnitureIds
		{
			get
			{
				return this.furnitureIds_;
			}
		}

		// Token: 0x060098DA RID: 39130 RVA: 0x001702AA File Offset: 0x0016E4AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FurnitureUnlockNotify);
		}

		// Token: 0x060098DB RID: 39131 RVA: 0x001702B8 File Offset: 0x0016E4B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FurnitureUnlockNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.furnitureIds_.Equals(other.furnitureIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060098DC RID: 39132 RVA: 0x00170308 File Offset: 0x0016E508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.furnitureIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060098DD RID: 39133 RVA: 0x00170355 File Offset: 0x0016E555
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060098DE RID: 39134 RVA: 0x00170362 File Offset: 0x0016E562
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060098DF RID: 39135 RVA: 0x0017036C File Offset: 0x0016E56C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ActivityId);
			}
			this.furnitureIds_.WriteTo(ref output, FurnitureUnlockNotify._repeated_furnitureIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060098E0 RID: 39136 RVA: 0x001703BC File Offset: 0x0016E5BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.furnitureIds_.CalculateSize(FurnitureUnlockNotify._repeated_furnitureIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060098E1 RID: 39137 RVA: 0x00170410 File Offset: 0x0016E610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FurnitureUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.furnitureIds_.Add(other.furnitureIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060098E2 RID: 39138 RVA: 0x0017045D File Offset: 0x0016E65D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060098E3 RID: 39139 RVA: 0x00170468 File Offset: 0x0016E668
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
					if (num != 96U && num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.furnitureIds_.AddEntriesFrom(ref input, FurnitureUnlockNotify._repeated_furnitureIds_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004861 RID: 18529
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004862 RID: 18530
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x04004863 RID: 18531
		private int activityId_;

		// Token: 0x04004864 RID: 18532
		public const int FurnitureIdsFieldNumber = 12;

		// Token: 0x04004865 RID: 18533
		private static readonly FieldCodec<int> _repeated_furnitureIds_codec = FieldCodec.ForInt32(98U);

		// Token: 0x04004866 RID: 18534
		private readonly RepeatedField<int> furnitureIds_ = new RepeatedField<int>();
	}
}
