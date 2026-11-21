using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000506 RID: 1286
	public sealed class FanComponentPb : IMessage<FanComponentPb>, IMessage, IEquatable<FanComponentPb>, IDeepCloneable<FanComponentPb>, IBufferMessage
	{
		// Token: 0x06007961 RID: 31073 RVA: 0x0012755A File Offset: 0x0012575A
		[NullableContext(1)]
		public static FanComponentPb Create()
		{
			return new FanComponentPb();
		}

		// Token: 0x17001783 RID: 6019
		// (get) Token: 0x06007962 RID: 31074 RVA: 0x00127561 File Offset: 0x00125761
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001784 RID: 6020
		// (get) Token: 0x06007963 RID: 31075 RVA: 0x00127564 File Offset: 0x00125764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FanComponentPb.Descriptor;
			}
		}

		// Token: 0x06007964 RID: 31076 RVA: 0x0012756B File Offset: 0x0012576B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FanComponentPb()
		{
		}

		// Token: 0x06007965 RID: 31077 RVA: 0x00127573 File Offset: 0x00125773
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FanComponentPb(FanComponentPb other) : this()
		{
			this.numOfTurns_ = other.numOfTurns_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007966 RID: 31078 RVA: 0x00127598 File Offset: 0x00125798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FanComponentPb Clone()
		{
			return new FanComponentPb(this);
		}

		// Token: 0x17001785 RID: 6021
		// (get) Token: 0x06007967 RID: 31079 RVA: 0x001275A0 File Offset: 0x001257A0
		// (set) Token: 0x06007968 RID: 31080 RVA: 0x001275A8 File Offset: 0x001257A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NumOfTurns
		{
			get
			{
				return this.numOfTurns_;
			}
			set
			{
				this.numOfTurns_ = value;
			}
		}

		// Token: 0x06007969 RID: 31081 RVA: 0x001275B1 File Offset: 0x001257B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FanComponentPb);
		}

		// Token: 0x0600796A RID: 31082 RVA: 0x001275BF File Offset: 0x001257BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FanComponentPb other)
		{
			return other != null && (other == this || (this.NumOfTurns == other.NumOfTurns && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600796B RID: 31083 RVA: 0x001275F0 File Offset: 0x001257F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NumOfTurns != 0)
			{
				num ^= this.NumOfTurns.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600796C RID: 31084 RVA: 0x0012762F File Offset: 0x0012582F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600796D RID: 31085 RVA: 0x0012763C File Offset: 0x0012583C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600796E RID: 31086 RVA: 0x00127645 File Offset: 0x00125845
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NumOfTurns != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.NumOfTurns);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600796F RID: 31087 RVA: 0x00127678 File Offset: 0x00125878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NumOfTurns != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NumOfTurns);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007970 RID: 31088 RVA: 0x001276B6 File Offset: 0x001258B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FanComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NumOfTurns != 0)
			{
				this.NumOfTurns = other.NumOfTurns;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007971 RID: 31089 RVA: 0x001276E7 File Offset: 0x001258E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007972 RID: 31090 RVA: 0x001276F0 File Offset: 0x001258F0
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.NumOfTurns = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003EF5 RID: 16117
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003EF6 RID: 16118
		public const int NumOfTurnsFieldNumber = 1;

		// Token: 0x04003EF7 RID: 16119
		private int numOfTurns_;
	}
}
