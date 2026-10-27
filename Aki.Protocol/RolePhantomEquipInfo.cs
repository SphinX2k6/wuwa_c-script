using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001097 RID: 4247
	public sealed class RolePhantomEquipInfo : IMessage<RolePhantomEquipInfo>, IMessage, IEquatable<RolePhantomEquipInfo>, IDeepCloneable<RolePhantomEquipInfo>, IBufferMessage
	{
		// Token: 0x06016AF9 RID: 92921 RVA: 0x0034C2FD File Offset: 0x0034A4FD
		[NullableContext(1)]
		public static RolePhantomEquipInfo Create()
		{
			return new RolePhantomEquipInfo();
		}

		// Token: 0x17004C00 RID: 19456
		// (get) Token: 0x06016AFA RID: 92922 RVA: 0x0034C304 File Offset: 0x0034A504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RolePhantomEquipInfo> Parser
		{
			get
			{
				return RolePhantomEquipInfo._parser;
			}
		}

		// Token: 0x17004C01 RID: 19457
		// (get) Token: 0x06016AFB RID: 92923 RVA: 0x0034C30B File Offset: 0x0034A50B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C02 RID: 19458
		// (get) Token: 0x06016AFC RID: 92924 RVA: 0x0034C30E File Offset: 0x0034A50E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RolePhantomEquipInfo.Descriptor;
			}
		}

		// Token: 0x06016AFD RID: 92925 RVA: 0x0034C315 File Offset: 0x0034A515
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePhantomEquipInfo()
		{
		}

		// Token: 0x06016AFE RID: 92926 RVA: 0x0034C328 File Offset: 0x0034A528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePhantomEquipInfo(RolePhantomEquipInfo other) : this()
		{
			this.roleId_ = other.roleId_;
			this.phantomItemIncrId_ = other.phantomItemIncrId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016AFF RID: 92927 RVA: 0x0034C35E File Offset: 0x0034A55E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePhantomEquipInfo Clone()
		{
			return new RolePhantomEquipInfo(this);
		}

		// Token: 0x17004C03 RID: 19459
		// (get) Token: 0x06016B00 RID: 92928 RVA: 0x0034C366 File Offset: 0x0034A566
		// (set) Token: 0x06016B01 RID: 92929 RVA: 0x0034C36E File Offset: 0x0034A56E
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

		// Token: 0x17004C04 RID: 19460
		// (get) Token: 0x06016B02 RID: 92930 RVA: 0x0034C377 File Offset: 0x0034A577
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PhantomItemIncrId
		{
			get
			{
				return this.phantomItemIncrId_;
			}
		}

		// Token: 0x06016B03 RID: 92931 RVA: 0x0034C37F File Offset: 0x0034A57F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RolePhantomEquipInfo);
		}

		// Token: 0x06016B04 RID: 92932 RVA: 0x0034C390 File Offset: 0x0034A590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RolePhantomEquipInfo other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.phantomItemIncrId_.Equals(other.phantomItemIncrId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016B05 RID: 92933 RVA: 0x0034C3E0 File Offset: 0x0034A5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			num ^= this.phantomItemIncrId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016B06 RID: 92934 RVA: 0x0034C42D File Offset: 0x0034A62D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016B07 RID: 92935 RVA: 0x0034C43A File Offset: 0x0034A63A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016B08 RID: 92936 RVA: 0x0034C444 File Offset: 0x0034A644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			this.phantomItemIncrId_.WriteTo(ref output, RolePhantomEquipInfo._repeated_phantomItemIncrId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016B09 RID: 92937 RVA: 0x0034C494 File Offset: 0x0034A694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			num += this.phantomItemIncrId_.CalculateSize(RolePhantomEquipInfo._repeated_phantomItemIncrId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016B0A RID: 92938 RVA: 0x0034C4E8 File Offset: 0x0034A6E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RolePhantomEquipInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this.phantomItemIncrId_.Add(other.phantomItemIncrId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016B0B RID: 92939 RVA: 0x0034C535 File Offset: 0x0034A735
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016B0C RID: 92940 RVA: 0x0034C540 File Offset: 0x0034A740
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
					if (num != 16U && num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.phantomItemIncrId_.AddEntriesFrom(ref input, RolePhantomEquipInfo._repeated_phantomItemIncrId_codec);
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400878A RID: 34698
		private static readonly MessageParser<RolePhantomEquipInfo> _parser = new MessageParser<RolePhantomEquipInfo>(() => new RolePhantomEquipInfo());

		// Token: 0x0400878B RID: 34699
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400878C RID: 34700
		public const int RoleIdFieldNumber = 1;

		// Token: 0x0400878D RID: 34701
		private int roleId_;

		// Token: 0x0400878E RID: 34702
		public const int PhantomItemIncrIdFieldNumber = 2;

		// Token: 0x0400878F RID: 34703
		private static readonly FieldCodec<int> _repeated_phantomItemIncrId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04008790 RID: 34704
		private readonly RepeatedField<int> phantomItemIncrId_ = new RepeatedField<int>();
	}
}
