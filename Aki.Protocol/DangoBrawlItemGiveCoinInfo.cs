using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200035F RID: 863
	public sealed class DangoBrawlItemGiveCoinInfo : IMessage<DangoBrawlItemGiveCoinInfo>, IMessage, IEquatable<DangoBrawlItemGiveCoinInfo>, IDeepCloneable<DangoBrawlItemGiveCoinInfo>, IBufferMessage
	{
		// Token: 0x06005622 RID: 22050 RVA: 0x000D2900 File Offset: 0x000D0B00
		[NullableContext(1)]
		public static DangoBrawlItemGiveCoinInfo Create()
		{
			return new DangoBrawlItemGiveCoinInfo();
		}

		// Token: 0x17000FCC RID: 4044
		// (get) Token: 0x06005623 RID: 22051 RVA: 0x000D2907 File Offset: 0x000D0B07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DangoBrawlItemGiveCoinInfo> Parser
		{
			get
			{
				return DangoBrawlItemGiveCoinInfo._parser;
			}
		}

		// Token: 0x17000FCD RID: 4045
		// (get) Token: 0x06005624 RID: 22052 RVA: 0x000D290E File Offset: 0x000D0B0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000FCE RID: 4046
		// (get) Token: 0x06005625 RID: 22053 RVA: 0x000D2911 File Offset: 0x000D0B11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlItemGiveCoinInfo.Descriptor;
			}
		}

		// Token: 0x06005626 RID: 22054 RVA: 0x000D2918 File Offset: 0x000D0B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlItemGiveCoinInfo()
		{
		}

		// Token: 0x06005627 RID: 22055 RVA: 0x000D2920 File Offset: 0x000D0B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlItemGiveCoinInfo(DangoBrawlItemGiveCoinInfo other) : this()
		{
			this.itemUId_ = other.itemUId_;
			this.delta_ = other.delta_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005628 RID: 22056 RVA: 0x000D2951 File Offset: 0x000D0B51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlItemGiveCoinInfo Clone()
		{
			return new DangoBrawlItemGiveCoinInfo(this);
		}

		// Token: 0x17000FCF RID: 4047
		// (get) Token: 0x06005629 RID: 22057 RVA: 0x000D2959 File Offset: 0x000D0B59
		// (set) Token: 0x0600562A RID: 22058 RVA: 0x000D2961 File Offset: 0x000D0B61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemUId
		{
			get
			{
				return this.itemUId_;
			}
			set
			{
				this.itemUId_ = value;
			}
		}

		// Token: 0x17000FD0 RID: 4048
		// (get) Token: 0x0600562B RID: 22059 RVA: 0x000D296A File Offset: 0x000D0B6A
		// (set) Token: 0x0600562C RID: 22060 RVA: 0x000D2972 File Offset: 0x000D0B72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Delta
		{
			get
			{
				return this.delta_;
			}
			set
			{
				this.delta_ = value;
			}
		}

		// Token: 0x0600562D RID: 22061 RVA: 0x000D297B File Offset: 0x000D0B7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlItemGiveCoinInfo);
		}

		// Token: 0x0600562E RID: 22062 RVA: 0x000D2989 File Offset: 0x000D0B89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlItemGiveCoinInfo other)
		{
			return other != null && (other == this || (this.ItemUId == other.ItemUId && this.Delta == other.Delta && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600562F RID: 22063 RVA: 0x000D29C8 File Offset: 0x000D0BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemUId != 0)
			{
				num ^= this.ItemUId.GetHashCode();
			}
			if (this.Delta != 0)
			{
				num ^= this.Delta.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005630 RID: 22064 RVA: 0x000D2A20 File Offset: 0x000D0C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005631 RID: 22065 RVA: 0x000D2A2D File Offset: 0x000D0C2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005632 RID: 22066 RVA: 0x000D2A38 File Offset: 0x000D0C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemUId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemUId);
			}
			if (this.Delta != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Delta);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005633 RID: 22067 RVA: 0x000D2A90 File Offset: 0x000D0C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemUId);
			}
			if (this.Delta != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Delta);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005634 RID: 22068 RVA: 0x000D2AE8 File Offset: 0x000D0CE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlItemGiveCoinInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemUId != 0)
			{
				this.ItemUId = other.ItemUId;
			}
			if (other.Delta != 0)
			{
				this.Delta = other.Delta;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005635 RID: 22069 RVA: 0x000D2B38 File Offset: 0x000D0D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005636 RID: 22070 RVA: 0x000D2B44 File Offset: 0x000D0D44
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
						this.Delta = input.ReadInt32();
					}
				}
				else
				{
					this.ItemUId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003467 RID: 13415
		private static readonly MessageParser<DangoBrawlItemGiveCoinInfo> _parser = new MessageParser<DangoBrawlItemGiveCoinInfo>(() => new DangoBrawlItemGiveCoinInfo());

		// Token: 0x04003468 RID: 13416
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003469 RID: 13417
		public const int ItemUIdFieldNumber = 1;

		// Token: 0x0400346A RID: 13418
		private int itemUId_;

		// Token: 0x0400346B RID: 13419
		public const int DeltaFieldNumber = 2;

		// Token: 0x0400346C RID: 13420
		private int delta_;
	}
}
