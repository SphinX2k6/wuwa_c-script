using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B05 RID: 2821
	[NetMessage(EMessageId.NewbieCarnivalTaskDataUpdateNotify)]
	public sealed class NewbieCarnivalTaskDataUpdateNotify : IMessage<NewbieCarnivalTaskDataUpdateNotify>, IMessage, IEquatable<NewbieCarnivalTaskDataUpdateNotify>, IDeepCloneable<NewbieCarnivalTaskDataUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600F52B RID: 62763 RVA: 0x0023C80D File Offset: 0x0023AA0D
		[NullableContext(1)]
		public static NewbieCarnivalTaskDataUpdateNotify Create()
		{
			return new NewbieCarnivalTaskDataUpdateNotify();
		}

		// Token: 0x170031F1 RID: 12785
		// (get) Token: 0x0600F52C RID: 62764 RVA: 0x0023C814 File Offset: 0x0023AA14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031F2 RID: 12786
		// (get) Token: 0x0600F52D RID: 62765 RVA: 0x0023C817 File Offset: 0x0023AA17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieCarnivalTaskDataUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600F52E RID: 62766 RVA: 0x0023C81E File Offset: 0x0023AA1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCarnivalTaskDataUpdateNotify()
		{
		}

		// Token: 0x0600F52F RID: 62767 RVA: 0x0023C826 File Offset: 0x0023AA26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCarnivalTaskDataUpdateNotify(NewbieCarnivalTaskDataUpdateNotify other) : this()
		{
			this.activityTaskData_ = ((other.activityTaskData_ != null) ? other.activityTaskData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F530 RID: 62768 RVA: 0x0023C85B File Offset: 0x0023AA5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCarnivalTaskDataUpdateNotify Clone()
		{
			return new NewbieCarnivalTaskDataUpdateNotify(this);
		}

		// Token: 0x170031F3 RID: 12787
		// (get) Token: 0x0600F531 RID: 62769 RVA: 0x0023C863 File Offset: 0x0023AA63
		// (set) Token: 0x0600F532 RID: 62770 RVA: 0x0023C86B File Offset: 0x0023AA6B
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

		// Token: 0x0600F533 RID: 62771 RVA: 0x0023C874 File Offset: 0x0023AA74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieCarnivalTaskDataUpdateNotify);
		}

		// Token: 0x0600F534 RID: 62772 RVA: 0x0023C882 File Offset: 0x0023AA82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieCarnivalTaskDataUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ActivityTaskData, other.ActivityTaskData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F535 RID: 62773 RVA: 0x0023C8B8 File Offset: 0x0023AAB8
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

		// Token: 0x0600F536 RID: 62774 RVA: 0x0023C8F4 File Offset: 0x0023AAF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F537 RID: 62775 RVA: 0x0023C901 File Offset: 0x0023AB01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F538 RID: 62776 RVA: 0x0023C90A File Offset: 0x0023AB0A
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

		// Token: 0x0600F539 RID: 62777 RVA: 0x0023C93C File Offset: 0x0023AB3C
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

		// Token: 0x0600F53A RID: 62778 RVA: 0x0023C97C File Offset: 0x0023AB7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewbieCarnivalTaskDataUpdateNotify other)
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

		// Token: 0x0600F53B RID: 62779 RVA: 0x0023C9D0 File Offset: 0x0023ABD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F53C RID: 62780 RVA: 0x0023C9DC File Offset: 0x0023ABDC
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

		// Token: 0x040062A2 RID: 25250
		private UnknownFieldSet _unknownFields;

		// Token: 0x040062A3 RID: 25251
		public const int ActivityTaskDataFieldNumber = 2;

		// Token: 0x040062A4 RID: 25252
		private ActivityTaskData activityTaskData_;
	}
}
