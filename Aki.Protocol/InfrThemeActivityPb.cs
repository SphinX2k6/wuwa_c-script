using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007E0 RID: 2016
	public sealed class InfrThemeActivityPb : IMessage<InfrThemeActivityPb>, IMessage, IEquatable<InfrThemeActivityPb>, IDeepCloneable<InfrThemeActivityPb>, IBufferMessage
	{
		// Token: 0x0600B52C RID: 46380 RVA: 0x001B0EE1 File Offset: 0x001AF0E1
		[NullableContext(1)]
		public static InfrThemeActivityPb Create()
		{
			return new InfrThemeActivityPb();
		}

		// Token: 0x17002483 RID: 9347
		// (get) Token: 0x0600B52D RID: 46381 RVA: 0x001B0EE8 File Offset: 0x001AF0E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002484 RID: 9348
		// (get) Token: 0x0600B52E RID: 46382 RVA: 0x001B0EEB File Offset: 0x001AF0EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrThemeActivityPb.Descriptor;
			}
		}

		// Token: 0x0600B52F RID: 46383 RVA: 0x001B0EF2 File Offset: 0x001AF0F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrThemeActivityPb()
		{
		}

		// Token: 0x0600B530 RID: 46384 RVA: 0x001B0EFA File Offset: 0x001AF0FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrThemeActivityPb(InfrThemeActivityPb other) : this()
		{
			this.activityTaskData_ = ((other.activityTaskData_ != null) ? other.activityTaskData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B531 RID: 46385 RVA: 0x001B0F2F File Offset: 0x001AF12F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrThemeActivityPb Clone()
		{
			return new InfrThemeActivityPb(this);
		}

		// Token: 0x17002485 RID: 9349
		// (get) Token: 0x0600B532 RID: 46386 RVA: 0x001B0F37 File Offset: 0x001AF137
		// (set) Token: 0x0600B533 RID: 46387 RVA: 0x001B0F3F File Offset: 0x001AF13F
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

		// Token: 0x0600B534 RID: 46388 RVA: 0x001B0F48 File Offset: 0x001AF148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrThemeActivityPb);
		}

		// Token: 0x0600B535 RID: 46389 RVA: 0x001B0F56 File Offset: 0x001AF156
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrThemeActivityPb other)
		{
			return other != null && (other == this || (object.Equals(this.ActivityTaskData, other.ActivityTaskData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B536 RID: 46390 RVA: 0x001B0F8C File Offset: 0x001AF18C
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

		// Token: 0x0600B537 RID: 46391 RVA: 0x001B0FC8 File Offset: 0x001AF1C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B538 RID: 46392 RVA: 0x001B0FD5 File Offset: 0x001AF1D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B539 RID: 46393 RVA: 0x001B0FDE File Offset: 0x001AF1DE
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

		// Token: 0x0600B53A RID: 46394 RVA: 0x001B1010 File Offset: 0x001AF210
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

		// Token: 0x0600B53B RID: 46395 RVA: 0x001B1050 File Offset: 0x001AF250
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

		// Token: 0x0600B53C RID: 46396 RVA: 0x001B10A4 File Offset: 0x001AF2A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B53D RID: 46397 RVA: 0x001B10B0 File Offset: 0x001AF2B0
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

		// Token: 0x040050C8 RID: 20680
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050C9 RID: 20681
		public const int ActivityTaskDataFieldNumber = 2;

		// Token: 0x040050CA RID: 20682
		private ActivityTaskData activityTaskData_;
	}
}
