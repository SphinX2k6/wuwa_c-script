using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200079E RID: 1950
	public sealed class HookLockPointActionCtxPb : IMessage<HookLockPointActionCtxPb>, IMessage, IEquatable<HookLockPointActionCtxPb>, IDeepCloneable<HookLockPointActionCtxPb>, IBufferMessage
	{
		// Token: 0x0600B01F RID: 45087 RVA: 0x001A6C76 File Offset: 0x001A4E76
		[NullableContext(1)]
		public static HookLockPointActionCtxPb Create()
		{
			return new HookLockPointActionCtxPb();
		}

		// Token: 0x17002386 RID: 9094
		// (get) Token: 0x0600B020 RID: 45088 RVA: 0x001A6C7D File Offset: 0x001A4E7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002387 RID: 9095
		// (get) Token: 0x0600B021 RID: 45089 RVA: 0x001A6C80 File Offset: 0x001A4E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HookLockPointActionCtxPb.Descriptor;
			}
		}

		// Token: 0x0600B022 RID: 45090 RVA: 0x001A6C87 File Offset: 0x001A4E87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointActionCtxPb()
		{
		}

		// Token: 0x0600B023 RID: 45091 RVA: 0x001A6C90 File Offset: 0x001A4E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointActionCtxPb(HookLockPointActionCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.interactActionType_ = other.interactActionType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B024 RID: 45092 RVA: 0x001A6CDC File Offset: 0x001A4EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointActionCtxPb Clone()
		{
			return new HookLockPointActionCtxPb(this);
		}

		// Token: 0x17002388 RID: 9096
		// (get) Token: 0x0600B025 RID: 45093 RVA: 0x001A6CE4 File Offset: 0x001A4EE4
		// (set) Token: 0x0600B026 RID: 45094 RVA: 0x001A6CEC File Offset: 0x001A4EEC
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

		// Token: 0x17002389 RID: 9097
		// (get) Token: 0x0600B027 RID: 45095 RVA: 0x001A6CF5 File Offset: 0x001A4EF5
		// (set) Token: 0x0600B028 RID: 45096 RVA: 0x001A6CFD File Offset: 0x001A4EFD
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

		// Token: 0x0600B029 RID: 45097 RVA: 0x001A6D06 File Offset: 0x001A4F06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HookLockPointActionCtxPb);
		}

		// Token: 0x0600B02A RID: 45098 RVA: 0x001A6D14 File Offset: 0x001A4F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HookLockPointActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && this.InteractActionType == other.InteractActionType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B02B RID: 45099 RVA: 0x001A6D64 File Offset: 0x001A4F64
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

		// Token: 0x0600B02C RID: 45100 RVA: 0x001A6DBF File Offset: 0x001A4FBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B02D RID: 45101 RVA: 0x001A6DCC File Offset: 0x001A4FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B02E RID: 45102 RVA: 0x001A6DD8 File Offset: 0x001A4FD8
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

		// Token: 0x0600B02F RID: 45103 RVA: 0x001A6E34 File Offset: 0x001A5034
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

		// Token: 0x0600B030 RID: 45104 RVA: 0x001A6E8C File Offset: 0x001A508C
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

		// Token: 0x0600B031 RID: 45105 RVA: 0x001A6EF4 File Offset: 0x001A50F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B032 RID: 45106 RVA: 0x001A6F00 File Offset: 0x001A5100
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

		// Token: 0x04004F89 RID: 20361
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F8A RID: 20362
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04004F8B RID: 20363
		private EntityCtxPb entityCtx_;

		// Token: 0x04004F8C RID: 20364
		public const int InteractActionTypeFieldNumber = 2;

		// Token: 0x04004F8D RID: 20365
		private HookInteractActionType interactActionType_;
	}
}
