using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200149F RID: 5279
	public sealed class TrapDefenseGoldenCoinPbData : IMessage<TrapDefenseGoldenCoinPbData>, IMessage, IEquatable<TrapDefenseGoldenCoinPbData>, IDeepCloneable<TrapDefenseGoldenCoinPbData>, IBufferMessage
	{
		// Token: 0x0601C054 RID: 114772 RVA: 0x00411B76 File Offset: 0x0040FD76
		[NullableContext(1)]
		public static TrapDefenseGoldenCoinPbData Create()
		{
			return new TrapDefenseGoldenCoinPbData();
		}

		// Token: 0x17005EDA RID: 24282
		// (get) Token: 0x0601C055 RID: 114773 RVA: 0x00411B7D File Offset: 0x0040FD7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005EDB RID: 24283
		// (get) Token: 0x0601C056 RID: 114774 RVA: 0x00411B80 File Offset: 0x0040FD80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseGoldenCoinPbData.Descriptor;
			}
		}

		// Token: 0x0601C057 RID: 114775 RVA: 0x00411B87 File Offset: 0x0040FD87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGoldenCoinPbData()
		{
		}

		// Token: 0x0601C058 RID: 114776 RVA: 0x00411B8F File Offset: 0x0040FD8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGoldenCoinPbData(TrapDefenseGoldenCoinPbData other) : this()
		{
			this.configId_ = other.configId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C059 RID: 114777 RVA: 0x00411BB4 File Offset: 0x0040FDB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGoldenCoinPbData Clone()
		{
			return new TrapDefenseGoldenCoinPbData(this);
		}

		// Token: 0x17005EDC RID: 24284
		// (get) Token: 0x0601C05A RID: 114778 RVA: 0x00411BBC File Offset: 0x0040FDBC
		// (set) Token: 0x0601C05B RID: 114779 RVA: 0x00411BC4 File Offset: 0x0040FDC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x0601C05C RID: 114780 RVA: 0x00411BCD File Offset: 0x0040FDCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseGoldenCoinPbData);
		}

		// Token: 0x0601C05D RID: 114781 RVA: 0x00411BDB File Offset: 0x0040FDDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseGoldenCoinPbData other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C05E RID: 114782 RVA: 0x00411C0C File Offset: 0x0040FE0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C05F RID: 114783 RVA: 0x00411C4B File Offset: 0x0040FE4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C060 RID: 114784 RVA: 0x00411C58 File Offset: 0x0040FE58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C061 RID: 114785 RVA: 0x00411C61 File Offset: 0x0040FE61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C062 RID: 114786 RVA: 0x00411C94 File Offset: 0x0040FE94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C063 RID: 114787 RVA: 0x00411CD2 File Offset: 0x0040FED2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseGoldenCoinPbData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C064 RID: 114788 RVA: 0x00411D03 File Offset: 0x0040FF03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C065 RID: 114789 RVA: 0x00411D0C File Offset: 0x0040FF0C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A24B RID: 41547
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A24C RID: 41548
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x0400A24D RID: 41549
		private int configId_;
	}
}
