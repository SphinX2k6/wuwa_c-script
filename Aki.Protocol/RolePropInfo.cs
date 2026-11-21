using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200108C RID: 4236
	public sealed class RolePropInfo : IMessage<RolePropInfo>, IMessage, IEquatable<RolePropInfo>, IDeepCloneable<RolePropInfo>, IBufferMessage
	{
		// Token: 0x06016A81 RID: 92801 RVA: 0x0034BBB6 File Offset: 0x00349DB6
		[NullableContext(1)]
		public static RolePropInfo Create()
		{
			return new RolePropInfo();
		}

		// Token: 0x17004BF1 RID: 19441
		// (get) Token: 0x06016A82 RID: 92802 RVA: 0x0034BBBD File Offset: 0x00349DBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RolePropInfo> Parser
		{
			get
			{
				return RolePropInfo._parser;
			}
		}

		// Token: 0x17004BF2 RID: 19442
		// (get) Token: 0x06016A83 RID: 92803 RVA: 0x0034BBC4 File Offset: 0x00349DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004BF3 RID: 19443
		// (get) Token: 0x06016A84 RID: 92804 RVA: 0x0034BBC7 File Offset: 0x00349DC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RolePropInfo.Descriptor;
			}
		}

		// Token: 0x06016A85 RID: 92805 RVA: 0x0034BBCE File Offset: 0x00349DCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePropInfo()
		{
		}

		// Token: 0x06016A86 RID: 92806 RVA: 0x0034BBEC File Offset: 0x00349DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePropInfo(RolePropInfo other) : this()
		{
			this.roleId_ = other.roleId_;
			this.baseProp_ = other.baseProp_.Clone();
			this.addProp_ = other.addProp_.Clone();
			this.phantomProp_ = ((other.phantomProp_ != null) ? other.phantomProp_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016A87 RID: 92807 RVA: 0x0034BC5A File Offset: 0x00349E5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePropInfo Clone()
		{
			return new RolePropInfo(this);
		}

		// Token: 0x17004BF4 RID: 19444
		// (get) Token: 0x06016A88 RID: 92808 RVA: 0x0034BC62 File Offset: 0x00349E62
		// (set) Token: 0x06016A89 RID: 92809 RVA: 0x0034BC6A File Offset: 0x00349E6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x17004BF5 RID: 19445
		// (get) Token: 0x06016A8A RID: 92810 RVA: 0x0034BC73 File Offset: 0x00349E73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArrayIntInt> BaseProp
		{
			get
			{
				return this.baseProp_;
			}
		}

		// Token: 0x17004BF6 RID: 19446
		// (get) Token: 0x06016A8B RID: 92811 RVA: 0x0034BC7B File Offset: 0x00349E7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArrayIntInt> AddProp
		{
			get
			{
				return this.addProp_;
			}
		}

		// Token: 0x17004BF7 RID: 19447
		// (get) Token: 0x06016A8C RID: 92812 RVA: 0x0034BC83 File Offset: 0x00349E83
		// (set) Token: 0x06016A8D RID: 92813 RVA: 0x0034BC8B File Offset: 0x00349E8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePhantomPropInfo PhantomProp
		{
			get
			{
				return this.phantomProp_;
			}
			set
			{
				this.phantomProp_ = value;
			}
		}

		// Token: 0x06016A8E RID: 92814 RVA: 0x0034BC94 File Offset: 0x00349E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RolePropInfo);
		}

		// Token: 0x06016A8F RID: 92815 RVA: 0x0034BCA4 File Offset: 0x00349EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RolePropInfo other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.baseProp_.Equals(other.baseProp_) && this.addProp_.Equals(other.addProp_) && object.Equals(this.PhantomProp, other.PhantomProp) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016A90 RID: 92816 RVA: 0x0034BD1C File Offset: 0x00349F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			num ^= this.baseProp_.GetHashCode();
			num ^= this.addProp_.GetHashCode();
			if (this.phantomProp_ != null)
			{
				num ^= this.PhantomProp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016A91 RID: 92817 RVA: 0x0034BD8D File Offset: 0x00349F8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016A92 RID: 92818 RVA: 0x0034BD9A File Offset: 0x00349F9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016A93 RID: 92819 RVA: 0x0034BDA4 File Offset: 0x00349FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			this.baseProp_.WriteTo(ref output, RolePropInfo._repeated_baseProp_codec);
			this.addProp_.WriteTo(ref output, RolePropInfo._repeated_addProp_codec);
			if (this.phantomProp_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.PhantomProp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016A94 RID: 92820 RVA: 0x0034BE20 File Offset: 0x0034A020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			num += this.baseProp_.CalculateSize(RolePropInfo._repeated_baseProp_codec);
			num += this.addProp_.CalculateSize(RolePropInfo._repeated_addProp_codec);
			if (this.phantomProp_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomProp);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016A95 RID: 92821 RVA: 0x0034BE9C File Offset: 0x0034A09C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RolePropInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this.baseProp_.Add(other.baseProp_);
			this.addProp_.Add(other.addProp_);
			if (other.phantomProp_ != null)
			{
				if (this.phantomProp_ == null)
				{
					this.PhantomProp = new RolePhantomPropInfo();
				}
				this.PhantomProp.MergeFrom(other.PhantomProp);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016A96 RID: 92822 RVA: 0x0034BF26 File Offset: 0x0034A126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016A97 RID: 92823 RVA: 0x0034BF30 File Offset: 0x0034A130
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
					if (num == 8U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
					if (num == 18U)
					{
						this.baseProp_.AddEntriesFrom(ref input, RolePropInfo._repeated_baseProp_codec);
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						this.addProp_.AddEntriesFrom(ref input, RolePropInfo._repeated_addProp_codec);
						continue;
					}
					if (num == 34U)
					{
						if (this.phantomProp_ == null)
						{
							this.PhantomProp = new RolePhantomPropInfo();
						}
						input.ReadMessage(this.PhantomProp);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040087DD RID: 34781
		private static readonly MessageParser<RolePropInfo> _parser = new MessageParser<RolePropInfo>(() => new RolePropInfo());

		// Token: 0x040087DE RID: 34782
		private UnknownFieldSet _unknownFields;

		// Token: 0x040087DF RID: 34783
		public const int RoleIdFieldNumber = 1;

		// Token: 0x040087E0 RID: 34784
		private int roleId_;

		// Token: 0x040087E1 RID: 34785
		public const int BasePropFieldNumber = 2;

		// Token: 0x040087E2 RID: 34786
		private static readonly FieldCodec<ArrayIntInt> _repeated_baseProp_codec = FieldCodec.ForMessage<ArrayIntInt>(18U, ArrayIntInt.Parser);

		// Token: 0x040087E3 RID: 34787
		private readonly RepeatedField<ArrayIntInt> baseProp_ = new RepeatedField<ArrayIntInt>();

		// Token: 0x040087E4 RID: 34788
		public const int AddPropFieldNumber = 3;

		// Token: 0x040087E5 RID: 34789
		private static readonly FieldCodec<ArrayIntInt> _repeated_addProp_codec = FieldCodec.ForMessage<ArrayIntInt>(26U, ArrayIntInt.Parser);

		// Token: 0x040087E6 RID: 34790
		private readonly RepeatedField<ArrayIntInt> addProp_ = new RepeatedField<ArrayIntInt>();

		// Token: 0x040087E7 RID: 34791
		public const int PhantomPropFieldNumber = 4;

		// Token: 0x040087E8 RID: 34792
		private RolePhantomPropInfo phantomProp_;
	}
}
