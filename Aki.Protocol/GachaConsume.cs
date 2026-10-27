using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200068E RID: 1678
	public sealed class GachaConsume : IMessage<GachaConsume>, IMessage, IEquatable<GachaConsume>, IDeepCloneable<GachaConsume>, IBufferMessage
	{
		// Token: 0x06009991 RID: 39313 RVA: 0x00171EA5 File Offset: 0x001700A5
		[NullableContext(1)]
		public static GachaConsume Create()
		{
			return new GachaConsume();
		}

		// Token: 0x17001EA0 RID: 7840
		// (get) Token: 0x06009992 RID: 39314 RVA: 0x00171EAC File Offset: 0x001700AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GachaConsume> Parser
		{
			get
			{
				return GachaConsume._parser;
			}
		}

		// Token: 0x17001EA1 RID: 7841
		// (get) Token: 0x06009993 RID: 39315 RVA: 0x00171EB3 File Offset: 0x001700B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001EA2 RID: 7842
		// (get) Token: 0x06009994 RID: 39316 RVA: 0x00171EB6 File Offset: 0x001700B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaConsume.Descriptor;
			}
		}

		// Token: 0x06009995 RID: 39317 RVA: 0x00171EBD File Offset: 0x001700BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaConsume()
		{
		}

		// Token: 0x06009996 RID: 39318 RVA: 0x00171EC5 File Offset: 0x001700C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaConsume(GachaConsume other) : this()
		{
			this.times_ = other.times_;
			this.consume_ = other.consume_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009997 RID: 39319 RVA: 0x00171EF6 File Offset: 0x001700F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaConsume Clone()
		{
			return new GachaConsume(this);
		}

		// Token: 0x17001EA3 RID: 7843
		// (get) Token: 0x06009998 RID: 39320 RVA: 0x00171EFE File Offset: 0x001700FE
		// (set) Token: 0x06009999 RID: 39321 RVA: 0x00171F06 File Offset: 0x00170106
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

		// Token: 0x17001EA4 RID: 7844
		// (get) Token: 0x0600999A RID: 39322 RVA: 0x00171F0F File Offset: 0x0017010F
		// (set) Token: 0x0600999B RID: 39323 RVA: 0x00171F17 File Offset: 0x00170117
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

		// Token: 0x0600999C RID: 39324 RVA: 0x00171F20 File Offset: 0x00170120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaConsume);
		}

		// Token: 0x0600999D RID: 39325 RVA: 0x00171F2E File Offset: 0x0017012E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaConsume other)
		{
			return other != null && (other == this || (this.Times == other.Times && this.Consume == other.Consume && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600999E RID: 39326 RVA: 0x00171F6C File Offset: 0x0017016C
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

		// Token: 0x0600999F RID: 39327 RVA: 0x00171FC4 File Offset: 0x001701C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060099A0 RID: 39328 RVA: 0x00171FD1 File Offset: 0x001701D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060099A1 RID: 39329 RVA: 0x00171FDC File Offset: 0x001701DC
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

		// Token: 0x060099A2 RID: 39330 RVA: 0x00172034 File Offset: 0x00170234
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

		// Token: 0x060099A3 RID: 39331 RVA: 0x0017208C File Offset: 0x0017028C
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

		// Token: 0x060099A4 RID: 39332 RVA: 0x001720DC File Offset: 0x001702DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060099A5 RID: 39333 RVA: 0x001720E8 File Offset: 0x001702E8
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

		// Token: 0x040048A0 RID: 18592
		private static readonly MessageParser<GachaConsume> _parser = new MessageParser<GachaConsume>(() => new GachaConsume());

		// Token: 0x040048A1 RID: 18593
		private UnknownFieldSet _unknownFields;

		// Token: 0x040048A2 RID: 18594
		public const int TimesFieldNumber = 1;

		// Token: 0x040048A3 RID: 18595
		private int times_;

		// Token: 0x040048A4 RID: 18596
		public const int ConsumeFieldNumber = 2;

		// Token: 0x040048A5 RID: 18597
		private int consume_;
	}
}
