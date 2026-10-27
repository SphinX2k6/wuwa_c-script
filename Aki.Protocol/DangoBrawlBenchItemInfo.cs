using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200033A RID: 826
	public sealed class DangoBrawlBenchItemInfo : IMessage<DangoBrawlBenchItemInfo>, IMessage, IEquatable<DangoBrawlBenchItemInfo>, IDeepCloneable<DangoBrawlBenchItemInfo>, IBufferMessage
	{
		// Token: 0x060052E1 RID: 21217 RVA: 0x000CA4A3 File Offset: 0x000C86A3
		[NullableContext(1)]
		public static DangoBrawlBenchItemInfo Create()
		{
			return new DangoBrawlBenchItemInfo();
		}

		// Token: 0x17000F08 RID: 3848
		// (get) Token: 0x060052E2 RID: 21218 RVA: 0x000CA4AA File Offset: 0x000C86AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DangoBrawlBenchItemInfo> Parser
		{
			get
			{
				return DangoBrawlBenchItemInfo._parser;
			}
		}

		// Token: 0x17000F09 RID: 3849
		// (get) Token: 0x060052E3 RID: 21219 RVA: 0x000CA4B1 File Offset: 0x000C86B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F0A RID: 3850
		// (get) Token: 0x060052E4 RID: 21220 RVA: 0x000CA4B4 File Offset: 0x000C86B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlBenchItemInfo.Descriptor;
			}
		}

		// Token: 0x060052E5 RID: 21221 RVA: 0x000CA4BB File Offset: 0x000C86BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBenchItemInfo()
		{
		}

		// Token: 0x060052E6 RID: 21222 RVA: 0x000CA4C3 File Offset: 0x000C86C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBenchItemInfo(DangoBrawlBenchItemInfo other) : this()
		{
			this.inst_ = ((other.inst_ != null) ? other.inst_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060052E7 RID: 21223 RVA: 0x000CA4F8 File Offset: 0x000C86F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBenchItemInfo Clone()
		{
			return new DangoBrawlBenchItemInfo(this);
		}

		// Token: 0x17000F0B RID: 3851
		// (get) Token: 0x060052E8 RID: 21224 RVA: 0x000CA500 File Offset: 0x000C8700
		// (set) Token: 0x060052E9 RID: 21225 RVA: 0x000CA508 File Offset: 0x000C8708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBaseItemInfo Inst
		{
			get
			{
				return this.inst_;
			}
			set
			{
				this.inst_ = value;
			}
		}

		// Token: 0x060052EA RID: 21226 RVA: 0x000CA511 File Offset: 0x000C8711
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlBenchItemInfo);
		}

		// Token: 0x060052EB RID: 21227 RVA: 0x000CA51F File Offset: 0x000C871F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlBenchItemInfo other)
		{
			return other != null && (other == this || (object.Equals(this.Inst, other.Inst) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060052EC RID: 21228 RVA: 0x000CA554 File Offset: 0x000C8754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.inst_ != null)
			{
				num ^= this.Inst.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060052ED RID: 21229 RVA: 0x000CA590 File Offset: 0x000C8790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060052EE RID: 21230 RVA: 0x000CA59D File Offset: 0x000C879D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060052EF RID: 21231 RVA: 0x000CA5A6 File Offset: 0x000C87A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.inst_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Inst);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060052F0 RID: 21232 RVA: 0x000CA5D8 File Offset: 0x000C87D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.inst_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Inst);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060052F1 RID: 21233 RVA: 0x000CA618 File Offset: 0x000C8818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlBenchItemInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.inst_ != null)
			{
				if (this.inst_ == null)
				{
					this.Inst = new DangoBrawlBaseItemInfo();
				}
				this.Inst.MergeFrom(other.Inst);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060052F2 RID: 21234 RVA: 0x000CA66C File Offset: 0x000C886C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060052F3 RID: 21235 RVA: 0x000CA678 File Offset: 0x000C8878
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
					if (this.inst_ == null)
					{
						this.Inst = new DangoBrawlBaseItemInfo();
					}
					input.ReadMessage(this.Inst);
				}
			}
		}

		// Token: 0x04003353 RID: 13139
		private static readonly MessageParser<DangoBrawlBenchItemInfo> _parser = new MessageParser<DangoBrawlBenchItemInfo>(() => new DangoBrawlBenchItemInfo());

		// Token: 0x04003354 RID: 13140
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003355 RID: 13141
		public const int InstFieldNumber = 1;

		// Token: 0x04003356 RID: 13142
		private DangoBrawlBaseItemInfo inst_;
	}
}
