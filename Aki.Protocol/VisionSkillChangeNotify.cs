using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014E2 RID: 5346
	[NetMessage(EMessageId.VisionSkillChangeNotify)]
	public sealed class VisionSkillChangeNotify : IMessage<VisionSkillChangeNotify>, IMessage, IEquatable<VisionSkillChangeNotify>, IDeepCloneable<VisionSkillChangeNotify>, IBufferMessage
	{
		// Token: 0x0601C447 RID: 115783 RVA: 0x00415BFF File Offset: 0x00413DFF
		[NullableContext(1)]
		public static VisionSkillChangeNotify Create()
		{
			return new VisionSkillChangeNotify();
		}

		// Token: 0x17005F4C RID: 24396
		// (get) Token: 0x0601C448 RID: 115784 RVA: 0x00415C06 File Offset: 0x00413E06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F4D RID: 24397
		// (get) Token: 0x0601C449 RID: 115785 RVA: 0x00415C09 File Offset: 0x00413E09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VisionSkillChangeNotify.Descriptor;
			}
		}

		// Token: 0x0601C44A RID: 115786 RVA: 0x00415C10 File Offset: 0x00413E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionSkillChangeNotify()
		{
		}

		// Token: 0x0601C44B RID: 115787 RVA: 0x00415C24 File Offset: 0x00413E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionSkillChangeNotify(VisionSkillChangeNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.visionSkillInfos_ = other.visionSkillInfos_.Clone();
			this.phantomSkillInfo_ = ((other.phantomSkillInfo_ != null) ? other.phantomSkillInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C44C RID: 115788 RVA: 0x00415C81 File Offset: 0x00413E81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionSkillChangeNotify Clone()
		{
			return new VisionSkillChangeNotify(this);
		}

		// Token: 0x17005F4E RID: 24398
		// (get) Token: 0x0601C44D RID: 115789 RVA: 0x00415C89 File Offset: 0x00413E89
		// (set) Token: 0x0601C44E RID: 115790 RVA: 0x00415C91 File Offset: 0x00413E91
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

		// Token: 0x17005F4F RID: 24399
		// (get) Token: 0x0601C44F RID: 115791 RVA: 0x00415C9A File Offset: 0x00413E9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<VisionSkillInformation> VisionSkillInfos
		{
			get
			{
				return this.visionSkillInfos_;
			}
		}

		// Token: 0x17005F50 RID: 24400
		// (get) Token: 0x0601C450 RID: 115792 RVA: 0x00415CA2 File Offset: 0x00413EA2
		// (set) Token: 0x0601C451 RID: 115793 RVA: 0x00415CAA File Offset: 0x00413EAA
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

		// Token: 0x0601C452 RID: 115794 RVA: 0x00415CB3 File Offset: 0x00413EB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VisionSkillChangeNotify);
		}

		// Token: 0x0601C453 RID: 115795 RVA: 0x00415CC4 File Offset: 0x00413EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VisionSkillChangeNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.visionSkillInfos_.Equals(other.visionSkillInfos_) && object.Equals(this.PhantomSkillInfo, other.PhantomSkillInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C454 RID: 115796 RVA: 0x00415D28 File Offset: 0x00413F28
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

		// Token: 0x0601C455 RID: 115797 RVA: 0x00415D8B File Offset: 0x00413F8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C456 RID: 115798 RVA: 0x00415D98 File Offset: 0x00413F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C457 RID: 115799 RVA: 0x00415DA4 File Offset: 0x00413FA4
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
				output.WriteRawTag(104);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C458 RID: 115800 RVA: 0x00415E10 File Offset: 0x00414010
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

		// Token: 0x0601C459 RID: 115801 RVA: 0x00415E7C File Offset: 0x0041407C
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

		// Token: 0x0601C45A RID: 115802 RVA: 0x00415EF5 File Offset: 0x004140F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C45B RID: 115803 RVA: 0x00415F00 File Offset: 0x00414100
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
				if (num != 58U)
				{
					if (num != 66U)
					{
						if (num != 104U)
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

		// Token: 0x0400A207 RID: 41479
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A208 RID: 41480
		public const int EntityIdFieldNumber = 13;

		// Token: 0x0400A209 RID: 41481
		private long entityId_;

		// Token: 0x0400A20A RID: 41482
		public const int VisionSkillInfosFieldNumber = 7;

		// Token: 0x0400A20B RID: 41483
		private static readonly FieldCodec<VisionSkillInformation> _repeated_visionSkillInfos_codec = FieldCodec.ForMessage<VisionSkillInformation>(58U, VisionSkillInformation.Parser);

		// Token: 0x0400A20C RID: 41484
		private readonly RepeatedField<VisionSkillInformation> visionSkillInfos_ = new RepeatedField<VisionSkillInformation>();

		// Token: 0x0400A20D RID: 41485
		public const int PhantomSkillInfoFieldNumber = 8;

		// Token: 0x0400A20E RID: 41486
		private VisionSkillInformation phantomSkillInfo_;
	}
}
