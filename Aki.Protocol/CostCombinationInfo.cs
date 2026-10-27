using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200030A RID: 778
	public sealed class CostCombinationInfo : IMessage<CostCombinationInfo>, IMessage, IEquatable<CostCombinationInfo>, IDeepCloneable<CostCombinationInfo>, IBufferMessage
	{
		// Token: 0x06004E6B RID: 20075 RVA: 0x000BE5F2 File Offset: 0x000BC7F2
		[NullableContext(1)]
		public static CostCombinationInfo Create()
		{
			return new CostCombinationInfo();
		}

		// Token: 0x17000DE7 RID: 3559
		// (get) Token: 0x06004E6C RID: 20076 RVA: 0x000BE5F9 File Offset: 0x000BC7F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CostCombinationInfo> Parser
		{
			get
			{
				return CostCombinationInfo._parser;
			}
		}

		// Token: 0x17000DE8 RID: 3560
		// (get) Token: 0x06004E6D RID: 20077 RVA: 0x000BE600 File Offset: 0x000BC800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000DE9 RID: 3561
		// (get) Token: 0x06004E6E RID: 20078 RVA: 0x000BE603 File Offset: 0x000BC803
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CostCombinationInfo.Descriptor;
			}
		}

		// Token: 0x06004E6F RID: 20079 RVA: 0x000BE60A File Offset: 0x000BC80A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CostCombinationInfo()
		{
		}

		// Token: 0x06004E70 RID: 20080 RVA: 0x000BE612 File Offset: 0x000BC812
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CostCombinationInfo(CostCombinationInfo other) : this()
		{
			this.costId_ = other.costId_;
			this.usage_ = other.usage_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004E71 RID: 20081 RVA: 0x000BE643 File Offset: 0x000BC843
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CostCombinationInfo Clone()
		{
			return new CostCombinationInfo(this);
		}

		// Token: 0x17000DEA RID: 3562
		// (get) Token: 0x06004E72 RID: 20082 RVA: 0x000BE64B File Offset: 0x000BC84B
		// (set) Token: 0x06004E73 RID: 20083 RVA: 0x000BE653 File Offset: 0x000BC853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CostId
		{
			get
			{
				return this.costId_;
			}
			set
			{
				this.costId_ = value;
			}
		}

		// Token: 0x17000DEB RID: 3563
		// (get) Token: 0x06004E74 RID: 20084 RVA: 0x000BE65C File Offset: 0x000BC85C
		// (set) Token: 0x06004E75 RID: 20085 RVA: 0x000BE664 File Offset: 0x000BC864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Usage
		{
			get
			{
				return this.usage_;
			}
			set
			{
				this.usage_ = value;
			}
		}

		// Token: 0x06004E76 RID: 20086 RVA: 0x000BE66D File Offset: 0x000BC86D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CostCombinationInfo);
		}

		// Token: 0x06004E77 RID: 20087 RVA: 0x000BE67B File Offset: 0x000BC87B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CostCombinationInfo other)
		{
			return other != null && (other == this || (this.CostId == other.CostId && this.Usage == other.Usage && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004E78 RID: 20088 RVA: 0x000BE6BC File Offset: 0x000BC8BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CostId != 0)
			{
				num ^= this.CostId.GetHashCode();
			}
			if (this.Usage != 0)
			{
				num ^= this.Usage.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004E79 RID: 20089 RVA: 0x000BE714 File Offset: 0x000BC914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004E7A RID: 20090 RVA: 0x000BE721 File Offset: 0x000BC921
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004E7B RID: 20091 RVA: 0x000BE72C File Offset: 0x000BC92C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CostId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CostId);
			}
			if (this.Usage != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Usage);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004E7C RID: 20092 RVA: 0x000BE784 File Offset: 0x000BC984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CostId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CostId);
			}
			if (this.Usage != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Usage);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004E7D RID: 20093 RVA: 0x000BE7DC File Offset: 0x000BC9DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CostCombinationInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CostId != 0)
			{
				this.CostId = other.CostId;
			}
			if (other.Usage != 0)
			{
				this.Usage = other.Usage;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004E7E RID: 20094 RVA: 0x000BE82C File Offset: 0x000BCA2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004E7F RID: 20095 RVA: 0x000BE838 File Offset: 0x000BCA38
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
						this.Usage = input.ReadInt32();
					}
				}
				else
				{
					this.CostId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003193 RID: 12691
		private static readonly MessageParser<CostCombinationInfo> _parser = new MessageParser<CostCombinationInfo>(() => new CostCombinationInfo());

		// Token: 0x04003194 RID: 12692
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003195 RID: 12693
		public const int CostIdFieldNumber = 1;

		// Token: 0x04003196 RID: 12694
		private int costId_;

		// Token: 0x04003197 RID: 12695
		public const int UsageFieldNumber = 2;

		// Token: 0x04003198 RID: 12696
		private int usage_;
	}
}
