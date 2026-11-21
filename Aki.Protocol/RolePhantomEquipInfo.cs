using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001087 RID: 4231
	public sealed class RolePhantomEquipInfo : IMessage<RolePhantomEquipInfo>, IMessage, IEquatable<RolePhantomEquipInfo>, IDeepCloneable<RolePhantomEquipInfo>, IBufferMessage
	{
		// Token: 0x06016A14 RID: 92692 RVA: 0x0034AC21 File Offset: 0x00348E21
		[NullableContext(1)]
		public static RolePhantomEquipInfo Create()
		{
			return new RolePhantomEquipInfo();
		}

		// Token: 0x17004BD6 RID: 19414
		// (get) Token: 0x06016A15 RID: 92693 RVA: 0x0034AC28 File Offset: 0x00348E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RolePhantomEquipInfo> Parser
		{
			get
			{
				return RolePhantomEquipInfo._parser;
			}
		}

		// Token: 0x17004BD7 RID: 19415
		// (get) Token: 0x06016A16 RID: 92694 RVA: 0x0034AC2F File Offset: 0x00348E2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004BD8 RID: 19416
		// (get) Token: 0x06016A17 RID: 92695 RVA: 0x0034AC32 File Offset: 0x00348E32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RolePhantomEquipInfo.Descriptor;
			}
		}

		// Token: 0x06016A18 RID: 92696 RVA: 0x0034AC39 File Offset: 0x00348E39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePhantomEquipInfo()
		{
		}

		// Token: 0x06016A19 RID: 92697 RVA: 0x0034AC4C File Offset: 0x00348E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePhantomEquipInfo(RolePhantomEquipInfo other) : this()
		{
			this.roleId_ = other.roleId_;
			this.phantomItemIncrId_ = other.phantomItemIncrId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016A1A RID: 92698 RVA: 0x0034AC82 File Offset: 0x00348E82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePhantomEquipInfo Clone()
		{
			return new RolePhantomEquipInfo(this);
		}

		// Token: 0x17004BD9 RID: 19417
		// (get) Token: 0x06016A1B RID: 92699 RVA: 0x0034AC8A File Offset: 0x00348E8A
		// (set) Token: 0x06016A1C RID: 92700 RVA: 0x0034AC92 File Offset: 0x00348E92
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

		// Token: 0x17004BDA RID: 19418
		// (get) Token: 0x06016A1D RID: 92701 RVA: 0x0034AC9B File Offset: 0x00348E9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PhantomItemIncrId
		{
			get
			{
				return this.phantomItemIncrId_;
			}
		}

		// Token: 0x06016A1E RID: 92702 RVA: 0x0034ACA3 File Offset: 0x00348EA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RolePhantomEquipInfo);
		}

		// Token: 0x06016A1F RID: 92703 RVA: 0x0034ACB4 File Offset: 0x00348EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RolePhantomEquipInfo other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.phantomItemIncrId_.Equals(other.phantomItemIncrId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016A20 RID: 92704 RVA: 0x0034AD04 File Offset: 0x00348F04
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

		// Token: 0x06016A21 RID: 92705 RVA: 0x0034AD51 File Offset: 0x00348F51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016A22 RID: 92706 RVA: 0x0034AD5E File Offset: 0x00348F5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016A23 RID: 92707 RVA: 0x0034AD68 File Offset: 0x00348F68
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

		// Token: 0x06016A24 RID: 92708 RVA: 0x0034ADB8 File Offset: 0x00348FB8
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

		// Token: 0x06016A25 RID: 92709 RVA: 0x0034AE0C File Offset: 0x0034900C
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

		// Token: 0x06016A26 RID: 92710 RVA: 0x0034AE59 File Offset: 0x00349059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016A27 RID: 92711 RVA: 0x0034AE64 File Offset: 0x00349064
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

		// Token: 0x040087B4 RID: 34740
		private static readonly MessageParser<RolePhantomEquipInfo> _parser = new MessageParser<RolePhantomEquipInfo>(() => new RolePhantomEquipInfo());

		// Token: 0x040087B5 RID: 34741
		private UnknownFieldSet _unknownFields;

		// Token: 0x040087B6 RID: 34742
		public const int RoleIdFieldNumber = 1;

		// Token: 0x040087B7 RID: 34743
		private int roleId_;

		// Token: 0x040087B8 RID: 34744
		public const int PhantomItemIncrIdFieldNumber = 2;

		// Token: 0x040087B9 RID: 34745
		private static readonly FieldCodec<int> _repeated_phantomItemIncrId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040087BA RID: 34746
		private readonly RepeatedField<int> phantomItemIncrId_ = new RepeatedField<int>();
	}
}
