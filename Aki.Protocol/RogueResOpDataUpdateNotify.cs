using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FEB RID: 4075
	[NetMessage(EMessageId.RogueResOpDataUpdateNotify)]
	public sealed class RogueResOpDataUpdateNotify : IMessage<RogueResOpDataUpdateNotify>, IMessage, IEquatable<RogueResOpDataUpdateNotify>, IDeepCloneable<RogueResOpDataUpdateNotify>, IBufferMessage
	{
		// Token: 0x06015D05 RID: 89349 RVA: 0x0032C185 File Offset: 0x0032A385
		[NullableContext(1)]
		public static RogueResOpDataUpdateNotify Create()
		{
			return new RogueResOpDataUpdateNotify();
		}

		// Token: 0x170048DD RID: 18653
		// (get) Token: 0x06015D06 RID: 89350 RVA: 0x0032C18C File Offset: 0x0032A38C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170048DE RID: 18654
		// (get) Token: 0x06015D07 RID: 89351 RVA: 0x0032C18F File Offset: 0x0032A38F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResOpDataUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06015D08 RID: 89352 RVA: 0x0032C196 File Offset: 0x0032A396
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResOpDataUpdateNotify()
		{
		}

		// Token: 0x06015D09 RID: 89353 RVA: 0x0032C1C0 File Offset: 0x0032A3C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResOpDataUpdateNotify(RogueResOpDataUpdateNotify other) : this()
		{
			this.adds_ = other.adds_.Clone();
			this.updates_ = other.updates_.Clone();
			this.removes_ = other.removes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015D0A RID: 89354 RVA: 0x0032C217 File Offset: 0x0032A417
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResOpDataUpdateNotify Clone()
		{
			return new RogueResOpDataUpdateNotify(this);
		}

		// Token: 0x170048DF RID: 18655
		// (get) Token: 0x06015D0B RID: 89355 RVA: 0x0032C21F File Offset: 0x0032A41F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueResOpData> Adds
		{
			get
			{
				return this.adds_;
			}
		}

		// Token: 0x170048E0 RID: 18656
		// (get) Token: 0x06015D0C RID: 89356 RVA: 0x0032C227 File Offset: 0x0032A427
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueResOpData> Updates
		{
			get
			{
				return this.updates_;
			}
		}

		// Token: 0x170048E1 RID: 18657
		// (get) Token: 0x06015D0D RID: 89357 RVA: 0x0032C22F File Offset: 0x0032A42F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Removes
		{
			get
			{
				return this.removes_;
			}
		}

		// Token: 0x06015D0E RID: 89358 RVA: 0x0032C237 File Offset: 0x0032A437
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResOpDataUpdateNotify);
		}

		// Token: 0x06015D0F RID: 89359 RVA: 0x0032C248 File Offset: 0x0032A448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResOpDataUpdateNotify other)
		{
			return other != null && (other == this || (this.adds_.Equals(other.adds_) && this.updates_.Equals(other.updates_) && this.removes_.Equals(other.removes_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015D10 RID: 89360 RVA: 0x0032C2B0 File Offset: 0x0032A4B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.adds_.GetHashCode();
			num ^= this.updates_.GetHashCode();
			num ^= this.removes_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015D11 RID: 89361 RVA: 0x0032C300 File Offset: 0x0032A500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015D12 RID: 89362 RVA: 0x0032C30D File Offset: 0x0032A50D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015D13 RID: 89363 RVA: 0x0032C318 File Offset: 0x0032A518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.updates_.WriteTo(ref output, RogueResOpDataUpdateNotify._repeated_updates_codec);
			this.adds_.WriteTo(ref output, RogueResOpDataUpdateNotify._repeated_adds_codec);
			this.removes_.WriteTo(ref output, RogueResOpDataUpdateNotify._repeated_removes_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015D14 RID: 89364 RVA: 0x0032C36C File Offset: 0x0032A56C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.adds_.CalculateSize(RogueResOpDataUpdateNotify._repeated_adds_codec);
			num += this.updates_.CalculateSize(RogueResOpDataUpdateNotify._repeated_updates_codec);
			num += this.removes_.CalculateSize(RogueResOpDataUpdateNotify._repeated_removes_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015D15 RID: 89365 RVA: 0x0032C3CC File Offset: 0x0032A5CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResOpDataUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.adds_.Add(other.adds_);
			this.updates_.Add(other.updates_);
			this.removes_.Add(other.removes_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015D16 RID: 89366 RVA: 0x0032C427 File Offset: 0x0032A627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015D17 RID: 89367 RVA: 0x0032C430 File Offset: 0x0032A630
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
				if (num <= 98U)
				{
					if (num == 42U)
					{
						this.updates_.AddEntriesFrom(ref input, RogueResOpDataUpdateNotify._repeated_updates_codec);
						continue;
					}
					if (num == 98U)
					{
						this.adds_.AddEntriesFrom(ref input, RogueResOpDataUpdateNotify._repeated_adds_codec);
						continue;
					}
				}
				else if (num == 112U || num == 114U)
				{
					this.removes_.AddEntriesFrom(ref input, RogueResOpDataUpdateNotify._repeated_removes_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008354 RID: 33620
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008355 RID: 33621
		public const int AddsFieldNumber = 12;

		// Token: 0x04008356 RID: 33622
		private static readonly FieldCodec<RogueResOpData> _repeated_adds_codec = FieldCodec.ForMessage<RogueResOpData>(98U, RogueResOpData.Parser);

		// Token: 0x04008357 RID: 33623
		private readonly RepeatedField<RogueResOpData> adds_ = new RepeatedField<RogueResOpData>();

		// Token: 0x04008358 RID: 33624
		public const int UpdatesFieldNumber = 5;

		// Token: 0x04008359 RID: 33625
		private static readonly FieldCodec<RogueResOpData> _repeated_updates_codec = FieldCodec.ForMessage<RogueResOpData>(42U, RogueResOpData.Parser);

		// Token: 0x0400835A RID: 33626
		private readonly RepeatedField<RogueResOpData> updates_ = new RepeatedField<RogueResOpData>();

		// Token: 0x0400835B RID: 33627
		public const int RemovesFieldNumber = 14;

		// Token: 0x0400835C RID: 33628
		private static readonly FieldCodec<int> _repeated_removes_codec = FieldCodec.ForInt32(114U);

		// Token: 0x0400835D RID: 33629
		private readonly RepeatedField<int> removes_ = new RepeatedField<int>();
	}
}
