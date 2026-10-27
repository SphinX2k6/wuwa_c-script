using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200131E RID: 4894
	[NetMessage(EMessageId.TargetGearHitRequest)]
	public sealed class TargetGearHitRequest : IMessage<TargetGearHitRequest>, IMessage, IEquatable<TargetGearHitRequest>, IDeepCloneable<TargetGearHitRequest>, IBufferMessage
	{
		// Token: 0x0601A022 RID: 106530 RVA: 0x003C75C7 File Offset: 0x003C57C7
		[NullableContext(1)]
		public static TargetGearHitRequest Create()
		{
			return new TargetGearHitRequest();
		}

		// Token: 0x170057B7 RID: 22455
		// (get) Token: 0x0601A023 RID: 106531 RVA: 0x003C75CE File Offset: 0x003C57CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170057B8 RID: 22456
		// (get) Token: 0x0601A024 RID: 106532 RVA: 0x003C75D1 File Offset: 0x003C57D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TargetGearHitRequest.Descriptor;
			}
		}

		// Token: 0x0601A025 RID: 106533 RVA: 0x003C75D8 File Offset: 0x003C57D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TargetGearHitRequest()
		{
		}

		// Token: 0x0601A026 RID: 106534 RVA: 0x003C75F8 File Offset: 0x003C57F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TargetGearHitRequest(TargetGearHitRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.bulletTypes_ = other.bulletTypes_.Clone();
			this.bulletId_ = other.bulletId_;
			this.hitParts_ = other.hitParts_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A027 RID: 106535 RVA: 0x003C7656 File Offset: 0x003C5856
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TargetGearHitRequest Clone()
		{
			return new TargetGearHitRequest(this);
		}

		// Token: 0x170057B9 RID: 22457
		// (get) Token: 0x0601A028 RID: 106536 RVA: 0x003C765E File Offset: 0x003C585E
		// (set) Token: 0x0601A029 RID: 106537 RVA: 0x003C7666 File Offset: 0x003C5866
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x170057BA RID: 22458
		// (get) Token: 0x0601A02A RID: 106538 RVA: 0x003C766F File Offset: 0x003C586F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BulletTypes
		{
			get
			{
				return this.bulletTypes_;
			}
		}

		// Token: 0x170057BB RID: 22459
		// (get) Token: 0x0601A02B RID: 106539 RVA: 0x003C7677 File Offset: 0x003C5877
		// (set) Token: 0x0601A02C RID: 106540 RVA: 0x003C767F File Offset: 0x003C587F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BulletId
		{
			get
			{
				return this.bulletId_;
			}
			set
			{
				this.bulletId_ = value;
			}
		}

		// Token: 0x170057BC RID: 22460
		// (get) Token: 0x0601A02D RID: 106541 RVA: 0x003C7688 File Offset: 0x003C5888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> HitParts
		{
			get
			{
				return this.hitParts_;
			}
		}

		// Token: 0x0601A02E RID: 106542 RVA: 0x003C7690 File Offset: 0x003C5890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TargetGearHitRequest);
		}

		// Token: 0x0601A02F RID: 106543 RVA: 0x003C76A0 File Offset: 0x003C58A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TargetGearHitRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.bulletTypes_.Equals(other.bulletTypes_) && this.BulletId == other.BulletId && this.hitParts_.Equals(other.hitParts_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A030 RID: 106544 RVA: 0x003C7714 File Offset: 0x003C5914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			num ^= this.bulletTypes_.GetHashCode();
			if (this.BulletId != 0)
			{
				num ^= this.BulletId.GetHashCode();
			}
			num ^= this.hitParts_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A031 RID: 106545 RVA: 0x003C7788 File Offset: 0x003C5988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A032 RID: 106546 RVA: 0x003C7795 File Offset: 0x003C5995
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A033 RID: 106547 RVA: 0x003C77A0 File Offset: 0x003C59A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BulletId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.BulletId);
			}
			this.hitParts_.WriteTo(ref output, TargetGearHitRequest._repeated_hitParts_codec);
			this.bulletTypes_.WriteTo(ref output, TargetGearHitRequest._repeated_bulletTypes_codec);
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A034 RID: 106548 RVA: 0x003C781C File Offset: 0x003C5A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			num += this.bulletTypes_.CalculateSize(TargetGearHitRequest._repeated_bulletTypes_codec);
			if (this.BulletId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BulletId);
			}
			num += this.hitParts_.CalculateSize(TargetGearHitRequest._repeated_hitParts_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A035 RID: 106549 RVA: 0x003C7898 File Offset: 0x003C5A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TargetGearHitRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this.bulletTypes_.Add(other.bulletTypes_);
			if (other.BulletId != 0)
			{
				this.BulletId = other.BulletId;
			}
			this.hitParts_.Add(other.hitParts_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A036 RID: 106550 RVA: 0x003C790A File Offset: 0x003C5B0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A037 RID: 106551 RVA: 0x003C7914 File Offset: 0x003C5B14
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
					if (num == 24U)
					{
						this.BulletId = input.ReadInt32();
						continue;
					}
					if (num == 42U)
					{
						this.hitParts_.AddEntriesFrom(ref input, TargetGearHitRequest._repeated_hitParts_codec);
						continue;
					}
				}
				else
				{
					if (num == 80U || num == 82U)
					{
						this.bulletTypes_.AddEntriesFrom(ref input, TargetGearHitRequest._repeated_bulletTypes_codec);
						continue;
					}
					if (num == 96U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040097F2 RID: 38898
		private UnknownFieldSet _unknownFields;

		// Token: 0x040097F3 RID: 38899
		public const int EntityIdFieldNumber = 12;

		// Token: 0x040097F4 RID: 38900
		private long entityId_;

		// Token: 0x040097F5 RID: 38901
		public const int BulletTypesFieldNumber = 10;

		// Token: 0x040097F6 RID: 38902
		private static readonly FieldCodec<int> _repeated_bulletTypes_codec = FieldCodec.ForInt32(82U);

		// Token: 0x040097F7 RID: 38903
		private readonly RepeatedField<int> bulletTypes_ = new RepeatedField<int>();

		// Token: 0x040097F8 RID: 38904
		public const int BulletIdFieldNumber = 3;

		// Token: 0x040097F9 RID: 38905
		private int bulletId_;

		// Token: 0x040097FA RID: 38906
		public const int HitPartsFieldNumber = 5;

		// Token: 0x040097FB RID: 38907
		private static readonly FieldCodec<string> _repeated_hitParts_codec = FieldCodec.ForString(42U);

		// Token: 0x040097FC RID: 38908
		private readonly RepeatedField<string> hitParts_ = new RepeatedField<string>();
	}
}
