using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000262 RID: 610
	[NetMessage(EMessageId.ChangeStateRequest)]
	public sealed class ChangeStateRequest : IMessage<ChangeStateRequest>, IMessage, IEquatable<ChangeStateRequest>, IDeepCloneable<ChangeStateRequest>, IBufferMessage
	{
		// Token: 0x06004085 RID: 16517 RVA: 0x0009E623 File Offset: 0x0009C823
		[NullableContext(1)]
		public static ChangeStateRequest Create()
		{
			return new ChangeStateRequest();
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x06004086 RID: 16518 RVA: 0x0009E62A File Offset: 0x0009C82A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x06004087 RID: 16519 RVA: 0x0009E62D File Offset: 0x0009C82D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeStateRequest.Descriptor;
			}
		}

		// Token: 0x06004088 RID: 16520 RVA: 0x0009E634 File Offset: 0x0009C834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateRequest()
		{
		}

		// Token: 0x06004089 RID: 16521 RVA: 0x0009E63C File Offset: 0x0009C83C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateRequest(ChangeStateRequest other) : this()
		{
			this.fsmId_ = other.fsmId_;
			this.fromState_ = other.fromState_;
			this.toState_ = other.toState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600408A RID: 16522 RVA: 0x0009E679 File Offset: 0x0009C879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateRequest Clone()
		{
			return new ChangeStateRequest(this);
		}

		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x0600408B RID: 16523 RVA: 0x0009E681 File Offset: 0x0009C881
		// (set) Token: 0x0600408C RID: 16524 RVA: 0x0009E689 File Offset: 0x0009C889
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

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x0600408D RID: 16525 RVA: 0x0009E692 File Offset: 0x0009C892
		// (set) Token: 0x0600408E RID: 16526 RVA: 0x0009E69A File Offset: 0x0009C89A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FromState
		{
			get
			{
				return this.fromState_;
			}
			set
			{
				this.fromState_ = value;
			}
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x0600408F RID: 16527 RVA: 0x0009E6A3 File Offset: 0x0009C8A3
		// (set) Token: 0x06004090 RID: 16528 RVA: 0x0009E6AB File Offset: 0x0009C8AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ToState
		{
			get
			{
				return this.toState_;
			}
			set
			{
				this.toState_ = value;
			}
		}

		// Token: 0x06004091 RID: 16529 RVA: 0x0009E6B4 File Offset: 0x0009C8B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeStateRequest);
		}

		// Token: 0x06004092 RID: 16530 RVA: 0x0009E6C4 File Offset: 0x0009C8C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeStateRequest other)
		{
			return other != null && (other == this || (this.FsmId == other.FsmId && this.FromState == other.FromState && this.ToState == other.ToState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004093 RID: 16531 RVA: 0x0009E720 File Offset: 0x0009C920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FsmId != 0)
			{
				num ^= this.FsmId.GetHashCode();
			}
			if (this.FromState != 0)
			{
				num ^= this.FromState.GetHashCode();
			}
			if (this.ToState != 0)
			{
				num ^= this.ToState.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004094 RID: 16532 RVA: 0x0009E791 File Offset: 0x0009C991
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004095 RID: 16533 RVA: 0x0009E79E File Offset: 0x0009C99E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004096 RID: 16534 RVA: 0x0009E7A8 File Offset: 0x0009C9A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ToState != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ToState);
			}
			if (this.FsmId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.FsmId);
			}
			if (this.FromState != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.FromState);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004097 RID: 16535 RVA: 0x0009E81C File Offset: 0x0009CA1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FsmId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FsmId);
			}
			if (this.FromState != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FromState);
			}
			if (this.ToState != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ToState);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004098 RID: 16536 RVA: 0x0009E88C File Offset: 0x0009CA8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeStateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FsmId != 0)
			{
				this.FsmId = other.FsmId;
			}
			if (other.FromState != 0)
			{
				this.FromState = other.FromState;
			}
			if (other.ToState != 0)
			{
				this.ToState = other.ToState;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004099 RID: 16537 RVA: 0x0009E8F0 File Offset: 0x0009CAF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600409A RID: 16538 RVA: 0x0009E8FC File Offset: 0x0009CAFC
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
					if (num != 24U)
					{
						if (num != 64U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.FromState = input.ReadInt32();
						}
					}
					else
					{
						this.FsmId = input.ReadInt32();
					}
				}
				else
				{
					this.ToState = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002D67 RID: 11623
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D68 RID: 11624
		public const int FsmIdFieldNumber = 3;

		// Token: 0x04002D69 RID: 11625
		private int fsmId_;

		// Token: 0x04002D6A RID: 11626
		public const int FromStateFieldNumber = 8;

		// Token: 0x04002D6B RID: 11627
		private int fromState_;

		// Token: 0x04002D6C RID: 11628
		public const int ToStateFieldNumber = 1;

		// Token: 0x04002D6D RID: 11629
		private int toState_;
	}
}
