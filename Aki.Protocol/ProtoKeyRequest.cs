using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DEB RID: 3563
	[NetMessage(EMessageId.ProtoKeyRequest)]
	public sealed class ProtoKeyRequest : IMessage<ProtoKeyRequest>, IMessage, IEquatable<ProtoKeyRequest>, IDeepCloneable<ProtoKeyRequest>, IBufferMessage
	{
		// Token: 0x060132AD RID: 78509 RVA: 0x002CAABA File Offset: 0x002C8CBA
		[NullableContext(1)]
		public static ProtoKeyRequest Create()
		{
			return new ProtoKeyRequest();
		}

		// Token: 0x17003F97 RID: 16279
		// (get) Token: 0x060132AE RID: 78510 RVA: 0x002CAAC1 File Offset: 0x002C8CC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F98 RID: 16280
		// (get) Token: 0x060132AF RID: 78511 RVA: 0x002CAAC4 File Offset: 0x002C8CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ProtoKeyRequest.Descriptor;
			}
		}

		// Token: 0x060132B0 RID: 78512 RVA: 0x002CAACB File Offset: 0x002C8CCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ProtoKeyRequest()
		{
		}

		// Token: 0x060132B1 RID: 78513 RVA: 0x002CAADE File Offset: 0x002C8CDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ProtoKeyRequest(ProtoKeyRequest other) : this()
		{
			this.isLogin_ = other.isLogin_;
			this.traceId_ = other.traceId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060132B2 RID: 78514 RVA: 0x002CAB0F File Offset: 0x002C8D0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ProtoKeyRequest Clone()
		{
			return new ProtoKeyRequest(this);
		}

		// Token: 0x17003F99 RID: 16281
		// (get) Token: 0x060132B3 RID: 78515 RVA: 0x002CAB17 File Offset: 0x002C8D17
		// (set) Token: 0x060132B4 RID: 78516 RVA: 0x002CAB1F File Offset: 0x002C8D1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsLogin
		{
			get
			{
				return this.isLogin_;
			}
			set
			{
				this.isLogin_ = value;
			}
		}

		// Token: 0x17003F9A RID: 16282
		// (get) Token: 0x060132B5 RID: 78517 RVA: 0x002CAB28 File Offset: 0x002C8D28
		// (set) Token: 0x060132B6 RID: 78518 RVA: 0x002CAB30 File Offset: 0x002C8D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string TraceId
		{
			get
			{
				return this.traceId_;
			}
			set
			{
				this.traceId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x060132B7 RID: 78519 RVA: 0x002CAB43 File Offset: 0x002C8D43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ProtoKeyRequest);
		}

		// Token: 0x060132B8 RID: 78520 RVA: 0x002CAB54 File Offset: 0x002C8D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ProtoKeyRequest other)
		{
			return other != null && (other == this || (this.IsLogin == other.IsLogin && !(this.TraceId != other.TraceId) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060132B9 RID: 78521 RVA: 0x002CABA4 File Offset: 0x002C8DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsLogin)
			{
				num ^= this.IsLogin.GetHashCode();
			}
			if (this.TraceId.Length != 0)
			{
				num ^= this.TraceId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060132BA RID: 78522 RVA: 0x002CABFE File Offset: 0x002C8DFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060132BB RID: 78523 RVA: 0x002CAC0B File Offset: 0x002C8E0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060132BC RID: 78524 RVA: 0x002CAC14 File Offset: 0x002C8E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsLogin)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsLogin);
			}
			if (this.TraceId.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.TraceId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060132BD RID: 78525 RVA: 0x002CAC74 File Offset: 0x002C8E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsLogin)
			{
				num += 2;
			}
			if (this.TraceId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.TraceId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060132BE RID: 78526 RVA: 0x002CACC4 File Offset: 0x002C8EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ProtoKeyRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsLogin)
			{
				this.IsLogin = other.IsLogin;
			}
			if (other.TraceId.Length != 0)
			{
				this.TraceId = other.TraceId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060132BF RID: 78527 RVA: 0x002CAD19 File Offset: 0x002C8F19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060132C0 RID: 78528 RVA: 0x002CAD24 File Offset: 0x002C8F24
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
						this.TraceId = input.ReadString();
					}
				}
				else
				{
					this.IsLogin = input.ReadBool();
				}
			}
		}

		// Token: 0x0400760E RID: 30222
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400760F RID: 30223
		public const int IsLoginFieldNumber = 1;

		// Token: 0x04007610 RID: 30224
		private bool isLogin_;

		// Token: 0x04007611 RID: 30225
		public const int TraceIdFieldNumber = 2;

		// Token: 0x04007612 RID: 30226
		private string traceId_ = "";
	}
}
