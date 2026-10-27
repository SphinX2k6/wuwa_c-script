using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x020016B9 RID: 5817
	public sealed class Int2Long : IMessage<Int2Long>, IMessage, IEquatable<Int2Long>, IDeepCloneable<Int2Long>, IBufferMessage
	{
		// Token: 0x0601D243 RID: 119363 RVA: 0x0044340B File Offset: 0x0044160B
		[NullableContext(1)]
		public static Int2Long Create()
		{
			return new Int2Long();
		}

		// Token: 0x170062D9 RID: 25305
		// (get) Token: 0x0601D244 RID: 119364 RVA: 0x00443412 File Offset: 0x00441612
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Int2Long> Parser
		{
			get
			{
				return Int2Long._parser;
			}
		}

		// Token: 0x170062DA RID: 25306
		// (get) Token: 0x0601D245 RID: 119365 RVA: 0x00443419 File Offset: 0x00441619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170062DB RID: 25307
		// (get) Token: 0x0601D246 RID: 119366 RVA: 0x0044341C File Offset: 0x0044161C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Int2Long.Descriptor;
			}
		}

		// Token: 0x0601D247 RID: 119367 RVA: 0x00443423 File Offset: 0x00441623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Int2Long()
		{
		}

		// Token: 0x0601D248 RID: 119368 RVA: 0x0044342B File Offset: 0x0044162B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Int2Long(Int2Long other) : this()
		{
			this.first_ = other.first_;
			this.second_ = other.second_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D249 RID: 119369 RVA: 0x0044345C File Offset: 0x0044165C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Int2Long Clone()
		{
			return new Int2Long(this);
		}

		// Token: 0x170062DC RID: 25308
		// (get) Token: 0x0601D24A RID: 119370 RVA: 0x00443464 File Offset: 0x00441664
		// (set) Token: 0x0601D24B RID: 119371 RVA: 0x0044346C File Offset: 0x0044166C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int First
		{
			get
			{
				return this.first_;
			}
			set
			{
				this.first_ = value;
			}
		}

		// Token: 0x170062DD RID: 25309
		// (get) Token: 0x0601D24C RID: 119372 RVA: 0x00443475 File Offset: 0x00441675
		// (set) Token: 0x0601D24D RID: 119373 RVA: 0x0044347D File Offset: 0x0044167D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Second
		{
			get
			{
				return this.second_;
			}
			set
			{
				this.second_ = value;
			}
		}

		// Token: 0x0601D24E RID: 119374 RVA: 0x00443486 File Offset: 0x00441686
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as Int2Long);
		}

		// Token: 0x0601D24F RID: 119375 RVA: 0x00443494 File Offset: 0x00441694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Int2Long other)
		{
			return other != null && (other == this || (this.First == other.First && this.Second == other.Second && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D250 RID: 119376 RVA: 0x004434D4 File Offset: 0x004416D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.First != 0)
			{
				num ^= this.First.GetHashCode();
			}
			if (this.Second != 0L)
			{
				num ^= this.Second.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D251 RID: 119377 RVA: 0x0044352C File Offset: 0x0044172C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D252 RID: 119378 RVA: 0x00443539 File Offset: 0x00441739
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D253 RID: 119379 RVA: 0x00443544 File Offset: 0x00441744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.First != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.First);
			}
			if (this.Second != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.Second);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D254 RID: 119380 RVA: 0x0044359C File Offset: 0x0044179C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.First != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.First);
			}
			if (this.Second != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Second);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D255 RID: 119381 RVA: 0x004435F4 File Offset: 0x004417F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Int2Long other)
		{
			if (other == null)
			{
				return;
			}
			if (other.First != 0)
			{
				this.First = other.First;
			}
			if (other.Second != 0L)
			{
				this.Second = other.Second;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D256 RID: 119382 RVA: 0x00443644 File Offset: 0x00441844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D257 RID: 119383 RVA: 0x00443650 File Offset: 0x00441850
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
						this.Second = input.ReadInt64();
					}
				}
				else
				{
					this.First = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400C46C RID: 50284
		private static readonly MessageParser<Int2Long> _parser = new MessageParser<Int2Long>(() => new Int2Long());

		// Token: 0x0400C46D RID: 50285
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C46E RID: 50286
		public const int FirstFieldNumber = 1;

		// Token: 0x0400C46F RID: 50287
		private int first_;

		// Token: 0x0400C470 RID: 50288
		public const int SecondFieldNumber = 2;

		// Token: 0x0400C471 RID: 50289
		private long second_;
	}
}
