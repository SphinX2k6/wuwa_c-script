using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012D1 RID: 4817
	public sealed class SurvivorsMonsterKilledCtxPb : IMessage<SurvivorsMonsterKilledCtxPb>, IMessage, IEquatable<SurvivorsMonsterKilledCtxPb>, IDeepCloneable<SurvivorsMonsterKilledCtxPb>, IBufferMessage
	{
		// Token: 0x06019A0B RID: 104971 RVA: 0x003B9BF5 File Offset: 0x003B7DF5
		[NullableContext(1)]
		public static SurvivorsMonsterKilledCtxPb Create()
		{
			return new SurvivorsMonsterKilledCtxPb();
		}

		// Token: 0x17005675 RID: 22133
		// (get) Token: 0x06019A0C RID: 104972 RVA: 0x003B9BFC File Offset: 0x003B7DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005676 RID: 22134
		// (get) Token: 0x06019A0D RID: 104973 RVA: 0x003B9BFF File Offset: 0x003B7DFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsMonsterKilledCtxPb.Descriptor;
			}
		}

		// Token: 0x06019A0E RID: 104974 RVA: 0x003B9C06 File Offset: 0x003B7E06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsMonsterKilledCtxPb()
		{
		}

		// Token: 0x06019A0F RID: 104975 RVA: 0x003B9C0E File Offset: 0x003B7E0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsMonsterKilledCtxPb(SurvivorsMonsterKilledCtxPb other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019A10 RID: 104976 RVA: 0x003B9C33 File Offset: 0x003B7E33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsMonsterKilledCtxPb Clone()
		{
			return new SurvivorsMonsterKilledCtxPb(this);
		}

		// Token: 0x17005677 RID: 22135
		// (get) Token: 0x06019A11 RID: 104977 RVA: 0x003B9C3B File Offset: 0x003B7E3B
		// (set) Token: 0x06019A12 RID: 104978 RVA: 0x003B9C43 File Offset: 0x003B7E43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
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

		// Token: 0x06019A13 RID: 104979 RVA: 0x003B9C4C File Offset: 0x003B7E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsMonsterKilledCtxPb);
		}

		// Token: 0x06019A14 RID: 104980 RVA: 0x003B9C5A File Offset: 0x003B7E5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsMonsterKilledCtxPb other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019A15 RID: 104981 RVA: 0x003B9C88 File Offset: 0x003B7E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019A16 RID: 104982 RVA: 0x003B9CC7 File Offset: 0x003B7EC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019A17 RID: 104983 RVA: 0x003B9CD4 File Offset: 0x003B7ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019A18 RID: 104984 RVA: 0x003B9CDD File Offset: 0x003B7EDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019A19 RID: 104985 RVA: 0x003B9D10 File Offset: 0x003B7F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019A1A RID: 104986 RVA: 0x003B9D4E File Offset: 0x003B7F4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsMonsterKilledCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019A1B RID: 104987 RVA: 0x003B9D7F File Offset: 0x003B7F7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019A1C RID: 104988 RVA: 0x003B9D88 File Offset: 0x003B7F88
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400964B RID: 38475
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400964C RID: 38476
		public const int EntityIdFieldNumber = 1;

		// Token: 0x0400964D RID: 38477
		private long entityId_;
	}
}
