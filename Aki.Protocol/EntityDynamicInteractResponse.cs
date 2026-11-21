using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200046F RID: 1135
	[NetMessage(EMessageId.EntityDynamicInteractResponse)]
	public sealed class EntityDynamicInteractResponse : IMessage<EntityDynamicInteractResponse>, IMessage, IEquatable<EntityDynamicInteractResponse>, IDeepCloneable<EntityDynamicInteractResponse>, IBufferMessage
	{
		// Token: 0x06006D48 RID: 27976 RVA: 0x0010D250 File Offset: 0x0010B450
		[NullableContext(1)]
		public static EntityDynamicInteractResponse Create()
		{
			return new EntityDynamicInteractResponse();
		}

		// Token: 0x170014FC RID: 5372
		// (get) Token: 0x06006D49 RID: 27977 RVA: 0x0010D257 File Offset: 0x0010B457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170014FD RID: 5373
		// (get) Token: 0x06006D4A RID: 27978 RVA: 0x0010D25A File Offset: 0x0010B45A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityDynamicInteractResponse.Descriptor;
			}
		}

		// Token: 0x06006D4B RID: 27979 RVA: 0x0010D261 File Offset: 0x0010B461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityDynamicInteractResponse()
		{
		}

		// Token: 0x06006D4C RID: 27980 RVA: 0x0010D269 File Offset: 0x0010B469
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityDynamicInteractResponse(EntityDynamicInteractResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.interacting_ = other.interacting_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006D4D RID: 27981 RVA: 0x0010D29A File Offset: 0x0010B49A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityDynamicInteractResponse Clone()
		{
			return new EntityDynamicInteractResponse(this);
		}

		// Token: 0x170014FE RID: 5374
		// (get) Token: 0x06006D4E RID: 27982 RVA: 0x0010D2A2 File Offset: 0x0010B4A2
		// (set) Token: 0x06006D4F RID: 27983 RVA: 0x0010D2AA File Offset: 0x0010B4AA
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

		// Token: 0x170014FF RID: 5375
		// (get) Token: 0x06006D50 RID: 27984 RVA: 0x0010D2B3 File Offset: 0x0010B4B3
		// (set) Token: 0x06006D51 RID: 27985 RVA: 0x0010D2BB File Offset: 0x0010B4BB
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

		// Token: 0x06006D52 RID: 27986 RVA: 0x0010D2C4 File Offset: 0x0010B4C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityDynamicInteractResponse);
		}

		// Token: 0x06006D53 RID: 27987 RVA: 0x0010D2D2 File Offset: 0x0010B4D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityDynamicInteractResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.Interacting == other.Interacting && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006D54 RID: 27988 RVA: 0x0010D310 File Offset: 0x0010B510
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

		// Token: 0x06006D55 RID: 27989 RVA: 0x0010D36E File Offset: 0x0010B56E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006D56 RID: 27990 RVA: 0x0010D37B File Offset: 0x0010B57B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006D57 RID: 27991 RVA: 0x0010D384 File Offset: 0x0010B584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
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

		// Token: 0x06006D58 RID: 27992 RVA: 0x0010D3E0 File Offset: 0x0010B5E0
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

		// Token: 0x06006D59 RID: 27993 RVA: 0x0010D42C File Offset: 0x0010B62C
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

		// Token: 0x06006D5A RID: 27994 RVA: 0x0010D47C File Offset: 0x0010B67C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006D5B RID: 27995 RVA: 0x0010D488 File Offset: 0x0010B688
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
				if (num != 32U)
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

		// Token: 0x04003BAB RID: 15275
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BAC RID: 15276
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04003BAD RID: 15277
		private ErrorCode errorCode_;

		// Token: 0x04003BAE RID: 15278
		public const int InteractingFieldNumber = 8;

		// Token: 0x04003BAF RID: 15279
		private bool interacting_;
	}
}
