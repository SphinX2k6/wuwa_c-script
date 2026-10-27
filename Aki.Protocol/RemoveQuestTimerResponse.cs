using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F07 RID: 3847
	public sealed class RemoveQuestTimerResponse : IMessage<RemoveQuestTimerResponse>, IMessage, IEquatable<RemoveQuestTimerResponse>, IDeepCloneable<RemoveQuestTimerResponse>, IBufferMessage
	{
		// Token: 0x060149AA RID: 84394 RVA: 0x002FE064 File Offset: 0x002FC264
		[NullableContext(1)]
		public static RemoveQuestTimerResponse Create()
		{
			return new RemoveQuestTimerResponse();
		}

		// Token: 0x17004482 RID: 17538
		// (get) Token: 0x060149AB RID: 84395 RVA: 0x002FE06B File Offset: 0x002FC26B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004483 RID: 17539
		// (get) Token: 0x060149AC RID: 84396 RVA: 0x002FE06E File Offset: 0x002FC26E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveQuestTimerResponse.Descriptor;
			}
		}

		// Token: 0x060149AD RID: 84397 RVA: 0x002FE075 File Offset: 0x002FC275
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveQuestTimerResponse()
		{
		}

		// Token: 0x060149AE RID: 84398 RVA: 0x002FE07D File Offset: 0x002FC27D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveQuestTimerResponse(RemoveQuestTimerResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.timerId_ = other.timerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060149AF RID: 84399 RVA: 0x002FE0AE File Offset: 0x002FC2AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveQuestTimerResponse Clone()
		{
			return new RemoveQuestTimerResponse(this);
		}

		// Token: 0x17004484 RID: 17540
		// (get) Token: 0x060149B0 RID: 84400 RVA: 0x002FE0B6 File Offset: 0x002FC2B6
		// (set) Token: 0x060149B1 RID: 84401 RVA: 0x002FE0BE File Offset: 0x002FC2BE
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

		// Token: 0x17004485 RID: 17541
		// (get) Token: 0x060149B2 RID: 84402 RVA: 0x002FE0C7 File Offset: 0x002FC2C7
		// (set) Token: 0x060149B3 RID: 84403 RVA: 0x002FE0CF File Offset: 0x002FC2CF
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

		// Token: 0x060149B4 RID: 84404 RVA: 0x002FE0D8 File Offset: 0x002FC2D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveQuestTimerResponse);
		}

		// Token: 0x060149B5 RID: 84405 RVA: 0x002FE0E6 File Offset: 0x002FC2E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveQuestTimerResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.TimerId == other.TimerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060149B6 RID: 84406 RVA: 0x002FE124 File Offset: 0x002FC324
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

		// Token: 0x060149B7 RID: 84407 RVA: 0x002FE182 File Offset: 0x002FC382
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060149B8 RID: 84408 RVA: 0x002FE18F File Offset: 0x002FC38F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060149B9 RID: 84409 RVA: 0x002FE198 File Offset: 0x002FC398
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

		// Token: 0x060149BA RID: 84410 RVA: 0x002FE1F0 File Offset: 0x002FC3F0
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

		// Token: 0x060149BB RID: 84411 RVA: 0x002FE248 File Offset: 0x002FC448
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

		// Token: 0x060149BC RID: 84412 RVA: 0x002FE298 File Offset: 0x002FC498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060149BD RID: 84413 RVA: 0x002FE2A4 File Offset: 0x002FC4A4
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

		// Token: 0x04007CBF RID: 31935
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007CC0 RID: 31936
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04007CC1 RID: 31937
		private ErrorCode errorCode_;

		// Token: 0x04007CC2 RID: 31938
		public const int TimerIdFieldNumber = 2;

		// Token: 0x04007CC3 RID: 31939
		private int timerId_;
	}
}
