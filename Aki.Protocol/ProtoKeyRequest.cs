using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DDB RID: 3547
	[NetMessage(EMessageId.ProtoKeyRequest)]
	public sealed class ProtoKeyRequest : IMessage<ProtoKeyRequest>, IMessage, IEquatable<ProtoKeyRequest>, IDeepCloneable<ProtoKeyRequest>, IBufferMessage
	{
		// Token: 0x060131C8 RID: 78280 RVA: 0x002C93F6 File Offset: 0x002C75F6
		[NullableContext(1)]
		public static ProtoKeyRequest Create()
		{
			return new ProtoKeyRequest();
		}

		// Token: 0x17003F6D RID: 16237
		// (get) Token: 0x060131C9 RID: 78281 RVA: 0x002C93FD File Offset: 0x002C75FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F6E RID: 16238
		// (get) Token: 0x060131CA RID: 78282 RVA: 0x002C9400 File Offset: 0x002C7600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ProtoKeyRequest.Descriptor;
			}
		}

		// Token: 0x060131CB RID: 78283 RVA: 0x002C9407 File Offset: 0x002C7607
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ProtoKeyRequest()
		{
		}

		// Token: 0x060131CC RID: 78284 RVA: 0x002C941A File Offset: 0x002C761A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ProtoKeyRequest(ProtoKeyRequest other) : this()
		{
			this.isLogin_ = other.isLogin_;
			this.traceId_ = other.traceId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060131CD RID: 78285 RVA: 0x002C944B File Offset: 0x002C764B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ProtoKeyRequest Clone()
		{
			return new ProtoKeyRequest(this);
		}

		// Token: 0x17003F6F RID: 16239
		// (get) Token: 0x060131CE RID: 78286 RVA: 0x002C9453 File Offset: 0x002C7653
		// (set) Token: 0x060131CF RID: 78287 RVA: 0x002C945B File Offset: 0x002C765B
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

		// Token: 0x17003F70 RID: 16240
		// (get) Token: 0x060131D0 RID: 78288 RVA: 0x002C9464 File Offset: 0x002C7664
		// (set) Token: 0x060131D1 RID: 78289 RVA: 0x002C946C File Offset: 0x002C766C
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

		// Token: 0x060131D2 RID: 78290 RVA: 0x002C947F File Offset: 0x002C767F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ProtoKeyRequest);
		}

		// Token: 0x060131D3 RID: 78291 RVA: 0x002C9490 File Offset: 0x002C7690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ProtoKeyRequest other)
		{
			return other != null && (other == this || (this.IsLogin == other.IsLogin && !(this.TraceId != other.TraceId) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060131D4 RID: 78292 RVA: 0x002C94E0 File Offset: 0x002C76E0
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

		// Token: 0x060131D5 RID: 78293 RVA: 0x002C953A File Offset: 0x002C773A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060131D6 RID: 78294 RVA: 0x002C9547 File Offset: 0x002C7747
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060131D7 RID: 78295 RVA: 0x002C9550 File Offset: 0x002C7750
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

		// Token: 0x060131D8 RID: 78296 RVA: 0x002C95B0 File Offset: 0x002C77B0
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

		// Token: 0x060131D9 RID: 78297 RVA: 0x002C9600 File Offset: 0x002C7800
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

		// Token: 0x060131DA RID: 78298 RVA: 0x002C9655 File Offset: 0x002C7855
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060131DB RID: 78299 RVA: 0x002C9660 File Offset: 0x002C7860
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

		// Token: 0x04007638 RID: 30264
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007639 RID: 30265
		public const int IsLoginFieldNumber = 1;

		// Token: 0x0400763A RID: 30266
		private bool isLogin_;

		// Token: 0x0400763B RID: 30267
		public const int TraceIdFieldNumber = 2;

		// Token: 0x0400763C RID: 30268
		private string traceId_ = "";
	}
}
