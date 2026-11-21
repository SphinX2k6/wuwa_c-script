using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000342 RID: 834
	public sealed class DangoBrawlBenchItemInfo : IMessage<DangoBrawlBenchItemInfo>, IMessage, IEquatable<DangoBrawlBenchItemInfo>, IDeepCloneable<DangoBrawlBenchItemInfo>, IBufferMessage
	{
		// Token: 0x060053CE RID: 21454 RVA: 0x000CCB27 File Offset: 0x000CAD27
		[NullableContext(1)]
		public static DangoBrawlBenchItemInfo Create()
		{
			return new DangoBrawlBenchItemInfo();
		}

		// Token: 0x17000F39 RID: 3897
		// (get) Token: 0x060053CF RID: 21455 RVA: 0x000CCB2E File Offset: 0x000CAD2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DangoBrawlBenchItemInfo> Parser
		{
			get
			{
				return DangoBrawlBenchItemInfo._parser;
			}
		}

		// Token: 0x17000F3A RID: 3898
		// (get) Token: 0x060053D0 RID: 21456 RVA: 0x000CCB35 File Offset: 0x000CAD35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F3B RID: 3899
		// (get) Token: 0x060053D1 RID: 21457 RVA: 0x000CCB38 File Offset: 0x000CAD38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlBenchItemInfo.Descriptor;
			}
		}

		// Token: 0x060053D2 RID: 21458 RVA: 0x000CCB3F File Offset: 0x000CAD3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBenchItemInfo()
		{
		}

		// Token: 0x060053D3 RID: 21459 RVA: 0x000CCB47 File Offset: 0x000CAD47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBenchItemInfo(DangoBrawlBenchItemInfo other) : this()
		{
			this.inst_ = ((other.inst_ != null) ? other.inst_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060053D4 RID: 21460 RVA: 0x000CCB7C File Offset: 0x000CAD7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBenchItemInfo Clone()
		{
			return new DangoBrawlBenchItemInfo(this);
		}

		// Token: 0x17000F3C RID: 3900
		// (get) Token: 0x060053D5 RID: 21461 RVA: 0x000CCB84 File Offset: 0x000CAD84
		// (set) Token: 0x060053D6 RID: 21462 RVA: 0x000CCB8C File Offset: 0x000CAD8C
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

		// Token: 0x060053D7 RID: 21463 RVA: 0x000CCB95 File Offset: 0x000CAD95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlBenchItemInfo);
		}

		// Token: 0x060053D8 RID: 21464 RVA: 0x000CCBA3 File Offset: 0x000CADA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlBenchItemInfo other)
		{
			return other != null && (other == this || (object.Equals(this.Inst, other.Inst) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060053D9 RID: 21465 RVA: 0x000CCBD8 File Offset: 0x000CADD8
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

		// Token: 0x060053DA RID: 21466 RVA: 0x000CCC14 File Offset: 0x000CAE14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060053DB RID: 21467 RVA: 0x000CCC21 File Offset: 0x000CAE21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060053DC RID: 21468 RVA: 0x000CCC2A File Offset: 0x000CAE2A
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

		// Token: 0x060053DD RID: 21469 RVA: 0x000CCC5C File Offset: 0x000CAE5C
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

		// Token: 0x060053DE RID: 21470 RVA: 0x000CCC9C File Offset: 0x000CAE9C
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

		// Token: 0x060053DF RID: 21471 RVA: 0x000CCCF0 File Offset: 0x000CAEF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060053E0 RID: 21472 RVA: 0x000CCCFC File Offset: 0x000CAEFC
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

		// Token: 0x040033EF RID: 13295
		private static readonly MessageParser<DangoBrawlBenchItemInfo> _parser = new MessageParser<DangoBrawlBenchItemInfo>(() => new DangoBrawlBenchItemInfo());

		// Token: 0x040033F0 RID: 13296
		private UnknownFieldSet _unknownFields;

		// Token: 0x040033F1 RID: 13297
		public const int InstFieldNumber = 1;

		// Token: 0x040033F2 RID: 13298
		private DangoBrawlBaseItemInfo inst_;
	}
}
