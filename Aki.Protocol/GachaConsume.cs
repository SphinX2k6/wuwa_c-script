using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200067A RID: 1658
	public sealed class GachaConsume : IMessage<GachaConsume>, IMessage, IEquatable<GachaConsume>, IDeepCloneable<GachaConsume>, IBufferMessage
	{
		// Token: 0x0600983B RID: 38971 RVA: 0x0016F471 File Offset: 0x0016D671
		[NullableContext(1)]
		public static GachaConsume Create()
		{
			return new GachaConsume();
		}

		// Token: 0x17001E56 RID: 7766
		// (get) Token: 0x0600983C RID: 38972 RVA: 0x0016F478 File Offset: 0x0016D678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GachaConsume> Parser
		{
			get
			{
				return GachaConsume._parser;
			}
		}

		// Token: 0x17001E57 RID: 7767
		// (get) Token: 0x0600983D RID: 38973 RVA: 0x0016F47F File Offset: 0x0016D67F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E58 RID: 7768
		// (get) Token: 0x0600983E RID: 38974 RVA: 0x0016F482 File Offset: 0x0016D682
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaConsume.Descriptor;
			}
		}

		// Token: 0x0600983F RID: 38975 RVA: 0x0016F489 File Offset: 0x0016D689
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaConsume()
		{
		}

		// Token: 0x06009840 RID: 38976 RVA: 0x0016F491 File Offset: 0x0016D691
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaConsume(GachaConsume other) : this()
		{
			this.times_ = other.times_;
			this.consume_ = other.consume_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009841 RID: 38977 RVA: 0x0016F4C2 File Offset: 0x0016D6C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaConsume Clone()
		{
			return new GachaConsume(this);
		}

		// Token: 0x17001E59 RID: 7769
		// (get) Token: 0x06009842 RID: 38978 RVA: 0x0016F4CA File Offset: 0x0016D6CA
		// (set) Token: 0x06009843 RID: 38979 RVA: 0x0016F4D2 File Offset: 0x0016D6D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Times
		{
			get
			{
				return this.times_;
			}
			set
			{
				this.times_ = value;
			}
		}

		// Token: 0x17001E5A RID: 7770
		// (get) Token: 0x06009844 RID: 38980 RVA: 0x0016F4DB File Offset: 0x0016D6DB
		// (set) Token: 0x06009845 RID: 38981 RVA: 0x0016F4E3 File Offset: 0x0016D6E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Consume
		{
			get
			{
				return this.consume_;
			}
			set
			{
				this.consume_ = value;
			}
		}

		// Token: 0x06009846 RID: 38982 RVA: 0x0016F4EC File Offset: 0x0016D6EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaConsume);
		}

		// Token: 0x06009847 RID: 38983 RVA: 0x0016F4FA File Offset: 0x0016D6FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaConsume other)
		{
			return other != null && (other == this || (this.Times == other.Times && this.Consume == other.Consume && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009848 RID: 38984 RVA: 0x0016F538 File Offset: 0x0016D738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Times != 0)
			{
				num ^= this.Times.GetHashCode();
			}
			if (this.Consume != 0)
			{
				num ^= this.Consume.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009849 RID: 38985 RVA: 0x0016F590 File Offset: 0x0016D790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600984A RID: 38986 RVA: 0x0016F59D File Offset: 0x0016D79D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600984B RID: 38987 RVA: 0x0016F5A8 File Offset: 0x0016D7A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Times != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Times);
			}
			if (this.Consume != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Consume);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600984C RID: 38988 RVA: 0x0016F600 File Offset: 0x0016D800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Times != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Times);
			}
			if (this.Consume != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Consume);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600984D RID: 38989 RVA: 0x0016F658 File Offset: 0x0016D858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaConsume other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Times != 0)
			{
				this.Times = other.Times;
			}
			if (other.Consume != 0)
			{
				this.Consume = other.Consume;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600984E RID: 38990 RVA: 0x0016F6A8 File Offset: 0x0016D8A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600984F RID: 38991 RVA: 0x0016F6B4 File Offset: 0x0016D8B4
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
						this.Consume = input.ReadInt32();
					}
				}
				else
				{
					this.Times = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004899 RID: 18585
		private static readonly MessageParser<GachaConsume> _parser = new MessageParser<GachaConsume>(() => new GachaConsume());

		// Token: 0x0400489A RID: 18586
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400489B RID: 18587
		public const int TimesFieldNumber = 1;

		// Token: 0x0400489C RID: 18588
		private int times_;

		// Token: 0x0400489D RID: 18589
		public const int ConsumeFieldNumber = 2;

		// Token: 0x0400489E RID: 18590
		private int consume_;
	}
}
