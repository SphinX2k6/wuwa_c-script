using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001549 RID: 5449
	[NetMessage(EMessageId.VehiclePlatformGetOnRequest)]
	public sealed class VehiclePlatformGetOnRequest : IMessage<VehiclePlatformGetOnRequest>, IMessage, IEquatable<VehiclePlatformGetOnRequest>, IDeepCloneable<VehiclePlatformGetOnRequest>, IBufferMessage
	{
		// Token: 0x0601CDD0 RID: 118224 RVA: 0x0042EA3C File Offset: 0x0042CC3C
		[NullableContext(1)]
		public static VehiclePlatformGetOnRequest Create()
		{
			return new VehiclePlatformGetOnRequest();
		}

		// Token: 0x170061A8 RID: 25000
		// (get) Token: 0x0601CDD1 RID: 118225 RVA: 0x0042EA43 File Offset: 0x0042CC43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170061A9 RID: 25001
		// (get) Token: 0x0601CDD2 RID: 118226 RVA: 0x0042EA46 File Offset: 0x0042CC46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VehiclePlatformGetOnRequest.Descriptor;
			}
		}

		// Token: 0x0601CDD3 RID: 118227 RVA: 0x0042EA4D File Offset: 0x0042CC4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehiclePlatformGetOnRequest()
		{
		}

		// Token: 0x0601CDD4 RID: 118228 RVA: 0x0042EA55 File Offset: 0x0042CC55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehiclePlatformGetOnRequest(VehiclePlatformGetOnRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.isGetOn_ = other.isGetOn_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CDD5 RID: 118229 RVA: 0x0042EA86 File Offset: 0x0042CC86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehiclePlatformGetOnRequest Clone()
		{
			return new VehiclePlatformGetOnRequest(this);
		}

		// Token: 0x170061AA RID: 25002
		// (get) Token: 0x0601CDD6 RID: 118230 RVA: 0x0042EA8E File Offset: 0x0042CC8E
		// (set) Token: 0x0601CDD7 RID: 118231 RVA: 0x0042EA96 File Offset: 0x0042CC96
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

		// Token: 0x170061AB RID: 25003
		// (get) Token: 0x0601CDD8 RID: 118232 RVA: 0x0042EA9F File Offset: 0x0042CC9F
		// (set) Token: 0x0601CDD9 RID: 118233 RVA: 0x0042EAA7 File Offset: 0x0042CCA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsGetOn
		{
			get
			{
				return this.isGetOn_;
			}
			set
			{
				this.isGetOn_ = value;
			}
		}

		// Token: 0x0601CDDA RID: 118234 RVA: 0x0042EAB0 File Offset: 0x0042CCB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VehiclePlatformGetOnRequest);
		}

		// Token: 0x0601CDDB RID: 118235 RVA: 0x0042EABE File Offset: 0x0042CCBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VehiclePlatformGetOnRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.IsGetOn == other.IsGetOn && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CDDC RID: 118236 RVA: 0x0042EAFC File Offset: 0x0042CCFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.IsGetOn)
			{
				num ^= this.IsGetOn.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CDDD RID: 118237 RVA: 0x0042EB54 File Offset: 0x0042CD54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CDDE RID: 118238 RVA: 0x0042EB61 File Offset: 0x0042CD61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CDDF RID: 118239 RVA: 0x0042EB6C File Offset: 0x0042CD6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.EntityId);
			}
			if (this.IsGetOn)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsGetOn);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CDE0 RID: 118240 RVA: 0x0042EBC8 File Offset: 0x0042CDC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.IsGetOn)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CDE1 RID: 118241 RVA: 0x0042EC14 File Offset: 0x0042CE14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VehiclePlatformGetOnRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.IsGetOn)
			{
				this.IsGetOn = other.IsGetOn;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CDE2 RID: 118242 RVA: 0x0042EC64 File Offset: 0x0042CE64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CDE3 RID: 118243 RVA: 0x0042EC70 File Offset: 0x0042CE70
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
				if (num != 32U)
				{
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsGetOn = input.ReadBool();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400A603 RID: 42499
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A604 RID: 42500
		public const int EntityIdFieldNumber = 4;

		// Token: 0x0400A605 RID: 42501
		private long entityId_;

		// Token: 0x0400A606 RID: 42502
		public const int IsGetOnFieldNumber = 8;

		// Token: 0x0400A607 RID: 42503
		private bool isGetOn_;
	}
}
