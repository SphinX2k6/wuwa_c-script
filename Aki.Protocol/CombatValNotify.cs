using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002B5 RID: 693
	[NetMessage(EMessageId.CombatValNotify)]
	public sealed class CombatValNotify : IMessage<CombatValNotify>, IMessage, IEquatable<CombatValNotify>, IDeepCloneable<CombatValNotify>, IBufferMessage
	{
		// Token: 0x060047EA RID: 18410 RVA: 0x000B0E5A File Offset: 0x000AF05A
		[NullableContext(1)]
		public static CombatValNotify Create()
		{
			return new CombatValNotify();
		}

		// Token: 0x17000C87 RID: 3207
		// (get) Token: 0x060047EB RID: 18411 RVA: 0x000B0E61 File Offset: 0x000AF061
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C88 RID: 3208
		// (get) Token: 0x060047EC RID: 18412 RVA: 0x000B0E64 File Offset: 0x000AF064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombatValNotify.Descriptor;
			}
		}

		// Token: 0x060047ED RID: 18413 RVA: 0x000B0E6B File Offset: 0x000AF06B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatValNotify()
		{
		}

		// Token: 0x060047EE RID: 18414 RVA: 0x000B0E73 File Offset: 0x000AF073
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatValNotify(CombatValNotify other) : this()
		{
			this.type_ = other.type_;
			this.value_ = other.value_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060047EF RID: 18415 RVA: 0x000B0EA4 File Offset: 0x000AF0A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatValNotify Clone()
		{
			return new CombatValNotify(this);
		}

		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x060047F0 RID: 18416 RVA: 0x000B0EAC File Offset: 0x000AF0AC
		// (set) Token: 0x060047F1 RID: 18417 RVA: 0x000B0EB4 File Offset: 0x000AF0B4
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

		// Token: 0x17000C8A RID: 3210
		// (get) Token: 0x060047F2 RID: 18418 RVA: 0x000B0EBD File Offset: 0x000AF0BD
		// (set) Token: 0x060047F3 RID: 18419 RVA: 0x000B0EC5 File Offset: 0x000AF0C5
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

		// Token: 0x060047F4 RID: 18420 RVA: 0x000B0ECE File Offset: 0x000AF0CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombatValNotify);
		}

		// Token: 0x060047F5 RID: 18421 RVA: 0x000B0EDC File Offset: 0x000AF0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombatValNotify other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.Value == other.Value && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060047F6 RID: 18422 RVA: 0x000B0F1C File Offset: 0x000AF11C
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

		// Token: 0x060047F7 RID: 18423 RVA: 0x000B0F7A File Offset: 0x000AF17A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060047F8 RID: 18424 RVA: 0x000B0F87 File Offset: 0x000AF187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060047F9 RID: 18425 RVA: 0x000B0F90 File Offset: 0x000AF190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Value != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Value);
			}
			if (this.Type != CombatValType.CvtNone)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060047FA RID: 18426 RVA: 0x000B0FEC File Offset: 0x000AF1EC
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

		// Token: 0x060047FB RID: 18427 RVA: 0x000B1044 File Offset: 0x000AF244
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

		// Token: 0x060047FC RID: 18428 RVA: 0x000B1094 File Offset: 0x000AF294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060047FD RID: 18429 RVA: 0x000B10A0 File Offset: 0x000AF2A0
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
				if (num != 24U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Type = (CombatValType)input.ReadEnum();
					}
				}
				else
				{
					this.Value = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003019 RID: 12313
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400301A RID: 12314
		public const int TypeFieldNumber = 7;

		// Token: 0x0400301B RID: 12315
		private CombatValType type_;

		// Token: 0x0400301C RID: 12316
		public const int ValueFieldNumber = 3;

		// Token: 0x0400301D RID: 12317
		private int value_;
	}
}
