using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000252 RID: 594
	[NetMessage(EMessageId.ChangeMonsterRoleNotify)]
	public sealed class ChangeMonsterRoleNotify : IMessage<ChangeMonsterRoleNotify>, IMessage, IEquatable<ChangeMonsterRoleNotify>, IDeepCloneable<ChangeMonsterRoleNotify>, IBufferMessage
	{
		// Token: 0x06003F45 RID: 16197 RVA: 0x0009BBCC File Offset: 0x00099DCC
		[NullableContext(1)]
		public static ChangeMonsterRoleNotify Create()
		{
			return new ChangeMonsterRoleNotify();
		}

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x06003F46 RID: 16198 RVA: 0x0009BBD3 File Offset: 0x00099DD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x06003F47 RID: 16199 RVA: 0x0009BBD6 File Offset: 0x00099DD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeMonsterRoleNotify.Descriptor;
			}
		}

		// Token: 0x06003F48 RID: 16200 RVA: 0x0009BBDD File Offset: 0x00099DDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeMonsterRoleNotify()
		{
		}

		// Token: 0x06003F49 RID: 16201 RVA: 0x0009BBE5 File Offset: 0x00099DE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeMonsterRoleNotify(ChangeMonsterRoleNotify other) : this()
		{
			this.id_ = other.id_;
			this.playerId_ = other.playerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003F4A RID: 16202 RVA: 0x0009BC16 File Offset: 0x00099E16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeMonsterRoleNotify Clone()
		{
			return new ChangeMonsterRoleNotify(this);
		}

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x06003F4B RID: 16203 RVA: 0x0009BC1E File Offset: 0x00099E1E
		// (set) Token: 0x06003F4C RID: 16204 RVA: 0x0009BC26 File Offset: 0x00099E26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
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

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x06003F4D RID: 16205 RVA: 0x0009BC2F File Offset: 0x00099E2F
		// (set) Token: 0x06003F4E RID: 16206 RVA: 0x0009BC37 File Offset: 0x00099E37
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

		// Token: 0x06003F4F RID: 16207 RVA: 0x0009BC40 File Offset: 0x00099E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeMonsterRoleNotify);
		}

		// Token: 0x06003F50 RID: 16208 RVA: 0x0009BC4E File Offset: 0x00099E4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeMonsterRoleNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.PlayerId == other.PlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003F51 RID: 16209 RVA: 0x0009BC8C File Offset: 0x00099E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003F52 RID: 16210 RVA: 0x0009BCE4 File Offset: 0x00099EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003F53 RID: 16211 RVA: 0x0009BCF1 File Offset: 0x00099EF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003F54 RID: 16212 RVA: 0x0009BCFC File Offset: 0x00099EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.Id);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003F55 RID: 16213 RVA: 0x0009BD58 File Offset: 0x00099F58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003F56 RID: 16214 RVA: 0x0009BDB0 File Offset: 0x00099FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeMonsterRoleNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003F57 RID: 16215 RVA: 0x0009BE00 File Offset: 0x0009A000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003F58 RID: 16216 RVA: 0x0009BE0C File Offset: 0x0009A00C
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
				if (num != 16U)
				{
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PlayerId = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt64();
				}
			}
		}

		// Token: 0x04002D14 RID: 11540
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D15 RID: 11541
		public const int IdFieldNumber = 2;

		// Token: 0x04002D16 RID: 11542
		private long id_;

		// Token: 0x04002D17 RID: 11543
		public const int PlayerIdFieldNumber = 8;

		// Token: 0x04002D18 RID: 11544
		private int playerId_;
	}
}
