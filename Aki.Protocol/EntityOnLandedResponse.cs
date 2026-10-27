using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004A7 RID: 1191
	[NetMessage(EMessageId.EntityOnLandedResponse)]
	public sealed class EntityOnLandedResponse : IMessage<EntityOnLandedResponse>, IMessage, IEquatable<EntityOnLandedResponse>, IDeepCloneable<EntityOnLandedResponse>, IBufferMessage
	{
		// Token: 0x0600718D RID: 29069 RVA: 0x0011682D File Offset: 0x00114A2D
		[NullableContext(1)]
		public static EntityOnLandedResponse Create()
		{
			return new EntityOnLandedResponse();
		}

		// Token: 0x170015E7 RID: 5607
		// (get) Token: 0x0600718E RID: 29070 RVA: 0x00116834 File Offset: 0x00114A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015E8 RID: 5608
		// (get) Token: 0x0600718F RID: 29071 RVA: 0x00116837 File Offset: 0x00114A37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityOnLandedResponse.Descriptor;
			}
		}

		// Token: 0x06007190 RID: 29072 RVA: 0x0011683E File Offset: 0x00114A3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityOnLandedResponse()
		{
		}

		// Token: 0x06007191 RID: 29073 RVA: 0x00116846 File Offset: 0x00114A46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityOnLandedResponse(EntityOnLandedResponse other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007192 RID: 29074 RVA: 0x0011685F File Offset: 0x00114A5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityOnLandedResponse Clone()
		{
			return new EntityOnLandedResponse(this);
		}

		// Token: 0x06007193 RID: 29075 RVA: 0x00116867 File Offset: 0x00114A67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityOnLandedResponse);
		}

		// Token: 0x06007194 RID: 29076 RVA: 0x00116875 File Offset: 0x00114A75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityOnLandedResponse other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06007195 RID: 29077 RVA: 0x00116894 File Offset: 0x00114A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007196 RID: 29078 RVA: 0x001168BA File Offset: 0x00114ABA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007197 RID: 29079 RVA: 0x001168C7 File Offset: 0x00114AC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007198 RID: 29080 RVA: 0x001168D0 File Offset: 0x00114AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007199 RID: 29081 RVA: 0x001168E8 File Offset: 0x00114AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600719A RID: 29082 RVA: 0x0011690E File Offset: 0x00114B0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityOnLandedResponse other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600719B RID: 29083 RVA: 0x0011692B File Offset: 0x00114B2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600719C RID: 29084 RVA: 0x00116934 File Offset: 0x00114B34
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003C8B RID: 15499
		private UnknownFieldSet _unknownFields;
	}
}
