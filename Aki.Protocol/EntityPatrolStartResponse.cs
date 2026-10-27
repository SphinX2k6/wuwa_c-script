using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004AD RID: 1197
	[NetMessage(EMessageId.EntityPatrolStartResponse)]
	public sealed class EntityPatrolStartResponse : IMessage<EntityPatrolStartResponse>, IMessage, IEquatable<EntityPatrolStartResponse>, IDeepCloneable<EntityPatrolStartResponse>, IBufferMessage
	{
		// Token: 0x06007201 RID: 29185 RVA: 0x00117633 File Offset: 0x00115833
		[NullableContext(1)]
		public static EntityPatrolStartResponse Create()
		{
			return new EntityPatrolStartResponse();
		}

		// Token: 0x170015FD RID: 5629
		// (get) Token: 0x06007202 RID: 29186 RVA: 0x0011763A File Offset: 0x0011583A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015FE RID: 5630
		// (get) Token: 0x06007203 RID: 29187 RVA: 0x0011763D File Offset: 0x0011583D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityPatrolStartResponse.Descriptor;
			}
		}

		// Token: 0x06007204 RID: 29188 RVA: 0x00117644 File Offset: 0x00115844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolStartResponse()
		{
		}

		// Token: 0x06007205 RID: 29189 RVA: 0x0011764C File Offset: 0x0011584C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolStartResponse(EntityPatrolStartResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007206 RID: 29190 RVA: 0x00117671 File Offset: 0x00115871
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolStartResponse Clone()
		{
			return new EntityPatrolStartResponse(this);
		}

		// Token: 0x170015FF RID: 5631
		// (get) Token: 0x06007207 RID: 29191 RVA: 0x00117679 File Offset: 0x00115879
		// (set) Token: 0x06007208 RID: 29192 RVA: 0x00117681 File Offset: 0x00115881
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

		// Token: 0x06007209 RID: 29193 RVA: 0x0011768A File Offset: 0x0011588A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityPatrolStartResponse);
		}

		// Token: 0x0600720A RID: 29194 RVA: 0x00117698 File Offset: 0x00115898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityPatrolStartResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600720B RID: 29195 RVA: 0x001176C8 File Offset: 0x001158C8
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

		// Token: 0x0600720C RID: 29196 RVA: 0x0011770D File Offset: 0x0011590D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600720D RID: 29197 RVA: 0x0011771A File Offset: 0x0011591A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600720E RID: 29198 RVA: 0x00117723 File Offset: 0x00115923
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600720F RID: 29199 RVA: 0x00117758 File Offset: 0x00115958
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

		// Token: 0x06007210 RID: 29200 RVA: 0x00117796 File Offset: 0x00115996
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityPatrolStartResponse other)
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

		// Token: 0x06007211 RID: 29201 RVA: 0x001177C7 File Offset: 0x001159C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007212 RID: 29202 RVA: 0x001177D0 File Offset: 0x001159D0
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003CA5 RID: 15525
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003CA6 RID: 15526
		public const int CodeFieldNumber = 11;

		// Token: 0x04003CA7 RID: 15527
		private ErrorCode code_;
	}
}
