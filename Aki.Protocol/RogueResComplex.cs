using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FD3 RID: 4051
	public sealed class RogueResComplex : IMessage<RogueResComplex>, IMessage, IEquatable<RogueResComplex>, IDeepCloneable<RogueResComplex>, IBufferMessage
	{
		// Token: 0x06015A72 RID: 88690 RVA: 0x00324803 File Offset: 0x00322A03
		[NullableContext(1)]
		public static RogueResComplex Create()
		{
			return new RogueResComplex();
		}

		// Token: 0x17004835 RID: 18485
		// (get) Token: 0x06015A73 RID: 88691 RVA: 0x0032480A File Offset: 0x00322A0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004836 RID: 18486
		// (get) Token: 0x06015A74 RID: 88692 RVA: 0x0032480D File Offset: 0x00322A0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResComplex.Descriptor;
			}
		}

		// Token: 0x06015A75 RID: 88693 RVA: 0x00324814 File Offset: 0x00322A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResComplex()
		{
		}

		// Token: 0x06015A76 RID: 88694 RVA: 0x0032481C File Offset: 0x00322A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResComplex(RogueResComplex other) : this()
		{
			this.configId_ = other.configId_;
			this.itemId_ = other.itemId_;
			this.count_ = other.count_;
			this.isSelect_ = other.isSelect_;
			this.isRole_ = other.isRole_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015A77 RID: 88695 RVA: 0x0032487C File Offset: 0x00322A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResComplex Clone()
		{
			return new RogueResComplex(this);
		}

		// Token: 0x17004837 RID: 18487
		// (get) Token: 0x06015A78 RID: 88696 RVA: 0x00324884 File Offset: 0x00322A84
		// (set) Token: 0x06015A79 RID: 88697 RVA: 0x0032488C File Offset: 0x00322A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x17004838 RID: 18488
		// (get) Token: 0x06015A7A RID: 88698 RVA: 0x00324895 File Offset: 0x00322A95
		// (set) Token: 0x06015A7B RID: 88699 RVA: 0x0032489D File Offset: 0x00322A9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x17004839 RID: 18489
		// (get) Token: 0x06015A7C RID: 88700 RVA: 0x003248A6 File Offset: 0x00322AA6
		// (set) Token: 0x06015A7D RID: 88701 RVA: 0x003248AE File Offset: 0x00322AAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x1700483A RID: 18490
		// (get) Token: 0x06015A7E RID: 88702 RVA: 0x003248B7 File Offset: 0x00322AB7
		// (set) Token: 0x06015A7F RID: 88703 RVA: 0x003248BF File Offset: 0x00322ABF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSelect
		{
			get
			{
				return this.isSelect_;
			}
			set
			{
				this.isSelect_ = value;
			}
		}

		// Token: 0x1700483B RID: 18491
		// (get) Token: 0x06015A80 RID: 88704 RVA: 0x003248C8 File Offset: 0x00322AC8
		// (set) Token: 0x06015A81 RID: 88705 RVA: 0x003248D0 File Offset: 0x00322AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsRole
		{
			get
			{
				return this.isRole_;
			}
			set
			{
				this.isRole_ = value;
			}
		}

		// Token: 0x06015A82 RID: 88706 RVA: 0x003248D9 File Offset: 0x00322AD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResComplex);
		}

		// Token: 0x06015A83 RID: 88707 RVA: 0x003248E8 File Offset: 0x00322AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResComplex other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.ItemId == other.ItemId && this.Count == other.Count && this.IsSelect == other.IsSelect && this.IsRole == other.IsRole && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015A84 RID: 88708 RVA: 0x00324964 File Offset: 0x00322B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this.IsSelect)
			{
				num ^= this.IsSelect.GetHashCode();
			}
			if (this.IsRole)
			{
				num ^= this.IsRole.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015A85 RID: 88709 RVA: 0x00324A07 File Offset: 0x00322C07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015A86 RID: 88710 RVA: 0x00324A14 File Offset: 0x00322C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015A87 RID: 88711 RVA: 0x00324A20 File Offset: 0x00322C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConfigId);
			}
			if (this.ItemId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ItemId);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Count);
			}
			if (this.IsSelect)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsSelect);
			}
			if (this.IsRole)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsRole);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015A88 RID: 88712 RVA: 0x00324ACC File Offset: 0x00322CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this.IsSelect)
			{
				num += 2;
			}
			if (this.IsRole)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015A89 RID: 88713 RVA: 0x00324B54 File Offset: 0x00322D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResComplex other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			if (other.IsSelect)
			{
				this.IsSelect = other.IsSelect;
			}
			if (other.IsRole)
			{
				this.IsRole = other.IsRole;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015A8A RID: 88714 RVA: 0x00324BE0 File Offset: 0x00322DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015A8B RID: 88715 RVA: 0x00324BEC File Offset: 0x00322DEC
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.ConfigId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.ItemId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Count = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.IsSelect = input.ReadBool();
						continue;
					}
					if (num == 40U)
					{
						this.IsRole = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040081FC RID: 33276
		private UnknownFieldSet _unknownFields;

		// Token: 0x040081FD RID: 33277
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x040081FE RID: 33278
		private int configId_;

		// Token: 0x040081FF RID: 33279
		public const int ItemIdFieldNumber = 2;

		// Token: 0x04008200 RID: 33280
		private int itemId_;

		// Token: 0x04008201 RID: 33281
		public const int CountFieldNumber = 3;

		// Token: 0x04008202 RID: 33282
		private int count_;

		// Token: 0x04008203 RID: 33283
		public const int IsSelectFieldNumber = 4;

		// Token: 0x04008204 RID: 33284
		private bool isSelect_;

		// Token: 0x04008205 RID: 33285
		public const int IsRoleFieldNumber = 5;

		// Token: 0x04008206 RID: 33286
		private bool isRole_;
	}
}
