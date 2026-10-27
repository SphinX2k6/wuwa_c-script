using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F06 RID: 3846
	public sealed class RemoveQuestTimerRequest : IMessage<RemoveQuestTimerRequest>, IMessage, IEquatable<RemoveQuestTimerRequest>, IDeepCloneable<RemoveQuestTimerRequest>, IBufferMessage
	{
		// Token: 0x06014998 RID: 84376 RVA: 0x002FDE8C File Offset: 0x002FC08C
		[NullableContext(1)]
		public static RemoveQuestTimerRequest Create()
		{
			return new RemoveQuestTimerRequest();
		}

		// Token: 0x1700447F RID: 17535
		// (get) Token: 0x06014999 RID: 84377 RVA: 0x002FDE93 File Offset: 0x002FC093
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004480 RID: 17536
		// (get) Token: 0x0601499A RID: 84378 RVA: 0x002FDE96 File Offset: 0x002FC096
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveQuestTimerRequest.Descriptor;
			}
		}

		// Token: 0x0601499B RID: 84379 RVA: 0x002FDE9D File Offset: 0x002FC09D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveQuestTimerRequest()
		{
		}

		// Token: 0x0601499C RID: 84380 RVA: 0x002FDEA5 File Offset: 0x002FC0A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveQuestTimerRequest(RemoveQuestTimerRequest other) : this()
		{
			this.timerId_ = other.timerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601499D RID: 84381 RVA: 0x002FDECA File Offset: 0x002FC0CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveQuestTimerRequest Clone()
		{
			return new RemoveQuestTimerRequest(this);
		}

		// Token: 0x17004481 RID: 17537
		// (get) Token: 0x0601499E RID: 84382 RVA: 0x002FDED2 File Offset: 0x002FC0D2
		// (set) Token: 0x0601499F RID: 84383 RVA: 0x002FDEDA File Offset: 0x002FC0DA
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

		// Token: 0x060149A0 RID: 84384 RVA: 0x002FDEE3 File Offset: 0x002FC0E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveQuestTimerRequest);
		}

		// Token: 0x060149A1 RID: 84385 RVA: 0x002FDEF1 File Offset: 0x002FC0F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveQuestTimerRequest other)
		{
			return other != null && (other == this || (this.TimerId == other.TimerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060149A2 RID: 84386 RVA: 0x002FDF20 File Offset: 0x002FC120
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

		// Token: 0x060149A3 RID: 84387 RVA: 0x002FDF5F File Offset: 0x002FC15F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060149A4 RID: 84388 RVA: 0x002FDF6C File Offset: 0x002FC16C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060149A5 RID: 84389 RVA: 0x002FDF75 File Offset: 0x002FC175
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

		// Token: 0x060149A6 RID: 84390 RVA: 0x002FDFA8 File Offset: 0x002FC1A8
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

		// Token: 0x060149A7 RID: 84391 RVA: 0x002FDFE6 File Offset: 0x002FC1E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveQuestTimerRequest other)
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

		// Token: 0x060149A8 RID: 84392 RVA: 0x002FE017 File Offset: 0x002FC217
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060149A9 RID: 84393 RVA: 0x002FE020 File Offset: 0x002FC220
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

		// Token: 0x04007CBC RID: 31932
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007CBD RID: 31933
		public const int TimerIdFieldNumber = 1;

		// Token: 0x04007CBE RID: 31934
		private int timerId_;
	}
}
