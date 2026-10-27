using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004AB RID: 1195
	[NetMessage(EMessageId.EntityPatrolChangeDirResponse)]
	public sealed class EntityPatrolChangeDirResponse : IMessage<EntityPatrolChangeDirResponse>, IMessage, IEquatable<EntityPatrolChangeDirResponse>, IDeepCloneable<EntityPatrolChangeDirResponse>, IBufferMessage
	{
		// Token: 0x060071DB RID: 29147 RVA: 0x001171C7 File Offset: 0x001153C7
		[NullableContext(1)]
		public static EntityPatrolChangeDirResponse Create()
		{
			return new EntityPatrolChangeDirResponse();
		}

		// Token: 0x170015F6 RID: 5622
		// (get) Token: 0x060071DC RID: 29148 RVA: 0x001171CE File Offset: 0x001153CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015F7 RID: 5623
		// (get) Token: 0x060071DD RID: 29149 RVA: 0x001171D1 File Offset: 0x001153D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityPatrolChangeDirResponse.Descriptor;
			}
		}

		// Token: 0x060071DE RID: 29150 RVA: 0x001171D8 File Offset: 0x001153D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolChangeDirResponse()
		{
		}

		// Token: 0x060071DF RID: 29151 RVA: 0x001171E0 File Offset: 0x001153E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolChangeDirResponse(EntityPatrolChangeDirResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060071E0 RID: 29152 RVA: 0x00117205 File Offset: 0x00115405
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolChangeDirResponse Clone()
		{
			return new EntityPatrolChangeDirResponse(this);
		}

		// Token: 0x170015F8 RID: 5624
		// (get) Token: 0x060071E1 RID: 29153 RVA: 0x0011720D File Offset: 0x0011540D
		// (set) Token: 0x060071E2 RID: 29154 RVA: 0x00117215 File Offset: 0x00115415
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

		// Token: 0x060071E3 RID: 29155 RVA: 0x0011721E File Offset: 0x0011541E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityPatrolChangeDirResponse);
		}

		// Token: 0x060071E4 RID: 29156 RVA: 0x0011722C File Offset: 0x0011542C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityPatrolChangeDirResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060071E5 RID: 29157 RVA: 0x0011725C File Offset: 0x0011545C
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

		// Token: 0x060071E6 RID: 29158 RVA: 0x001172A1 File Offset: 0x001154A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060071E7 RID: 29159 RVA: 0x001172AE File Offset: 0x001154AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060071E8 RID: 29160 RVA: 0x001172B7 File Offset: 0x001154B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060071E9 RID: 29161 RVA: 0x001172EC File Offset: 0x001154EC
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

		// Token: 0x060071EA RID: 29162 RVA: 0x0011732A File Offset: 0x0011552A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityPatrolChangeDirResponse other)
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

		// Token: 0x060071EB RID: 29163 RVA: 0x0011735B File Offset: 0x0011555B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060071EC RID: 29164 RVA: 0x00117364 File Offset: 0x00115564
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003C9D RID: 15517
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C9E RID: 15518
		public const int CodeFieldNumber = 15;

		// Token: 0x04003C9F RID: 15519
		private ErrorCode code_;
	}
}
