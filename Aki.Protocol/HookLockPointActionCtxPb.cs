using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007B2 RID: 1970
	public sealed class HookLockPointActionCtxPb : IMessage<HookLockPointActionCtxPb>, IMessage, IEquatable<HookLockPointActionCtxPb>, IDeepCloneable<HookLockPointActionCtxPb>, IBufferMessage
	{
		// Token: 0x0600B175 RID: 45429 RVA: 0x001A96A6 File Offset: 0x001A78A6
		[NullableContext(1)]
		public static HookLockPointActionCtxPb Create()
		{
			return new HookLockPointActionCtxPb();
		}

		// Token: 0x170023D0 RID: 9168
		// (get) Token: 0x0600B176 RID: 45430 RVA: 0x001A96AD File Offset: 0x001A78AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023D1 RID: 9169
		// (get) Token: 0x0600B177 RID: 45431 RVA: 0x001A96B0 File Offset: 0x001A78B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HookLockPointActionCtxPb.Descriptor;
			}
		}

		// Token: 0x0600B178 RID: 45432 RVA: 0x001A96B7 File Offset: 0x001A78B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointActionCtxPb()
		{
		}

		// Token: 0x0600B179 RID: 45433 RVA: 0x001A96C0 File Offset: 0x001A78C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointActionCtxPb(HookLockPointActionCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.interactActionType_ = other.interactActionType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B17A RID: 45434 RVA: 0x001A970C File Offset: 0x001A790C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointActionCtxPb Clone()
		{
			return new HookLockPointActionCtxPb(this);
		}

		// Token: 0x170023D2 RID: 9170
		// (get) Token: 0x0600B17B RID: 45435 RVA: 0x001A9714 File Offset: 0x001A7914
		// (set) Token: 0x0600B17C RID: 45436 RVA: 0x001A971C File Offset: 0x001A791C
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

		// Token: 0x170023D3 RID: 9171
		// (get) Token: 0x0600B17D RID: 45437 RVA: 0x001A9725 File Offset: 0x001A7925
		// (set) Token: 0x0600B17E RID: 45438 RVA: 0x001A972D File Offset: 0x001A792D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookInteractActionType InteractActionType
		{
			get
			{
				return this.interactActionType_;
			}
			set
			{
				this.interactActionType_ = value;
			}
		}

		// Token: 0x0600B17F RID: 45439 RVA: 0x001A9736 File Offset: 0x001A7936
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HookLockPointActionCtxPb);
		}

		// Token: 0x0600B180 RID: 45440 RVA: 0x001A9744 File Offset: 0x001A7944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HookLockPointActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && this.InteractActionType == other.InteractActionType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B181 RID: 45441 RVA: 0x001A9794 File Offset: 0x001A7994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.entityCtx_ != null)
			{
				num ^= this.EntityCtx.GetHashCode();
			}
			if (this.InteractActionType != HookInteractActionType.Hooked)
			{
				num ^= this.InteractActionType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B182 RID: 45442 RVA: 0x001A97EF File Offset: 0x001A79EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B183 RID: 45443 RVA: 0x001A97FC File Offset: 0x001A79FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B184 RID: 45444 RVA: 0x001A9808 File Offset: 0x001A7A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.entityCtx_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EntityCtx);
			}
			if (this.InteractActionType != HookInteractActionType.Hooked)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.InteractActionType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B185 RID: 45445 RVA: 0x001A9864 File Offset: 0x001A7A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.entityCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityCtx);
			}
			if (this.InteractActionType != HookInteractActionType.Hooked)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.InteractActionType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B186 RID: 45446 RVA: 0x001A98BC File Offset: 0x001A7ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HookLockPointActionCtxPb other)
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
			if (other.InteractActionType != HookInteractActionType.Hooked)
			{
				this.InteractActionType = other.InteractActionType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B187 RID: 45447 RVA: 0x001A9924 File Offset: 0x001A7B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B188 RID: 45448 RVA: 0x001A9930 File Offset: 0x001A7B30
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
						this.InteractActionType = (HookInteractActionType)input.ReadEnum();
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

		// Token: 0x04004F90 RID: 20368
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F91 RID: 20369
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04004F92 RID: 20370
		private EntityCtxPb entityCtx_;

		// Token: 0x04004F93 RID: 20371
		public const int InteractActionTypeFieldNumber = 2;

		// Token: 0x04004F94 RID: 20372
		private HookInteractActionType interactActionType_;
	}
}
