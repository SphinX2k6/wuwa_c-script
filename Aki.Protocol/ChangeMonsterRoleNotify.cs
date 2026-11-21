using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000257 RID: 599
	[NetMessage(EMessageId.ChangeMonsterRoleNotify)]
	public sealed class ChangeMonsterRoleNotify : IMessage<ChangeMonsterRoleNotify>, IMessage, IEquatable<ChangeMonsterRoleNotify>, IDeepCloneable<ChangeMonsterRoleNotify>, IBufferMessage
	{
		// Token: 0x06003FEA RID: 16362 RVA: 0x0009D7F0 File Offset: 0x0009B9F0
		[NullableContext(1)]
		public static ChangeMonsterRoleNotify Create()
		{
			return new ChangeMonsterRoleNotify();
		}

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x06003FEB RID: 16363 RVA: 0x0009D7F7 File Offset: 0x0009B9F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x06003FEC RID: 16364 RVA: 0x0009D7FA File Offset: 0x0009B9FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeMonsterRoleNotify.Descriptor;
			}
		}

		// Token: 0x06003FED RID: 16365 RVA: 0x0009D801 File Offset: 0x0009BA01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeMonsterRoleNotify()
		{
		}

		// Token: 0x06003FEE RID: 16366 RVA: 0x0009D809 File Offset: 0x0009BA09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeMonsterRoleNotify(ChangeMonsterRoleNotify other) : this()
		{
			this.id_ = other.id_;
			this.playerId_ = other.playerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003FEF RID: 16367 RVA: 0x0009D83A File Offset: 0x0009BA3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeMonsterRoleNotify Clone()
		{
			return new ChangeMonsterRoleNotify(this);
		}

		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x06003FF0 RID: 16368 RVA: 0x0009D842 File Offset: 0x0009BA42
		// (set) Token: 0x06003FF1 RID: 16369 RVA: 0x0009D84A File Offset: 0x0009BA4A
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

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x06003FF2 RID: 16370 RVA: 0x0009D853 File Offset: 0x0009BA53
		// (set) Token: 0x06003FF3 RID: 16371 RVA: 0x0009D85B File Offset: 0x0009BA5B
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

		// Token: 0x06003FF4 RID: 16372 RVA: 0x0009D864 File Offset: 0x0009BA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeMonsterRoleNotify);
		}

		// Token: 0x06003FF5 RID: 16373 RVA: 0x0009D872 File Offset: 0x0009BA72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeMonsterRoleNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.PlayerId == other.PlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003FF6 RID: 16374 RVA: 0x0009D8B0 File Offset: 0x0009BAB0
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

		// Token: 0x06003FF7 RID: 16375 RVA: 0x0009D908 File Offset: 0x0009BB08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003FF8 RID: 16376 RVA: 0x0009D915 File Offset: 0x0009BB15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003FF9 RID: 16377 RVA: 0x0009D920 File Offset: 0x0009BB20
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
				output.WriteRawTag(32);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003FFA RID: 16378 RVA: 0x0009D97C File Offset: 0x0009BB7C
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

		// Token: 0x06003FFB RID: 16379 RVA: 0x0009D9D4 File Offset: 0x0009BBD4
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

		// Token: 0x06003FFC RID: 16380 RVA: 0x0009DA24 File Offset: 0x0009BC24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003FFD RID: 16381 RVA: 0x0009DA30 File Offset: 0x0009BC30
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
					if (num != 32U)
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

		// Token: 0x04002D96 RID: 11670
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D97 RID: 11671
		public const int IdFieldNumber = 2;

		// Token: 0x04002D98 RID: 11672
		private long id_;

		// Token: 0x04002D99 RID: 11673
		public const int PlayerIdFieldNumber = 4;

		// Token: 0x04002D9A RID: 11674
		private int playerId_;
	}
}
