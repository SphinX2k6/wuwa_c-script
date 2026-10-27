using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001003 RID: 4099
	public sealed class RogueResRoleBuff : IMessage<RogueResRoleBuff>, IMessage, IEquatable<RogueResRoleBuff>, IDeepCloneable<RogueResRoleBuff>, IBufferMessage
	{
		// Token: 0x06015EAB RID: 89771 RVA: 0x0032F8BD File Offset: 0x0032DABD
		[NullableContext(1)]
		public static RogueResRoleBuff Create()
		{
			return new RogueResRoleBuff();
		}

		// Token: 0x17004939 RID: 18745
		// (get) Token: 0x06015EAC RID: 89772 RVA: 0x0032F8C4 File Offset: 0x0032DAC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700493A RID: 18746
		// (get) Token: 0x06015EAD RID: 89773 RVA: 0x0032F8C7 File Offset: 0x0032DAC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResRoleBuff.Descriptor;
			}
		}

		// Token: 0x06015EAE RID: 89774 RVA: 0x0032F8CE File Offset: 0x0032DACE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResRoleBuff()
		{
		}

		// Token: 0x06015EAF RID: 89775 RVA: 0x0032F8D6 File Offset: 0x0032DAD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResRoleBuff(RogueResRoleBuff other) : this()
		{
			this.configId_ = other.configId_;
			this.isNew_ = other.isNew_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015EB0 RID: 89776 RVA: 0x0032F907 File Offset: 0x0032DB07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResRoleBuff Clone()
		{
			return new RogueResRoleBuff(this);
		}

		// Token: 0x1700493B RID: 18747
		// (get) Token: 0x06015EB1 RID: 89777 RVA: 0x0032F90F File Offset: 0x0032DB0F
		// (set) Token: 0x06015EB2 RID: 89778 RVA: 0x0032F917 File Offset: 0x0032DB17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x1700493C RID: 18748
		// (get) Token: 0x06015EB3 RID: 89779 RVA: 0x0032F920 File Offset: 0x0032DB20
		// (set) Token: 0x06015EB4 RID: 89780 RVA: 0x0032F928 File Offset: 0x0032DB28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsNew
		{
			get
			{
				return this.isNew_;
			}
			set
			{
				this.isNew_ = value;
			}
		}

		// Token: 0x06015EB5 RID: 89781 RVA: 0x0032F931 File Offset: 0x0032DB31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResRoleBuff);
		}

		// Token: 0x06015EB6 RID: 89782 RVA: 0x0032F93F File Offset: 0x0032DB3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResRoleBuff other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.IsNew == other.IsNew && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015EB7 RID: 89783 RVA: 0x0032F980 File Offset: 0x0032DB80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.IsNew)
			{
				num ^= this.IsNew.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015EB8 RID: 89784 RVA: 0x0032F9D8 File Offset: 0x0032DBD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015EB9 RID: 89785 RVA: 0x0032F9E5 File Offset: 0x0032DBE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015EBA RID: 89786 RVA: 0x0032F9F0 File Offset: 0x0032DBF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConfigId);
			}
			if (this.IsNew)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsNew);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015EBB RID: 89787 RVA: 0x0032FA48 File Offset: 0x0032DC48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.IsNew)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015EBC RID: 89788 RVA: 0x0032FA94 File Offset: 0x0032DC94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResRoleBuff other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.IsNew)
			{
				this.IsNew = other.IsNew;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015EBD RID: 89789 RVA: 0x0032FAE4 File Offset: 0x0032DCE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015EBE RID: 89790 RVA: 0x0032FAF0 File Offset: 0x0032DCF0
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsNew = input.ReadBool();
					}
				}
				else
				{
					this.ConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400837D RID: 33661
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400837E RID: 33662
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x0400837F RID: 33663
		private int configId_;

		// Token: 0x04008380 RID: 33664
		public const int IsNewFieldNumber = 2;

		// Token: 0x04008381 RID: 33665
		private bool isNew_;
	}
}
