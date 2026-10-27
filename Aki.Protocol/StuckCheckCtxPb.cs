using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200129E RID: 4766
	public sealed class StuckCheckCtxPb : IMessage<StuckCheckCtxPb>, IMessage, IEquatable<StuckCheckCtxPb>, IDeepCloneable<StuckCheckCtxPb>, IBufferMessage
	{
		// Token: 0x060195E2 RID: 103906 RVA: 0x003AFFF8 File Offset: 0x003AE1F8
		[NullableContext(1)]
		public static StuckCheckCtxPb Create()
		{
			return new StuckCheckCtxPb();
		}

		// Token: 0x1700558C RID: 21900
		// (get) Token: 0x060195E3 RID: 103907 RVA: 0x003AFFFF File Offset: 0x003AE1FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700558D RID: 21901
		// (get) Token: 0x060195E4 RID: 103908 RVA: 0x003B0002 File Offset: 0x003AE202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StuckCheckCtxPb.Descriptor;
			}
		}

		// Token: 0x060195E5 RID: 103909 RVA: 0x003B0009 File Offset: 0x003AE209
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StuckCheckCtxPb()
		{
		}

		// Token: 0x060195E6 RID: 103910 RVA: 0x003B0014 File Offset: 0x003AE214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StuckCheckCtxPb(StuckCheckCtxPb other) : this()
		{
			this.behaviorTreeCtx_ = ((other.behaviorTreeCtx_ != null) ? other.behaviorTreeCtx_.Clone() : null);
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060195E7 RID: 103911 RVA: 0x003B0060 File Offset: 0x003AE260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StuckCheckCtxPb Clone()
		{
			return new StuckCheckCtxPb(this);
		}

		// Token: 0x1700558E RID: 21902
		// (get) Token: 0x060195E8 RID: 103912 RVA: 0x003B0068 File Offset: 0x003AE268
		// (set) Token: 0x060195E9 RID: 103913 RVA: 0x003B0070 File Offset: 0x003AE270
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

		// Token: 0x1700558F RID: 21903
		// (get) Token: 0x060195EA RID: 103914 RVA: 0x003B0079 File Offset: 0x003AE279
		// (set) Token: 0x060195EB RID: 103915 RVA: 0x003B0081 File Offset: 0x003AE281
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

		// Token: 0x060195EC RID: 103916 RVA: 0x003B008A File Offset: 0x003AE28A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StuckCheckCtxPb);
		}

		// Token: 0x060195ED RID: 103917 RVA: 0x003B0098 File Offset: 0x003AE298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StuckCheckCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.BehaviorTreeCtx, other.BehaviorTreeCtx) && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060195EE RID: 103918 RVA: 0x003B00E8 File Offset: 0x003AE2E8
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

		// Token: 0x060195EF RID: 103919 RVA: 0x003B013D File Offset: 0x003AE33D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060195F0 RID: 103920 RVA: 0x003B014A File Offset: 0x003AE34A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060195F1 RID: 103921 RVA: 0x003B0154 File Offset: 0x003AE354
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

		// Token: 0x060195F2 RID: 103922 RVA: 0x003B01B0 File Offset: 0x003AE3B0
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

		// Token: 0x060195F3 RID: 103923 RVA: 0x003B0208 File Offset: 0x003AE408
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

		// Token: 0x060195F4 RID: 103924 RVA: 0x003B0270 File Offset: 0x003AE470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060195F5 RID: 103925 RVA: 0x003B027C File Offset: 0x003AE47C
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

		// Token: 0x04009502 RID: 38146
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009503 RID: 38147
		public const int BehaviorTreeCtxFieldNumber = 1;

		// Token: 0x04009504 RID: 38148
		private BehaviorTreeCtxPb behaviorTreeCtx_;

		// Token: 0x04009505 RID: 38149
		public const int IndexFieldNumber = 2;

		// Token: 0x04009506 RID: 38150
		private int index_;
	}
}
