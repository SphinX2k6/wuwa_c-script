using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EEF RID: 3823
	[NetMessage(EMessageId.RemoveInstanceTimerRequest)]
	public sealed class RemoveInstanceTimerRequest : IMessage<RemoveInstanceTimerRequest>, IMessage, IEquatable<RemoveInstanceTimerRequest>, IDeepCloneable<RemoveInstanceTimerRequest>, IBufferMessage
	{
		// Token: 0x0601482B RID: 84011 RVA: 0x002FB68D File Offset: 0x002F988D
		[NullableContext(1)]
		public static RemoveInstanceTimerRequest Create()
		{
			return new RemoveInstanceTimerRequest();
		}

		// Token: 0x1700443B RID: 17467
		// (get) Token: 0x0601482C RID: 84012 RVA: 0x002FB694 File Offset: 0x002F9894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700443C RID: 17468
		// (get) Token: 0x0601482D RID: 84013 RVA: 0x002FB697 File Offset: 0x002F9897
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveInstanceTimerRequest.Descriptor;
			}
		}

		// Token: 0x0601482E RID: 84014 RVA: 0x002FB69E File Offset: 0x002F989E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveInstanceTimerRequest()
		{
		}

		// Token: 0x0601482F RID: 84015 RVA: 0x002FB6A6 File Offset: 0x002F98A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveInstanceTimerRequest(RemoveInstanceTimerRequest other) : this()
		{
			this.timerId_ = other.timerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014830 RID: 84016 RVA: 0x002FB6CB File Offset: 0x002F98CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveInstanceTimerRequest Clone()
		{
			return new RemoveInstanceTimerRequest(this);
		}

		// Token: 0x1700443D RID: 17469
		// (get) Token: 0x06014831 RID: 84017 RVA: 0x002FB6D3 File Offset: 0x002F98D3
		// (set) Token: 0x06014832 RID: 84018 RVA: 0x002FB6DB File Offset: 0x002F98DB
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

		// Token: 0x06014833 RID: 84019 RVA: 0x002FB6E4 File Offset: 0x002F98E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveInstanceTimerRequest);
		}

		// Token: 0x06014834 RID: 84020 RVA: 0x002FB6F2 File Offset: 0x002F98F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveInstanceTimerRequest other)
		{
			return other != null && (other == this || (this.TimerId == other.TimerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014835 RID: 84021 RVA: 0x002FB720 File Offset: 0x002F9920
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

		// Token: 0x06014836 RID: 84022 RVA: 0x002FB75F File Offset: 0x002F995F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014837 RID: 84023 RVA: 0x002FB76C File Offset: 0x002F996C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014838 RID: 84024 RVA: 0x002FB775 File Offset: 0x002F9975
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TimerId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TimerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014839 RID: 84025 RVA: 0x002FB7A8 File Offset: 0x002F99A8
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

		// Token: 0x0601483A RID: 84026 RVA: 0x002FB7E6 File Offset: 0x002F99E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveInstanceTimerRequest other)
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

		// Token: 0x0601483B RID: 84027 RVA: 0x002FB817 File Offset: 0x002F9A17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601483C RID: 84028 RVA: 0x002FB820 File Offset: 0x002F9A20
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TimerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007CC5 RID: 31941
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007CC6 RID: 31942
		public const int TimerIdFieldNumber = 3;

		// Token: 0x04007CC7 RID: 31943
		private int timerId_;
	}
}
