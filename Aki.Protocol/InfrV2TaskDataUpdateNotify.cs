using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007F2 RID: 2034
	[NetMessage(EMessageId.InfrV2TaskDataUpdateNotify)]
	public sealed class InfrV2TaskDataUpdateNotify : IMessage<InfrV2TaskDataUpdateNotify>, IMessage, IEquatable<InfrV2TaskDataUpdateNotify>, IDeepCloneable<InfrV2TaskDataUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600B684 RID: 46724 RVA: 0x001B39D9 File Offset: 0x001B1BD9
		[NullableContext(1)]
		public static InfrV2TaskDataUpdateNotify Create()
		{
			return new InfrV2TaskDataUpdateNotify();
		}

		// Token: 0x170024C4 RID: 9412
		// (get) Token: 0x0600B685 RID: 46725 RVA: 0x001B39E0 File Offset: 0x001B1BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024C5 RID: 9413
		// (get) Token: 0x0600B686 RID: 46726 RVA: 0x001B39E3 File Offset: 0x001B1BE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2TaskDataUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600B687 RID: 46727 RVA: 0x001B39EA File Offset: 0x001B1BEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TaskDataUpdateNotify()
		{
		}

		// Token: 0x0600B688 RID: 46728 RVA: 0x001B39F2 File Offset: 0x001B1BF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TaskDataUpdateNotify(InfrV2TaskDataUpdateNotify other) : this()
		{
			this.task_ = ((other.task_ != null) ? other.task_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B689 RID: 46729 RVA: 0x001B3A27 File Offset: 0x001B1C27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TaskDataUpdateNotify Clone()
		{
			return new InfrV2TaskDataUpdateNotify(this);
		}

		// Token: 0x170024C6 RID: 9414
		// (get) Token: 0x0600B68A RID: 46730 RVA: 0x001B3A2F File Offset: 0x001B1C2F
		// (set) Token: 0x0600B68B RID: 46731 RVA: 0x001B3A37 File Offset: 0x001B1C37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionTask Task
		{
			get
			{
				return this.task_;
			}
			set
			{
				this.task_ = value;
			}
		}

		// Token: 0x0600B68C RID: 46732 RVA: 0x001B3A40 File Offset: 0x001B1C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2TaskDataUpdateNotify);
		}

		// Token: 0x0600B68D RID: 46733 RVA: 0x001B3A4E File Offset: 0x001B1C4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2TaskDataUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Task, other.Task) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B68E RID: 46734 RVA: 0x001B3A84 File Offset: 0x001B1C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.task_ != null)
			{
				num ^= this.Task.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B68F RID: 46735 RVA: 0x001B3AC0 File Offset: 0x001B1CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B690 RID: 46736 RVA: 0x001B3ACD File Offset: 0x001B1CCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B691 RID: 46737 RVA: 0x001B3AD6 File Offset: 0x001B1CD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.task_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Task);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B692 RID: 46738 RVA: 0x001B3B08 File Offset: 0x001B1D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.task_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Task);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B693 RID: 46739 RVA: 0x001B3B48 File Offset: 0x001B1D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrV2TaskDataUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.task_ != null)
			{
				if (this.task_ == null)
				{
					this.Task = new ConditionTask();
				}
				this.Task.MergeFrom(other.Task);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B694 RID: 46740 RVA: 0x001B3B9C File Offset: 0x001B1D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B695 RID: 46741 RVA: 0x001B3BA8 File Offset: 0x001B1DA8
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
					if (this.task_ == null)
					{
						this.Task = new ConditionTask();
					}
					input.ReadMessage(this.Task);
				}
			}
		}

		// Token: 0x04005117 RID: 20759
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005118 RID: 20760
		public const int TaskFieldNumber = 10;

		// Token: 0x04005119 RID: 20761
		private ConditionTask task_;
	}
}
