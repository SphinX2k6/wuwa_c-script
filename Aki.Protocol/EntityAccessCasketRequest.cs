using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000447 RID: 1095
	[NetMessage(EMessageId.EntityAccessCasketRequest)]
	public sealed class EntityAccessCasketRequest : IMessage<EntityAccessCasketRequest>, IMessage, IEquatable<EntityAccessCasketRequest>, IDeepCloneable<EntityAccessCasketRequest>, IBufferMessage
	{
		// Token: 0x06006936 RID: 26934 RVA: 0x000FE805 File Offset: 0x000FCA05
		[NullableContext(1)]
		public static EntityAccessCasketRequest Create()
		{
			return new EntityAccessCasketRequest();
		}

		// Token: 0x170013E1 RID: 5089
		// (get) Token: 0x06006937 RID: 26935 RVA: 0x000FE80C File Offset: 0x000FCA0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170013E2 RID: 5090
		// (get) Token: 0x06006938 RID: 26936 RVA: 0x000FE80F File Offset: 0x000FCA0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityAccessCasketRequest.Descriptor;
			}
		}

		// Token: 0x06006939 RID: 26937 RVA: 0x000FE816 File Offset: 0x000FCA16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAccessCasketRequest()
		{
		}

		// Token: 0x0600693A RID: 26938 RVA: 0x000FE82C File Offset: 0x000FCA2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAccessCasketRequest(EntityAccessCasketRequest other) : this()
		{
			this.entityIncId_ = other.entityIncId_;
			this.accessEntityIncIds_ = other.accessEntityIncIds_.Clone();
			this.isEnter_ = other.isEnter_;
			this.casketEntityIncId_ = other.casketEntityIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600693B RID: 26939 RVA: 0x000FE885 File Offset: 0x000FCA85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAccessCasketRequest Clone()
		{
			return new EntityAccessCasketRequest(this);
		}

		// Token: 0x170013E3 RID: 5091
		// (get) Token: 0x0600693C RID: 26940 RVA: 0x000FE88D File Offset: 0x000FCA8D
		// (set) Token: 0x0600693D RID: 26941 RVA: 0x000FE895 File Offset: 0x000FCA95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityIncId
		{
			get
			{
				return this.entityIncId_;
			}
			set
			{
				this.entityIncId_ = value;
			}
		}

		// Token: 0x170013E4 RID: 5092
		// (get) Token: 0x0600693E RID: 26942 RVA: 0x000FE89E File Offset: 0x000FCA9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> AccessEntityIncIds
		{
			get
			{
				return this.accessEntityIncIds_;
			}
		}

		// Token: 0x170013E5 RID: 5093
		// (get) Token: 0x0600693F RID: 26943 RVA: 0x000FE8A6 File Offset: 0x000FCAA6
		// (set) Token: 0x06006940 RID: 26944 RVA: 0x000FE8AE File Offset: 0x000FCAAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsEnter
		{
			get
			{
				return this.isEnter_;
			}
			set
			{
				this.isEnter_ = value;
			}
		}

		// Token: 0x170013E6 RID: 5094
		// (get) Token: 0x06006941 RID: 26945 RVA: 0x000FE8B7 File Offset: 0x000FCAB7
		// (set) Token: 0x06006942 RID: 26946 RVA: 0x000FE8BF File Offset: 0x000FCABF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CasketEntityIncId
		{
			get
			{
				return this.casketEntityIncId_;
			}
			set
			{
				this.casketEntityIncId_ = value;
			}
		}

		// Token: 0x06006943 RID: 26947 RVA: 0x000FE8C8 File Offset: 0x000FCAC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityAccessCasketRequest);
		}

		// Token: 0x06006944 RID: 26948 RVA: 0x000FE8D8 File Offset: 0x000FCAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityAccessCasketRequest other)
		{
			return other != null && (other == this || (this.EntityIncId == other.EntityIncId && this.accessEntityIncIds_.Equals(other.accessEntityIncIds_) && this.IsEnter == other.IsEnter && this.CasketEntityIncId == other.CasketEntityIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006945 RID: 26949 RVA: 0x000FE948 File Offset: 0x000FCB48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityIncId != 0L)
			{
				num ^= this.EntityIncId.GetHashCode();
			}
			num ^= this.accessEntityIncIds_.GetHashCode();
			if (this.IsEnter)
			{
				num ^= this.IsEnter.GetHashCode();
			}
			if (this.CasketEntityIncId != 0L)
			{
				num ^= this.CasketEntityIncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006946 RID: 26950 RVA: 0x000FE9C7 File Offset: 0x000FCBC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006947 RID: 26951 RVA: 0x000FE9D4 File Offset: 0x000FCBD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006948 RID: 26952 RVA: 0x000FE9E0 File Offset: 0x000FCBE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.accessEntityIncIds_.WriteTo(ref output, EntityAccessCasketRequest._repeated_accessEntityIncIds_codec);
			if (this.EntityIncId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.EntityIncId);
			}
			if (this.IsEnter)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsEnter);
			}
			if (this.CasketEntityIncId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.CasketEntityIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006949 RID: 26953 RVA: 0x000FEA68 File Offset: 0x000FCC68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityIncId);
			}
			num += this.accessEntityIncIds_.CalculateSize(EntityAccessCasketRequest._repeated_accessEntityIncIds_codec);
			if (this.IsEnter)
			{
				num += 2;
			}
			if (this.CasketEntityIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CasketEntityIncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600694A RID: 26954 RVA: 0x000FEAE0 File Offset: 0x000FCCE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityAccessCasketRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityIncId != 0L)
			{
				this.EntityIncId = other.EntityIncId;
			}
			this.accessEntityIncIds_.Add(other.accessEntityIncIds_);
			if (other.IsEnter)
			{
				this.IsEnter = other.IsEnter;
			}
			if (other.CasketEntityIncId != 0L)
			{
				this.CasketEntityIncId = other.CasketEntityIncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600694B RID: 26955 RVA: 0x000FEB55 File Offset: 0x000FCD55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600694C RID: 26956 RVA: 0x000FEB60 File Offset: 0x000FCD60
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
				if (num <= 34U)
				{
					if (num == 32U || num == 34U)
					{
						this.accessEntityIncIds_.AddEntriesFrom(ref input, EntityAccessCasketRequest._repeated_accessEntityIncIds_codec);
						continue;
					}
				}
				else
				{
					if (num == 40U)
					{
						this.EntityIncId = input.ReadInt64();
						continue;
					}
					if (num == 88U)
					{
						this.IsEnter = input.ReadBool();
						continue;
					}
					if (num == 112U)
					{
						this.CasketEntityIncId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003A48 RID: 14920
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A49 RID: 14921
		public const int EntityIncIdFieldNumber = 5;

		// Token: 0x04003A4A RID: 14922
		private long entityIncId_;

		// Token: 0x04003A4B RID: 14923
		public const int AccessEntityIncIdsFieldNumber = 4;

		// Token: 0x04003A4C RID: 14924
		private static readonly FieldCodec<long> _repeated_accessEntityIncIds_codec = FieldCodec.ForInt64(34U);

		// Token: 0x04003A4D RID: 14925
		private readonly RepeatedField<long> accessEntityIncIds_ = new RepeatedField<long>();

		// Token: 0x04003A4E RID: 14926
		public const int IsEnterFieldNumber = 11;

		// Token: 0x04003A4F RID: 14927
		private bool isEnter_;

		// Token: 0x04003A50 RID: 14928
		public const int CasketEntityIncIdFieldNumber = 14;

		// Token: 0x04003A51 RID: 14929
		private long casketEntityIncId_;
	}
}
