using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EFF RID: 3839
	[NetMessage(EMessageId.RemoveInstanceTimerRequest)]
	public sealed class RemoveInstanceTimerRequest : IMessage<RemoveInstanceTimerRequest>, IMessage, IEquatable<RemoveInstanceTimerRequest>, IDeepCloneable<RemoveInstanceTimerRequest>, IBufferMessage
	{
		// Token: 0x06014910 RID: 84240 RVA: 0x002FCD49 File Offset: 0x002FAF49
		[NullableContext(1)]
		public static RemoveInstanceTimerRequest Create()
		{
			return new RemoveInstanceTimerRequest();
		}

		// Token: 0x17004465 RID: 17509
		// (get) Token: 0x06014911 RID: 84241 RVA: 0x002FCD50 File Offset: 0x002FAF50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004466 RID: 17510
		// (get) Token: 0x06014912 RID: 84242 RVA: 0x002FCD53 File Offset: 0x002FAF53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveInstanceTimerRequest.Descriptor;
			}
		}

		// Token: 0x06014913 RID: 84243 RVA: 0x002FCD5A File Offset: 0x002FAF5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveInstanceTimerRequest()
		{
		}

		// Token: 0x06014914 RID: 84244 RVA: 0x002FCD62 File Offset: 0x002FAF62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveInstanceTimerRequest(RemoveInstanceTimerRequest other) : this()
		{
			this.timerId_ = other.timerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014915 RID: 84245 RVA: 0x002FCD87 File Offset: 0x002FAF87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveInstanceTimerRequest Clone()
		{
			return new RemoveInstanceTimerRequest(this);
		}

		// Token: 0x17004467 RID: 17511
		// (get) Token: 0x06014916 RID: 84246 RVA: 0x002FCD8F File Offset: 0x002FAF8F
		// (set) Token: 0x06014917 RID: 84247 RVA: 0x002FCD97 File Offset: 0x002FAF97
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

		// Token: 0x06014918 RID: 84248 RVA: 0x002FCDA0 File Offset: 0x002FAFA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveInstanceTimerRequest);
		}

		// Token: 0x06014919 RID: 84249 RVA: 0x002FCDAE File Offset: 0x002FAFAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveInstanceTimerRequest other)
		{
			return other != null && (other == this || (this.TimerId == other.TimerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601491A RID: 84250 RVA: 0x002FCDDC File Offset: 0x002FAFDC
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

		// Token: 0x0601491B RID: 84251 RVA: 0x002FCE1B File Offset: 0x002FB01B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601491C RID: 84252 RVA: 0x002FCE28 File Offset: 0x002FB028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601491D RID: 84253 RVA: 0x002FCE31 File Offset: 0x002FB031
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TimerId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.TimerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601491E RID: 84254 RVA: 0x002FCE64 File Offset: 0x002FB064
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

		// Token: 0x0601491F RID: 84255 RVA: 0x002FCEA2 File Offset: 0x002FB0A2
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

		// Token: 0x06014920 RID: 84256 RVA: 0x002FCED3 File Offset: 0x002FB0D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014921 RID: 84257 RVA: 0x002FCEDC File Offset: 0x002FB0DC
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TimerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007C9B RID: 31899
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C9C RID: 31900
		public const int TimerIdFieldNumber = 6;

		// Token: 0x04007C9D RID: 31901
		private int timerId_;
	}
}
