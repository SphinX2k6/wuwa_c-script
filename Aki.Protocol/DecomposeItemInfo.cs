using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003BC RID: 956
	public sealed class DecomposeItemInfo : IMessage<DecomposeItemInfo>, IMessage, IEquatable<DecomposeItemInfo>, IDeepCloneable<DecomposeItemInfo>, IBufferMessage
	{
		// Token: 0x06005DA1 RID: 23969 RVA: 0x000E3211 File Offset: 0x000E1411
		[NullableContext(1)]
		public static DecomposeItemInfo Create()
		{
			return new DecomposeItemInfo();
		}

		// Token: 0x17001163 RID: 4451
		// (get) Token: 0x06005DA2 RID: 23970 RVA: 0x000E3218 File Offset: 0x000E1418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DecomposeItemInfo> Parser
		{
			get
			{
				return DecomposeItemInfo._parser;
			}
		}

		// Token: 0x17001164 RID: 4452
		// (get) Token: 0x06005DA3 RID: 23971 RVA: 0x000E321F File Offset: 0x000E141F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001165 RID: 4453
		// (get) Token: 0x06005DA4 RID: 23972 RVA: 0x000E3222 File Offset: 0x000E1422
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DecomposeItemInfo.Descriptor;
			}
		}

		// Token: 0x06005DA5 RID: 23973 RVA: 0x000E3229 File Offset: 0x000E1429
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DecomposeItemInfo()
		{
		}

		// Token: 0x06005DA6 RID: 23974 RVA: 0x000E3231 File Offset: 0x000E1431
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DecomposeItemInfo(DecomposeItemInfo other) : this()
		{
			this.count_ = other.count_;
			this.itemId_ = other.itemId_;
			this.incrId_ = other.incrId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005DA7 RID: 23975 RVA: 0x000E326E File Offset: 0x000E146E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DecomposeItemInfo Clone()
		{
			return new DecomposeItemInfo(this);
		}

		// Token: 0x17001166 RID: 4454
		// (get) Token: 0x06005DA8 RID: 23976 RVA: 0x000E3276 File Offset: 0x000E1476
		// (set) Token: 0x06005DA9 RID: 23977 RVA: 0x000E327E File Offset: 0x000E147E
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

		// Token: 0x17001167 RID: 4455
		// (get) Token: 0x06005DAA RID: 23978 RVA: 0x000E3287 File Offset: 0x000E1487
		// (set) Token: 0x06005DAB RID: 23979 RVA: 0x000E328F File Offset: 0x000E148F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x17001168 RID: 4456
		// (get) Token: 0x06005DAC RID: 23980 RVA: 0x000E3298 File Offset: 0x000E1498
		// (set) Token: 0x06005DAD RID: 23981 RVA: 0x000E32A0 File Offset: 0x000E14A0
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

		// Token: 0x06005DAE RID: 23982 RVA: 0x000E32A9 File Offset: 0x000E14A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DecomposeItemInfo);
		}

		// Token: 0x06005DAF RID: 23983 RVA: 0x000E32B8 File Offset: 0x000E14B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DecomposeItemInfo other)
		{
			return other != null && (other == this || (this.Count == other.Count && this.ItemId == other.ItemId && this.IncrId == other.IncrId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005DB0 RID: 23984 RVA: 0x000E3314 File Offset: 0x000E1514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.IncrId != 0)
			{
				num ^= this.IncrId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005DB1 RID: 23985 RVA: 0x000E3385 File Offset: 0x000E1585
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005DB2 RID: 23986 RVA: 0x000E3392 File Offset: 0x000E1592
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005DB3 RID: 23987 RVA: 0x000E339C File Offset: 0x000E159C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Count != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Count);
			}
			if (this.ItemId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ItemId);
			}
			if (this.IncrId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.IncrId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005DB4 RID: 23988 RVA: 0x000E3414 File Offset: 0x000E1614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.IncrId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncrId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005DB5 RID: 23989 RVA: 0x000E3484 File Offset: 0x000E1684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DecomposeItemInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.IncrId != 0)
			{
				this.IncrId = other.IncrId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005DB6 RID: 23990 RVA: 0x000E34E8 File Offset: 0x000E16E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005DB7 RID: 23991 RVA: 0x000E34F4 File Offset: 0x000E16F4
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
				if (num != 16U)
				{
					if (num != 24U)
					{
						if (num != 32U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IncrId = input.ReadInt32();
						}
					}
					else
					{
						this.ItemId = input.ReadInt32();
					}
				}
				else
				{
					this.Count = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400369A RID: 13978
		private static readonly MessageParser<DecomposeItemInfo> _parser = new MessageParser<DecomposeItemInfo>(() => new DecomposeItemInfo());

		// Token: 0x0400369B RID: 13979
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400369C RID: 13980
		public const int CountFieldNumber = 2;

		// Token: 0x0400369D RID: 13981
		private int count_;

		// Token: 0x0400369E RID: 13982
		public const int ItemIdFieldNumber = 3;

		// Token: 0x0400369F RID: 13983
		private int itemId_;

		// Token: 0x040036A0 RID: 13984
		public const int IncrIdFieldNumber = 4;

		// Token: 0x040036A1 RID: 13985
		private int incrId_;
	}
}
