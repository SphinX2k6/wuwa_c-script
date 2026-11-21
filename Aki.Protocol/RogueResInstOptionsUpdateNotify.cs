using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FDD RID: 4061
	[NetMessage(EMessageId.RogueResInstOptionsUpdateNotify)]
	public sealed class RogueResInstOptionsUpdateNotify : IMessage<RogueResInstOptionsUpdateNotify>, IMessage, IEquatable<RogueResInstOptionsUpdateNotify>, IDeepCloneable<RogueResInstOptionsUpdateNotify>, IBufferMessage
	{
		// Token: 0x06015BE3 RID: 89059 RVA: 0x00329547 File Offset: 0x00327747
		[NullableContext(1)]
		public static RogueResInstOptionsUpdateNotify Create()
		{
			return new RogueResInstOptionsUpdateNotify();
		}

		// Token: 0x1700489F RID: 18591
		// (get) Token: 0x06015BE4 RID: 89060 RVA: 0x0032954E File Offset: 0x0032774E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170048A0 RID: 18592
		// (get) Token: 0x06015BE5 RID: 89061 RVA: 0x00329551 File Offset: 0x00327751
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResInstOptionsUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06015BE6 RID: 89062 RVA: 0x00329558 File Offset: 0x00327758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResInstOptionsUpdateNotify()
		{
		}

		// Token: 0x06015BE7 RID: 89063 RVA: 0x00329584 File Offset: 0x00327784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResInstOptionsUpdateNotify(RogueResInstOptionsUpdateNotify other) : this()
		{
			this.adds_ = other.adds_.Clone();
			this.updates_ = other.updates_.Clone();
			this.removes_ = other.removes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015BE8 RID: 89064 RVA: 0x003295DB File Offset: 0x003277DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResInstOptionsUpdateNotify Clone()
		{
			return new RogueResInstOptionsUpdateNotify(this);
		}

		// Token: 0x170048A1 RID: 18593
		// (get) Token: 0x06015BE9 RID: 89065 RVA: 0x003295E3 File Offset: 0x003277E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, RogueResOption> Adds
		{
			get
			{
				return this.adds_;
			}
		}

		// Token: 0x170048A2 RID: 18594
		// (get) Token: 0x06015BEA RID: 89066 RVA: 0x003295EB File Offset: 0x003277EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, RogueResOption> Updates
		{
			get
			{
				return this.updates_;
			}
		}

		// Token: 0x170048A3 RID: 18595
		// (get) Token: 0x06015BEB RID: 89067 RVA: 0x003295F3 File Offset: 0x003277F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Removes
		{
			get
			{
				return this.removes_;
			}
		}

		// Token: 0x06015BEC RID: 89068 RVA: 0x003295FB File Offset: 0x003277FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResInstOptionsUpdateNotify);
		}

		// Token: 0x06015BED RID: 89069 RVA: 0x0032960C File Offset: 0x0032780C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResInstOptionsUpdateNotify other)
		{
			return other != null && (other == this || (this.Adds.Equals(other.Adds) && this.Updates.Equals(other.Updates) && this.removes_.Equals(other.removes_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015BEE RID: 89070 RVA: 0x00329674 File Offset: 0x00327874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.Adds.GetHashCode();
			num ^= this.Updates.GetHashCode();
			num ^= this.removes_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015BEF RID: 89071 RVA: 0x003296C4 File Offset: 0x003278C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015BF0 RID: 89072 RVA: 0x003296D1 File Offset: 0x003278D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015BF1 RID: 89073 RVA: 0x003296DC File Offset: 0x003278DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.removes_.WriteTo(ref output, RogueResInstOptionsUpdateNotify._repeated_removes_codec);
			this.updates_.WriteTo(ref output, RogueResInstOptionsUpdateNotify._map_updates_codec);
			this.adds_.WriteTo(ref output, RogueResInstOptionsUpdateNotify._map_adds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015BF2 RID: 89074 RVA: 0x00329730 File Offset: 0x00327930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.adds_.CalculateSize(RogueResInstOptionsUpdateNotify._map_adds_codec);
			num += this.updates_.CalculateSize(RogueResInstOptionsUpdateNotify._map_updates_codec);
			num += this.removes_.CalculateSize(RogueResInstOptionsUpdateNotify._repeated_removes_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015BF3 RID: 89075 RVA: 0x00329790 File Offset: 0x00327990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResInstOptionsUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.adds_.MergeFrom(other.adds_);
			this.updates_.MergeFrom(other.updates_);
			this.removes_.Add(other.removes_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015BF4 RID: 89076 RVA: 0x003297EB File Offset: 0x003279EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015BF5 RID: 89077 RVA: 0x003297F4 File Offset: 0x003279F4
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
					if (num == 40U || num == 42U)
					{
						this.removes_.AddEntriesFrom(ref input, RogueResInstOptionsUpdateNotify._repeated_removes_codec);
						continue;
					}
				}
				else
				{
					if (num == 50U)
					{
						this.updates_.AddEntriesFrom(ref input, RogueResInstOptionsUpdateNotify._map_updates_codec);
						continue;
					}
					if (num == 74U)
					{
						this.adds_.AddEntriesFrom(ref input, RogueResInstOptionsUpdateNotify._map_adds_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008309 RID: 33545
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400830A RID: 33546
		public const int AddsFieldNumber = 9;

		// Token: 0x0400830B RID: 33547
		private static readonly MapField<int, RogueResOption>.Codec _map_adds_codec = new MapField<int, RogueResOption>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<RogueResOption>(18U, RogueResOption.Parser), 74U);

		// Token: 0x0400830C RID: 33548
		private readonly MapField<int, RogueResOption> adds_ = new MapField<int, RogueResOption>();

		// Token: 0x0400830D RID: 33549
		public const int UpdatesFieldNumber = 6;

		// Token: 0x0400830E RID: 33550
		private static readonly MapField<int, RogueResOption>.Codec _map_updates_codec = new MapField<int, RogueResOption>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<RogueResOption>(18U, RogueResOption.Parser), 50U);

		// Token: 0x0400830F RID: 33551
		private readonly MapField<int, RogueResOption> updates_ = new MapField<int, RogueResOption>();

		// Token: 0x04008310 RID: 33552
		public const int RemovesFieldNumber = 5;

		// Token: 0x04008311 RID: 33553
		private static readonly FieldCodec<int> _repeated_removes_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04008312 RID: 33554
		private readonly RepeatedField<int> removes_ = new RepeatedField<int>();
	}
}
