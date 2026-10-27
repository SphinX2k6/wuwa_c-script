using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003D3 RID: 979
	public sealed class DetectionUnlock : IMessage<DetectionUnlock>, IMessage, IEquatable<DetectionUnlock>, IDeepCloneable<DetectionUnlock>, IBufferMessage
	{
		// Token: 0x06005F71 RID: 24433 RVA: 0x000E6FE1 File Offset: 0x000E51E1
		[NullableContext(1)]
		public static DetectionUnlock Create()
		{
			return new DetectionUnlock();
		}

		// Token: 0x170011C2 RID: 4546
		// (get) Token: 0x06005F72 RID: 24434 RVA: 0x000E6FE8 File Offset: 0x000E51E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011C3 RID: 4547
		// (get) Token: 0x06005F73 RID: 24435 RVA: 0x000E6FEB File Offset: 0x000E51EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DetectionUnlock.Descriptor;
			}
		}

		// Token: 0x06005F74 RID: 24436 RVA: 0x000E6FF2 File Offset: 0x000E51F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionUnlock()
		{
		}

		// Token: 0x06005F75 RID: 24437 RVA: 0x000E701C File Offset: 0x000E521C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionUnlock(DetectionUnlock other) : this()
		{
			this.monsterDetectionIds_ = other.monsterDetectionIds_.Clone();
			this.dungeonDetectionIds_ = other.dungeonDetectionIds_.Clone();
			this.silentAreaDetectionIds_ = other.silentAreaDetectionIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005F76 RID: 24438 RVA: 0x000E7073 File Offset: 0x000E5273
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionUnlock Clone()
		{
			return new DetectionUnlock(this);
		}

		// Token: 0x170011C4 RID: 4548
		// (get) Token: 0x06005F77 RID: 24439 RVA: 0x000E707B File Offset: 0x000E527B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MonsterDetectionIds
		{
			get
			{
				return this.monsterDetectionIds_;
			}
		}

		// Token: 0x170011C5 RID: 4549
		// (get) Token: 0x06005F78 RID: 24440 RVA: 0x000E7083 File Offset: 0x000E5283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DungeonDetectionIds
		{
			get
			{
				return this.dungeonDetectionIds_;
			}
		}

		// Token: 0x170011C6 RID: 4550
		// (get) Token: 0x06005F79 RID: 24441 RVA: 0x000E708B File Offset: 0x000E528B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SilentAreaDetectionIds
		{
			get
			{
				return this.silentAreaDetectionIds_;
			}
		}

		// Token: 0x06005F7A RID: 24442 RVA: 0x000E7093 File Offset: 0x000E5293
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DetectionUnlock);
		}

		// Token: 0x06005F7B RID: 24443 RVA: 0x000E70A4 File Offset: 0x000E52A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DetectionUnlock other)
		{
			return other != null && (other == this || (this.monsterDetectionIds_.Equals(other.monsterDetectionIds_) && this.dungeonDetectionIds_.Equals(other.dungeonDetectionIds_) && this.silentAreaDetectionIds_.Equals(other.silentAreaDetectionIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005F7C RID: 24444 RVA: 0x000E710C File Offset: 0x000E530C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.monsterDetectionIds_.GetHashCode();
			num ^= this.dungeonDetectionIds_.GetHashCode();
			num ^= this.silentAreaDetectionIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005F7D RID: 24445 RVA: 0x000E715C File Offset: 0x000E535C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005F7E RID: 24446 RVA: 0x000E7169 File Offset: 0x000E5369
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005F7F RID: 24447 RVA: 0x000E7174 File Offset: 0x000E5374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.monsterDetectionIds_.WriteTo(ref output, DetectionUnlock._repeated_monsterDetectionIds_codec);
			this.dungeonDetectionIds_.WriteTo(ref output, DetectionUnlock._repeated_dungeonDetectionIds_codec);
			this.silentAreaDetectionIds_.WriteTo(ref output, DetectionUnlock._repeated_silentAreaDetectionIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005F80 RID: 24448 RVA: 0x000E71C8 File Offset: 0x000E53C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.monsterDetectionIds_.CalculateSize(DetectionUnlock._repeated_monsterDetectionIds_codec);
			num += this.dungeonDetectionIds_.CalculateSize(DetectionUnlock._repeated_dungeonDetectionIds_codec);
			num += this.silentAreaDetectionIds_.CalculateSize(DetectionUnlock._repeated_silentAreaDetectionIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005F81 RID: 24449 RVA: 0x000E7228 File Offset: 0x000E5428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DetectionUnlock other)
		{
			if (other == null)
			{
				return;
			}
			this.monsterDetectionIds_.Add(other.monsterDetectionIds_);
			this.dungeonDetectionIds_.Add(other.dungeonDetectionIds_);
			this.silentAreaDetectionIds_.Add(other.silentAreaDetectionIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005F82 RID: 24450 RVA: 0x000E7283 File Offset: 0x000E5483
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005F83 RID: 24451 RVA: 0x000E728C File Offset: 0x000E548C
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
				if (num <= 16U)
				{
					if (num == 8U || num == 10U)
					{
						this.monsterDetectionIds_.AddEntriesFrom(ref input, DetectionUnlock._repeated_monsterDetectionIds_codec);
						continue;
					}
					if (num == 16U)
					{
						goto IL_54;
					}
				}
				else
				{
					if (num == 18U)
					{
						goto IL_54;
					}
					if (num == 24U || num == 26U)
					{
						this.silentAreaDetectionIds_.AddEntriesFrom(ref input, DetectionUnlock._repeated_silentAreaDetectionIds_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_54:
				this.dungeonDetectionIds_.AddEntriesFrom(ref input, DetectionUnlock._repeated_dungeonDetectionIds_codec);
			}
		}

		// Token: 0x04003719 RID: 14105
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400371A RID: 14106
		public const int MonsterDetectionIdsFieldNumber = 1;

		// Token: 0x0400371B RID: 14107
		private static readonly FieldCodec<int> _repeated_monsterDetectionIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x0400371C RID: 14108
		private readonly RepeatedField<int> monsterDetectionIds_ = new RepeatedField<int>();

		// Token: 0x0400371D RID: 14109
		public const int DungeonDetectionIdsFieldNumber = 2;

		// Token: 0x0400371E RID: 14110
		private static readonly FieldCodec<int> _repeated_dungeonDetectionIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x0400371F RID: 14111
		private readonly RepeatedField<int> dungeonDetectionIds_ = new RepeatedField<int>();

		// Token: 0x04003720 RID: 14112
		public const int SilentAreaDetectionIdsFieldNumber = 3;

		// Token: 0x04003721 RID: 14113
		private static readonly FieldCodec<int> _repeated_silentAreaDetectionIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04003722 RID: 14114
		private readonly RepeatedField<int> silentAreaDetectionIds_ = new RepeatedField<int>();
	}
}
