using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003BF RID: 959
	public sealed class DFsmBlackBoard : IMessage<DFsmBlackBoard>, IMessage, IEquatable<DFsmBlackBoard>, IDeepCloneable<DFsmBlackBoard>, IBufferMessage
	{
		// Token: 0x06005E2B RID: 24107 RVA: 0x000E4BCC File Offset: 0x000E2DCC
		[NullableContext(1)]
		public static DFsmBlackBoard Create()
		{
			return new DFsmBlackBoard();
		}

		// Token: 0x17001181 RID: 4481
		// (get) Token: 0x06005E2C RID: 24108 RVA: 0x000E4BD3 File Offset: 0x000E2DD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DFsmBlackBoard> Parser
		{
			get
			{
				return DFsmBlackBoard._parser;
			}
		}

		// Token: 0x17001182 RID: 4482
		// (get) Token: 0x06005E2D RID: 24109 RVA: 0x000E4BDA File Offset: 0x000E2DDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001183 RID: 4483
		// (get) Token: 0x06005E2E RID: 24110 RVA: 0x000E4BDD File Offset: 0x000E2DDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DFsmBlackBoard.Descriptor;
			}
		}

		// Token: 0x06005E2F RID: 24111 RVA: 0x000E4BE4 File Offset: 0x000E2DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DFsmBlackBoard()
		{
		}

		// Token: 0x06005E30 RID: 24112 RVA: 0x000E4BEC File Offset: 0x000E2DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DFsmBlackBoard(DFsmBlackBoard other) : this()
		{
			this.key_ = other.key_;
			this.value_ = other.value_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005E31 RID: 24113 RVA: 0x000E4C1D File Offset: 0x000E2E1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DFsmBlackBoard Clone()
		{
			return new DFsmBlackBoard(this);
		}

		// Token: 0x17001184 RID: 4484
		// (get) Token: 0x06005E32 RID: 24114 RVA: 0x000E4C25 File Offset: 0x000E2E25
		// (set) Token: 0x06005E33 RID: 24115 RVA: 0x000E4C2D File Offset: 0x000E2E2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Key
		{
			get
			{
				return this.key_;
			}
			set
			{
				this.key_ = value;
			}
		}

		// Token: 0x17001185 RID: 4485
		// (get) Token: 0x06005E34 RID: 24116 RVA: 0x000E4C36 File Offset: 0x000E2E36
		// (set) Token: 0x06005E35 RID: 24117 RVA: 0x000E4C3E File Offset: 0x000E2E3E
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

		// Token: 0x06005E36 RID: 24118 RVA: 0x000E4C47 File Offset: 0x000E2E47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DFsmBlackBoard);
		}

		// Token: 0x06005E37 RID: 24119 RVA: 0x000E4C55 File Offset: 0x000E2E55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DFsmBlackBoard other)
		{
			return other != null && (other == this || (this.Key == other.Key && this.Value == other.Value && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005E38 RID: 24120 RVA: 0x000E4C94 File Offset: 0x000E2E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Key != 0)
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

		// Token: 0x06005E39 RID: 24121 RVA: 0x000E4CEC File Offset: 0x000E2EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005E3A RID: 24122 RVA: 0x000E4CF9 File Offset: 0x000E2EF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005E3B RID: 24123 RVA: 0x000E4D04 File Offset: 0x000E2F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Key != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Key);
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

		// Token: 0x06005E3C RID: 24124 RVA: 0x000E4D5C File Offset: 0x000E2F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Key != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Key);
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

		// Token: 0x06005E3D RID: 24125 RVA: 0x000E4DB4 File Offset: 0x000E2FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DFsmBlackBoard other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Key != 0)
			{
				this.Key = other.Key;
			}
			if (other.Value != 0)
			{
				this.Value = other.Value;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005E3E RID: 24126 RVA: 0x000E4E04 File Offset: 0x000E3004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005E3F RID: 24127 RVA: 0x000E4E10 File Offset: 0x000E3010
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
						this.Value = input.ReadInt32();
					}
				}
				else
				{
					this.Key = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003727 RID: 14119
		private static readonly MessageParser<DFsmBlackBoard> _parser = new MessageParser<DFsmBlackBoard>(() => new DFsmBlackBoard());

		// Token: 0x04003728 RID: 14120
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003729 RID: 14121
		public const int KeyFieldNumber = 1;

		// Token: 0x0400372A RID: 14122
		private int key_;

		// Token: 0x0400372B RID: 14123
		public const int ValueFieldNumber = 2;

		// Token: 0x0400372C RID: 14124
		private int value_;
	}
}
