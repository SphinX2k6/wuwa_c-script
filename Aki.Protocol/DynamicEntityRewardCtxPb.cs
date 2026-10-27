using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200041C RID: 1052
	public sealed class DynamicEntityRewardCtxPb : IMessage<DynamicEntityRewardCtxPb>, IMessage, IEquatable<DynamicEntityRewardCtxPb>, IDeepCloneable<DynamicEntityRewardCtxPb>, IBufferMessage
	{
		// Token: 0x0600653C RID: 25916 RVA: 0x000F3A45 File Offset: 0x000F1C45
		[NullableContext(1)]
		public static DynamicEntityRewardCtxPb Create()
		{
			return new DynamicEntityRewardCtxPb();
		}

		// Token: 0x170012FB RID: 4859
		// (get) Token: 0x0600653D RID: 25917 RVA: 0x000F3A4C File Offset: 0x000F1C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170012FC RID: 4860
		// (get) Token: 0x0600653E RID: 25918 RVA: 0x000F3A4F File Offset: 0x000F1C4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DynamicEntityRewardCtxPb.Descriptor;
			}
		}

		// Token: 0x0600653F RID: 25919 RVA: 0x000F3A56 File Offset: 0x000F1C56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DynamicEntityRewardCtxPb()
		{
		}

		// Token: 0x06006540 RID: 25920 RVA: 0x000F3A5E File Offset: 0x000F1C5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DynamicEntityRewardCtxPb(DynamicEntityRewardCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006541 RID: 25921 RVA: 0x000F3A93 File Offset: 0x000F1C93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DynamicEntityRewardCtxPb Clone()
		{
			return new DynamicEntityRewardCtxPb(this);
		}

		// Token: 0x170012FD RID: 4861
		// (get) Token: 0x06006542 RID: 25922 RVA: 0x000F3A9B File Offset: 0x000F1C9B
		// (set) Token: 0x06006543 RID: 25923 RVA: 0x000F3AA3 File Offset: 0x000F1CA3
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

		// Token: 0x06006544 RID: 25924 RVA: 0x000F3AAC File Offset: 0x000F1CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DynamicEntityRewardCtxPb);
		}

		// Token: 0x06006545 RID: 25925 RVA: 0x000F3ABA File Offset: 0x000F1CBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DynamicEntityRewardCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006546 RID: 25926 RVA: 0x000F3AF0 File Offset: 0x000F1CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x06006547 RID: 25927 RVA: 0x000F3B2C File Offset: 0x000F1D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006548 RID: 25928 RVA: 0x000F3B39 File Offset: 0x000F1D39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006549 RID: 25929 RVA: 0x000F3B42 File Offset: 0x000F1D42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.entityCtx_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EntityCtx);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600654A RID: 25930 RVA: 0x000F3B74 File Offset: 0x000F1D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600654B RID: 25931 RVA: 0x000F3BB4 File Offset: 0x000F1DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DynamicEntityRewardCtxPb other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600654C RID: 25932 RVA: 0x000F3C08 File Offset: 0x000F1E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600654D RID: 25933 RVA: 0x000F3C14 File Offset: 0x000F1E14
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
		}

		// Token: 0x040038CA RID: 14538
		private UnknownFieldSet _unknownFields;

		// Token: 0x040038CB RID: 14539
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x040038CC RID: 14540
		private EntityCtxPb entityCtx_;
	}
}
