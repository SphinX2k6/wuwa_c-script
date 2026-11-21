using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013D7 RID: 5079
	[NetMessage(EMessageId.ThroughTrainForceRemindNotify)]
	public sealed class ThroughTrainForceRemindNotify : IMessage<ThroughTrainForceRemindNotify>, IMessage, IEquatable<ThroughTrainForceRemindNotify>, IDeepCloneable<ThroughTrainForceRemindNotify>, IBufferMessage
	{
		// Token: 0x0601B058 RID: 110680 RVA: 0x003EF2B5 File Offset: 0x003ED4B5
		[NullableContext(1)]
		public static ThroughTrainForceRemindNotify Create()
		{
			return new ThroughTrainForceRemindNotify();
		}

		// Token: 0x17005B81 RID: 23425
		// (get) Token: 0x0601B059 RID: 110681 RVA: 0x003EF2BC File Offset: 0x003ED4BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B82 RID: 23426
		// (get) Token: 0x0601B05A RID: 110682 RVA: 0x003EF2BF File Offset: 0x003ED4BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ThroughTrainForceRemindNotify.Descriptor;
			}
		}

		// Token: 0x0601B05B RID: 110683 RVA: 0x003EF2C6 File Offset: 0x003ED4C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThroughTrainForceRemindNotify()
		{
		}

		// Token: 0x0601B05C RID: 110684 RVA: 0x003EF2CE File Offset: 0x003ED4CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThroughTrainForceRemindNotify(ThroughTrainForceRemindNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B05D RID: 110685 RVA: 0x003EF2F3 File Offset: 0x003ED4F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThroughTrainForceRemindNotify Clone()
		{
			return new ThroughTrainForceRemindNotify(this);
		}

		// Token: 0x17005B83 RID: 23427
		// (get) Token: 0x0601B05E RID: 110686 RVA: 0x003EF2FB File Offset: 0x003ED4FB
		// (set) Token: 0x0601B05F RID: 110687 RVA: 0x003EF303 File Offset: 0x003ED503
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x0601B060 RID: 110688 RVA: 0x003EF30C File Offset: 0x003ED50C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ThroughTrainForceRemindNotify);
		}

		// Token: 0x0601B061 RID: 110689 RVA: 0x003EF31A File Offset: 0x003ED51A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ThroughTrainForceRemindNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B062 RID: 110690 RVA: 0x003EF348 File Offset: 0x003ED548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B063 RID: 110691 RVA: 0x003EF387 File Offset: 0x003ED587
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B064 RID: 110692 RVA: 0x003EF394 File Offset: 0x003ED594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B065 RID: 110693 RVA: 0x003EF39D File Offset: 0x003ED59D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B066 RID: 110694 RVA: 0x003EF3D0 File Offset: 0x003ED5D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B067 RID: 110695 RVA: 0x003EF40E File Offset: 0x003ED60E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ThroughTrainForceRemindNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B068 RID: 110696 RVA: 0x003EF43F File Offset: 0x003ED63F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B069 RID: 110697 RVA: 0x003EF448 File Offset: 0x003ED648
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009DDD RID: 40413
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009DDE RID: 40414
		public const int ActivityIdFieldNumber = 6;

		// Token: 0x04009DDF RID: 40415
		private int activityId_;
	}
}
