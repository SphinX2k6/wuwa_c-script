using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000032 RID: 50
	public sealed class AbyssPluginItemInfo : IMessage<AbyssPluginItemInfo>, IMessage, IEquatable<AbyssPluginItemInfo>, IDeepCloneable<AbyssPluginItemInfo>, IBufferMessage
	{
		// Token: 0x060012A6 RID: 4774 RVA: 0x000332F5 File Offset: 0x000314F5
		[NullableContext(1)]
		public static AbyssPluginItemInfo Create()
		{
			return new AbyssPluginItemInfo();
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060012A7 RID: 4775 RVA: 0x000332FC File Offset: 0x000314FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AbyssPluginItemInfo> Parser
		{
			get
			{
				return AbyssPluginItemInfo._parser;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060012A8 RID: 4776 RVA: 0x00033303 File Offset: 0x00031503
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060012A9 RID: 4777 RVA: 0x00033306 File Offset: 0x00031506
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssPluginItemInfo.Descriptor;
			}
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x0003330D File Offset: 0x0003150D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginItemInfo()
		{
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x00033318 File Offset: 0x00031518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginItemInfo(AbyssPluginItemInfo other) : this()
		{
			this.itemId_ = other.itemId_;
			this.count_ = other.count_;
			this.incrId_ = other.incrId_;
			this.funcValue_ = other.funcValue_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x0003336C File Offset: 0x0003156C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginItemInfo Clone()
		{
			return new AbyssPluginItemInfo(this);
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060012AD RID: 4781 RVA: 0x00033374 File Offset: 0x00031574
		// (set) Token: 0x060012AE RID: 4782 RVA: 0x0003337C File Offset: 0x0003157C
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

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060012AF RID: 4783 RVA: 0x00033385 File Offset: 0x00031585
		// (set) Token: 0x060012B0 RID: 4784 RVA: 0x0003338D File Offset: 0x0003158D
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

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060012B1 RID: 4785 RVA: 0x00033396 File Offset: 0x00031596
		// (set) Token: 0x060012B2 RID: 4786 RVA: 0x0003339E File Offset: 0x0003159E
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

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060012B3 RID: 4787 RVA: 0x000333A7 File Offset: 0x000315A7
		// (set) Token: 0x060012B4 RID: 4788 RVA: 0x000333AF File Offset: 0x000315AF
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

		// Token: 0x060012B5 RID: 4789 RVA: 0x000333B8 File Offset: 0x000315B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssPluginItemInfo);
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x000333C8 File Offset: 0x000315C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssPluginItemInfo other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.Count == other.Count && this.IncrId == other.IncrId && this.FuncValue == other.FuncValue && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x00033434 File Offset: 0x00031634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
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

		// Token: 0x060012B8 RID: 4792 RVA: 0x000334BE File Offset: 0x000316BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x000334CB File Offset: 0x000316CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x000334D4 File Offset: 0x000316D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Count);
			}
			if (this.IncrId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.IncrId);
			}
			if (this.FuncValue != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.FuncValue);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x00033564 File Offset: 0x00031764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
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

		// Token: 0x060012BC RID: 4796 RVA: 0x000335EC File Offset: 0x000317EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssPluginItemInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
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

		// Token: 0x060012BD RID: 4797 RVA: 0x00033664 File Offset: 0x00031864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x00033670 File Offset: 0x00031870
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.ItemId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Count = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.IncrId = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.FuncValue = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002024 RID: 8228
		private static readonly MessageParser<AbyssPluginItemInfo> _parser = new MessageParser<AbyssPluginItemInfo>(() => new AbyssPluginItemInfo());

		// Token: 0x04002025 RID: 8229
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002026 RID: 8230
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04002027 RID: 8231
		private int itemId_;

		// Token: 0x04002028 RID: 8232
		public const int CountFieldNumber = 2;

		// Token: 0x04002029 RID: 8233
		private int count_;

		// Token: 0x0400202A RID: 8234
		public const int IncrIdFieldNumber = 3;

		// Token: 0x0400202B RID: 8235
		private int incrId_;

		// Token: 0x0400202C RID: 8236
		public const int FuncValueFieldNumber = 4;

		// Token: 0x0400202D RID: 8237
		private int funcValue_;
	}
}
