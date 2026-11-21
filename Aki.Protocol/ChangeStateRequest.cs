using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000267 RID: 615
	[NetMessage(EMessageId.ChangeStateRequest)]
	public sealed class ChangeStateRequest : IMessage<ChangeStateRequest>, IMessage, IEquatable<ChangeStateRequest>, IDeepCloneable<ChangeStateRequest>, IBufferMessage
	{
		// Token: 0x0600412C RID: 16684 RVA: 0x000A02FB File Offset: 0x0009E4FB
		[NullableContext(1)]
		public static ChangeStateRequest Create()
		{
			return new ChangeStateRequest();
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x0600412D RID: 16685 RVA: 0x000A0302 File Offset: 0x0009E502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x0600412E RID: 16686 RVA: 0x000A0305 File Offset: 0x0009E505
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeStateRequest.Descriptor;
			}
		}

		// Token: 0x0600412F RID: 16687 RVA: 0x000A030C File Offset: 0x0009E50C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateRequest()
		{
		}

		// Token: 0x06004130 RID: 16688 RVA: 0x000A0314 File Offset: 0x0009E514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateRequest(ChangeStateRequest other) : this()
		{
			this.fsmId_ = other.fsmId_;
			this.fromState_ = other.fromState_;
			this.toState_ = other.toState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004131 RID: 16689 RVA: 0x000A0351 File Offset: 0x0009E551
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateRequest Clone()
		{
			return new ChangeStateRequest(this);
		}

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x06004132 RID: 16690 RVA: 0x000A0359 File Offset: 0x0009E559
		// (set) Token: 0x06004133 RID: 16691 RVA: 0x000A0361 File Offset: 0x0009E561
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

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x06004134 RID: 16692 RVA: 0x000A036A File Offset: 0x0009E56A
		// (set) Token: 0x06004135 RID: 16693 RVA: 0x000A0372 File Offset: 0x0009E572
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

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x06004136 RID: 16694 RVA: 0x000A037B File Offset: 0x0009E57B
		// (set) Token: 0x06004137 RID: 16695 RVA: 0x000A0383 File Offset: 0x0009E583
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

		// Token: 0x06004138 RID: 16696 RVA: 0x000A038C File Offset: 0x0009E58C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeStateRequest);
		}

		// Token: 0x06004139 RID: 16697 RVA: 0x000A039C File Offset: 0x0009E59C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeStateRequest other)
		{
			return other != null && (other == this || (this.FsmId == other.FsmId && this.FromState == other.FromState && this.ToState == other.ToState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600413A RID: 16698 RVA: 0x000A03F8 File Offset: 0x0009E5F8
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

		// Token: 0x0600413B RID: 16699 RVA: 0x000A0469 File Offset: 0x0009E669
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600413C RID: 16700 RVA: 0x000A0476 File Offset: 0x0009E676
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600413D RID: 16701 RVA: 0x000A0480 File Offset: 0x0009E680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FromState != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.FromState);
			}
			if (this.ToState != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ToState);
			}
			if (this.FsmId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.FsmId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600413E RID: 16702 RVA: 0x000A04F8 File Offset: 0x0009E6F8
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

		// Token: 0x0600413F RID: 16703 RVA: 0x000A0568 File Offset: 0x0009E768
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

		// Token: 0x06004140 RID: 16704 RVA: 0x000A05CC File Offset: 0x0009E7CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004141 RID: 16705 RVA: 0x000A05D8 File Offset: 0x0009E7D8
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
				if (num != 16U)
				{
					if (num != 112U)
					{
						if (num != 120U)
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
						this.ToState = input.ReadInt32();
					}
				}
				else
				{
					this.FromState = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002DEB RID: 11755
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DEC RID: 11756
		public const int FsmIdFieldNumber = 15;

		// Token: 0x04002DED RID: 11757
		private int fsmId_;

		// Token: 0x04002DEE RID: 11758
		public const int FromStateFieldNumber = 2;

		// Token: 0x04002DEF RID: 11759
		private int fromState_;

		// Token: 0x04002DF0 RID: 11760
		public const int ToStateFieldNumber = 14;

		// Token: 0x04002DF1 RID: 11761
		private int toState_;
	}
}
