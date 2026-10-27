using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001270 RID: 4720
	[NetMessage(EMessageId.SplinePositionUpdateRequest)]
	public sealed class SplinePositionUpdateRequest : IMessage<SplinePositionUpdateRequest>, IMessage, IEquatable<SplinePositionUpdateRequest>, IDeepCloneable<SplinePositionUpdateRequest>, IBufferMessage
	{
		// Token: 0x06019248 RID: 102984 RVA: 0x003A843E File Offset: 0x003A663E
		[NullableContext(1)]
		public static SplinePositionUpdateRequest Create()
		{
			return new SplinePositionUpdateRequest();
		}

		// Token: 0x170054CD RID: 21709
		// (get) Token: 0x06019249 RID: 102985 RVA: 0x003A8445 File Offset: 0x003A6645
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170054CE RID: 21710
		// (get) Token: 0x0601924A RID: 102986 RVA: 0x003A8448 File Offset: 0x003A6648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SplinePositionUpdateRequest.Descriptor;
			}
		}

		// Token: 0x0601924B RID: 102987 RVA: 0x003A844F File Offset: 0x003A664F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SplinePositionUpdateRequest()
		{
		}

		// Token: 0x0601924C RID: 102988 RVA: 0x003A8458 File Offset: 0x003A6658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SplinePositionUpdateRequest(SplinePositionUpdateRequest other) : this()
		{
			this.instId_ = other.instId_;
			this.splineId_ = other.splineId_;
			this.splineIdx_ = other.splineIdx_;
			this.entityId_ = other.entityId_;
			this.dir_ = other.dir_;
			this.splineType_ = other.splineType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601924D RID: 102989 RVA: 0x003A84C4 File Offset: 0x003A66C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SplinePositionUpdateRequest Clone()
		{
			return new SplinePositionUpdateRequest(this);
		}

		// Token: 0x170054CF RID: 21711
		// (get) Token: 0x0601924E RID: 102990 RVA: 0x003A84CC File Offset: 0x003A66CC
		// (set) Token: 0x0601924F RID: 102991 RVA: 0x003A84D4 File Offset: 0x003A66D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x170054D0 RID: 21712
		// (get) Token: 0x06019250 RID: 102992 RVA: 0x003A84DD File Offset: 0x003A66DD
		// (set) Token: 0x06019251 RID: 102993 RVA: 0x003A84E5 File Offset: 0x003A66E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SplineId
		{
			get
			{
				return this.splineId_;
			}
			set
			{
				this.splineId_ = value;
			}
		}

		// Token: 0x170054D1 RID: 21713
		// (get) Token: 0x06019252 RID: 102994 RVA: 0x003A84EE File Offset: 0x003A66EE
		// (set) Token: 0x06019253 RID: 102995 RVA: 0x003A84F6 File Offset: 0x003A66F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SplineIdx
		{
			get
			{
				return this.splineIdx_;
			}
			set
			{
				this.splineIdx_ = value;
			}
		}

		// Token: 0x170054D2 RID: 21714
		// (get) Token: 0x06019254 RID: 102996 RVA: 0x003A84FF File Offset: 0x003A66FF
		// (set) Token: 0x06019255 RID: 102997 RVA: 0x003A8507 File Offset: 0x003A6707
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

		// Token: 0x170054D3 RID: 21715
		// (get) Token: 0x06019256 RID: 102998 RVA: 0x003A8510 File Offset: 0x003A6710
		// (set) Token: 0x06019257 RID: 102999 RVA: 0x003A8518 File Offset: 0x003A6718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Dir
		{
			get
			{
				return this.dir_;
			}
			set
			{
				this.dir_ = value;
			}
		}

		// Token: 0x170054D4 RID: 21716
		// (get) Token: 0x06019258 RID: 103000 RVA: 0x003A8521 File Offset: 0x003A6721
		// (set) Token: 0x06019259 RID: 103001 RVA: 0x003A8529 File Offset: 0x003A6729
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcTimeScheduleSplineType SplineType
		{
			get
			{
				return this.splineType_;
			}
			set
			{
				this.splineType_ = value;
			}
		}

		// Token: 0x0601925A RID: 103002 RVA: 0x003A8532 File Offset: 0x003A6732
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SplinePositionUpdateRequest);
		}

		// Token: 0x0601925B RID: 103003 RVA: 0x003A8540 File Offset: 0x003A6740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SplinePositionUpdateRequest other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.SplineId == other.SplineId && this.SplineIdx == other.SplineIdx && this.EntityId == other.EntityId && this.Dir == other.Dir && this.SplineType == other.SplineType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601925C RID: 103004 RVA: 0x003A85CC File Offset: 0x003A67CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.SplineId != 0)
			{
				num ^= this.SplineId.GetHashCode();
			}
			if (this.SplineIdx != 0)
			{
				num ^= this.SplineIdx.GetHashCode();
			}
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.Dir)
			{
				num ^= this.Dir.GetHashCode();
			}
			if (this.SplineType != NpcTimeScheduleSplineType.PathSpline)
			{
				num ^= this.SplineType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601925D RID: 103005 RVA: 0x003A868F File Offset: 0x003A688F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601925E RID: 103006 RVA: 0x003A869C File Offset: 0x003A689C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601925F RID: 103007 RVA: 0x003A86A8 File Offset: 0x003A68A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SplineIdx != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SplineIdx);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.InstId);
			}
			if (this.Dir)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.Dir);
			}
			if (this.SplineType != NpcTimeScheduleSplineType.PathSpline)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.SplineType);
			}
			if (this.SplineId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.SplineId);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019260 RID: 103008 RVA: 0x003A8770 File Offset: 0x003A6970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.SplineId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SplineId);
			}
			if (this.SplineIdx != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SplineIdx);
			}
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.Dir)
			{
				num += 2;
			}
			if (this.SplineType != NpcTimeScheduleSplineType.PathSpline)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.SplineType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019261 RID: 103009 RVA: 0x003A881C File Offset: 0x003A6A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SplinePositionUpdateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.SplineId != 0)
			{
				this.SplineId = other.SplineId;
			}
			if (other.SplineIdx != 0)
			{
				this.SplineIdx = other.SplineIdx;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.Dir)
			{
				this.Dir = other.Dir;
			}
			if (other.SplineType != NpcTimeScheduleSplineType.PathSpline)
			{
				this.SplineType = other.SplineType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019262 RID: 103010 RVA: 0x003A88BC File Offset: 0x003A6ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019263 RID: 103011 RVA: 0x003A88C8 File Offset: 0x003A6AC8
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
				if (num <= 40U)
				{
					if (num == 8U)
					{
						this.SplineIdx = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.InstId = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.Dir = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.SplineType = (NpcTimeScheduleSplineType)input.ReadEnum();
						continue;
					}
					if (num == 88U)
					{
						this.SplineId = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040093FC RID: 37884
		private UnknownFieldSet _unknownFields;

		// Token: 0x040093FD RID: 37885
		public const int InstIdFieldNumber = 4;

		// Token: 0x040093FE RID: 37886
		private int instId_;

		// Token: 0x040093FF RID: 37887
		public const int SplineIdFieldNumber = 11;

		// Token: 0x04009400 RID: 37888
		private int splineId_;

		// Token: 0x04009401 RID: 37889
		public const int SplineIdxFieldNumber = 1;

		// Token: 0x04009402 RID: 37890
		private int splineIdx_;

		// Token: 0x04009403 RID: 37891
		public const int EntityIdFieldNumber = 12;

		// Token: 0x04009404 RID: 37892
		private long entityId_;

		// Token: 0x04009405 RID: 37893
		public const int DirFieldNumber = 5;

		// Token: 0x04009406 RID: 37894
		private bool dir_;

		// Token: 0x04009407 RID: 37895
		public const int SplineTypeFieldNumber = 9;

		// Token: 0x04009408 RID: 37896
		private NpcTimeScheduleSplineType splineType_;
	}
}
