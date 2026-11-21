using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000219 RID: 537
	public sealed class BulletScreenTimes : IMessage<BulletScreenTimes>, IMessage, IEquatable<BulletScreenTimes>, IDeepCloneable<BulletScreenTimes>, IBufferMessage
	{
		// Token: 0x06003B0E RID: 15118 RVA: 0x00093420 File Offset: 0x00091620
		[NullableContext(1)]
		public static BulletScreenTimes Create()
		{
			return new BulletScreenTimes();
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x06003B0F RID: 15119 RVA: 0x00093427 File Offset: 0x00091627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BulletScreenTimes> Parser
		{
			get
			{
				return BulletScreenTimes._parser;
			}
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x06003B10 RID: 15120 RVA: 0x0009342E File Offset: 0x0009162E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x06003B11 RID: 15121 RVA: 0x00093431 File Offset: 0x00091631
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BulletScreenTimes.Descriptor;
			}
		}

		// Token: 0x06003B12 RID: 15122 RVA: 0x00093438 File Offset: 0x00091638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BulletScreenTimes()
		{
		}

		// Token: 0x06003B13 RID: 15123 RVA: 0x00093440 File Offset: 0x00091640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BulletScreenTimes(BulletScreenTimes other) : this()
		{
			this.bulletScreenId_ = other.bulletScreenId_;
			this.num_ = other.num_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003B14 RID: 15124 RVA: 0x00093471 File Offset: 0x00091671
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BulletScreenTimes Clone()
		{
			return new BulletScreenTimes(this);
		}

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x06003B15 RID: 15125 RVA: 0x00093479 File Offset: 0x00091679
		// (set) Token: 0x06003B16 RID: 15126 RVA: 0x00093481 File Offset: 0x00091681
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BulletScreenId
		{
			get
			{
				return this.bulletScreenId_;
			}
			set
			{
				this.bulletScreenId_ = value;
			}
		}

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x06003B17 RID: 15127 RVA: 0x0009348A File Offset: 0x0009168A
		// (set) Token: 0x06003B18 RID: 15128 RVA: 0x00093492 File Offset: 0x00091692
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Num
		{
			get
			{
				return this.num_;
			}
			set
			{
				this.num_ = value;
			}
		}

		// Token: 0x06003B19 RID: 15129 RVA: 0x0009349B File Offset: 0x0009169B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BulletScreenTimes);
		}

		// Token: 0x06003B1A RID: 15130 RVA: 0x000934A9 File Offset: 0x000916A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BulletScreenTimes other)
		{
			return other != null && (other == this || (this.BulletScreenId == other.BulletScreenId && this.Num == other.Num && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003B1B RID: 15131 RVA: 0x000934E8 File Offset: 0x000916E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BulletScreenId != 0)
			{
				num ^= this.BulletScreenId.GetHashCode();
			}
			if (this.Num != 0)
			{
				num ^= this.Num.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003B1C RID: 15132 RVA: 0x00093540 File Offset: 0x00091740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003B1D RID: 15133 RVA: 0x0009354D File Offset: 0x0009174D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003B1E RID: 15134 RVA: 0x00093558 File Offset: 0x00091758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BulletScreenId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BulletScreenId);
			}
			if (this.Num != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Num);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003B1F RID: 15135 RVA: 0x000935B0 File Offset: 0x000917B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BulletScreenId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BulletScreenId);
			}
			if (this.Num != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Num);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003B20 RID: 15136 RVA: 0x00093608 File Offset: 0x00091808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BulletScreenTimes other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BulletScreenId != 0)
			{
				this.BulletScreenId = other.BulletScreenId;
			}
			if (other.Num != 0)
			{
				this.Num = other.Num;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003B21 RID: 15137 RVA: 0x00093658 File Offset: 0x00091858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003B22 RID: 15138 RVA: 0x00093664 File Offset: 0x00091864
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
						this.Num = input.ReadInt32();
					}
				}
				else
				{
					this.BulletScreenId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002C50 RID: 11344
		private static readonly MessageParser<BulletScreenTimes> _parser = new MessageParser<BulletScreenTimes>(() => new BulletScreenTimes());

		// Token: 0x04002C51 RID: 11345
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C52 RID: 11346
		public const int BulletScreenIdFieldNumber = 1;

		// Token: 0x04002C53 RID: 11347
		private int bulletScreenId_;

		// Token: 0x04002C54 RID: 11348
		public const int NumFieldNumber = 2;

		// Token: 0x04002C55 RID: 11349
		private int num_;
	}
}
