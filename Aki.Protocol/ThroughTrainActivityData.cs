using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001361 RID: 4961
	public sealed class ThroughTrainActivityData : IMessage<ThroughTrainActivityData>, IMessage, IEquatable<ThroughTrainActivityData>, IDeepCloneable<ThroughTrainActivityData>, IBufferMessage
	{
		// Token: 0x0601A599 RID: 107929 RVA: 0x003D3B25 File Offset: 0x003D1D25
		[NullableContext(1)]
		public static ThroughTrainActivityData Create()
		{
			return new ThroughTrainActivityData();
		}

		// Token: 0x170058E4 RID: 22756
		// (get) Token: 0x0601A59A RID: 107930 RVA: 0x003D3B2C File Offset: 0x003D1D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170058E5 RID: 22757
		// (get) Token: 0x0601A59B RID: 107931 RVA: 0x003D3B2F File Offset: 0x003D1D2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ThroughTrainActivityData.Descriptor;
			}
		}

		// Token: 0x0601A59C RID: 107932 RVA: 0x003D3B36 File Offset: 0x003D1D36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThroughTrainActivityData()
		{
		}

		// Token: 0x0601A59D RID: 107933 RVA: 0x003D3B3E File Offset: 0x003D1D3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThroughTrainActivityData(ThroughTrainActivityData other) : this()
		{
			this.isFinish_ = other.isFinish_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A59E RID: 107934 RVA: 0x003D3B63 File Offset: 0x003D1D63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThroughTrainActivityData Clone()
		{
			return new ThroughTrainActivityData(this);
		}

		// Token: 0x170058E6 RID: 22758
		// (get) Token: 0x0601A59F RID: 107935 RVA: 0x003D3B6B File Offset: 0x003D1D6B
		// (set) Token: 0x0601A5A0 RID: 107936 RVA: 0x003D3B73 File Offset: 0x003D1D73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFinish
		{
			get
			{
				return this.isFinish_;
			}
			set
			{
				this.isFinish_ = value;
			}
		}

		// Token: 0x0601A5A1 RID: 107937 RVA: 0x003D3B7C File Offset: 0x003D1D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ThroughTrainActivityData);
		}

		// Token: 0x0601A5A2 RID: 107938 RVA: 0x003D3B8A File Offset: 0x003D1D8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ThroughTrainActivityData other)
		{
			return other != null && (other == this || (this.IsFinish == other.IsFinish && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A5A3 RID: 107939 RVA: 0x003D3BB8 File Offset: 0x003D1DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsFinish)
			{
				num ^= this.IsFinish.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A5A4 RID: 107940 RVA: 0x003D3BF7 File Offset: 0x003D1DF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A5A5 RID: 107941 RVA: 0x003D3C04 File Offset: 0x003D1E04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A5A6 RID: 107942 RVA: 0x003D3C0D File Offset: 0x003D1E0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsFinish)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsFinish);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A5A7 RID: 107943 RVA: 0x003D3C40 File Offset: 0x003D1E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsFinish)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A5A8 RID: 107944 RVA: 0x003D3C72 File Offset: 0x003D1E72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ThroughTrainActivityData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsFinish)
			{
				this.IsFinish = other.IsFinish;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A5A9 RID: 107945 RVA: 0x003D3CA3 File Offset: 0x003D1EA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A5AA RID: 107946 RVA: 0x003D3CAC File Offset: 0x003D1EAC
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
					this.IsFinish = input.ReadBool();
				}
			}
		}

		// Token: 0x0400998F RID: 39311
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009990 RID: 39312
		public const int IsFinishFieldNumber = 1;

		// Token: 0x04009991 RID: 39313
		private bool isFinish_;
	}
}
