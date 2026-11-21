using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000482 RID: 1154
	[NetMessage(EMessageId.EntityInteractResponse)]
	public sealed class EntityInteractResponse : IMessage<EntityInteractResponse>, IMessage, IEquatable<EntityInteractResponse>, IDeepCloneable<EntityInteractResponse>, IBufferMessage
	{
		// Token: 0x06006EDA RID: 28378 RVA: 0x00110DDF File Offset: 0x0010EFDF
		[NullableContext(1)]
		public static EntityInteractResponse Create()
		{
			return new EntityInteractResponse();
		}

		// Token: 0x17001554 RID: 5460
		// (get) Token: 0x06006EDB RID: 28379 RVA: 0x00110DE6 File Offset: 0x0010EFE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001555 RID: 5461
		// (get) Token: 0x06006EDC RID: 28380 RVA: 0x00110DE9 File Offset: 0x0010EFE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityInteractResponse.Descriptor;
			}
		}

		// Token: 0x06006EDD RID: 28381 RVA: 0x00110DF0 File Offset: 0x0010EFF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityInteractResponse()
		{
		}

		// Token: 0x06006EDE RID: 28382 RVA: 0x00110DF8 File Offset: 0x0010EFF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityInteractResponse(EntityInteractResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.interacting_ = other.interacting_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006EDF RID: 28383 RVA: 0x00110E29 File Offset: 0x0010F029
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityInteractResponse Clone()
		{
			return new EntityInteractResponse(this);
		}

		// Token: 0x17001556 RID: 5462
		// (get) Token: 0x06006EE0 RID: 28384 RVA: 0x00110E31 File Offset: 0x0010F031
		// (set) Token: 0x06006EE1 RID: 28385 RVA: 0x00110E39 File Offset: 0x0010F039
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

		// Token: 0x17001557 RID: 5463
		// (get) Token: 0x06006EE2 RID: 28386 RVA: 0x00110E42 File Offset: 0x0010F042
		// (set) Token: 0x06006EE3 RID: 28387 RVA: 0x00110E4A File Offset: 0x0010F04A
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

		// Token: 0x06006EE4 RID: 28388 RVA: 0x00110E53 File Offset: 0x0010F053
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityInteractResponse);
		}

		// Token: 0x06006EE5 RID: 28389 RVA: 0x00110E61 File Offset: 0x0010F061
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityInteractResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.Interacting == other.Interacting && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006EE6 RID: 28390 RVA: 0x00110EA0 File Offset: 0x0010F0A0
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

		// Token: 0x06006EE7 RID: 28391 RVA: 0x00110EFE File Offset: 0x0010F0FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006EE8 RID: 28392 RVA: 0x00110F0B File Offset: 0x0010F10B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006EE9 RID: 28393 RVA: 0x00110F14 File Offset: 0x0010F114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.Interacting)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.Interacting);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006EEA RID: 28394 RVA: 0x00110F70 File Offset: 0x0010F170
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

		// Token: 0x06006EEB RID: 28395 RVA: 0x00110FBC File Offset: 0x0010F1BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityInteractResponse other)
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

		// Token: 0x06006EEC RID: 28396 RVA: 0x0011100C File Offset: 0x0010F20C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006EED RID: 28397 RVA: 0x00111018 File Offset: 0x0010F218
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
				if (num != 16U)
				{
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Interacting = input.ReadBool();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003C25 RID: 15397
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C26 RID: 15398
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04003C27 RID: 15399
		private ErrorCode errorCode_;

		// Token: 0x04003C28 RID: 15400
		public const int InteractingFieldNumber = 8;

		// Token: 0x04003C29 RID: 15401
		private bool interacting_;
	}
}
