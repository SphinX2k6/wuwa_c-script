using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009B4 RID: 2484
	[NetMessage(EMessageId.MatchChangeRoleNotify)]
	public sealed class MatchChangeRoleNotify : IMessage<MatchChangeRoleNotify>, IMessage, IEquatable<MatchChangeRoleNotify>, IDeepCloneable<MatchChangeRoleNotify>, IBufferMessage
	{
		// Token: 0x0600D9FD RID: 55805 RVA: 0x0020022E File Offset: 0x001FE42E
		[NullableContext(1)]
		public static MatchChangeRoleNotify Create()
		{
			return new MatchChangeRoleNotify();
		}

		// Token: 0x17002C25 RID: 11301
		// (get) Token: 0x0600D9FE RID: 55806 RVA: 0x00200235 File Offset: 0x001FE435
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C26 RID: 11302
		// (get) Token: 0x0600D9FF RID: 55807 RVA: 0x00200238 File Offset: 0x001FE438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchChangeRoleNotify.Descriptor;
			}
		}

		// Token: 0x0600DA00 RID: 55808 RVA: 0x0020023F File Offset: 0x001FE43F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangeRoleNotify()
		{
		}

		// Token: 0x0600DA01 RID: 55809 RVA: 0x00200252 File Offset: 0x001FE452
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangeRoleNotify(MatchChangeRoleNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.roleInfo_ = other.roleInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DA02 RID: 55810 RVA: 0x00200288 File Offset: 0x001FE488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangeRoleNotify Clone()
		{
			return new MatchChangeRoleNotify(this);
		}

		// Token: 0x17002C27 RID: 11303
		// (get) Token: 0x0600DA03 RID: 55811 RVA: 0x00200290 File Offset: 0x001FE490
		// (set) Token: 0x0600DA04 RID: 55812 RVA: 0x00200298 File Offset: 0x001FE498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x17002C28 RID: 11304
		// (get) Token: 0x0600DA05 RID: 55813 RVA: 0x002002A1 File Offset: 0x001FE4A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MatchRoleInfo> RoleInfo
		{
			get
			{
				return this.roleInfo_;
			}
		}

		// Token: 0x0600DA06 RID: 55814 RVA: 0x002002A9 File Offset: 0x001FE4A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchChangeRoleNotify);
		}

		// Token: 0x0600DA07 RID: 55815 RVA: 0x002002B8 File Offset: 0x001FE4B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchChangeRoleNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.roleInfo_.Equals(other.roleInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DA08 RID: 55816 RVA: 0x00200308 File Offset: 0x001FE508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			num ^= this.roleInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DA09 RID: 55817 RVA: 0x00200355 File Offset: 0x001FE555
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DA0A RID: 55818 RVA: 0x00200362 File Offset: 0x001FE562
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DA0B RID: 55819 RVA: 0x0020036C File Offset: 0x001FE56C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.PlayerId);
			}
			this.roleInfo_.WriteTo(ref output, MatchChangeRoleNotify._repeated_roleInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DA0C RID: 55820 RVA: 0x002003BC File Offset: 0x001FE5BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			num += this.roleInfo_.CalculateSize(MatchChangeRoleNotify._repeated_roleInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DA0D RID: 55821 RVA: 0x00200410 File Offset: 0x001FE610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchChangeRoleNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this.roleInfo_.Add(other.roleInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DA0E RID: 55822 RVA: 0x0020045D File Offset: 0x001FE65D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DA0F RID: 55823 RVA: 0x00200468 File Offset: 0x001FE668
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
				if (num != 32U)
				{
					if (num != 42U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.roleInfo_.AddEntriesFrom(ref input, MatchChangeRoleNotify._repeated_roleInfo_codec);
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005A94 RID: 23188
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A95 RID: 23189
		public const int PlayerIdFieldNumber = 4;

		// Token: 0x04005A96 RID: 23190
		private int playerId_;

		// Token: 0x04005A97 RID: 23191
		public const int RoleInfoFieldNumber = 5;

		// Token: 0x04005A98 RID: 23192
		private static readonly FieldCodec<MatchRoleInfo> _repeated_roleInfo_codec = FieldCodec.ForMessage<MatchRoleInfo>(42U, MatchRoleInfo.Parser);

		// Token: 0x04005A99 RID: 23193
		private readonly RepeatedField<MatchRoleInfo> roleInfo_ = new RepeatedField<MatchRoleInfo>();
	}
}
