using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000051 RID: 81
	[NetMessage(EMessageId.AccessPasserbyNpcSpawnerRequest)]
	public sealed class AccessPasserbyNpcSpawnerRequest : IMessage<AccessPasserbyNpcSpawnerRequest>, IMessage, IEquatable<AccessPasserbyNpcSpawnerRequest>, IDeepCloneable<AccessPasserbyNpcSpawnerRequest>, IBufferMessage
	{
		// Token: 0x06001518 RID: 5400 RVA: 0x0003845C File Offset: 0x0003665C
		[NullableContext(1)]
		public static AccessPasserbyNpcSpawnerRequest Create()
		{
			return new AccessPasserbyNpcSpawnerRequest();
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06001519 RID: 5401 RVA: 0x00038463 File Offset: 0x00036663
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600151A RID: 5402 RVA: 0x00038466 File Offset: 0x00036666
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AccessPasserbyNpcSpawnerRequest.Descriptor;
			}
		}

		// Token: 0x0600151B RID: 5403 RVA: 0x0003846D File Offset: 0x0003666D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccessPasserbyNpcSpawnerRequest()
		{
		}

		// Token: 0x0600151C RID: 5404 RVA: 0x00038475 File Offset: 0x00036675
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccessPasserbyNpcSpawnerRequest(AccessPasserbyNpcSpawnerRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.splineConfigId_ = other.splineConfigId_;
			this.isSplneNotValid_ = other.isSplneNotValid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x000384B2 File Offset: 0x000366B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccessPasserbyNpcSpawnerRequest Clone()
		{
			return new AccessPasserbyNpcSpawnerRequest(this);
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x0600151E RID: 5406 RVA: 0x000384BA File Offset: 0x000366BA
		// (set) Token: 0x0600151F RID: 5407 RVA: 0x000384C2 File Offset: 0x000366C2
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

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06001520 RID: 5408 RVA: 0x000384CB File Offset: 0x000366CB
		// (set) Token: 0x06001521 RID: 5409 RVA: 0x000384D3 File Offset: 0x000366D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SplineConfigId
		{
			get
			{
				return this.splineConfigId_;
			}
			set
			{
				this.splineConfigId_ = value;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06001522 RID: 5410 RVA: 0x000384DC File Offset: 0x000366DC
		// (set) Token: 0x06001523 RID: 5411 RVA: 0x000384E4 File Offset: 0x000366E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSplneNotValid
		{
			get
			{
				return this.isSplneNotValid_;
			}
			set
			{
				this.isSplneNotValid_ = value;
			}
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x000384ED File Offset: 0x000366ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AccessPasserbyNpcSpawnerRequest);
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x000384FC File Offset: 0x000366FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AccessPasserbyNpcSpawnerRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.SplineConfigId == other.SplineConfigId && this.IsSplneNotValid == other.IsSplneNotValid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x00038558 File Offset: 0x00036758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.SplineConfigId != 0)
			{
				num ^= this.SplineConfigId.GetHashCode();
			}
			if (this.IsSplneNotValid)
			{
				num ^= this.IsSplneNotValid.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x000385C9 File Offset: 0x000367C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x000385D6 File Offset: 0x000367D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x000385E0 File Offset: 0x000367E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.EntityId);
			}
			if (this.IsSplneNotValid)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsSplneNotValid);
			}
			if (this.SplineConfigId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.SplineConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x00038658 File Offset: 0x00036858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.SplineConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SplineConfigId);
			}
			if (this.IsSplneNotValid)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x000386BC File Offset: 0x000368BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AccessPasserbyNpcSpawnerRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.SplineConfigId != 0)
			{
				this.SplineConfigId = other.SplineConfigId;
			}
			if (other.IsSplneNotValid)
			{
				this.IsSplneNotValid = other.IsSplneNotValid;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x00038720 File Offset: 0x00036920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x0003872C File Offset: 0x0003692C
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
				if (num != 40U)
				{
					if (num != 64U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.SplineConfigId = input.ReadInt32();
						}
					}
					else
					{
						this.IsSplneNotValid = input.ReadBool();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040020D8 RID: 8408
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020D9 RID: 8409
		public const int EntityIdFieldNumber = 5;

		// Token: 0x040020DA RID: 8410
		private long entityId_;

		// Token: 0x040020DB RID: 8411
		public const int SplineConfigIdFieldNumber = 11;

		// Token: 0x040020DC RID: 8412
		private int splineConfigId_;

		// Token: 0x040020DD RID: 8413
		public const int IsSplneNotValidFieldNumber = 8;

		// Token: 0x040020DE RID: 8414
		private bool isSplneNotValid_;
	}
}
