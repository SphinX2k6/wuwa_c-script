using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E4C RID: 3660
	public sealed class RacingBetsChangeHighData : IMessage<RacingBetsChangeHighData>, IMessage, IEquatable<RacingBetsChangeHighData>, IDeepCloneable<RacingBetsChangeHighData>, IBufferMessage
	{
		// Token: 0x06013A6E RID: 80494 RVA: 0x002DB761 File Offset: 0x002D9961
		[NullableContext(1)]
		public static RacingBetsChangeHighData Create()
		{
			return new RacingBetsChangeHighData();
		}

		// Token: 0x17004138 RID: 16696
		// (get) Token: 0x06013A6F RID: 80495 RVA: 0x002DB768 File Offset: 0x002D9968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RacingBetsChangeHighData> Parser
		{
			get
			{
				return RacingBetsChangeHighData._parser;
			}
		}

		// Token: 0x17004139 RID: 16697
		// (get) Token: 0x06013A70 RID: 80496 RVA: 0x002DB76F File Offset: 0x002D996F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700413A RID: 16698
		// (get) Token: 0x06013A71 RID: 80497 RVA: 0x002DB772 File Offset: 0x002D9972
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsChangeHighData.Descriptor;
			}
		}

		// Token: 0x06013A72 RID: 80498 RVA: 0x002DB779 File Offset: 0x002D9979
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsChangeHighData()
		{
		}

		// Token: 0x06013A73 RID: 80499 RVA: 0x002DB781 File Offset: 0x002D9981
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsChangeHighData(RacingBetsChangeHighData other) : this()
		{
			this.dangoId_ = other.dangoId_;
			this.high_ = other.high_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013A74 RID: 80500 RVA: 0x002DB7B2 File Offset: 0x002D99B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsChangeHighData Clone()
		{
			return new RacingBetsChangeHighData(this);
		}

		// Token: 0x1700413B RID: 16699
		// (get) Token: 0x06013A75 RID: 80501 RVA: 0x002DB7BA File Offset: 0x002D99BA
		// (set) Token: 0x06013A76 RID: 80502 RVA: 0x002DB7C2 File Offset: 0x002D99C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DangoId
		{
			get
			{
				return this.dangoId_;
			}
			set
			{
				this.dangoId_ = value;
			}
		}

		// Token: 0x1700413C RID: 16700
		// (get) Token: 0x06013A77 RID: 80503 RVA: 0x002DB7CB File Offset: 0x002D99CB
		// (set) Token: 0x06013A78 RID: 80504 RVA: 0x002DB7D3 File Offset: 0x002D99D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int High
		{
			get
			{
				return this.high_;
			}
			set
			{
				this.high_ = value;
			}
		}

		// Token: 0x06013A79 RID: 80505 RVA: 0x002DB7DC File Offset: 0x002D99DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsChangeHighData);
		}

		// Token: 0x06013A7A RID: 80506 RVA: 0x002DB7EA File Offset: 0x002D99EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsChangeHighData other)
		{
			return other != null && (other == this || (this.DangoId == other.DangoId && this.High == other.High && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013A7B RID: 80507 RVA: 0x002DB828 File Offset: 0x002D9A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DangoId != 0)
			{
				num ^= this.DangoId.GetHashCode();
			}
			if (this.High != 0)
			{
				num ^= this.High.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013A7C RID: 80508 RVA: 0x002DB880 File Offset: 0x002D9A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013A7D RID: 80509 RVA: 0x002DB88D File Offset: 0x002D9A8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013A7E RID: 80510 RVA: 0x002DB898 File Offset: 0x002D9A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DangoId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.DangoId);
			}
			if (this.High != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.High);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013A7F RID: 80511 RVA: 0x002DB8F0 File Offset: 0x002D9AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DangoId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DangoId);
			}
			if (this.High != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.High);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013A80 RID: 80512 RVA: 0x002DB948 File Offset: 0x002D9B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsChangeHighData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DangoId != 0)
			{
				this.DangoId = other.DangoId;
			}
			if (other.High != 0)
			{
				this.High = other.High;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013A81 RID: 80513 RVA: 0x002DB998 File Offset: 0x002D9B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013A82 RID: 80514 RVA: 0x002DB9A4 File Offset: 0x002D9BA4
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
						this.High = input.ReadInt32();
					}
				}
				else
				{
					this.DangoId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400784A RID: 30794
		private static readonly MessageParser<RacingBetsChangeHighData> _parser = new MessageParser<RacingBetsChangeHighData>(() => new RacingBetsChangeHighData());

		// Token: 0x0400784B RID: 30795
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400784C RID: 30796
		public const int DangoIdFieldNumber = 1;

		// Token: 0x0400784D RID: 30797
		private int dangoId_;

		// Token: 0x0400784E RID: 30798
		public const int HighFieldNumber = 2;

		// Token: 0x0400784F RID: 30799
		private int high_;
	}
}
