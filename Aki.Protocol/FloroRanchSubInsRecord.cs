using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005E9 RID: 1513
	public sealed class FloroRanchSubInsRecord : IMessage<FloroRanchSubInsRecord>, IMessage, IEquatable<FloroRanchSubInsRecord>, IDeepCloneable<FloroRanchSubInsRecord>, IBufferMessage
	{
		// Token: 0x06008C00 RID: 35840 RVA: 0x00152C1E File Offset: 0x00150E1E
		[NullableContext(1)]
		public static FloroRanchSubInsRecord Create()
		{
			return new FloroRanchSubInsRecord();
		}

		// Token: 0x17001BAD RID: 7085
		// (get) Token: 0x06008C01 RID: 35841 RVA: 0x00152C25 File Offset: 0x00150E25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FloroRanchSubInsRecord> Parser
		{
			get
			{
				return FloroRanchSubInsRecord._parser;
			}
		}

		// Token: 0x17001BAE RID: 7086
		// (get) Token: 0x06008C02 RID: 35842 RVA: 0x00152C2C File Offset: 0x00150E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001BAF RID: 7087
		// (get) Token: 0x06008C03 RID: 35843 RVA: 0x00152C2F File Offset: 0x00150E2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchSubInsRecord.Descriptor;
			}
		}

		// Token: 0x06008C04 RID: 35844 RVA: 0x00152C36 File Offset: 0x00150E36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchSubInsRecord()
		{
		}

		// Token: 0x06008C05 RID: 35845 RVA: 0x00152C3E File Offset: 0x00150E3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchSubInsRecord(FloroRanchSubInsRecord other) : this()
		{
			this.subInsId_ = other.subInsId_;
			this.maxDay_ = other.maxDay_;
			this.maxCoin_ = other.maxCoin_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008C06 RID: 35846 RVA: 0x00152C7B File Offset: 0x00150E7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchSubInsRecord Clone()
		{
			return new FloroRanchSubInsRecord(this);
		}

		// Token: 0x17001BB0 RID: 7088
		// (get) Token: 0x06008C07 RID: 35847 RVA: 0x00152C83 File Offset: 0x00150E83
		// (set) Token: 0x06008C08 RID: 35848 RVA: 0x00152C8B File Offset: 0x00150E8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SubInsId
		{
			get
			{
				return this.subInsId_;
			}
			set
			{
				this.subInsId_ = value;
			}
		}

		// Token: 0x17001BB1 RID: 7089
		// (get) Token: 0x06008C09 RID: 35849 RVA: 0x00152C94 File Offset: 0x00150E94
		// (set) Token: 0x06008C0A RID: 35850 RVA: 0x00152C9C File Offset: 0x00150E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxDay
		{
			get
			{
				return this.maxDay_;
			}
			set
			{
				this.maxDay_ = value;
			}
		}

		// Token: 0x17001BB2 RID: 7090
		// (get) Token: 0x06008C0B RID: 35851 RVA: 0x00152CA5 File Offset: 0x00150EA5
		// (set) Token: 0x06008C0C RID: 35852 RVA: 0x00152CAD File Offset: 0x00150EAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long MaxCoin
		{
			get
			{
				return this.maxCoin_;
			}
			set
			{
				this.maxCoin_ = value;
			}
		}

		// Token: 0x06008C0D RID: 35853 RVA: 0x00152CB6 File Offset: 0x00150EB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchSubInsRecord);
		}

		// Token: 0x06008C0E RID: 35854 RVA: 0x00152CC4 File Offset: 0x00150EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchSubInsRecord other)
		{
			return other != null && (other == this || (this.SubInsId == other.SubInsId && this.MaxDay == other.MaxDay && this.MaxCoin == other.MaxCoin && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008C0F RID: 35855 RVA: 0x00152D20 File Offset: 0x00150F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SubInsId != 0)
			{
				num ^= this.SubInsId.GetHashCode();
			}
			if (this.MaxDay != 0)
			{
				num ^= this.MaxDay.GetHashCode();
			}
			if (this.MaxCoin != 0L)
			{
				num ^= this.MaxCoin.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008C10 RID: 35856 RVA: 0x00152D91 File Offset: 0x00150F91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008C11 RID: 35857 RVA: 0x00152D9E File Offset: 0x00150F9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008C12 RID: 35858 RVA: 0x00152DA8 File Offset: 0x00150FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubInsId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SubInsId);
			}
			if (this.MaxDay != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.MaxDay);
			}
			if (this.MaxCoin != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.MaxCoin);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008C13 RID: 35859 RVA: 0x00152E1C File Offset: 0x0015101C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SubInsId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubInsId);
			}
			if (this.MaxDay != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxDay);
			}
			if (this.MaxCoin != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.MaxCoin);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008C14 RID: 35860 RVA: 0x00152E8C File Offset: 0x0015108C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchSubInsRecord other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SubInsId != 0)
			{
				this.SubInsId = other.SubInsId;
			}
			if (other.MaxDay != 0)
			{
				this.MaxDay = other.MaxDay;
			}
			if (other.MaxCoin != 0L)
			{
				this.MaxCoin = other.MaxCoin;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008C15 RID: 35861 RVA: 0x00152EF0 File Offset: 0x001510F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008C16 RID: 35862 RVA: 0x00152EFC File Offset: 0x001510FC
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.MaxCoin = input.ReadInt64();
						}
					}
					else
					{
						this.MaxDay = input.ReadInt32();
					}
				}
				else
				{
					this.SubInsId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004499 RID: 17561
		private static readonly MessageParser<FloroRanchSubInsRecord> _parser = new MessageParser<FloroRanchSubInsRecord>(() => new FloroRanchSubInsRecord());

		// Token: 0x0400449A RID: 17562
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400449B RID: 17563
		public const int SubInsIdFieldNumber = 1;

		// Token: 0x0400449C RID: 17564
		private int subInsId_;

		// Token: 0x0400449D RID: 17565
		public const int MaxDayFieldNumber = 2;

		// Token: 0x0400449E RID: 17566
		private int maxDay_;

		// Token: 0x0400449F RID: 17567
		public const int MaxCoinFieldNumber = 3;

		// Token: 0x040044A0 RID: 17568
		private long maxCoin_;
	}
}
