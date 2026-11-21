using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200065E RID: 1630
	[NetMessage(EMessageId.FsmStateBehaviorResponse)]
	public sealed class FsmStateBehaviorResponse : IMessage<FsmStateBehaviorResponse>, IMessage, IEquatable<FsmStateBehaviorResponse>, IDeepCloneable<FsmStateBehaviorResponse>, IBufferMessage
	{
		// Token: 0x060095F7 RID: 38391 RVA: 0x0016A524 File Offset: 0x00168724
		[NullableContext(1)]
		public static FsmStateBehaviorResponse Create()
		{
			return new FsmStateBehaviorResponse();
		}

		// Token: 0x17001DDA RID: 7642
		// (get) Token: 0x060095F8 RID: 38392 RVA: 0x0016A52B File Offset: 0x0016872B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001DDB RID: 7643
		// (get) Token: 0x060095F9 RID: 38393 RVA: 0x0016A52E File Offset: 0x0016872E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FsmStateBehaviorResponse.Descriptor;
			}
		}

		// Token: 0x060095FA RID: 38394 RVA: 0x0016A535 File Offset: 0x00168735
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmStateBehaviorResponse()
		{
		}

		// Token: 0x060095FB RID: 38395 RVA: 0x0016A53D File Offset: 0x0016873D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmStateBehaviorResponse(FsmStateBehaviorResponse other) : this()
		{
			this.fsmId_ = other.fsmId_;
			this.state_ = other.state_;
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060095FC RID: 38396 RVA: 0x0016A57A File Offset: 0x0016877A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmStateBehaviorResponse Clone()
		{
			return new FsmStateBehaviorResponse(this);
		}

		// Token: 0x17001DDC RID: 7644
		// (get) Token: 0x060095FD RID: 38397 RVA: 0x0016A582 File Offset: 0x00168782
		// (set) Token: 0x060095FE RID: 38398 RVA: 0x0016A58A File Offset: 0x0016878A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FsmId
		{
			get
			{
				return this.fsmId_;
			}
			set
			{
				this.fsmId_ = value;
			}
		}

		// Token: 0x17001DDD RID: 7645
		// (get) Token: 0x060095FF RID: 38399 RVA: 0x0016A593 File Offset: 0x00168793
		// (set) Token: 0x06009600 RID: 38400 RVA: 0x0016A59B File Offset: 0x0016879B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x17001DDE RID: 7646
		// (get) Token: 0x06009601 RID: 38401 RVA: 0x0016A5A4 File Offset: 0x001687A4
		// (set) Token: 0x06009602 RID: 38402 RVA: 0x0016A5AC File Offset: 0x001687AC
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

		// Token: 0x06009603 RID: 38403 RVA: 0x0016A5B5 File Offset: 0x001687B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FsmStateBehaviorResponse);
		}

		// Token: 0x06009604 RID: 38404 RVA: 0x0016A5C4 File Offset: 0x001687C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FsmStateBehaviorResponse other)
		{
			return other != null && (other == this || (this.FsmId == other.FsmId && this.State == other.State && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009605 RID: 38405 RVA: 0x0016A620 File Offset: 0x00168820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FsmId != 0)
			{
				num ^= this.FsmId.GetHashCode();
			}
			if (this.State != 0)
			{
				num ^= this.State.GetHashCode();
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009606 RID: 38406 RVA: 0x0016A697 File Offset: 0x00168897
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009607 RID: 38407 RVA: 0x0016A6A4 File Offset: 0x001688A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009608 RID: 38408 RVA: 0x0016A6B0 File Offset: 0x001688B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.FsmId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.FsmId);
			}
			if (this.State != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.State);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009609 RID: 38409 RVA: 0x0016A724 File Offset: 0x00168924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FsmId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FsmId);
			}
			if (this.State != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.State);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600960A RID: 38410 RVA: 0x0016A794 File Offset: 0x00168994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FsmStateBehaviorResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FsmId != 0)
			{
				this.FsmId = other.FsmId;
			}
			if (other.State != 0)
			{
				this.State = other.State;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600960B RID: 38411 RVA: 0x0016A7F8 File Offset: 0x001689F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600960C RID: 38412 RVA: 0x0016A804 File Offset: 0x00168A04
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
					if (num != 112U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.State = input.ReadInt32();
						}
					}
					else
					{
						this.FsmId = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040047EC RID: 18412
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047ED RID: 18413
		public const int FsmIdFieldNumber = 14;

		// Token: 0x040047EE RID: 18414
		private int fsmId_;

		// Token: 0x040047EF RID: 18415
		public const int StateFieldNumber = 15;

		// Token: 0x040047F0 RID: 18416
		private int state_;

		// Token: 0x040047F1 RID: 18417
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x040047F2 RID: 18418
		private ErrorCode errorCode_;
	}
}
