using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200024C RID: 588
	[NetMessage(EMessageId.ChangeEntityStateRequest)]
	public sealed class ChangeEntityStateRequest : IMessage<ChangeEntityStateRequest>, IMessage, IEquatable<ChangeEntityStateRequest>, IDeepCloneable<ChangeEntityStateRequest>, IBufferMessage
	{
		// Token: 0x06003ED1 RID: 16081 RVA: 0x0009ADEB File Offset: 0x00098FEB
		[NullableContext(1)]
		public static ChangeEntityStateRequest Create()
		{
			return new ChangeEntityStateRequest();
		}

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x06003ED2 RID: 16082 RVA: 0x0009ADF2 File Offset: 0x00098FF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x06003ED3 RID: 16083 RVA: 0x0009ADF5 File Offset: 0x00098FF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeEntityStateRequest.Descriptor;
			}
		}

		// Token: 0x06003ED4 RID: 16084 RVA: 0x0009ADFC File Offset: 0x00098FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeEntityStateRequest()
		{
		}

		// Token: 0x06003ED5 RID: 16085 RVA: 0x0009AE04 File Offset: 0x00099004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeEntityStateRequest(ChangeEntityStateRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.stateTagId_ = other.stateTagId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003ED6 RID: 16086 RVA: 0x0009AE35 File Offset: 0x00099035
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeEntityStateRequest Clone()
		{
			return new ChangeEntityStateRequest(this);
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x06003ED7 RID: 16087 RVA: 0x0009AE3D File Offset: 0x0009903D
		// (set) Token: 0x06003ED8 RID: 16088 RVA: 0x0009AE45 File Offset: 0x00099045
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x06003ED9 RID: 16089 RVA: 0x0009AE4E File Offset: 0x0009904E
		// (set) Token: 0x06003EDA RID: 16090 RVA: 0x0009AE56 File Offset: 0x00099056
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StateTagId
		{
			get
			{
				return this.stateTagId_;
			}
			set
			{
				this.stateTagId_ = value;
			}
		}

		// Token: 0x06003EDB RID: 16091 RVA: 0x0009AE5F File Offset: 0x0009905F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeEntityStateRequest);
		}

		// Token: 0x06003EDC RID: 16092 RVA: 0x0009AE6D File Offset: 0x0009906D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeEntityStateRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.StateTagId == other.StateTagId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003EDD RID: 16093 RVA: 0x0009AEAC File Offset: 0x000990AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.StateTagId != 0)
			{
				num ^= this.StateTagId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003EDE RID: 16094 RVA: 0x0009AF04 File Offset: 0x00099104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003EDF RID: 16095 RVA: 0x0009AF11 File Offset: 0x00099111
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003EE0 RID: 16096 RVA: 0x0009AF1C File Offset: 0x0009911C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StateTagId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.StateTagId);
			}
			if (this.EntityId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003EE1 RID: 16097 RVA: 0x0009AF78 File Offset: 0x00099178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityId);
			}
			if (this.StateTagId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StateTagId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003EE2 RID: 16098 RVA: 0x0009AFD0 File Offset: 0x000991D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeEntityStateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0)
			{
				this.EntityId = other.EntityId;
			}
			if (other.StateTagId != 0)
			{
				this.StateTagId = other.StateTagId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003EE3 RID: 16099 RVA: 0x0009B020 File Offset: 0x00099220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003EE4 RID: 16100 RVA: 0x0009B02C File Offset: 0x0009922C
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
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityId = input.ReadInt32();
					}
				}
				else
				{
					this.StateTagId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002CFA RID: 11514
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CFB RID: 11515
		public const int EntityIdFieldNumber = 15;

		// Token: 0x04002CFC RID: 11516
		private int entityId_;

		// Token: 0x04002CFD RID: 11517
		public const int StateTagIdFieldNumber = 2;

		// Token: 0x04002CFE RID: 11518
		private int stateTagId_;
	}
}
