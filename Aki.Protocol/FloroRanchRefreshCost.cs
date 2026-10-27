using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005DA RID: 1498
	public sealed class FloroRanchRefreshCost : IMessage<FloroRanchRefreshCost>, IMessage, IEquatable<FloroRanchRefreshCost>, IDeepCloneable<FloroRanchRefreshCost>, IBufferMessage
	{
		// Token: 0x06008A9D RID: 35485 RVA: 0x0014F302 File Offset: 0x0014D502
		[NullableContext(1)]
		public static FloroRanchRefreshCost Create()
		{
			return new FloroRanchRefreshCost();
		}

		// Token: 0x17001B55 RID: 6997
		// (get) Token: 0x06008A9E RID: 35486 RVA: 0x0014F309 File Offset: 0x0014D509
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FloroRanchRefreshCost> Parser
		{
			get
			{
				return FloroRanchRefreshCost._parser;
			}
		}

		// Token: 0x17001B56 RID: 6998
		// (get) Token: 0x06008A9F RID: 35487 RVA: 0x0014F310 File Offset: 0x0014D510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B57 RID: 6999
		// (get) Token: 0x06008AA0 RID: 35488 RVA: 0x0014F313 File Offset: 0x0014D513
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchRefreshCost.Descriptor;
			}
		}

		// Token: 0x06008AA1 RID: 35489 RVA: 0x0014F31A File Offset: 0x0014D51A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchRefreshCost()
		{
		}

		// Token: 0x06008AA2 RID: 35490 RVA: 0x0014F322 File Offset: 0x0014D522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchRefreshCost(FloroRanchRefreshCost other) : this()
		{
			this.type_ = other.type_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008AA3 RID: 35491 RVA: 0x0014F353 File Offset: 0x0014D553
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchRefreshCost Clone()
		{
			return new FloroRanchRefreshCost(this);
		}

		// Token: 0x17001B58 RID: 7000
		// (get) Token: 0x06008AA4 RID: 35492 RVA: 0x0014F35B File Offset: 0x0014D55B
		// (set) Token: 0x06008AA5 RID: 35493 RVA: 0x0014F363 File Offset: 0x0014D563
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayResourcesType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17001B59 RID: 7001
		// (get) Token: 0x06008AA6 RID: 35494 RVA: 0x0014F36C File Offset: 0x0014D56C
		// (set) Token: 0x06008AA7 RID: 35495 RVA: 0x0014F374 File Offset: 0x0014D574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x06008AA8 RID: 35496 RVA: 0x0014F37D File Offset: 0x0014D57D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchRefreshCost);
		}

		// Token: 0x06008AA9 RID: 35497 RVA: 0x0014F38B File Offset: 0x0014D58B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchRefreshCost other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008AAA RID: 35498 RVA: 0x0014F3CC File Offset: 0x0014D5CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != FloroRanchPlayResourcesType.Coin)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008AAB RID: 35499 RVA: 0x0014F42A File Offset: 0x0014D62A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008AAC RID: 35500 RVA: 0x0014F437 File Offset: 0x0014D637
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008AAD RID: 35501 RVA: 0x0014F440 File Offset: 0x0014D640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != FloroRanchPlayResourcesType.Coin)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Type);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Count);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008AAE RID: 35502 RVA: 0x0014F498 File Offset: 0x0014D698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != FloroRanchPlayResourcesType.Coin)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008AAF RID: 35503 RVA: 0x0014F4F0 File Offset: 0x0014D6F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchRefreshCost other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != FloroRanchPlayResourcesType.Coin)
			{
				this.Type = other.Type;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008AB0 RID: 35504 RVA: 0x0014F540 File Offset: 0x0014D740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008AB1 RID: 35505 RVA: 0x0014F54C File Offset: 0x0014D74C
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
						this.Count = input.ReadInt32();
					}
				}
				else
				{
					this.Type = (FloroRanchPlayResourcesType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004411 RID: 17425
		private static readonly MessageParser<FloroRanchRefreshCost> _parser = new MessageParser<FloroRanchRefreshCost>(() => new FloroRanchRefreshCost());

		// Token: 0x04004412 RID: 17426
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004413 RID: 17427
		public const int TypeFieldNumber = 1;

		// Token: 0x04004414 RID: 17428
		private FloroRanchPlayResourcesType type_;

		// Token: 0x04004415 RID: 17429
		public const int CountFieldNumber = 2;

		// Token: 0x04004416 RID: 17430
		private int count_;
	}
}
