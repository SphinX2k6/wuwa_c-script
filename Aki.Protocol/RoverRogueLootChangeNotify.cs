using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200110C RID: 4364
	[NetMessage(EMessageId.RoverRogueLootChangeNotify)]
	public sealed class RoverRogueLootChangeNotify : IMessage<RoverRogueLootChangeNotify>, IMessage, IEquatable<RoverRogueLootChangeNotify>, IDeepCloneable<RoverRogueLootChangeNotify>, IBufferMessage
	{
		// Token: 0x0601746C RID: 95340 RVA: 0x0036140F File Offset: 0x0035F60F
		[NullableContext(1)]
		public static RoverRogueLootChangeNotify Create()
		{
			return new RoverRogueLootChangeNotify();
		}

		// Token: 0x17004E0F RID: 19983
		// (get) Token: 0x0601746D RID: 95341 RVA: 0x00361416 File Offset: 0x0035F616
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E10 RID: 19984
		// (get) Token: 0x0601746E RID: 95342 RVA: 0x00361419 File Offset: 0x0035F619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueLootChangeNotify.Descriptor;
			}
		}

		// Token: 0x0601746F RID: 95343 RVA: 0x00361420 File Offset: 0x0035F620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueLootChangeNotify()
		{
		}

		// Token: 0x06017470 RID: 95344 RVA: 0x00361433 File Offset: 0x0035F633
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueLootChangeNotify(RoverRogueLootChangeNotify other) : this()
		{
			this.lootData_ = other.lootData_.Clone();
			this.enableUse_ = other.enableUse_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017471 RID: 95345 RVA: 0x00361469 File Offset: 0x0035F669
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueLootChangeNotify Clone()
		{
			return new RoverRogueLootChangeNotify(this);
		}

		// Token: 0x17004E11 RID: 19985
		// (get) Token: 0x06017472 RID: 95346 RVA: 0x00361471 File Offset: 0x0035F671
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueGainEntry> LootData
		{
			get
			{
				return this.lootData_;
			}
		}

		// Token: 0x17004E12 RID: 19986
		// (get) Token: 0x06017473 RID: 95347 RVA: 0x00361479 File Offset: 0x0035F679
		// (set) Token: 0x06017474 RID: 95348 RVA: 0x00361481 File Offset: 0x0035F681
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

		// Token: 0x06017475 RID: 95349 RVA: 0x0036148A File Offset: 0x0035F68A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueLootChangeNotify);
		}

		// Token: 0x06017476 RID: 95350 RVA: 0x00361498 File Offset: 0x0035F698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueLootChangeNotify other)
		{
			return other != null && (other == this || (this.lootData_.Equals(other.lootData_) && this.EnableUse == other.EnableUse && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017477 RID: 95351 RVA: 0x003614E8 File Offset: 0x0035F6E8
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

		// Token: 0x06017478 RID: 95352 RVA: 0x00361535 File Offset: 0x0035F735
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017479 RID: 95353 RVA: 0x00361542 File Offset: 0x0035F742
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601747A RID: 95354 RVA: 0x0036154C File Offset: 0x0035F74C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EnableUse)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.EnableUse);
			}
			this.lootData_.WriteTo(ref output, RoverRogueLootChangeNotify._repeated_lootData_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601747B RID: 95355 RVA: 0x0036159C File Offset: 0x0035F79C
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

		// Token: 0x0601747C RID: 95356 RVA: 0x003615E4 File Offset: 0x0035F7E4
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

		// Token: 0x0601747D RID: 95357 RVA: 0x00361631 File Offset: 0x0035F831
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601747E RID: 95358 RVA: 0x0036163C File Offset: 0x0035F83C
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
				if (num != 24U)
				{
					if (num != 58U)
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

		// Token: 0x04008A7B RID: 35451
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008A7C RID: 35452
		public const int LootDataFieldNumber = 7;

		// Token: 0x04008A7D RID: 35453
		private static readonly FieldCodec<RoverRogueGainEntry> _repeated_lootData_codec = FieldCodec.ForMessage<RoverRogueGainEntry>(58U, RoverRogueGainEntry.Parser);

		// Token: 0x04008A7E RID: 35454
		private readonly RepeatedField<RoverRogueGainEntry> lootData_ = new RepeatedField<RoverRogueGainEntry>();

		// Token: 0x04008A7F RID: 35455
		public const int EnableUseFieldNumber = 3;

		// Token: 0x04008A80 RID: 35456
		private bool enableUse_;
	}
}
