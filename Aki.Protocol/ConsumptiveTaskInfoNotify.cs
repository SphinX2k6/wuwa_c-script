using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002F0 RID: 752
	[NetMessage(EMessageId.ConsumptiveTaskInfoNotify)]
	public sealed class ConsumptiveTaskInfoNotify : IMessage<ConsumptiveTaskInfoNotify>, IMessage, IEquatable<ConsumptiveTaskInfoNotify>, IDeepCloneable<ConsumptiveTaskInfoNotify>, IBufferMessage
	{
		// Token: 0x06004C96 RID: 19606 RVA: 0x000BACA8 File Offset: 0x000B8EA8
		[NullableContext(1)]
		public static ConsumptiveTaskInfoNotify Create()
		{
			return new ConsumptiveTaskInfoNotify();
		}

		// Token: 0x17000D80 RID: 3456
		// (get) Token: 0x06004C97 RID: 19607 RVA: 0x000BACAF File Offset: 0x000B8EAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D81 RID: 3457
		// (get) Token: 0x06004C98 RID: 19608 RVA: 0x000BACB2 File Offset: 0x000B8EB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConsumptiveTaskInfoNotify.Descriptor;
			}
		}

		// Token: 0x06004C99 RID: 19609 RVA: 0x000BACB9 File Offset: 0x000B8EB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveTaskInfoNotify()
		{
		}

		// Token: 0x06004C9A RID: 19610 RVA: 0x000BACC1 File Offset: 0x000B8EC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveTaskInfoNotify(ConsumptiveTaskInfoNotify other) : this()
		{
			this.consumptiveTaskInfo_ = ((other.consumptiveTaskInfo_ != null) ? other.consumptiveTaskInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004C9B RID: 19611 RVA: 0x000BACF6 File Offset: 0x000B8EF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveTaskInfoNotify Clone()
		{
			return new ConsumptiveTaskInfoNotify(this);
		}

		// Token: 0x17000D82 RID: 3458
		// (get) Token: 0x06004C9C RID: 19612 RVA: 0x000BACFE File Offset: 0x000B8EFE
		// (set) Token: 0x06004C9D RID: 19613 RVA: 0x000BAD06 File Offset: 0x000B8F06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveTaskInfo ConsumptiveTaskInfo
		{
			get
			{
				return this.consumptiveTaskInfo_;
			}
			set
			{
				this.consumptiveTaskInfo_ = value;
			}
		}

		// Token: 0x06004C9E RID: 19614 RVA: 0x000BAD0F File Offset: 0x000B8F0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConsumptiveTaskInfoNotify);
		}

		// Token: 0x06004C9F RID: 19615 RVA: 0x000BAD1D File Offset: 0x000B8F1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConsumptiveTaskInfoNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ConsumptiveTaskInfo, other.ConsumptiveTaskInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004CA0 RID: 19616 RVA: 0x000BAD50 File Offset: 0x000B8F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.consumptiveTaskInfo_ != null)
			{
				num ^= this.ConsumptiveTaskInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004CA1 RID: 19617 RVA: 0x000BAD8C File Offset: 0x000B8F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004CA2 RID: 19618 RVA: 0x000BAD99 File Offset: 0x000B8F99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004CA3 RID: 19619 RVA: 0x000BADA2 File Offset: 0x000B8FA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.consumptiveTaskInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.ConsumptiveTaskInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004CA4 RID: 19620 RVA: 0x000BADD4 File Offset: 0x000B8FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.consumptiveTaskInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ConsumptiveTaskInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004CA5 RID: 19621 RVA: 0x000BAE14 File Offset: 0x000B9014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConsumptiveTaskInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.consumptiveTaskInfo_ != null)
			{
				if (this.consumptiveTaskInfo_ == null)
				{
					this.ConsumptiveTaskInfo = new ConsumptiveTaskInfo();
				}
				this.ConsumptiveTaskInfo.MergeFrom(other.ConsumptiveTaskInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004CA6 RID: 19622 RVA: 0x000BAE68 File Offset: 0x000B9068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004CA7 RID: 19623 RVA: 0x000BAE74 File Offset: 0x000B9074
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
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.consumptiveTaskInfo_ == null)
					{
						this.ConsumptiveTaskInfo = new ConsumptiveTaskInfo();
					}
					input.ReadMessage(this.ConsumptiveTaskInfo);
				}
			}
		}

		// Token: 0x04003164 RID: 12644
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003165 RID: 12645
		public const int ConsumptiveTaskInfoFieldNumber = 5;

		// Token: 0x04003166 RID: 12646
		private ConsumptiveTaskInfo consumptiveTaskInfo_;
	}
}
