using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200050B RID: 1291
	[NetMessage(EMessageId.FarmGoldLevelNotify)]
	public sealed class FarmGoldLevelNotify : IMessage<FarmGoldLevelNotify>, IMessage, IEquatable<FarmGoldLevelNotify>, IDeepCloneable<FarmGoldLevelNotify>, IBufferMessage
	{
		// Token: 0x060079C0 RID: 31168 RVA: 0x001280C5 File Offset: 0x001262C5
		[NullableContext(1)]
		public static FarmGoldLevelNotify Create()
		{
			return new FarmGoldLevelNotify();
		}

		// Token: 0x17001795 RID: 6037
		// (get) Token: 0x060079C1 RID: 31169 RVA: 0x001280CC File Offset: 0x001262CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001796 RID: 6038
		// (get) Token: 0x060079C2 RID: 31170 RVA: 0x001280CF File Offset: 0x001262CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FarmGoldLevelNotify.Descriptor;
			}
		}

		// Token: 0x060079C3 RID: 31171 RVA: 0x001280D6 File Offset: 0x001262D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelNotify()
		{
		}

		// Token: 0x060079C4 RID: 31172 RVA: 0x001280E0 File Offset: 0x001262E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelNotify(FarmGoldLevelNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.levelPlayTasks_ = ((other.levelPlayTasks_ != null) ? other.levelPlayTasks_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060079C5 RID: 31173 RVA: 0x0012812C File Offset: 0x0012632C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelNotify Clone()
		{
			return new FarmGoldLevelNotify(this);
		}

		// Token: 0x17001797 RID: 6039
		// (get) Token: 0x060079C6 RID: 31174 RVA: 0x00128134 File Offset: 0x00126334
		// (set) Token: 0x060079C7 RID: 31175 RVA: 0x0012813C File Offset: 0x0012633C
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

		// Token: 0x17001798 RID: 6040
		// (get) Token: 0x060079C8 RID: 31176 RVA: 0x00128145 File Offset: 0x00126345
		// (set) Token: 0x060079C9 RID: 31177 RVA: 0x0012814D File Offset: 0x0012634D
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

		// Token: 0x060079CA RID: 31178 RVA: 0x00128156 File Offset: 0x00126356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FarmGoldLevelNotify);
		}

		// Token: 0x060079CB RID: 31179 RVA: 0x00128164 File Offset: 0x00126364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FarmGoldLevelNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this.LevelPlayTasks, other.LevelPlayTasks) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060079CC RID: 31180 RVA: 0x001281B4 File Offset: 0x001263B4
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

		// Token: 0x060079CD RID: 31181 RVA: 0x00128209 File Offset: 0x00126409
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060079CE RID: 31182 RVA: 0x00128216 File Offset: 0x00126416
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060079CF RID: 31183 RVA: 0x00128220 File Offset: 0x00126420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.levelPlayTasks_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.LevelPlayTasks);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060079D0 RID: 31184 RVA: 0x0012827C File Offset: 0x0012647C
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

		// Token: 0x060079D1 RID: 31185 RVA: 0x001282D4 File Offset: 0x001264D4
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

		// Token: 0x060079D2 RID: 31186 RVA: 0x0012833C File Offset: 0x0012653C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060079D3 RID: 31187 RVA: 0x00128348 File Offset: 0x00126548
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
					if (num != 32U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
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
		}

		// Token: 0x04003F0D RID: 16141
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F0E RID: 16142
		public const int ActivityIdFieldNumber = 4;

		// Token: 0x04003F0F RID: 16143
		private int activityId_;

		// Token: 0x04003F10 RID: 16144
		public const int LevelPlayTasksFieldNumber = 1;

		// Token: 0x04003F11 RID: 16145
		private FarmGoldLevelPlayInfo levelPlayTasks_;
	}
}
