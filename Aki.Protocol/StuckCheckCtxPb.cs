using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200130D RID: 4877
	public sealed class StuckCheckCtxPb : IMessage<StuckCheckCtxPb>, IMessage, IEquatable<StuckCheckCtxPb>, IDeepCloneable<StuckCheckCtxPb>, IBufferMessage
	{
		// Token: 0x0601A018 RID: 106520 RVA: 0x003CA728 File Offset: 0x003C8928
		[NullableContext(1)]
		public static StuckCheckCtxPb Create()
		{
			return new StuckCheckCtxPb();
		}

		// Token: 0x1700580D RID: 22541
		// (get) Token: 0x0601A019 RID: 106521 RVA: 0x003CA72F File Offset: 0x003C892F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700580E RID: 22542
		// (get) Token: 0x0601A01A RID: 106522 RVA: 0x003CA732 File Offset: 0x003C8932
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StuckCheckCtxPb.Descriptor;
			}
		}

		// Token: 0x0601A01B RID: 106523 RVA: 0x003CA739 File Offset: 0x003C8939
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StuckCheckCtxPb()
		{
		}

		// Token: 0x0601A01C RID: 106524 RVA: 0x003CA744 File Offset: 0x003C8944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StuckCheckCtxPb(StuckCheckCtxPb other) : this()
		{
			this.behaviorTreeCtx_ = ((other.behaviorTreeCtx_ != null) ? other.behaviorTreeCtx_.Clone() : null);
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A01D RID: 106525 RVA: 0x003CA790 File Offset: 0x003C8990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StuckCheckCtxPb Clone()
		{
			return new StuckCheckCtxPb(this);
		}

		// Token: 0x1700580F RID: 22543
		// (get) Token: 0x0601A01E RID: 106526 RVA: 0x003CA798 File Offset: 0x003C8998
		// (set) Token: 0x0601A01F RID: 106527 RVA: 0x003CA7A0 File Offset: 0x003C89A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BehaviorTreeCtxPb BehaviorTreeCtx
		{
			get
			{
				return this.behaviorTreeCtx_;
			}
			set
			{
				this.behaviorTreeCtx_ = value;
			}
		}

		// Token: 0x17005810 RID: 22544
		// (get) Token: 0x0601A020 RID: 106528 RVA: 0x003CA7A9 File Offset: 0x003C89A9
		// (set) Token: 0x0601A021 RID: 106529 RVA: 0x003CA7B1 File Offset: 0x003C89B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x0601A022 RID: 106530 RVA: 0x003CA7BA File Offset: 0x003C89BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StuckCheckCtxPb);
		}

		// Token: 0x0601A023 RID: 106531 RVA: 0x003CA7C8 File Offset: 0x003C89C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StuckCheckCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.BehaviorTreeCtx, other.BehaviorTreeCtx) && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A024 RID: 106532 RVA: 0x003CA818 File Offset: 0x003C8A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.behaviorTreeCtx_ != null)
			{
				num ^= this.BehaviorTreeCtx.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A025 RID: 106533 RVA: 0x003CA86D File Offset: 0x003C8A6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A026 RID: 106534 RVA: 0x003CA87A File Offset: 0x003C8A7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A027 RID: 106535 RVA: 0x003CA884 File Offset: 0x003C8A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.behaviorTreeCtx_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.BehaviorTreeCtx);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A028 RID: 106536 RVA: 0x003CA8E0 File Offset: 0x003C8AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.behaviorTreeCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BehaviorTreeCtx);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A029 RID: 106537 RVA: 0x003CA938 File Offset: 0x003C8B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StuckCheckCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.behaviorTreeCtx_ != null)
			{
				if (this.behaviorTreeCtx_ == null)
				{
					this.BehaviorTreeCtx = new BehaviorTreeCtxPb();
				}
				this.BehaviorTreeCtx.MergeFrom(other.BehaviorTreeCtx);
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A02A RID: 106538 RVA: 0x003CA9A0 File Offset: 0x003C8BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A02B RID: 106539 RVA: 0x003CA9AC File Offset: 0x003C8BAC
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
				if (num != 10U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Index = input.ReadInt32();
					}
				}
				else
				{
					if (this.behaviorTreeCtx_ == null)
					{
						this.BehaviorTreeCtx = new BehaviorTreeCtxPb();
					}
					input.ReadMessage(this.BehaviorTreeCtx);
				}
			}
		}

		// Token: 0x0400992C RID: 39212
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400992D RID: 39213
		public const int BehaviorTreeCtxFieldNumber = 1;

		// Token: 0x0400992E RID: 39214
		private BehaviorTreeCtxPb behaviorTreeCtx_;

		// Token: 0x0400992F RID: 39215
		public const int IndexFieldNumber = 2;

		// Token: 0x04009930 RID: 39216
		private int index_;
	}
}
