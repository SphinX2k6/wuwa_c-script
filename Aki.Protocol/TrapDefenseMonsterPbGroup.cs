using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014A6 RID: 5286
	public sealed class TrapDefenseMonsterPbGroup : IMessage<TrapDefenseMonsterPbGroup>, IMessage, IEquatable<TrapDefenseMonsterPbGroup>, IDeepCloneable<TrapDefenseMonsterPbGroup>, IBufferMessage
	{
		// Token: 0x0601C0D8 RID: 114904 RVA: 0x00412A30 File Offset: 0x00410C30
		[NullableContext(1)]
		public static TrapDefenseMonsterPbGroup Create()
		{
			return new TrapDefenseMonsterPbGroup();
		}

		// Token: 0x17005EF2 RID: 24306
		// (get) Token: 0x0601C0D9 RID: 114905 RVA: 0x00412A37 File Offset: 0x00410C37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TrapDefenseMonsterPbGroup> Parser
		{
			get
			{
				return TrapDefenseMonsterPbGroup._parser;
			}
		}

		// Token: 0x17005EF3 RID: 24307
		// (get) Token: 0x0601C0DA RID: 114906 RVA: 0x00412A3E File Offset: 0x00410C3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005EF4 RID: 24308
		// (get) Token: 0x0601C0DB RID: 114907 RVA: 0x00412A41 File Offset: 0x00410C41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseMonsterPbGroup.Descriptor;
			}
		}

		// Token: 0x0601C0DC RID: 114908 RVA: 0x00412A48 File Offset: 0x00410C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseMonsterPbGroup()
		{
		}

		// Token: 0x0601C0DD RID: 114909 RVA: 0x00412A5C File Offset: 0x00410C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseMonsterPbGroup(TrapDefenseMonsterPbGroup other) : this()
		{
			this.monsterConfigIds_ = other.monsterConfigIds_.Clone();
			this.previewDelayTime_ = other.previewDelayTime_;
			this.previewIntervalTime_ = other.previewIntervalTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C0DE RID: 114910 RVA: 0x00412AA9 File Offset: 0x00410CA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseMonsterPbGroup Clone()
		{
			return new TrapDefenseMonsterPbGroup(this);
		}

		// Token: 0x17005EF5 RID: 24309
		// (get) Token: 0x0601C0DF RID: 114911 RVA: 0x00412AB1 File Offset: 0x00410CB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MonsterConfigIds
		{
			get
			{
				return this.monsterConfigIds_;
			}
		}

		// Token: 0x17005EF6 RID: 24310
		// (get) Token: 0x0601C0E0 RID: 114912 RVA: 0x00412AB9 File Offset: 0x00410CB9
		// (set) Token: 0x0601C0E1 RID: 114913 RVA: 0x00412AC1 File Offset: 0x00410CC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float PreviewDelayTime
		{
			get
			{
				return this.previewDelayTime_;
			}
			set
			{
				this.previewDelayTime_ = value;
			}
		}

		// Token: 0x17005EF7 RID: 24311
		// (get) Token: 0x0601C0E2 RID: 114914 RVA: 0x00412ACA File Offset: 0x00410CCA
		// (set) Token: 0x0601C0E3 RID: 114915 RVA: 0x00412AD2 File Offset: 0x00410CD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float PreviewIntervalTime
		{
			get
			{
				return this.previewIntervalTime_;
			}
			set
			{
				this.previewIntervalTime_ = value;
			}
		}

		// Token: 0x0601C0E4 RID: 114916 RVA: 0x00412ADB File Offset: 0x00410CDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseMonsterPbGroup);
		}

		// Token: 0x0601C0E5 RID: 114917 RVA: 0x00412AEC File Offset: 0x00410CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseMonsterPbGroup other)
		{
			return other != null && (other == this || (this.monsterConfigIds_.Equals(other.monsterConfigIds_) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PreviewDelayTime, other.PreviewDelayTime) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PreviewIntervalTime, other.PreviewIntervalTime) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C0E6 RID: 114918 RVA: 0x00412B60 File Offset: 0x00410D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.monsterConfigIds_.GetHashCode();
			if (this.PreviewDelayTime != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.PreviewDelayTime);
			}
			if (this.PreviewIntervalTime != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.PreviewIntervalTime);
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C0E7 RID: 114919 RVA: 0x00412BD4 File Offset: 0x00410DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C0E8 RID: 114920 RVA: 0x00412BE1 File Offset: 0x00410DE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C0E9 RID: 114921 RVA: 0x00412BEC File Offset: 0x00410DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.monsterConfigIds_.WriteTo(ref output, TrapDefenseMonsterPbGroup._repeated_monsterConfigIds_codec);
			if (this.PreviewDelayTime != 0f)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.PreviewDelayTime);
			}
			if (this.PreviewIntervalTime != 0f)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.PreviewIntervalTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C0EA RID: 114922 RVA: 0x00412C60 File Offset: 0x00410E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.monsterConfigIds_.CalculateSize(TrapDefenseMonsterPbGroup._repeated_monsterConfigIds_codec);
			if (this.PreviewDelayTime != 0f)
			{
				num += 5;
			}
			if (this.PreviewIntervalTime != 0f)
			{
				num += 5;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C0EB RID: 114923 RVA: 0x00412CBC File Offset: 0x00410EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseMonsterPbGroup other)
		{
			if (other == null)
			{
				return;
			}
			this.monsterConfigIds_.Add(other.monsterConfigIds_);
			if (other.PreviewDelayTime != 0f)
			{
				this.PreviewDelayTime = other.PreviewDelayTime;
			}
			if (other.PreviewIntervalTime != 0f)
			{
				this.PreviewIntervalTime = other.PreviewIntervalTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C0EC RID: 114924 RVA: 0x00412D27 File Offset: 0x00410F27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C0ED RID: 114925 RVA: 0x00412D30 File Offset: 0x00410F30
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
				if (num <= 10U)
				{
					if (num == 8U || num == 10U)
					{
						this.monsterConfigIds_.AddEntriesFrom(ref input, TrapDefenseMonsterPbGroup._repeated_monsterConfigIds_codec);
						continue;
					}
				}
				else
				{
					if (num == 21U)
					{
						this.PreviewDelayTime = input.ReadFloat();
						continue;
					}
					if (num == 29U)
					{
						this.PreviewIntervalTime = input.ReadFloat();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A267 RID: 41575
		private static readonly MessageParser<TrapDefenseMonsterPbGroup> _parser = new MessageParser<TrapDefenseMonsterPbGroup>(() => new TrapDefenseMonsterPbGroup());

		// Token: 0x0400A268 RID: 41576
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A269 RID: 41577
		public const int MonsterConfigIdsFieldNumber = 1;

		// Token: 0x0400A26A RID: 41578
		private static readonly FieldCodec<int> _repeated_monsterConfigIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x0400A26B RID: 41579
		private readonly RepeatedField<int> monsterConfigIds_ = new RepeatedField<int>();

		// Token: 0x0400A26C RID: 41580
		public const int PreviewDelayTimeFieldNumber = 2;

		// Token: 0x0400A26D RID: 41581
		private float previewDelayTime_;

		// Token: 0x0400A26E RID: 41582
		public const int PreviewIntervalTimeFieldNumber = 3;

		// Token: 0x0400A26F RID: 41583
		private float previewIntervalTime_;
	}
}
