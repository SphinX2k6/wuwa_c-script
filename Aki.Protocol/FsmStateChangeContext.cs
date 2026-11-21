using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200065F RID: 1631
	public sealed class FsmStateChangeContext : IMessage<FsmStateChangeContext>, IMessage, IEquatable<FsmStateChangeContext>, IDeepCloneable<FsmStateChangeContext>, IBufferMessage
	{
		// Token: 0x0600960D RID: 38413 RVA: 0x0016A86E File Offset: 0x00168A6E
		[NullableContext(1)]
		public static FsmStateChangeContext Create()
		{
			return new FsmStateChangeContext();
		}

		// Token: 0x17001DDF RID: 7647
		// (get) Token: 0x0600960E RID: 38414 RVA: 0x0016A875 File Offset: 0x00168A75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001DE0 RID: 7648
		// (get) Token: 0x0600960F RID: 38415 RVA: 0x0016A878 File Offset: 0x00168A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FsmStateChangeContext.Descriptor;
			}
		}

		// Token: 0x06009610 RID: 38416 RVA: 0x0016A87F File Offset: 0x00168A7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmStateChangeContext()
		{
		}

		// Token: 0x06009611 RID: 38417 RVA: 0x0016A888 File Offset: 0x00168A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmStateChangeContext(FsmStateChangeContext other) : this()
		{
			this.fsmId_ = other.fsmId_;
			this.state_ = other.state_;
			this.changeType_ = other.changeType_;
			this.index_ = other.index_;
			this.contextId_ = other.contextId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009612 RID: 38418 RVA: 0x0016A8E8 File Offset: 0x00168AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmStateChangeContext Clone()
		{
			return new FsmStateChangeContext(this);
		}

		// Token: 0x17001DE1 RID: 7649
		// (get) Token: 0x06009613 RID: 38419 RVA: 0x0016A8F0 File Offset: 0x00168AF0
		// (set) Token: 0x06009614 RID: 38420 RVA: 0x0016A8F8 File Offset: 0x00168AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FsmId
		{
			get
			{
				return this.fsmId_;
			}
			set
			{
				this.fsmId_ = value;
			}
		}

		// Token: 0x17001DE2 RID: 7650
		// (get) Token: 0x06009615 RID: 38421 RVA: 0x0016A901 File Offset: 0x00168B01
		// (set) Token: 0x06009616 RID: 38422 RVA: 0x0016A909 File Offset: 0x00168B09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x17001DE3 RID: 7651
		// (get) Token: 0x06009617 RID: 38423 RVA: 0x0016A912 File Offset: 0x00168B12
		// (set) Token: 0x06009618 RID: 38424 RVA: 0x0016A91A File Offset: 0x00168B1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EEntityFsmChangeType ChangeType
		{
			get
			{
				return this.changeType_;
			}
			set
			{
				this.changeType_ = value;
			}
		}

		// Token: 0x17001DE4 RID: 7652
		// (get) Token: 0x06009619 RID: 38425 RVA: 0x0016A923 File Offset: 0x00168B23
		// (set) Token: 0x0600961A RID: 38426 RVA: 0x0016A92B File Offset: 0x00168B2B
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

		// Token: 0x17001DE5 RID: 7653
		// (get) Token: 0x0600961B RID: 38427 RVA: 0x0016A934 File Offset: 0x00168B34
		// (set) Token: 0x0600961C RID: 38428 RVA: 0x0016A93C File Offset: 0x00168B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ContextId
		{
			get
			{
				return this.contextId_;
			}
			set
			{
				this.contextId_ = value;
			}
		}

		// Token: 0x0600961D RID: 38429 RVA: 0x0016A945 File Offset: 0x00168B45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FsmStateChangeContext);
		}

		// Token: 0x0600961E RID: 38430 RVA: 0x0016A954 File Offset: 0x00168B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FsmStateChangeContext other)
		{
			return other != null && (other == this || (this.FsmId == other.FsmId && this.State == other.State && this.ChangeType == other.ChangeType && this.Index == other.Index && this.ContextId == other.ContextId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600961F RID: 38431 RVA: 0x0016A9D0 File Offset: 0x00168BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FsmId != 0)
			{
				num ^= this.FsmId.GetHashCode();
			}
			if (this.State != 0)
			{
				num ^= this.State.GetHashCode();
			}
			if (this.ChangeType != EEntityFsmChangeType.Enter)
			{
				num ^= this.ChangeType.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.ContextId != 0L)
			{
				num ^= this.ContextId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009620 RID: 38432 RVA: 0x0016AA79 File Offset: 0x00168C79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009621 RID: 38433 RVA: 0x0016AA86 File Offset: 0x00168C86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009622 RID: 38434 RVA: 0x0016AA90 File Offset: 0x00168C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FsmId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.FsmId);
			}
			if (this.State != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.State);
			}
			if (this.ChangeType != EEntityFsmChangeType.Enter)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ChangeType);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Index);
			}
			if (this.ContextId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.ContextId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009623 RID: 38435 RVA: 0x0016AB3C File Offset: 0x00168D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FsmId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FsmId);
			}
			if (this.State != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.State);
			}
			if (this.ChangeType != EEntityFsmChangeType.Enter)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ChangeType);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this.ContextId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ContextId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009624 RID: 38436 RVA: 0x0016ABDC File Offset: 0x00168DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FsmStateChangeContext other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FsmId != 0)
			{
				this.FsmId = other.FsmId;
			}
			if (other.State != 0)
			{
				this.State = other.State;
			}
			if (other.ChangeType != EEntityFsmChangeType.Enter)
			{
				this.ChangeType = other.ChangeType;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			if (other.ContextId != 0L)
			{
				this.ContextId = other.ContextId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009625 RID: 38437 RVA: 0x0016AC68 File Offset: 0x00168E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009626 RID: 38438 RVA: 0x0016AC74 File Offset: 0x00168E74
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.FsmId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.State = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.ChangeType = (EEntityFsmChangeType)input.ReadEnum();
						continue;
					}
					if (num == 32U)
					{
						this.Index = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.ContextId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040047F3 RID: 18419
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047F4 RID: 18420
		public const int FsmIdFieldNumber = 1;

		// Token: 0x040047F5 RID: 18421
		private int fsmId_;

		// Token: 0x040047F6 RID: 18422
		public const int StateFieldNumber = 2;

		// Token: 0x040047F7 RID: 18423
		private int state_;

		// Token: 0x040047F8 RID: 18424
		public const int ChangeTypeFieldNumber = 3;

		// Token: 0x040047F9 RID: 18425
		private EEntityFsmChangeType changeType_;

		// Token: 0x040047FA RID: 18426
		public const int IndexFieldNumber = 4;

		// Token: 0x040047FB RID: 18427
		private int index_;

		// Token: 0x040047FC RID: 18428
		public const int ContextIdFieldNumber = 5;

		// Token: 0x040047FD RID: 18429
		private long contextId_;
	}
}
