using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004B7 RID: 1207
	[NetMessage(EMessageId.EntityRandomInteractResponse)]
	public sealed class EntityRandomInteractResponse : IMessage<EntityRandomInteractResponse>, IMessage, IEquatable<EntityRandomInteractResponse>, IDeepCloneable<EntityRandomInteractResponse>, IBufferMessage
	{
		// Token: 0x060072F4 RID: 29428 RVA: 0x00119F53 File Offset: 0x00118153
		[NullableContext(1)]
		public static EntityRandomInteractResponse Create()
		{
			return new EntityRandomInteractResponse();
		}

		// Token: 0x1700163B RID: 5691
		// (get) Token: 0x060072F5 RID: 29429 RVA: 0x00119F5A File Offset: 0x0011815A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700163C RID: 5692
		// (get) Token: 0x060072F6 RID: 29430 RVA: 0x00119F5D File Offset: 0x0011815D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityRandomInteractResponse.Descriptor;
			}
		}

		// Token: 0x060072F7 RID: 29431 RVA: 0x00119F64 File Offset: 0x00118164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRandomInteractResponse()
		{
		}

		// Token: 0x060072F8 RID: 29432 RVA: 0x00119F6C File Offset: 0x0011816C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRandomInteractResponse(EntityRandomInteractResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.interacting_ = other.interacting_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060072F9 RID: 29433 RVA: 0x00119F9D File Offset: 0x0011819D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRandomInteractResponse Clone()
		{
			return new EntityRandomInteractResponse(this);
		}

		// Token: 0x1700163D RID: 5693
		// (get) Token: 0x060072FA RID: 29434 RVA: 0x00119FA5 File Offset: 0x001181A5
		// (set) Token: 0x060072FB RID: 29435 RVA: 0x00119FAD File Offset: 0x001181AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x1700163E RID: 5694
		// (get) Token: 0x060072FC RID: 29436 RVA: 0x00119FB6 File Offset: 0x001181B6
		// (set) Token: 0x060072FD RID: 29437 RVA: 0x00119FBE File Offset: 0x001181BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Interacting
		{
			get
			{
				return this.interacting_;
			}
			set
			{
				this.interacting_ = value;
			}
		}

		// Token: 0x060072FE RID: 29438 RVA: 0x00119FC7 File Offset: 0x001181C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityRandomInteractResponse);
		}

		// Token: 0x060072FF RID: 29439 RVA: 0x00119FD5 File Offset: 0x001181D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityRandomInteractResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.Interacting == other.Interacting && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007300 RID: 29440 RVA: 0x0011A014 File Offset: 0x00118214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.Interacting)
			{
				num ^= this.Interacting.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007301 RID: 29441 RVA: 0x0011A072 File Offset: 0x00118272
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007302 RID: 29442 RVA: 0x0011A07F File Offset: 0x0011827F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007303 RID: 29443 RVA: 0x0011A088 File Offset: 0x00118288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Interacting)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.Interacting);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007304 RID: 29444 RVA: 0x0011A0E4 File Offset: 0x001182E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.Interacting)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007305 RID: 29445 RVA: 0x0011A130 File Offset: 0x00118330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityRandomInteractResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.Interacting)
			{
				this.Interacting = other.Interacting;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007306 RID: 29446 RVA: 0x0011A180 File Offset: 0x00118380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007307 RID: 29447 RVA: 0x0011A18C File Offset: 0x0011838C
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
				if (num != 112U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.Interacting = input.ReadBool();
				}
			}
		}

		// Token: 0x04003D04 RID: 15620
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D05 RID: 15621
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04003D06 RID: 15622
		private ErrorCode errorCode_;

		// Token: 0x04003D07 RID: 15623
		public const int InteractingFieldNumber = 14;

		// Token: 0x04003D08 RID: 15624
		private bool interacting_;
	}
}
