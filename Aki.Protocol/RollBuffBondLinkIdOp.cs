using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001127 RID: 4391
	public sealed class RollBuffBondLinkIdOp : IMessage<RollBuffBondLinkIdOp>, IMessage, IEquatable<RollBuffBondLinkIdOp>, IDeepCloneable<RollBuffBondLinkIdOp>, IBufferMessage
	{
		// Token: 0x06017750 RID: 96080 RVA: 0x00369548 File Offset: 0x00367748
		[NullableContext(1)]
		public static RollBuffBondLinkIdOp Create()
		{
			return new RollBuffBondLinkIdOp();
		}

		// Token: 0x17004ECC RID: 20172
		// (get) Token: 0x06017751 RID: 96081 RVA: 0x0036954F File Offset: 0x0036774F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004ECD RID: 20173
		// (get) Token: 0x06017752 RID: 96082 RVA: 0x00369552 File Offset: 0x00367752
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBuffBondLinkIdOp.Descriptor;
			}
		}

		// Token: 0x06017753 RID: 96083 RVA: 0x00369559 File Offset: 0x00367759
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBuffBondLinkIdOp()
		{
		}

		// Token: 0x06017754 RID: 96084 RVA: 0x0036956C File Offset: 0x0036776C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBuffBondLinkIdOp(RollBuffBondLinkIdOp other) : this()
		{
			this.rogueResOption_ = ((other.rogueResOption_ != null) ? other.rogueResOption_.Clone() : null);
			this.roleBondInfoView_ = ((other.roleBondInfoView_ != null) ? other.roleBondInfoView_.Clone() : null);
			this.linkId_ = other.linkId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017755 RID: 96085 RVA: 0x003695D9 File Offset: 0x003677D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBuffBondLinkIdOp Clone()
		{
			return new RollBuffBondLinkIdOp(this);
		}

		// Token: 0x17004ECE RID: 20174
		// (get) Token: 0x06017756 RID: 96086 RVA: 0x003695E1 File Offset: 0x003677E1
		// (set) Token: 0x06017757 RID: 96087 RVA: 0x003695E9 File Offset: 0x003677E9
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

		// Token: 0x17004ECF RID: 20175
		// (get) Token: 0x06017758 RID: 96088 RVA: 0x003695F2 File Offset: 0x003677F2
		// (set) Token: 0x06017759 RID: 96089 RVA: 0x003695FA File Offset: 0x003677FA
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

		// Token: 0x17004ED0 RID: 20176
		// (get) Token: 0x0601775A RID: 96090 RVA: 0x00369603 File Offset: 0x00367803
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> LinkId
		{
			get
			{
				return this.linkId_;
			}
		}

		// Token: 0x0601775B RID: 96091 RVA: 0x0036960B File Offset: 0x0036780B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBuffBondLinkIdOp);
		}

		// Token: 0x0601775C RID: 96092 RVA: 0x0036961C File Offset: 0x0036781C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBuffBondLinkIdOp other)
		{
			return other != null && (other == this || (object.Equals(this.RogueResOption, other.RogueResOption) && object.Equals(this.RoleBondInfoView, other.RoleBondInfoView) && this.linkId_.Equals(other.linkId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601775D RID: 96093 RVA: 0x00369684 File Offset: 0x00367884
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

		// Token: 0x0601775E RID: 96094 RVA: 0x003696E4 File Offset: 0x003678E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601775F RID: 96095 RVA: 0x003696F1 File Offset: 0x003678F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017760 RID: 96096 RVA: 0x003696FC File Offset: 0x003678FC
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

		// Token: 0x06017761 RID: 96097 RVA: 0x00369768 File Offset: 0x00367968
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

		// Token: 0x06017762 RID: 96098 RVA: 0x003697D4 File Offset: 0x003679D4
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

		// Token: 0x06017763 RID: 96099 RVA: 0x00369865 File Offset: 0x00367A65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017764 RID: 96100 RVA: 0x00369870 File Offset: 0x00367A70
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

		// Token: 0x04008BF2 RID: 35826
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008BF3 RID: 35827
		public const int RogueResOptionFieldNumber = 1;

		// Token: 0x04008BF4 RID: 35828
		private RogueResOption rogueResOption_;

		// Token: 0x04008BF5 RID: 35829
		public const int RoleBondInfoViewFieldNumber = 2;

		// Token: 0x04008BF6 RID: 35830
		private RoleBondInfoView roleBondInfoView_;

		// Token: 0x04008BF7 RID: 35831
		public const int LinkIdFieldNumber = 3;

		// Token: 0x04008BF8 RID: 35832
		private static readonly FieldCodec<int> _repeated_linkId_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04008BF9 RID: 35833
		private readonly RepeatedField<int> linkId_ = new RepeatedField<int>();
	}
}
