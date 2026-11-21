using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BBE RID: 3006
	[NetMessage(EMessageId.PassiveSkillAddResponse)]
	public sealed class PassiveSkillAddResponse : IMessage<PassiveSkillAddResponse>, IMessage, IEquatable<PassiveSkillAddResponse>, IDeepCloneable<PassiveSkillAddResponse>, IBufferMessage
	{
		// Token: 0x060104E5 RID: 66789 RVA: 0x00261437 File Offset: 0x0025F637
		[NullableContext(1)]
		public static PassiveSkillAddResponse Create()
		{
			return new PassiveSkillAddResponse();
		}

		// Token: 0x17003576 RID: 13686
		// (get) Token: 0x060104E6 RID: 66790 RVA: 0x0026143E File Offset: 0x0025F63E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003577 RID: 13687
		// (get) Token: 0x060104E7 RID: 66791 RVA: 0x00261441 File Offset: 0x0025F641
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PassiveSkillAddResponse.Descriptor;
			}
		}

		// Token: 0x060104E8 RID: 66792 RVA: 0x00261448 File Offset: 0x0025F648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillAddResponse()
		{
		}

		// Token: 0x060104E9 RID: 66793 RVA: 0x00261450 File Offset: 0x0025F650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillAddResponse(PassiveSkillAddResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060104EA RID: 66794 RVA: 0x00261475 File Offset: 0x0025F675
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillAddResponse Clone()
		{
			return new PassiveSkillAddResponse(this);
		}

		// Token: 0x17003578 RID: 13688
		// (get) Token: 0x060104EB RID: 66795 RVA: 0x0026147D File Offset: 0x0025F67D
		// (set) Token: 0x060104EC RID: 66796 RVA: 0x00261485 File Offset: 0x0025F685
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x060104ED RID: 66797 RVA: 0x0026148E File Offset: 0x0025F68E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PassiveSkillAddResponse);
		}

		// Token: 0x060104EE RID: 66798 RVA: 0x0026149C File Offset: 0x0025F69C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PassiveSkillAddResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060104EF RID: 66799 RVA: 0x002614CC File Offset: 0x0025F6CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060104F0 RID: 66800 RVA: 0x00261511 File Offset: 0x0025F711
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060104F1 RID: 66801 RVA: 0x0026151E File Offset: 0x0025F71E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060104F2 RID: 66802 RVA: 0x00261527 File Offset: 0x0025F727
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060104F3 RID: 66803 RVA: 0x0026155C File Offset: 0x0025F75C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060104F4 RID: 66804 RVA: 0x0026159A File Offset: 0x0025F79A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PassiveSkillAddResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060104F5 RID: 66805 RVA: 0x002615CB File Offset: 0x0025F7CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060104F6 RID: 66806 RVA: 0x002615D4 File Offset: 0x0025F7D4
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040067FE RID: 26622
		private UnknownFieldSet _unknownFields;

		// Token: 0x040067FF RID: 26623
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04006800 RID: 26624
		private ErrorCode errorCode_;
	}
}
