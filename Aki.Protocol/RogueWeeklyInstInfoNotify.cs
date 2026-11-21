using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200102A RID: 4138
	[NetMessage(EMessageId.RogueWeeklyInstInfoNotify)]
	public sealed class RogueWeeklyInstInfoNotify : IMessage<RogueWeeklyInstInfoNotify>, IMessage, IEquatable<RogueWeeklyInstInfoNotify>, IDeepCloneable<RogueWeeklyInstInfoNotify>, IBufferMessage
	{
		// Token: 0x0601624E RID: 90702 RVA: 0x003383CC File Offset: 0x003365CC
		[NullableContext(1)]
		public static RogueWeeklyInstInfoNotify Create()
		{
			return new RogueWeeklyInstInfoNotify();
		}

		// Token: 0x17004A0D RID: 18957
		// (get) Token: 0x0601624F RID: 90703 RVA: 0x003383D3 File Offset: 0x003365D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A0E RID: 18958
		// (get) Token: 0x06016250 RID: 90704 RVA: 0x003383D6 File Offset: 0x003365D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyInstInfoNotify.Descriptor;
			}
		}

		// Token: 0x06016251 RID: 90705 RVA: 0x003383DD File Offset: 0x003365DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyInstInfoNotify()
		{
		}

		// Token: 0x06016252 RID: 90706 RVA: 0x003383FC File Offset: 0x003365FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyInstInfoNotify(RogueWeeklyInstInfoNotify other) : this()
		{
			this.rogueWeeklyBuffs_ = other.rogueWeeklyBuffs_.Clone();
			this.rogueWeeklyOptions_ = other.rogueWeeklyOptions_.Clone();
			this.configId_ = other.configId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016253 RID: 90707 RVA: 0x0033844E File Offset: 0x0033664E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyInstInfoNotify Clone()
		{
			return new RogueWeeklyInstInfoNotify(this);
		}

		// Token: 0x17004A0F RID: 18959
		// (get) Token: 0x06016254 RID: 90708 RVA: 0x00338456 File Offset: 0x00336656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RogueWeeklyBuffs
		{
			get
			{
				return this.rogueWeeklyBuffs_;
			}
		}

		// Token: 0x17004A10 RID: 18960
		// (get) Token: 0x06016255 RID: 90709 RVA: 0x0033845E File Offset: 0x0033665E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, RogueWeeklyOption> RogueWeeklyOptions
		{
			get
			{
				return this.rogueWeeklyOptions_;
			}
		}

		// Token: 0x17004A11 RID: 18961
		// (get) Token: 0x06016256 RID: 90710 RVA: 0x00338466 File Offset: 0x00336666
		// (set) Token: 0x06016257 RID: 90711 RVA: 0x0033846E File Offset: 0x0033666E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x06016258 RID: 90712 RVA: 0x00338477 File Offset: 0x00336677
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyInstInfoNotify);
		}

		// Token: 0x06016259 RID: 90713 RVA: 0x00338488 File Offset: 0x00336688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyInstInfoNotify other)
		{
			return other != null && (other == this || (this.rogueWeeklyBuffs_.Equals(other.rogueWeeklyBuffs_) && this.RogueWeeklyOptions.Equals(other.RogueWeeklyOptions) && this.ConfigId == other.ConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601625A RID: 90714 RVA: 0x003384EC File Offset: 0x003366EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.rogueWeeklyBuffs_.GetHashCode();
			num ^= this.RogueWeeklyOptions.GetHashCode();
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601625B RID: 90715 RVA: 0x00338547 File Offset: 0x00336747
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601625C RID: 90716 RVA: 0x00338554 File Offset: 0x00336754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601625D RID: 90717 RVA: 0x00338560 File Offset: 0x00336760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ConfigId);
			}
			this.rogueWeeklyOptions_.WriteTo(ref output, RogueWeeklyInstInfoNotify._map_rogueWeeklyOptions_codec);
			this.rogueWeeklyBuffs_.WriteTo(ref output, RogueWeeklyInstInfoNotify._repeated_rogueWeeklyBuffs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601625E RID: 90718 RVA: 0x003385C0 File Offset: 0x003367C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rogueWeeklyBuffs_.CalculateSize(RogueWeeklyInstInfoNotify._repeated_rogueWeeklyBuffs_codec);
			num += this.rogueWeeklyOptions_.CalculateSize(RogueWeeklyInstInfoNotify._map_rogueWeeklyOptions_codec);
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601625F RID: 90719 RVA: 0x00338624 File Offset: 0x00336824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWeeklyInstInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.rogueWeeklyBuffs_.Add(other.rogueWeeklyBuffs_);
			this.rogueWeeklyOptions_.MergeFrom(other.rogueWeeklyOptions_);
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016260 RID: 90720 RVA: 0x00338682 File Offset: 0x00336882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016261 RID: 90721 RVA: 0x0033868C File Offset: 0x0033688C
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
				if (num <= 82U)
				{
					if (num == 24U)
					{
						this.ConfigId = input.ReadInt32();
						continue;
					}
					if (num == 82U)
					{
						this.rogueWeeklyOptions_.AddEntriesFrom(ref input, RogueWeeklyInstInfoNotify._map_rogueWeeklyOptions_codec);
						continue;
					}
				}
				else if (num == 112U || num == 114U)
				{
					this.rogueWeeklyBuffs_.AddEntriesFrom(ref input, RogueWeeklyInstInfoNotify._repeated_rogueWeeklyBuffs_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008506 RID: 34054
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008507 RID: 34055
		public const int RogueWeeklyBuffsFieldNumber = 14;

		// Token: 0x04008508 RID: 34056
		private static readonly FieldCodec<int> _repeated_rogueWeeklyBuffs_codec = FieldCodec.ForInt32(114U);

		// Token: 0x04008509 RID: 34057
		private readonly RepeatedField<int> rogueWeeklyBuffs_ = new RepeatedField<int>();

		// Token: 0x0400850A RID: 34058
		public const int RogueWeeklyOptionsFieldNumber = 10;

		// Token: 0x0400850B RID: 34059
		private static readonly MapField<int, RogueWeeklyOption>.Codec _map_rogueWeeklyOptions_codec = new MapField<int, RogueWeeklyOption>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<RogueWeeklyOption>(18U, RogueWeeklyOption.Parser), 82U);

		// Token: 0x0400850C RID: 34060
		private readonly MapField<int, RogueWeeklyOption> rogueWeeklyOptions_ = new MapField<int, RogueWeeklyOption>();

		// Token: 0x0400850D RID: 34061
		public const int ConfigIdFieldNumber = 3;

		// Token: 0x0400850E RID: 34062
		private int configId_;
	}
}
