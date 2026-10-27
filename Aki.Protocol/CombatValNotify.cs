using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002AF RID: 687
	[NetMessage(EMessageId.CombatValNotify)]
	public sealed class CombatValNotify : IMessage<CombatValNotify>, IMessage, IEquatable<CombatValNotify>, IDeepCloneable<CombatValNotify>, IBufferMessage
	{
		// Token: 0x06004723 RID: 18211 RVA: 0x000AEC57 File Offset: 0x000ACE57
		[NullableContext(1)]
		public static CombatValNotify Create()
		{
			return new CombatValNotify();
		}

		// Token: 0x17000C5D RID: 3165
		// (get) Token: 0x06004724 RID: 18212 RVA: 0x000AEC5E File Offset: 0x000ACE5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C5E RID: 3166
		// (get) Token: 0x06004725 RID: 18213 RVA: 0x000AEC61 File Offset: 0x000ACE61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombatValNotify.Descriptor;
			}
		}

		// Token: 0x06004726 RID: 18214 RVA: 0x000AEC68 File Offset: 0x000ACE68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatValNotify()
		{
		}

		// Token: 0x06004727 RID: 18215 RVA: 0x000AEC70 File Offset: 0x000ACE70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatValNotify(CombatValNotify other) : this()
		{
			this.type_ = other.type_;
			this.value_ = other.value_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004728 RID: 18216 RVA: 0x000AECA1 File Offset: 0x000ACEA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatValNotify Clone()
		{
			return new CombatValNotify(this);
		}

		// Token: 0x17000C5F RID: 3167
		// (get) Token: 0x06004729 RID: 18217 RVA: 0x000AECA9 File Offset: 0x000ACEA9
		// (set) Token: 0x0600472A RID: 18218 RVA: 0x000AECB1 File Offset: 0x000ACEB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatValType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17000C60 RID: 3168
		// (get) Token: 0x0600472B RID: 18219 RVA: 0x000AECBA File Offset: 0x000ACEBA
		// (set) Token: 0x0600472C RID: 18220 RVA: 0x000AECC2 File Offset: 0x000ACEC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Value
		{
			get
			{
				return this.value_;
			}
			set
			{
				this.value_ = value;
			}
		}

		// Token: 0x0600472D RID: 18221 RVA: 0x000AECCB File Offset: 0x000ACECB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombatValNotify);
		}

		// Token: 0x0600472E RID: 18222 RVA: 0x000AECD9 File Offset: 0x000ACED9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombatValNotify other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.Value == other.Value && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600472F RID: 18223 RVA: 0x000AED18 File Offset: 0x000ACF18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != CombatValType.CvtNone)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.Value != 0)
			{
				num ^= this.Value.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004730 RID: 18224 RVA: 0x000AED76 File Offset: 0x000ACF76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004731 RID: 18225 RVA: 0x000AED83 File Offset: 0x000ACF83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004732 RID: 18226 RVA: 0x000AED8C File Offset: 0x000ACF8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != CombatValType.CvtNone)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.Type);
			}
			if (this.Value != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Value);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004733 RID: 18227 RVA: 0x000AEDE8 File Offset: 0x000ACFE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != CombatValType.CvtNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.Value != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Value);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004734 RID: 18228 RVA: 0x000AEE40 File Offset: 0x000AD040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CombatValNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != CombatValType.CvtNone)
			{
				this.Type = other.Type;
			}
			if (other.Value != 0)
			{
				this.Value = other.Value;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004735 RID: 18229 RVA: 0x000AEE90 File Offset: 0x000AD090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004736 RID: 18230 RVA: 0x000AEE9C File Offset: 0x000AD09C
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
				if (num != 96U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Value = input.ReadInt32();
					}
				}
				else
				{
					this.Type = (CombatValType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002F86 RID: 12166
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F87 RID: 12167
		public const int TypeFieldNumber = 12;

		// Token: 0x04002F88 RID: 12168
		private CombatValType type_;

		// Token: 0x04002F89 RID: 12169
		public const int ValueFieldNumber = 15;

		// Token: 0x04002F8A RID: 12170
		private int value_;
	}
}
