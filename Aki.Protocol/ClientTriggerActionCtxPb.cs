using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002B0 RID: 688
	public sealed class ClientTriggerActionCtxPb : IMessage<ClientTriggerActionCtxPb>, IMessage, IEquatable<ClientTriggerActionCtxPb>, IDeepCloneable<ClientTriggerActionCtxPb>, IBufferMessage
	{
		// Token: 0x0600477A RID: 18298 RVA: 0x000AFCC1 File Offset: 0x000ADEC1
		[NullableContext(1)]
		public static ClientTriggerActionCtxPb Create()
		{
			return new ClientTriggerActionCtxPb();
		}

		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x0600477B RID: 18299 RVA: 0x000AFCC8 File Offset: 0x000ADEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x0600477C RID: 18300 RVA: 0x000AFCCB File Offset: 0x000ADECB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientTriggerActionCtxPb.Descriptor;
			}
		}

		// Token: 0x0600477D RID: 18301 RVA: 0x000AFCD2 File Offset: 0x000ADED2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientTriggerActionCtxPb()
		{
		}

		// Token: 0x0600477E RID: 18302 RVA: 0x000AFCDC File Offset: 0x000ADEDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientTriggerActionCtxPb(ClientTriggerActionCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.isEnter_ = other.isEnter_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600477F RID: 18303 RVA: 0x000AFD28 File Offset: 0x000ADF28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientTriggerActionCtxPb Clone()
		{
			return new ClientTriggerActionCtxPb(this);
		}

		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x06004780 RID: 18304 RVA: 0x000AFD30 File Offset: 0x000ADF30
		// (set) Token: 0x06004781 RID: 18305 RVA: 0x000AFD38 File Offset: 0x000ADF38
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

		// Token: 0x17000C70 RID: 3184
		// (get) Token: 0x06004782 RID: 18306 RVA: 0x000AFD41 File Offset: 0x000ADF41
		// (set) Token: 0x06004783 RID: 18307 RVA: 0x000AFD49 File Offset: 0x000ADF49
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

		// Token: 0x06004784 RID: 18308 RVA: 0x000AFD52 File Offset: 0x000ADF52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientTriggerActionCtxPb);
		}

		// Token: 0x06004785 RID: 18309 RVA: 0x000AFD60 File Offset: 0x000ADF60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientTriggerActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && this.IsEnter == other.IsEnter && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004786 RID: 18310 RVA: 0x000AFDB0 File Offset: 0x000ADFB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.entityCtx_ != null)
			{
				num ^= this.EntityCtx.GetHashCode();
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

		// Token: 0x06004787 RID: 18311 RVA: 0x000AFE05 File Offset: 0x000AE005
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004788 RID: 18312 RVA: 0x000AFE12 File Offset: 0x000AE012
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004789 RID: 18313 RVA: 0x000AFE1C File Offset: 0x000AE01C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.entityCtx_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EntityCtx);
			}
			if (this.IsEnter)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsEnter);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600478A RID: 18314 RVA: 0x000AFE78 File Offset: 0x000AE078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.entityCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityCtx);
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

		// Token: 0x0600478B RID: 18315 RVA: 0x000AFEC4 File Offset: 0x000AE0C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClientTriggerActionCtxPb other)
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
			if (other.IsEnter)
			{
				this.IsEnter = other.IsEnter;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600478C RID: 18316 RVA: 0x000AFF2C File Offset: 0x000AE12C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600478D RID: 18317 RVA: 0x000AFF38 File Offset: 0x000AE138
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
						this.IsEnter = input.ReadBool();
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

		// Token: 0x04002FF4 RID: 12276
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FF5 RID: 12277
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04002FF6 RID: 12278
		private EntityCtxPb entityCtx_;

		// Token: 0x04002FF7 RID: 12279
		public const int IsEnterFieldNumber = 2;

		// Token: 0x04002FF8 RID: 12280
		private bool isEnter_;
	}
}
