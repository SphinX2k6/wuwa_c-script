using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001137 RID: 4407
	[NetMessage(EMessageId.RoverRogueGainDataUpdateNotify)]
	public sealed class RoverRogueGainDataUpdateNotify : IMessage<RoverRogueGainDataUpdateNotify>, IMessage, IEquatable<RoverRogueGainDataUpdateNotify>, IDeepCloneable<RoverRogueGainDataUpdateNotify>, IBufferMessage
	{
		// Token: 0x060178AA RID: 96426 RVA: 0x0036CB45 File Offset: 0x0036AD45
		[NullableContext(1)]
		public static RoverRogueGainDataUpdateNotify Create()
		{
			return new RoverRogueGainDataUpdateNotify();
		}

		// Token: 0x17004F1E RID: 20254
		// (get) Token: 0x060178AB RID: 96427 RVA: 0x0036CB4C File Offset: 0x0036AD4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F1F RID: 20255
		// (get) Token: 0x060178AC RID: 96428 RVA: 0x0036CB4F File Offset: 0x0036AD4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueGainDataUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060178AD RID: 96429 RVA: 0x0036CB56 File Offset: 0x0036AD56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGainDataUpdateNotify()
		{
		}

		// Token: 0x060178AE RID: 96430 RVA: 0x0036CB80 File Offset: 0x0036AD80
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

		// Token: 0x060178AF RID: 96431 RVA: 0x0036CBE3 File Offset: 0x0036ADE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGainDataUpdateNotify Clone()
		{
			return new RoverRogueGainDataUpdateNotify(this);
		}

		// Token: 0x17004F20 RID: 20256
		// (get) Token: 0x060178B0 RID: 96432 RVA: 0x0036CBEB File Offset: 0x0036ADEB
		// (set) Token: 0x060178B1 RID: 96433 RVA: 0x0036CBF3 File Offset: 0x0036ADF3
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

		// Token: 0x17004F21 RID: 20257
		// (get) Token: 0x060178B2 RID: 96434 RVA: 0x0036CBFC File Offset: 0x0036ADFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueGainEntry> Adds
		{
			get
			{
				return this.adds_;
			}
		}

		// Token: 0x17004F22 RID: 20258
		// (get) Token: 0x060178B3 RID: 96435 RVA: 0x0036CC04 File Offset: 0x0036AE04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RemoveIncIds
		{
			get
			{
				return this.removeIncIds_;
			}
		}

		// Token: 0x17004F23 RID: 20259
		// (get) Token: 0x060178B4 RID: 96436 RVA: 0x0036CC0C File Offset: 0x0036AE0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueGainEntry> Updates
		{
			get
			{
				return this.updates_;
			}
		}

		// Token: 0x060178B5 RID: 96437 RVA: 0x0036CC14 File Offset: 0x0036AE14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueGainDataUpdateNotify);
		}

		// Token: 0x060178B6 RID: 96438 RVA: 0x0036CC24 File Offset: 0x0036AE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueGainDataUpdateNotify other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.adds_.Equals(other.adds_) && this.removeIncIds_.Equals(other.removeIncIds_) && this.updates_.Equals(other.updates_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060178B7 RID: 96439 RVA: 0x0036CC9C File Offset: 0x0036AE9C
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

		// Token: 0x060178B8 RID: 96440 RVA: 0x0036CD0B File Offset: 0x0036AF0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060178B9 RID: 96441 RVA: 0x0036CD18 File Offset: 0x0036AF18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060178BA RID: 96442 RVA: 0x0036CD24 File Offset: 0x0036AF24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.adds_.WriteTo(ref output, RoverRogueGainDataUpdateNotify._repeated_adds_codec);
			this.removeIncIds_.WriteTo(ref output, RoverRogueGainDataUpdateNotify._repeated_removeIncIds_codec);
			if (this.Type != RoverRogueGainDataType.RoverRogueGainUnknown)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.Type);
			}
			this.updates_.WriteTo(ref output, RoverRogueGainDataUpdateNotify._repeated_updates_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060178BB RID: 96443 RVA: 0x0036CD94 File Offset: 0x0036AF94
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

		// Token: 0x060178BC RID: 96444 RVA: 0x0036CE0C File Offset: 0x0036B00C
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

		// Token: 0x060178BD RID: 96445 RVA: 0x0036CE7B File Offset: 0x0036B07B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060178BE RID: 96446 RVA: 0x0036CE84 File Offset: 0x0036B084
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
				if (num <= 40U)
				{
					if (num == 18U)
					{
						this.adds_.AddEntriesFrom(ref input, RoverRogueGainDataUpdateNotify._repeated_adds_codec);
						continue;
					}
					if (num == 40U)
					{
						goto IL_53;
					}
				}
				else
				{
					if (num == 42U)
					{
						goto IL_53;
					}
					if (num == 48U)
					{
						this.Type = (RoverRogueGainDataType)input.ReadEnum();
						continue;
					}
					if (num == 106U)
					{
						this.updates_.AddEntriesFrom(ref input, RoverRogueGainDataUpdateNotify._repeated_updates_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_53:
				this.removeIncIds_.AddEntriesFrom(ref input, RoverRogueGainDataUpdateNotify._repeated_removeIncIds_codec);
			}
		}

		// Token: 0x04008C75 RID: 35957
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008C76 RID: 35958
		public const int TypeFieldNumber = 6;

		// Token: 0x04008C77 RID: 35959
		private RoverRogueGainDataType type_;

		// Token: 0x04008C78 RID: 35960
		public const int AddsFieldNumber = 2;

		// Token: 0x04008C79 RID: 35961
		private static readonly FieldCodec<RoverRogueGainEntry> _repeated_adds_codec = FieldCodec.ForMessage<RoverRogueGainEntry>(18U, RoverRogueGainEntry.Parser);

		// Token: 0x04008C7A RID: 35962
		private readonly RepeatedField<RoverRogueGainEntry> adds_ = new RepeatedField<RoverRogueGainEntry>();

		// Token: 0x04008C7B RID: 35963
		public const int RemoveIncIdsFieldNumber = 5;

		// Token: 0x04008C7C RID: 35964
		private static readonly FieldCodec<int> _repeated_removeIncIds_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04008C7D RID: 35965
		private readonly RepeatedField<int> removeIncIds_ = new RepeatedField<int>();

		// Token: 0x04008C7E RID: 35966
		public const int UpdatesFieldNumber = 13;

		// Token: 0x04008C7F RID: 35967
		private static readonly FieldCodec<RoverRogueGainEntry> _repeated_updates_codec = FieldCodec.ForMessage<RoverRogueGainEntry>(106U, RoverRogueGainEntry.Parser);

		// Token: 0x04008C80 RID: 35968
		private readonly RepeatedField<RoverRogueGainEntry> updates_ = new RepeatedField<RoverRogueGainEntry>();
	}
}
