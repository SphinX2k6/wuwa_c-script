using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000840 RID: 2112
	[NetMessage(EMessageId.ItemFuncValueUpdateNotify)]
	public sealed class ItemFuncValueUpdateNotify : IMessage<ItemFuncValueUpdateNotify>, IMessage, IEquatable<ItemFuncValueUpdateNotify>, IDeepCloneable<ItemFuncValueUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600BCCA RID: 48330 RVA: 0x001C1302 File Offset: 0x001BF502
		[NullableContext(1)]
		public static ItemFuncValueUpdateNotify Create()
		{
			return new ItemFuncValueUpdateNotify();
		}

		// Token: 0x1700261A RID: 9754
		// (get) Token: 0x0600BCCB RID: 48331 RVA: 0x001C1309 File Offset: 0x001BF509
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700261B RID: 9755
		// (get) Token: 0x0600BCCC RID: 48332 RVA: 0x001C130C File Offset: 0x001BF50C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemFuncValueUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600BCCD RID: 48333 RVA: 0x001C1313 File Offset: 0x001BF513
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemFuncValueUpdateNotify()
		{
		}

		// Token: 0x0600BCCE RID: 48334 RVA: 0x001C131B File Offset: 0x001BF51B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemFuncValueUpdateNotify(ItemFuncValueUpdateNotify other) : this()
		{
			this.incrId_ = other.incrId_;
			this.funcValue_ = other.funcValue_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BCCF RID: 48335 RVA: 0x001C134C File Offset: 0x001BF54C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemFuncValueUpdateNotify Clone()
		{
			return new ItemFuncValueUpdateNotify(this);
		}

		// Token: 0x1700261C RID: 9756
		// (get) Token: 0x0600BCD0 RID: 48336 RVA: 0x001C1354 File Offset: 0x001BF554
		// (set) Token: 0x0600BCD1 RID: 48337 RVA: 0x001C135C File Offset: 0x001BF55C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncrId
		{
			get
			{
				return this.incrId_;
			}
			set
			{
				this.incrId_ = value;
			}
		}

		// Token: 0x1700261D RID: 9757
		// (get) Token: 0x0600BCD2 RID: 48338 RVA: 0x001C1365 File Offset: 0x001BF565
		// (set) Token: 0x0600BCD3 RID: 48339 RVA: 0x001C136D File Offset: 0x001BF56D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FuncValue
		{
			get
			{
				return this.funcValue_;
			}
			set
			{
				this.funcValue_ = value;
			}
		}

		// Token: 0x0600BCD4 RID: 48340 RVA: 0x001C1376 File Offset: 0x001BF576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemFuncValueUpdateNotify);
		}

		// Token: 0x0600BCD5 RID: 48341 RVA: 0x001C1384 File Offset: 0x001BF584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemFuncValueUpdateNotify other)
		{
			return other != null && (other == this || (this.IncrId == other.IncrId && this.FuncValue == other.FuncValue && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BCD6 RID: 48342 RVA: 0x001C13C4 File Offset: 0x001BF5C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncrId != 0)
			{
				num ^= this.IncrId.GetHashCode();
			}
			if (this.FuncValue != 0)
			{
				num ^= this.FuncValue.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BCD7 RID: 48343 RVA: 0x001C141C File Offset: 0x001BF61C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BCD8 RID: 48344 RVA: 0x001C1429 File Offset: 0x001BF629
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BCD9 RID: 48345 RVA: 0x001C1434 File Offset: 0x001BF634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncrId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.IncrId);
			}
			if (this.FuncValue != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.FuncValue);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BCDA RID: 48346 RVA: 0x001C1490 File Offset: 0x001BF690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncrId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncrId);
			}
			if (this.FuncValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FuncValue);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BCDB RID: 48347 RVA: 0x001C14E8 File Offset: 0x001BF6E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ItemFuncValueUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncrId != 0)
			{
				this.IncrId = other.IncrId;
			}
			if (other.FuncValue != 0)
			{
				this.FuncValue = other.FuncValue;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BCDC RID: 48348 RVA: 0x001C1538 File Offset: 0x001BF738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BCDD RID: 48349 RVA: 0x001C1544 File Offset: 0x001BF744
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
				if (num != 40U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.FuncValue = input.ReadInt32();
					}
				}
				else
				{
					this.IncrId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040052EE RID: 21230
		private UnknownFieldSet _unknownFields;

		// Token: 0x040052EF RID: 21231
		public const int IncrIdFieldNumber = 5;

		// Token: 0x040052F0 RID: 21232
		private int incrId_;

		// Token: 0x040052F1 RID: 21233
		public const int FuncValueFieldNumber = 15;

		// Token: 0x040052F2 RID: 21234
		private int funcValue_;
	}
}
