using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000311 RID: 785
	public sealed class CostCombinationInfo : IMessage<CostCombinationInfo>, IMessage, IEquatable<CostCombinationInfo>, IDeepCloneable<CostCombinationInfo>, IBufferMessage
	{
		// Token: 0x06004F44 RID: 20292 RVA: 0x000C09DE File Offset: 0x000BEBDE
		[NullableContext(1)]
		public static CostCombinationInfo Create()
		{
			return new CostCombinationInfo();
		}

		// Token: 0x17000E14 RID: 3604
		// (get) Token: 0x06004F45 RID: 20293 RVA: 0x000C09E5 File Offset: 0x000BEBE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CostCombinationInfo> Parser
		{
			get
			{
				return CostCombinationInfo._parser;
			}
		}

		// Token: 0x17000E15 RID: 3605
		// (get) Token: 0x06004F46 RID: 20294 RVA: 0x000C09EC File Offset: 0x000BEBEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E16 RID: 3606
		// (get) Token: 0x06004F47 RID: 20295 RVA: 0x000C09EF File Offset: 0x000BEBEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CostCombinationInfo.Descriptor;
			}
		}

		// Token: 0x06004F48 RID: 20296 RVA: 0x000C09F6 File Offset: 0x000BEBF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CostCombinationInfo()
		{
		}

		// Token: 0x06004F49 RID: 20297 RVA: 0x000C09FE File Offset: 0x000BEBFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CostCombinationInfo(CostCombinationInfo other) : this()
		{
			this.costId_ = other.costId_;
			this.usage_ = other.usage_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004F4A RID: 20298 RVA: 0x000C0A2F File Offset: 0x000BEC2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CostCombinationInfo Clone()
		{
			return new CostCombinationInfo(this);
		}

		// Token: 0x17000E17 RID: 3607
		// (get) Token: 0x06004F4B RID: 20299 RVA: 0x000C0A37 File Offset: 0x000BEC37
		// (set) Token: 0x06004F4C RID: 20300 RVA: 0x000C0A3F File Offset: 0x000BEC3F
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

		// Token: 0x17000E18 RID: 3608
		// (get) Token: 0x06004F4D RID: 20301 RVA: 0x000C0A48 File Offset: 0x000BEC48
		// (set) Token: 0x06004F4E RID: 20302 RVA: 0x000C0A50 File Offset: 0x000BEC50
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

		// Token: 0x06004F4F RID: 20303 RVA: 0x000C0A59 File Offset: 0x000BEC59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CostCombinationInfo);
		}

		// Token: 0x06004F50 RID: 20304 RVA: 0x000C0A67 File Offset: 0x000BEC67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CostCombinationInfo other)
		{
			return other != null && (other == this || (this.CostId == other.CostId && this.Usage == other.Usage && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004F51 RID: 20305 RVA: 0x000C0AA8 File Offset: 0x000BECA8
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

		// Token: 0x06004F52 RID: 20306 RVA: 0x000C0B00 File Offset: 0x000BED00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004F53 RID: 20307 RVA: 0x000C0B0D File Offset: 0x000BED0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004F54 RID: 20308 RVA: 0x000C0B18 File Offset: 0x000BED18
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

		// Token: 0x06004F55 RID: 20309 RVA: 0x000C0B70 File Offset: 0x000BED70
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

		// Token: 0x06004F56 RID: 20310 RVA: 0x000C0BC8 File Offset: 0x000BEDC8
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

		// Token: 0x06004F57 RID: 20311 RVA: 0x000C0C18 File Offset: 0x000BEE18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004F58 RID: 20312 RVA: 0x000C0C24 File Offset: 0x000BEE24
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

		// Token: 0x0400322A RID: 12842
		private static readonly MessageParser<CostCombinationInfo> _parser = new MessageParser<CostCombinationInfo>(() => new CostCombinationInfo());

		// Token: 0x0400322B RID: 12843
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400322C RID: 12844
		public const int CostIdFieldNumber = 1;

		// Token: 0x0400322D RID: 12845
		private int costId_;

		// Token: 0x0400322E RID: 12846
		public const int UsageFieldNumber = 2;

		// Token: 0x0400322F RID: 12847
		private int usage_;
	}
}
