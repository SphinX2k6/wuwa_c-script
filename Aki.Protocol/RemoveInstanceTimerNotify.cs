using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EEE RID: 3822
	[NetMessage(EMessageId.RemoveInstanceTimerNotify)]
	public sealed class RemoveInstanceTimerNotify : IMessage<RemoveInstanceTimerNotify>, IMessage, IEquatable<RemoveInstanceTimerNotify>, IDeepCloneable<RemoveInstanceTimerNotify>, IBufferMessage
	{
		// Token: 0x06014819 RID: 83993 RVA: 0x002FB4B4 File Offset: 0x002F96B4
		[NullableContext(1)]
		public static RemoveInstanceTimerNotify Create()
		{
			return new RemoveInstanceTimerNotify();
		}

		// Token: 0x17004438 RID: 17464
		// (get) Token: 0x0601481A RID: 83994 RVA: 0x002FB4BB File Offset: 0x002F96BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004439 RID: 17465
		// (get) Token: 0x0601481B RID: 83995 RVA: 0x002FB4BE File Offset: 0x002F96BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveInstanceTimerNotify.Descriptor;
			}
		}

		// Token: 0x0601481C RID: 83996 RVA: 0x002FB4C5 File Offset: 0x002F96C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveInstanceTimerNotify()
		{
		}

		// Token: 0x0601481D RID: 83997 RVA: 0x002FB4CD File Offset: 0x002F96CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveInstanceTimerNotify(RemoveInstanceTimerNotify other) : this()
		{
			this.timerId_ = other.timerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601481E RID: 83998 RVA: 0x002FB4F2 File Offset: 0x002F96F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveInstanceTimerNotify Clone()
		{
			return new RemoveInstanceTimerNotify(this);
		}

		// Token: 0x1700443A RID: 17466
		// (get) Token: 0x0601481F RID: 83999 RVA: 0x002FB4FA File Offset: 0x002F96FA
		// (set) Token: 0x06014820 RID: 84000 RVA: 0x002FB502 File Offset: 0x002F9702
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

		// Token: 0x06014821 RID: 84001 RVA: 0x002FB50B File Offset: 0x002F970B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveInstanceTimerNotify);
		}

		// Token: 0x06014822 RID: 84002 RVA: 0x002FB519 File Offset: 0x002F9719
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveInstanceTimerNotify other)
		{
			return other != null && (other == this || (this.TimerId == other.TimerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014823 RID: 84003 RVA: 0x002FB548 File Offset: 0x002F9748
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

		// Token: 0x06014824 RID: 84004 RVA: 0x002FB587 File Offset: 0x002F9787
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014825 RID: 84005 RVA: 0x002FB594 File Offset: 0x002F9794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014826 RID: 84006 RVA: 0x002FB59D File Offset: 0x002F979D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TimerId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.TimerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014827 RID: 84007 RVA: 0x002FB5D0 File Offset: 0x002F97D0
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

		// Token: 0x06014828 RID: 84008 RVA: 0x002FB60E File Offset: 0x002F980E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveInstanceTimerNotify other)
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

		// Token: 0x06014829 RID: 84009 RVA: 0x002FB63F File Offset: 0x002F983F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601482A RID: 84010 RVA: 0x002FB648 File Offset: 0x002F9848
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TimerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007CC2 RID: 31938
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007CC3 RID: 31939
		public const int TimerIdFieldNumber = 12;

		// Token: 0x04007CC4 RID: 31940
		private int timerId_;
	}
}
