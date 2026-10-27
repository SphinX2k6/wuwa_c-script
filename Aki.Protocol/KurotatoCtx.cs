using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200088D RID: 2189
	public sealed class KurotatoCtx : IMessage<KurotatoCtx>, IMessage, IEquatable<KurotatoCtx>, IDeepCloneable<KurotatoCtx>, IBufferMessage
	{
		// Token: 0x0600C2B9 RID: 49849 RVA: 0x001CE5A0 File Offset: 0x001CC7A0
		[NullableContext(1)]
		public static KurotatoCtx Create()
		{
			return new KurotatoCtx();
		}

		// Token: 0x1700275F RID: 10079
		// (get) Token: 0x0600C2BA RID: 49850 RVA: 0x001CE5A7 File Offset: 0x001CC7A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002760 RID: 10080
		// (get) Token: 0x0600C2BB RID: 49851 RVA: 0x001CE5AA File Offset: 0x001CC7AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoCtx.Descriptor;
			}
		}

		// Token: 0x0600C2BC RID: 49852 RVA: 0x001CE5B1 File Offset: 0x001CC7B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoCtx()
		{
		}

		// Token: 0x0600C2BD RID: 49853 RVA: 0x001CE5B9 File Offset: 0x001CC7B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoCtx(KurotatoCtx other) : this()
		{
			this.continue_ = other.continue_;
			this.levelId_ = other.levelId_;
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C2BE RID: 49854 RVA: 0x001CE5F6 File Offset: 0x001CC7F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoCtx Clone()
		{
			return new KurotatoCtx(this);
		}

		// Token: 0x17002761 RID: 10081
		// (get) Token: 0x0600C2BF RID: 49855 RVA: 0x001CE5FE File Offset: 0x001CC7FE
		// (set) Token: 0x0600C2C0 RID: 49856 RVA: 0x001CE606 File Offset: 0x001CC806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Continue
		{
			get
			{
				return this.continue_;
			}
			set
			{
				this.continue_ = value;
			}
		}

		// Token: 0x17002762 RID: 10082
		// (get) Token: 0x0600C2C1 RID: 49857 RVA: 0x001CE60F File Offset: 0x001CC80F
		// (set) Token: 0x0600C2C2 RID: 49858 RVA: 0x001CE617 File Offset: 0x001CC817
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x17002763 RID: 10083
		// (get) Token: 0x0600C2C3 RID: 49859 RVA: 0x001CE620 File Offset: 0x001CC820
		// (set) Token: 0x0600C2C4 RID: 49860 RVA: 0x001CE628 File Offset: 0x001CC828
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

		// Token: 0x0600C2C5 RID: 49861 RVA: 0x001CE631 File Offset: 0x001CC831
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoCtx);
		}

		// Token: 0x0600C2C6 RID: 49862 RVA: 0x001CE640 File Offset: 0x001CC840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoCtx other)
		{
			return other != null && (other == this || (this.Continue == other.Continue && this.LevelId == other.LevelId && this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C2C7 RID: 49863 RVA: 0x001CE69C File Offset: 0x001CC89C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Continue)
			{
				num ^= this.Continue.GetHashCode();
			}
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C2C8 RID: 49864 RVA: 0x001CE70D File Offset: 0x001CC90D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C2C9 RID: 49865 RVA: 0x001CE71A File Offset: 0x001CC91A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C2CA RID: 49866 RVA: 0x001CE724 File Offset: 0x001CC924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Continue)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Continue);
			}
			if (this.LevelId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.LevelId);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C2CB RID: 49867 RVA: 0x001CE798 File Offset: 0x001CC998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Continue)
			{
				num += 2;
			}
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C2CC RID: 49868 RVA: 0x001CE7FC File Offset: 0x001CC9FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Continue)
			{
				this.Continue = other.Continue;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C2CD RID: 49869 RVA: 0x001CE860 File Offset: 0x001CCA60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C2CE RID: 49870 RVA: 0x001CE86C File Offset: 0x001CCA6C
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
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.RoleId = input.ReadInt32();
						}
					}
					else
					{
						this.LevelId = input.ReadInt32();
					}
				}
				else
				{
					this.Continue = input.ReadBool();
				}
			}
		}

		// Token: 0x0400544A RID: 21578
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400544B RID: 21579
		public const int ContinueFieldNumber = 1;

		// Token: 0x0400544C RID: 21580
		private bool continue_;

		// Token: 0x0400544D RID: 21581
		public const int LevelIdFieldNumber = 2;

		// Token: 0x0400544E RID: 21582
		private int levelId_;

		// Token: 0x0400544F RID: 21583
		public const int RoleIdFieldNumber = 3;

		// Token: 0x04005450 RID: 21584
		private int roleId_;
	}
}
