using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003D6 RID: 982
	public sealed class DFsmBlackBoard : IMessage<DFsmBlackBoard>, IMessage, IEquatable<DFsmBlackBoard>, IDeepCloneable<DFsmBlackBoard>, IBufferMessage
	{
		// Token: 0x06005FBB RID: 24507 RVA: 0x000E7D4C File Offset: 0x000E5F4C
		[NullableContext(1)]
		public static DFsmBlackBoard Create()
		{
			return new DFsmBlackBoard();
		}

		// Token: 0x170011D6 RID: 4566
		// (get) Token: 0x06005FBC RID: 24508 RVA: 0x000E7D53 File Offset: 0x000E5F53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DFsmBlackBoard> Parser
		{
			get
			{
				return DFsmBlackBoard._parser;
			}
		}

		// Token: 0x170011D7 RID: 4567
		// (get) Token: 0x06005FBD RID: 24509 RVA: 0x000E7D5A File Offset: 0x000E5F5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011D8 RID: 4568
		// (get) Token: 0x06005FBE RID: 24510 RVA: 0x000E7D5D File Offset: 0x000E5F5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DFsmBlackBoard.Descriptor;
			}
		}

		// Token: 0x06005FBF RID: 24511 RVA: 0x000E7D64 File Offset: 0x000E5F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DFsmBlackBoard()
		{
		}

		// Token: 0x06005FC0 RID: 24512 RVA: 0x000E7D6C File Offset: 0x000E5F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DFsmBlackBoard(DFsmBlackBoard other) : this()
		{
			this.key_ = other.key_;
			this.value_ = other.value_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005FC1 RID: 24513 RVA: 0x000E7D9D File Offset: 0x000E5F9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DFsmBlackBoard Clone()
		{
			return new DFsmBlackBoard(this);
		}

		// Token: 0x170011D9 RID: 4569
		// (get) Token: 0x06005FC2 RID: 24514 RVA: 0x000E7DA5 File Offset: 0x000E5FA5
		// (set) Token: 0x06005FC3 RID: 24515 RVA: 0x000E7DAD File Offset: 0x000E5FAD
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

		// Token: 0x170011DA RID: 4570
		// (get) Token: 0x06005FC4 RID: 24516 RVA: 0x000E7DB6 File Offset: 0x000E5FB6
		// (set) Token: 0x06005FC5 RID: 24517 RVA: 0x000E7DBE File Offset: 0x000E5FBE
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

		// Token: 0x06005FC6 RID: 24518 RVA: 0x000E7DC7 File Offset: 0x000E5FC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DFsmBlackBoard);
		}

		// Token: 0x06005FC7 RID: 24519 RVA: 0x000E7DD5 File Offset: 0x000E5FD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DFsmBlackBoard other)
		{
			return other != null && (other == this || (this.Key == other.Key && this.Value == other.Value && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005FC8 RID: 24520 RVA: 0x000E7E14 File Offset: 0x000E6014
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

		// Token: 0x06005FC9 RID: 24521 RVA: 0x000E7E6C File Offset: 0x000E606C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005FCA RID: 24522 RVA: 0x000E7E79 File Offset: 0x000E6079
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005FCB RID: 24523 RVA: 0x000E7E84 File Offset: 0x000E6084
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

		// Token: 0x06005FCC RID: 24524 RVA: 0x000E7EDC File Offset: 0x000E60DC
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

		// Token: 0x06005FCD RID: 24525 RVA: 0x000E7F34 File Offset: 0x000E6134
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

		// Token: 0x06005FCE RID: 24526 RVA: 0x000E7F84 File Offset: 0x000E6184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005FCF RID: 24527 RVA: 0x000E7F90 File Offset: 0x000E6190
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

		// Token: 0x0400373A RID: 14138
		private static readonly MessageParser<DFsmBlackBoard> _parser = new MessageParser<DFsmBlackBoard>(() => new DFsmBlackBoard());

		// Token: 0x0400373B RID: 14139
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400373C RID: 14140
		public const int KeyFieldNumber = 1;

		// Token: 0x0400373D RID: 14141
		private int key_;

		// Token: 0x0400373E RID: 14142
		public const int ValueFieldNumber = 2;

		// Token: 0x0400373F RID: 14143
		private int value_;
	}
}
