using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200049D RID: 1181
	[NetMessage(EMessageId.EntityPreloadNotify)]
	public sealed class EntityPreloadNotify : IMessage<EntityPreloadNotify>, IMessage, IEquatable<EntityPreloadNotify>, IDeepCloneable<EntityPreloadNotify>, IBufferMessage
	{
		// Token: 0x06007128 RID: 28968 RVA: 0x0011662D File Offset: 0x0011482D
		[NullableContext(1)]
		public static EntityPreloadNotify Create()
		{
			return new EntityPreloadNotify();
		}

		// Token: 0x170015DA RID: 5594
		// (get) Token: 0x06007129 RID: 28969 RVA: 0x00116634 File Offset: 0x00114834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015DB RID: 5595
		// (get) Token: 0x0600712A RID: 28970 RVA: 0x00116637 File Offset: 0x00114837
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityPreloadNotify.Descriptor;
			}
		}

		// Token: 0x0600712B RID: 28971 RVA: 0x0011663E File Offset: 0x0011483E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPreloadNotify()
		{
		}

		// Token: 0x0600712C RID: 28972 RVA: 0x00116651 File Offset: 0x00114851
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPreloadNotify(EntityPreloadNotify other) : this()
		{
			this.preloadEntityIds_ = other.preloadEntityIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600712D RID: 28973 RVA: 0x0011667B File Offset: 0x0011487B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPreloadNotify Clone()
		{
			return new EntityPreloadNotify(this);
		}

		// Token: 0x170015DC RID: 5596
		// (get) Token: 0x0600712E RID: 28974 RVA: 0x00116683 File Offset: 0x00114883
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> PreloadEntityIds
		{
			get
			{
				return this.preloadEntityIds_;
			}
		}

		// Token: 0x0600712F RID: 28975 RVA: 0x0011668B File Offset: 0x0011488B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityPreloadNotify);
		}

		// Token: 0x06007130 RID: 28976 RVA: 0x00116699 File Offset: 0x00114899
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityPreloadNotify other)
		{
			return other != null && (other == this || (this.preloadEntityIds_.Equals(other.preloadEntityIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007131 RID: 28977 RVA: 0x001166CC File Offset: 0x001148CC
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

		// Token: 0x06007132 RID: 28978 RVA: 0x00116700 File Offset: 0x00114900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007133 RID: 28979 RVA: 0x0011670D File Offset: 0x0011490D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007134 RID: 28980 RVA: 0x00116716 File Offset: 0x00114916
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

		// Token: 0x06007135 RID: 28981 RVA: 0x00116740 File Offset: 0x00114940
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

		// Token: 0x06007136 RID: 28982 RVA: 0x00116779 File Offset: 0x00114979
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

		// Token: 0x06007137 RID: 28983 RVA: 0x001167A7 File Offset: 0x001149A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007138 RID: 28984 RVA: 0x001167B0 File Offset: 0x001149B0
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
				if (num != 120U && num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.preloadEntityIds_.AddEntriesFrom(ref input, EntityPreloadNotify._repeated_preloadEntityIds_codec);
				}
			}
		}

		// Token: 0x04003CE0 RID: 15584
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003CE1 RID: 15585
		public const int PreloadEntityIdsFieldNumber = 15;

		// Token: 0x04003CE2 RID: 15586
		private static readonly FieldCodec<long> _repeated_preloadEntityIds_codec = FieldCodec.ForInt64(122U);

		// Token: 0x04003CE3 RID: 15587
		private readonly RepeatedField<long> preloadEntityIds_ = new RepeatedField<long>();
	}
}
