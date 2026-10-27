using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007F4 RID: 2036
	public sealed class InfrThemeActivityPb : IMessage<InfrThemeActivityPb>, IMessage, IEquatable<InfrThemeActivityPb>, IDeepCloneable<InfrThemeActivityPb>, IBufferMessage
	{
		// Token: 0x0600B682 RID: 46722 RVA: 0x001B3919 File Offset: 0x001B1B19
		[NullableContext(1)]
		public static InfrThemeActivityPb Create()
		{
			return new InfrThemeActivityPb();
		}

		// Token: 0x170024CD RID: 9421
		// (get) Token: 0x0600B683 RID: 46723 RVA: 0x001B3920 File Offset: 0x001B1B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024CE RID: 9422
		// (get) Token: 0x0600B684 RID: 46724 RVA: 0x001B3923 File Offset: 0x001B1B23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrThemeActivityPb.Descriptor;
			}
		}

		// Token: 0x0600B685 RID: 46725 RVA: 0x001B392A File Offset: 0x001B1B2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrThemeActivityPb()
		{
		}

		// Token: 0x0600B686 RID: 46726 RVA: 0x001B3932 File Offset: 0x001B1B32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrThemeActivityPb(InfrThemeActivityPb other) : this()
		{
			this.activityTaskData_ = ((other.activityTaskData_ != null) ? other.activityTaskData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B687 RID: 46727 RVA: 0x001B3967 File Offset: 0x001B1B67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrThemeActivityPb Clone()
		{
			return new InfrThemeActivityPb(this);
		}

		// Token: 0x170024CF RID: 9423
		// (get) Token: 0x0600B688 RID: 46728 RVA: 0x001B396F File Offset: 0x001B1B6F
		// (set) Token: 0x0600B689 RID: 46729 RVA: 0x001B3977 File Offset: 0x001B1B77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityTaskData ActivityTaskData
		{
			get
			{
				return this.activityTaskData_;
			}
			set
			{
				this.activityTaskData_ = value;
			}
		}

		// Token: 0x0600B68A RID: 46730 RVA: 0x001B3980 File Offset: 0x001B1B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrThemeActivityPb);
		}

		// Token: 0x0600B68B RID: 46731 RVA: 0x001B398E File Offset: 0x001B1B8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrThemeActivityPb other)
		{
			return other != null && (other == this || (object.Equals(this.ActivityTaskData, other.ActivityTaskData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B68C RID: 46732 RVA: 0x001B39C4 File Offset: 0x001B1BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.activityTaskData_ != null)
			{
				num ^= this.ActivityTaskData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B68D RID: 46733 RVA: 0x001B3A00 File Offset: 0x001B1C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B68E RID: 46734 RVA: 0x001B3A0D File Offset: 0x001B1C0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B68F RID: 46735 RVA: 0x001B3A16 File Offset: 0x001B1C16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.activityTaskData_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ActivityTaskData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B690 RID: 46736 RVA: 0x001B3A48 File Offset: 0x001B1C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.activityTaskData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ActivityTaskData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B691 RID: 46737 RVA: 0x001B3A88 File Offset: 0x001B1C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrThemeActivityPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.activityTaskData_ != null)
			{
				if (this.activityTaskData_ == null)
				{
					this.ActivityTaskData = new ActivityTaskData();
				}
				this.ActivityTaskData.MergeFrom(other.ActivityTaskData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B692 RID: 46738 RVA: 0x001B3ADC File Offset: 0x001B1CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B693 RID: 46739 RVA: 0x001B3AE8 File Offset: 0x001B1CE8
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.activityTaskData_ == null)
					{
						this.ActivityTaskData = new ActivityTaskData();
					}
					input.ReadMessage(this.ActivityTaskData);
				}
			}
		}

		// Token: 0x040050CF RID: 20687
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050D0 RID: 20688
		public const int ActivityTaskDataFieldNumber = 2;

		// Token: 0x040050D1 RID: 20689
		private ActivityTaskData activityTaskData_;
	}
}
