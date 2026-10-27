using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001098 RID: 4248
	public sealed class RolePhantomPropInfo : IMessage<RolePhantomPropInfo>, IMessage, IEquatable<RolePhantomPropInfo>, IDeepCloneable<RolePhantomPropInfo>, IBufferMessage
	{
		// Token: 0x06016B0E RID: 92942 RVA: 0x0034C5C9 File Offset: 0x0034A7C9
		[NullableContext(1)]
		public static RolePhantomPropInfo Create()
		{
			return new RolePhantomPropInfo();
		}

		// Token: 0x17004C05 RID: 19461
		// (get) Token: 0x06016B0F RID: 92943 RVA: 0x0034C5D0 File Offset: 0x0034A7D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RolePhantomPropInfo> Parser
		{
			get
			{
				return RolePhantomPropInfo._parser;
			}
		}

		// Token: 0x17004C06 RID: 19462
		// (get) Token: 0x06016B10 RID: 92944 RVA: 0x0034C5D7 File Offset: 0x0034A7D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C07 RID: 19463
		// (get) Token: 0x06016B11 RID: 92945 RVA: 0x0034C5DA File Offset: 0x0034A7DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RolePhantomPropInfo.Descriptor;
			}
		}

		// Token: 0x06016B12 RID: 92946 RVA: 0x0034C5E1 File Offset: 0x0034A7E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePhantomPropInfo()
		{
		}

		// Token: 0x06016B13 RID: 92947 RVA: 0x0034C600 File Offset: 0x0034A800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePhantomPropInfo(RolePhantomPropInfo other) : this()
		{
			this.roleId_ = other.roleId_;
			this.baseProp_ = other.baseProp_.Clone();
			this.addProp_ = other.addProp_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016B14 RID: 92948 RVA: 0x0034C652 File Offset: 0x0034A852
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePhantomPropInfo Clone()
		{
			return new RolePhantomPropInfo(this);
		}

		// Token: 0x17004C08 RID: 19464
		// (get) Token: 0x06016B15 RID: 92949 RVA: 0x0034C65A File Offset: 0x0034A85A
		// (set) Token: 0x06016B16 RID: 92950 RVA: 0x0034C662 File Offset: 0x0034A862
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

		// Token: 0x17004C09 RID: 19465
		// (get) Token: 0x06016B17 RID: 92951 RVA: 0x0034C66B File Offset: 0x0034A86B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArrayIntInt> BaseProp
		{
			get
			{
				return this.baseProp_;
			}
		}

		// Token: 0x17004C0A RID: 19466
		// (get) Token: 0x06016B18 RID: 92952 RVA: 0x0034C673 File Offset: 0x0034A873
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArrayIntInt> AddProp
		{
			get
			{
				return this.addProp_;
			}
		}

		// Token: 0x06016B19 RID: 92953 RVA: 0x0034C67B File Offset: 0x0034A87B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RolePhantomPropInfo);
		}

		// Token: 0x06016B1A RID: 92954 RVA: 0x0034C68C File Offset: 0x0034A88C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RolePhantomPropInfo other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.baseProp_.Equals(other.baseProp_) && this.addProp_.Equals(other.addProp_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016B1B RID: 92955 RVA: 0x0034C6F0 File Offset: 0x0034A8F0
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

		// Token: 0x06016B1C RID: 92956 RVA: 0x0034C74B File Offset: 0x0034A94B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016B1D RID: 92957 RVA: 0x0034C758 File Offset: 0x0034A958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016B1E RID: 92958 RVA: 0x0034C764 File Offset: 0x0034A964
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

		// Token: 0x06016B1F RID: 92959 RVA: 0x0034C7C4 File Offset: 0x0034A9C4
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

		// Token: 0x06016B20 RID: 92960 RVA: 0x0034C828 File Offset: 0x0034AA28
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

		// Token: 0x06016B21 RID: 92961 RVA: 0x0034C886 File Offset: 0x0034AA86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016B22 RID: 92962 RVA: 0x0034C890 File Offset: 0x0034AA90
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

		// Token: 0x04008791 RID: 34705
		private static readonly MessageParser<RolePhantomPropInfo> _parser = new MessageParser<RolePhantomPropInfo>(() => new RolePhantomPropInfo());

		// Token: 0x04008792 RID: 34706
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008793 RID: 34707
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04008794 RID: 34708
		private int roleId_;

		// Token: 0x04008795 RID: 34709
		public const int BasePropFieldNumber = 2;

		// Token: 0x04008796 RID: 34710
		private static readonly FieldCodec<ArrayIntInt> _repeated_baseProp_codec = FieldCodec.ForMessage<ArrayIntInt>(18U, ArrayIntInt.Parser);

		// Token: 0x04008797 RID: 34711
		private readonly RepeatedField<ArrayIntInt> baseProp_ = new RepeatedField<ArrayIntInt>();

		// Token: 0x04008798 RID: 34712
		public const int AddPropFieldNumber = 3;

		// Token: 0x04008799 RID: 34713
		private static readonly FieldCodec<ArrayIntInt> _repeated_addProp_codec = FieldCodec.ForMessage<ArrayIntInt>(26U, ArrayIntInt.Parser);

		// Token: 0x0400879A RID: 34714
		private readonly RepeatedField<ArrayIntInt> addProp_ = new RepeatedField<ArrayIntInt>();
	}
}
