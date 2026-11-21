using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001253 RID: 4691
	[NetMessage(EMessageId.SignActivityKeepTimeNotify)]
	public sealed class SignActivityKeepTimeNotify : IMessage<SignActivityKeepTimeNotify>, IMessage, IEquatable<SignActivityKeepTimeNotify>, IDeepCloneable<SignActivityKeepTimeNotify>, IBufferMessage
	{
		// Token: 0x060190B7 RID: 102583 RVA: 0x003A6AB5 File Offset: 0x003A4CB5
		[NullableContext(1)]
		public static SignActivityKeepTimeNotify Create()
		{
			return new SignActivityKeepTimeNotify();
		}

		// Token: 0x170054A2 RID: 21666
		// (get) Token: 0x060190B8 RID: 102584 RVA: 0x003A6ABC File Offset: 0x003A4CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170054A3 RID: 21667
		// (get) Token: 0x060190B9 RID: 102585 RVA: 0x003A6ABF File Offset: 0x003A4CBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SignActivityKeepTimeNotify.Descriptor;
			}
		}

		// Token: 0x060190BA RID: 102586 RVA: 0x003A6AC6 File Offset: 0x003A4CC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignActivityKeepTimeNotify()
		{
		}

		// Token: 0x060190BB RID: 102587 RVA: 0x003A6ACE File Offset: 0x003A4CCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignActivityKeepTimeNotify(SignActivityKeepTimeNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.keepTime_ = other.keepTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060190BC RID: 102588 RVA: 0x003A6AFF File Offset: 0x003A4CFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignActivityKeepTimeNotify Clone()
		{
			return new SignActivityKeepTimeNotify(this);
		}

		// Token: 0x170054A4 RID: 21668
		// (get) Token: 0x060190BD RID: 102589 RVA: 0x003A6B07 File Offset: 0x003A4D07
		// (set) Token: 0x060190BE RID: 102590 RVA: 0x003A6B0F File Offset: 0x003A4D0F
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

		// Token: 0x170054A5 RID: 21669
		// (get) Token: 0x060190BF RID: 102591 RVA: 0x003A6B18 File Offset: 0x003A4D18
		// (set) Token: 0x060190C0 RID: 102592 RVA: 0x003A6B20 File Offset: 0x003A4D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long KeepTime
		{
			get
			{
				return this.keepTime_;
			}
			set
			{
				this.keepTime_ = value;
			}
		}

		// Token: 0x060190C1 RID: 102593 RVA: 0x003A6B29 File Offset: 0x003A4D29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SignActivityKeepTimeNotify);
		}

		// Token: 0x060190C2 RID: 102594 RVA: 0x003A6B37 File Offset: 0x003A4D37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SignActivityKeepTimeNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.KeepTime == other.KeepTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060190C3 RID: 102595 RVA: 0x003A6B78 File Offset: 0x003A4D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.KeepTime != 0L)
			{
				num ^= this.KeepTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060190C4 RID: 102596 RVA: 0x003A6BD0 File Offset: 0x003A4DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060190C5 RID: 102597 RVA: 0x003A6BDD File Offset: 0x003A4DDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060190C6 RID: 102598 RVA: 0x003A6BE8 File Offset: 0x003A4DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ActivityId);
			}
			if (this.KeepTime != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.KeepTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060190C7 RID: 102599 RVA: 0x003A6C40 File Offset: 0x003A4E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.KeepTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.KeepTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060190C8 RID: 102600 RVA: 0x003A6C98 File Offset: 0x003A4E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SignActivityKeepTimeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.KeepTime != 0L)
			{
				this.KeepTime = other.KeepTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060190C9 RID: 102601 RVA: 0x003A6CE8 File Offset: 0x003A4EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060190CA RID: 102602 RVA: 0x003A6CF4 File Offset: 0x003A4EF4
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
				if (num != 8U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.KeepTime = input.ReadInt64();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400946C RID: 37996
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400946D RID: 37997
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x0400946E RID: 37998
		private int activityId_;

		// Token: 0x0400946F RID: 37999
		public const int KeepTimeFieldNumber = 11;

		// Token: 0x04009470 RID: 38000
		private long keepTime_;
	}
}
