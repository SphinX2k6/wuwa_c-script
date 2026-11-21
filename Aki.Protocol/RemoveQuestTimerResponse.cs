using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EF7 RID: 3831
	public sealed class RemoveQuestTimerResponse : IMessage<RemoveQuestTimerResponse>, IMessage, IEquatable<RemoveQuestTimerResponse>, IDeepCloneable<RemoveQuestTimerResponse>, IBufferMessage
	{
		// Token: 0x060148C5 RID: 84165 RVA: 0x002FC9A8 File Offset: 0x002FABA8
		[NullableContext(1)]
		public static RemoveQuestTimerResponse Create()
		{
			return new RemoveQuestTimerResponse();
		}

		// Token: 0x17004458 RID: 17496
		// (get) Token: 0x060148C6 RID: 84166 RVA: 0x002FC9AF File Offset: 0x002FABAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004459 RID: 17497
		// (get) Token: 0x060148C7 RID: 84167 RVA: 0x002FC9B2 File Offset: 0x002FABB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveQuestTimerResponse.Descriptor;
			}
		}

		// Token: 0x060148C8 RID: 84168 RVA: 0x002FC9B9 File Offset: 0x002FABB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveQuestTimerResponse()
		{
		}

		// Token: 0x060148C9 RID: 84169 RVA: 0x002FC9C1 File Offset: 0x002FABC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveQuestTimerResponse(RemoveQuestTimerResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.timerId_ = other.timerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060148CA RID: 84170 RVA: 0x002FC9F2 File Offset: 0x002FABF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveQuestTimerResponse Clone()
		{
			return new RemoveQuestTimerResponse(this);
		}

		// Token: 0x1700445A RID: 17498
		// (get) Token: 0x060148CB RID: 84171 RVA: 0x002FC9FA File Offset: 0x002FABFA
		// (set) Token: 0x060148CC RID: 84172 RVA: 0x002FCA02 File Offset: 0x002FAC02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x1700445B RID: 17499
		// (get) Token: 0x060148CD RID: 84173 RVA: 0x002FCA0B File Offset: 0x002FAC0B
		// (set) Token: 0x060148CE RID: 84174 RVA: 0x002FCA13 File Offset: 0x002FAC13
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

		// Token: 0x060148CF RID: 84175 RVA: 0x002FCA1C File Offset: 0x002FAC1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveQuestTimerResponse);
		}

		// Token: 0x060148D0 RID: 84176 RVA: 0x002FCA2A File Offset: 0x002FAC2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveQuestTimerResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.TimerId == other.TimerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060148D1 RID: 84177 RVA: 0x002FCA68 File Offset: 0x002FAC68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
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

		// Token: 0x060148D2 RID: 84178 RVA: 0x002FCAC6 File Offset: 0x002FACC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060148D3 RID: 84179 RVA: 0x002FCAD3 File Offset: 0x002FACD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060148D4 RID: 84180 RVA: 0x002FCADC File Offset: 0x002FACDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.TimerId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.TimerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060148D5 RID: 84181 RVA: 0x002FCB34 File Offset: 0x002FAD34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
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

		// Token: 0x060148D6 RID: 84182 RVA: 0x002FCB8C File Offset: 0x002FAD8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveQuestTimerResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.TimerId != 0)
			{
				this.TimerId = other.TimerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060148D7 RID: 84183 RVA: 0x002FCBDC File Offset: 0x002FADDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060148D8 RID: 84184 RVA: 0x002FCBE8 File Offset: 0x002FADE8
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TimerId = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007CE9 RID: 31977
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007CEA RID: 31978
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04007CEB RID: 31979
		private ErrorCode errorCode_;

		// Token: 0x04007CEC RID: 31980
		public const int TimerIdFieldNumber = 2;

		// Token: 0x04007CED RID: 31981
		private int timerId_;
	}
}
