using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200023F RID: 575
	public sealed class CasketTriggerCtxPb : IMessage<CasketTriggerCtxPb>, IMessage, IEquatable<CasketTriggerCtxPb>, IDeepCloneable<CasketTriggerCtxPb>, IBufferMessage
	{
		// Token: 0x06003E18 RID: 15896 RVA: 0x00099E0B File Offset: 0x0009800B
		[NullableContext(1)]
		public static CasketTriggerCtxPb Create()
		{
			return new CasketTriggerCtxPb();
		}

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x06003E19 RID: 15897 RVA: 0x00099E12 File Offset: 0x00098012
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x06003E1A RID: 15898 RVA: 0x00099E15 File Offset: 0x00098015
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CasketTriggerCtxPb.Descriptor;
			}
		}

		// Token: 0x06003E1B RID: 15899 RVA: 0x00099E1C File Offset: 0x0009801C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CasketTriggerCtxPb()
		{
		}

		// Token: 0x06003E1C RID: 15900 RVA: 0x00099E24 File Offset: 0x00098024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CasketTriggerCtxPb(CasketTriggerCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.index_ = other.index_;
			this.isEnter_ = other.isEnter_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003E1D RID: 15901 RVA: 0x00099E7C File Offset: 0x0009807C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CasketTriggerCtxPb Clone()
		{
			return new CasketTriggerCtxPb(this);
		}

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x06003E1E RID: 15902 RVA: 0x00099E84 File Offset: 0x00098084
		// (set) Token: 0x06003E1F RID: 15903 RVA: 0x00099E8C File Offset: 0x0009808C
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

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x06003E20 RID: 15904 RVA: 0x00099E95 File Offset: 0x00098095
		// (set) Token: 0x06003E21 RID: 15905 RVA: 0x00099E9D File Offset: 0x0009809D
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

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x06003E22 RID: 15906 RVA: 0x00099EA6 File Offset: 0x000980A6
		// (set) Token: 0x06003E23 RID: 15907 RVA: 0x00099EAE File Offset: 0x000980AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsEnter
		{
			get
			{
				return this.isEnter_;
			}
			set
			{
				this.isEnter_ = value;
			}
		}

		// Token: 0x06003E24 RID: 15908 RVA: 0x00099EB7 File Offset: 0x000980B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CasketTriggerCtxPb);
		}

		// Token: 0x06003E25 RID: 15909 RVA: 0x00099EC8 File Offset: 0x000980C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CasketTriggerCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && this.Index == other.Index && this.IsEnter == other.IsEnter && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003E26 RID: 15910 RVA: 0x00099F28 File Offset: 0x00098128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.entityCtx_ != null)
			{
				num ^= this.EntityCtx.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.IsEnter)
			{
				num ^= this.IsEnter.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003E27 RID: 15911 RVA: 0x00099F96 File Offset: 0x00098196
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003E28 RID: 15912 RVA: 0x00099FA3 File Offset: 0x000981A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003E29 RID: 15913 RVA: 0x00099FAC File Offset: 0x000981AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.entityCtx_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EntityCtx);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Index);
			}
			if (this.IsEnter)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsEnter);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003E2A RID: 15914 RVA: 0x0009A024 File Offset: 0x00098224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.entityCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityCtx);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this.IsEnter)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003E2B RID: 15915 RVA: 0x0009A088 File Offset: 0x00098288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CasketTriggerCtxPb other)
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
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			if (other.IsEnter)
			{
				this.IsEnter = other.IsEnter;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003E2C RID: 15916 RVA: 0x0009A104 File Offset: 0x00098304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003E2D RID: 15917 RVA: 0x0009A110 File Offset: 0x00098310
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsEnter = input.ReadBool();
						}
					}
					else
					{
						this.Index = input.ReadInt32();
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

		// Token: 0x04002D2C RID: 11564
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D2D RID: 11565
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04002D2E RID: 11566
		private EntityCtxPb entityCtx_;

		// Token: 0x04002D2F RID: 11567
		public const int IndexFieldNumber = 2;

		// Token: 0x04002D30 RID: 11568
		private int index_;

		// Token: 0x04002D31 RID: 11569
		public const int IsEnterFieldNumber = 3;

		// Token: 0x04002D32 RID: 11570
		private bool isEnter_;
	}
}
