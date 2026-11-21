using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F8B RID: 3979
	[NetMessage(EMessageId.RoguelikeGainDataUpdateNotify)]
	public sealed class RoguelikeGainDataUpdateNotify : IMessage<RoguelikeGainDataUpdateNotify>, IMessage, IEquatable<RoguelikeGainDataUpdateNotify>, IDeepCloneable<RoguelikeGainDataUpdateNotify>, IBufferMessage
	{
		// Token: 0x060154F0 RID: 87280 RVA: 0x00318442 File Offset: 0x00316642
		[NullableContext(1)]
		public static RoguelikeGainDataUpdateNotify Create()
		{
			return new RoguelikeGainDataUpdateNotify();
		}

		// Token: 0x17004709 RID: 18185
		// (get) Token: 0x060154F1 RID: 87281 RVA: 0x00318449 File Offset: 0x00316649
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700470A RID: 18186
		// (get) Token: 0x060154F2 RID: 87282 RVA: 0x0031844C File Offset: 0x0031664C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeGainDataUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060154F3 RID: 87283 RVA: 0x00318453 File Offset: 0x00316653
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeGainDataUpdateNotify()
		{
		}

		// Token: 0x060154F4 RID: 87284 RVA: 0x00318468 File Offset: 0x00316668
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

		// Token: 0x060154F5 RID: 87285 RVA: 0x003184D1 File Offset: 0x003166D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeGainDataUpdateNotify Clone()
		{
			return new RoguelikeGainDataUpdateNotify(this);
		}

		// Token: 0x1700470B RID: 18187
		// (get) Token: 0x060154F6 RID: 87286 RVA: 0x003184D9 File Offset: 0x003166D9
		// (set) Token: 0x060154F7 RID: 87287 RVA: 0x003184E1 File Offset: 0x003166E1
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

		// Token: 0x1700470C RID: 18188
		// (get) Token: 0x060154F8 RID: 87288 RVA: 0x003184EA File Offset: 0x003166EA
		// (set) Token: 0x060154F9 RID: 87289 RVA: 0x003184F2 File Offset: 0x003166F2
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

		// Token: 0x1700470D RID: 18189
		// (get) Token: 0x060154FA RID: 87290 RVA: 0x003184FB File Offset: 0x003166FB
		// (set) Token: 0x060154FB RID: 87291 RVA: 0x00318503 File Offset: 0x00316703
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

		// Token: 0x1700470E RID: 18190
		// (get) Token: 0x060154FC RID: 87292 RVA: 0x0031850C File Offset: 0x0031670C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ElementDict
		{
			get
			{
				return this.elementDict_;
			}
		}

		// Token: 0x060154FD RID: 87293 RVA: 0x00318514 File Offset: 0x00316714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeGainDataUpdateNotify);
		}

		// Token: 0x060154FE RID: 87294 RVA: 0x00318524 File Offset: 0x00316724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeGainDataUpdateNotify other)
		{
			return other != null && (other == this || (this.GainDataUpdateType == other.GainDataUpdateType && this.Index == other.Index && object.Equals(this.RogueGainEntry, other.RogueGainEntry) && this.ElementDict.Equals(other.ElementDict) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060154FF RID: 87295 RVA: 0x00318598 File Offset: 0x00316798
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

		// Token: 0x06015500 RID: 87296 RVA: 0x0031861A File Offset: 0x0031681A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015501 RID: 87297 RVA: 0x00318627 File Offset: 0x00316827
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015502 RID: 87298 RVA: 0x00318630 File Offset: 0x00316830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueGainEntry_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.RogueGainEntry);
			}
			this.elementDict_.WriteTo(ref output, RoguelikeGainDataUpdateNotify._map_elementDict_codec);
			if (this.Index != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Index);
			}
			if (this.GainDataUpdateType != GainDataUpdateType.GainDataAdd)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.GainDataUpdateType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015503 RID: 87299 RVA: 0x003186B8 File Offset: 0x003168B8
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

		// Token: 0x06015504 RID: 87300 RVA: 0x0031873C File Offset: 0x0031693C
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

		// Token: 0x06015505 RID: 87301 RVA: 0x003187C9 File Offset: 0x003169C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015506 RID: 87302 RVA: 0x003187D4 File Offset: 0x003169D4
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
				if (num <= 42U)
				{
					if (num == 10U)
					{
						if (this.rogueGainEntry_ == null)
						{
							this.RogueGainEntry = new RogueGainEntry();
						}
						input.ReadMessage(this.RogueGainEntry);
						continue;
					}
					if (num == 42U)
					{
						this.elementDict_.AddEntriesFrom(ref input, RoguelikeGainDataUpdateNotify._map_elementDict_codec);
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.Index = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.GainDataUpdateType = (GainDataUpdateType)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040080B3 RID: 32947
		private UnknownFieldSet _unknownFields;

		// Token: 0x040080B4 RID: 32948
		public const int GainDataUpdateTypeFieldNumber = 11;

		// Token: 0x040080B5 RID: 32949
		private GainDataUpdateType gainDataUpdateType_;

		// Token: 0x040080B6 RID: 32950
		public const int IndexFieldNumber = 10;

		// Token: 0x040080B7 RID: 32951
		private int index_;

		// Token: 0x040080B8 RID: 32952
		public const int RogueGainEntryFieldNumber = 1;

		// Token: 0x040080B9 RID: 32953
		private RogueGainEntry rogueGainEntry_;

		// Token: 0x040080BA RID: 32954
		public const int ElementDictFieldNumber = 5;

		// Token: 0x040080BB RID: 32955
		private static readonly MapField<int, int>.Codec _map_elementDict_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 42U);

		// Token: 0x040080BC RID: 32956
		private readonly MapField<int, int> elementDict_ = new MapField<int, int>();
	}
}
