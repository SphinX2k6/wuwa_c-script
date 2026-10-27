using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004B4 RID: 1204
	[NetMessage(EMessageId.EntityPreloadNotify)]
	public sealed class EntityPreloadNotify : IMessage<EntityPreloadNotify>, IMessage, IEquatable<EntityPreloadNotify>, IDeepCloneable<EntityPreloadNotify>, IBufferMessage
	{
		// Token: 0x060072B8 RID: 29368 RVA: 0x00119751 File Offset: 0x00117951
		[NullableContext(1)]
		public static EntityPreloadNotify Create()
		{
			return new EntityPreloadNotify();
		}

		// Token: 0x1700162F RID: 5679
		// (get) Token: 0x060072B9 RID: 29369 RVA: 0x00119758 File Offset: 0x00117958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001630 RID: 5680
		// (get) Token: 0x060072BA RID: 29370 RVA: 0x0011975B File Offset: 0x0011795B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityPreloadNotify.Descriptor;
			}
		}

		// Token: 0x060072BB RID: 29371 RVA: 0x00119762 File Offset: 0x00117962
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPreloadNotify()
		{
		}

		// Token: 0x060072BC RID: 29372 RVA: 0x00119775 File Offset: 0x00117975
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPreloadNotify(EntityPreloadNotify other) : this()
		{
			this.preloadEntityIds_ = other.preloadEntityIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060072BD RID: 29373 RVA: 0x0011979F File Offset: 0x0011799F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPreloadNotify Clone()
		{
			return new EntityPreloadNotify(this);
		}

		// Token: 0x17001631 RID: 5681
		// (get) Token: 0x060072BE RID: 29374 RVA: 0x001197A7 File Offset: 0x001179A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> PreloadEntityIds
		{
			get
			{
				return this.preloadEntityIds_;
			}
		}

		// Token: 0x060072BF RID: 29375 RVA: 0x001197AF File Offset: 0x001179AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityPreloadNotify);
		}

		// Token: 0x060072C0 RID: 29376 RVA: 0x001197BD File Offset: 0x001179BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityPreloadNotify other)
		{
			return other != null && (other == this || (this.preloadEntityIds_.Equals(other.preloadEntityIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060072C1 RID: 29377 RVA: 0x001197F0 File Offset: 0x001179F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.preloadEntityIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060072C2 RID: 29378 RVA: 0x00119824 File Offset: 0x00117A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060072C3 RID: 29379 RVA: 0x00119831 File Offset: 0x00117A31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060072C4 RID: 29380 RVA: 0x0011983A File Offset: 0x00117A3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.preloadEntityIds_.WriteTo(ref output, EntityPreloadNotify._repeated_preloadEntityIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060072C5 RID: 29381 RVA: 0x00119864 File Offset: 0x00117A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.preloadEntityIds_.CalculateSize(EntityPreloadNotify._repeated_preloadEntityIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060072C6 RID: 29382 RVA: 0x0011989D File Offset: 0x00117A9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityPreloadNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.preloadEntityIds_.Add(other.preloadEntityIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060072C7 RID: 29383 RVA: 0x001198CB File Offset: 0x00117ACB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060072C8 RID: 29384 RVA: 0x001198D4 File Offset: 0x00117AD4
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
				if (num != 104U && num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.preloadEntityIds_.AddEntriesFrom(ref input, EntityPreloadNotify._repeated_preloadEntityIds_codec);
				}
			}
		}

		// Token: 0x04003CF4 RID: 15604
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003CF5 RID: 15605
		public const int PreloadEntityIdsFieldNumber = 13;

		// Token: 0x04003CF6 RID: 15606
		private static readonly FieldCodec<long> _repeated_preloadEntityIds_codec = FieldCodec.ForInt64(106U);

		// Token: 0x04003CF7 RID: 15607
		private readonly RepeatedField<long> preloadEntityIds_ = new RepeatedField<long>();
	}
}
