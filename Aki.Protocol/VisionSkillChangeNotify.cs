using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001558 RID: 5464
	[NetMessage(EMessageId.VisionSkillChangeNotify)]
	public sealed class VisionSkillChangeNotify : IMessage<VisionSkillChangeNotify>, IMessage, IEquatable<VisionSkillChangeNotify>, IDeepCloneable<VisionSkillChangeNotify>, IBufferMessage
	{
		// Token: 0x0601CF0E RID: 118542 RVA: 0x004316BB File Offset: 0x0042F8BB
		[NullableContext(1)]
		public static VisionSkillChangeNotify Create()
		{
			return new VisionSkillChangeNotify();
		}

		// Token: 0x170061ED RID: 25069
		// (get) Token: 0x0601CF0F RID: 118543 RVA: 0x004316C2 File Offset: 0x0042F8C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170061EE RID: 25070
		// (get) Token: 0x0601CF10 RID: 118544 RVA: 0x004316C5 File Offset: 0x0042F8C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VisionSkillChangeNotify.Descriptor;
			}
		}

		// Token: 0x0601CF11 RID: 118545 RVA: 0x004316CC File Offset: 0x0042F8CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionSkillChangeNotify()
		{
		}

		// Token: 0x0601CF12 RID: 118546 RVA: 0x004316E0 File Offset: 0x0042F8E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionSkillChangeNotify(VisionSkillChangeNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.visionSkillInfos_ = other.visionSkillInfos_.Clone();
			this.phantomSkillInfo_ = ((other.phantomSkillInfo_ != null) ? other.phantomSkillInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CF13 RID: 118547 RVA: 0x0043173D File Offset: 0x0042F93D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionSkillChangeNotify Clone()
		{
			return new VisionSkillChangeNotify(this);
		}

		// Token: 0x170061EF RID: 25071
		// (get) Token: 0x0601CF14 RID: 118548 RVA: 0x00431745 File Offset: 0x0042F945
		// (set) Token: 0x0601CF15 RID: 118549 RVA: 0x0043174D File Offset: 0x0042F94D
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

		// Token: 0x170061F0 RID: 25072
		// (get) Token: 0x0601CF16 RID: 118550 RVA: 0x00431756 File Offset: 0x0042F956
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<VisionSkillInformation> VisionSkillInfos
		{
			get
			{
				return this.visionSkillInfos_;
			}
		}

		// Token: 0x170061F1 RID: 25073
		// (get) Token: 0x0601CF17 RID: 118551 RVA: 0x0043175E File Offset: 0x0042F95E
		// (set) Token: 0x0601CF18 RID: 118552 RVA: 0x00431766 File Offset: 0x0042F966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionSkillInformation PhantomSkillInfo
		{
			get
			{
				return this.phantomSkillInfo_;
			}
			set
			{
				this.phantomSkillInfo_ = value;
			}
		}

		// Token: 0x0601CF19 RID: 118553 RVA: 0x0043176F File Offset: 0x0042F96F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VisionSkillChangeNotify);
		}

		// Token: 0x0601CF1A RID: 118554 RVA: 0x00431780 File Offset: 0x0042F980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VisionSkillChangeNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.visionSkillInfos_.Equals(other.visionSkillInfos_) && object.Equals(this.PhantomSkillInfo, other.PhantomSkillInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CF1B RID: 118555 RVA: 0x004317E4 File Offset: 0x0042F9E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			num ^= this.visionSkillInfos_.GetHashCode();
			if (this.phantomSkillInfo_ != null)
			{
				num ^= this.PhantomSkillInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CF1C RID: 118556 RVA: 0x00431847 File Offset: 0x0042FA47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CF1D RID: 118557 RVA: 0x00431854 File Offset: 0x0042FA54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CF1E RID: 118558 RVA: 0x00431860 File Offset: 0x0042FA60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.visionSkillInfos_.WriteTo(ref output, VisionSkillChangeNotify._repeated_visionSkillInfos_codec);
			if (this.phantomSkillInfo_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.PhantomSkillInfo);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CF1F RID: 118559 RVA: 0x004318CC File Offset: 0x0042FACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			num += this.visionSkillInfos_.CalculateSize(VisionSkillChangeNotify._repeated_visionSkillInfos_codec);
			if (this.phantomSkillInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomSkillInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CF20 RID: 118560 RVA: 0x00431938 File Offset: 0x0042FB38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VisionSkillChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this.visionSkillInfos_.Add(other.visionSkillInfos_);
			if (other.phantomSkillInfo_ != null)
			{
				if (this.phantomSkillInfo_ == null)
				{
					this.PhantomSkillInfo = new VisionSkillInformation();
				}
				this.PhantomSkillInfo.MergeFrom(other.PhantomSkillInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CF21 RID: 118561 RVA: 0x004319B1 File Offset: 0x0042FBB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CF22 RID: 118562 RVA: 0x004319BC File Offset: 0x0042FBBC
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
				if (num != 10U)
				{
					if (num != 66U)
					{
						if (num != 88U)
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
						if (this.phantomSkillInfo_ == null)
						{
							this.PhantomSkillInfo = new VisionSkillInformation();
						}
						input.ReadMessage(this.PhantomSkillInfo);
					}
				}
				else
				{
					this.visionSkillInfos_.AddEntriesFrom(ref input, VisionSkillChangeNotify._repeated_visionSkillInfos_codec);
				}
			}
		}

		// Token: 0x0400A660 RID: 42592
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A661 RID: 42593
		public const int EntityIdFieldNumber = 11;

		// Token: 0x0400A662 RID: 42594
		private long entityId_;

		// Token: 0x0400A663 RID: 42595
		public const int VisionSkillInfosFieldNumber = 1;

		// Token: 0x0400A664 RID: 42596
		private static readonly FieldCodec<VisionSkillInformation> _repeated_visionSkillInfos_codec = FieldCodec.ForMessage<VisionSkillInformation>(10U, VisionSkillInformation.Parser);

		// Token: 0x0400A665 RID: 42597
		private readonly RepeatedField<VisionSkillInformation> visionSkillInfos_ = new RepeatedField<VisionSkillInformation>();

		// Token: 0x0400A666 RID: 42598
		public const int PhantomSkillInfoFieldNumber = 8;

		// Token: 0x0400A667 RID: 42599
		private VisionSkillInformation phantomSkillInfo_;
	}
}
