using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001117 RID: 4375
	[NetMessage(EMessageId.RollBlockInputRequest)]
	public sealed class RollBlockInputRequest : IMessage<RollBlockInputRequest>, IMessage, IEquatable<RollBlockInputRequest>, IDeepCloneable<RollBlockInputRequest>, IBufferMessage
	{
		// Token: 0x06017622 RID: 95778 RVA: 0x003670C9 File Offset: 0x003652C9
		[NullableContext(1)]
		public static RollBlockInputRequest Create()
		{
			return new RollBlockInputRequest();
		}

		// Token: 0x17004E95 RID: 20117
		// (get) Token: 0x06017623 RID: 95779 RVA: 0x003670D0 File Offset: 0x003652D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E96 RID: 20118
		// (get) Token: 0x06017624 RID: 95780 RVA: 0x003670D3 File Offset: 0x003652D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBlockInputRequest.Descriptor;
			}
		}

		// Token: 0x06017625 RID: 95781 RVA: 0x003670DA File Offset: 0x003652DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockInputRequest()
		{
		}

		// Token: 0x06017626 RID: 95782 RVA: 0x003670E4 File Offset: 0x003652E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockInputRequest(RollBlockInputRequest other) : this()
		{
			this.incId_ = other.incId_;
			this.input_ = ((other.input_ != null) ? other.input_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017627 RID: 95783 RVA: 0x00367130 File Offset: 0x00365330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockInputRequest Clone()
		{
			return new RollBlockInputRequest(this);
		}

		// Token: 0x17004E97 RID: 20119
		// (get) Token: 0x06017628 RID: 95784 RVA: 0x00367138 File Offset: 0x00365338
		// (set) Token: 0x06017629 RID: 95785 RVA: 0x00367140 File Offset: 0x00365340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x17004E98 RID: 20120
		// (get) Token: 0x0601762A RID: 95786 RVA: 0x00367149 File Offset: 0x00365349
		// (set) Token: 0x0601762B RID: 95787 RVA: 0x00367151 File Offset: 0x00365351
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbInput Input
		{
			get
			{
				return this.input_;
			}
			set
			{
				this.input_ = value;
			}
		}

		// Token: 0x0601762C RID: 95788 RVA: 0x0036715A File Offset: 0x0036535A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBlockInputRequest);
		}

		// Token: 0x0601762D RID: 95789 RVA: 0x00367168 File Offset: 0x00365368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBlockInputRequest other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && object.Equals(this.Input, other.Input) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601762E RID: 95790 RVA: 0x003671B8 File Offset: 0x003653B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.input_ != null)
			{
				num ^= this.Input.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601762F RID: 95791 RVA: 0x0036720D File Offset: 0x0036540D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017630 RID: 95792 RVA: 0x0036721A File Offset: 0x0036541A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017631 RID: 95793 RVA: 0x00367224 File Offset: 0x00365424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.input_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Input);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017632 RID: 95794 RVA: 0x00367280 File Offset: 0x00365480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this.input_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Input);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017633 RID: 95795 RVA: 0x003672D8 File Offset: 0x003654D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RollBlockInputRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			if (other.input_ != null)
			{
				if (this.input_ == null)
				{
					this.Input = new RbInput();
				}
				this.Input.MergeFrom(other.Input);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017634 RID: 95796 RVA: 0x00367340 File Offset: 0x00365540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017635 RID: 95797 RVA: 0x0036734C File Offset: 0x0036554C
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
				if (num != 50U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IncId = input.ReadInt32();
					}
				}
				else
				{
					if (this.input_ == null)
					{
						this.Input = new RbInput();
					}
					input.ReadMessage(this.Input);
				}
			}
		}

		// Token: 0x04008BB2 RID: 35762
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008BB3 RID: 35763
		public const int IncIdFieldNumber = 11;

		// Token: 0x04008BB4 RID: 35764
		private int incId_;

		// Token: 0x04008BB5 RID: 35765
		public const int InputFieldNumber = 6;

		// Token: 0x04008BB6 RID: 35766
		private RbInput input_;
	}
}
