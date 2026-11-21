using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200131C RID: 4892
	[NetMessage(EMessageId.Summon3Response)]
	public sealed class Summon3Response : IMessage<Summon3Response>, IMessage, IEquatable<Summon3Response>, IDeepCloneable<Summon3Response>, IBufferMessage
	{
		// Token: 0x0601A14E RID: 106830 RVA: 0x003CD227 File Offset: 0x003CB427
		[NullableContext(1)]
		public static Summon3Response Create()
		{
			return new Summon3Response();
		}

		// Token: 0x1700584E RID: 22606
		// (get) Token: 0x0601A14F RID: 106831 RVA: 0x003CD22E File Offset: 0x003CB42E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700584F RID: 22607
		// (get) Token: 0x0601A150 RID: 106832 RVA: 0x003CD231 File Offset: 0x003CB431
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Summon3Response.Descriptor;
			}
		}

		// Token: 0x0601A151 RID: 106833 RVA: 0x003CD238 File Offset: 0x003CB438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Summon3Response()
		{
		}

		// Token: 0x0601A152 RID: 106834 RVA: 0x003CD240 File Offset: 0x003CB440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Summon3Response(Summon3Response other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A153 RID: 106835 RVA: 0x003CD265 File Offset: 0x003CB465
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Summon3Response Clone()
		{
			return new Summon3Response(this);
		}

		// Token: 0x17005850 RID: 22608
		// (get) Token: 0x0601A154 RID: 106836 RVA: 0x003CD26D File Offset: 0x003CB46D
		// (set) Token: 0x0601A155 RID: 106837 RVA: 0x003CD275 File Offset: 0x003CB475
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

		// Token: 0x0601A156 RID: 106838 RVA: 0x003CD27E File Offset: 0x003CB47E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as Summon3Response);
		}

		// Token: 0x0601A157 RID: 106839 RVA: 0x003CD28C File Offset: 0x003CB48C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Summon3Response other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A158 RID: 106840 RVA: 0x003CD2BC File Offset: 0x003CB4BC
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

		// Token: 0x0601A159 RID: 106841 RVA: 0x003CD301 File Offset: 0x003CB501
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A15A RID: 106842 RVA: 0x003CD30E File Offset: 0x003CB50E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A15B RID: 106843 RVA: 0x003CD317 File Offset: 0x003CB517
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A15C RID: 106844 RVA: 0x003CD34C File Offset: 0x003CB54C
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

		// Token: 0x0601A15D RID: 106845 RVA: 0x003CD38A File Offset: 0x003CB58A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Summon3Response other)
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

		// Token: 0x0601A15E RID: 106846 RVA: 0x003CD3BB File Offset: 0x003CB5BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A15F RID: 106847 RVA: 0x003CD3C4 File Offset: 0x003CB5C4
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009982 RID: 39298
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009983 RID: 39299
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04009984 RID: 39300
		private ErrorCode errorCode_;
	}
}
