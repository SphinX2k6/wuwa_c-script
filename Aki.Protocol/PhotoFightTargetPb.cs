using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D1F RID: 3359
	public sealed class PhotoFightTargetPb : IMessage<PhotoFightTargetPb>, IMessage, IEquatable<PhotoFightTargetPb>, IDeepCloneable<PhotoFightTargetPb>, IBufferMessage
	{
		// Token: 0x06012295 RID: 74389 RVA: 0x002A784D File Offset: 0x002A5A4D
		[NullableContext(1)]
		public static PhotoFightTargetPb Create()
		{
			return new PhotoFightTargetPb();
		}

		// Token: 0x17003C2F RID: 15407
		// (get) Token: 0x06012296 RID: 74390 RVA: 0x002A7854 File Offset: 0x002A5A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhotoFightTargetPb> Parser
		{
			get
			{
				return PhotoFightTargetPb._parser;
			}
		}

		// Token: 0x17003C30 RID: 15408
		// (get) Token: 0x06012297 RID: 74391 RVA: 0x002A785B File Offset: 0x002A5A5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C31 RID: 15409
		// (get) Token: 0x06012298 RID: 74392 RVA: 0x002A785E File Offset: 0x002A5A5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhotoFightTargetPb.Descriptor;
			}
		}

		// Token: 0x06012299 RID: 74393 RVA: 0x002A7865 File Offset: 0x002A5A65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightTargetPb()
		{
		}

		// Token: 0x0601229A RID: 74394 RVA: 0x002A7878 File Offset: 0x002A5A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightTargetPb(PhotoFightTargetPb other) : this()
		{
			this.id_ = other.id_;
			this.status_ = other.status_;
			this.preItemMap_ = other.preItemMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601229B RID: 74395 RVA: 0x002A78C5 File Offset: 0x002A5AC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightTargetPb Clone()
		{
			return new PhotoFightTargetPb(this);
		}

		// Token: 0x17003C32 RID: 15410
		// (get) Token: 0x0601229C RID: 74396 RVA: 0x002A78CD File Offset: 0x002A5ACD
		// (set) Token: 0x0601229D RID: 74397 RVA: 0x002A78D5 File Offset: 0x002A5AD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17003C33 RID: 15411
		// (get) Token: 0x0601229E RID: 74398 RVA: 0x002A78DE File Offset: 0x002A5ADE
		// (set) Token: 0x0601229F RID: 74399 RVA: 0x002A78E6 File Offset: 0x002A5AE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityTaskState Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x17003C34 RID: 15412
		// (get) Token: 0x060122A0 RID: 74400 RVA: 0x002A78EF File Offset: 0x002A5AEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> PreItemMap
		{
			get
			{
				return this.preItemMap_;
			}
		}

		// Token: 0x060122A1 RID: 74401 RVA: 0x002A78F7 File Offset: 0x002A5AF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhotoFightTargetPb);
		}

		// Token: 0x060122A2 RID: 74402 RVA: 0x002A7908 File Offset: 0x002A5B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhotoFightTargetPb other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Status == other.Status && this.PreItemMap.Equals(other.PreItemMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060122A3 RID: 74403 RVA: 0x002A7968 File Offset: 0x002A5B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Status != ActivityTaskState.ActivityTaskRunning)
			{
				num ^= this.Status.GetHashCode();
			}
			num ^= this.PreItemMap.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060122A4 RID: 74404 RVA: 0x002A79D4 File Offset: 0x002A5BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060122A5 RID: 74405 RVA: 0x002A79E1 File Offset: 0x002A5BE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060122A6 RID: 74406 RVA: 0x002A79EC File Offset: 0x002A5BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Status != ActivityTaskState.ActivityTaskRunning)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Status);
			}
			this.preItemMap_.WriteTo(ref output, PhotoFightTargetPb._map_preItemMap_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060122A7 RID: 74407 RVA: 0x002A7A58 File Offset: 0x002A5C58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Status != ActivityTaskState.ActivityTaskRunning)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			num += this.preItemMap_.CalculateSize(PhotoFightTargetPb._map_preItemMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060122A8 RID: 74408 RVA: 0x002A7AC4 File Offset: 0x002A5CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhotoFightTargetPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Status != ActivityTaskState.ActivityTaskRunning)
			{
				this.Status = other.Status;
			}
			this.preItemMap_.MergeFrom(other.preItemMap_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060122A9 RID: 74409 RVA: 0x002A7B25 File Offset: 0x002A5D25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060122AA RID: 74410 RVA: 0x002A7B30 File Offset: 0x002A5D30
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
				if (num != 8U)
				{
					if (num != 32U)
					{
						if (num != 42U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.preItemMap_.AddEntriesFrom(ref input, PhotoFightTargetPb._map_preItemMap_codec);
						}
					}
					else
					{
						this.Status = (ActivityTaskState)input.ReadEnum();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040071DE RID: 29150
		private static readonly MessageParser<PhotoFightTargetPb> _parser = new MessageParser<PhotoFightTargetPb>(() => new PhotoFightTargetPb());

		// Token: 0x040071DF RID: 29151
		private UnknownFieldSet _unknownFields;

		// Token: 0x040071E0 RID: 29152
		public const int IdFieldNumber = 1;

		// Token: 0x040071E1 RID: 29153
		private int id_;

		// Token: 0x040071E2 RID: 29154
		public const int StatusFieldNumber = 4;

		// Token: 0x040071E3 RID: 29155
		private ActivityTaskState status_;

		// Token: 0x040071E4 RID: 29156
		public const int PreItemMapFieldNumber = 5;

		// Token: 0x040071E5 RID: 29157
		private static readonly MapField<int, int>.Codec _map_preItemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 42U);

		// Token: 0x040071E6 RID: 29158
		private readonly MapField<int, int> preItemMap_ = new MapField<int, int>();
	}
}
