using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200065D RID: 1629
	[NetMessage(EMessageId.FsmStateBehaviorRequest)]
	public sealed class FsmStateBehaviorRequest : IMessage<FsmStateBehaviorRequest>, IMessage, IEquatable<FsmStateBehaviorRequest>, IDeepCloneable<FsmStateBehaviorRequest>, IBufferMessage
	{
		// Token: 0x060095DF RID: 38367 RVA: 0x0016A124 File Offset: 0x00168324
		[NullableContext(1)]
		public static FsmStateBehaviorRequest Create()
		{
			return new FsmStateBehaviorRequest();
		}

		// Token: 0x17001DD4 RID: 7636
		// (get) Token: 0x060095E0 RID: 38368 RVA: 0x0016A12B File Offset: 0x0016832B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001DD5 RID: 7637
		// (get) Token: 0x060095E1 RID: 38369 RVA: 0x0016A12E File Offset: 0x0016832E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FsmStateBehaviorRequest.Descriptor;
			}
		}

		// Token: 0x060095E2 RID: 38370 RVA: 0x0016A135 File Offset: 0x00168335
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmStateBehaviorRequest()
		{
		}

		// Token: 0x060095E3 RID: 38371 RVA: 0x0016A140 File Offset: 0x00168340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmStateBehaviorRequest(FsmStateBehaviorRequest other) : this()
		{
			this.fsmId_ = other.fsmId_;
			this.state_ = other.state_;
			this.index_ = other.index_;
			this.behaviorType_ = other.behaviorType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060095E4 RID: 38372 RVA: 0x0016A194 File Offset: 0x00168394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmStateBehaviorRequest Clone()
		{
			return new FsmStateBehaviorRequest(this);
		}

		// Token: 0x17001DD6 RID: 7638
		// (get) Token: 0x060095E5 RID: 38373 RVA: 0x0016A19C File Offset: 0x0016839C
		// (set) Token: 0x060095E6 RID: 38374 RVA: 0x0016A1A4 File Offset: 0x001683A4
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

		// Token: 0x17001DD7 RID: 7639
		// (get) Token: 0x060095E7 RID: 38375 RVA: 0x0016A1AD File Offset: 0x001683AD
		// (set) Token: 0x060095E8 RID: 38376 RVA: 0x0016A1B5 File Offset: 0x001683B5
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

		// Token: 0x17001DD8 RID: 7640
		// (get) Token: 0x060095E9 RID: 38377 RVA: 0x0016A1BE File Offset: 0x001683BE
		// (set) Token: 0x060095EA RID: 38378 RVA: 0x0016A1C6 File Offset: 0x001683C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x17001DD9 RID: 7641
		// (get) Token: 0x060095EB RID: 38379 RVA: 0x0016A1CF File Offset: 0x001683CF
		// (set) Token: 0x060095EC RID: 38380 RVA: 0x0016A1D7 File Offset: 0x001683D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmStateBehaviorType BehaviorType
		{
			get
			{
				return this.behaviorType_;
			}
			set
			{
				this.behaviorType_ = value;
			}
		}

		// Token: 0x060095ED RID: 38381 RVA: 0x0016A1E0 File Offset: 0x001683E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FsmStateBehaviorRequest);
		}

		// Token: 0x060095EE RID: 38382 RVA: 0x0016A1F0 File Offset: 0x001683F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FsmStateBehaviorRequest other)
		{
			return other != null && (other == this || (this.FsmId == other.FsmId && this.State == other.State && this.Index == other.Index && this.BehaviorType == other.BehaviorType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060095EF RID: 38383 RVA: 0x0016A25C File Offset: 0x0016845C
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
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.BehaviorType != FsmStateBehaviorType.BtEnter)
			{
				num ^= this.BehaviorType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060095F0 RID: 38384 RVA: 0x0016A2EC File Offset: 0x001684EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060095F1 RID: 38385 RVA: 0x0016A2F9 File Offset: 0x001684F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060095F2 RID: 38386 RVA: 0x0016A304 File Offset: 0x00168504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Index);
			}
			if (this.State != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.State);
			}
			if (this.FsmId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.FsmId);
			}
			if (this.BehaviorType != FsmStateBehaviorType.BtEnter)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.BehaviorType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060095F3 RID: 38387 RVA: 0x0016A394 File Offset: 0x00168594
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
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this.BehaviorType != FsmStateBehaviorType.BtEnter)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.BehaviorType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060095F4 RID: 38388 RVA: 0x0016A41C File Offset: 0x0016861C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FsmStateBehaviorRequest other)
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
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			if (other.BehaviorType != FsmStateBehaviorType.BtEnter)
			{
				this.BehaviorType = other.BehaviorType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060095F5 RID: 38389 RVA: 0x0016A494 File Offset: 0x00168694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060095F6 RID: 38390 RVA: 0x0016A4A0 File Offset: 0x001686A0
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
				if (num <= 56U)
				{
					if (num == 8U)
					{
						this.Index = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.State = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 112U)
					{
						this.FsmId = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.BehaviorType = (FsmStateBehaviorType)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040047E3 RID: 18403
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047E4 RID: 18404
		public const int FsmIdFieldNumber = 14;

		// Token: 0x040047E5 RID: 18405
		private int fsmId_;

		// Token: 0x040047E6 RID: 18406
		public const int StateFieldNumber = 7;

		// Token: 0x040047E7 RID: 18407
		private int state_;

		// Token: 0x040047E8 RID: 18408
		public const int IndexFieldNumber = 1;

		// Token: 0x040047E9 RID: 18409
		private int index_;

		// Token: 0x040047EA RID: 18410
		public const int BehaviorTypeFieldNumber = 15;

		// Token: 0x040047EB RID: 18411
		private FsmStateBehaviorType behaviorType_;
	}
}
