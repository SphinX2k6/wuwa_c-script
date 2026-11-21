using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D67 RID: 3431
	public sealed class PlayEnterOrExitPollutionRangeCtxPb : IMessage<PlayEnterOrExitPollutionRangeCtxPb>, IMessage, IEquatable<PlayEnterOrExitPollutionRangeCtxPb>, IDeepCloneable<PlayEnterOrExitPollutionRangeCtxPb>, IBufferMessage
	{
		// Token: 0x06012850 RID: 75856 RVA: 0x002B4064 File Offset: 0x002B2264
		[NullableContext(1)]
		public static PlayEnterOrExitPollutionRangeCtxPb Create()
		{
			return new PlayEnterOrExitPollutionRangeCtxPb();
		}

		// Token: 0x17003D62 RID: 15714
		// (get) Token: 0x06012851 RID: 75857 RVA: 0x002B406B File Offset: 0x002B226B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D63 RID: 15715
		// (get) Token: 0x06012852 RID: 75858 RVA: 0x002B406E File Offset: 0x002B226E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayEnterOrExitPollutionRangeCtxPb.Descriptor;
			}
		}

		// Token: 0x06012853 RID: 75859 RVA: 0x002B4075 File Offset: 0x002B2275
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayEnterOrExitPollutionRangeCtxPb()
		{
		}

		// Token: 0x06012854 RID: 75860 RVA: 0x002B4080 File Offset: 0x002B2280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayEnterOrExitPollutionRangeCtxPb(PlayEnterOrExitPollutionRangeCtxPb other) : this()
		{
			this.rangeType_ = other.rangeType_;
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012855 RID: 75861 RVA: 0x002B40CC File Offset: 0x002B22CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayEnterOrExitPollutionRangeCtxPb Clone()
		{
			return new PlayEnterOrExitPollutionRangeCtxPb(this);
		}

		// Token: 0x17003D64 RID: 15716
		// (get) Token: 0x06012856 RID: 75862 RVA: 0x002B40D4 File Offset: 0x002B22D4
		// (set) Token: 0x06012857 RID: 75863 RVA: 0x002B40DC File Offset: 0x002B22DC
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

		// Token: 0x17003D65 RID: 15717
		// (get) Token: 0x06012858 RID: 75864 RVA: 0x002B40E5 File Offset: 0x002B22E5
		// (set) Token: 0x06012859 RID: 75865 RVA: 0x002B40ED File Offset: 0x002B22ED
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

		// Token: 0x0601285A RID: 75866 RVA: 0x002B40F6 File Offset: 0x002B22F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayEnterOrExitPollutionRangeCtxPb);
		}

		// Token: 0x0601285B RID: 75867 RVA: 0x002B4104 File Offset: 0x002B2304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayEnterOrExitPollutionRangeCtxPb other)
		{
			return other != null && (other == this || (this.RangeType == other.RangeType && object.Equals(this.EntityCtx, other.EntityCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601285C RID: 75868 RVA: 0x002B4154 File Offset: 0x002B2354
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

		// Token: 0x0601285D RID: 75869 RVA: 0x002B41AF File Offset: 0x002B23AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601285E RID: 75870 RVA: 0x002B41BC File Offset: 0x002B23BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601285F RID: 75871 RVA: 0x002B41C8 File Offset: 0x002B23C8
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

		// Token: 0x06012860 RID: 75872 RVA: 0x002B4220 File Offset: 0x002B2420
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

		// Token: 0x06012861 RID: 75873 RVA: 0x002B4278 File Offset: 0x002B2478
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

		// Token: 0x06012862 RID: 75874 RVA: 0x002B42E0 File Offset: 0x002B24E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012863 RID: 75875 RVA: 0x002B42EC File Offset: 0x002B24EC
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

		// Token: 0x04007371 RID: 29553
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007372 RID: 29554
		public const int RangeTypeFieldNumber = 1;

		// Token: 0x04007373 RID: 29555
		private PlayEnterOrExitPollutionRangeType rangeType_;

		// Token: 0x04007374 RID: 29556
		public const int EntityCtxFieldNumber = 2;

		// Token: 0x04007375 RID: 29557
		private EntityCtxPb entityCtx_;
	}
}
