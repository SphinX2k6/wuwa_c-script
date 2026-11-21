using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003BC RID: 956
	public sealed class DetectionUnlock : IMessage<DetectionUnlock>, IMessage, IEquatable<DetectionUnlock>, IDeepCloneable<DetectionUnlock>, IBufferMessage
	{
		// Token: 0x06005DE1 RID: 24033 RVA: 0x000E3E61 File Offset: 0x000E2061
		[NullableContext(1)]
		public static DetectionUnlock Create()
		{
			return new DetectionUnlock();
		}

		// Token: 0x1700116D RID: 4461
		// (get) Token: 0x06005DE2 RID: 24034 RVA: 0x000E3E68 File Offset: 0x000E2068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700116E RID: 4462
		// (get) Token: 0x06005DE3 RID: 24035 RVA: 0x000E3E6B File Offset: 0x000E206B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DetectionUnlock.Descriptor;
			}
		}

		// Token: 0x06005DE4 RID: 24036 RVA: 0x000E3E72 File Offset: 0x000E2072
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionUnlock()
		{
		}

		// Token: 0x06005DE5 RID: 24037 RVA: 0x000E3E9C File Offset: 0x000E209C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionUnlock(DetectionUnlock other) : this()
		{
			this.monsterDetectionIds_ = other.monsterDetectionIds_.Clone();
			this.dungeonDetectionIds_ = other.dungeonDetectionIds_.Clone();
			this.silentAreaDetectionIds_ = other.silentAreaDetectionIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005DE6 RID: 24038 RVA: 0x000E3EF3 File Offset: 0x000E20F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionUnlock Clone()
		{
			return new DetectionUnlock(this);
		}

		// Token: 0x1700116F RID: 4463
		// (get) Token: 0x06005DE7 RID: 24039 RVA: 0x000E3EFB File Offset: 0x000E20FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MonsterDetectionIds
		{
			get
			{
				return this.monsterDetectionIds_;
			}
		}

		// Token: 0x17001170 RID: 4464
		// (get) Token: 0x06005DE8 RID: 24040 RVA: 0x000E3F03 File Offset: 0x000E2103
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DungeonDetectionIds
		{
			get
			{
				return this.dungeonDetectionIds_;
			}
		}

		// Token: 0x17001171 RID: 4465
		// (get) Token: 0x06005DE9 RID: 24041 RVA: 0x000E3F0B File Offset: 0x000E210B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SilentAreaDetectionIds
		{
			get
			{
				return this.silentAreaDetectionIds_;
			}
		}

		// Token: 0x06005DEA RID: 24042 RVA: 0x000E3F13 File Offset: 0x000E2113
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DetectionUnlock);
		}

		// Token: 0x06005DEB RID: 24043 RVA: 0x000E3F24 File Offset: 0x000E2124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DetectionUnlock other)
		{
			return other != null && (other == this || (this.monsterDetectionIds_.Equals(other.monsterDetectionIds_) && this.dungeonDetectionIds_.Equals(other.dungeonDetectionIds_) && this.silentAreaDetectionIds_.Equals(other.silentAreaDetectionIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005DEC RID: 24044 RVA: 0x000E3F8C File Offset: 0x000E218C
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

		// Token: 0x06005DED RID: 24045 RVA: 0x000E3FDC File Offset: 0x000E21DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005DEE RID: 24046 RVA: 0x000E3FE9 File Offset: 0x000E21E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005DEF RID: 24047 RVA: 0x000E3FF4 File Offset: 0x000E21F4
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

		// Token: 0x06005DF0 RID: 24048 RVA: 0x000E4048 File Offset: 0x000E2248
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

		// Token: 0x06005DF1 RID: 24049 RVA: 0x000E40A8 File Offset: 0x000E22A8
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

		// Token: 0x06005DF2 RID: 24050 RVA: 0x000E4103 File Offset: 0x000E2303
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005DF3 RID: 24051 RVA: 0x000E410C File Offset: 0x000E230C
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

		// Token: 0x04003706 RID: 14086
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003707 RID: 14087
		public const int MonsterDetectionIdsFieldNumber = 1;

		// Token: 0x04003708 RID: 14088
		private static readonly FieldCodec<int> _repeated_monsterDetectionIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04003709 RID: 14089
		private readonly RepeatedField<int> monsterDetectionIds_ = new RepeatedField<int>();

		// Token: 0x0400370A RID: 14090
		public const int DungeonDetectionIdsFieldNumber = 2;

		// Token: 0x0400370B RID: 14091
		private static readonly FieldCodec<int> _repeated_dungeonDetectionIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x0400370C RID: 14092
		private readonly RepeatedField<int> dungeonDetectionIds_ = new RepeatedField<int>();

		// Token: 0x0400370D RID: 14093
		public const int SilentAreaDetectionIdsFieldNumber = 3;

		// Token: 0x0400370E RID: 14094
		private static readonly FieldCodec<int> _repeated_silentAreaDetectionIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x0400370F RID: 14095
		private readonly RepeatedField<int> silentAreaDetectionIds_ = new RepeatedField<int>();
	}
}
