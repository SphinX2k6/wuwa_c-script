using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000520 RID: 1312
	[NetMessage(EMessageId.FarmGoldLevelNotify)]
	public sealed class FarmGoldLevelNotify : IMessage<FarmGoldLevelNotify>, IMessage, IEquatable<FarmGoldLevelNotify>, IDeepCloneable<FarmGoldLevelNotify>, IBufferMessage
	{
		// Token: 0x06007B28 RID: 31528 RVA: 0x0012ACC5 File Offset: 0x00128EC5
		[NullableContext(1)]
		public static FarmGoldLevelNotify Create()
		{
			return new FarmGoldLevelNotify();
		}

		// Token: 0x170017E2 RID: 6114
		// (get) Token: 0x06007B29 RID: 31529 RVA: 0x0012ACCC File Offset: 0x00128ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017E3 RID: 6115
		// (get) Token: 0x06007B2A RID: 31530 RVA: 0x0012ACCF File Offset: 0x00128ECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FarmGoldLevelNotify.Descriptor;
			}
		}

		// Token: 0x06007B2B RID: 31531 RVA: 0x0012ACD6 File Offset: 0x00128ED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelNotify()
		{
		}

		// Token: 0x06007B2C RID: 31532 RVA: 0x0012ACE0 File Offset: 0x00128EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelNotify(FarmGoldLevelNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.levelPlayTasks_ = ((other.levelPlayTasks_ != null) ? other.levelPlayTasks_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007B2D RID: 31533 RVA: 0x0012AD2C File Offset: 0x00128F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelNotify Clone()
		{
			return new FarmGoldLevelNotify(this);
		}

		// Token: 0x170017E4 RID: 6116
		// (get) Token: 0x06007B2E RID: 31534 RVA: 0x0012AD34 File Offset: 0x00128F34
		// (set) Token: 0x06007B2F RID: 31535 RVA: 0x0012AD3C File Offset: 0x00128F3C
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

		// Token: 0x170017E5 RID: 6117
		// (get) Token: 0x06007B30 RID: 31536 RVA: 0x0012AD45 File Offset: 0x00128F45
		// (set) Token: 0x06007B31 RID: 31537 RVA: 0x0012AD4D File Offset: 0x00128F4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelPlayInfo LevelPlayTasks
		{
			get
			{
				return this.levelPlayTasks_;
			}
			set
			{
				this.levelPlayTasks_ = value;
			}
		}

		// Token: 0x06007B32 RID: 31538 RVA: 0x0012AD56 File Offset: 0x00128F56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FarmGoldLevelNotify);
		}

		// Token: 0x06007B33 RID: 31539 RVA: 0x0012AD64 File Offset: 0x00128F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FarmGoldLevelNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this.LevelPlayTasks, other.LevelPlayTasks) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007B34 RID: 31540 RVA: 0x0012ADB4 File Offset: 0x00128FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.levelPlayTasks_ != null)
			{
				num ^= this.LevelPlayTasks.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007B35 RID: 31541 RVA: 0x0012AE09 File Offset: 0x00129009
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007B36 RID: 31542 RVA: 0x0012AE16 File Offset: 0x00129016
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007B37 RID: 31543 RVA: 0x0012AE20 File Offset: 0x00129020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActivityId);
			}
			if (this.levelPlayTasks_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.LevelPlayTasks);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007B38 RID: 31544 RVA: 0x0012AE7C File Offset: 0x0012907C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.levelPlayTasks_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LevelPlayTasks);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007B39 RID: 31545 RVA: 0x0012AED4 File Offset: 0x001290D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FarmGoldLevelNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.levelPlayTasks_ != null)
			{
				if (this.levelPlayTasks_ == null)
				{
					this.LevelPlayTasks = new FarmGoldLevelPlayInfo();
				}
				this.LevelPlayTasks.MergeFrom(other.LevelPlayTasks);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007B3A RID: 31546 RVA: 0x0012AF3C File Offset: 0x0012913C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007B3B RID: 31547 RVA: 0x0012AF48 File Offset: 0x00129148
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
				if (num != 24U)
				{
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.levelPlayTasks_ == null)
						{
							this.LevelPlayTasks = new FarmGoldLevelPlayInfo();
						}
						input.ReadMessage(this.LevelPlayTasks);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003F17 RID: 16151
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F18 RID: 16152
		public const int ActivityIdFieldNumber = 3;

		// Token: 0x04003F19 RID: 16153
		private int activityId_;

		// Token: 0x04003F1A RID: 16154
		public const int LevelPlayTasksFieldNumber = 12;

		// Token: 0x04003F1B RID: 16155
		private FarmGoldLevelPlayInfo levelPlayTasks_;
	}
}
