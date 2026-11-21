using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013D4 RID: 5076
	public sealed class ThroughTrainActivityData : IMessage<ThroughTrainActivityData>, IMessage, IEquatable<ThroughTrainActivityData>, IDeepCloneable<ThroughTrainActivityData>, IBufferMessage
	{
		// Token: 0x0601B022 RID: 110626 RVA: 0x003EED31 File Offset: 0x003ECF31
		[NullableContext(1)]
		public static ThroughTrainActivityData Create()
		{
			return new ThroughTrainActivityData();
		}

		// Token: 0x17005B78 RID: 23416
		// (get) Token: 0x0601B023 RID: 110627 RVA: 0x003EED38 File Offset: 0x003ECF38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B79 RID: 23417
		// (get) Token: 0x0601B024 RID: 110628 RVA: 0x003EED3B File Offset: 0x003ECF3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ThroughTrainActivityData.Descriptor;
			}
		}

		// Token: 0x0601B025 RID: 110629 RVA: 0x003EED42 File Offset: 0x003ECF42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThroughTrainActivityData()
		{
		}

		// Token: 0x0601B026 RID: 110630 RVA: 0x003EED4A File Offset: 0x003ECF4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThroughTrainActivityData(ThroughTrainActivityData other) : this()
		{
			this.isFinish_ = other.isFinish_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B027 RID: 110631 RVA: 0x003EED6F File Offset: 0x003ECF6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThroughTrainActivityData Clone()
		{
			return new ThroughTrainActivityData(this);
		}

		// Token: 0x17005B7A RID: 23418
		// (get) Token: 0x0601B028 RID: 110632 RVA: 0x003EED77 File Offset: 0x003ECF77
		// (set) Token: 0x0601B029 RID: 110633 RVA: 0x003EED7F File Offset: 0x003ECF7F
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

		// Token: 0x0601B02A RID: 110634 RVA: 0x003EED88 File Offset: 0x003ECF88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ThroughTrainActivityData);
		}

		// Token: 0x0601B02B RID: 110635 RVA: 0x003EED96 File Offset: 0x003ECF96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ThroughTrainActivityData other)
		{
			return other != null && (other == this || (this.IsFinish == other.IsFinish && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B02C RID: 110636 RVA: 0x003EEDC4 File Offset: 0x003ECFC4
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

		// Token: 0x0601B02D RID: 110637 RVA: 0x003EEE03 File Offset: 0x003ED003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B02E RID: 110638 RVA: 0x003EEE10 File Offset: 0x003ED010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B02F RID: 110639 RVA: 0x003EEE19 File Offset: 0x003ED019
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

		// Token: 0x0601B030 RID: 110640 RVA: 0x003EEE4C File Offset: 0x003ED04C
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

		// Token: 0x0601B031 RID: 110641 RVA: 0x003EEE7E File Offset: 0x003ED07E
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

		// Token: 0x0601B032 RID: 110642 RVA: 0x003EEEAF File Offset: 0x003ED0AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B033 RID: 110643 RVA: 0x003EEEB8 File Offset: 0x003ED0B8
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

		// Token: 0x04009DD4 RID: 40404
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009DD5 RID: 40405
		public const int IsFinishFieldNumber = 1;

		// Token: 0x04009DD6 RID: 40406
		private bool isFinish_;
	}
}
