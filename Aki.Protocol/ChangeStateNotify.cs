using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000266 RID: 614
	[NetMessage(EMessageId.ChangeStateNotify)]
	public sealed class ChangeStateNotify : IMessage<ChangeStateNotify>, IMessage, IEquatable<ChangeStateNotify>, IDeepCloneable<ChangeStateNotify>, IBufferMessage
	{
		// Token: 0x06004116 RID: 16662 RVA: 0x0009FFB2 File Offset: 0x0009E1B2
		[NullableContext(1)]
		public static ChangeStateNotify Create()
		{
			return new ChangeStateNotify();
		}

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x06004117 RID: 16663 RVA: 0x0009FFB9 File Offset: 0x0009E1B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x06004118 RID: 16664 RVA: 0x0009FFBC File Offset: 0x0009E1BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeStateNotify.Descriptor;
			}
		}

		// Token: 0x06004119 RID: 16665 RVA: 0x0009FFC3 File Offset: 0x0009E1C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateNotify()
		{
		}

		// Token: 0x0600411A RID: 16666 RVA: 0x0009FFCB File Offset: 0x0009E1CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateNotify(ChangeStateNotify other) : this()
		{
			this.fsmId_ = other.fsmId_;
			this.fromState_ = other.fromState_;
			this.toState_ = other.toState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600411B RID: 16667 RVA: 0x000A0008 File Offset: 0x0009E208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateNotify Clone()
		{
			return new ChangeStateNotify(this);
		}

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x0600411C RID: 16668 RVA: 0x000A0010 File Offset: 0x0009E210
		// (set) Token: 0x0600411D RID: 16669 RVA: 0x000A0018 File Offset: 0x0009E218
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

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x0600411E RID: 16670 RVA: 0x000A0021 File Offset: 0x0009E221
		// (set) Token: 0x0600411F RID: 16671 RVA: 0x000A0029 File Offset: 0x0009E229
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

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x06004120 RID: 16672 RVA: 0x000A0032 File Offset: 0x0009E232
		// (set) Token: 0x06004121 RID: 16673 RVA: 0x000A003A File Offset: 0x0009E23A
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

		// Token: 0x06004122 RID: 16674 RVA: 0x000A0043 File Offset: 0x0009E243
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeStateNotify);
		}

		// Token: 0x06004123 RID: 16675 RVA: 0x000A0054 File Offset: 0x0009E254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeStateNotify other)
		{
			return other != null && (other == this || (this.FsmId == other.FsmId && this.FromState == other.FromState && this.ToState == other.ToState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004124 RID: 16676 RVA: 0x000A00B0 File Offset: 0x0009E2B0
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

		// Token: 0x06004125 RID: 16677 RVA: 0x000A0121 File Offset: 0x0009E321
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004126 RID: 16678 RVA: 0x000A012E File Offset: 0x0009E32E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004127 RID: 16679 RVA: 0x000A0138 File Offset: 0x0009E338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ToState != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ToState);
			}
			if (this.FromState != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.FromState);
			}
			if (this.FsmId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.FsmId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004128 RID: 16680 RVA: 0x000A01B0 File Offset: 0x0009E3B0
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

		// Token: 0x06004129 RID: 16681 RVA: 0x000A0220 File Offset: 0x0009E420
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

		// Token: 0x0600412A RID: 16682 RVA: 0x000A0284 File Offset: 0x0009E484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600412B RID: 16683 RVA: 0x000A0290 File Offset: 0x0009E490
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
				if (num != 32U)
				{
					if (num != 56U)
					{
						if (num != 96U)
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

		// Token: 0x04002DE4 RID: 11748
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DE5 RID: 11749
		public const int FsmIdFieldNumber = 12;

		// Token: 0x04002DE6 RID: 11750
		private int fsmId_;

		// Token: 0x04002DE7 RID: 11751
		public const int FromStateFieldNumber = 7;

		// Token: 0x04002DE8 RID: 11752
		private int fromState_;

		// Token: 0x04002DE9 RID: 11753
		public const int ToStateFieldNumber = 4;

		// Token: 0x04002DEA RID: 11754
		private int toState_;
	}
}
