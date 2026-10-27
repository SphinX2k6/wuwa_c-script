using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200041D RID: 1053
	public sealed class DynamicInteractCtxPb : IMessage<DynamicInteractCtxPb>, IMessage, IEquatable<DynamicInteractCtxPb>, IDeepCloneable<DynamicInteractCtxPb>, IBufferMessage
	{
		// Token: 0x0600654E RID: 25934 RVA: 0x000F3C6C File Offset: 0x000F1E6C
		[NullableContext(1)]
		public static DynamicInteractCtxPb Create()
		{
			return new DynamicInteractCtxPb();
		}

		// Token: 0x170012FE RID: 4862
		// (get) Token: 0x0600654F RID: 25935 RVA: 0x000F3C73 File Offset: 0x000F1E73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170012FF RID: 4863
		// (get) Token: 0x06006550 RID: 25936 RVA: 0x000F3C76 File Offset: 0x000F1E76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DynamicInteractCtxPb.Descriptor;
			}
		}

		// Token: 0x06006551 RID: 25937 RVA: 0x000F3C7D File Offset: 0x000F1E7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DynamicInteractCtxPb()
		{
		}

		// Token: 0x06006552 RID: 25938 RVA: 0x000F3C90 File Offset: 0x000F1E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DynamicInteractCtxPb(DynamicInteractCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.optionGuid_ = other.optionGuid_;
			this.finalOptionCtx_ = ((other.finalOptionCtx_ != null) ? other.finalOptionCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006553 RID: 25939 RVA: 0x000F3CF8 File Offset: 0x000F1EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DynamicInteractCtxPb Clone()
		{
			return new DynamicInteractCtxPb(this);
		}

		// Token: 0x17001300 RID: 4864
		// (get) Token: 0x06006554 RID: 25940 RVA: 0x000F3D00 File Offset: 0x000F1F00
		// (set) Token: 0x06006555 RID: 25941 RVA: 0x000F3D08 File Offset: 0x000F1F08
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

		// Token: 0x17001301 RID: 4865
		// (get) Token: 0x06006556 RID: 25942 RVA: 0x000F3D11 File Offset: 0x000F1F11
		// (set) Token: 0x06006557 RID: 25943 RVA: 0x000F3D19 File Offset: 0x000F1F19
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

		// Token: 0x17001302 RID: 4866
		// (get) Token: 0x06006558 RID: 25944 RVA: 0x000F3D2C File Offset: 0x000F1F2C
		// (set) Token: 0x06006559 RID: 25945 RVA: 0x000F3D34 File Offset: 0x000F1F34
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

		// Token: 0x0600655A RID: 25946 RVA: 0x000F3D3D File Offset: 0x000F1F3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DynamicInteractCtxPb);
		}

		// Token: 0x0600655B RID: 25947 RVA: 0x000F3D4C File Offset: 0x000F1F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DynamicInteractCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && !(this.OptionGuid != other.OptionGuid) && object.Equals(this.FinalOptionCtx, other.FinalOptionCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600655C RID: 25948 RVA: 0x000F3DB4 File Offset: 0x000F1FB4
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

		// Token: 0x0600655D RID: 25949 RVA: 0x000F3E21 File Offset: 0x000F2021
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600655E RID: 25950 RVA: 0x000F3E2E File Offset: 0x000F202E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600655F RID: 25951 RVA: 0x000F3E38 File Offset: 0x000F2038
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

		// Token: 0x06006560 RID: 25952 RVA: 0x000F3EB4 File Offset: 0x000F20B4
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

		// Token: 0x06006561 RID: 25953 RVA: 0x000F3F28 File Offset: 0x000F2128
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

		// Token: 0x06006562 RID: 25954 RVA: 0x000F3FC1 File Offset: 0x000F21C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006563 RID: 25955 RVA: 0x000F3FCC File Offset: 0x000F21CC
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

		// Token: 0x040038CD RID: 14541
		private UnknownFieldSet _unknownFields;

		// Token: 0x040038CE RID: 14542
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x040038CF RID: 14543
		private EntityCtxPb entityCtx_;

		// Token: 0x040038D0 RID: 14544
		public const int OptionGuidFieldNumber = 2;

		// Token: 0x040038D1 RID: 14545
		private string optionGuid_ = "";

		// Token: 0x040038D2 RID: 14546
		public const int FinalOptionCtxFieldNumber = 3;

		// Token: 0x040038D3 RID: 14547
		private GameCtxPb finalOptionCtx_;
	}
}
