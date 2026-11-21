using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011FB RID: 4603
	public sealed class SelectViewOp : IMessage<SelectViewOp>, IMessage, IEquatable<SelectViewOp>, IDeepCloneable<SelectViewOp>, IBufferMessage
	{
		// Token: 0x060189A7 RID: 100775 RVA: 0x00396FF7 File Offset: 0x003951F7
		[NullableContext(1)]
		public static SelectViewOp Create()
		{
			return new SelectViewOp();
		}

		// Token: 0x17005320 RID: 21280
		// (get) Token: 0x060189A8 RID: 100776 RVA: 0x00396FFE File Offset: 0x003951FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005321 RID: 21281
		// (get) Token: 0x060189A9 RID: 100777 RVA: 0x00397001 File Offset: 0x00395201
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SelectViewOp.Descriptor;
			}
		}

		// Token: 0x060189AA RID: 100778 RVA: 0x00397008 File Offset: 0x00395208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectViewOp()
		{
		}

		// Token: 0x060189AB RID: 100779 RVA: 0x00397010 File Offset: 0x00395210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectViewOp(SelectViewOp other) : this()
		{
			this.rogueResOption_ = ((other.rogueResOption_ != null) ? other.rogueResOption_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060189AC RID: 100780 RVA: 0x00397045 File Offset: 0x00395245
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectViewOp Clone()
		{
			return new SelectViewOp(this);
		}

		// Token: 0x17005322 RID: 21282
		// (get) Token: 0x060189AD RID: 100781 RVA: 0x0039704D File Offset: 0x0039524D
		// (set) Token: 0x060189AE RID: 100782 RVA: 0x00397055 File Offset: 0x00395255
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResOption RogueResOption
		{
			get
			{
				return this.rogueResOption_;
			}
			set
			{
				this.rogueResOption_ = value;
			}
		}

		// Token: 0x060189AF RID: 100783 RVA: 0x0039705E File Offset: 0x0039525E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SelectViewOp);
		}

		// Token: 0x060189B0 RID: 100784 RVA: 0x0039706C File Offset: 0x0039526C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SelectViewOp other)
		{
			return other != null && (other == this || (object.Equals(this.RogueResOption, other.RogueResOption) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060189B1 RID: 100785 RVA: 0x003970A0 File Offset: 0x003952A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueResOption_ != null)
			{
				num ^= this.RogueResOption.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060189B2 RID: 100786 RVA: 0x003970DC File Offset: 0x003952DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060189B3 RID: 100787 RVA: 0x003970E9 File Offset: 0x003952E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060189B4 RID: 100788 RVA: 0x003970F2 File Offset: 0x003952F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueResOption_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.RogueResOption);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060189B5 RID: 100789 RVA: 0x00397124 File Offset: 0x00395324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueResOption_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueResOption);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060189B6 RID: 100790 RVA: 0x00397164 File Offset: 0x00395364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SelectViewOp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueResOption_ != null)
			{
				if (this.rogueResOption_ == null)
				{
					this.RogueResOption = new RogueResOption();
				}
				this.RogueResOption.MergeFrom(other.RogueResOption);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060189B7 RID: 100791 RVA: 0x003971B8 File Offset: 0x003953B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060189B8 RID: 100792 RVA: 0x003971C4 File Offset: 0x003953C4
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.rogueResOption_ == null)
					{
						this.RogueResOption = new RogueResOption();
					}
					input.ReadMessage(this.RogueResOption);
				}
			}
		}

		// Token: 0x0400925A RID: 37466
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400925B RID: 37467
		public const int RogueResOptionFieldNumber = 1;

		// Token: 0x0400925C RID: 37468
		private RogueResOption rogueResOption_;
	}
}
