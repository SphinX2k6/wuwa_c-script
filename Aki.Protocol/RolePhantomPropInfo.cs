using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001088 RID: 4232
	public sealed class RolePhantomPropInfo : IMessage<RolePhantomPropInfo>, IMessage, IEquatable<RolePhantomPropInfo>, IDeepCloneable<RolePhantomPropInfo>, IBufferMessage
	{
		// Token: 0x06016A29 RID: 92713 RVA: 0x0034AEED File Offset: 0x003490ED
		[NullableContext(1)]
		public static RolePhantomPropInfo Create()
		{
			return new RolePhantomPropInfo();
		}

		// Token: 0x17004BDB RID: 19419
		// (get) Token: 0x06016A2A RID: 92714 RVA: 0x0034AEF4 File Offset: 0x003490F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RolePhantomPropInfo> Parser
		{
			get
			{
				return RolePhantomPropInfo._parser;
			}
		}

		// Token: 0x17004BDC RID: 19420
		// (get) Token: 0x06016A2B RID: 92715 RVA: 0x0034AEFB File Offset: 0x003490FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004BDD RID: 19421
		// (get) Token: 0x06016A2C RID: 92716 RVA: 0x0034AEFE File Offset: 0x003490FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RolePhantomPropInfo.Descriptor;
			}
		}

		// Token: 0x06016A2D RID: 92717 RVA: 0x0034AF05 File Offset: 0x00349105
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePhantomPropInfo()
		{
		}

		// Token: 0x06016A2E RID: 92718 RVA: 0x0034AF24 File Offset: 0x00349124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePhantomPropInfo(RolePhantomPropInfo other) : this()
		{
			this.roleId_ = other.roleId_;
			this.baseProp_ = other.baseProp_.Clone();
			this.addProp_ = other.addProp_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016A2F RID: 92719 RVA: 0x0034AF76 File Offset: 0x00349176
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePhantomPropInfo Clone()
		{
			return new RolePhantomPropInfo(this);
		}

		// Token: 0x17004BDE RID: 19422
		// (get) Token: 0x06016A30 RID: 92720 RVA: 0x0034AF7E File Offset: 0x0034917E
		// (set) Token: 0x06016A31 RID: 92721 RVA: 0x0034AF86 File Offset: 0x00349186
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

		// Token: 0x17004BDF RID: 19423
		// (get) Token: 0x06016A32 RID: 92722 RVA: 0x0034AF8F File Offset: 0x0034918F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArrayIntInt> BaseProp
		{
			get
			{
				return this.baseProp_;
			}
		}

		// Token: 0x17004BE0 RID: 19424
		// (get) Token: 0x06016A33 RID: 92723 RVA: 0x0034AF97 File Offset: 0x00349197
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArrayIntInt> AddProp
		{
			get
			{
				return this.addProp_;
			}
		}

		// Token: 0x06016A34 RID: 92724 RVA: 0x0034AF9F File Offset: 0x0034919F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RolePhantomPropInfo);
		}

		// Token: 0x06016A35 RID: 92725 RVA: 0x0034AFB0 File Offset: 0x003491B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RolePhantomPropInfo other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.baseProp_.Equals(other.baseProp_) && this.addProp_.Equals(other.addProp_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016A36 RID: 92726 RVA: 0x0034B014 File Offset: 0x00349214
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016A37 RID: 92727 RVA: 0x0034B06F File Offset: 0x0034926F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016A38 RID: 92728 RVA: 0x0034B07C File Offset: 0x0034927C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016A39 RID: 92729 RVA: 0x0034B088 File Offset: 0x00349288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			this.baseProp_.WriteTo(ref output, RolePhantomPropInfo._repeated_baseProp_codec);
			this.addProp_.WriteTo(ref output, RolePhantomPropInfo._repeated_addProp_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016A3A RID: 92730 RVA: 0x0034B0E8 File Offset: 0x003492E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			num += this.baseProp_.CalculateSize(RolePhantomPropInfo._repeated_baseProp_codec);
			num += this.addProp_.CalculateSize(RolePhantomPropInfo._repeated_addProp_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016A3B RID: 92731 RVA: 0x0034B14C File Offset: 0x0034934C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RolePhantomPropInfo other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016A3C RID: 92732 RVA: 0x0034B1AA File Offset: 0x003493AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016A3D RID: 92733 RVA: 0x0034B1B4 File Offset: 0x003493B4
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
				if (num != 8U)
				{
					if (num != 18U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.addProp_.AddEntriesFrom(ref input, RolePhantomPropInfo._repeated_addProp_codec);
						}
					}
					else
					{
						this.baseProp_.AddEntriesFrom(ref input, RolePhantomPropInfo._repeated_baseProp_codec);
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040087BB RID: 34747
		private static readonly MessageParser<RolePhantomPropInfo> _parser = new MessageParser<RolePhantomPropInfo>(() => new RolePhantomPropInfo());

		// Token: 0x040087BC RID: 34748
		private UnknownFieldSet _unknownFields;

		// Token: 0x040087BD RID: 34749
		public const int RoleIdFieldNumber = 1;

		// Token: 0x040087BE RID: 34750
		private int roleId_;

		// Token: 0x040087BF RID: 34751
		public const int BasePropFieldNumber = 2;

		// Token: 0x040087C0 RID: 34752
		private static readonly FieldCodec<ArrayIntInt> _repeated_baseProp_codec = FieldCodec.ForMessage<ArrayIntInt>(18U, ArrayIntInt.Parser);

		// Token: 0x040087C1 RID: 34753
		private readonly RepeatedField<ArrayIntInt> baseProp_ = new RepeatedField<ArrayIntInt>();

		// Token: 0x040087C2 RID: 34754
		public const int AddPropFieldNumber = 3;

		// Token: 0x040087C3 RID: 34755
		private static readonly FieldCodec<ArrayIntInt> _repeated_addProp_codec = FieldCodec.ForMessage<ArrayIntInt>(26U, ArrayIntInt.Parser);

		// Token: 0x040087C4 RID: 34756
		private readonly RepeatedField<ArrayIntInt> addProp_ = new RepeatedField<ArrayIntInt>();
	}
}
