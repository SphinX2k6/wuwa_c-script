using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200049D RID: 1181
	[NetMessage(EMessageId.EntityIsVisibleResponse)]
	public sealed class EntityIsVisibleResponse : IMessage<EntityIsVisibleResponse>, IMessage, IEquatable<EntityIsVisibleResponse>, IDeepCloneable<EntityIsVisibleResponse>, IBufferMessage
	{
		// Token: 0x060070BE RID: 28862 RVA: 0x00114B72 File Offset: 0x00112D72
		[NullableContext(1)]
		public static EntityIsVisibleResponse Create()
		{
			return new EntityIsVisibleResponse();
		}

		// Token: 0x170015BB RID: 5563
		// (get) Token: 0x060070BF RID: 28863 RVA: 0x00114B79 File Offset: 0x00112D79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015BC RID: 5564
		// (get) Token: 0x060070C0 RID: 28864 RVA: 0x00114B7C File Offset: 0x00112D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityIsVisibleResponse.Descriptor;
			}
		}

		// Token: 0x060070C1 RID: 28865 RVA: 0x00114B83 File Offset: 0x00112D83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityIsVisibleResponse()
		{
		}

		// Token: 0x060070C2 RID: 28866 RVA: 0x00114B8B File Offset: 0x00112D8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityIsVisibleResponse(EntityIsVisibleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060070C3 RID: 28867 RVA: 0x00114BB0 File Offset: 0x00112DB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityIsVisibleResponse Clone()
		{
			return new EntityIsVisibleResponse(this);
		}

		// Token: 0x170015BD RID: 5565
		// (get) Token: 0x060070C4 RID: 28868 RVA: 0x00114BB8 File Offset: 0x00112DB8
		// (set) Token: 0x060070C5 RID: 28869 RVA: 0x00114BC0 File Offset: 0x00112DC0
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

		// Token: 0x060070C6 RID: 28870 RVA: 0x00114BC9 File Offset: 0x00112DC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityIsVisibleResponse);
		}

		// Token: 0x060070C7 RID: 28871 RVA: 0x00114BD7 File Offset: 0x00112DD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityIsVisibleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060070C8 RID: 28872 RVA: 0x00114C08 File Offset: 0x00112E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060070C9 RID: 28873 RVA: 0x00114C4D File Offset: 0x00112E4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060070CA RID: 28874 RVA: 0x00114C5A File Offset: 0x00112E5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060070CB RID: 28875 RVA: 0x00114C63 File Offset: 0x00112E63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060070CC RID: 28876 RVA: 0x00114C98 File Offset: 0x00112E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060070CD RID: 28877 RVA: 0x00114CD6 File Offset: 0x00112ED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityIsVisibleResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060070CE RID: 28878 RVA: 0x00114D07 File Offset: 0x00112F07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060070CF RID: 28879 RVA: 0x00114D10 File Offset: 0x00112F10
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003C51 RID: 15441
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C52 RID: 15442
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04003C53 RID: 15443
		private ErrorCode errorCode_;
	}
}
