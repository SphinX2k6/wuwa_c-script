using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BB8 RID: 3000
	[NetMessage(EMessageId.PartUpdatePush)]
	public sealed class PartUpdatePush : IMessage<PartUpdatePush>, IMessage, IEquatable<PartUpdatePush>, IDeepCloneable<PartUpdatePush>, IBufferMessage
	{
		// Token: 0x0601046F RID: 66671 RVA: 0x00260528 File Offset: 0x0025E728
		[NullableContext(1)]
		public static PartUpdatePush Create()
		{
			return new PartUpdatePush();
		}

		// Token: 0x1700355F RID: 13663
		// (get) Token: 0x06010470 RID: 66672 RVA: 0x0026052F File Offset: 0x0025E72F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003560 RID: 13664
		// (get) Token: 0x06010471 RID: 66673 RVA: 0x00260532 File Offset: 0x0025E732
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartUpdatePush.Descriptor;
			}
		}

		// Token: 0x06010472 RID: 66674 RVA: 0x00260539 File Offset: 0x0025E739
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartUpdatePush()
		{
		}

		// Token: 0x06010473 RID: 66675 RVA: 0x0026054C File Offset: 0x0025E74C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartUpdatePush(PartUpdatePush other) : this()
		{
			this.entityId_ = other.entityId_;
			this.partUpdateInfos_ = other.partUpdateInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010474 RID: 66676 RVA: 0x00260582 File Offset: 0x0025E782
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartUpdatePush Clone()
		{
			return new PartUpdatePush(this);
		}

		// Token: 0x17003561 RID: 13665
		// (get) Token: 0x06010475 RID: 66677 RVA: 0x0026058A File Offset: 0x0025E78A
		// (set) Token: 0x06010476 RID: 66678 RVA: 0x00260592 File Offset: 0x0025E792
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

		// Token: 0x17003562 RID: 13666
		// (get) Token: 0x06010477 RID: 66679 RVA: 0x0026059B File Offset: 0x0025E79B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PartUpdateInfo> PartUpdateInfos
		{
			get
			{
				return this.partUpdateInfos_;
			}
		}

		// Token: 0x06010478 RID: 66680 RVA: 0x002605A3 File Offset: 0x0025E7A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartUpdatePush);
		}

		// Token: 0x06010479 RID: 66681 RVA: 0x002605B4 File Offset: 0x0025E7B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PartUpdatePush other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.partUpdateInfos_.Equals(other.partUpdateInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601047A RID: 66682 RVA: 0x00260604 File Offset: 0x0025E804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			num ^= this.partUpdateInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601047B RID: 66683 RVA: 0x00260651 File Offset: 0x0025E851
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601047C RID: 66684 RVA: 0x0026065E File Offset: 0x0025E85E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601047D RID: 66685 RVA: 0x00260668 File Offset: 0x0025E868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.partUpdateInfos_.WriteTo(ref output, PartUpdatePush._repeated_partUpdateInfos_codec);
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601047E RID: 66686 RVA: 0x002606B8 File Offset: 0x0025E8B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			num += this.partUpdateInfos_.CalculateSize(PartUpdatePush._repeated_partUpdateInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601047F RID: 66687 RVA: 0x0026070C File Offset: 0x0025E90C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PartUpdatePush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this.partUpdateInfos_.Add(other.partUpdateInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010480 RID: 66688 RVA: 0x00260759 File Offset: 0x0025E959
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010481 RID: 66689 RVA: 0x00260764 File Offset: 0x0025E964
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
				if (num != 50U)
				{
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					this.partUpdateInfos_.AddEntriesFrom(ref input, PartUpdatePush._repeated_partUpdateInfos_codec);
				}
			}
		}

		// Token: 0x040067DF RID: 26591
		private UnknownFieldSet _unknownFields;

		// Token: 0x040067E0 RID: 26592
		public const int EntityIdFieldNumber = 8;

		// Token: 0x040067E1 RID: 26593
		private long entityId_;

		// Token: 0x040067E2 RID: 26594
		public const int PartUpdateInfosFieldNumber = 6;

		// Token: 0x040067E3 RID: 26595
		private static readonly FieldCodec<PartUpdateInfo> _repeated_partUpdateInfos_codec = FieldCodec.ForMessage<PartUpdateInfo>(50U, PartUpdateInfo.Parser);

		// Token: 0x040067E4 RID: 26596
		private readonly RepeatedField<PartUpdateInfo> partUpdateInfos_ = new RepeatedField<PartUpdateInfo>();
	}
}
