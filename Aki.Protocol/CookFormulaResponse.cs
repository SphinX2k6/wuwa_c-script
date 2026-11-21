using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002FC RID: 764
	[NetMessage(EMessageId.CookFormulaResponse)]
	public sealed class CookFormulaResponse : IMessage<CookFormulaResponse>, IMessage, IEquatable<CookFormulaResponse>, IDeepCloneable<CookFormulaResponse>, IBufferMessage
	{
		// Token: 0x06004D8F RID: 19855 RVA: 0x000BCDE9 File Offset: 0x000BAFE9
		[NullableContext(1)]
		public static CookFormulaResponse Create()
		{
			return new CookFormulaResponse();
		}

		// Token: 0x17000DB5 RID: 3509
		// (get) Token: 0x06004D90 RID: 19856 RVA: 0x000BCDF0 File Offset: 0x000BAFF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000DB6 RID: 3510
		// (get) Token: 0x06004D91 RID: 19857 RVA: 0x000BCDF3 File Offset: 0x000BAFF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CookFormulaResponse.Descriptor;
			}
		}

		// Token: 0x06004D92 RID: 19858 RVA: 0x000BCDFA File Offset: 0x000BAFFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookFormulaResponse()
		{
		}

		// Token: 0x06004D93 RID: 19859 RVA: 0x000BCE02 File Offset: 0x000BB002
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookFormulaResponse(CookFormulaResponse other) : this()
		{
			this.code_ = other.code_;
			this.cookFormulaId_ = other.cookFormulaId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004D94 RID: 19860 RVA: 0x000BCE33 File Offset: 0x000BB033
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookFormulaResponse Clone()
		{
			return new CookFormulaResponse(this);
		}

		// Token: 0x17000DB7 RID: 3511
		// (get) Token: 0x06004D95 RID: 19861 RVA: 0x000BCE3B File Offset: 0x000BB03B
		// (set) Token: 0x06004D96 RID: 19862 RVA: 0x000BCE43 File Offset: 0x000BB043
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x17000DB8 RID: 3512
		// (get) Token: 0x06004D97 RID: 19863 RVA: 0x000BCE4C File Offset: 0x000BB04C
		// (set) Token: 0x06004D98 RID: 19864 RVA: 0x000BCE54 File Offset: 0x000BB054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CookFormulaId
		{
			get
			{
				return this.cookFormulaId_;
			}
			set
			{
				this.cookFormulaId_ = value;
			}
		}

		// Token: 0x06004D99 RID: 19865 RVA: 0x000BCE5D File Offset: 0x000BB05D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CookFormulaResponse);
		}

		// Token: 0x06004D9A RID: 19866 RVA: 0x000BCE6B File Offset: 0x000BB06B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CookFormulaResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.CookFormulaId == other.CookFormulaId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004D9B RID: 19867 RVA: 0x000BCEAC File Offset: 0x000BB0AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this.CookFormulaId != 0)
			{
				num ^= this.CookFormulaId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004D9C RID: 19868 RVA: 0x000BCF0A File Offset: 0x000BB10A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004D9D RID: 19869 RVA: 0x000BCF17 File Offset: 0x000BB117
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004D9E RID: 19870 RVA: 0x000BCF20 File Offset: 0x000BB120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Code);
			}
			if (this.CookFormulaId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.CookFormulaId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004D9F RID: 19871 RVA: 0x000BCF7C File Offset: 0x000BB17C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this.CookFormulaId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CookFormulaId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004DA0 RID: 19872 RVA: 0x000BCFD4 File Offset: 0x000BB1D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CookFormulaResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.CookFormulaId != 0)
			{
				this.CookFormulaId = other.CookFormulaId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004DA1 RID: 19873 RVA: 0x000BD024 File Offset: 0x000BB224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004DA2 RID: 19874 RVA: 0x000BD030 File Offset: 0x000BB230
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
				if (num != 32U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CookFormulaId = input.ReadInt32();
					}
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040031AB RID: 12715
		private UnknownFieldSet _unknownFields;

		// Token: 0x040031AC RID: 12716
		public const int CodeFieldNumber = 4;

		// Token: 0x040031AD RID: 12717
		private ErrorCode code_;

		// Token: 0x040031AE RID: 12718
		public const int CookFormulaIdFieldNumber = 10;

		// Token: 0x040031AF RID: 12719
		private int cookFormulaId_;
	}
}
