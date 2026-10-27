using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200038E RID: 910
	[NetMessage(EMessageId.DangoMonopolySceneGridInfoNotify)]
	public sealed class DangoMonopolySceneGridInfoNotify : IMessage<DangoMonopolySceneGridInfoNotify>, IMessage, IEquatable<DangoMonopolySceneGridInfoNotify>, IDeepCloneable<DangoMonopolySceneGridInfoNotify>, IBufferMessage
	{
		// Token: 0x060059EB RID: 23019 RVA: 0x000DAE52 File Offset: 0x000D9052
		[NullableContext(1)]
		public static DangoMonopolySceneGridInfoNotify Create()
		{
			return new DangoMonopolySceneGridInfoNotify();
		}

		// Token: 0x1700109A RID: 4250
		// (get) Token: 0x060059EC RID: 23020 RVA: 0x000DAE59 File Offset: 0x000D9059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700109B RID: 4251
		// (get) Token: 0x060059ED RID: 23021 RVA: 0x000DAE5C File Offset: 0x000D905C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoMonopolySceneGridInfoNotify.Descriptor;
			}
		}

		// Token: 0x060059EE RID: 23022 RVA: 0x000DAE63 File Offset: 0x000D9063
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolySceneGridInfoNotify()
		{
		}

		// Token: 0x060059EF RID: 23023 RVA: 0x000DAE78 File Offset: 0x000D9078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolySceneGridInfoNotify(DangoMonopolySceneGridInfoNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.mainRoleEntityId_ = other.mainRoleEntityId_;
			this.gridInfos_ = other.gridInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060059F0 RID: 23024 RVA: 0x000DAEC5 File Offset: 0x000D90C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolySceneGridInfoNotify Clone()
		{
			return new DangoMonopolySceneGridInfoNotify(this);
		}

		// Token: 0x1700109C RID: 4252
		// (get) Token: 0x060059F1 RID: 23025 RVA: 0x000DAECD File Offset: 0x000D90CD
		// (set) Token: 0x060059F2 RID: 23026 RVA: 0x000DAED5 File Offset: 0x000D90D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x1700109D RID: 4253
		// (get) Token: 0x060059F3 RID: 23027 RVA: 0x000DAEDE File Offset: 0x000D90DE
		// (set) Token: 0x060059F4 RID: 23028 RVA: 0x000DAEE6 File Offset: 0x000D90E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long MainRoleEntityId
		{
			get
			{
				return this.mainRoleEntityId_;
			}
			set
			{
				this.mainRoleEntityId_ = value;
			}
		}

		// Token: 0x1700109E RID: 4254
		// (get) Token: 0x060059F5 RID: 23029 RVA: 0x000DAEEF File Offset: 0x000D90EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, long> GridInfos
		{
			get
			{
				return this.gridInfos_;
			}
		}

		// Token: 0x060059F6 RID: 23030 RVA: 0x000DAEF7 File Offset: 0x000D90F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoMonopolySceneGridInfoNotify);
		}

		// Token: 0x060059F7 RID: 23031 RVA: 0x000DAF08 File Offset: 0x000D9108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoMonopolySceneGridInfoNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.MainRoleEntityId == other.MainRoleEntityId && this.GridInfos.Equals(other.GridInfos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060059F8 RID: 23032 RVA: 0x000DAF68 File Offset: 0x000D9168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.MainRoleEntityId != 0L)
			{
				num ^= this.MainRoleEntityId.GetHashCode();
			}
			num ^= this.GridInfos.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060059F9 RID: 23033 RVA: 0x000DAFCE File Offset: 0x000D91CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060059FA RID: 23034 RVA: 0x000DAFDB File Offset: 0x000D91DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060059FB RID: 23035 RVA: 0x000DAFE4 File Offset: 0x000D91E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ActivityId);
			}
			this.gridInfos_.WriteTo(ref output, DangoMonopolySceneGridInfoNotify._map_gridInfos_codec);
			if (this.MainRoleEntityId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.MainRoleEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060059FC RID: 23036 RVA: 0x000DB050 File Offset: 0x000D9250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.MainRoleEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.MainRoleEntityId);
			}
			num += this.gridInfos_.CalculateSize(DangoMonopolySceneGridInfoNotify._map_gridInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060059FD RID: 23037 RVA: 0x000DB0BC File Offset: 0x000D92BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoMonopolySceneGridInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.MainRoleEntityId != 0L)
			{
				this.MainRoleEntityId = other.MainRoleEntityId;
			}
			this.gridInfos_.MergeFrom(other.gridInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060059FE RID: 23038 RVA: 0x000DB11D File Offset: 0x000D931D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060059FF RID: 23039 RVA: 0x000DB128 File Offset: 0x000D9328
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
					if (num != 82U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.MainRoleEntityId = input.ReadInt64();
						}
					}
					else
					{
						this.gridInfos_.AddEntriesFrom(ref input, DangoMonopolySceneGridInfoNotify._map_gridInfos_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400358A RID: 13706
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400358B RID: 13707
		public const int ActivityIdFieldNumber = 6;

		// Token: 0x0400358C RID: 13708
		private int activityId_;

		// Token: 0x0400358D RID: 13709
		public const int MainRoleEntityIdFieldNumber = 13;

		// Token: 0x0400358E RID: 13710
		private long mainRoleEntityId_;

		// Token: 0x0400358F RID: 13711
		public const int GridInfosFieldNumber = 10;

		// Token: 0x04003590 RID: 13712
		private static readonly MapField<int, long>.Codec _map_gridInfos_codec = new MapField<int, long>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt64(16U, 0L), 82U);

		// Token: 0x04003591 RID: 13713
		private readonly MapField<int, long> gridInfos_ = new MapField<int, long>();
	}
}
