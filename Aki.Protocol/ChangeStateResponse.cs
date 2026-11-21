using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000268 RID: 616
	[NetMessage(EMessageId.ChangeStateResponse)]
	public sealed class ChangeStateResponse : IMessage<ChangeStateResponse>, IMessage, IEquatable<ChangeStateResponse>, IDeepCloneable<ChangeStateResponse>, IBufferMessage
	{
		// Token: 0x06004142 RID: 16706 RVA: 0x000A0643 File Offset: 0x0009E843
		[NullableContext(1)]
		public static ChangeStateResponse Create()
		{
			return new ChangeStateResponse();
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x06004143 RID: 16707 RVA: 0x000A064A File Offset: 0x0009E84A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x06004144 RID: 16708 RVA: 0x000A064D File Offset: 0x0009E84D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeStateResponse.Descriptor;
			}
		}

		// Token: 0x06004145 RID: 16709 RVA: 0x000A0654 File Offset: 0x0009E854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateResponse()
		{
		}

		// Token: 0x06004146 RID: 16710 RVA: 0x000A065C File Offset: 0x0009E85C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateResponse(ChangeStateResponse other) : this()
		{
			this.fsmId_ = other.fsmId_;
			this.error_ = ((other.error_ != null) ? other.error_.Clone() : null);
			this.currentState_ = other.currentState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004147 RID: 16711 RVA: 0x000A06B4 File Offset: 0x0009E8B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateResponse Clone()
		{
			return new ChangeStateResponse(this);
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x06004148 RID: 16712 RVA: 0x000A06BC File Offset: 0x0009E8BC
		// (set) Token: 0x06004149 RID: 16713 RVA: 0x000A06C4 File Offset: 0x0009E8C4
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

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x0600414A RID: 16714 RVA: 0x000A06CD File Offset: 0x0009E8CD
		// (set) Token: 0x0600414B RID: 16715 RVA: 0x000A06D5 File Offset: 0x0009E8D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DErrorResult Error
		{
			get
			{
				return this.error_;
			}
			set
			{
				this.error_ = value;
			}
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x0600414C RID: 16716 RVA: 0x000A06DE File Offset: 0x0009E8DE
		// (set) Token: 0x0600414D RID: 16717 RVA: 0x000A06E6 File Offset: 0x0009E8E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurrentState
		{
			get
			{
				return this.currentState_;
			}
			set
			{
				this.currentState_ = value;
			}
		}

		// Token: 0x0600414E RID: 16718 RVA: 0x000A06EF File Offset: 0x0009E8EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeStateResponse);
		}

		// Token: 0x0600414F RID: 16719 RVA: 0x000A0700 File Offset: 0x0009E900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeStateResponse other)
		{
			return other != null && (other == this || (this.FsmId == other.FsmId && object.Equals(this.Error, other.Error) && this.CurrentState == other.CurrentState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004150 RID: 16720 RVA: 0x000A0760 File Offset: 0x0009E960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FsmId != 0)
			{
				num ^= this.FsmId.GetHashCode();
			}
			if (this.error_ != null)
			{
				num ^= this.Error.GetHashCode();
			}
			if (this.CurrentState != 0)
			{
				num ^= this.CurrentState.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004151 RID: 16721 RVA: 0x000A07CE File Offset: 0x0009E9CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004152 RID: 16722 RVA: 0x000A07DB File Offset: 0x0009E9DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004153 RID: 16723 RVA: 0x000A07E4 File Offset: 0x0009E9E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.error_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Error);
			}
			if (this.FsmId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.FsmId);
			}
			if (this.CurrentState != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.CurrentState);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004154 RID: 16724 RVA: 0x000A085C File Offset: 0x0009EA5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FsmId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FsmId);
			}
			if (this.error_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Error);
			}
			if (this.CurrentState != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurrentState);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004155 RID: 16725 RVA: 0x000A08CC File Offset: 0x0009EACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeStateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FsmId != 0)
			{
				this.FsmId = other.FsmId;
			}
			if (other.error_ != null)
			{
				if (this.error_ == null)
				{
					this.Error = new DErrorResult();
				}
				this.Error.MergeFrom(other.Error);
			}
			if (other.CurrentState != 0)
			{
				this.CurrentState = other.CurrentState;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004156 RID: 16726 RVA: 0x000A0948 File Offset: 0x0009EB48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004157 RID: 16727 RVA: 0x000A0954 File Offset: 0x0009EB54
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
				if (num != 10U)
				{
					if (num != 56U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.CurrentState = input.ReadInt32();
						}
					}
					else
					{
						this.FsmId = input.ReadInt32();
					}
				}
				else
				{
					if (this.error_ == null)
					{
						this.Error = new DErrorResult();
					}
					input.ReadMessage(this.Error);
				}
			}
		}

		// Token: 0x04002DF2 RID: 11762
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DF3 RID: 11763
		public const int FsmIdFieldNumber = 7;

		// Token: 0x04002DF4 RID: 11764
		private int fsmId_;

		// Token: 0x04002DF5 RID: 11765
		public const int ErrorFieldNumber = 1;

		// Token: 0x04002DF6 RID: 11766
		private DErrorResult error_;

		// Token: 0x04002DF7 RID: 11767
		public const int CurrentStateFieldNumber = 13;

		// Token: 0x04002DF8 RID: 11768
		private int currentState_;
	}
}
