using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000406 RID: 1030
	public sealed class DynamicInteractCtxPb : IMessage<DynamicInteractCtxPb>, IMessage, IEquatable<DynamicInteractCtxPb>, IDeepCloneable<DynamicInteractCtxPb>, IBufferMessage
	{
		// Token: 0x060063BE RID: 25534 RVA: 0x000F0AF8 File Offset: 0x000EECF8
		[NullableContext(1)]
		public static DynamicInteractCtxPb Create()
		{
			return new DynamicInteractCtxPb();
		}

		// Token: 0x170012A9 RID: 4777
		// (get) Token: 0x060063BF RID: 25535 RVA: 0x000F0AFF File Offset: 0x000EECFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170012AA RID: 4778
		// (get) Token: 0x060063C0 RID: 25536 RVA: 0x000F0B02 File Offset: 0x000EED02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DynamicInteractCtxPb.Descriptor;
			}
		}

		// Token: 0x060063C1 RID: 25537 RVA: 0x000F0B09 File Offset: 0x000EED09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DynamicInteractCtxPb()
		{
		}

		// Token: 0x060063C2 RID: 25538 RVA: 0x000F0B1C File Offset: 0x000EED1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DynamicInteractCtxPb(DynamicInteractCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.optionGuid_ = other.optionGuid_;
			this.finalOptionCtx_ = ((other.finalOptionCtx_ != null) ? other.finalOptionCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060063C3 RID: 25539 RVA: 0x000F0B84 File Offset: 0x000EED84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DynamicInteractCtxPb Clone()
		{
			return new DynamicInteractCtxPb(this);
		}

		// Token: 0x170012AB RID: 4779
		// (get) Token: 0x060063C4 RID: 25540 RVA: 0x000F0B8C File Offset: 0x000EED8C
		// (set) Token: 0x060063C5 RID: 25541 RVA: 0x000F0B94 File Offset: 0x000EED94
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

		// Token: 0x170012AC RID: 4780
		// (get) Token: 0x060063C6 RID: 25542 RVA: 0x000F0B9D File Offset: 0x000EED9D
		// (set) Token: 0x060063C7 RID: 25543 RVA: 0x000F0BA5 File Offset: 0x000EEDA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string OptionGuid
		{
			get
			{
				return this.optionGuid_;
			}
			set
			{
				this.optionGuid_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170012AD RID: 4781
		// (get) Token: 0x060063C8 RID: 25544 RVA: 0x000F0BB8 File Offset: 0x000EEDB8
		// (set) Token: 0x060063C9 RID: 25545 RVA: 0x000F0BC0 File Offset: 0x000EEDC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameCtxPb FinalOptionCtx
		{
			get
			{
				return this.finalOptionCtx_;
			}
			set
			{
				this.finalOptionCtx_ = value;
			}
		}

		// Token: 0x060063CA RID: 25546 RVA: 0x000F0BC9 File Offset: 0x000EEDC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DynamicInteractCtxPb);
		}

		// Token: 0x060063CB RID: 25547 RVA: 0x000F0BD8 File Offset: 0x000EEDD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DynamicInteractCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && !(this.OptionGuid != other.OptionGuid) && object.Equals(this.FinalOptionCtx, other.FinalOptionCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060063CC RID: 25548 RVA: 0x000F0C40 File Offset: 0x000EEE40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.entityCtx_ != null)
			{
				num ^= this.EntityCtx.GetHashCode();
			}
			if (this.OptionGuid.Length != 0)
			{
				num ^= this.OptionGuid.GetHashCode();
			}
			if (this.finalOptionCtx_ != null)
			{
				num ^= this.FinalOptionCtx.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060063CD RID: 25549 RVA: 0x000F0CAD File Offset: 0x000EEEAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060063CE RID: 25550 RVA: 0x000F0CBA File Offset: 0x000EEEBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060063CF RID: 25551 RVA: 0x000F0CC4 File Offset: 0x000EEEC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.entityCtx_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EntityCtx);
			}
			if (this.OptionGuid.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.OptionGuid);
			}
			if (this.finalOptionCtx_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.FinalOptionCtx);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060063D0 RID: 25552 RVA: 0x000F0D40 File Offset: 0x000EEF40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.entityCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityCtx);
			}
			if (this.OptionGuid.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.OptionGuid);
			}
			if (this.finalOptionCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FinalOptionCtx);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060063D1 RID: 25553 RVA: 0x000F0DB4 File Offset: 0x000EEFB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DynamicInteractCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.entityCtx_ != null)
			{
				if (this.entityCtx_ == null)
				{
					this.EntityCtx = new EntityCtxPb();
				}
				this.EntityCtx.MergeFrom(other.EntityCtx);
			}
			if (other.OptionGuid.Length != 0)
			{
				this.OptionGuid = other.OptionGuid;
			}
			if (other.finalOptionCtx_ != null)
			{
				if (this.finalOptionCtx_ == null)
				{
					this.FinalOptionCtx = new GameCtxPb();
				}
				this.FinalOptionCtx.MergeFrom(other.FinalOptionCtx);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060063D2 RID: 25554 RVA: 0x000F0E4D File Offset: 0x000EF04D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060063D3 RID: 25555 RVA: 0x000F0E58 File Offset: 0x000EF058
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
					if (num != 18U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.finalOptionCtx_ == null)
							{
								this.FinalOptionCtx = new GameCtxPb();
							}
							input.ReadMessage(this.FinalOptionCtx);
						}
					}
					else
					{
						this.OptionGuid = input.ReadString();
					}
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
		}

		// Token: 0x040038BA RID: 14522
		private UnknownFieldSet _unknownFields;

		// Token: 0x040038BB RID: 14523
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x040038BC RID: 14524
		private EntityCtxPb entityCtx_;

		// Token: 0x040038BD RID: 14525
		public const int OptionGuidFieldNumber = 2;

		// Token: 0x040038BE RID: 14526
		private string optionGuid_ = "";

		// Token: 0x040038BF RID: 14527
		public const int FinalOptionCtxFieldNumber = 3;

		// Token: 0x040038C0 RID: 14528
		private GameCtxPb finalOptionCtx_;
	}
}
