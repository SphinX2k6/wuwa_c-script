using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DED RID: 3565
	[NetMessage(EMessageId.QingXiaoTaskUpdateNotify)]
	public sealed class QingXiaoTaskUpdateNotify : IMessage<QingXiaoTaskUpdateNotify>, IMessage, IEquatable<QingXiaoTaskUpdateNotify>, IDeepCloneable<QingXiaoTaskUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601333A RID: 78650 RVA: 0x002CC69D File Offset: 0x002CA89D
		[NullableContext(1)]
		public static QingXiaoTaskUpdateNotify Create()
		{
			return new QingXiaoTaskUpdateNotify();
		}

		// Token: 0x17003FBB RID: 16315
		// (get) Token: 0x0601333B RID: 78651 RVA: 0x002CC6A4 File Offset: 0x002CA8A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FBC RID: 16316
		// (get) Token: 0x0601333C RID: 78652 RVA: 0x002CC6A7 File Offset: 0x002CA8A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QingXiaoTaskUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601333D RID: 78653 RVA: 0x002CC6AE File Offset: 0x002CA8AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QingXiaoTaskUpdateNotify()
		{
		}

		// Token: 0x0601333E RID: 78654 RVA: 0x002CC6B6 File Offset: 0x002CA8B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QingXiaoTaskUpdateNotify(QingXiaoTaskUpdateNotify other) : this()
		{
			this.task_ = ((other.task_ != null) ? other.task_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601333F RID: 78655 RVA: 0x002CC6EB File Offset: 0x002CA8EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QingXiaoTaskUpdateNotify Clone()
		{
			return new QingXiaoTaskUpdateNotify(this);
		}

		// Token: 0x17003FBD RID: 16317
		// (get) Token: 0x06013340 RID: 78656 RVA: 0x002CC6F3 File Offset: 0x002CA8F3
		// (set) Token: 0x06013341 RID: 78657 RVA: 0x002CC6FB File Offset: 0x002CA8FB
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

		// Token: 0x06013342 RID: 78658 RVA: 0x002CC704 File Offset: 0x002CA904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QingXiaoTaskUpdateNotify);
		}

		// Token: 0x06013343 RID: 78659 RVA: 0x002CC712 File Offset: 0x002CA912
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QingXiaoTaskUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Task, other.Task) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013344 RID: 78660 RVA: 0x002CC748 File Offset: 0x002CA948
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

		// Token: 0x06013345 RID: 78661 RVA: 0x002CC784 File Offset: 0x002CA984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013346 RID: 78662 RVA: 0x002CC791 File Offset: 0x002CA991
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013347 RID: 78663 RVA: 0x002CC79A File Offset: 0x002CA99A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.task_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.Task);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013348 RID: 78664 RVA: 0x002CC7CC File Offset: 0x002CA9CC
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

		// Token: 0x06013349 RID: 78665 RVA: 0x002CC80C File Offset: 0x002CAA0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QingXiaoTaskUpdateNotify other)
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

		// Token: 0x0601334A RID: 78666 RVA: 0x002CC860 File Offset: 0x002CAA60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601334B RID: 78667 RVA: 0x002CC86C File Offset: 0x002CAA6C
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
				if (num != 122U)
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

		// Token: 0x040076A2 RID: 30370
		private UnknownFieldSet _unknownFields;

		// Token: 0x040076A3 RID: 30371
		public const int TaskFieldNumber = 15;

		// Token: 0x040076A4 RID: 30372
		private ConditionTask task_;
	}
}
