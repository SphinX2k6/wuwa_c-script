using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002F5 RID: 757
	[NetMessage(EMessageId.CookFormulaResponse)]
	public sealed class CookFormulaResponse : IMessage<CookFormulaResponse>, IMessage, IEquatable<CookFormulaResponse>, IDeepCloneable<CookFormulaResponse>, IBufferMessage
	{
		// Token: 0x06004CB6 RID: 19638 RVA: 0x000BA9FD File Offset: 0x000B8BFD
		[NullableContext(1)]
		public static CookFormulaResponse Create()
		{
			return new CookFormulaResponse();
		}

		// Token: 0x17000D88 RID: 3464
		// (get) Token: 0x06004CB7 RID: 19639 RVA: 0x000BAA04 File Offset: 0x000B8C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D89 RID: 3465
		// (get) Token: 0x06004CB8 RID: 19640 RVA: 0x000BAA07 File Offset: 0x000B8C07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CookFormulaResponse.Descriptor;
			}
		}

		// Token: 0x06004CB9 RID: 19641 RVA: 0x000BAA0E File Offset: 0x000B8C0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookFormulaResponse()
		{
		}

		// Token: 0x06004CBA RID: 19642 RVA: 0x000BAA16 File Offset: 0x000B8C16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookFormulaResponse(CookFormulaResponse other) : this()
		{
			this.code_ = other.code_;
			this.cookFormulaId_ = other.cookFormulaId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004CBB RID: 19643 RVA: 0x000BAA47 File Offset: 0x000B8C47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookFormulaResponse Clone()
		{
			return new CookFormulaResponse(this);
		}

		// Token: 0x17000D8A RID: 3466
		// (get) Token: 0x06004CBC RID: 19644 RVA: 0x000BAA4F File Offset: 0x000B8C4F
		// (set) Token: 0x06004CBD RID: 19645 RVA: 0x000BAA57 File Offset: 0x000B8C57
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

		// Token: 0x17000D8B RID: 3467
		// (get) Token: 0x06004CBE RID: 19646 RVA: 0x000BAA60 File Offset: 0x000B8C60
		// (set) Token: 0x06004CBF RID: 19647 RVA: 0x000BAA68 File Offset: 0x000B8C68
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

		// Token: 0x06004CC0 RID: 19648 RVA: 0x000BAA71 File Offset: 0x000B8C71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CookFormulaResponse);
		}

		// Token: 0x06004CC1 RID: 19649 RVA: 0x000BAA7F File Offset: 0x000B8C7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CookFormulaResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.CookFormulaId == other.CookFormulaId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004CC2 RID: 19650 RVA: 0x000BAAC0 File Offset: 0x000B8CC0
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

		// Token: 0x06004CC3 RID: 19651 RVA: 0x000BAB1E File Offset: 0x000B8D1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004CC4 RID: 19652 RVA: 0x000BAB2B File Offset: 0x000B8D2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004CC5 RID: 19653 RVA: 0x000BAB34 File Offset: 0x000B8D34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CookFormulaId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.CookFormulaId);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004CC6 RID: 19654 RVA: 0x000BAB90 File Offset: 0x000B8D90
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

		// Token: 0x06004CC7 RID: 19655 RVA: 0x000BABE8 File Offset: 0x000B8DE8
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

		// Token: 0x06004CC8 RID: 19656 RVA: 0x000BAC38 File Offset: 0x000B8E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004CC9 RID: 19657 RVA: 0x000BAC44 File Offset: 0x000B8E44
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
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Code = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.CookFormulaId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003114 RID: 12564
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003115 RID: 12565
		public const int CodeFieldNumber = 13;

		// Token: 0x04003116 RID: 12566
		private ErrorCode code_;

		// Token: 0x04003117 RID: 12567
		public const int CookFormulaIdFieldNumber = 11;

		// Token: 0x04003118 RID: 12568
		private int cookFormulaId_;
	}
}
