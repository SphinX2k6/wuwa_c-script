using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000693 RID: 1683
	[NetMessage(EMessageId.GameplayCuePush)]
	public sealed class GameplayCuePush : IMessage<GameplayCuePush>, IMessage, IEquatable<GameplayCuePush>, IDeepCloneable<GameplayCuePush>, IBufferMessage
	{
		// Token: 0x06009B02 RID: 39682 RVA: 0x0017A169 File Offset: 0x00178369
		[NullableContext(1)]
		public static GameplayCuePush Create()
		{
			return new GameplayCuePush();
		}

		// Token: 0x17001F2A RID: 7978
		// (get) Token: 0x06009B03 RID: 39683 RVA: 0x0017A170 File Offset: 0x00178370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F2B RID: 7979
		// (get) Token: 0x06009B04 RID: 39684 RVA: 0x0017A173 File Offset: 0x00178373
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameplayCuePush.Descriptor;
			}
		}

		// Token: 0x06009B05 RID: 39685 RVA: 0x0017A17A File Offset: 0x0017837A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayCuePush()
		{
		}

		// Token: 0x06009B06 RID: 39686 RVA: 0x0017A182 File Offset: 0x00178382
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayCuePush(GameplayCuePush other) : this()
		{
			this.cueConfigId_ = other.cueConfigId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009B07 RID: 39687 RVA: 0x0017A1A7 File Offset: 0x001783A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayCuePush Clone()
		{
			return new GameplayCuePush(this);
		}

		// Token: 0x17001F2C RID: 7980
		// (get) Token: 0x06009B08 RID: 39688 RVA: 0x0017A1AF File Offset: 0x001783AF
		// (set) Token: 0x06009B09 RID: 39689 RVA: 0x0017A1B7 File Offset: 0x001783B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CueConfigId
		{
			get
			{
				return this.cueConfigId_;
			}
			set
			{
				this.cueConfigId_ = value;
			}
		}

		// Token: 0x06009B0A RID: 39690 RVA: 0x0017A1C0 File Offset: 0x001783C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameplayCuePush);
		}

		// Token: 0x06009B0B RID: 39691 RVA: 0x0017A1CE File Offset: 0x001783CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GameplayCuePush other)
		{
			return other != null && (other == this || (this.CueConfigId == other.CueConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009B0C RID: 39692 RVA: 0x0017A1FC File Offset: 0x001783FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CueConfigId != 0L)
			{
				num ^= this.CueConfigId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009B0D RID: 39693 RVA: 0x0017A23B File Offset: 0x0017843B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009B0E RID: 39694 RVA: 0x0017A248 File Offset: 0x00178448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009B0F RID: 39695 RVA: 0x0017A251 File Offset: 0x00178451
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CueConfigId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.CueConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009B10 RID: 39696 RVA: 0x0017A284 File Offset: 0x00178484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CueConfigId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CueConfigId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009B11 RID: 39697 RVA: 0x0017A2C2 File Offset: 0x001784C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GameplayCuePush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CueConfigId != 0L)
			{
				this.CueConfigId = other.CueConfigId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009B12 RID: 39698 RVA: 0x0017A2F3 File Offset: 0x001784F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009B13 RID: 39699 RVA: 0x0017A2FC File Offset: 0x001784FC
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CueConfigId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040049B9 RID: 18873
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049BA RID: 18874
		public const int CueConfigIdFieldNumber = 12;

		// Token: 0x040049BB RID: 18875
		private long cueConfigId_;
	}
}
