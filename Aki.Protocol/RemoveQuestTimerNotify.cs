using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F05 RID: 3845
	public sealed class RemoveQuestTimerNotify : IMessage<RemoveQuestTimerNotify>, IMessage, IEquatable<RemoveQuestTimerNotify>, IDeepCloneable<RemoveQuestTimerNotify>, IBufferMessage
	{
		// Token: 0x06014986 RID: 84358 RVA: 0x002FDCB5 File Offset: 0x002FBEB5
		[NullableContext(1)]
		public static RemoveQuestTimerNotify Create()
		{
			return new RemoveQuestTimerNotify();
		}

		// Token: 0x1700447C RID: 17532
		// (get) Token: 0x06014987 RID: 84359 RVA: 0x002FDCBC File Offset: 0x002FBEBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700447D RID: 17533
		// (get) Token: 0x06014988 RID: 84360 RVA: 0x002FDCBF File Offset: 0x002FBEBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveQuestTimerNotify.Descriptor;
			}
		}

		// Token: 0x06014989 RID: 84361 RVA: 0x002FDCC6 File Offset: 0x002FBEC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveQuestTimerNotify()
		{
		}

		// Token: 0x0601498A RID: 84362 RVA: 0x002FDCCE File Offset: 0x002FBECE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveQuestTimerNotify(RemoveQuestTimerNotify other) : this()
		{
			this.timerId_ = other.timerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601498B RID: 84363 RVA: 0x002FDCF3 File Offset: 0x002FBEF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveQuestTimerNotify Clone()
		{
			return new RemoveQuestTimerNotify(this);
		}

		// Token: 0x1700447E RID: 17534
		// (get) Token: 0x0601498C RID: 84364 RVA: 0x002FDCFB File Offset: 0x002FBEFB
		// (set) Token: 0x0601498D RID: 84365 RVA: 0x002FDD03 File Offset: 0x002FBF03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TimerId
		{
			get
			{
				return this.timerId_;
			}
			set
			{
				this.timerId_ = value;
			}
		}

		// Token: 0x0601498E RID: 84366 RVA: 0x002FDD0C File Offset: 0x002FBF0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveQuestTimerNotify);
		}

		// Token: 0x0601498F RID: 84367 RVA: 0x002FDD1A File Offset: 0x002FBF1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveQuestTimerNotify other)
		{
			return other != null && (other == this || (this.TimerId == other.TimerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014990 RID: 84368 RVA: 0x002FDD48 File Offset: 0x002FBF48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TimerId != 0)
			{
				num ^= this.TimerId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014991 RID: 84369 RVA: 0x002FDD87 File Offset: 0x002FBF87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014992 RID: 84370 RVA: 0x002FDD94 File Offset: 0x002FBF94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014993 RID: 84371 RVA: 0x002FDD9D File Offset: 0x002FBF9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TimerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TimerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014994 RID: 84372 RVA: 0x002FDDD0 File Offset: 0x002FBFD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TimerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TimerId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014995 RID: 84373 RVA: 0x002FDE0E File Offset: 0x002FC00E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveQuestTimerNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TimerId != 0)
			{
				this.TimerId = other.TimerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014996 RID: 84374 RVA: 0x002FDE3F File Offset: 0x002FC03F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014997 RID: 84375 RVA: 0x002FDE48 File Offset: 0x002FC048
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TimerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007CB9 RID: 31929
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007CBA RID: 31930
		public const int TimerIdFieldNumber = 1;

		// Token: 0x04007CBB RID: 31931
		private int timerId_;
	}
}
