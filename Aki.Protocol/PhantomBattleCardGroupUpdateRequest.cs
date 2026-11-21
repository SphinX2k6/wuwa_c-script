using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C3F RID: 3135
	[NetMessage(EMessageId.PhantomBattleCardGroupUpdateRequest)]
	public sealed class PhantomBattleCardGroupUpdateRequest : IMessage<PhantomBattleCardGroupUpdateRequest>, IMessage, IEquatable<PhantomBattleCardGroupUpdateRequest>, IDeepCloneable<PhantomBattleCardGroupUpdateRequest>, IBufferMessage
	{
		// Token: 0x0601106A RID: 69738 RVA: 0x0027EE73 File Offset: 0x0027D073
		[NullableContext(1)]
		public static PhantomBattleCardGroupUpdateRequest Create()
		{
			return new PhantomBattleCardGroupUpdateRequest();
		}

		// Token: 0x17003846 RID: 14406
		// (get) Token: 0x0601106B RID: 69739 RVA: 0x0027EE7A File Offset: 0x0027D07A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003847 RID: 14407
		// (get) Token: 0x0601106C RID: 69740 RVA: 0x0027EE7D File Offset: 0x0027D07D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardGroupUpdateRequest.Descriptor;
			}
		}

		// Token: 0x0601106D RID: 69741 RVA: 0x0027EE84 File Offset: 0x0027D084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupUpdateRequest()
		{
		}

		// Token: 0x0601106E RID: 69742 RVA: 0x0027EE98 File Offset: 0x0027D098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupUpdateRequest(PhantomBattleCardGroupUpdateRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.equipCardIds_ = other.equipCardIds_.Clone();
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601106F RID: 69743 RVA: 0x0027EEE5 File Offset: 0x0027D0E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupUpdateRequest Clone()
		{
			return new PhantomBattleCardGroupUpdateRequest(this);
		}

		// Token: 0x17003848 RID: 14408
		// (get) Token: 0x06011070 RID: 69744 RVA: 0x0027EEED File Offset: 0x0027D0ED
		// (set) Token: 0x06011071 RID: 69745 RVA: 0x0027EEF5 File Offset: 0x0027D0F5
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

		// Token: 0x17003849 RID: 14409
		// (get) Token: 0x06011072 RID: 69746 RVA: 0x0027EEFE File Offset: 0x0027D0FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> EquipCardIds
		{
			get
			{
				return this.equipCardIds_;
			}
		}

		// Token: 0x1700384A RID: 14410
		// (get) Token: 0x06011073 RID: 69747 RVA: 0x0027EF06 File Offset: 0x0027D106
		// (set) Token: 0x06011074 RID: 69748 RVA: 0x0027EF0E File Offset: 0x0027D10E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x06011075 RID: 69749 RVA: 0x0027EF17 File Offset: 0x0027D117
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardGroupUpdateRequest);
		}

		// Token: 0x06011076 RID: 69750 RVA: 0x0027EF28 File Offset: 0x0027D128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardGroupUpdateRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.equipCardIds_.Equals(other.equipCardIds_) && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011077 RID: 69751 RVA: 0x0027EF88 File Offset: 0x0027D188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.equipCardIds_.GetHashCode();
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011078 RID: 69752 RVA: 0x0027EFEE File Offset: 0x0027D1EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011079 RID: 69753 RVA: 0x0027EFFB File Offset: 0x0027D1FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601107A RID: 69754 RVA: 0x0027F004 File Offset: 0x0027D204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.equipCardIds_.WriteTo(ref output, PhantomBattleCardGroupUpdateRequest._repeated_equipCardIds_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ActivityId);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601107B RID: 69755 RVA: 0x0027F070 File Offset: 0x0027D270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.equipCardIds_.CalculateSize(PhantomBattleCardGroupUpdateRequest._repeated_equipCardIds_codec);
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601107C RID: 69756 RVA: 0x0027F0DC File Offset: 0x0027D2DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardGroupUpdateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.equipCardIds_.Add(other.equipCardIds_);
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601107D RID: 69757 RVA: 0x0027F13D File Offset: 0x0027D33D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601107E RID: 69758 RVA: 0x0027F148 File Offset: 0x0027D348
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
				if (num <= 34U)
				{
					if (num == 32U || num == 34U)
					{
						this.equipCardIds_.AddEntriesFrom(ref input, PhantomBattleCardGroupUpdateRequest._repeated_equipCardIds_codec);
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.Index = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006C5A RID: 27738
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006C5B RID: 27739
		public const int ActivityIdFieldNumber = 10;

		// Token: 0x04006C5C RID: 27740
		private int activityId_;

		// Token: 0x04006C5D RID: 27741
		public const int EquipCardIdsFieldNumber = 4;

		// Token: 0x04006C5E RID: 27742
		private static readonly FieldCodec<int> _repeated_equipCardIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04006C5F RID: 27743
		private readonly RepeatedField<int> equipCardIds_ = new RepeatedField<int>();

		// Token: 0x04006C60 RID: 27744
		public const int IndexFieldNumber = 14;

		// Token: 0x04006C61 RID: 27745
		private int index_;
	}
}
