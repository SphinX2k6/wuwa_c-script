using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D2F RID: 3375
	public sealed class PhotoFightTargetPb : IMessage<PhotoFightTargetPb>, IMessage, IEquatable<PhotoFightTargetPb>, IDeepCloneable<PhotoFightTargetPb>, IBufferMessage
	{
		// Token: 0x06012391 RID: 74641 RVA: 0x002A9471 File Offset: 0x002A7671
		[NullableContext(1)]
		public static PhotoFightTargetPb Create()
		{
			return new PhotoFightTargetPb();
		}

		// Token: 0x17003C64 RID: 15460
		// (get) Token: 0x06012392 RID: 74642 RVA: 0x002A9478 File Offset: 0x002A7678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhotoFightTargetPb> Parser
		{
			get
			{
				return PhotoFightTargetPb._parser;
			}
		}

		// Token: 0x17003C65 RID: 15461
		// (get) Token: 0x06012393 RID: 74643 RVA: 0x002A947F File Offset: 0x002A767F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C66 RID: 15462
		// (get) Token: 0x06012394 RID: 74644 RVA: 0x002A9482 File Offset: 0x002A7682
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhotoFightTargetPb.Descriptor;
			}
		}

		// Token: 0x06012395 RID: 74645 RVA: 0x002A9489 File Offset: 0x002A7689
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightTargetPb()
		{
		}

		// Token: 0x06012396 RID: 74646 RVA: 0x002A949C File Offset: 0x002A769C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightTargetPb(PhotoFightTargetPb other) : this()
		{
			this.id_ = other.id_;
			this.status_ = other.status_;
			this.preItemMap_ = other.preItemMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012397 RID: 74647 RVA: 0x002A94E9 File Offset: 0x002A76E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightTargetPb Clone()
		{
			return new PhotoFightTargetPb(this);
		}

		// Token: 0x17003C67 RID: 15463
		// (get) Token: 0x06012398 RID: 74648 RVA: 0x002A94F1 File Offset: 0x002A76F1
		// (set) Token: 0x06012399 RID: 74649 RVA: 0x002A94F9 File Offset: 0x002A76F9
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

		// Token: 0x17003C68 RID: 15464
		// (get) Token: 0x0601239A RID: 74650 RVA: 0x002A9502 File Offset: 0x002A7702
		// (set) Token: 0x0601239B RID: 74651 RVA: 0x002A950A File Offset: 0x002A770A
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

		// Token: 0x17003C69 RID: 15465
		// (get) Token: 0x0601239C RID: 74652 RVA: 0x002A9513 File Offset: 0x002A7713
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> PreItemMap
		{
			get
			{
				return this.preItemMap_;
			}
		}

		// Token: 0x0601239D RID: 74653 RVA: 0x002A951B File Offset: 0x002A771B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhotoFightTargetPb);
		}

		// Token: 0x0601239E RID: 74654 RVA: 0x002A952C File Offset: 0x002A772C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhotoFightTargetPb other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Status == other.Status && this.PreItemMap.Equals(other.PreItemMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601239F RID: 74655 RVA: 0x002A958C File Offset: 0x002A778C
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

		// Token: 0x060123A0 RID: 74656 RVA: 0x002A95F8 File Offset: 0x002A77F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060123A1 RID: 74657 RVA: 0x002A9605 File Offset: 0x002A7805
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060123A2 RID: 74658 RVA: 0x002A9610 File Offset: 0x002A7810
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

		// Token: 0x060123A3 RID: 74659 RVA: 0x002A967C File Offset: 0x002A787C
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

		// Token: 0x060123A4 RID: 74660 RVA: 0x002A96E8 File Offset: 0x002A78E8
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

		// Token: 0x060123A5 RID: 74661 RVA: 0x002A9749 File Offset: 0x002A7949
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060123A6 RID: 74662 RVA: 0x002A9754 File Offset: 0x002A7954
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

		// Token: 0x040071C6 RID: 29126
		private static readonly MessageParser<PhotoFightTargetPb> _parser = new MessageParser<PhotoFightTargetPb>(() => new PhotoFightTargetPb());

		// Token: 0x040071C7 RID: 29127
		private UnknownFieldSet _unknownFields;

		// Token: 0x040071C8 RID: 29128
		public const int IdFieldNumber = 1;

		// Token: 0x040071C9 RID: 29129
		private int id_;

		// Token: 0x040071CA RID: 29130
		public const int StatusFieldNumber = 4;

		// Token: 0x040071CB RID: 29131
		private ActivityTaskState status_;

		// Token: 0x040071CC RID: 29132
		public const int PreItemMapFieldNumber = 5;

		// Token: 0x040071CD RID: 29133
		private static readonly MapField<int, int>.Codec _map_preItemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 42U);

		// Token: 0x040071CE RID: 29134
		private readonly MapField<int, int> preItemMap_ = new MapField<int, int>();
	}
}
