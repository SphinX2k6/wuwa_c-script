using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000261 RID: 609
	[NetMessage(EMessageId.ChangeStateNotify)]
	public sealed class ChangeStateNotify : IMessage<ChangeStateNotify>, IMessage, IEquatable<ChangeStateNotify>, IDeepCloneable<ChangeStateNotify>, IBufferMessage
	{
		// Token: 0x0600406F RID: 16495 RVA: 0x0009E2DD File Offset: 0x0009C4DD
		[NullableContext(1)]
		public static ChangeStateNotify Create()
		{
			return new ChangeStateNotify();
		}

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x06004070 RID: 16496 RVA: 0x0009E2E4 File Offset: 0x0009C4E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x06004071 RID: 16497 RVA: 0x0009E2E7 File Offset: 0x0009C4E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeStateNotify.Descriptor;
			}
		}

		// Token: 0x06004072 RID: 16498 RVA: 0x0009E2EE File Offset: 0x0009C4EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateNotify()
		{
		}

		// Token: 0x06004073 RID: 16499 RVA: 0x0009E2F6 File Offset: 0x0009C4F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateNotify(ChangeStateNotify other) : this()
		{
			this.fsmId_ = other.fsmId_;
			this.fromState_ = other.fromState_;
			this.toState_ = other.toState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004074 RID: 16500 RVA: 0x0009E333 File Offset: 0x0009C533
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateNotify Clone()
		{
			return new ChangeStateNotify(this);
		}

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x06004075 RID: 16501 RVA: 0x0009E33B File Offset: 0x0009C53B
		// (set) Token: 0x06004076 RID: 16502 RVA: 0x0009E343 File Offset: 0x0009C543
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

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x06004077 RID: 16503 RVA: 0x0009E34C File Offset: 0x0009C54C
		// (set) Token: 0x06004078 RID: 16504 RVA: 0x0009E354 File Offset: 0x0009C554
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

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x06004079 RID: 16505 RVA: 0x0009E35D File Offset: 0x0009C55D
		// (set) Token: 0x0600407A RID: 16506 RVA: 0x0009E365 File Offset: 0x0009C565
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

		// Token: 0x0600407B RID: 16507 RVA: 0x0009E36E File Offset: 0x0009C56E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeStateNotify);
		}

		// Token: 0x0600407C RID: 16508 RVA: 0x0009E37C File Offset: 0x0009C57C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeStateNotify other)
		{
			return other != null && (other == this || (this.FsmId == other.FsmId && this.FromState == other.FromState && this.ToState == other.ToState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600407D RID: 16509 RVA: 0x0009E3D8 File Offset: 0x0009C5D8
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

		// Token: 0x0600407E RID: 16510 RVA: 0x0009E449 File Offset: 0x0009C649
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600407F RID: 16511 RVA: 0x0009E456 File Offset: 0x0009C656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004080 RID: 16512 RVA: 0x0009E460 File Offset: 0x0009C660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ToState != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ToState);
			}
			if (this.FromState != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.FromState);
			}
			if (this.FsmId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.FsmId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004081 RID: 16513 RVA: 0x0009E4D8 File Offset: 0x0009C6D8
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

		// Token: 0x06004082 RID: 16514 RVA: 0x0009E548 File Offset: 0x0009C748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeStateNotify other)
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

		// Token: 0x06004083 RID: 16515 RVA: 0x0009E5AC File Offset: 0x0009C7AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004084 RID: 16516 RVA: 0x0009E5B8 File Offset: 0x0009C7B8
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
					if (num != 56U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.FsmId = input.ReadInt32();
						}
					}
					else
					{
						this.FromState = input.ReadInt32();
					}
				}
				else
				{
					this.ToState = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002D60 RID: 11616
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D61 RID: 11617
		public const int FsmIdFieldNumber = 11;

		// Token: 0x04002D62 RID: 11618
		private int fsmId_;

		// Token: 0x04002D63 RID: 11619
		public const int FromStateFieldNumber = 7;

		// Token: 0x04002D64 RID: 11620
		private int fromState_;

		// Token: 0x04002D65 RID: 11621
		public const int ToStateFieldNumber = 6;

		// Token: 0x04002D66 RID: 11622
		private int toState_;
	}
}
