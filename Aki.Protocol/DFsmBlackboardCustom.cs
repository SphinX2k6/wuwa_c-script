using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003D7 RID: 983
	public sealed class DFsmBlackboardCustom : IMessage<DFsmBlackboardCustom>, IMessage, IEquatable<DFsmBlackboardCustom>, IDeepCloneable<DFsmBlackboardCustom>, IBufferMessage
	{
		// Token: 0x06005FD1 RID: 24529 RVA: 0x000E8003 File Offset: 0x000E6203
		[NullableContext(1)]
		public static DFsmBlackboardCustom Create()
		{
			return new DFsmBlackboardCustom();
		}

		// Token: 0x170011DB RID: 4571
		// (get) Token: 0x06005FD2 RID: 24530 RVA: 0x000E800A File Offset: 0x000E620A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DFsmBlackboardCustom> Parser
		{
			get
			{
				return DFsmBlackboardCustom._parser;
			}
		}

		// Token: 0x170011DC RID: 4572
		// (get) Token: 0x06005FD3 RID: 24531 RVA: 0x000E8011 File Offset: 0x000E6211
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011DD RID: 4573
		// (get) Token: 0x06005FD4 RID: 24532 RVA: 0x000E8014 File Offset: 0x000E6214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DFsmBlackboardCustom.Descriptor;
			}
		}

		// Token: 0x06005FD5 RID: 24533 RVA: 0x000E801B File Offset: 0x000E621B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DFsmBlackboardCustom()
		{
		}

		// Token: 0x06005FD6 RID: 24534 RVA: 0x000E802E File Offset: 0x000E622E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DFsmBlackboardCustom(DFsmBlackboardCustom other) : this()
		{
			this.key_ = other.key_;
			this.value_ = other.value_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005FD7 RID: 24535 RVA: 0x000E805F File Offset: 0x000E625F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DFsmBlackboardCustom Clone()
		{
			return new DFsmBlackboardCustom(this);
		}

		// Token: 0x170011DE RID: 4574
		// (get) Token: 0x06005FD8 RID: 24536 RVA: 0x000E8067 File Offset: 0x000E6267
		// (set) Token: 0x06005FD9 RID: 24537 RVA: 0x000E806F File Offset: 0x000E626F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Key
		{
			get
			{
				return this.key_;
			}
			set
			{
				this.key_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170011DF RID: 4575
		// (get) Token: 0x06005FDA RID: 24538 RVA: 0x000E8082 File Offset: 0x000E6282
		// (set) Token: 0x06005FDB RID: 24539 RVA: 0x000E808A File Offset: 0x000E628A
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

		// Token: 0x06005FDC RID: 24540 RVA: 0x000E8093 File Offset: 0x000E6293
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DFsmBlackboardCustom);
		}

		// Token: 0x06005FDD RID: 24541 RVA: 0x000E80A4 File Offset: 0x000E62A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DFsmBlackboardCustom other)
		{
			return other != null && (other == this || (!(this.Key != other.Key) && this.Value == other.Value && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005FDE RID: 24542 RVA: 0x000E80F4 File Offset: 0x000E62F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Key.Length != 0)
			{
				num ^= this.Key.GetHashCode();
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

		// Token: 0x06005FDF RID: 24543 RVA: 0x000E814E File Offset: 0x000E634E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005FE0 RID: 24544 RVA: 0x000E815B File Offset: 0x000E635B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005FE1 RID: 24545 RVA: 0x000E8164 File Offset: 0x000E6364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Key.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Key);
			}
			if (this.Value != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Value);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005FE2 RID: 24546 RVA: 0x000E81C4 File Offset: 0x000E63C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Key.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Key);
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

		// Token: 0x06005FE3 RID: 24547 RVA: 0x000E8220 File Offset: 0x000E6420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DFsmBlackboardCustom other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Key.Length != 0)
			{
				this.Key = other.Key;
			}
			if (other.Value != 0)
			{
				this.Value = other.Value;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005FE4 RID: 24548 RVA: 0x000E8275 File Offset: 0x000E6475
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005FE5 RID: 24549 RVA: 0x000E8280 File Offset: 0x000E6480
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
					if (num != 16U)
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
					this.Key = input.ReadString();
				}
			}
		}

		// Token: 0x04003740 RID: 14144
		private static readonly MessageParser<DFsmBlackboardCustom> _parser = new MessageParser<DFsmBlackboardCustom>(() => new DFsmBlackboardCustom());

		// Token: 0x04003741 RID: 14145
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003742 RID: 14146
		public const int KeyFieldNumber = 1;

		// Token: 0x04003743 RID: 14147
		private string key_ = "";

		// Token: 0x04003744 RID: 14148
		public const int ValueFieldNumber = 2;

		// Token: 0x04003745 RID: 14149
		private int value_;
	}
}
