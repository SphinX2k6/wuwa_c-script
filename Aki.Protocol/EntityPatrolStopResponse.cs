using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004AF RID: 1199
	[NetMessage(EMessageId.EntityPatrolStopResponse)]
	public sealed class EntityPatrolStopResponse : IMessage<EntityPatrolStopResponse>, IMessage, IEquatable<EntityPatrolStopResponse>, IDeepCloneable<EntityPatrolStopResponse>, IBufferMessage
	{
		// Token: 0x06007225 RID: 29221 RVA: 0x001179ED File Offset: 0x00115BED
		[NullableContext(1)]
		public static EntityPatrolStopResponse Create()
		{
			return new EntityPatrolStopResponse();
		}

		// Token: 0x17001603 RID: 5635
		// (get) Token: 0x06007226 RID: 29222 RVA: 0x001179F4 File Offset: 0x00115BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001604 RID: 5636
		// (get) Token: 0x06007227 RID: 29223 RVA: 0x001179F7 File Offset: 0x00115BF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityPatrolStopResponse.Descriptor;
			}
		}

		// Token: 0x06007228 RID: 29224 RVA: 0x001179FE File Offset: 0x00115BFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolStopResponse()
		{
		}

		// Token: 0x06007229 RID: 29225 RVA: 0x00117A06 File Offset: 0x00115C06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolStopResponse(EntityPatrolStopResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600722A RID: 29226 RVA: 0x00117A2B File Offset: 0x00115C2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolStopResponse Clone()
		{
			return new EntityPatrolStopResponse(this);
		}

		// Token: 0x17001605 RID: 5637
		// (get) Token: 0x0600722B RID: 29227 RVA: 0x00117A33 File Offset: 0x00115C33
		// (set) Token: 0x0600722C RID: 29228 RVA: 0x00117A3B File Offset: 0x00115C3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x0600722D RID: 29229 RVA: 0x00117A44 File Offset: 0x00115C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityPatrolStopResponse);
		}

		// Token: 0x0600722E RID: 29230 RVA: 0x00117A52 File Offset: 0x00115C52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityPatrolStopResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600722F RID: 29231 RVA: 0x00117A80 File Offset: 0x00115C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007230 RID: 29232 RVA: 0x00117AC5 File Offset: 0x00115CC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007231 RID: 29233 RVA: 0x00117AD2 File Offset: 0x00115CD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007232 RID: 29234 RVA: 0x00117ADB File Offset: 0x00115CDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007233 RID: 29235 RVA: 0x00117B10 File Offset: 0x00115D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007234 RID: 29236 RVA: 0x00117B4E File Offset: 0x00115D4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityPatrolStopResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007235 RID: 29237 RVA: 0x00117B7F File Offset: 0x00115D7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007236 RID: 29238 RVA: 0x00117B88 File Offset: 0x00115D88
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003CAB RID: 15531
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003CAC RID: 15532
		public const int CodeFieldNumber = 5;

		// Token: 0x04003CAD RID: 15533
		private ErrorCode code_;
	}
}
