using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B54 RID: 2900
	public sealed class NpcPb : IMessage<NpcPb>, IMessage, IEquatable<NpcPb>, IDeepCloneable<NpcPb>, IBufferMessage
	{
		// Token: 0x0600FB9E RID: 64414 RVA: 0x0024A996 File Offset: 0x00248B96
		[NullableContext(1)]
		public static NpcPb Create()
		{
			return new NpcPb();
		}

		// Token: 0x17003345 RID: 13125
		// (get) Token: 0x0600FB9F RID: 64415 RVA: 0x0024A99D File Offset: 0x00248B9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003346 RID: 13126
		// (get) Token: 0x0600FBA0 RID: 64416 RVA: 0x0024A9A0 File Offset: 0x00248BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcPb.Descriptor;
			}
		}

		// Token: 0x0600FBA1 RID: 64417 RVA: 0x0024A9A7 File Offset: 0x00248BA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPb()
		{
		}

		// Token: 0x0600FBA2 RID: 64418 RVA: 0x0024A9AF File Offset: 0x00248BAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPb(NpcPb other) : this()
		{
			this.splineEntityId_ = other.splineEntityId_;
			this.spawnEntityId_ = other.spawnEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FBA3 RID: 64419 RVA: 0x0024A9E0 File Offset: 0x00248BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPb Clone()
		{
			return new NpcPb(this);
		}

		// Token: 0x17003347 RID: 13127
		// (get) Token: 0x0600FBA4 RID: 64420 RVA: 0x0024A9E8 File Offset: 0x00248BE8
		// (set) Token: 0x0600FBA5 RID: 64421 RVA: 0x0024A9F0 File Offset: 0x00248BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SplineEntityId
		{
			get
			{
				return this.splineEntityId_;
			}
			set
			{
				this.splineEntityId_ = value;
			}
		}

		// Token: 0x17003348 RID: 13128
		// (get) Token: 0x0600FBA6 RID: 64422 RVA: 0x0024A9F9 File Offset: 0x00248BF9
		// (set) Token: 0x0600FBA7 RID: 64423 RVA: 0x0024AA01 File Offset: 0x00248C01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SpawnEntityId
		{
			get
			{
				return this.spawnEntityId_;
			}
			set
			{
				this.spawnEntityId_ = value;
			}
		}

		// Token: 0x0600FBA8 RID: 64424 RVA: 0x0024AA0A File Offset: 0x00248C0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcPb);
		}

		// Token: 0x0600FBA9 RID: 64425 RVA: 0x0024AA18 File Offset: 0x00248C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcPb other)
		{
			return other != null && (other == this || (this.SplineEntityId == other.SplineEntityId && this.SpawnEntityId == other.SpawnEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FBAA RID: 64426 RVA: 0x0024AA58 File Offset: 0x00248C58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SplineEntityId != 0)
			{
				num ^= this.SplineEntityId.GetHashCode();
			}
			if (this.SpawnEntityId != 0)
			{
				num ^= this.SpawnEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FBAB RID: 64427 RVA: 0x0024AAB0 File Offset: 0x00248CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FBAC RID: 64428 RVA: 0x0024AABD File Offset: 0x00248CBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FBAD RID: 64429 RVA: 0x0024AAC8 File Offset: 0x00248CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SplineEntityId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SplineEntityId);
			}
			if (this.SpawnEntityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SpawnEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FBAE RID: 64430 RVA: 0x0024AB24 File Offset: 0x00248D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SplineEntityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SplineEntityId);
			}
			if (this.SpawnEntityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SpawnEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FBAF RID: 64431 RVA: 0x0024AB7C File Offset: 0x00248D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NpcPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SplineEntityId != 0)
			{
				this.SplineEntityId = other.SplineEntityId;
			}
			if (other.SpawnEntityId != 0)
			{
				this.SpawnEntityId = other.SpawnEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FBB0 RID: 64432 RVA: 0x0024ABCC File Offset: 0x00248DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FBB1 RID: 64433 RVA: 0x0024ABD8 File Offset: 0x00248DD8
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
					if (num != 24U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SpawnEntityId = input.ReadInt32();
					}
				}
				else
				{
					this.SplineEntityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040064DF RID: 25823
		private UnknownFieldSet _unknownFields;

		// Token: 0x040064E0 RID: 25824
		public const int SplineEntityIdFieldNumber = 2;

		// Token: 0x040064E1 RID: 25825
		private int splineEntityId_;

		// Token: 0x040064E2 RID: 25826
		public const int SpawnEntityIdFieldNumber = 3;

		// Token: 0x040064E3 RID: 25827
		private int spawnEntityId_;
	}
}
