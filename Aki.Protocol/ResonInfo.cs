using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F2D RID: 3885
	public sealed class ResonInfo : IMessage<ResonInfo>, IMessage, IEquatable<ResonInfo>, IDeepCloneable<ResonInfo>, IBufferMessage
	{
		// Token: 0x06014C94 RID: 85140 RVA: 0x00303EF7 File Offset: 0x003020F7
		[NullableContext(1)]
		public static ResonInfo Create()
		{
			return new ResonInfo();
		}

		// Token: 0x17004513 RID: 17683
		// (get) Token: 0x06014C95 RID: 85141 RVA: 0x00303EFE File Offset: 0x003020FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ResonInfo> Parser
		{
			get
			{
				return ResonInfo._parser;
			}
		}

		// Token: 0x17004514 RID: 17684
		// (get) Token: 0x06014C96 RID: 85142 RVA: 0x00303F05 File Offset: 0x00302105
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004515 RID: 17685
		// (get) Token: 0x06014C97 RID: 85143 RVA: 0x00303F08 File Offset: 0x00302108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ResonInfo.Descriptor;
			}
		}

		// Token: 0x06014C98 RID: 85144 RVA: 0x00303F0F File Offset: 0x0030210F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResonInfo()
		{
		}

		// Token: 0x06014C99 RID: 85145 RVA: 0x00303F17 File Offset: 0x00302117
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResonInfo(ResonInfo other) : this()
		{
			this.resonId_ = other.resonId_;
			this.isOpen_ = other.isOpen_;
			this.increase_ = other.increase_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014C9A RID: 85146 RVA: 0x00303F54 File Offset: 0x00302154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResonInfo Clone()
		{
			return new ResonInfo(this);
		}

		// Token: 0x17004516 RID: 17686
		// (get) Token: 0x06014C9B RID: 85147 RVA: 0x00303F5C File Offset: 0x0030215C
		// (set) Token: 0x06014C9C RID: 85148 RVA: 0x00303F64 File Offset: 0x00302164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ResonId
		{
			get
			{
				return this.resonId_;
			}
			set
			{
				this.resonId_ = value;
			}
		}

		// Token: 0x17004517 RID: 17687
		// (get) Token: 0x06014C9D RID: 85149 RVA: 0x00303F6D File Offset: 0x0030216D
		// (set) Token: 0x06014C9E RID: 85150 RVA: 0x00303F75 File Offset: 0x00302175
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsOpen
		{
			get
			{
				return this.isOpen_;
			}
			set
			{
				this.isOpen_ = value;
			}
		}

		// Token: 0x17004518 RID: 17688
		// (get) Token: 0x06014C9F RID: 85151 RVA: 0x00303F7E File Offset: 0x0030217E
		// (set) Token: 0x06014CA0 RID: 85152 RVA: 0x00303F86 File Offset: 0x00302186
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Increase
		{
			get
			{
				return this.increase_;
			}
			set
			{
				this.increase_ = value;
			}
		}

		// Token: 0x06014CA1 RID: 85153 RVA: 0x00303F8F File Offset: 0x0030218F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ResonInfo);
		}

		// Token: 0x06014CA2 RID: 85154 RVA: 0x00303FA0 File Offset: 0x003021A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ResonInfo other)
		{
			return other != null && (other == this || (this.ResonId == other.ResonId && this.IsOpen == other.IsOpen && this.Increase == other.Increase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014CA3 RID: 85155 RVA: 0x00303FFC File Offset: 0x003021FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ResonId != 0)
			{
				num ^= this.ResonId.GetHashCode();
			}
			if (this.IsOpen)
			{
				num ^= this.IsOpen.GetHashCode();
			}
			if (this.Increase != 0)
			{
				num ^= this.Increase.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014CA4 RID: 85156 RVA: 0x0030406D File Offset: 0x0030226D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014CA5 RID: 85157 RVA: 0x0030407A File Offset: 0x0030227A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014CA6 RID: 85158 RVA: 0x00304084 File Offset: 0x00302284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ResonId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ResonId);
			}
			if (this.IsOpen)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsOpen);
			}
			if (this.Increase != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Increase);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014CA7 RID: 85159 RVA: 0x003040F8 File Offset: 0x003022F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ResonId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ResonId);
			}
			if (this.IsOpen)
			{
				num += 2;
			}
			if (this.Increase != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Increase);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014CA8 RID: 85160 RVA: 0x0030415C File Offset: 0x0030235C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ResonInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ResonId != 0)
			{
				this.ResonId = other.ResonId;
			}
			if (other.IsOpen)
			{
				this.IsOpen = other.IsOpen;
			}
			if (other.Increase != 0)
			{
				this.Increase = other.Increase;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014CA9 RID: 85161 RVA: 0x003041C0 File Offset: 0x003023C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014CAA RID: 85162 RVA: 0x003041CC File Offset: 0x003023CC
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
							this.Increase = input.ReadInt32();
						}
					}
					else
					{
						this.IsOpen = input.ReadBool();
					}
				}
				else
				{
					this.ResonId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007D71 RID: 32113
		private static readonly MessageParser<ResonInfo> _parser = new MessageParser<ResonInfo>(() => new ResonInfo());

		// Token: 0x04007D72 RID: 32114
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D73 RID: 32115
		public const int ResonIdFieldNumber = 1;

		// Token: 0x04007D74 RID: 32116
		private int resonId_;

		// Token: 0x04007D75 RID: 32117
		public const int IsOpenFieldNumber = 2;

		// Token: 0x04007D76 RID: 32118
		private bool isOpen_;

		// Token: 0x04007D77 RID: 32119
		public const int IncreaseFieldNumber = 3;

		// Token: 0x04007D78 RID: 32120
		private int increase_;
	}
}
