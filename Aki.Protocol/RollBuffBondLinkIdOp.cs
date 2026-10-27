using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010ED RID: 4333
	public sealed class RollBuffBondLinkIdOp : IMessage<RollBuffBondLinkIdOp>, IMessage, IEquatable<RollBuffBondLinkIdOp>, IDeepCloneable<RollBuffBondLinkIdOp>, IBufferMessage
	{
		// Token: 0x060171AF RID: 94639 RVA: 0x0035A1F0 File Offset: 0x003583F0
		[NullableContext(1)]
		public static RollBuffBondLinkIdOp Create()
		{
			return new RollBuffBondLinkIdOp();
		}

		// Token: 0x17004D60 RID: 19808
		// (get) Token: 0x060171B0 RID: 94640 RVA: 0x0035A1F7 File Offset: 0x003583F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D61 RID: 19809
		// (get) Token: 0x060171B1 RID: 94641 RVA: 0x0035A1FA File Offset: 0x003583FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBuffBondLinkIdOp.Descriptor;
			}
		}

		// Token: 0x060171B2 RID: 94642 RVA: 0x0035A201 File Offset: 0x00358401
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBuffBondLinkIdOp()
		{
		}

		// Token: 0x060171B3 RID: 94643 RVA: 0x0035A214 File Offset: 0x00358414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBuffBondLinkIdOp(RollBuffBondLinkIdOp other) : this()
		{
			this.rogueResOption_ = ((other.rogueResOption_ != null) ? other.rogueResOption_.Clone() : null);
			this.roleBondInfoView_ = ((other.roleBondInfoView_ != null) ? other.roleBondInfoView_.Clone() : null);
			this.linkId_ = other.linkId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060171B4 RID: 94644 RVA: 0x0035A281 File Offset: 0x00358481
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBuffBondLinkIdOp Clone()
		{
			return new RollBuffBondLinkIdOp(this);
		}

		// Token: 0x17004D62 RID: 19810
		// (get) Token: 0x060171B5 RID: 94645 RVA: 0x0035A289 File Offset: 0x00358489
		// (set) Token: 0x060171B6 RID: 94646 RVA: 0x0035A291 File Offset: 0x00358491
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

		// Token: 0x17004D63 RID: 19811
		// (get) Token: 0x060171B7 RID: 94647 RVA: 0x0035A29A File Offset: 0x0035849A
		// (set) Token: 0x060171B8 RID: 94648 RVA: 0x0035A2A2 File Offset: 0x003584A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleBondInfoView RoleBondInfoView
		{
			get
			{
				return this.roleBondInfoView_;
			}
			set
			{
				this.roleBondInfoView_ = value;
			}
		}

		// Token: 0x17004D64 RID: 19812
		// (get) Token: 0x060171B9 RID: 94649 RVA: 0x0035A2AB File Offset: 0x003584AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> LinkId
		{
			get
			{
				return this.linkId_;
			}
		}

		// Token: 0x060171BA RID: 94650 RVA: 0x0035A2B3 File Offset: 0x003584B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBuffBondLinkIdOp);
		}

		// Token: 0x060171BB RID: 94651 RVA: 0x0035A2C4 File Offset: 0x003584C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBuffBondLinkIdOp other)
		{
			return other != null && (other == this || (object.Equals(this.RogueResOption, other.RogueResOption) && object.Equals(this.RoleBondInfoView, other.RoleBondInfoView) && this.linkId_.Equals(other.linkId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060171BC RID: 94652 RVA: 0x0035A32C File Offset: 0x0035852C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueResOption_ != null)
			{
				num ^= this.RogueResOption.GetHashCode();
			}
			if (this.roleBondInfoView_ != null)
			{
				num ^= this.RoleBondInfoView.GetHashCode();
			}
			num ^= this.linkId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060171BD RID: 94653 RVA: 0x0035A38C File Offset: 0x0035858C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060171BE RID: 94654 RVA: 0x0035A399 File Offset: 0x00358599
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060171BF RID: 94655 RVA: 0x0035A3A4 File Offset: 0x003585A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueResOption_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.RogueResOption);
			}
			if (this.roleBondInfoView_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.RoleBondInfoView);
			}
			this.linkId_.WriteTo(ref output, RollBuffBondLinkIdOp._repeated_linkId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060171C0 RID: 94656 RVA: 0x0035A410 File Offset: 0x00358610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueResOption_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueResOption);
			}
			if (this.roleBondInfoView_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoleBondInfoView);
			}
			num += this.linkId_.CalculateSize(RollBuffBondLinkIdOp._repeated_linkId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060171C1 RID: 94657 RVA: 0x0035A47C File Offset: 0x0035867C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RollBuffBondLinkIdOp other)
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
			if (other.roleBondInfoView_ != null)
			{
				if (this.roleBondInfoView_ == null)
				{
					this.RoleBondInfoView = new RoleBondInfoView();
				}
				this.RoleBondInfoView.MergeFrom(other.RoleBondInfoView);
			}
			this.linkId_.Add(other.linkId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060171C2 RID: 94658 RVA: 0x0035A50D File Offset: 0x0035870D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060171C3 RID: 94659 RVA: 0x0035A518 File Offset: 0x00358718
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
				if (num <= 18U)
				{
					if (num == 10U)
					{
						if (this.rogueResOption_ == null)
						{
							this.RogueResOption = new RogueResOption();
						}
						input.ReadMessage(this.RogueResOption);
						continue;
					}
					if (num == 18U)
					{
						if (this.roleBondInfoView_ == null)
						{
							this.RoleBondInfoView = new RoleBondInfoView();
						}
						input.ReadMessage(this.RoleBondInfoView);
						continue;
					}
				}
				else if (num == 24U || num == 26U)
				{
					this.linkId_.AddEntriesFrom(ref input, RollBuffBondLinkIdOp._repeated_linkId_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400895F RID: 35167
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008960 RID: 35168
		public const int RogueResOptionFieldNumber = 1;

		// Token: 0x04008961 RID: 35169
		private RogueResOption rogueResOption_;

		// Token: 0x04008962 RID: 35170
		public const int RoleBondInfoViewFieldNumber = 2;

		// Token: 0x04008963 RID: 35171
		private RoleBondInfoView roleBondInfoView_;

		// Token: 0x04008964 RID: 35172
		public const int LinkIdFieldNumber = 3;

		// Token: 0x04008965 RID: 35173
		private static readonly FieldCodec<int> _repeated_linkId_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04008966 RID: 35174
		private readonly RepeatedField<int> linkId_ = new RepeatedField<int>();
	}
}
