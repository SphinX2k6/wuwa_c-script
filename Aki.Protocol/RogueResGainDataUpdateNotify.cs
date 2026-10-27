using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FE0 RID: 4064
	[NetMessage(EMessageId.RogueResGainDataUpdateNotify)]
	public sealed class RogueResGainDataUpdateNotify : IMessage<RogueResGainDataUpdateNotify>, IMessage, IEquatable<RogueResGainDataUpdateNotify>, IDeepCloneable<RogueResGainDataUpdateNotify>, IBufferMessage
	{
		// Token: 0x06015B89 RID: 88969 RVA: 0x003273AB File Offset: 0x003255AB
		[NullableContext(1)]
		public static RogueResGainDataUpdateNotify Create()
		{
			return new RogueResGainDataUpdateNotify();
		}

		// Token: 0x17004875 RID: 18549
		// (get) Token: 0x06015B8A RID: 88970 RVA: 0x003273B2 File Offset: 0x003255B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004876 RID: 18550
		// (get) Token: 0x06015B8B RID: 88971 RVA: 0x003273B5 File Offset: 0x003255B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResGainDataUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06015B8C RID: 88972 RVA: 0x003273BC File Offset: 0x003255BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGainDataUpdateNotify()
		{
		}

		// Token: 0x06015B8D RID: 88973 RVA: 0x003273E8 File Offset: 0x003255E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGainDataUpdateNotify(RogueResGainDataUpdateNotify other) : this()
		{
			this.adds_ = other.adds_.Clone();
			this.updates_ = other.updates_.Clone();
			this.removes_ = other.removes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015B8E RID: 88974 RVA: 0x0032743F File Offset: 0x0032563F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGainDataUpdateNotify Clone()
		{
			return new RogueResGainDataUpdateNotify(this);
		}

		// Token: 0x17004877 RID: 18551
		// (get) Token: 0x06015B8F RID: 88975 RVA: 0x00327447 File Offset: 0x00325647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueResGainData> Adds
		{
			get
			{
				return this.adds_;
			}
		}

		// Token: 0x17004878 RID: 18552
		// (get) Token: 0x06015B90 RID: 88976 RVA: 0x0032744F File Offset: 0x0032564F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueResGainData> Updates
		{
			get
			{
				return this.updates_;
			}
		}

		// Token: 0x17004879 RID: 18553
		// (get) Token: 0x06015B91 RID: 88977 RVA: 0x00327457 File Offset: 0x00325657
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Removes
		{
			get
			{
				return this.removes_;
			}
		}

		// Token: 0x06015B92 RID: 88978 RVA: 0x0032745F File Offset: 0x0032565F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResGainDataUpdateNotify);
		}

		// Token: 0x06015B93 RID: 88979 RVA: 0x00327470 File Offset: 0x00325670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResGainDataUpdateNotify other)
		{
			return other != null && (other == this || (this.adds_.Equals(other.adds_) && this.updates_.Equals(other.updates_) && this.removes_.Equals(other.removes_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015B94 RID: 88980 RVA: 0x003274D8 File Offset: 0x003256D8
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

		// Token: 0x06015B95 RID: 88981 RVA: 0x00327528 File Offset: 0x00325728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015B96 RID: 88982 RVA: 0x00327535 File Offset: 0x00325735
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015B97 RID: 88983 RVA: 0x00327540 File Offset: 0x00325740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.updates_.WriteTo(ref output, RogueResGainDataUpdateNotify._repeated_updates_codec);
			this.removes_.WriteTo(ref output, RogueResGainDataUpdateNotify._repeated_removes_codec);
			this.adds_.WriteTo(ref output, RogueResGainDataUpdateNotify._repeated_adds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015B98 RID: 88984 RVA: 0x00327594 File Offset: 0x00325794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.adds_.CalculateSize(RogueResGainDataUpdateNotify._repeated_adds_codec);
			num += this.updates_.CalculateSize(RogueResGainDataUpdateNotify._repeated_updates_codec);
			num += this.removes_.CalculateSize(RogueResGainDataUpdateNotify._repeated_removes_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015B99 RID: 88985 RVA: 0x003275F4 File Offset: 0x003257F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResGainDataUpdateNotify other)
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

		// Token: 0x06015B9A RID: 88986 RVA: 0x0032764F File Offset: 0x0032584F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015B9B RID: 88987 RVA: 0x00327658 File Offset: 0x00325858
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
				if (num <= 104U)
				{
					if (num == 50U)
					{
						this.updates_.AddEntriesFrom(ref input, RogueResGainDataUpdateNotify._repeated_updates_codec);
						continue;
					}
					if (num == 104U)
					{
						goto IL_4B;
					}
				}
				else
				{
					if (num == 106U)
					{
						goto IL_4B;
					}
					if (num == 114U)
					{
						this.adds_.AddEntriesFrom(ref input, RogueResGainDataUpdateNotify._repeated_adds_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_4B:
				this.removes_.AddEntriesFrom(ref input, RogueResGainDataUpdateNotify._repeated_removes_codec);
			}
		}

		// Token: 0x04008257 RID: 33367
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008258 RID: 33368
		public const int AddsFieldNumber = 14;

		// Token: 0x04008259 RID: 33369
		private static readonly FieldCodec<RogueResGainData> _repeated_adds_codec = FieldCodec.ForMessage<RogueResGainData>(114U, RogueResGainData.Parser);

		// Token: 0x0400825A RID: 33370
		private readonly RepeatedField<RogueResGainData> adds_ = new RepeatedField<RogueResGainData>();

		// Token: 0x0400825B RID: 33371
		public const int UpdatesFieldNumber = 6;

		// Token: 0x0400825C RID: 33372
		private static readonly FieldCodec<RogueResGainData> _repeated_updates_codec = FieldCodec.ForMessage<RogueResGainData>(50U, RogueResGainData.Parser);

		// Token: 0x0400825D RID: 33373
		private readonly RepeatedField<RogueResGainData> updates_ = new RepeatedField<RogueResGainData>();

		// Token: 0x0400825E RID: 33374
		public const int RemovesFieldNumber = 13;

		// Token: 0x0400825F RID: 33375
		private static readonly FieldCodec<int> _repeated_removes_codec = FieldCodec.ForInt32(106U);

		// Token: 0x04008260 RID: 33376
		private readonly RepeatedField<int> removes_ = new RepeatedField<int>();
	}
}
