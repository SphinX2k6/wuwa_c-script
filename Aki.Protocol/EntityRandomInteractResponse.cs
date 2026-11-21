using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004A0 RID: 1184
	[NetMessage(EMessageId.EntityRandomInteractResponse)]
	public sealed class EntityRandomInteractResponse : IMessage<EntityRandomInteractResponse>, IMessage, IEquatable<EntityRandomInteractResponse>, IDeepCloneable<EntityRandomInteractResponse>, IBufferMessage
	{
		// Token: 0x06007164 RID: 29028 RVA: 0x00116E34 File Offset: 0x00115034
		[NullableContext(1)]
		public static EntityRandomInteractResponse Create()
		{
			return new EntityRandomInteractResponse();
		}

		// Token: 0x170015E6 RID: 5606
		// (get) Token: 0x06007165 RID: 29029 RVA: 0x00116E3B File Offset: 0x0011503B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015E7 RID: 5607
		// (get) Token: 0x06007166 RID: 29030 RVA: 0x00116E3E File Offset: 0x0011503E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityRandomInteractResponse.Descriptor;
			}
		}

		// Token: 0x06007167 RID: 29031 RVA: 0x00116E45 File Offset: 0x00115045
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRandomInteractResponse()
		{
		}

		// Token: 0x06007168 RID: 29032 RVA: 0x00116E4D File Offset: 0x0011504D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRandomInteractResponse(EntityRandomInteractResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.interacting_ = other.interacting_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007169 RID: 29033 RVA: 0x00116E7E File Offset: 0x0011507E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRandomInteractResponse Clone()
		{
			return new EntityRandomInteractResponse(this);
		}

		// Token: 0x170015E8 RID: 5608
		// (get) Token: 0x0600716A RID: 29034 RVA: 0x00116E86 File Offset: 0x00115086
		// (set) Token: 0x0600716B RID: 29035 RVA: 0x00116E8E File Offset: 0x0011508E
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

		// Token: 0x170015E9 RID: 5609
		// (get) Token: 0x0600716C RID: 29036 RVA: 0x00116E97 File Offset: 0x00115097
		// (set) Token: 0x0600716D RID: 29037 RVA: 0x00116E9F File Offset: 0x0011509F
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

		// Token: 0x0600716E RID: 29038 RVA: 0x00116EA8 File Offset: 0x001150A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityRandomInteractResponse);
		}

		// Token: 0x0600716F RID: 29039 RVA: 0x00116EB6 File Offset: 0x001150B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityRandomInteractResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.Interacting == other.Interacting && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007170 RID: 29040 RVA: 0x00116EF4 File Offset: 0x001150F4
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

		// Token: 0x06007171 RID: 29041 RVA: 0x00116F52 File Offset: 0x00115152
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007172 RID: 29042 RVA: 0x00116F5F File Offset: 0x0011515F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007173 RID: 29043 RVA: 0x00116F68 File Offset: 0x00115168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.Interacting)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.Interacting);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007174 RID: 29044 RVA: 0x00116FC4 File Offset: 0x001151C4
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

		// Token: 0x06007175 RID: 29045 RVA: 0x00117010 File Offset: 0x00115210
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

		// Token: 0x06007176 RID: 29046 RVA: 0x00117060 File Offset: 0x00115260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007177 RID: 29047 RVA: 0x0011706C File Offset: 0x0011526C
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
				if (num != 48U)
				{
					if (num != 120U)
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

		// Token: 0x04003CF0 RID: 15600
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003CF1 RID: 15601
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04003CF2 RID: 15602
		private ErrorCode errorCode_;

		// Token: 0x04003CF3 RID: 15603
		public const int InteractingFieldNumber = 15;

		// Token: 0x04003CF4 RID: 15604
		private bool interacting_;
	}
}
