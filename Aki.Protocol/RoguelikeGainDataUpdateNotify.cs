using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F9B RID: 3995
	[NetMessage(EMessageId.RoguelikeGainDataUpdateNotify)]
	public sealed class RoguelikeGainDataUpdateNotify : IMessage<RoguelikeGainDataUpdateNotify>, IMessage, IEquatable<RoguelikeGainDataUpdateNotify>, IDeepCloneable<RoguelikeGainDataUpdateNotify>, IBufferMessage
	{
		// Token: 0x060155D5 RID: 87509 RVA: 0x00319AEA File Offset: 0x00317CEA
		[NullableContext(1)]
		public static RoguelikeGainDataUpdateNotify Create()
		{
			return new RoguelikeGainDataUpdateNotify();
		}

		// Token: 0x17004733 RID: 18227
		// (get) Token: 0x060155D6 RID: 87510 RVA: 0x00319AF1 File Offset: 0x00317CF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004734 RID: 18228
		// (get) Token: 0x060155D7 RID: 87511 RVA: 0x00319AF4 File Offset: 0x00317CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeGainDataUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060155D8 RID: 87512 RVA: 0x00319AFB File Offset: 0x00317CFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeGainDataUpdateNotify()
		{
		}

		// Token: 0x060155D9 RID: 87513 RVA: 0x00319B10 File Offset: 0x00317D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeGainDataUpdateNotify(RoguelikeGainDataUpdateNotify other) : this()
		{
			this.gainDataUpdateType_ = other.gainDataUpdateType_;
			this.index_ = other.index_;
			this.rogueGainEntry_ = ((other.rogueGainEntry_ != null) ? other.rogueGainEntry_.Clone() : null);
			this.elementDict_ = other.elementDict_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060155DA RID: 87514 RVA: 0x00319B79 File Offset: 0x00317D79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeGainDataUpdateNotify Clone()
		{
			return new RoguelikeGainDataUpdateNotify(this);
		}

		// Token: 0x17004735 RID: 18229
		// (get) Token: 0x060155DB RID: 87515 RVA: 0x00319B81 File Offset: 0x00317D81
		// (set) Token: 0x060155DC RID: 87516 RVA: 0x00319B89 File Offset: 0x00317D89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GainDataUpdateType GainDataUpdateType
		{
			get
			{
				return this.gainDataUpdateType_;
			}
			set
			{
				this.gainDataUpdateType_ = value;
			}
		}

		// Token: 0x17004736 RID: 18230
		// (get) Token: 0x060155DD RID: 87517 RVA: 0x00319B92 File Offset: 0x00317D92
		// (set) Token: 0x060155DE RID: 87518 RVA: 0x00319B9A File Offset: 0x00317D9A
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

		// Token: 0x17004737 RID: 18231
		// (get) Token: 0x060155DF RID: 87519 RVA: 0x00319BA3 File Offset: 0x00317DA3
		// (set) Token: 0x060155E0 RID: 87520 RVA: 0x00319BAB File Offset: 0x00317DAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGainEntry RogueGainEntry
		{
			get
			{
				return this.rogueGainEntry_;
			}
			set
			{
				this.rogueGainEntry_ = value;
			}
		}

		// Token: 0x17004738 RID: 18232
		// (get) Token: 0x060155E1 RID: 87521 RVA: 0x00319BB4 File Offset: 0x00317DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ElementDict
		{
			get
			{
				return this.elementDict_;
			}
		}

		// Token: 0x060155E2 RID: 87522 RVA: 0x00319BBC File Offset: 0x00317DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeGainDataUpdateNotify);
		}

		// Token: 0x060155E3 RID: 87523 RVA: 0x00319BCC File Offset: 0x00317DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeGainDataUpdateNotify other)
		{
			return other != null && (other == this || (this.GainDataUpdateType == other.GainDataUpdateType && this.Index == other.Index && object.Equals(this.RogueGainEntry, other.RogueGainEntry) && this.ElementDict.Equals(other.ElementDict) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060155E4 RID: 87524 RVA: 0x00319C40 File Offset: 0x00317E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GainDataUpdateType != GainDataUpdateType.GainDataAdd)
			{
				num ^= this.GainDataUpdateType.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.rogueGainEntry_ != null)
			{
				num ^= this.RogueGainEntry.GetHashCode();
			}
			num ^= this.ElementDict.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060155E5 RID: 87525 RVA: 0x00319CC2 File Offset: 0x00317EC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060155E6 RID: 87526 RVA: 0x00319CCF File Offset: 0x00317ECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060155E7 RID: 87527 RVA: 0x00319CD8 File Offset: 0x00317ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Index);
			}
			if (this.rogueGainEntry_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.RogueGainEntry);
			}
			if (this.GainDataUpdateType != GainDataUpdateType.GainDataAdd)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.GainDataUpdateType);
			}
			this.elementDict_.WriteTo(ref output, RoguelikeGainDataUpdateNotify._map_elementDict_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060155E8 RID: 87528 RVA: 0x00319D60 File Offset: 0x00317F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GainDataUpdateType != GainDataUpdateType.GainDataAdd)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.GainDataUpdateType);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this.rogueGainEntry_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueGainEntry);
			}
			num += this.elementDict_.CalculateSize(RoguelikeGainDataUpdateNotify._map_elementDict_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060155E9 RID: 87529 RVA: 0x00319DE4 File Offset: 0x00317FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeGainDataUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GainDataUpdateType != GainDataUpdateType.GainDataAdd)
			{
				this.GainDataUpdateType = other.GainDataUpdateType;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			if (other.rogueGainEntry_ != null)
			{
				if (this.rogueGainEntry_ == null)
				{
					this.RogueGainEntry = new RogueGainEntry();
				}
				this.RogueGainEntry.MergeFrom(other.RogueGainEntry);
			}
			this.elementDict_.MergeFrom(other.elementDict_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060155EA RID: 87530 RVA: 0x00319E71 File Offset: 0x00318071
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060155EB RID: 87531 RVA: 0x00319E7C File Offset: 0x0031807C
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
				if (num <= 90U)
				{
					if (num == 32U)
					{
						this.Index = input.ReadInt32();
						continue;
					}
					if (num == 90U)
					{
						if (this.rogueGainEntry_ == null)
						{
							this.RogueGainEntry = new RogueGainEntry();
						}
						input.ReadMessage(this.RogueGainEntry);
						continue;
					}
				}
				else
				{
					if (num == 112U)
					{
						this.GainDataUpdateType = (GainDataUpdateType)input.ReadEnum();
						continue;
					}
					if (num == 122U)
					{
						this.elementDict_.AddEntriesFrom(ref input, RoguelikeGainDataUpdateNotify._map_elementDict_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008089 RID: 32905
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400808A RID: 32906
		public const int GainDataUpdateTypeFieldNumber = 14;

		// Token: 0x0400808B RID: 32907
		private GainDataUpdateType gainDataUpdateType_;

		// Token: 0x0400808C RID: 32908
		public const int IndexFieldNumber = 4;

		// Token: 0x0400808D RID: 32909
		private int index_;

		// Token: 0x0400808E RID: 32910
		public const int RogueGainEntryFieldNumber = 11;

		// Token: 0x0400808F RID: 32911
		private RogueGainEntry rogueGainEntry_;

		// Token: 0x04008090 RID: 32912
		public const int ElementDictFieldNumber = 15;

		// Token: 0x04008091 RID: 32913
		private static readonly MapField<int, int>.Codec _map_elementDict_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 122U);

		// Token: 0x04008092 RID: 32914
		private readonly MapField<int, int> elementDict_ = new MapField<int, int>();
	}
}
