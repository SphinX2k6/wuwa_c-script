using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008E2 RID: 2274
	[NetMessage(EMessageId.LandingDamageRequest)]
	public sealed class LandingDamageRequest : IMessage<LandingDamageRequest>, IMessage, IEquatable<LandingDamageRequest>, IDeepCloneable<LandingDamageRequest>, IBufferMessage
	{
		// Token: 0x0600C93E RID: 51518 RVA: 0x001DBC58 File Offset: 0x001D9E58
		[NullableContext(1)]
		public static LandingDamageRequest Create()
		{
			return new LandingDamageRequest();
		}

		// Token: 0x170028A7 RID: 10407
		// (get) Token: 0x0600C93F RID: 51519 RVA: 0x001DBC5F File Offset: 0x001D9E5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028A8 RID: 10408
		// (get) Token: 0x0600C940 RID: 51520 RVA: 0x001DBC62 File Offset: 0x001D9E62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LandingDamageRequest.Descriptor;
			}
		}

		// Token: 0x0600C941 RID: 51521 RVA: 0x001DBC69 File Offset: 0x001D9E69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LandingDamageRequest()
		{
		}

		// Token: 0x0600C942 RID: 51522 RVA: 0x001DBC71 File Offset: 0x001D9E71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LandingDamageRequest(LandingDamageRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.speedZ_ = other.speedZ_;
			this.timeExceeding_ = other.timeExceeding_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C943 RID: 51523 RVA: 0x001DBCAE File Offset: 0x001D9EAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LandingDamageRequest Clone()
		{
			return new LandingDamageRequest(this);
		}

		// Token: 0x170028A9 RID: 10409
		// (get) Token: 0x0600C944 RID: 51524 RVA: 0x001DBCB6 File Offset: 0x001D9EB6
		// (set) Token: 0x0600C945 RID: 51525 RVA: 0x001DBCBE File Offset: 0x001D9EBE
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

		// Token: 0x170028AA RID: 10410
		// (get) Token: 0x0600C946 RID: 51526 RVA: 0x001DBCC7 File Offset: 0x001D9EC7
		// (set) Token: 0x0600C947 RID: 51527 RVA: 0x001DBCCF File Offset: 0x001D9ECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float SpeedZ
		{
			get
			{
				return this.speedZ_;
			}
			set
			{
				this.speedZ_ = value;
			}
		}

		// Token: 0x170028AB RID: 10411
		// (get) Token: 0x0600C948 RID: 51528 RVA: 0x001DBCD8 File Offset: 0x001D9ED8
		// (set) Token: 0x0600C949 RID: 51529 RVA: 0x001DBCE0 File Offset: 0x001D9EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TimeExceeding
		{
			get
			{
				return this.timeExceeding_;
			}
			set
			{
				this.timeExceeding_ = value;
			}
		}

		// Token: 0x0600C94A RID: 51530 RVA: 0x001DBCE9 File Offset: 0x001D9EE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LandingDamageRequest);
		}

		// Token: 0x0600C94B RID: 51531 RVA: 0x001DBCF8 File Offset: 0x001D9EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LandingDamageRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.SpeedZ, other.SpeedZ) && this.TimeExceeding == other.TimeExceeding && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C94C RID: 51532 RVA: 0x001DBD5C File Offset: 0x001D9F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.SpeedZ != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.SpeedZ);
			}
			if (this.TimeExceeding != 0)
			{
				num ^= this.TimeExceeding.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C94D RID: 51533 RVA: 0x001DBDD4 File Offset: 0x001D9FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C94E RID: 51534 RVA: 0x001DBDE1 File Offset: 0x001D9FE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C94F RID: 51535 RVA: 0x001DBDEC File Offset: 0x001D9FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EntityId);
			}
			if (this.TimeExceeding != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.TimeExceeding);
			}
			if (this.SpeedZ != 0f)
			{
				output.WriteRawTag(125);
				output.WriteFloat(this.SpeedZ);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C950 RID: 51536 RVA: 0x001DBE68 File Offset: 0x001DA068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.SpeedZ != 0f)
			{
				num += 5;
			}
			if (this.TimeExceeding != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TimeExceeding);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C951 RID: 51537 RVA: 0x001DBED0 File Offset: 0x001DA0D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LandingDamageRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.SpeedZ != 0f)
			{
				this.SpeedZ = other.SpeedZ;
			}
			if (other.TimeExceeding != 0)
			{
				this.TimeExceeding = other.TimeExceeding;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C952 RID: 51538 RVA: 0x001DBF39 File Offset: 0x001DA139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C953 RID: 51539 RVA: 0x001DBF44 File Offset: 0x001DA144
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
					if (num != 88U)
					{
						if (num != 125U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.SpeedZ = input.ReadFloat();
						}
					}
					else
					{
						this.TimeExceeding = input.ReadInt32();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040055E4 RID: 21988
		private UnknownFieldSet _unknownFields;

		// Token: 0x040055E5 RID: 21989
		public const int EntityIdFieldNumber = 2;

		// Token: 0x040055E6 RID: 21990
		private long entityId_;

		// Token: 0x040055E7 RID: 21991
		public const int SpeedZFieldNumber = 15;

		// Token: 0x040055E8 RID: 21992
		private float speedZ_;

		// Token: 0x040055E9 RID: 21993
		public const int TimeExceedingFieldNumber = 11;

		// Token: 0x040055EA RID: 21994
		private int timeExceeding_;
	}
}
