using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200136A RID: 4970
	[NetMessage(EMessageId.ThrowDamageRequest)]
	public sealed class ThrowDamageRequest : IMessage<ThrowDamageRequest>, IMessage, IEquatable<ThrowDamageRequest>, IDeepCloneable<ThrowDamageRequest>, IBufferMessage
	{
		// Token: 0x0601A640 RID: 108096 RVA: 0x003D4DF8 File Offset: 0x003D2FF8
		[NullableContext(1)]
		public static ThrowDamageRequest Create()
		{
			return new ThrowDamageRequest();
		}

		// Token: 0x17005902 RID: 22786
		// (get) Token: 0x0601A641 RID: 108097 RVA: 0x003D4DFF File Offset: 0x003D2FFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005903 RID: 22787
		// (get) Token: 0x0601A642 RID: 108098 RVA: 0x003D4E02 File Offset: 0x003D3002
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ThrowDamageRequest.Descriptor;
			}
		}

		// Token: 0x0601A643 RID: 108099 RVA: 0x003D4E09 File Offset: 0x003D3009
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThrowDamageRequest()
		{
		}

		// Token: 0x0601A644 RID: 108100 RVA: 0x003D4E11 File Offset: 0x003D3011
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThrowDamageRequest(ThrowDamageRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.calculateId_ = other.calculateId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A645 RID: 108101 RVA: 0x003D4E42 File Offset: 0x003D3042
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThrowDamageRequest Clone()
		{
			return new ThrowDamageRequest(this);
		}

		// Token: 0x17005904 RID: 22788
		// (get) Token: 0x0601A646 RID: 108102 RVA: 0x003D4E4A File Offset: 0x003D304A
		// (set) Token: 0x0601A647 RID: 108103 RVA: 0x003D4E52 File Offset: 0x003D3052
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

		// Token: 0x17005905 RID: 22789
		// (get) Token: 0x0601A648 RID: 108104 RVA: 0x003D4E5B File Offset: 0x003D305B
		// (set) Token: 0x0601A649 RID: 108105 RVA: 0x003D4E63 File Offset: 0x003D3063
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CalculateId
		{
			get
			{
				return this.calculateId_;
			}
			set
			{
				this.calculateId_ = value;
			}
		}

		// Token: 0x0601A64A RID: 108106 RVA: 0x003D4E6C File Offset: 0x003D306C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ThrowDamageRequest);
		}

		// Token: 0x0601A64B RID: 108107 RVA: 0x003D4E7A File Offset: 0x003D307A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ThrowDamageRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.CalculateId == other.CalculateId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A64C RID: 108108 RVA: 0x003D4EB8 File Offset: 0x003D30B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.CalculateId != 0L)
			{
				num ^= this.CalculateId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A64D RID: 108109 RVA: 0x003D4F10 File Offset: 0x003D3110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A64E RID: 108110 RVA: 0x003D4F1D File Offset: 0x003D311D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A64F RID: 108111 RVA: 0x003D4F28 File Offset: 0x003D3128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CalculateId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.CalculateId);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A650 RID: 108112 RVA: 0x003D4F84 File Offset: 0x003D3184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.CalculateId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CalculateId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A651 RID: 108113 RVA: 0x003D4FDC File Offset: 0x003D31DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ThrowDamageRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.CalculateId != 0L)
			{
				this.CalculateId = other.CalculateId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A652 RID: 108114 RVA: 0x003D502C File Offset: 0x003D322C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A653 RID: 108115 RVA: 0x003D5038 File Offset: 0x003D3238
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
				if (num != 56U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					this.CalculateId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040099B2 RID: 39346
		private UnknownFieldSet _unknownFields;

		// Token: 0x040099B3 RID: 39347
		public const int EntityIdFieldNumber = 13;

		// Token: 0x040099B4 RID: 39348
		private long entityId_;

		// Token: 0x040099B5 RID: 39349
		public const int CalculateIdFieldNumber = 7;

		// Token: 0x040099B6 RID: 39350
		private long calculateId_;
	}
}
