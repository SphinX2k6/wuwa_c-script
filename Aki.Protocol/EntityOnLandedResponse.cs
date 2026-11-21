using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000490 RID: 1168
	[NetMessage(EMessageId.EntityOnLandedResponse)]
	public sealed class EntityOnLandedResponse : IMessage<EntityOnLandedResponse>, IMessage, IEquatable<EntityOnLandedResponse>, IDeepCloneable<EntityOnLandedResponse>, IBufferMessage
	{
		// Token: 0x06006FFF RID: 28671 RVA: 0x001137B5 File Offset: 0x001119B5
		[NullableContext(1)]
		public static EntityOnLandedResponse Create()
		{
			return new EntityOnLandedResponse();
		}

		// Token: 0x17001593 RID: 5523
		// (get) Token: 0x06007000 RID: 28672 RVA: 0x001137BC File Offset: 0x001119BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001594 RID: 5524
		// (get) Token: 0x06007001 RID: 28673 RVA: 0x001137BF File Offset: 0x001119BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityOnLandedResponse.Descriptor;
			}
		}

		// Token: 0x06007002 RID: 28674 RVA: 0x001137C6 File Offset: 0x001119C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityOnLandedResponse()
		{
		}

		// Token: 0x06007003 RID: 28675 RVA: 0x001137CE File Offset: 0x001119CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityOnLandedResponse(EntityOnLandedResponse other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007004 RID: 28676 RVA: 0x001137E7 File Offset: 0x001119E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityOnLandedResponse Clone()
		{
			return new EntityOnLandedResponse(this);
		}

		// Token: 0x06007005 RID: 28677 RVA: 0x001137EF File Offset: 0x001119EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityOnLandedResponse);
		}

		// Token: 0x06007006 RID: 28678 RVA: 0x001137FD File Offset: 0x001119FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityOnLandedResponse other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06007007 RID: 28679 RVA: 0x0011381C File Offset: 0x00111A1C
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

		// Token: 0x06007008 RID: 28680 RVA: 0x00113842 File Offset: 0x00111A42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007009 RID: 28681 RVA: 0x0011384F File Offset: 0x00111A4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600700A RID: 28682 RVA: 0x00113858 File Offset: 0x00111A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600700B RID: 28683 RVA: 0x00113870 File Offset: 0x00111A70
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

		// Token: 0x0600700C RID: 28684 RVA: 0x00113896 File Offset: 0x00111A96
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

		// Token: 0x0600700D RID: 28685 RVA: 0x001138B3 File Offset: 0x00111AB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600700E RID: 28686 RVA: 0x001138BC File Offset: 0x00111ABC
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

		// Token: 0x04003C79 RID: 15481
		private UnknownFieldSet _unknownFields;
	}
}
