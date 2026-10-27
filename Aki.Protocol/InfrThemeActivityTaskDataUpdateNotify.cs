using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007F5 RID: 2037
	[NetMessage(EMessageId.InfrThemeActivityTaskDataUpdateNotify)]
	public sealed class InfrThemeActivityTaskDataUpdateNotify : IMessage<InfrThemeActivityTaskDataUpdateNotify>, IMessage, IEquatable<InfrThemeActivityTaskDataUpdateNotify>, IDeepCloneable<InfrThemeActivityTaskDataUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600B694 RID: 46740 RVA: 0x001B3B40 File Offset: 0x001B1D40
		[NullableContext(1)]
		public static InfrThemeActivityTaskDataUpdateNotify Create()
		{
			return new InfrThemeActivityTaskDataUpdateNotify();
		}

		// Token: 0x170024D0 RID: 9424
		// (get) Token: 0x0600B695 RID: 46741 RVA: 0x001B3B47 File Offset: 0x001B1D47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024D1 RID: 9425
		// (get) Token: 0x0600B696 RID: 46742 RVA: 0x001B3B4A File Offset: 0x001B1D4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrThemeActivityTaskDataUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600B697 RID: 46743 RVA: 0x001B3B51 File Offset: 0x001B1D51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrThemeActivityTaskDataUpdateNotify()
		{
		}

		// Token: 0x0600B698 RID: 46744 RVA: 0x001B3B59 File Offset: 0x001B1D59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrThemeActivityTaskDataUpdateNotify(InfrThemeActivityTaskDataUpdateNotify other) : this()
		{
			this.activityTask_ = ((other.activityTask_ != null) ? other.activityTask_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B699 RID: 46745 RVA: 0x001B3B8E File Offset: 0x001B1D8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrThemeActivityTaskDataUpdateNotify Clone()
		{
			return new InfrThemeActivityTaskDataUpdateNotify(this);
		}

		// Token: 0x170024D2 RID: 9426
		// (get) Token: 0x0600B69A RID: 46746 RVA: 0x001B3B96 File Offset: 0x001B1D96
		// (set) Token: 0x0600B69B RID: 46747 RVA: 0x001B3B9E File Offset: 0x001B1D9E
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

		// Token: 0x0600B69C RID: 46748 RVA: 0x001B3BA7 File Offset: 0x001B1DA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrThemeActivityTaskDataUpdateNotify);
		}

		// Token: 0x0600B69D RID: 46749 RVA: 0x001B3BB5 File Offset: 0x001B1DB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrThemeActivityTaskDataUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ActivityTask, other.ActivityTask) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B69E RID: 46750 RVA: 0x001B3BE8 File Offset: 0x001B1DE8
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

		// Token: 0x0600B69F RID: 46751 RVA: 0x001B3C24 File Offset: 0x001B1E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B6A0 RID: 46752 RVA: 0x001B3C31 File Offset: 0x001B1E31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B6A1 RID: 46753 RVA: 0x001B3C3A File Offset: 0x001B1E3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.activityTask_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.ActivityTask);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B6A2 RID: 46754 RVA: 0x001B3C6C File Offset: 0x001B1E6C
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

		// Token: 0x0600B6A3 RID: 46755 RVA: 0x001B3CAC File Offset: 0x001B1EAC
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

		// Token: 0x0600B6A4 RID: 46756 RVA: 0x001B3D00 File Offset: 0x001B1F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B6A5 RID: 46757 RVA: 0x001B3D0C File Offset: 0x001B1F0C
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
				if (num != 66U)
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

		// Token: 0x040050D2 RID: 20690
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050D3 RID: 20691
		public const int ActivityTaskFieldNumber = 8;

		// Token: 0x040050D4 RID: 20692
		private ActivityTask activityTask_;
	}
}
