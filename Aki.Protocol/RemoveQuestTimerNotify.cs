using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EF5 RID: 3829
	public sealed class RemoveQuestTimerNotify : IMessage<RemoveQuestTimerNotify>, IMessage, IEquatable<RemoveQuestTimerNotify>, IDeepCloneable<RemoveQuestTimerNotify>, IBufferMessage
	{
		// Token: 0x060148A1 RID: 84129 RVA: 0x002FC5F9 File Offset: 0x002FA7F9
		[NullableContext(1)]
		public static RemoveQuestTimerNotify Create()
		{
			return new RemoveQuestTimerNotify();
		}

		// Token: 0x17004452 RID: 17490
		// (get) Token: 0x060148A2 RID: 84130 RVA: 0x002FC600 File Offset: 0x002FA800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004453 RID: 17491
		// (get) Token: 0x060148A3 RID: 84131 RVA: 0x002FC603 File Offset: 0x002FA803
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveQuestTimerNotify.Descriptor;
			}
		}

		// Token: 0x060148A4 RID: 84132 RVA: 0x002FC60A File Offset: 0x002FA80A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveQuestTimerNotify()
		{
		}

		// Token: 0x060148A5 RID: 84133 RVA: 0x002FC612 File Offset: 0x002FA812
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveQuestTimerNotify(RemoveQuestTimerNotify other) : this()
		{
			this.timerId_ = other.timerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060148A6 RID: 84134 RVA: 0x002FC637 File Offset: 0x002FA837
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveQuestTimerNotify Clone()
		{
			return new RemoveQuestTimerNotify(this);
		}

		// Token: 0x17004454 RID: 17492
		// (get) Token: 0x060148A7 RID: 84135 RVA: 0x002FC63F File Offset: 0x002FA83F
		// (set) Token: 0x060148A8 RID: 84136 RVA: 0x002FC647 File Offset: 0x002FA847
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

		// Token: 0x060148A9 RID: 84137 RVA: 0x002FC650 File Offset: 0x002FA850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveQuestTimerNotify);
		}

		// Token: 0x060148AA RID: 84138 RVA: 0x002FC65E File Offset: 0x002FA85E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveQuestTimerNotify other)
		{
			return other != null && (other == this || (this.TimerId == other.TimerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060148AB RID: 84139 RVA: 0x002FC68C File Offset: 0x002FA88C
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

		// Token: 0x060148AC RID: 84140 RVA: 0x002FC6CB File Offset: 0x002FA8CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060148AD RID: 84141 RVA: 0x002FC6D8 File Offset: 0x002FA8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060148AE RID: 84142 RVA: 0x002FC6E1 File Offset: 0x002FA8E1
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

		// Token: 0x060148AF RID: 84143 RVA: 0x002FC714 File Offset: 0x002FA914
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

		// Token: 0x060148B0 RID: 84144 RVA: 0x002FC752 File Offset: 0x002FA952
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

		// Token: 0x060148B1 RID: 84145 RVA: 0x002FC783 File Offset: 0x002FA983
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060148B2 RID: 84146 RVA: 0x002FC78C File Offset: 0x002FA98C
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

		// Token: 0x04007CE3 RID: 31971
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007CE4 RID: 31972
		public const int TimerIdFieldNumber = 1;

		// Token: 0x04007CE5 RID: 31973
		private int timerId_;
	}
}
