using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D77 RID: 3447
	public sealed class PlayEnterOrExitPollutionRangeCtxPb : IMessage<PlayEnterOrExitPollutionRangeCtxPb>, IMessage, IEquatable<PlayEnterOrExitPollutionRangeCtxPb>, IDeepCloneable<PlayEnterOrExitPollutionRangeCtxPb>, IBufferMessage
	{
		// Token: 0x0601294C RID: 76108 RVA: 0x002B5C80 File Offset: 0x002B3E80
		[NullableContext(1)]
		public static PlayEnterOrExitPollutionRangeCtxPb Create()
		{
			return new PlayEnterOrExitPollutionRangeCtxPb();
		}

		// Token: 0x17003D97 RID: 15767
		// (get) Token: 0x0601294D RID: 76109 RVA: 0x002B5C87 File Offset: 0x002B3E87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D98 RID: 15768
		// (get) Token: 0x0601294E RID: 76110 RVA: 0x002B5C8A File Offset: 0x002B3E8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayEnterOrExitPollutionRangeCtxPb.Descriptor;
			}
		}

		// Token: 0x0601294F RID: 76111 RVA: 0x002B5C91 File Offset: 0x002B3E91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayEnterOrExitPollutionRangeCtxPb()
		{
		}

		// Token: 0x06012950 RID: 76112 RVA: 0x002B5C9C File Offset: 0x002B3E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayEnterOrExitPollutionRangeCtxPb(PlayEnterOrExitPollutionRangeCtxPb other) : this()
		{
			this.rangeType_ = other.rangeType_;
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012951 RID: 76113 RVA: 0x002B5CE8 File Offset: 0x002B3EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayEnterOrExitPollutionRangeCtxPb Clone()
		{
			return new PlayEnterOrExitPollutionRangeCtxPb(this);
		}

		// Token: 0x17003D99 RID: 15769
		// (get) Token: 0x06012952 RID: 76114 RVA: 0x002B5CF0 File Offset: 0x002B3EF0
		// (set) Token: 0x06012953 RID: 76115 RVA: 0x002B5CF8 File Offset: 0x002B3EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayEnterOrExitPollutionRangeType RangeType
		{
			get
			{
				return this.rangeType_;
			}
			set
			{
				this.rangeType_ = value;
			}
		}

		// Token: 0x17003D9A RID: 15770
		// (get) Token: 0x06012954 RID: 76116 RVA: 0x002B5D01 File Offset: 0x002B3F01
		// (set) Token: 0x06012955 RID: 76117 RVA: 0x002B5D09 File Offset: 0x002B3F09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityCtxPb EntityCtx
		{
			get
			{
				return this.entityCtx_;
			}
			set
			{
				this.entityCtx_ = value;
			}
		}

		// Token: 0x06012956 RID: 76118 RVA: 0x002B5D12 File Offset: 0x002B3F12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayEnterOrExitPollutionRangeCtxPb);
		}

		// Token: 0x06012957 RID: 76119 RVA: 0x002B5D20 File Offset: 0x002B3F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayEnterOrExitPollutionRangeCtxPb other)
		{
			return other != null && (other == this || (this.RangeType == other.RangeType && object.Equals(this.EntityCtx, other.EntityCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012958 RID: 76120 RVA: 0x002B5D70 File Offset: 0x002B3F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RangeType != PlayEnterOrExitPollutionRangeType.EnterAction)
			{
				num ^= this.RangeType.GetHashCode();
			}
			if (this.entityCtx_ != null)
			{
				num ^= this.EntityCtx.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012959 RID: 76121 RVA: 0x002B5DCB File Offset: 0x002B3FCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601295A RID: 76122 RVA: 0x002B5DD8 File Offset: 0x002B3FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601295B RID: 76123 RVA: 0x002B5DE4 File Offset: 0x002B3FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RangeType != PlayEnterOrExitPollutionRangeType.EnterAction)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.RangeType);
			}
			if (this.entityCtx_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.EntityCtx);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601295C RID: 76124 RVA: 0x002B5E3C File Offset: 0x002B403C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RangeType != PlayEnterOrExitPollutionRangeType.EnterAction)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.RangeType);
			}
			if (this.entityCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityCtx);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601295D RID: 76125 RVA: 0x002B5E94 File Offset: 0x002B4094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayEnterOrExitPollutionRangeCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RangeType != PlayEnterOrExitPollutionRangeType.EnterAction)
			{
				this.RangeType = other.RangeType;
			}
			if (other.entityCtx_ != null)
			{
				if (this.entityCtx_ == null)
				{
					this.EntityCtx = new EntityCtxPb();
				}
				this.EntityCtx.MergeFrom(other.EntityCtx);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601295E RID: 76126 RVA: 0x002B5EFC File Offset: 0x002B40FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601295F RID: 76127 RVA: 0x002B5F08 File Offset: 0x002B4108
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.entityCtx_ == null)
						{
							this.EntityCtx = new EntityCtxPb();
						}
						input.ReadMessage(this.EntityCtx);
					}
				}
				else
				{
					this.RangeType = (PlayEnterOrExitPollutionRangeType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007359 RID: 29529
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400735A RID: 29530
		public const int RangeTypeFieldNumber = 1;

		// Token: 0x0400735B RID: 29531
		private PlayEnterOrExitPollutionRangeType rangeType_;

		// Token: 0x0400735C RID: 29532
		public const int EntityCtxFieldNumber = 2;

		// Token: 0x0400735D RID: 29533
		private EntityCtxPb entityCtx_;
	}
}
