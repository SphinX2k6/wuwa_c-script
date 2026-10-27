using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011B9 RID: 4537
	[NetMessage(EMessageId.SecWorldSEndFlowResponse)]
	public sealed class SecWorldSEndFlowResponse : IMessage<SecWorldSEndFlowResponse>, IMessage, IEquatable<SecWorldSEndFlowResponse>, IDeepCloneable<SecWorldSEndFlowResponse>, IBufferMessage
	{
		// Token: 0x0601835C RID: 99164 RVA: 0x00386223 File Offset: 0x00384423
		[NullableContext(1)]
		public static SecWorldSEndFlowResponse Create()
		{
			return new SecWorldSEndFlowResponse();
		}

		// Token: 0x1700518F RID: 20879
		// (get) Token: 0x0601835D RID: 99165 RVA: 0x0038622A File Offset: 0x0038442A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005190 RID: 20880
		// (get) Token: 0x0601835E RID: 99166 RVA: 0x0038622D File Offset: 0x0038442D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SecWorldSEndFlowResponse.Descriptor;
			}
		}

		// Token: 0x0601835F RID: 99167 RVA: 0x00386234 File Offset: 0x00384434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecWorldSEndFlowResponse()
		{
		}

		// Token: 0x06018360 RID: 99168 RVA: 0x0038623C File Offset: 0x0038443C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecWorldSEndFlowResponse(SecWorldSEndFlowResponse other) : this()
		{
			this.logId_ = other.logId_;
			this.error_ = ((other.error_ != null) ? other.error_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018361 RID: 99169 RVA: 0x00386288 File Offset: 0x00384488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecWorldSEndFlowResponse Clone()
		{
			return new SecWorldSEndFlowResponse(this);
		}

		// Token: 0x17005191 RID: 20881
		// (get) Token: 0x06018362 RID: 99170 RVA: 0x00386290 File Offset: 0x00384490
		// (set) Token: 0x06018363 RID: 99171 RVA: 0x00386298 File Offset: 0x00384498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LogId
		{
			get
			{
				return this.logId_;
			}
			set
			{
				this.logId_ = value;
			}
		}

		// Token: 0x17005192 RID: 20882
		// (get) Token: 0x06018364 RID: 99172 RVA: 0x003862A1 File Offset: 0x003844A1
		// (set) Token: 0x06018365 RID: 99173 RVA: 0x003862A9 File Offset: 0x003844A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DErrorResult Error
		{
			get
			{
				return this.error_;
			}
			set
			{
				this.error_ = value;
			}
		}

		// Token: 0x06018366 RID: 99174 RVA: 0x003862B2 File Offset: 0x003844B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SecWorldSEndFlowResponse);
		}

		// Token: 0x06018367 RID: 99175 RVA: 0x003862C0 File Offset: 0x003844C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SecWorldSEndFlowResponse other)
		{
			return other != null && (other == this || (this.LogId == other.LogId && object.Equals(this.Error, other.Error) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018368 RID: 99176 RVA: 0x00386310 File Offset: 0x00384510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LogId != 0L)
			{
				num ^= this.LogId.GetHashCode();
			}
			if (this.error_ != null)
			{
				num ^= this.Error.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018369 RID: 99177 RVA: 0x00386365 File Offset: 0x00384565
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601836A RID: 99178 RVA: 0x00386372 File Offset: 0x00384572
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601836B RID: 99179 RVA: 0x0038637C File Offset: 0x0038457C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.error_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Error);
			}
			if (this.LogId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.LogId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601836C RID: 99180 RVA: 0x003863D8 File Offset: 0x003845D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LogId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LogId);
			}
			if (this.error_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Error);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601836D RID: 99181 RVA: 0x00386430 File Offset: 0x00384630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SecWorldSEndFlowResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LogId != 0L)
			{
				this.LogId = other.LogId;
			}
			if (other.error_ != null)
			{
				if (this.error_ == null)
				{
					this.Error = new DErrorResult();
				}
				this.Error.MergeFrom(other.Error);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601836E RID: 99182 RVA: 0x00386498 File Offset: 0x00384698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601836F RID: 99183 RVA: 0x003864A4 File Offset: 0x003846A4
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
				if (num != 18U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.LogId = input.ReadInt64();
					}
				}
				else
				{
					if (this.error_ == null)
					{
						this.Error = new DErrorResult();
					}
					input.ReadMessage(this.Error);
				}
			}
		}

		// Token: 0x04008F94 RID: 36756
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008F95 RID: 36757
		public const int LogIdFieldNumber = 7;

		// Token: 0x04008F96 RID: 36758
		private long logId_;

		// Token: 0x04008F97 RID: 36759
		public const int ErrorFieldNumber = 2;

		// Token: 0x04008F98 RID: 36760
		private DErrorResult error_;
	}
}
