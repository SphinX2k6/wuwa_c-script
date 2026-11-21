using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000396 RID: 918
	[NetMessage(EMessageId.DangoMonopolySceneGridInfoNotify)]
	public sealed class DangoMonopolySceneGridInfoNotify : IMessage<DangoMonopolySceneGridInfoNotify>, IMessage, IEquatable<DangoMonopolySceneGridInfoNotify>, IDeepCloneable<DangoMonopolySceneGridInfoNotify>, IBufferMessage
	{
		// Token: 0x06005AD8 RID: 23256 RVA: 0x000DD4DA File Offset: 0x000DB6DA
		[NullableContext(1)]
		public static DangoMonopolySceneGridInfoNotify Create()
		{
			return new DangoMonopolySceneGridInfoNotify();
		}

		// Token: 0x170010CB RID: 4299
		// (get) Token: 0x06005AD9 RID: 23257 RVA: 0x000DD4E1 File Offset: 0x000DB6E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010CC RID: 4300
		// (get) Token: 0x06005ADA RID: 23258 RVA: 0x000DD4E4 File Offset: 0x000DB6E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoMonopolySceneGridInfoNotify.Descriptor;
			}
		}

		// Token: 0x06005ADB RID: 23259 RVA: 0x000DD4EB File Offset: 0x000DB6EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolySceneGridInfoNotify()
		{
		}

		// Token: 0x06005ADC RID: 23260 RVA: 0x000DD500 File Offset: 0x000DB700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolySceneGridInfoNotify(DangoMonopolySceneGridInfoNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.mainRoleEntityId_ = other.mainRoleEntityId_;
			this.gridInfos_ = other.gridInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005ADD RID: 23261 RVA: 0x000DD54D File Offset: 0x000DB74D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolySceneGridInfoNotify Clone()
		{
			return new DangoMonopolySceneGridInfoNotify(this);
		}

		// Token: 0x170010CD RID: 4301
		// (get) Token: 0x06005ADE RID: 23262 RVA: 0x000DD555 File Offset: 0x000DB755
		// (set) Token: 0x06005ADF RID: 23263 RVA: 0x000DD55D File Offset: 0x000DB75D
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

		// Token: 0x170010CE RID: 4302
		// (get) Token: 0x06005AE0 RID: 23264 RVA: 0x000DD566 File Offset: 0x000DB766
		// (set) Token: 0x06005AE1 RID: 23265 RVA: 0x000DD56E File Offset: 0x000DB76E
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

		// Token: 0x170010CF RID: 4303
		// (get) Token: 0x06005AE2 RID: 23266 RVA: 0x000DD577 File Offset: 0x000DB777
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, long> GridInfos
		{
			get
			{
				return this.gridInfos_;
			}
		}

		// Token: 0x06005AE3 RID: 23267 RVA: 0x000DD57F File Offset: 0x000DB77F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoMonopolySceneGridInfoNotify);
		}

		// Token: 0x06005AE4 RID: 23268 RVA: 0x000DD590 File Offset: 0x000DB790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoMonopolySceneGridInfoNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.MainRoleEntityId == other.MainRoleEntityId && this.GridInfos.Equals(other.GridInfos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005AE5 RID: 23269 RVA: 0x000DD5F0 File Offset: 0x000DB7F0
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

		// Token: 0x06005AE6 RID: 23270 RVA: 0x000DD656 File Offset: 0x000DB856
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005AE7 RID: 23271 RVA: 0x000DD663 File Offset: 0x000DB863
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005AE8 RID: 23272 RVA: 0x000DD66C File Offset: 0x000DB86C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MainRoleEntityId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.MainRoleEntityId);
			}
			this.gridInfos_.WriteTo(ref output, DangoMonopolySceneGridInfoNotify._map_gridInfos_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005AE9 RID: 23273 RVA: 0x000DD6D8 File Offset: 0x000DB8D8
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

		// Token: 0x06005AEA RID: 23274 RVA: 0x000DD744 File Offset: 0x000DB944
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

		// Token: 0x06005AEB RID: 23275 RVA: 0x000DD7A5 File Offset: 0x000DB9A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005AEC RID: 23276 RVA: 0x000DD7B0 File Offset: 0x000DB9B0
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
					if (num != 58U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ActivityId = input.ReadInt32();
						}
					}
					else
					{
						this.gridInfos_.AddEntriesFrom(ref input, DangoMonopolySceneGridInfoNotify._map_gridInfos_codec);
					}
				}
				else
				{
					this.MainRoleEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003626 RID: 13862
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003627 RID: 13863
		public const int ActivityIdFieldNumber = 15;

		// Token: 0x04003628 RID: 13864
		private int activityId_;

		// Token: 0x04003629 RID: 13865
		public const int MainRoleEntityIdFieldNumber = 4;

		// Token: 0x0400362A RID: 13866
		private long mainRoleEntityId_;

		// Token: 0x0400362B RID: 13867
		public const int GridInfosFieldNumber = 7;

		// Token: 0x0400362C RID: 13868
		private static readonly MapField<int, long>.Codec _map_gridInfos_codec = new MapField<int, long>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt64(16U, 0L), 58U);

		// Token: 0x0400362D RID: 13869
		private readonly MapField<int, long> gridInfos_ = new MapField<int, long>();
	}
}
