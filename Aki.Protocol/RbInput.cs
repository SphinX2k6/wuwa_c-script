using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E8F RID: 3727
	public sealed class RbInput : IMessage<RbInput>, IMessage, IEquatable<RbInput>, IDeepCloneable<RbInput>, IBufferMessage
	{
		// Token: 0x06014042 RID: 81986 RVA: 0x002EA4E7 File Offset: 0x002E86E7
		[NullableContext(1)]
		public static RbInput Create()
		{
			return new RbInput();
		}

		// Token: 0x17004297 RID: 17047
		// (get) Token: 0x06014043 RID: 81987 RVA: 0x002EA4EE File Offset: 0x002E86EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RbInput> Parser
		{
			get
			{
				return RbInput._parser;
			}
		}

		// Token: 0x17004298 RID: 17048
		// (get) Token: 0x06014044 RID: 81988 RVA: 0x002EA4F5 File Offset: 0x002E86F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004299 RID: 17049
		// (get) Token: 0x06014045 RID: 81989 RVA: 0x002EA4F8 File Offset: 0x002E86F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RbInput.Descriptor;
			}
		}

		// Token: 0x06014046 RID: 81990 RVA: 0x002EA4FF File Offset: 0x002E86FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbInput()
		{
		}

		// Token: 0x06014047 RID: 81991 RVA: 0x002EA507 File Offset: 0x002E8707
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

		// Token: 0x06014048 RID: 81992 RVA: 0x002EA53A File Offset: 0x002E873A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbInput Clone()
		{
			return new RbInput(this);
		}

		// Token: 0x1700429A RID: 17050
		// (get) Token: 0x06014049 RID: 81993 RVA: 0x002EA542 File Offset: 0x002E8742
		// (set) Token: 0x0601404A RID: 81994 RVA: 0x002EA55A File Offset: 0x002E875A
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

		// Token: 0x1700429B RID: 17051
		// (get) Token: 0x0601404B RID: 81995 RVA: 0x002EA570 File Offset: 0x002E8770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbInput.InputOneofCase InputCase
		{
			get
			{
				return this.inputCase_;
			}
		}

		// Token: 0x0601404C RID: 81996 RVA: 0x002EA578 File Offset: 0x002E8778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearInput()
		{
			this.inputCase_ = RbInput.InputOneofCase.None;
			this.input_ = null;
		}

		// Token: 0x0601404D RID: 81997 RVA: 0x002EA588 File Offset: 0x002E8788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RbInput);
		}

		// Token: 0x0601404E RID: 81998 RVA: 0x002EA598 File Offset: 0x002E8798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RbInput other)
		{
			return other != null && (other == this || (object.Equals(this.Roll, other.Roll) && this.InputCase == other.InputCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601404F RID: 81999 RVA: 0x002EA5E8 File Offset: 0x002E87E8
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

		// Token: 0x06014050 RID: 82000 RVA: 0x002EA62E File Offset: 0x002E882E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014051 RID: 82001 RVA: 0x002EA63B File Offset: 0x002E883B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014052 RID: 82002 RVA: 0x002EA644 File Offset: 0x002E8844
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

		// Token: 0x06014053 RID: 82003 RVA: 0x002EA678 File Offset: 0x002E8878
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

		// Token: 0x06014054 RID: 82004 RVA: 0x002EA6B8 File Offset: 0x002E88B8
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

		// Token: 0x06014055 RID: 82005 RVA: 0x002EA70D File Offset: 0x002E890D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014056 RID: 82006 RVA: 0x002EA718 File Offset: 0x002E8918
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

		// Token: 0x04007A37 RID: 31287
		private static readonly MessageParser<RbInput> _parser = new MessageParser<RbInput>(() => new RbInput());

		// Token: 0x04007A38 RID: 31288
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A39 RID: 31289
		public const int RollFieldNumber = 1;

		// Token: 0x04007A3A RID: 31290
		private object input_;

		// Token: 0x04007A3B RID: 31291
		private RbInput.InputOneofCase inputCase_;

		// Token: 0x0200190A RID: 6410
		public enum InputOneofCase
		{
			// Token: 0x0400C942 RID: 51522
			None,
			// Token: 0x0400C943 RID: 51523
			Roll
		}
	}
}
