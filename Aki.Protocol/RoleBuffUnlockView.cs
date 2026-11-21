using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200104B RID: 4171
	public sealed class RoleBuffUnlockView : IMessage<RoleBuffUnlockView>, IMessage, IEquatable<RoleBuffUnlockView>, IDeepCloneable<RoleBuffUnlockView>, IBufferMessage
	{
		// Token: 0x06016513 RID: 91411 RVA: 0x0033EE33 File Offset: 0x0033D033
		[NullableContext(1)]
		public static RoleBuffUnlockView Create()
		{
			return new RoleBuffUnlockView();
		}

		// Token: 0x17004AB0 RID: 19120
		// (get) Token: 0x06016514 RID: 91412 RVA: 0x0033EE3A File Offset: 0x0033D03A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004AB1 RID: 19121
		// (get) Token: 0x06016515 RID: 91413 RVA: 0x0033EE3D File Offset: 0x0033D03D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleBuffUnlockView.Descriptor;
			}
		}

		// Token: 0x06016516 RID: 91414 RVA: 0x0033EE44 File Offset: 0x0033D044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleBuffUnlockView()
		{
		}

		// Token: 0x06016517 RID: 91415 RVA: 0x0033EE58 File Offset: 0x0033D058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleBuffUnlockView(RoleBuffUnlockView other) : this()
		{
			this.rogueResRole_ = ((other.rogueResRole_ != null) ? other.rogueResRole_.Clone() : null);
			this.buffs_ = other.buffs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016518 RID: 91416 RVA: 0x0033EEA9 File Offset: 0x0033D0A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleBuffUnlockView Clone()
		{
			return new RoleBuffUnlockView(this);
		}

		// Token: 0x17004AB2 RID: 19122
		// (get) Token: 0x06016519 RID: 91417 RVA: 0x0033EEB1 File Offset: 0x0033D0B1
		// (set) Token: 0x0601651A RID: 91418 RVA: 0x0033EEB9 File Offset: 0x0033D0B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResRole RogueResRole
		{
			get
			{
				return this.rogueResRole_;
			}
			set
			{
				this.rogueResRole_ = value;
			}
		}

		// Token: 0x17004AB3 RID: 19123
		// (get) Token: 0x0601651B RID: 91419 RVA: 0x0033EEC2 File Offset: 0x0033D0C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Buffs
		{
			get
			{
				return this.buffs_;
			}
		}

		// Token: 0x0601651C RID: 91420 RVA: 0x0033EECA File Offset: 0x0033D0CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleBuffUnlockView);
		}

		// Token: 0x0601651D RID: 91421 RVA: 0x0033EED8 File Offset: 0x0033D0D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleBuffUnlockView other)
		{
			return other != null && (other == this || (object.Equals(this.RogueResRole, other.RogueResRole) && this.buffs_.Equals(other.buffs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601651E RID: 91422 RVA: 0x0033EF2C File Offset: 0x0033D12C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueResRole_ != null)
			{
				num ^= this.RogueResRole.GetHashCode();
			}
			num ^= this.buffs_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601651F RID: 91423 RVA: 0x0033EF76 File Offset: 0x0033D176
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016520 RID: 91424 RVA: 0x0033EF83 File Offset: 0x0033D183
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016521 RID: 91425 RVA: 0x0033EF8C File Offset: 0x0033D18C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueResRole_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.RogueResRole);
			}
			this.buffs_.WriteTo(ref output, RoleBuffUnlockView._repeated_buffs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016522 RID: 91426 RVA: 0x0033EFDC File Offset: 0x0033D1DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueResRole_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueResRole);
			}
			num += this.buffs_.CalculateSize(RoleBuffUnlockView._repeated_buffs_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016523 RID: 91427 RVA: 0x0033F030 File Offset: 0x0033D230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleBuffUnlockView other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueResRole_ != null)
			{
				if (this.rogueResRole_ == null)
				{
					this.RogueResRole = new RogueResRole();
				}
				this.RogueResRole.MergeFrom(other.RogueResRole);
			}
			this.buffs_.Add(other.buffs_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016524 RID: 91428 RVA: 0x0033F095 File Offset: 0x0033D295
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016525 RID: 91429 RVA: 0x0033F0A0 File Offset: 0x0033D2A0
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
				if (num != 10U)
				{
					if (num != 16U && num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.buffs_.AddEntriesFrom(ref input, RoleBuffUnlockView._repeated_buffs_codec);
					}
				}
				else
				{
					if (this.rogueResRole_ == null)
					{
						this.RogueResRole = new RogueResRole();
					}
					input.ReadMessage(this.RogueResRole);
				}
			}
		}

		// Token: 0x040085FB RID: 34299
		private UnknownFieldSet _unknownFields;

		// Token: 0x040085FC RID: 34300
		public const int RogueResRoleFieldNumber = 1;

		// Token: 0x040085FD RID: 34301
		private RogueResRole rogueResRole_;

		// Token: 0x040085FE RID: 34302
		public const int BuffsFieldNumber = 2;

		// Token: 0x040085FF RID: 34303
		private static readonly FieldCodec<int> _repeated_buffs_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04008600 RID: 34304
		private readonly RepeatedField<int> buffs_ = new RepeatedField<int>();
	}
}
