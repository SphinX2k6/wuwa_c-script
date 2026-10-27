using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200002B RID: 43
	[NetMessage(EMessageId.AbyssLittleRoleLevelUpRequest)]
	public sealed class AbyssLittleRoleLevelUpRequest : IMessage<AbyssLittleRoleLevelUpRequest>, IMessage, IEquatable<AbyssLittleRoleLevelUpRequest>, IDeepCloneable<AbyssLittleRoleLevelUpRequest>, IBufferMessage
	{
		// Token: 0x060011EF RID: 4591 RVA: 0x00031B31 File Offset: 0x0002FD31
		[NullableContext(1)]
		public static AbyssLittleRoleLevelUpRequest Create()
		{
			return new AbyssLittleRoleLevelUpRequest();
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060011F0 RID: 4592 RVA: 0x00031B38 File Offset: 0x0002FD38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060011F1 RID: 4593 RVA: 0x00031B3B File Offset: 0x0002FD3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssLittleRoleLevelUpRequest.Descriptor;
			}
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x00031B42 File Offset: 0x0002FD42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssLittleRoleLevelUpRequest()
		{
		}

		// Token: 0x060011F3 RID: 4595 RVA: 0x00031B4A File Offset: 0x0002FD4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssLittleRoleLevelUpRequest(AbyssLittleRoleLevelUpRequest other) : this()
		{
			this.id_ = other.id_;
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x00031B7B File Offset: 0x0002FD7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssLittleRoleLevelUpRequest Clone()
		{
			return new AbyssLittleRoleLevelUpRequest(this);
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060011F5 RID: 4597 RVA: 0x00031B83 File Offset: 0x0002FD83
		// (set) Token: 0x060011F6 RID: 4598 RVA: 0x00031B8B File Offset: 0x0002FD8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060011F7 RID: 4599 RVA: 0x00031B94 File Offset: 0x0002FD94
		// (set) Token: 0x060011F8 RID: 4600 RVA: 0x00031B9C File Offset: 0x0002FD9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x060011F9 RID: 4601 RVA: 0x00031BA5 File Offset: 0x0002FDA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssLittleRoleLevelUpRequest);
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x00031BB3 File Offset: 0x0002FDB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssLittleRoleLevelUpRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x00031BF4 File Offset: 0x0002FDF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x00031C4C File Offset: 0x0002FE4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x00031C59 File Offset: 0x0002FE59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060011FE RID: 4606 RVA: 0x00031C64 File Offset: 0x0002FE64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Level);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x00031CC0 File Offset: 0x0002FEC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x00031D18 File Offset: 0x0002FF18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssLittleRoleLevelUpRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x00031D68 File Offset: 0x0002FF68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x00031D74 File Offset: 0x0002FF74
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
				if (num != 48U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadInt32();
					}
				}
				else
				{
					this.Level = input.ReadInt32();
				}
			}
		}

		// Token: 0x04001FA7 RID: 8103
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FA8 RID: 8104
		public const int IdFieldNumber = 12;

		// Token: 0x04001FA9 RID: 8105
		private int id_;

		// Token: 0x04001FAA RID: 8106
		public const int LevelFieldNumber = 6;

		// Token: 0x04001FAB RID: 8107
		private int level_;
	}
}
