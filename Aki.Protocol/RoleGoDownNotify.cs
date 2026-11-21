using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001072 RID: 4210
	[NetMessage(EMessageId.RoleGoDownNotify)]
	public sealed class RoleGoDownNotify : IMessage<RoleGoDownNotify>, IMessage, IEquatable<RoleGoDownNotify>, IDeepCloneable<RoleGoDownNotify>, IBufferMessage
	{
		// Token: 0x0601684B RID: 92235 RVA: 0x00346655 File Offset: 0x00344855
		[NullableContext(1)]
		public static RoleGoDownNotify Create()
		{
			return new RoleGoDownNotify();
		}

		// Token: 0x17004B68 RID: 19304
		// (get) Token: 0x0601684C RID: 92236 RVA: 0x0034665C File Offset: 0x0034485C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B69 RID: 19305
		// (get) Token: 0x0601684D RID: 92237 RVA: 0x0034665F File Offset: 0x0034485F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleGoDownNotify.Descriptor;
			}
		}

		// Token: 0x0601684E RID: 92238 RVA: 0x00346666 File Offset: 0x00344866
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleGoDownNotify()
		{
		}

		// Token: 0x0601684F RID: 92239 RVA: 0x0034666E File Offset: 0x0034486E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleGoDownNotify(RoleGoDownNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016850 RID: 92240 RVA: 0x00346693 File Offset: 0x00344893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleGoDownNotify Clone()
		{
			return new RoleGoDownNotify(this);
		}

		// Token: 0x17004B6A RID: 19306
		// (get) Token: 0x06016851 RID: 92241 RVA: 0x0034669B File Offset: 0x0034489B
		// (set) Token: 0x06016852 RID: 92242 RVA: 0x003466A3 File Offset: 0x003448A3
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

		// Token: 0x06016853 RID: 92243 RVA: 0x003466AC File Offset: 0x003448AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleGoDownNotify);
		}

		// Token: 0x06016854 RID: 92244 RVA: 0x003466BA File Offset: 0x003448BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleGoDownNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016855 RID: 92245 RVA: 0x003466E8 File Offset: 0x003448E8
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

		// Token: 0x06016856 RID: 92246 RVA: 0x00346727 File Offset: 0x00344927
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016857 RID: 92247 RVA: 0x00346734 File Offset: 0x00344934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016858 RID: 92248 RVA: 0x0034673D File Offset: 0x0034493D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016859 RID: 92249 RVA: 0x00346770 File Offset: 0x00344970
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

		// Token: 0x0601685A RID: 92250 RVA: 0x003467AE File Offset: 0x003449AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleGoDownNotify other)
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

		// Token: 0x0601685B RID: 92251 RVA: 0x003467DF File Offset: 0x003449DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601685C RID: 92252 RVA: 0x003467E8 File Offset: 0x003449E8
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04008709 RID: 34569
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400870A RID: 34570
		public const int EntityIdFieldNumber = 6;

		// Token: 0x0400870B RID: 34571
		private long entityId_;
	}
}
