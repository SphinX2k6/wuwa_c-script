using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DFD RID: 3581
	[NetMessage(EMessageId.QingXiaoTaskUpdateNotify)]
	public sealed class QingXiaoTaskUpdateNotify : IMessage<QingXiaoTaskUpdateNotify>, IMessage, IEquatable<QingXiaoTaskUpdateNotify>, IDeepCloneable<QingXiaoTaskUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601341F RID: 78879 RVA: 0x002CDD5C File Offset: 0x002CBF5C
		[NullableContext(1)]
		public static QingXiaoTaskUpdateNotify Create()
		{
			return new QingXiaoTaskUpdateNotify();
		}

		// Token: 0x17003FE5 RID: 16357
		// (get) Token: 0x06013420 RID: 78880 RVA: 0x002CDD63 File Offset: 0x002CBF63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FE6 RID: 16358
		// (get) Token: 0x06013421 RID: 78881 RVA: 0x002CDD66 File Offset: 0x002CBF66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QingXiaoTaskUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06013422 RID: 78882 RVA: 0x002CDD6D File Offset: 0x002CBF6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QingXiaoTaskUpdateNotify()
		{
		}

		// Token: 0x06013423 RID: 78883 RVA: 0x002CDD75 File Offset: 0x002CBF75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QingXiaoTaskUpdateNotify(QingXiaoTaskUpdateNotify other) : this()
		{
			this.task_ = ((other.task_ != null) ? other.task_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013424 RID: 78884 RVA: 0x002CDDAA File Offset: 0x002CBFAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QingXiaoTaskUpdateNotify Clone()
		{
			return new QingXiaoTaskUpdateNotify(this);
		}

		// Token: 0x17003FE7 RID: 16359
		// (get) Token: 0x06013425 RID: 78885 RVA: 0x002CDDB2 File Offset: 0x002CBFB2
		// (set) Token: 0x06013426 RID: 78886 RVA: 0x002CDDBA File Offset: 0x002CBFBA
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

		// Token: 0x06013427 RID: 78887 RVA: 0x002CDDC3 File Offset: 0x002CBFC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QingXiaoTaskUpdateNotify);
		}

		// Token: 0x06013428 RID: 78888 RVA: 0x002CDDD1 File Offset: 0x002CBFD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QingXiaoTaskUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Task, other.Task) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013429 RID: 78889 RVA: 0x002CDE04 File Offset: 0x002CC004
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

		// Token: 0x0601342A RID: 78890 RVA: 0x002CDE40 File Offset: 0x002CC040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601342B RID: 78891 RVA: 0x002CDE4D File Offset: 0x002CC04D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601342C RID: 78892 RVA: 0x002CDE56 File Offset: 0x002CC056
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.task_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.Task);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601342D RID: 78893 RVA: 0x002CDE88 File Offset: 0x002CC088
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

		// Token: 0x0601342E RID: 78894 RVA: 0x002CDEC8 File Offset: 0x002CC0C8
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

		// Token: 0x0601342F RID: 78895 RVA: 0x002CDF1C File Offset: 0x002CC11C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013430 RID: 78896 RVA: 0x002CDF28 File Offset: 0x002CC128
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
				if (num != 58U)
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

		// Token: 0x04007678 RID: 30328
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007679 RID: 30329
		public const int TaskFieldNumber = 7;

		// Token: 0x0400767A RID: 30330
		private ConditionTask task_;
	}
}
