using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001433 RID: 5171
	public sealed class TrapDefenseMonsterPbGroup : IMessage<TrapDefenseMonsterPbGroup>, IMessage, IEquatable<TrapDefenseMonsterPbGroup>, IDeepCloneable<TrapDefenseMonsterPbGroup>, IBufferMessage
	{
		// Token: 0x0601B64D RID: 112205 RVA: 0x003F775C File Offset: 0x003F595C
		[NullableContext(1)]
		public static TrapDefenseMonsterPbGroup Create()
		{
			return new TrapDefenseMonsterPbGroup();
		}

		// Token: 0x17005C5D RID: 23645
		// (get) Token: 0x0601B64E RID: 112206 RVA: 0x003F7763 File Offset: 0x003F5963
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TrapDefenseMonsterPbGroup> Parser
		{
			get
			{
				return TrapDefenseMonsterPbGroup._parser;
			}
		}

		// Token: 0x17005C5E RID: 23646
		// (get) Token: 0x0601B64F RID: 112207 RVA: 0x003F776A File Offset: 0x003F596A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C5F RID: 23647
		// (get) Token: 0x0601B650 RID: 112208 RVA: 0x003F776D File Offset: 0x003F596D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseMonsterPbGroup.Descriptor;
			}
		}

		// Token: 0x0601B651 RID: 112209 RVA: 0x003F7774 File Offset: 0x003F5974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseMonsterPbGroup()
		{
		}

		// Token: 0x0601B652 RID: 112210 RVA: 0x003F7788 File Offset: 0x003F5988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseMonsterPbGroup(TrapDefenseMonsterPbGroup other) : this()
		{
			this.monsterConfigIds_ = other.monsterConfigIds_.Clone();
			this.previewDelayTime_ = other.previewDelayTime_;
			this.previewIntervalTime_ = other.previewIntervalTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B653 RID: 112211 RVA: 0x003F77D5 File Offset: 0x003F59D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseMonsterPbGroup Clone()
		{
			return new TrapDefenseMonsterPbGroup(this);
		}

		// Token: 0x17005C60 RID: 23648
		// (get) Token: 0x0601B654 RID: 112212 RVA: 0x003F77DD File Offset: 0x003F59DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MonsterConfigIds
		{
			get
			{
				return this.monsterConfigIds_;
			}
		}

		// Token: 0x17005C61 RID: 23649
		// (get) Token: 0x0601B655 RID: 112213 RVA: 0x003F77E5 File Offset: 0x003F59E5
		// (set) Token: 0x0601B656 RID: 112214 RVA: 0x003F77ED File Offset: 0x003F59ED
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

		// Token: 0x17005C62 RID: 23650
		// (get) Token: 0x0601B657 RID: 112215 RVA: 0x003F77F6 File Offset: 0x003F59F6
		// (set) Token: 0x0601B658 RID: 112216 RVA: 0x003F77FE File Offset: 0x003F59FE
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

		// Token: 0x0601B659 RID: 112217 RVA: 0x003F7807 File Offset: 0x003F5A07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseMonsterPbGroup);
		}

		// Token: 0x0601B65A RID: 112218 RVA: 0x003F7818 File Offset: 0x003F5A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseMonsterPbGroup other)
		{
			return other != null && (other == this || (this.monsterConfigIds_.Equals(other.monsterConfigIds_) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PreviewDelayTime, other.PreviewDelayTime) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PreviewIntervalTime, other.PreviewIntervalTime) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B65B RID: 112219 RVA: 0x003F788C File Offset: 0x003F5A8C
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

		// Token: 0x0601B65C RID: 112220 RVA: 0x003F7900 File Offset: 0x003F5B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B65D RID: 112221 RVA: 0x003F790D File Offset: 0x003F5B0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B65E RID: 112222 RVA: 0x003F7918 File Offset: 0x003F5B18
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

		// Token: 0x0601B65F RID: 112223 RVA: 0x003F798C File Offset: 0x003F5B8C
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

		// Token: 0x0601B660 RID: 112224 RVA: 0x003F79E8 File Offset: 0x003F5BE8
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

		// Token: 0x0601B661 RID: 112225 RVA: 0x003F7A53 File Offset: 0x003F5C53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B662 RID: 112226 RVA: 0x003F7A5C File Offset: 0x003F5C5C
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

		// Token: 0x04009E20 RID: 40480
		private static readonly MessageParser<TrapDefenseMonsterPbGroup> _parser = new MessageParser<TrapDefenseMonsterPbGroup>(() => new TrapDefenseMonsterPbGroup());

		// Token: 0x04009E21 RID: 40481
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E22 RID: 40482
		public const int MonsterConfigIdsFieldNumber = 1;

		// Token: 0x04009E23 RID: 40483
		private static readonly FieldCodec<int> _repeated_monsterConfigIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04009E24 RID: 40484
		private readonly RepeatedField<int> monsterConfigIds_ = new RepeatedField<int>();

		// Token: 0x04009E25 RID: 40485
		public const int PreviewDelayTimeFieldNumber = 2;

		// Token: 0x04009E26 RID: 40486
		private float previewDelayTime_;

		// Token: 0x04009E27 RID: 40487
		public const int PreviewIntervalTimeFieldNumber = 3;

		// Token: 0x04009E28 RID: 40488
		private float previewIntervalTime_;
	}
}
