using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E7F RID: 3711
	public sealed class RbInput : IMessage<RbInput>, IMessage, IEquatable<RbInput>, IDeepCloneable<RbInput>, IBufferMessage
	{
		// Token: 0x06013F5D RID: 81757 RVA: 0x002E8E2B File Offset: 0x002E702B
		[NullableContext(1)]
		public static RbInput Create()
		{
			return new RbInput();
		}

		// Token: 0x1700426D RID: 17005
		// (get) Token: 0x06013F5E RID: 81758 RVA: 0x002E8E32 File Offset: 0x002E7032
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RbInput> Parser
		{
			get
			{
				return RbInput._parser;
			}
		}

		// Token: 0x1700426E RID: 17006
		// (get) Token: 0x06013F5F RID: 81759 RVA: 0x002E8E39 File Offset: 0x002E7039
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700426F RID: 17007
		// (get) Token: 0x06013F60 RID: 81760 RVA: 0x002E8E3C File Offset: 0x002E703C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RbInput.Descriptor;
			}
		}

		// Token: 0x06013F61 RID: 81761 RVA: 0x002E8E43 File Offset: 0x002E7043
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbInput()
		{
		}

		// Token: 0x06013F62 RID: 81762 RVA: 0x002E8E4B File Offset: 0x002E704B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbInput(RbInput other) : this()
		{
			if (other.InputCase == RbInput.InputOneofCase.Roll)
			{
				this.Roll = other.Roll.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013F63 RID: 81763 RVA: 0x002E8E7E File Offset: 0x002E707E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbInput Clone()
		{
			return new RbInput(this);
		}

		// Token: 0x17004270 RID: 17008
		// (get) Token: 0x06013F64 RID: 81764 RVA: 0x002E8E86 File Offset: 0x002E7086
		// (set) Token: 0x06013F65 RID: 81765 RVA: 0x002E8E9E File Offset: 0x002E709E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbRollInput Roll
		{
			get
			{
				if (this.inputCase_ != RbInput.InputOneofCase.Roll)
				{
					return null;
				}
				return (RbRollInput)this.input_;
			}
			set
			{
				this.input_ = value;
				this.inputCase_ = ((value == null) ? RbInput.InputOneofCase.None : RbInput.InputOneofCase.Roll);
			}
		}

		// Token: 0x17004271 RID: 17009
		// (get) Token: 0x06013F66 RID: 81766 RVA: 0x002E8EB4 File Offset: 0x002E70B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbInput.InputOneofCase InputCase
		{
			get
			{
				return this.inputCase_;
			}
		}

		// Token: 0x06013F67 RID: 81767 RVA: 0x002E8EBC File Offset: 0x002E70BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearInput()
		{
			this.inputCase_ = RbInput.InputOneofCase.None;
			this.input_ = null;
		}

		// Token: 0x06013F68 RID: 81768 RVA: 0x002E8ECC File Offset: 0x002E70CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RbInput);
		}

		// Token: 0x06013F69 RID: 81769 RVA: 0x002E8EDC File Offset: 0x002E70DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RbInput other)
		{
			return other != null && (other == this || (object.Equals(this.Roll, other.Roll) && this.InputCase == other.InputCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013F6A RID: 81770 RVA: 0x002E8F2C File Offset: 0x002E712C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.inputCase_ == RbInput.InputOneofCase.Roll)
			{
				num ^= this.Roll.GetHashCode();
			}
			num ^= (int)this.inputCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013F6B RID: 81771 RVA: 0x002E8F72 File Offset: 0x002E7172
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013F6C RID: 81772 RVA: 0x002E8F7F File Offset: 0x002E717F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013F6D RID: 81773 RVA: 0x002E8F88 File Offset: 0x002E7188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.inputCase_ == RbInput.InputOneofCase.Roll)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Roll);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013F6E RID: 81774 RVA: 0x002E8FBC File Offset: 0x002E71BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.inputCase_ == RbInput.InputOneofCase.Roll)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Roll);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013F6F RID: 81775 RVA: 0x002E8FFC File Offset: 0x002E71FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RbInput other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InputCase == RbInput.InputOneofCase.Roll)
			{
				if (this.Roll == null)
				{
					this.Roll = new RbRollInput();
				}
				this.Roll.MergeFrom(other.Roll);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013F70 RID: 81776 RVA: 0x002E9051 File Offset: 0x002E7251
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013F71 RID: 81777 RVA: 0x002E905C File Offset: 0x002E725C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					RbRollInput rbRollInput = new RbRollInput();
					if (this.inputCase_ == RbInput.InputOneofCase.Roll)
					{
						rbRollInput.MergeFrom(this.Roll);
					}
					input.ReadMessage(rbRollInput);
					this.Roll = rbRollInput;
				}
			}
		}

		// Token: 0x04007A61 RID: 31329
		private static readonly MessageParser<RbInput> _parser = new MessageParser<RbInput>(() => new RbInput());

		// Token: 0x04007A62 RID: 31330
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A63 RID: 31331
		public const int RollFieldNumber = 1;

		// Token: 0x04007A64 RID: 31332
		private object input_;

		// Token: 0x04007A65 RID: 31333
		private RbInput.InputOneofCase inputCase_;

		// Token: 0x02001982 RID: 6530
		public enum InputOneofCase
		{
			// Token: 0x0400CE6D RID: 52845
			None,
			// Token: 0x0400CE6E RID: 52846
			Roll
		}
	}
}
