using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200109C RID: 4252
	public sealed class RolePropInfo : IMessage<RolePropInfo>, IMessage, IEquatable<RolePropInfo>, IDeepCloneable<RolePropInfo>, IBufferMessage
	{
		// Token: 0x06016B66 RID: 93030 RVA: 0x0034D292 File Offset: 0x0034B492
		[NullableContext(1)]
		public static RolePropInfo Create()
		{
			return new RolePropInfo();
		}

		// Token: 0x17004C1B RID: 19483
		// (get) Token: 0x06016B67 RID: 93031 RVA: 0x0034D299 File Offset: 0x0034B499
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RolePropInfo> Parser
		{
			get
			{
				return RolePropInfo._parser;
			}
		}

		// Token: 0x17004C1C RID: 19484
		// (get) Token: 0x06016B68 RID: 93032 RVA: 0x0034D2A0 File Offset: 0x0034B4A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C1D RID: 19485
		// (get) Token: 0x06016B69 RID: 93033 RVA: 0x0034D2A3 File Offset: 0x0034B4A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RolePropInfo.Descriptor;
			}
		}

		// Token: 0x06016B6A RID: 93034 RVA: 0x0034D2AA File Offset: 0x0034B4AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePropInfo()
		{
		}

		// Token: 0x06016B6B RID: 93035 RVA: 0x0034D2C8 File Offset: 0x0034B4C8
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

		// Token: 0x06016B6C RID: 93036 RVA: 0x0034D336 File Offset: 0x0034B536
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePropInfo Clone()
		{
			return new RolePropInfo(this);
		}

		// Token: 0x17004C1E RID: 19486
		// (get) Token: 0x06016B6D RID: 93037 RVA: 0x0034D33E File Offset: 0x0034B53E
		// (set) Token: 0x06016B6E RID: 93038 RVA: 0x0034D346 File Offset: 0x0034B546
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

		// Token: 0x17004C1F RID: 19487
		// (get) Token: 0x06016B6F RID: 93039 RVA: 0x0034D34F File Offset: 0x0034B54F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArrayIntInt> BaseProp
		{
			get
			{
				return this.baseProp_;
			}
		}

		// Token: 0x17004C20 RID: 19488
		// (get) Token: 0x06016B70 RID: 93040 RVA: 0x0034D357 File Offset: 0x0034B557
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArrayIntInt> AddProp
		{
			get
			{
				return this.addProp_;
			}
		}

		// Token: 0x17004C21 RID: 19489
		// (get) Token: 0x06016B71 RID: 93041 RVA: 0x0034D35F File Offset: 0x0034B55F
		// (set) Token: 0x06016B72 RID: 93042 RVA: 0x0034D367 File Offset: 0x0034B567
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

		// Token: 0x06016B73 RID: 93043 RVA: 0x0034D370 File Offset: 0x0034B570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RolePropInfo);
		}

		// Token: 0x06016B74 RID: 93044 RVA: 0x0034D380 File Offset: 0x0034B580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RolePropInfo other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.baseProp_.Equals(other.baseProp_) && this.addProp_.Equals(other.addProp_) && object.Equals(this.PhantomProp, other.PhantomProp) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016B75 RID: 93045 RVA: 0x0034D3F8 File Offset: 0x0034B5F8
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

		// Token: 0x06016B76 RID: 93046 RVA: 0x0034D469 File Offset: 0x0034B669
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016B77 RID: 93047 RVA: 0x0034D476 File Offset: 0x0034B676
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016B78 RID: 93048 RVA: 0x0034D480 File Offset: 0x0034B680
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

		// Token: 0x06016B79 RID: 93049 RVA: 0x0034D4FC File Offset: 0x0034B6FC
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

		// Token: 0x06016B7A RID: 93050 RVA: 0x0034D578 File Offset: 0x0034B778
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

		// Token: 0x06016B7B RID: 93051 RVA: 0x0034D602 File Offset: 0x0034B802
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016B7C RID: 93052 RVA: 0x0034D60C File Offset: 0x0034B80C
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

		// Token: 0x040087B3 RID: 34739
		private static readonly MessageParser<RolePropInfo> _parser = new MessageParser<RolePropInfo>(() => new RolePropInfo());

		// Token: 0x040087B4 RID: 34740
		private UnknownFieldSet _unknownFields;

		// Token: 0x040087B5 RID: 34741
		public const int RoleIdFieldNumber = 1;

		// Token: 0x040087B6 RID: 34742
		private int roleId_;

		// Token: 0x040087B7 RID: 34743
		public const int BasePropFieldNumber = 2;

		// Token: 0x040087B8 RID: 34744
		private static readonly FieldCodec<ArrayIntInt> _repeated_baseProp_codec = FieldCodec.ForMessage<ArrayIntInt>(18U, ArrayIntInt.Parser);

		// Token: 0x040087B9 RID: 34745
		private readonly RepeatedField<ArrayIntInt> baseProp_ = new RepeatedField<ArrayIntInt>();

		// Token: 0x040087BA RID: 34746
		public const int AddPropFieldNumber = 3;

		// Token: 0x040087BB RID: 34747
		private static readonly FieldCodec<ArrayIntInt> _repeated_addProp_codec = FieldCodec.ForMessage<ArrayIntInt>(26U, ArrayIntInt.Parser);

		// Token: 0x040087BC RID: 34748
		private readonly RepeatedField<ArrayIntInt> addProp_ = new RepeatedField<ArrayIntInt>();

		// Token: 0x040087BD RID: 34749
		public const int PhantomPropFieldNumber = 4;

		// Token: 0x040087BE RID: 34750
		private RolePhantomPropInfo phantomProp_;
	}
}
