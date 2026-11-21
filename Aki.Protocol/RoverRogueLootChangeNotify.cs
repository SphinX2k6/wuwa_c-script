using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001146 RID: 4422
	[NetMessage(EMessageId.RoverRogueLootChangeNotify)]
	public sealed class RoverRogueLootChangeNotify : IMessage<RoverRogueLootChangeNotify>, IMessage, IEquatable<RoverRogueLootChangeNotify>, IDeepCloneable<RoverRogueLootChangeNotify>, IBufferMessage
	{
		// Token: 0x06017A0D RID: 96781 RVA: 0x0037075B File Offset: 0x0036E95B
		[NullableContext(1)]
		public static RoverRogueLootChangeNotify Create()
		{
			return new RoverRogueLootChangeNotify();
		}

		// Token: 0x17004F7B RID: 20347
		// (get) Token: 0x06017A0E RID: 96782 RVA: 0x00370762 File Offset: 0x0036E962
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F7C RID: 20348
		// (get) Token: 0x06017A0F RID: 96783 RVA: 0x00370765 File Offset: 0x0036E965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueLootChangeNotify.Descriptor;
			}
		}

		// Token: 0x06017A10 RID: 96784 RVA: 0x0037076C File Offset: 0x0036E96C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueLootChangeNotify()
		{
		}

		// Token: 0x06017A11 RID: 96785 RVA: 0x0037077F File Offset: 0x0036E97F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueLootChangeNotify(RoverRogueLootChangeNotify other) : this()
		{
			this.lootData_ = other.lootData_.Clone();
			this.enableUse_ = other.enableUse_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017A12 RID: 96786 RVA: 0x003707B5 File Offset: 0x0036E9B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueLootChangeNotify Clone()
		{
			return new RoverRogueLootChangeNotify(this);
		}

		// Token: 0x17004F7D RID: 20349
		// (get) Token: 0x06017A13 RID: 96787 RVA: 0x003707BD File Offset: 0x0036E9BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueGainEntry> LootData
		{
			get
			{
				return this.lootData_;
			}
		}

		// Token: 0x17004F7E RID: 20350
		// (get) Token: 0x06017A14 RID: 96788 RVA: 0x003707C5 File Offset: 0x0036E9C5
		// (set) Token: 0x06017A15 RID: 96789 RVA: 0x003707CD File Offset: 0x0036E9CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool EnableUse
		{
			get
			{
				return this.enableUse_;
			}
			set
			{
				this.enableUse_ = value;
			}
		}

		// Token: 0x06017A16 RID: 96790 RVA: 0x003707D6 File Offset: 0x0036E9D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueLootChangeNotify);
		}

		// Token: 0x06017A17 RID: 96791 RVA: 0x003707E4 File Offset: 0x0036E9E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueLootChangeNotify other)
		{
			return other != null && (other == this || (this.lootData_.Equals(other.lootData_) && this.EnableUse == other.EnableUse && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017A18 RID: 96792 RVA: 0x00370834 File Offset: 0x0036EA34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.lootData_.GetHashCode();
			if (this.EnableUse)
			{
				num ^= this.EnableUse.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017A19 RID: 96793 RVA: 0x00370881 File Offset: 0x0036EA81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017A1A RID: 96794 RVA: 0x0037088E File Offset: 0x0036EA8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017A1B RID: 96795 RVA: 0x00370898 File Offset: 0x0036EA98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EnableUse)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.EnableUse);
			}
			this.lootData_.WriteTo(ref output, RoverRogueLootChangeNotify._repeated_lootData_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017A1C RID: 96796 RVA: 0x003708E8 File Offset: 0x0036EAE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.lootData_.CalculateSize(RoverRogueLootChangeNotify._repeated_lootData_codec);
			if (this.EnableUse)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017A1D RID: 96797 RVA: 0x00370930 File Offset: 0x0036EB30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueLootChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.lootData_.Add(other.lootData_);
			if (other.EnableUse)
			{
				this.EnableUse = other.EnableUse;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017A1E RID: 96798 RVA: 0x0037097D File Offset: 0x0036EB7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017A1F RID: 96799 RVA: 0x00370988 File Offset: 0x0036EB88
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
				if (num != 16U)
				{
					if (num != 42U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.lootData_.AddEntriesFrom(ref input, RoverRogueLootChangeNotify._repeated_lootData_codec);
					}
				}
				else
				{
					this.EnableUse = input.ReadBool();
				}
			}
		}

		// Token: 0x04008D0E RID: 36110
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008D0F RID: 36111
		public const int LootDataFieldNumber = 5;

		// Token: 0x04008D10 RID: 36112
		private static readonly FieldCodec<RoverRogueGainEntry> _repeated_lootData_codec = FieldCodec.ForMessage<RoverRogueGainEntry>(42U, RoverRogueGainEntry.Parser);

		// Token: 0x04008D11 RID: 36113
		private readonly RepeatedField<RoverRogueGainEntry> lootData_ = new RepeatedField<RoverRogueGainEntry>();

		// Token: 0x04008D12 RID: 36114
		public const int EnableUseFieldNumber = 2;

		// Token: 0x04008D13 RID: 36115
		private bool enableUse_;
	}
}
