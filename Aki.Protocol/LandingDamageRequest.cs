using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008D1 RID: 2257
	[NetMessage(EMessageId.LandingDamageRequest)]
	public sealed class LandingDamageRequest : IMessage<LandingDamageRequest>, IMessage, IEquatable<LandingDamageRequest>, IDeepCloneable<LandingDamageRequest>, IBufferMessage
	{
		// Token: 0x0600C822 RID: 51234 RVA: 0x001D997C File Offset: 0x001D7B7C
		[NullableContext(1)]
		public static LandingDamageRequest Create()
		{
			return new LandingDamageRequest();
		}

		// Token: 0x17002868 RID: 10344
		// (get) Token: 0x0600C823 RID: 51235 RVA: 0x001D9983 File Offset: 0x001D7B83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002869 RID: 10345
		// (get) Token: 0x0600C824 RID: 51236 RVA: 0x001D9986 File Offset: 0x001D7B86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LandingDamageRequest.Descriptor;
			}
		}

		// Token: 0x0600C825 RID: 51237 RVA: 0x001D998D File Offset: 0x001D7B8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LandingDamageRequest()
		{
		}

		// Token: 0x0600C826 RID: 51238 RVA: 0x001D9995 File Offset: 0x001D7B95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LandingDamageRequest(LandingDamageRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.speedZ_ = other.speedZ_;
			this.timeExceeding_ = other.timeExceeding_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C827 RID: 51239 RVA: 0x001D99D2 File Offset: 0x001D7BD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LandingDamageRequest Clone()
		{
			return new LandingDamageRequest(this);
		}

		// Token: 0x1700286A RID: 10346
		// (get) Token: 0x0600C828 RID: 51240 RVA: 0x001D99DA File Offset: 0x001D7BDA
		// (set) Token: 0x0600C829 RID: 51241 RVA: 0x001D99E2 File Offset: 0x001D7BE2
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

		// Token: 0x1700286B RID: 10347
		// (get) Token: 0x0600C82A RID: 51242 RVA: 0x001D99EB File Offset: 0x001D7BEB
		// (set) Token: 0x0600C82B RID: 51243 RVA: 0x001D99F3 File Offset: 0x001D7BF3
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

		// Token: 0x1700286C RID: 10348
		// (get) Token: 0x0600C82C RID: 51244 RVA: 0x001D99FC File Offset: 0x001D7BFC
		// (set) Token: 0x0600C82D RID: 51245 RVA: 0x001D9A04 File Offset: 0x001D7C04
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

		// Token: 0x0600C82E RID: 51246 RVA: 0x001D9A0D File Offset: 0x001D7C0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LandingDamageRequest);
		}

		// Token: 0x0600C82F RID: 51247 RVA: 0x001D9A1C File Offset: 0x001D7C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LandingDamageRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.SpeedZ, other.SpeedZ) && this.TimeExceeding == other.TimeExceeding && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C830 RID: 51248 RVA: 0x001D9A80 File Offset: 0x001D7C80
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

		// Token: 0x0600C831 RID: 51249 RVA: 0x001D9AF8 File Offset: 0x001D7CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C832 RID: 51250 RVA: 0x001D9B05 File Offset: 0x001D7D05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C833 RID: 51251 RVA: 0x001D9B10 File Offset: 0x001D7D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TimeExceeding != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.TimeExceeding);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.EntityId);
			}
			if (this.SpeedZ != 0f)
			{
				output.WriteRawTag(93);
				output.WriteFloat(this.SpeedZ);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C834 RID: 51252 RVA: 0x001D9B8C File Offset: 0x001D7D8C
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

		// Token: 0x0600C835 RID: 51253 RVA: 0x001D9BF4 File Offset: 0x001D7DF4
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

		// Token: 0x0600C836 RID: 51254 RVA: 0x001D9C5D File Offset: 0x001D7E5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C837 RID: 51255 RVA: 0x001D9C68 File Offset: 0x001D7E68
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
					if (num != 64U)
					{
						if (num != 93U)
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
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					this.TimeExceeding = input.ReadInt32();
				}
			}
		}

		// Token: 0x040055EB RID: 21995
		private UnknownFieldSet _unknownFields;

		// Token: 0x040055EC RID: 21996
		public const int EntityIdFieldNumber = 8;

		// Token: 0x040055ED RID: 21997
		private long entityId_;

		// Token: 0x040055EE RID: 21998
		public const int SpeedZFieldNumber = 11;

		// Token: 0x040055EF RID: 21999
		private float speedZ_;

		// Token: 0x040055F0 RID: 22000
		public const int TimeExceedingFieldNumber = 7;

		// Token: 0x040055F1 RID: 22001
		private int timeExceeding_;
	}
}
