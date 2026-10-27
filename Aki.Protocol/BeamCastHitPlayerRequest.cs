using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000182 RID: 386
	[NetMessage(EMessageId.BeamCastHitPlayerRequest)]
	public sealed class BeamCastHitPlayerRequest : IMessage<BeamCastHitPlayerRequest>, IMessage, IEquatable<BeamCastHitPlayerRequest>, IDeepCloneable<BeamCastHitPlayerRequest>, IBufferMessage
	{
		// Token: 0x06002EA9 RID: 11945 RVA: 0x00077FB8 File Offset: 0x000761B8
		[NullableContext(1)]
		public static BeamCastHitPlayerRequest Create()
		{
			return new BeamCastHitPlayerRequest();
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x06002EAA RID: 11946 RVA: 0x00077FBF File Offset: 0x000761BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x06002EAB RID: 11947 RVA: 0x00077FC2 File Offset: 0x000761C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BeamCastHitPlayerRequest.Descriptor;
			}
		}

		// Token: 0x06002EAC RID: 11948 RVA: 0x00077FC9 File Offset: 0x000761C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeamCastHitPlayerRequest()
		{
		}

		// Token: 0x06002EAD RID: 11949 RVA: 0x00077FD1 File Offset: 0x000761D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeamCastHitPlayerRequest(BeamCastHitPlayerRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002EAE RID: 11950 RVA: 0x00077FF6 File Offset: 0x000761F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeamCastHitPlayerRequest Clone()
		{
			return new BeamCastHitPlayerRequest(this);
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x06002EAF RID: 11951 RVA: 0x00077FFE File Offset: 0x000761FE
		// (set) Token: 0x06002EB0 RID: 11952 RVA: 0x00078006 File Offset: 0x00076206
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

		// Token: 0x06002EB1 RID: 11953 RVA: 0x0007800F File Offset: 0x0007620F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BeamCastHitPlayerRequest);
		}

		// Token: 0x06002EB2 RID: 11954 RVA: 0x0007801D File Offset: 0x0007621D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BeamCastHitPlayerRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002EB3 RID: 11955 RVA: 0x0007804C File Offset: 0x0007624C
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

		// Token: 0x06002EB4 RID: 11956 RVA: 0x0007808B File Offset: 0x0007628B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002EB5 RID: 11957 RVA: 0x00078098 File Offset: 0x00076298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002EB6 RID: 11958 RVA: 0x000780A1 File Offset: 0x000762A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002EB7 RID: 11959 RVA: 0x000780D4 File Offset: 0x000762D4
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

		// Token: 0x06002EB8 RID: 11960 RVA: 0x00078112 File Offset: 0x00076312
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BeamCastHitPlayerRequest other)
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

		// Token: 0x06002EB9 RID: 11961 RVA: 0x00078143 File Offset: 0x00076343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002EBA RID: 11962 RVA: 0x0007814C File Offset: 0x0007634C
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04002880 RID: 10368
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002881 RID: 10369
		public const int EntityIdFieldNumber = 3;

		// Token: 0x04002882 RID: 10370
		private long entityId_;
	}
}
