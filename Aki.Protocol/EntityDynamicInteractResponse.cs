using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000486 RID: 1158
	[NetMessage(EMessageId.EntityDynamicInteractResponse)]
	public sealed class EntityDynamicInteractResponse : IMessage<EntityDynamicInteractResponse>, IMessage, IEquatable<EntityDynamicInteractResponse>, IDeepCloneable<EntityDynamicInteractResponse>, IBufferMessage
	{
		// Token: 0x06006ED6 RID: 28374 RVA: 0x001102C4 File Offset: 0x0010E4C4
		[NullableContext(1)]
		public static EntityDynamicInteractResponse Create()
		{
			return new EntityDynamicInteractResponse();
		}

		// Token: 0x17001550 RID: 5456
		// (get) Token: 0x06006ED7 RID: 28375 RVA: 0x001102CB File Offset: 0x0010E4CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001551 RID: 5457
		// (get) Token: 0x06006ED8 RID: 28376 RVA: 0x001102CE File Offset: 0x0010E4CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityDynamicInteractResponse.Descriptor;
			}
		}

		// Token: 0x06006ED9 RID: 28377 RVA: 0x001102D5 File Offset: 0x0010E4D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityDynamicInteractResponse()
		{
		}

		// Token: 0x06006EDA RID: 28378 RVA: 0x001102DD File Offset: 0x0010E4DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityDynamicInteractResponse(EntityDynamicInteractResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.interacting_ = other.interacting_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006EDB RID: 28379 RVA: 0x0011030E File Offset: 0x0010E50E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityDynamicInteractResponse Clone()
		{
			return new EntityDynamicInteractResponse(this);
		}

		// Token: 0x17001552 RID: 5458
		// (get) Token: 0x06006EDC RID: 28380 RVA: 0x00110316 File Offset: 0x0010E516
		// (set) Token: 0x06006EDD RID: 28381 RVA: 0x0011031E File Offset: 0x0010E51E
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

		// Token: 0x17001553 RID: 5459
		// (get) Token: 0x06006EDE RID: 28382 RVA: 0x00110327 File Offset: 0x0010E527
		// (set) Token: 0x06006EDF RID: 28383 RVA: 0x0011032F File Offset: 0x0010E52F
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

		// Token: 0x06006EE0 RID: 28384 RVA: 0x00110338 File Offset: 0x0010E538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityDynamicInteractResponse);
		}

		// Token: 0x06006EE1 RID: 28385 RVA: 0x00110346 File Offset: 0x0010E546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityDynamicInteractResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.Interacting == other.Interacting && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006EE2 RID: 28386 RVA: 0x00110384 File Offset: 0x0010E584
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

		// Token: 0x06006EE3 RID: 28387 RVA: 0x001103E2 File Offset: 0x0010E5E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006EE4 RID: 28388 RVA: 0x001103EF File Offset: 0x0010E5EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006EE5 RID: 28389 RVA: 0x001103F8 File Offset: 0x0010E5F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Interacting)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.Interacting);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006EE6 RID: 28390 RVA: 0x00110454 File Offset: 0x0010E654
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

		// Token: 0x06006EE7 RID: 28391 RVA: 0x001104A0 File Offset: 0x0010E6A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityDynamicInteractResponse other)
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

		// Token: 0x06006EE8 RID: 28392 RVA: 0x001104F0 File Offset: 0x0010E6F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006EE9 RID: 28393 RVA: 0x001104FC File Offset: 0x0010E6FC
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
				if (num != 56U)
				{
					if (num != 80U)
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

		// Token: 0x04003BBD RID: 15293
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BBE RID: 15294
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04003BBF RID: 15295
		private ErrorCode errorCode_;

		// Token: 0x04003BC0 RID: 15296
		public const int InteractingFieldNumber = 7;

		// Token: 0x04003BC1 RID: 15297
		private bool interacting_;
	}
}
