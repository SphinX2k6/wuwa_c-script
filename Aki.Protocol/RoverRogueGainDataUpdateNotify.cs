using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010FD RID: 4349
	[NetMessage(EMessageId.RoverRogueGainDataUpdateNotify)]
	public sealed class RoverRogueGainDataUpdateNotify : IMessage<RoverRogueGainDataUpdateNotify>, IMessage, IEquatable<RoverRogueGainDataUpdateNotify>, IDeepCloneable<RoverRogueGainDataUpdateNotify>, IBufferMessage
	{
		// Token: 0x06017309 RID: 94985 RVA: 0x0035D7F1 File Offset: 0x0035B9F1
		[NullableContext(1)]
		public static RoverRogueGainDataUpdateNotify Create()
		{
			return new RoverRogueGainDataUpdateNotify();
		}

		// Token: 0x17004DB2 RID: 19890
		// (get) Token: 0x0601730A RID: 94986 RVA: 0x0035D7F8 File Offset: 0x0035B9F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004DB3 RID: 19891
		// (get) Token: 0x0601730B RID: 94987 RVA: 0x0035D7FB File Offset: 0x0035B9FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueGainDataUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601730C RID: 94988 RVA: 0x0035D802 File Offset: 0x0035BA02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGainDataUpdateNotify()
		{
		}

		// Token: 0x0601730D RID: 94989 RVA: 0x0035D82C File Offset: 0x0035BA2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGainDataUpdateNotify(RoverRogueGainDataUpdateNotify other) : this()
		{
			this.type_ = other.type_;
			this.adds_ = other.adds_.Clone();
			this.removeIncIds_ = other.removeIncIds_.Clone();
			this.updates_ = other.updates_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601730E RID: 94990 RVA: 0x0035D88F File Offset: 0x0035BA8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGainDataUpdateNotify Clone()
		{
			return new RoverRogueGainDataUpdateNotify(this);
		}

		// Token: 0x17004DB4 RID: 19892
		// (get) Token: 0x0601730F RID: 94991 RVA: 0x0035D897 File Offset: 0x0035BA97
		// (set) Token: 0x06017310 RID: 94992 RVA: 0x0035D89F File Offset: 0x0035BA9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGainDataType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17004DB5 RID: 19893
		// (get) Token: 0x06017311 RID: 94993 RVA: 0x0035D8A8 File Offset: 0x0035BAA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueGainEntry> Adds
		{
			get
			{
				return this.adds_;
			}
		}

		// Token: 0x17004DB6 RID: 19894
		// (get) Token: 0x06017312 RID: 94994 RVA: 0x0035D8B0 File Offset: 0x0035BAB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RemoveIncIds
		{
			get
			{
				return this.removeIncIds_;
			}
		}

		// Token: 0x17004DB7 RID: 19895
		// (get) Token: 0x06017313 RID: 94995 RVA: 0x0035D8B8 File Offset: 0x0035BAB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueGainEntry> Updates
		{
			get
			{
				return this.updates_;
			}
		}

		// Token: 0x06017314 RID: 94996 RVA: 0x0035D8C0 File Offset: 0x0035BAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueGainDataUpdateNotify);
		}

		// Token: 0x06017315 RID: 94997 RVA: 0x0035D8D0 File Offset: 0x0035BAD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueGainDataUpdateNotify other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.adds_.Equals(other.adds_) && this.removeIncIds_.Equals(other.removeIncIds_) && this.updates_.Equals(other.updates_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017316 RID: 94998 RVA: 0x0035D948 File Offset: 0x0035BB48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != RoverRogueGainDataType.RoverRogueGainUnknown)
			{
				num ^= this.Type.GetHashCode();
			}
			num ^= this.adds_.GetHashCode();
			num ^= this.removeIncIds_.GetHashCode();
			num ^= this.updates_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017317 RID: 94999 RVA: 0x0035D9B7 File Offset: 0x0035BBB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017318 RID: 95000 RVA: 0x0035D9C4 File Offset: 0x0035BBC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017319 RID: 95001 RVA: 0x0035D9D0 File Offset: 0x0035BBD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.removeIncIds_.WriteTo(ref output, RoverRogueGainDataUpdateNotify._repeated_removeIncIds_codec);
			this.adds_.WriteTo(ref output, RoverRogueGainDataUpdateNotify._repeated_adds_codec);
			this.updates_.WriteTo(ref output, RoverRogueGainDataUpdateNotify._repeated_updates_codec);
			if (this.Type != RoverRogueGainDataType.RoverRogueGainUnknown)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601731A RID: 95002 RVA: 0x0035DA40 File Offset: 0x0035BC40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != RoverRogueGainDataType.RoverRogueGainUnknown)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			num += this.adds_.CalculateSize(RoverRogueGainDataUpdateNotify._repeated_adds_codec);
			num += this.removeIncIds_.CalculateSize(RoverRogueGainDataUpdateNotify._repeated_removeIncIds_codec);
			num += this.updates_.CalculateSize(RoverRogueGainDataUpdateNotify._repeated_updates_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601731B RID: 95003 RVA: 0x0035DAB8 File Offset: 0x0035BCB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueGainDataUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != RoverRogueGainDataType.RoverRogueGainUnknown)
			{
				this.Type = other.Type;
			}
			this.adds_.Add(other.adds_);
			this.removeIncIds_.Add(other.removeIncIds_);
			this.updates_.Add(other.updates_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601731C RID: 95004 RVA: 0x0035DB27 File Offset: 0x0035BD27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601731D RID: 95005 RVA: 0x0035DB30 File Offset: 0x0035BD30
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
						this.removeIncIds_.AddEntriesFrom(ref input, RoverRogueGainDataUpdateNotify._repeated_removeIncIds_codec);
						continue;
					}
				}
				else
				{
					if (num == 58U)
					{
						this.adds_.AddEntriesFrom(ref input, RoverRogueGainDataUpdateNotify._repeated_adds_codec);
						continue;
					}
					if (num == 90U)
					{
						this.updates_.AddEntriesFrom(ref input, RoverRogueGainDataUpdateNotify._repeated_updates_codec);
						continue;
					}
					if (num == 120U)
					{
						this.Type = (RoverRogueGainDataType)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040089E2 RID: 35298
		private UnknownFieldSet _unknownFields;

		// Token: 0x040089E3 RID: 35299
		public const int TypeFieldNumber = 15;

		// Token: 0x040089E4 RID: 35300
		private RoverRogueGainDataType type_;

		// Token: 0x040089E5 RID: 35301
		public const int AddsFieldNumber = 7;

		// Token: 0x040089E6 RID: 35302
		private static readonly FieldCodec<RoverRogueGainEntry> _repeated_adds_codec = FieldCodec.ForMessage<RoverRogueGainEntry>(58U, RoverRogueGainEntry.Parser);

		// Token: 0x040089E7 RID: 35303
		private readonly RepeatedField<RoverRogueGainEntry> adds_ = new RepeatedField<RoverRogueGainEntry>();

		// Token: 0x040089E8 RID: 35304
		public const int RemoveIncIdsFieldNumber = 5;

		// Token: 0x040089E9 RID: 35305
		private static readonly FieldCodec<int> _repeated_removeIncIds_codec = FieldCodec.ForInt32(42U);

		// Token: 0x040089EA RID: 35306
		private readonly RepeatedField<int> removeIncIds_ = new RepeatedField<int>();

		// Token: 0x040089EB RID: 35307
		public const int UpdatesFieldNumber = 11;

		// Token: 0x040089EC RID: 35308
		private static readonly FieldCodec<RoverRogueGainEntry> _repeated_updates_codec = FieldCodec.ForMessage<RoverRogueGainEntry>(90U, RoverRogueGainEntry.Parser);

		// Token: 0x040089ED RID: 35309
		private readonly RepeatedField<RoverRogueGainEntry> updates_ = new RepeatedField<RoverRogueGainEntry>();
	}
}
