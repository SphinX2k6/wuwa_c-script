using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007E1 RID: 2017
	[NetMessage(EMessageId.InfrThemeActivityTaskDataUpdateNotify)]
	public sealed class InfrThemeActivityTaskDataUpdateNotify : IMessage<InfrThemeActivityTaskDataUpdateNotify>, IMessage, IEquatable<InfrThemeActivityTaskDataUpdateNotify>, IDeepCloneable<InfrThemeActivityTaskDataUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600B53E RID: 46398 RVA: 0x001B1108 File Offset: 0x001AF308
		[NullableContext(1)]
		public static InfrThemeActivityTaskDataUpdateNotify Create()
		{
			return new InfrThemeActivityTaskDataUpdateNotify();
		}

		// Token: 0x17002486 RID: 9350
		// (get) Token: 0x0600B53F RID: 46399 RVA: 0x001B110F File Offset: 0x001AF30F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002487 RID: 9351
		// (get) Token: 0x0600B540 RID: 46400 RVA: 0x001B1112 File Offset: 0x001AF312
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrThemeActivityTaskDataUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600B541 RID: 46401 RVA: 0x001B1119 File Offset: 0x001AF319
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrThemeActivityTaskDataUpdateNotify()
		{
		}

		// Token: 0x0600B542 RID: 46402 RVA: 0x001B1121 File Offset: 0x001AF321
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrThemeActivityTaskDataUpdateNotify(InfrThemeActivityTaskDataUpdateNotify other) : this()
		{
			this.activityTask_ = ((other.activityTask_ != null) ? other.activityTask_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B543 RID: 46403 RVA: 0x001B1156 File Offset: 0x001AF356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrThemeActivityTaskDataUpdateNotify Clone()
		{
			return new InfrThemeActivityTaskDataUpdateNotify(this);
		}

		// Token: 0x17002488 RID: 9352
		// (get) Token: 0x0600B544 RID: 46404 RVA: 0x001B115E File Offset: 0x001AF35E
		// (set) Token: 0x0600B545 RID: 46405 RVA: 0x001B1166 File Offset: 0x001AF366
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityTask ActivityTask
		{
			get
			{
				return this.activityTask_;
			}
			set
			{
				this.activityTask_ = value;
			}
		}

		// Token: 0x0600B546 RID: 46406 RVA: 0x001B116F File Offset: 0x001AF36F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrThemeActivityTaskDataUpdateNotify);
		}

		// Token: 0x0600B547 RID: 46407 RVA: 0x001B117D File Offset: 0x001AF37D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrThemeActivityTaskDataUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ActivityTask, other.ActivityTask) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B548 RID: 46408 RVA: 0x001B11B0 File Offset: 0x001AF3B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.activityTask_ != null)
			{
				num ^= this.ActivityTask.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B549 RID: 46409 RVA: 0x001B11EC File Offset: 0x001AF3EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B54A RID: 46410 RVA: 0x001B11F9 File Offset: 0x001AF3F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B54B RID: 46411 RVA: 0x001B1202 File Offset: 0x001AF402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.activityTask_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.ActivityTask);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B54C RID: 46412 RVA: 0x001B1234 File Offset: 0x001AF434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.activityTask_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ActivityTask);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B54D RID: 46413 RVA: 0x001B1274 File Offset: 0x001AF474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrThemeActivityTaskDataUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.activityTask_ != null)
			{
				if (this.activityTask_ == null)
				{
					this.ActivityTask = new ActivityTask();
				}
				this.ActivityTask.MergeFrom(other.ActivityTask);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B54E RID: 46414 RVA: 0x001B12C8 File Offset: 0x001AF4C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B54F RID: 46415 RVA: 0x001B12D4 File Offset: 0x001AF4D4
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.activityTask_ == null)
					{
						this.ActivityTask = new ActivityTask();
					}
					input.ReadMessage(this.ActivityTask);
				}
			}
		}

		// Token: 0x040050CB RID: 20683
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050CC RID: 20684
		public const int ActivityTaskFieldNumber = 10;

		// Token: 0x040050CD RID: 20685
		private ActivityTask activityTask_;
	}
}
