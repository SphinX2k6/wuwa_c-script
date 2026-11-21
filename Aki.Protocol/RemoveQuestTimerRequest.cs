using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EF6 RID: 3830
	public sealed class RemoveQuestTimerRequest : IMessage<RemoveQuestTimerRequest>, IMessage, IEquatable<RemoveQuestTimerRequest>, IDeepCloneable<RemoveQuestTimerRequest>, IBufferMessage
	{
		// Token: 0x060148B3 RID: 84147 RVA: 0x002FC7D0 File Offset: 0x002FA9D0
		[NullableContext(1)]
		public static RemoveQuestTimerRequest Create()
		{
			return new RemoveQuestTimerRequest();
		}

		// Token: 0x17004455 RID: 17493
		// (get) Token: 0x060148B4 RID: 84148 RVA: 0x002FC7D7 File Offset: 0x002FA9D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004456 RID: 17494
		// (get) Token: 0x060148B5 RID: 84149 RVA: 0x002FC7DA File Offset: 0x002FA9DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveQuestTimerRequest.Descriptor;
			}
		}

		// Token: 0x060148B6 RID: 84150 RVA: 0x002FC7E1 File Offset: 0x002FA9E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveQuestTimerRequest()
		{
		}

		// Token: 0x060148B7 RID: 84151 RVA: 0x002FC7E9 File Offset: 0x002FA9E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveQuestTimerRequest(RemoveQuestTimerRequest other) : this()
		{
			this.timerId_ = other.timerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060148B8 RID: 84152 RVA: 0x002FC80E File Offset: 0x002FAA0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveQuestTimerRequest Clone()
		{
			return new RemoveQuestTimerRequest(this);
		}

		// Token: 0x17004457 RID: 17495
		// (get) Token: 0x060148B9 RID: 84153 RVA: 0x002FC816 File Offset: 0x002FAA16
		// (set) Token: 0x060148BA RID: 84154 RVA: 0x002FC81E File Offset: 0x002FAA1E
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

		// Token: 0x060148BB RID: 84155 RVA: 0x002FC827 File Offset: 0x002FAA27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveQuestTimerRequest);
		}

		// Token: 0x060148BC RID: 84156 RVA: 0x002FC835 File Offset: 0x002FAA35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveQuestTimerRequest other)
		{
			return other != null && (other == this || (this.TimerId == other.TimerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060148BD RID: 84157 RVA: 0x002FC864 File Offset: 0x002FAA64
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

		// Token: 0x060148BE RID: 84158 RVA: 0x002FC8A3 File Offset: 0x002FAAA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060148BF RID: 84159 RVA: 0x002FC8B0 File Offset: 0x002FAAB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060148C0 RID: 84160 RVA: 0x002FC8B9 File Offset: 0x002FAAB9
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

		// Token: 0x060148C1 RID: 84161 RVA: 0x002FC8EC File Offset: 0x002FAAEC
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

		// Token: 0x060148C2 RID: 84162 RVA: 0x002FC92A File Offset: 0x002FAB2A
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

		// Token: 0x060148C3 RID: 84163 RVA: 0x002FC95B File Offset: 0x002FAB5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060148C4 RID: 84164 RVA: 0x002FC964 File Offset: 0x002FAB64
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

		// Token: 0x04007CE6 RID: 31974
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007CE7 RID: 31975
		public const int TimerIdFieldNumber = 1;

		// Token: 0x04007CE8 RID: 31976
		private int timerId_;
	}
}
